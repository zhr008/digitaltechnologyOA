using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
	/// <summary>
	/// ��ERPReportType��
	/// </summary>
	public class ERPReportType
	{
		public ERPReportType()
		{}
		#region Model
		private int _id;
		private string _typename;
		private string _backinfo;
		private string _paixustr;
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
		/// ��ע
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		/// <summary>
		/// �����ַ�
		/// </summary>
		public string PaiXuStr
		{
			set{ _paixustr=value;}
			get{return _paixustr;}
		}
		#endregion Model


		#region  ��Ա����

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ERPReportType(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,TypeName,BackInfo,PaiXuStr ");
			strSql.Append(" FROM ERPReportType ");
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
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				PaiXuStr=ds.Tables[0].Rows[0]["PaiXuStr"].ToString();
			}
		}

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPReportType"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPReportType");
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
			strSql.Append("insert into ERPReportType(");
			strSql.Append("TypeName,BackInfo,PaiXuStr)");
			strSql.Append(" values (");
			strSql.Append("@TypeName,@BackInfo,@PaiXuStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,500),
					new SqlParameter("@PaiXuStr", SqlDbType.VarChar,50)};
			parameters[0].Value = TypeName;
			parameters[1].Value = BackInfo;
			parameters[2].Value = PaiXuStr;

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
			strSql.Append("update ERPReportType set ");
			strSql.Append("TypeName=@TypeName,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append("PaiXuStr=@PaiXuStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,500),
					new SqlParameter("@PaiXuStr", SqlDbType.VarChar,50)};
			parameters[0].Value = ID;
			parameters[1].Value = TypeName;
			parameters[2].Value = BackInfo;
			parameters[3].Value = PaiXuStr;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPReportType ");
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
			strSql.Append("select  top 1 ID,TypeName,BackInfo,PaiXuStr ");
			strSql.Append(" FROM ERPReportType ");
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
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				PaiXuStr=ds.Tables[0].Rows[0]["PaiXuStr"].ToString();
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPReportType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}

