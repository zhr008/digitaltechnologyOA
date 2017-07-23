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

namespace OA.aspx.Moa.DocFile{ 
 public partial class JiXiaoView: System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();
			FTD.BLL.ERPJiXiao Model = new FTD.BLL.ERPJiXiao();
			Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
			this.lblJXName.Text=Model.JXName.ToString();
			this.lblJianJie.Text=Model.JianJie.ToString();
			this.lblUserName.Text=Model.UserName.ToString();
			this.lblTimeStr.Text=Model.TimeStr.ToString();
			
			//写系统日志
			FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
			MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
			MyRiZhi.DoSomething = "用户查看绩效考核信息(" + this.lblJXName.Text + ")";
			MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
			MyRiZhi.Add();

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            //获取动态参数项        
            DataSet CanShuDT = FTD.DBUnit.DbHelperSQL.GetDataSet("select ItemName,ID from ERPJiXiaoCanShu order by BackInfo");

            //绑定数据到列表中
            DataSet UserDT = FTD.DBUnit.DbHelperSQL.GetDataSet("select UserName from ERPUser order by UserName asc");

            //合计特殊行
            string HeJiStr = "<tr><td align=center height=30px style=\"background-color: #ffffff\">合计</td><td align=center style=\"background-color: #ffffff\"></td>";

            //生成表格头！！！！！
            Label1.Text = "<table width=100% bgcolor=\"#999999\" border=\"0\" cellpadding=\"2\" cellspacing=\"1\" ><tr><td align=center height=30px style=\"background-color: #ffffff\">序号</td><td align=center style=\"background-color: #ffffff\">用户名</td>";
            for (int i = 0; i < CanShuDT.Tables[0].Rows.Count; i++)
            {
                Label1.Text = Label1.Text + "<td align=center style=\"background-color: #ffffff\">" + CanShuDT.Tables[0].Rows[i]["ItemName"].ToString() + "</td>";
                HeJiStr = HeJiStr + "<td align=center style=\"background-color: #ffffff\">" + GetFenXiangHeJi(i.ToString(), UserDT, CanShuDT) + "</td>";
            }
            Label1.Text = Label1.Text + "<td align=center style=\"background-color: #ffffff\">小计</td></tr>";
            HeJiStr = HeJiStr + "<td align=center style=\"background-color: #ffffff\">" + GetZongTiHeJi(UserDT, CanShuDT) + "</td></tr>";


            //生成数据项
            for (int j = 0; j < UserDT.Tables[0].Rows.Count; j++)
            {
                Label1.Text = Label1.Text + "<tr><td align=center height=30px style=\"background-color: #ffffff\">" + (j + 1).ToString() + "</td>";
                Label1.Text = Label1.Text + "<td align=center height=30px style=\"background-color: #ffffff\">" + UserDT.Tables[0].Rows[j]["UserName"].ToString() + "</td>";

                for (int K = 0; K < CanShuDT.Tables[0].Rows.Count; K++)
                {
                    Label1.Text = Label1.Text + "<td align=center style=\"background-color: #ffffff\"><INPUT readOnly style=\"border:0px\"  value=\"" + FTD.DBUnit.DbHelperSQL.GetSHSL("select top 1 NumStr from ERPJXDetails where JXID=" + Request.QueryString["ID"].ToString() + " and ItemsID=" + CanShuDT.Tables[0].Rows[K]["ID"].ToString() + " and UserName='" + UserDT.Tables[0].Rows[j]["UserName"].ToString() + "'") + "\" id=InP-" + j.ToString() + "-" + K.ToString() + " name=InP-" + UserDT.Tables[0].Rows[j]["UserName"].ToString() + "-" + CanShuDT.Tables[0].Rows[K]["ID"].ToString() + " SIZE=10></td>";
                }
                Label1.Text = Label1.Text + "<td align=center style=\"background-color: #ffffff\">" + GetUserXiaoJi(j.ToString(), UserDT, CanShuDT) + "</td>";
            }
            Label1.Text = Label1.Text + "</tr>";


