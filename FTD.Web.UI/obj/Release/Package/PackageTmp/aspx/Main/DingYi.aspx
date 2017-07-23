﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DingYi.aspx.cs" Inherits="OA.aspx.Main.DingYi" %>
<html>
	<head>
		<title><%=System.Configuration.ConfigurationManager.AppSettings["SYSTitle"]%></title>
<link href="../../css/main.css" type="text/css" rel="stylesheet" />
  <LINK href="../../Style/Style.css" type="text/css" rel="STYLESHEET">
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">    
     <table id="PrintHide" style="width: 100%" border="0" cellpadding="0" cellspacing="0">            
            <tr>
                <td valign="middle" style=" height: 30px;">&nbsp;<img src="../../images/BanKuaiJianTou.gif" />
                <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;桌面管理 &gt;&gt; 快捷导航设置
                </td>
                <td align="right" valign="middle" style=" height: 30px;">
                    
<asp:Button ID="iButton1" runat="server" CssClass="btn btn-blue" Text="提交" OnClick="iButton1_Click" />
                    
                    &nbsp;<button type="button" class="btn btn-yellow" onclick="javascript:window.history.go(-1)">返回</button></td>
            </tr>
            <tr>
            <td height="3px" colspan="2" style="background-color: #ffffff"></td>
        </tr>
        </table>
    <table style="width: 600px" bgcolor="#999999" border="0" cellpadding="2" cellspacing="1">            
        <tr>
            <td style="padding-left: 5px; height: 25px; background-color: #ffffff; text-align: center">
                <strong>所有菜单列表（只可选择最终子菜单，勾选前面的选择框即可）</strong></td>
        </tr>
        
        <tr>
                <td style="background-color: #ffffff; height: 25px; padding-left:5px; text-align: left;" >
                    <asp:TreeView ID="ListTreeView" runat="server" ExpandDepth="0" ForeColor="Black"
                        ShowCheckBoxes="Leaf" ShowLines="True">
                        <ParentNodeStyle HorizontalPadding="2px" />
                        <Nodes>
                            
                        </Nodes>
                        <RootNodeStyle HorizontalPadding="2px" />
                        <LeafNodeStyle HorizontalPadding="2px" />
                    </asp:TreeView>
                    &nbsp;
                </td>
        </tr>
        </table>
        </div>
    </form>
</body>
</html>