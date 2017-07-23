using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPBBSTieZi。
    /// </summary>
    public class ERPBBSTieZi
    {
        public ERPBBSTieZi()
        { }
        #region Model
        private int _id;
        private int? _bankuaiid;
        private string _titlestr;
        private string _username;
        private DateTime? _timestr;
        private string _contentstr;
        private string _zuihouuser;
        private DateTime? _zuihoutime;
        private int? _paixu;
        private string _huifucontent;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 版块ID
        /// </summary>
        public int? BanKuaiID
        {
            set { _bankuaiid = value; }
            get { return _bankuaiid; }
        }
        /// <summary>
        /// 帖子标题
        /// </summary>
        public string TitleStr
        {
            set { _titlestr = value; }
            get { return _titlestr; }
        }
        /// <summary>
        /// 发布人
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime? TimeStr
        {
            set { _timestr = value; }
            get { return _timestr; }
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
        /// 最后发布人
        /// </summary>
        public string ZuiHouUser
        {
            set { _zuihouuser = value; }
            get { return _zuihouuser; }
        }
        /// <summary>
        /// 最后发布时间
        /// </summary>
        public DateTime? ZuiHouTime
        {
            set { _zuihoutime = value; }
            get { return _zuihoutime; }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public int? PaiXu
        {
            set { _paixu = value; }
            get { return _paixu; }
        }
        /// <summary>
        /// 回复内容
        /// </summary>
        public string HuiFuContent
        {
            set { _huifucontent = value; }
            get { return _huifucontent; }
        }
        #endregion Model


        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPBBSTieZi");
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
            strSql.Append("insert into ERPBBSTieZi(");
            strSql.Append("BanKuaiID,TitleStr,UserName,TimeStr,ContentStr,ZuiHouUser,ZuiHouTime,PaiXu,HuiFuContent)");
            strSql.Append(" values (");
            strSql.Append("@BanKuaiID,@TitleStr,@UserName,@TimeStr,@ContentStr,@ZuiHouUser,@ZuiHouTime,@PaiXu,@HuiFuContent)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@BanKuaiID", SqlDbType.Int,4),
					new SqlParameter("@TitleStr", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@ContentStr", SqlDbType.Text),
					new SqlParameter("@ZuiHouUser", SqlDbType.VarChar,50),
					new SqlParameter("@ZuiHouTime", SqlDbType.DateTime),
					new SqlParameter("@PaiXu", SqlDbType.Int,4),
					new SqlParameter("@HuiFuContent", SqlDbType.Text)};
            parameters[0].Value = BanKuaiID;
            parameters[1].Value = TitleStr;
            parameters[2].Value = UserName;
            parameters[3].Value = TimeStr;
            parameters[4].Value = ContentStr;
            parameters[5].Value = ZuiHouUser;
            parameters[6].Value = ZuiHouTime;
            parameters[7].Value = PaiXu;
            parameters[8].Value = HuiFuContent;

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
            strSql.Append("update ERPBBSTieZi set ");            
            strSql.Append("TitleStr=@TitleStr,");            
            strSql.Append("ContentStr=@ContentStr");            
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),					
					new SqlParameter("@TitleStr", SqlDbType.VarChar,500),					
					new SqlParameter("@ContentStr", SqlDbType.Text)};
            parameters[0].Value = ID;            
            parameters[1].Value = TitleStr;            
            parameters[2].Value = ContentStr;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPBBSTieZi ");
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
            strSql.Append("select ID,BanKuaiID,TitleStr,UserName,TimeStr,ContentStr,ZuiHouUser,ZuiHouTime,PaiXu,HuiFuContent ");
            strSql.Append(" FROM ERPBBSTieZi ");
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
                if (ds.Tables[0].Rows[0]["BanKuaiID"].ToString() != "")
                {
                    BanKuaiID = int.Parse(ds.Tables[0].Rows[0]["BanKuaiID"].ToString());
                }
                TitleStr = ds.Tables[0].Rows[0]["TitleStr"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                ContentStr = ds.Tables[0].Rows[0]["ContentStr"].ToString();
                ZuiHouUser = ds.Tables[0].Rows[0]["ZuiHouUser"].ToString();
                if (ds.Tables[0].Rows[0]["ZuiHouTime"].ToString() != "")
                {
                    ZuiHouTime = DateTime.Parse(ds.Tables[0].Rows[0]["ZuiHouTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PaiXu"].ToString() != "")
                {
                    PaiXu = int.Parse(ds.Tables[0].Rows[0]["PaiXu"].ToString());
                }
                HuiFuContent = ds.Tables[0].Rows[0]["HuiFuContent"].ToString();
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ID],[BanKuaiID],[TitleStr],[UserName],[TimeStr],[ContentStr],[ZuiHouUser],[ZuiHouTime],[PaiXu],[HuiFuContent] ");
            strSql.Append(" FROM ERPBBSTieZi ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}