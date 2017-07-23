using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPCarShiYong。
	/// </summary>
	public class ERPCarShiYong
	{
		public ERPCarShiYong()
		{}
		#region Model
		private int _id;
		private string _carname;
		private string _driveruser;
		private string _yongcheuser;
		private string _yongchebumen;
		private string _qishitime;
		private string _jieshutime;
		private string _mudidi;
		private string _licheng;
		private string _shengqinguser;
		private string _diaoduuser;
		private string _shengqingshiyou;
		private string _nowstate;
		private string _username;
		private DateTime? _timestr;
		private string _backinfo;
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
		/// 司机
		/// </summary>
		public string DriverUser
		{
			set{ _driveruser=value;}
			get{return _driveruser;}
		}
		/// <summary>
		/// 用车人
		/// </summary>
		public string YongCheUser
		{
			set{ _yongcheuser=value;}
			get{return _yongcheuser;}
		}
		/// <summary>
		/// 用车部门
		/// </summary>
		public string YongCheBuMen
		{
			set{ _yongchebumen=value;}
			get{return _yongchebumen;}
		}
		/// <summary>
		/// 起始时间
		/// </summary>
		public string QiShiTime
		{
			set{ _qishitime=value;}
			get{return _qishitime;}
		}
		/// <summary>
		/// 结束时间
		/// </summary>
		public string JieShuTime
		{
			set{ _jieshutime=value;}
			get{return _jieshutime;}
		}
		/// <summary>
		/// 目的地
		/// </summary>
		public string MuDiDi
		{
			set{ _mudidi=value;}
			get{return _mudidi;}
		}
		/// <summary>
		/// 里程
		/// </summary>
		public string LiCheng
		{
			set{ _licheng=value;}
			get{return _licheng;}
		}
		/// <summary>
		/// 申请人
		/// </summary>
		public string ShengQingUser
		{
			set{ _shengqinguser=value;}
			get{return _shengqinguser;}
		}
		/// <summary>
		/// 调度人
		/// </summary>
		public string DiaoDuUser
		{
			set{ _diaoduuser=value;}
			get{return _diaoduuser;}
		}
		/// <summary>
		/// 申请事由
		/// </summary>
		public string ShengQingShiYou
		{
			set{ _shengqingshiyou=value;}
			get{return _shengqingshiyou;}
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
		/// 备注说明
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		#endregion Model


		#region  成员方法

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPCarShiYong(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CarName,DriverUser,YongCheUser,YongCheBuMen,QiShiTime,JieShuTime,MuDiDi,LiCheng,ShengQingUser,DiaoDuUser,ShengQingShiYou,NowState,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPCarShiYong ");
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
				DriverUser=ds.Tables[0].Rows[0]["DriverUser"].ToString();
				YongCheUser=ds.Tables[0].Rows[0]["YongCheUser"].ToString();
				YongCheBuMen=ds.Tables[0].Rows[0]["YongCheBuMen"].ToString();
				QiShiTime=ds.Tables[0].Rows[0]["QiShiTime"].ToString();
				JieShuTime=ds.Tables[0].Rows[0]["JieShuTime"].ToString();
				MuDiDi=ds.Tables[0].Rows[0]["MuDiDi"].ToString();
				LiCheng=ds.Tables[0].Rows[0]["LiCheng"].ToString();
				ShengQingUser=ds.Tables[0].Rows[0]["ShengQingUser"].ToString();
				DiaoDuUser=ds.Tables[0].Rows[0]["DiaoDuUser"].ToString();
				ShengQingShiYou=ds.Tables[0].Rows[0]["ShengQingShiYou"].ToString();
				NowState=ds.Tables[0].Rows[0]["NowState"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPCarShiYong"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPCarShiYong");
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
			strSql.Append("insert into ERPCarShiYong(");
			strSql.Append("CarName,DriverUser,YongCheUser,YongCheBuMen,QiShiTime,JieShuTime,MuDiDi,LiCheng,ShengQingUser,DiaoDuUser,ShengQingShiYou,NowState,UserName,TimeStr,BackInfo)");
			strSql.Append(" values (");
			strSql.Append("@CarName,@DriverUser,@YongCheUser,@YongCheBuMen,@QiShiTime,@JieShuTime,@MuDiDi,@LiCheng,@ShengQingUser,@DiaoDuUser,@ShengQingShiYou,@NowState,@UserName,@TimeStr,@BackInfo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CarName", SqlDbType.VarChar,50),
					new SqlParameter("@DriverUser", SqlDbType.VarChar,50),
					new SqlParameter("@YongCheUser", SqlDbType.VarChar,50),
					new SqlParameter("@YongCheBuMen", SqlDbType.VarChar,50),
					new SqlParameter("@QiShiTime", SqlDbType.VarChar,50),
					new SqlParameter("@JieShuTime", SqlDbType.VarChar,50),
					new SqlParameter("@MuDiDi", SqlDbType.VarChar,50),
					new SqlParameter("@LiCheng", SqlDbType.VarChar,50),
					new SqlParameter("@ShengQingUser", SqlDbType.VarChar,50),
					new SqlParameter("@DiaoDuUser", SqlDbType.VarChar,50),
					new SqlParameter("@ShengQingShiYou", SqlDbType.VarChar,5000),
					new SqlParameter("@NowState", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = CarName;
			parameters[1].Value = DriverUser;
			parameters[2].Value = YongCheUser;
			parameters[3].Value = YongCheBuMen;
			parameters[4].Value = QiShiTime;
			parameters[5].Value = JieShuTime;
			parameters[6].Value = MuDiDi;
			parameters[7].Value = LiCheng;
			parameters[8].Value = ShengQingUser;
			parameters[9].Value = DiaoDuUser;
			parameters[10].Value = ShengQingShiYou;
			parameters[11].Value = NowState;
			parameters[12].Value = UserName;
			parameters[13].Value = TimeStr;
			parameters[14].Value = BackInfo;

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
			strSql.Append("update ERPCarShiYong set ");
			strSql.Append("CarName=@CarName,");
			strSql.Append("DriverUser=@DriverUser,");
			strSql.Append("YongCheUser=@YongCheUser,");
			strSql.Append("YongCheBuMen=@YongCheBuMen,");
			strSql.Append("QiShiTime=@QiShiTime,");
			strSql.Append("JieShuTime=@JieShuTime,");
			strSql.Append("MuDiDi=@MuDiDi,");
			strSql.Append("LiCheng=@LiCheng,");
			strSql.Append("ShengQingUser=@ShengQingUser,");
			strSql.Append("DiaoDuUser=@DiaoDuUser,");
			strSql.Append("ShengQingShiYou=@ShengQingShiYou,");
			strSql.Append("NowState=@NowState,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr,");
			strSql.Append("BackInfo=@BackInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@CarName", SqlDbType.VarChar,50),
					new SqlParameter("@DriverUser", SqlDbType.VarChar,50),
					new SqlParameter("@YongCheUser", SqlDbType.VarChar,50),
					new SqlParameter("@YongCheBuMen", SqlDbType.VarChar,50),
					new SqlParameter("@QiShiTime", SqlDbType.VarChar,50),
					new SqlParameter("@JieShuTime", SqlDbType.VarChar,50),
					new SqlParameter("@MuDiDi", SqlDbType.VarChar,50),
					new SqlParameter("@LiCheng", SqlDbType.VarChar,50),
					new SqlParameter("@ShengQingUser", SqlDbType.VarChar,50),
					new SqlParameter("@DiaoDuUser", SqlDbType.VarChar,50),
					new SqlParameter("@ShengQingShiYou", SqlDbType.VarChar,5000),
					new SqlParameter("@NowState", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = ID;
			parameters[1].Value = CarName;
			parameters[2].Value = DriverUser;
			parameters[3].Value = YongCheUser;
			parameters[4].Value = YongCheBuMen;
			parameters[5].Value = QiShiTime;
			parameters[6].Value = JieShuTime;
			parameters[7].Value = MuDiDi;
			parameters[8].Value = LiCheng;
			parameters[9].Value = ShengQingUser;
			parameters[10].Value = DiaoDuUser;
			parameters[11].Value = ShengQingShiYou;
			parameters[12].Value = NowState;
			parameters[13].Value = UserName;
			parameters[14].Value = TimeStr;
			parameters[15].Value = BackInfo;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPCarShiYong ");
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
			strSql.Append("select  top 1 ID,CarName,DriverUser,YongCheUser,YongCheBuMen,QiShiTime,JieShuTime,MuDiDi,LiCheng,ShengQingUser,DiaoDuUser,ShengQingShiYou,NowState,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPCarShiYong ");
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
				DriverUser=ds.Tables[0].Rows[0]["DriverUser"].ToString();
				YongCheUser=ds.Tables[0].Rows[0]["YongCheUser"].ToString();
				YongCheBuMen=ds.Tables[0].Rows[0]["YongCheBuMen"].ToString();
				QiShiTime=ds.Tables[0].Rows[0]["QiShiTime"].ToString();
				JieShuTime=ds.Tables[0].Rows[0]["JieShuTime"].ToString();
				MuDiDi=ds.Tables[0].Rows[0]["MuDiDi"].ToString();
				LiCheng=ds.Tables[0].Rows[0]["LiCheng"].ToString();
				ShengQingUser=ds.Tables[0].Rows[0]["ShengQingUser"].ToString();
				DiaoDuUser=ds.Tables[0].Rows[0]["DiaoDuUser"].ToString();
				ShengQingShiYou=ds.Tables[0].Rows[0]["ShengQingShiYou"].ToString();
				NowState=ds.Tables[0].Rows[0]["NowState"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPCarShiYong ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

