using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using HangmanService;

namespace hangmanweb
{
	
	public partial class Igra : System.Web.UI.Page
	{
		private int ukupanBrojSlova;

		protected void Page_Load (object sender, EventArgs e)
		{
			int i, j;
			int[] args;
			HangmanClient client = (HangmanClient)Session ["client"];

			PostaviKontrole ();

			if (!IsPostBack)
			{
				try
				{
					args = client.PokreniIgru ();
					ukupanBrojSlova = args [0];
					lblGlavna.Text = "";

					// Resavanje praznih mesta
					for (i = 0, j = 1; i < ukupanBrojSlova; i++)
					{
						if (j < args.Length && args[j] == i)
						{
							j++;
							lblGlavna.Text += " ";
							continue;
						}
						lblGlavna.Text += "_";
					}
				} catch(Exception ex)
				{
				}
			}
		}

		protected void SlovoClick (object sender, EventArgs e)
		{
			string zaProveru = ((Button)sender).Text;
			char[] chGlavna = lblGlavna.Text.ToCharArray ();
			List<int> indeksi;
			HangmanClient client = (HangmanClient)Session ["client"];

			try
			{
				indeksi = client.Provera (zaProveru.ToCharArray ());
			} catch (Exception ex)
			{
				return;
			}

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
		}

		private void PostaviKontrole ()
		{
			int i;

			string[] slova = {
				"A", "B", "C", "Č", "Ć", "D", "Dž", "Đ", "E", "F",
				"G", "H", "I", "J", "K", "L", "Lj", "M", "N", "Nj",
				"O", "P", "R", "S", "Š", "T", "U", "V", "Z", "Ž"
			};
			for (i = 0; i < slova.Length; i++)
			{
				Button btnSlovo = new Button ();
				btnSlovo.ID = i.ToString ();
				btnSlovo.Text = slova [i];
				btnSlovo.Click += SlovoClick;
				panelDugmad.Controls.Add (btnSlovo);
				if ((i + 1) % 10 == 0)
					panelDugmad.Controls.Add (new LiteralControl ("<br />"));
			}
		}
	}
}

