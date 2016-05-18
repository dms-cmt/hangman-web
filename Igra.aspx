<%@ Page Language="C#" Inherits="hangmanweb.Igra" MasterPageFile="~/Main.master" %>

<asp:Content ContentPlaceHolderID="main" runat="server">
	<link href="styles/igra.css" rel="stylesheet" type="text/css" />

	<h2 style="letter-spacing:5px;"><asp:Label id="lblGlavna" runat="server" /></h2>
	<br /><br />
	<asp:Panel id="panelDugmad" runat="server" />
</asp:Content>
