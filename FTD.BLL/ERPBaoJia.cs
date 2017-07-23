using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPBaoJia。
	/// </summary>
	public class ERPBaoJia
	{
		public ERPBaoJia()
		{}
		#region Model
		private int _id;
		private string _customname;
		private string _baojiatitle;
		private string _baojiatype;
		private string _baojiajine;
		private string _baojiacontent;
		private string _baojiaresult;
		private string _baojiatime;
		private string _backinfo;
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
		public string BaoJiaTitle
		{
			set{ _baojiatitle=value;}
			get{return _baojiatitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BaoJiaType
		{
			set{ _baojiatype=value;}
			get{return _baojiatype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BaoJiaJinE
		{
			set{ _baojiajine=value;}
			get{return _baojiajine;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BaoJiaContent
		{
			set{ _baojiacontent=value;}
			get{return _baojiacontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BaoJiaResult
		{
			set{ _baojiaresult=value;}
			get{return _baojiaresult;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BaoJiaTime
		{
			set{ _baojiatime=value;}
			get{return _baojiatime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
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
		public ERPBaoJia(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CustomName,BaoJiaTitle,BaoJiaType,BaoJiaJinE,BaoJiaContent,BaoJiaResult,BaoJiaTime,BackInfo,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE ");
			strSql.Append(" FROM ERPBaoJia ");
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
				BaoJiaTitle=ds.Tables[0].Rows[0]["BaoJiaTitle"].ToString();
				BaoJiaType=ds.Tables[0].Rows[0]["BaoJiaType"].ToString();
				BaoJiaJinE=ds.Tables[0].Rows[0]["BaoJiaJinE"].ToString();
				BaoJiaContent=ds.Tables[0].Rows[0]["BaoJiaContent"].ToString();
				BaoJiaResult=ds.Tables[0].Rows[0]["BaoJiaResult"].ToString();
				BaoJiaTime=ds.Tables[0].Rows[0]["BaoJiaTime"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
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

		return DbHelperSQL.GetMaxID("ID", "ERPBaoJia"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPBaoJia");
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
			strSql.Append("insert into ERPBaoJia(");
			strSql.Append("CustomName,BaoJiaTitle,BaoJiaType,BaoJiaJinE,BaoJiaContent,BaoJiaResult,BaoJiaTime,BackInfo,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE)");
			strSql.Append(" values (");
			strSql.Append("@CustomName,@BaoJiaTitle,@BaoJiaType,@BaoJiaJinE,@BaoJiaContent,@BaoJiaResult,@BaoJiaTime,@BackInfo,@UserName,@TimeStr,@IFShare,@CusBakA,@CusBakB,@CusBakC,@CusBakD,@CusBakE)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomName", SqlDbType.VarChar,100),
					new SqlParameter("@BaoJiaTitle", SqlDbType.VarChar,500),
					new SqlParameter("@BaoJiaType", SqlDbType.VarChar,500),
					new SqlParameter("@BaoJiaJinE", SqlDbType.VarChar,500),
					new SqlParameter("@BaoJiaContent", SqlDbType.VarChar,8000),
					new SqlParameter("@BaoJiaResult", SqlDbType.VarChar,5000),
					new SqlParameter("@BaoJiaTime", SqlDbType.VarChar,500),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,8000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@IFShare", SqlDbType.VarChar,5000),
					new SqlParameter("@CusBakA", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakB", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakC", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakD", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakE", SqlDbType.VarChar,8000)};
			parameters[0].Value = CustomName;
			parameters[1].Value = BaoJiaTitle;
			parameters[2].Value = BaoJiaType;
			parameters[3].Value = BaoJiaJinE;
			parameters[4].Value = BaoJiaContent;
			parameters[5].Value = BaoJiaResult;
			parameters[6].Value = BaoJiaTime;
			parameters[7].Value = BackInfo;
			parameters[8].Value = UserName;
			parameters[9].Value = TimeStr;
			parameters[10].Value = IFShare;
			parameters[11].Value = CusBakA;
			parameters[12].Value = CusBakB;
			parameters[13].Value = CusBakC;
			parameters[14].Value = CusBakD;
			parameters[15].Value = CusBakE;

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
			strSql.Append("update ERPBaoJia set ");
			strSql.Append("CustomName=@CustomName,");
			strSql.Append("BaoJiaTitle=@BaoJiaTitle,");
			strSql.Append("BaoJiaType=@BaoJiaType,");
			strSql.Append("BaoJiaJinE=@BaoJiaJinE,");
			strSql.Append("BaoJiaContent=@BaoJiaContent,");
			strSql.Append("BaoJiaResult=@BaoJiaResult,");
			strSql.Append("BaoJiaTime=@BaoJiaTime,");
			strSql.Append("BackInfo=@BackInfo,");
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
					new SqlParameter("@BaoJiaTitle", SqlDbType.VarChar,500),
					new SqlParameter("@BaoJiaType", SqlDbType.VarChar,500),
					new SqlParameter("@BaoJiaJinE", SqlDbType.VarChar,500),
					new SqlParameter("@BaoJiaContent", SqlDbType.VarChar,8000),
					new SqlParameter("@BaoJiaResult", SqlDbType.VarChar,5000),
					new SqlParameter("@BaoJiaTime", SqlDbType.VarChar,500),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,8000),
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
			parameters[2].Value = BaoJiaTitle;
			parameters[3].Value = BaoJiaType;
			parameters[4].Value = BaoJiaJinE;
			parameters[5].Value = BaoJiaContent;
			parameters[6].Value = BaoJiaResult;
			parameters[7].Value = BaoJiaTime;
			parameters[8].Value = BackInfo;
			parameters[9].Value = UserName;
			parameters[10].Value = TimeStr;
			parameters[11].Value = IFShare;
			parameters[12].Value = CusBakA;
			parameters[13].Value = CusBakB;
			parameters[14].Value = CusBakC;
			parameters[15].Value = CusBakD;
			parameters[16].Value = CusBakE;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete ERPBaoJia ");
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
			strSql.Append("select ID,CustomName,BaoJiaTitle,BaoJiaType,BaoJiaJinE,BaoJiaContent,BaoJiaResult,BaoJiaTime,BackInfo,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE ");
			strSql.Append(" FROM ERPBaoJia ");
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
				BaoJiaTitle=ds.Tables[0].Rows[0]["BaoJiaTitle"].ToString();
				BaoJiaType=ds.Tables[0].Rows[0]["BaoJiaType"].ToString();
				BaoJiaJinE=ds.Tables[0].Rows[0]["BaoJiaJinE"].ToString();
				BaoJiaContent=ds.Tables[0].Rows[0]["BaoJiaContent"].ToString();
				BaoJiaResult=ds.Tables[0].Rows[0]["BaoJiaResult"].ToString();
				BaoJiaTime=ds.Tables[0].Rows[0]["BaoJiaTime"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
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
			strSql.Append("select [ID],[CustomName],[BaoJiaTitle],[BaoJiaType],[BaoJiaJinE],[BaoJiaContent],[BaoJiaResult],[BaoJiaTime],[BackInfo],[UserName],[TimeStr],[IFShare],[CusBakA],[CusBakB],[CusBakC],[CusBakD],[CusBakE] ");
			strSql.Append(" FROM ERPBaoJia ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

