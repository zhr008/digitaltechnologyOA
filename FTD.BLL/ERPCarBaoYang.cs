using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
	/// <summary>
	/// ��ERPCarBaoYang��
	/// </summary>
	public class ERPCarBaoYang
	{
		public ERPCarBaoYang()
		{}
		#region Model
		private int _id;
		private string _carname;
		private string _bydate;
		private string _jingbanuser;
		private string _zhuguanuser;
		private string _byqianlcbnum;
		private string _qiyoujine;
		private string _byjine;
		private string _weixiujine;
		private string _otherjine;
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
		public string BYDate
		{
			set{ _bydate=value;}
			get{return _bydate;}
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
		/// ����
		/// </summary>
		public string ZhuGuanUser
		{
			set{ _zhuguanuser=value;}
			get{return _zhuguanuser;}
		}
		/// <summary>
		/// ����ǰ��̱���
		/// </summary>
		public string BYQianLCBNum
		{
			set{ _byqianlcbnum=value;}
			get{return _byqianlcbnum;}
		}
		/// <summary>
		/// ���ͽ��
		/// </summary>
		public string QiYouJinE
		{
			set{ _qiyoujine=value;}
			get{return _qiyoujine;}
		}
		/// <summary>
		/// �������
		/// </summary>
		public string BYJinE
		{
			set{ _byjine=value;}
			get{return _byjine;}
		}
		/// <summary>
		/// ά�޽��
		/// </summary>
		public string WeiXiuJinE
		{
			set{ _weixiujine=value;}
			get{return _weixiujine;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string OtherJinE
		{
			set{ _otherjine=value;}
			get{return _otherjine;}
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
		public ERPCarBaoYang(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CarName,BYDate,JingBanUser,ZhuGuanUser,BYQianLCBNum,QiYouJinE,BYJinE,WeiXiuJinE,OtherJinE,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPCarBaoYang ");
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
				BYDate=ds.Tables[0].Rows[0]["BYDate"].ToString();
				JingBanUser=ds.Tables[0].Rows[0]["JingBanUser"].ToString();
				ZhuGuanUser=ds.Tables[0].Rows[0]["ZhuGuanUser"].ToString();
				BYQianLCBNum=ds.Tables[0].Rows[0]["BYQianLCBNum"].ToString();
				QiYouJinE=ds.Tables[0].Rows[0]["QiYouJinE"].ToString();
				BYJinE=ds.Tables[0].Rows[0]["BYJinE"].ToString();
				WeiXiuJinE=ds.Tables[0].Rows[0]["WeiXiuJinE"].ToString();
				OtherJinE=ds.Tables[0].Rows[0]["OtherJinE"].ToString();
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

		return DbHelperSQL.GetMaxID("ID", "ERPCarBaoYang"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPCarBaoYang");
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
			strSql.Append("insert into ERPCarBaoYang(");
			strSql.Append("CarName,BYDate,JingBanUser,ZhuGuanUser,BYQianLCBNum,QiYouJinE,BYJinE,WeiXiuJinE,OtherJinE,UserName,TimeStr,BackInfo)");
			strSql.Append(" values (");
			strSql.Append("@CarName,@BYDate,@JingBanUser,@ZhuGuanUser,@BYQianLCBNum,@QiYouJinE,@BYJinE,@WeiXiuJinE,@OtherJinE,@UserName,@TimeStr,@BackInfo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CarName", SqlDbType.VarChar,50),
					new SqlParameter("@BYDate", SqlDbType.VarChar,50),
					new SqlParameter("@JingBanUser", SqlDbType.VarChar,50),
					new SqlParameter("@ZhuGuanUser", SqlDbType.VarChar,50),
					new SqlParameter("@BYQianLCBNum", SqlDbType.VarChar,50),
					new SqlParameter("@QiYouJinE", SqlDbType.VarChar,50),
					new SqlParameter("@BYJinE", SqlDbType.VarChar,50),
					new SqlParameter("@WeiXiuJinE", SqlDbType.VarChar,50),
					new SqlParameter("@OtherJinE", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = CarName;
			parameters[1].Value = BYDate;
			parameters[2].Value = JingBanUser;
			parameters[3].Value = ZhuGuanUser;
			parameters[4].Value = BYQianLCBNum;
			parameters[5].Value = QiYouJinE;
			parameters[6].Value = BYJinE;
			parameters[7].Value = WeiXiuJinE;
			parameters[8].Value = OtherJinE;
			parameters[9].Value = UserName;
			parameters[10].Value = TimeStr;
			parameters[11].Value = BackInfo;

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
			strSql.Append("update ERPCarBaoYang set ");
			strSql.Append("CarName=@CarName,");
			strSql.Append("BYDate=@BYDate,");
			strSql.Append("JingBanUser=@JingBanUser,");
			strSql.Append("ZhuGuanUser=@ZhuGuanUser,");
			strSql.Append("BYQianLCBNum=@BYQianLCBNum,");
			strSql.Append("QiYouJinE=@QiYouJinE,");
			strSql.Append("BYJinE=@BYJinE,");
			strSql.Append("WeiXiuJinE=@WeiXiuJinE,");
			strSql.Append("OtherJinE=@OtherJinE,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr,");
			strSql.Append("BackInfo=@BackInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@CarName", SqlDbType.VarChar,50),
					new SqlParameter("@BYDate", SqlDbType.VarChar,50),
					new SqlParameter("@JingBanUser", SqlDbType.VarChar,50),
					new SqlParameter("@ZhuGuanUser", SqlDbType.VarChar,50),
					new SqlParameter("@BYQianLCBNum", SqlDbType.VarChar,50),
					new SqlParameter("@QiYouJinE", SqlDbType.VarChar,50),
					new SqlParameter("@BYJinE", SqlDbType.VarChar,50),
					new SqlParameter("@WeiXiuJinE", SqlDbType.VarChar,50),
					new SqlParameter("@OtherJinE", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = ID;
			parameters[1].Value = CarName;
			parameters[2].Value = BYDate;
			parameters[3].Value = JingBanUser;
			parameters[4].Value = ZhuGuanUser;
			parameters[5].Value = BYQianLCBNum;
			parameters[6].Value = QiYouJinE;
			parameters[7].Value = BYJinE;
			parameters[8].Value = WeiXiuJinE;
			parameters[9].Value = OtherJinE;
			parameters[10].Value = UserName;
			parameters[11].Value = TimeStr;
			parameters[12].Value = BackInfo;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPCarBaoYang ");
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
			strSql.Append("select  top 1 ID,CarName,BYDate,JingBanUser,ZhuGuanUser,BYQianLCBNum,QiYouJinE,BYJinE,WeiXiuJinE,OtherJinE,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPCarBaoYang ");
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
				BYDate=ds.Tables[0].Rows[0]["BYDate"].ToString();
				JingBanUser=ds.Tables[0].Rows[0]["JingBanUser"].ToString();
				ZhuGuanUser=ds.Tables[0].Rows[0]["ZhuGuanUser"].ToString();
				BYQianLCBNum=ds.Tables[0].Rows[0]["BYQianLCBNum"].ToString();
				QiYouJinE=ds.Tables[0].Rows[0]["QiYouJinE"].ToString();
				BYJinE=ds.Tables[0].Rows[0]["BYJinE"].ToString();
				WeiXiuJinE=ds.Tables[0].Rows[0]["WeiXiuJinE"].ToString();
				OtherJinE=ds.Tables[0].Rows[0]["OtherJinE"].ToString();
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
			strSql.Append(" FROM ERPCarBaoYang ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}

