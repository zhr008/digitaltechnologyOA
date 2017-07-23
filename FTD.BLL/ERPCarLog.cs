using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
	/// <summary>
	/// ��ERPCarLog��
	/// </summary>
	public class ERPCarLog
	{
		public ERPCarLog()
		{}
		#region Model
		private int _id;
		private string _carname;
		private string _logdate;
		private string _jingbanuser;
		private string _driveruser;
		private string _chuchedate;
		private string _startnum;
		private string _endnum;
		private string _xingshitime;
		private string _shiyou;
		private string _xingshilicheng;
		private string _youhaoshu;
		private string _daodaaddress;
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
		/// ��־����
		/// </summary>
		public string LogDate
		{
			set{ _logdate=value;}
			get{return _logdate;}
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
		/// ��������
		/// </summary>
		public string ChuCheDate
		{
			set{ _chuchedate=value;}
			get{return _chuchedate;}
		}
		/// <summary>
		/// ����ǰ��̱���
		/// </summary>
		public string StartNum
		{
			set{ _startnum=value;}
			get{return _startnum;}
		}
		/// <summary>
		/// ������̱���
		/// </summary>
		public string EndNum
		{
			set{ _endnum=value;}
			get{return _endnum;}
		}
		/// <summary>
		/// ��ʻʱ��
		/// </summary>
		public string XingShiTime
		{
			set{ _xingshitime=value;}
			get{return _xingshitime;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string ShiYou
		{
			set{ _shiyou=value;}
			get{return _shiyou;}
		}
		/// <summary>
		/// ��ʻ���
		/// </summary>
		public string XingShiLiCheng
		{
			set{ _xingshilicheng=value;}
			get{return _xingshilicheng;}
		}
		/// <summary>
		/// �ͺ���
		/// </summary>
		public string YouHaoShu
		{
			set{ _youhaoshu=value;}
			get{return _youhaoshu;}
		}
		/// <summary>
		/// ����ص�
		/// </summary>
		public string DaoDaAddress
		{
			set{ _daodaaddress=value;}
			get{return _daodaaddress;}
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
		public ERPCarLog(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CarName,LogDate,JingBanUser,DriverUser,ChuCheDate,StartNum,EndNum,XingShiTime,ShiYou,XingShiLiCheng,YouHaoShu,DaoDaAddress,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPCarLog ");
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
				LogDate=ds.Tables[0].Rows[0]["LogDate"].ToString();
				JingBanUser=ds.Tables[0].Rows[0]["JingBanUser"].ToString();
				DriverUser=ds.Tables[0].Rows[0]["DriverUser"].ToString();
				ChuCheDate=ds.Tables[0].Rows[0]["ChuCheDate"].ToString();
				StartNum=ds.Tables[0].Rows[0]["StartNum"].ToString();
				EndNum=ds.Tables[0].Rows[0]["EndNum"].ToString();
				XingShiTime=ds.Tables[0].Rows[0]["XingShiTime"].ToString();
				ShiYou=ds.Tables[0].Rows[0]["ShiYou"].ToString();
				XingShiLiCheng=ds.Tables[0].Rows[0]["XingShiLiCheng"].ToString();
				YouHaoShu=ds.Tables[0].Rows[0]["YouHaoShu"].ToString();
				DaoDaAddress=ds.Tables[0].Rows[0]["DaoDaAddress"].ToString();
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

		return DbHelperSQL.GetMaxID("ID", "ERPCarLog"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPCarLog");
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
			strSql.Append("insert into ERPCarLog(");
			strSql.Append("CarName,LogDate,JingBanUser,DriverUser,ChuCheDate,StartNum,EndNum,XingShiTime,ShiYou,XingShiLiCheng,YouHaoShu,DaoDaAddress,UserName,TimeStr,BackInfo)");
			strSql.Append(" values (");
			strSql.Append("@CarName,@LogDate,@JingBanUser,@DriverUser,@ChuCheDate,@StartNum,@EndNum,@XingShiTime,@ShiYou,@XingShiLiCheng,@YouHaoShu,@DaoDaAddress,@UserName,@TimeStr,@BackInfo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CarName", SqlDbType.VarChar,50),
					new SqlParameter("@LogDate", SqlDbType.VarChar,50),
					new SqlParameter("@JingBanUser", SqlDbType.VarChar,50),
					new SqlParameter("@DriverUser", SqlDbType.VarChar,50),
					new SqlParameter("@ChuCheDate", SqlDbType.VarChar,50),
					new SqlParameter("@StartNum", SqlDbType.VarChar,50),
					new SqlParameter("@EndNum", SqlDbType.VarChar,50),
					new SqlParameter("@XingShiTime", SqlDbType.VarChar,50),
					new SqlParameter("@ShiYou", SqlDbType.VarChar,5000),
					new SqlParameter("@XingShiLiCheng", SqlDbType.VarChar,50),
					new SqlParameter("@YouHaoShu", SqlDbType.VarChar,50),
					new SqlParameter("@DaoDaAddress", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = CarName;
			parameters[1].Value = LogDate;
			parameters[2].Value = JingBanUser;
			parameters[3].Value = DriverUser;
			parameters[4].Value = ChuCheDate;
			parameters[5].Value = StartNum;
			parameters[6].Value = EndNum;
			parameters[7].Value = XingShiTime;
			parameters[8].Value = ShiYou;
			parameters[9].Value = XingShiLiCheng;
			parameters[10].Value = YouHaoShu;
			parameters[11].Value = DaoDaAddress;
			parameters[12].Value = UserName;
			parameters[13].Value = TimeStr;
			parameters[14].Value = BackInfo;

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
			strSql.Append("update ERPCarLog set ");
			strSql.Append("CarName=@CarName,");
			strSql.Append("LogDate=@LogDate,");
			strSql.Append("JingBanUser=@JingBanUser,");
			strSql.Append("DriverUser=@DriverUser,");
			strSql.Append("ChuCheDate=@ChuCheDate,");
			strSql.Append("StartNum=@StartNum,");
			strSql.Append("EndNum=@EndNum,");
			strSql.Append("XingShiTime=@XingShiTime,");
			strSql.Append("ShiYou=@ShiYou,");
			strSql.Append("XingShiLiCheng=@XingShiLiCheng,");
			strSql.Append("YouHaoShu=@YouHaoShu,");
			strSql.Append("DaoDaAddress=@DaoDaAddress,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr,");
			strSql.Append("BackInfo=@BackInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@CarName", SqlDbType.VarChar,50),
					new SqlParameter("@LogDate", SqlDbType.VarChar,50),
					new SqlParameter("@JingBanUser", SqlDbType.VarChar,50),
					new SqlParameter("@DriverUser", SqlDbType.VarChar,50),
					new SqlParameter("@ChuCheDate", SqlDbType.VarChar,50),
					new SqlParameter("@StartNum", SqlDbType.VarChar,50),
					new SqlParameter("@EndNum", SqlDbType.VarChar,50),
					new SqlParameter("@XingShiTime", SqlDbType.VarChar,50),
					new SqlParameter("@ShiYou", SqlDbType.VarChar,5000),
					new SqlParameter("@XingShiLiCheng", SqlDbType.VarChar,50),
					new SqlParameter("@YouHaoShu", SqlDbType.VarChar,50),
					new SqlParameter("@DaoDaAddress", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = ID;
			parameters[1].Value = CarName;
			parameters[2].Value = LogDate;
			parameters[3].Value = JingBanUser;
			parameters[4].Value = DriverUser;
			parameters[5].Value = ChuCheDate;
			parameters[6].Value = StartNum;
			parameters[7].Value = EndNum;
			parameters[8].Value = XingShiTime;
			parameters[9].Value = ShiYou;
			parameters[10].Value = XingShiLiCheng;
			parameters[11].Value = YouHaoShu;
			parameters[12].Value = DaoDaAddress;
			parameters[13].Value = UserName;
			parameters[14].Value = TimeStr;
			parameters[15].Value = BackInfo;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPCarLog ");
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
			strSql.Append("select  top 1 ID,CarName,LogDate,JingBanUser,DriverUser,ChuCheDate,StartNum,EndNum,XingShiTime,ShiYou,XingShiLiCheng,YouHaoShu,DaoDaAddress,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPCarLog ");
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
				LogDate=ds.Tables[0].Rows[0]["LogDate"].ToString();
				JingBanUser=ds.Tables[0].Rows[0]["JingBanUser"].ToString();
				DriverUser=ds.Tables[0].Rows[0]["DriverUser"].ToString();
				ChuCheDate=ds.Tables[0].Rows[0]["ChuCheDate"].ToString();
				StartNum=ds.Tables[0].Rows[0]["StartNum"].ToString();
				EndNum=ds.Tables[0].Rows[0]["EndNum"].ToString();
				XingShiTime=ds.Tables[0].Rows[0]["XingShiTime"].ToString();
				ShiYou=ds.Tables[0].Rows[0]["ShiYou"].ToString();
				XingShiLiCheng=ds.Tables[0].Rows[0]["XingShiLiCheng"].ToString();
				YouHaoShu=ds.Tables[0].Rows[0]["YouHaoShu"].ToString();
				DaoDaAddress=ds.Tables[0].Rows[0]["DaoDaAddress"].ToString();
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
			strSql.Append(" FROM ERPCarLog ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}

