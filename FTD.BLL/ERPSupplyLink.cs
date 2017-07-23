using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPSupplyLink。
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
		/// 供应商名称
		/// </summary>
		public string SupplysName
		{
			set{ _supplysname=value;}
			get{return _supplysname;}
		}
		/// <summary>
		/// 联系人姓名
		/// </summary>
		public string LinkManName
		{
			set{ _linkmanname=value;}
			get{return _linkmanname;}
		}
		/// <summary>
		/// 职位
		/// </summary>
		public string ZhiWei
		{
			set{ _zhiwei=value;}
			get{return _zhiwei;}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 生日
		/// </summary>
		public DateTime? ShengRi
		{
			set{ _shengri=value;}
			get{return _shengri;}
		}
		/// <summary>
		/// 爱好
		/// </summary>
		public string AiHao
		{
			set{ _aihao=value;}
			get{return _aihao;}
		}
		/// <summary>
		/// 是否主联系人
		/// </summary>
		public string IFFirstLink
		{
			set{ _iffirstlink=value;}
			get{return _iffirstlink;}
		}
		/// <summary>
		/// 邮编
		/// </summary>
		public string YouBian
		{
			set{ _youbian=value;}
			get{return _youbian;}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string DiZhi
		{
			set{ _dizhi=value;}
			get{return _dizhi;}
		}
		/// <summary>
		/// 工作电话
		/// </summary>
		public string JobTel
		{
			set{ _jobtel=value;}
			get{return _jobtel;}
		}
		/// <summary>
		/// 家庭电话
		/// </summary>
		public string JiaTingTel
		{
			set{ _jiatingtel=value;}
			get{return _jiatingtel;}
		}
		/// <summary>
		/// 手机号码
		/// </summary>
		public string MobTel
		{
			set{ _mobtel=value;}
			get{return _mobtel;}
		}
		/// <summary>
		/// 电子邮件
		/// </summary>
		public string EmailStr
		{
			set{ _emailstr=value;}
			get{return _emailstr;}
		}
		/// <summary>
		/// QQ或MSN
		/// </summary>
		public string QQorMsn
		{
			set{ _qqormsn=value;}
			get{return _qqormsn;}
		}
		/// <summary>
		/// 备注说明
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		/// <summary>
		/// 录入人
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 录入时间
		/// </summary>
		public DateTime? TimeStr
		{
			set{ _timestr=value;}
			get{return _timestr;}
		}
		#endregion Model


		#region  成员方法

		/// <summary>
		/// 得到一个对象实体
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
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPSupplyLink"); 
		}

		/// <summary>
		/// 是否存在该记录
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
		/// 增加一条数据
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
		/// 更新一条数据
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
		/// 删除一条数据
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
		/// 得到一个对象实体
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
		/// 获得数据列表
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

		#endregion  成员方法
	}
}

