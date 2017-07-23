using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
	/// <summary>
	/// ��ERPCarBaoXian��
	/// </summary>
	public class ERPCarBaoXian
	{
		public ERPCarBaoXian()
		{}
		#region Model
		private int _id;
		private string _carname;
		private string _feiyongname;
		private string _projectname;
		private string _baoxianprice;
		private string _baoxiandate;
		private string _tixingdate;
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
		/// ��������
		/// </summary>
		public string CarName
		{
			set{ _carname=value;}
			get{return _carname;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string FeiYongName
		{
			set{ _feiyongname=value;}
			get{return _feiyongname;}
		}
		/// <summary>
		/// ��Ŀ����
		/// </summary>
		public string ProjectName
		{
			set{ _projectname=value;}
			get{return _projectname;}
		}
		/// <summary>
		/// ���ս��
		/// </summary>
		public string BaoXianPrice
		{
			set{ _baoxianprice=value;}
			get{return _baoxianprice;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string BaoXianDate
		{
			set{ _baoxiandate=value;}
			get{return _baoxiandate;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string TiXingDate
		{
			set{ _tixingdate=value;}
			get{return _tixingdate;}
		}
		/// <summary>
		/// ¼����
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// ¼��ʱ��
		/// </summary>
		public DateTime? TimeStr
		{
			set{ _timestr=value;}
			get{return _timestr;}
		}
		/// <summary>
		/// ��ע˵��
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
		public ERPCarBaoXian(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CarName,FeiYongName,ProjectName,BaoXianPrice,BaoXianDate,TiXingDate,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPCarBaoXian ");
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
				FeiYongName=ds.Tables[0].Rows[0]["FeiYongName"].ToString();
				ProjectName=ds.Tables[0].Rows[0]["ProjectName"].ToString();
				BaoXianPrice=ds.Tables[0].Rows[0]["BaoXianPrice"].ToString();
				BaoXianDate=ds.Tables[0].Rows[0]["BaoXianDate"].ToString();
				TiXingDate=ds.Tables[0].Rows[0]["TiXingDate"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
			}
		}

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPCarBaoXian"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPCarBaoXian");
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
			strSql.Append("insert into ERPCarBaoXian(");
			strSql.Append("CarName,FeiYongName,ProjectName,BaoXianPrice,BaoXianDate,TiXingDate,UserName,TimeStr,BackInfo)");
			strSql.Append(" values (");
			strSql.Append("@CarName,@FeiYongName,@ProjectName,@BaoXianPrice,@BaoXianDate,@TiXingDate,@UserName,@TimeStr,@BackInfo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CarName", SqlDbType.VarChar,50),
					new SqlParameter("@FeiYongName", SqlDbType.VarChar,50),
					new SqlParameter("@ProjectName", SqlDbType.VarChar,50),
					new SqlParameter("@BaoXianPrice", SqlDbType.VarChar,50),
					new SqlParameter("@BaoXianDate", SqlDbType.VarChar,50),
					new SqlParameter("@TiXingDate", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = CarName;
			parameters[1].Value = FeiYongName;
			parameters[2].Value = ProjectName;
			parameters[3].Value = BaoXianPrice;
			parameters[4].Value = BaoXianDate;
			parameters[5].Value = TiXingDate;
			parameters[6].Value = UserName;
			parameters[7].Value = TimeStr;
			parameters[8].Value = BackInfo;

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
			strSql.Append("update ERPCarBaoXian set ");
			strSql.Append("CarName=@CarName,");
			strSql.Append("FeiYongName=@FeiYongName,");
			strSql.Append("ProjectName=@ProjectName,");
			strSql.Append("BaoXianPrice=@BaoXianPrice,");
			strSql.Append("BaoXianDate=@BaoXianDate,");
			strSql.Append("TiXingDate=@TiXingDate,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr,");
			strSql.Append("BackInfo=@BackInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@CarName", SqlDbType.VarChar,50),
					new SqlParameter("@FeiYongName", SqlDbType.VarChar,50),
					new SqlParameter("@ProjectName", SqlDbType.VarChar,50),
					new SqlParameter("@BaoXianPrice", SqlDbType.VarChar,50),
					new SqlParameter("@BaoXianDate", SqlDbType.VarChar,50),
					new SqlParameter("@TiXingDate", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = ID;
			parameters[1].Value = CarName;
			parameters[2].Value = FeiYongName;
			parameters[3].Value = ProjectName;
			parameters[4].Value = BaoXianPrice;
			parameters[5].Value = BaoXianDate;
			parameters[6].Value = TiXingDate;
			parameters[7].Value = UserName;
			parameters[8].Value = TimeStr;
			parameters[9].Value = BackInfo;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPCarBaoXian ");
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
			strSql.Append("select  top 1 ID,CarName,FeiYongName,ProjectName,BaoXianPrice,BaoXianDate,TiXingDate,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPCarBaoXian ");
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
				FeiYongName=ds.Tables[0].Rows[0]["FeiYongName"].ToString();
				ProjectName=ds.Tables[0].Rows[0]["ProjectName"].ToString();
				BaoXianPrice=ds.Tables[0].Rows[0]["BaoXianPrice"].ToString();
				BaoXianDate=ds.Tables[0].Rows[0]["BaoXianDate"].ToString();
				TiXingDate=ds.Tables[0].Rows[0]["TiXingDate"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
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
			strSql.Append(" FROM ERPCarBaoXian ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}

