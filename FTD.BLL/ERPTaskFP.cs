using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPTaskFP。
    /// </summary>
    public class ERPTaskFP
    {
        public ERPTaskFP()
        { }
        #region Model
        private int _id;
        private string _tasktitle;
        private string _taskcontent;
        private string _fromuser;
        private string _touserlist;
        private string _xinxigoutong;
        private decimal? _jindu;
        private string _wancheng;
        private string _nowstate;
        private DateTime _kssj;
        private DateTime _jssj;
        private string _sffk;
        private DateTime _fksj;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 任务标题
        /// </summary>
        public string TaskTitle
        {
            set { _tasktitle = value; }
            get { return _tasktitle; }
        }
        /// <summary>
        /// 任务内容
        /// </summary>
        public string TaskContent
        {
            set { _taskcontent = value; }
            get { return _taskcontent; }
        }
        /// <summary>
        /// 分配人
        /// </summary>
        public string FromUser
        {
            set { _fromuser = value; }
            get { return _fromuser; }
        }
        /// <summary>
        /// 执行人
        /// </summary>
        public string ToUserList
        {
            set { _touserlist = value; }
            get { return _touserlist; }
        }
        /// <summary>
        /// 汇报与批示
        /// </summary>
        public string XinXiGouTong
        {
            set { _xinxigoutong = value; }
            get { return _xinxigoutong; }
        }
        /// <summary>
        /// 任务进度
        /// </summary>
        public decimal? JinDu
        {
            set { _jindu = value; }
            get { return _jindu; }
        }
        /// <summary>
        /// 完成情况
        /// </summary>
        public string WanCheng
        {
            set { _wancheng = value; }
            get { return _wancheng; }
        }
        /// <summary>
        /// 当前状态
        /// </summary>
        public string NowState
        {
            set { _nowstate = value; }
            get { return _nowstate; }
        }

        /// <summary>
        /// 当前状态
        /// </summary>
        public DateTime KSSJ
        {
            set { _kssj = value; }
            get { return _kssj; }
        }


        /// <summary>
        /// 当前状态
        /// </summary>
        public DateTime JSSJ
        {
            set { _jssj = value; }
            get { return _jssj; }
        }


        /// <summary>
        /// 当前状态
        /// </summary>
        public string SFFK
        {
            set { _sffk = value; }
            get { return _sffk; }
        }

        /// <summary>
        /// 当前状态
        /// </summary>
        public DateTime FKSJ
        {
            set { _fksj = value; }
            get { return _fksj; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPTaskFP(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,TaskTitle,TaskContent,FromUser,ToUserList,XinXiGouTong,JinDu,WanCheng,NowState,KSSJ,JSSJ,SFFK,FKSJ ");
            strSql.Append(" FROM ERPTaskFP ");
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
                TaskTitle = ds.Tables[0].Rows[0]["TaskTitle"].ToString();
                TaskContent = ds.Tables[0].Rows[0]["TaskContent"].ToString();
                FromUser = ds.Tables[0].Rows[0]["FromUser"].ToString();
                ToUserList = ds.Tables[0].Rows[0]["ToUserList"].ToString();
                XinXiGouTong = ds.Tables[0].Rows[0]["XinXiGouTong"].ToString();
                if (ds.Tables[0].Rows[0]["JinDu"].ToString() != "")
                {
                    JinDu = decimal.Parse(ds.Tables[0].Rows[0]["JinDu"].ToString());
                }
                WanCheng = ds.Tables[0].Rows[0]["WanCheng"].ToString();
                NowState = ds.Tables[0].Rows[0]["NowState"].ToString();
                if (ds.Tables[0].Rows[0]["KSSJ"].ToString() != "")
                {
                    KSSJ = DateTime.Parse(ds.Tables[0].Rows[0]["KSSJ"].ToString());
                }
                if (ds.Tables[0].Rows[0]["JSSJ"].ToString() != "")
                {
                    JSSJ = DateTime.Parse(ds.Tables[0].Rows[0]["JSSJ"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SFFK"].ToString() != "")
                {
                    SFFK = ds.Tables[0].Rows[0]["SFFK"].ToString();
                }
                if (ds.Tables[0].Rows[0]["FKSJ"].ToString() != "")
                {
                    FKSJ = DateTime.Parse(ds.Tables[0].Rows[0]["FKSJ"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPTaskFP");
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
            strSql.Append("insert into ERPTaskFP(");
            strSql.Append("TaskTitle,TaskContent,FromUser,ToUserList,XinXiGouTong,JinDu,WanCheng,NowState,KSSJ,JSSJ,SFFK,FKSJ)");
            strSql.Append(" values (");
            strSql.Append("@TaskTitle,@TaskContent,@FromUser,@ToUserList,@XinXiGouTong,@JinDu,@WanCheng,@NowState,@KSSJ,@JSSJ,@SFFK,@FKSJ)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@TaskTitle", SqlDbType.VarChar,500),
					new SqlParameter("@TaskContent", SqlDbType.Text),
					new SqlParameter("@FromUser", SqlDbType.VarChar,50),
					new SqlParameter("@ToUserList", SqlDbType.VarChar,8000),
					new SqlParameter("@XinXiGouTong", SqlDbType.Text),
					new SqlParameter("@JinDu", SqlDbType.Decimal,9),
					new SqlParameter("@WanCheng", SqlDbType.VarChar,8000),
					new SqlParameter("@NowState", SqlDbType.VarChar,50),new SqlParameter("@KSSJ", SqlDbType.DateTime),
                                        new SqlParameter("@JSSJ", SqlDbType.DateTime),
                                        new SqlParameter("@SFFK", SqlDbType.VarChar,50),
                                        new SqlParameter("@FKSJ", SqlDbType.DateTime)};
            parameters[0].Value = TaskTitle;
            parameters[1].Value = TaskContent;
            parameters[2].Value = FromUser;
            parameters[3].Value = ToUserList;
            parameters[4].Value = XinXiGouTong;
            parameters[5].Value = JinDu;
            parameters[6].Value = WanCheng;
            parameters[7].Value = NowState;
            parameters[8].Value = KSSJ;
            parameters[9].Value = JSSJ;
            parameters[10].Value = SFFK;
            parameters[11].Value = FKSJ;

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
            strSql.Append("update ERPTaskFP set ");
            strSql.Append("TaskTitle=@TaskTitle,");
            strSql.Append("TaskContent=@TaskContent,");
            strSql.Append("FromUser=@FromUser,");
            strSql.Append("ToUserList=@ToUserList,");
            strSql.Append("XinXiGouTong=@XinXiGouTong,");
            strSql.Append("JinDu=@JinDu,");
            strSql.Append("WanCheng=@WanCheng,");
            strSql.Append("NowState=@NowState,");
            strSql.Append("KSSJ=@KSSJ,");
            strSql.Append("JSSJ=@JSSJ,");
            strSql.Append("SFFK=@SFFK,");
            strSql.Append("FKSJ=@FKSJ ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@TaskTitle", SqlDbType.VarChar,500),
					new SqlParameter("@TaskContent", SqlDbType.Text),
					new SqlParameter("@FromUser", SqlDbType.VarChar,50),
					new SqlParameter("@ToUserList", SqlDbType.VarChar,8000),
					new SqlParameter("@XinXiGouTong", SqlDbType.Text),
					new SqlParameter("@JinDu", SqlDbType.Decimal,9),
					new SqlParameter("@WanCheng", SqlDbType.VarChar,8000),
					new SqlParameter("@NowState", SqlDbType.VarChar,50),new SqlParameter("@KSSJ", SqlDbType.DateTime),
                                        new SqlParameter("@JSSJ", SqlDbType.DateTime),
                                        new SqlParameter("@SFFK", SqlDbType.VarChar,50),
                                        new SqlParameter("@FKSJ", SqlDbType.DateTime)};
            parameters[0].Value = ID;
            parameters[1].Value = TaskTitle;
            parameters[2].Value = TaskContent;
            parameters[3].Value = FromUser;
            parameters[4].Value = ToUserList;
            parameters[5].Value = XinXiGouTong;
            parameters[6].Value = JinDu;
            parameters[7].Value = WanCheng;
            parameters[8].Value = NowState;
            parameters[9].Value = KSSJ;
            parameters[10].Value = JSSJ;
            parameters[11].Value = SFFK;
            parameters[12].Value = FKSJ;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPTaskFP ");
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
            strSql.Append("select  top 1 ID,TaskTitle,TaskContent,FromUser,ToUserList,XinXiGouTong,JinDu,WanCheng,NowState,KSSJ,JSSJ,SFFK,FKSJ ");
            strSql.Append(" FROM ERPTaskFP ");
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
                TaskTitle = ds.Tables[0].Rows[0]["TaskTitle"].ToString();
                TaskContent = ds.Tables[0].Rows[0]["TaskContent"].ToString();
                FromUser = ds.Tables[0].Rows[0]["FromUser"].ToString();
                ToUserList = ds.Tables[0].Rows[0]["ToUserList"].ToString();
                XinXiGouTong = ds.Tables[0].Rows[0]["XinXiGouTong"].ToString();
                if (ds.Tables[0].Rows[0]["JinDu"].ToString() != "")
                {
                    JinDu = decimal.Parse(ds.Tables[0].Rows[0]["JinDu"].ToString());
                }
                WanCheng = ds.Tables[0].Rows[0]["WanCheng"].ToString();
                NowState = ds.Tables[0].Rows[0]["NowState"].ToString();
                if (ds.Tables[0].Rows[0]["KSSJ"].ToString() != "")
                {
                    KSSJ = DateTime.Parse(ds.Tables[0].Rows[0]["KSSJ"].ToString());
                }
                if (ds.Tables[0].Rows[0]["JSSJ"].ToString() != "")
                {
                    JSSJ = DateTime.Parse(ds.Tables[0].Rows[0]["JSSJ"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SFFK"].ToString() != "")
                {
                    SFFK = ds.Tables[0].Rows[0]["SFFK"].ToString();
                }
                if (ds.Tables[0].Rows[0]["FKSJ"].ToString() != "")
                {
                    FKSJ = DateTime.Parse(ds.Tables[0].Rows[0]["FKSJ"].ToString());
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
            strSql.Append(" FROM ERPTaskFP ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

