﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaskHB.aspx.cs" Inherits="OA.aspx.Moa.Subaltern.TaskHB" %>
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
                <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;任务分配&nbsp;>>&nbsp;任务汇报
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
		任务标题：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblTaskTitle" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		任务内容：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblTaskContent" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		分配人：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblFromUser" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		执行人：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblToUserList" runat="server"></asp:Label>
	</td></tr>
    <tr>
        <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		任务进度：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblJinDu" runat="server"></asp:Label>
	</td>
    </tr>
    <tr>
        <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
            完成情况：
        </td>
        <td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblWanCheng" runat="server"></asp:Label>
	</td>
    </tr>
    <tr>
        <td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		当前状态：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblNowState" runat="server"></asp:Label>
	</td>
    </tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		汇报与批示：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblXinXiGouTong" runat="server"></asp:Label>
	</td></tr>
    <tr>
        <td colspan="2" style="padding-left: 5px; height: 25px; background-color: #ffffff;
            text-align: center">
            <strong>我的汇报</strong></td>
    </tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
        任务进度(%)：</td>
        <td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
            <asp:TextBox ID="txtJinDu" runat="server" Width="350px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtJinDu"
                Display="Dynamic" ErrorMessage="*必须为有效数字" MaximumValue="100" MinimumValue="0"
                Type="Double"></asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtJinDu"
                Display="Dynamic" ErrorMessage="*该项必须输入"></asp:RequiredFieldValidator></td>
    </tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
		完成情况：</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
        <asp:TextBox ID="txtWanCheng" runat="server" Height="60px" TextMode="MultiLine" Width="350px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtWanCheng"
            Display="Dynamic" ErrorMessage="*该项必须输入"></asp:RequiredFieldValidator></td>
    </tr>
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
        我的汇报：</td>
        <td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
            <asp:TextBox ID="TextBox1" runat="server" Height="60px" TextMode="MultiLine" Width="350px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox1"
                Display="Dynamic" ErrorMessage="*该项必须输入"></asp:RequiredFieldValidator></td>
    </tr>
    <tr>
        <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
        </td>
        <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
            
<asp:Button ID="iButton1" runat="server" CssClass="btn btn-blue" Text="提交" OnClick="iButton1_Click" /></td>
    </tr>
</table>
		</div>
	</form>
</body>
</html>
