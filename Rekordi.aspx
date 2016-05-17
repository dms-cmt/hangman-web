<%@ Page Language="C#" Inherits="hangmanweb.Rekordi" MasterPageFile="~/Main.master" %>

<asp:Content ContentPlaceHolderID="main" runat="server">
	<link href="styles/rekordi.css" rel="stylesheet" type="text/css" />

	<asp:Label id="lblBrojRekorda">Broj rekorda: </asp:Label>
	<asp:DropDownList id="ddlBrojRekorda" runat="server" AutoPostBack="true">
		<asp:ListItem Text="Svi" Value="0"></asp:ListItem>
		<asp:ListItem Text="10" Value="10"></asp:ListItem>
		<asp:ListItem Text="15" Value="15"></asp:ListItem>
		<asp:ListItem Text="30" Value="30"></asp:ListItem>
		<asp:ListItem Text="100" Value="100"></asp:ListItem>
	</asp:DropDownList>
	<asp:Label id="lblSortiranje">Sortirani po: </asp:Label>
	<asp:DropDownList id="ddlSortiranje" runat="server" AutoPostBack="true">
		<asp:ListItem Text="Ukupno" Value="0"></asp:ListItem>
		<asp:ListItem Text="Po vremenu" Value="1"></asp:ListItem>
		<asp:ListItem Text="Po broju pogresnih slova" Value="2"></asp:ListItem>
	</asp:DropDownList>
	<table id="tblRekordi" class="tblRekordi">
		<tr id="trHeader" class="trHeader">
			<td><b>Ime:</b></td>
			<td><b>Vreme:</b></td>
			<td><b>Broj pogresnih slova:</b></td>
		</tr>
		<asp:Repeater id="repRekordi" runat="server">
			<ItemTemplate>
				<tr id="trContent" class="tcContent">
					<td><asp:Label id="lblIme" runat="server"><%# Eval("ImeKorisnika") %></asp:Label></td>
					<td><asp:Label id="lblVreme" runat="server"><%# Eval("BrojSekundi") %></asp:Label></td>
					<td><asp:Label id="lblBrojSlova" runat="server"><%# Eval("BrojPogresnihSlova") %></asp:Label></td>
				</tr>
			</ItemTemplate>
		</asp:Repeater>
	</table>
</asp:Content>
	