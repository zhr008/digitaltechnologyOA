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

namespace OA.aspx.WorkFlow{ 
 public partial class YinZhangView: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FTD.Unit.PublicMethod.CheckSession();

            FTD.BLL.ERPYinZhang MyModel = new FTD.BLL.ERPYinZhang();
            MyModel.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
            this.Image1.ImageUrl = "../../UploadFile/" + MyModel.ImgPath;
            this.Label1.Text = MyModel.YinZhangName;
            this.Label2.Text = MyModel.YinZhangMiMa;
        }
    }
}
}