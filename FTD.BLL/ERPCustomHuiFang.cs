using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPCustomHuiFang。
	/// </summary>
	public class ERPCustomHuiFang
	{
		public ERPCustomHuiFang()
		{}
		#region Model
		private int _id;
		private string _customname;
		private string _huifangtitle;
		private string _huifangtype;
		private string _huifangresult;
		private string _huifangtime;
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
		public string HuiFangTitle
		{
			set{ _huifangtitle=value;}
			get{return _huifangtitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HuiFangType
		{
			set{ _huifangtype=value;}
			get{return _huifangtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HuiFangResult
		{
			set{ _huifangresult=value;}
			get{return _huifangresult;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HuiFangTime
		{
			set{ _huifangtime=value;}
			get{return _huifangtime;}
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
		public ERPCustomHuiFang(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CustomName,HuiFangTitle,HuiFangType,HuiFangResult,HuiFangTime,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE ");
			strSql.Append(" FROM ERPCustomHuiFang ");
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
				HuiFangTitle=ds.Tables[0].Rows[0]["HuiFangTitle"].ToString();
				HuiFangType=ds.Tables[0].Rows[0]["HuiFangType"].ToString();
				HuiFangResult=ds.Tables[0].Rows[0]["HuiFangResult"].ToString();
				HuiFangTime=ds.Tables[0].Rows[0]["HuiFangTime"].ToString();
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

		return DbHelperSQL.GetMaxID("ID", "ERPCustomHuiFang"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPCustomHuiFang");
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
			strSql.Append("insert into ERPCustomHuiFang(");
			strSql.Append("CustomName,HuiFangTitle,HuiFangType,HuiFangResult,HuiFangTime,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE)");
			strSql.Append(" values (");
			strSql.Append("@CustomName,@HuiFangTitle,@HuiFangType,@HuiFangResult,@HuiFangTime,@UserName,@TimeStr,@IFShare,@CusBakA,@CusBakB,@CusBakC,@CusBakD,@CusBakE)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomName", SqlDbType.VarChar,100),
					new SqlParameter("@HuiFangTitle", SqlDbType.VarChar,500),
					new SqlParameter("@HuiFangType", SqlDbType.VarChar,500),
					new SqlParameter("@HuiFangResult", SqlDbType.VarChar,5000),
					new SqlParameter("@HuiFangTime", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@IFShare", SqlDbType.VarChar,5000),
					new SqlParameter("@CusBakA", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakB", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakC", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakD", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakE", SqlDbType.VarChar,8000)};
			parameters[0].Value = CustomName;
			parameters[1].Value = HuiFangTitle;
			parameters[2].Value = HuiFangType;
			parameters[3].Value = HuiFangResult;
			parameters[4].Value = HuiFangTime;
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
			strSql.Append("update ERPCustomHuiFang set ");
			strSql.Append("CustomName=@CustomName,");
			strSql.Append("HuiFangTitle=@HuiFangTitle,");
			strSql.Append("HuiFangType=@HuiFangType,");
			strSql.Append("HuiFangResult=@HuiFangResult,");
			strSql.Append("HuiFangTime=@HuiFangTime,");
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
					new SqlParameter("@HuiFangTitle", SqlDbType.VarChar,500),
					new SqlParameter("@HuiFangType", SqlDbType.VarChar,500),
					new SqlParameter("@HuiFangResult", SqlDbType.VarChar,5000),
					new SqlParameter("@HuiFangTime", SqlDbType.VarChar,500),
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
			parameters[2].Value = HuiFangTitle;
			parameters[3].Value = HuiFangType;
			parameters[4].Value = HuiFangResult;
			parameters[5].Value = HuiFangTime;
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
			strSql.Append("delete ERPCustomHuiFang ");
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
			strSql.Append("select ID,CustomName,HuiFangTitle,HuiFangType,HuiFangResult,HuiFangTime,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE ");
			strSql.Append(" FROM ERPCustomHuiFang ");
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
				HuiFangTitle=ds.Tables[0].Rows[0]["HuiFangTitle"].ToString();
				HuiFangType=ds.Tables[0].Rows[0]["HuiFangType"].ToString();
				HuiFangResult=ds.Tables[0].Rows[0]["HuiFangResult"].ToString();
				HuiFangTime=ds.Tables[0].Rows[0]["HuiFangTime"].ToString();
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
			strSql.Append("select [ID],[CustomName],[HuiFangTitle],[HuiFangType],[HuiFangResult],[HuiFangTime],[UserName],[TimeStr],[IFShare],[CusBakA],[CusBakB],[CusBakC],[CusBakD],[CusBakE] ");
			strSql.Append(" FROM ERPCustomHuiFang ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

