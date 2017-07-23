using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPSongYang。
	/// </summary>
	public class ERPSongYang
	{
		public ERPSongYang()
		{}
		#region Model
		private int _id;
		private string _customname;
		private string _songyangliaohao;
		private string _songyangtype;
		private string _songyangshuliang;
		private string _songyangdanjia;
		private string _songyangjine;
		private string _songyangresult;
		private string _songyangtime;
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
		public string SongYangLiaoHao
		{
			set{ _songyangliaohao=value;}
			get{return _songyangliaohao;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SongYangType
		{
			set{ _songyangtype=value;}
			get{return _songyangtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SongYangShuLiang
		{
			set{ _songyangshuliang=value;}
			get{return _songyangshuliang;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SongYangDanJia
		{
			set{ _songyangdanjia=value;}
			get{return _songyangdanjia;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SongYangJinE
		{
			set{ _songyangjine=value;}
			get{return _songyangjine;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SongYangResult
		{
			set{ _songyangresult=value;}
			get{return _songyangresult;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SongYangTime
		{
			set{ _songyangtime=value;}
			get{return _songyangtime;}
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
		public ERPSongYang(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CustomName,SongYangLiaoHao,SongYangType,SongYangShuLiang,SongYangDanJia,SongYangJinE,SongYangResult,SongYangTime,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE ");
			strSql.Append(" FROM ERPSongYang ");
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
				SongYangLiaoHao=ds.Tables[0].Rows[0]["SongYangLiaoHao"].ToString();
				SongYangType=ds.Tables[0].Rows[0]["SongYangType"].ToString();
				SongYangShuLiang=ds.Tables[0].Rows[0]["SongYangShuLiang"].ToString();
				SongYangDanJia=ds.Tables[0].Rows[0]["SongYangDanJia"].ToString();
				SongYangJinE=ds.Tables[0].Rows[0]["SongYangJinE"].ToString();
				SongYangResult=ds.Tables[0].Rows[0]["SongYangResult"].ToString();
				SongYangTime=ds.Tables[0].Rows[0]["SongYangTime"].ToString();
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

		return DbHelperSQL.GetMaxID("ID", "ERPSongYang"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPSongYang");
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
			strSql.Append("insert into ERPSongYang(");
			strSql.Append("CustomName,SongYangLiaoHao,SongYangType,SongYangShuLiang,SongYangResult,SongYangTime,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE)");
			strSql.Append(" values (");
			strSql.Append("@CustomName,@SongYangLiaoHao,@SongYangType,@SongYangShuLiang,@SongYangResult,@SongYangTime,@UserName,@TimeStr,@IFShare,@CusBakA,@CusBakB,@CusBakC,@CusBakD,@CusBakE)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomName", SqlDbType.VarChar,100),
					new SqlParameter("@SongYangLiaoHao", SqlDbType.VarChar,500),
					new SqlParameter("@SongYangType", SqlDbType.VarChar,500),
					new SqlParameter("@SongYangShuLiang", SqlDbType.VarChar,50),
					new SqlParameter("@SongYangResult", SqlDbType.VarChar,5000),
					new SqlParameter("@SongYangTime", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@IFShare", SqlDbType.VarChar,5000),
					new SqlParameter("@CusBakA", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakB", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakC", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakD", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakE", SqlDbType.VarChar,8000)};
			parameters[0].Value = CustomName;
			parameters[1].Value = SongYangLiaoHao;
			parameters[2].Value = SongYangType;
			parameters[3].Value = SongYangShuLiang;
			parameters[4].Value = SongYangResult;
			parameters[5].Value = SongYangTime;
			parameters[6].Value = UserName;
			parameters[7].Value = TimeStr;
			parameters[8].Value = IFShare;
			parameters[9].Value = CusBakA;
			parameters[10].Value = CusBakB;
			parameters[11].Value = CusBakC;
			parameters[12].Value = CusBakD;
			parameters[13].Value = CusBakE;

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
			strSql.Append("update ERPSongYang set ");
			strSql.Append("CustomName=@CustomName,");
			strSql.Append("SongYangLiaoHao=@SongYangLiaoHao,");
			strSql.Append("SongYangType=@SongYangType,");
			strSql.Append("SongYangShuLiang=@SongYangShuLiang,");
			strSql.Append("SongYangResult=@SongYangResult,");
			strSql.Append("SongYangTime=@SongYangTime,");
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
					new SqlParameter("@SongYangLiaoHao", SqlDbType.VarChar,500),
					new SqlParameter("@SongYangType", SqlDbType.VarChar,500),
					new SqlParameter("@SongYangShuLiang", SqlDbType.VarChar,50),
					new SqlParameter("@SongYangResult", SqlDbType.VarChar,5000),
					new SqlParameter("@SongYangTime", SqlDbType.VarChar,500),
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
			parameters[2].Value = SongYangLiaoHao;
			parameters[3].Value = SongYangType;
			parameters[4].Value = SongYangShuLiang;
			parameters[5].Value = SongYangResult;
			parameters[6].Value = SongYangTime;
			parameters[7].Value = UserName;
			parameters[8].Value = TimeStr;
			parameters[9].Value = IFShare;
			parameters[10].Value = CusBakA;
			parameters[11].Value = CusBakB;
			parameters[12].Value = CusBakC;
			parameters[13].Value = CusBakD;
			parameters[14].Value = CusBakE;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete ERPSongYang ");
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
			strSql.Append("select ID,CustomName,SongYangLiaoHao,SongYangType,SongYangShuLiang,SongYangDanJia,SongYangJinE,SongYangResult,SongYangTime,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE ");
			strSql.Append(" FROM ERPSongYang ");
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
				SongYangLiaoHao=ds.Tables[0].Rows[0]["SongYangLiaoHao"].ToString();
				SongYangType=ds.Tables[0].Rows[0]["SongYangType"].ToString();
				SongYangShuLiang=ds.Tables[0].Rows[0]["SongYangShuLiang"].ToString();
				SongYangDanJia=ds.Tables[0].Rows[0]["SongYangDanJia"].ToString();
				SongYangJinE=ds.Tables[0].Rows[0]["SongYangJinE"].ToString();
				SongYangResult=ds.Tables[0].Rows[0]["SongYangResult"].ToString();
				SongYangTime=ds.Tables[0].Rows[0]["SongYangTime"].ToString();
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
			strSql.Append("select [ID],[CustomName],[SongYangLiaoHao],[SongYangType],[SongYangShuLiang],[SongYangDanJia],[SongYangJinE],[SongYangResult],[SongYangTime],[UserName],[TimeStr],[IFShare],[CusBakA],[CusBakB],[CusBakC],[CusBakD],[CusBakE] ");
			strSql.Append(" FROM ERPSongYang ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

