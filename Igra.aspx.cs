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

			if (!IsPostBack)
			{
				string[] slova = {
					"A", "B", "C", "Č", "Ć", "D", "Dž", "Đ", "E", "F",
					"G", "H", "I", "J", "K", "L", "Lj", "M", "N", "Nj",
					"O", "P", "R", "S", "Š", "T", "U", "V", "Z", "Ž"
				};
				btnSlovo = new Button [slova.Length];
				for (i = 0; i < btnSlovo.Length; i++)
				{
					btnSlovo [i] = new Button ();
					btnSlovo [i].ID = i.ToString ();
					btnSlovo [i].Text = slova [i];
					//btnSlovo [i].OnClientClick += new EventHandler (SlovoClick);
				}

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

			for (i = 0 ; i < btnSlovo.Length; i++)
			{
				panelDugmad.Controls.Add (btnSlovo [i]);
				if ((i + 1) % 10 == 0)
					panelDugmad.Controls.Add (new LiteralControl ("<br />"));
			}
		}

		protected void SlovoClick (object sender, EventArgs e)
		{
		}
	}
}

