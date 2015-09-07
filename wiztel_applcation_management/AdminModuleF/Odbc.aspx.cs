
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

public partial class AdminModuleF_Odbc : System.Web.UI.Page
{
    Class1 objAdmin = new Class1();
    Int32 total = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        objAdmin.CheckingForCookie();
        databind();
    }
    public void databind()
    {
        grdResult.DataSource = objAdmin.getLinkserver();
        grdResult.DataBind();
    }
    protected void grdResult_RowDataBound(Object sender, GridViewRowEventArgs e)
    {
        //e.Row.BackColor = System.Drawing.Color.Green;
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            HiddenField hdnstatus = (HiddenField)e.Row.FindControl("hdnstatus");
            if (hdnstatus.Value.Contains("access"))
            {
                e.Row.BackColor = System.Drawing.Color.Green;
            }
            else
                {
                    e.Row.BackColor = System.Drawing.Color.Red;
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
