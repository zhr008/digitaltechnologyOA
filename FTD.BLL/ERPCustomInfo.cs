using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPCustomInfo。
    /// </summary>
    public class ERPCustomInfo
    {
        public ERPCustomInfo()
        { }
        #region Model
        private int _id;
        private string _customname;
        private string _customserils;
        private string _chargeman;
        private string _address;
        private string _urllink;
        private string _youbian;
        private string _telstr;
        private string _xingzhi;
        private string _laiyuan;
        private string _quyu;
        private string _zhuangtai;
        private string _renshu;
        private string _bangongmianji;
        private string _leibie;
        private string _jibie;
        private string _yewufanwei;
        private string _hangye;
        private string _muqianwenti;
        private string _yujidingdandate;
        private string _backinfoa;
        private string _backinfob;
        private string _backinfoc;
        private string _backinfod;
        private DateTime? _timestr;
        private string _username;
        private string _dingdancount;
        private string _yujitixing;
        private string _ifshare;
        private string _cusbaka;
        private string _cusbakb;
        private string _cusbakc;
        private string _cusbakd;
        private string _cusbake;
        private string _nameeng;
        private string _farendaima;
        private string _yingyezhizhao;
        private string _zibene;
        private string _zuzhixingzhi;
        private string _yingyechangsuo;
        private string _jingji;
        private string _shehuiguanxi;
        private string _bengongsiguanxi;
        private string _jieshaoren;
        private string _baozhengren;
        private string _shuipiaoname;
        private string _dizhidianhua;
        private string _nashuidengjihao;
        private string _kaihuhangzhanghao;
        private string _jiaoyifangshi;
        private string _zhangqi;
        private string _fukuanfangshi;
        private string _yunfeichengdan;
        private string _cuxiaofei;
        private string _guanggaofei;
        private string _youdaizhekou;
        private string _fukuantaidu;
        private string _shifouduizhang;
        private string _duizhangshijian;
        private string _zuijiapaifangshijian;
        private string _zuijiashoukuanshijian;
        private string _qitagongying;
        private string _changyongnajia;
        private string _gongsiyijian;
        private string _zixin;
        private string _zongjielun;
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
        public string CustomName
        {
            set { _customname = value; }
            get { return _customname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CustomSerils
        {
            set { _customserils = value; }
            get { return _customserils; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ChargeMan
        {
            set { _chargeman = value; }
            get { return _chargeman; }
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
        public string UrlLink
        {
            set { _urllink = value; }
            get { return _urllink; }
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
        public string TelStr
        {
            set { _telstr = value; }
            get { return _telstr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string XingZhi
        {
            set { _xingzhi = value; }
            get { return _xingzhi; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LaiYuan
        {
            set { _laiyuan = value; }
            get { return _laiyuan; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QuYu
        {
            set { _quyu = value; }
            get { return _quyu; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZhuangTai
        {
            set { _zhuangtai = value; }
            get { return _zhuangtai; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RenShu
        {
            set { _renshu = value; }
            get { return _renshu; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BanGongMianJi
        {
            set { _bangongmianji = value; }
            get { return _bangongmianji; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LeiBie
        {
            set { _leibie = value; }
            get { return _leibie; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string JiBie
        {
            set { _jibie = value; }
            get { return _jibie; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string YeWuFanWei
        {
            set { _yewufanwei = value; }
            get { return _yewufanwei; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string HangYe
        {
            set { _hangye = value; }
            get { return _hangye; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MuQianWenTi
        {
            set { _muqianwenti = value; }
            get { return _muqianwenti; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string YuJiDingDanDate
        {
            set { _yujidingdandate = value; }
            get { return _yujidingdandate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BackInfoA
        {
            set { _backinfoa = value; }
            get { return _backinfoa; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BackInfoB
        {
            set { _backinfob = value; }
            get { return _backinfob; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BackInfoC
        {
            set { _backinfoc = value; }
            get { return _backinfoc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BackInfoD
        {
            set { _backinfod = value; }
            get { return _backinfod; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? TimeStr
        {
            set { _timestr = value; }
            get { return _timestr; }
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
        public string DingDanCount
        {
            set { _dingdancount = value; }
            get { return _dingdancount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string YuJiTiXing
        {
            set { _yujitixing = value; }
            get { return _yujitixing; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IFShare
        {
            set { _ifshare = value; }
            get { return _ifshare; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CusBakA
        {
            set { _cusbaka = value; }
            get { return _cusbaka; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CusBakB
        {
            set { _cusbakb = value; }
            get { return _cusbakb; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CusBakC
        {
            set { _cusbakc = value; }
            get { return _cusbakc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CusBakD
        {
            set { _cusbakd = value; }
            get { return _cusbakd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CusBakE
        {
            set { _cusbake = value; }
            get { return _cusbake; }
        }
        /// <summary>
        /// 公司名称英文
        /// </summary>
        public string NameEng
        {
            set { _nameeng = value; }
            get { return _nameeng; }
        }
        /// <summary>
        /// 法人代码
        /// </summary>
        public string FaRenDaiMa
        {
            set { _farendaima = value; }
            get { return _farendaima; }
        }
        /// <summary>
        /// 营业执照
        /// </summary>
        public string YingYeZhiZhao
        {
            set { _yingyezhizhao = value; }
            get { return _yingyezhizhao; }
        }
        /// <summary>
        /// 资本额
        /// </summary>
        public string ZiBenE
        {
            set { _zibene = value; }
            get { return _zibene; }
        }
        /// <summary>
        /// 组织性质
        /// </summary>
        public string ZuZhiXingZhi
        {
            set { _zuzhixingzhi = value; }
            get { return _zuzhixingzhi; }
        }
        /// <summary>
        /// 营业场所
        /// </summary>
        public string YingYeChangSuo
        {
            set { _yingyechangsuo = value; }
            get { return _yingyechangsuo; }
        }
        /// <summary>
        /// 经济状况
        /// </summary>
        public string JingJi
        {
            set { _jingji = value; }
            get { return _jingji; }
        }
        /// <summary>
        /// 社会关系
        /// </summary>
        public string SheHuiGuanXi
        {
            set { _shehuiguanxi = value; }
            get { return _shehuiguanxi; }
        }
        /// <summary>
        /// 与本公司关系
        /// </summary>
        public string BenGongSiGuanXi
        {
            set { _bengongsiguanxi = value; }
            get { return _bengongsiguanxi; }
        }
        /// <summary>
        /// 介绍人
        /// </summary>
        public string JieShaoRen
        {
            set { _jieshaoren = value; }
            get { return _jieshaoren; }
        }
        /// <summary>
        /// 保证人
        /// </summary>
        public string BaoZhengRen
        {
            set { _baozhengren = value; }
            get { return _baozhengren; }
        }
        /// <summary>
        /// 税票名称
        /// </summary>
        public string ShuiPiaoName
        {
            set { _shuipiaoname = value; }
            get { return _shuipiaoname; }
        }
        /// <summary>
        /// 地址电话
        /// </summary>
        public string DiZhiDianHua
        {
            set { _dizhidianhua = value; }
            get { return _dizhidianhua; }
        }
        /// <summary>
        /// 纳税登记号
        /// </summary>
        public string NaShuiDengJiHao
        {
            set { _nashuidengjihao = value; }
            get { return _nashuidengjihao; }
        }
        /// <summary>
        /// 开户行账号
        /// </summary>
        public string KaiHuHangZhangHao
        {
            set { _kaihuhangzhanghao = value; }
            get { return _kaihuhangzhanghao; }
        }
        /// <summary>
        /// 交易方式
        /// </summary>
        public string JiaoYiFangShi
        {
            set { _jiaoyifangshi = value; }
            get { return _jiaoyifangshi; }
        }
        /// <summary>
        /// 帐期
        /// </summary>
        public string ZhangQi
        {
            set { _zhangqi = value; }
            get { return _zhangqi; }
        }
        /// <summary>
        /// 付款方式
        /// </summary>
        public string FuKuanFangShi
        {
            set { _fukuanfangshi = value; }
            get { return _fukuanfangshi; }
        }
        /// <summary>
        /// 运费承担方
        /// </summary>
        public string YunFeiChengDan
        {
            set { _yunfeichengdan = value; }
            get { return _yunfeichengdan; }
        }
        /// <summary>
        /// 促销费用
        /// </summary>
        public string CuXiaoFei
        {
            set { _cuxiaofei = value; }
            get { return _cuxiaofei; }
        }
        /// <summary>
        /// 广告费用
        /// </summary>
        public string GuangGaoFei
        {
            set { _guanggaofei = value; }
            get { return _guanggaofei; }
        }
        /// <summary>
        /// 优待折扣
        /// </summary>
        public string YouDaiZheKou
        {
            set { _youdaizhekou = value; }
            get { return _youdaizhekou; }
        }
        /// <summary>
        /// 付款态度
        /// </summary>
        public string FuKuanTaiDu
        {
            set { _fukuantaidu = value; }
            get { return _fukuantaidu; }
        }
        /// <summary>
        /// 要否对账
        /// </summary>
        public string ShiFouDuiZhang
        {
            set { _shifouduizhang = value; }
            get { return _shifouduizhang; }
        }
        /// <summary>
        /// 对账时间
        /// </summary>
        public string DuiZhangShiJian
        {
            set { _duizhangshijian = value; }
            get { return _duizhangshijian; }
        }
        /// <summary>
        /// 最佳拜访时间
        /// </summary>
        public string ZuiJiaPaiFangShiJian
        {
            set { _zuijiapaifangshijian = value; }
            get { return _zuijiapaifangshijian; }
        }
        /// <summary>
        /// 最佳收款时间
        /// </summary>
        public string ZuiJiaShouKuanShiJian
        {
            set { _zuijiashoukuanshijian = value; }
            get { return _zuijiashoukuanshijian; }
        }
        /// <summary>
        /// 同类产品其他供应客户
        /// </summary>
        public string QiTaGongYing
        {
            set { _qitagongying = value; }
            get { return _qitagongying; }
        }
        /// <summary>
        /// 常用哪家产品及原因
        /// </summary>
        public string ChangYongNaJia
        {
            set { _changyongnajia = value; }
            get { return _changyongnajia; }
        }
        /// <summary>
        /// 对本公司意见
        /// </summary>
        public string GongSiYiJian
        {
            set { _gongsiyijian = value; }
            get { return _gongsiyijian; }
        }
        /// <summary>
        /// 资信
        /// </summary>
        public string ZiXin
        {
            set { _zixin = value; }
            get { return _zixin; }
        }
        /// <summary>
        /// 总结论
        /// </summary>
        public string ZongJieLun
        {
            set { _zongjielun = value; }
            get { return _zongjielun; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPCustomInfo(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,CustomName,CustomSerils,ChargeMan,Address,UrlLink,YouBian,TelStr,XingZhi,LaiYuan,QuYu,ZhuangTai,RenShu,BanGongMianJi,LeiBie,JiBie,YeWuFanWei,HangYe,MuQianWenTi,YuJiDingDanDate,BackInfoA,BackInfoB,BackInfoC,BackInfoD,TimeStr,UserName,DingDanCount,YuJiTiXing,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE,NameEng,FaRenDaiMa,YingYeZhiZhao,ZiBenE,ZuZhiXingZhi,YingYeChangSuo,JingJi,SheHuiGuanXi,BenGongSiGuanXi,JieShaoRen,BaoZhengRen,ShuiPiaoName,DiZhiDianHua,NaShuiDengJiHao,KaiHuHangZhangHao,JiaoYiFangShi,ZhangQi,FuKuanFangShi,YunFeiChengDan,CuXiaoFei,GuangGaoFei,YouDaiZheKou,FuKuanTaiDu,ShiFouDuiZhang,DuiZhangShiJian,ZuiJiaPaiFangShiJian,ZuiJiaShouKuanShiJian,QiTaGongYing,ChangYongNaJia,GongSiYiJian,ZiXin,ZongJieLun ");
            strSql.Append(" FROM ERPCustomInfo ");
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
                CustomName = ds.Tables[0].Rows[0]["CustomName"].ToString();
                CustomSerils = ds.Tables[0].Rows[0]["CustomSerils"].ToString();
                ChargeMan = ds.Tables[0].Rows[0]["ChargeMan"].ToString();
                Address = ds.Tables[0].Rows[0]["Address"].ToString();
                UrlLink = ds.Tables[0].Rows[0]["UrlLink"].ToString();
                YouBian = ds.Tables[0].Rows[0]["YouBian"].ToString();
                TelStr = ds.Tables[0].Rows[0]["TelStr"].ToString();
                XingZhi = ds.Tables[0].Rows[0]["XingZhi"].ToString();
                LaiYuan = ds.Tables[0].Rows[0]["LaiYuan"].ToString();
                QuYu = ds.Tables[0].Rows[0]["QuYu"].ToString();
                ZhuangTai = ds.Tables[0].Rows[0]["ZhuangTai"].ToString();
                RenShu = ds.Tables[0].Rows[0]["RenShu"].ToString();
                BanGongMianJi = ds.Tables[0].Rows[0]["BanGongMianJi"].ToString();
                LeiBie = ds.Tables[0].Rows[0]["LeiBie"].ToString();
                JiBie = ds.Tables[0].Rows[0]["JiBie"].ToString();
                YeWuFanWei = ds.Tables[0].Rows[0]["YeWuFanWei"].ToString();
                HangYe = ds.Tables[0].Rows[0]["HangYe"].ToString();
                MuQianWenTi = ds.Tables[0].Rows[0]["MuQianWenTi"].ToString();
                YuJiDingDanDate = ds.Tables[0].Rows[0]["YuJiDingDanDate"].ToString();
                BackInfoA = ds.Tables[0].Rows[0]["BackInfoA"].ToString();
                BackInfoB = ds.Tables[0].Rows[0]["BackInfoB"].ToString();
                BackInfoC = ds.Tables[0].Rows[0]["BackInfoC"].ToString();
                BackInfoD = ds.Tables[0].Rows[0]["BackInfoD"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                DingDanCount = ds.Tables[0].Rows[0]["DingDanCount"].ToString();
                YuJiTiXing = ds.Tables[0].Rows[0]["YuJiTiXing"].ToString();
                IFShare = ds.Tables[0].Rows[0]["IFShare"].ToString();
                CusBakA = ds.Tables[0].Rows[0]["CusBakA"].ToString();
                CusBakB = ds.Tables[0].Rows[0]["CusBakB"].ToString();
                CusBakC = ds.Tables[0].Rows[0]["CusBakC"].ToString();
                CusBakD = ds.Tables[0].Rows[0]["CusBakD"].ToString();
                CusBakE = ds.Tables[0].Rows[0]["CusBakE"].ToString();
                NameEng = ds.Tables[0].Rows[0]["NameEng"].ToString();
                FaRenDaiMa = ds.Tables[0].Rows[0]["FaRenDaiMa"].ToString();
                YingYeZhiZhao = ds.Tables[0].Rows[0]["YingYeZhiZhao"].ToString();
                ZiBenE = ds.Tables[0].Rows[0]["ZiBenE"].ToString();
                ZuZhiXingZhi = ds.Tables[0].Rows[0]["ZuZhiXingZhi"].ToString();
                YingYeChangSuo = ds.Tables[0].Rows[0]["YingYeChangSuo"].ToString();
                JingJi = ds.Tables[0].Rows[0]["JingJi"].ToString();
                SheHuiGuanXi = ds.Tables[0].Rows[0]["SheHuiGuanXi"].ToString();
                BenGongSiGuanXi = ds.Tables[0].Rows[0]["BenGongSiGuanXi"].ToString();
                JieShaoRen = ds.Tables[0].Rows[0]["JieShaoRen"].ToString();
                BaoZhengRen = ds.Tables[0].Rows[0]["BaoZhengRen"].ToString();
                ShuiPiaoName = ds.Tables[0].Rows[0]["ShuiPiaoName"].ToString();
                DiZhiDianHua = ds.Tables[0].Rows[0]["DiZhiDianHua"].ToString();
                NaShuiDengJiHao = ds.Tables[0].Rows[0]["NaShuiDengJiHao"].ToString();
                KaiHuHangZhangHao = ds.Tables[0].Rows[0]["KaiHuHangZhangHao"].ToString();
                JiaoYiFangShi = ds.Tables[0].Rows[0]["JiaoYiFangShi"].ToString();
                ZhangQi = ds.Tables[0].Rows[0]["ZhangQi"].ToString();
                FuKuanFangShi = ds.Tables[0].Rows[0]["FuKuanFangShi"].ToString();
                YunFeiChengDan = ds.Tables[0].Rows[0]["YunFeiChengDan"].ToString();
                CuXiaoFei = ds.Tables[0].Rows[0]["CuXiaoFei"].ToString();
                GuangGaoFei = ds.Tables[0].Rows[0]["GuangGaoFei"].ToString();
                YouDaiZheKou = ds.Tables[0].Rows[0]["YouDaiZheKou"].ToString();
                FuKuanTaiDu = ds.Tables[0].Rows[0]["FuKuanTaiDu"].ToString();
                ShiFouDuiZhang = ds.Tables[0].Rows[0]["ShiFouDuiZhang"].ToString();
                DuiZhangShiJian = ds.Tables[0].Rows[0]["DuiZhangShiJian"].ToString();
                ZuiJiaPaiFangShiJian = ds.Tables[0].Rows[0]["ZuiJiaPaiFangShiJian"].ToString();
                ZuiJiaShouKuanShiJian = ds.Tables[0].Rows[0]["ZuiJiaShouKuanShiJian"].ToString();
                QiTaGongYing = ds.Tables[0].Rows[0]["QiTaGongYing"].ToString();
                ChangYongNaJia = ds.Tables[0].Rows[0]["ChangYongNaJia"].ToString();
                GongSiYiJian = ds.Tables[0].Rows[0]["GongSiYiJian"].ToString();
                ZiXin = ds.Tables[0].Rows[0]["ZiXin"].ToString();
                ZongJieLun = ds.Tables[0].Rows[0]["ZongJieLun"].ToString();
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPCustomInfo");
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
            strSql.Append("insert into ERPCustomInfo(");
            strSql.Append("CustomName,CustomSerils,ChargeMan,Address,UrlLink,YouBian,TelStr,XingZhi,LaiYuan,QuYu,ZhuangTai,RenShu,BanGongMianJi,LeiBie,JiBie,YeWuFanWei,HangYe,MuQianWenTi,YuJiDingDanDate,BackInfoA,BackInfoB,BackInfoC,BackInfoD,TimeStr,UserName,DingDanCount,YuJiTiXing,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE,NameEng,FaRenDaiMa,YingYeZhiZhao,ZiBenE,ZuZhiXingZhi,YingYeChangSuo,JingJi,SheHuiGuanXi,BenGongSiGuanXi,JieShaoRen,BaoZhengRen,ShuiPiaoName,DiZhiDianHua,NaShuiDengJiHao,KaiHuHangZhangHao,JiaoYiFangShi,ZhangQi,FuKuanFangShi,YunFeiChengDan,CuXiaoFei,GuangGaoFei,YouDaiZheKou,FuKuanTaiDu,ShiFouDuiZhang,DuiZhangShiJian,ZuiJiaPaiFangShiJian,ZuiJiaShouKuanShiJian,QiTaGongYing,ChangYongNaJia,GongSiYiJian,ZiXin,ZongJieLun)");
            strSql.Append(" values (");
            strSql.Append("@CustomName,@CustomSerils,@ChargeMan,@Address,@UrlLink,@YouBian,@TelStr,@XingZhi,@LaiYuan,@QuYu,@ZhuangTai,@RenShu,@BanGongMianJi,@LeiBie,@JiBie,@YeWuFanWei,@HangYe,@MuQianWenTi,@YuJiDingDanDate,@BackInfoA,@BackInfoB,@BackInfoC,@BackInfoD,@TimeStr,@UserName,@DingDanCount,@YuJiTiXing,@IFShare,@CusBakA,@CusBakB,@CusBakC,@CusBakD,@CusBakE,@NameEng,@FaRenDaiMa,@YingYeZhiZhao,@ZiBenE,@ZuZhiXingZhi,@YingYeChangSuo,@JingJi,@SheHuiGuanXi,@BenGongSiGuanXi,@JieShaoRen,@BaoZhengRen,@ShuiPiaoName,@DiZhiDianHua,@NaShuiDengJiHao,@KaiHuHangZhangHao,@JiaoYiFangShi,@ZhangQi,@FuKuanFangShi,@YunFeiChengDan,@CuXiaoFei,@GuangGaoFei,@YouDaiZheKou,@FuKuanTaiDu,@ShiFouDuiZhang,@DuiZhangShiJian,@ZuiJiaPaiFangShiJian,@ZuiJiaShouKuanShiJian,@QiTaGongYing,@ChangYongNaJia,@GongSiYiJian,@ZiXin,@ZongJieLun)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@CustomName", SqlDbType.VarChar,200),
					new SqlParameter("@CustomSerils", SqlDbType.VarChar,100),
					new SqlParameter("@ChargeMan", SqlDbType.VarChar,100),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@UrlLink", SqlDbType.VarChar,200),
					new SqlParameter("@YouBian", SqlDbType.VarChar,50),
					new SqlParameter("@TelStr", SqlDbType.VarChar,100),
					new SqlParameter("@XingZhi", SqlDbType.VarChar,50),
					new SqlParameter("@LaiYuan", SqlDbType.VarChar,50),
					new SqlParameter("@QuYu", SqlDbType.VarChar,50),
					new SqlParameter("@ZhuangTai", SqlDbType.VarChar,50),
					new SqlParameter("@RenShu", SqlDbType.VarChar,50),
					new SqlParameter("@BanGongMianJi", SqlDbType.VarChar,50),
					new SqlParameter("@LeiBie", SqlDbType.VarChar,50),
					new SqlParameter("@JiBie", SqlDbType.VarChar,50),
					new SqlParameter("@YeWuFanWei", SqlDbType.VarChar,200),
					new SqlParameter("@HangYe", SqlDbType.VarChar,100),
					new SqlParameter("@MuQianWenTi", SqlDbType.VarChar,500),
					new SqlParameter("@YuJiDingDanDate", SqlDbType.VarChar,100),
					new SqlParameter("@BackInfoA", SqlDbType.VarChar,8000),
					new SqlParameter("@BackInfoB", SqlDbType.VarChar,8000),
					new SqlParameter("@BackInfoC", SqlDbType.VarChar,8000),
					new SqlParameter("@BackInfoD", SqlDbType.VarChar,8000),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@DingDanCount", SqlDbType.VarChar,50),
					new SqlParameter("@YuJiTiXing", SqlDbType.VarChar,50),
					new SqlParameter("@IFShare", SqlDbType.VarChar,5000),
					new SqlParameter("@CusBakA", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakB", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakC", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakD", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakE", SqlDbType.VarChar,8000),
					new SqlParameter("@NameEng", SqlDbType.VarChar,50),
					new SqlParameter("@FaRenDaiMa", SqlDbType.VarChar,50),
					new SqlParameter("@YingYeZhiZhao", SqlDbType.VarChar,50),
					new SqlParameter("@ZiBenE", SqlDbType.VarChar,50),
					new SqlParameter("@ZuZhiXingZhi", SqlDbType.VarChar,50),
					new SqlParameter("@YingYeChangSuo", SqlDbType.VarChar,50),
					new SqlParameter("@JingJi", SqlDbType.VarChar,50),
					new SqlParameter("@SheHuiGuanXi", SqlDbType.VarChar,100),
					new SqlParameter("@BenGongSiGuanXi", SqlDbType.VarChar,50),
					new SqlParameter("@JieShaoRen", SqlDbType.VarChar,50),
					new SqlParameter("@BaoZhengRen", SqlDbType.VarChar,50),
					new SqlParameter("@ShuiPiaoName", SqlDbType.VarChar,50),
					new SqlParameter("@DiZhiDianHua", SqlDbType.VarChar,500),
					new SqlParameter("@NaShuiDengJiHao", SqlDbType.VarChar,50),
					new SqlParameter("@KaiHuHangZhangHao", SqlDbType.VarChar,200),
					new SqlParameter("@JiaoYiFangShi", SqlDbType.VarChar,50),
					new SqlParameter("@ZhangQi", SqlDbType.VarChar,50),
					new SqlParameter("@FuKuanFangShi", SqlDbType.VarChar,50),
					new SqlParameter("@YunFeiChengDan", SqlDbType.VarChar,50),
					new SqlParameter("@CuXiaoFei", SqlDbType.VarChar,50),
					new SqlParameter("@GuangGaoFei", SqlDbType.VarChar,50),
					new SqlParameter("@YouDaiZheKou", SqlDbType.VarChar,50),
					new SqlParameter("@FuKuanTaiDu", SqlDbType.VarChar,50),
					new SqlParameter("@ShiFouDuiZhang", SqlDbType.VarChar,50),
					new SqlParameter("@DuiZhangShiJian", SqlDbType.VarChar,50),
					new SqlParameter("@ZuiJiaPaiFangShiJian", SqlDbType.VarChar,50),
					new SqlParameter("@ZuiJiaShouKuanShiJian", SqlDbType.VarChar,50),
					new SqlParameter("@QiTaGongYing", SqlDbType.VarChar,500),
					new SqlParameter("@ChangYongNaJia", SqlDbType.VarChar,5000),
					new SqlParameter("@GongSiYiJian", SqlDbType.VarChar,500),
					new SqlParameter("@ZiXin", SqlDbType.VarChar,50),
					new SqlParameter("@ZongJieLun", SqlDbType.VarChar,50)};
            parameters[0].Value = CustomName;
            parameters[1].Value = CustomSerils;
            parameters[2].Value = ChargeMan;
            parameters[3].Value = Address;
            parameters[4].Value = UrlLink;
            parameters[5].Value = YouBian;
            parameters[6].Value = TelStr;
            parameters[7].Value = XingZhi;
            parameters[8].Value = LaiYuan;
            parameters[9].Value = QuYu;
            parameters[10].Value = ZhuangTai;
            parameters[11].Value = RenShu;
            parameters[12].Value = BanGongMianJi;
            parameters[13].Value = LeiBie;
            parameters[14].Value = JiBie;
            parameters[15].Value = YeWuFanWei;
            parameters[16].Value = HangYe;
            parameters[17].Value = MuQianWenTi;
            parameters[18].Value = YuJiDingDanDate;
            parameters[19].Value = BackInfoA;
            parameters[20].Value = BackInfoB;
            parameters[21].Value = BackInfoC;
            parameters[22].Value = BackInfoD;
            parameters[23].Value = TimeStr;
            parameters[24].Value = UserName;
            parameters[25].Value = DingDanCount;
            parameters[26].Value = YuJiTiXing;
            parameters[27].Value = IFShare;
            parameters[28].Value = CusBakA;
            parameters[29].Value = CusBakB;
            parameters[30].Value = CusBakC;
            parameters[31].Value = CusBakD;
            parameters[32].Value = CusBakE;
            parameters[33].Value = NameEng;
            parameters[34].Value = FaRenDaiMa;
            parameters[35].Value = YingYeZhiZhao;
            parameters[36].Value = ZiBenE;
            parameters[37].Value = ZuZhiXingZhi;
            parameters[38].Value = YingYeChangSuo;
            parameters[39].Value = JingJi;
            parameters[40].Value = SheHuiGuanXi;
            parameters[41].Value = BenGongSiGuanXi;
            parameters[42].Value = JieShaoRen;
            parameters[43].Value = BaoZhengRen;
            parameters[44].Value = ShuiPiaoName;
            parameters[45].Value = DiZhiDianHua;
            parameters[46].Value = NaShuiDengJiHao;
            parameters[47].Value = KaiHuHangZhangHao;
            parameters[48].Value = JiaoYiFangShi;
            parameters[49].Value = ZhangQi;
            parameters[50].Value = FuKuanFangShi;
            parameters[51].Value = YunFeiChengDan;
            parameters[52].Value = CuXiaoFei;
            parameters[53].Value = GuangGaoFei;
            parameters[54].Value = YouDaiZheKou;
            parameters[55].Value = FuKuanTaiDu;
            parameters[56].Value = ShiFouDuiZhang;
            parameters[57].Value = DuiZhangShiJian;
            parameters[58].Value = ZuiJiaPaiFangShiJian;
            parameters[59].Value = ZuiJiaShouKuanShiJian;
            parameters[60].Value = QiTaGongYing;
            parameters[61].Value = ChangYongNaJia;
            parameters[62].Value = GongSiYiJian;
            parameters[63].Value = ZiXin;
            parameters[64].Value = ZongJieLun;

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
            strSql.Append("update ERPCustomInfo set ");
            strSql.Append("CustomName=@CustomName,");
            strSql.Append("CustomSerils=@CustomSerils,");
            strSql.Append("ChargeMan=@ChargeMan,");
            strSql.Append("Address=@Address,");
            strSql.Append("UrlLink=@UrlLink,");
            strSql.Append("YouBian=@YouBian,");
            strSql.Append("TelStr=@TelStr,");
            strSql.Append("XingZhi=@XingZhi,");
            strSql.Append("LaiYuan=@LaiYuan,");
            strSql.Append("QuYu=@QuYu,");
            strSql.Append("ZhuangTai=@ZhuangTai,");
            strSql.Append("RenShu=@RenShu,");
            strSql.Append("BanGongMianJi=@BanGongMianJi,");
            strSql.Append("LeiBie=@LeiBie,");
            strSql.Append("JiBie=@JiBie,");
            strSql.Append("YeWuFanWei=@YeWuFanWei,");
            strSql.Append("HangYe=@HangYe,");
            strSql.Append("MuQianWenTi=@MuQianWenTi,");
            strSql.Append("YuJiDingDanDate=@YuJiDingDanDate,");
            strSql.Append("BackInfoA=@BackInfoA,");
            strSql.Append("BackInfoB=@BackInfoB,");
            strSql.Append("BackInfoC=@BackInfoC,");
            strSql.Append("BackInfoD=@BackInfoD,");
            strSql.Append("TimeStr=@TimeStr,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("DingDanCount=@DingDanCount,");
            strSql.Append("YuJiTiXing=@YuJiTiXing,");
            strSql.Append("IFShare=@IFShare,");
            strSql.Append("CusBakA=@CusBakA,");
            strSql.Append("CusBakB=@CusBakB,");
            strSql.Append("CusBakC=@CusBakC,");
            strSql.Append("CusBakD=@CusBakD,");
            strSql.Append("CusBakE=@CusBakE,");
            strSql.Append("NameEng=@NameEng,");
            strSql.Append("FaRenDaiMa=@FaRenDaiMa,");
            strSql.Append("YingYeZhiZhao=@YingYeZhiZhao,");
            strSql.Append("ZiBenE=@ZiBenE,");
            strSql.Append("ZuZhiXingZhi=@ZuZhiXingZhi,");
            strSql.Append("YingYeChangSuo=@YingYeChangSuo,");
            strSql.Append("JingJi=@JingJi,");
            strSql.Append("SheHuiGuanXi=@SheHuiGuanXi,");
            strSql.Append("BenGongSiGuanXi=@BenGongSiGuanXi,");
            strSql.Append("JieShaoRen=@JieShaoRen,");
            strSql.Append("BaoZhengRen=@BaoZhengRen,");
            strSql.Append("ShuiPiaoName=@ShuiPiaoName,");
            strSql.Append("DiZhiDianHua=@DiZhiDianHua,");
            strSql.Append("NaShuiDengJiHao=@NaShuiDengJiHao,");
            strSql.Append("KaiHuHangZhangHao=@KaiHuHangZhangHao,");
            strSql.Append("JiaoYiFangShi=@JiaoYiFangShi,");
            strSql.Append("ZhangQi=@ZhangQi,");
            strSql.Append("FuKuanFangShi=@FuKuanFangShi,");
            strSql.Append("YunFeiChengDan=@YunFeiChengDan,");
            strSql.Append("CuXiaoFei=@CuXiaoFei,");
            strSql.Append("GuangGaoFei=@GuangGaoFei,");
            strSql.Append("YouDaiZheKou=@YouDaiZheKou,");
            strSql.Append("FuKuanTaiDu=@FuKuanTaiDu,");
            strSql.Append("ShiFouDuiZhang=@ShiFouDuiZhang,");
            strSql.Append("DuiZhangShiJian=@DuiZhangShiJian,");
            strSql.Append("ZuiJiaPaiFangShiJian=@ZuiJiaPaiFangShiJian,");
            strSql.Append("ZuiJiaShouKuanShiJian=@ZuiJiaShouKuanShiJian,");
            strSql.Append("QiTaGongYing=@QiTaGongYing,");
            strSql.Append("ChangYongNaJia=@ChangYongNaJia,");
            strSql.Append("GongSiYiJian=@GongSiYiJian,");
            strSql.Append("ZiXin=@ZiXin,");
            strSql.Append("ZongJieLun=@ZongJieLun");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@CustomName", SqlDbType.VarChar,200),
					new SqlParameter("@CustomSerils", SqlDbType.VarChar,100),
					new SqlParameter("@ChargeMan", SqlDbType.VarChar,100),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@UrlLink", SqlDbType.VarChar,200),
					new SqlParameter("@YouBian", SqlDbType.VarChar,50),
					new SqlParameter("@TelStr", SqlDbType.VarChar,100),
					new SqlParameter("@XingZhi", SqlDbType.VarChar,50),
					new SqlParameter("@LaiYuan", SqlDbType.VarChar,50),
					new SqlParameter("@QuYu", SqlDbType.VarChar,50),
					new SqlParameter("@ZhuangTai", SqlDbType.VarChar,50),
					new SqlParameter("@RenShu", SqlDbType.VarChar,50),
					new SqlParameter("@BanGongMianJi", SqlDbType.VarChar,50),
					new SqlParameter("@LeiBie", SqlDbType.VarChar,50),
					new SqlParameter("@JiBie", SqlDbType.VarChar,50),
					new SqlParameter("@YeWuFanWei", SqlDbType.VarChar,200),
					new SqlParameter("@HangYe", SqlDbType.VarChar,100),
					new SqlParameter("@MuQianWenTi", SqlDbType.VarChar,500),
					new SqlParameter("@YuJiDingDanDate", SqlDbType.VarChar,100),
					new SqlParameter("@BackInfoA", SqlDbType.VarChar,8000),
					new SqlParameter("@BackInfoB", SqlDbType.VarChar,8000),
					new SqlParameter("@BackInfoC", SqlDbType.VarChar,8000),
					new SqlParameter("@BackInfoD", SqlDbType.VarChar,8000),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@DingDanCount", SqlDbType.VarChar,50),
					new SqlParameter("@YuJiTiXing", SqlDbType.VarChar,50),
					new SqlParameter("@IFShare", SqlDbType.VarChar,5000),
					new SqlParameter("@CusBakA", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakB", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakC", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakD", SqlDbType.VarChar,8000),
					new SqlParameter("@CusBakE", SqlDbType.VarChar,8000),
					new SqlParameter("@NameEng", SqlDbType.VarChar,50),
					new SqlParameter("@FaRenDaiMa", SqlDbType.VarChar,50),
					new SqlParameter("@YingYeZhiZhao", SqlDbType.VarChar,50),
					new SqlParameter("@ZiBenE", SqlDbType.VarChar,50),
					new SqlParameter("@ZuZhiXingZhi", SqlDbType.VarChar,50),
					new SqlParameter("@YingYeChangSuo", SqlDbType.VarChar,50),
					new SqlParameter("@JingJi", SqlDbType.VarChar,50),
					new SqlParameter("@SheHuiGuanXi", SqlDbType.VarChar,100),
					new SqlParameter("@BenGongSiGuanXi", SqlDbType.VarChar,50),
					new SqlParameter("@JieShaoRen", SqlDbType.VarChar,50),
					new SqlParameter("@BaoZhengRen", SqlDbType.VarChar,50),
					new SqlParameter("@ShuiPiaoName", SqlDbType.VarChar,50),
					new SqlParameter("@DiZhiDianHua", SqlDbType.VarChar,500),
					new SqlParameter("@NaShuiDengJiHao", SqlDbType.VarChar,50),
					new SqlParameter("@KaiHuHangZhangHao", SqlDbType.VarChar,200),
					new SqlParameter("@JiaoYiFangShi", SqlDbType.VarChar,50),
					new SqlParameter("@ZhangQi", SqlDbType.VarChar,50),
					new SqlParameter("@FuKuanFangShi", SqlDbType.VarChar,50),
					new SqlParameter("@YunFeiChengDan", SqlDbType.VarChar,50),
					new SqlParameter("@CuXiaoFei", SqlDbType.VarChar,50),
					new SqlParameter("@GuangGaoFei", SqlDbType.VarChar,50),
					new SqlParameter("@YouDaiZheKou", SqlDbType.VarChar,50),
					new SqlParameter("@FuKuanTaiDu", SqlDbType.VarChar,50),
					new SqlParameter("@ShiFouDuiZhang", SqlDbType.VarChar,50),
					new SqlParameter("@DuiZhangShiJian", SqlDbType.VarChar,50),
					new SqlParameter("@ZuiJiaPaiFangShiJian", SqlDbType.VarChar,50),
					new SqlParameter("@ZuiJiaShouKuanShiJian", SqlDbType.VarChar,50),
					new SqlParameter("@QiTaGongYing", SqlDbType.VarChar,500),
					new SqlParameter("@ChangYongNaJia", SqlDbType.VarChar,5000),
					new SqlParameter("@GongSiYiJian", SqlDbType.VarChar,500),
					new SqlParameter("@ZiXin", SqlDbType.VarChar,50),
					new SqlParameter("@ZongJieLun", SqlDbType.VarChar,50)};
            parameters[0].Value = ID;
            parameters[1].Value = CustomName;
            parameters[2].Value = CustomSerils;
            parameters[3].Value = ChargeMan;
            parameters[4].Value = Address;
            parameters[5].Value = UrlLink;
            parameters[6].Value = YouBian;
            parameters[7].Value = TelStr;
            parameters[8].Value = XingZhi;
            parameters[9].Value = LaiYuan;
            parameters[10].Value = QuYu;
            parameters[11].Value = ZhuangTai;
            parameters[12].Value = RenShu;
            parameters[13].Value = BanGongMianJi;
            parameters[14].Value = LeiBie;
            parameters[15].Value = JiBie;
            parameters[16].Value = YeWuFanWei;
            parameters[17].Value = HangYe;
            parameters[18].Value = MuQianWenTi;
            parameters[19].Value = YuJiDingDanDate;
            parameters[20].Value = BackInfoA;
            parameters[21].Value = BackInfoB;
            parameters[22].Value = BackInfoC;
            parameters[23].Value = BackInfoD;
            parameters[24].Value = TimeStr;
            parameters[25].Value = UserName;
            parameters[26].Value = DingDanCount;
            parameters[27].Value = YuJiTiXing;
            parameters[28].Value = IFShare;
            parameters[29].Value = CusBakA;
            parameters[30].Value = CusBakB;
            parameters[31].Value = CusBakC;
            parameters[32].Value = CusBakD;
            parameters[33].Value = CusBakE;
            parameters[34].Value = NameEng;
            parameters[35].Value = FaRenDaiMa;
            parameters[36].Value = YingYeZhiZhao;
            parameters[37].Value = ZiBenE;
            parameters[38].Value = ZuZhiXingZhi;
            parameters[39].Value = YingYeChangSuo;
            parameters[40].Value = JingJi;
            parameters[41].Value = SheHuiGuanXi;
            parameters[42].Value = BenGongSiGuanXi;
            parameters[43].Value = JieShaoRen;
            parameters[44].Value = BaoZhengRen;
            parameters[45].Value = ShuiPiaoName;
            parameters[46].Value = DiZhiDianHua;
            parameters[47].Value = NaShuiDengJiHao;
            parameters[48].Value = KaiHuHangZhangHao;
            parameters[49].Value = JiaoYiFangShi;
            parameters[50].Value = ZhangQi;
            parameters[51].Value = FuKuanFangShi;
            parameters[52].Value = YunFeiChengDan;
            parameters[53].Value = CuXiaoFei;
            parameters[54].Value = GuangGaoFei;
            parameters[55].Value = YouDaiZheKou;
            parameters[56].Value = FuKuanTaiDu;
            parameters[57].Value = ShiFouDuiZhang;
            parameters[58].Value = DuiZhangShiJian;
            parameters[59].Value = ZuiJiaPaiFangShiJian;
            parameters[60].Value = ZuiJiaShouKuanShiJian;
            parameters[61].Value = QiTaGongYing;
            parameters[62].Value = ChangYongNaJia;
            parameters[63].Value = GongSiYiJian;
            parameters[64].Value = ZiXin;
            parameters[65].Value = ZongJieLun;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPCustomInfo ");
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
            strSql.Append("select  top 1 ID,CustomName,CustomSerils,ChargeMan,Address,UrlLink,YouBian,TelStr,XingZhi,LaiYuan,QuYu,ZhuangTai,RenShu,BanGongMianJi,LeiBie,JiBie,YeWuFanWei,HangYe,MuQianWenTi,YuJiDingDanDate,BackInfoA,BackInfoB,BackInfoC,BackInfoD,TimeStr,UserName,DingDanCount,YuJiTiXing,IFShare,CusBakA,CusBakB,CusBakC,CusBakD,CusBakE,NameEng,FaRenDaiMa,YingYeZhiZhao,ZiBenE,ZuZhiXingZhi,YingYeChangSuo,JingJi,SheHuiGuanXi,BenGongSiGuanXi,JieShaoRen,BaoZhengRen,ShuiPiaoName,DiZhiDianHua,NaShuiDengJiHao,KaiHuHangZhangHao,JiaoYiFangShi,ZhangQi,FuKuanFangShi,YunFeiChengDan,CuXiaoFei,GuangGaoFei,YouDaiZheKou,FuKuanTaiDu,ShiFouDuiZhang,DuiZhangShiJian,ZuiJiaPaiFangShiJian,ZuiJiaShouKuanShiJian,QiTaGongYing,ChangYongNaJia,GongSiYiJian,ZiXin,ZongJieLun ");
            strSql.Append(" FROM ERPCustomInfo ");
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
                CustomName = ds.Tables[0].Rows[0]["CustomName"].ToString();
                CustomSerils = ds.Tables[0].Rows[0]["CustomSerils"].ToString();
                ChargeMan = ds.Tables[0].Rows[0]["ChargeMan"].ToString();
                Address = ds.Tables[0].Rows[0]["Address"].ToString();
                UrlLink = ds.Tables[0].Rows[0]["UrlLink"].ToString();
                YouBian = ds.Tables[0].Rows[0]["YouBian"].ToString();
                TelStr = ds.Tables[0].Rows[0]["TelStr"].ToString();
                XingZhi = ds.Tables[0].Rows[0]["XingZhi"].ToString();
                LaiYuan = ds.Tables[0].Rows[0]["LaiYuan"].ToString();
                QuYu = ds.Tables[0].Rows[0]["QuYu"].ToString();
                ZhuangTai = ds.Tables[0].Rows[0]["ZhuangTai"].ToString();
                RenShu = ds.Tables[0].Rows[0]["RenShu"].ToString();
                BanGongMianJi = ds.Tables[0].Rows[0]["BanGongMianJi"].ToString();
                LeiBie = ds.Tables[0].Rows[0]["LeiBie"].ToString();
                JiBie = ds.Tables[0].Rows[0]["JiBie"].ToString();
                YeWuFanWei = ds.Tables[0].Rows[0]["YeWuFanWei"].ToString();
                HangYe = ds.Tables[0].Rows[0]["HangYe"].ToString();
                MuQianWenTi = ds.Tables[0].Rows[0]["MuQianWenTi"].ToString();
                YuJiDingDanDate = ds.Tables[0].Rows[0]["YuJiDingDanDate"].ToString();
                BackInfoA = ds.Tables[0].Rows[0]["BackInfoA"].ToString();
                BackInfoB = ds.Tables[0].Rows[0]["BackInfoB"].ToString();
                BackInfoC = ds.Tables[0].Rows[0]["BackInfoC"].ToString();
                BackInfoD = ds.Tables[0].Rows[0]["BackInfoD"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                DingDanCount = ds.Tables[0].Rows[0]["DingDanCount"].ToString();
                YuJiTiXing = ds.Tables[0].Rows[0]["YuJiTiXing"].ToString();
                IFShare = ds.Tables[0].Rows[0]["IFShare"].ToString();
                CusBakA = ds.Tables[0].Rows[0]["CusBakA"].ToString();
                CusBakB = ds.Tables[0].Rows[0]["CusBakB"].ToString();
                CusBakC = ds.Tables[0].Rows[0]["CusBakC"].ToString();
                CusBakD = ds.Tables[0].Rows[0]["CusBakD"].ToString();
                CusBakE = ds.Tables[0].Rows[0]["CusBakE"].ToString();
                NameEng = ds.Tables[0].Rows[0]["NameEng"].ToString();
                FaRenDaiMa = ds.Tables[0].Rows[0]["FaRenDaiMa"].ToString();
                YingYeZhiZhao = ds.Tables[0].Rows[0]["YingYeZhiZhao"].ToString();
                ZiBenE = ds.Tables[0].Rows[0]["ZiBenE"].ToString();
                ZuZhiXingZhi = ds.Tables[0].Rows[0]["ZuZhiXingZhi"].ToString();
                YingYeChangSuo = ds.Tables[0].Rows[0]["YingYeChangSuo"].ToString();
                JingJi = ds.Tables[0].Rows[0]["JingJi"].ToString();
                SheHuiGuanXi = ds.Tables[0].Rows[0]["SheHuiGuanXi"].ToString();
                BenGongSiGuanXi = ds.Tables[0].Rows[0]["BenGongSiGuanXi"].ToString();
                JieShaoRen = ds.Tables[0].Rows[0]["JieShaoRen"].ToString();
                BaoZhengRen = ds.Tables[0].Rows[0]["BaoZhengRen"].ToString();
                ShuiPiaoName = ds.Tables[0].Rows[0]["ShuiPiaoName"].ToString();
                DiZhiDianHua = ds.Tables[0].Rows[0]["DiZhiDianHua"].ToString();
                NaShuiDengJiHao = ds.Tables[0].Rows[0]["NaShuiDengJiHao"].ToString();
                KaiHuHangZhangHao = ds.Tables[0].Rows[0]["KaiHuHangZhangHao"].ToString();
                JiaoYiFangShi = ds.Tables[0].Rows[0]["JiaoYiFangShi"].ToString();
                ZhangQi = ds.Tables[0].Rows[0]["ZhangQi"].ToString();
                FuKuanFangShi = ds.Tables[0].Rows[0]["FuKuanFangShi"].ToString();
                YunFeiChengDan = ds.Tables[0].Rows[0]["YunFeiChengDan"].ToString();
                CuXiaoFei = ds.Tables[0].Rows[0]["CuXiaoFei"].ToString();
                GuangGaoFei = ds.Tables[0].Rows[0]["GuangGaoFei"].ToString();
                YouDaiZheKou = ds.Tables[0].Rows[0]["YouDaiZheKou"].ToString();
                FuKuanTaiDu = ds.Tables[0].Rows[0]["FuKuanTaiDu"].ToString();
                ShiFouDuiZhang = ds.Tables[0].Rows[0]["ShiFouDuiZhang"].ToString();
                DuiZhangShiJian = ds.Tables[0].Rows[0]["DuiZhangShiJian"].ToString();
                ZuiJiaPaiFangShiJian = ds.Tables[0].Rows[0]["ZuiJiaPaiFangShiJian"].ToString();
                ZuiJiaShouKuanShiJian = ds.Tables[0].Rows[0]["ZuiJiaShouKuanShiJian"].ToString();
                QiTaGongYing = ds.Tables[0].Rows[0]["QiTaGongYing"].ToString();
                ChangYongNaJia = ds.Tables[0].Rows[0]["ChangYongNaJia"].ToString();
                GongSiYiJian = ds.Tables[0].Rows[0]["GongSiYiJian"].ToString();
                ZiXin = ds.Tables[0].Rows[0]["ZiXin"].ToString();
                ZongJieLun = ds.Tables[0].Rows[0]["ZongJieLun"].ToString();
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ERPCustomInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

