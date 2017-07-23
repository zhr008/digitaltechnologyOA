using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPBuyOrder。
    /// </summary>
    public class ERPBuyOrder
    {
        public ERPBuyOrder()
        { }
        #region Model
        private int _id;
        private string _ordername;
        private string _gongyingshangname;
        private string _serils;
        private string _dingdanleixing;
        private string _dingdanmiaoshu;
        private DateTime? _createdate;
        private DateTime? _laihuodate;
        private DateTime? _tixingdate;
        private string _chuangjianren;
        private string _fuzeren;
        private string _fujianlist;
        private string _nowstate;
        private string _shenpitongguoren;
        private string _backinfo;
        private string _username;
        private DateTime? _timestr;
        private string _htzj;
        private string _yffy;
        private string _sfjf;
        private string _sqfy;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 订单名称
        /// </summary>
        public string OrderName
        {
            set { _ordername = value; }
            get { return _ordername; }
        }
        /// <summary>
        /// 供应商名称
        /// </summary>
        public string GongYingShangName
        {
            set { _gongyingshangname = value; }
            get { return _gongyingshangname; }
        }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string Serils
        {
            set { _serils = value; }
            get { return _serils; }
        }
        /// <summary>
        /// 订单类型
        /// </summary>
        public string DingDanLeiXing
        {
            set { _dingdanleixing = value; }
            get { return _dingdanleixing; }
        }
        /// <summary>
        /// 订单描述
        /// </summary>
        public string DingDanMiaoShu
        {
            set { _dingdanmiaoshu = value; }
            get { return _dingdanmiaoshu; }
        }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        /// <summary>
        /// 来货日期
        /// </summary>
        public DateTime? LaiHuoDate
        {
            set { _laihuodate = value; }
            get { return _laihuodate; }
        }
        /// <summary>
        /// 提醒日期
        /// </summary>
        public DateTime? TiXingDate
        {
            set { _tixingdate = value; }
            get { return _tixingdate; }
        }
        /// <summary>
        /// 创建人
        /// </summary>
        public string ChuangJianRen
        {
            set { _chuangjianren = value; }
            get { return _chuangjianren; }
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
        /// 附件文件
        /// </summary>
        public string FuJianList
        {
            set { _fujianlist = value; }
            get { return _fujianlist; }
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
        /// 审核人
        /// </summary>
        public string ShenPiTongGuoRen
        {
            set { _shenpitongguoren = value; }
            get { return _shenpitongguoren; }
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

        /// <summary>
        /// 当前状态
        /// </summary>
        public string HTZJ
        {
            set { _htzj = value; }
            get { return _htzj; }
        }

        /// <summary>
        /// 当前状态
        /// </summary>
        public string YFFY
        {
            set { _yffy = value; }
            get { return _yffy; }
        }

        /// <summary>
        /// 当前状态
        /// </summary>
        public string SFJF
        {
            set { _sfjf = value; }
            get { return _sfjf; }
        }

        /// <summary>
        /// 当前状态
        /// </summary>
        public string SQFY
        {
            set { _sqfy = value; }
            get { return _sqfy; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPBuyOrder(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,OrderName,GongYingShangName,Serils,DingDanLeiXing,DingDanMiaoShu,CreateDate,LaiHuoDate,TiXingDate,ChuangJianRen,FuZeRen,FuJianList,NowState,ShenPiTongGuoRen,BackInfo,UserName,TimeStr,HTZJ,YFFY,SFJF,SQFY ");
            strSql.Append(" FROM ERPBuyOrder ");
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
                OrderName = ds.Tables[0].Rows[0]["OrderName"].ToString();
                GongYingShangName = ds.Tables[0].Rows[0]["GongYingShangName"].ToString();
                Serils = ds.Tables[0].Rows[0]["Serils"].ToString();
                DingDanLeiXing = ds.Tables[0].Rows[0]["DingDanLeiXing"].ToString();
                DingDanMiaoShu = ds.Tables[0].Rows[0]["DingDanMiaoShu"].ToString();
                if (ds.Tables[0].Rows[0]["CreateDate"].ToString() != "")
                {
                    CreateDate = DateTime.Parse(ds.Tables[0].Rows[0]["CreateDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LaiHuoDate"].ToString() != "")
                {
                    LaiHuoDate = DateTime.Parse(ds.Tables[0].Rows[0]["LaiHuoDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TiXingDate"].ToString() != "")
                {
                    TiXingDate = DateTime.Parse(ds.Tables[0].Rows[0]["TiXingDate"].ToString());
                }
                ChuangJianRen = ds.Tables[0].Rows[0]["ChuangJianRen"].ToString();
                FuZeRen = ds.Tables[0].Rows[0]["FuZeRen"].ToString();
                FuJianList = ds.Tables[0].Rows[0]["FuJianList"].ToString();
                NowState = ds.Tables[0].Rows[0]["NowState"].ToString();
                ShenPiTongGuoRen = ds.Tables[0].Rows[0]["ShenPiTongGuoRen"].ToString();
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                HTZJ = ds.Tables[0].Rows[0]["HTZJ"].ToString();
                YFFY = ds.Tables[0].Rows[0]["YFFY"].ToString();
                SFJF = ds.Tables[0].Rows[0]["SFJF"].ToString();
                SQFY = ds.Tables[0].Rows[0]["SQFY"].ToString();
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPBuyOrder");
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
            strSql.Append("insert into ERPBuyOrder(");
            strSql.Append("OrderName,GongYingShangName,Serils,DingDanLeiXing,DingDanMiaoShu,CreateDate,LaiHuoDate,TiXingDate,ChuangJianRen,FuZeRen,FuJianList,NowState,ShenPiTongGuoRen,BackInfo,UserName,TimeStr,HTZJ,YFFY,SFJF,SQFY)");
            strSql.Append(" values (");
            strSql.Append("@OrderName,@GongYingShangName,@Serils,@DingDanLeiXing,@DingDanMiaoShu,@CreateDate,@LaiHuoDate,@TiXingDate,@ChuangJianRen,@FuZeRen,@FuJianList,@NowState,@ShenPiTongGuoRen,@BackInfo,@UserName,@TimeStr,@HTZJ,@YFFY,@SFJF,@SQFY)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@OrderName", SqlDbType.VarChar,50),
					new SqlParameter("@GongYingShangName", SqlDbType.VarChar,50),
					new SqlParameter("@Serils", SqlDbType.VarChar,50),
					new SqlParameter("@DingDanLeiXing", SqlDbType.VarChar,50),
					new SqlParameter("@DingDanMiaoShu", SqlDbType.VarChar,5000),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@LaiHuoDate", SqlDbType.DateTime),
					new SqlParameter("@TiXingDate", SqlDbType.DateTime),
					new SqlParameter("@ChuangJianRen", SqlDbType.VarChar,50),
					new SqlParameter("@FuZeRen", SqlDbType.VarChar,50),
					new SqlParameter("@FuJianList", SqlDbType.VarChar,500),
					new SqlParameter("@NowState", SqlDbType.VarChar,50),
					new SqlParameter("@ShenPiTongGuoRen", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.Text),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
                                         new SqlParameter("@HTZJ", SqlDbType.VarChar,50),
                                        new SqlParameter("@YFFY", SqlDbType.VarChar,50),
                                        new SqlParameter("@SFJF", SqlDbType.VarChar,50),
                                        new SqlParameter("@SQFY", SqlDbType.VarChar,50)};
            parameters[0].Value = OrderName;
            parameters[1].Value = GongYingShangName;
            parameters[2].Value = Serils;
            parameters[3].Value = DingDanLeiXing;
            parameters[4].Value = DingDanMiaoShu;
            parameters[5].Value = CreateDate;
            parameters[6].Value = LaiHuoDate;
            parameters[7].Value = TiXingDate;
            parameters[8].Value = ChuangJianRen;
            parameters[9].Value = FuZeRen;
            parameters[10].Value = FuJianList;
            parameters[11].Value = NowState;
            parameters[12].Value = ShenPiTongGuoRen;
            parameters[13].Value = BackInfo;
            parameters[14].Value = UserName;
            parameters[15].Value = TimeStr;
            parameters[16].Value = HTZJ;
            parameters[17].Value = YFFY;
            parameters[18].Value = SFJF;
            parameters[19].Value = SQFY;

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
            strSql.Append("update ERPBuyOrder set ");
            strSql.Append("OrderName=@OrderName,");
            strSql.Append("GongYingShangName=@GongYingShangName,");
            strSql.Append("Serils=@Serils,");
            strSql.Append("DingDanLeiXing=@DingDanLeiXing,");
            strSql.Append("DingDanMiaoShu=@DingDanMiaoShu,");
            strSql.Append("CreateDate=@CreateDate,");
            strSql.Append("LaiHuoDate=@LaiHuoDate,");
            strSql.Append("TiXingDate=@TiXingDate,");
            strSql.Append("ChuangJianRen=@ChuangJianRen,");
            strSql.Append("FuZeRen=@FuZeRen,");
            strSql.Append("FuJianList=@FuJianList,");
            strSql.Append("NowState=@NowState,");
            strSql.Append("ShenPiTongGuoRen=@ShenPiTongGuoRen,");
            strSql.Append("BackInfo=@BackInfo,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TimeStr=@TimeStr,");
            strSql.Append("HTZJ=@HTZJ,");
            strSql.Append("YFFY=@YFFY,");
            strSql.Append("SFJF=@SFJF,");
            strSql.Append("SQFY=@SQFY");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@OrderName", SqlDbType.VarChar,50),
					new SqlParameter("@GongYingShangName", SqlDbType.VarChar,50),
					new SqlParameter("@Serils", SqlDbType.VarChar,50),
					new SqlParameter("@DingDanLeiXing", SqlDbType.VarChar,50),
					new SqlParameter("@DingDanMiaoShu", SqlDbType.VarChar,5000),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@LaiHuoDate", SqlDbType.DateTime),
					new SqlParameter("@TiXingDate", SqlDbType.DateTime),
					new SqlParameter("@ChuangJianRen", SqlDbType.VarChar,50),
					new SqlParameter("@FuZeRen", SqlDbType.VarChar,50),
					new SqlParameter("@FuJianList", SqlDbType.VarChar,500),
					new SqlParameter("@NowState", SqlDbType.VarChar,50),
					new SqlParameter("@ShenPiTongGuoRen", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.Text),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
                     new SqlParameter("@HTZJ", SqlDbType.VarChar,50),
                                        new SqlParameter("@YFFY", SqlDbType.VarChar,50),
                                        new SqlParameter("@SFJF", SqlDbType.VarChar,50),
                                        new SqlParameter("@SQFY", SqlDbType.VarChar,50)};
            parameters[0].Value = ID;
            parameters[1].Value = OrderName;
            parameters[2].Value = GongYingShangName;
            parameters[3].Value = Serils;
            parameters[4].Value = DingDanLeiXing;
            parameters[5].Value = DingDanMiaoShu;
            parameters[6].Value = CreateDate;
            parameters[7].Value = LaiHuoDate;
            parameters[8].Value = TiXingDate;
            parameters[9].Value = ChuangJianRen;
            parameters[10].Value = FuZeRen;
            parameters[11].Value = FuJianList;
            parameters[12].Value = NowState;
            parameters[13].Value = ShenPiTongGuoRen;
            parameters[14].Value = BackInfo;
            parameters[15].Value = UserName;
            parameters[16].Value = TimeStr;
            parameters[17].Value = HTZJ;
            parameters[18].Value = YFFY;
            parameters[19].Value = SFJF;
            parameters[20].Value = SQFY;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPBuyOrder ");
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
            strSql.Append("select  top 1 ID,OrderName,GongYingShangName,Serils,DingDanLeiXing,DingDanMiaoShu,CreateDate,LaiHuoDate,TiXingDate,ChuangJianRen,FuZeRen,FuJianList,NowState,ShenPiTongGuoRen,BackInfo,UserName,TimeStr,HTZJ,YFFY,SFJF,SQFY  ");
            strSql.Append(" FROM ERPBuyOrder ");
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
                OrderName = ds.Tables[0].Rows[0]["OrderName"].ToString();
                GongYingShangName = ds.Tables[0].Rows[0]["GongYingShangName"].ToString();
                Serils = ds.Tables[0].Rows[0]["Serils"].ToString();
                DingDanLeiXing = ds.Tables[0].Rows[0]["DingDanLeiXing"].ToString();
                DingDanMiaoShu = ds.Tables[0].Rows[0]["DingDanMiaoShu"].ToString();
                if (ds.Tables[0].Rows[0]["CreateDate"].ToString() != "")
                {
                    CreateDate = DateTime.Parse(ds.Tables[0].Rows[0]["CreateDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LaiHuoDate"].ToString() != "")
                {
                    LaiHuoDate = DateTime.Parse(ds.Tables[0].Rows[0]["LaiHuoDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TiXingDate"].ToString() != "")
                {
                    TiXingDate = DateTime.Parse(ds.Tables[0].Rows[0]["TiXingDate"].ToString());
                }
                ChuangJianRen = ds.Tables[0].Rows[0]["ChuangJianRen"].ToString();
                FuZeRen = ds.Tables[0].Rows[0]["FuZeRen"].ToString();
                FuJianList = ds.Tables[0].Rows[0]["FuJianList"].ToString();
                NowState = ds.Tables[0].Rows[0]["NowState"].ToString();
                ShenPiTongGuoRen = ds.Tables[0].Rows[0]["ShenPiTongGuoRen"].ToString();
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                HTZJ = ds.Tables[0].Rows[0]["HTZJ"].ToString();
                YFFY = ds.Tables[0].Rows[0]["YFFY"].ToString();
                SFJF = ds.Tables[0].Rows[0]["SFJF"].ToString();
                SQFY = ds.Tables[0].Rows[0]["SQFY"].ToString();
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ERPBuyOrder ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public void HZ()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ERPBuyOrder ");
            strSql.Append(" set HTZJ=(select sum(b.ZongJia) from ERPBuyChanPin b where b.OrderName=a.OrderName),YFFY=(select sum(convert(float, c.HTJE)) from ERPYS c where c.HeTongName=a.OrderName and c.SFDK='是' and c.NowState='F'),SQFY= HTZJ -YFFY , SFJF=(select case when exists(select * from ERPBuyChanPin b where b.OrderName=a.OrderName and b.IFJiaoFu='未交付') then '未交付' when not exists (select * from ERPBuyChanPin b where b.OrderName=a.OrderName) then '未交付' else '已交付' end) from ERPBuyOrder a");

            DbHelperSQL.Query(strSql.ToString());
        }

        public string GetSerils()
        { 
            DateTime dt = DateTime.Today;
            string sPreFix = "YL-" + dt.Year.ToString() + dt.Month.ToString().PadLeft(2, '0') + "-S-";
            string sSql = "select Serils from ERPBuyOrder where Serils like @PreFix order by ID desc ";
            SqlParameter[] parameters = {
					new SqlParameter("@PreFix", SqlDbType.VarChar,50)};
            parameters[0].Value = sPreFix + "%";
            DataSet ds = DbHelperSQL.Query(sSql, parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                string sSerils = ds.Tables[0].Rows[0]["Serils"].ToString();
                return sPreFix + (Int32.Parse(sSerils.Substring(12)) + 1).ToString().PadLeft(4, '0');
            }
            return sPreFix + "0001";
        }
        #endregion  成员方法
    }
}

