<%@ Page Language="C#" Inherits="hangmanweb.Igra" MasterPageFile="~/Main.master" %>

<asp:Content ContentPlaceHolderID="main" runat="server">
	<link href="styles/igra.css" rel="stylesheet" type="txt/css" />

	<h2><asp:Label id="lblGlavna" runat="server" /></h2>
	<br /><br />
	<asp:Panel id="panelDugmad" runat="server" />
</asp:Content>
