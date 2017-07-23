using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPTiKu。
    /// </summary>
    public class ERPTiKu
    {
        public ERPTiKu()
        { }
        #region Model
        private int _id;
        private string _titlestr;
        private string _itemsa;
        private string _itemsb;
        private string _itemsc;
        private string _itemsd;
        private string _itemse;
        private string _itemsf;
        private string _itemsg;
        private string _itemsh;
        private string _answerstr;
        private int? _tikuid;
        private string _fenleistr;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 题目标题
        /// </summary>
        public string TitleStr
        {
            set { _titlestr = value; }
            get { return _titlestr; }
        }
        /// <summary>
        /// A
        /// </summary>
        public string ItemsA
        {
            set { _itemsa = value; }
            get { return _itemsa; }
        }
        /// <summary>
        /// B
        /// </summary>
        public string ItemsB
        {
            set { _itemsb = value; }
            get { return _itemsb; }
        }
        /// <summary>
        /// C
        /// </summary>
        public string ItemsC
        {
            set { _itemsc = value; }
            get { return _itemsc; }
        }
        /// <summary>
        /// D
        /// </summary>
        public string ItemsD
        {
            set { _itemsd = value; }
            get { return _itemsd; }
        }
        /// <summary>
        /// E
        /// </summary>
        public string ItemsE
        {
            set { _itemse = value; }
            get { return _itemse; }
        }
        /// <summary>
        /// F
        /// </summary>
        public string ItemsF
        {
            set { _itemsf = value; }
            get { return _itemsf; }
        }
        /// <summary>
        /// G
        /// </summary>
        public string ItemsG
        {
            set { _itemsg = value; }
            get { return _itemsg; }
        }
        /// <summary>
        /// H
        /// </summary>
        public string ItemsH
        {
            set { _itemsh = value; }
            get { return _itemsh; }
        }
        /// <summary>
        /// 正确答案
        /// </summary>
        public string AnswerStr
        {
            set { _answerstr = value; }
            get { return _answerstr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? TiKuID
        {
            set { _tikuid = value; }
            get { return _tikuid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FenLeiStr
        {
            set { _fenleistr = value; }
            get { return _fenleistr; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPTiKu(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,TitleStr,ItemsA,ItemsB,ItemsC,ItemsD,ItemsE,ItemsF,ItemsG,ItemsH,AnswerStr,TiKuID,FenLeiStr ");
            strSql.Append(" FROM ERPTiKu ");
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
                ItemsA = ds.Tables[0].Rows[0]["ItemsA"].ToString();
                ItemsB = ds.Tables[0].Rows[0]["ItemsB"].ToString();
                ItemsC = ds.Tables[0].Rows[0]["ItemsC"].ToString();
                ItemsD = ds.Tables[0].Rows[0]["ItemsD"].ToString();
                ItemsE = ds.Tables[0].Rows[0]["ItemsE"].ToString();
                ItemsF = ds.Tables[0].Rows[0]["ItemsF"].ToString();
                ItemsG = ds.Tables[0].Rows[0]["ItemsG"].ToString();
                ItemsH = ds.Tables[0].Rows[0]["ItemsH"].ToString();
                AnswerStr = ds.Tables[0].Rows[0]["AnswerStr"].ToString();
                if (ds.Tables[0].Rows[0]["TiKuID"].ToString() != "")
                {
                    TiKuID = int.Parse(ds.Tables[0].Rows[0]["TiKuID"].ToString());
                }
                FenLeiStr = ds.Tables[0].Rows[0]["FenLeiStr"].ToString();
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPTiKu");
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
            strSql.Append("insert into ERPTiKu(");
            strSql.Append("TitleStr,ItemsA,ItemsB,ItemsC,ItemsD,ItemsE,ItemsF,ItemsG,ItemsH,AnswerStr,TiKuID,FenLeiStr)");
            strSql.Append(" values (");
            strSql.Append("@TitleStr,@ItemsA,@ItemsB,@ItemsC,@ItemsD,@ItemsE,@ItemsF,@ItemsG,@ItemsH,@AnswerStr,@TiKuID,@FenLeiStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@TitleStr", SqlDbType.VarChar,200),
					new SqlParameter("@ItemsA", SqlDbType.VarChar,200),
					new SqlParameter("@ItemsB", SqlDbType.VarChar,200),
					new SqlParameter("@ItemsC", SqlDbType.VarChar,200),
					new SqlParameter("@ItemsD", SqlDbType.VarChar,200),
					new SqlParameter("@ItemsE", SqlDbType.VarChar,200),
					new SqlParameter("@ItemsF", SqlDbType.VarChar,200),
					new SqlParameter("@ItemsG", SqlDbType.VarChar,200),
					new SqlParameter("@ItemsH", SqlDbType.VarChar,200),
					new SqlParameter("@AnswerStr", SqlDbType.VarChar,8000),
					new SqlParameter("@TiKuID", SqlDbType.Int,4),
					new SqlParameter("@FenLeiStr", SqlDbType.VarChar,20)};
            parameters[0].Value = TitleStr;
            parameters[1].Value = ItemsA;
            parameters[2].Value = ItemsB;
            parameters[3].Value = ItemsC;
            parameters[4].Value = ItemsD;
            parameters[5].Value = ItemsE;
            parameters[6].Value = ItemsF;
            parameters[7].Value = ItemsG;
            parameters[8].Value = ItemsH;
            parameters[9].Value = AnswerStr;
            parameters[10].Value = TiKuID;
            parameters[11].Value = FenLeiStr;

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
            strSql.Append("update ERPTiKu set ");
            strSql.Append("TitleStr=@TitleStr,");
            strSql.Append("ItemsA=@ItemsA,");
            strSql.Append("ItemsB=@ItemsB,");
            strSql.Append("ItemsC=@ItemsC,");
            strSql.Append("ItemsD=@ItemsD,");
            strSql.Append("ItemsE=@ItemsE,");
            strSql.Append("ItemsF=@ItemsF,");
            strSql.Append("ItemsG=@ItemsG,");
            strSql.Append("ItemsH=@ItemsH,");
            strSql.Append("AnswerStr=@AnswerStr,");
            strSql.Append("TiKuID=@TiKuID,");
            strSql.Append("FenLeiStr=@FenLeiStr");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@TitleStr", SqlDbType.VarChar,200),
					new SqlParameter("@ItemsA", SqlDbType.VarChar,200),
					new SqlParameter("@ItemsB", SqlDbType.VarChar,200),
					new SqlParameter("@ItemsC", SqlDbType.VarChar,200),
					new SqlParameter("@ItemsD", SqlDbType.VarChar,200),
					new SqlParameter("@ItemsE", SqlDbType.VarChar,200),
					new SqlParameter("@ItemsF", SqlDbType.VarChar,200),
					new SqlParameter("@ItemsG", SqlDbType.VarChar,200),
					new SqlParameter("@ItemsH", SqlDbType.VarChar,200),
					new SqlParameter("@AnswerStr", SqlDbType.VarChar,8000),
					new SqlParameter("@TiKuID", SqlDbType.Int,4),
					new SqlParameter("@FenLeiStr", SqlDbType.VarChar,20)};
            parameters[0].Value = ID;
            parameters[1].Value = TitleStr;
            parameters[2].Value = ItemsA;
            parameters[3].Value = ItemsB;
            parameters[4].Value = ItemsC;
            parameters[5].Value = ItemsD;
            parameters[6].Value = ItemsE;
            parameters[7].Value = ItemsF;
            parameters[8].Value = ItemsG;
            parameters[9].Value = ItemsH;
            parameters[10].Value = AnswerStr;
            parameters[11].Value = TiKuID;
            parameters[12].Value = FenLeiStr;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPTiKu ");
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
            strSql.Append("select  top 1 ID,TitleStr,ItemsA,ItemsB,ItemsC,ItemsD,ItemsE,ItemsF,ItemsG,ItemsH,AnswerStr,TiKuID,FenLeiStr ");
            strSql.Append(" FROM ERPTiKu ");
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
                ItemsA = ds.Tables[0].Rows[0]["ItemsA"].ToString();
                ItemsB = ds.Tables[0].Rows[0]["ItemsB"].ToString();
                ItemsC = ds.Tables[0].Rows[0]["ItemsC"].ToString();
                ItemsD = ds.Tables[0].Rows[0]["ItemsD"].ToString();
                ItemsE = ds.Tables[0].Rows[0]["ItemsE"].ToString();
                ItemsF = ds.Tables[0].Rows[0]["ItemsF"].ToString();
                ItemsG = ds.Tables[0].Rows[0]["ItemsG"].ToString();
                ItemsH = ds.Tables[0].Rows[0]["ItemsH"].ToString();
                AnswerStr = ds.Tables[0].Rows[0]["AnswerStr"].ToString();
                if (ds.Tables[0].Rows[0]["TiKuID"].ToString() != "")
                {
                    TiKuID = int.Parse(ds.Tables[0].Rows[0]["TiKuID"].ToString());
                }
                FenLeiStr = ds.Tables[0].Rows[0]["FenLeiStr"].ToString();
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ERPTiKu ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

