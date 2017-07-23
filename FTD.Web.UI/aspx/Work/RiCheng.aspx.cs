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
using System.Data.SqlClient;

namespace OA.aspx.Work{ 
 public partial class RiCheng: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FTD.Unit.PublicMethod.CheckSession();
            DataBindToGridview();
            this.Calendar1.SelectedDate = DateTime.Now.Date;

            //设定按钮权限            
            iButton1.Visible = FTD.Unit.PublicMethod.StrIFIn("|006A|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
            iButton5.Visible = FTD.Unit.PublicMethod.StrIFIn("|006M|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
            iButton3.Visible = FTD.Unit.PublicMethod.StrIFIn("|006D|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
            iButton2.Visible = FTD.Unit.PublicMethod.StrIFIn("|006E|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
        }
    }
    public void DataBindToGridview()
    {
        FTD.BLL.ERPAnPai MyModel = new FTD.BLL.ERPAnPai();
        GVData.DataSource = MyModel.GetList("TitleStr Like '%" + this.TextBox1.Text + "%' and UserName='"+FTD.Unit.PublicMethod.GetSessionValue("UserName")+"' order by ID desc");
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
    protected void iButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("RiChengAdd.aspx");
    }
    protected void iButton3_Click(object sender, EventArgs e)
    {
        string IDlist = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
        if (FTD.DBUnit.DbHelperSQL.ExecuteSQL("delete from ERPAnPai where ID in (" + IDlist + ")") == -1)
        {
            Response.Write("<script>alert('删除选中记录时发生错误！请重新登陆后重试！');</script>");
        }
        else
        {
            DataBindToGridview();
            //写系统日志
            FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
            MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
            MyRiZhi.DoSomething = "用户删除日程安排信息";
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
        MyTable.Add("TitleStr", "主题");
        MyTable.Add("TypeStr", "类型");
        MyTable.Add("TimeStart", "开始时间");
        MyTable.Add("TimeEnd", "结束时间");
        MyTable.Add("TimeTiXing", "提醒时间");

        FTD.Unit.DataToExcel.GridViewToExcel(FTD.DBUnit.DbHelperSQL.GetDataSet("select TitleStr,TypeStr,TimeStart,TimeEnd,TimeTiXing from ERPAnPai where ID in (" + IDList + ") order by ID desc"), MyTable, "Excel报表");
    }
    protected void iButton5_Click(object sender, EventArgs e)
    {
        string CheckStr = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
        string[] CheckStrArray = CheckStr.Split(',');
        Response.Redirect("RiChengModify.aspx?ID=" + CheckStrArray[0].ToString());
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (this.LinkButton1.Text == "列表显示模式")
        {
            this.Panel1.Visible = true;
            this.Panel2.Visible = false;
            this.LinkButton1.Text = "日历显示模式";
        }
        else
        {
            this.Panel1.Visible = false;
            this.Panel2.Visible = true;
            this.LinkButton1.Text = "列表显示模式";
        }
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

    }
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        DataSet MYDT = FTD.DBUnit.DbHelperSQL.GetDataSet("select TitleStr,ID,GongXiangWho from ERPAnPai where datediff(day,TimeStart,'" + e.Day.Date.ToString() + "')=0 and UserName='" + FTD.Unit.PublicMethod.GetSessionValue("UserName") + "'");
        for (int i = 0; i < MYDT.Tables[0].Rows.Count; i++)
        {
            e.Cell.BackColor = System.Drawing.Color.AntiqueWhite;
            e.Cell.ToolTip = MYDT.Tables[0].Rows[i]["TitleStr"].ToString();
            Label MyContent = new Label();
            MyContent.Text = "<BR><a href=\"RiChengView.aspx?ID=" + MYDT.Tables[0].Rows[i]["ID"].ToString() + " \">" + MYDT.Tables[0].Rows[i]["TitleStr"].ToString() + "【" + MYDT.Tables[0].Rows[i]["GongXiangWho"].ToString() + "】</a>";
            MyContent.ForeColor = System.Drawing.Color.White;
            e.Cell.Controls.Add(MyContent);
        }        
    }
}}