using System.Data;
using System.Data.SqlClient;
using System.Text;
using DataAccessLayer;
using System;
using System.Web;
using System.Web.UI.WebControls;
using System.Collections;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.Net;
using CommonModule;


namespace AdminModule
{
    public class Class1 : CommonBLL
    {
        public Class1()
        {
            objDALCIILibrary = new DALLibrary();
        }

        public Class1(object obj)
        {
            objDALCIILibrary = new DALLibrary(obj);
        }

        DALLibrary objDALCIILibrary;//= new DALLibrary();
        SqlCommand dbSqlCommand;
        DataTable dbSqlDataTable = new DataTable();
        public string SelectedContacts { get; set; }
        public string Subject
        { get; set; }
        public string Message
        { get; set; }
        public string SortName
        { get; set; }
        public string EmailId
        { get; set; }
        public string FullName
        { get; set; }
        public string strID
        { get; set; }
        public string strInvoiceID
        { get; set; }
        public string OrgName
        { get; set; }
        public string UnSelectedContacts
        { get; set; }
        //public string[] arrIPs = new string[20];
        public ArrayList arrList = new ArrayList();
        public string strIP = string.Empty;
        public string strCallFor = string.Empty;
        public string strTemp = string.Empty;
        public string strCheckjob = string.Empty;
        public Boolean strExpert = true;
        public string strChkText = string.Empty;
        public string strMailsub = string.Empty;
        public string Where = string.Empty;
        public string username = string.Empty;
        public string view = string.Empty;
        public string view1 = string.Empty;
        public string massageid = string.Empty;
        public string Name, X1Custid, vdsName, vdsType, vbsid, Cost, vrcId, vrtId = string.Empty;
        public DataTable getReportTable()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "proc_ManagerAdminPage";
            dbSqlCommand.Parameters.AddWithValue("@IP", strIP);
            dbSqlCommand.Parameters.AddWithValue("@strCallFor", strCallFor);
            if ((strCallFor.Contains("Shorewall")) || ((strCallFor.Contains("Cdrtables"))))
            {
                dbSqlCommand.Parameters.AddWithValue("@ExpChk", strExpert);
            }
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable getUSANPANXXtransfer()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "USANPANXXtransfer_Manager2";
            dbSqlCommand.Parameters.AddWithValue("@IP", strIP);
            dbSqlCommand.Parameters.AddWithValue("@transaction_name", "dtexec");
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable getCRDCon(string tran)
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "IntegrityManager";
            dbSqlCommand.Parameters.AddWithValue("@transaction", tran.Trim());
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable getMssqlJobStatus()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "Mera_IP_Subnets_generator_manager";
            dbSqlCommand.Parameters.AddWithValue("@query", "93");
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable getTableSizes()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "sp_TableSizes_New";
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable InsertintoPart2()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandText = "InserttblVoIPCDRs_Archive2012_PART2";
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }

