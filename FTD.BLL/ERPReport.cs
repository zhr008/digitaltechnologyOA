using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPReport。
	/// </summary>
	public class ERPReport
	{
		public ERPReport()
		{}
		#region Model
		private int _id;
		private string _reportname;
		private string _reportsql;
		private string _backinfo;
		private int? _typeid;
		private string _userlistok;
		private string _deplistok;
		private string _jiaoselistok;
		private string _paixustr;
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
		/// 报表名称
		/// </summary>
		public string ReportName
		{
			set{ _reportname=value;}
			get{return _reportname;}
		}
		/// <summary>
		/// 报表SQL语句
		/// </summary>
		public string ReportSql
		{
			set{ _reportsql=value;}
			get{return _reportsql;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		/// <summary>
		/// 所属分类ID
		/// </summary>
		public int? TypeID
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 允许使用人
		/// </summary>
		public string UserListOK
		{
			set{ _userlistok=value;}
			get{return _userlistok;}
		}
		/// <summary>
		/// 允许使用部门
		/// </summary>
		public string DepListOK
		{
			set{ _deplistok=value;}
			get{return _deplistok;}
		}
		/// <summary>
		/// 允许使用角色
		/// </summary>
		public string JiaoSeListOK
		{
			set{ _jiaoselistok=value;}
			get{return _jiaoselistok;}
		}
		/// <summary>
		/// 排序字符
		/// </summary>
		public string PaiXuStr
		{
			set{ _paixustr=value;}
			get{return _paixustr;}
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
		public ERPReport(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,ReportName,ReportSql,BackInfo,TypeID,UserListOK,DepListOK,JiaoSeListOK,PaiXuStr,UserName,TimeStr ");
			strSql.Append(" FROM ERPReport ");
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
				ReportName=ds.Tables[0].Rows[0]["ReportName"].ToString();
				ReportSql=ds.Tables[0].Rows[0]["ReportSql"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				if(ds.Tables[0].Rows[0]["TypeID"].ToString()!="")
				{
					TypeID=int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
				}
				UserListOK=ds.Tables[0].Rows[0]["UserListOK"].ToString();
				DepListOK=ds.Tables[0].Rows[0]["DepListOK"].ToString();
				JiaoSeListOK=ds.Tables[0].Rows[0]["JiaoSeListOK"].ToString();
				PaiXuStr=ds.Tables[0].Rows[0]["PaiXuStr"].ToString();
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

		return DbHelperSQL.GetMaxID("ID", "ERPReport"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPReport");
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
			strSql.Append("insert into ERPReport(");
			strSql.Append("ReportName,ReportSql,BackInfo,TypeID,UserListOK,DepListOK,JiaoSeListOK,PaiXuStr,UserName,TimeStr)");
			strSql.Append(" values (");
			strSql.Append("@ReportName,@ReportSql,@BackInfo,@TypeID,@UserListOK,@DepListOK,@JiaoSeListOK,@PaiXuStr,@UserName,@TimeStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ReportName", SqlDbType.VarChar,100),
					new SqlParameter("@ReportSql", SqlDbType.VarChar,8000),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@UserListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@DepListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@JiaoSeListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@PaiXuStr", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = ReportName;
			parameters[1].Value = ReportSql;
			parameters[2].Value = BackInfo;
			parameters[3].Value = TypeID;
			parameters[4].Value = UserListOK;
			parameters[5].Value = DepListOK;
			parameters[6].Value = JiaoSeListOK;
			parameters[7].Value = PaiXuStr;
			parameters[8].Value = UserName;
			parameters[9].Value = TimeStr;

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
			strSql.Append("update ERPReport set ");
			strSql.Append("ReportName=@ReportName,");
			strSql.Append("ReportSql=@ReportSql,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("UserListOK=@UserListOK,");
			strSql.Append("DepListOK=@DepListOK,");
			strSql.Append("JiaoSeListOK=@JiaoSeListOK,");
			strSql.Append("PaiXuStr=@PaiXuStr,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@ReportName", SqlDbType.VarChar,100),
					new SqlParameter("@ReportSql", SqlDbType.VarChar,8000),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@UserListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@DepListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@JiaoSeListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@PaiXuStr", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = ID;
			parameters[1].Value = ReportName;
			parameters[2].Value = ReportSql;
			parameters[3].Value = BackInfo;
			parameters[4].Value = TypeID;
			parameters[5].Value = UserListOK;
			parameters[6].Value = DepListOK;
			parameters[7].Value = JiaoSeListOK;
			parameters[8].Value = PaiXuStr;
			parameters[9].Value = UserName;
			parameters[10].Value = TimeStr;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPReport ");
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
			strSql.Append("select  top 1 ID,ReportName,ReportSql,BackInfo,TypeID,UserListOK,DepListOK,JiaoSeListOK,PaiXuStr,UserName,TimeStr ");
			strSql.Append(" FROM ERPReport ");
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
				ReportName=ds.Tables[0].Rows[0]["ReportName"].ToString();
				ReportSql=ds.Tables[0].Rows[0]["ReportSql"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				if(ds.Tables[0].Rows[0]["TypeID"].ToString()!="")
				{
					TypeID=int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
				}
				UserListOK=ds.Tables[0].Rows[0]["UserListOK"].ToString();
				DepListOK=ds.Tables[0].Rows[0]["DepListOK"].ToString();
				JiaoSeListOK=ds.Tables[0].Rows[0]["JiaoSeListOK"].ToString();
				PaiXuStr=ds.Tables[0].Rows[0]["PaiXuStr"].ToString();
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
			strSql.Append(" FROM ERPReport ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

