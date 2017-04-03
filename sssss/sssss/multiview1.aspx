<%@ Page Language="C#" Inherits="demo.multiview1" EnableEventValidation="false" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>multiview1</title>
</head>
<body>
	<form id="form1" runat="server">
			<div style="font-family: Arial">
				<asp:MultiView id="mtv_View" runat="server" ActiveViewIndex="0">
				<asp:View id="view1" runat="server">
						<table style="border:1px solid black">
					<tr>
					<td> <h2> heading</h2> </td>
							
					</tr>
							<tr>
							<td> Name: </td>
								<td> <asp:TextBox id="name1" runat="server">
								</asp:TextBox> </td>
							</tr>
							<tr>
								<td>
								<asp:Button id="btn1" runat="server" OnClick="btn1_Click" Text="ClickMe"></asp:Button></td>
							</tr>
				</table>
				</asp:View>

					<asp:View id="view2" runat="server">
						<table style="border:1px solid black">
				<tr>
					<td>
						<h2> heading</h2>
					</td>
				</tr>
						
				</table>
					</asp:View>
					
				</asp:MultiView>

			</div>
	</form>
</body>
</html>