        public DataSet getRadius(string ip, string username, string dstnumber)
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandText = "proc_Radius1";
            dbSqlCommand.Parameters.AddWithValue("@ip1", ip);
            dbSqlCommand.Parameters.AddWithValue("@username", username);
            dbSqlCommand.Parameters.AddWithValue("@dstnumber", dstnumber);
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            return objDALCIILibrary.GetDataSet(dbSqlCommand);
        }
        public DataTable Getcustomer(string ip)
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandText = "UsaNPANXXManager";
            dbSqlCommand.Parameters.AddWithValue("@query", "971");
            dbSqlCommand.Parameters.AddWithValue("@ip", ip);
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable GetUnlock()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandText = "proc_Unlock";
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable Getrecover(string startdate, string enddate)
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandText = "proc_MysqlCdrTRansferCascadedbconf";
            dbSqlCommand.Parameters.AddWithValue("@transaction", "21");
            dbSqlCommand.Parameters.AddWithValue("@mode", "full");
            dbSqlCommand.Parameters.AddWithValue("@syslabuser", "adminpage");
            dbSqlCommand.Parameters.AddWithValue("@startdate", startdate);
            dbSqlCommand.Parameters.AddWithValue("@enddate", enddate);
            dbSqlCommand.Parameters.AddWithValue("@view", "1");
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable Getstate()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandText = "UsaNPANXXManager";
            dbSqlCommand.Parameters.AddWithValue("@query", "973");
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable Getstatecity(string filter)
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandText = "UsaNPANXXManager";
            dbSqlCommand.Parameters.AddWithValue("@query", "972");
            dbSqlCommand.Parameters.AddWithValue("@filter", filter);
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable getRestartServer()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandText = "UsaNPANXXManager";
            dbSqlCommand.Parameters.AddWithValue("@query", "99");
            dbSqlCommand.Parameters.AddWithValue("@count", "2");
            dbSqlCommand.Parameters.AddWithValue("@ip", "72.15.129.27");
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataSet getShowstatus(string ip)
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandText = "UsaNPANXXManager";
            dbSqlCommand.Parameters.AddWithValue("@query", "98");
            dbSqlCommand.Parameters.AddWithValue("@ip", ip);
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            return objDALCIILibrary.GetDataSet(dbSqlCommand);
        }
        public DataSet getUsaNPANXXManagerforAdmin(string sup, string cus, string unr)
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandText = "UsaNPANXXManagerforAdmin";
            dbSqlCommand.Parameters.AddWithValue("@sup", sup);
            dbSqlCommand.Parameters.AddWithValue("@cust", cus);
            dbSqlCommand.Parameters.AddWithValue("@unr", unr);
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            return objDALCIILibrary.GetDataSet(dbSqlCommand);
        }
        public DataTable getLinkserver()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "sp_helpserver";
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable AddPartition(string parameter1, string parameter2, string parameter3, string parameter4, string parameter5, string domain)
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "wpartitionManager";
            dbSqlCommand.Parameters.AddWithValue("@parameter1", parameter1);
            dbSqlCommand.Parameters.AddWithValue("@parameter1", parameter2);
            dbSqlCommand.Parameters.AddWithValue("@parameter1", parameter3);
            dbSqlCommand.Parameters.AddWithValue("@parameter1", parameter4);
            dbSqlCommand.Parameters.AddWithValue("@parameter1", parameter5);
            dbSqlCommand.Parameters.AddWithValue("@parameter1", domain);
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataSet Getinternalmenueactive(string contactID, string Access_Deny, string Action)
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandText = "proc_internalmenueactive";
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.Parameters.AddWithValue("@Userid", contactID);
            dbSqlCommand.Parameters.AddWithValue("@Active", Access_Deny);
            dbSqlCommand.Parameters.AddWithValue("@where", Where);
            dbSqlCommand.Parameters.AddWithValue("@Action", Action);
            return objDALCIILibrary.GetDataSet(dbSqlCommand);
        }
        public DataSet Getupdatemsjobactive(string contactID, string Access_Deny)
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandText = "proc_updatemsjobactive";
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.Parameters.AddWithValue("@Userid", contactID);
            dbSqlCommand.Parameters.AddWithValue("@Active", Access_Deny);
            return objDALCIILibrary.GetDataSet(dbSqlCommand);
        }
        public DataSet GetgatewayNames()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandText = "Proc_Check_Lengthof_GatewayNamesNew";
            dbSqlCommand.Parameters.AddWithValue("@view", view);
            dbSqlCommand.Parameters.AddWithValue("@view1", view1);
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            return objDALCIILibrary.GetDataSet(dbSqlCommand);
        }
        public DataSet GetPrefixes()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandText = "Proc_Check_Vdsid_Assingment_Prefixes";
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            return objDALCIILibrary.GetDataSet(dbSqlCommand);
        }
        public DataSet GetInsertMenu()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandText = "wpartitionmanager";
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.Parameters.AddWithValue("@transaction", "91");
            dbSqlCommand.Parameters.AddWithValue("@username", username);
            return objDALCIILibrary.GetDataSet(dbSqlCommand);
        }

        public DataTable getInternalMenu()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "Proc_InternalMenu";
            dbSqlCommand.Parameters.AddWithValue("@where", Where);
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable getFullEport()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "proc_FullEport";
            dbSqlCommand.Parameters.AddWithValue("@massageid", massageid);
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable getSortEport()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "proc_SortEport";
            dbSqlCommand.Parameters.AddWithValue("@massageid", massageid);
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataSet getRates()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "proc_Rates";
            dbSqlCommand.Parameters.AddWithValue("@voipUserId", Name);
            dbSqlCommand.Parameters.AddWithValue("@X1Custid", "");
            dbSqlCommand.Parameters.AddWithValue("@vdsName", vdsName);
            dbSqlCommand.Parameters.AddWithValue("@vdsType", vdsType);
            dbSqlCommand.Parameters.AddWithValue("@vbsid", vbsid);
            return objDALCIILibrary.GetDataSet(dbSqlCommand);
        }
        public DataTable getRates1()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "proc_Rates1";
            dbSqlCommand.Parameters.AddWithValue("@voipUserId", Name);
            dbSqlCommand.Parameters.AddWithValue("@X1Custid", "");
            dbSqlCommand.Parameters.AddWithValue("@vdsName", vdsName);
            dbSqlCommand.Parameters.AddWithValue("@vdsType", vdsType);
            dbSqlCommand.Parameters.AddWithValue("@vbsid", vbsid);
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        // public DataTable getEmailXlsfile(string datetimecreated, string datetimecreated1)
        public DataTable getEmailXlsfile()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "EmailXlsfile";
            dbSqlCommand.Parameters.AddWithValue("@userid", "sergey");

            dbSqlCommand.Parameters.AddWithValue("@BulkMailId", 0);
            // dbSqlCommand.Parameters.AddWithValue("@datetimecreated1", datetimecreated1);
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable getUpdateRates()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "proc_UpdateRates";
            dbSqlCommand.Parameters.AddWithValue("@cost", Cost);
            dbSqlCommand.Parameters.AddWithValue("@vrcId", vrcId);
            dbSqlCommand.Parameters.AddWithValue("@vrtId", vrtId);
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable getrollbackRates()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "proc_rollbackRates";
            dbSqlCommand.Parameters.AddWithValue("@vrcId", vrcId);
            dbSqlCommand.Parameters.AddWithValue("@vrtId", vrtId);
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable getElapsed()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "Mera_IP_Subnets_generator_manager";
            dbSqlCommand.Parameters.AddWithValue("@query", "65");
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable getjobcheck()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "proc_Checkjob";
            dbSqlCommand.Parameters.AddWithValue("@jobname", strCheckjob);
            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        public DataTable gettest()
        {
            DataTable dtReturn = new DataTable();
            dtReturn.Columns.Add("Detail");
            DataTable dtTemp;
            StringBuilder strBuilder = new StringBuilder();

           
                strBuilder = new StringBuilder();
                StringBuilder strResultdisk = new StringBuilder();
                dtTemp = getUSANPANXXtransfer();
                strResultdisk.AppendFormat("<b><br/>USANPANXXtransfer for {0}:</b><br/>", strIP + " is");
                foreach (DataRow dr in dtTemp.Rows)
                {
                    strBuilder.AppendLine(dr["f"].ToString() + "<br/>");
                }
                if (strBuilder.ToString().Contains("DTSER_SUCCESS"))
                {
                    strResultdisk.AppendFormat("<div runat='server' style='color:white; float: left; font-family: Arial; font-size: 12px; background-color:Green; width: 100%; '>" + strBuilder.ToString().Trim() + " <br/></div>");
                }
                else
                {
                    strResultdisk.AppendFormat("<div runat='server' style='color:white; float: left; font-family: Arial; font-size: 12px; background-color:Red; width: 100%; '>" + strBuilder.ToString().Trim() + " <br/></div>");
                }
                dtReturn.Rows.Add(strResultdisk.ToString().Trim());
           
            return dtReturn;
        }
        public DataTable getReport()
        {
            DataTable dtReturn = new DataTable();
            dtReturn.Columns.Add("Detail");
            DataTable dtTemp;
            StringBuilder strBuilder = new StringBuilder();

            foreach (string value in arrList)
            {
                strBuilder = new StringBuilder();
                string[] iptext = value.Split(',');
                strIP = iptext[0];
                strChkText = iptext[1];

                if (strTemp == string.Empty || strCallFor.Contains("Shorewall") || strCallFor.Contains("Cdrtables") || strCallFor.Contains("CheckDiskSpace") || strCallFor.Contains("Replication"))// Go btn
                {
                    StringBuilder strResultdisk = new StringBuilder();
                    dtTemp = getReportTable();
                    foreach (DataRow dr in dtTemp.Rows)
                    {
                        if (strCallFor.Contains("Replication"))
                            strBuilder.AppendLine(dr["f"].ToString());
                        else
                            strBuilder.AppendLine(dr["f"].ToString().Replace(";;", "<br/>") + "<br/>");
                    }
                    if (strCallFor.Contains("Load"))
                    {
                        strResultdisk.AppendFormat("<b><br/>Check Load Average for {0}:</b><br/>", strChkText + " is");
                        if (strBuilder.ToString().Contains("CRITICAL"))
                        {
                            strResultdisk.AppendFormat("<div runat='server' style='color:white; float: left; font-family: Arial; font-size: 12px; background-color:Red; width: 100%; '>" + strBuilder.ToString().Trim() + " <br/></div>");
                        }
                        else
                            if ((strBuilder.ToString().Contains("load average")) && !(strBuilder.ToString().Contains("CRITICAL")))
                            {
                                strResultdisk.AppendFormat("<div runat='server' style='color:white; float: left; font-family: Arial; font-size: 12px; background-color:Green; width: 100%; '>" + strBuilder.ToString().Trim() + " <br/></div>");
                            }
                            else
                            {
                                strResultdisk.AppendFormat("<div runat='server' style='color:white; float: left; font-family: Arial; font-size: 12px; background-color:Orange; width: 100%; '>" + strBuilder.ToString().Trim() + " <br/></div>");
                            }
                        dtReturn.Rows.Add(strResultdisk.ToString().Trim());
                    }
                    else
                        if (strCallFor.Contains("Shorewall"))
                        {
                            if (strExpert == false)
                            {
                                strResultdisk.AppendFormat("<b><br/>Check Shorewall for {0}:</b><br/>", strChkText + " is");
                                dtReturn.Rows.Add(strResultdisk.ToString().Trim() + strBuilder.ToString().Trim());
                            }
                            else
                            {
                                strResultdisk.AppendFormat("<b><br/>Check Shorewall for {0}:</b><br/>", strChkText + " is");
                                if (strBuilder.ToString().Contains("Chain reject"))
                                {
                                    strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Green; width: 100%; '>" + strBuilder.ToString().Trim() + " <br/></div>");
                                }
                                else
                                    if (strBuilder.ToString().Contains("iptables: No chain"))
                                    {
                                        strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Red; width: 100%; '>" + strBuilder.ToString().Trim() + " <br/></div>");
                                    }
                                    else
                                    {
                                        strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Orange; width: 100%; '>Check Shorewall Failed<br/></div>");
                                    }
                                dtReturn.Rows.Add(strResultdisk.ToString().Trim());
                            }

                        }
                        else
                            if (strCallFor.Contains("Cdrtables"))
                            {
                                if (strExpert == false)
                                {
                                    strResultdisk.AppendFormat("<b><br/>Check Cdr tables for {0}:</b><br/>", strChkText + " is");
                                    dtReturn.Rows.Add(strResultdisk.ToString().Trim() + strBuilder.ToString().Trim());
                                }
                                else
                                {
                                    strResultdisk.AppendFormat("<b><br/>Check Cdr tables for {0}:</b><br/>", strChkText + " is");
                                    if (strBuilder.ToString().Contains("Chain reject"))
                                    {
                                        strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Green; width: 100%; '>" + strBuilder.ToString().Trim() + " <br/></div>");
                                    }
                                    else
                                        if (strBuilder.ToString().Contains("iptables: No chain"))
                                        {
                                            strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Red; width: 100%; '>" + strBuilder.ToString().Trim() + " <br/></div>");
                                        }
                                        else
                                        {
                                            strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Orange; width: 100%; '>Check Shorewall Failed<br/></div>");
                                        }
                                    dtReturn.Rows.Add(strResultdisk.ToString().Trim());
                                }

                            }
                            else
                                if (strCallFor.Contains("Replication"))
                                {
                                    strResultdisk.AppendFormat("<b><br/>Status of replication {0}:</b><br/>", strChkText + "(" + strIP + ") is");
                                    string replication = strBuilder.ToString().Trim();
                                    if ((dtTemp.Rows.Count > 0) && (replication.Trim().Length > 0))
                                    {


                                        if (Convert.ToInt32(replication.Trim()) < 15)
                                        {
                                            strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Green; width: 100%; '>" + strBuilder.ToString().Trim() + " <br/></div>");
                                            //strResultdisk.AppendFormat("<b><br/>Status of replication  {0}:</b><br/>of", strChkText + "(" + strIP + ") is " + strBuilder.ToString().Trim());
                                        }
                                        else
                                        {
                                            strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Red; width: 100%; '>" + strBuilder.ToString().Trim() + " <br/></div>");
                                        }
                                    }
                                    else
                                    {
                                        strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Orange; width: 100%; '> Check replication failed <br/></div>");
                                    }
                                    dtReturn.Rows.Add(strResultdisk.ToString().Trim());

                                }
                                else
                                    if (strExpert == false)
                                    {
                                        if (strCallFor.Contains("CheckDiskSpace"))
                                        {
                                            strResultdisk.AppendFormat("<b><br/>Check disk space for {0}:</b><br/>", strChkText + "(" + strIP + ")");
                                            if (strBuilder.ToString().Trim().Contains("DISK OK"))
                                            {
                                                string per = strBuilder.ToString().Trim().Substring(strBuilder.ToString().Trim().IndexOf("(") + 1, 2);


                                                if (Convert.ToInt16(per) < 80)
                                                {
                                                    strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Green; width: 100%; '>" + strBuilder.ToString().Trim() + " <br/></div>");
                                                }
                                                else
                                                {
                                                    strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Red; width: 100%; '>" + strBuilder.ToString().Trim() + " <br/></div>");
                                                }
                                            }
                                            else
                                                if (strBuilder.ToString().Trim().Contains("DISK CRITICAL"))
                                                { strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Orange; width: 100%; '>" + strBuilder.ToString().Trim() + " <br/></div>"); }
                                                else
                                                {
                                                    strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Red; width: 100%; '>" + strBuilder.ToString().Trim() + " <br/></div>");
                                                }
                                            dtReturn.Rows.Add(strResultdisk.ToString().Trim());

                                        }
                                        else
                                        {
                                            strResultdisk.AppendFormat("<b><br/>Ping statistics for {0}:</b><br/>", strChkText + "(" + strIP + ")");
                                            dtReturn.Rows.Add(strResultdisk.ToString().Trim() + strBuilder.ToString().Trim());
                                        }

                                    }
                                    else
                                    {
                                        strResultdisk.AppendFormat("<b><br/>Check disk space for {0}:</b><br/>", strChkText + "(" + strIP + ")");
                                        if (strBuilder.ToString().Trim().Contains("DISK OK"))
                                        {
                                            string per = strBuilder.ToString().Trim().Substring(strBuilder.ToString().Trim().IndexOf("(") + 1, 2);


                                            if (Convert.ToInt16(per) < 80)
                                            {
                                                strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Green; width: 100%; '><b> Free disk space is " + per + "% <br/></b></div>");
                                            }
                                            else
                                            {
                                                strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Red; width: 100%; '><b>Free disk space is " + per + "% <br/></b></div>");
                                            }
                                        }
                                        else
                                            if (strBuilder.ToString().Trim().Contains("DISK CRITICAL"))
                                            {
                                                string per = strBuilder.ToString().Trim().Substring(strBuilder.ToString().Trim().IndexOf("(") + 1, 2);
                                                strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Orange; width: 100%; '><b>Free disk space is " + per + "% <br/></b></div>");
                                                //strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Orange; width: 100%; '><b>Check disk space failed <br/></b></div>");
                                            }
                                            else
                                            {
                                                strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Red; width: 100%; '><b>Check disk space failed <br/></b></div>");
                                            }
                                        //else
                                        //{
                                        //    strResultdisk.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Red; width: 100%; '><b>Check disk space failed <br/></b></div>");
                                        //}
                                        dtReturn.Rows.Add(strResultdisk.ToString().Trim());
                                    }
                }
                else //Call from Ping .net btn
                {
                    dtReturn.Rows.Add(Ping(strIP, strChkText));


                }

            }

            return dtReturn;

        }

        public string Ping(string argument, string strChkText)
        {
            //var ping = new System.Net.NetworkInformation.Ping();

            //var result = ping.Send("www.google.com");

            //if (result.Status != System.Net.NetworkInformation.IPStatus.Success)
            //    return;
            StringBuilder strReturn = new StringBuilder();
            strReturn.AppendFormat("<b><br/>Ping statistics for {0}:</b><br/>", argument);

            //set options ttl=128 and no fragmentation
            PingOptions options = new PingOptions(128, true);

            //create a Ping object
            Ping ping = new Ping();

            //32 empty bytes buffer
            byte[] data = new byte[64];

            int received = 0;
            List<long> responseTimes = new List<long>();
            if (strExpert == false)
            {
                //ping 4 times
                for (int i = 0; i < 5; i++)
                {
                    PingReply reply;
                    if (strMailsub == "yes")
                    {
                        reply = ping.Send("www.google.com", 1000, data, options);
                    }
                    else
                    {
                        IPAddress ip = null;
                        ip = IPAddress.Parse(argument);
                        reply = ping.Send(ip, 1000, data, options);
                    }

                    if (reply != null)
                    {
                        switch (reply.Status)
                        {
                            case IPStatus.Success:
                                strReturn.AppendFormat("Reply from {0}: " + "bytes={1} time={2}ms TTL={3} <br/>", reply.Address, reply.Buffer.Length,
                                        reply.RoundtripTime, reply.Options.Ttl);
                                received++;
                                responseTimes.Add(reply.RoundtripTime);

                                break;
                            case IPStatus.TimedOut:
                                strReturn.AppendFormat("Request timed out.<br/>");

                                break;
                            default:
                                strReturn.AppendFormat("Ping failed {0}<br/>", reply.Status.ToString());

                                break;
                        }
                    }
                    else
                    {
                        strReturn.AppendFormat("Ping failed for an unknown reason<br/>");
                    }
                }

                //statistics calculations
                long averageTime = -1;
                long minimumTime = 0;
                long maximumTime = 0;

                for (int i = 0; i < responseTimes.Count; i++)
                {
                    if (i == 0)
                    {
                        minimumTime = responseTimes[i];
                        maximumTime = responseTimes[i];
                    }
                    else
                    {
                        if (responseTimes[i] > maximumTime)
                        {
                            maximumTime = responseTimes[i];
                        }
                        if (responseTimes[i] < minimumTime)
                        {
                            minimumTime = responseTimes[i];
                        }
                    }
                    averageTime += responseTimes[i];
                }

                StringBuilder statistics = new StringBuilder();

                statistics.AppendFormat("   Packets: Sent = 5, " +
                    "Received = {0}, Lost = {1} <{2}% loss>,",
                    received, 5 - received, Convert.ToInt32(((5 - received) * 100) / 5));
                statistics.AppendLine();
                statistics.Append("<br/> Approximate round trip times in milli-seconds:</b><br/>");
                statistics.AppendLine();

                ////show only if loss is not 100%
                //if (averageTime != -1)
                //{
                statistics.AppendFormat("Minimum = {0}ms, " +
                    "Maximum = {1}ms, Average = {2}ms",
                    minimumTime, maximumTime, (received == 0 ? 0 : (long)(averageTime / received)));
                //}

                strReturn.AppendFormat("<br/>");
                strReturn.AppendFormat(statistics.ToString());
            }
            else
            {
                PingReply reply;
                if (strMailsub == "yes")
                {
                    reply = ping.Send(argument, 1000, data, options);
                }
                else
                {
                    IPAddress ip = null;
                    ip = IPAddress.Parse(argument);
                    reply = ping.Send(ip, 1000, data, options);
                }

                if (reply != null)
                {
                    switch (reply.Status)
                    {
                        case IPStatus.Success:

                            strReturn.AppendFormat("<div runat='server' style='  color:white; float: left; font-family: Arial; font-size: 12px; background-color:Green; width: 100%; '><b>" + argument + "  (" + strChkText + ") <br/></b> Ping Success</div>");

                            break;
                        case IPStatus.TimedOut:
                            strReturn.AppendFormat("<div runat='server' style='float: left; color:white; font-family: Arial; font-size: 12px; background-color:Red; width: 100%; '><b>" + argument + "  (" + strChkText + ") <br/></b> Ping request timed out</div>");

                            break;
                        default:

                            strReturn.AppendFormat("<div runat='server' style='float: left; color:white; font-family: Arial; font-size: 12px; background-color:Red; width: 100%; '><b>" + argument + "  (" + strChkText + ") <br/></b> Ping Failed</div>");

                            break;
                    }
                }
                else
                {
                    strReturn.AppendFormat("<div runat='server' style='float: left; font-family: Arial; color:white; font-size: 12px; background-color:Orange; width: 100%; '><b>" + argument + "  (" + strChkText + ") <br/></b> Ping failed for an unknown reason</div>");
                }

            }

            return strReturn.ToString();
        }

        Menu menuTabMaster;
        int indx2;
        DataRow dtRow;
        public Menu CallMasterTabMenu()
        {
            dbSqlDataTable = new DataTable();
            string MenusToDisplay = string.Empty;

            MenusToDisplay = "''";
            SqlCommand SqlCMD = new SqlCommand("SELECT  MenuCode,MenuType,case when (Displayname='#' Or MenuCode>4 ) then '<font color=''''Green''''>' + Displayname + '</font>' else Displayname end Displayname  ,ParentMenuCode,ContentType,Destination FROM tblMenus WHERE MenuType='t' ");
            dbSqlDataTable = objDALCIILibrary.GetDataTable(SqlCMD);
            menuTabMaster = new Menu();

            CreateMasterTab(string.Empty, new MenuItem());
            return (menuTabMaster);
        }

        protected Int32 CreateMasterTab(String parentId, MenuItem parent)
        {

            DataTable dt;
            String menuId, menuName, menuNevigate, menuNavType, menuType;
            Int32 rowcount;
            if (parentId == String.Empty)
                dt = FilterTabMenuData(true, "");
            //strCommand = "SELECT MenuCode,MenuType,Displayname,ParentMenuCode,ContentType,Destination FROM tblMenus WHERE ParentMenuCode=MenuCode and MenuType='t'  and Active=1  order by Sequenc";
            else
                dt = FilterTabMenuData(false, parentId);
            //strCommand = "SELECT MenuCode,MenuType,Displayname,ParentMenuCode,ContentType,Destination FROM tblMenus Where ParentMenuCode='" + parentId + "' and ParentMenuCode <> MenuCode and MenuType='t'  and Active=1  order by Sequenc";

            //dt = new DataTable();
            //dt = objDALCIILibrary.GetResultFromSqlQur(strCommand);
            if (dt.Rows.Count == 0)
                return 0;
            else
                for (rowcount = 0; rowcount <= dt.Rows.Count - 1; rowcount++)
                {

                    menuType = dt.Rows[rowcount]["MenuType"].ToString().ToLower().Trim();
                    menuId = dt.Rows[rowcount]["MenuCode"].ToString().Trim();
                    menuName = dt.Rows[rowcount]["Displayname"].ToString().Trim();
                    menuNavType = dt.Rows[rowcount]["ContentType"].ToString().Trim();
                    menuNevigate = dt.Rows[rowcount]["Destination"].ToString().Trim();
                    if (menuType.Trim() == "t")
                    {
                        if ((parentId.Trim() == "") || (parentId.Trim() == menuId))
                        {
                            //if (menuNevigate.Trim() != "#")
                            //{
                            //  menuTabMaster.MenuItemClick = "";
                            //  menuTabMaster.Attributes.Add("onclick", "javascript:test();");
                            //}
                            MenuItem tempMenu = new MenuItem(menuName, menuId, "", menuNevigate);
                            menuTabMaster.Items.Add(tempMenu);
                            //menuTabMaster.items[0].Attributes.Add("onclick", "myfunction();");

                            CreateMasterTab(menuId, menuTabMaster.Items[menuTabMaster.Items.Count - 1]);
                            //menuTabMaster.Items[menuTabMaster.Items.Count - 1].SeparatorImageUrl = "Image/SeparatorTopMenu.JPG";                            
                        }
                        else
                        {
                            //if (Department)
                            if ((menuName.Trim() == "Department") && (Convert.ToBoolean(HttpContext.Current.Session["IsHOD"])) == false)
                                CreateMasterTab(menuId, parent.ChildItems[parent.ChildItems.Count - 1]);
                            else
                            {
                                //if (menuNevigate.Trim() == "#")
                                //{
                                //    menuNevigate = "javascript:test();";
                                //}
                                MenuItem objNewChild = new MenuItem(menuName, menuId, "", menuNevigate);
                                parent.ChildItems.Add(objNewChild);
                                if (menuNevigate.Trim() == "#")
                                {
                                    objNewChild.Enabled = false;

                                }

                                CreateMasterTab(menuId, parent.ChildItems[parent.ChildItems.Count - 1]);

                            }

                        }
                    }
                }
            return 0;
        }
        int indx;
        protected DataTable FilterTabMenuData(bool IsRoot, string parentMenuId)
        {
            DataTable temporaryMenuData = new DataTable();
            for (indx = 0; indx <= dbSqlDataTable.Columns.Count - 1; indx++)
            {
                temporaryMenuData.Columns.Add(dbSqlDataTable.Columns[indx].ColumnName.ToString());
            }
            for (indx = 0; indx <= dbSqlDataTable.Rows.Count - 1; indx++)
            {
                if (IsRoot == true)
                {
                    if (dbSqlDataTable.Rows[indx]["MenuCode"].ToString().Trim().ToUpper() == dbSqlDataTable.Rows[indx]["ParentMenuCode"].ToString().Trim().ToUpper())
                    {
                        dtRow = temporaryMenuData.NewRow();
                        for (indx2 = 0; indx2 <= dbSqlDataTable.Columns.Count - 1; indx2++)
                        {
                            dtRow[indx2] = dbSqlDataTable.Rows[indx][indx2];
                        }
                        temporaryMenuData.Rows.Add(dtRow);
                    }
                }
                else
                {
                    if ((dbSqlDataTable.Rows[indx]["MenuCode"].ToString().Trim().ToUpper() != dbSqlDataTable.Rows[indx]["ParentMenuCode"].ToString().Trim().ToUpper()) && (dbSqlDataTable.Rows[indx]["ParentMenuCode"].ToString().Trim().ToUpper() == parentMenuId.ToUpper().Trim()))
                    {
                        dtRow = temporaryMenuData.NewRow();
                        for (indx2 = 0; indx2 <= dbSqlDataTable.Columns.Count - 1; indx2++)
                        {
                            dtRow[indx2] = dbSqlDataTable.Rows[indx][indx2];
                        }
                        temporaryMenuData.Rows.Add(dtRow);
                    }
                }
            }
            return (temporaryMenuData);
        }


        #region "Send Bulk Mail"
        public DataTable SaveBulkMailData()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.CommandText = "proc_InsertBulkMailDetail";
            dbSqlCommand.Parameters.AddWithValue("@SelectedContacts", SelectedContacts);
            dbSqlCommand.Parameters.AddWithValue("@Subject", Subject);
            dbSqlCommand.Parameters.AddWithValue("@Message", Message);
            dbSqlCommand.Parameters.AddWithValue("@SortName", SortName);
            dbSqlCommand.Parameters.AddWithValue("@EmailId", EmailId);
            dbSqlCommand.Parameters.AddWithValue("@FullName", FullName);
            dbSqlCommand.Parameters.AddWithValue("@OrgName", OrgName);
            dbSqlCommand.Parameters.AddWithValue("@UnSelectedContacts", UnSelectedContacts);

            return objDALCIILibrary.GetDataTable(dbSqlCommand);
        }
        #endregion

        #region "Invoice Crstal Report"
        public DataSet GetInVoiceDetail()
        {
            dbSqlCommand = new SqlCommand();
            dbSqlCommand.CommandText = "proc_GetInvoiceDetail";
            dbSqlCommand.CommandType = CommandType.StoredProcedure;
            dbSqlCommand.Parameters.AddWithValue("@InvoiceID", strInvoiceID);
            dbSqlCommand.Parameters.AddWithValue("@ID", strID);
            return objDALCIILibrary.GetDataSet(dbSqlCommand);
        }
        #endregion
    }
}
