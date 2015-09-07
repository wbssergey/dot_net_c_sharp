<%@ Page Title="" Language="C#" MasterPageFile="~/Wiztel.master" AutoEventWireup="true"
    CodeFile="shorewall.aspx.cs" Theme="MasterTheme" Inherits="AdminModuleF_shorewall" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
        function ddlShorewallOnSelectedIndexChange(ctrl) {
            //alert(ctrl.value);
            if (ctrl.value == 1) {
                document.getElementById('ContentPlaceHolder1_divIP').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divMedia').style.display = '';
                document.getElementById('ContentPlaceHolder1_divSwitches').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divRetail').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divVPN').style.display = 'none';
            }
            else if (ctrl.value == 2) {
                document.getElementById('ContentPlaceHolder1_divIP').style.display = '';
                document.getElementById('ContentPlaceHolder1_divMedia').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divSwitches').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divRetail').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divVPN').style.display = 'none';
            }
            else if (ctrl.value == 3) {
                document.getElementById('ContentPlaceHolder1_divIP').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divMedia').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divSwitches').style.display = '';
                document.getElementById('ContentPlaceHolder1_divRetail').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divVPN').style.display = 'none';
            }
            else if (ctrl.value == 4) {
                document.getElementById('ContentPlaceHolder1_divIP').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divMedia').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divSwitches').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divRetail').style.display = '';
                document.getElementById('ContentPlaceHolder1_divVPN').style.display = 'none';
            }
            else if (ctrl.value == 5) {
                document.getElementById('ContentPlaceHolder1_divIP').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divMedia').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divSwitches').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divRetail').style.display = 'none';
                document.getElementById('ContentPlaceHolder1_divVPN').style.display = '';
            }
        }
    </script>
    <div style="float: left; font-family: Arial; font-size: 12px; width: 100%;">
        <div id="divBtns" style="float: left; font-family: Arial; font-size: 12px; width: 100%;">
            <div style="text-align: left; float: left; font-family: Arial; width: 100%; font-size: 12px;
                margin-top: 10px">
                <div style='float: left; font-weight: normal; font-family: Arial; font-size: 12px;
                    width: 12%; margin-top: 1px; text-align: left'>
                    <asp:Label ID="lblShorewall" runat="server" Text="Check Shorewall" Style="float: left;"
                        Height="16px" Width="100%"></asp:Label>
                </div>
                <div style='float: left; font-weight: normal; font-family: Arial; font-size: 12px;
                    width: 15%; margin-top: 1px; text-align: left'>
                    <asp:DropDownList ID="ddlShorewall" runat="server">
                        <asp:ListItem Text="Media" Value="1">
                        </asp:ListItem>
                        <asp:ListItem Text="Mysql database" Value="2">
                        </asp:ListItem>
                        <asp:ListItem Text="TS switches" Value="3">
                        </asp:ListItem>
                        <asp:ListItem Text="Retail" Value="4">
                        </asp:ListItem>
                        <asp:ListItem Text="VPN" Value="5">
                        </asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div id="divExp" runat="server" style='float: left; margin-left: 5px; font-weight: normal;
                    font-family: Arial; font-size: 12px; width: 9%; margin-top: 1px; text-align: left'>
                    <asp:CheckBox ID="chkExp" Text="Expert" runat="server" />
                </div>
                <div style="text-align: left; float: left; margin-left: 25px; font-family: Arial;
                    width: 35%; font-size: 12px; margin-top: 0px;">
                    <asp:Button ID="btnGo" runat="server" Text="GO" OnClick="btnGo_Click" />
                    <asp:Button ID="btnClear" runat="server" Text="Clear All" OnClick="btnClearAll_Click" />
                </div>
            </div>
            <div style="text-align: left; float: left; font-family: Arial; width: 100%; font-size: 12px;
                margin-top: 10px">
                <div id="divIP" runat="server" style="display: none; font-family: Arial; width: 100%;
                    font-size: 12px; float: left; margin-top: 20px">
                    <div style='float: left; font-weight: normal; width: 10%; padding-top: 5px; text-align: left'>
                        <asp:Label ID="lblIP" runat="server" Text="Mysql database : " Style="float: left;"></asp:Label>
                    </div>
                    <div style='float: left; font-weight: normal; font-family: Arial; font-size: 12px;
                        width: 88%; text-align: left;'>
                        <asp:CheckBoxList ID="chKListPing" Style="float: left;" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="72.15.129.10" Text="129.10 Mysql master" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.11" Text="129.11 Mysql master" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.27" Text="129.27 Mysql slave" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.28" Text="129.28 Mysql slave" Selected="True"></asp:ListItem>
                        </asp:CheckBoxList>
                    </div>
                </div>
                <div id="divRetail" runat="server" style="font-family: Arial; width: 100%; font-size: 12px;
                    float: left; margin-top: 20px; display: none">
                    <div style='float: left; font-weight: normal; width: 10%; padding-top: 5px; text-align: left'>
                        <asp:Label ID="lblRetail" runat="server" Text="Retail : " Style="float: left;"></asp:Label>
                    </div>
                    <div style='float: left; font-weight: normal; font-family: Arial; font-size: 12px;
                        width: 88%; text-align: left;'>
                        <asp:CheckBoxList ID="chkRetail" Style="float: left;" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="72.15.142.20" Text="72.15.142.20"></asp:ListItem>
                        </asp:CheckBoxList>
                    </div>
                </div>
                <div id="divVPN" runat="server" style="font-family: Arial; width: 100%; font-size: 12px;
                    float: left; margin-top: 20px; display: none">
                    <div style='float: left; font-weight: normal; width: 10%; padding-top: 5px; text-align: left'>
                        <asp:Label ID="lblVPN" runat="server" Text="VPN : " Style="float: left;"></asp:Label>
                    </div>
                    <div style='float: left; font-weight: normal; font-family: Arial; font-size: 12px;
                        width: 88%; text-align: left;'>
                        <asp:CheckBoxList ID="chkVPN" Style="float: left;" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="72.15.129.20" Text="72.15.129.20"></asp:ListItem>
                        </asp:CheckBoxList>
                    </div>
                </div>
                <div id="divSwitches" runat="server" style="font-family: Arial; width: 100%; font-size: 12px;
                    float: left; margin-top: 20px; display: none">
                    <div style='float: left; font-weight: normal; width: 10%; padding-top: 5px; text-align: left'>
                        <asp:Label ID="lblSwitches" runat="server" Text="TS switche : " Style="float: left;"></asp:Label>
                    </div>
                    <div style='float: left; font-weight: normal; font-family: Arial; font-size: 12px;
                        width: 88%; text-align: left;'>
                        <asp:CheckBoxList ID="chkSwitches" Style="float: left;" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="72.15.129.207" Text="72.15.129.207"></asp:ListItem>
                            <asp:ListItem Value="72.15.129.208" Text="72.15.129.208"></asp:ListItem>
                        </asp:CheckBoxList>
                    </div>
                </div>
                <div id="divMedia" runat="server" style="font-family: Arial; font-size: 12px; float: left;
                    width: 100%; margin-top: 20px;">
                    <div style='float: left; font-weight: normal; width: 5%; margin-top: 5px; text-align: left'>
                        <asp:Label ID="lblMedia" runat="server" Text="Media : " Style="float: left;"></asp:Label>
                    </div>
                    <div style='float: left; font-weight: normal; font-family: Arial; font-size: 12px;
                        width: 88%; text-align: left;'>
                        <asp:CheckBoxList ID="chkListMedia" Style="float: left;" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="1" Text="Media1" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Media2" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="3" Text="Media3" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="4" Text="Media4" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="5" Text="Media5" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="6" Text="Media6" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="7" Text="Media7" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="8" Text="Media8" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="9" Text="Media9" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="10" Text="Media10" Selected="True"></asp:ListItem>
                        </asp:CheckBoxList>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="divReport" runat="server" style="vertical-align: top; text-align: justify">
        <asp:DataList ID="dlReport" runat="server" RepeatColumns="2" RepeatDirection="Horizontal"
            ItemStyle-VerticalAlign="Top" ItemStyle-Width="470px" BorderColor="Black" BorderStyle="Solid"
            BorderWidth="1px">
            <EditItemStyle BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
            <ItemStyle VerticalAlign="Top" Width="470px"></ItemStyle>
            <ItemTemplate>
                <div style='width: 100%; float: left; font-size: 12px; font-family: Arial; text-align: left;'>
                    <asp:Label ID="lblReportDetail" runat="server" Text='<%#Eval("Detail") %>'></asp:Label><br />
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
</asp:Content>
