using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPLinkMan。
	/// </summary>
	public class ERPLinkMan
	{
		public ERPLinkMan()
		{}
		#region Model
		private int _id;
		private string _customname;
		private string _namestr;
		private string _sex;
		private string _birthday;
		private string _suochujiaose;
		private string _zhiwu;
		private string _peiou;
		private string _zinv;
		private string _danwiedianhua;
		private string _danweichuanzhen;
		private string _jiatingzhuzhi;
		private string _jiatingyoubian;
		private string _jiatingdianhua;
		private string _shouji;
		private string _xiaolingtong;
		private string _email;
		private string _qq;
		private string _msn;
		private string _backinfo;
		private string _username;
		private DateTime? _timestr;
		private string _ifshare;
		private string _cusbaka;
		private string _cusbakb;
		private string _cusbakc;
		private string _cusbakd;
		private string _cusbake;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomName
		{
			set{ _customname=value;}
			get{return _customname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NameStr
		{
			set{ _namestr=value;}
			get{return _namestr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BirthDay
		{
			set{ _birthday=value;}
			get{return _birthday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SuoChuJiaoSe
		{
			set{ _suochujiaose=value;}
			get{return _suochujiaose;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZhiWu
		{
			set{ _zhiwu=value;}
			get{return _zhiwu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PeiOu
		{
			set{ _peiou=value;}
			get{return _peiou;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZiNv
		{
			set{ _zinv=value;}
			get{return _zinv;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DanWieDianHua
		{
			set{ _danwiedianhua=value;}
			get{return _danwiedianhua;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DanWeiChuanZhen
		{
			set{ _danweichuanzhen=value;}
			get{return _danweichuanzhen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JiaTingZhuZhi
		{
			set{ _jiatingzhuzhi=value;}
			get{return _jiatingzhuzhi;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JiaTingYouBian
		{
			set{ _jiatingyoubian=value;}
			get{return _jiatingyoubian;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JiaTingDianHua
		{
			set{ _jiatingdianhua=value;}
			get{return _jiatingdianhua;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShouJi
		{
			set{ _shouji=value;}
			get{return _shouji;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XiaoLingTong
		{
			set{ _xiaolingtong=value;}
			get{return _xiaolingtong;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QQ
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Msn
		{
			set{ _msn=value;}
			get{return _msn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TimeStr
		{
			set{ _timestr=value;}
			get{return _timestr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IFShare
		{
			set{ _ifshare=value;}
			get{return _ifshare;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusBakA
		{
			set{ _cusbaka=value;}
			get{return _cusbaka;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusBakB
		{
			set{ _cusbakb=value;}
			get{return _cusbakb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusBakC
		{
			set{ _cusbakc=value;}
			get{return _cusbakc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusBakD
		{
			set{ _cusbakd=value;}
			get{return _cusbakd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CusBakE
		{
			set{ _cusbake=value;}
			get{return _cusbake;}
		}
		#endregion Model


		#region  成员方法

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPLinkMan(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,CustomName,NameStr,Sex,BirthDay,SuoChuJiaoSe,ZhiWu,PeiOu,ZiNv,DanWieDianHua,DanWeiChuanZhen,JiaTingZhuZhi,JiaTingYouBian,JiaTingDianHua,ShouJi,XiaoLingTong,Email,QQ,Msn,BackInfo,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE ");
			strSql.Append(" FROM ERPLinkMan ");
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
				CustomName=ds.Tables[0].Rows[0]["CustomName"].ToString();
				NameStr=ds.Tables[0].Rows[0]["NameStr"].ToString();
				Sex=ds.Tables[0].Rows[0]["Sex"].ToString();
				BirthDay=ds.Tables[0].Rows[0]["BirthDay"].ToString();
				SuoChuJiaoSe=ds.Tables[0].Rows[0]["SuoChuJiaoSe"].ToString();
				ZhiWu=ds.Tables[0].Rows[0]["ZhiWu"].ToString();
				PeiOu=ds.Tables[0].Rows[0]["PeiOu"].ToString();
				ZiNv=ds.Tables[0].Rows[0]["ZiNv"].ToString();
				DanWieDianHua=ds.Tables[0].Rows[0]["DanWieDianHua"].ToString();
				DanWeiChuanZhen=ds.Tables[0].Rows[0]["DanWeiChuanZhen"].ToString();
				JiaTingZhuZhi=ds.Tables[0].Rows[0]["JiaTingZhuZhi"].ToString();
				JiaTingYouBian=ds.Tables[0].Rows[0]["JiaTingYouBian"].ToString();
				JiaTingDianHua=ds.Tables[0].Rows[0]["JiaTingDianHua"].ToString();
				ShouJi=ds.Tables[0].Rows[0]["ShouJi"].ToString();
				XiaoLingTong=ds.Tables[0].Rows[0]["XiaoLingTong"].ToString();
				Email=ds.Tables[0].Rows[0]["Email"].ToString();
				QQ=ds.Tables[0].Rows[0]["QQ"].ToString();
				Msn=ds.Tables[0].Rows[0]["Msn"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				IFShare=ds.Tables[0].Rows[0]["IFShare"].ToString();
				CusBakA=ds.Tables[0].Rows[0]["CusBakA"].ToString();
				CusBakB=ds.Tables[0].Rows[0]["CusBakB"].ToString();
				CusBakC=ds.Tables[0].Rows[0]["CusBakC"].ToString();
				CusBakD=ds.Tables[0].Rows[0]["CusBakD"].ToString();
				CusBakE=ds.Tables[0].Rows[0]["CusBakE"].ToString();
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPLinkMan"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPLinkMan");
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
			strSql.Append("insert into ERPLinkMan(");
			strSql.Append("CustomName,NameStr,Sex,BirthDay,SuoChuJiaoSe,ZhiWu,PeiOu,ZiNv,DanWieDianHua,DanWeiChuanZhen,JiaTingZhuZhi,JiaTingYouBian,JiaTingDianHua,ShouJi,XiaoLingTong,Email,QQ,Msn,BackInfo,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE)");
			strSql.Append(" values (");
			strSql.Append("@CustomName,@NameStr,@Sex,@BirthDay,@SuoChuJiaoSe,@ZhiWu,@PeiOu,@ZiNv,@DanWieDianHua,@DanWeiChuanZhen,@JiaTingZhuZhi,@JiaTingYouBian,@JiaTingDianHua,@ShouJi,@XiaoLingTong,@Email,@QQ,@Msn,@BackInfo,@UserName,@TimeStr,@IFShare,@CusBakA,@CusBakB,@CusBakC,@CusBakD,@CusBakE)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomName", SqlDbType.VarChar,100),
					new SqlParameter("@NameStr", SqlDbType.VarChar,50),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@BirthDay", SqlDbType.VarChar,50),
					new SqlParameter("@SuoChuJiaoSe", SqlDbType.VarChar,50),
					new SqlParameter("@ZhiWu", SqlDbType.VarChar,50),
					new SqlParameter("@PeiOu", SqlDbType.VarChar,500),
					new SqlParameter("@ZiNv", SqlDbType.VarChar,500),
					new SqlParameter("@DanWieDianHua", SqlDbType.VarChar,50),
					new SqlParameter("@DanWeiChuanZhen", SqlDbType.VarChar,50),
					new SqlParameter("@JiaTingZhuZhi", SqlDbType.VarChar,500),
					new SqlParameter("@JiaTingYouBian", SqlDbType.VarChar,50),
					new SqlParameter("@JiaTingDianHua", SqlDbType.VarChar,50),
					new SqlParameter("@ShouJi", SqlDbType.VarChar,50),
					new SqlParameter("@XiaoLingTong", SqlDbType.VarChar,50),
					new SqlParameter("@Email", SqlDbType.VarChar,50),
					new SqlParameter("@QQ", SqlDbType.VarChar,50),
					new SqlParameter("@Msn", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.Text),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@IFShare", SqlDbType.VarChar,5000),
					new SqlParameter("@CusBakA", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakB", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakC", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakD", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakE", SqlDbType.VarChar,8000)};
			parameters[0].Value = CustomName;
			parameters[1].Value = NameStr;
			parameters[2].Value = Sex;
			parameters[3].Value = BirthDay;
			parameters[4].Value = SuoChuJiaoSe;
			parameters[5].Value = ZhiWu;
			parameters[6].Value = PeiOu;
			parameters[7].Value = ZiNv;
			parameters[8].Value = DanWieDianHua;
			parameters[9].Value = DanWeiChuanZhen;
			parameters[10].Value = JiaTingZhuZhi;
			parameters[11].Value = JiaTingYouBian;
			parameters[12].Value = JiaTingDianHua;
			parameters[13].Value = ShouJi;
			parameters[14].Value = XiaoLingTong;
			parameters[15].Value = Email;
			parameters[16].Value = QQ;
			parameters[17].Value = Msn;
			parameters[18].Value = BackInfo;
			parameters[19].Value = UserName;
			parameters[20].Value = TimeStr;
			parameters[21].Value = IFShare;
			parameters[22].Value = CusBakA;
			parameters[23].Value = CusBakB;
			parameters[24].Value = CusBakC;
			parameters[25].Value = CusBakD;
			parameters[26].Value = CusBakE;

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
			strSql.Append("update ERPLinkMan set ");
			strSql.Append("CustomName=@CustomName,");
			strSql.Append("NameStr=@NameStr,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("BirthDay=@BirthDay,");
			strSql.Append("SuoChuJiaoSe=@SuoChuJiaoSe,");
			strSql.Append("ZhiWu=@ZhiWu,");
			strSql.Append("PeiOu=@PeiOu,");
			strSql.Append("ZiNv=@ZiNv,");
			strSql.Append("DanWieDianHua=@DanWieDianHua,");
			strSql.Append("DanWeiChuanZhen=@DanWeiChuanZhen,");
			strSql.Append("JiaTingZhuZhi=@JiaTingZhuZhi,");
			strSql.Append("JiaTingYouBian=@JiaTingYouBian,");
			strSql.Append("JiaTingDianHua=@JiaTingDianHua,");
			strSql.Append("ShouJi=@ShouJi,");
			strSql.Append("XiaoLingTong=@XiaoLingTong,");
			strSql.Append("Email=@Email,");
			strSql.Append("QQ=@QQ,");
			strSql.Append("Msn=@Msn,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr,");
			strSql.Append("IFShare=@IFShare,");
			strSql.Append("CusBakA=@CusBakA,");
			strSql.Append("CusBakB=@CusBakB,");
			strSql.Append("CusBakC=@CusBakC,");
			strSql.Append("CusBakD=@CusBakD,");
			strSql.Append("CusBakE=@CusBakE");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@CustomName", SqlDbType.VarChar,100),
					new SqlParameter("@NameStr", SqlDbType.VarChar,50),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@BirthDay", SqlDbType.VarChar,50),
					new SqlParameter("@SuoChuJiaoSe", SqlDbType.VarChar,50),
					new SqlParameter("@ZhiWu", SqlDbType.VarChar,50),
					new SqlParameter("@PeiOu", SqlDbType.VarChar,500),
					new SqlParameter("@ZiNv", SqlDbType.VarChar,500),
					new SqlParameter("@DanWieDianHua", SqlDbType.VarChar,50),
					new SqlParameter("@DanWeiChuanZhen", SqlDbType.VarChar,50),
					new SqlParameter("@JiaTingZhuZhi", SqlDbType.VarChar,500),
					new SqlParameter("@JiaTingYouBian", SqlDbType.VarChar,50),
					new SqlParameter("@JiaTingDianHua", SqlDbType.VarChar,50),
					new SqlParameter("@ShouJi", SqlDbType.VarChar,50),
					new SqlParameter("@XiaoLingTong", SqlDbType.VarChar,50),
					new SqlParameter("@Email", SqlDbType.VarChar,50),
					new SqlParameter("@QQ", SqlDbType.VarChar,50),
					new SqlParameter("@Msn", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.Text),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@IFShare", SqlDbType.VarChar,5000),
					new SqlParameter("@CusBakA", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakB", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakC", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakD", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakE", SqlDbType.VarChar,8000)};
			parameters[0].Value = ID;
			parameters[1].Value = CustomName;
			parameters[2].Value = NameStr;
			parameters[3].Value = Sex;
			parameters[4].Value = BirthDay;
			parameters[5].Value = SuoChuJiaoSe;
			parameters[6].Value = ZhiWu;
			parameters[7].Value = PeiOu;
			parameters[8].Value = ZiNv;
			parameters[9].Value = DanWieDianHua;
			parameters[10].Value = DanWeiChuanZhen;
			parameters[11].Value = JiaTingZhuZhi;
			parameters[12].Value = JiaTingYouBian;
			parameters[13].Value = JiaTingDianHua;
			parameters[14].Value = ShouJi;
			parameters[15].Value = XiaoLingTong;
			parameters[16].Value = Email;
			parameters[17].Value = QQ;
			parameters[18].Value = Msn;
			parameters[19].Value = BackInfo;
			parameters[20].Value = UserName;
			parameters[21].Value = TimeStr;
			parameters[22].Value = IFShare;
			parameters[23].Value = CusBakA;
			parameters[24].Value = CusBakB;
			parameters[25].Value = CusBakC;
			parameters[26].Value = CusBakD;
			parameters[27].Value = CusBakE;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete ERPLinkMan ");
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
			strSql.Append("select ID,CustomName,NameStr,Sex,BirthDay,SuoChuJiaoSe,ZhiWu,PeiOu,ZiNv,DanWieDianHua,DanWeiChuanZhen,JiaTingZhuZhi,JiaTingYouBian,JiaTingDianHua,ShouJi,XiaoLingTong,Email,QQ,Msn,BackInfo,UserName,TimeStr,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE ");
			strSql.Append(" FROM ERPLinkMan ");
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
				CustomName=ds.Tables[0].Rows[0]["CustomName"].ToString();
				NameStr=ds.Tables[0].Rows[0]["NameStr"].ToString();
				Sex=ds.Tables[0].Rows[0]["Sex"].ToString();
				BirthDay=ds.Tables[0].Rows[0]["BirthDay"].ToString();
				SuoChuJiaoSe=ds.Tables[0].Rows[0]["SuoChuJiaoSe"].ToString();
				ZhiWu=ds.Tables[0].Rows[0]["ZhiWu"].ToString();
				PeiOu=ds.Tables[0].Rows[0]["PeiOu"].ToString();
				ZiNv=ds.Tables[0].Rows[0]["ZiNv"].ToString();
				DanWieDianHua=ds.Tables[0].Rows[0]["DanWieDianHua"].ToString();
				DanWeiChuanZhen=ds.Tables[0].Rows[0]["DanWeiChuanZhen"].ToString();
				JiaTingZhuZhi=ds.Tables[0].Rows[0]["JiaTingZhuZhi"].ToString();
				JiaTingYouBian=ds.Tables[0].Rows[0]["JiaTingYouBian"].ToString();
				JiaTingDianHua=ds.Tables[0].Rows[0]["JiaTingDianHua"].ToString();
				ShouJi=ds.Tables[0].Rows[0]["ShouJi"].ToString();
				XiaoLingTong=ds.Tables[0].Rows[0]["XiaoLingTong"].ToString();
				Email=ds.Tables[0].Rows[0]["Email"].ToString();
				QQ=ds.Tables[0].Rows[0]["QQ"].ToString();
				Msn=ds.Tables[0].Rows[0]["Msn"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				IFShare=ds.Tables[0].Rows[0]["IFShare"].ToString();
				CusBakA=ds.Tables[0].Rows[0]["CusBakA"].ToString();
				CusBakB=ds.Tables[0].Rows[0]["CusBakB"].ToString();
				CusBakC=ds.Tables[0].Rows[0]["CusBakC"].ToString();
				CusBakD=ds.Tables[0].Rows[0]["CusBakD"].ToString();
				CusBakE=ds.Tables[0].Rows[0]["CusBakE"].ToString();
			}
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select [ID],[CustomName],[NameStr],[Sex],[BirthDay],[SuoChuJiaoSe],[ZhiWu],[PeiOu],[ZiNv],[DanWieDianHua],[DanWeiChuanZhen],[JiaTingZhuZhi],[JiaTingYouBian],[JiaTingDianHua],[ShouJi],[XiaoLingTong],[Email],[QQ],[Msn],[BackInfo],[UserName],[TimeStr],[IFShare],[CusBakA],[CusBakB],[CusBakC],[CusBakD],[CusBakE] ");
			strSql.Append(" FROM ERPLinkMan ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

