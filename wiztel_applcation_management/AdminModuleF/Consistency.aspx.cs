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

public partial class AdminModuleF_Consistency : System.Web.UI.Page
{
    Class1 objAdmin = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
         objAdmin.CheckingForCookie();
        databind();
    }
    public void databind()
    {
        grdResult.DataSource = objAdmin.getCRDCon("10");
        grdResult.DataBind();
    }
    protected void grdResult_RowDataBound(Object sender, GridViewRowEventArgs e)
    {

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label lblmindt_a = (Label)e.Row.FindControl("lblmindt_a");
            Label lblmaxdt_a = (Label)e.Row.FindControl("lblmaxdt_a");
            Label lblmindt = (Label)e.Row.FindControl("lblmindt");
            Label lblmaxdt = (Label)e.Row.FindControl("lblmaxdt");
            Label lbldiff = (Label)e.Row.FindControl("lbldiff");
            if ((lblmindt_a.Text == lblmindt.Text) && Convert.ToInt32(lbldiff.Text) < 30)
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
    protected void btngo_Click(object sender, EventArgs e)
    {
        if (chkuae.Checked == true)
        {
            grdResult.DataSource = objAdmin.getCRDCon("101");
            grdResult.DataBind();
        }
        else
            databind();
    }
}
