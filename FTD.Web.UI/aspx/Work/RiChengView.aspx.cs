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

namespace OA.aspx.Work{ 
 public partial class RiChengView: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FTD.Unit.PublicMethod.CheckSession();
            //绑定页面数据
            FTD.BLL.ERPAnPai Model = new FTD.BLL.ERPAnPai();
            Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
            this.Label1.Text = Model.TitleStr;
            this.Label6.Text = Model.ContentStr;
            this.Label5.Text = Model.TypeStr;
            this.Label7.Text = Model.GongXiangWho;
            this.Label2.Text = Model.TimeStart.ToString();           
            this.Label3.Text = Model.TimeEnd.ToString();            
            this.Label4.Text = Model.TimeTiXing.ToString().Split(' ')[0];            
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Button TempBtn = (Button)sender;
        FTD.DBUnit.DbHelperSQL.ExecuteSQL("update ERPAnPai set GongXiangWho='" + TempBtn.Text.ToString() + "' where ID=" + Request.QueryString["ID"].ToString());
        Response.Redirect("RiCheng.aspx");
    }
}
}