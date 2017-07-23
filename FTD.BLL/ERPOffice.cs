using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPOffice。
    /// </summary>
    public class ERPOffice
    {
        public ERPOffice()
        { }
        #region Model
        private int _id;
        private string _officename;
        private string _miaoshu;
        private string _fujianstr;
        private string _typestr;
        private string _serils;
        private string _danwei;
        private string _danjia;
        private string _gongyingshang;
        private string _minnum;
        private string _maxnum;
        private string _nownum;
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
        /// 办公用品名称

        /// </summary>
        public string OfficeName
        {
            set { _officename = value; }
            get { return _officename; }
        }
        /// <summary>
        /// 办公用品描述
        /// </summary>
        public string MiaoShu
        {
            set { _miaoshu = value; }
            get { return _miaoshu; }
        }
        /// <summary>
        /// 附件上传
        /// </summary>
        public string FuJianStr
        {
            set { _fujianstr = value; }
            get { return _fujianstr; }
        }
        /// <summary>
        /// 办公用品类别
        /// </summary>
        public string TypeStr
        {
            set { _typestr = value; }
            get { return _typestr; }
        }
        /// <summary>
        /// 办公用品编码
        /// </summary>
        public string Serils
        {
            set { _serils = value; }
            get { return _serils; }
        }
        /// <summary>
        /// 计量单位
        /// </summary>
        public string DanWei
        {
            set { _danwei = value; }
            get { return _danwei; }
        }
        /// <summary>
        /// 单价
        /// </summary>
        public string DanJia
        {
            set { _danjia = value; }
            get { return _danjia; }
        }
        /// <summary>
        /// 供应商
        /// </summary>
        public string GongYingShang
        {
            set { _gongyingshang = value; }
            get { return _gongyingshang; }
        }
        /// <summary>
        /// 最低警戒库存
        /// </summary>
        public string MinNum
        {
            set { _minnum = value; }
            get { return _minnum; }
        }
        /// <summary>
        /// 最高警戒库存
        /// </summary>
        public string MaxNum
        {
            set { _maxnum = value; }
            get { return _maxnum; }
        }
        /// <summary>
        /// 当前库存
        /// </summary>
        public string NowNum
        {
            set { _nownum = value; }
            get { return _nownum; }
        }
        /// <summary>
        /// 创建人
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 创建时间
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
        public ERPOffice(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,OfficeName,MiaoShu,FuJianStr,TypeStr,Serils,DanWei,DanJia,GongYingShang,MinNum,MaxNum,NowNum,UserName,TimeStr ");
            strSql.Append(" FROM ERPOffice ");
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
                OfficeName = ds.Tables[0].Rows[0]["OfficeName"].ToString();
                MiaoShu = ds.Tables[0].Rows[0]["MiaoShu"].ToString();
                FuJianStr = ds.Tables[0].Rows[0]["FuJianStr"].ToString();
                TypeStr = ds.Tables[0].Rows[0]["TypeStr"].ToString();
                Serils = ds.Tables[0].Rows[0]["Serils"].ToString();
                DanWei = ds.Tables[0].Rows[0]["DanWei"].ToString();
                DanJia = ds.Tables[0].Rows[0]["DanJia"].ToString();
                GongYingShang = ds.Tables[0].Rows[0]["GongYingShang"].ToString();
                MinNum = ds.Tables[0].Rows[0]["MinNum"].ToString();
                MaxNum = ds.Tables[0].Rows[0]["MaxNum"].ToString();
                NowNum = ds.Tables[0].Rows[0]["NowNum"].ToString();
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
            strSql.Append("select count(1) from ERPOffice");
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
            strSql.Append("insert into ERPOffice(");
            strSql.Append("OfficeName,MiaoShu,FuJianStr,TypeStr,Serils,DanWei,DanJia,GongYingShang,MinNum,MaxNum,NowNum,UserName,TimeStr)");
            strSql.Append(" values (");
            strSql.Append("@OfficeName,@MiaoShu,@FuJianStr,@TypeStr,@Serils,@DanWei,@DanJia,@GongYingShang,@MinNum,@MaxNum,@NowNum,@UserName,@TimeStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@OfficeName", SqlDbType.VarChar,50),
					new SqlParameter("@MiaoShu", SqlDbType.VarChar,5000),
					new SqlParameter("@FuJianStr", SqlDbType.VarChar,500),
					new SqlParameter("@TypeStr", SqlDbType.VarChar,100),
					new SqlParameter("@Serils", SqlDbType.VarChar,100),
					new SqlParameter("@DanWei", SqlDbType.VarChar,50),
					new SqlParameter("@DanJia", SqlDbType.VarChar,50),
					new SqlParameter("@GongYingShang", SqlDbType.VarChar,100),
					new SqlParameter("@MinNum", SqlDbType.VarChar,50),
					new SqlParameter("@MaxNum", SqlDbType.VarChar,50),
					new SqlParameter("@NowNum", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = OfficeName;
            parameters[1].Value = MiaoShu;
            parameters[2].Value = FuJianStr;
            parameters[3].Value = TypeStr;
            parameters[4].Value = Serils;
            parameters[5].Value = DanWei;
            parameters[6].Value = DanJia;
            parameters[7].Value = GongYingShang;
            parameters[8].Value = MinNum;
            parameters[9].Value = MaxNum;
            parameters[10].Value = NowNum;
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
            strSql.Append("update ERPOffice set ");
            strSql.Append("OfficeName=@OfficeName,");
            strSql.Append("MiaoShu=@MiaoShu,");
            strSql.Append("FuJianStr=@FuJianStr,");
            strSql.Append("TypeStr=@TypeStr,");
            strSql.Append("Serils=@Serils,");
            strSql.Append("DanWei=@DanWei,");
            strSql.Append("DanJia=@DanJia,");
            strSql.Append("GongYingShang=@GongYingShang,");
            strSql.Append("MinNum=@MinNum,");
            strSql.Append("MaxNum=@MaxNum,");
            strSql.Append("NowNum=@NowNum,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TimeStr=@TimeStr");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@OfficeName", SqlDbType.VarChar,50),
					new SqlParameter("@MiaoShu", SqlDbType.VarChar,5000),
					new SqlParameter("@FuJianStr", SqlDbType.VarChar,500),
					new SqlParameter("@TypeStr", SqlDbType.VarChar,100),
					new SqlParameter("@Serils", SqlDbType.VarChar,100),
					new SqlParameter("@DanWei", SqlDbType.VarChar,50),
					new SqlParameter("@DanJia", SqlDbType.VarChar,50),
					new SqlParameter("@GongYingShang", SqlDbType.VarChar,100),
					new SqlParameter("@MinNum", SqlDbType.VarChar,50),
					new SqlParameter("@MaxNum", SqlDbType.VarChar,50),
					new SqlParameter("@NowNum", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = ID;
            parameters[1].Value = OfficeName;
            parameters[2].Value = MiaoShu;
            parameters[3].Value = FuJianStr;
            parameters[4].Value = TypeStr;
            parameters[5].Value = Serils;
            parameters[6].Value = DanWei;
            parameters[7].Value = DanJia;
            parameters[8].Value = GongYingShang;
            parameters[9].Value = MinNum;
            parameters[10].Value = MaxNum;
            parameters[11].Value = NowNum;
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
            strSql.Append("delete from ERPOffice ");
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
            strSql.Append("select  top 1 ID,OfficeName,MiaoShu,FuJianStr,TypeStr,Serils,DanWei,DanJia,GongYingShang,MinNum,MaxNum,NowNum,UserName,TimeStr ");
            strSql.Append(" FROM ERPOffice ");
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
                OfficeName = ds.Tables[0].Rows[0]["OfficeName"].ToString();
                MiaoShu = ds.Tables[0].Rows[0]["MiaoShu"].ToString();
                FuJianStr = ds.Tables[0].Rows[0]["FuJianStr"].ToString();
                TypeStr = ds.Tables[0].Rows[0]["TypeStr"].ToString();
                Serils = ds.Tables[0].Rows[0]["Serils"].ToString();
                DanWei = ds.Tables[0].Rows[0]["DanWei"].ToString();
                DanJia = ds.Tables[0].Rows[0]["DanJia"].ToString();
                GongYingShang = ds.Tables[0].Rows[0]["GongYingShang"].ToString();
                MinNum = ds.Tables[0].Rows[0]["MinNum"].ToString();
                MaxNum = ds.Tables[0].Rows[0]["MaxNum"].ToString();
                NowNum = ds.Tables[0].Rows[0]["NowNum"].ToString();
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
            strSql.Append(" FROM ERPOffice ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

