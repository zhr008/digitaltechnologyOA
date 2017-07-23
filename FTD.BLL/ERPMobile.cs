using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPMobile。
    /// </summary>
    public class ERPMobile
    {
        public ERPMobile()
        { }
        #region Model
        private int _id;
        private string _fasonguser;
        private string _touserlist;
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
        public string FaSongUser
        {
            set { _fasonguser = value; }
            get { return _fasonguser; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ToUserList
        {
            set { _touserlist = value; }
            get { return _touserlist; }
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
            strSql.Append("select count(1) from ERPMobile");
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
            strSql.Append("insert into ERPMobile(");
            strSql.Append("FaSongUser,ToUserList,ContentStr)");
            strSql.Append(" values (");
            strSql.Append("@FaSongUser,@ToUserList,@ContentStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@FaSongUser", SqlDbType.VarChar,50),
					new SqlParameter("@ToUserList", SqlDbType.VarChar,8000),
					new SqlParameter("@ContentStr", SqlDbType.VarChar,8000)};
            parameters[0].Value = FaSongUser;
            parameters[1].Value = ToUserList;
            parameters[2].Value = ContentStr;

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
            strSql.Append("update ERPMobile set ");
            strSql.Append("FaSongUser=@FaSongUser,");
            strSql.Append("ToUserList=@ToUserList,");
            strSql.Append("ContentStr=@ContentStr");
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@FaSongUser", SqlDbType.VarChar,50),
					new SqlParameter("@ToUserList", SqlDbType.VarChar,8000),
					new SqlParameter("@ContentStr", SqlDbType.VarChar,8000)};
            parameters[0].Value = ID;
            parameters[1].Value = FaSongUser;
            parameters[2].Value = ToUserList;
            parameters[3].Value = ContentStr;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPMobile ");
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
            strSql.Append("select ID,FaSongUser,ToUserList,ContentStr ");
            strSql.Append(" FROM ERPMobile ");
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
                FaSongUser = ds.Tables[0].Rows[0]["FaSongUser"].ToString();
                ToUserList = ds.Tables[0].Rows[0]["ToUserList"].ToString();
                ContentStr = ds.Tables[0].Rows[0]["ContentStr"].ToString();
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ID],[FaSongUser],[ToUserList],[ContentStr],[TimeStr] ");
            strSql.Append(" FROM ERPMobile ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}