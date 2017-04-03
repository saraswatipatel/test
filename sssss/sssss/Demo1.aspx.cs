using System;
using System.Web;
using System.Web.UI;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Web.UI.WebControls;
using System.Drawing;
namespace demo
{

	public partial class Demo1 : System.Web.UI.Page
	{
		static test jj;
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				//Response.Write("Page load");
				StringBuilder sb = new StringBuilder();
				sb.Append(Server.MapPath("~"));
				sb.Append("CountryJson.txt");
				StreamReader read = new StreamReader(sb.ToString());
				string str = read.ReadToEnd();
				jj = JsonConvert.DeserializeObject<test>(str);
				grd.DataSource = jj.City;

				//grd.Columns.Add(ne
				//String strname = grd.SelectedRow.Cells[1].i;
				//Response.Write(strname);
				grd.DataBind();


					Calendar1.Visible = false;

			}
		}
		protected void Calendar1_SelectionChanged(object sender, EventArgs e)
		{ 
			 TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
			Calendar1.Visible = false;
		}
		protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
		{ 
			 if (e.Day.IsWeekend || e.Day.IsOtherMonth)
			{
				e.Day.IsSelectable = false;
				e.Cell.BackColor = System.Drawing.Color.LightGray;
			}
		}
		protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
		{
			if (Calendar1.Visible)
			{
				Calendar1.Visible = false;
			}
			else
			{
				Calendar1.Visible = true;
			}
		}

	}
}
