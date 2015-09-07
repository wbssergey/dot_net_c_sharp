<%@ Page Title="" Language="C#" MasterPageFile="~/Wiztel.master" AutoEventWireup="true"
    CodeFile="Admin.aspx.cs" Inherits="AdminModuleF_Admin" Theme="MasterTheme" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link href="../App_Themes/MasterTheme/EAMMasterStyle.css" rel="stylesheet" type="text/css" />
    <link href="../App_Themes/CIITheme/ProgressBar.css" rel="stylesheet" type="text/css" />
    <script src="../JS/Lodingpanal.js" type="text/javascript"></script>
    <script type="text/javascript" language="javascript">
        window.onbeforeunload = function () {
            ShowProgress();
        }

        //        Sys.WebForms.PageRequestManager.getInstance().add_pageLoaded(pageLoaded);
        //        function pageLoaded() {
        //            HideProgress();
        //        }
        function ddlPluginsOnSelectedIndexChange(ctrl) {
            //alert(ctrl.value);
            if (ctrl.value == 1) {
                document.getElementById('ContentPlaceHolder1_divIP').style.display = '';
                document.getElementById('ContentPlaceHolder1_divMedia').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divMailsub').style.display = 'none';
            }
            else if (ctrl.value == 2) {
                document.getElementById('ContentPlaceHolder1_divIP').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divMedia').style.display = '';
                document.getElementById('ContentPlaceHolder1_divMailsub').style.display = 'none';
            }
            else {
                document.getElementById('ContentPlaceHolder1_divIP').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divMedia').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divMailsub').style.display = '';
            }
        }
    </script>
    <div style="float: left; font-family: Arial; font-size: 12px; width: 100%;">
        <div id="divBtns" style="float: left; font-family: Arial; font-size: 12px; width: 100%;">
            <div style="text-align: left; float: left; font-family: Arial; width: 100%; font-size: 12px;
                margin-top: 10px">
                <div style='float: left; font-weight: normal; font-family: Arial; font-size: 12px;
                    width: 5%; margin-top: 1px; text-align: left'>
                    <asp:Label ID="lblPlugins" runat="server" Text="Plugin : " Style="float: left;" Height="16px"
                        Width="55px"></asp:Label>
                </div>
                <div style='float: left; font-weight: normal; font-family: Arial; font-size: 12px;
                    width: 15%; margin-top: 1px; text-align: left'>
                    <asp:DropDownList ID="ddlPlugins" runat="server">
                        <asp:ListItem Text="Mysql database" Value="1">
                        </asp:ListItem>
                        <asp:ListItem Text="Media" Value="2">
                        </asp:ListItem>
                        <asp:ListItem Text="Mail subsystem" Value="3">
                        </asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div style='float: left; font-weight: normal; font-family: Arial; font-size: 12px;
                    width: 5%; margin-top: 1px; text-align: left'>
                    <asp:Label ID="lblAction" runat="server" Text="Action : " Style="float: left;" Height="16px"
                        Width="55px"></asp:Label>
                </div>
                <div style='float: left; font-weight: normal; font-family: Arial; font-size: 12px;
                    width: 15%; margin-top: 1px; text-align: left'>
                    <asp:DropDownList ID="ddlActionType" runat="server">
                        <asp:ListItem Text="Ping" Value="Ping">
                        </asp:ListItem>
                        <asp:ListItem Text="Check Disk Space" Value="CheckDiskSpace">
                        </asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div id="divExp" runat="server" style='float: left; margin-left: 5px; font-weight: normal;
                    font-family: Arial; font-size: 12px; width: 9%; margin-top: 1px; text-align: left'>
                    <asp:CheckBox ID="chkExp" Text="Expert" runat="server" />
                </div>
                <div style="text-align: left; float: left; margin-left: 25px; font-family: Arial;
                    width: 35%; font-size: 12px; margin-top: 0px;">
                    <asp:Button ID="btnPing" runat="server" Style="display: none" Text="Ping Using .net"
                        OnClick="btnPing_Click" Width="100px" />
                    <asp:Button ID="btnGo" runat="server" Text="GO" OnClick="btnGo_Click" />
                    <asp:Button ID="btnClear" runat="server" Text="Clear All" OnClick="btnClearAll_Click" />
                </div>
            </div>
            <div style="text-align: left; float: left; font-family: Arial; width: 100%; font-size: 12px;
                margin-top: 10px">
                <div id="divIP" runat="server" style="font-family: Arial; width: 100%; font-size: 12px;
                    float: left; margin-top: 20px">
                    <div style='float: left; font-weight: normal; width: 10%; padding-top: 5px; text-align: left'>
                        <asp:Label ID="lblIP" runat="server" Text="Mysql database : " Style="float: left;"></asp:Label>
                    </div>
                    <div style='float: left; font-weight: normal; font-family: Arial; font-size: 12px;
                        width: 88%; text-align: left;'>
                        <asp:CheckBoxList ID="chKListPing" Style="float: left;" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="72.15.129.10" Text="129.10 Mysql master" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.11" Text="129.11 Mysql master" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.21" Text="72.15.129.21" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.27" Text="129.27 Mysql slave" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.28" Text="129.28 Mysql slave" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.29" Text="72.15.129.29" Selected="True"></asp:ListItem>
                        </asp:CheckBoxList>
                    </div>
                </div>
                <div id="divMailsub" runat="server" style="font-family: Arial; width: 100%; font-size: 12px;
                    float: left; margin-top: 20px; display: none">
                    <div style='float: left; font-weight: normal; width: 10%; padding-top: 5px; text-align: left'>
                        <asp:Label ID="lblMailsub" runat="server" Text="Mail subsystem : " Style="float: left;"></asp:Label>
                    </div>
                    <div style='float: left; font-weight: normal; font-family: Arial; font-size: 12px;
                        width: 88%; text-align: left;'>
                        <asp:CheckBoxList ID="chkMailsub" Style="float: left;" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="Barracuda.wiztel.ca" Text="Barracuda"></asp:ListItem>
                            <asp:ListItem Value="authsmtp.wiztel.ca" Text="Mail"></asp:ListItem>
                            <asp:ListItem Value="mail.wiztel.ca" Text="Authsmtp"></asp:ListItem>
                            <%--<asp:ListItem Value="72.15.142.12" Text="Barracuda"></asp:ListItem>
                            <asp:ListItem Value="72.15.128.2" Text="Mail"></asp:ListItem>
                            <asp:ListItem Value="72.15.128.12" Text="Authsmtp"></asp:ListItem>--%>
                        </asp:CheckBoxList>
                    </div>
                </div>
                <div id="divMedia" runat="server" style="font-family: Arial; font-size: 12px; float: left;
                    width: 100%; margin-top: 20px; display: none">
                    <div style='float: left; font-weight: normal; width: 5%; margin-top: 5px; text-align: left'>
                        <asp:Label ID="lblMedia" runat="server" Text="Media : " Style="float: left;"></asp:Label>
                    </div>
                    <div style='float: left; font-weight: normal; font-family: Arial; font-size: 12px;
                        width: 88%; text-align: left;'>
                        <asp:CheckBoxList ID="chkListMedia" Style="float: left;" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="72.15.129.30" Text="Media1"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.31" Text="Media2"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.32" Text="Media3"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.33" Text="Media4"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.34" Text="Media5"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.35" Text="Media6"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.36" Text="Media7"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.37" Text="Media8"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.38" Text="Media9"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.39" Text="Media10"></asp:ListItem>
                        </asp:CheckBoxList>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="divReport" runat="server" style="vertical-align: top; text-align: justify">
        <asp:DataList ID="dlReport" runat="server" RepeatColumns="2" RepeatDirection="Horizontal"
            OnItemDataBound="dlReport_Item_Bound" ItemStyle-VerticalAlign="Top" ItemStyle-Width="300px"
            BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
            <EditItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
            <ItemStyle VerticalAlign="Top" Width="300px"></ItemStyle>
            <ItemTemplate>
                <div style='width: 100%; float: left; font-size: 12px; font-family: Arial; text-align: left;'>
                    <asp:Label ID="lblReportDetail" runat="server" Text='<%#Eval("Detail") %>'></asp:Label><br />
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
    <div id="divDiskCheck" runat="server" style="vertical-align: top; text-align: justify;
        display: none;">
        <asp:DataList ID="dlDiskCheck" runat="server" RepeatColumns="1" RepeatDirection="Horizontal"
            OnItemDataBound="dlDiskCheck_Item_Bound" ItemStyle-VerticalAlign="Top" ItemStyle-Width="100%"
            BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
            <EditItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
            <ItemStyle VerticalAlign="Top" Width="100%"></ItemStyle>
            <ItemTemplate>
                <div style='width: 100%; float: left; font-size: 12px; font-family: Arial; text-align: left;'>
                    <asp:Literal ID="ltrDiskDetail" runat="server" Text='<%#Eval("Detail") %>'></asp:Literal><br />
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
    <div id="Background2" class="Background" style="display: none; z-index: 999999;">
    </div>
    <div id="Progress2" class="Progress" style="display: none;">
        <img src="../Image/ajaxloader.gif" width="50px" style="vertical-align: middle" alt='' />
        &nbsp;&nbsp; Please Wait...
    </div>
    <script language="javascript" type="text/javascript">
//        if ((parent.frames.length == 0) && (typeof (window.opener) != 'object' || window.opener.name == 'mainFrame')) 
//        {
//            var app = navigator.appVersion;
//            if (app.indexOf('MSIE') <= 0) 
//            {
//                window.open('/closedsecurity.asp', '_self', '');
//            } 
//            else
//            {
//                 window.opener = 'x'; 
//                 window.open('', '_parent', '');
//                 window.open('/closedsecurity.asp', '_self', '')
//            };
//        };
         //Response.write(s);
         </script>
</asp:Content>
