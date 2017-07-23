using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPTiKuKaoShiJieGuo。
    /// </summary>
    public class ERPTiKuKaoShiJieGuo
    {
        public ERPTiKuKaoShiJieGuo()
        { }
        #region Model
        private int _id;
        private int? _kaoshiid;
        private int? _timuid;
        private string _daan;
        private string _userdaan;
        private decimal? _defen;
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
        public int? KaoShiID
        {
            set { _kaoshiid = value; }
            get { return _kaoshiid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? TiMuID
        {
            set { _timuid = value; }
            get { return _timuid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DaAn
        {
            set { _daan = value; }
            get { return _daan; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserDaAn
        {
            set { _userdaan = value; }
            get { return _userdaan; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? DeFen
        {
            set { _defen = value; }
            get { return _defen; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPTiKuKaoShiJieGuo(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,KaoShiID,TiMuID,DaAn,UserDaAn,DeFen ");
            strSql.Append(" FROM ERPTiKuKaoShiJieGuo ");
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
                if (ds.Tables[0].Rows[0]["KaoShiID"].ToString() != "")
                {
                    KaoShiID = int.Parse(ds.Tables[0].Rows[0]["KaoShiID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TiMuID"].ToString() != "")
                {
                    TiMuID = int.Parse(ds.Tables[0].Rows[0]["TiMuID"].ToString());
                }
                DaAn = ds.Tables[0].Rows[0]["DaAn"].ToString();
                UserDaAn = ds.Tables[0].Rows[0]["UserDaAn"].ToString();
                if (ds.Tables[0].Rows[0]["DeFen"].ToString() != "")
                {
                    DeFen = decimal.Parse(ds.Tables[0].Rows[0]["DeFen"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPTiKuKaoShiJieGuo");
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
            strSql.Append("insert into ERPTiKuKaoShiJieGuo(");
            strSql.Append("KaoShiID,TiMuID,DaAn,UserDaAn,DeFen)");
            strSql.Append(" values (");
            strSql.Append("@KaoShiID,@TiMuID,@DaAn,@UserDaAn,@DeFen)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@KaoShiID", SqlDbType.Int,4),
					new SqlParameter("@TiMuID", SqlDbType.Int,4),
					new SqlParameter("@DaAn", SqlDbType.VarChar,8000),
					new SqlParameter("@UserDaAn", SqlDbType.VarChar,8000),
					new SqlParameter("@DeFen", SqlDbType.Decimal,9)};
            parameters[0].Value = KaoShiID;
            parameters[1].Value = TiMuID;
            parameters[2].Value = DaAn;
            parameters[3].Value = UserDaAn;
            parameters[4].Value = DeFen;

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
            strSql.Append("update ERPTiKuKaoShiJieGuo set ");
            strSql.Append("KaoShiID=@KaoShiID,");
            strSql.Append("TiMuID=@TiMuID,");
            strSql.Append("DaAn=@DaAn,");
            strSql.Append("UserDaAn=@UserDaAn,");
            strSql.Append("DeFen=@DeFen");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@KaoShiID", SqlDbType.Int,4),
					new SqlParameter("@TiMuID", SqlDbType.Int,4),
					new SqlParameter("@DaAn", SqlDbType.VarChar,8000),
					new SqlParameter("@UserDaAn", SqlDbType.VarChar,8000),
					new SqlParameter("@DeFen", SqlDbType.Decimal,9)};
            parameters[0].Value = ID;
            parameters[1].Value = KaoShiID;
            parameters[2].Value = TiMuID;
            parameters[3].Value = DaAn;
            parameters[4].Value = UserDaAn;
            parameters[5].Value = DeFen;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPTiKuKaoShiJieGuo ");
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
            strSql.Append("select  top 1 ID,KaoShiID,TiMuID,DaAn,UserDaAn,DeFen ");
            strSql.Append(" FROM ERPTiKuKaoShiJieGuo ");
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
                if (ds.Tables[0].Rows[0]["KaoShiID"].ToString() != "")
                {
                    KaoShiID = int.Parse(ds.Tables[0].Rows[0]["KaoShiID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TiMuID"].ToString() != "")
                {
                    TiMuID = int.Parse(ds.Tables[0].Rows[0]["TiMuID"].ToString());
                }
                DaAn = ds.Tables[0].Rows[0]["DaAn"].ToString();
                UserDaAn = ds.Tables[0].Rows[0]["UserDaAn"].ToString();
                if (ds.Tables[0].Rows[0]["DeFen"].ToString() != "")
                {
                    DeFen = decimal.Parse(ds.Tables[0].Rows[0]["DeFen"].ToString());
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
            strSql.Append(" FROM ERPTiKuKaoShiJieGuo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

