﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MailSetting.aspx.cs" Inherits="OA.aspx.Personal.MailSetting" %>
<html>
	<head>
		<title><%=System.Configuration.ConfigurationManager.AppSettings["SYSTitle"]%></title>
<link href="../../css/main.css" type="text/css" rel="stylesheet" />
  <LINK href="../../Style/Style.css" type="text/css" rel="STYLESHEET">
</head>
<body>
    <form id="form1" runat="server">
    <div>    
     <table id="PrintHide" style="width: 100%" border="0" cellpadding="0" cellspacing="0">            
            <tr>
                <td valign="middle" style=" height: 30px;">&nbsp;<img src="../../images/BanKuaiJianTou.gif" />
                <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;个人设置&nbsp;>>&nbsp;邮件设置
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
            <td align="right" style="width: 170px; background-color: #f9f9f7; height: 25px;" >
                邮箱地址：</td>
                <td style="background-color: #ffffff; height: 25px; padding-left:5px;" >
                    <asp:TextBox ID="TextBox8" runat="server" CssClass="inputCss" Width="350px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
                POP3登录名：</td>
            <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="inputCss" Width="350px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
                POP3密码：</td>
            <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                <asp:TextBox ID="TextBox2" runat="server" CssClass="inputCss" Width="350px" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
                POP3服务器：</td>
            <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                <asp:TextBox ID="TextBox3" runat="server" CssClass="inputCss" Width="350px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
                POP3端口：</td>
            <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                <asp:TextBox ID="TextBox4" runat="server" CssClass="inputCss" Width="350px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
                SMTP登录名：</td>
            <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                <asp:TextBox ID="TextBox5" runat="server" CssClass="inputCss" Width="350px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
                SMTP密码：</td>
            <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                <asp:TextBox ID="TextBox6" runat="server" CssClass="inputCss" Width="350px" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 170px; height: 25px; background-color: #f9f9f7">
                SMTP服务器：</td>
            <td style="padding-left: 5px; height: 25px; background-color: #ffffff">
                <asp:TextBox ID="TextBox7" runat="server" CssClass="inputCss" Width="350px"></asp:TextBox></td>
        </tr>
        </table></div>
    </form>
</body>
</html>