using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hangmanweb
{
	
	public partial class Igra : System.Web.UI.Page
	{
		protected void Page_Load (object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				panelDugmad.Controls.Add (new LiteralControl ("<br />"));
				for (char i = 'A'; i <= 'Z'; i++)
				{
					Button test = new Button ();
					test.Text = i.ToString ();
					panelDugmad.Controls.Add (test);
					if ((i - 'A') % 5 == 0)
						panelDugmad.Controls.Add (new LiteralControl ("<br />"));
				}
			}
		}
	}
}

