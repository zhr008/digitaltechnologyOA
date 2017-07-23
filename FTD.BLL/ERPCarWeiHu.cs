using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPCarWeiHu。
	/// </summary>
	public class ERPCarWeiHu
	{
		public ERPCarWeiHu()
		{}
		#region Model
		private int _id;
		private string _carname;
		private string _weihuriqi;
		private string _weihuleixing;
		private string _weihuyuanyin;
		private string _jingbanuser;
		private string _weihufeiyong;
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
		/// 维护日期
		/// </summary>
		public string WeiHuRiQi
		{
			set{ _weihuriqi=value;}
			get{return _weihuriqi;}
		}
		/// <summary>
		/// 维护类型
		/// </summary>
		public string WeiHuLeiXing
		{
			set{ _weihuleixing=value;}
			get{return _weihuleixing;}
		}
		/// <summary>
		/// 维护原因
		/// </summary>
		public string WeiHuYuanYin
		{
			set{ _weihuyuanyin=value;}
			get{return _weihuyuanyin;}
		}
		/// <summary>
		/// 经办人
		/// </summary>
		public string JingBanUser
		{
			set{ _jingbanuser=value;}
			get{return _jingbanuser;}
		}
		/// <summary>
		/// 维护费用
		/// </summary>
		public string WeiHuFeiYong
		{
			set{ _weihufeiyong=value;}
			get{return _weihufeiyong;}
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
		#endregion Model


		#region  成员方法

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPCarWeiHu(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CarName,WeiHuRiQi,WeiHuLeiXing,WeiHuYuanYin,JingBanUser,WeiHuFeiYong,NowState,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPCarWeiHu ");
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
				WeiHuRiQi=ds.Tables[0].Rows[0]["WeiHuRiQi"].ToString();
				WeiHuLeiXing=ds.Tables[0].Rows[0]["WeiHuLeiXing"].ToString();
				WeiHuYuanYin=ds.Tables[0].Rows[0]["WeiHuYuanYin"].ToString();
				JingBanUser=ds.Tables[0].Rows[0]["JingBanUser"].ToString();
				WeiHuFeiYong=ds.Tables[0].Rows[0]["WeiHuFeiYong"].ToString();
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

		return DbHelperSQL.GetMaxID("ID", "ERPCarWeiHu"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPCarWeiHu");
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
			strSql.Append("insert into ERPCarWeiHu(");
			strSql.Append("CarName,WeiHuRiQi,WeiHuLeiXing,WeiHuYuanYin,JingBanUser,WeiHuFeiYong,NowState,UserName,TimeStr,BackInfo)");
			strSql.Append(" values (");
			strSql.Append("@CarName,@WeiHuRiQi,@WeiHuLeiXing,@WeiHuYuanYin,@JingBanUser,@WeiHuFeiYong,@NowState,@UserName,@TimeStr,@BackInfo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CarName", SqlDbType.VarChar,50),
					new SqlParameter("@WeiHuRiQi", SqlDbType.VarChar,50),
					new SqlParameter("@WeiHuLeiXing", SqlDbType.VarChar,50),
					new SqlParameter("@WeiHuYuanYin", SqlDbType.VarChar,5000),
					new SqlParameter("@JingBanUser", SqlDbType.VarChar,50),
					new SqlParameter("@WeiHuFeiYong", SqlDbType.VarChar,50),
					new SqlParameter("@NowState", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = CarName;
			parameters[1].Value = WeiHuRiQi;
			parameters[2].Value = WeiHuLeiXing;
			parameters[3].Value = WeiHuYuanYin;
			parameters[4].Value = JingBanUser;
			parameters[5].Value = WeiHuFeiYong;
			parameters[6].Value = NowState;
			parameters[7].Value = UserName;
			parameters[8].Value = TimeStr;
			parameters[9].Value = BackInfo;

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
			strSql.Append("update ERPCarWeiHu set ");
			strSql.Append("CarName=@CarName,");
			strSql.Append("WeiHuRiQi=@WeiHuRiQi,");
			strSql.Append("WeiHuLeiXing=@WeiHuLeiXing,");
			strSql.Append("WeiHuYuanYin=@WeiHuYuanYin,");
			strSql.Append("JingBanUser=@JingBanUser,");
			strSql.Append("WeiHuFeiYong=@WeiHuFeiYong,");
			strSql.Append("NowState=@NowState,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr,");
			strSql.Append("BackInfo=@BackInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@CarName", SqlDbType.VarChar,50),
					new SqlParameter("@WeiHuRiQi", SqlDbType.VarChar,50),
					new SqlParameter("@WeiHuLeiXing", SqlDbType.VarChar,50),
					new SqlParameter("@WeiHuYuanYin", SqlDbType.VarChar,5000),
					new SqlParameter("@JingBanUser", SqlDbType.VarChar,50),
					new SqlParameter("@WeiHuFeiYong", SqlDbType.VarChar,50),
					new SqlParameter("@NowState", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = ID;
			parameters[1].Value = CarName;
			parameters[2].Value = WeiHuRiQi;
			parameters[3].Value = WeiHuLeiXing;
			parameters[4].Value = WeiHuYuanYin;
			parameters[5].Value = JingBanUser;
			parameters[6].Value = WeiHuFeiYong;
			parameters[7].Value = NowState;
			parameters[8].Value = UserName;
			parameters[9].Value = TimeStr;
			parameters[10].Value = BackInfo;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPCarWeiHu ");
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
			strSql.Append("select  top 1 ID,CarName,WeiHuRiQi,WeiHuLeiXing,WeiHuYuanYin,JingBanUser,WeiHuFeiYong,NowState,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPCarWeiHu ");
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
				WeiHuRiQi=ds.Tables[0].Rows[0]["WeiHuRiQi"].ToString();
				WeiHuLeiXing=ds.Tables[0].Rows[0]["WeiHuLeiXing"].ToString();
				WeiHuYuanYin=ds.Tables[0].Rows[0]["WeiHuYuanYin"].ToString();
				JingBanUser=ds.Tables[0].Rows[0]["JingBanUser"].ToString();
				WeiHuFeiYong=ds.Tables[0].Rows[0]["WeiHuFeiYong"].ToString();
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
			strSql.Append(" FROM ERPCarWeiHu ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

