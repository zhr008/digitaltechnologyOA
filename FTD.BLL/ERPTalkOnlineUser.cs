using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPTalkOnlineUser。
    /// </summary>
    public class ERPTalkOnlineUser
    {
        public ERPTalkOnlineUser()
        { }
        #region Model
        private int _id;
        private string _talkroomname;
        private string _loginuser;
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
        /// 聊天室名称
        /// </summary>
        public string TalkRoomName
        {
            set { _talkroomname = value; }
            get { return _talkroomname; }
        }
        /// <summary>
        /// 登陆进入的用户名
        /// </summary>
        public string LoginUser
        {
            set { _loginuser = value; }
            get { return _loginuser; }
        }
        /// <summary>
        /// 最后刷新时间
        /// </summary>
        public DateTime? TimeStr
        {
            set { _timestr = value; }
            get { return _timestr; }
        }
        #endregion Model


        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPTalkOnlineUser");
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
            strSql.Append("insert into ERPTalkOnlineUser(");
            strSql.Append("TalkRoomName,LoginUser,TimeStr)");
            strSql.Append(" values (");
            strSql.Append("@TalkRoomName,@LoginUser,@TimeStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@TalkRoomName", SqlDbType.VarChar,500),
					new SqlParameter("@LoginUser", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = TalkRoomName;
            parameters[1].Value = LoginUser;
            parameters[2].Value = TimeStr;

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
            strSql.Append("update ERPTalkOnlineUser set ");
            strSql.Append("TalkRoomName=@TalkRoomName,");
            strSql.Append("LoginUser=@LoginUser,");
            strSql.Append("TimeStr=@TimeStr");
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@TalkRoomName", SqlDbType.VarChar,500),
					new SqlParameter("@LoginUser", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = ID;
            parameters[1].Value = TalkRoomName;
            parameters[2].Value = LoginUser;
            parameters[3].Value = TimeStr;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPTalkOnlineUser ");
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
            strSql.Append("select ID,TalkRoomName,LoginUser,TimeStr ");
            strSql.Append(" FROM ERPTalkOnlineUser ");
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
                LoginUser = ds.Tables[0].Rows[0]["LoginUser"].ToString();
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
            strSql.Append("select [ID],[TalkRoomName],[LoginUser],[TimeStr] ");
            strSql.Append(" FROM ERPTalkOnlineUser ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

