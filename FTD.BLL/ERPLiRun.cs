using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPLiRun。
    /// </summary>
    public class ERPLiRun
    {
        public ERPLiRun()
        { }
        #region Model
        private int _id;
        private string _projectname;
        private string _projectserils;
        private string _sumjine;
        private string _feiyong;
        private string _chengben;
        private string _fangzu;
        private string _shuie;
        private string _gongzi;
        private string _ticheng;
        private string _qita;
        private string _shiji;
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
        /// 项目总金额：
        /// </summary>
        public string SumJinE
        {
            set { _sumjine = value; }
            get { return _sumjine; }
        }
        /// <summary>
        /// 项目费用：
        /// </summary>
        public string FeiYong
        {
            set { _feiyong = value; }
            get { return _feiyong; }
        }
        /// <summary>
        /// 项目成本：
        /// </summary>
        public string ChengBen
        {
            set { _chengben = value; }
            get { return _chengben; }
        }
        /// <summary>
        /// 房租费用：
        /// </summary>
        public string FangZu
        {
            set { _fangzu = value; }
            get { return _fangzu; }
        }
        /// <summary>
        /// 税额费用：
        /// </summary>
        public string ShuiE
        {
            set { _shuie = value; }
            get { return _shuie; }
        }
        /// <summary>
        /// 员工工资：
        /// </summary>
        public string GongZi
        {
            set { _gongzi = value; }
            get { return _gongzi; }
        }
        /// <summary>
        /// 业务员提成：
        /// </summary>
        public string TiCheng
        {
            set { _ticheng = value; }
            get { return _ticheng; }
        }
        /// <summary>
        /// 其他费用：
        /// </summary>
        public string QiTa
        {
            set { _qita = value; }
            get { return _qita; }
        }
        /// <summary>
        /// 实际利润：
        /// </summary>
        public string ShiJi
        {
            set { _shiji = value; }
            get { return _shiji; }
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
        public ERPLiRun(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,ProjectName,ProjectSerils,SumJinE,FeiYong,ChengBen,FangZu,ShuiE,GongZi,TiCheng,QiTa,ShiJi,UserName,TimeStr ");
            strSql.Append(" FROM ERPLiRun ");
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
                SumJinE = ds.Tables[0].Rows[0]["SumJinE"].ToString();
                FeiYong = ds.Tables[0].Rows[0]["FeiYong"].ToString();
                ChengBen = ds.Tables[0].Rows[0]["ChengBen"].ToString();
                FangZu = ds.Tables[0].Rows[0]["FangZu"].ToString();
                ShuiE = ds.Tables[0].Rows[0]["ShuiE"].ToString();
                GongZi = ds.Tables[0].Rows[0]["GongZi"].ToString();
                TiCheng = ds.Tables[0].Rows[0]["TiCheng"].ToString();
                QiTa = ds.Tables[0].Rows[0]["QiTa"].ToString();
                ShiJi = ds.Tables[0].Rows[0]["ShiJi"].ToString();
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
            strSql.Append("select count(1) from ERPLiRun");
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
            strSql.Append("insert into ERPLiRun(");
            strSql.Append("ProjectName,ProjectSerils,SumJinE,FeiYong,ChengBen,FangZu,ShuiE,GongZi,TiCheng,QiTa,ShiJi,UserName,TimeStr)");
            strSql.Append(" values (");
            strSql.Append("@ProjectName,@ProjectSerils,@SumJinE,@FeiYong,@ChengBen,@FangZu,@ShuiE,@GongZi,@TiCheng,@QiTa,@ShiJi,@UserName,@TimeStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ProjectName", SqlDbType.VarChar,200),
					new SqlParameter("@ProjectSerils", SqlDbType.VarChar,50),
					new SqlParameter("@SumJinE", SqlDbType.VarChar,50),
					new SqlParameter("@FeiYong", SqlDbType.VarChar,50),
					new SqlParameter("@ChengBen", SqlDbType.VarChar,50),
					new SqlParameter("@FangZu", SqlDbType.VarChar,50),
					new SqlParameter("@ShuiE", SqlDbType.VarChar,50),
					new SqlParameter("@GongZi", SqlDbType.VarChar,50),
					new SqlParameter("@TiCheng", SqlDbType.VarChar,50),
					new SqlParameter("@QiTa", SqlDbType.VarChar,50),
					new SqlParameter("@ShiJi", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = ProjectName;
            parameters[1].Value = ProjectSerils;
            parameters[2].Value = SumJinE;
            parameters[3].Value = FeiYong;
            parameters[4].Value = ChengBen;
            parameters[5].Value = FangZu;
            parameters[6].Value = ShuiE;
            parameters[7].Value = GongZi;
            parameters[8].Value = TiCheng;
            parameters[9].Value = QiTa;
            parameters[10].Value = ShiJi;
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
            strSql.Append("update ERPLiRun set ");
            strSql.Append("ProjectName=@ProjectName,");
            strSql.Append("ProjectSerils=@ProjectSerils,");
            strSql.Append("SumJinE=@SumJinE,");
            strSql.Append("FeiYong=@FeiYong,");
            strSql.Append("ChengBen=@ChengBen,");
            strSql.Append("FangZu=@FangZu,");
            strSql.Append("ShuiE=@ShuiE,");
            strSql.Append("GongZi=@GongZi,");
            strSql.Append("TiCheng=@TiCheng,");
            strSql.Append("QiTa=@QiTa,");
            strSql.Append("ShiJi=@ShiJi,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TimeStr=@TimeStr");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@ProjectName", SqlDbType.VarChar,200),
					new SqlParameter("@ProjectSerils", SqlDbType.VarChar,50),
					new SqlParameter("@SumJinE", SqlDbType.VarChar,50),
					new SqlParameter("@FeiYong", SqlDbType.VarChar,50),
					new SqlParameter("@ChengBen", SqlDbType.VarChar,50),
					new SqlParameter("@FangZu", SqlDbType.VarChar,50),
					new SqlParameter("@ShuiE", SqlDbType.VarChar,50),
					new SqlParameter("@GongZi", SqlDbType.VarChar,50),
					new SqlParameter("@TiCheng", SqlDbType.VarChar,50),
					new SqlParameter("@QiTa", SqlDbType.VarChar,50),
					new SqlParameter("@ShiJi", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = ID;
            parameters[1].Value = ProjectName;
            parameters[2].Value = ProjectSerils;
            parameters[3].Value = SumJinE;
            parameters[4].Value = FeiYong;
            parameters[5].Value = ChengBen;
            parameters[6].Value = FangZu;
            parameters[7].Value = ShuiE;
            parameters[8].Value = GongZi;
            parameters[9].Value = TiCheng;
            parameters[10].Value = QiTa;
            parameters[11].Value = ShiJi;
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
            strSql.Append("delete ERPLiRun ");
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
            strSql.Append("select ID,ProjectName,ProjectSerils,SumJinE,FeiYong,ChengBen,FangZu,ShuiE,GongZi,TiCheng,QiTa,ShiJi,UserName,TimeStr ");
            strSql.Append(" FROM ERPLiRun ");
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
                SumJinE = ds.Tables[0].Rows[0]["SumJinE"].ToString();
                FeiYong = ds.Tables[0].Rows[0]["FeiYong"].ToString();
                ChengBen = ds.Tables[0].Rows[0]["ChengBen"].ToString();
                FangZu = ds.Tables[0].Rows[0]["FangZu"].ToString();
                ShuiE = ds.Tables[0].Rows[0]["ShuiE"].ToString();
                GongZi = ds.Tables[0].Rows[0]["GongZi"].ToString();
                TiCheng = ds.Tables[0].Rows[0]["TiCheng"].ToString();
                QiTa = ds.Tables[0].Rows[0]["QiTa"].ToString();
                ShiJi = ds.Tables[0].Rows[0]["ShiJi"].ToString();
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
            strSql.Append("select [ID],[ProjectName],[ProjectSerils],[SumJinE],[FeiYong],[ChengBen],[FangZu],[ShuiE],[GongZi],[TiCheng],[QiTa],[ShiJi],[UserName],[TimeStr] ");
            strSql.Append(" FROM ERPLiRun ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

