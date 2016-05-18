using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using HangmanService;

namespace hangmanweb
{
	
	public partial class Igra : System.Web.UI.Page
	{
		private Button[] btnSlovo;
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
		}

		private void PostaviKontrole ()
		{
			int i;

			string[] slova = {
				"A", "B", "C", "Č", "Ć", "D", "Dž", "Đ", "E", "F",
				"G", "H", "I", "J", "K", "L", "Lj", "M", "N", "Nj",
				"O", "P", "R", "S", "Š", "T", "U", "V", "Z", "Ž"
			};
			for (i = 0; i < btnSlovo.Length; i++)
			{
				Button btnSlovo = new Button ();
				btnSlovo.ID = i.ToString ();
				btnSlovo.Text = slova [i];
				btnSlovo.Click += SlovoClick;
				panelDugmad.Controls.Add (btnSlovo);
			}
		}
	}
}

