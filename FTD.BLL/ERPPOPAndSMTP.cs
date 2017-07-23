using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类POPAndSMTP。
    /// </summary>
    public class ERPPOPAndSMTP
    {
        public ERPPOPAndSMTP()
        { }
        #region Model
        private int _id;
        private string _pop3username;
        private string _pop3userpwd;
        private string _pop3server;
        private string _pop3port;
        private string _smtpusername;
        private string _smtpuserpwd;
        private string _smtpserver;
        private string _smtpfromemail;
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
        public string POP3UserName
        {
            set { _pop3username = value; }
            get { return _pop3username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string POP3UserPwd
        {
            set { _pop3userpwd = value; }
            get { return _pop3userpwd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string POP3Server
        {
            set { _pop3server = value; }
            get { return _pop3server; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string POP3Port
        {
            set { _pop3port = value; }
            get { return _pop3port; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SMTPUserName
        {
            set { _smtpusername = value; }
            get { return _smtpusername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SMTPUserPwd
        {
            set { _smtpuserpwd = value; }
            get { return _smtpuserpwd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SMTPServer
        {
            set { _smtpserver = value; }
            get { return _smtpserver; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SMTPFromEmail
        {
            set { _smtpfromemail = value; }
            get { return _smtpfromemail; }
        }
        #endregion Model


        #region  成员方法
        
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ERPUser set ");
            strSql.Append("POP3UserName=@POP3UserName,");
            strSql.Append("POP3UserPwd=@POP3UserPwd,");
            strSql.Append("POP3Server=@POP3Server,");
            strSql.Append("POP3Port=@POP3Port,");
            strSql.Append("SMTPUserName=@SMTPUserName,");
            strSql.Append("SMTPUserPwd=@SMTPUserPwd,");
            strSql.Append("SMTPServer=@SMTPServer,");
            strSql.Append("SMTPFromEmail=@SMTPFromEmail");
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@POP3UserName", SqlDbType.VarChar,50),
					new SqlParameter("@POP3UserPwd", SqlDbType.VarChar,50),
					new SqlParameter("@POP3Server", SqlDbType.VarChar,50),
					new SqlParameter("@POP3Port", SqlDbType.VarChar,50),
					new SqlParameter("@SMTPUserName", SqlDbType.VarChar,50),
					new SqlParameter("@SMTPUserPwd", SqlDbType.VarChar,50),
					new SqlParameter("@SMTPServer", SqlDbType.VarChar,50),
					new SqlParameter("@SMTPFromEmail", SqlDbType.VarChar,50)};
            parameters[0].Value = ID;
            parameters[1].Value = POP3UserName;
            parameters[2].Value = POP3UserPwd;
            parameters[3].Value = POP3Server;
            parameters[4].Value = POP3Port;
            parameters[5].Value = SMTPUserName;
            parameters[6].Value = SMTPUserPwd;
            parameters[7].Value = SMTPServer;
            parameters[8].Value = SMTPFromEmail;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,POP3UserName,POP3UserPwd,POP3Server,POP3Port,SMTPUserName,SMTPUserPwd,SMTPServer,SMTPFromEmail ");
            strSql.Append(" FROM ERPUser ");
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
                POP3UserName = ds.Tables[0].Rows[0]["POP3UserName"].ToString();
                POP3UserPwd = ds.Tables[0].Rows[0]["POP3UserPwd"].ToString();
                POP3Server = ds.Tables[0].Rows[0]["POP3Server"].ToString();
                POP3Port = ds.Tables[0].Rows[0]["POP3Port"].ToString();
                SMTPUserName = ds.Tables[0].Rows[0]["SMTPUserName"].ToString();
                SMTPUserPwd = ds.Tables[0].Rows[0]["SMTPUserPwd"].ToString();
                SMTPServer = ds.Tables[0].Rows[0]["SMTPServer"].ToString();
                SMTPFromEmail = ds.Tables[0].Rows[0]["SMTPFromEmail"].ToString();
            }
        }
        #endregion  成员方法
    }
}