<%@ Page Language="C#" Inherits="hangmanweb.Igra" MasterPageFile="~/Main.master" %>

<asp:Content ContentPlaceHolderID="main" runat="server">
	<link href="styles/igra.css" rel="stylesheet" type="text/css" />

	<h1><asp:Label id="lblGlavna" runat="server" CssClass="lblGlavna" /></h1>
	<br />
	<asp:Panel id="panelDugmad" runat="server" />
</asp:Content>
