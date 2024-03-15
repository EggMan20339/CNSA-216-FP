using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FWA_MAIN
{
    public partial class main : MasterPage
    {

        public bool navIsVisible = true;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        // protected void btnToggleNav_OnClick(object sender, EventArgs e)
        // {
        //     
        //     if(navIsVisible)
        //     {
        //         btnToggleNav.Width = Unit.Percentage(0);
        //         navIsVisible = false;
        //     }
        //     else
        //     {
        //         btnToggleNav.Width = Unit.Percentage(8);
        //         navIsVisible = true;
        //     }
        // }
        protected void home_OnClick(object sender, EventArgs e)
        {
            
            Response.Redirect("Default.aspx");
            
            
        }

        protected void btnPatient_OnClick(object sender, EventArgs e)
        {
            
            Response.Redirect("patient.aspx");
            
        }

        protected void btnPhysician_OnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void btnMedication_OnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void btnPrescription_OnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}