<%@ Page Language="C#" Inherits="hangmanweb.Igra" MasterPageFile="~/Main.master" %>

<asp:Content ContentPlaceHolderID="cphMain" runat="server">
	<form runat="server">

		<section class="cd-section cd-placeholder-1">
			<div class="cd-container">
				<h2><asp:Label id="lblGlavna" runat="server" Style="letter-spacing: 5px;" /></h2>
				<p>
					<asp:Panel id="panelDugmad" runat="server" />
				</p>
			</div> <!-- cd-container -->
		</section>

	</form>
</asp:Content>
