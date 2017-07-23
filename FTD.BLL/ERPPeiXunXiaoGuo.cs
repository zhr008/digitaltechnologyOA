using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPPeiXunXiaoGuo。
	/// </summary>
	public class ERPPeiXunXiaoGuo
	{
		public ERPPeiXunXiaoGuo()
		{}
		#region Model
		private int _id;
		private string _peixunname;
		private string _fankuizhuti;
		private string _xiaoguofankui;
		private string _zongtijielun;
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
		/// 培训名称
		/// </summary>
		public string PeiXunName
		{
			set{ _peixunname=value;}
			get{return _peixunname;}
		}
		/// <summary>
		/// 反馈主题
		/// </summary>
		public string FanKuiZhuTi
		{
			set{ _fankuizhuti=value;}
			get{return _fankuizhuti;}
		}
		/// <summary>
		/// 反馈内容
		/// </summary>
		public string XiaoGuoFanKui
		{
			set{ _xiaoguofankui=value;}
			get{return _xiaoguofankui;}
		}
		/// <summary>
		/// 总体结论
		/// </summary>
		public string ZongTiJieLun
		{
			set{ _zongtijielun=value;}
			get{return _zongtijielun;}
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
		public ERPPeiXunXiaoGuo(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,PeiXunName,FanKuiZhuTi,XiaoGuoFanKui,ZongTiJieLun,UserName,TimeStr ");
			strSql.Append(" FROM ERPPeiXunXiaoGuo ");
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
				PeiXunName=ds.Tables[0].Rows[0]["PeiXunName"].ToString();
				FanKuiZhuTi=ds.Tables[0].Rows[0]["FanKuiZhuTi"].ToString();
				XiaoGuoFanKui=ds.Tables[0].Rows[0]["XiaoGuoFanKui"].ToString();
				ZongTiJieLun=ds.Tables[0].Rows[0]["ZongTiJieLun"].ToString();
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

		return DbHelperSQL.GetMaxID("ID", "ERPPeiXunXiaoGuo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPPeiXunXiaoGuo");
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
			strSql.Append("insert into ERPPeiXunXiaoGuo(");
			strSql.Append("PeiXunName,FanKuiZhuTi,XiaoGuoFanKui,ZongTiJieLun,UserName,TimeStr)");
			strSql.Append(" values (");
			strSql.Append("@PeiXunName,@FanKuiZhuTi,@XiaoGuoFanKui,@ZongTiJieLun,@UserName,@TimeStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@PeiXunName", SqlDbType.VarChar,50),
					new SqlParameter("@FanKuiZhuTi", SqlDbType.VarChar,50),
					new SqlParameter("@XiaoGuoFanKui", SqlDbType.VarChar,5000),
					new SqlParameter("@ZongTiJieLun", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = PeiXunName;
			parameters[1].Value = FanKuiZhuTi;
			parameters[2].Value = XiaoGuoFanKui;
			parameters[3].Value = ZongTiJieLun;
			parameters[4].Value = UserName;
			parameters[5].Value = TimeStr;

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
			strSql.Append("update ERPPeiXunXiaoGuo set ");
			strSql.Append("PeiXunName=@PeiXunName,");
			strSql.Append("FanKuiZhuTi=@FanKuiZhuTi,");
			strSql.Append("XiaoGuoFanKui=@XiaoGuoFanKui,");
			strSql.Append("ZongTiJieLun=@ZongTiJieLun,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@PeiXunName", SqlDbType.VarChar,50),
					new SqlParameter("@FanKuiZhuTi", SqlDbType.VarChar,50),
					new SqlParameter("@XiaoGuoFanKui", SqlDbType.VarChar,5000),
					new SqlParameter("@ZongTiJieLun", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = ID;
			parameters[1].Value = PeiXunName;
			parameters[2].Value = FanKuiZhuTi;
			parameters[3].Value = XiaoGuoFanKui;
			parameters[4].Value = ZongTiJieLun;
			parameters[5].Value = UserName;
			parameters[6].Value = TimeStr;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPPeiXunXiaoGuo ");
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
			strSql.Append("select  top 1 ID,PeiXunName,FanKuiZhuTi,XiaoGuoFanKui,ZongTiJieLun,UserName,TimeStr ");
			strSql.Append(" FROM ERPPeiXunXiaoGuo ");
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
				PeiXunName=ds.Tables[0].Rows[0]["PeiXunName"].ToString();
				FanKuiZhuTi=ds.Tables[0].Rows[0]["FanKuiZhuTi"].ToString();
				XiaoGuoFanKui=ds.Tables[0].Rows[0]["XiaoGuoFanKui"].ToString();
				ZongTiJieLun=ds.Tables[0].Rows[0]["ZongTiJieLun"].ToString();
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
			strSql.Append(" FROM ERPPeiXunXiaoGuo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

