﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NFormReView.aspx.cs" Inherits="OA.aspx.NWorkFlow.NFormReView" %>
<html>
	<head>
		<title><%=System.Configuration.ConfigurationManager.AppSettings["SYSTitle"]%></title>
<link href="../../css/main.css" type="text/css" rel="stylesheet" />
  <LINK href="../../Style/Style.css" type="text/css" rel="STYLESHEET">
  <script type="text/javascript" language="javascript" src="../../JS/calendar.js"></script>
  <script language="javascript">
      function PrintTable() {
          document.getElementById("PrintHide").style.visibility = "hidden"
          print();
          document.getElementById("PrintHide").style.visibility = "visible"
      }
      function selectUser(imgidstr) {
          var wName;
          var RadNum = Math.random();
          wName = window.showModalDialog('../Main/SelectUser.aspx?Radstr=' + RadNum, '', 'dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');
          if (wName == null || wName == "")
          { }
          else
          {
              imgidstr.value = wName;
          }
      }

      function selectBuMen(imgidstr) {
          var wName;
          var RadNum = Math.random();
          wName = window.showModalDialog('../Main/SelectDanWei.aspx?Radstr=' + RadNum, '', 'dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');
          if (wName == null || wName == "")
          { }
          else
          {
              imgidstr.value = wName;
          }
      }


      function selectyinzhang(imgidstr) {
          var wName;
          var RadNum = Math.random();
          wName = window.showModalDialog('../Main/SelectYinZhang.aspx?Radstr=' + RadNum, '', 'dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');
          if (wName == null || wName == "")
          { }
          else
          {
              imgidstr.src = "http://" + window.location.host + "<%=System.Configuration.ConfigurationManager.AppSettings["OARoot"] %>/UploadFile/" + wName;
            }
        }
        function selectShouXie(imgidstr) {
            var wName;
            var RadNum = Math.random();
            wName = window.showModalDialog('../Main/InsertQianMing.aspx?Radstr=' + RadNum, '', 'dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');
            if (wName == null || wName == "")
            { }
            else
            {
                imgidstr.src = "http://" + window.location.host + "<%=System.Configuration.ConfigurationManager.AppSettings["OARoot"] %>/UploadFile/" + wName;
            }
        }
  </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
     <table id="PrintHide" style="width: 100%" border="0" cellpadding="0" cellspacing="0">            
            <tr>
                <td valign="middle" style=" height: 30px;">&nbsp;<img src="../../images/BanKuaiJianTou.gif" />
                <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;>>&nbsp;流程表单&nbsp;>>&nbsp;查看表单
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
	<td style="padding-left: 5px; height: 25px; background-color: #ffffff" >
		<asp:Label id="lblIFOK" runat="server"></asp:Label></td></tr>
</table>
		</div>
	</form>
</body>
</html>
