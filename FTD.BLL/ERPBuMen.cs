using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPBuMen。
    /// </summary>
    public class ERPBuMen
    {
        public ERPBuMen()
        { }
        #region Model
        private int _id;
        private string _bumenname;
        private string _chargeman;
        private string _telstr;
        private string _chuanzhen;
        private string _backinfo;
        private int? _dirid;
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
        public string BuMenName
        {
            set { _bumenname = value; }
            get { return _bumenname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ChargeMan
        {
            set { _chargeman = value; }
            get { return _chargeman; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TelStr
        {
            set { _telstr = value; }
            get { return _telstr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ChuanZhen
        {
            set { _chuanzhen = value; }
            get { return _chuanzhen; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BackInfo
        {
            set { _backinfo = value; }
            get { return _backinfo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? DirID
        {
            set { _dirid = value; }
            get { return _dirid; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {

            return DbHelperSQL.GetMaxID("ID", "ERPBuMen");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPBuMen");
            strSql.Append(" where ID=" + ID + " ");

            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)				};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ERPBuMen(");
            strSql.Append("BuMenName,ChargeMan,TelStr,ChuanZhen,BackInfo,DirID)");
            strSql.Append(" values (");
            strSql.Append("@BuMenName,@ChargeMan,@TelStr,@ChuanZhen,@BackInfo,@DirID)");
            SqlParameter[] parameters = {					
					new SqlParameter("@BuMenName", SqlDbType.VarChar,50),
					new SqlParameter("@ChargeMan", SqlDbType.VarChar,50),
					new SqlParameter("@TelStr", SqlDbType.VarChar,50),
					new SqlParameter("@ChuanZhen", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,8000),
					new SqlParameter("@DirID", SqlDbType.Int,4)};            
            parameters[0].Value = BuMenName;
            parameters[1].Value = ChargeMan;
            parameters[2].Value = TelStr;
            parameters[3].Value = ChuanZhen;
            parameters[4].Value = BackInfo;
            parameters[5].Value = DirID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ERPBuMen set ");
            strSql.Append("BuMenName=@BuMenName,");
            strSql.Append("ChargeMan=@ChargeMan,");
            strSql.Append("TelStr=@TelStr,");
            strSql.Append("ChuanZhen=@ChuanZhen,");
            strSql.Append("BackInfo=@BackInfo,");
            strSql.Append("DirID=@DirID");
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@BuMenName", SqlDbType.VarChar,50),
					new SqlParameter("@ChargeMan", SqlDbType.VarChar,50),
					new SqlParameter("@TelStr", SqlDbType.VarChar,50),
					new SqlParameter("@ChuanZhen", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,8000),
					new SqlParameter("@DirID", SqlDbType.Int,4)};
            parameters[0].Value = ID;
            parameters[1].Value = BuMenName;
            parameters[2].Value = ChargeMan;
            parameters[3].Value = TelStr;
            parameters[4].Value = ChuanZhen;
            parameters[5].Value = BackInfo;
            parameters[6].Value = DirID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPBuMen ");
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
            strSql.Append("select ID,BuMenName,ChargeMan,TelStr,ChuanZhen,BackInfo,DirID ");
            strSql.Append(" FROM ERPBuMen ");
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
                BuMenName = ds.Tables[0].Rows[0]["BuMenName"].ToString();
                ChargeMan = ds.Tables[0].Rows[0]["ChargeMan"].ToString();
                TelStr = ds.Tables[0].Rows[0]["TelStr"].ToString();
                ChuanZhen = ds.Tables[0].Rows[0]["ChuanZhen"].ToString();
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
                if (ds.Tables[0].Rows[0]["DirID"].ToString() != "")
                {
                    DirID = int.Parse(ds.Tables[0].Rows[0]["DirID"].ToString());
                }
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ID],[BuMenName],[ChargeMan],[TelStr],[ChuanZhen],[BackInfo],[DirID] ");
            strSql.Append(" FROM ERPBuMen ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}