using System;
using System.Web;
using System.Web.UI;

namespace demo
{

	public partial class multiview1 : System.Web.UI.Page
	{
		

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				btn1.Click+=btn1_Click;
				//Response.Output
				//mtv_View.ActiveViewIndex = 0;
			}
		}

		protected void btn1_Click(object sender, EventArgs e)
		{
			mtv_View.ActiveViewIndex += 1;
		}

		//protected void btnGoToStep3_Click(object sender, EventArgs e)
		//{ }
	}
}
