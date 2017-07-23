using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPTreeList。
    /// </summary>
    public class ERPTreeList
    {
        public ERPTreeList()
        { }
        #region Model
        private int _id;
        private string _textstr;
        private string _imageurlstr;
        private string _valuestr;
        private string _parentclass;
        private string _navigateurlstr;
        private string _target;
        private int? _parentid;
        private string _quanxianlist;
        private int? _paixustr;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 显示文字
        /// </summary>
        public string TextStr
        {
            set { _textstr = value; }
            get { return _textstr; }
        }
        /// <summary>
        /// 所用图片
        /// </summary>
        public string ImageUrlStr
        {
            set { _imageurlstr = value; }
            get { return _imageurlstr; }
        }
        /// <summary>
        /// 主菜单样式
        /// </summary>
        public string ParentClass
        {
            set { _parentclass = value; }
            get { return _parentclass; }
        }
        /// <summary>
        /// 后台数值
        /// </summary>
        public string ValueStr
        {
            set { _valuestr = value; }
            get { return _valuestr; }
        }
        /// <summary>
        /// 链接地址
        /// </summary>
        public string NavigateUrlStr
        {
            set { _navigateurlstr = value; }
            get { return _navigateurlstr; }
        }
        /// <summary>
        /// 目标框架
        /// </summary>
        public string Target
        {
            set { _target = value; }
            get { return _target; }
        }
        /// <summary>
        /// 父节点
        /// </summary>
        public int? ParentID
        {
            set { _parentid = value; }
            get { return _parentid; }
        }
        /// <summary>
        /// 权限： 021A_添加|021M_修改|021D_删除|021E_导出
        /// </summary>
        public string QuanXianList
        {
            set { _quanxianlist = value; }
            get { return _quanxianlist; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PaiXuStr
        {
            set { _paixustr = value; }
            get { return _paixustr; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPTreeList(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,TextStr,ImageUrlStr,ParentClass,ValueStr,NavigateUrlStr,Target,ParentID,QuanXianList,PaiXuStr ");
            strSql.Append(" FROM ERPTreeList ");
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
                TextStr = ds.Tables[0].Rows[0]["TextStr"].ToString();
                ImageUrlStr = ds.Tables[0].Rows[0]["ImageUrlStr"].ToString();
                ParentClass = ds.Tables[0].Rows[0]["ParentClass"].ToString();
                ValueStr = ds.Tables[0].Rows[0]["ValueStr"].ToString();
                NavigateUrlStr = ds.Tables[0].Rows[0]["NavigateUrlStr"].ToString();
                Target = ds.Tables[0].Rows[0]["Target"].ToString();
                if (ds.Tables[0].Rows[0]["ParentID"].ToString() != "")
                {
                    ParentID = int.Parse(ds.Tables[0].Rows[0]["ParentID"].ToString());
                }
                QuanXianList = ds.Tables[0].Rows[0]["QuanXianList"].ToString();
                if (ds.Tables[0].Rows[0]["PaiXuStr"].ToString() != "")
                {
                    PaiXuStr = int.Parse(ds.Tables[0].Rows[0]["PaiXuStr"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPTreeList");
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
            strSql.Append("insert into ERPTreeList(");
            strSql.Append("TextStr,ImageUrlStr,ParentClass,ValueStr,NavigateUrlStr,Target,ParentID,QuanXianList,PaiXuStr)");
            strSql.Append(" values (");
            strSql.Append("@TextStr,@ImageUrlStr,@ParentClass,@ValueStr,@NavigateUrlStr,@Target,@ParentID,@QuanXianList,@PaiXuStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@TextStr", SqlDbType.VarChar,50),
					new SqlParameter("@ImageUrlStr", SqlDbType.VarChar,200),
                    new SqlParameter("@ParentClass", SqlDbType.NVarChar,50),
					new SqlParameter("@ValueStr", SqlDbType.VarChar,50),
					new SqlParameter("@NavigateUrlStr", SqlDbType.VarChar,200),
					new SqlParameter("@Target", SqlDbType.VarChar,50),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@QuanXianList", SqlDbType.VarChar,200),
					new SqlParameter("@PaiXuStr", SqlDbType.Int,4)};
            parameters[0].Value = TextStr;
            parameters[1].Value = ImageUrlStr;
            parameters[2].Value = ParentClass;
            parameters[3].Value = ValueStr;
            parameters[4].Value = NavigateUrlStr;
            parameters[5].Value = Target;
            parameters[6].Value = ParentID;
            parameters[7].Value = QuanXianList;
            parameters[8].Value = PaiXuStr;

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
            strSql.Append("update ERPTreeList set ");
            strSql.Append("TextStr=@TextStr,");
            strSql.Append("ImageUrlStr=@ImageUrlStr,");
            strSql.Append("ParentClass=@ParentClass,");
            strSql.Append("ValueStr=@ValueStr,");
            strSql.Append("NavigateUrlStr=@NavigateUrlStr,");
            strSql.Append("Target=@Target,");
            strSql.Append("ParentID=@ParentID,");
            strSql.Append("QuanXianList=@QuanXianList,");
            strSql.Append("PaiXuStr=@PaiXuStr");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@TextStr", SqlDbType.VarChar,50),
					new SqlParameter("@ImageUrlStr", SqlDbType.VarChar,200),
                    new SqlParameter("@ParentClass", SqlDbType.NVarChar,50),
					new SqlParameter("@ValueStr", SqlDbType.VarChar,50),
					new SqlParameter("@NavigateUrlStr", SqlDbType.VarChar,200),
					new SqlParameter("@Target", SqlDbType.VarChar,50),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@QuanXianList", SqlDbType.VarChar,200),
					new SqlParameter("@PaiXuStr", SqlDbType.Int,4)};
            parameters[0].Value = ID;
            parameters[1].Value = TextStr;
            parameters[2].Value = ImageUrlStr;
            parameters[3].Value = ParentClass;
            parameters[4].Value = ValueStr;
            parameters[5].Value = NavigateUrlStr;
            parameters[6].Value = Target;
            parameters[7].Value = ParentID;
            parameters[8].Value = QuanXianList;
            parameters[9].Value = PaiXuStr;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPTreeList ");
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
            strSql.Append("select  top 1 ID,TextStr,ImageUrlStr,ParentClass,ValueStr,NavigateUrlStr,Target,ParentID,QuanXianList,PaiXuStr ");
            strSql.Append(" FROM ERPTreeList ");
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
                TextStr = ds.Tables[0].Rows[0]["TextStr"].ToString();
                ImageUrlStr = ds.Tables[0].Rows[0]["ImageUrlStr"].ToString();
                ParentClass = ds.Tables[0].Rows[0]["ParentClass"].ToString();
                ValueStr = ds.Tables[0].Rows[0]["ValueStr"].ToString();
                NavigateUrlStr = ds.Tables[0].Rows[0]["NavigateUrlStr"].ToString();
                Target = ds.Tables[0].Rows[0]["Target"].ToString();
                if (ds.Tables[0].Rows[0]["ParentID"].ToString() != "")
                {
                    ParentID = int.Parse(ds.Tables[0].Rows[0]["ParentID"].ToString());
                }
                QuanXianList = ds.Tables[0].Rows[0]["QuanXianList"].ToString();
                if (ds.Tables[0].Rows[0]["PaiXuStr"].ToString() != "")
                {
                    PaiXuStr = int.Parse(ds.Tables[0].Rows[0]["PaiXuStr"].ToString());
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
            strSql.Append(" FROM ERPTreeList ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

