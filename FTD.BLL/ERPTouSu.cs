using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
	/// <summary>
	/// ��ERPTouSu��
	/// </summary>
	public class ERPTouSu
	{
		public ERPTouSu()
		{}
		#region Model
		private int _id;
		private string _customname;
		private string _tousuwho;
		private string _tousutype;
		private string _chuliresult;
		private string _tousutime;
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
		public string TouSuWho
		{
			set{ _tousuwho=value;}
			get{return _tousuwho;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TouSuType
		{
			set{ _tousutype=value;}
			get{return _tousutype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChuLiResult
		{
			set{ _chuliresult=value;}
			get{return _chuliresult;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TouSuTime
		{
			set{ _tousutime=value;}
			get{return _tousutime;}
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


		#region  ��Ա����

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ERPTouSu(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CustomName,TouSuWho,TouSuType,ChuLiResult,TouSuTime,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE ");
			strSql.Append(" FROM ERPTouSu ");
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
				TouSuWho=ds.Tables[0].Rows[0]["TouSuWho"].ToString();
				TouSuType=ds.Tables[0].Rows[0]["TouSuType"].ToString();
				ChuLiResult=ds.Tables[0].Rows[0]["ChuLiResult"].ToString();
				TouSuTime=ds.Tables[0].Rows[0]["TouSuTime"].ToString();
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
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPTouSu"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPTouSu");
			strSql.Append(" where ID=@ID ");

			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ERPTouSu(");
			strSql.Append("CustomName,TouSuWho,TouSuType,ChuLiResult,TouSuTime,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE)");
			strSql.Append(" values (");
			strSql.Append("@CustomName,@TouSuWho,@TouSuType,@ChuLiResult,@TouSuTime,@UserName,@TimeStr,@IFShare,@CusBakA,@CusBakB,@CusBakC,@CusBakD,@CusBakE)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomName", SqlDbType.VarChar,100),
					new SqlParameter("@TouSuWho", SqlDbType.VarChar,500),
					new SqlParameter("@TouSuType", SqlDbType.VarChar,500),
					new SqlParameter("@ChuLiResult", SqlDbType.VarChar,5000),
					new SqlParameter("@TouSuTime", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@IFShare", SqlDbType.VarChar,5000),
					new SqlParameter("@CusBakA", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakB", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakC", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakD", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakE", SqlDbType.VarChar,8000)};
			parameters[0].Value = CustomName;
			parameters[1].Value = TouSuWho;
			parameters[2].Value = TouSuType;
			parameters[3].Value = ChuLiResult;
			parameters[4].Value = TouSuTime;
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
		/// ����һ������
		/// </summary>
		public void Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ERPTouSu set ");
			strSql.Append("CustomName=@CustomName,");
			strSql.Append("TouSuWho=@TouSuWho,");
			strSql.Append("TouSuType=@TouSuType,");
			strSql.Append("ChuLiResult=@ChuLiResult,");
			strSql.Append("TouSuTime=@TouSuTime,");
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
					new SqlParameter("@TouSuWho", SqlDbType.VarChar,500),
					new SqlParameter("@TouSuType", SqlDbType.VarChar,500),
					new SqlParameter("@ChuLiResult", SqlDbType.VarChar,5000),
					new SqlParameter("@TouSuTime", SqlDbType.VarChar,500),
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
			parameters[2].Value = TouSuWho;
			parameters[3].Value = TouSuType;
			parameters[4].Value = ChuLiResult;
			parameters[5].Value = TouSuTime;
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
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete ERPTouSu ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public void GetModel(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CustomName,TouSuWho,TouSuType,ChuLiResult,TouSuTime,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE ");
			strSql.Append(" FROM ERPTouSu ");
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
				TouSuWho=ds.Tables[0].Rows[0]["TouSuWho"].ToString();
				TouSuType=ds.Tables[0].Rows[0]["TouSuType"].ToString();
				ChuLiResult=ds.Tables[0].Rows[0]["ChuLiResult"].ToString();
				TouSuTime=ds.Tables[0].Rows[0]["TouSuTime"].ToString();
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
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select [ID],[CustomName],[TouSuWho],[TouSuType],[ChuLiResult],[TouSuTime],[UserName],[TimeStr],[IFShare],[CusBakA],[CusBakB],[CusBakC],[CusBakD],[CusBakE] ");
			strSql.Append(" FROM ERPTouSu ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}

