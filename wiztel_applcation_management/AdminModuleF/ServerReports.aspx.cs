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

public partial class AdminModuleF_ServerReports : System.Web.UI.Page
{
    Class1 objAdmin = new Class1();
    DataSet dsMainTables = new DataSet();
    DataTable dtcustomer = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
         objAdmin.CheckingForCookie();
        if (!IsPostBack)
        {
            DataTable dtstate = new DataTable();
            
            dtstate = objAdmin.Getstate();
            ddlState.DataTextField = "state";
            ddlState.DataValueField = "state";
            ddlState.DataSource = dtstate;
            ddlState.DataBind();
            ddlState.Items.Insert(0, new ListItem("--Select--", ""));
            dtcustomer = objAdmin.Getcustomer(ddlip.SelectedValue.Trim());
            ddlcustomer.DataTextField = "customer";
            ddlcustomer.DataValueField = "username";
            ddlcustomer.DataSource = dtcustomer;
            ddlcustomer.DataBind();
            ddlcustomer.Items.Insert(0, new ListItem("--Select--", ""));
            //databind();
        }
    }
    public void databind()
    {
        //div2.Style["display"] = "";
        //div3.Style["display"] = "";
        dsMainTables = objAdmin.getRadius(Convert.ToString(ddlip.SelectedValue.Trim()), Convert.ToString(ddlcustomer.SelectedValue.Trim()), Convert.ToString(ddlcity.SelectedValue.Trim()));
        grdResult.DataSource = dsMainTables.Tables[0];
        grdResult.DataBind();
        //grdResult1.DataSource = dsMainTables.Tables[1];
        //grdResult1.DataBind();

    }
    protected void btnRestart_Click(object sender, EventArgs e)
    {
        objAdmin.getRestartServer();
        databind();
    }
    protected void btnStatus_Click(object sender, EventArgs e)
    {
        Label1.Text = "Status";
        //div2.Style["display"] = "none";
        //div3.Style["display"] = "none";
        dsMainTables = objAdmin.getShowstatus(Convert.ToString(ddlip.SelectedValue.Trim()));
        grdResult.DataSource = dsMainTables.Tables[0];
        grdResult.DataBind();

    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        databind();
    }
    protected void btncheck_Click(object sender, EventArgs e)
    {
        databind();
    }
    protected void ddlip_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        try
        {
            dtcustomer = objAdmin.Getcustomer(ddlip.SelectedValue.Trim());
            ddlcustomer.DataTextField = "customer";
            ddlcustomer.DataValueField = "username";
            ddlcustomer.DataSource = dtcustomer;
            ddlcustomer.DataBind();
            ddlcustomer.Items.Insert(0, new ListItem("--Select--", ""));
        }
        catch (Exception ex)
        {
        }
        finally
        {
            dtcustomer.Dispose();
        }
    }
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataTable dtcity = new DataTable();
        try
        {
            dtcity = objAdmin.Getstatecity(ddlState.SelectedValue.Trim());
            ddlcity.DataTextField = "citycode";
            ddlcity.DataValueField = "vdsdialcode";
            ddlcity.DataSource = dtcity;
            ddlcity.DataBind();
            ddlcity.Items.Insert(0, new ListItem("--Select--", ""));
        }
        catch (Exception ex)
        {
        }
        finally
        {
            dtcity.Dispose();
        }
    }
}
