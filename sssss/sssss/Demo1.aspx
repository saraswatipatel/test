<%@ Page Language="C#" Inherits="demo.Demo1"  EnableEventValidation="false" Title="demo Page1"  %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Demo1</title>
</head>
<body>
	<form id="form1" runat="server">
		<asp:GridView id="grd" runat="server" ></asp:GridView>
		<!--			<asp:FileUpload id="FileUpload" runat="server"></asp:FileUpload>-->
<!--			<asp:AdRotator AdvertisementFile="~/AdsData.xml" ID="AdRotator1" runat="server" Target="_blank" />-->
			<asp:TextBox ID="TextBox1" runat="server" Width="115px"></asp:TextBox>
<asp:ImageButton ID="ImageButton1" runat="server" 
    ImageUrl="~/Images/Calendar.png" onclick="ImageButton1_Click" />
			<asp:Calendar ID="Calendar1" runat="server" ondayrender="Calendar1_DayRender" 
    onselectionchanged="Calendar1_SelectionChanged"></asp:Calendar> 
	</form>
</body>
</html>
