<%@ Page Language="C#" Inherits="hangmanweb.Igra" MasterPageFile="~/Main.master" %>

<asp:Content ContentPlaceHolderID="cphMain" runat="server">

	<script type="text/javascript">
		function unosImena ()
		{
			var ime = prompt("Snimanje rekorda:", "");
			if(ime != null)
			{
				document.getElementById("<%=hidIme.ClientID%>").value = ime;
			}
		}
	</script>

	<form id="frmIgra" runat="server">
		<input type="hidden" id="hidIme" runat="server" value="" />

		<section class="cd-section cd-placeholder-1">
			<div class="cd-container">
				<table>
					<tr>
						<td>
						</td>
						<td>
							<asp:Image id="imgZivot1" runat="server" ImageUrl="img/glava.png" Visible="false" />
						</td>
						<td>
						</td>
					</tr>
					<tr>
						<td>
							<asp:Image id="imgZivot3" runat="server" ImageUrl="img/rukal.png" Visible="false" />
						</td>
						<td>
							<asp:Image id="imgZivot2" runat="server" ImageUrl="img/telo.png" Visible="false" />
						</td>
						<td>
							<asp:Image id="imgZivot4" runat="server" ImageUrl="img/rukad.png" Visible="false" />
						</td>
					</tr>
					<tr>
						<td>
							<asp:Image id="imgZivot5" runat="server" ImageUrl="img/nogal.png" Visible="false" />
						</td>
						<td>
						</td>
						<td>
							<asp:Image id="imgZivot6" runat="server" ImageUrl="img/nogad.png" Visible="false" />
						</td>
					</tr>
				</table>

				<h2><asp:Label id="lblGlavna" runat="server" Style="letter-spacing: 5px;" /></h2>
				<p>
					<asp:Panel id="panelDugmad" runat="server" />
				</p>
			</div> <!-- cd-container -->
		</section>

	</form>
</asp:Content>
