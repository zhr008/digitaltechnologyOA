using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPSheBei。
	/// </summary>
	public class ERPSheBei
	{
		public ERPSheBei()
		{}
		#region Model
		private int _id;
		private string _shebeiname;
		private string _yuanbianhao;
		private string _caiwubianhao;
		private string _jibubianhao;
		private string _shebeileibie;
		private string _xinghao;
		private string _xiangmu;
		private string _chuchangbianhao;
		private string _shiyongbumen;
		private string _shengchanchangjia;
		private string _danwei;
		private string _danjia;
		private string _suyuanfangshi;
		private string _suyaundanwei;
		private string _suyuanzhouqi;
		private string _shangcisuyuandate;
		private string _jihuasuyaundate;
		private string _zhengshubianhao;
		private string _celiangfanwei;
		private string _buquedingdu;
		private string _shiyongceliangfanwei;
		private string _jingdu;
		private string _jieguopingjia;
		private string _pingjiauser;
		private string _qianzidate;
		private string _zhenggai;
		private string _chucisuyuandate;
		private string _qiyongdate;
		private string _cunfangaddr;
		private string _guanliuser;
		private string _jifei;
		private string _zhuangtai;
		private string _beizhu;
		private string _heduiuser;
		private string _tixingdate;
		private string _tixinguser;
		private string _username;
		private DateTime? _timestr;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 设备名称
		/// </summary>
		public string SheBeiName
		{
			set{ _shebeiname=value;}
			get{return _shebeiname;}
		}
		/// <summary>
		/// 原资产编号
		/// </summary>
		public string YuanBianHao
		{
			set{ _yuanbianhao=value;}
			get{return _yuanbianhao;}
		}
		/// <summary>
		/// 财务编号
		/// </summary>
		public string CaiWuBianHao
		{
			set{ _caiwubianhao=value;}
			get{return _caiwubianhao;}
		}
		/// <summary>
		/// 技质部编号
		/// </summary>
		public string JiBuBianHao
		{
			set{ _jibubianhao=value;}
			get{return _jibubianhao;}
		}
		/// <summary>
		/// 设备类别
		/// </summary>
		public string SheBeiLeiBie
		{
			set{ _shebeileibie=value;}
			get{return _shebeileibie;}
		}
		/// <summary>
		/// 型号
		/// </summary>
		public string XingHao
		{
			set{ _xinghao=value;}
			get{return _xinghao;}
		}
		/// <summary>
		/// 项目
		/// </summary>
		public string XiangMu
		{
			set{ _xiangmu=value;}
			get{return _xiangmu;}
		}
		/// <summary>
		/// 出厂编号
		/// </summary>
		public string ChuChangBianHao
		{
			set{ _chuchangbianhao=value;}
			get{return _chuchangbianhao;}
		}
		/// <summary>
		/// 使用部门
		/// </summary>
		public string ShiYongBuMen
		{
			set{ _shiyongbumen=value;}
			get{return _shiyongbumen;}
		}
		/// <summary>
		/// 生产厂家
		/// </summary>
		public string ShengChanChangJia
		{
			set{ _shengchanchangjia=value;}
			get{return _shengchanchangjia;}
		}
		/// <summary>
		/// 单位
		/// </summary>
		public string DanWei
		{
			set{ _danwei=value;}
			get{return _danwei;}
		}
		/// <summary>
		/// 单价(元)
		/// </summary>
		public string DanJia
		{
			set{ _danjia=value;}
			get{return _danjia;}
		}
		/// <summary>
		/// 溯源方式
		/// </summary>
		public string SuYuanFangShi
		{
			set{ _suyuanfangshi=value;}
			get{return _suyuanfangshi;}
		}
		/// <summary>
		/// 溯源单位
		/// </summary>
		public string SuYaunDanWei
		{
			set{ _suyaundanwei=value;}
			get{return _suyaundanwei;}
		}
		/// <summary>
		/// 溯源周期(月)
		/// </summary>
		public string SuYuanZhouQi
		{
			set{ _suyuanzhouqi=value;}
			get{return _suyuanzhouqi;}
		}
		/// <summary>
		/// 上次溯源日期
		/// </summary>
		public string ShangCiSuYuanDate
		{
			set{ _shangcisuyuandate=value;}
			get{return _shangcisuyuandate;}
		}
		/// <summary>
		/// 计划溯源日期
		/// </summary>
		public string JiHuaSuYaunDate
		{
			set{ _jihuasuyaundate=value;}
			get{return _jihuasuyaundate;}
		}
		/// <summary>
		/// 证书编号
		/// </summary>
		public string ZhengShuBianHao
		{
			set{ _zhengshubianhao=value;}
			get{return _zhengshubianhao;}
		}
		/// <summary>
		/// 检定/校准结果-测量范围
		/// </summary>
		public string CeLiangFanWei
		{
			set{ _celiangfanwei=value;}
			get{return _celiangfanwei;}
		}
		/// <summary>
		/// 不确定度或准确度等级或最大允许误差
		/// </summary>
		public string BuQueDingDu
		{
			set{ _buquedingdu=value;}
			get{return _buquedingdu;}
		}
		/// <summary>
		/// 使用要求--测量范围
		/// </summary>
		public string ShiYongCeLiangFanWei
		{
			set{ _shiyongceliangfanwei=value;}
			get{return _shiyongceliangfanwei;}
		}
		/// <summary>
		/// 精度
		/// </summary>
		public string JingDu
		{
			set{ _jingdu=value;}
			get{return _jingdu;}
		}
		/// <summary>
		/// 校准结果评价
		/// </summary>
		public string JieGuoPingJia
		{
			set{ _jieguopingjia=value;}
			get{return _jieguopingjia;}
		}
		/// <summary>
		/// 评价人员
		/// </summary>
		public string PingJiaUser
		{
			set{ _pingjiauser=value;}
			get{return _pingjiauser;}
		}
		/// <summary>
		/// 签字日期
		/// </summary>
		public string QianZiDate
		{
			set{ _qianzidate=value;}
			get{return _qianzidate;}
		}
		/// <summary>
		/// 整改内容及结果
		/// </summary>
		public string ZhengGai
		{
			set{ _zhenggai=value;}
			get{return _zhenggai;}
		}
		/// <summary>
		/// 初次溯源日期
		/// </summary>
		public string ChuCiSuYuanDate
		{
			set{ _chucisuyuandate=value;}
			get{return _chucisuyuandate;}
		}
		/// <summary>
		/// 启用日期
		/// </summary>
		public string QiYongDate
		{
			set{ _qiyongdate=value;}
			get{return _qiyongdate;}
		}
		/// <summary>
		/// 存放位置
		/// </summary>
		public string CunFangAddr
		{
			set{ _cunfangaddr=value;}
			get{return _cunfangaddr;}
		}
		/// <summary>
		/// 管理人
		/// </summary>
		public string GuanLiUser
		{
			set{ _guanliuser=value;}
			get{return _guanliuser;}
		}
		/// <summary>
		/// 检定计费
		/// </summary>
		public string JiFei
		{
			set{ _jifei=value;}
			get{return _jifei;}
		}
		/// <summary>
		/// 设备状态
		/// </summary>
		public string ZhuangTai
		{
			set{ _zhuangtai=value;}
			get{return _zhuangtai;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string BeiZhu
		{
			set{ _beizhu=value;}
			get{return _beizhu;}
		}
		/// <summary>
		/// 核对人
		/// </summary>
		public string HeDuiUser
		{
			set{ _heduiuser=value;}
			get{return _heduiuser;}
		}
		/// <summary>
		/// 提醒日期
		/// </summary>
		public string TiXingDate
		{
			set{ _tixingdate=value;}
			get{return _tixingdate;}
		}
		/// <summary>
		/// 被提醒人
		/// </summary>
		public string TiXingUser
		{
			set{ _tixinguser=value;}
			get{return _tixinguser;}
		}
		/// <summary>
		/// 录入人
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 录入时间
		/// </summary>
		public DateTime? TimeStr
		{
			set{ _timestr=value;}
			get{return _timestr;}
		}
		#endregion Model


		#region  成员方法

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPSheBei(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,SheBeiName,YuanBianHao,CaiWuBianHao,JiBuBianHao,SheBeiLeiBie,XingHao,XiangMu,ChuChangBianHao,ShiYongBuMen,ShengChanChangJia,DanWei,DanJia,SuYuanFangShi,SuYaunDanWei,SuYuanZhouQi,ShangCiSuYuanDate,JiHuaSuYaunDate,ZhengShuBianHao,CeLiangFanWei,BuQueDingDu,ShiYongCeLiangFanWei,JingDu,JieGuoPingJia,PingJiaUser,QianZiDate,ZhengGai,ChuCiSuYuanDate,QiYongDate,CunFangAddr,GuanLiUser,JiFei,ZhuangTai,BeiZhu,HeDuiUser,TiXingDate,TiXingUser,UserName,TimeStr ");
			strSql.Append(" FROM ERPSheBei ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				SheBeiName=ds.Tables[0].Rows[0]["SheBeiName"].ToString();
				YuanBianHao=ds.Tables[0].Rows[0]["YuanBianHao"].ToString();
				CaiWuBianHao=ds.Tables[0].Rows[0]["CaiWuBianHao"].ToString();
				JiBuBianHao=ds.Tables[0].Rows[0]["JiBuBianHao"].ToString();
				SheBeiLeiBie=ds.Tables[0].Rows[0]["SheBeiLeiBie"].ToString();
				XingHao=ds.Tables[0].Rows[0]["XingHao"].ToString();
				XiangMu=ds.Tables[0].Rows[0]["XiangMu"].ToString();
				ChuChangBianHao=ds.Tables[0].Rows[0]["ChuChangBianHao"].ToString();
				ShiYongBuMen=ds.Tables[0].Rows[0]["ShiYongBuMen"].ToString();
				ShengChanChangJia=ds.Tables[0].Rows[0]["ShengChanChangJia"].ToString();
				DanWei=ds.Tables[0].Rows[0]["DanWei"].ToString();
				DanJia=ds.Tables[0].Rows[0]["DanJia"].ToString();
				SuYuanFangShi=ds.Tables[0].Rows[0]["SuYuanFangShi"].ToString();
				SuYaunDanWei=ds.Tables[0].Rows[0]["SuYaunDanWei"].ToString();
				SuYuanZhouQi=ds.Tables[0].Rows[0]["SuYuanZhouQi"].ToString();
				ShangCiSuYuanDate=ds.Tables[0].Rows[0]["ShangCiSuYuanDate"].ToString();
				JiHuaSuYaunDate=ds.Tables[0].Rows[0]["JiHuaSuYaunDate"].ToString();
				ZhengShuBianHao=ds.Tables[0].Rows[0]["ZhengShuBianHao"].ToString();
				CeLiangFanWei=ds.Tables[0].Rows[0]["CeLiangFanWei"].ToString();
				BuQueDingDu=ds.Tables[0].Rows[0]["BuQueDingDu"].ToString();
				ShiYongCeLiangFanWei=ds.Tables[0].Rows[0]["ShiYongCeLiangFanWei"].ToString();
				JingDu=ds.Tables[0].Rows[0]["JingDu"].ToString();
				JieGuoPingJia=ds.Tables[0].Rows[0]["JieGuoPingJia"].ToString();
				PingJiaUser=ds.Tables[0].Rows[0]["PingJiaUser"].ToString();
				QianZiDate=ds.Tables[0].Rows[0]["QianZiDate"].ToString();
				ZhengGai=ds.Tables[0].Rows[0]["ZhengGai"].ToString();
				ChuCiSuYuanDate=ds.Tables[0].Rows[0]["ChuCiSuYuanDate"].ToString();
				QiYongDate=ds.Tables[0].Rows[0]["QiYongDate"].ToString();
				CunFangAddr=ds.Tables[0].Rows[0]["CunFangAddr"].ToString();
				GuanLiUser=ds.Tables[0].Rows[0]["GuanLiUser"].ToString();
				JiFei=ds.Tables[0].Rows[0]["JiFei"].ToString();
				ZhuangTai=ds.Tables[0].Rows[0]["ZhuangTai"].ToString();
				BeiZhu=ds.Tables[0].Rows[0]["BeiZhu"].ToString();
				HeDuiUser=ds.Tables[0].Rows[0]["HeDuiUser"].ToString();
				TiXingDate=ds.Tables[0].Rows[0]["TiXingDate"].ToString();
				TiXingUser=ds.Tables[0].Rows[0]["TiXingUser"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
			}
		}
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPSheBei");
			strSql.Append(" where ID=@ID ");

			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ERPSheBei(");
			strSql.Append("SheBeiName,YuanBianHao,CaiWuBianHao,JiBuBianHao,SheBeiLeiBie,XingHao,XiangMu,ChuChangBianHao,ShiYongBuMen,ShengChanChangJia,DanWei,DanJia,SuYuanFangShi,SuYaunDanWei,SuYuanZhouQi,ShangCiSuYuanDate,JiHuaSuYaunDate,ZhengShuBianHao,CeLiangFanWei,BuQueDingDu,ShiYongCeLiangFanWei,JingDu,JieGuoPingJia,PingJiaUser,QianZiDate,ZhengGai,ChuCiSuYuanDate,QiYongDate,CunFangAddr,GuanLiUser,JiFei,ZhuangTai,BeiZhu,HeDuiUser,TiXingDate,TiXingUser,UserName,TimeStr)");
			strSql.Append(" values (");
			strSql.Append("@SheBeiName,@YuanBianHao,@CaiWuBianHao,@JiBuBianHao,@SheBeiLeiBie,@XingHao,@XiangMu,@ChuChangBianHao,@ShiYongBuMen,@ShengChanChangJia,@DanWei,@DanJia,@SuYuanFangShi,@SuYaunDanWei,@SuYuanZhouQi,@ShangCiSuYuanDate,@JiHuaSuYaunDate,@ZhengShuBianHao,@CeLiangFanWei,@BuQueDingDu,@ShiYongCeLiangFanWei,@JingDu,@JieGuoPingJia,@PingJiaUser,@QianZiDate,@ZhengGai,@ChuCiSuYuanDate,@QiYongDate,@CunFangAddr,@GuanLiUser,@JiFei,@ZhuangTai,@BeiZhu,@HeDuiUser,@TiXingDate,@TiXingUser,@UserName,@TimeStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SheBeiName", SqlDbType.VarChar,50),
					new SqlParameter("@YuanBianHao", SqlDbType.VarChar,50),
					new SqlParameter("@CaiWuBianHao", SqlDbType.VarChar,50),
					new SqlParameter("@JiBuBianHao", SqlDbType.VarChar,50),
					new SqlParameter("@SheBeiLeiBie", SqlDbType.VarChar,50),
					new SqlParameter("@XingHao", SqlDbType.VarChar,50),
					new SqlParameter("@XiangMu", SqlDbType.VarChar,50),
					new SqlParameter("@ChuChangBianHao", SqlDbType.VarChar,50),
					new SqlParameter("@ShiYongBuMen", SqlDbType.VarChar,50),
					new SqlParameter("@ShengChanChangJia", SqlDbType.VarChar,50),
					new SqlParameter("@DanWei", SqlDbType.VarChar,50),
					new SqlParameter("@DanJia", SqlDbType.VarChar,50),
					new SqlParameter("@SuYuanFangShi", SqlDbType.VarChar,50),
					new SqlParameter("@SuYaunDanWei", SqlDbType.VarChar,50),
					new SqlParameter("@SuYuanZhouQi", SqlDbType.VarChar,50),
					new SqlParameter("@ShangCiSuYuanDate", SqlDbType.VarChar,50),
					new SqlParameter("@JiHuaSuYaunDate", SqlDbType.VarChar,50),
					new SqlParameter("@ZhengShuBianHao", SqlDbType.VarChar,50),
					new SqlParameter("@CeLiangFanWei", SqlDbType.VarChar,50),
					new SqlParameter("@BuQueDingDu", SqlDbType.VarChar,50),
					new SqlParameter("@ShiYongCeLiangFanWei", SqlDbType.VarChar,50),
					new SqlParameter("@JingDu", SqlDbType.VarChar,50),
					new SqlParameter("@JieGuoPingJia", SqlDbType.VarChar,50),
					new SqlParameter("@PingJiaUser", SqlDbType.VarChar,50),
					new SqlParameter("@QianZiDate", SqlDbType.VarChar,50),
					new SqlParameter("@ZhengGai", SqlDbType.VarChar,50),
					new SqlParameter("@ChuCiSuYuanDate", SqlDbType.VarChar,50),
					new SqlParameter("@QiYongDate", SqlDbType.VarChar,50),
					new SqlParameter("@CunFangAddr", SqlDbType.VarChar,50),
					new SqlParameter("@GuanLiUser", SqlDbType.VarChar,50),
					new SqlParameter("@JiFei", SqlDbType.VarChar,50),
					new SqlParameter("@ZhuangTai", SqlDbType.VarChar,50),
					new SqlParameter("@BeiZhu", SqlDbType.VarChar,500),
					new SqlParameter("@HeDuiUser", SqlDbType.VarChar,50),
					new SqlParameter("@TiXingDate", SqlDbType.VarChar,50),
					new SqlParameter("@TiXingUser", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = SheBeiName;
			parameters[1].Value = YuanBianHao;
			parameters[2].Value = CaiWuBianHao;
			parameters[3].Value = JiBuBianHao;
			parameters[4].Value = SheBeiLeiBie;
			parameters[5].Value = XingHao;
			parameters[6].Value = XiangMu;
			parameters[7].Value = ChuChangBianHao;
			parameters[8].Value = ShiYongBuMen;
			parameters[9].Value = ShengChanChangJia;
			parameters[10].Value = DanWei;
			parameters[11].Value = DanJia;
			parameters[12].Value = SuYuanFangShi;
			parameters[13].Value = SuYaunDanWei;
			parameters[14].Value = SuYuanZhouQi;
			parameters[15].Value = ShangCiSuYuanDate;
			parameters[16].Value = JiHuaSuYaunDate;
			parameters[17].Value = ZhengShuBianHao;
			parameters[18].Value = CeLiangFanWei;
			parameters[19].Value = BuQueDingDu;
			parameters[20].Value = ShiYongCeLiangFanWei;
			parameters[21].Value = JingDu;
			parameters[22].Value = JieGuoPingJia;
			parameters[23].Value = PingJiaUser;
			parameters[24].Value = QianZiDate;
			parameters[25].Value = ZhengGai;
			parameters[26].Value = ChuCiSuYuanDate;
			parameters[27].Value = QiYongDate;
			parameters[28].Value = CunFangAddr;
			parameters[29].Value = GuanLiUser;
			parameters[30].Value = JiFei;
			parameters[31].Value = ZhuangTai;
			parameters[32].Value = BeiZhu;
			parameters[33].Value = HeDuiUser;
			parameters[34].Value = TiXingDate;
			parameters[35].Value = TiXingUser;
			parameters[36].Value = UserName;
			parameters[37].Value = TimeStr;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ERPSheBei set ");
			strSql.Append("SheBeiName=@SheBeiName,");
			strSql.Append("YuanBianHao=@YuanBianHao,");
			strSql.Append("CaiWuBianHao=@CaiWuBianHao,");
			strSql.Append("JiBuBianHao=@JiBuBianHao,");
			strSql.Append("SheBeiLeiBie=@SheBeiLeiBie,");
			strSql.Append("XingHao=@XingHao,");
			strSql.Append("XiangMu=@XiangMu,");
			strSql.Append("ChuChangBianHao=@ChuChangBianHao,");
			strSql.Append("ShiYongBuMen=@ShiYongBuMen,");
			strSql.Append("ShengChanChangJia=@ShengChanChangJia,");
			strSql.Append("DanWei=@DanWei,");
			strSql.Append("DanJia=@DanJia,");
			strSql.Append("SuYuanFangShi=@SuYuanFangShi,");
			strSql.Append("SuYaunDanWei=@SuYaunDanWei,");
			strSql.Append("SuYuanZhouQi=@SuYuanZhouQi,");
			strSql.Append("ShangCiSuYuanDate=@ShangCiSuYuanDate,");
			strSql.Append("JiHuaSuYaunDate=@JiHuaSuYaunDate,");
			strSql.Append("ZhengShuBianHao=@ZhengShuBianHao,");
			strSql.Append("CeLiangFanWei=@CeLiangFanWei,");
			strSql.Append("BuQueDingDu=@BuQueDingDu,");
			strSql.Append("ShiYongCeLiangFanWei=@ShiYongCeLiangFanWei,");
			strSql.Append("JingDu=@JingDu,");
			strSql.Append("JieGuoPingJia=@JieGuoPingJia,");
			strSql.Append("PingJiaUser=@PingJiaUser,");
			strSql.Append("QianZiDate=@QianZiDate,");
			strSql.Append("ZhengGai=@ZhengGai,");
			strSql.Append("ChuCiSuYuanDate=@ChuCiSuYuanDate,");
			strSql.Append("QiYongDate=@QiYongDate,");
			strSql.Append("CunFangAddr=@CunFangAddr,");
			strSql.Append("GuanLiUser=@GuanLiUser,");
			strSql.Append("JiFei=@JiFei,");
			strSql.Append("ZhuangTai=@ZhuangTai,");
			strSql.Append("BeiZhu=@BeiZhu,");
			strSql.Append("HeDuiUser=@HeDuiUser,");
			strSql.Append("TiXingDate=@TiXingDate,");
			strSql.Append("TiXingUser=@TiXingUser,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@SheBeiName", SqlDbType.VarChar,50),
					new SqlParameter("@YuanBianHao", SqlDbType.VarChar,50),
					new SqlParameter("@CaiWuBianHao", SqlDbType.VarChar,50),
					new SqlParameter("@JiBuBianHao", SqlDbType.VarChar,50),
					new SqlParameter("@SheBeiLeiBie", SqlDbType.VarChar,50),
					new SqlParameter("@XingHao", SqlDbType.VarChar,50),
					new SqlParameter("@XiangMu", SqlDbType.VarChar,50),
					new SqlParameter("@ChuChangBianHao", SqlDbType.VarChar,50),
					new SqlParameter("@ShiYongBuMen", SqlDbType.VarChar,50),
					new SqlParameter("@ShengChanChangJia", SqlDbType.VarChar,50),
					new SqlParameter("@DanWei", SqlDbType.VarChar,50),
					new SqlParameter("@DanJia", SqlDbType.VarChar,50),
					new SqlParameter("@SuYuanFangShi", SqlDbType.VarChar,50),
					new SqlParameter("@SuYaunDanWei", SqlDbType.VarChar,50),
					new SqlParameter("@SuYuanZhouQi", SqlDbType.VarChar,50),
					new SqlParameter("@ShangCiSuYuanDate", SqlDbType.VarChar,50),
					new SqlParameter("@JiHuaSuYaunDate", SqlDbType.VarChar,50),
					new SqlParameter("@ZhengShuBianHao", SqlDbType.VarChar,50),
					new SqlParameter("@CeLiangFanWei", SqlDbType.VarChar,50),
					new SqlParameter("@BuQueDingDu", SqlDbType.VarChar,50),
					new SqlParameter("@ShiYongCeLiangFanWei", SqlDbType.VarChar,50),
					new SqlParameter("@JingDu", SqlDbType.VarChar,50),
					new SqlParameter("@JieGuoPingJia", SqlDbType.VarChar,50),
					new SqlParameter("@PingJiaUser", SqlDbType.VarChar,50),
					new SqlParameter("@QianZiDate", SqlDbType.VarChar,50),
					new SqlParameter("@ZhengGai", SqlDbType.VarChar,50),
					new SqlParameter("@ChuCiSuYuanDate", SqlDbType.VarChar,50),
					new SqlParameter("@QiYongDate", SqlDbType.VarChar,50),
					new SqlParameter("@CunFangAddr", SqlDbType.VarChar,50),
					new SqlParameter("@GuanLiUser", SqlDbType.VarChar,50),
					new SqlParameter("@JiFei", SqlDbType.VarChar,50),
					new SqlParameter("@ZhuangTai", SqlDbType.VarChar,50),
					new SqlParameter("@BeiZhu", SqlDbType.VarChar,500),
					new SqlParameter("@HeDuiUser", SqlDbType.VarChar,50),
					new SqlParameter("@TiXingDate", SqlDbType.VarChar,50),
					new SqlParameter("@TiXingUser", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = ID;
			parameters[1].Value = SheBeiName;
			parameters[2].Value = YuanBianHao;
			parameters[3].Value = CaiWuBianHao;
			parameters[4].Value = JiBuBianHao;
			parameters[5].Value = SheBeiLeiBie;
			parameters[6].Value = XingHao;
			parameters[7].Value = XiangMu;
			parameters[8].Value = ChuChangBianHao;
			parameters[9].Value = ShiYongBuMen;
			parameters[10].Value = ShengChanChangJia;
			parameters[11].Value = DanWei;
			parameters[12].Value = DanJia;
			parameters[13].Value = SuYuanFangShi;
			parameters[14].Value = SuYaunDanWei;
			parameters[15].Value = SuYuanZhouQi;
			parameters[16].Value = ShangCiSuYuanDate;
			parameters[17].Value = JiHuaSuYaunDate;
			parameters[18].Value = ZhengShuBianHao;
			parameters[19].Value = CeLiangFanWei;
			parameters[20].Value = BuQueDingDu;
			parameters[21].Value = ShiYongCeLiangFanWei;
			parameters[22].Value = JingDu;
			parameters[23].Value = JieGuoPingJia;
			parameters[24].Value = PingJiaUser;
			parameters[25].Value = QianZiDate;
			parameters[26].Value = ZhengGai;
			parameters[27].Value = ChuCiSuYuanDate;
			parameters[28].Value = QiYongDate;
			parameters[29].Value = CunFangAddr;
			parameters[30].Value = GuanLiUser;
			parameters[31].Value = JiFei;
			parameters[32].Value = ZhuangTai;
			parameters[33].Value = BeiZhu;
			parameters[34].Value = HeDuiUser;
			parameters[35].Value = TiXingDate;
			parameters[36].Value = TiXingUser;
			parameters[37].Value = UserName;
			parameters[38].Value = TimeStr;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPSheBei ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public void GetModel(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,SheBeiName,YuanBianHao,CaiWuBianHao,JiBuBianHao,SheBeiLeiBie,XingHao,XiangMu,ChuChangBianHao,ShiYongBuMen,ShengChanChangJia,DanWei,DanJia,SuYuanFangShi,SuYaunDanWei,SuYuanZhouQi,ShangCiSuYuanDate,JiHuaSuYaunDate,ZhengShuBianHao,CeLiangFanWei,BuQueDingDu,ShiYongCeLiangFanWei,JingDu,JieGuoPingJia,PingJiaUser,QianZiDate,ZhengGai,ChuCiSuYuanDate,QiYongDate,CunFangAddr,GuanLiUser,JiFei,ZhuangTai,BeiZhu,HeDuiUser,TiXingDate,TiXingUser,UserName,TimeStr ");
			strSql.Append(" FROM ERPSheBei ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				SheBeiName=ds.Tables[0].Rows[0]["SheBeiName"].ToString();
				YuanBianHao=ds.Tables[0].Rows[0]["YuanBianHao"].ToString();
				CaiWuBianHao=ds.Tables[0].Rows[0]["CaiWuBianHao"].ToString();
				JiBuBianHao=ds.Tables[0].Rows[0]["JiBuBianHao"].ToString();
				SheBeiLeiBie=ds.Tables[0].Rows[0]["SheBeiLeiBie"].ToString();
				XingHao=ds.Tables[0].Rows[0]["XingHao"].ToString();
				XiangMu=ds.Tables[0].Rows[0]["XiangMu"].ToString();
				ChuChangBianHao=ds.Tables[0].Rows[0]["ChuChangBianHao"].ToString();
				ShiYongBuMen=ds.Tables[0].Rows[0]["ShiYongBuMen"].ToString();
				ShengChanChangJia=ds.Tables[0].Rows[0]["ShengChanChangJia"].ToString();
				DanWei=ds.Tables[0].Rows[0]["DanWei"].ToString();
				DanJia=ds.Tables[0].Rows[0]["DanJia"].ToString();
				SuYuanFangShi=ds.Tables[0].Rows[0]["SuYuanFangShi"].ToString();
				SuYaunDanWei=ds.Tables[0].Rows[0]["SuYaunDanWei"].ToString();
				SuYuanZhouQi=ds.Tables[0].Rows[0]["SuYuanZhouQi"].ToString();
				ShangCiSuYuanDate=ds.Tables[0].Rows[0]["ShangCiSuYuanDate"].ToString();
				JiHuaSuYaunDate=ds.Tables[0].Rows[0]["JiHuaSuYaunDate"].ToString();
				ZhengShuBianHao=ds.Tables[0].Rows[0]["ZhengShuBianHao"].ToString();
				CeLiangFanWei=ds.Tables[0].Rows[0]["CeLiangFanWei"].ToString();
				BuQueDingDu=ds.Tables[0].Rows[0]["BuQueDingDu"].ToString();
				ShiYongCeLiangFanWei=ds.Tables[0].Rows[0]["ShiYongCeLiangFanWei"].ToString();
				JingDu=ds.Tables[0].Rows[0]["JingDu"].ToString();
				JieGuoPingJia=ds.Tables[0].Rows[0]["JieGuoPingJia"].ToString();
				PingJiaUser=ds.Tables[0].Rows[0]["PingJiaUser"].ToString();
				QianZiDate=ds.Tables[0].Rows[0]["QianZiDate"].ToString();
				ZhengGai=ds.Tables[0].Rows[0]["ZhengGai"].ToString();
				ChuCiSuYuanDate=ds.Tables[0].Rows[0]["ChuCiSuYuanDate"].ToString();
				QiYongDate=ds.Tables[0].Rows[0]["QiYongDate"].ToString();
				CunFangAddr=ds.Tables[0].Rows[0]["CunFangAddr"].ToString();
				GuanLiUser=ds.Tables[0].Rows[0]["GuanLiUser"].ToString();
				JiFei=ds.Tables[0].Rows[0]["JiFei"].ToString();
				ZhuangTai=ds.Tables[0].Rows[0]["ZhuangTai"].ToString();
				BeiZhu=ds.Tables[0].Rows[0]["BeiZhu"].ToString();
				HeDuiUser=ds.Tables[0].Rows[0]["HeDuiUser"].ToString();
				TiXingDate=ds.Tables[0].Rows[0]["TiXingDate"].ToString();
				TiXingUser=ds.Tables[0].Rows[0]["TiXingUser"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPSheBei ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

