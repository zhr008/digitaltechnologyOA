using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPDanWeiInfo。
    /// </summary>
    public class ERPDanWeiInfo
    {
        public ERPDanWeiInfo()
        { }
        #region Model
        private int _id;
        private string _danweiname;
        private string _tel;
        private string _fax;
        private string _youbian;
        private string _address;
        private string _weburl;
        private string _email;
        private string _kaihuhang;
        private string _zhanghao;
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
        public string DanWeiName
        {
            set { _danweiname = value; }
            get { return _danweiname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Tel
        {
            set { _tel = value; }
            get { return _tel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Fax
        {
            set { _fax = value; }
            get { return _fax; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string YouBian
        {
            set { _youbian = value; }
            get { return _youbian; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WebUrl
        {
            set { _weburl = value; }
            get { return _weburl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string KaiHuHang
        {
            set { _kaihuhang = value; }
            get { return _kaihuhang; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZhangHao
        {
            set { _zhanghao = value; }
            get { return _zhanghao; }
        }
        #endregion Model


        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPDanWeiInfo");
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
            strSql.Append("insert into ERPDanWeiInfo(");
            strSql.Append("DanWeiName,Tel,Fax,YouBian,Address,WebUrl,Email,KaiHuHang,ZhangHao)");
            strSql.Append(" values (");
            strSql.Append("@DanWeiName,@Tel,@Fax,@YouBian,@Address,@WebUrl,@Email,@KaiHuHang,@ZhangHao)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@DanWeiName", SqlDbType.VarChar,100),
					new SqlParameter("@Tel", SqlDbType.VarChar,100),
					new SqlParameter("@Fax", SqlDbType.VarChar,100),
					new SqlParameter("@YouBian", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@WebUrl", SqlDbType.VarChar,200),
					new SqlParameter("@Email", SqlDbType.VarChar,100),
					new SqlParameter("@KaiHuHang", SqlDbType.VarChar,100),
					new SqlParameter("@ZhangHao", SqlDbType.VarChar,100)};
            parameters[0].Value = DanWeiName;
            parameters[1].Value = Tel;
            parameters[2].Value = Fax;
            parameters[3].Value = YouBian;
            parameters[4].Value = Address;
            parameters[5].Value = WebUrl;
            parameters[6].Value = Email;
            parameters[7].Value = KaiHuHang;
            parameters[8].Value = ZhangHao;

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
            strSql.Append("update ERPDanWeiInfo set ");
            strSql.Append("DanWeiName=@DanWeiName,");
            strSql.Append("Tel=@Tel,");
            strSql.Append("Fax=@Fax,");
            strSql.Append("YouBian=@YouBian,");
            strSql.Append("Address=@Address,");
            strSql.Append("WebUrl=@WebUrl,");
            strSql.Append("Email=@Email,");
            strSql.Append("KaiHuHang=@KaiHuHang,");
            strSql.Append("ZhangHao=@ZhangHao");            
            SqlParameter[] parameters = {					
					new SqlParameter("@DanWeiName", SqlDbType.VarChar,100),
					new SqlParameter("@Tel", SqlDbType.VarChar,100),
					new SqlParameter("@Fax", SqlDbType.VarChar,100),
					new SqlParameter("@YouBian", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@WebUrl", SqlDbType.VarChar,200),
					new SqlParameter("@Email", SqlDbType.VarChar,100),
					new SqlParameter("@KaiHuHang", SqlDbType.VarChar,100),
					new SqlParameter("@ZhangHao", SqlDbType.VarChar,100)};           
            parameters[0].Value = DanWeiName;
            parameters[1].Value = Tel;
            parameters[2].Value = Fax;
            parameters[3].Value = YouBian;
            parameters[4].Value = Address;
            parameters[5].Value = WebUrl;
            parameters[6].Value = Email;
            parameters[7].Value = KaiHuHang;
            parameters[8].Value = ZhangHao;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPDanWeiInfo ");
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
            strSql.Append("select ID,DanWeiName,Tel,Fax,YouBian,Address,WebUrl,Email,KaiHuHang,ZhangHao ");
            strSql.Append(" FROM ERPDanWeiInfo ");
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
                DanWeiName = ds.Tables[0].Rows[0]["DanWeiName"].ToString();
                Tel = ds.Tables[0].Rows[0]["Tel"].ToString();
                Fax = ds.Tables[0].Rows[0]["Fax"].ToString();
                YouBian = ds.Tables[0].Rows[0]["YouBian"].ToString();
                Address = ds.Tables[0].Rows[0]["Address"].ToString();
                WebUrl = ds.Tables[0].Rows[0]["WebUrl"].ToString();
                Email = ds.Tables[0].Rows[0]["Email"].ToString();
                KaiHuHang = ds.Tables[0].Rows[0]["KaiHuHang"].ToString();
                ZhangHao = ds.Tables[0].Rows[0]["ZhangHao"].ToString();
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,DanWeiName,Tel,Fax,YouBian,Address,WebUrl,Email,KaiHuHang,ZhangHao ");
            strSql.Append(" FROM ERPDanWeiInfo ");            
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
                DanWeiName = ds.Tables[0].Rows[0]["DanWeiName"].ToString();
                Tel = ds.Tables[0].Rows[0]["Tel"].ToString();
                Fax = ds.Tables[0].Rows[0]["Fax"].ToString();
                YouBian = ds.Tables[0].Rows[0]["YouBian"].ToString();
                Address = ds.Tables[0].Rows[0]["Address"].ToString();
                WebUrl = ds.Tables[0].Rows[0]["WebUrl"].ToString();
                Email = ds.Tables[0].Rows[0]["Email"].ToString();
                KaiHuHang = ds.Tables[0].Rows[0]["KaiHuHang"].ToString();
                ZhangHao = ds.Tables[0].Rows[0]["ZhangHao"].ToString();
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ID],[DanWeiName],[Tel],[Fax],[YouBian],[Address],[WebUrl],[Email],[KaiHuHang],[ZhangHao] ");
            strSql.Append(" FROM ERPDanWeiInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}