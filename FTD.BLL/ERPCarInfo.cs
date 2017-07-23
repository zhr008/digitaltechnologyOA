using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPCarInfo。
	/// </summary>
	public class ERPCarInfo
	{
		public ERPCarInfo()
		{}
		#region Model
		private int _id;
		private string _carname;
		private string _carpaihao;
		private string _carxinghao;
		private string _leixing;
		private string _driveruser;
		private string _nowstate;
		private string _username;
		private DateTime? _timestr;
		private string _backinfo;
        private string _suoshudep;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 车辆名称
		/// </summary>
		public string CarName
		{
			set{ _carname=value;}
			get{return _carname;}
		}
		/// <summary>
		/// 车牌号
		/// </summary>
		public string CarPaiHao
		{
			set{ _carpaihao=value;}
			get{return _carpaihao;}
		}
		/// <summary>
		/// 厂牌型号
		/// </summary>
		public string CarXingHao
		{
			set{ _carxinghao=value;}
			get{return _carxinghao;}
		}
		/// <summary>
		/// 车辆类型
		/// </summary>
		public string LeiXing
		{
			set{ _leixing=value;}
			get{return _leixing;}
		}
		/// <summary>
		/// 驾驶员
		/// </summary>
		public string DriverUser
		{
			set{ _driveruser=value;}
			get{return _driveruser;}
		}
		/// <summary>
		/// 当前状态
		/// </summary>
		public string NowState
		{
			set{ _nowstate=value;}
			get{return _nowstate;}
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
		/// <summary>
		/// 备注信息
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}

        public string SuoShuDep
        {
            set { _suoshudep = value; }
            get { return _suoshudep; }
        }
		#endregion Model


		#region  成员方法

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPCarInfo(int ID)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select ID,CarName,CarPaiHao,CarXingHao,LeiXing,DriverUser,NowState,UserName,TimeStr,BackInfo,SuoShuDep ");
			strSql.Append(" FROM ERPCarInfo ");
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
				CarName=ds.Tables[0].Rows[0]["CarName"].ToString();
				CarPaiHao=ds.Tables[0].Rows[0]["CarPaiHao"].ToString();
				CarXingHao=ds.Tables[0].Rows[0]["CarXingHao"].ToString();
				LeiXing=ds.Tables[0].Rows[0]["LeiXing"].ToString();
				DriverUser=ds.Tables[0].Rows[0]["DriverUser"].ToString();
				NowState=ds.Tables[0].Rows[0]["NowState"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
                SuoShuDep = ds.Tables[0].Rows[0]["SuoShuDep"].ToString();
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPCarInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPCarInfo");
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
			strSql.Append("insert into ERPCarInfo(");
            strSql.Append("CarName,CarPaiHao,CarXingHao,LeiXing,DriverUser,NowState,UserName,TimeStr,BackInfo,SuoShuDep)");
			strSql.Append(" values (");
            strSql.Append("@CarName,@CarPaiHao,@CarXingHao,@LeiXing,@DriverUser,@NowState,@UserName,@TimeStr,@BackInfo,@SuoShuDep)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CarName", SqlDbType.VarChar,50),
					new SqlParameter("@CarPaiHao", SqlDbType.VarChar,50),
					new SqlParameter("@CarXingHao", SqlDbType.VarChar,50),
					new SqlParameter("@LeiXing", SqlDbType.VarChar,50),
					new SqlParameter("@DriverUser", SqlDbType.VarChar,50),
					new SqlParameter("@NowState", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
                    new SqlParameter("@SuoShuDep", SqlDbType.VarChar,8000)};
			parameters[0].Value = CarName;
			parameters[1].Value = CarPaiHao;
			parameters[2].Value = CarXingHao;
			parameters[3].Value = LeiXing;
			parameters[4].Value = DriverUser;
			parameters[5].Value = NowState;
			parameters[6].Value = UserName;
			parameters[7].Value = TimeStr;
			parameters[8].Value = BackInfo;
            parameters[9].Value = SuoShuDep;

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
			strSql.Append("update ERPCarInfo set ");
			strSql.Append("CarName=@CarName,");
			strSql.Append("CarPaiHao=@CarPaiHao,");
			strSql.Append("CarXingHao=@CarXingHao,");
			strSql.Append("LeiXing=@LeiXing,");
			strSql.Append("DriverUser=@DriverUser,");
			strSql.Append("NowState=@NowState,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr,");
			strSql.Append("BackInfo=@BackInfo,");
            strSql.Append("SuoShuDep=@SuoShuDep");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@CarName", SqlDbType.VarChar,50),
					new SqlParameter("@CarPaiHao", SqlDbType.VarChar,50),
					new SqlParameter("@CarXingHao", SqlDbType.VarChar,50),
					new SqlParameter("@LeiXing", SqlDbType.VarChar,50),
					new SqlParameter("@DriverUser", SqlDbType.VarChar,50),
					new SqlParameter("@NowState", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
                    new SqlParameter("@SuoShuDep", SqlDbType.VarChar,8000)};
			parameters[0].Value = ID;
			parameters[1].Value = CarName;
			parameters[2].Value = CarPaiHao;
			parameters[3].Value = CarXingHao;
			parameters[4].Value = LeiXing;
			parameters[5].Value = DriverUser;
			parameters[6].Value = NowState;
			parameters[7].Value = UserName;
			parameters[8].Value = TimeStr;
			parameters[9].Value = BackInfo;
            parameters[10].Value = SuoShuDep;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPCarInfo ");
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
            strSql.Append("select  top 1 ID,CarName,CarPaiHao,CarXingHao,LeiXing,DriverUser,NowState,UserName,TimeStr,BackInfo,SuoShuDep ");
			strSql.Append(" FROM ERPCarInfo ");
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
				CarName=ds.Tables[0].Rows[0]["CarName"].ToString();
				CarPaiHao=ds.Tables[0].Rows[0]["CarPaiHao"].ToString();
				CarXingHao=ds.Tables[0].Rows[0]["CarXingHao"].ToString();
				LeiXing=ds.Tables[0].Rows[0]["LeiXing"].ToString();
				DriverUser=ds.Tables[0].Rows[0]["DriverUser"].ToString();
				NowState=ds.Tables[0].Rows[0]["NowState"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
                SuoShuDep = ds.Tables[0].Rows[0]["SuoShuDep"].ToString();
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPCarInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

