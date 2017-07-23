using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPPeiXunRiJi。
	/// </summary>
	public class ERPPeiXunRiJi
	{
		public ERPPeiXunRiJi()
		{}
		#region Model
		private int _id;
		private string _peixunname;
		private string _rijititle;
		private string _rijidate;
		private string _rijicontent;
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
		/// 培训名称
		/// </summary>
		public string PeiXunName
		{
			set{ _peixunname=value;}
			get{return _peixunname;}
		}
		/// <summary>
		/// 日志主题
		/// </summary>
		public string RiJiTitle
		{
			set{ _rijititle=value;}
			get{return _rijititle;}
		}
		/// <summary>
		/// 日志日期
		/// </summary>
		public string RiJiDate
		{
			set{ _rijidate=value;}
			get{return _rijidate;}
		}
		/// <summary>
		/// 日志内容
		/// </summary>
		public string RiJiContent
		{
			set{ _rijicontent=value;}
			get{return _rijicontent;}
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
		public ERPPeiXunRiJi(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,PeiXunName,RiJiTitle,RiJiDate,RiJiContent,UserName,TimeStr ");
			strSql.Append(" FROM ERPPeiXunRiJi ");
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
				PeiXunName=ds.Tables[0].Rows[0]["PeiXunName"].ToString();
				RiJiTitle=ds.Tables[0].Rows[0]["RiJiTitle"].ToString();
				RiJiDate=ds.Tables[0].Rows[0]["RiJiDate"].ToString();
				RiJiContent=ds.Tables[0].Rows[0]["RiJiContent"].ToString();
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

		return DbHelperSQL.GetMaxID("ID", "ERPPeiXunRiJi"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPPeiXunRiJi");
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
			strSql.Append("insert into ERPPeiXunRiJi(");
			strSql.Append("PeiXunName,RiJiTitle,RiJiDate,RiJiContent,UserName,TimeStr)");
			strSql.Append(" values (");
			strSql.Append("@PeiXunName,@RiJiTitle,@RiJiDate,@RiJiContent,@UserName,@TimeStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@PeiXunName", SqlDbType.VarChar,50),
					new SqlParameter("@RiJiTitle", SqlDbType.VarChar,50),
					new SqlParameter("@RiJiDate", SqlDbType.VarChar,50),
					new SqlParameter("@RiJiContent", SqlDbType.Text),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = PeiXunName;
			parameters[1].Value = RiJiTitle;
			parameters[2].Value = RiJiDate;
			parameters[3].Value = RiJiContent;
			parameters[4].Value = UserName;
			parameters[5].Value = TimeStr;

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
			strSql.Append("update ERPPeiXunRiJi set ");
			strSql.Append("PeiXunName=@PeiXunName,");
			strSql.Append("RiJiTitle=@RiJiTitle,");
			strSql.Append("RiJiDate=@RiJiDate,");
			strSql.Append("RiJiContent=@RiJiContent,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@PeiXunName", SqlDbType.VarChar,50),
					new SqlParameter("@RiJiTitle", SqlDbType.VarChar,50),
					new SqlParameter("@RiJiDate", SqlDbType.VarChar,50),
					new SqlParameter("@RiJiContent", SqlDbType.Text),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = ID;
			parameters[1].Value = PeiXunName;
			parameters[2].Value = RiJiTitle;
			parameters[3].Value = RiJiDate;
			parameters[4].Value = RiJiContent;
			parameters[5].Value = UserName;
			parameters[6].Value = TimeStr;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPPeiXunRiJi ");
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
			strSql.Append("select  top 1 ID,PeiXunName,RiJiTitle,RiJiDate,RiJiContent,UserName,TimeStr ");
			strSql.Append(" FROM ERPPeiXunRiJi ");
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
				PeiXunName=ds.Tables[0].Rows[0]["PeiXunName"].ToString();
				RiJiTitle=ds.Tables[0].Rows[0]["RiJiTitle"].ToString();
				RiJiDate=ds.Tables[0].Rows[0]["RiJiDate"].ToString();
				RiJiContent=ds.Tables[0].Rows[0]["RiJiContent"].ToString();
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
			strSql.Append(" FROM ERPPeiXunRiJi ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

