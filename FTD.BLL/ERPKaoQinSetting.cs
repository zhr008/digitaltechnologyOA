using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPKaoQinSetting。
    /// </summary>
    public class ERPKaoQinSetting
    {
        public ERPKaoQinSetting()
        { }
        #region Model
        private int _id;
        private string _guidingtime1;
        private string _guidingtime2;
        private string _guidingtime3;
        private string _guidingtime4;
        private string _guidingtime5;
        private string _guidingtime6;
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
        public string GuiDingTime1
        {
            set { _guidingtime1 = value; }
            get { return _guidingtime1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GuiDingTime2
        {
            set { _guidingtime2 = value; }
            get { return _guidingtime2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GuiDingTime3
        {
            set { _guidingtime3 = value; }
            get { return _guidingtime3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GuiDingTime4
        {
            set { _guidingtime4 = value; }
            get { return _guidingtime4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GuiDingTime5
        {
            set { _guidingtime5 = value; }
            get { return _guidingtime5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GuiDingTime6
        {
            set { _guidingtime6 = value; }
            get { return _guidingtime6; }
        }
        #endregion Model


        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPKaoQinSetting");
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
            strSql.Append("insert into ERPKaoQinSetting(");
            strSql.Append("GuiDingTime1,GuiDingTime2,GuiDingTime3,GuiDingTime4,GuiDingTime5,GuiDingTime6)");
            strSql.Append(" values (");
            strSql.Append("@GuiDingTime1,@GuiDingTime2,@GuiDingTime3,@GuiDingTime4,@GuiDingTime5,@GuiDingTime6)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@GuiDingTime1", SqlDbType.VarChar,50),
					new SqlParameter("@GuiDingTime2", SqlDbType.VarChar,50),
					new SqlParameter("@GuiDingTime3", SqlDbType.VarChar,50),
					new SqlParameter("@GuiDingTime4", SqlDbType.VarChar,50),
					new SqlParameter("@GuiDingTime5", SqlDbType.VarChar,50),
					new SqlParameter("@GuiDingTime6", SqlDbType.VarChar,50)};
            parameters[0].Value = GuiDingTime1;
            parameters[1].Value = GuiDingTime2;
            parameters[2].Value = GuiDingTime3;
            parameters[3].Value = GuiDingTime4;
            parameters[4].Value = GuiDingTime5;
            parameters[5].Value = GuiDingTime6;

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
            strSql.Append("update ERPKaoQinSetting set ");
            strSql.Append("GuiDingTime1=@GuiDingTime1,");
            strSql.Append("GuiDingTime2=@GuiDingTime2,");
            strSql.Append("GuiDingTime3=@GuiDingTime3,");
            strSql.Append("GuiDingTime4=@GuiDingTime4,");
            strSql.Append("GuiDingTime5=@GuiDingTime5,");
            strSql.Append("GuiDingTime6=@GuiDingTime6");
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@GuiDingTime1", SqlDbType.VarChar,50),
					new SqlParameter("@GuiDingTime2", SqlDbType.VarChar,50),
					new SqlParameter("@GuiDingTime3", SqlDbType.VarChar,50),
					new SqlParameter("@GuiDingTime4", SqlDbType.VarChar,50),
					new SqlParameter("@GuiDingTime5", SqlDbType.VarChar,50),
					new SqlParameter("@GuiDingTime6", SqlDbType.VarChar,50)};
            parameters[0].Value = ID;
            parameters[1].Value = GuiDingTime1;
            parameters[2].Value = GuiDingTime2;
            parameters[3].Value = GuiDingTime3;
            parameters[4].Value = GuiDingTime4;
            parameters[5].Value = GuiDingTime5;
            parameters[6].Value = GuiDingTime6;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPKaoQinSetting ");
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
            strSql.Append("select ID,GuiDingTime1,GuiDingTime2,GuiDingTime3,GuiDingTime4,GuiDingTime5,GuiDingTime6 ");
            strSql.Append(" FROM ERPKaoQinSetting ");
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
                GuiDingTime1 = ds.Tables[0].Rows[0]["GuiDingTime1"].ToString();
                GuiDingTime2 = ds.Tables[0].Rows[0]["GuiDingTime2"].ToString();
                GuiDingTime3 = ds.Tables[0].Rows[0]["GuiDingTime3"].ToString();
                GuiDingTime4 = ds.Tables[0].Rows[0]["GuiDingTime4"].ToString();
                GuiDingTime5 = ds.Tables[0].Rows[0]["GuiDingTime5"].ToString();
                GuiDingTime6 = ds.Tables[0].Rows[0]["GuiDingTime6"].ToString();
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ID],[GuiDingTime1],[GuiDingTime2],[GuiDingTime3],[GuiDingTime4],[GuiDingTime5],[GuiDingTime6] ");
            strSql.Append(" FROM ERPKaoQinSetting ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}