using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPYinZhangLog。
    /// </summary>
    public class ERPYinZhangLog
    {
        public ERPYinZhangLog()
        { }
        #region Model
        private int _id;
        private string _username;
        private DateTime? _timestr;
        private string _dosomething;
        private string _ipstr;
        private string _typestr;
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
        /// <summary>
        /// 
        /// </summary>
        public string DoSomething
        {
            set { _dosomething = value; }
            get { return _dosomething; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IpStr
        {
            set { _ipstr = value; }
            get { return _ipstr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TypeStr
        {
            set { _typestr = value; }
            get { return _typestr; }
        }
        #endregion Model


        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPYinZhangLog");
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
            strSql.Append("insert into ERPYinZhangLog(");
            strSql.Append("UserName,TimeStr,DoSomething,IpStr,TypeStr)");
            strSql.Append(" values (");
            strSql.Append("@UserName,@TimeStr,@DoSomething,@IpStr,@TypeStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@DoSomething", SqlDbType.VarChar,1000),
					new SqlParameter("@IpStr", SqlDbType.VarChar,50),
					new SqlParameter("@TypeStr", SqlDbType.VarChar,50)};
            parameters[0].Value = UserName;
            parameters[1].Value = TimeStr;
            parameters[2].Value = DoSomething;
            parameters[3].Value = IpStr;
            parameters[4].Value = TypeStr;

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
            strSql.Append("update ERPYinZhangLog set ");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TimeStr=@TimeStr,");
            strSql.Append("DoSomething=@DoSomething,");
            strSql.Append("IpStr=@IpStr,");
            strSql.Append("TypeStr=@TypeStr");
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@DoSomething", SqlDbType.VarChar,1000),
					new SqlParameter("@IpStr", SqlDbType.VarChar,50),
					new SqlParameter("@TypeStr", SqlDbType.VarChar,50)};
            parameters[0].Value = ID;
            parameters[1].Value = UserName;
            parameters[2].Value = TimeStr;
            parameters[3].Value = DoSomething;
            parameters[4].Value = IpStr;
            parameters[5].Value = TypeStr;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPYinZhangLog ");
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
            strSql.Append("select ID,UserName,TimeStr,DoSomething,IpStr,TypeStr ");
            strSql.Append(" FROM ERPYinZhangLog ");
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
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                DoSomething = ds.Tables[0].Rows[0]["DoSomething"].ToString();
                IpStr = ds.Tables[0].Rows[0]["IpStr"].ToString();
                TypeStr = ds.Tables[0].Rows[0]["TypeStr"].ToString();
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ID],[UserName],[TimeStr],[DoSomething],[IpStr],[TypeStr] ");
            strSql.Append(" FROM ERPYinZhangLog ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}