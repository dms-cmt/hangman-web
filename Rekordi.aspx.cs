using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using HangmanService;
using Hangman;

namespace hangmanweb
{
	
	public partial class Rekordi : System.Web.UI.Page
	{
		protected void Page_Load (object sender, EventArgs e)
		{
			int? brojRekorda;
			ETipSortiranja tipSortiranja;

			/*
			if (!IsPostBack)
			{
				string[] tekst = {
					"Ukupno",
					"Po vremenu",
					"Po broju pogresnih slova"
				};
				int[] vrednosti = {
					(int)ETipSortiranja.NajboljiUkupno,
					(int)ETipSortiranja.NajboljiPoVremenu,
					(int)ETipSortiranja.NajboljiPoBrojuSlova
				};

				for (int i = 0; i < tekst.Length; i++)
					ddlSortiranje.Items.Add (new ListItem (tekst[i], vrednosti[i].ToString ()));
			}
			*/

			HangmanClient client = (HangmanClient)Session ["client"];
			if (client == null)
			{
				Response.Write ("<script>alert(\"Nema konekcije sa servisom!\")</script>");
				return;
			}

			brojRekorda = int.Parse (ddlBrojRekorda.SelectedValue);
			if (brojRekorda < 1)
				brojRekorda = null;

			tipSortiranja = (ETipSortiranja)Enum.Parse (typeof(ETipSortiranja), ddlSortiranje.SelectedValue);

			List<Rekord> rekordi = client.PreuzmiRekorde (brojRekorda, tipSortiranja);
			repRekordi.DataSource = rekordi;
			repRekordi.DataBind ();
		}
	}
}

