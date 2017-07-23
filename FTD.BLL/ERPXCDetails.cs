using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
	/// <summary>
	/// ��ERPXCDetails��
	/// </summary>
	public class ERPXCDetails
	{
		public ERPXCDetails()
		{}
		#region Model
		private int _id;
		private int? _xcid;
		private int? _itemsid;
		private string _username;
		private string _numstr;
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
		public int? XCID
		{
			set{ _xcid=value;}
			get{return _xcid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ItemsID
		{
			set{ _itemsid=value;}
			get{return _itemsid;}
		}
		/// <summary>
		/// �û���
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NumStr
		{
			set{ _numstr=value;}
			get{return _numstr;}
		}
		#endregion Model


		#region  ��Ա����

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ERPXCDetails(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,XCID,ItemsID,UserName,NumStr ");
			strSql.Append(" FROM ERPXCDetails ");
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
				if(ds.Tables[0].Rows[0]["XCID"].ToString()!="")
				{
					XCID=int.Parse(ds.Tables[0].Rows[0]["XCID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ItemsID"].ToString()!="")
				{
					ItemsID=int.Parse(ds.Tables[0].Rows[0]["ItemsID"].ToString());
				}
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				NumStr=ds.Tables[0].Rows[0]["NumStr"].ToString();
			}
		}

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPXCDetails"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPXCDetails");
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
			strSql.Append("insert into ERPXCDetails(");
			strSql.Append("XCID,ItemsID,UserName,NumStr)");
			strSql.Append(" values (");
			strSql.Append("@XCID,@ItemsID,@UserName,@NumStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@XCID", SqlDbType.Int,4),
					new SqlParameter("@ItemsID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@NumStr", SqlDbType.VarChar,50)};
			parameters[0].Value = XCID;
			parameters[1].Value = ItemsID;
			parameters[2].Value = UserName;
			parameters[3].Value = NumStr;

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
			strSql.Append("update ERPXCDetails set ");
			strSql.Append("XCID=@XCID,");
			strSql.Append("ItemsID=@ItemsID,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("NumStr=@NumStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@XCID", SqlDbType.Int,4),
					new SqlParameter("@ItemsID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@NumStr", SqlDbType.VarChar,50)};
			parameters[0].Value = ID;
			parameters[1].Value = XCID;
			parameters[2].Value = ItemsID;
			parameters[3].Value = UserName;
			parameters[4].Value = NumStr;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPXCDetails ");
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
			strSql.Append("select  top 1 ID,XCID,ItemsID,UserName,NumStr ");
			strSql.Append(" FROM ERPXCDetails ");
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
				if(ds.Tables[0].Rows[0]["XCID"].ToString()!="")
				{
					XCID=int.Parse(ds.Tables[0].Rows[0]["XCID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ItemsID"].ToString()!="")
				{
					ItemsID=int.Parse(ds.Tables[0].Rows[0]["ItemsID"].ToString());
				}
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				NumStr=ds.Tables[0].Rows[0]["NumStr"].ToString();
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPXCDetails ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}

