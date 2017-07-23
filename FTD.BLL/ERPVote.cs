using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPVote。
    /// </summary>
    public class ERPVote
    {
        public ERPVote()
        { }
        #region Model
        private int _id;
        private string _titlestr;
        private DateTime? _timestr;
        private string _username;
        private string _contentstr;
        private string _scorestr;
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
        public string TitleStr
        {
            set { _titlestr = value; }
            get { return _titlestr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? TimeStr
        {
            set { _timestr = value; }
            get { return _timestr; }
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
        public string ContentStr
        {
            set { _contentstr = value; }
            get { return _contentstr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ScoreStr
        {
            set { _scorestr = value; }
            get { return _scorestr; }
        }
        #endregion Model


        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPVote");
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
            strSql.Append("insert into ERPVote(");
            strSql.Append("TitleStr,TimeStr,UserName,ContentStr,ScoreStr)");
            strSql.Append(" values (");
            strSql.Append("@TitleStr,@TimeStr,@UserName,@ContentStr,@ScoreStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@TitleStr", SqlDbType.VarChar,500),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@ContentStr", SqlDbType.VarChar,8000),
					new SqlParameter("@ScoreStr", SqlDbType.VarChar,800)};
            parameters[0].Value = TitleStr;
            parameters[1].Value = TimeStr;
            parameters[2].Value = UserName;
            parameters[3].Value = ContentStr;
            parameters[4].Value = ScoreStr;

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
            strSql.Append("update ERPVote set ");
            strSql.Append("TitleStr=@TitleStr,");            
            strSql.Append("ContentStr=@ContentStr,");
            strSql.Append("ScoreStr=@ScoreStr");
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@TitleStr", SqlDbType.VarChar,500),
					new SqlParameter("@ContentStr", SqlDbType.VarChar,8000),
					new SqlParameter("@ScoreStr", SqlDbType.VarChar,800)};
            parameters[0].Value = ID;
            parameters[1].Value = TitleStr;
            parameters[2].Value = ContentStr;
            parameters[3].Value = ScoreStr;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPVote ");
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
            strSql.Append("select ID,TitleStr,TimeStr,UserName,ContentStr,ScoreStr ");
            strSql.Append(" FROM ERPVote ");
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
                TitleStr = ds.Tables[0].Rows[0]["TitleStr"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                ContentStr = ds.Tables[0].Rows[0]["ContentStr"].ToString();
                ScoreStr = ds.Tables[0].Rows[0]["ScoreStr"].ToString();
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ID],[TitleStr],[TimeStr],[UserName],[ContentStr],[ScoreStr] ");
            strSql.Append(" FROM ERPVote ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}