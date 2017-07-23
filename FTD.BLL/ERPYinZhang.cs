using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPYinZhang。
    /// </summary>
    public class ERPYinZhang
    {
        public ERPYinZhang()
        { }
        #region Model
        private int _id;
        private string _yinzhangname;
        private string _yinzhangleibie;
        private string _yinzhangmima;
        private string _username;
        private string _imgpath;
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
        /// 
        /// </summary>
        public string YinZhangName
        {
            set { _yinzhangname = value; }
            get { return _yinzhangname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string YinZhangLeiBie
        {
            set { _yinzhangleibie = value; }
            get { return _yinzhangleibie; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string YinZhangMiMa
        {
            set { _yinzhangmima = value; }
            get { return _yinzhangmima; }
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
        public string ImgPath
        {
            set { _imgpath = value; }
            get { return _imgpath; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? TimeStr
        {
            set { _timestr = value; }
            get { return _timestr; }
        }
        #endregion Model


        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPYinZhang");
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
            strSql.Append("insert into ERPYinZhang(");
            strSql.Append("YinZhangName,YinZhangLeiBie,YinZhangMiMa,UserName,ImgPath,TimeStr)");
            strSql.Append(" values (");
            strSql.Append("@YinZhangName,@YinZhangLeiBie,@YinZhangMiMa,@UserName,@ImgPath,@TimeStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@YinZhangName", SqlDbType.VarChar,50),
					new SqlParameter("@YinZhangLeiBie", SqlDbType.VarChar,50),
					new SqlParameter("@YinZhangMiMa", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@ImgPath", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = YinZhangName;
            parameters[1].Value = YinZhangLeiBie;
            parameters[2].Value = YinZhangMiMa;
            parameters[3].Value = UserName;
            parameters[4].Value = ImgPath;
            parameters[5].Value = TimeStr;

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
            strSql.Append("update ERPYinZhang set ");
            strSql.Append("YinZhangName=@YinZhangName,");
            strSql.Append("YinZhangLeiBie=@YinZhangLeiBie,");
            strSql.Append("YinZhangMiMa=@YinZhangMiMa,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("ImgPath=@ImgPath,");
            strSql.Append("TimeStr=@TimeStr");
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@YinZhangName", SqlDbType.VarChar,50),
					new SqlParameter("@YinZhangLeiBie", SqlDbType.VarChar,50),
					new SqlParameter("@YinZhangMiMa", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@ImgPath", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = ID;
            parameters[1].Value = YinZhangName;
            parameters[2].Value = YinZhangLeiBie;
            parameters[3].Value = YinZhangMiMa;
            parameters[4].Value = UserName;
            parameters[5].Value = ImgPath;
            parameters[6].Value = TimeStr;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPYinZhang ");
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
            strSql.Append("select ID,YinZhangName,YinZhangLeiBie,YinZhangMiMa,UserName,ImgPath,TimeStr ");
            strSql.Append(" FROM ERPYinZhang ");
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
                YinZhangName = ds.Tables[0].Rows[0]["YinZhangName"].ToString();
                YinZhangLeiBie = ds.Tables[0].Rows[0]["YinZhangLeiBie"].ToString();
                YinZhangMiMa = ds.Tables[0].Rows[0]["YinZhangMiMa"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                ImgPath = ds.Tables[0].Rows[0]["ImgPath"].ToString();
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
            strSql.Append("select [ID],[YinZhangName],[YinZhangLeiBie],[YinZhangMiMa],[UserName],[ImgPath],[TimeStr] ");
            strSql.Append(" FROM ERPYinZhang ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}