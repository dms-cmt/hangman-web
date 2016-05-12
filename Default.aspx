<%@ Page Language="C#" Inherits="hangmanweb.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head runat="server">
	<title>Hangman</title>
	<link href="styles/main.css" rel="stylesheet" type="txt/css" />
	<script src="scripts/main.js"></script>
</head>
<body>
	<form id="form1" runat="server">
		<h1 id="hNaslov" align="center">HANGMAN</h1>
		<hr />
		<center>
		<div id="main" class="main">
			<br />
			<asp:Button id="btnNovaIgra" runat="server" Text="Nova Igra" PostBackUrl="~/igra.aspx" CssClass="mainButton" /> <br /><br />
			<asp:Button id="btnRekordi" runat="server" Text="Rekordi" PostBackUrl="~/rekordi.aspx" CssClass="mainButton" /><br /><br />
			<asp:Button id="btnOProgramu" runat="server" Text="O Programu" PostBackUrl="~/oigri.aspx" CssClass="mainButton" /><br /><br />
		</div>
		</center>
	</form>
</body>
</html>
