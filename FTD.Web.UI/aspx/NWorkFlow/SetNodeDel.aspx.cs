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

namespace OA.aspx.NWorkFlow{ 
 public partial class SetNodeDel: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FTD.DBUnit.DbHelperSQL.ExecuteSQL("delete from ERPNWorkFlowNode where ID=" + Request.QueryString["ID"].ToString());
        Response.Redirect("NWorkFlowNode.aspx?WorkFlowID=" + Request.QueryString["WorkFlowID"].ToString());
    }
}
}