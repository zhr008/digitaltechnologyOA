using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPTongXunLu。
    /// </summary>
    public class ERPTongXunLu
    {
        public ERPTongXunLu()
        { }
        #region Model
        private int _id;
        private string _username;
        private string _ifshare;
        private string _typestr;
        private string _fenzu;
        private string _namestr;
        private string _sex;
        private string _birthday;
        private string _nicheng;
        private string _zhiwu;
        private string _peiou;
        private string _zinv;
        private string _danweimingcheng;
        private string _danweidizhi;
        private string _danweiyoubian;
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
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 是否共享
        /// </summary>
        public string IfShare
        {
            set { _ifshare = value; }
            get { return _ifshare; }
        }
        /// <summary>
        /// 类别（共享、个人、公共）
        /// </summary>
        public string TypeStr
        {
            set { _typestr = value; }
            get { return _typestr; }
        }
        /// <summary>
        /// 分组
        /// </summary>
        public string FenZu
        {
            set { _fenzu = value; }
            get { return _fenzu; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NameStr
        {
            set { _namestr = value; }
            get { return _namestr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BirthDay
        {
            set { _birthday = value; }
            get { return _birthday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NiCheng
        {
            set { _nicheng = value; }
            get { return _nicheng; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZhiWu
        {
            set { _zhiwu = value; }
            get { return _zhiwu; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PeiOu
        {
            set { _peiou = value; }
            get { return _peiou; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZiNv
        {
            set { _zinv = value; }
            get { return _zinv; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DanWeiMingCheng
        {
            set { _danweimingcheng = value; }
            get { return _danweimingcheng; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DanWeiDiZhi
        {
            set { _danweidizhi = value; }
            get { return _danweidizhi; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DanWeiYouBian
        {
            set { _danweiyoubian = value; }
            get { return _danweiyoubian; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DanWieDianHua
        {
            set { _danwiedianhua = value; }
            get { return _danwiedianhua; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DanWeiChuanZhen
        {
            set { _danweichuanzhen = value; }
            get { return _danweichuanzhen; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string JiaTingZhuZhi
        {
            set { _jiatingzhuzhi = value; }
            get { return _jiatingzhuzhi; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string JiaTingYouBian
        {
            set { _jiatingyoubian = value; }
            get { return _jiatingyoubian; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string JiaTingDianHua
        {
            set { _jiatingdianhua = value; }
            get { return _jiatingdianhua; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShouJi
        {
            set { _shouji = value; }
            get { return _shouji; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string XiaoLingTong
        {
            set { _xiaolingtong = value; }
            get { return _xiaolingtong; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QQ
        {
            set { _qq = value; }
            get { return _qq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Msn
        {
            set { _msn = value; }
            get { return _msn; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BackInfo
        {
            set { _backinfo = value; }
            get { return _backinfo; }
        }
        #endregion Model


        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPTongXunLu");
            strSql.Append(" where ID=" + ID + " ");

            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)				};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ERPTongXunLu(");
            strSql.Append("UserName,IfShare,TypeStr,FenZu,NameStr,Sex,BirthDay,NiCheng,ZhiWu,PeiOu,ZiNv,DanWeiMingCheng,DanWeiDiZhi,DanWeiYouBian,DanWieDianHua,DanWeiChuanZhen,JiaTingZhuZhi,JiaTingYouBian,JiaTingDianHua,ShouJi,XiaoLingTong,Email,QQ,Msn,BackInfo)");
            strSql.Append(" values (");
            strSql.Append("@UserName,@IfShare,@TypeStr,@FenZu,@NameStr,@Sex,@BirthDay,@NiCheng,@ZhiWu,@PeiOu,@ZiNv,@DanWeiMingCheng,@DanWeiDiZhi,@DanWeiYouBian,@DanWieDianHua,@DanWeiChuanZhen,@JiaTingZhuZhi,@JiaTingYouBian,@JiaTingDianHua,@ShouJi,@XiaoLingTong,@Email,@QQ,@Msn,@BackInfo)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@IfShare", SqlDbType.VarChar,50),
					new SqlParameter("@TypeStr", SqlDbType.VarChar,50),
					new SqlParameter("@FenZu", SqlDbType.VarChar,50),
					new SqlParameter("@NameStr", SqlDbType.VarChar,50),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@BirthDay", SqlDbType.VarChar,50),
					new SqlParameter("@NiCheng", SqlDbType.VarChar,50),
					new SqlParameter("@ZhiWu", SqlDbType.VarChar,50),
					new SqlParameter("@PeiOu", SqlDbType.VarChar,500),
					new SqlParameter("@ZiNv", SqlDbType.VarChar,500),
					new SqlParameter("@DanWeiMingCheng", SqlDbType.VarChar,500),
					new SqlParameter("@DanWeiDiZhi", SqlDbType.VarChar,500),
					new SqlParameter("@DanWeiYouBian", SqlDbType.VarChar,50),
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
					new SqlParameter("@BackInfo", SqlDbType.Text)};
            parameters[0].Value = UserName;
            parameters[1].Value = IfShare;
            parameters[2].Value = TypeStr;
            parameters[3].Value = FenZu;
            parameters[4].Value = NameStr;
            parameters[5].Value = Sex;
            parameters[6].Value = BirthDay;
            parameters[7].Value = NiCheng;
            parameters[8].Value = ZhiWu;
            parameters[9].Value = PeiOu;
            parameters[10].Value = ZiNv;
            parameters[11].Value = DanWeiMingCheng;
            parameters[12].Value = DanWeiDiZhi;
            parameters[13].Value = DanWeiYouBian;
            parameters[14].Value = DanWieDianHua;
            parameters[15].Value = DanWeiChuanZhen;
            parameters[16].Value = JiaTingZhuZhi;
            parameters[17].Value = JiaTingYouBian;
            parameters[18].Value = JiaTingDianHua;
            parameters[19].Value = ShouJi;
            parameters[20].Value = XiaoLingTong;
            parameters[21].Value = Email;
            parameters[22].Value = QQ;
            parameters[23].Value = Msn;
            parameters[24].Value = BackInfo;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ERPTongXunLu set ");
            strSql.Append("UserName=@UserName,");
            strSql.Append("IfShare=@IfShare,");
            strSql.Append("TypeStr=@TypeStr,");
            strSql.Append("FenZu=@FenZu,");
            strSql.Append("NameStr=@NameStr,");
            strSql.Append("Sex=@Sex,");
            strSql.Append("BirthDay=@BirthDay,");
            strSql.Append("NiCheng=@NiCheng,");
            strSql.Append("ZhiWu=@ZhiWu,");
            strSql.Append("PeiOu=@PeiOu,");
            strSql.Append("ZiNv=@ZiNv,");
            strSql.Append("DanWeiMingCheng=@DanWeiMingCheng,");
            strSql.Append("DanWeiDiZhi=@DanWeiDiZhi,");
            strSql.Append("DanWeiYouBian=@DanWeiYouBian,");
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
            strSql.Append("BackInfo=@BackInfo");
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@IfShare", SqlDbType.VarChar,50),
					new SqlParameter("@TypeStr", SqlDbType.VarChar,50),
					new SqlParameter("@FenZu", SqlDbType.VarChar,50),
					new SqlParameter("@NameStr", SqlDbType.VarChar,50),
					new SqlParameter("@Sex", SqlDbType.VarChar,50),
					new SqlParameter("@BirthDay", SqlDbType.VarChar,50),
					new SqlParameter("@NiCheng", SqlDbType.VarChar,50),
					new SqlParameter("@ZhiWu", SqlDbType.VarChar,50),
					new SqlParameter("@PeiOu", SqlDbType.VarChar,500),
					new SqlParameter("@ZiNv", SqlDbType.VarChar,500),
					new SqlParameter("@DanWeiMingCheng", SqlDbType.VarChar,500),
					new SqlParameter("@DanWeiDiZhi", SqlDbType.VarChar,500),
					new SqlParameter("@DanWeiYouBian", SqlDbType.VarChar,50),
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
					new SqlParameter("@BackInfo", SqlDbType.Text)};
            parameters[0].Value = ID;
            parameters[1].Value = UserName;
            parameters[2].Value = IfShare;
            parameters[3].Value = TypeStr;
            parameters[4].Value = FenZu;
            parameters[5].Value = NameStr;
            parameters[6].Value = Sex;
            parameters[7].Value = BirthDay;
            parameters[8].Value = NiCheng;
            parameters[9].Value = ZhiWu;
            parameters[10].Value = PeiOu;
            parameters[11].Value = ZiNv;
            parameters[12].Value = DanWeiMingCheng;
            parameters[13].Value = DanWeiDiZhi;
            parameters[14].Value = DanWeiYouBian;
            parameters[15].Value = DanWieDianHua;
            parameters[16].Value = DanWeiChuanZhen;
            parameters[17].Value = JiaTingZhuZhi;
            parameters[18].Value = JiaTingYouBian;
            parameters[19].Value = JiaTingDianHua;
            parameters[20].Value = ShouJi;
            parameters[21].Value = XiaoLingTong;
            parameters[22].Value = Email;
            parameters[23].Value = QQ;
            parameters[24].Value = Msn;
            parameters[25].Value = BackInfo;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPTongXunLu ");
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)				};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,UserName,IfShare,TypeStr,FenZu,NameStr,Sex,BirthDay,NiCheng,ZhiWu,PeiOu,ZiNv,DanWeiMingCheng,DanWeiDiZhi,DanWeiYouBian,DanWieDianHua,DanWeiChuanZhen,JiaTingZhuZhi,JiaTingYouBian,JiaTingDianHua,ShouJi,XiaoLingTong,Email,QQ,Msn,BackInfo ");
            strSql.Append(" FROM ERPTongXunLu ");
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)				};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                IfShare = ds.Tables[0].Rows[0]["IfShare"].ToString();
                TypeStr = ds.Tables[0].Rows[0]["TypeStr"].ToString();
                FenZu = ds.Tables[0].Rows[0]["FenZu"].ToString();
                NameStr = ds.Tables[0].Rows[0]["NameStr"].ToString();
                Sex = ds.Tables[0].Rows[0]["Sex"].ToString();
                BirthDay = ds.Tables[0].Rows[0]["BirthDay"].ToString();
                NiCheng = ds.Tables[0].Rows[0]["NiCheng"].ToString();
                ZhiWu = ds.Tables[0].Rows[0]["ZhiWu"].ToString();
                PeiOu = ds.Tables[0].Rows[0]["PeiOu"].ToString();
                ZiNv = ds.Tables[0].Rows[0]["ZiNv"].ToString();
                DanWeiMingCheng = ds.Tables[0].Rows[0]["DanWeiMingCheng"].ToString();
                DanWeiDiZhi = ds.Tables[0].Rows[0]["DanWeiDiZhi"].ToString();
                DanWeiYouBian = ds.Tables[0].Rows[0]["DanWeiYouBian"].ToString();
                DanWieDianHua = ds.Tables[0].Rows[0]["DanWieDianHua"].ToString();
                DanWeiChuanZhen = ds.Tables[0].Rows[0]["DanWeiChuanZhen"].ToString();
                JiaTingZhuZhi = ds.Tables[0].Rows[0]["JiaTingZhuZhi"].ToString();
                JiaTingYouBian = ds.Tables[0].Rows[0]["JiaTingYouBian"].ToString();
                JiaTingDianHua = ds.Tables[0].Rows[0]["JiaTingDianHua"].ToString();
                ShouJi = ds.Tables[0].Rows[0]["ShouJi"].ToString();
                XiaoLingTong = ds.Tables[0].Rows[0]["XiaoLingTong"].ToString();
                Email = ds.Tables[0].Rows[0]["Email"].ToString();
                QQ = ds.Tables[0].Rows[0]["QQ"].ToString();
                Msn = ds.Tables[0].Rows[0]["Msn"].ToString();
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ID],[UserName],[IfShare],[TypeStr],[FenZu],[NameStr],[Sex],[BirthDay],[NiCheng],[ZhiWu],[PeiOu],[ZiNv],[DanWeiMingCheng],[DanWeiDiZhi],[DanWeiYouBian],[DanWieDianHua],[DanWeiChuanZhen],[JiaTingZhuZhi],[JiaTingYouBian],[JiaTingDianHua],[ShouJi],[XiaoLingTong],[Email],[QQ],[Msn],[BackInfo] ");
            strSql.Append(" FROM ERPTongXunLu ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}