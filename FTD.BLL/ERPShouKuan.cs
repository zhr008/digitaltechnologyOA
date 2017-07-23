using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPShouKuan。
    /// </summary>
    public class ERPShouKuan
    {
        public ERPShouKuan()
        { }
        #region Model
        private int _id;
        private string _projectname;
        private string _projectserils;
        private string _jieduanname;
        private string _shoukuane;
        private string _fapiaohao;
        private string _shoukuandate;
        private string _daokuandate;
        private string _shengyue;
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
        /// 
        /// </summary>
        public string ProjectName
        {
            set { _projectname = value; }
            get { return _projectname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ProjectSerils
        {
            set { _projectserils = value; }
            get { return _projectserils; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string JieDuanName
        {
            set { _jieduanname = value; }
            get { return _jieduanname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShouKuanE
        {
            set { _shoukuane = value; }
            get { return _shoukuane; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FaPiaoHao
        {
            set { _fapiaohao = value; }
            get { return _fapiaohao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShouKuanDate
        {
            set { _shoukuandate = value; }
            get { return _shoukuandate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DaoKuanDate
        {
            set { _daokuandate = value; }
            get { return _daokuandate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShengYuE
        {
            set { _shengyue = value; }
            get { return _shengyue; }
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
        /// 
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
        public ERPShouKuan(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,ProjectName,ProjectSerils,JieDuanName,ShouKuanE,FaPiaoHao,ShouKuanDate,DaoKuanDate,ShengYuE,UserName,TimeStr ");
            strSql.Append(" FROM ERPShouKuan ");
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
                ProjectName = ds.Tables[0].Rows[0]["ProjectName"].ToString();
                ProjectSerils = ds.Tables[0].Rows[0]["ProjectSerils"].ToString();
                JieDuanName = ds.Tables[0].Rows[0]["JieDuanName"].ToString();
                ShouKuanE = ds.Tables[0].Rows[0]["ShouKuanE"].ToString();
                FaPiaoHao = ds.Tables[0].Rows[0]["FaPiaoHao"].ToString();
                ShouKuanDate = ds.Tables[0].Rows[0]["ShouKuanDate"].ToString();
                DaoKuanDate = ds.Tables[0].Rows[0]["DaoKuanDate"].ToString();
                ShengYuE = ds.Tables[0].Rows[0]["ShengYuE"].ToString();
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
            strSql.Append("select count(1) from ERPShouKuan");
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
            strSql.Append("insert into ERPShouKuan(");
            strSql.Append("ProjectName,ProjectSerils,JieDuanName,ShouKuanE,FaPiaoHao,ShouKuanDate,DaoKuanDate,ShengYuE,UserName,TimeStr)");
            strSql.Append(" values (");
            strSql.Append("@ProjectName,@ProjectSerils,@JieDuanName,@ShouKuanE,@FaPiaoHao,@ShouKuanDate,@DaoKuanDate,@ShengYuE,@UserName,@TimeStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ProjectName", SqlDbType.VarChar,200),
					new SqlParameter("@ProjectSerils", SqlDbType.VarChar,50),
					new SqlParameter("@JieDuanName", SqlDbType.VarChar,50),
					new SqlParameter("@ShouKuanE", SqlDbType.VarChar,50),
					new SqlParameter("@FaPiaoHao", SqlDbType.VarChar,50),
					new SqlParameter("@ShouKuanDate", SqlDbType.VarChar,50),
					new SqlParameter("@DaoKuanDate", SqlDbType.VarChar,50),
					new SqlParameter("@ShengYuE", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = ProjectName;
            parameters[1].Value = ProjectSerils;
            parameters[2].Value = JieDuanName;
            parameters[3].Value = ShouKuanE;
            parameters[4].Value = FaPiaoHao;
            parameters[5].Value = ShouKuanDate;
            parameters[6].Value = DaoKuanDate;
            parameters[7].Value = ShengYuE;
            parameters[8].Value = UserName;
            parameters[9].Value = TimeStr;

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
            strSql.Append("update ERPShouKuan set ");
            strSql.Append("ProjectName=@ProjectName,");
            strSql.Append("ProjectSerils=@ProjectSerils,");
            strSql.Append("JieDuanName=@JieDuanName,");
            strSql.Append("ShouKuanE=@ShouKuanE,");
            strSql.Append("FaPiaoHao=@FaPiaoHao,");
            strSql.Append("ShouKuanDate=@ShouKuanDate,");
            strSql.Append("DaoKuanDate=@DaoKuanDate,");
            strSql.Append("ShengYuE=@ShengYuE,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TimeStr=@TimeStr");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@ProjectName", SqlDbType.VarChar,200),
					new SqlParameter("@ProjectSerils", SqlDbType.VarChar,50),
					new SqlParameter("@JieDuanName", SqlDbType.VarChar,50),
					new SqlParameter("@ShouKuanE", SqlDbType.VarChar,50),
					new SqlParameter("@FaPiaoHao", SqlDbType.VarChar,50),
					new SqlParameter("@ShouKuanDate", SqlDbType.VarChar,50),
					new SqlParameter("@DaoKuanDate", SqlDbType.VarChar,50),
					new SqlParameter("@ShengYuE", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = ID;
            parameters[1].Value = ProjectName;
            parameters[2].Value = ProjectSerils;
            parameters[3].Value = JieDuanName;
            parameters[4].Value = ShouKuanE;
            parameters[5].Value = FaPiaoHao;
            parameters[6].Value = ShouKuanDate;
            parameters[7].Value = DaoKuanDate;
            parameters[8].Value = ShengYuE;
            parameters[9].Value = UserName;
            parameters[10].Value = TimeStr;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPShouKuan ");
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
            strSql.Append("select ID,ProjectName,ProjectSerils,JieDuanName,ShouKuanE,FaPiaoHao,ShouKuanDate,DaoKuanDate,ShengYuE,UserName,TimeStr ");
            strSql.Append(" FROM ERPShouKuan ");
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
                ProjectName = ds.Tables[0].Rows[0]["ProjectName"].ToString();
                ProjectSerils = ds.Tables[0].Rows[0]["ProjectSerils"].ToString();
                JieDuanName = ds.Tables[0].Rows[0]["JieDuanName"].ToString();
                ShouKuanE = ds.Tables[0].Rows[0]["ShouKuanE"].ToString();
                FaPiaoHao = ds.Tables[0].Rows[0]["FaPiaoHao"].ToString();
                ShouKuanDate = ds.Tables[0].Rows[0]["ShouKuanDate"].ToString();
                DaoKuanDate = ds.Tables[0].Rows[0]["DaoKuanDate"].ToString();
                ShengYuE = ds.Tables[0].Rows[0]["ShengYuE"].ToString();
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
            strSql.Append("select [ID],[ProjectName],[ProjectSerils],[JieDuanName],[ShouKuanE],[FaPiaoHao],[ShouKuanDate],[DaoKuanDate],[ShengYuE],[UserName],[TimeStr] ");
            strSql.Append(" FROM ERPShouKuan ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

