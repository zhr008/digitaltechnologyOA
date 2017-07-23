using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPJianLi。
	/// </summary>
	public class ERPJianLi
	{
		public ERPJianLi()
		{}
		#region Model
		private int _id;
		private string _ypname;
		private string _ypdate;
		private string _ypsex;
		private string _ypage;
		private string _xueli;
		private string _zhuanye;
		private string _ypzhiwei;
		private string _ypjieguo;
		private string _backinfo;
		private string _fujianstr;
		private string _username;
		private DateTime? _timestr;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 应聘人姓名
		/// </summary>
		public string YPName
		{
			set{ _ypname=value;}
			get{return _ypname;}
		}
		/// <summary>
		/// 应聘日期
		/// </summary>
		public string YPDate
		{
			set{ _ypdate=value;}
			get{return _ypdate;}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public string YPSex
		{
			set{ _ypsex=value;}
			get{return _ypsex;}
		}
		/// <summary>
		/// 年龄
		/// </summary>
		public string YPAge
		{
			set{ _ypage=value;}
			get{return _ypage;}
		}
		/// <summary>
		/// 学历
		/// </summary>
		public string XueLi
		{
			set{ _xueli=value;}
			get{return _xueli;}
		}
		/// <summary>
		/// 专业
		/// </summary>
		public string ZhuanYe
		{
			set{ _zhuanye=value;}
			get{return _zhuanye;}
		}
		/// <summary>
		/// 应聘职位
		/// </summary>
		public string YPZhiWei
		{
			set{ _ypzhiwei=value;}
			get{return _ypzhiwei;}
		}
		/// <summary>
		/// 应聘结果
		/// </summary>
		public string YPJieGuo
		{
			set{ _ypjieguo=value;}
			get{return _ypjieguo;}
		}
		/// <summary>
		/// 备注说明
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		/// <summary>
		/// 个人简历
		/// </summary>
		public string FuJianStr
		{
			set{ _fujianstr=value;}
			get{return _fujianstr;}
		}
		/// <summary>
		/// 录入人
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 录入时间
		/// </summary>
		public DateTime? TimeStr
		{
			set{ _timestr=value;}
			get{return _timestr;}
		}
		#endregion Model


		#region  成员方法

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPJianLi(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,YPName,YPDate,YPSex,YPAge,XueLi,ZhuanYe,YPZhiWei,YPJieGuo,BackInfo,FuJianStr,UserName,TimeStr ");
			strSql.Append(" FROM ERPJianLi ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				YPName=ds.Tables[0].Rows[0]["YPName"].ToString();
				YPDate=ds.Tables[0].Rows[0]["YPDate"].ToString();
				YPSex=ds.Tables[0].Rows[0]["YPSex"].ToString();
				YPAge=ds.Tables[0].Rows[0]["YPAge"].ToString();
				XueLi=ds.Tables[0].Rows[0]["XueLi"].ToString();
				ZhuanYe=ds.Tables[0].Rows[0]["ZhuanYe"].ToString();
				YPZhiWei=ds.Tables[0].Rows[0]["YPZhiWei"].ToString();
				YPJieGuo=ds.Tables[0].Rows[0]["YPJieGuo"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				FuJianStr=ds.Tables[0].Rows[0]["FuJianStr"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPJianLi"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPJianLi");
			strSql.Append(" where ID=@ID ");

			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ERPJianLi(");
			strSql.Append("YPName,YPDate,YPSex,YPAge,XueLi,ZhuanYe,YPZhiWei,YPJieGuo,BackInfo,FuJianStr,UserName,TimeStr)");
			strSql.Append(" values (");
			strSql.Append("@YPName,@YPDate,@YPSex,@YPAge,@XueLi,@ZhuanYe,@YPZhiWei,@YPJieGuo,@BackInfo,@FuJianStr,@UserName,@TimeStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@YPName", SqlDbType.VarChar,50),
					new SqlParameter("@YPDate", SqlDbType.VarChar,50),
					new SqlParameter("@YPSex", SqlDbType.VarChar,50),
					new SqlParameter("@YPAge", SqlDbType.VarChar,50),
					new SqlParameter("@XueLi", SqlDbType.VarChar,50),
					new SqlParameter("@ZhuanYe", SqlDbType.VarChar,50),
					new SqlParameter("@YPZhiWei", SqlDbType.VarChar,50),
					new SqlParameter("@YPJieGuo", SqlDbType.VarChar,100),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@FuJianStr", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = YPName;
			parameters[1].Value = YPDate;
			parameters[2].Value = YPSex;
			parameters[3].Value = YPAge;
			parameters[4].Value = XueLi;
			parameters[5].Value = ZhuanYe;
			parameters[6].Value = YPZhiWei;
			parameters[7].Value = YPJieGuo;
			parameters[8].Value = BackInfo;
			parameters[9].Value = FuJianStr;
			parameters[10].Value = UserName;
			parameters[11].Value = TimeStr;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 1;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ERPJianLi set ");
			strSql.Append("YPName=@YPName,");
			strSql.Append("YPDate=@YPDate,");
			strSql.Append("YPSex=@YPSex,");
			strSql.Append("YPAge=@YPAge,");
			strSql.Append("XueLi=@XueLi,");
			strSql.Append("ZhuanYe=@ZhuanYe,");
			strSql.Append("YPZhiWei=@YPZhiWei,");
			strSql.Append("YPJieGuo=@YPJieGuo,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append("FuJianStr=@FuJianStr,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@YPName", SqlDbType.VarChar,50),
					new SqlParameter("@YPDate", SqlDbType.VarChar,50),
					new SqlParameter("@YPSex", SqlDbType.VarChar,50),
					new SqlParameter("@YPAge", SqlDbType.VarChar,50),
					new SqlParameter("@XueLi", SqlDbType.VarChar,50),
					new SqlParameter("@ZhuanYe", SqlDbType.VarChar,50),
					new SqlParameter("@YPZhiWei", SqlDbType.VarChar,50),
					new SqlParameter("@YPJieGuo", SqlDbType.VarChar,100),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@FuJianStr", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = ID;
			parameters[1].Value = YPName;
			parameters[2].Value = YPDate;
			parameters[3].Value = YPSex;
			parameters[4].Value = YPAge;
			parameters[5].Value = XueLi;
			parameters[6].Value = ZhuanYe;
			parameters[7].Value = YPZhiWei;
			parameters[8].Value = YPJieGuo;
			parameters[9].Value = BackInfo;
			parameters[10].Value = FuJianStr;
			parameters[11].Value = UserName;
			parameters[12].Value = TimeStr;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPJianLi ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public void GetModel(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,YPName,YPDate,YPSex,YPAge,XueLi,ZhuanYe,YPZhiWei,YPJieGuo,BackInfo,FuJianStr,UserName,TimeStr ");
			strSql.Append(" FROM ERPJianLi ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				YPName=ds.Tables[0].Rows[0]["YPName"].ToString();
				YPDate=ds.Tables[0].Rows[0]["YPDate"].ToString();
				YPSex=ds.Tables[0].Rows[0]["YPSex"].ToString();
				YPAge=ds.Tables[0].Rows[0]["YPAge"].ToString();
				XueLi=ds.Tables[0].Rows[0]["XueLi"].ToString();
				ZhuanYe=ds.Tables[0].Rows[0]["ZhuanYe"].ToString();
				YPZhiWei=ds.Tables[0].Rows[0]["YPZhiWei"].ToString();
				YPJieGuo=ds.Tables[0].Rows[0]["YPJieGuo"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				FuJianStr=ds.Tables[0].Rows[0]["FuJianStr"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPJianLi ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

