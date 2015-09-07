
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
public partial class AdminModuleF_shorewall : System.Web.UI.Page
{
    Class1 objAdmin = new Class1();

    protected void Page_Load(object sender, EventArgs e)
    {
         objAdmin.CheckingForCookie();
        if (!IsPostBack)
        {
            ddlShorewall.Attributes.Add("onChange", "return ddlShorewallOnSelectedIndexChange(this);");
            databind();
        }
    }

    protected void btnGo_Click(object sender, EventArgs e)
    {
        databind();
    }
    public void databind()
    {
        objAdmin.strCallFor = "Shorewall";
        if (chkExp.Checked == false)
        {
            objAdmin.strExpert = true;
        }
        else
        {
            objAdmin.strExpert = false;
        }
        if (ddlShorewall.SelectedValue == "1")
        {
            objAdmin.arrList.Clear();
            foreach (ListItem chk in chkListMedia.Items)
                if (chk.Selected)
                {

                    objAdmin.arrList.Add(chk.Value + "," + chk.Text);
                }

            divIP.Style["display"] = "none";
            divMedia.Style["display"] = "";
            divSwitches.Style["display"] = "none";
            divRetail.Style["display"] = "none";
            divVPN.Style["display"] = "none";

        }
        else if (ddlShorewall.SelectedValue == "2")
        {
            objAdmin.arrList.Clear();
            foreach (ListItem chk in chKListPing.Items)
                if (chk.Selected)
                {
                    objAdmin.arrList.Add(chk.Value + "," + chk.Text);
                }

            divIP.Style["display"] = "";
            divMedia.Style["display"] = "none";
            divSwitches.Style["display"] = "none";
            divRetail.Style["display"] = "none";
            divVPN.Style["display"] = "none";
        }
        else if (ddlShorewall.SelectedValue == "3")
        {
            objAdmin.arrList.Clear();
            foreach (ListItem chk in chkSwitches.Items)
                if (chk.Selected)
                {
                    objAdmin.arrList.Add(chk.Value + "," + chk.Text);
                }
            divIP.Style["display"] = "none";
            divMedia.Style["display"] = "none";
            divSwitches.Style["display"] = "";
            divRetail.Style["display"] = "none";
            divVPN.Style["display"] = "none";
        }
        else if (ddlShorewall.SelectedValue == "4")
        {
            objAdmin.arrList.Clear();
            foreach (ListItem chk in chkRetail.Items)
                if (chk.Selected)
                {
                    objAdmin.arrList.Add(chk.Value + "," + chk.Text);
                }
            divIP.Style["display"] = "none";
            divMedia.Style["display"] = "none";
            divSwitches.Style["display"] = "none";
            divRetail.Style["display"] = "";
            divVPN.Style["display"] = "none";
        }
        else if (ddlShorewall.SelectedValue == "5")
        {
            objAdmin.arrList.Clear();
            foreach (ListItem chk in chkVPN.Items)
                if (chk.Selected)
                {
                    objAdmin.arrList.Add(chk.Value + "," + chk.Text);
                }
            divIP.Style["display"] = "none";
            divMedia.Style["display"] = "none";
            divSwitches.Style["display"] = "none";
            divRetail.Style["display"] = "none";
            divVPN.Style["display"] = "";
        }
        dlReport.DataSource = objAdmin.getReport();
        dlReport.DataBind();

    }

    protected void btnClearAll_Click(object sender, EventArgs e)
    {
        Response.Redirect("shorewall.aspx");
    }
}
