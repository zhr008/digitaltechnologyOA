using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPHuiYuan。
    /// </summary>
    public class ERPHuiYuan
    {
        public ERPHuiYuan()
        { }
        #region Model
        private int _id;
        private string _namestr;
        private string _ruhuidate;
        private string _jieshaoren;
        private string _sexstr;
        private string _jiguan;
        private string _jingji;
        private string _chushengdate;
        private string _xueli;
        private string _zili;
        private string _gexing;
        private string _aihao;
        private string _address;
        private string _tel;
        private string _mobtel;
        private string _zuijiatime;
        private string _changyong;
        private string _zixin;
        private string _jielun;
        private string _backinfo;
        private string _username;
        private DateTime? _timestr;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 姓名
        /// </summary>
        public string NameStr
        {
            set { _namestr = value; }
            get { return _namestr; }
        }
        /// <summary>
        /// 入会时间
        /// </summary>
        public string RuHuiDate
        {
            set { _ruhuidate = value; }
            get { return _ruhuidate; }
        }
        /// <summary>
        /// 介绍人

        /// </summary>
        public string JieShaoRen
        {
            set { _jieshaoren = value; }
            get { return _jieshaoren; }
        }
        /// <summary>
        /// 性别

        /// </summary>
        public string SexStr
        {
            set { _sexstr = value; }
            get { return _sexstr; }
        }
        /// <summary>
        /// 籍贯

        /// </summary>
        public string JiGuan
        {
            set { _jiguan = value; }
            get { return _jiguan; }
        }
        /// <summary>
        /// 经济状况

        /// </summary>
        public string JingJi
        {
            set { _jingji = value; }
            get { return _jingji; }
        }
        /// <summary>
        /// 出生日期

        /// </summary>
        public string ChuShengDate
        {
            set { _chushengdate = value; }
            get { return _chushengdate; }
        }
        /// <summary>
        /// 学历

        /// </summary>
        public string XueLi
        {
            set { _xueli = value; }
            get { return _xueli; }
        }
        /// <summary>
        /// 资历

        /// </summary>
        public string ZiLi
        {
            set { _zili = value; }
            get { return _zili; }
        }
        /// <summary>
        /// 个性

        /// </summary>
        public string GeXing
        {
            set { _gexing = value; }
            get { return _gexing; }
        }
        /// <summary>
        /// 爱好

        /// </summary>
        public string AiHao
        {
            set { _aihao = value; }
            get { return _aihao; }
        }
        /// <summary>
        /// 家庭住址

        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 电话
        /// </summary>
        public string Tel
        {
            set { _tel = value; }
            get { return _tel; }
        }
        /// <summary>
        /// 手机
        /// </summary>
        public string MobTel
        {
            set { _mobtel = value; }
            get { return _mobtel; }
        }
        /// <summary>
        /// 最佳拜访时间

        /// </summary>
        public string ZuiJiaTime
        {
            set { _zuijiatime = value; }
            get { return _zuijiatime; }
        }
        /// <summary>
        /// 常饮用品牌
        /// </summary>
        public string ChangYong
        {
            set { _changyong = value; }
            get { return _changyong; }
        }
        /// <summary>
        /// 资信

        /// </summary>
        public string ZiXin
        {
            set { _zixin = value; }
            get { return _zixin; }
        }
        /// <summary>
        /// 总结论

        /// </summary>
        public string JieLun
        {
            set { _jielun = value; }
            get { return _jielun; }
        }
        /// <summary>
        /// 备注说明
        /// </summary>
        public string BackInfo
        {
            set { _backinfo = value; }
            get { return _backinfo; }
        }
        /// <summary>
        /// 录入人
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 录入时间
        /// </summary>
        public DateTime? TimeStr
        {
            set { _timestr = value; }
            get { return _timestr; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPHuiYuan(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,NameStr,RuHuiDate,JieShaoRen,SexStr,JiGuan,JingJi,ChuShengDate,XueLi,ZiLi,GeXing,AiHao,Address,Tel,MobTel,ZuiJiaTime,ChangYong,ZiXin,JieLun,BackInfo,UserName,TimeStr ");
            strSql.Append(" FROM ERPHuiYuan ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                NameStr = ds.Tables[0].Rows[0]["NameStr"].ToString();
                RuHuiDate = ds.Tables[0].Rows[0]["RuHuiDate"].ToString();
                JieShaoRen = ds.Tables[0].Rows[0]["JieShaoRen"].ToString();
                SexStr = ds.Tables[0].Rows[0]["SexStr"].ToString();
                JiGuan = ds.Tables[0].Rows[0]["JiGuan"].ToString();
                JingJi = ds.Tables[0].Rows[0]["JingJi"].ToString();
                ChuShengDate = ds.Tables[0].Rows[0]["ChuShengDate"].ToString();
                XueLi = ds.Tables[0].Rows[0]["XueLi"].ToString();
                ZiLi = ds.Tables[0].Rows[0]["ZiLi"].ToString();
                GeXing = ds.Tables[0].Rows[0]["GeXing"].ToString();
                AiHao = ds.Tables[0].Rows[0]["AiHao"].ToString();
                Address = ds.Tables[0].Rows[0]["Address"].ToString();
                Tel = ds.Tables[0].Rows[0]["Tel"].ToString();
                MobTel = ds.Tables[0].Rows[0]["MobTel"].ToString();
                ZuiJiaTime = ds.Tables[0].Rows[0]["ZuiJiaTime"].ToString();
                ChangYong = ds.Tables[0].Rows[0]["ChangYong"].ToString();
                ZiXin = ds.Tables[0].Rows[0]["ZiXin"].ToString();
                JieLun = ds.Tables[0].Rows[0]["JieLun"].ToString();
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPHuiYuan");
            strSql.Append(" where ID=@ID ");

            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ERPHuiYuan(");
            strSql.Append("NameStr,RuHuiDate,JieShaoRen,SexStr,JiGuan,JingJi,ChuShengDate,XueLi,ZiLi,GeXing,AiHao,Address,Tel,MobTel,ZuiJiaTime,ChangYong,ZiXin,JieLun,BackInfo,UserName,TimeStr)");
            strSql.Append(" values (");
            strSql.Append("@NameStr,@RuHuiDate,@JieShaoRen,@SexStr,@JiGuan,@JingJi,@ChuShengDate,@XueLi,@ZiLi,@GeXing,@AiHao,@Address,@Tel,@MobTel,@ZuiJiaTime,@ChangYong,@ZiXin,@JieLun,@BackInfo,@UserName,@TimeStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@NameStr", SqlDbType.VarChar,50),
					new SqlParameter("@RuHuiDate", SqlDbType.VarChar,50),
					new SqlParameter("@JieShaoRen", SqlDbType.VarChar,50),
					new SqlParameter("@SexStr", SqlDbType.VarChar,50),
					new SqlParameter("@JiGuan", SqlDbType.VarChar,50),
					new SqlParameter("@JingJi", SqlDbType.VarChar,50),
					new SqlParameter("@ChuShengDate", SqlDbType.VarChar,50),
					new SqlParameter("@XueLi", SqlDbType.VarChar,50),
					new SqlParameter("@ZiLi", SqlDbType.VarChar,50),
					new SqlParameter("@GeXing", SqlDbType.VarChar,50),
					new SqlParameter("@AiHao", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,200),
					new SqlParameter("@Tel", SqlDbType.VarChar,50),
					new SqlParameter("@MobTel", SqlDbType.VarChar,50),
					new SqlParameter("@ZuiJiaTime", SqlDbType.VarChar,50),
					new SqlParameter("@ChangYong", SqlDbType.VarChar,50),
					new SqlParameter("@ZiXin", SqlDbType.VarChar,200),
					new SqlParameter("@JieLun", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.Text),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = NameStr;
            parameters[1].Value = RuHuiDate;
            parameters[2].Value = JieShaoRen;
            parameters[3].Value = SexStr;
            parameters[4].Value = JiGuan;
            parameters[5].Value = JingJi;
            parameters[6].Value = ChuShengDate;
            parameters[7].Value = XueLi;
            parameters[8].Value = ZiLi;
            parameters[9].Value = GeXing;
            parameters[10].Value = AiHao;
            parameters[11].Value = Address;
            parameters[12].Value = Tel;
            parameters[13].Value = MobTel;
            parameters[14].Value = ZuiJiaTime;
            parameters[15].Value = ChangYong;
            parameters[16].Value = ZiXin;
            parameters[17].Value = JieLun;
            parameters[18].Value = BackInfo;
            parameters[19].Value = UserName;
            parameters[20].Value = TimeStr;

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
            strSql.Append("update ERPHuiYuan set ");
            strSql.Append("NameStr=@NameStr,");
            strSql.Append("RuHuiDate=@RuHuiDate,");
            strSql.Append("JieShaoRen=@JieShaoRen,");
            strSql.Append("SexStr=@SexStr,");
            strSql.Append("JiGuan=@JiGuan,");
            strSql.Append("JingJi=@JingJi,");
            strSql.Append("ChuShengDate=@ChuShengDate,");
            strSql.Append("XueLi=@XueLi,");
            strSql.Append("ZiLi=@ZiLi,");
            strSql.Append("GeXing=@GeXing,");
            strSql.Append("AiHao=@AiHao,");
            strSql.Append("Address=@Address,");
            strSql.Append("Tel=@Tel,");
            strSql.Append("MobTel=@MobTel,");
            strSql.Append("ZuiJiaTime=@ZuiJiaTime,");
            strSql.Append("ChangYong=@ChangYong,");
            strSql.Append("ZiXin=@ZiXin,");
            strSql.Append("JieLun=@JieLun,");
            strSql.Append("BackInfo=@BackInfo,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TimeStr=@TimeStr");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@NameStr", SqlDbType.VarChar,50),
					new SqlParameter("@RuHuiDate", SqlDbType.VarChar,50),
					new SqlParameter("@JieShaoRen", SqlDbType.VarChar,50),
					new SqlParameter("@SexStr", SqlDbType.VarChar,50),
					new SqlParameter("@JiGuan", SqlDbType.VarChar,50),
					new SqlParameter("@JingJi", SqlDbType.VarChar,50),
					new SqlParameter("@ChuShengDate", SqlDbType.VarChar,50),
					new SqlParameter("@XueLi", SqlDbType.VarChar,50),
					new SqlParameter("@ZiLi", SqlDbType.VarChar,50),
					new SqlParameter("@GeXing", SqlDbType.VarChar,50),
					new SqlParameter("@AiHao", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,200),
					new SqlParameter("@Tel", SqlDbType.VarChar,50),
					new SqlParameter("@MobTel", SqlDbType.VarChar,50),
					new SqlParameter("@ZuiJiaTime", SqlDbType.VarChar,50),
					new SqlParameter("@ChangYong", SqlDbType.VarChar,50),
					new SqlParameter("@ZiXin", SqlDbType.VarChar,200),
					new SqlParameter("@JieLun", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.Text),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = ID;
            parameters[1].Value = NameStr;
            parameters[2].Value = RuHuiDate;
            parameters[3].Value = JieShaoRen;
            parameters[4].Value = SexStr;
            parameters[5].Value = JiGuan;
            parameters[6].Value = JingJi;
            parameters[7].Value = ChuShengDate;
            parameters[8].Value = XueLi;
            parameters[9].Value = ZiLi;
            parameters[10].Value = GeXing;
            parameters[11].Value = AiHao;
            parameters[12].Value = Address;
            parameters[13].Value = Tel;
            parameters[14].Value = MobTel;
            parameters[15].Value = ZuiJiaTime;
            parameters[16].Value = ChangYong;
            parameters[17].Value = ZiXin;
            parameters[18].Value = JieLun;
            parameters[19].Value = BackInfo;
            parameters[20].Value = UserName;
            parameters[21].Value = TimeStr;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPHuiYuan ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,NameStr,RuHuiDate,JieShaoRen,SexStr,JiGuan,JingJi,ChuShengDate,XueLi,ZiLi,GeXing,AiHao,Address,Tel,MobTel,ZuiJiaTime,ChangYong,ZiXin,JieLun,BackInfo,UserName,TimeStr ");
            strSql.Append(" FROM ERPHuiYuan ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                NameStr = ds.Tables[0].Rows[0]["NameStr"].ToString();
                RuHuiDate = ds.Tables[0].Rows[0]["RuHuiDate"].ToString();
                JieShaoRen = ds.Tables[0].Rows[0]["JieShaoRen"].ToString();
                SexStr = ds.Tables[0].Rows[0]["SexStr"].ToString();
                JiGuan = ds.Tables[0].Rows[0]["JiGuan"].ToString();
                JingJi = ds.Tables[0].Rows[0]["JingJi"].ToString();
                ChuShengDate = ds.Tables[0].Rows[0]["ChuShengDate"].ToString();
                XueLi = ds.Tables[0].Rows[0]["XueLi"].ToString();
                ZiLi = ds.Tables[0].Rows[0]["ZiLi"].ToString();
                GeXing = ds.Tables[0].Rows[0]["GeXing"].ToString();
                AiHao = ds.Tables[0].Rows[0]["AiHao"].ToString();
                Address = ds.Tables[0].Rows[0]["Address"].ToString();
                Tel = ds.Tables[0].Rows[0]["Tel"].ToString();
                MobTel = ds.Tables[0].Rows[0]["MobTel"].ToString();
                ZuiJiaTime = ds.Tables[0].Rows[0]["ZuiJiaTime"].ToString();
                ChangYong = ds.Tables[0].Rows[0]["ChangYong"].ToString();
                ZiXin = ds.Tables[0].Rows[0]["ZiXin"].ToString();
                JieLun = ds.Tables[0].Rows[0]["JieLun"].ToString();
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ERPHuiYuan ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

