﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RiChengView.aspx.cs" Inherits="OA.aspx.Work.RiChengView" %>
<html>
	<head>
		<title><%=System.Configuration.ConfigurationManager.AppSettings["SYSTitle"]%></title>
<link href="../../css/main.css" type="text/css" rel="stylesheet" />
  <LINK href="../../Style/Style.css" type="text/css" rel="STYLESHEET">
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
                <td valign="middle" style=" height: 30px;">&nbsp;<img src="../../images/BanKuaiJianTou.gif" />
                <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;日程安排&nbsp;>>&nbsp;查看日程安排
                </td>
                <td align="right" valign="middle" style=" height: 30px;">
                    <button type="button" class="btn btn-blue" onclick="javascript:PrintTable()">打印</button>&nbsp;
                    
                    &nbsp;<button type="button" class="btn btn-yellow" onclick="javascript:window.history.go(-1)">返回</button></td>
            </tr>
            <tr>
            <td height="3px" colspan="2" style="background-color: #ffffff"></td>
        </tr>
        </table>
    <table style="width: 100%" bgcolor="#999999" class="gridview_m" border="0" cellpadding="2" cellspacing="1">            
        
        <tr>
            <td align="right" style="width: 170px; background-color: #f9f9f7; height: 25px;" >
                信息主题：</td>
                <td style="background-color: #ffffff; height: 25px; padding-left:5px;" >
                    <asp:Label ID="Label1" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
                开始时间：</td>
            <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                <asp:Label ID="Label2" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
                结束时间：</td>
            <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                <asp:Label ID="Label3" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
                提醒日期：</td>
            <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                <asp:Label ID="Label4" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
                事务类型：</td>
            <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                <asp:Label ID="Label5" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
                当前状态：</td>
            <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                <asp:Label ID="Label7" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
                标记状态为：</td>
            <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="待处理" />
                <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="处理中" />
                <asp:Button ID="Button3" runat="server" OnClick="Button1_Click" Text="已处理" />
                <asp:Button ID="Button4" runat="server" OnClick="Button1_Click" Text="待安排" />
                <asp:Button ID="Button5" runat="server" OnClick="Button1_Click" Text="已安排" />
                <asp:Button ID="Button6" runat="server" OnClick="Button1_Click" Text="已完成" />
            </td>
        </tr>
        <tr>
            <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
                详细内容：</td>
            <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                <asp:Label ID="Label6" runat="server"></asp:Label></td>
        </tr>
        </table></div>
    </form>
</body>
</html>