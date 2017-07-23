using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPXueXiXinDe。
	/// </summary>
	public class ERPXueXiXinDe
	{
		public ERPXueXiXinDe()
		{}
		#region Model
		private int _id;
		private string _xindetitle;
		private string _xindecontent;
		private string _fujianstr;
		private string _shenpicontent;
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
		/// 心得标题
		/// </summary>
		public string XinDeTitle
		{
			set{ _xindetitle=value;}
			get{return _xindetitle;}
		}
		/// <summary>
		/// 心得内容
		/// </summary>
		public string XinDeContent
		{
			set{ _xindecontent=value;}
			get{return _xindecontent;}
		}
		/// <summary>
		/// 附件文件
		/// </summary>
		public string FuJianStr
		{
			set{ _fujianstr=value;}
			get{return _fujianstr;}
		}
		/// <summary>
		/// 领导意见
		/// </summary>
		public string ShenPiContent
		{
			set{ _shenpicontent=value;}
			get{return _shenpicontent;}
		}
		/// <summary>
		/// 撰写用户
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 撰写时间
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
		public ERPXueXiXinDe(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,XinDeTitle,XinDeContent,FuJianStr,ShenPiContent,UserName,TimeStr ");
			strSql.Append(" FROM ERPXueXiXinDe ");
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
				XinDeTitle=ds.Tables[0].Rows[0]["XinDeTitle"].ToString();
				XinDeContent=ds.Tables[0].Rows[0]["XinDeContent"].ToString();
				FuJianStr=ds.Tables[0].Rows[0]["FuJianStr"].ToString();
				ShenPiContent=ds.Tables[0].Rows[0]["ShenPiContent"].ToString();
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

		return DbHelperSQL.GetMaxID("ID", "ERPXueXiXinDe"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPXueXiXinDe");
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
			strSql.Append("insert into ERPXueXiXinDe(");
			strSql.Append("XinDeTitle,XinDeContent,FuJianStr,ShenPiContent,UserName,TimeStr)");
			strSql.Append(" values (");
			strSql.Append("@XinDeTitle,@XinDeContent,@FuJianStr,@ShenPiContent,@UserName,@TimeStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@XinDeTitle", SqlDbType.VarChar,200),
					new SqlParameter("@XinDeContent", SqlDbType.Text),
					new SqlParameter("@FuJianStr", SqlDbType.VarChar,500),
					new SqlParameter("@ShenPiContent", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = XinDeTitle;
			parameters[1].Value = XinDeContent;
			parameters[2].Value = FuJianStr;
			parameters[3].Value = ShenPiContent;
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
			strSql.Append("update ERPXueXiXinDe set ");
			strSql.Append("XinDeTitle=@XinDeTitle,");
			strSql.Append("XinDeContent=@XinDeContent,");
			strSql.Append("FuJianStr=@FuJianStr,");
			strSql.Append("ShenPiContent=@ShenPiContent,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@XinDeTitle", SqlDbType.VarChar,200),
					new SqlParameter("@XinDeContent", SqlDbType.Text),
					new SqlParameter("@FuJianStr", SqlDbType.VarChar,500),
					new SqlParameter("@ShenPiContent", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = ID;
			parameters[1].Value = XinDeTitle;
			parameters[2].Value = XinDeContent;
			parameters[3].Value = FuJianStr;
			parameters[4].Value = ShenPiContent;
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
			strSql.Append("delete from ERPXueXiXinDe ");
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
			strSql.Append("select  top 1 ID,XinDeTitle,XinDeContent,FuJianStr,ShenPiContent,UserName,TimeStr ");
			strSql.Append(" FROM ERPXueXiXinDe ");
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
				XinDeTitle=ds.Tables[0].Rows[0]["XinDeTitle"].ToString();
				XinDeContent=ds.Tables[0].Rows[0]["XinDeContent"].ToString();
				FuJianStr=ds.Tables[0].Rows[0]["FuJianStr"].ToString();
				ShenPiContent=ds.Tables[0].Rows[0]["ShenPiContent"].ToString();
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
			strSql.Append(" FROM ERPXueXiXinDe ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

