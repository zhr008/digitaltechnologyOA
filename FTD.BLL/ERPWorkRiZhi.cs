using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPWorkRiZhi。
    /// </summary>
    public class ERPWorkRiZhi
    {
        public ERPWorkRiZhi()
        { }
        #region Model
        private int _id;
        private string _username;
        private string _titlestr;
        private DateTime? _timestr;
        private string _typestr;
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
        public string TypeStr
        {
            set { _typestr = value; }
            get { return _typestr; }
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
            strSql.Append("select count(1) from ERPWorkRiZhi");
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
            strSql.Append("insert into ERPWorkRiZhi(");
            strSql.Append("UserName,TitleStr,TimeStr,TypeStr,ContentStr)");
            strSql.Append(" values (");
            strSql.Append("@UserName,@TitleStr,@TimeStr,@TypeStr,@ContentStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TitleStr", SqlDbType.VarChar,1000),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@TypeStr", SqlDbType.VarChar,50),
					new SqlParameter("@ContentStr", SqlDbType.Text)};
            parameters[0].Value = UserName;
            parameters[1].Value = TitleStr;
            parameters[2].Value = TimeStr;
            parameters[3].Value = TypeStr;
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
            strSql.Append("update ERPWorkRiZhi set ");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TitleStr=@TitleStr,");            
            strSql.Append("TypeStr=@TypeStr,");
            strSql.Append("ContentStr=@ContentStr");
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TitleStr", SqlDbType.VarChar,1000),					
					new SqlParameter("@TypeStr", SqlDbType.VarChar,50),
					new SqlParameter("@ContentStr", SqlDbType.Text)};
            parameters[0].Value = ID;
            parameters[1].Value = UserName;
            parameters[2].Value = TitleStr;            
            parameters[3].Value = TypeStr;
            parameters[4].Value = ContentStr;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPWorkRiZhi ");
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
            strSql.Append("select ID,UserName,TitleStr,TimeStr,TypeStr,ContentStr ");
            strSql.Append(" FROM ERPWorkRiZhi ");
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
                TitleStr = ds.Tables[0].Rows[0]["TitleStr"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                TypeStr = ds.Tables[0].Rows[0]["TypeStr"].ToString();
                ContentStr = ds.Tables[0].Rows[0]["ContentStr"].ToString();
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ID],[UserName],[TitleStr],[TimeStr],[TypeStr],[ContentStr] ");
            strSql.Append(" FROM ERPWorkRiZhi ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}