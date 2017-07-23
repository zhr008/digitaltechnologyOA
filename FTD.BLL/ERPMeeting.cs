using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPMeeting。
    /// </summary>
    public class ERPMeeting
    {
        public ERPMeeting()
        { }
        #region Model
        private int _id;
        private string _meetingtitle;
        private string _meetingzhuti;
        private string _miaoshu;
        private string _chuxiren;
        private string _wangluohuiyishiip;
        private string _huiyizhuchi;
        private DateTime? _kaishitime;
        private DateTime? _jieshutime;
        private string _huiyijiyao;
        private string _zhuanxieren;
        private DateTime? _timestr;
        private string _curentonline;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 会议标题
        /// </summary>
        public string MeetingTitle
        {
            set { _meetingtitle = value; }
            get { return _meetingtitle; }
        }
        /// <summary>
        /// 会议主题
        /// </summary>
        public string MeetingZhuTi
        {
            set { _meetingzhuti = value; }
            get { return _meetingzhuti; }
        }
        /// <summary>
        /// 描述
        /// </summary>
        public string MiaoShu
        {
            set { _miaoshu = value; }
            get { return _miaoshu; }
        }
        /// <summary>
        /// 出席人
        /// </summary>
        public string ChuXiRen
        {
            set { _chuxiren = value; }
            get { return _chuxiren; }
        }
        /// <summary>
        /// 会议室IP
        /// </summary>
        public string WangLuoHuiYiShiIP
        {
            set { _wangluohuiyishiip = value; }
            get { return _wangluohuiyishiip; }
        }
        /// <summary>
        /// 主持人
        /// </summary>
        public string HuiYiZhuChi
        {
            set { _huiyizhuchi = value; }
            get { return _huiyizhuchi; }
        }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? KaiShiTime
        {
            set { _kaishitime = value; }
            get { return _kaishitime; }
        }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? JieShuTime
        {
            set { _jieshutime = value; }
            get { return _jieshutime; }
        }
        /// <summary>
        /// 会议纪要
        /// </summary>
        public string HuiYiJiYao
        {
            set { _huiyijiyao = value; }
            get { return _huiyijiyao; }
        }
        /// <summary>
        /// 撰写人
        /// </summary>
        public string ZhuanXieRen
        {
            set { _zhuanxieren = value; }
            get { return _zhuanxieren; }
        }
        /// <summary>
        /// 撰写时间
        /// </summary>
        public DateTime? TimeStr
        {
            set { _timestr = value; }
            get { return _timestr; }
        }
        /// <summary>
        /// 当前在线
        /// </summary>
        public string CurentOnline
        {
            set { _curentonline = value; }
            get { return _curentonline; }
        }
        #endregion Model


        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPMeeting");
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
            strSql.Append("insert into ERPMeeting(");
            strSql.Append("MeetingTitle,MeetingZhuTi,MiaoShu,ChuXiRen,WangLuoHuiYiShiIP,HuiYiZhuChi,KaiShiTime,JieShuTime,HuiYiJiYao,ZhuanXieRen,TimeStr,CurentOnline)");
            strSql.Append(" values (");
            strSql.Append("@MeetingTitle,@MeetingZhuTi,@MiaoShu,@ChuXiRen,@WangLuoHuiYiShiIP,@HuiYiZhuChi,@KaiShiTime,@JieShuTime,@HuiYiJiYao,@ZhuanXieRen,@TimeStr,@CurentOnline)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MeetingTitle", SqlDbType.VarChar,500),
					new SqlParameter("@MeetingZhuTi", SqlDbType.VarChar,5000),
					new SqlParameter("@MiaoShu", SqlDbType.VarChar,5000),
					new SqlParameter("@ChuXiRen", SqlDbType.VarChar,8000),
					new SqlParameter("@WangLuoHuiYiShiIP", SqlDbType.VarChar,50),
					new SqlParameter("@HuiYiZhuChi", SqlDbType.VarChar,50),
					new SqlParameter("@KaiShiTime", SqlDbType.DateTime),
					new SqlParameter("@JieShuTime", SqlDbType.DateTime),
					new SqlParameter("@HuiYiJiYao", SqlDbType.Text),
					new SqlParameter("@ZhuanXieRen", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@CurentOnline", SqlDbType.VarChar,8000)};
            parameters[0].Value = MeetingTitle;
            parameters[1].Value = MeetingZhuTi;
            parameters[2].Value = MiaoShu;
            parameters[3].Value = ChuXiRen;
            parameters[4].Value = WangLuoHuiYiShiIP;
            parameters[5].Value = HuiYiZhuChi;
            parameters[6].Value = KaiShiTime;
            parameters[7].Value = JieShuTime;
            parameters[8].Value = HuiYiJiYao;
            parameters[9].Value = ZhuanXieRen;
            parameters[10].Value = TimeStr;
            parameters[11].Value = CurentOnline;

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
            strSql.Append("update ERPMeeting set ");
            strSql.Append("MeetingTitle=@MeetingTitle,");
            strSql.Append("MeetingZhuTi=@MeetingZhuTi,");
            strSql.Append("MiaoShu=@MiaoShu,");
            strSql.Append("ChuXiRen=@ChuXiRen,");
            strSql.Append("WangLuoHuiYiShiIP=@WangLuoHuiYiShiIP,");
            strSql.Append("HuiYiZhuChi=@HuiYiZhuChi,");
            strSql.Append("KaiShiTime=@KaiShiTime,");
            strSql.Append("JieShuTime=@JieShuTime,");
            strSql.Append("HuiYiJiYao=@HuiYiJiYao");
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MeetingTitle", SqlDbType.VarChar,500),
					new SqlParameter("@MeetingZhuTi", SqlDbType.VarChar,5000),
					new SqlParameter("@MiaoShu", SqlDbType.VarChar,5000),
					new SqlParameter("@ChuXiRen", SqlDbType.VarChar,8000),
					new SqlParameter("@WangLuoHuiYiShiIP", SqlDbType.VarChar,50),
					new SqlParameter("@HuiYiZhuChi", SqlDbType.VarChar,50),
					new SqlParameter("@KaiShiTime", SqlDbType.DateTime),
					new SqlParameter("@JieShuTime", SqlDbType.DateTime),
					new SqlParameter("@HuiYiJiYao", SqlDbType.Text)};
            parameters[0].Value = ID;
            parameters[1].Value = MeetingTitle;
            parameters[2].Value = MeetingZhuTi;
            parameters[3].Value = MiaoShu;
            parameters[4].Value = ChuXiRen;
            parameters[5].Value = WangLuoHuiYiShiIP;
            parameters[6].Value = HuiYiZhuChi;
            parameters[7].Value = KaiShiTime;
            parameters[8].Value = JieShuTime;
            parameters[9].Value = HuiYiJiYao;           

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPMeeting ");
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
            strSql.Append("select ID,MeetingTitle,MeetingZhuTi,MiaoShu,ChuXiRen,WangLuoHuiYiShiIP,HuiYiZhuChi,KaiShiTime,JieShuTime,HuiYiJiYao,ZhuanXieRen,TimeStr,CurentOnline ");
            strSql.Append(" FROM ERPMeeting ");
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
                MeetingTitle = ds.Tables[0].Rows[0]["MeetingTitle"].ToString();
                MeetingZhuTi = ds.Tables[0].Rows[0]["MeetingZhuTi"].ToString();
                MiaoShu = ds.Tables[0].Rows[0]["MiaoShu"].ToString();
                ChuXiRen = ds.Tables[0].Rows[0]["ChuXiRen"].ToString();
                WangLuoHuiYiShiIP = ds.Tables[0].Rows[0]["WangLuoHuiYiShiIP"].ToString();
                HuiYiZhuChi = ds.Tables[0].Rows[0]["HuiYiZhuChi"].ToString();
                if (ds.Tables[0].Rows[0]["KaiShiTime"].ToString() != "")
                {
                    KaiShiTime = DateTime.Parse(ds.Tables[0].Rows[0]["KaiShiTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["JieShuTime"].ToString() != "")
                {
                    JieShuTime = DateTime.Parse(ds.Tables[0].Rows[0]["JieShuTime"].ToString());
                }
                HuiYiJiYao = ds.Tables[0].Rows[0]["HuiYiJiYao"].ToString();
                ZhuanXieRen = ds.Tables[0].Rows[0]["ZhuanXieRen"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                CurentOnline = ds.Tables[0].Rows[0]["CurentOnline"].ToString();
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ID],[MeetingTitle],[MeetingZhuTi],[MiaoShu],[ChuXiRen],[WangLuoHuiYiShiIP],[HuiYiZhuChi],[KaiShiTime],[JieShuTime],[HuiYiJiYao],[ZhuanXieRen],[TimeStr],[CurentOnline],[NowState] ");
            strSql.Append(" FROM ERPMeeting ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}