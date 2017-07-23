﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuDingView.aspx.cs" Inherits="OA.aspx.Office.GuDingView" %>
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
                <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;资产信息&nbsp;>>&nbsp;查看资产信息
                </td>
                <td align="right" valign="middle" style=" height: 30px;">
                    <button type="button" class="btn btn-blue" onclick="javascript:PrintTable()">打印</button>
                    
                    &nbsp;<button type="button" class="btn btn-yellow" onclick="javascript:window.history.go(-1)">返回</button></td>
            </tr>
            <tr>
            <td height="3px" colspan="2" style="background-color: #ffffff"></td>
        </tr>
        </table>
<table style="width: 100%" bgcolor="#999999" class="gridview_m" border="0" cellpadding="2" cellspacing="1">
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		资产名称：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblGDName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		资产编号：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblGDSerils" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		资产类别：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblGDType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		所属部门：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblSuoShuBuMen" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		资产原值：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblGDAllCount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		资产残值：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblNowCount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		折旧年限：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblNianXian" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		资产性质：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblGDXingZhi" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		启用时间：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblQiYongDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		保管人：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblBaoGuanUser" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		录入人：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblUserName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		录入时间：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblTimeStr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		备注说明：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblBackInfo" runat="server"></asp:Label>
	</td></tr>
</table>

<hr style="height:1px; color: #003333;">
    &nbsp;
    <img src="../../images/TreeImages/hrms.gif" /><a target="RMid" href="GuDingJiLu.aspx?GDName=<%=GDName %>">折旧记录</a>&nbsp;
    
    <hr style="height:1px; color: #003333;">
    <IFRAME name="RMid" frameBorder="0" marginHeight="0" marginWidth="0" width="100%" height="500"
													BORDERCOLOR="#ffffFF"  src="GuDingJiLu.aspx?GDName=<%=GDName %>" border="0"></IFRAME>
													
													
		</div>
	</form>
</body>
</html>