            Label1.Text = Label1.Text + HeJiStr + "</table>";
		}
	}

    /// <summary>
    /// 返回总体的合计数量
    /// </summary>
    /// <returns></returns>
    public string GetZongTiHeJi(DataSet UserData, DataSet CanShuData)
    {
        string ReturnStr = "<INPUT readOnly  style=\"border:0px\" id=\"ZongJiTongJi\" name=\"ZongJiTongJi\" SIZE=10>";
        string DingYiBianLiang = "";//定义变量的命名，利于下面的相加。
        string ShuZhiAdd = "0";//相加的数值
        for (int j = 0; j < CanShuData.Tables[0].Rows.Count; j++)
        {
            DingYiBianLiang = DingYiBianLiang + "var Item" + j.ToString() + "=0;Item" + j.ToString() + "=document.getElementById(\"FenXiang" + j.ToString() + "\").value/1;";
            ShuZhiAdd = ShuZhiAdd + "+Item" + j.ToString() + "";
        }
        //组合js函数
        ReturnStr = ReturnStr + "<script>function Load_ZongJi(){setTimeout(\"Load_ZongJi()\",5000);" + DingYiBianLiang + "document.getElementById(\"ZongJiTongJi\").value=" + ShuZhiAdd + ";}</script><script>Load_ZongJi();</script>";
        return ReturnStr;
    }

    /// <summary>
    /// 返回分项的合计数量
    /// </summary>
    /// <param name="FenXiangNum">分项在参数中对应的顺序号</param>
    /// <returns></returns>
    public string GetFenXiangHeJi(string FenXiangNum, DataSet UserData, DataSet CanShuData)
    {
        string ReturnStr = "<INPUT readOnly  style=\"border:0px\" id=FenXiang" + FenXiangNum + " name=FenXiang" + FenXiangNum + " SIZE=10>";
        string DingYiBianLiang = "";//定义变量的命名，利于下面的相加。
        string ShuZhiAdd = "0";//相加的数值
        for (int j = 0; j < UserData.Tables[0].Rows.Count; j++)
        {
            //InP-" + j.ToString() + "-" + K.ToString() + "
            DingYiBianLiang = DingYiBianLiang + "var Item" + j.ToString() + "=0;Item" + j.ToString() + "=document.getElementById(\"InP-" + j.ToString() + "-" + FenXiangNum + "\").value/1;";
            ShuZhiAdd = ShuZhiAdd + "+Item" + j.ToString() + "";
        }
        //组合js函数
        ReturnStr = ReturnStr + "<script>function Load_DoFenXiang" + FenXiangNum + "(){setTimeout(\"Load_DoFenXiang" + FenXiangNum + "()\",5000);" + DingYiBianLiang + "document.getElementById(\"FenXiang" + FenXiangNum + "\").value=" + ShuZhiAdd + ";}</script><script>Load_DoFenXiang" + FenXiangNum + "();</script>";
        return ReturnStr;
    }

    /// <summary>
    /// 返回一行的小计数量
    /// </summary>
    /// <param name="UserNum">用户在Data中对应的顺序号</param>
    /// <returns></returns>
    public string GetUserXiaoJi(string UserNum, DataSet UserData, DataSet CanShuData)
    {
        string ReturnStr = "<INPUT readOnly  style=\"border:0px\" id=XiaoJi" + UserNum + " name=XiaoJi" + UserNum + " SIZE=10>";
        string DingYiBianLiang = "";//定义变量的命名，利于下面的相加。
        string ShuZhiAdd = "0";//相加的数值
        for (int j = 0; j < CanShuData.Tables[0].Rows.Count; j++)
        {
            //InP-" + j.ToString() + "-" + K.ToString() + "
            DingYiBianLiang = DingYiBianLiang + "var Item" + j.ToString() + "=0;Item" + j.ToString() + "=document.getElementById(\"InP-" + UserNum.ToString() + "-" + j.ToString() + "\").value/1;";
            ShuZhiAdd = ShuZhiAdd + "+Item" + j.ToString() + "";
        }
        //组合js函数
        ReturnStr = ReturnStr + "<script>function Load_DoXiaoJi" + UserNum + "(){setTimeout(\"Load_DoXiaoJi" + UserNum + "()\",5000);" + DingYiBianLiang + "document.getElementById(\"XiaoJi" + UserNum + "\").value=" + ShuZhiAdd + ";}</script><script>Load_DoXiaoJi" + UserNum + "();</script>";
        return ReturnStr;
    }
}
}