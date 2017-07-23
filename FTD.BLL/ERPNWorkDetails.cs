using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPNWorkDetails。
	/// </summary>
	public class ERPNWorkDetails
	{
		public ERPNWorkDetails()
		{}
		#region Model
		private int _id;
		private int? _workid;
		private string _itemsnamecn;
		private string _itemsnameen;
		private string _itemsvalue;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 对应工作
		/// </summary>
		public int? WorkID
		{
			set{ _workid=value;}
			get{return _workid;}
		}
		/// <summary>
		/// 列中文名
		/// </summary>
		public string ItemsNameCN
		{
			set{ _itemsnamecn=value;}
			get{return _itemsnamecn;}
		}
		/// <summary>
		/// 列英文名
		/// </summary>
		public string ItemsNameEn
		{
			set{ _itemsnameen=value;}
			get{return _itemsnameen;}
		}
		/// <summary>
		/// 列值
		/// </summary>
		public string ItemsValue
		{
			set{ _itemsvalue=value;}
			get{return _itemsvalue;}
		}
		#endregion Model


		#region  成员方法

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPNWorkDetails(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,WorkID,ItemsNameCN,ItemsNameEn,ItemsValue ");
			strSql.Append(" FROM ERPNWorkDetails ");
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
				if(ds.Tables[0].Rows[0]["WorkID"].ToString()!="")
				{
					WorkID=int.Parse(ds.Tables[0].Rows[0]["WorkID"].ToString());
				}
				ItemsNameCN=ds.Tables[0].Rows[0]["ItemsNameCN"].ToString();
				ItemsNameEn=ds.Tables[0].Rows[0]["ItemsNameEn"].ToString();
				ItemsValue=ds.Tables[0].Rows[0]["ItemsValue"].ToString();
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPNWorkDetails"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPNWorkDetails");
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
			strSql.Append("insert into ERPNWorkDetails(");
			strSql.Append("WorkID,ItemsNameCN,ItemsNameEn,ItemsValue)");
			strSql.Append(" values (");
			strSql.Append("@WorkID,@ItemsNameCN,@ItemsNameEn,@ItemsValue)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkID", SqlDbType.Int,4),
					new SqlParameter("@ItemsNameCN", SqlDbType.VarChar,50),
					new SqlParameter("@ItemsNameEn", SqlDbType.VarChar,50),
					new SqlParameter("@ItemsValue", SqlDbType.VarChar,8000)};
			parameters[0].Value = WorkID;
			parameters[1].Value = ItemsNameCN;
			parameters[2].Value = ItemsNameEn;
			parameters[3].Value = ItemsValue;

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
			strSql.Append("update ERPNWorkDetails set ");
			strSql.Append("WorkID=@WorkID,");
			strSql.Append("ItemsNameCN=@ItemsNameCN,");
			strSql.Append("ItemsNameEn=@ItemsNameEn,");
			strSql.Append("ItemsValue=@ItemsValue");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@WorkID", SqlDbType.Int,4),
					new SqlParameter("@ItemsNameCN", SqlDbType.VarChar,50),
					new SqlParameter("@ItemsNameEn", SqlDbType.VarChar,50),
					new SqlParameter("@ItemsValue", SqlDbType.VarChar,8000)};
			parameters[0].Value = ID;
			parameters[1].Value = WorkID;
			parameters[2].Value = ItemsNameCN;
			parameters[3].Value = ItemsNameEn;
			parameters[4].Value = ItemsValue;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPNWorkDetails ");
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
			strSql.Append("select  top 1 ID,WorkID,ItemsNameCN,ItemsNameEn,ItemsValue ");
			strSql.Append(" FROM ERPNWorkDetails ");
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
				if(ds.Tables[0].Rows[0]["WorkID"].ToString()!="")
				{
					WorkID=int.Parse(ds.Tables[0].Rows[0]["WorkID"].ToString());
				}
				ItemsNameCN=ds.Tables[0].Rows[0]["ItemsNameCN"].ToString();
				ItemsNameEn=ds.Tables[0].Rows[0]["ItemsNameEn"].ToString();
				ItemsValue=ds.Tables[0].Rows[0]["ItemsValue"].ToString();
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPNWorkDetails ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

