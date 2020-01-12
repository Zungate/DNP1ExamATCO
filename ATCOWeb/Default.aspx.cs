using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AtcoDataLibrary;

namespace ATCOWeb
{
    public partial class _Default : Page
    {
        protected void Add_Click(object sender, EventArgs e)
        {
            Session["AddedATCO"] = new ATCO(int.Parse(CertId.Text), int.Parse(Id.Text), Name.Text);

            Response.Redirect("AtcoAdded.aspx");
        }
    }
}