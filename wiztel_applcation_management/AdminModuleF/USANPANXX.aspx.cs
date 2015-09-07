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

public partial class AdminModuleF_USANPANXX : System.Web.UI.Page
{
    Class1 objAdmin = new Class1();
    DataSet dsMainTables = new DataSet();
    DataTable dt1 = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        //objAdmin.CheckingForCookie();
        if (!IsPostBack)
        {
            
            databind();
        }
    }
     public void databind()
    {
        //div2.Style["display"] = "";
        //div3.Style["display"] = "";
        string sup, cus, unr =string.Empty;
        if (chkSup.Checked == true)
            sup = "1";
        else
            sup = "0";
        if (chkCust.Checked == true)
            cus = "1";
        else
            cus = "0";
        if (chkUnr.Checked == true)
            unr = "1";
        else
            unr = "0";

            dsMainTables = objAdmin.getUsaNPANXXManagerforAdmin(sup, cus, unr);
            if (dsMainTables.Tables[0].Rows.Count > 0)
            {
                dt1 = dsMainTables.Tables[0];
                if (Convert.ToString(dsMainTables.Tables[0].Rows[0][0]) == "1")
                {
                    div4.Style["display"] = "none";
                    divResult.Style["display"] = "none";
                }
                else
                    if (dsMainTables.Tables[0].Rows.Count > 0)
                    {
                        div4.Style["display"] = "";
                        divResult.Style["display"] = "";
                        grdResult.DataSource = dsMainTables.Tables[0];
                        grdResult.DataBind();
                    }
            }
            else
            {
                div4.Style["display"] = "none";
                divResult.Style["display"] = "none";
            }
            if (dsMainTables.Tables[1].Rows.Count > 0)
            {
                if (Convert.ToString(dsMainTables.Tables[1].Rows[0][0]) == "1")
                {
                    div3.Style["display"] = "none";
                    divResult1.Style["display"] = "none";
                }
                else
                    if (dsMainTables.Tables[1].Rows.Count > 0)
                    {
                        div3.Style["display"] = "";
                        divResult1.Style["display"] = "";
                        grdResult1.DataSource = dsMainTables.Tables[1];
                        grdResult1.DataBind();
                    }
            }
            else
            {
                div3.Style["display"] = "none";
                divResult1.Style["display"] = "none";
            }
            if (dsMainTables.Tables[2].Rows.Count > 0)
            {
                if (Convert.ToString(dsMainTables.Tables[2].Rows[0][0]) == "1")
                {
                    div7.Style["display"] = "none";
                    divResult2.Style["display"] = "none";
                }
                else
                    if (dsMainTables.Tables[2].Rows.Count > 0)
                    {
                        div7.Style["display"] = "";
                        divResult2.Style["display"] = "";
                        grdResult2.DataSource = dsMainTables.Tables[2];
                        grdResult2.DataBind();
                    }
            }
            else
            {
                div7.Style["display"] = "none";
                divResult2.Style["display"] = "none"; 
            }
    }
     protected void btnGo_Click(object sender, EventArgs e)
     {
         databind();
     }
}
