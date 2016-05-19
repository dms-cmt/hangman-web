<%@ Page Language="C#" Inherits="hangmanweb.Default" MasterPageFile="~/Main.master" %>

<asp:Content ContentPlaceHolderID="cphMain" runat="server">
	<form runat="server">
		<section class="cd-section cd-placeholder-1">
			<div class="cd-container">
				<h2>Main menu</h2>
				<p>
					<asp:Button id="btnNovaIgra" runat="server" Text="Nova Igra" PostBackUrl="~/Igra.aspx" />
				</p>
				<p>
					<asp:Button id="btnRekordi" runat="server" Text="Rekordi" PostBackUrl="~/Rekordi.aspx" />
				</p>
				<p>
					<asp:Button id="btnOIgri" runat="server" Text="O Igri" PostBackUrl="~/OIgri.aspx" />
				</p>
			</div> <!-- cd-container -->
		</section>

		<section id="cd-team" class="cd-section">
			<div class="cd-container">
				<h2>Tim</h2>
				<ul>
					<li>
						<a href="#0" data-type="member-1">
							<figure>
								<img src="img/team-member-1.jpg" alt="Team member 1">
								<div class="cd-img-overlay"><span>O njemu</span></div>
							</figure>
								<div class="cd-member-info">
								Milos Zivlak <span>Programer</span>
							</div> <!-- cd-member-info -->
						</a>
					</li>	

					<li>
						<a href="#0" data-type="member-2">
							<figure>
								<img src="img/team-member-1.jpg" alt="Team member 1">
								<div class="cd-img-overlay"><span>O njemu</span></div>
							</figure>
								<div class="cd-member-info">
								Djordje Gluvajic <span>Instruktor</span>
							</div> <!-- cd-member-info -->
						</a>
					</li>
						<li>
						<a href="#0" data-type="member-3">
							<figure>
								<img src="img/team-member-1.jpg" alt="Team member 1">
								<div class="cd-img-overlay"><span>O njemu</span></div>
							</figure>
								<div class="cd-member-info">
								Bvze <span>Web Design</span>
							</div> <!-- cd-member-info -->
						</a>
					</li>
				</ul>
			</div> <!-- cd-container -->
		</section> <!-- cd-team -->
	</form>
</asp:Content>
