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
 public partial class NWorkFlowNodeAdd: System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();
			//设置上传的附件为空
			 FTD.Unit.PublicMethod.SetSessionValue("WenJianList", "");

             string ExsistID = FTD.DBUnit.DbHelperSQL.GetSHSL("select ID from ERPNWorkFlowNode where WorkFlowID=" + Request.QueryString["WorkFlowID"].ToString() + " and NodeAddr='开始'");
             if (ExsistID.Trim().Length > 0)
             {
                 this.DropDownList1.Items.Remove(new ListItem("开始"));
             }

             string ExsistID1 = FTD.DBUnit.DbHelperSQL.GetSHSL("select ID from ERPNWorkFlowNode where WorkFlowID=" + Request.QueryString["WorkFlowID"].ToString() + " and NodeAddr='结束'");
             if (ExsistID1.Trim().Length > 0)
             {
                 this.DropDownList1.Items.Remove(new ListItem("结束"));
             }
		}
	}
	protected void iButton1_Click(object sender, EventArgs e)
	{
        //判断开始、结束两个节点的唯一性，中间节点必须指定下一节点
        if (this.DropDownList1.SelectedItem.Text == "开始")
        {
            string ExsistID = FTD.DBUnit.DbHelperSQL.GetSHSL("select ID from ERPNWorkFlowNode where WorkFlowID=" + Request.QueryString["WorkFlowID"].ToString() + " and NodeAddr='开始'");
            if (ExsistID.Trim().Length > 0)
            {
                FTD.Unit.MessageBox.Show(this, "该流程已经存在“开始”节点，请不要重复添加！");
                return;
            }
        }
        if (this.DropDownList1.SelectedItem.Text == "结束")
        {
            string ExsistID = FTD.DBUnit.DbHelperSQL.GetSHSL("select ID from ERPNWorkFlowNode where WorkFlowID=" + Request.QueryString["WorkFlowID"].ToString() + " and NodeAddr='结束'");
            if (ExsistID.Trim().Length > 0)
            {
                FTD.Unit.MessageBox.Show(this, "该流程已经存在“结束”节点，请不要重复添加！");
                return;
            }
        }

        if (this.DropDownList1.SelectedItem.Text == "中间段" || this.DropDownList1.SelectedItem.Text == "开始")
        {
            string ExsistID = this.txtNextNode.Text.Trim();
            if (ExsistID.Trim().Length <= 0)
            {
                FTD.Unit.MessageBox.Show(this, "中间段和开始节点必须指定下一节点序号！");
                return;
            }
        }
        //判断节点序号的唯一性
        string NodeSerils = FTD.DBUnit.DbHelperSQL.GetSHSL("select ID from ERPNWorkFlowNode where WorkFlowID=" + Request.QueryString["WorkFlowID"].ToString() + " and NodeSerils='" + this.txtNodeSerils.Text.Trim() + "'");
        if (NodeSerils.Trim().Length > 0)
        {
            FTD.Unit.MessageBox.Show(this, "该节点序号已经存在，请不要重复添加！");
            return;
        }

		FTD.BLL.ERPNWorkFlowNode Model = new FTD.BLL.ERPNWorkFlowNode();

        Model.WorkFlowID = int.Parse(Request.QueryString["WorkFlowID"].ToString());
		Model.NodeSerils=this.txtNodeSerils.Text.ToString().Trim();
        Model.NodeName = this.txtNodeName.Text.ToString().Trim();
		Model.NodeAddr=this.DropDownList1.SelectedItem.Text.ToString();
        Model.NextNode = this.txtNextNode.Text.ToString().Trim();
        Model.IFCanJump = this.DropDownList2.SelectedItem.Text.ToString();
        Model.IFCanView = this.DropDownList3.SelectedItem.Text.ToString();
        Model.IFCanEdit = this.DropDownList4.SelectedItem.Text.ToString();
        Model.IFCanDel = this.DropDownList5.SelectedItem.Text.ToString();
        Model.JieShuHours = int.Parse(this.txtJieShuHours.Text.Trim());
        Model.PSType = this.DropDownList6.SelectedItem.Text.ToString();
        Model.SPType = this.DropDownList7.SelectedItem.Text.ToString();
        Model.SPDefaultList = this.txtSPDefaultList.Text.ToString().Trim();
		Model.CanWriteSet="";
		Model.SecretSet="";
		Model.ConditionSet="";
		
		Model.Add();
		
		//写系统日志
		FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
		MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
        MyRiZhi.DoSomething = "用户添加节点定义信息(" + this.txtNodeName.Text + ")";
		MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
		MyRiZhi.Add();

        FTD.Unit.MessageBox.ShowAndRedirect(this, "节点定义信息添加成功！", "NWorkFlowNode.aspx?WorkFlowID=" + Request.QueryString["WorkFlowID"].ToString());
	}
}
}