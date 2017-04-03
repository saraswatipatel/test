using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;
namespace demo
{

	public partial class wizardDemo : System.Web.UI.Page
	{
		protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
		{
			if (e.NextStepIndex == 2)
			{
				lblFirstName.Text = txtFirstName.Text;
				lblLastName.Text = txtLastName.Text;
				lblGender.Text = ddlGender.SelectedValue; 
				lblEmail.Text = txtEmail.Text;
				lblMobile.Text = txtMobile.Text;
			}
		}

		protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
		{
			Response.Redirect("~/Demo1.aspx");
		}
	}

	public class TestIEnumerable
	{
		public class Point
		{
			public int X { get; set; }
			public int Y { get; set; }
		}

		private IEnumerable<Point> GetPoints()
		{
			for (int index = 1; index < 20; index++)
				yield return new Point() { X = index, Y = index * 2 };
		}

		private void DoubleXValue(IEnumerable<Point> points)
		{
			foreach (var point in points)
				point.X *= 2;	
		}

		//[TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
		//public void Asdf()
		//{
		//	var points = GetPoints();
		//	DoubleXValue(points);

		//	Assert.AreEqual<int>(2, points.ElementAt(0).X);
		//}
	}
}
