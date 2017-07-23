using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPGuDingJiLu。
    /// </summary>
    public class ERPGuDingJiLu
    {
        public ERPGuDingJiLu()
        { }
        #region Model
        private int _id;
        private string _gdname;
        private string _zjtype;
        private string _zjdate;
        private string _zjjine;
        private string _username;
        private DateTime? _timestr;
        private string _backinfo;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 资产名称
        /// </summary>
        public string GDName
        {
            set { _gdname = value; }
            get { return _gdname; }
        }
        /// <summary>
        /// 折旧类别
        /// </summary>
        public string ZJType
        {
            set { _zjtype = value; }
            get { return _zjtype; }
        }
        /// <summary>
        /// 折旧日期
        /// </summary>
        public string ZJDate
        {
            set { _zjdate = value; }
            get { return _zjdate; }
        }
        /// <summary>
        /// 折旧金额
        /// </summary>
        public string ZJJinE
        {
            set { _zjjine = value; }
            get { return _zjjine; }
        }
        /// <summary>
        /// 录入人
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 录入时间
        /// </summary>
        public DateTime? TimeStr
        {
            set { _timestr = value; }
            get { return _timestr; }
        }
        /// <summary>
        /// 备注说明
        /// </summary>
        public string BackInfo
        {
            set { _backinfo = value; }
            get { return _backinfo; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPGuDingJiLu(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,GDName,ZJType,ZJDate,ZJJinE,UserName,TimeStr,BackInfo ");
            strSql.Append(" FROM ERPGuDingJiLu ");
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
                GDName = ds.Tables[0].Rows[0]["GDName"].ToString();
                ZJType = ds.Tables[0].Rows[0]["ZJType"].ToString();
                ZJDate = ds.Tables[0].Rows[0]["ZJDate"].ToString();
                ZJJinE = ds.Tables[0].Rows[0]["ZJJinE"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPGuDingJiLu");
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
            strSql.Append("insert into ERPGuDingJiLu(");
            strSql.Append("GDName,ZJType,ZJDate,ZJJinE,UserName,TimeStr,BackInfo)");
            strSql.Append(" values (");
            strSql.Append("@GDName,@ZJType,@ZJDate,@ZJJinE,@UserName,@TimeStr,@BackInfo)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@GDName", SqlDbType.VarChar,50),
					new SqlParameter("@ZJType", SqlDbType.VarChar,50),
					new SqlParameter("@ZJDate", SqlDbType.VarChar,50),
					new SqlParameter("@ZJJinE", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
            parameters[0].Value = GDName;
            parameters[1].Value = ZJType;
            parameters[2].Value = ZJDate;
            parameters[3].Value = ZJJinE;
            parameters[4].Value = UserName;
            parameters[5].Value = TimeStr;
            parameters[6].Value = BackInfo;

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
            strSql.Append("update ERPGuDingJiLu set ");
            strSql.Append("GDName=@GDName,");
            strSql.Append("ZJType=@ZJType,");
            strSql.Append("ZJDate=@ZJDate,");
            strSql.Append("ZJJinE=@ZJJinE,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TimeStr=@TimeStr,");
            strSql.Append("BackInfo=@BackInfo");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@GDName", SqlDbType.VarChar,50),
					new SqlParameter("@ZJType", SqlDbType.VarChar,50),
					new SqlParameter("@ZJDate", SqlDbType.VarChar,50),
					new SqlParameter("@ZJJinE", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
            parameters[0].Value = ID;
            parameters[1].Value = GDName;
            parameters[2].Value = ZJType;
            parameters[3].Value = ZJDate;
            parameters[4].Value = ZJJinE;
            parameters[5].Value = UserName;
            parameters[6].Value = TimeStr;
            parameters[7].Value = BackInfo;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPGuDingJiLu ");
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
            strSql.Append("select  top 1 ID,GDName,ZJType,ZJDate,ZJJinE,UserName,TimeStr,BackInfo ");
            strSql.Append(" FROM ERPGuDingJiLu ");
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
                GDName = ds.Tables[0].Rows[0]["GDName"].ToString();
                ZJType = ds.Tables[0].Rows[0]["ZJType"].ToString();
                ZJDate = ds.Tables[0].Rows[0]["ZJDate"].ToString();
                ZJJinE = ds.Tables[0].Rows[0]["ZJJinE"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ERPGuDingJiLu ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

