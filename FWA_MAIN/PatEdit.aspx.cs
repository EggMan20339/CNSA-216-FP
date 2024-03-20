using System;
using System.Web.UI;

namespace FWA_MAIN
{
    public partial class PatEdit : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelPat_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("patient.aspx");
        }
    }
}