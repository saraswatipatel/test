<%@ Page Language="C#" Inherits="demo.demo"  EnableEventValidation="false" Title="demo Page" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>demo</title>
</head>
<body>
	<form id="form1" runat="server">
<!--			<asp:Label id="LBL" runat="server" text="demo"></asp:Label>-->
			<!--<asp:RadioButton id="rdb1" runat="server" Text="male" GroupName="gender"></asp:RadioButton>
			<asp:RadioButton id="rdb2" runat="server" Text="female" GroupName="gender"></asp:RadioButton>
			<asp:Button id="btn" Text="click me" runat="server" OnCommand="btn_Command" CommandName="click" CommandArgument="show"></asp:Button>
-->
			<asp:DropDownList ID="ddlContinents" Width="200px" DataTextField="ContinentName"  DataValueField="ContinentId" runat="server" AutoPostBack="True" 
					onselectedindexchanged="ddlContinents_SelectedIndexChanged">
			</asp:DropDownList>
			<br /><br />
			<asp:DropDownList ID="ddlCountries" DataValueField="CountryId"  DataTextField="CountryName" Width="200px" runat="server" AutoPostBack="True" 
					onselectedindexchanged="ddlCountries_SelectedIndexChanged">
			</asp:DropDownList>
			<br /><br />
			<asp:DropDownList ID="ddlCities" Width="200px" DataTextField="CityName" DataValueField="CityId" runat="server">
			</asp:DropDownList> 
	</form>
</body>
</html>
