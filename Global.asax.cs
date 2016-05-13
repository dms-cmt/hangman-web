using System;
using System.Collections;
using System.ComponentModel;
using System.Web;
using System.Web.SessionState;
using System.ServiceModel;

using HangmanService;

namespace hangmanweb
{
	public class Global : System.Web.HttpApplication
	{
		protected virtual void Application_Start (Object sender, EventArgs e)
		{
		}
		
		protected virtual void Session_Start (Object sender, EventArgs e)
		{
			Connect ();
		}
		
		protected virtual void Application_BeginRequest (Object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_EndRequest (Object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_AuthenticateRequest (Object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_Error (Object sender, EventArgs e)
		{
		}
		
		protected virtual void Session_End (Object sender, EventArgs e)
		{
		}
		
		protected virtual void Application_End (Object sender, EventArgs e)
		{
		}

		/*
		 * Otvaranje konekcije na servis
		 */
		private void Connect ()
		{
			var security = new SecurityMode ();
			var binding = new WSHttpBinding (security, true);
			var address = new EndpointAddress ("http://localhost:8325/");
			Session ["client"] = new HangmanClient (binding, address);
		}
	}
}

