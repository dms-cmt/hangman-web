<%@ Page Language="C#" Inherits="hangmanweb.Rekordi" MasterPageFile="~/Main.master" %>

<asp:Content ContentPlaceHolderID="main" runat="server">
	<link href="styles/rekordi.css" rel="stylesheet" type="txt/css" />
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
	