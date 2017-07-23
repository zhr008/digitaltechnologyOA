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
 public partial class CustomInfo: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FTD.Unit.PublicMethod.CheckSession();
            //设定按钮权限            
            iButton3.Visible = FTD.Unit.PublicMethod.StrIFIn("|C009D|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
            iButton2.Visible = FTD.Unit.PublicMethod.StrIFIn("|C009E|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
            LinkButton1.Visible = FTD.Unit.PublicMethod.StrIFIn("|C009M|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));

            try
            {
                this.DropDownList1.SelectedValue = Request.QueryString["DropStr"].ToString();
                this.TextBox1.Text = Request.QueryString["TextStr"].ToString();
            }
            catch
            {}


            DataBindToGridview();
        }
    }
    public string GetTimeCondition()
    {
        string ConditionStr = "";
        DateTime MyDate, MyDateSec;
        if (DateTime.TryParse(this.TextBox2.Text.Trim(), out MyDate) == true)
        {
            ConditionStr = ConditionStr + " and TimeStr>='" + this.TextBox2.Text.Trim() + " 00:00:00' ";
        }
        if (DateTime.TryParse(this.TextBox3.Text.Trim(), out MyDateSec) == true)
        {
            ConditionStr = ConditionStr + " and TimeStr<='" + this.TextBox3.Text.Trim() + " 23:59:59' ";
        }
        return ConditionStr;
    }
    public string SetIfShare()
    {
        try
        {
            string tempStr = Request.QueryString["Type"].ToString();
            iButton3.Visible = false;
            LinkButton1.Visible = false;
            return " and  ','+IFShare+',' like '%," + FTD.Unit.PublicMethod.GetSessionValue("UserName") + ",%' ";
        }
        catch
        {
            return "";
        }
    }
    public void DataBindToGridview()
    {
        FTD.BLL.ERPCustomInfo MyModel = new FTD.BLL.ERPCustomInfo();
        GVData.DataSource = MyModel.GetList(" " + this.DropDownList1.SelectedItem.Value.ToString() + " Like '%" + this.TextBox1.Text + "%' " + GetTimeCondition() + " " + SetIfShare() + " order by ID desc");
        GVData.DataBind();
        LabPageSum.Text = Convert.ToString(GVData.PageCount);
        LabCurrentPage.Text = Convert.ToString(((int)GVData.PageIndex + 1));
        this.GoPage.Text = LabCurrentPage.Text.ToString();
    }
    #region  分页方法
    protected void ButtonGo_Click(object sender, EventArgs e)
    {
        try
        {
            if (GoPage.Text.Trim().ToString() == "")
            {
                Response.Write("<script language='javascript'>alert('页码不可以为空!');</script>");
            }
            else if (GoPage.Text.Trim().ToString() == "0" || Convert.ToInt32(GoPage.Text.Trim().ToString()) > GVData.PageCount)
            {
                Response.Write("<script language='javascript'>alert('页码不是一个有效值!');</script>");
            }
            else if (GoPage.Text.Trim() != "")
            {
                int PageI = Int32.Parse(GoPage.Text.Trim()) - 1;
                if (PageI >= 0 && PageI < (GVData.PageCount))
                {
                    GVData.PageIndex = PageI;
                }
            }

            if (TxtPageSize.Text.Trim().ToString() == "")
            {
                Response.Write("<script language='javascript'>alert('每页显示行数不可以为空!');</script>");
            }
            else if (TxtPageSize.Text.Trim().ToString() == "0")
            {
                Response.Write("<script language='javascript'>alert('每页显示行数不是一个有效值!');</script>");
            }
            else if (TxtPageSize.Text.Trim() != "")
            {
                try
                {
                    int MyPageSize = int.Parse(TxtPageSize.Text.ToString().Trim());
                    this.GVData.PageSize = MyPageSize;
                }
                catch
                {
                    Response.Write("<script language='javascript'>alert('每页显示行数不是一个有效值!');</script>");
                }
            }

            DataBindToGridview();
        }
        catch
        {
            DataBindToGridview();
            Response.Write("<script language='javascript'>alert('请输入有效数字！');</script>");
        }
    }
    protected void PagerButtonClick(object sender, EventArgs e)
    {
        //获得Button的参数值
        string arg = ((ImageButton)sender).CommandName.ToString();
        switch (arg)
        {
            case ("Next"):
                if (this.GVData.PageIndex < (GVData.PageCount - 1))
                    GVData.PageIndex++;
                break;
            case ("Pre"):
                if (GVData.PageIndex > 0)
                    GVData.PageIndex--;
                break;
            case ("Last"):
                try
                {
                    GVData.PageIndex = (GVData.PageCount - 1);
                }
                catch
                {
                    GVData.PageIndex = 0;
                }

                break;
            default:
                //本页值
                GVData.PageIndex = 0;
                break;
        }
        DataBindToGridview();
    }
    #endregion
    protected void GVData_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        FTD.Unit.PublicMethod.GridViewRowDataBound(e);
    }
    protected void iButton4_Click(object sender, EventArgs e)
    {
        DataBindToGridview();
    }
    protected void iButton3_Click(object sender, EventArgs e)
    {
        string IDlist = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
        if (FTD.DBUnit.DbHelperSQL.ExecuteSQL("delete from ERPCustomInfo where ID in (" + IDlist + ")") == -1)
        {
            Response.Write("<script>alert('删除选中记录时发生错误！请重新登陆后重试！');</script>");
        }
        else
        {
            DataBindToGridview();
            //写系统日志
            FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
            MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
            MyRiZhi.DoSomething = "用户删除客户信息";
            MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
            MyRiZhi.Add();
        }
    }
    protected void iButton2_Click(object sender, EventArgs e)
    {
        string IDList = "0";
        for (int i = 0; i < GVData.Rows.Count; i++)
        {
            Label LabVis = (Label)GVData.Rows[i].FindControl("LabVisible");
            IDList = IDList + "," + LabVis.Text.ToString();
        }
        Hashtable MyTable = new Hashtable();
        MyTable.Add("CustomName", "客户名称");
        MyTable.Add("CustomSerils", "客户编号");
        MyTable.Add("Address", "单位地址");
        MyTable.Add("UrlLink", "客户单位网站");
        MyTable.Add("FaRenDaiMa", "法人");
        MyTable.Add("ChargeMan", "负责人");
        MyTable.Add("TelStr", "联系电话");
        MyTable.Add("XingZhi", "客户性质");
        MyTable.Add("LaiYuan", "客户来源");
        MyTable.Add("QuYu", "所在区域");
        MyTable.Add("ZhuangTai", "客户状态");
        MyTable.Add("LeiBie", "客户类别");
        MyTable.Add("JiBie", "客户级别");
        MyTable.Add("HangYe", "客户行业");
        MyTable.Add("TimeStr", "创建时间");
        FTD.Unit.DataToExcel.GridViewToExcel(FTD.DBUnit.DbHelperSQL.GetDataSet("select CustomName,CustomSerils,Address,UrlLink,FaRenDaiMa,ChargeMan,TelStr,XingZhi,LaiYuan,QuYu,ZhuangTai,LeiBie,JiBie,HangYe,TimeStr from ERPCustomInfo where ID in (" + IDList + ") order by ID desc"), MyTable, "Excel报表");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //查找目的业务员是否存在
        if (FTD.Unit.PublicMethod.IFExists("UserName", "ERPUser", 0, this.TextBox4.Text) == false)
        {
            string IDlist = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
            if (FTD.DBUnit.DbHelperSQL.ExecuteSQL("update ERPCustomInfo set UserName='" + this.TextBox4.Text.Trim() + "' where ID in (" + IDlist + ")") == -1)
            {
                Response.Write("<script>alert('转移选中客户时发生错误！请重新登陆后重试！');</script>");
            }
            else
            {
                DataBindToGridview();
                //写系统日志
                FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
                MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
                MyRiZhi.DoSomething = "用户转移客户信息";
                MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
                MyRiZhi.Add();
            }
        }
        else
        {
            FTD.Unit.MessageBox.Show(this, "目的业务员不存在，请查证业务员用户名！");
        }
    }
}}