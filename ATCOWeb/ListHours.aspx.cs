using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AtcoDataLibrary;

namespace ATCOWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Date.Text = "2019-04-30";
            var ATC = new ATCCenter();
            if (Session["Employees"] != null)
            {
                var employees = (List<Employee>)Session["Employees"];
                DataTable dt = new DataTable();

                dt.Columns.Add("Id");
                dt.Columns.Add("Name");
                dt.Columns.Add("Cert id");
                dt.Columns.Add("Date");
                dt.Columns.Add("Hours");
                foreach (ATCO item in employees)
                {
                    var row = dt.NewRow();

                    row["Id"] = item.Id;
                    row["Name"] = item.Name;
                    DateTime datetime = DateTime.Parse(Session["Date"].ToString());
                    row["Cert id"] = item.CertificateId;
                    row["Date"] = datetime;
                    row["Hours"] = item.HoursWorked[datetime];

                    dt.Rows.Add(row);
                }
                gridView.DataSource = dt;
                gridView.DataBind();
            }
            
        }

        protected void Check_Click(object sender, EventArgs e)
        {
            var ATC = new ATCCenter();

            Session["Employees"] = ATC.GetEmployees();
            Session["Date"] = Date.Text;

            Response.Redirect("ListHours.aspx");
        }
    }
}