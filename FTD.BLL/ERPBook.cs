using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPBook。
    /// </summary>
    public class ERPBook
    {
        public ERPBook()
        { }
        #region Model
        private int _id;
        private string _bookname;
        private string _bookserils;
        private string _suoshubumen;
        private string _booktype;
        private string _auother;
        private string _isbn;
        private string _coperstr;
        private string _chubandate;
        private string _cunfangdian;
        private string _shuliang;
        private string _jiage;
        private string _neirong;
        private string _nowstate;
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
        /// 图书编码
        /// </summary>
        public string BookSerils
        {
            set { _bookserils = value; }
            get { return _bookserils; }
        }
        /// <summary>
        /// 所属部门
        /// </summary>
        public string SuoShuBuMen
        {
            set { _suoshubumen = value; }
            get { return _suoshubumen; }
        }
        /// <summary>
        /// 图书类别
        /// </summary>
        public string BookType
        {
            set { _booktype = value; }
            get { return _booktype; }
        }
        /// <summary>
        /// 作者
        /// </summary>
        public string Auother
        {
            set { _auother = value; }
            get { return _auother; }
        }
        /// <summary>
        /// ISBN号
        /// </summary>
        public string ISBN
        {
            set { _isbn = value; }
            get { return _isbn; }
        }
        /// <summary>
        /// 出版社
        /// </summary>
        public string CoperStr
        {
            set { _coperstr = value; }
            get { return _coperstr; }
        }
        /// <summary>
        /// 出版日期
        /// </summary>
        public string ChuBanDate
        {
            set { _chubandate = value; }
            get { return _chubandate; }
        }
        /// <summary>
        /// 存放位置
        /// </summary>
        public string CunFangDian
        {
            set { _cunfangdian = value; }
            get { return _cunfangdian; }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public string ShuLiang
        {
            set { _shuliang = value; }
            get { return _shuliang; }
        }
        /// <summary>
        /// 价格
        /// </summary>
        public string JiaGe
        {
            set { _jiage = value; }
            get { return _jiage; }
        }
        /// <summary>
        /// 内容简介
        /// </summary>
        public string NeiRong
        {
            set { _neirong = value; }
            get { return _neirong; }
        }
        /// <summary>
        /// 当前状态
        /// </summary>
        public string NowState
        {
            set { _nowstate = value; }
            get { return _nowstate; }
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
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPBook(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,BookName,BookSerils,SuoShuBuMen,BookType,Auother,ISBN,CoperStr,ChuBanDate,CunFangDian,ShuLiang,JiaGe,NeiRong,NowState,BackInfo,UserName,TimeStr ");
            strSql.Append(" FROM ERPBook ");
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
                BookSerils = ds.Tables[0].Rows[0]["BookSerils"].ToString();
                SuoShuBuMen = ds.Tables[0].Rows[0]["SuoShuBuMen"].ToString();
                BookType = ds.Tables[0].Rows[0]["BookType"].ToString();
                Auother = ds.Tables[0].Rows[0]["Auother"].ToString();
                ISBN = ds.Tables[0].Rows[0]["ISBN"].ToString();
                CoperStr = ds.Tables[0].Rows[0]["CoperStr"].ToString();
                ChuBanDate = ds.Tables[0].Rows[0]["ChuBanDate"].ToString();
                CunFangDian = ds.Tables[0].Rows[0]["CunFangDian"].ToString();
                ShuLiang = ds.Tables[0].Rows[0]["ShuLiang"].ToString();
                JiaGe = ds.Tables[0].Rows[0]["JiaGe"].ToString();
                NeiRong = ds.Tables[0].Rows[0]["NeiRong"].ToString();
                NowState = ds.Tables[0].Rows[0]["NowState"].ToString();
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
            strSql.Append("select count(1) from ERPBook");
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
            strSql.Append("insert into ERPBook(");
            strSql.Append("BookName,BookSerils,SuoShuBuMen,BookType,Auother,ISBN,CoperStr,ChuBanDate,CunFangDian,ShuLiang,JiaGe,NeiRong,NowState,BackInfo,UserName,TimeStr)");
            strSql.Append(" values (");
            strSql.Append("@BookName,@BookSerils,@SuoShuBuMen,@BookType,@Auother,@ISBN,@CoperStr,@ChuBanDate,@CunFangDian,@ShuLiang,@JiaGe,@NeiRong,@NowState,@BackInfo,@UserName,@TimeStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@BookName", SqlDbType.VarChar,50),
					new SqlParameter("@BookSerils", SqlDbType.VarChar,50),
					new SqlParameter("@SuoShuBuMen", SqlDbType.VarChar,50),
					new SqlParameter("@BookType", SqlDbType.VarChar,50),
					new SqlParameter("@Auother", SqlDbType.VarChar,50),
					new SqlParameter("@ISBN", SqlDbType.VarChar,50),
					new SqlParameter("@CoperStr", SqlDbType.VarChar,50),
					new SqlParameter("@ChuBanDate", SqlDbType.VarChar,50),
					new SqlParameter("@CunFangDian", SqlDbType.VarChar,50),
					new SqlParameter("@ShuLiang", SqlDbType.VarChar,50),
					new SqlParameter("@JiaGe", SqlDbType.VarChar,50),
					new SqlParameter("@NeiRong", SqlDbType.VarChar,5000),
					new SqlParameter("@NowState", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = BookName;
            parameters[1].Value = BookSerils;
            parameters[2].Value = SuoShuBuMen;
            parameters[3].Value = BookType;
            parameters[4].Value = Auother;
            parameters[5].Value = ISBN;
            parameters[6].Value = CoperStr;
            parameters[7].Value = ChuBanDate;
            parameters[8].Value = CunFangDian;
            parameters[9].Value = ShuLiang;
            parameters[10].Value = JiaGe;
            parameters[11].Value = NeiRong;
            parameters[12].Value = NowState;
            parameters[13].Value = BackInfo;
            parameters[14].Value = UserName;
            parameters[15].Value = TimeStr;

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
            strSql.Append("update ERPBook set ");
            strSql.Append("BookName=@BookName,");
            strSql.Append("BookSerils=@BookSerils,");
            strSql.Append("SuoShuBuMen=@SuoShuBuMen,");
            strSql.Append("BookType=@BookType,");
            strSql.Append("Auother=@Auother,");
            strSql.Append("ISBN=@ISBN,");
            strSql.Append("CoperStr=@CoperStr,");
            strSql.Append("ChuBanDate=@ChuBanDate,");
            strSql.Append("CunFangDian=@CunFangDian,");
            strSql.Append("ShuLiang=@ShuLiang,");
            strSql.Append("JiaGe=@JiaGe,");
            strSql.Append("NeiRong=@NeiRong,");
            strSql.Append("NowState=@NowState,");
            strSql.Append("BackInfo=@BackInfo,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TimeStr=@TimeStr");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@BookName", SqlDbType.VarChar,50),
					new SqlParameter("@BookSerils", SqlDbType.VarChar,50),
					new SqlParameter("@SuoShuBuMen", SqlDbType.VarChar,50),
					new SqlParameter("@BookType", SqlDbType.VarChar,50),
					new SqlParameter("@Auother", SqlDbType.VarChar,50),
					new SqlParameter("@ISBN", SqlDbType.VarChar,50),
					new SqlParameter("@CoperStr", SqlDbType.VarChar,50),
					new SqlParameter("@ChuBanDate", SqlDbType.VarChar,50),
					new SqlParameter("@CunFangDian", SqlDbType.VarChar,50),
					new SqlParameter("@ShuLiang", SqlDbType.VarChar,50),
					new SqlParameter("@JiaGe", SqlDbType.VarChar,50),
					new SqlParameter("@NeiRong", SqlDbType.VarChar,5000),
					new SqlParameter("@NowState", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = ID;
            parameters[1].Value = BookName;
            parameters[2].Value = BookSerils;
            parameters[3].Value = SuoShuBuMen;
            parameters[4].Value = BookType;
            parameters[5].Value = Auother;
            parameters[6].Value = ISBN;
            parameters[7].Value = CoperStr;
            parameters[8].Value = ChuBanDate;
            parameters[9].Value = CunFangDian;
            parameters[10].Value = ShuLiang;
            parameters[11].Value = JiaGe;
            parameters[12].Value = NeiRong;
            parameters[13].Value = NowState;
            parameters[14].Value = BackInfo;
            parameters[15].Value = UserName;
            parameters[16].Value = TimeStr;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPBook ");
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
            strSql.Append("select  top 1 ID,BookName,BookSerils,SuoShuBuMen,BookType,Auother,ISBN,CoperStr,ChuBanDate,CunFangDian,ShuLiang,JiaGe,NeiRong,NowState,BackInfo,UserName,TimeStr ");
            strSql.Append(" FROM ERPBook ");
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
                BookSerils = ds.Tables[0].Rows[0]["BookSerils"].ToString();
                SuoShuBuMen = ds.Tables[0].Rows[0]["SuoShuBuMen"].ToString();
                BookType = ds.Tables[0].Rows[0]["BookType"].ToString();
                Auother = ds.Tables[0].Rows[0]["Auother"].ToString();
                ISBN = ds.Tables[0].Rows[0]["ISBN"].ToString();
                CoperStr = ds.Tables[0].Rows[0]["CoperStr"].ToString();
                ChuBanDate = ds.Tables[0].Rows[0]["ChuBanDate"].ToString();
                CunFangDian = ds.Tables[0].Rows[0]["CunFangDian"].ToString();
                ShuLiang = ds.Tables[0].Rows[0]["ShuLiang"].ToString();
                JiaGe = ds.Tables[0].Rows[0]["JiaGe"].ToString();
                NeiRong = ds.Tables[0].Rows[0]["NeiRong"].ToString();
                NowState = ds.Tables[0].Rows[0]["NowState"].ToString();
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
            strSql.Append(" FROM ERPBook ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

