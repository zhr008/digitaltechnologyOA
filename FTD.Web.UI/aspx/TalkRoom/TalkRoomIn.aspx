﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TalkRoomIn.aspx.cs" Inherits="OA.aspx.TalkRoom.TalkRoomIn" %>
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
                <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;信息交流&nbsp;>>&nbsp;内部聊天室&nbsp;>>&nbsp;<%=Request.QueryString["TalkRoomName"].ToString()%>
                </td>
                <td align="right" valign="middle" style=" height: 30px;">
                    
<asp:Button ID="iButton3" runat="server" CssClass="btn btn-red" Text="删除" OnClick="iButton3_Click" OnClientClick="javascript:return window.confirm('是否确认删除？');"/>
                    &nbsp;
                    &nbsp;<button type="button" class="btn btn-yellow" onclick="javascript:window.history.go(-1)">返回</button></td>
            </tr>
            <tr>
            <td height="3px" colspan="2" style="background-color: #ffffff"></td>
        </tr>
        </table>
    <table style="width: 100%" bgcolor="#999999" class="gridview_m" border="0" cellpadding="2" cellspacing="1">
        
        <tr>
                <td style="background-color: #ffffff; height: 25px; padding-left:5px;" >
                <iframe name="ShowMsg" src="ShowMessage.aspx?TalkRoomName=<%=Request.QueryString["TalkRoomName"].ToString()%>" width="100%" height="350px"></iframe>
                <iframe name="Speak" src="Speak.aspx?TalkRoomName=<%=Request.QueryString["TalkRoomName"].ToString()%>" width="100%" height="100px"></iframe>                
                </td><td width="120px" style="background-color: #ffffff; " ><iframe name="UserList" src="TalkRoomUser.aspx?TalkRoomName=<%=Request.QueryString["TalkRoomName"].ToString()%>" width="120px" height="450px"></iframe></td>
        </tr>
        </table></div>
    </form>
</body>
</html>