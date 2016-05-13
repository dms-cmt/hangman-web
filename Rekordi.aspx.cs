using System;
using System.Web;
using System.Web.UI;
using System.Collections.Generic;

using HangmanService;
using Hangman;

namespace hangmanweb
{
	
	public partial class Rekordi : System.Web.UI.Page
	{
		protected void Page_Load (object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				HangmanClient client = (HangmanClient)Session ["client"];
				if (client == null)
				{
					Response.Write ("<script>alert(\"Nema konekcije sa servisom!\")</script>");
					return;
				}
				List<Rekord> rekordi = client.PreuzmiRekorde ();
				repRekordi.DataSource = rekordi;
				repRekordi.DataBind ();
			}
		}
	}
}

