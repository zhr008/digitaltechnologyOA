using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPBaoXiao。
    /// </summary>
    public class ERPBaoXiao
    {
        public ERPBaoXiao()
        { }
        #region Model
        private int _id;
        private string _projectname;
        private string _feiyongtype;
        private string _shenqingren;
        private string _shenpiren;
        private string _shenqingcontent;
        private string _jine;
        private string _statenow;
        private string _username;
        private DateTime? _shenqingtime;
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
        /// 费用类别：
        /// </summary>
        public string FeiYongType
        {
            set { _feiyongtype = value; }
            get { return _feiyongtype; }
        }
        /// <summary>
        /// 申请人：
        /// </summary>
        public string ShenQingRen
        {
            set { _shenqingren = value; }
            get { return _shenqingren; }
        }
        /// <summary>
        /// 审批人：
        /// </summary>
        public string ShenPiRen
        {
            set { _shenpiren = value; }
            get { return _shenpiren; }
        }
        /// <summary>
        /// 申请内容：
        /// </summary>
        public string ShenQingContent
        {
            set { _shenqingcontent = value; }
            get { return _shenqingcontent; }
        }
        /// <summary>
        /// 报销金额：
        /// </summary>
        public string JinE
        {
            set { _jine = value; }
            get { return _jine; }
        }
        /// <summary>
        /// 当前状态：
        /// </summary>
        public string StateNow
        {
            set { _statenow = value; }
            get { return _statenow; }
        }
        /// <summary>
        /// 录入人：
        /// </summary>
        public string Username
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ShenQingTime
        {
            set { _shenqingtime = value; }
            get { return _shenqingtime; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPBaoXiao(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,ProjectName,FeiYongType,ShenQingRen,ShenPiRen,ShenQingContent,JinE,StateNow,Username,ShenQingTime ");
            strSql.Append(" FROM ERPBaoXiao ");
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
                FeiYongType = ds.Tables[0].Rows[0]["FeiYongType"].ToString();
                ShenQingRen = ds.Tables[0].Rows[0]["ShenQingRen"].ToString();
                ShenPiRen = ds.Tables[0].Rows[0]["ShenPiRen"].ToString();
                ShenQingContent = ds.Tables[0].Rows[0]["ShenQingContent"].ToString();
                JinE = ds.Tables[0].Rows[0]["JinE"].ToString();
                StateNow = ds.Tables[0].Rows[0]["StateNow"].ToString();
                Username = ds.Tables[0].Rows[0]["Username"].ToString();
                if (ds.Tables[0].Rows[0]["ShenQingTime"].ToString() != "")
                {
                    ShenQingTime = DateTime.Parse(ds.Tables[0].Rows[0]["ShenQingTime"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPBaoXiao");
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
            strSql.Append("insert into ERPBaoXiao(");
            strSql.Append("ProjectName,FeiYongType,ShenQingRen,ShenPiRen,ShenQingContent,JinE,StateNow,Username,ShenQingTime)");
            strSql.Append(" values (");
            strSql.Append("@ProjectName,@FeiYongType,@ShenQingRen,@ShenPiRen,@ShenQingContent,@JinE,@StateNow,@Username,@ShenQingTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ProjectName", SqlDbType.VarChar,200),
					new SqlParameter("@FeiYongType", SqlDbType.VarChar,50),
					new SqlParameter("@ShenQingRen", SqlDbType.VarChar,50),
					new SqlParameter("@ShenPiRen", SqlDbType.VarChar,50),
					new SqlParameter("@ShenQingContent", SqlDbType.VarChar,5000),
					new SqlParameter("@JinE", SqlDbType.VarChar,50),
					new SqlParameter("@StateNow", SqlDbType.VarChar,50),
					new SqlParameter("@Username", SqlDbType.VarChar,50),
					new SqlParameter("@ShenQingTime", SqlDbType.DateTime)};
            parameters[0].Value = ProjectName;
            parameters[1].Value = FeiYongType;
            parameters[2].Value = ShenQingRen;
            parameters[3].Value = ShenPiRen;
            parameters[4].Value = ShenQingContent;
            parameters[5].Value = JinE;
            parameters[6].Value = StateNow;
            parameters[7].Value = Username;
            parameters[8].Value = ShenQingTime;

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
            strSql.Append("update ERPBaoXiao set ");
            strSql.Append("ProjectName=@ProjectName,");
            strSql.Append("FeiYongType=@FeiYongType,");
            strSql.Append("ShenQingRen=@ShenQingRen,");
            strSql.Append("ShenPiRen=@ShenPiRen,");
            strSql.Append("ShenQingContent=@ShenQingContent,");
            strSql.Append("JinE=@JinE,");
            strSql.Append("StateNow=@StateNow,");
            strSql.Append("Username=@Username,");
            strSql.Append("ShenQingTime=@ShenQingTime");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@ProjectName", SqlDbType.VarChar,200),
					new SqlParameter("@FeiYongType", SqlDbType.VarChar,50),
					new SqlParameter("@ShenQingRen", SqlDbType.VarChar,50),
					new SqlParameter("@ShenPiRen", SqlDbType.VarChar,50),
					new SqlParameter("@ShenQingContent", SqlDbType.VarChar,5000),
					new SqlParameter("@JinE", SqlDbType.VarChar,50),
					new SqlParameter("@StateNow", SqlDbType.VarChar,50),
					new SqlParameter("@Username", SqlDbType.VarChar,50),
					new SqlParameter("@ShenQingTime", SqlDbType.DateTime)};
            parameters[0].Value = ID;
            parameters[1].Value = ProjectName;
            parameters[2].Value = FeiYongType;
            parameters[3].Value = ShenQingRen;
            parameters[4].Value = ShenPiRen;
            parameters[5].Value = ShenQingContent;
            parameters[6].Value = JinE;
            parameters[7].Value = StateNow;
            parameters[8].Value = Username;
            parameters[9].Value = ShenQingTime;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPBaoXiao ");
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
            strSql.Append("select ID,ProjectName,FeiYongType,ShenQingRen,ShenPiRen,ShenQingContent,JinE,StateNow,Username,ShenQingTime ");
            strSql.Append(" FROM ERPBaoXiao ");
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
                FeiYongType = ds.Tables[0].Rows[0]["FeiYongType"].ToString();
                ShenQingRen = ds.Tables[0].Rows[0]["ShenQingRen"].ToString();
                ShenPiRen = ds.Tables[0].Rows[0]["ShenPiRen"].ToString();
                ShenQingContent = ds.Tables[0].Rows[0]["ShenQingContent"].ToString();
                JinE = ds.Tables[0].Rows[0]["JinE"].ToString();
                StateNow = ds.Tables[0].Rows[0]["StateNow"].ToString();
                Username = ds.Tables[0].Rows[0]["Username"].ToString();
                if (ds.Tables[0].Rows[0]["ShenQingTime"].ToString() != "")
                {
                    ShenQingTime = DateTime.Parse(ds.Tables[0].Rows[0]["ShenQingTime"].ToString());
                }
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ID],[ProjectName],[FeiYongType],[ShenQingRen],[ShenPiRen],[ShenQingContent],[JinE],[StateNow],[Username],[ShenQingTime] ");
            strSql.Append(" FROM ERPBaoXiao ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

