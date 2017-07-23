﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace OA.aspx.SystemManage{ 
 public partial class DanWeiInfo: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FTD.BLL.ERPDanWeiInfo MyDanWei = new FTD.BLL.ERPDanWeiInfo();
            MyDanWei.GetModel();
            TextBox1.Text = MyDanWei.DanWeiName;
            TextBox2.Text = MyDanWei.Tel;
            TextBox3.Text = MyDanWei.Fax;
            TextBox4.Text = MyDanWei.YouBian;
            TextBox5.Text = MyDanWei.Address;
            TextBox6.Text = MyDanWei.WebUrl;
            TextBox7.Text = MyDanWei.Email;
            TextBox8.Text = MyDanWei.KaiHuHang;
            TextBox9.Text = MyDanWei.ZhangHao;

            //设定按钮权限
            iButton1.Visible = FTD.Unit.PublicMethod.StrIFIn("|084M|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));

            //判断是否属于查询模块
            try
            {
                string SerchTypeStr = Request.QueryString["Type"].ToString();
                this.iButton1.Visible = false;
            }
            catch
            { }
        }
    }
    protected void iButton1_Click(object sender, EventArgs e)
    {
        FTD.BLL.ERPDanWeiInfo MyDanWei = new FTD.BLL.ERPDanWeiInfo();
        MyDanWei.DanWeiName=TextBox1.Text.Trim();
        MyDanWei.Tel=TextBox2.Text.Trim() ;
        MyDanWei.Fax=TextBox3.Text;
        MyDanWei.YouBian=TextBox4.Text;
        MyDanWei.Address=TextBox5.Text;
        MyDanWei.WebUrl=TextBox6.Text;
        MyDanWei.Email=TextBox7.Text;
        MyDanWei.KaiHuHang=TextBox8.Text;
        MyDanWei.ZhangHao=TextBox9.Text;
        MyDanWei.Update();
        FTD.Unit.MessageBox.Show(this,"修改单位信息成功！");

        //写系统日志
        FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
        MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
        MyRiZhi.DoSomething = "用户修改单位信息";
        MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
        MyRiZhi.Add();
    }
}
}