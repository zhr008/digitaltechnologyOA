﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TiKuShiJuanSetDongTai.aspx.cs" Inherits="OA.aspx.DocFile.TiKuShiJuanSetDongTai" %>
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
                <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;试卷管理&nbsp;>>&nbsp;题目设置
                </td>
                <td align="right" valign="middle" style=" height: 30px;">
                    &nbsp;
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
        单选题数量：
	</td>
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
        <asp:TextBox ID="TextBox1" runat="server">0</asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
            Display="Dynamic" ErrorMessage="*该项不可为空"></asp:RequiredFieldValidator><asp:RangeValidator
                ID="RangeValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic"
                ErrorMessage="*必须为有效数字" MaximumValue="100000" MinimumValue="0" SetFocusOnError="True"
                Type="Integer"></asp:RangeValidator></td></tr>
    <tr>
        <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
            多选题数量：</td>
        <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
            <asp:TextBox ID="TextBox2" runat="server">0</asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                Display="Dynamic" ErrorMessage="*该项不可为空"></asp:RequiredFieldValidator><asp:RangeValidator
                    ID="RangeValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic"
                    ErrorMessage="*必须为有效数字" MaximumValue="100000" MinimumValue="0" SetFocusOnError="True"
                    Type="Integer"></asp:RangeValidator></td>
    </tr>
    <tr>
        <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
            判断题数量：</td>
        <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
            <asp:TextBox ID="TextBox3" runat="server">0</asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3"
                Display="Dynamic" ErrorMessage="*该项不可为空"></asp:RequiredFieldValidator><asp:RangeValidator
                    ID="RangeValidator3" runat="server" ControlToValidate="TextBox3" Display="Dynamic"
                    ErrorMessage="*必须为有效数字" MaximumValue="100000" MinimumValue="0" SetFocusOnError="True"
                    Type="Integer"></asp:RangeValidator></td>
    </tr>
    <tr>
        <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
            填空题数量：</td>
        <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
            <asp:TextBox ID="TextBox4" runat="server">0</asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4"
                Display="Dynamic" ErrorMessage="*该项不可为空"></asp:RequiredFieldValidator><asp:RangeValidator
                    ID="RangeValidator4" runat="server" ControlToValidate="TextBox4" Display="Dynamic"
                    ErrorMessage="*必须为有效数字" MaximumValue="100000" MinimumValue="0" SetFocusOnError="True"
                    Type="Integer"></asp:RangeValidator></td>
    </tr>
    <tr>
        <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
            简答题数量：</td>
        <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
            <asp:TextBox ID="TextBox5" runat="server">0</asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5"
                Display="Dynamic" ErrorMessage="*该项不可为空"></asp:RequiredFieldValidator><asp:RangeValidator
                    ID="RangeValidator5" runat="server" ControlToValidate="TextBox5" Display="Dynamic"
                    ErrorMessage="*必须为有效数字" MaximumValue="100000" MinimumValue="0" SetFocusOnError="True"
                    Type="Integer"></asp:RangeValidator></td>
    </tr>
    <tr>
        <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
            选择题库：</td>
        <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList></td>
    </tr>
</table>
		</div>
	</form>
</body>
</html>
