using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPBookJieHuan。
    /// </summary>
    public class ERPBookJieHuan
    {
        public ERPBookJieHuan()
        { }
        #region Model
        private int _id;
        private string _bookname;
        private string _jieshudate;
        private string _guihuandate;
        private string _jiehuanstate;
        private string _backinfo;
        private string _username;
        private DateTime? _timestr;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 图书名称
        /// </summary>
        public string BookName
        {
            set { _bookname = value; }
            get { return _bookname; }
        }
        /// <summary>
        /// 借书日期
        /// </summary>
        public string JieShuDate
        {
            set { _jieshudate = value; }
            get { return _jieshudate; }
        }
        /// <summary>
        /// 归还日期
        /// </summary>
        public string GuiHuanDate
        {
            set { _guihuandate = value; }
            get { return _guihuandate; }
        }
        /// <summary>
        /// 借还状态
        /// </summary>
        public string JieHuanState
        {
            set { _jiehuanstate = value; }
            get { return _jiehuanstate; }
        }
        /// <summary>
        /// 备注说明
        /// </summary>
        public string BackInfo
        {
            set { _backinfo = value; }
            get { return _backinfo; }
        }
        /// <summary>
        /// 借书人
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime? TimeStr
        {
            set { _timestr = value; }
            get { return _timestr; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPBookJieHuan(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,BookName,JieShuDate,GuiHuanDate,JieHuanState,BackInfo,UserName,TimeStr ");
            strSql.Append(" FROM ERPBookJieHuan ");
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
                BookName = ds.Tables[0].Rows[0]["BookName"].ToString();
                JieShuDate = ds.Tables[0].Rows[0]["JieShuDate"].ToString();
                GuiHuanDate = ds.Tables[0].Rows[0]["GuiHuanDate"].ToString();
                JieHuanState = ds.Tables[0].Rows[0]["JieHuanState"].ToString();
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPBookJieHuan");
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
            strSql.Append("insert into ERPBookJieHuan(");
            strSql.Append("BookName,JieShuDate,GuiHuanDate,JieHuanState,BackInfo,UserName,TimeStr)");
            strSql.Append(" values (");
            strSql.Append("@BookName,@JieShuDate,@GuiHuanDate,@JieHuanState,@BackInfo,@UserName,@TimeStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@BookName", SqlDbType.VarChar,50),
					new SqlParameter("@JieShuDate", SqlDbType.VarChar,50),
					new SqlParameter("@GuiHuanDate", SqlDbType.VarChar,50),
					new SqlParameter("@JieHuanState", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = BookName;
            parameters[1].Value = JieShuDate;
            parameters[2].Value = GuiHuanDate;
            parameters[3].Value = JieHuanState;
            parameters[4].Value = BackInfo;
            parameters[5].Value = UserName;
            parameters[6].Value = TimeStr;

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
            strSql.Append("update ERPBookJieHuan set ");
            strSql.Append("BookName=@BookName,");
            strSql.Append("JieShuDate=@JieShuDate,");
            strSql.Append("GuiHuanDate=@GuiHuanDate,");
            strSql.Append("JieHuanState=@JieHuanState,");
            strSql.Append("BackInfo=@BackInfo,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TimeStr=@TimeStr");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@BookName", SqlDbType.VarChar,50),
					new SqlParameter("@JieShuDate", SqlDbType.VarChar,50),
					new SqlParameter("@GuiHuanDate", SqlDbType.VarChar,50),
					new SqlParameter("@JieHuanState", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = ID;
            parameters[1].Value = BookName;
            parameters[2].Value = JieShuDate;
            parameters[3].Value = GuiHuanDate;
            parameters[4].Value = JieHuanState;
            parameters[5].Value = BackInfo;
            parameters[6].Value = UserName;
            parameters[7].Value = TimeStr;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPBookJieHuan ");
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
            strSql.Append("select  top 1 ID,BookName,JieShuDate,GuiHuanDate,JieHuanState,BackInfo,UserName,TimeStr ");
            strSql.Append(" FROM ERPBookJieHuan ");
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
                BookName = ds.Tables[0].Rows[0]["BookName"].ToString();
                JieShuDate = ds.Tables[0].Rows[0]["JieShuDate"].ToString();
                GuiHuanDate = ds.Tables[0].Rows[0]["GuiHuanDate"].ToString();
                JieHuanState = ds.Tables[0].Rows[0]["JieHuanState"].ToString();
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
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
            strSql.Append(" FROM ERPBookJieHuan ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

