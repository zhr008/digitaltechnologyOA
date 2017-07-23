using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPJiangCheng。
	/// </summary>
	public class ERPJiangCheng
	{
		public ERPJiangCheng()
		{}
		#region Model
		private int _id;
		private string _jcuser;
		private string _jiangchengqufen;
		private string _jiangchengtype;
		private string _shouyudanwei;
		private string _jiangchengdate;
		private string _jiangchengmingmu;
		private string _jiangchengyuanyin;
		private string _backinfo;
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
		/// 职员用户
		/// </summary>
		public string JCUser
		{
			set{ _jcuser=value;}
			get{return _jcuser;}
		}
		/// <summary>
		/// 奖惩区分
		/// </summary>
		public string JiangChengQuFen
		{
			set{ _jiangchengqufen=value;}
			get{return _jiangchengqufen;}
		}
		/// <summary>
		/// 奖惩类别
		/// </summary>
		public string JiangChengType
		{
			set{ _jiangchengtype=value;}
			get{return _jiangchengtype;}
		}
		/// <summary>
		/// 授予单位
		/// </summary>
		public string ShouYuDanWei
		{
			set{ _shouyudanwei=value;}
			get{return _shouyudanwei;}
		}
		/// <summary>
		/// 奖惩日期
		/// </summary>
		public string JiangChengDate
		{
			set{ _jiangchengdate=value;}
			get{return _jiangchengdate;}
		}
		/// <summary>
		/// 奖惩名目
		/// </summary>
		public string JiangChengMingMu
		{
			set{ _jiangchengmingmu=value;}
			get{return _jiangchengmingmu;}
		}
		/// <summary>
		/// 奖惩原因
		/// </summary>
		public string JiangChengYuanYin
		{
			set{ _jiangchengyuanyin=value;}
			get{return _jiangchengyuanyin;}
		}
		/// <summary>
		/// 备注说明
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
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
		public ERPJiangCheng(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,JCUser,JiangChengQuFen,JiangChengType,ShouYuDanWei,JiangChengDate,JiangChengMingMu,JiangChengYuanYin,BackInfo,UserName,TimeStr ");
			strSql.Append(" FROM ERPJiangCheng ");
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
				JCUser=ds.Tables[0].Rows[0]["JCUser"].ToString();
				JiangChengQuFen=ds.Tables[0].Rows[0]["JiangChengQuFen"].ToString();
				JiangChengType=ds.Tables[0].Rows[0]["JiangChengType"].ToString();
				ShouYuDanWei=ds.Tables[0].Rows[0]["ShouYuDanWei"].ToString();
				JiangChengDate=ds.Tables[0].Rows[0]["JiangChengDate"].ToString();
				JiangChengMingMu=ds.Tables[0].Rows[0]["JiangChengMingMu"].ToString();
				JiangChengYuanYin=ds.Tables[0].Rows[0]["JiangChengYuanYin"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
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

		return DbHelperSQL.GetMaxID("ID", "ERPJiangCheng"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPJiangCheng");
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
			strSql.Append("insert into ERPJiangCheng(");
			strSql.Append("JCUser,JiangChengQuFen,JiangChengType,ShouYuDanWei,JiangChengDate,JiangChengMingMu,JiangChengYuanYin,BackInfo,UserName,TimeStr)");
			strSql.Append(" values (");
			strSql.Append("@JCUser,@JiangChengQuFen,@JiangChengType,@ShouYuDanWei,@JiangChengDate,@JiangChengMingMu,@JiangChengYuanYin,@BackInfo,@UserName,@TimeStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@JCUser", SqlDbType.VarChar,50),
					new SqlParameter("@JiangChengQuFen", SqlDbType.VarChar,50),
					new SqlParameter("@JiangChengType", SqlDbType.VarChar,50),
					new SqlParameter("@ShouYuDanWei", SqlDbType.VarChar,50),
					new SqlParameter("@JiangChengDate", SqlDbType.VarChar,50),
					new SqlParameter("@JiangChengMingMu", SqlDbType.VarChar,5000),
					new SqlParameter("@JiangChengYuanYin", SqlDbType.VarChar,5000),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = JCUser;
			parameters[1].Value = JiangChengQuFen;
			parameters[2].Value = JiangChengType;
			parameters[3].Value = ShouYuDanWei;
			parameters[4].Value = JiangChengDate;
			parameters[5].Value = JiangChengMingMu;
			parameters[6].Value = JiangChengYuanYin;
			parameters[7].Value = BackInfo;
			parameters[8].Value = UserName;
			parameters[9].Value = TimeStr;

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
			strSql.Append("update ERPJiangCheng set ");
			strSql.Append("JCUser=@JCUser,");
			strSql.Append("JiangChengQuFen=@JiangChengQuFen,");
			strSql.Append("JiangChengType=@JiangChengType,");
			strSql.Append("ShouYuDanWei=@ShouYuDanWei,");
			strSql.Append("JiangChengDate=@JiangChengDate,");
			strSql.Append("JiangChengMingMu=@JiangChengMingMu,");
			strSql.Append("JiangChengYuanYin=@JiangChengYuanYin,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@JCUser", SqlDbType.VarChar,50),
					new SqlParameter("@JiangChengQuFen", SqlDbType.VarChar,50),
					new SqlParameter("@JiangChengType", SqlDbType.VarChar,50),
					new SqlParameter("@ShouYuDanWei", SqlDbType.VarChar,50),
					new SqlParameter("@JiangChengDate", SqlDbType.VarChar,50),
					new SqlParameter("@JiangChengMingMu", SqlDbType.VarChar,5000),
					new SqlParameter("@JiangChengYuanYin", SqlDbType.VarChar,5000),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = ID;
			parameters[1].Value = JCUser;
			parameters[2].Value = JiangChengQuFen;
			parameters[3].Value = JiangChengType;
			parameters[4].Value = ShouYuDanWei;
			parameters[5].Value = JiangChengDate;
			parameters[6].Value = JiangChengMingMu;
			parameters[7].Value = JiangChengYuanYin;
			parameters[8].Value = BackInfo;
			parameters[9].Value = UserName;
			parameters[10].Value = TimeStr;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPJiangCheng ");
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
			strSql.Append("select  top 1 ID,JCUser,JiangChengQuFen,JiangChengType,ShouYuDanWei,JiangChengDate,JiangChengMingMu,JiangChengYuanYin,BackInfo,UserName,TimeStr ");
			strSql.Append(" FROM ERPJiangCheng ");
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
				JCUser=ds.Tables[0].Rows[0]["JCUser"].ToString();
				JiangChengQuFen=ds.Tables[0].Rows[0]["JiangChengQuFen"].ToString();
				JiangChengType=ds.Tables[0].Rows[0]["JiangChengType"].ToString();
				ShouYuDanWei=ds.Tables[0].Rows[0]["ShouYuDanWei"].ToString();
				JiangChengDate=ds.Tables[0].Rows[0]["JiangChengDate"].ToString();
				JiangChengMingMu=ds.Tables[0].Rows[0]["JiangChengMingMu"].ToString();
				JiangChengYuanYin=ds.Tables[0].Rows[0]["JiangChengYuanYin"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
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
			strSql.Append(" FROM ERPJiangCheng ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

