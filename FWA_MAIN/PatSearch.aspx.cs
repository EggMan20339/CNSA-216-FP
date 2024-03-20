using System;
using System.Data;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FWA_MAIN
{
    public partial class PatSearch : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string eventTarget = this.Request["__EVENTTARGET"];
                if (!String.IsNullOrEmpty(eventTarget) && eventTarget == "Select$")
                {
                    string argument = Request["__EVENTARGUMENT"];
                    // Use the argument (row ID) to find out which row was clicked
                    // and perform your selection logic here
                }
            }
        }

        protected void btnNew_OnClick(object sender, EventArgs e)
        {
            
            Response.Redirect("patNew.aspx");
            
        }

        protected void btnPatSearch_OnClick(object sender, EventArgs e)
        {

            if (txtPatID.Text.Trim().Length > 0 || txtFNAME.Text.Trim().Length > 0 || txtLNAME.Text.Trim().Length > 0)
            {

                
                try
                {

                    string patID = txtPatID.Text.Trim();
                    string LNAME = txtFNAME.Text.Trim();
                    string FNAME = txtLNAME.Text.Trim();

                    Cache.Remove("StudentData");
                    DataSet ds = new DataSet();
            
                    // PharmacyDataTier dt = new PharmacyDataTier();

                    // patID = Convert.ToString(Session["vStuID"]);
                    // LNAME = Convert.ToString(Session["vLNAME"]);
                    // FNAME = Convert.ToString(Session["vFNAME"]);

                    txtPatID.Text = patID;
                    txtFNAME.Text = LNAME;
                    txtLNAME.Text = FNAME;

                    ds = PharmacyDataTier.PatientInfoSearch(patID, LNAME, FNAME);
                    
            
            
                    // ds = dt.GetStudents();
                    gvPatient.DataSource = ds.Tables[0];

                    if (Cache["StudentData"] == null)
                    {
                        Cache.Add("StudentData", new DataView(ds.Tables[0]),
                            null,System.Web.Caching.Cache.NoAbsoluteExpiration,
                            System.TimeSpan.FromMinutes(10), System.Web.Caching.CacheItemPriority.Default,
                            null);
                    }
                    gvPatient.DataBind();
                    
                    
                    
                }
                catch (Exception exception)
                {

                    

                }
                
            }

        }

        protected void gvPatient_OnSelectedIndexChanged(object sender, EventArgs e)
        { 
            foreach (GridViewRow row in gvPatient.Rows)
            {
                if (row.RowIndex == gvPatient.SelectedIndex)
                {
                    row.CssClass = "selectedRow";
                }
                else
                {
                    row.CssClass = "";
                }
            }
        }

        protected void gvPatient_OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gvPatient, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }
    }
}