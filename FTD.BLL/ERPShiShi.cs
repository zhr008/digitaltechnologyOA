using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPShiShi。
    /// </summary>
    public class ERPShiShi
    {
        public ERPShiShi()
        { }
        #region Model
        private int _id;
        private string _projectname;
        private string _projectserils;
        private string _shishitime;
        private string _shishiren;
        private string _shishicontent;
        private string _wangongliang;
        private string _pingjia;
        private string _xiaojie;
        private string _wenti;
        private string _yujijiejueriqi;
        private string _wentijieda;
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
        /// 项目名称：
        /// </summary>
        public string ProjectName
        {
            set { _projectname = value; }
            get { return _projectname; }
        }
        /// <summary>
        /// 项目编号：
        /// </summary>
        public string ProjectSerils
        {
            set { _projectserils = value; }
            get { return _projectserils; }
        }
        /// <summary>
        /// 实施时间：
        /// </summary>
        public string ShiShiTime
        {
            set { _shishitime = value; }
            get { return _shishitime; }
        }
        /// <summary>
        /// 实施人：
        /// </summary>
        public string ShiShiRen
        {
            set { _shishiren = value; }
            get { return _shishiren; }
        }
        /// <summary>
        /// 实施内容：
        /// </summary>
        public string ShiShiContent
        {
            set { _shishicontent = value; }
            get { return _shishicontent; }
        }
        /// <summary>
        /// 完工量：
        /// </summary>
        public string WanGongLiang
        {
            set { _wangongliang = value; }
            get { return _wangongliang; }
        }
        /// <summary>
        /// 客户评价：
        /// </summary>
        public string PingJia
        {
            set { _pingjia = value; }
            get { return _pingjia; }
        }
        /// <summary>
        /// 实施小结：
        /// </summary>
        public string XiaoJie
        {
            set { _xiaojie = value; }
            get { return _xiaojie; }
        }
        /// <summary>
        /// 实施问题：
        /// </summary>
        public string WenTi
        {
            set { _wenti = value; }
            get { return _wenti; }
        }
        /// <summary>
        /// 预计解决问题日期：
        /// </summary>
        public string YuJiJieJueRiQi
        {
            set { _yujijiejueriqi = value; }
            get { return _yujijiejueriqi; }
        }
        /// <summary>
        /// 问题解答：
        /// </summary>
        public string WenTiJieDa
        {
            set { _wentijieda = value; }
            get { return _wentijieda; }
        }
        /// <summary>
        /// 录入人：
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 录入时间：
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
        public ERPShiShi(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,ProjectName,ProjectSerils,ShiShiTime,ShiShiRen,ShiShiContent,WanGongLiang,PingJia,XiaoJie,WenTi,YuJiJieJueRiQi,WenTiJieDa,UserName,TimeStr ");
            strSql.Append(" FROM ERPShiShi ");
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
                ProjectName = ds.Tables[0].Rows[0]["ProjectName"].ToString();
                ProjectSerils = ds.Tables[0].Rows[0]["ProjectSerils"].ToString();
                ShiShiTime = ds.Tables[0].Rows[0]["ShiShiTime"].ToString();
                ShiShiRen = ds.Tables[0].Rows[0]["ShiShiRen"].ToString();
                ShiShiContent = ds.Tables[0].Rows[0]["ShiShiContent"].ToString();
                WanGongLiang = ds.Tables[0].Rows[0]["WanGongLiang"].ToString();
                PingJia = ds.Tables[0].Rows[0]["PingJia"].ToString();
                XiaoJie = ds.Tables[0].Rows[0]["XiaoJie"].ToString();
                WenTi = ds.Tables[0].Rows[0]["WenTi"].ToString();
                YuJiJieJueRiQi = ds.Tables[0].Rows[0]["YuJiJieJueRiQi"].ToString();
                WenTiJieDa = ds.Tables[0].Rows[0]["WenTiJieDa"].ToString();
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
            strSql.Append("select count(1) from ERPShiShi");
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
            strSql.Append("insert into ERPShiShi(");
            strSql.Append("ProjectName,ProjectSerils,ShiShiTime,ShiShiRen,ShiShiContent,WanGongLiang,PingJia,XiaoJie,WenTi,YuJiJieJueRiQi,WenTiJieDa,UserName,TimeStr)");
            strSql.Append(" values (");
            strSql.Append("@ProjectName,@ProjectSerils,@ShiShiTime,@ShiShiRen,@ShiShiContent,@WanGongLiang,@PingJia,@XiaoJie,@WenTi,@YuJiJieJueRiQi,@WenTiJieDa,@UserName,@TimeStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ProjectName", SqlDbType.VarChar,200),
					new SqlParameter("@ProjectSerils", SqlDbType.VarChar,50),
					new SqlParameter("@ShiShiTime", SqlDbType.VarChar,50),
					new SqlParameter("@ShiShiRen", SqlDbType.VarChar,50),
					new SqlParameter("@ShiShiContent", SqlDbType.VarChar,500),
					new SqlParameter("@WanGongLiang", SqlDbType.VarChar,50),
					new SqlParameter("@PingJia", SqlDbType.VarChar,50),
					new SqlParameter("@XiaoJie", SqlDbType.VarChar,8000),
					new SqlParameter("@WenTi", SqlDbType.VarChar,8000),
					new SqlParameter("@YuJiJieJueRiQi", SqlDbType.VarChar,50),
					new SqlParameter("@WenTiJieDa", SqlDbType.VarChar,8000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = ProjectName;
            parameters[1].Value = ProjectSerils;
            parameters[2].Value = ShiShiTime;
            parameters[3].Value = ShiShiRen;
            parameters[4].Value = ShiShiContent;
            parameters[5].Value = WanGongLiang;
            parameters[6].Value = PingJia;
            parameters[7].Value = XiaoJie;
            parameters[8].Value = WenTi;
            parameters[9].Value = YuJiJieJueRiQi;
            parameters[10].Value = WenTiJieDa;
            parameters[11].Value = UserName;
            parameters[12].Value = TimeStr;

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
            strSql.Append("update ERPShiShi set ");
            strSql.Append("ProjectName=@ProjectName,");
            strSql.Append("ProjectSerils=@ProjectSerils,");
            strSql.Append("ShiShiTime=@ShiShiTime,");
            strSql.Append("ShiShiRen=@ShiShiRen,");
            strSql.Append("ShiShiContent=@ShiShiContent,");
            strSql.Append("WanGongLiang=@WanGongLiang,");
            strSql.Append("PingJia=@PingJia,");
            strSql.Append("XiaoJie=@XiaoJie,");
            strSql.Append("WenTi=@WenTi,");
            strSql.Append("YuJiJieJueRiQi=@YuJiJieJueRiQi,");
            strSql.Append("WenTiJieDa=@WenTiJieDa,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TimeStr=@TimeStr");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@ProjectName", SqlDbType.VarChar,200),
					new SqlParameter("@ProjectSerils", SqlDbType.VarChar,50),
					new SqlParameter("@ShiShiTime", SqlDbType.VarChar,50),
					new SqlParameter("@ShiShiRen", SqlDbType.VarChar,50),
					new SqlParameter("@ShiShiContent", SqlDbType.VarChar,500),
					new SqlParameter("@WanGongLiang", SqlDbType.VarChar,50),
					new SqlParameter("@PingJia", SqlDbType.VarChar,50),
					new SqlParameter("@XiaoJie", SqlDbType.VarChar,8000),
					new SqlParameter("@WenTi", SqlDbType.VarChar,8000),
					new SqlParameter("@YuJiJieJueRiQi", SqlDbType.VarChar,50),
					new SqlParameter("@WenTiJieDa", SqlDbType.VarChar,8000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = ID;
            parameters[1].Value = ProjectName;
            parameters[2].Value = ProjectSerils;
            parameters[3].Value = ShiShiTime;
            parameters[4].Value = ShiShiRen;
            parameters[5].Value = ShiShiContent;
            parameters[6].Value = WanGongLiang;
            parameters[7].Value = PingJia;
            parameters[8].Value = XiaoJie;
            parameters[9].Value = WenTi;
            parameters[10].Value = YuJiJieJueRiQi;
            parameters[11].Value = WenTiJieDa;
            parameters[12].Value = UserName;
            parameters[13].Value = TimeStr;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPShiShi ");
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
            strSql.Append("select ID,ProjectName,ProjectSerils,ShiShiTime,ShiShiRen,ShiShiContent,WanGongLiang,PingJia,XiaoJie,WenTi,YuJiJieJueRiQi,WenTiJieDa,UserName,TimeStr ");
            strSql.Append(" FROM ERPShiShi ");
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
                ProjectName = ds.Tables[0].Rows[0]["ProjectName"].ToString();
                ProjectSerils = ds.Tables[0].Rows[0]["ProjectSerils"].ToString();
                ShiShiTime = ds.Tables[0].Rows[0]["ShiShiTime"].ToString();
                ShiShiRen = ds.Tables[0].Rows[0]["ShiShiRen"].ToString();
                ShiShiContent = ds.Tables[0].Rows[0]["ShiShiContent"].ToString();
                WanGongLiang = ds.Tables[0].Rows[0]["WanGongLiang"].ToString();
                PingJia = ds.Tables[0].Rows[0]["PingJia"].ToString();
                XiaoJie = ds.Tables[0].Rows[0]["XiaoJie"].ToString();
                WenTi = ds.Tables[0].Rows[0]["WenTi"].ToString();
                YuJiJieJueRiQi = ds.Tables[0].Rows[0]["YuJiJieJueRiQi"].ToString();
                WenTiJieDa = ds.Tables[0].Rows[0]["WenTiJieDa"].ToString();
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
            strSql.Append("select [ID],[ProjectName],[ProjectSerils],[ShiShiTime],[ShiShiRen],[ShiShiContent],[WanGongLiang],[PingJia],[XiaoJie],[WenTi],[YuJiJieJueRiQi],[WenTiJieDa],[UserName],[TimeStr] ");
            strSql.Append(" FROM ERPShiShi ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

