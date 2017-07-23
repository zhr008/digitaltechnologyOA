using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
	/// <summary>
	/// ��ERPPeiXun��
	/// </summary>
	public class ERPPeiXun
	{
		public ERPPeiXun()
		{}
		#region Model
		private int _id;
		private string _peixunname;
		private string _peixunuser;
		private string _canyuuser;
		private string _startdate;
		private string _enddate;
		private string _peixunmudi;
		private string _peixunneirong;
		private string _xiaoguo;
		private string _backinfo;
		private string _fujianlist;
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
		/// ��ѵ����
		/// </summary>
		public string PeiXunName
		{
			set{ _peixunname=value;}
			get{return _peixunname;}
		}
		/// <summary>
		/// ��ѵ��
		/// </summary>
		public string PeiXunUser
		{
			set{ _peixunuser=value;}
			get{return _peixunuser;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public string CanYuUser
		{
			set{ _canyuuser=value;}
			get{return _canyuuser;}
		}
		/// <summary>
		/// ��ʼʱ��
		/// </summary>
		public string StartDate
		{
			set{ _startdate=value;}
			get{return _startdate;}
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public string EndDate
		{
			set{ _enddate=value;}
			get{return _enddate;}
		}
		/// <summary>
		/// ��ѵĿ��
		/// </summary>
		public string PeiXunMuDi
		{
			set{ _peixunmudi=value;}
			get{return _peixunmudi;}
		}
		/// <summary>
		/// ��ѵ����
		/// </summary>
		public string PeiXunNeiRong
		{
			set{ _peixunneirong=value;}
			get{return _peixunneirong;}
		}
		/// <summary>
		/// ��ѵЧ��
		/// </summary>
		public string XiaoGuo
		{
			set{ _xiaoguo=value;}
			get{return _xiaoguo;}
		}
		/// <summary>
		/// ��ע˵��
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		/// <summary>
		/// �����ļ�
		/// </summary>
		public string FuJianList
		{
			set{ _fujianlist=value;}
			get{return _fujianlist;}
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
		#endregion Model


		#region  ��Ա����

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ERPPeiXun(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,PeiXunName,PeiXunUser,CanYuUser,StartDate,EndDate,PeiXunMuDi,PeiXunNeiRong,XiaoGuo,BackInfo,FuJianList,UserName,TimeStr ");
			strSql.Append(" FROM ERPPeiXun ");
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
				PeiXunName=ds.Tables[0].Rows[0]["PeiXunName"].ToString();
				PeiXunUser=ds.Tables[0].Rows[0]["PeiXunUser"].ToString();
				CanYuUser=ds.Tables[0].Rows[0]["CanYuUser"].ToString();
				StartDate=ds.Tables[0].Rows[0]["StartDate"].ToString();
				EndDate=ds.Tables[0].Rows[0]["EndDate"].ToString();
				PeiXunMuDi=ds.Tables[0].Rows[0]["PeiXunMuDi"].ToString();
				PeiXunNeiRong=ds.Tables[0].Rows[0]["PeiXunNeiRong"].ToString();
				XiaoGuo=ds.Tables[0].Rows[0]["XiaoGuo"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				FuJianList=ds.Tables[0].Rows[0]["FuJianList"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
			}
		}

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPPeiXun"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPPeiXun");
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
			strSql.Append("insert into ERPPeiXun(");
			strSql.Append("PeiXunName,PeiXunUser,CanYuUser,StartDate,EndDate,PeiXunMuDi,PeiXunNeiRong,XiaoGuo,BackInfo,FuJianList,UserName,TimeStr)");
			strSql.Append(" values (");
			strSql.Append("@PeiXunName,@PeiXunUser,@CanYuUser,@StartDate,@EndDate,@PeiXunMuDi,@PeiXunNeiRong,@XiaoGuo,@BackInfo,@FuJianList,@UserName,@TimeStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@PeiXunName", SqlDbType.VarChar,50),
					new SqlParameter("@PeiXunUser", SqlDbType.VarChar,50),
					new SqlParameter("@CanYuUser", SqlDbType.VarChar,8000),
					new SqlParameter("@StartDate", SqlDbType.VarChar,50),
					new SqlParameter("@EndDate", SqlDbType.VarChar,50),
					new SqlParameter("@PeiXunMuDi", SqlDbType.VarChar,5000),
					new SqlParameter("@PeiXunNeiRong", SqlDbType.VarChar,5000),
					new SqlParameter("@XiaoGuo", SqlDbType.VarChar,5000),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@FuJianList", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = PeiXunName;
			parameters[1].Value = PeiXunUser;
			parameters[2].Value = CanYuUser;
			parameters[3].Value = StartDate;
			parameters[4].Value = EndDate;
			parameters[5].Value = PeiXunMuDi;
			parameters[6].Value = PeiXunNeiRong;
			parameters[7].Value = XiaoGuo;
			parameters[8].Value = BackInfo;
			parameters[9].Value = FuJianList;
			parameters[10].Value = UserName;
			parameters[11].Value = TimeStr;

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
			strSql.Append("update ERPPeiXun set ");
			strSql.Append("PeiXunName=@PeiXunName,");
			strSql.Append("PeiXunUser=@PeiXunUser,");
			strSql.Append("CanYuUser=@CanYuUser,");
			strSql.Append("StartDate=@StartDate,");
			strSql.Append("EndDate=@EndDate,");
			strSql.Append("PeiXunMuDi=@PeiXunMuDi,");
			strSql.Append("PeiXunNeiRong=@PeiXunNeiRong,");
			strSql.Append("XiaoGuo=@XiaoGuo,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append("FuJianList=@FuJianList,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@PeiXunName", SqlDbType.VarChar,50),
					new SqlParameter("@PeiXunUser", SqlDbType.VarChar,50),
					new SqlParameter("@CanYuUser", SqlDbType.VarChar,8000),
					new SqlParameter("@StartDate", SqlDbType.VarChar,50),
					new SqlParameter("@EndDate", SqlDbType.VarChar,50),
					new SqlParameter("@PeiXunMuDi", SqlDbType.VarChar,5000),
					new SqlParameter("@PeiXunNeiRong", SqlDbType.VarChar,5000),
					new SqlParameter("@XiaoGuo", SqlDbType.VarChar,5000),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@FuJianList", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = ID;
			parameters[1].Value = PeiXunName;
			parameters[2].Value = PeiXunUser;
			parameters[3].Value = CanYuUser;
			parameters[4].Value = StartDate;
			parameters[5].Value = EndDate;
			parameters[6].Value = PeiXunMuDi;
			parameters[7].Value = PeiXunNeiRong;
			parameters[8].Value = XiaoGuo;
			parameters[9].Value = BackInfo;
			parameters[10].Value = FuJianList;
			parameters[11].Value = UserName;
			parameters[12].Value = TimeStr;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPPeiXun ");
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
			strSql.Append("select  top 1 ID,PeiXunName,PeiXunUser,CanYuUser,StartDate,EndDate,PeiXunMuDi,PeiXunNeiRong,XiaoGuo,BackInfo,FuJianList,UserName,TimeStr ");
			strSql.Append(" FROM ERPPeiXun ");
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
				PeiXunName=ds.Tables[0].Rows[0]["PeiXunName"].ToString();
				PeiXunUser=ds.Tables[0].Rows[0]["PeiXunUser"].ToString();
				CanYuUser=ds.Tables[0].Rows[0]["CanYuUser"].ToString();
				StartDate=ds.Tables[0].Rows[0]["StartDate"].ToString();
				EndDate=ds.Tables[0].Rows[0]["EndDate"].ToString();
				PeiXunMuDi=ds.Tables[0].Rows[0]["PeiXunMuDi"].ToString();
				PeiXunNeiRong=ds.Tables[0].Rows[0]["PeiXunNeiRong"].ToString();
				XiaoGuo=ds.Tables[0].Rows[0]["XiaoGuo"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				FuJianList=ds.Tables[0].Rows[0]["FuJianList"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPPeiXun ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}

