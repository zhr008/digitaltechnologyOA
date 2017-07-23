using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPTalkInfo。
    /// </summary>
    public class ERPTalkInfo
    {
        public ERPTalkInfo()
        { }
        #region Model
        private int _id;
        private string _talkroomname;
        private string _username;
        private string _touser;
        private DateTime? _timestr;
        private string _contentstr;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 聊天室名称
        /// </summary>
        public string TalkRoomName
        {
            set { _talkroomname = value; }
            get { return _talkroomname; }
        }
        /// <summary>
        /// 发信息人
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 收信息人
        /// </summary>
        public string ToUser
        {
            set { _touser = value; }
            get { return _touser; }
        }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime? TimeStr
        {
            set { _timestr = value; }
            get { return _timestr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ContentStr
        {
            set { _contentstr = value; }
            get { return _contentstr; }
        }
        #endregion Model


        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPTalkInfo");
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
            strSql.Append("insert into ERPTalkInfo(");
            strSql.Append("TalkRoomName,UserName,ToUser,TimeStr,ContentStr)");
            strSql.Append(" values (");
            strSql.Append("@TalkRoomName,@UserName,@ToUser,@TimeStr,@ContentStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@TalkRoomName", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@ToUser", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@ContentStr", SqlDbType.VarChar,8000)};
            parameters[0].Value = TalkRoomName;
            parameters[1].Value = UserName;
            parameters[2].Value = ToUser;
            parameters[3].Value = TimeStr;
            parameters[4].Value = ContentStr;

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
            strSql.Append("update ERPTalkInfo set ");
            strSql.Append("TalkRoomName=@TalkRoomName,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("ToUser=@ToUser,");
            strSql.Append("TimeStr=@TimeStr,");
            strSql.Append("ContentStr=@ContentStr");
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@TalkRoomName", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@ToUser", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@ContentStr", SqlDbType.VarChar,8000)};
            parameters[0].Value = ID;
            parameters[1].Value = TalkRoomName;
            parameters[2].Value = UserName;
            parameters[3].Value = ToUser;
            parameters[4].Value = TimeStr;
            parameters[5].Value = ContentStr;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPTalkInfo ");
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
            strSql.Append("select ID,TalkRoomName,UserName,ToUser,TimeStr,ContentStr ");
            strSql.Append(" FROM ERPTalkInfo ");
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
                TalkRoomName = ds.Tables[0].Rows[0]["TalkRoomName"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                ToUser = ds.Tables[0].Rows[0]["ToUser"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                ContentStr = ds.Tables[0].Rows[0]["ContentStr"].ToString();
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ID],[TalkRoomName],[UserName],[ToUser],[TimeStr],[ContentStr] ");
            strSql.Append(" FROM ERPTalkInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

