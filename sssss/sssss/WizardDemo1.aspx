<%@ Page Language="C#" Inherits="demo.WizardDemo1" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>wizardDemo1</title>
</head>
<body>
	<form id="form1" runat="server">
			<div>
				<asp:Wizard id="wz1" runat="server" >
					<WizardSteps>
						<asp:WizardStep id="step1" runat="server">
							<table>
								<tr>
									<td>
										<h2>
											hello
										</h2>
									</td>
								</tr>
							</table>
						</asp:WizardStep>

							<asp:WizardStep id="step2" runat="server">
							<table>
								<tr>
									<td>
										<h2>
											hello0000
										</h2>
									</td>
								</tr>
							</table>
						</asp:WizardStep>
					</WizardSteps>
				</asp:Wizard>


			</div>
	</form>
</body>
</html>
