using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
	/// <summary>
	/// ��ERPSupplyLink��
	/// </summary>
	public class ERPSupplyLink
	{
		public ERPSupplyLink()
		{}
		#region Model
		private int _id;
		private string _supplysname;
		private string _linkmanname;
		private string _zhiwei;
		private string _sex;
		private DateTime? _shengri;
		private string _aihao;
		private string _iffirstlink;
		private string _youbian;
		private string _dizhi;
		private string _jobtel;
		private string _jiatingtel;
		private string _mobtel;
		private string _emailstr;
		private string _qqormsn;
		private string _backinfo;
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
		/// ��Ӧ������
		/// </summary>
		public string SupplysName
		{
			set{ _supplysname=value;}
			get{return _supplysname;}
		}
		/// <summary>
		/// ��ϵ������
		/// </summary>
		public string LinkManName
		{
			set{ _linkmanname=value;}
			get{return _linkmanname;}
		}
		/// <summary>
		/// ְλ
		/// </summary>
		public string ZhiWei
		{
			set{ _zhiwei=value;}
			get{return _zhiwei;}
		}
		/// <summary>
		/// �Ա�
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public DateTime? ShengRi
		{
			set{ _shengri=value;}
			get{return _shengri;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string AiHao
		{
			set{ _aihao=value;}
			get{return _aihao;}
		}
		/// <summary>
		/// �Ƿ�����ϵ��
		/// </summary>
		public string IFFirstLink
		{
			set{ _iffirstlink=value;}
			get{return _iffirstlink;}
		}
		/// <summary>
		/// �ʱ�
		/// </summary>
		public string YouBian
		{
			set{ _youbian=value;}
			get{return _youbian;}
		}
		/// <summary>
		/// ��ַ
		/// </summary>
		public string DiZhi
		{
			set{ _dizhi=value;}
			get{return _dizhi;}
		}
		/// <summary>
		/// �����绰
		/// </summary>
		public string JobTel
		{
			set{ _jobtel=value;}
			get{return _jobtel;}
		}
		/// <summary>
		/// ��ͥ�绰
		/// </summary>
		public string JiaTingTel
		{
			set{ _jiatingtel=value;}
			get{return _jiatingtel;}
		}
		/// <summary>
		/// �ֻ�����
		/// </summary>
		public string MobTel
		{
			set{ _mobtel=value;}
			get{return _mobtel;}
		}
		/// <summary>
		/// �����ʼ�
		/// </summary>
		public string EmailStr
		{
			set{ _emailstr=value;}
			get{return _emailstr;}
		}
		/// <summary>
		/// QQ��MSN
		/// </summary>
		public string QQorMsn
		{
			set{ _qqormsn=value;}
			get{return _qqormsn;}
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
		public ERPSupplyLink(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,SupplysName,LinkManName,ZhiWei,Sex,ShengRi,AiHao,IFFirstLink,YouBian,DiZhi,JobTel,JiaTingTel,MobTel,EmailStr,QQorMsn,BackInfo,UserName,TimeStr ");
			strSql.Append(" FROM ERPSupplyLink ");
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
				SupplysName=ds.Tables[0].Rows[0]["SupplysName"].ToString();
				LinkManName=ds.Tables[0].Rows[0]["LinkManName"].ToString();
				ZhiWei=ds.Tables[0].Rows[0]["ZhiWei"].ToString();
				Sex=ds.Tables[0].Rows[0]["Sex"].ToString();
				if(ds.Tables[0].Rows[0]["ShengRi"].ToString()!="")
				{
					ShengRi=DateTime.Parse(ds.Tables[0].Rows[0]["ShengRi"].ToString());
				}
				AiHao=ds.Tables[0].Rows[0]["AiHao"].ToString();
				IFFirstLink=ds.Tables[0].Rows[0]["IFFirstLink"].ToString();
				YouBian=ds.Tables[0].Rows[0]["YouBian"].ToString();
				DiZhi=ds.Tables[0].Rows[0]["DiZhi"].ToString();
				JobTel=ds.Tables[0].Rows[0]["JobTel"].ToString();
				JiaTingTel=ds.Tables[0].Rows[0]["JiaTingTel"].ToString();
				MobTel=ds.Tables[0].Rows[0]["MobTel"].ToString();
				EmailStr=ds.Tables[0].Rows[0]["EmailStr"].ToString();
				QQorMsn=ds.Tables[0].Rows[0]["QQorMsn"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
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

		return DbHelperSQL.GetMaxID("ID", "ERPSupplyLink"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPSupplyLink");
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
			strSql.Append("insert into ERPSupplyLink(");
			strSql.Append("SupplysName,LinkManName,ZhiWei,Sex,ShengRi,AiHao,IFFirstLink,YouBian,DiZhi,JobTel,JiaTingTel,MobTel,EmailStr,QQorMsn,BackInfo,UserName,TimeStr)");
			strSql.Append(" values (");
			strSql.Append("@SupplysName,@LinkManName,@ZhiWei,@Sex,@ShengRi,@AiHao,@IFFirstLink,@YouBian,@DiZhi,@JobTel,@JiaTingTel,@MobTel,@EmailStr,@QQorMsn,@BackInfo,@UserName,@TimeStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SupplysName", SqlDbType.VarChar,50),
					new SqlParameter("@LinkManName", SqlDbType.VarChar,50),
					new SqlParameter("@ZhiWei", SqlDbType.VarChar,50),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@ShengRi", SqlDbType.DateTime),
					new SqlParameter("@AiHao", SqlDbType.VarChar,200),
					new SqlParameter("@IFFirstLink", SqlDbType.VarChar,50),
					new SqlParameter("@YouBian", SqlDbType.VarChar,50),
					new SqlParameter("@DiZhi", SqlDbType.VarChar,500),
					new SqlParameter("@JobTel", SqlDbType.VarChar,50),
					new SqlParameter("@JiaTingTel", SqlDbType.VarChar,50),
					new SqlParameter("@MobTel", SqlDbType.VarChar,50),
					new SqlParameter("@EmailStr", SqlDbType.VarChar,50),
					new SqlParameter("@QQorMsn", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = SupplysName;
			parameters[1].Value = LinkManName;
			parameters[2].Value = ZhiWei;
			parameters[3].Value = Sex;
			parameters[4].Value = ShengRi;
			parameters[5].Value = AiHao;
			parameters[6].Value = IFFirstLink;
			parameters[7].Value = YouBian;
			parameters[8].Value = DiZhi;
			parameters[9].Value = JobTel;
			parameters[10].Value = JiaTingTel;
			parameters[11].Value = MobTel;
			parameters[12].Value = EmailStr;
			parameters[13].Value = QQorMsn;
			parameters[14].Value = BackInfo;
			parameters[15].Value = UserName;
			parameters[16].Value = TimeStr;

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
			strSql.Append("update ERPSupplyLink set ");
			strSql.Append("SupplysName=@SupplysName,");
			strSql.Append("LinkManName=@LinkManName,");
			strSql.Append("ZhiWei=@ZhiWei,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("ShengRi=@ShengRi,");
			strSql.Append("AiHao=@AiHao,");
			strSql.Append("IFFirstLink=@IFFirstLink,");
			strSql.Append("YouBian=@YouBian,");
			strSql.Append("DiZhi=@DiZhi,");
			strSql.Append("JobTel=@JobTel,");
			strSql.Append("JiaTingTel=@JiaTingTel,");
			strSql.Append("MobTel=@MobTel,");
			strSql.Append("EmailStr=@EmailStr,");
			strSql.Append("QQorMsn=@QQorMsn,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@SupplysName", SqlDbType.VarChar,50),
					new SqlParameter("@LinkManName", SqlDbType.VarChar,50),
					new SqlParameter("@ZhiWei", SqlDbType.VarChar,50),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@ShengRi", SqlDbType.DateTime),
					new SqlParameter("@AiHao", SqlDbType.VarChar,200),
					new SqlParameter("@IFFirstLink", SqlDbType.VarChar,50),
					new SqlParameter("@YouBian", SqlDbType.VarChar,50),
					new SqlParameter("@DiZhi", SqlDbType.VarChar,500),
					new SqlParameter("@JobTel", SqlDbType.VarChar,50),
					new SqlParameter("@JiaTingTel", SqlDbType.VarChar,50),
					new SqlParameter("@MobTel", SqlDbType.VarChar,50),
					new SqlParameter("@EmailStr", SqlDbType.VarChar,50),
					new SqlParameter("@QQorMsn", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = ID;
			parameters[1].Value = SupplysName;
			parameters[2].Value = LinkManName;
			parameters[3].Value = ZhiWei;
			parameters[4].Value = Sex;
			parameters[5].Value = ShengRi;
			parameters[6].Value = AiHao;
			parameters[7].Value = IFFirstLink;
			parameters[8].Value = YouBian;
			parameters[9].Value = DiZhi;
			parameters[10].Value = JobTel;
			parameters[11].Value = JiaTingTel;
			parameters[12].Value = MobTel;
			parameters[13].Value = EmailStr;
			parameters[14].Value = QQorMsn;
			parameters[15].Value = BackInfo;
			parameters[16].Value = UserName;
			parameters[17].Value = TimeStr;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPSupplyLink ");
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
			strSql.Append("select  top 1 ID,SupplysName,LinkManName,ZhiWei,Sex,ShengRi,AiHao,IFFirstLink,YouBian,DiZhi,JobTel,JiaTingTel,MobTel,EmailStr,QQorMsn,BackInfo,UserName,TimeStr ");
			strSql.Append(" FROM ERPSupplyLink ");
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
				SupplysName=ds.Tables[0].Rows[0]["SupplysName"].ToString();
				LinkManName=ds.Tables[0].Rows[0]["LinkManName"].ToString();
				ZhiWei=ds.Tables[0].Rows[0]["ZhiWei"].ToString();
				Sex=ds.Tables[0].Rows[0]["Sex"].ToString();
				if(ds.Tables[0].Rows[0]["ShengRi"].ToString()!="")
				{
					ShengRi=DateTime.Parse(ds.Tables[0].Rows[0]["ShengRi"].ToString());
				}
				AiHao=ds.Tables[0].Rows[0]["AiHao"].ToString();
				IFFirstLink=ds.Tables[0].Rows[0]["IFFirstLink"].ToString();
				YouBian=ds.Tables[0].Rows[0]["YouBian"].ToString();
				DiZhi=ds.Tables[0].Rows[0]["DiZhi"].ToString();
				JobTel=ds.Tables[0].Rows[0]["JobTel"].ToString();
				JiaTingTel=ds.Tables[0].Rows[0]["JiaTingTel"].ToString();
				MobTel=ds.Tables[0].Rows[0]["MobTel"].ToString();
				EmailStr=ds.Tables[0].Rows[0]["EmailStr"].ToString();
				QQorMsn=ds.Tables[0].Rows[0]["QQorMsn"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
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
			strSql.Append(" FROM ERPSupplyLink ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}

