using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPProject。
    /// </summary>
    public class ERPProject
    {
        public ERPProject()
        { }
        #region Model
        private int _id;
        private string _projectname;
        private string _projectserils;
        private string _suoshukehu;
        private string _yujichengjiaoriqi;
        private string _tixingdate;
        private string _fuzeren;
        private string _xiangmujine;
        private string _xiangmuyusuan;
        private string _xiangmudaxiao;
        private string _peiherenlist;
        private string _username;
        private DateTime? _timestr;
        private string _hetongandfujian;
        private string _backinfo;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ProjectName
        {
            set { _projectname = value; }
            get { return _projectname; }
        }
        /// <summary>
        /// 项目编号
        /// </summary>
        public string ProjectSerils
        {
            set { _projectserils = value; }
            get { return _projectserils; }
        }
        /// <summary>
        /// 所属客户
        /// </summary>
        public string SuoShuKeHu
        {
            set { _suoshukehu = value; }
            get { return _suoshukehu; }
        }
        /// <summary>
        /// 预计成交日期
        /// </summary>
        public string YuJiChengJiaoRiQi
        {
            set { _yujichengjiaoriqi = value; }
            get { return _yujichengjiaoriqi; }
        }
        /// <summary>
        /// 提醒日期
        /// </summary>
        public string TiXingDate
        {
            set { _tixingdate = value; }
            get { return _tixingdate; }
        }
        /// <summary>
        /// 负责人
        /// </summary>
        public string FuZeRen
        {
            set { _fuzeren = value; }
            get { return _fuzeren; }
        }
        /// <summary>
        /// 项目金额
        /// </summary>
        public string XiangMuJinE
        {
            set { _xiangmujine = value; }
            get { return _xiangmujine; }
        }
        /// <summary>
        /// 项目预算
        /// </summary>
        public string XiangMuYuSuan
        {
            set { _xiangmuyusuan = value; }
            get { return _xiangmuyusuan; }
        }
        /// <summary>
        /// 项目大小
        /// </summary>
        public string XiangMuDaXiao
        {
            set { _xiangmudaxiao = value; }
            get { return _xiangmudaxiao; }
        }
        /// <summary>
        /// 项目配合人
        /// </summary>
        public string PeiHeRenList
        {
            set { _peiherenlist = value; }
            get { return _peiherenlist; }
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
        /// 更新时间
        /// </summary>
        public DateTime? TimeStr
        {
            set { _timestr = value; }
            get { return _timestr; }
        }
        /// <summary>
        /// 合同以及附件
        /// </summary>
        public string HeTongAndFuJian
        {
            set { _hetongandfujian = value; }
            get { return _hetongandfujian; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BackInfo
        {
            set { _backinfo = value; }
            get { return _backinfo; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPProject(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,ProjectName,ProjectSerils,SuoShuKeHu,YuJiChengJiaoRiQi,TiXingDate,FuZeRen,XiangMuJinE,XiangMuYuSuan,XiangMuDaXiao,PeiHeRenList,UserName,TimeStr,HeTongAndFuJian,BackInfo ");
            strSql.Append(" FROM ERPProject ");
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
                SuoShuKeHu = ds.Tables[0].Rows[0]["SuoShuKeHu"].ToString();
                YuJiChengJiaoRiQi = ds.Tables[0].Rows[0]["YuJiChengJiaoRiQi"].ToString();
                TiXingDate = ds.Tables[0].Rows[0]["TiXingDate"].ToString();
                FuZeRen = ds.Tables[0].Rows[0]["FuZeRen"].ToString();
                XiangMuJinE = ds.Tables[0].Rows[0]["XiangMuJinE"].ToString();
                XiangMuYuSuan = ds.Tables[0].Rows[0]["XiangMuYuSuan"].ToString();
                XiangMuDaXiao = ds.Tables[0].Rows[0]["XiangMuDaXiao"].ToString();
                PeiHeRenList = ds.Tables[0].Rows[0]["PeiHeRenList"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                HeTongAndFuJian = ds.Tables[0].Rows[0]["HeTongAndFuJian"].ToString();
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPProject");
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
            strSql.Append("insert into ERPProject(");
            strSql.Append("ProjectName,ProjectSerils,SuoShuKeHu,YuJiChengJiaoRiQi,TiXingDate,FuZeRen,XiangMuJinE,XiangMuYuSuan,XiangMuDaXiao,PeiHeRenList,UserName,TimeStr,HeTongAndFuJian,BackInfo)");
            strSql.Append(" values (");
            strSql.Append("@ProjectName,@ProjectSerils,@SuoShuKeHu,@YuJiChengJiaoRiQi,@TiXingDate,@FuZeRen,@XiangMuJinE,@XiangMuYuSuan,@XiangMuDaXiao,@PeiHeRenList,@UserName,@TimeStr,@HeTongAndFuJian,@BackInfo)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ProjectName", SqlDbType.VarChar,200),
					new SqlParameter("@ProjectSerils", SqlDbType.VarChar,50),
					new SqlParameter("@SuoShuKeHu", SqlDbType.VarChar,200),
					new SqlParameter("@YuJiChengJiaoRiQi", SqlDbType.VarChar,50),
					new SqlParameter("@TiXingDate", SqlDbType.VarChar,5000),
					new SqlParameter("@FuZeRen", SqlDbType.VarChar,50),
					new SqlParameter("@XiangMuJinE", SqlDbType.VarChar,200),
					new SqlParameter("@XiangMuYuSuan", SqlDbType.VarChar,200),
					new SqlParameter("@XiangMuDaXiao", SqlDbType.VarChar,50),
					new SqlParameter("@PeiHeRenList", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@HeTongAndFuJian", SqlDbType.VarChar,5000),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
            parameters[0].Value = ProjectName;
            parameters[1].Value = ProjectSerils;
            parameters[2].Value = SuoShuKeHu;
            parameters[3].Value = YuJiChengJiaoRiQi;
            parameters[4].Value = TiXingDate;
            parameters[5].Value = FuZeRen;
            parameters[6].Value = XiangMuJinE;
            parameters[7].Value = XiangMuYuSuan;
            parameters[8].Value = XiangMuDaXiao;
            parameters[9].Value = PeiHeRenList;
            parameters[10].Value = UserName;
            parameters[11].Value = TimeStr;
            parameters[12].Value = HeTongAndFuJian;
            parameters[13].Value = BackInfo;

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
            strSql.Append("update ERPProject set ");
            strSql.Append("ProjectName=@ProjectName,");
            strSql.Append("ProjectSerils=@ProjectSerils,");
            strSql.Append("SuoShuKeHu=@SuoShuKeHu,");
            strSql.Append("YuJiChengJiaoRiQi=@YuJiChengJiaoRiQi,");
            strSql.Append("TiXingDate=@TiXingDate,");
            strSql.Append("FuZeRen=@FuZeRen,");
            strSql.Append("XiangMuJinE=@XiangMuJinE,");
            strSql.Append("XiangMuYuSuan=@XiangMuYuSuan,");
            strSql.Append("XiangMuDaXiao=@XiangMuDaXiao,");
            strSql.Append("PeiHeRenList=@PeiHeRenList,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TimeStr=@TimeStr,");
            strSql.Append("HeTongAndFuJian=@HeTongAndFuJian,");
            strSql.Append("BackInfo=@BackInfo");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@ProjectName", SqlDbType.VarChar,200),
					new SqlParameter("@ProjectSerils", SqlDbType.VarChar,50),
					new SqlParameter("@SuoShuKeHu", SqlDbType.VarChar,200),
					new SqlParameter("@YuJiChengJiaoRiQi", SqlDbType.VarChar,50),
					new SqlParameter("@TiXingDate", SqlDbType.VarChar,5000),
					new SqlParameter("@FuZeRen", SqlDbType.VarChar,50),
					new SqlParameter("@XiangMuJinE", SqlDbType.VarChar,200),
					new SqlParameter("@XiangMuYuSuan", SqlDbType.VarChar,200),
					new SqlParameter("@XiangMuDaXiao", SqlDbType.VarChar,50),
					new SqlParameter("@PeiHeRenList", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@HeTongAndFuJian", SqlDbType.VarChar,5000),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
            parameters[0].Value = ID;
            parameters[1].Value = ProjectName;
            parameters[2].Value = ProjectSerils;
            parameters[3].Value = SuoShuKeHu;
            parameters[4].Value = YuJiChengJiaoRiQi;
            parameters[5].Value = TiXingDate;
            parameters[6].Value = FuZeRen;
            parameters[7].Value = XiangMuJinE;
            parameters[8].Value = XiangMuYuSuan;
            parameters[9].Value = XiangMuDaXiao;
            parameters[10].Value = PeiHeRenList;
            parameters[11].Value = UserName;
            parameters[12].Value = TimeStr;
            parameters[13].Value = HeTongAndFuJian;
            parameters[14].Value = BackInfo;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPProject ");
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
            strSql.Append("select ID,ProjectName,ProjectSerils,SuoShuKeHu,YuJiChengJiaoRiQi,TiXingDate,FuZeRen,XiangMuJinE,XiangMuYuSuan,XiangMuDaXiao,PeiHeRenList,UserName,TimeStr,HeTongAndFuJian,BackInfo ");
            strSql.Append(" FROM ERPProject ");
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
                SuoShuKeHu = ds.Tables[0].Rows[0]["SuoShuKeHu"].ToString();
                YuJiChengJiaoRiQi = ds.Tables[0].Rows[0]["YuJiChengJiaoRiQi"].ToString();
                TiXingDate = ds.Tables[0].Rows[0]["TiXingDate"].ToString();
                FuZeRen = ds.Tables[0].Rows[0]["FuZeRen"].ToString();
                XiangMuJinE = ds.Tables[0].Rows[0]["XiangMuJinE"].ToString();
                XiangMuYuSuan = ds.Tables[0].Rows[0]["XiangMuYuSuan"].ToString();
                XiangMuDaXiao = ds.Tables[0].Rows[0]["XiangMuDaXiao"].ToString();
                PeiHeRenList = ds.Tables[0].Rows[0]["PeiHeRenList"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                HeTongAndFuJian = ds.Tables[0].Rows[0]["HeTongAndFuJian"].ToString();
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ID],[ProjectName],[ProjectSerils],[SuoShuKeHu],[YuJiChengJiaoRiQi],[TiXingDate],[FuZeRen],[XiangMuJinE],[XiangMuYuSuan],[XiangMuDaXiao],[PeiHeRenList],[UserName],[TimeStr],[HeTongAndFuJian],[BackInfo] ");
            strSql.Append(" FROM ERPProject ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

