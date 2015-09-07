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


public partial class AdminModuleF_Admin : System.Web.UI.Page
{
    Class1 objAdmin = new Class1();

    protected void Page_Load(object sender, EventArgs e)
    {
        objAdmin.CheckingForCookie();

        if (!IsPostBack)
        {
            ddlPlugins.Attributes.Add("onChange", "return ddlPluginsOnSelectedIndexChange(this);");

            databind();


        }
    }

    protected void btnGo_Click(object sender, EventArgs e)
    {
        databind();
    }
    public void databind()
    {

        objAdmin.strCallFor = ddlActionType.SelectedValue.Trim();
        //foreach (ListItem chk in chKListPing.Items)
        //    if (chk.Selected)
        //        objAdmin.arrList.Add(chk.Value);

        //dlReport.DataSource = objAdmin.getPingReport();
        //dlReport.DataBind();

        if (ddlPlugins.SelectedValue == "1")
        {
            objAdmin.arrList.Clear();
            foreach (ListItem chk in chKListPing.Items)
                if (chk.Selected)
                {

                    objAdmin.arrList.Add(chk.Value + "," + chk.Text);
                }

            divIP.Style["display"] = "";
            divMedia.Style["display"] = "none";
            divMailsub.Style["display"] = "none";

        }
        else
            if (ddlPlugins.SelectedValue == "2")
            {
                objAdmin.arrList.Clear();
                foreach (ListItem chk in chkListMedia.Items)
                    if (chk.Selected)
                    {
                        objAdmin.arrList.Add(chk.Value + "," + chk.Text);
                    }

                divIP.Style["display"] = "none";
                divMedia.Style["display"] = "";
                divMailsub.Style["display"] = "none";

            }
            else
            {
                objAdmin.arrList.Clear();
                foreach (ListItem chk in chkMailsub.Items)
                    if (chk.Selected)
                    {
                        if (objAdmin.strCallFor == "CheckDiskSpace")
                        {
                            if (chk.Text == "Barracuda")
                            {
                                chk.Value = "72.15.142.12";
                            }
                            if (chk.Text == "Mail")
                            {
                                chk.Value = "72.15.128.2";
                            }
                            if (chk.Text == "Authsmtp")
                            {
                                chk.Value = "72.15.128.12"; 
                            }
                        }
                        objAdmin.arrList.Add(chk.Value + "," + chk.Text);
                    }
                objAdmin.strMailsub = "yes";
                divIP.Style["display"] = "none";
                divMedia.Style["display"] = "none";
                divMailsub.Style["display"] = "";

            }
        if (chkExp.Checked == false)
        {
            objAdmin.strExpert = true;
        }
        else
        {
            objAdmin.strExpert = false;
        }
        if (objAdmin.strCallFor == "CheckDiskSpace")
        {

            dlDiskCheck.DataSource = objAdmin.getReport();
            dlDiskCheck.DataBind();
            divDiskCheck.Style["display"] = "";
            divReport.Style["display"] = "none";
            //divExp.Style["display"] = "none";
        }
        else
        {
            objAdmin.strTemp = "yes";

            //divExp.Style["display"] = "";
            dlReport.DataSource = objAdmin.getReport();
            dlReport.DataBind();
            divDiskCheck.Style["display"] = "none";
            divReport.Style["display"] = "";
        }
    }

    protected void btnPing_Click(object sender, EventArgs e)
    {

        objAdmin.strExpert = false;
        objAdmin.strTemp = "yes";
        databind();



    }

    protected void dlReport_Item_Bound(Object sender, DataListItemEventArgs e)
    {

        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            System.Data.DataRowView drv = (System.Data.DataRowView)(e.Item.DataItem);

            string hld = Convert.ToString(drv.Row["Detail"]).Trim();

            if ((objAdmin.strExpert == false) && (hld.Contains("0 received") || hld.Contains("Received = 0")))
                //if  (hld.Contains("0 received") || hld.Contains("Received = 0"))
                e.Item.BackColor = System.Drawing.Color.Red;
        }

    }

    protected void dlDiskCheck_Item_Bound(Object sender, DataListItemEventArgs e)
    {

        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            System.Data.DataRowView drv = (System.Data.DataRowView)(e.Item.DataItem);

            string hld = Convert.ToString(drv.Row["Detail"]).Trim();

            //if ((objAdmin.strExpert == false) &&(!hld.Contains("/dev/")))
            //    e.Item.BackColor = System.Drawing.Color.Red;
        }

    }

    protected void btnClearAll_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin.aspx");
    }

}
