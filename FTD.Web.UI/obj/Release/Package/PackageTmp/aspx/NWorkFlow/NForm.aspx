﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NForm.aspx.cs" Inherits="OA.aspx.NWorkFlow.NForm" %>
<html>
	<head>
		<title><%=System.Configuration.ConfigurationManager.AppSettings["SYSTitle"]%></title>
<link href="../../css/main.css" type="text/css" rel="stylesheet" />
  <LINK href="../../Style/Style.css" type="text/css" rel="STYLESHEET">
</head>
<SCRIPT LANGUAGE="JavaScript">
    var a;
    function CheckValuePiece() {
        if (window.document.form1.GoPage.value == "") {
            alert("请输入跳转的页码！");
            window.document.form1.GoPage.focus();
            return false;
        }
        return true;
    }
    function CheckAll() {
        if (a == 1) {
            for (var i = 0; i < window.document.forms['form1'].elements.length; i++) {
                var e = form1.elements[i];
                e.checked = false;
            }
            a = 0;
        }
        else {
            for (var i = 0; i < window.document.forms['form1'].elements.length; i++) {
                var e = form1.elements[i];
                e.checked = true;
            }
            a = 1;
        }
    }
    function CheckDel() {
        var number = 0;
        for (var i = 0; i < window.document.forms['form1'].elements.length; i++) {
            var e = form1.elements[i];
            if (e.Name != "CheckBoxAll") {
                if (e.checked == true) {
                    number = number + 1;
                }
            }
        }
        if (number == 0) {
            alert("请选择需要删除的项！");
            return false;
        }
        if (window.confirm("你确认删除吗？")) {
            return true;
        }
        else {
            return false;
        }
    }

    function CheckModify() {
        var Modifynumber = 0;
        for (var i = 0; i < window.document.forms['form1'].elements.length; i++) {
            var e = form1.elements[i];
            if (e.Name != "CheckBoxAll") {
                if (e.checked == true) {
                    Modifynumber = Modifynumber + 1;
                }
            }
        }
        if (Modifynumber == 0) {
            alert("请至少选择一项！");
            return false;
        }
        if (Modifynumber > 1) {
            alert("只允许选择一项！");
            return false;
        }

        return true;
    }



		</SCRIPT>  
<body>
    <form id="form1" runat="server">
    <div>    
     <table style="width: 100%" border="0" cellpadding="0" cellspacing="0">            
            <tr>
                <td align="right" style=" height: 30px; text-align: left"
                    valign="middle">
                    &nbsp;<img src="../../images/BanKuaiJianTou.gif" /> &nbsp;分类：<asp:Label ID="Label1" runat="server"></asp:Label></td>
                <td align="right" valign="middle" style=" height: 30px;">
					查询：<asp:DropDownList ID="DropDownList2" runat="server">
					<asp:ListItem Value="FormName">表单名称</asp:ListItem>
					<asp:ListItem Value="IFOK">是否启用</asp:ListItem>
					</asp:DropDownList><asp:TextBox ID="TextBox3" runat="server" Width="80px"></asp:TextBox><img class="HerCss"
					onclick="var wName;var RadNum=Math.random();wName=window.showModalDialog('../Main/SelectCondition.aspx?TableName=ERPNForm&LieName='+document.getElementById('DropDownList2').value+'&Radstr='+RadNum,'','dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');if(wName==null){}else{document.getElementById('TextBox3').value=wName;}"
					src="../../images/Button/search.gif" />
<asp:Button ID="iButton4" runat="server" CssClass="btn btn-blue" Text="查询" OnClick="iButton4_Click" />
<asp:Button ID="iButton6" runat="server"  OnClick="iButton6_Click" Text="结果中查找" CssClass="btn btn-aqua"/>&nbsp; &nbsp;
                    
<asp:Button ID="iButton1" runat="server" CssClass="btn btn-aqua" Text="添加" OnClick="iButton1_Click" />
                    
<asp:Button ID="iButton5" runat="server" CssClass="btn btn-green" Text="修改" OnClick="iButton5_Click" OnClientClick="javascript:return CheckModify();"/>
                    
<asp:Button ID="iButton3" runat="server" OnClientClick="javascript:return CheckDel();" CssClass="btn btn-red" Text="删除" OnClick="iButton3_Click" />   
                    &nbsp;
