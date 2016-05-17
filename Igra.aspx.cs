using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hangmanweb
{
	
	public partial class Igra : System.Web.UI.Page
	{
		private Button[] btnSlovo;

		protected void Page_Load (object sender, EventArgs e)
		{
			int i;

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
			}

			panelDugmad.Controls.Add (new LiteralControl ("<br />"));
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

