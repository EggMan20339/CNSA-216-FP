using System;
using System.Web.UI;

namespace FWA_MAIN
{
    public partial class patient : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNew_OnClick(object sender, EventArgs e)
        {
            
            Response.Redirect("patNew.aspx");
            
        }
    }
}