using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
namespace demo
{
	public partial class demo : System.Web.UI.Page
	{
	static 	test jj;
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
				PopulateContinentsDropDownList();
			}
			else {
				Response.Write("allready loaded");
			}

		}
		int i;
		protected void btn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(System.Convert.ToString(ViewState["click"])))
			{
				i++;
				ViewState["click"] = i;
			}
			else {
				i = (int)ViewState["click"] + 1;
				ViewState["click"] = i;
			}
			Response.Write("<br/>click count--" + i);
		}

		protected void btn_Command(object sender, CommandEventArgs e)
		{
			Response.Write("<br/>" + e.CommandName);
			Response.Write("<br/>" + e.CommandArgument);
		}
		private void PopulateContinentsDropDownList()
		{
			ddlContinents.DataSource =jj.Continents;
			ddlContinents.DataTextField = "Name";
			ddlContinents.DataValueField = "ID";
			ddlContinents.DataBind();

			ddlCountries.Items.Clear();
			ddlCities.Items.Clear();

			ListItem liContinent = new ListItem("Select Continent", "-1");
			ddlContinents.Items.Insert(0, liContinent);
			//ddlContinents.Items[0].Attributes["disabled"] = "disabled";

			ListItem liCountry = new ListItem("Select Country", "-1");
			ddlCountries.Items.Insert(0, liCountry);

			ListItem liCity = new ListItem("Select City", "-1");
			ddlCities.Items.Insert(0, liCity);


			ddlCountries.Enabled = false;
			ddlCities.Enabled = false;
		}

		protected void ddlContinents_SelectedIndexChanged(object sender, EventArgs e)
		{
			Response.Write("<br/>"+ddlContinents.SelectedValue);
			if (ddlContinents.SelectedValue == "-1")
			{
				ddlCities.SelectedIndex = 0;
				ddlCountries.SelectedIndex = 0;
				ddlCities.Enabled = false;
				ddlCountries.Enabled = false;
			}
			else
			{
				ddlCountries.Enabled = true;
				ddlCities.Items.Clear();
				ddlCountries.DataSource = jj.Countries.FindAll(x => x.ContinentID == ddlContinents.SelectedValue);
				ddlCountries.DataTextField = "Name";
				ddlCountries.DataValueField = "ID";
				ddlCountries.DataBind();

				ListItem liCountry = new ListItem("Select Country", "-1");
				ddlCountries.Items.Insert(0, liCountry);

				ListItem liCity = new ListItem("Select City", "-1");
				ddlCities.Items.Insert(0, liCity);
			
				ddlCities.SelectedIndex = 0;
				ddlCities.Enabled = false;
			}

		}

		protected void ddlCountries_SelectedIndexChanged(object sender, EventArgs e)
		{
			Response.Write("<br/>" +ddlCountries.SelectedValue);
			if (ddlCountries.SelectedValue == "-1")
			{
				ddlCities.SelectedIndex = 0;
				ddlCities.Enabled = false;
			}
			else
			{
				ddlCities.Enabled = true;

				ddlCities.DataSource = jj.City.FindAll(x => x.CountryID == ddlCountries.SelectedValue);
				ddlCities.DataTextField = "Name";
				ddlCities.DataValueField = "ID";
				ddlCities.DataBind();

				ListItem liCity = new ListItem("Select City", "-1");
				ddlCities.Items.Insert(0, liCity);
			}
}	
	}
}
public class Employee
{
	public int ID { get; set; }
	public string Name { get; set; }
	public string Address { get; set; }
}

public class Continents
{
	public int ID { get; set; }
	public string Name { get; set; }

}

public class Countries
{
	public int ID { get; set; }
	public string Name { get; set; }
	public string ContinentID { get; set; }
}
public class City
{
	public int ID { get; set; }
	public string Name { get; set; }
	public string CountryID { get; set; }
}

public class test
{
	public List<Continents> Continents { get; set; }
	public List<Countries> Countries { get; set; }
	public List<City> City { get; set; }

}