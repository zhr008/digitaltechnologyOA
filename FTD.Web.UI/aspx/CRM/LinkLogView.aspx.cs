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

namespace OA.aspx.CRM{ 
 public partial class LinkLogView: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FTD.Unit.PublicMethod.CheckSession();
            FTD.BLL.ERPLinkLog model = new FTD.BLL.ERPLinkLog();
            model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
            this.lblCustomName.Text = model.CustomName;
            this.lblLinkTitle.Text = model.LinkTitle;
            this.lblLinkType.Text = model.LinkType;
            this.lblLinkResult.Text = model.LinkResult;
            this.lblLinkTime.Text = model.LinkTime;
            this.lblUserName.Text = model.UserName;
            this.lblTimeStr.Text = model.TimeStr.ToString();
            this.lblIFShare.Text = model.IFShare;
            this.lblCusBakA.Text = model.CusBakA;
            this.lblCusBakB.Text = model.CusBakB;
            this.lblCusBakC.Text = model.CusBakC;
            this.lblCusBakD.Text = model.CusBakD;
            this.lblCusBakE.Text = model.CusBakE;

            //写系统日志
            FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
            MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
            MyRiZhi.DoSomething = "用户查看联系信息(" + this.lblCustomName.Text + ")";
            MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
            MyRiZhi.Add();
        }
    }
}
}