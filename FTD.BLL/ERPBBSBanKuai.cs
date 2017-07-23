using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPBBSBanKuai。
    /// </summary>
    public class ERPBBSBanKuai
    {
        public ERPBBSBanKuai()
        { }
        #region Model
        private int _id;
        private string _bankuainame;
        private string _banzhulist;
        private string _bankuaimiaoshu;
        private string _bankuaiimg;
        private string _jiaosexianzhilist;
        private string _bumenxianzhi;
        private string _userxianzhi;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 版块名称
        /// </summary>
        public string BanKuaiName
        {
            set { _bankuainame = value; }
            get { return _bankuainame; }
        }
        /// <summary>
        /// 版主列表
        /// </summary>
        public string BanZhuList
        {
            set { _banzhulist = value; }
            get { return _banzhulist; }
        }
        /// <summary>
        /// 版块描述
        /// </summary>
        public string BanKuaiMiaoShu
        {
            set { _bankuaimiaoshu = value; }
            get { return _bankuaimiaoshu; }
        }
        /// <summary>
        /// 版块图片
        /// </summary>
        public string BanKuaiImg
        {
            set { _bankuaiimg = value; }
            get { return _bankuaiimg; }
        }
        /// <summary>
        /// 限制允许哪些角色访问
        /// </summary>
        public string JiaoSeXianZhiList
        {
            set { _jiaosexianzhilist = value; }
            get { return _jiaosexianzhilist; }
        }
        /// <summary>
        /// 限制只允许哪些部门访问
        /// </summary>
        public string BuMenXianZhi
        {
            set { _bumenxianzhi = value; }
            get { return _bumenxianzhi; }
        }
        /// <summary>
        /// 限制只允许哪些用户访问
        /// </summary>
        public string UserXianZhi
        {
            set { _userxianzhi = value; }
            get { return _userxianzhi; }
        }
        #endregion Model


        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPBBSBanKuai");
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
            strSql.Append("insert into ERPBBSBanKuai(");
            strSql.Append("BanKuaiName,BanZhuList,BanKuaiMiaoShu,BanKuaiImg,JiaoSeXianZhiList,BuMenXianZhi,UserXianZhi)");
            strSql.Append(" values (");
            strSql.Append("@BanKuaiName,@BanZhuList,@BanKuaiMiaoShu,@BanKuaiImg,@JiaoSeXianZhiList,@BuMenXianZhi,@UserXianZhi)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@BanKuaiName", SqlDbType.VarChar,500),
					new SqlParameter("@BanZhuList", SqlDbType.VarChar,500),
					new SqlParameter("@BanKuaiMiaoShu", SqlDbType.VarChar,8000),
					new SqlParameter("@BanKuaiImg", SqlDbType.VarChar,200),
					new SqlParameter("@JiaoSeXianZhiList", SqlDbType.VarChar,8000),
					new SqlParameter("@BuMenXianZhi", SqlDbType.VarChar,8000),
					new SqlParameter("@UserXianZhi", SqlDbType.VarChar,8000)};
            parameters[0].Value = BanKuaiName;
            parameters[1].Value = BanZhuList;
            parameters[2].Value = BanKuaiMiaoShu;
            parameters[3].Value = BanKuaiImg;
            parameters[4].Value = JiaoSeXianZhiList;
            parameters[5].Value = BuMenXianZhi;
            parameters[6].Value = UserXianZhi;

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
            strSql.Append("update ERPBBSBanKuai set ");
            strSql.Append("BanKuaiName=@BanKuaiName,");
            strSql.Append("BanZhuList=@BanZhuList,");
            strSql.Append("BanKuaiMiaoShu=@BanKuaiMiaoShu,");
            strSql.Append("BanKuaiImg=@BanKuaiImg,");
            strSql.Append("JiaoSeXianZhiList=@JiaoSeXianZhiList,");
            strSql.Append("BuMenXianZhi=@BuMenXianZhi,");
            strSql.Append("UserXianZhi=@UserXianZhi");
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@BanKuaiName", SqlDbType.VarChar,500),
					new SqlParameter("@BanZhuList", SqlDbType.VarChar,500),
					new SqlParameter("@BanKuaiMiaoShu", SqlDbType.VarChar,8000),
					new SqlParameter("@BanKuaiImg", SqlDbType.VarChar,200),
					new SqlParameter("@JiaoSeXianZhiList", SqlDbType.VarChar,8000),
					new SqlParameter("@BuMenXianZhi", SqlDbType.VarChar,8000),
					new SqlParameter("@UserXianZhi", SqlDbType.VarChar,8000)};
            parameters[0].Value = ID;
            parameters[1].Value = BanKuaiName;
            parameters[2].Value = BanZhuList;
            parameters[3].Value = BanKuaiMiaoShu;
            parameters[4].Value = BanKuaiImg;
            parameters[5].Value = JiaoSeXianZhiList;
            parameters[6].Value = BuMenXianZhi;
            parameters[7].Value = UserXianZhi;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPBBSBanKuai ");
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
            strSql.Append("select ID,BanKuaiName,BanZhuList,BanKuaiMiaoShu,BanKuaiImg,JiaoSeXianZhiList,BuMenXianZhi,UserXianZhi ");
            strSql.Append(" FROM ERPBBSBanKuai ");
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
                BanKuaiName = ds.Tables[0].Rows[0]["BanKuaiName"].ToString();
                BanZhuList = ds.Tables[0].Rows[0]["BanZhuList"].ToString();
                BanKuaiMiaoShu = ds.Tables[0].Rows[0]["BanKuaiMiaoShu"].ToString();
                BanKuaiImg = ds.Tables[0].Rows[0]["BanKuaiImg"].ToString();
                JiaoSeXianZhiList = ds.Tables[0].Rows[0]["JiaoSeXianZhiList"].ToString();
                BuMenXianZhi = ds.Tables[0].Rows[0]["BuMenXianZhi"].ToString();
                UserXianZhi = ds.Tables[0].Rows[0]["UserXianZhi"].ToString();
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ID],[BanKuaiName],[BanZhuList],[BanKuaiMiaoShu],[BanKuaiImg],[JiaoSeXianZhiList],[BuMenXianZhi],[UserXianZhi] ");
            strSql.Append(" FROM ERPBBSBanKuai ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}