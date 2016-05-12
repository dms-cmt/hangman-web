<%@ Page Language="C#" Inherits="hangmanweb.Default" MasterPageFile="~/Main.master" %>

<asp:Content ContentPlaceHolderID="main" runat="server">
	<asp:Button id="btnNovaIgra" runat="server" Text="Nova Igra" PostBackUrl="~/Igra.aspx" /> <br /><br />
	<asp:Button id="btnRekordi" runat="server" Text="Rekordi" PostBackUrl="~/Rekordi.aspx" /><br /><br />
	<asp:Button id="btnOIgri" runat="server" Text="O Igri" PostBackUrl="~/OIgri.aspx" />
</asp:Content>
