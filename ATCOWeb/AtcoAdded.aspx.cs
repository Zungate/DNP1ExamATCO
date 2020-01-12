using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AtcoDataLibrary;

namespace ATCOWeb
{
    public partial class AtcoAdded : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ATCO atco = (ATCO)Session["AddedATCO"];
            lblATCOAdded.Text = $"ATCO Created: {atco.Name}, Id={atco.Id}, Cert Id={atco.CertificateId}";
        }
    }
}