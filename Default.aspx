<%@ Page Language="C#" Inherits="hangmanweb.Default" MasterPageFile="~/Main.master" %>

<asp:Content ContentPlaceHolderID="main" runat="server">
	<asp:Button id="btnNovaIgra" runat="server" Text="Nova Igra" PostBackUrl="~/Igra.aspx" /> <br /><br />
	<asp:Button id="btnRekordi" runat="server" Text="Rekordi" PostBackUrl="~/Rekordi.aspx" /><br /><br />
	<asp:Button id="btnOProgramu" runat="server" Text="O Programu" PostBackUrl="~/OIgri.aspx" /><br /><br />
</asp:Content>
