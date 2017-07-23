using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPCustomNeed。
	/// </summary>
	public class ERPCustomNeed
	{
		public ERPCustomNeed()
		{}
		#region Model
		private int _id;
		private string _customname;
		private string _needcontent;
		private string _neednow;
		private string _needproduct;
		private string _needtime;
		private string _needlike;
		private string _jingzhengduishou;
		private string _hezuoyiyuan;
		private string _hezuojilv;
		private string _needzhangai;
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
		public string NeedContent
		{
			set{ _needcontent=value;}
			get{return _needcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NeedNow
		{
			set{ _neednow=value;}
			get{return _neednow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NeedProduct
		{
			set{ _needproduct=value;}
			get{return _needproduct;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NeedTime
		{
			set{ _needtime=value;}
			get{return _needtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NeedLike
		{
			set{ _needlike=value;}
			get{return _needlike;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JingZhengDuiShou
		{
			set{ _jingzhengduishou=value;}
			get{return _jingzhengduishou;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HeZuoYiYuan
		{
			set{ _hezuoyiyuan=value;}
			get{return _hezuoyiyuan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HeZuoJiLv
		{
			set{ _hezuojilv=value;}
			get{return _hezuojilv;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NeedZhangAi
		{
			set{ _needzhangai=value;}
			get{return _needzhangai;}
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
		public ERPCustomNeed(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CustomName,NeedContent,NeedNow,NeedProduct,NeedTime,NeedLike,JingZhengDuiShou,HeZuoYiYuan,HeZuoJiLv,NeedZhangAi,BackInfo,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE ");
			strSql.Append(" FROM ERPCustomNeed ");
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
				NeedContent=ds.Tables[0].Rows[0]["NeedContent"].ToString();
				NeedNow=ds.Tables[0].Rows[0]["NeedNow"].ToString();
				NeedProduct=ds.Tables[0].Rows[0]["NeedProduct"].ToString();
				NeedTime=ds.Tables[0].Rows[0]["NeedTime"].ToString();
				NeedLike=ds.Tables[0].Rows[0]["NeedLike"].ToString();
				JingZhengDuiShou=ds.Tables[0].Rows[0]["JingZhengDuiShou"].ToString();
				HeZuoYiYuan=ds.Tables[0].Rows[0]["HeZuoYiYuan"].ToString();
				HeZuoJiLv=ds.Tables[0].Rows[0]["HeZuoJiLv"].ToString();
				NeedZhangAi=ds.Tables[0].Rows[0]["NeedZhangAi"].ToString();
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

		return DbHelperSQL.GetMaxID("ID", "ERPCustomNeed"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPCustomNeed");
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
			strSql.Append("insert into ERPCustomNeed(");
			strSql.Append("CustomName,NeedContent,NeedNow,NeedProduct,NeedTime,NeedLike,JingZhengDuiShou,HeZuoYiYuan,HeZuoJiLv,NeedZhangAi,BackInfo,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE)");
			strSql.Append(" values (");
			strSql.Append("@CustomName,@NeedContent,@NeedNow,@NeedProduct,@NeedTime,@NeedLike,@JingZhengDuiShou,@HeZuoYiYuan,@HeZuoJiLv,@NeedZhangAi,@BackInfo,@UserName,@TimeStr,@IFShare,@CusBakA,@CusBakB,@CusBakC,@CusBakD,@CusBakE)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomName", SqlDbType.VarChar,100),
					new SqlParameter("@NeedContent", SqlDbType.VarChar,8000),
					new SqlParameter("@NeedNow", SqlDbType.VarChar,5000),
					new SqlParameter("@NeedProduct", SqlDbType.VarChar,5000),
					new SqlParameter("@NeedTime", SqlDbType.VarChar,500),
					new SqlParameter("@NeedLike", SqlDbType.VarChar,500),
					new SqlParameter("@JingZhengDuiShou", SqlDbType.VarChar,500),
					new SqlParameter("@HeZuoYiYuan", SqlDbType.VarChar,500),
					new SqlParameter("@HeZuoJiLv", SqlDbType.VarChar,500),
					new SqlParameter("@NeedZhangAi", SqlDbType.VarChar,5000),
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
			parameters[1].Value = NeedContent;
			parameters[2].Value = NeedNow;
			parameters[3].Value = NeedProduct;
			parameters[4].Value = NeedTime;
			parameters[5].Value = NeedLike;
			parameters[6].Value = JingZhengDuiShou;
			parameters[7].Value = HeZuoYiYuan;
			parameters[8].Value = HeZuoJiLv;
			parameters[9].Value = NeedZhangAi;
			parameters[10].Value = BackInfo;
			parameters[11].Value = UserName;
			parameters[12].Value = TimeStr;
			parameters[13].Value = IFShare;
			parameters[14].Value = CusBakA;
			parameters[15].Value = CusBakB;
			parameters[16].Value = CusBakC;
			parameters[17].Value = CusBakD;
			parameters[18].Value = CusBakE;

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
			strSql.Append("update ERPCustomNeed set ");
			strSql.Append("CustomName=@CustomName,");
			strSql.Append("NeedContent=@NeedContent,");
			strSql.Append("NeedNow=@NeedNow,");
			strSql.Append("NeedProduct=@NeedProduct,");
			strSql.Append("NeedTime=@NeedTime,");
			strSql.Append("NeedLike=@NeedLike,");
			strSql.Append("JingZhengDuiShou=@JingZhengDuiShou,");
			strSql.Append("HeZuoYiYuan=@HeZuoYiYuan,");
			strSql.Append("HeZuoJiLv=@HeZuoJiLv,");
			strSql.Append("NeedZhangAi=@NeedZhangAi,");
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
					new SqlParameter("@NeedContent", SqlDbType.VarChar,8000),
					new SqlParameter("@NeedNow", SqlDbType.VarChar,5000),
					new SqlParameter("@NeedProduct", SqlDbType.VarChar,5000),
					new SqlParameter("@NeedTime", SqlDbType.VarChar,500),
					new SqlParameter("@NeedLike", SqlDbType.VarChar,500),
					new SqlParameter("@JingZhengDuiShou", SqlDbType.VarChar,500),
					new SqlParameter("@HeZuoYiYuan", SqlDbType.VarChar,500),
					new SqlParameter("@HeZuoJiLv", SqlDbType.VarChar,500),
					new SqlParameter("@NeedZhangAi", SqlDbType.VarChar,5000),
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
			parameters[2].Value = NeedContent;
			parameters[3].Value = NeedNow;
			parameters[4].Value = NeedProduct;
			parameters[5].Value = NeedTime;
			parameters[6].Value = NeedLike;
			parameters[7].Value = JingZhengDuiShou;
			parameters[8].Value = HeZuoYiYuan;
			parameters[9].Value = HeZuoJiLv;
			parameters[10].Value = NeedZhangAi;
			parameters[11].Value = BackInfo;
			parameters[12].Value = UserName;
			parameters[13].Value = TimeStr;
			parameters[14].Value = IFShare;
			parameters[15].Value = CusBakA;
			parameters[16].Value = CusBakB;
			parameters[17].Value = CusBakC;
			parameters[18].Value = CusBakD;
			parameters[19].Value = CusBakE;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete ERPCustomNeed ");
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
			strSql.Append("select ID,CustomName,NeedContent,NeedNow,NeedProduct,NeedTime,NeedLike,JingZhengDuiShou,HeZuoYiYuan,HeZuoJiLv,NeedZhangAi,BackInfo,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE ");
			strSql.Append(" FROM ERPCustomNeed ");
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
				NeedContent=ds.Tables[0].Rows[0]["NeedContent"].ToString();
				NeedNow=ds.Tables[0].Rows[0]["NeedNow"].ToString();
				NeedProduct=ds.Tables[0].Rows[0]["NeedProduct"].ToString();
				NeedTime=ds.Tables[0].Rows[0]["NeedTime"].ToString();
				NeedLike=ds.Tables[0].Rows[0]["NeedLike"].ToString();
				JingZhengDuiShou=ds.Tables[0].Rows[0]["JingZhengDuiShou"].ToString();
				HeZuoYiYuan=ds.Tables[0].Rows[0]["HeZuoYiYuan"].ToString();
				HeZuoJiLv=ds.Tables[0].Rows[0]["HeZuoJiLv"].ToString();
				NeedZhangAi=ds.Tables[0].Rows[0]["NeedZhangAi"].ToString();
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
			strSql.Append("select [ID],[CustomName],[NeedContent],[NeedNow],[NeedProduct],[NeedTime],[NeedLike],[JingZhengDuiShou],[HeZuoYiYuan],[HeZuoJiLv],[NeedZhangAi],[BackInfo],[UserName],[TimeStr],[IFShare],[CusBakA],[CusBakB],[CusBakC],[CusBakD],[CusBakE] ");
			strSql.Append(" FROM ERPCustomNeed ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

