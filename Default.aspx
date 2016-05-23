<%@ Page Language="C#" Inherits="hangmanweb.Default" MasterPageFile="~/Main.master" %>

<asp:Content ContentPlaceHolderID="cphMain" runat="server">
	<form runat="server">
		<section class="cd-section cd-placeholder-1">
			<div class="cd-container">
				<h2>Main menu</h2>
				<p>
					<asp:HyperLink id="hlNovaIgra" runat="server" NavigateUrl="~/Igra.aspx">Nova Igra</asp:HyperLink>
				</p>
				<p>
					<asp:HyperLink id="hlRekordi" runat="server" NavigateUrl="~/Rekordi.aspx">Rekordi</asp:HyperLink>
				</p>
			</div> <!-- cd-container -->
		</section>

		<section class="cd-section cd-placeholder-2">
			<div class="cd-container">
				<h2>O igri</h2>
				<p>
					Projekat za fondaciju "Centar za mlade talente"
    			</p>
			</div>
		</section>

		<section id="cd-team" class="cd-section">
			<div class="cd-container">
				<h2>Tim</h2>
				<ul>
					<li>
						<a href="#0" data-type="member-1">
							<figure>
								<img src="img/team-member-1.png" alt="Team member 1">
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
								<img src="img/team-member-2.png" alt="Team member 1">
								<div class="cd-img-overlay"><span>O njemu</span></div>
							</figure>
								<div class="cd-member-info">
								Djordje Gluvajic <span>Programer</span>
							</div> <!-- cd-member-info -->
						</a>
					</li>
						<li>
						<a href="#0" data-type="member-3">
							<figure>
								<img src="img/team-member-3.png" alt="Team member 1">
								<div class="cd-img-overlay"><span>O njemu</span></div>
							</figure>
								<div class="cd-member-info">
								Hangman <span>Projekat</span>
							</div> <!-- cd-member-info -->
						</a>
					</li>
				</ul>
			</div> <!-- cd-container -->
		</section> <!-- cd-team -->
	</form>
</asp:Content>
