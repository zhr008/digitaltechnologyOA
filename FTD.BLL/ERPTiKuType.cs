using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPTiKuType。
    /// </summary>
    public class ERPTiKuType
    {
        public ERPTiKuType()
        { }
        #region Model
        private int _id;
        private string _tikuname;
        private string _paixu;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 题库名称
        /// </summary>
        public string TiKuName
        {
            set { _tikuname = value; }
            get { return _tikuname; }
        }
        /// <summary>
        /// 排序字符
        /// </summary>
        public string PaiXu
        {
            set { _paixu = value; }
            get { return _paixu; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPTiKuType(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,TiKuName,PaiXu ");
            strSql.Append(" FROM ERPTiKuType ");
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
                TiKuName = ds.Tables[0].Rows[0]["TiKuName"].ToString();
                PaiXu = ds.Tables[0].Rows[0]["PaiXu"].ToString();
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPTiKuType");
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
            strSql.Append("insert into ERPTiKuType(");
            strSql.Append("TiKuName,PaiXu)");
            strSql.Append(" values (");
            strSql.Append("@TiKuName,@PaiXu)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@TiKuName", SqlDbType.VarChar,500),
					new SqlParameter("@PaiXu", SqlDbType.VarChar,50)};
            parameters[0].Value = TiKuName;
            parameters[1].Value = PaiXu;

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
            strSql.Append("update ERPTiKuType set ");
            strSql.Append("TiKuName=@TiKuName,");
            strSql.Append("PaiXu=@PaiXu");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@TiKuName", SqlDbType.VarChar,500),
					new SqlParameter("@PaiXu", SqlDbType.VarChar,50)};
            parameters[0].Value = ID;
            parameters[1].Value = TiKuName;
            parameters[2].Value = PaiXu;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPTiKuType ");
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
            strSql.Append("select  top 1 ID,TiKuName,PaiXu ");
            strSql.Append(" FROM ERPTiKuType ");
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
                TiKuName = ds.Tables[0].Rows[0]["TiKuName"].ToString();
                PaiXu = ds.Tables[0].Rows[0]["PaiXu"].ToString();
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ERPTiKuType ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