<asp:Button ID="iButton2" runat="server" CssClass="btn btn-aqua" Text="导出" OnClick="iButton2_Click" />&nbsp;<button type="button" class="btn btn-yellow" onclick="javascript:window.history.go(-1)">返回</button></td>
            </tr>
        </table>
        
    </div>
        <table style="width: 100%">
            <tr>
            <td ><asp:GridView ID="GVData" CssClass="gridview_m"  runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False"
                    BorderStyle="Groove" BorderWidth="1px" OnRowDataBound="GVData_RowDataBound" PageSize="15"
                    Width="100%">
                    <PagerSettings Mode="NumericFirstLast" Visible="False" />
                    <PagerStyle BackColor="LightSteelBlue" HorizontalAlign="Right" />
                    <HeaderStyle BackColor="#F3F3F3" Font-Size="12px" ForeColor="Black" Height="30px" /><AlternatingRowStyle BackColor="#f9f9f7" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Label ID="LabVisible" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "ID")%>'
                                    Visible="False"></asp:Label><asp:CheckBox ID="CheckSelect" runat="server" />
                            </ItemTemplate>
                            <HeaderStyle Width="35px" />
                            <HeaderTemplate>
                                <input id="CheckBoxAll" onclick="CheckAll()"  type="checkbox" />
                            </HeaderTemplate>
                        </asp:TemplateField>
					<asp:TemplateField HeaderText="表单名称"> <ItemTemplate> <asp:HyperLink ID="HyperLink1" runat="server" Font-Underline="False" ForeColor="green" NavigateUrl='<%# "NFormView.aspx?ID="+ DataBinder.Eval(Container.DataItem, "ID")%>'><%# DataBinder.Eval(Container.DataItem, "FormName")%></asp:HyperLink> </ItemTemplate>   <ItemStyle HorizontalAlign="Left" />  </asp:TemplateField> 
					<asp:BoundField DataField="UserName" HeaderText="录入人" ></asp:BoundField>     
					<asp:BoundField DataField="TimeStr" HeaderText="录入时间" ></asp:BoundField>  
					<asp:BoundField DataField="IFOK" HeaderText="是否启用" ></asp:BoundField>   
					
					  
                        <asp:TemplateField HeaderText="相关操作"><ItemTemplate>
                        
                        <asp:HyperLink ID="HyperLink10" runat="server" Font-Underline="False" ForeColor="green" Target="_blank" NavigateUrl='<%# "NFormDesign.aspx?TypeID="+DataBinder.Eval(Container.DataItem, "TypeID")+"&ID="+ DataBinder.Eval(Container.DataItem, "ID") %>' >[表单设计器]</asp:HyperLink>
                        <asp:HyperLink ID="HyperLink11" runat="server" Font-Underline="False" ForeColor="green" NavigateUrl='<%# "NFormReView.aspx?TypeID="+DataBinder.Eval(Container.DataItem, "TypeID")+"&ID="+ DataBinder.Eval(Container.DataItem, "ID") %>'  >[表单预览]</asp:HyperLink>
                        
                        </ItemTemplate></asp:TemplateField>
                        
                        
</Columns>
                    <RowStyle HorizontalAlign="Center" Height="25px" />
                <EmptyDataTemplate>
                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                        <tr>
                            <td align="center" style="border-right: black 1px; border-top: black 1px;
                                border-left: black 1px; border-bottom: black 1px; background-color: #f9f9f7;">
                                该列表中暂时无数据！</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                </asp:GridView>
                </td>
        </tr>
        <tr>
            <td style="border-top: #eeeeee 1px solid;border-bottom: #eeeeee 1px solid">
                <asp:ImageButton ID="BtnFirst" runat="server" CommandName="First" ImageUrl="../../images/Button/First.jpg"
                    OnClick="PagerButtonClick" />
                <asp:ImageButton ID="BtnPre" runat="server" CommandName="Pre" ImageUrl="../../images/Button/Pre.jpg"
                    OnClick="PagerButtonClick" />
                <asp:ImageButton ID="BtnNext" runat="server" CommandName="Next" ImageUrl="../../images/Button/Next.jpg"
                    OnClick="PagerButtonClick" />
                <asp:ImageButton ID="BtnLast" runat="server" CommandName="Last" ImageUrl="../../images/Button/Last.jpg"
                    OnClick="PagerButtonClick" />
                &nbsp;第<asp:Label ID="LabCurrentPage" runat="server" Text="Label"></asp:Label>页&nbsp; 共<asp:Label
                    ID="LabPageSum" runat="server" Text="Label"></asp:Label>页&nbsp;
                <asp:TextBox ID="TxtPageSize" runat="server" CssClass="TextBoxCssUnder2" Height="30px"
                    Width="35px">15</asp:TextBox>
                行每页 &nbsp; 转到第<asp:TextBox ID="GoPage" runat="server" CssClass="TextBoxCssUnder2"
                    Height="30px" Width="33px"></asp:TextBox>
                页&nbsp;
                <asp:ImageButton ID="ButtonGo" runat="server" OnClientClick="javascript:return CheckValuePiece();"  ImageUrl="../../images/Button/Jump.jpg" OnClick="ButtonGo_Click" />&nbsp;
                
<asp:ImageButton ID="iButton7" runat="server" ImageAlign="AbsMiddle" ImageUrl="../../images/Button/Copy.jpg" OnClick="iButton7_Click" OnClientClick="javascript:return CheckModify();" /></td>
        </tr>
        </table>
    </form>
</body>
</html>
