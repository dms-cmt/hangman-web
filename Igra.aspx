<%@ Page Language="C#" Inherits="hangmanweb.Igra" MasterPageFile="~/Main.master" %>

<asp:Content ContentPlaceHolderID="cphHeader" runat="server">
	<div align="left">	
	<p stype="align: left;">
		<a id="izlaz" onclick="zavrsi()" href="#">Zavrsi</a>
	</p>
	</div>
</asp:Content>

<asp:Content ContentPlaceHolderID="cphMain" runat="server">
	
	<script type="text/javascript">
		function unosImena ()
		{
			var polje = document.getElementById('<%=hidIme.ClientID%>');
			var ime = prompt('Snimanje rekorda:', '');
			if(polje != null && ime != null)
			{
				polje.value = ime;
				__doPostBack('<%=hidIme.UniqueID%>', '');
			}
		}
		function zavrsi ()
		{
			var polje = document.getElementById('<%=hidZavrsi.ClientID%>');
			var rez = confirm('Da li ste sigurni da zelite da zavrsite parttiju?');
			if(polje != null)
			{
				polje.value = rez;
				__doPostBack('<%=hidZavrsi.UniqueID%>', '');
			}
		}
		function zavrseno ()
		{
			var polje = document.getElementById('izlaz');
			if(polje != null)
			{
				polje.text = "Nazad";
				polje.href = "/Default.aspx";
				polje.onclick = function(event){}
			}
		}
	</script>

	<form id="frmIgra" runat="server">
	
		<asp:TextBox id="hidIme" runat="server" value="" AutoPostBack="true" OnTextChanged="SnimiRekord" style="display: none" />
		<asp:HiddenField id="hidZavrsi" runat="server" value="false" OnValueChanged="ZavrsiPartiju" />
		
		<section class="cd-section cd-placeholder-1">
			<div class="cd-container">
				<div align="center">
				<table>
					<tr>
						<td colspan="3" align="center">
							<asp:Image id="imgZivot1" runat="server" ImageUrl="img/glava.png" Visible="false" Width="50" Height="50" />
						</td>
					</tr>
					<tr>
						<td>
							<asp:Image id="imgZivot3" runat="server" ImageUrl="img/leva_ruka.png" Visible="false" />
						</td>
						<td>
							<asp:Image id="imgZivot2" runat="server" ImageUrl="img/telo.png" Visible="false" />
						</td>
						<td>
							<asp:Image id="imgZivot4" runat="server" ImageUrl="img/desna_ruka.png" Visible="false" />
						</td>
					</tr>
					<tr>
						<td>
							<asp:Image id="imgZivot5" runat="server" ImageUrl="img/leva_noga.png" Visible="false" />
						</td>
						<td>
						</td>
						<td>
							<asp:Image id="imgZivot6" runat="server" ImageUrl="img/desna_noga.png" Visible="false" />
						</td>
					</tr>
				</table>
				</div>

				<h2><asp:Label id="lblGlavna" runat="server" Style="letter-spacing: 5px;" /></h2>
				<p>
					<asp:Panel id="panelDugmad" runat="server" />
				</p>
			</div> <!-- cd-container -->
		</section>

	</form>
</asp:Content>