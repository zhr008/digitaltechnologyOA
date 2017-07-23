using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPGuDing。
    /// </summary>
    public class ERPGuDing
    {
        public ERPGuDing()
        { }
        #region Model
        private int _id;
        private string _gdname;
        private string _gdserils;
        private string _gdtype;
        private string _suoshubumen;
        private string _gdallcount;
        private string _nowcount;
        private string _nianxian;
        private string _gdxingzhi;
        private string _qiyongdate;
        private string _baoguanuser;
        private string _username;
        private DateTime? _timestr;
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
        /// 资产名称
        /// </summary>
        public string GDName
        {
            set { _gdname = value; }
            get { return _gdname; }
        }
        /// <summary>
        /// 资产编号
        /// </summary>
        public string GDSerils
        {
            set { _gdserils = value; }
            get { return _gdserils; }
        }
        /// <summary>
        /// 资产类别
        /// </summary>
        public string GDType
        {
            set { _gdtype = value; }
            get { return _gdtype; }
        }
        /// <summary>
        /// 所属部门
        /// </summary>
        public string SuoShuBuMen
        {
            set { _suoshubumen = value; }
            get { return _suoshubumen; }
        }
        /// <summary>
        /// 资产原值
        /// </summary>
        public string GDAllCount
        {
            set { _gdallcount = value; }
            get { return _gdallcount; }
        }
        /// <summary>
        /// 资产残值
        /// </summary>
        public string NowCount
        {
            set { _nowcount = value; }
            get { return _nowcount; }
        }
        /// <summary>
        /// 折旧年限
        /// </summary>
        public string NianXian
        {
            set { _nianxian = value; }
            get { return _nianxian; }
        }
        /// <summary>
        /// 资产性质
        /// </summary>
        public string GDXingZhi
        {
            set { _gdxingzhi = value; }
            get { return _gdxingzhi; }
        }
        /// <summary>
        /// 启用时间
        /// </summary>
        public string QiYongDate
        {
            set { _qiyongdate = value; }
            get { return _qiyongdate; }
        }
        /// <summary>
        /// 保管人
        /// </summary>
        public string BaoGuanUser
        {
            set { _baoguanuser = value; }
            get { return _baoguanuser; }
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
        /// <summary>
        /// 备注说明
        /// </summary>
        public string BackInfo
        {
            set { _backinfo = value; }
            get { return _backinfo; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPGuDing(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,GDName,GDSerils,GDType,SuoShuBuMen,GDAllCount,NowCount,NianXian,GDXingZhi,QiYongDate,BaoGuanUser,UserName,TimeStr,BackInfo ");
            strSql.Append(" FROM ERPGuDing ");
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
                GDName = ds.Tables[0].Rows[0]["GDName"].ToString();
                GDSerils = ds.Tables[0].Rows[0]["GDSerils"].ToString();
                GDType = ds.Tables[0].Rows[0]["GDType"].ToString();
                SuoShuBuMen = ds.Tables[0].Rows[0]["SuoShuBuMen"].ToString();
                GDAllCount = ds.Tables[0].Rows[0]["GDAllCount"].ToString();
                NowCount = ds.Tables[0].Rows[0]["NowCount"].ToString();
                NianXian = ds.Tables[0].Rows[0]["NianXian"].ToString();
                GDXingZhi = ds.Tables[0].Rows[0]["GDXingZhi"].ToString();
                QiYongDate = ds.Tables[0].Rows[0]["QiYongDate"].ToString();
                BaoGuanUser = ds.Tables[0].Rows[0]["BaoGuanUser"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPGuDing");
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
            strSql.Append("insert into ERPGuDing(");
            strSql.Append("GDName,GDSerils,GDType,SuoShuBuMen,GDAllCount,NowCount,NianXian,GDXingZhi,QiYongDate,BaoGuanUser,UserName,TimeStr,BackInfo)");
            strSql.Append(" values (");
            strSql.Append("@GDName,@GDSerils,@GDType,@SuoShuBuMen,@GDAllCount,@NowCount,@NianXian,@GDXingZhi,@QiYongDate,@BaoGuanUser,@UserName,@TimeStr,@BackInfo)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@GDName", SqlDbType.VarChar,50),
					new SqlParameter("@GDSerils", SqlDbType.VarChar,50),
					new SqlParameter("@GDType", SqlDbType.VarChar,50),
					new SqlParameter("@SuoShuBuMen", SqlDbType.VarChar,50),
					new SqlParameter("@GDAllCount", SqlDbType.VarChar,50),
					new SqlParameter("@NowCount", SqlDbType.VarChar,50),
					new SqlParameter("@NianXian", SqlDbType.VarChar,50),
					new SqlParameter("@GDXingZhi", SqlDbType.VarChar,50),
					new SqlParameter("@QiYongDate", SqlDbType.VarChar,50),
					new SqlParameter("@BaoGuanUser", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.Text)};
            parameters[0].Value = GDName;
            parameters[1].Value = GDSerils;
            parameters[2].Value = GDType;
            parameters[3].Value = SuoShuBuMen;
            parameters[4].Value = GDAllCount;
            parameters[5].Value = NowCount;
            parameters[6].Value = NianXian;
            parameters[7].Value = GDXingZhi;
            parameters[8].Value = QiYongDate;
            parameters[9].Value = BaoGuanUser;
            parameters[10].Value = UserName;
            parameters[11].Value = TimeStr;
            parameters[12].Value = BackInfo;

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
            strSql.Append("update ERPGuDing set ");
            strSql.Append("GDName=@GDName,");
            strSql.Append("GDSerils=@GDSerils,");
            strSql.Append("GDType=@GDType,");
            strSql.Append("SuoShuBuMen=@SuoShuBuMen,");
            strSql.Append("GDAllCount=@GDAllCount,");
            strSql.Append("NowCount=@NowCount,");
            strSql.Append("NianXian=@NianXian,");
            strSql.Append("GDXingZhi=@GDXingZhi,");
            strSql.Append("QiYongDate=@QiYongDate,");
            strSql.Append("BaoGuanUser=@BaoGuanUser,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TimeStr=@TimeStr,");
            strSql.Append("BackInfo=@BackInfo");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@GDName", SqlDbType.VarChar,50),
					new SqlParameter("@GDSerils", SqlDbType.VarChar,50),
					new SqlParameter("@GDType", SqlDbType.VarChar,50),
					new SqlParameter("@SuoShuBuMen", SqlDbType.VarChar,50),
					new SqlParameter("@GDAllCount", SqlDbType.VarChar,50),
					new SqlParameter("@NowCount", SqlDbType.VarChar,50),
					new SqlParameter("@NianXian", SqlDbType.VarChar,50),
					new SqlParameter("@GDXingZhi", SqlDbType.VarChar,50),
					new SqlParameter("@QiYongDate", SqlDbType.VarChar,50),
					new SqlParameter("@BaoGuanUser", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.Text)};
            parameters[0].Value = ID;
            parameters[1].Value = GDName;
            parameters[2].Value = GDSerils;
            parameters[3].Value = GDType;
            parameters[4].Value = SuoShuBuMen;
            parameters[5].Value = GDAllCount;
            parameters[6].Value = NowCount;
            parameters[7].Value = NianXian;
            parameters[8].Value = GDXingZhi;
            parameters[9].Value = QiYongDate;
            parameters[10].Value = BaoGuanUser;
            parameters[11].Value = UserName;
            parameters[12].Value = TimeStr;
            parameters[13].Value = BackInfo;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPGuDing ");
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
            strSql.Append("select  top 1 ID,GDName,GDSerils,GDType,SuoShuBuMen,GDAllCount,NowCount,NianXian,GDXingZhi,QiYongDate,BaoGuanUser,UserName,TimeStr,BackInfo ");
            strSql.Append(" FROM ERPGuDing ");
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
                GDName = ds.Tables[0].Rows[0]["GDName"].ToString();
                GDSerils = ds.Tables[0].Rows[0]["GDSerils"].ToString();
                GDType = ds.Tables[0].Rows[0]["GDType"].ToString();
                SuoShuBuMen = ds.Tables[0].Rows[0]["SuoShuBuMen"].ToString();
                GDAllCount = ds.Tables[0].Rows[0]["GDAllCount"].ToString();
                NowCount = ds.Tables[0].Rows[0]["NowCount"].ToString();
                NianXian = ds.Tables[0].Rows[0]["NianXian"].ToString();
                GDXingZhi = ds.Tables[0].Rows[0]["GDXingZhi"].ToString();
                QiYongDate = ds.Tables[0].Rows[0]["QiYongDate"].ToString();
                BaoGuanUser = ds.Tables[0].Rows[0]["BaoGuanUser"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ERPGuDing ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

