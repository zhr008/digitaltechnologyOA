using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
	/// <summary>
	/// ��ERPCarJiaYou��
	/// </summary>
	public class ERPCarJiaYou
	{
		public ERPCarJiaYou()
		{}
		#region Model
		private int _id;
		private string _carname;
		private string _jydate;
		private string _jingbanuser;
		private string _driveruser;
		private string _jiayouaddress;
		private string _startnum;
		private string _jiayounum;
		private string _youfeijine;
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
		public string JYDate
		{
			set{ _jydate=value;}
			get{return _jydate;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public string JingBanUser
		{
			set{ _jingbanuser=value;}
			get{return _jingbanuser;}
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
		/// ���͵ص�
		/// </summary>
		public string JiaYouAddress
		{
			set{ _jiayouaddress=value;}
			get{return _jiayouaddress;}
		}
		/// <summary>
		/// ��ʼ����
		/// </summary>
		public string StartNum
		{
			set{ _startnum=value;}
			get{return _startnum;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public string JiaYouNum
		{
			set{ _jiayounum=value;}
			get{return _jiayounum;}
		}
		/// <summary>
		/// ���ͷ���
		/// </summary>
		public string YouFeiJinE
		{
			set{ _youfeijine=value;}
			get{return _youfeijine;}
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
		public ERPCarJiaYou(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CarName,JYDate,JingBanUser,DriverUser,JiaYouAddress,StartNum,JiaYouNum,YouFeiJinE,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPCarJiaYou ");
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
				JYDate=ds.Tables[0].Rows[0]["JYDate"].ToString();
				JingBanUser=ds.Tables[0].Rows[0]["JingBanUser"].ToString();
				DriverUser=ds.Tables[0].Rows[0]["DriverUser"].ToString();
				JiaYouAddress=ds.Tables[0].Rows[0]["JiaYouAddress"].ToString();
				StartNum=ds.Tables[0].Rows[0]["StartNum"].ToString();
				JiaYouNum=ds.Tables[0].Rows[0]["JiaYouNum"].ToString();
				YouFeiJinE=ds.Tables[0].Rows[0]["YouFeiJinE"].ToString();
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

		return DbHelperSQL.GetMaxID("ID", "ERPCarJiaYou"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPCarJiaYou");
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
			strSql.Append("insert into ERPCarJiaYou(");
			strSql.Append("CarName,JYDate,JingBanUser,DriverUser,JiaYouAddress,StartNum,JiaYouNum,YouFeiJinE,UserName,TimeStr,BackInfo)");
			strSql.Append(" values (");
			strSql.Append("@CarName,@JYDate,@JingBanUser,@DriverUser,@JiaYouAddress,@StartNum,@JiaYouNum,@YouFeiJinE,@UserName,@TimeStr,@BackInfo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CarName", SqlDbType.VarChar,50),
					new SqlParameter("@JYDate", SqlDbType.VarChar,50),
					new SqlParameter("@JingBanUser", SqlDbType.VarChar,50),
					new SqlParameter("@DriverUser", SqlDbType.VarChar,50),
					new SqlParameter("@JiaYouAddress", SqlDbType.VarChar,50),
					new SqlParameter("@StartNum", SqlDbType.VarChar,50),
					new SqlParameter("@JiaYouNum", SqlDbType.VarChar,50),
					new SqlParameter("@YouFeiJinE", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = CarName;
			parameters[1].Value = JYDate;
			parameters[2].Value = JingBanUser;
			parameters[3].Value = DriverUser;
			parameters[4].Value = JiaYouAddress;
			parameters[5].Value = StartNum;
			parameters[6].Value = JiaYouNum;
			parameters[7].Value = YouFeiJinE;
			parameters[8].Value = UserName;
			parameters[9].Value = TimeStr;
			parameters[10].Value = BackInfo;

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
			strSql.Append("update ERPCarJiaYou set ");
			strSql.Append("CarName=@CarName,");
			strSql.Append("JYDate=@JYDate,");
			strSql.Append("JingBanUser=@JingBanUser,");
			strSql.Append("DriverUser=@DriverUser,");
			strSql.Append("JiaYouAddress=@JiaYouAddress,");
			strSql.Append("StartNum=@StartNum,");
			strSql.Append("JiaYouNum=@JiaYouNum,");
			strSql.Append("YouFeiJinE=@YouFeiJinE,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr,");
			strSql.Append("BackInfo=@BackInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@CarName", SqlDbType.VarChar,50),
					new SqlParameter("@JYDate", SqlDbType.VarChar,50),
					new SqlParameter("@JingBanUser", SqlDbType.VarChar,50),
					new SqlParameter("@DriverUser", SqlDbType.VarChar,50),
					new SqlParameter("@JiaYouAddress", SqlDbType.VarChar,50),
					new SqlParameter("@StartNum", SqlDbType.VarChar,50),
					new SqlParameter("@JiaYouNum", SqlDbType.VarChar,50),
					new SqlParameter("@YouFeiJinE", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = ID;
			parameters[1].Value = CarName;
			parameters[2].Value = JYDate;
			parameters[3].Value = JingBanUser;
			parameters[4].Value = DriverUser;
			parameters[5].Value = JiaYouAddress;
			parameters[6].Value = StartNum;
			parameters[7].Value = JiaYouNum;
			parameters[8].Value = YouFeiJinE;
			parameters[9].Value = UserName;
			parameters[10].Value = TimeStr;
			parameters[11].Value = BackInfo;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPCarJiaYou ");
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
			strSql.Append("select  top 1 ID,CarName,JYDate,JingBanUser,DriverUser,JiaYouAddress,StartNum,JiaYouNum,YouFeiJinE,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPCarJiaYou ");
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
				JYDate=ds.Tables[0].Rows[0]["JYDate"].ToString();
				JingBanUser=ds.Tables[0].Rows[0]["JingBanUser"].ToString();
				DriverUser=ds.Tables[0].Rows[0]["DriverUser"].ToString();
				JiaYouAddress=ds.Tables[0].Rows[0]["JiaYouAddress"].ToString();
				StartNum=ds.Tables[0].Rows[0]["StartNum"].ToString();
				JiaYouNum=ds.Tables[0].Rows[0]["JiaYouNum"].ToString();
				YouFeiJinE=ds.Tables[0].Rows[0]["YouFeiJinE"].ToString();
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
			strSql.Append(" FROM ERPCarJiaYou ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}

