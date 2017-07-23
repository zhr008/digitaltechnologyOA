using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
	/// <summary>
	/// ��ERPCarWeiZhang��
	/// </summary>
	public class ERPCarWeiZhang
	{
		public ERPCarWeiZhang()
		{}
		#region Model
		private int _id;
		private string _carname;
		private string _wzdate;
		private string _driveruser;
		private string _wzaddress;
		private string _koufennum;
		private string _fkjine;
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
		/// Υ������
		/// </summary>
		public string WZDate
		{
			set{ _wzdate=value;}
			get{return _wzdate;}
		}
		/// <summary>
		/// ˾��
		/// </summary>
		public string DriverUser
		{
			set{ _driveruser=value;}
			get{return _driveruser;}
		}
		/// <summary>
		/// Υ�µص�
		/// </summary>
		public string WZAddress
		{
			set{ _wzaddress=value;}
			get{return _wzaddress;}
		}
		/// <summary>
		/// �۷���
		/// </summary>
		public string KouFenNum
		{
			set{ _koufennum=value;}
			get{return _koufennum;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public string FKJinE
		{
			set{ _fkjine=value;}
			get{return _fkjine;}
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
		public ERPCarWeiZhang(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CarName,WZDate,DriverUser,WZAddress,KouFenNum,FKJinE,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPCarWeiZhang ");
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
				WZDate=ds.Tables[0].Rows[0]["WZDate"].ToString();
				DriverUser=ds.Tables[0].Rows[0]["DriverUser"].ToString();
				WZAddress=ds.Tables[0].Rows[0]["WZAddress"].ToString();
				KouFenNum=ds.Tables[0].Rows[0]["KouFenNum"].ToString();
				FKJinE=ds.Tables[0].Rows[0]["FKJinE"].ToString();
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

		return DbHelperSQL.GetMaxID("ID", "ERPCarWeiZhang"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPCarWeiZhang");
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
			strSql.Append("insert into ERPCarWeiZhang(");
			strSql.Append("CarName,WZDate,DriverUser,WZAddress,KouFenNum,FKJinE,UserName,TimeStr,BackInfo)");
			strSql.Append(" values (");
			strSql.Append("@CarName,@WZDate,@DriverUser,@WZAddress,@KouFenNum,@FKJinE,@UserName,@TimeStr,@BackInfo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CarName", SqlDbType.VarChar,50),
					new SqlParameter("@WZDate", SqlDbType.VarChar,50),
					new SqlParameter("@DriverUser", SqlDbType.VarChar,50),
					new SqlParameter("@WZAddress", SqlDbType.VarChar,50),
					new SqlParameter("@KouFenNum", SqlDbType.VarChar,50),
					new SqlParameter("@FKJinE", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = CarName;
			parameters[1].Value = WZDate;
			parameters[2].Value = DriverUser;
			parameters[3].Value = WZAddress;
			parameters[4].Value = KouFenNum;
			parameters[5].Value = FKJinE;
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
			strSql.Append("update ERPCarWeiZhang set ");
			strSql.Append("CarName=@CarName,");
			strSql.Append("WZDate=@WZDate,");
			strSql.Append("DriverUser=@DriverUser,");
			strSql.Append("WZAddress=@WZAddress,");
			strSql.Append("KouFenNum=@KouFenNum,");
			strSql.Append("FKJinE=@FKJinE,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr,");
			strSql.Append("BackInfo=@BackInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@CarName", SqlDbType.VarChar,50),
					new SqlParameter("@WZDate", SqlDbType.VarChar,50),
					new SqlParameter("@DriverUser", SqlDbType.VarChar,50),
					new SqlParameter("@WZAddress", SqlDbType.VarChar,50),
					new SqlParameter("@KouFenNum", SqlDbType.VarChar,50),
					new SqlParameter("@FKJinE", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = ID;
			parameters[1].Value = CarName;
			parameters[2].Value = WZDate;
			parameters[3].Value = DriverUser;
			parameters[4].Value = WZAddress;
			parameters[5].Value = KouFenNum;
			parameters[6].Value = FKJinE;
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
			strSql.Append("delete from ERPCarWeiZhang ");
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
			strSql.Append("select  top 1 ID,CarName,WZDate,DriverUser,WZAddress,KouFenNum,FKJinE,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPCarWeiZhang ");
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
				WZDate=ds.Tables[0].Rows[0]["WZDate"].ToString();
				DriverUser=ds.Tables[0].Rows[0]["DriverUser"].ToString();
				WZAddress=ds.Tables[0].Rows[0]["WZAddress"].ToString();
				KouFenNum=ds.Tables[0].Rows[0]["KouFenNum"].ToString();
				FKJinE=ds.Tables[0].Rows[0]["FKJinE"].ToString();
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
			strSql.Append(" FROM ERPCarWeiZhang ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}

