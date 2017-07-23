using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPJinDu。
    /// </summary>
    public class ERPJinDu
    {
        public ERPJinDu()
        { }
        #region Model
        private int _id;
        private string _projectname;
        private string _projectserils;
        private string _jieduanname;
        private DateTime? _starttime;
        private DateTime? _endtime;
        private string _wanchengdu;
        private string _fuzeren;
        private string _contentstr;
        private string _fujianlist;
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
        /// 项目名称：
        /// </summary>
        public string ProjectName
        {
            set { _projectname = value; }
            get { return _projectname; }
        }
        /// <summary>
        /// 项目编号：
        /// </summary>
        public string ProjectSerils
        {
            set { _projectserils = value; }
            get { return _projectserils; }
        }
        /// <summary>
        /// 阶段名称：
        /// </summary>
        public string JieDuanName
        {
            set { _jieduanname = value; }
            get { return _jieduanname; }
        }
        /// <summary>
        /// 开始时间：
        /// </summary>
        public DateTime? StartTime
        {
            set { _starttime = value; }
            get { return _starttime; }
        }
        /// <summary>
        /// 结束时间：
        /// </summary>
        public DateTime? EndTime
        {
            set { _endtime = value; }
            get { return _endtime; }
        }
        /// <summary>
        /// 完成度：
        /// </summary>
        public string WanChengDu
        {
            set { _wanchengdu = value; }
            get { return _wanchengdu; }
        }
        /// <summary>
        /// 负责人：
        /// </summary>
        public string FuZeRen
        {
            set { _fuzeren = value; }
            get { return _fuzeren; }
        }
        /// <summary>
        /// 详细内容：
        /// </summary>
        public string ContentStr
        {
            set { _contentstr = value; }
            get { return _contentstr; }
        }
        /// <summary>
        /// 附件文件：
        /// </summary>
        public string FuJianList
        {
            set { _fujianlist = value; }
            get { return _fujianlist; }
        }
        /// <summary>
        /// 录入人：
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 更新时间：
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
        public ERPJinDu(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,ProjectName,ProjectSerils,JieDuanName,StartTime,EndTime,WanChengDu,FuZeRen,ContentStr,FuJianList,UserName,TimeStr ");
            strSql.Append(" FROM ERPJinDu ");
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
                if (ds.Tables[0].Rows[0]["StartTime"].ToString() != "")
                {
                    StartTime = DateTime.Parse(ds.Tables[0].Rows[0]["StartTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EndTime"].ToString() != "")
                {
                    EndTime = DateTime.Parse(ds.Tables[0].Rows[0]["EndTime"].ToString());
                }
                WanChengDu = ds.Tables[0].Rows[0]["WanChengDu"].ToString();
                FuZeRen = ds.Tables[0].Rows[0]["FuZeRen"].ToString();
                ContentStr = ds.Tables[0].Rows[0]["ContentStr"].ToString();
                FuJianList = ds.Tables[0].Rows[0]["FuJianList"].ToString();
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
            strSql.Append("select count(1) from ERPJinDu");
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
            strSql.Append("insert into ERPJinDu(");
            strSql.Append("ProjectName,ProjectSerils,JieDuanName,StartTime,EndTime,WanChengDu,FuZeRen,ContentStr,FuJianList,UserName,TimeStr)");
            strSql.Append(" values (");
            strSql.Append("@ProjectName,@ProjectSerils,@JieDuanName,@StartTime,@EndTime,@WanChengDu,@FuZeRen,@ContentStr,@FuJianList,@UserName,@TimeStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ProjectName", SqlDbType.VarChar,200),
					new SqlParameter("@ProjectSerils", SqlDbType.VarChar,50),
					new SqlParameter("@JieDuanName", SqlDbType.VarChar,100),
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@WanChengDu", SqlDbType.VarChar,50),
					new SqlParameter("@FuZeRen", SqlDbType.VarChar,50),
					new SqlParameter("@ContentStr", SqlDbType.Text),
					new SqlParameter("@FuJianList", SqlDbType.VarChar,1000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = ProjectName;
            parameters[1].Value = ProjectSerils;
            parameters[2].Value = JieDuanName;
            parameters[3].Value = StartTime;
            parameters[4].Value = EndTime;
            parameters[5].Value = WanChengDu;
            parameters[6].Value = FuZeRen;
            parameters[7].Value = ContentStr;
            parameters[8].Value = FuJianList;
            parameters[9].Value = UserName;
            parameters[10].Value = TimeStr;

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
            strSql.Append("update ERPJinDu set ");
            strSql.Append("ProjectName=@ProjectName,");
            strSql.Append("ProjectSerils=@ProjectSerils,");
            strSql.Append("JieDuanName=@JieDuanName,");
            strSql.Append("StartTime=@StartTime,");
            strSql.Append("EndTime=@EndTime,");
            strSql.Append("WanChengDu=@WanChengDu,");
            strSql.Append("FuZeRen=@FuZeRen,");
            strSql.Append("ContentStr=@ContentStr,");
            strSql.Append("FuJianList=@FuJianList,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TimeStr=@TimeStr");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@ProjectName", SqlDbType.VarChar,200),
					new SqlParameter("@ProjectSerils", SqlDbType.VarChar,50),
					new SqlParameter("@JieDuanName", SqlDbType.VarChar,100),
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@WanChengDu", SqlDbType.VarChar,50),
					new SqlParameter("@FuZeRen", SqlDbType.VarChar,50),
					new SqlParameter("@ContentStr", SqlDbType.Text),
					new SqlParameter("@FuJianList", SqlDbType.VarChar,1000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = ID;
            parameters[1].Value = ProjectName;
            parameters[2].Value = ProjectSerils;
            parameters[3].Value = JieDuanName;
            parameters[4].Value = StartTime;
            parameters[5].Value = EndTime;
            parameters[6].Value = WanChengDu;
            parameters[7].Value = FuZeRen;
            parameters[8].Value = ContentStr;
            parameters[9].Value = FuJianList;
            parameters[10].Value = UserName;
            parameters[11].Value = TimeStr;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPJinDu ");
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
            strSql.Append("select ID,ProjectName,ProjectSerils,JieDuanName,StartTime,EndTime,WanChengDu,FuZeRen,ContentStr,FuJianList,UserName,TimeStr ");
            strSql.Append(" FROM ERPJinDu ");
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
                if (ds.Tables[0].Rows[0]["StartTime"].ToString() != "")
                {
                    StartTime = DateTime.Parse(ds.Tables[0].Rows[0]["StartTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EndTime"].ToString() != "")
                {
                    EndTime = DateTime.Parse(ds.Tables[0].Rows[0]["EndTime"].ToString());
                }
                WanChengDu = ds.Tables[0].Rows[0]["WanChengDu"].ToString();
                FuZeRen = ds.Tables[0].Rows[0]["FuZeRen"].ToString();
                ContentStr = ds.Tables[0].Rows[0]["ContentStr"].ToString();
                FuJianList = ds.Tables[0].Rows[0]["FuJianList"].ToString();
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
            strSql.Append("select [ID],[ProjectName],[ProjectSerils],[JieDuanName],[StartTime],[EndTime],[WanChengDu],[FuZeRen],[ContentStr],[FuJianList],[UserName],[TimeStr] ");
            strSql.Append(" FROM ERPJinDu ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

