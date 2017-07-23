using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPTelFile。
    /// </summary>
    public class ERPTelFile
    {
        public ERPTelFile()
        { }
        #region Model
        private int _id;
        private string _titlestr;
        private string _fromuser;
        private DateTime? _timestr;
        private string _filetype;
        private string _touser;
        private string _yijieshouren;
        private string _contentstr;
        private string _fujianstr;
        private string _chuanyueyijian;
        private string _qianshouhouidlist;
        private string _chuanyuehouidlist1;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 主题
        /// </summary>
        public string TitleStr
        {
            set { _titlestr = value; }
            get { return _titlestr; }
        }
        /// <summary>
        /// 发文件人
        /// </summary>
        public string FromUser
        {
            set { _fromuser = value; }
            get { return _fromuser; }
        }
        /// <summary>
        /// 发文时间
        /// </summary>
        public DateTime? TimeStr
        {
            set { _timestr = value; }
            get { return _timestr; }
        }
        /// <summary>
        /// 文件分类
        /// </summary>
        public string FileType
        {
            set { _filetype = value; }
            get { return _filetype; }
        }
        /// <summary>
        /// 接收人列表
        /// </summary>
        public string ToUser
        {
            set { _touser = value; }
            get { return _touser; }
        }
        /// <summary>
        /// 已经接收人
        /// </summary>
        public string YiJieShouRen
        {
            set { _yijieshouren = value; }
            get { return _yijieshouren; }
        }
        /// <summary>
        /// 详细内容
        /// </summary>
        public string ContentStr
        {
            set { _contentstr = value; }
            get { return _contentstr; }
        }
        /// <summary>
        /// 附件
        /// </summary>
        public string FuJianStr
        {
            set { _fujianstr = value; }
            get { return _fujianstr; }
        }
        /// <summary>
        /// 传阅意见
        /// </summary>
        public string ChuanYueYiJian
        {
            set { _chuanyueyijian = value; }
            get { return _chuanyueyijian; }
        }
        /// <summary>
        /// 签收后属于文件夹ID列表
        /// </summary>
        public string QianShouHouIDList
        {
            set { _qianshouhouidlist = value; }
            get { return _qianshouhouidlist; }
        }
        /// <summary>
        /// 传阅后属于文件夹ID列表
        /// </summary>
        public string ChuanYueHouIDList1
        {
            set { _chuanyuehouidlist1 = value; }
            get { return _chuanyuehouidlist1; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPTelFile(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,TitleStr,FromUser,TimeStr,FileType,ToUser,YiJieShouRen,ContentStr,FuJianStr,ChuanYueYiJian,QianShouHouIDList,ChuanYueHouIDList1 ");
            strSql.Append(" FROM ERPTelFile ");
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
                TitleStr = ds.Tables[0].Rows[0]["TitleStr"].ToString();
                FromUser = ds.Tables[0].Rows[0]["FromUser"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                FileType = ds.Tables[0].Rows[0]["FileType"].ToString();
                ToUser = ds.Tables[0].Rows[0]["ToUser"].ToString();
                YiJieShouRen = ds.Tables[0].Rows[0]["YiJieShouRen"].ToString();
                ContentStr = ds.Tables[0].Rows[0]["ContentStr"].ToString();
                FuJianStr = ds.Tables[0].Rows[0]["FuJianStr"].ToString();
                ChuanYueYiJian = ds.Tables[0].Rows[0]["ChuanYueYiJian"].ToString();
                QianShouHouIDList = ds.Tables[0].Rows[0]["QianShouHouIDList"].ToString();
                ChuanYueHouIDList1 = ds.Tables[0].Rows[0]["ChuanYueHouIDList1"].ToString();
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPTelFile");
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
            strSql.Append("insert into ERPTelFile(");
            strSql.Append("TitleStr,FromUser,TimeStr,FileType,ToUser,YiJieShouRen,ContentStr,FuJianStr,ChuanYueYiJian,QianShouHouIDList,ChuanYueHouIDList1)");
            strSql.Append(" values (");
            strSql.Append("@TitleStr,@FromUser,@TimeStr,@FileType,@ToUser,@YiJieShouRen,@ContentStr,@FuJianStr,@ChuanYueYiJian,@QianShouHouIDList,@ChuanYueHouIDList1)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@TitleStr", SqlDbType.VarChar,500),
					new SqlParameter("@FromUser", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@FileType", SqlDbType.VarChar,50),
					new SqlParameter("@ToUser", SqlDbType.VarChar,8000),
					new SqlParameter("@YiJieShouRen", SqlDbType.VarChar,8000),
					new SqlParameter("@ContentStr", SqlDbType.Text),
					new SqlParameter("@FuJianStr", SqlDbType.VarChar,1000),
					new SqlParameter("@ChuanYueYiJian", SqlDbType.Text),
					new SqlParameter("@QianShouHouIDList", SqlDbType.VarChar,8000),
					new SqlParameter("@ChuanYueHouIDList1", SqlDbType.VarChar,8000)};
            parameters[0].Value = TitleStr;
            parameters[1].Value = FromUser;
            parameters[2].Value = TimeStr;
            parameters[3].Value = FileType;
            parameters[4].Value = ToUser;
            parameters[5].Value = YiJieShouRen;
            parameters[6].Value = ContentStr;
            parameters[7].Value = FuJianStr;
            parameters[8].Value = ChuanYueYiJian;
            parameters[9].Value = QianShouHouIDList;
            parameters[10].Value = ChuanYueHouIDList1;

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
            strSql.Append("update ERPTelFile set ");
            strSql.Append("TitleStr=@TitleStr,");
            strSql.Append("FromUser=@FromUser,");
            strSql.Append("TimeStr=@TimeStr,");
            strSql.Append("FileType=@FileType,");
            strSql.Append("ToUser=@ToUser,");
            strSql.Append("YiJieShouRen=@YiJieShouRen,");
            strSql.Append("ContentStr=@ContentStr,");
            strSql.Append("FuJianStr=@FuJianStr,");
            strSql.Append("ChuanYueYiJian=@ChuanYueYiJian,");
            strSql.Append("QianShouHouIDList=@QianShouHouIDList,");
            strSql.Append("ChuanYueHouIDList1=@ChuanYueHouIDList1");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@TitleStr", SqlDbType.VarChar,500),
					new SqlParameter("@FromUser", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@FileType", SqlDbType.VarChar,50),
					new SqlParameter("@ToUser", SqlDbType.VarChar,8000),
					new SqlParameter("@YiJieShouRen", SqlDbType.VarChar,8000),
					new SqlParameter("@ContentStr", SqlDbType.Text),
					new SqlParameter("@FuJianStr", SqlDbType.VarChar,1000),
					new SqlParameter("@ChuanYueYiJian", SqlDbType.Text),
					new SqlParameter("@QianShouHouIDList", SqlDbType.VarChar,8000),
					new SqlParameter("@ChuanYueHouIDList1", SqlDbType.VarChar,8000)};
            parameters[0].Value = ID;
            parameters[1].Value = TitleStr;
            parameters[2].Value = FromUser;
            parameters[3].Value = TimeStr;
            parameters[4].Value = FileType;
            parameters[5].Value = ToUser;
            parameters[6].Value = YiJieShouRen;
            parameters[7].Value = ContentStr;
            parameters[8].Value = FuJianStr;
            parameters[9].Value = ChuanYueYiJian;
            parameters[10].Value = QianShouHouIDList;
            parameters[11].Value = ChuanYueHouIDList1;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPTelFile ");
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
            strSql.Append("select  top 1 ID,TitleStr,FromUser,TimeStr,FileType,ToUser,YiJieShouRen,ContentStr,FuJianStr,ChuanYueYiJian,QianShouHouIDList,ChuanYueHouIDList1 ");
            strSql.Append(" FROM ERPTelFile ");
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
                TitleStr = ds.Tables[0].Rows[0]["TitleStr"].ToString();
                FromUser = ds.Tables[0].Rows[0]["FromUser"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                FileType = ds.Tables[0].Rows[0]["FileType"].ToString();
                ToUser = ds.Tables[0].Rows[0]["ToUser"].ToString();
                YiJieShouRen = ds.Tables[0].Rows[0]["YiJieShouRen"].ToString();
                ContentStr = ds.Tables[0].Rows[0]["ContentStr"].ToString();
                FuJianStr = ds.Tables[0].Rows[0]["FuJianStr"].ToString();
                ChuanYueYiJian = ds.Tables[0].Rows[0]["ChuanYueYiJian"].ToString();
                QianShouHouIDList = ds.Tables[0].Rows[0]["QianShouHouIDList"].ToString();
                ChuanYueHouIDList1 = ds.Tables[0].Rows[0]["ChuanYueHouIDList1"].ToString();
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ERPTelFile ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

