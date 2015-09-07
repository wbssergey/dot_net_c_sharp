
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminModule;
using System.Data;
using System.Text;
using System.Collections;

public partial class AdminModuleF_StatusOfMssqlJob : System.Web.UI.Page
{
    Class1 objAdmin = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        objAdmin.CheckingForCookie();
        databind();
    }
    public void databind()
    {
        grdResult.DataSource = objAdmin.getMssqlJobStatus();
        grdResult.DataBind();
    }
    protected void grdResult_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "AccessDeny")
        {
            LinkButton lnk = (LinkButton)e.CommandSource;
            string Access_Deny = string.Empty;
            if (lnk.Text == "Enabled")
                Access_Deny = "1";
            else if (lnk.Text == "Disabled")
                Access_Deny = "0";
            objAdmin.Getupdatemsjobactive(e.CommandArgument.ToString(), Access_Deny);
            databind();

        }
    }
    protected void grdResult_RowDataBound(Object sender, GridViewRowEventArgs e)
    {

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            HiddenField hdnstatus = (HiddenField)e.Row.FindControl("hdnstatus");
            LinkButton lnkactive = (LinkButton)e.Row.FindControl("lnkactive");
            if (hdnstatus.Value == "1")
            {
                e.Row.BackColor = System.Drawing.Color.Green;
                lnkactive.Text = "Disabled";
            }
            else
                if (hdnstatus.Value == "0")
                {
                    e.Row.BackColor = System.Drawing.Color.Red;
                    lnkactive.Text = "Enabled";
                }
                else
                {
                    e.Row.BackColor = System.Drawing.Color.Orange;
                }


        }
        //if ((objAdmin.strExpert == false) && (hld.Contains("0 received") || hld.Contains("Received = 0")))
        //if  (hld.Contains("0 received") || hld.Contains("Received = 0"))
        // e.Item.BackColor = System.Drawing.Color.Red;
        //else
        //  if ((objAdmin.strExpert == true) && (!hld.Contains("0 received") || !hld.Contains("Received = 0")))
        //        e.Item.BackColor = System.Drawing.Color.Green;
        //  else
        //     if ((objAdmin.strExpert == false) && (hld.Contains("0 received") || hld.Contains("Received = 0")))
        //         e.Item.BackColor = System.Drawing.Color.Red;
        //}

    }
}
