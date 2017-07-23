using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPKaoQin。
    /// </summary>
    public class ERPKaoQin
    {
        public ERPKaoQin()
        { }
        #region Model
        private int _id;
        private string _username;
        private DateTime? _guidingtime1;
        private DateTime? _dengjitime1;
        private DateTime? _guidingtime2;
        private DateTime? _dengjitime2;
        private DateTime? _guidingtime3;
        private DateTime? _dengjitime3;
        private DateTime? _guidingtime4;
        private DateTime? _dengjitime4;
        private DateTime? _guidingtime5;
        private DateTime? _dengjitime5;
        private DateTime? _guidingtime6;
        private DateTime? _dengjitime6;
        private DateTime? _kaoqinriqi;
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
        public DateTime? GuiDingTime1
        {
            set { _guidingtime1 = value; }
            get { return _guidingtime1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? DengJiTime1
        {
            set { _dengjitime1 = value; }
            get { return _dengjitime1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? GuiDingTime2
        {
            set { _guidingtime2 = value; }
            get { return _guidingtime2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? DengJiTime2
        {
            set { _dengjitime2 = value; }
            get { return _dengjitime2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? GuiDingTime3
        {
            set { _guidingtime3 = value; }
            get { return _guidingtime3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? DengJiTime3
        {
            set { _dengjitime3 = value; }
            get { return _dengjitime3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? GuiDingTime4
        {
            set { _guidingtime4 = value; }
            get { return _guidingtime4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? DengJiTime4
        {
            set { _dengjitime4 = value; }
            get { return _dengjitime4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? GuiDingTime5
        {
            set { _guidingtime5 = value; }
            get { return _guidingtime5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? DengJiTime5
        {
            set { _dengjitime5 = value; }
            get { return _dengjitime5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? GuiDingTime6
        {
            set { _guidingtime6 = value; }
            get { return _guidingtime6; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? DengJiTime6
        {
            set { _dengjitime6 = value; }
            get { return _dengjitime6; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? KaoQinRiQi
        {
            set { _kaoqinriqi = value; }
            get { return _kaoqinriqi; }
        }
        #endregion Model


        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPKaoQin");
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
            strSql.Append("insert into ERPKaoQin(");
            strSql.Append("UserName,GuiDingTime1,DengJiTime1,GuiDingTime2,DengJiTime2,GuiDingTime3,DengJiTime3,GuiDingTime4,DengJiTime4,GuiDingTime5,DengJiTime5,GuiDingTime6,DengJiTime6,KaoQinRiQi)");
            strSql.Append(" values (");
            strSql.Append("@UserName,@GuiDingTime1,@DengJiTime1,@GuiDingTime2,@DengJiTime2,@GuiDingTime3,@DengJiTime3,@GuiDingTime4,@DengJiTime4,@GuiDingTime5,@DengJiTime5,@GuiDingTime6,@DengJiTime6,@KaoQinRiQi)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@GuiDingTime1", SqlDbType.DateTime),
					new SqlParameter("@DengJiTime1", SqlDbType.DateTime),
					new SqlParameter("@GuiDingTime2", SqlDbType.DateTime),
					new SqlParameter("@DengJiTime2", SqlDbType.DateTime),
					new SqlParameter("@GuiDingTime3", SqlDbType.DateTime),
					new SqlParameter("@DengJiTime3", SqlDbType.DateTime),
					new SqlParameter("@GuiDingTime4", SqlDbType.DateTime),
					new SqlParameter("@DengJiTime4", SqlDbType.DateTime),
					new SqlParameter("@GuiDingTime5", SqlDbType.DateTime),
					new SqlParameter("@DengJiTime5", SqlDbType.DateTime),
					new SqlParameter("@GuiDingTime6", SqlDbType.DateTime),
					new SqlParameter("@DengJiTime6", SqlDbType.DateTime),
					new SqlParameter("@KaoQinRiQi", SqlDbType.DateTime)};
            parameters[0].Value = UserName;
            parameters[1].Value = GuiDingTime1;
            parameters[2].Value = DengJiTime1;
            parameters[3].Value = GuiDingTime2;
            parameters[4].Value = DengJiTime2;
            parameters[5].Value = GuiDingTime3;
            parameters[6].Value = DengJiTime3;
            parameters[7].Value = GuiDingTime4;
            parameters[8].Value = DengJiTime4;
            parameters[9].Value = GuiDingTime5;
            parameters[10].Value = DengJiTime5;
            parameters[11].Value = GuiDingTime6;
            parameters[12].Value = DengJiTime6;
            parameters[13].Value = KaoQinRiQi;

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
            strSql.Append("update ERPKaoQin set ");
            strSql.Append("UserName=@UserName,");
            strSql.Append("GuiDingTime1=@GuiDingTime1,");
            strSql.Append("DengJiTime1=@DengJiTime1,");
            strSql.Append("GuiDingTime2=@GuiDingTime2,");
            strSql.Append("DengJiTime2=@DengJiTime2,");
            strSql.Append("GuiDingTime3=@GuiDingTime3,");
            strSql.Append("DengJiTime3=@DengJiTime3,");
            strSql.Append("GuiDingTime4=@GuiDingTime4,");
            strSql.Append("DengJiTime4=@DengJiTime4,");
            strSql.Append("GuiDingTime5=@GuiDingTime5,");
            strSql.Append("DengJiTime5=@DengJiTime5,");
            strSql.Append("GuiDingTime6=@GuiDingTime6,");
            strSql.Append("DengJiTime6=@DengJiTime6,");
            strSql.Append("KaoQinRiQi=@KaoQinRiQi");
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@GuiDingTime1", SqlDbType.DateTime),
					new SqlParameter("@DengJiTime1", SqlDbType.DateTime),
					new SqlParameter("@GuiDingTime2", SqlDbType.DateTime),
					new SqlParameter("@DengJiTime2", SqlDbType.DateTime),
					new SqlParameter("@GuiDingTime3", SqlDbType.DateTime),
					new SqlParameter("@DengJiTime3", SqlDbType.DateTime),
					new SqlParameter("@GuiDingTime4", SqlDbType.DateTime),
					new SqlParameter("@DengJiTime4", SqlDbType.DateTime),
					new SqlParameter("@GuiDingTime5", SqlDbType.DateTime),
					new SqlParameter("@DengJiTime5", SqlDbType.DateTime),
					new SqlParameter("@GuiDingTime6", SqlDbType.DateTime),
					new SqlParameter("@DengJiTime6", SqlDbType.DateTime),
					new SqlParameter("@KaoQinRiQi", SqlDbType.DateTime)};
            parameters[0].Value = ID;
            parameters[1].Value = UserName;
            parameters[2].Value = GuiDingTime1;
            parameters[3].Value = DengJiTime1;
            parameters[4].Value = GuiDingTime2;
            parameters[5].Value = DengJiTime2;
            parameters[6].Value = GuiDingTime3;
            parameters[7].Value = DengJiTime3;
            parameters[8].Value = GuiDingTime4;
            parameters[9].Value = DengJiTime4;
            parameters[10].Value = GuiDingTime5;
            parameters[11].Value = DengJiTime5;
            parameters[12].Value = GuiDingTime6;
            parameters[13].Value = DengJiTime6;
            parameters[14].Value = KaoQinRiQi;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPKaoQin ");
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
            strSql.Append("select ID,UserName,GuiDingTime1,DengJiTime1,GuiDingTime2,DengJiTime2,GuiDingTime3,DengJiTime3,GuiDingTime4,DengJiTime4,GuiDingTime5,DengJiTime5,GuiDingTime6,DengJiTime6,KaoQinRiQi ");
            strSql.Append(" FROM ERPKaoQin ");
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
                if (ds.Tables[0].Rows[0]["GuiDingTime1"].ToString() != "")
                {
                    GuiDingTime1 = DateTime.Parse(ds.Tables[0].Rows[0]["GuiDingTime1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DengJiTime1"].ToString() != "")
                {
                    DengJiTime1 = DateTime.Parse(ds.Tables[0].Rows[0]["DengJiTime1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["GuiDingTime2"].ToString() != "")
                {
                    GuiDingTime2 = DateTime.Parse(ds.Tables[0].Rows[0]["GuiDingTime2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DengJiTime2"].ToString() != "")
                {
                    DengJiTime2 = DateTime.Parse(ds.Tables[0].Rows[0]["DengJiTime2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["GuiDingTime3"].ToString() != "")
                {
                    GuiDingTime3 = DateTime.Parse(ds.Tables[0].Rows[0]["GuiDingTime3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DengJiTime3"].ToString() != "")
                {
                    DengJiTime3 = DateTime.Parse(ds.Tables[0].Rows[0]["DengJiTime3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["GuiDingTime4"].ToString() != "")
                {
                    GuiDingTime4 = DateTime.Parse(ds.Tables[0].Rows[0]["GuiDingTime4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DengJiTime4"].ToString() != "")
                {
                    DengJiTime4 = DateTime.Parse(ds.Tables[0].Rows[0]["DengJiTime4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["GuiDingTime5"].ToString() != "")
                {
                    GuiDingTime5 = DateTime.Parse(ds.Tables[0].Rows[0]["GuiDingTime5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DengJiTime5"].ToString() != "")
                {
                    DengJiTime5 = DateTime.Parse(ds.Tables[0].Rows[0]["DengJiTime5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["GuiDingTime6"].ToString() != "")
                {
                    GuiDingTime6 = DateTime.Parse(ds.Tables[0].Rows[0]["GuiDingTime6"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DengJiTime6"].ToString() != "")
                {
                    DengJiTime6 = DateTime.Parse(ds.Tables[0].Rows[0]["DengJiTime6"].ToString());
                }
                if (ds.Tables[0].Rows[0]["KaoQinRiQi"].ToString() != "")
                {
                    KaoQinRiQi = DateTime.Parse(ds.Tables[0].Rows[0]["KaoQinRiQi"].ToString());
                }
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ID],[UserName],[GuiDingTime1],[DengJiTime1],[GuiDingTime2],[DengJiTime2],[GuiDingTime3],[DengJiTime3],[GuiDingTime4],[DengJiTime4],[GuiDingTime5],[DengJiTime5],[GuiDingTime6],[DengJiTime6],[KaoQinRiQi] ");
            strSql.Append(" FROM ERPKaoQin ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}