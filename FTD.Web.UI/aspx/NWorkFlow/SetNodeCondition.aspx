﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SetNodeCondition.aspx.cs" Inherits="OA.aspx.NWorkFlow.SetNodeCondition" %>
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
                <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;流程定义&nbsp;>>&nbsp;设置条件字段
                </td>
                <td align="right" valign="middle" style=" height: 30px;">
                    &nbsp;
<asp:Button ID="iButton1" runat="server" CssClass="btn btn-blue" Text="提交" OnClick="iButton1_Click" />
                    
                    &nbsp;<button type="button" class="btn btn-yellow" onclick="javascript:window.history.go(-1)">返回</button></td>
            </tr>
        </table>
<table style="width: 100%" bgcolor="#999999" class="gridview_m" border="0" cellpadding="2" cellspacing="1">
	<tr>
	<td style="width: 170px; height: 25px; background-color: #f9f9f7" align="right">
        条件设置：</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
        字段：<asp:DropDownList ID="DropDownList7" runat="server" Width="203px">
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownList8" runat="server">
            <asp:ListItem Value="&gt;">大于</asp:ListItem>
            <asp:ListItem Value="&gt;=">大于等于</asp:ListItem>
            <asp:ListItem Value="&lt;">小于</asp:ListItem>
            <asp:ListItem Value="&lt;=">小于等于</asp:ListItem>
            <asp:ListItem Value="=">等于</asp:ListItem>
            <asp:ListItem Value="!=">不等于</asp:ListItem>
            <asp:ListItem>包含</asp:ListItem>
            <asp:ListItem>不包含</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox4" runat="server" Width="53px"></asp:TextBox>
        跳转到节点：<asp:TextBox ID="TextBox7" runat="server" Width="40px"></asp:TextBox><img class="HerCss"
            onclick="var wName;var RadNum=Math.random();wName=window.showModalDialog('../Main/SelectJieDian.aspx?WorkFlowID=<%=Request.QueryString["WorkFlowID"].ToString() %>&Radstr='+RadNum,'','dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');if(wName==null){}else{document.getElementById('TextBox7').value=wName;}"
            src="../../images/Button/search.gif" />
        <asp:Button ID="Button2" runat="server" CausesValidation="False" OnClick="Button2_Click1"
            Text="加入" /><br />
        <span style="color: darkgray">
        </span>
	</td></tr>
    <tr>
        <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
            已设置条件：</td>
        <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
            <asp:ListBox ID="ListBox2" runat="server" Height="310px" SelectionMode="Multiple"
                Width="550px"></asp:ListBox><br />
            <asp:Button ID="Button1" runat="server" CausesValidation="False" OnClick="Button1_Click"
                Text="删除选中" />
            &nbsp;<span style="color: #f9f9f7">*实际流转中以最先一个符合的条件设置为基准！</span></td>
    </tr>
</table>
		</div>
	</form>
</body>
</html>
