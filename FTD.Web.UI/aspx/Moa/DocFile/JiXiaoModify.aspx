﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JiXiaoModify.aspx.cs" Inherits="OA.aspx.Moa.DocFile.JiXiaoModify" %>
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
                <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;绩效考核&nbsp;>>&nbsp;修改信息
                </td>
                <td align="right" valign="middle" style=" height: 30px;">
                    
<asp:Button ID="iButton1" runat="server" CssClass="btn btn-blue" Text="提交" OnClick="iButton1_Click" />
                    
                    &nbsp;<button type="button" class="btn btn-yellow" onclick="javascript:window.history.go(-1)">返回</button></td>
            </tr>
            <tr>
            <td height="3px" colspan="2" style="background-color: #ffffff"></td>
        </tr>
        </table>
<table style="width: 100%" bgcolor="#999999" class="gridview_m" border="0" cellpadding="2" cellspacing="1">
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		绩效考核名称：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtJXName" runat="server" Width="350px"></asp:TextBox>
		<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtJXName" ErrorMessage="*该项不可以为空"></asp:RequiredFieldValidator>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		简要说明：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtJianJie" runat="server" Width="350px" Height="60px" TextMode="MultiLine"></asp:TextBox></td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		录入人：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtUserName" runat="server" Width="350px" Enabled="False"></asp:TextBox></td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		录入时间：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:TextBox id="txtTimeStr" runat="server" Width="350px" Enabled="False"></asp:TextBox>
	</td></tr>
    <tr>
        <td colspan="2" style="padding-left: 5px; height: 25px; background-color: #ffffff">
            <asp:Label ID="Label1" runat="server"></asp:Label></td>
    </tr>
</table>
		</div>
	</form>
</body>
</html>
