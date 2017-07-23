﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReimburseView.aspx.cs" Inherits="OA.aspx.Financial.ReimburseView" %>

<html>
<head>
    <title>
        <%=System.Configuration.ConfigurationManager.AppSettings["SYSTitle"]%></title>
<link href="../../css/main.css" type="text/css" rel="stylesheet" />
    <link href="../../Style/Style.css" type="text/css" rel="STYLESHEET">
    <script language="javascript">
        function PrintTable() {
            document.getElementById("PrintHide").style.visibility = "hidden"
            print();
            document.getElementById("PrintHide").style.visibility = "visible"
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table id="PrintHide" style="width: 100%" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td valign="middle" style=" height: 30px;">
                    &nbsp;<img src="../../images/BanKuaiJianTou.gif" />
                    <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;进销存类&nbsp;>>&nbsp;财务管理&nbsp;>>&nbsp;查看报销单
                </td>
                <td align="right" valign="middle" style=" height: 30px;">
                    <button type="button" class="btn btn-blue" onclick="javascript:PrintTable()">打印</button>
                    
                    &nbsp;<button type="button" class="btn btn-yellow" onclick="javascript:window.history.go(-1)">返回</button>
                </td>
            </tr>
            <tr>
                <td height="3px" colspan="2" style="background-color: #ffffff">
                </td>
            </tr>
        </table>
        <table style="width: 100%" bgcolor="#999999" class="gridview_m" border="0" cellpadding="2" cellspacing="1">
            <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    报销人：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:Label ID="lblUserName" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    合同名称：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:Label ID="lblHeTongName" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    签约客户：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:Label ID="lblQianYueKeHu" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    报销内容：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:Label ID="lblReimburseContent" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    申请时间：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:Label ID="lblApplyTime" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
                    备注：
                </td>
                <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                    <asp:Label ID="lblMemo" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
