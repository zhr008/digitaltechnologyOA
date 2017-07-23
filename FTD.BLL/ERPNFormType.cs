using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
	/// <summary>
	/// ��ERPNFormType��
	/// </summary>
	public class ERPNFormType
	{
		public ERPNFormType()
		{}
		#region Model
		private int _id;
		private string _typename;
		private string _paixustr;
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
		/// ��������
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// �����ַ�
		/// </summary>
		public string PaiXuStr
		{
			set{ _paixustr=value;}
			get{return _paixustr;}
		}
		/// <summary>
		/// ��Ҫ˵��
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		#endregion Model


		#region  ��Ա����

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ERPNFormType(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,TypeName,PaiXuStr,BackInfo ");
			strSql.Append(" FROM ERPNFormType ");
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
				TypeName=ds.Tables[0].Rows[0]["TypeName"].ToString();
				PaiXuStr=ds.Tables[0].Rows[0]["PaiXuStr"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
			}
		}

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPNFormType"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPNFormType");
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
			strSql.Append("insert into ERPNFormType(");
			strSql.Append("TypeName,PaiXuStr,BackInfo)");
			strSql.Append(" values (");
			strSql.Append("@TypeName,@PaiXuStr,@BackInfo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@PaiXuStr", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,2000)};
			parameters[0].Value = TypeName;
			parameters[1].Value = PaiXuStr;
			parameters[2].Value = BackInfo;

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
			strSql.Append("update ERPNFormType set ");
			strSql.Append("TypeName=@TypeName,");
			strSql.Append("PaiXuStr=@PaiXuStr,");
			strSql.Append("BackInfo=@BackInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@PaiXuStr", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,2000)};
			parameters[0].Value = ID;
			parameters[1].Value = TypeName;
			parameters[2].Value = PaiXuStr;
			parameters[3].Value = BackInfo;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPNFormType ");
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
			strSql.Append("select  top 1 ID,TypeName,PaiXuStr,BackInfo ");
			strSql.Append(" FROM ERPNFormType ");
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
				TypeName=ds.Tables[0].Rows[0]["TypeName"].ToString();
				PaiXuStr=ds.Tables[0].Rows[0]["PaiXuStr"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPNFormType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}

