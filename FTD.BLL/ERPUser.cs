using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;
using System.Web;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPUser。
	/// </summary>
	public class ERPUser
	{
		public ERPUser()
		{}
		#region Model
		private int _id;
		private string _username;
		private string _userpwd;
		private string _truename;
		private string _serils;
		private string _department;
		private string _jiaose;
		private DateTime? _activetime;
		private string _zhiwei;
		private string _zaigang;
		private string _emailstr;
		private string _iflogin;
		private string _sex;
		private string _backinfo;
		private string _birthday;
		private string _mingzu;
		private string _sfzserils;
		private string _hunying;
		private string _zhengzhimianmao;
		private string _jiguan;
		private string _hukou;
		private string _xueli;
		private string _zhicheng;
		private string _biyeyuanxiao;
		private string _zhuanye;
		private string _canjiagongzuotime;
		private string _jiarubendanweitime;
		private string _jiatingdianhua;
		private string _jiatingaddress;
		private string _gangweibiandong;
		private string _jiaoyuebeijing;
		private string _gongzuojianli;
		private string _shehuiguanxi;
		private string _jiangchengjilu;
		private string _zhiwuqingkuang;
		private string _peixunjilu;
		private string _danbaojilu;
		private string _naodonghetong;
		private string _shebaojiaona;
		private string _tijianjilu;
		private string _beizhustr;
		private string _fujian;
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
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserPwd
		{
			set{ _userpwd=value;}
			get{return _userpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TrueName
		{
			set{ _truename=value;}
			get{return _truename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Serils
		{
			set{ _serils=value;}
			get{return _serils;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Department
		{
			set{ _department=value;}
			get{return _department;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JiaoSe
		{
			set{ _jiaose=value;}
			get{return _jiaose;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ActiveTime
		{
			set{ _activetime=value;}
			get{return _activetime;}
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
		/// 
		/// </summary>
		public string ZaiGang
		{
			set{ _zaigang=value;}
			get{return _zaigang;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EmailStr
		{
			set{ _emailstr=value;}
			get{return _emailstr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IfLogin
		{
			set{ _iflogin=value;}
			get{return _iflogin;}
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
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
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
		public string MingZu
		{
			set{ _mingzu=value;}
			get{return _mingzu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SFZSerils
		{
			set{ _sfzserils=value;}
			get{return _sfzserils;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HunYing
		{
			set{ _hunying=value;}
			get{return _hunying;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZhengZhiMianMao
		{
			set{ _zhengzhimianmao=value;}
			get{return _zhengzhimianmao;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JiGuan
		{
			set{ _jiguan=value;}
			get{return _jiguan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HuKou
		{
			set{ _hukou=value;}
			get{return _hukou;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XueLi
		{
			set{ _xueli=value;}
			get{return _xueli;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZhiCheng
		{
			set{ _zhicheng=value;}
			get{return _zhicheng;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BiYeYuanXiao
		{
			set{ _biyeyuanxiao=value;}
			get{return _biyeyuanxiao;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZhuanYe
		{
			set{ _zhuanye=value;}
			get{return _zhuanye;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CanJiaGongZuoTime
		{
			set{ _canjiagongzuotime=value;}
			get{return _canjiagongzuotime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JiaRuBenDanWeiTime
		{
			set{ _jiarubendanweitime=value;}
			get{return _jiarubendanweitime;}
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
		public string JiaTingAddress
		{
			set{ _jiatingaddress=value;}
			get{return _jiatingaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GangWeiBianDong
		{
			set{ _gangweibiandong=value;}
			get{return _gangweibiandong;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JiaoYueBeiJing
		{
			set{ _jiaoyuebeijing=value;}
			get{return _jiaoyuebeijing;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GongZuoJianLi
		{
			set{ _gongzuojianli=value;}
			get{return _gongzuojianli;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SheHuiGuanXi
		{
			set{ _shehuiguanxi=value;}
			get{return _shehuiguanxi;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JiangChengJiLu
		{
			set{ _jiangchengjilu=value;}
			get{return _jiangchengjilu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZhiWuQingKuang
		{
			set{ _zhiwuqingkuang=value;}
			get{return _zhiwuqingkuang;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PeiXunJiLu
		{
			set{ _peixunjilu=value;}
			get{return _peixunjilu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DanBaoJiLu
		{
			set{ _danbaojilu=value;}
			get{return _danbaojilu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NaoDongHeTong
		{
			set{ _naodonghetong=value;}
			get{return _naodonghetong;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SheBaoJiaoNa
		{
			set{ _shebaojiaona=value;}
			get{return _shebaojiaona;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TiJianJiLu
		{
			set{ _tijianjilu=value;}
			get{return _tijianjilu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BeiZhuStr
		{
			set{ _beizhustr=value;}
			get{return _beizhustr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FuJian
		{
			set{ _fujian=value;}
			get{return _fujian;}
		}
		#endregion Model


		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPUser");
			strSql.Append(" where ID="+ID+" ");

			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)				};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ERPUser(");
			strSql.Append("UserName,UserPwd,TrueName,Serils,Department,JiaoSe,ActiveTime,ZhiWei,ZaiGang,EmailStr,IfLogin,Sex,BackInfo,BirthDay,MingZu,SFZSerils,HunYing,ZhengZhiMianMao,JiGuan,HuKou,XueLi,ZhiCheng,BiYeYuanXiao,ZhuanYe,CanJiaGongZuoTime,JiaRuBenDanWeiTime,JiaTingDianHua,JiaTingAddress,GangWeiBianDong,JiaoYueBeiJing,GongZuoJianLi,SheHuiGuanXi,JiangChengJiLu,ZhiWuQingKuang,PeiXunJiLu,DanBaoJiLu,NaoDongHeTong,SheBaoJiaoNa,TiJianJiLu,BeiZhuStr,FuJian)");
			strSql.Append(" values (");
			strSql.Append("@UserName,@UserPwd,@TrueName,@Serils,@Department,@JiaoSe,@ActiveTime,@ZhiWei,@ZaiGang,@EmailStr,@IfLogin,@Sex,@BackInfo,@BirthDay,@MingZu,@SFZSerils,@HunYing,@ZhengZhiMianMao,@JiGuan,@HuKou,@XueLi,@ZhiCheng,@BiYeYuanXiao,@ZhuanYe,@CanJiaGongZuoTime,@JiaRuBenDanWeiTime,@JiaTingDianHua,@JiaTingAddress,@GangWeiBianDong,@JiaoYueBeiJing,@GongZuoJianLi,@SheHuiGuanXi,@JiangChengJiLu,@ZhiWuQingKuang,@PeiXunJiLu,@DanBaoJiLu,@NaoDongHeTong,@SheBaoJiaoNa,@TiJianJiLu,@BeiZhuStr,@FuJian)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@UserPwd", SqlDbType.VarChar,200),
					new SqlParameter("@TrueName", SqlDbType.VarChar,50),
					new SqlParameter("@Serils", SqlDbType.VarChar,50),
					new SqlParameter("@Department", SqlDbType.VarChar,50),
					new SqlParameter("@JiaoSe", SqlDbType.VarChar,50),
					new SqlParameter("@ActiveTime", SqlDbType.DateTime),
					new SqlParameter("@ZhiWei", SqlDbType.VarChar,50),
					new SqlParameter("@ZaiGang", SqlDbType.VarChar,50),
					new SqlParameter("@EmailStr", SqlDbType.VarChar,50),
					new SqlParameter("@IfLogin", SqlDbType.VarChar,50),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,8000),
					new SqlParameter("@BirthDay", SqlDbType.VarChar,50),
					new SqlParameter("@MingZu", SqlDbType.VarChar,50),
					new SqlParameter("@SFZSerils", SqlDbType.VarChar,50),
					new SqlParameter("@HunYing", SqlDbType.VarChar,50),
					new SqlParameter("@ZhengZhiMianMao", SqlDbType.VarChar,50),
					new SqlParameter("@JiGuan", SqlDbType.VarChar,50),
					new SqlParameter("@HuKou", SqlDbType.VarChar,500),
					new SqlParameter("@XueLi", SqlDbType.VarChar,50),
					new SqlParameter("@ZhiCheng", SqlDbType.VarChar,50),
					new SqlParameter("@BiYeYuanXiao", SqlDbType.VarChar,50),
					new SqlParameter("@ZhuanYe", SqlDbType.VarChar,50),
					new SqlParameter("@CanJiaGongZuoTime", SqlDbType.VarChar,50),
					new SqlParameter("@JiaRuBenDanWeiTime", SqlDbType.VarChar,50),
					new SqlParameter("@JiaTingDianHua", SqlDbType.VarChar,50),
					new SqlParameter("@JiaTingAddress", SqlDbType.VarChar,500),
					new SqlParameter("@GangWeiBianDong", SqlDbType.Text),
					new SqlParameter("@JiaoYueBeiJing", SqlDbType.Text),
					new SqlParameter("@GongZuoJianLi", SqlDbType.Text),
					new SqlParameter("@SheHuiGuanXi", SqlDbType.Text),
					new SqlParameter("@JiangChengJiLu", SqlDbType.Text),
					new SqlParameter("@ZhiWuQingKuang", SqlDbType.Text),
					new SqlParameter("@PeiXunJiLu", SqlDbType.Text),
					new SqlParameter("@DanBaoJiLu", SqlDbType.Text),
					new SqlParameter("@NaoDongHeTong", SqlDbType.Text),
					new SqlParameter("@SheBaoJiaoNa", SqlDbType.Text),
					new SqlParameter("@TiJianJiLu", SqlDbType.Text),
					new SqlParameter("@BeiZhuStr", SqlDbType.Text),
					new SqlParameter("@FuJian", SqlDbType.VarChar,5000)};
			parameters[0].Value = UserName;
			parameters[1].Value = UserPwd;
			parameters[2].Value = TrueName;
			parameters[3].Value = Serils;
			parameters[4].Value = Department;
			parameters[5].Value = JiaoSe;
			parameters[6].Value = ActiveTime;
			parameters[7].Value = ZhiWei;
			parameters[8].Value = ZaiGang;
			parameters[9].Value = EmailStr;
			parameters[10].Value = IfLogin;
			parameters[11].Value = Sex;
			parameters[12].Value = BackInfo;
			parameters[13].Value = BirthDay;
			parameters[14].Value = MingZu;
			parameters[15].Value = SFZSerils;
			parameters[16].Value = HunYing;
			parameters[17].Value = ZhengZhiMianMao;
			parameters[18].Value = JiGuan;
			parameters[19].Value = HuKou;
			parameters[20].Value = XueLi;
			parameters[21].Value = ZhiCheng;
			parameters[22].Value = BiYeYuanXiao;
			parameters[23].Value = ZhuanYe;
			parameters[24].Value = CanJiaGongZuoTime;
			parameters[25].Value = JiaRuBenDanWeiTime;
			parameters[26].Value = JiaTingDianHua;
			parameters[27].Value = JiaTingAddress;
			parameters[28].Value = GangWeiBianDong;
			parameters[29].Value = JiaoYueBeiJing;
			parameters[30].Value = GongZuoJianLi;
			parameters[31].Value = SheHuiGuanXi;
			parameters[32].Value = JiangChengJiLu;
			parameters[33].Value = ZhiWuQingKuang;
			parameters[34].Value = PeiXunJiLu;
			parameters[35].Value = DanBaoJiLu;
			parameters[36].Value = NaoDongHeTong;
			parameters[37].Value = SheBaoJiaoNa;
			parameters[38].Value = TiJianJiLu;
			parameters[39].Value = BeiZhuStr;
			parameters[40].Value = FuJian;

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
        public void UpdatePwd()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ERPUser set ");            
            strSql.Append("UserPwd=@UserPwd");            
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),					
					new SqlParameter("@UserPwd", SqlDbType.VarChar,200)};
            parameters[0].Value = ID;            
            parameters[1].Value = UserPwd;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ERPUser set ");
			strSql.Append("UserName=@UserName,");
			strSql.Append("UserPwd=@UserPwd,");
			strSql.Append("TrueName=@TrueName,");
			strSql.Append("Serils=@Serils,");
			strSql.Append("Department=@Department,");
			strSql.Append("JiaoSe=@JiaoSe,");			
			strSql.Append("ZhiWei=@ZhiWei,");
			strSql.Append("ZaiGang=@ZaiGang,");
			strSql.Append("EmailStr=@EmailStr,");
			strSql.Append("IfLogin=@IfLogin,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append("BirthDay=@BirthDay,");
			strSql.Append("MingZu=@MingZu,");
			strSql.Append("SFZSerils=@SFZSerils,");
			strSql.Append("HunYing=@HunYing,");
			strSql.Append("ZhengZhiMianMao=@ZhengZhiMianMao,");
			strSql.Append("JiGuan=@JiGuan,");
			strSql.Append("HuKou=@HuKou,");
			strSql.Append("XueLi=@XueLi,");
			strSql.Append("ZhiCheng=@ZhiCheng,");
			strSql.Append("BiYeYuanXiao=@BiYeYuanXiao,");
			strSql.Append("ZhuanYe=@ZhuanYe,");
			strSql.Append("CanJiaGongZuoTime=@CanJiaGongZuoTime,");
			strSql.Append("JiaRuBenDanWeiTime=@JiaRuBenDanWeiTime,");
			strSql.Append("JiaTingDianHua=@JiaTingDianHua,");
			strSql.Append("JiaTingAddress=@JiaTingAddress,");
			strSql.Append("GangWeiBianDong=@GangWeiBianDong,");
			strSql.Append("JiaoYueBeiJing=@JiaoYueBeiJing,");
			strSql.Append("GongZuoJianLi=@GongZuoJianLi,");
			strSql.Append("SheHuiGuanXi=@SheHuiGuanXi,");
			strSql.Append("JiangChengJiLu=@JiangChengJiLu,");
			strSql.Append("ZhiWuQingKuang=@ZhiWuQingKuang,");
			strSql.Append("PeiXunJiLu=@PeiXunJiLu,");
			strSql.Append("DanBaoJiLu=@DanBaoJiLu,");
			strSql.Append("NaoDongHeTong=@NaoDongHeTong,");
			strSql.Append("SheBaoJiaoNa=@SheBaoJiaoNa,");
			strSql.Append("TiJianJiLu=@TiJianJiLu,");
			strSql.Append("BeiZhuStr=@BeiZhuStr,");
			strSql.Append("FuJian=@FuJian");
			strSql.Append(" where ID="+ID+" ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@UserPwd", SqlDbType.VarChar,200),
					new SqlParameter("@TrueName", SqlDbType.VarChar,50),
					new SqlParameter("@Serils", SqlDbType.VarChar,50),
					new SqlParameter("@Department", SqlDbType.VarChar,50),
					new SqlParameter("@JiaoSe", SqlDbType.VarChar,50),					
					new SqlParameter("@ZhiWei", SqlDbType.VarChar,50),
					new SqlParameter("@ZaiGang", SqlDbType.VarChar,50),
					new SqlParameter("@EmailStr", SqlDbType.VarChar,50),
					new SqlParameter("@IfLogin", SqlDbType.VarChar,50),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,8000),
					new SqlParameter("@BirthDay", SqlDbType.VarChar,50),
					new SqlParameter("@MingZu", SqlDbType.VarChar,50),
					new SqlParameter("@SFZSerils", SqlDbType.VarChar,50),
					new SqlParameter("@HunYing", SqlDbType.VarChar,50),
					new SqlParameter("@ZhengZhiMianMao", SqlDbType.VarChar,50),
					new SqlParameter("@JiGuan", SqlDbType.VarChar,50),
					new SqlParameter("@HuKou", SqlDbType.VarChar,500),
					new SqlParameter("@XueLi", SqlDbType.VarChar,50),
					new SqlParameter("@ZhiCheng", SqlDbType.VarChar,50),
					new SqlParameter("@BiYeYuanXiao", SqlDbType.VarChar,50),
					new SqlParameter("@ZhuanYe", SqlDbType.VarChar,50),
					new SqlParameter("@CanJiaGongZuoTime", SqlDbType.VarChar,50),
					new SqlParameter("@JiaRuBenDanWeiTime", SqlDbType.VarChar,50),
					new SqlParameter("@JiaTingDianHua", SqlDbType.VarChar,50),
					new SqlParameter("@JiaTingAddress", SqlDbType.VarChar,500),
					new SqlParameter("@GangWeiBianDong", SqlDbType.Text),
					new SqlParameter("@JiaoYueBeiJing", SqlDbType.Text),
					new SqlParameter("@GongZuoJianLi", SqlDbType.Text),
					new SqlParameter("@SheHuiGuanXi", SqlDbType.Text),
					new SqlParameter("@JiangChengJiLu", SqlDbType.Text),
					new SqlParameter("@ZhiWuQingKuang", SqlDbType.Text),
					new SqlParameter("@PeiXunJiLu", SqlDbType.Text),
					new SqlParameter("@DanBaoJiLu", SqlDbType.Text),
					new SqlParameter("@NaoDongHeTong", SqlDbType.Text),
					new SqlParameter("@SheBaoJiaoNa", SqlDbType.Text),
					new SqlParameter("@TiJianJiLu", SqlDbType.Text),
					new SqlParameter("@BeiZhuStr", SqlDbType.Text),
					new SqlParameter("@FuJian", SqlDbType.VarChar,5000)};
			parameters[0].Value = ID;
			parameters[1].Value = UserName;
			parameters[2].Value = UserPwd;
			parameters[3].Value = TrueName;
			parameters[4].Value = Serils;
			parameters[5].Value = Department;
			parameters[6].Value = JiaoSe;			
			parameters[7].Value = ZhiWei;
			parameters[8].Value = ZaiGang;
			parameters[9].Value = EmailStr;
			parameters[10].Value = IfLogin;
			parameters[11].Value = Sex;
			parameters[12].Value = BackInfo;
			parameters[13].Value = BirthDay;
			parameters[14].Value = MingZu;
			parameters[15].Value = SFZSerils;
			parameters[16].Value = HunYing;
			parameters[17].Value = ZhengZhiMianMao;
			parameters[18].Value = JiGuan;
			parameters[19].Value = HuKou;
			parameters[20].Value = XueLi;
			parameters[21].Value = ZhiCheng;
			parameters[22].Value = BiYeYuanXiao;
			parameters[23].Value = ZhuanYe;
			parameters[24].Value = CanJiaGongZuoTime;
			parameters[25].Value = JiaRuBenDanWeiTime;
			parameters[26].Value = JiaTingDianHua;
			parameters[27].Value = JiaTingAddress;
			parameters[28].Value = GangWeiBianDong;
			parameters[29].Value = JiaoYueBeiJing;
			parameters[30].Value = GongZuoJianLi;
			parameters[31].Value = SheHuiGuanXi;
			parameters[32].Value = JiangChengJiLu;
			parameters[33].Value = ZhiWuQingKuang;
			parameters[34].Value = PeiXunJiLu;
			parameters[35].Value = DanBaoJiLu;
			parameters[36].Value = NaoDongHeTong;
			parameters[37].Value = SheBaoJiaoNa;
			parameters[38].Value = TiJianJiLu;
			parameters[39].Value = BeiZhuStr;
			parameters[40].Value = FuJian;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete ERPUser ");
			strSql.Append(" where ID="+ID+" ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)				};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public void GetModel(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,UserName,UserPwd,TrueName,Serils,Department,JiaoSe,ActiveTime,ZhiWei,ZaiGang,EmailStr,IfLogin,Sex,BackInfo,BirthDay,MingZu,SFZSerils,HunYing,ZhengZhiMianMao,JiGuan,HuKou,XueLi,ZhiCheng,BiYeYuanXiao,ZhuanYe,CanJiaGongZuoTime,JiaRuBenDanWeiTime,JiaTingDianHua,JiaTingAddress,GangWeiBianDong,JiaoYueBeiJing,GongZuoJianLi,SheHuiGuanXi,JiangChengJiLu,ZhiWuQingKuang,PeiXunJiLu,DanBaoJiLu,NaoDongHeTong,SheBaoJiaoNa,TiJianJiLu,BeiZhuStr,FuJian ");
			strSql.Append(" FROM ERPUser ");
			strSql.Append(" where ID="+ID+" ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)				};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				UserPwd=ds.Tables[0].Rows[0]["UserPwd"].ToString();
				TrueName=ds.Tables[0].Rows[0]["TrueName"].ToString();
				Serils=ds.Tables[0].Rows[0]["Serils"].ToString();
				Department=ds.Tables[0].Rows[0]["Department"].ToString();
				JiaoSe=ds.Tables[0].Rows[0]["JiaoSe"].ToString();
				if(ds.Tables[0].Rows[0]["ActiveTime"].ToString()!="")
				{
					ActiveTime=DateTime.Parse(ds.Tables[0].Rows[0]["ActiveTime"].ToString());
				}
				ZhiWei=ds.Tables[0].Rows[0]["ZhiWei"].ToString();
				ZaiGang=ds.Tables[0].Rows[0]["ZaiGang"].ToString();
				EmailStr=ds.Tables[0].Rows[0]["EmailStr"].ToString();
				IfLogin=ds.Tables[0].Rows[0]["IfLogin"].ToString();
				Sex=ds.Tables[0].Rows[0]["Sex"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				BirthDay=ds.Tables[0].Rows[0]["BirthDay"].ToString();
				MingZu=ds.Tables[0].Rows[0]["MingZu"].ToString();
				SFZSerils=ds.Tables[0].Rows[0]["SFZSerils"].ToString();
				HunYing=ds.Tables[0].Rows[0]["HunYing"].ToString();
				ZhengZhiMianMao=ds.Tables[0].Rows[0]["ZhengZhiMianMao"].ToString();
				JiGuan=ds.Tables[0].Rows[0]["JiGuan"].ToString();
				HuKou=ds.Tables[0].Rows[0]["HuKou"].ToString();
				XueLi=ds.Tables[0].Rows[0]["XueLi"].ToString();
				ZhiCheng=ds.Tables[0].Rows[0]["ZhiCheng"].ToString();
				BiYeYuanXiao=ds.Tables[0].Rows[0]["BiYeYuanXiao"].ToString();
				ZhuanYe=ds.Tables[0].Rows[0]["ZhuanYe"].ToString();
				CanJiaGongZuoTime=ds.Tables[0].Rows[0]["CanJiaGongZuoTime"].ToString();
				JiaRuBenDanWeiTime=ds.Tables[0].Rows[0]["JiaRuBenDanWeiTime"].ToString();
				JiaTingDianHua=ds.Tables[0].Rows[0]["JiaTingDianHua"].ToString();
				JiaTingAddress=ds.Tables[0].Rows[0]["JiaTingAddress"].ToString();
				GangWeiBianDong=ds.Tables[0].Rows[0]["GangWeiBianDong"].ToString();
				JiaoYueBeiJing=ds.Tables[0].Rows[0]["JiaoYueBeiJing"].ToString();
				GongZuoJianLi=ds.Tables[0].Rows[0]["GongZuoJianLi"].ToString();
				SheHuiGuanXi=ds.Tables[0].Rows[0]["SheHuiGuanXi"].ToString();
				JiangChengJiLu=ds.Tables[0].Rows[0]["JiangChengJiLu"].ToString();
				ZhiWuQingKuang=ds.Tables[0].Rows[0]["ZhiWuQingKuang"].ToString();
				PeiXunJiLu=ds.Tables[0].Rows[0]["PeiXunJiLu"].ToString();
				DanBaoJiLu=ds.Tables[0].Rows[0]["DanBaoJiLu"].ToString();
				NaoDongHeTong=ds.Tables[0].Rows[0]["NaoDongHeTong"].ToString();
				SheBaoJiaoNa=ds.Tables[0].Rows[0]["SheBaoJiaoNa"].ToString();
				TiJianJiLu=ds.Tables[0].Rows[0]["TiJianJiLu"].ToString();
				BeiZhuStr=ds.Tables[0].Rows[0]["BeiZhuStr"].ToString();
				FuJian=ds.Tables[0].Rows[0]["FuJian"].ToString();
			}
		}

        /**/
        /// <summary>
        /// 分析用户请求是否正常
        /// </summary>
        /// <param name="Str">传入用户提交数据</param>
        /// <returns>返回是否含有SQL注入式攻击代码</returns>
        public string ProcessSqlStr(string Str)
        {
            string SqlStr = "'|exec|insert|select|delete|update|count|chr|mid|master|truncate|char|declare";
            string ReturnValue = Str;
            try
            {
                if (Str != "")
                {
                    string[] anySqlStr = SqlStr.Split('|');
                    foreach (string ss in anySqlStr)
                    {
                        if (Str.ToLower().IndexOf(ss) >= 0)
                        {
                            ReturnValue = "";
                        }
                    }
                }
            }
            catch
            {
                ReturnValue = "";
            }
            if (Str.Length > 20)
            {
                ReturnValue = "";
            }
            return ReturnValue;
        }

        /// <summary>
        /// 登陆系统
        /// </summary>
        /// <param name="MyUserName"></param>
        /// <param name="MyUserPwd"></param>
        public string UserLogin(string MyUserName, string MyUserPwd)
        {
            string SqlSTr = "select * from ERPUser where UserName='" + ProcessSqlStr(MyUserName) + "' or Serils='" + ProcessSqlStr(MyUserName) + "'";
            DataRow MyDataRow = DbHelperSQL.GetDataRow(SqlSTr);
            if (MyDataRow == null)
            {
                return "您所输入的用户名不存在";
            }
            else
            {
                if (MyUserPwd == FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "UserPwd"))
                {
                    if (FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "IfLogin").Trim() == "是")
                    {
                        return "ok";
                    }
                }
            }
            return "false";
        }

        /// <summary>
        /// 登陆系统
        /// </summary>
        /// <param name="MyUserName"></param>
        /// <param name="MyUserPwd"></param>
        public void UserLogin(string MyUserName, string MyUserPwd,string IFPop,string LoginType,string LoginToUrl,bool rem)
        {
            string SqlSTr = "select * from ERPUser where UserName='" + ProcessSqlStr(MyUserName) + "'";
            if (LoginType == "0")
            {
                SqlSTr = "select * from ERPUser where Serils='" + ProcessSqlStr(MyUserName) + "'";
            }
            else if (LoginType == "1")
            {
                SqlSTr = "select * from ERPUser where UserName='" + ProcessSqlStr(MyUserName) + "'";
            }
            else
            {
                SqlSTr = "select * from ERPUser where UserName='" + ProcessSqlStr(MyUserName) + "' or Serils='" + ProcessSqlStr(MyUserName) + "'";
            }

            DataRow MyDataRow = DbHelperSQL.GetDataRow(SqlSTr);
            if (MyDataRow == null)
            {
                System.Web.HttpContext.Current.Response.Write("<script language='javascript'>alert('您所输入的用户名不存在！');history.back();</script>");
            }
            else
            {
                if (MyUserPwd == FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "UserPwd"))
                {
                    if (FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "IfLogin").Trim()=="是")
                    {
                        System.Web.HttpContext.Current.Session["UserID"] = FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "ID");
                        System.Web.HttpContext.Current.Session["UserName"] = FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "UserName");
                        System.Web.HttpContext.Current.Session["Password"] = FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "UserPwd");
                        System.Web.HttpContext.Current.Session["JiaoSe"] = FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "JiaoSe");
                        System.Web.HttpContext.Current.Session["Department"] = FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "Department");
                        System.Web.HttpContext.Current.Session["TrueName"] = FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "TrueName");
                        System.Web.HttpContext.Current.Session["ZhiWei"] = FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "ZhiWei");
                        System.Web.HttpContext.Current.Session["QuanXian"] = FTD.DBUnit.DbHelperSQL.GetStringList("select QuanXian from ERPJiaoSe where JiaoSeName in(" +"'"+FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "JiaoSe").Replace(",","','")+"'"+ ")");
                        //写登陆日志
                        ERPRiZhi MyRiZhi = new ERPRiZhi();
                        MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
                        MyRiZhi.DoSomething = "用户登陆系统";
                        MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
                        MyRiZhi.Add();
                        //写入Cookies
                        if (rem)
                        {
                          FTD.Unit.PublicMethod.WriteCookie("DTRememberName", System.Web.HttpContext.Current.Session["UserName"].ToString(), 14400);
                        }
                        else
                        {
                            FTD.Unit.PublicMethod.WriteCookie("DTRememberName", System.Web.HttpContext.Current.Session["UserName"].ToString(), -14400);
                        }
                        FTD.Unit.PublicMethod.WriteCookie("AdminName", "DTcms", System.Web.HttpContext.Current.Session["UserName"].ToString());
                        FTD.Unit.PublicMethod.WriteCookie("AdminPwd", "DTcms", System.Web.HttpContext.Current.Session["Password"].ToString());
                        if (IFPop == "否")
                        {
                            //系统跳转
                            System.Web.HttpContext.Current.Response.Redirect(LoginToUrl);
                        }
                        else
                        {
                            System.Web.HttpContext.Current.Response.Write("<script language=javascript>window.open ('" + LoginToUrl + "','_blank', 'width='+screen.availWidth+',height='+screen.availHeight-20+', left=0,top=0,toolbar=no, menubar=no, scrollbars=no,location=no, status=no') ;window.opener='';window.close();</script>");
                        }
                    }
                    else
                    {
                        System.Web.HttpContext.Current.Response.Write("<script language='javascript'>alert('该用户暂时不允许登陆系统，请联系管理员！');history.back();</script>");
                    }
                }
                else
                {
                    System.Web.HttpContext.Current.Response.Write("<script language='javascript'>alert('该用户名对应的密码错误！');history.back();</script>");
                }
            }
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select [ID],[UserName],[UserPwd],[TrueName],[Serils],[Department],[JiaoSe],[ActiveTime],[ZhiWei],[ZaiGang],[EmailStr],[IfLogin],[Sex],[BackInfo],[BirthDay],[MingZu],[SFZSerils],[HunYing],[ZhengZhiMianMao],[JiGuan],[HuKou],[XueLi],[ZhiCheng],[BiYeYuanXiao],[ZhuanYe],[CanJiaGongZuoTime],[JiaRuBenDanWeiTime],[JiaTingDianHua],[JiaTingAddress],[GangWeiBianDong],[JiaoYueBeiJing],[GongZuoJianLi],[SheHuiGuanXi],[JiangChengJiLu],[ZhiWuQingKuang],[PeiXunJiLu],[DanBaoJiLu],[NaoDongHeTong],[SheBaoJiaoNa],[TiJianJiLu],[BeiZhuStr],[FuJian] ");
			strSql.Append(" FROM ERPUser ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

     

		#endregion  成员方法

	}
}