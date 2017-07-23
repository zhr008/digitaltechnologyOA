using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPLinkLog。
	/// </summary>
	public class ERPLinkLog
	{
		public ERPLinkLog()
		{}
		#region Model
		private int _id;
		private string _customname;
		private string _linktitle;
		private string _linktype;
		private string _linkresult;
		private string _linktime;
		private string _username;
		private DateTime? _timestr;
		private string _ifshare;
		private string _cusbaka;
		private string _cusbakb;
		private string _cusbakc;
		private string _cusbakd;
		private string _cusbake;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomName
		{
			set{ _customname=value;}
			get{return _customname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LinkTitle
		{
			set{ _linktitle=value;}
			get{return _linktitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LinkType
		{
			set{ _linktype=value;}
			get{return _linktype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LinkResult
		{
			set{ _linkresult=value;}
			get{return _linkresult;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LinkTime
		{
			set{ _linktime=value;}
			get{return _linktime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TimeStr
		{
			set{ _timestr=value;}
			get{return _timestr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IFShare
		{
			set{ _ifshare=value;}
			get{return _ifshare;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusBakA
		{
			set{ _cusbaka=value;}
			get{return _cusbaka;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusBakB
		{
			set{ _cusbakb=value;}
			get{return _cusbakb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusBakC
		{
			set{ _cusbakc=value;}
			get{return _cusbakc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusBakD
		{
			set{ _cusbakd=value;}
			get{return _cusbakd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusBakE
		{
			set{ _cusbake=value;}
			get{return _cusbake;}
		}
		#endregion Model


		#region  成员方法

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPLinkLog(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CustomName,LinkTitle,LinkType,LinkResult,LinkTime,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE ");
			strSql.Append(" FROM ERPLinkLog ");
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
				CustomName=ds.Tables[0].Rows[0]["CustomName"].ToString();
				LinkTitle=ds.Tables[0].Rows[0]["LinkTitle"].ToString();
				LinkType=ds.Tables[0].Rows[0]["LinkType"].ToString();
				LinkResult=ds.Tables[0].Rows[0]["LinkResult"].ToString();
				LinkTime=ds.Tables[0].Rows[0]["LinkTime"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				IFShare=ds.Tables[0].Rows[0]["IFShare"].ToString();
				CusBakA=ds.Tables[0].Rows[0]["CusBakA"].ToString();
				CusBakB=ds.Tables[0].Rows[0]["CusBakB"].ToString();
				CusBakC=ds.Tables[0].Rows[0]["CusBakC"].ToString();
				CusBakD=ds.Tables[0].Rows[0]["CusBakD"].ToString();
				CusBakE=ds.Tables[0].Rows[0]["CusBakE"].ToString();
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPLinkLog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPLinkLog");
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
			strSql.Append("insert into ERPLinkLog(");
			strSql.Append("CustomName,LinkTitle,LinkType,LinkResult,LinkTime,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE)");
			strSql.Append(" values (");
			strSql.Append("@CustomName,@LinkTitle,@LinkType,@LinkResult,@LinkTime,@UserName,@TimeStr,@IFShare,@CusBakA,@CusBakB,@CusBakC,@CusBakD,@CusBakE)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomName", SqlDbType.VarChar,100),
					new SqlParameter("@LinkTitle", SqlDbType.VarChar,500),
					new SqlParameter("@LinkType", SqlDbType.VarChar,500),
					new SqlParameter("@LinkResult", SqlDbType.VarChar,5000),
					new SqlParameter("@LinkTime", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@IFShare", SqlDbType.VarChar,5000),
					new SqlParameter("@CusBakA", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakB", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakC", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakD", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakE", SqlDbType.VarChar,8000)};
			parameters[0].Value = CustomName;
			parameters[1].Value = LinkTitle;
			parameters[2].Value = LinkType;
			parameters[3].Value = LinkResult;
			parameters[4].Value = LinkTime;
			parameters[5].Value = UserName;
			parameters[6].Value = TimeStr;
			parameters[7].Value = IFShare;
			parameters[8].Value = CusBakA;
			parameters[9].Value = CusBakB;
			parameters[10].Value = CusBakC;
			parameters[11].Value = CusBakD;
			parameters[12].Value = CusBakE;

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
			strSql.Append("update ERPLinkLog set ");
			strSql.Append("CustomName=@CustomName,");
			strSql.Append("LinkTitle=@LinkTitle,");
			strSql.Append("LinkType=@LinkType,");
			strSql.Append("LinkResult=@LinkResult,");
			strSql.Append("LinkTime=@LinkTime,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr,");
			strSql.Append("IFShare=@IFShare,");
			strSql.Append("CusBakA=@CusBakA,");
			strSql.Append("CusBakB=@CusBakB,");
			strSql.Append("CusBakC=@CusBakC,");
			strSql.Append("CusBakD=@CusBakD,");
			strSql.Append("CusBakE=@CusBakE");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@CustomName", SqlDbType.VarChar,100),
					new SqlParameter("@LinkTitle", SqlDbType.VarChar,500),
					new SqlParameter("@LinkType", SqlDbType.VarChar,500),
					new SqlParameter("@LinkResult", SqlDbType.VarChar,5000),
					new SqlParameter("@LinkTime", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@IFShare", SqlDbType.VarChar,5000),
					new SqlParameter("@CusBakA", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakB", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakC", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakD", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakE", SqlDbType.VarChar,8000)};
			parameters[0].Value = ID;
			parameters[1].Value = CustomName;
			parameters[2].Value = LinkTitle;
			parameters[3].Value = LinkType;
			parameters[4].Value = LinkResult;
			parameters[5].Value = LinkTime;
			parameters[6].Value = UserName;
			parameters[7].Value = TimeStr;
			parameters[8].Value = IFShare;
			parameters[9].Value = CusBakA;
			parameters[10].Value = CusBakB;
			parameters[11].Value = CusBakC;
			parameters[12].Value = CusBakD;
			parameters[13].Value = CusBakE;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete ERPLinkLog ");
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
			strSql.Append("select ID,CustomName,LinkTitle,LinkType,LinkResult,LinkTime,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE ");
			strSql.Append(" FROM ERPLinkLog ");
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
				CustomName=ds.Tables[0].Rows[0]["CustomName"].ToString();
				LinkTitle=ds.Tables[0].Rows[0]["LinkTitle"].ToString();
				LinkType=ds.Tables[0].Rows[0]["LinkType"].ToString();
				LinkResult=ds.Tables[0].Rows[0]["LinkResult"].ToString();
				LinkTime=ds.Tables[0].Rows[0]["LinkTime"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				IFShare=ds.Tables[0].Rows[0]["IFShare"].ToString();
				CusBakA=ds.Tables[0].Rows[0]["CusBakA"].ToString();
				CusBakB=ds.Tables[0].Rows[0]["CusBakB"].ToString();
				CusBakC=ds.Tables[0].Rows[0]["CusBakC"].ToString();
				CusBakD=ds.Tables[0].Rows[0]["CusBakD"].ToString();
				CusBakE=ds.Tables[0].Rows[0]["CusBakE"].ToString();
			}
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select [ID],[CustomName],[LinkTitle],[LinkType],[LinkResult],[LinkTime],[UserName],[TimeStr],[IFShare],[CusBakA],[CusBakB],[CusBakC],[CusBakD],[CusBakE] ");
			strSql.Append(" FROM ERPLinkLog ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

