using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.ServiceModel;

using HangmanService;
using Hangman;

namespace hangmanweb
{
	
	public partial class Igra : System.Web.UI.Page
	{
		private int ukupanBrojSlova;
		private List<string> iskoriscenaSlova;
		
		protected void Page_Init (object sender, EventArgs e)
		{
			iskoriscenaSlova = new List<string> ();
		}

		protected void Page_Load (object sender, EventArgs e)
		{
			int[] args;
			HangmanClient client = (HangmanClient)Session ["client"];

			if (!IsPostBack)
			{
				try
				{
					args = client.PokreniIgru ();
					ukupanBrojSlova = args [0];
					lblGlavna.Text = "";

					// Resavanje praznih mesta
					for (int i = 0, j = 1; i < ukupanBrojSlova; i++)
					{
						if (j < args.Length && args [j] == i)
						{
							j++;
							lblGlavna.Text += " ";
							continue;
						}
						lblGlavna.Text += "_";
					}
				} catch (FaultException<ServiceFault> ex)
				{
					ShowMessage (ex.Detail.ErrorMessage);
				} catch (Exception ex)
				{
					ShowMessage ("Nije moguca komunikacija sa servisom!");
				}
			}
			
			PostaviKontrole ();
		}

		protected void SlovoClick (object sender, EventArgs e)
		{
			string zaProveru = ((Button)sender).Text;
			char[] chGlavna = lblGlavna.Text.ToCharArray ();
			List<int> indeksi;
			HangmanClient client = (HangmanClient)Session ["client"];
			EStatusIgre status;

			try
			{
				indeksi = client.Provera (zaProveru.ToCharArray ());
			} catch (FaultException<ServiceFault> ex)
			{
				ShowMessage (ex.Detail.ErrorMessage);
				return;
			} catch (Exception ex)
			{
				ShowMessage ("Nije omguca komunikacija sa servisom!");
				return;
			}
			
			iskoriscenaSlova.Add (zaProveru);

			// Prikaz trenutnog stanja teksta koji se pogadja
			lblGlavna.Text = "";
			for (int i = 0, j = 0, k = 0; i < chGlavna.Length; i++)
			{
				if (Char.IsLower (chGlavna [i]))
				{
					lblGlavna.Text += chGlavna [i];
					k++;
				} else if (j < indeksi.Count && (i - k) == indeksi [j])
				{
					lblGlavna.Text += zaProveru;
					j++;
				} else
				{
					lblGlavna.Text += chGlavna [i];
				}
			}

			try
			{
				status = client.Status ();
				if (status == EStatusIgre.IGRA_ZAVRSENA_POBEDA)
				{
					ClientScript.RegisterStartupScript (GetType (), "prompt", "unosImena()", true);
				} else if(status == EStatusIgre.IGRA_ZAVRSENA_PORAZ)
				{
					lblGlavna.Text = "";
					char[] resenje = client.Resenje ();
					foreach (char c in resenje)
					{
						lblGlavna.Text += c;
					}
					ClientScript.RegisterStartupScript (GetType (), "zavrseno", "zavrseno()", true);
				}
			} catch (FaultException<ServiceFault> ex)
			{
				ShowMessage (ex.Detail.ErrorMessage);
			} catch(Exception ex)
			{
				ShowMessage ("Nije moguca komunikacija sa servisom!");
			}
			
			PrikaziZivot ();
		}
		
		protected void SnimiRekord (object sender, EventArgs e)
		{
			HangmanClient client = (HangmanClient)Session ["client"];
			string ime = ((TextBox)sender).Text;
			
			try
			{
				client.SnimiRekord (ime);
				ClientScript.RegisterStartupScript (GetType (), "zavrseno", "zavrseno()", true);
			} catch (FaultException<ServiceFault> ex)
			{
				ShowMessage (ex.Detail.ErrorMessage);
			} catch (Exception ex)
			{
				ShowMessage ("Nije moguca komunikacija sa servisom!");
			}
		}
		
		protected void ZavrsiPartiju (object sender, EventArgs e)
		{
			HangmanClient client = (HangmanClient)Session ["client"];
			string strHidZavrsi = hidZavrsi.Value;
			
			if (strHidZavrsi == "true")
			{
				try
				{
					lblGlavna.Text =  new string (client.Resenje ());
					ClientScript.RegisterStartupScript (GetType (), "zavrseno", "zavrseno()", true);
				} catch (FaultException<ServiceFault> ex)
				{
					ShowMessage (ex.Detail.ErrorMessage);
				} catch (Exception ex)
				{
					ShowMessage ("Nije moguca komunikacija sa servisom!");
				}
			}
		}

		private void PostaviKontrole ()
		{
			string[] slova = {
				"A", "B", "C", "Č", "Ć", "D", "Dž", "Đ", "E", "F",
				"G", "H", "I", "J", "K", "L", "Lj", "M", "N", "Nj",
				"O", "P", "R", "S", "Š", "T", "U", "V", "Z", "Ž"
			};
			for (int i = 0, j = 0; i < slova.Length; i++)
			{
				Button btnSlovo = new Button ();
				btnSlovo.ID = i.ToString ();
				btnSlovo.Text = slova [i];
				if (j < iskoriscenaSlova.Count && slova [i] == iskoriscenaSlova [j])
				{
					btnSlovo.Enabled = false;
					j++;
				}
				btnSlovo.Click += SlovoClick;
				panelDugmad.Controls.Add (btnSlovo);
				if ((i + 1) % 10 == 0)
					panelDugmad.Controls.Add (new LiteralControl ("<br />"));
			}
		}

		private void PrikaziZivot ()
		{
			HangmanClient client = (HangmanClient)Session ["client"];
			Image img;
			int brojPokusaja;

			try
			{
				brojPokusaja = client.BrojPokusaja ();
			} catch (FaultException<ServiceFault> ex)
			{
				ShowMessage (ex.Detail.ErrorMessage);
				return;
			} catch(Exception ex)
			{
				ShowMessage ("Nije moguca komunikacija sa servisom!");
				return;
			}

			for (int i = 0; i < brojPokusaja; i++)
			{
				img = (Image)frmIgra.FindControl ("imgZivot" + brojPokusaja.ToString ());
				img.Visible = true;
			}
		}
		
		private void ShowMessage (string message)
		{
			ClientScript.RegisterStartupScript (GetType (), "alert",
			                                    "alert(\"" + message + "\")", true);
		}
	}
}

