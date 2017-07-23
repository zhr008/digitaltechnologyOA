using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPContract。
	/// </summary>
	public class ERPContract
	{
		public ERPContract()
		{}
		#region Model
		private int _id;
		private string _hetongname;
		private string _hetongserils;
		private string _hetongleixing;
		private string _qianyuekehu;
		private string _hetongmiaoshu;
		private string _hetongtiaokuan;
		private string _hetongcontent;
		private DateTime? _shengxiaodate;
		private DateTime? _zhongzhidate;
		private DateTime? _tixingdate;
		private string _qianyuerenbuy;
		private string _qianyuerensell;
		private DateTime? _createtime;
		private string _createuser;
		private string _fujianlist;
		private string _backinfo;
		private string _nowstate;
        private string _htzj;
        private string _yffy;
        private string _sfjf;
        private string _sqfy;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 合同名称
		/// </summary>
		public string HeTongName
		{
			set{ _hetongname=value;}
			get{return _hetongname;}
		}
		/// <summary>
		/// 合同编号
		/// </summary>
		public string HeTongSerils
		{
			set{ _hetongserils=value;}
			get{return _hetongserils;}
		}
		/// <summary>
		/// 合同类型
		/// </summary>
		public string HeTongLeiXing
		{
			set{ _hetongleixing=value;}
			get{return _hetongleixing;}
		}
		/// <summary>
		/// 签约客户
		/// </summary>
		public string QianYueKeHu
		{
			set{ _qianyuekehu=value;}
			get{return _qianyuekehu;}
		}
		/// <summary>
		/// 合同描述
		/// </summary>
		public string HeTongMiaoShu
		{
			set{ _hetongmiaoshu=value;}
			get{return _hetongmiaoshu;}
		}
		/// <summary>
		/// 合同条款
		/// </summary>
		public string HeTongTiaoKuan
		{
			set{ _hetongtiaokuan=value;}
			get{return _hetongtiaokuan;}
		}
		/// <summary>
		/// 合同内容
		/// </summary>
		public string HeTongContent
		{
			set{ _hetongcontent=value;}
			get{return _hetongcontent;}
		}
		/// <summary>
		/// 生效日期
		/// </summary>
		public DateTime? ShengXiaoDate
		{
			set{ _shengxiaodate=value;}
			get{return _shengxiaodate;}
		}
		/// <summary>
		/// 终止日期
		/// </summary>
		public DateTime? ZhongZhiDate
		{
			set{ _zhongzhidate=value;}
			get{return _zhongzhidate;}
		}
		/// <summary>
		/// 提醒日期
		/// </summary>
		public DateTime? TiXingDate
		{
			set{ _tixingdate=value;}
			get{return _tixingdate;}
		}
		/// <summary>
		/// 签约人（买方）
		/// </summary>
		public string QianYueRenBuy
		{
			set{ _qianyuerenbuy=value;}
			get{return _qianyuerenbuy;}
		}
		/// <summary>
		/// 签约人（卖方）
		/// </summary>
		public string QianYueRenSell
		{
			set{ _qianyuerensell=value;}
			get{return _qianyuerensell;}
		}
		/// <summary>
		/// 创建日期
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public string CreateUser
		{
			set{ _createuser=value;}
			get{return _createuser;}
		}
		/// <summary>
		/// 附件文件
		/// </summary>
		public string FuJianList
		{
			set{ _fujianlist=value;}
			get{return _fujianlist;}
		}
		/// <summary>
		/// 备注信息
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		/// <summary>
		/// 当前状态
		/// </summary>
		public string NowState
		{
			set{ _nowstate=value;}
			get{return _nowstate;}
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
		public ERPContract(int ID)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select ID,HeTongName,HeTongSerils,HeTongLeiXing,QianYueKeHu,HeTongMiaoShu,HeTongTiaoKuan,HeTongContent,ShengXiaoDate,ZhongZhiDate,TiXingDate,QianYueRenBuy,QianYueRenSell,CreateTime,CreateUser,FuJianList,BackInfo,NowState,HTZJ,YFFY,SFJF,SQFY ");
			strSql.Append(" FROM ERPContract ");
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
				HeTongName=ds.Tables[0].Rows[0]["HeTongName"].ToString();
				HeTongSerils=ds.Tables[0].Rows[0]["HeTongSerils"].ToString();
				HeTongLeiXing=ds.Tables[0].Rows[0]["HeTongLeiXing"].ToString();
				QianYueKeHu=ds.Tables[0].Rows[0]["QianYueKeHu"].ToString();
				HeTongMiaoShu=ds.Tables[0].Rows[0]["HeTongMiaoShu"].ToString();
				HeTongTiaoKuan=ds.Tables[0].Rows[0]["HeTongTiaoKuan"].ToString();
				HeTongContent=ds.Tables[0].Rows[0]["HeTongContent"].ToString();
				if(ds.Tables[0].Rows[0]["ShengXiaoDate"].ToString()!="")
				{
					ShengXiaoDate=DateTime.Parse(ds.Tables[0].Rows[0]["ShengXiaoDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ZhongZhiDate"].ToString()!="")
				{
					ZhongZhiDate=DateTime.Parse(ds.Tables[0].Rows[0]["ZhongZhiDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TiXingDate"].ToString()!="")
				{
					TiXingDate=DateTime.Parse(ds.Tables[0].Rows[0]["TiXingDate"].ToString());
				}
				QianYueRenBuy=ds.Tables[0].Rows[0]["QianYueRenBuy"].ToString();
				QianYueRenSell=ds.Tables[0].Rows[0]["QianYueRenSell"].ToString();
				if(ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
				CreateUser=ds.Tables[0].Rows[0]["CreateUser"].ToString();
				FuJianList=ds.Tables[0].Rows[0]["FuJianList"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				NowState=ds.Tables[0].Rows[0]["NowState"].ToString();
                HTZJ = ds.Tables[0].Rows[0]["HTZJ"].ToString();
                YFFY = ds.Tables[0].Rows[0]["YFFY"].ToString();
                SFJF = ds.Tables[0].Rows[0]["SFJF"].ToString();
                SQFY = ds.Tables[0].Rows[0]["SQFY"].ToString();
               
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPContract"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPContract");
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
			strSql.Append("insert into ERPContract(");
            strSql.Append("HeTongName,HeTongSerils,HeTongLeiXing,QianYueKeHu,HeTongMiaoShu,HeTongTiaoKuan,HeTongContent,ShengXiaoDate,ZhongZhiDate,TiXingDate,QianYueRenBuy,QianYueRenSell,CreateTime,CreateUser,FuJianList,BackInfo,NowState,HTZJ,YFFY,SFJF,SQFY)");
			strSql.Append(" values (");
            strSql.Append("@HeTongName,@HeTongSerils,@HeTongLeiXing,@QianYueKeHu,@HeTongMiaoShu,@HeTongTiaoKuan,@HeTongContent,@ShengXiaoDate,@ZhongZhiDate,@TiXingDate,@QianYueRenBuy,@QianYueRenSell,@CreateTime,@CreateUser,@FuJianList,@BackInfo,@NowState,@HTZJ,@YFFY,@SFJF,@SQFY)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@HeTongName", SqlDbType.VarChar,200),
					new SqlParameter("@HeTongSerils", SqlDbType.VarChar,50),
					new SqlParameter("@HeTongLeiXing", SqlDbType.VarChar,50),
					new SqlParameter("@QianYueKeHu", SqlDbType.VarChar,200),
					new SqlParameter("@HeTongMiaoShu", SqlDbType.VarChar,8000),
					new SqlParameter("@HeTongTiaoKuan", SqlDbType.VarChar,8000),
					new SqlParameter("@HeTongContent", SqlDbType.Text),
					new SqlParameter("@ShengXiaoDate", SqlDbType.DateTime),
					new SqlParameter("@ZhongZhiDate", SqlDbType.DateTime),
					new SqlParameter("@TiXingDate", SqlDbType.DateTime),
					new SqlParameter("@QianYueRenBuy", SqlDbType.VarChar,50),
					new SqlParameter("@QianYueRenSell", SqlDbType.VarChar,50),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@CreateUser", SqlDbType.VarChar,50),
					new SqlParameter("@FuJianList", SqlDbType.VarChar,500),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,8000),
					new SqlParameter("@NowState", SqlDbType.VarChar,50),
                                        new SqlParameter("@HTZJ", SqlDbType.VarChar,50),
                                        new SqlParameter("@YFFY", SqlDbType.VarChar,50),
                                        new SqlParameter("@SFJF", SqlDbType.VarChar,50),
                                        new SqlParameter("@SQFY", SqlDbType.VarChar,50)};
			parameters[0].Value = HeTongName;
			parameters[1].Value = HeTongSerils;
			parameters[2].Value = HeTongLeiXing;
			parameters[3].Value = QianYueKeHu;
			parameters[4].Value = HeTongMiaoShu;
			parameters[5].Value = HeTongTiaoKuan;
			parameters[6].Value = HeTongContent;
			parameters[7].Value = ShengXiaoDate;
			parameters[8].Value = ZhongZhiDate;
			parameters[9].Value = TiXingDate;
			parameters[10].Value = QianYueRenBuy;
			parameters[11].Value = QianYueRenSell;
			parameters[12].Value = CreateTime;
			parameters[13].Value = CreateUser;
			parameters[14].Value = FuJianList;
			parameters[15].Value = BackInfo;
			parameters[16].Value = NowState;
            parameters[17].Value = HTZJ;
            parameters[18].Value = YFFY;
            parameters[19].Value = SFJF;
            parameters[20].Value = SQFY;

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
			strSql.Append("update ERPContract set ");
			strSql.Append("HeTongName=@HeTongName,");
			strSql.Append("HeTongSerils=@HeTongSerils,");
			strSql.Append("HeTongLeiXing=@HeTongLeiXing,");
			strSql.Append("QianYueKeHu=@QianYueKeHu,");
			strSql.Append("HeTongMiaoShu=@HeTongMiaoShu,");
			strSql.Append("HeTongTiaoKuan=@HeTongTiaoKuan,");
			strSql.Append("HeTongContent=@HeTongContent,");
			strSql.Append("ShengXiaoDate=@ShengXiaoDate,");
			strSql.Append("ZhongZhiDate=@ZhongZhiDate,");
			strSql.Append("TiXingDate=@TiXingDate,");
			strSql.Append("QianYueRenBuy=@QianYueRenBuy,");
			strSql.Append("QianYueRenSell=@QianYueRenSell,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("CreateUser=@CreateUser,");
			strSql.Append("FuJianList=@FuJianList,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append("NowState=@NowState,");
            strSql.Append("HTZJ=@HTZJ,");
            strSql.Append("YFFY=@YFFY,");
            strSql.Append("SFJF=@SFJF,");
            strSql.Append("SQFY=@SQFY");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@HeTongName", SqlDbType.VarChar,200),
					new SqlParameter("@HeTongSerils", SqlDbType.VarChar,50),
					new SqlParameter("@HeTongLeiXing", SqlDbType.VarChar,50),
					new SqlParameter("@QianYueKeHu", SqlDbType.VarChar,200),
					new SqlParameter("@HeTongMiaoShu", SqlDbType.VarChar,8000),
					new SqlParameter("@HeTongTiaoKuan", SqlDbType.VarChar,8000),
					new SqlParameter("@HeTongContent", SqlDbType.Text),
					new SqlParameter("@ShengXiaoDate", SqlDbType.DateTime),
					new SqlParameter("@ZhongZhiDate", SqlDbType.DateTime),
					new SqlParameter("@TiXingDate", SqlDbType.DateTime),
					new SqlParameter("@QianYueRenBuy", SqlDbType.VarChar,50),
					new SqlParameter("@QianYueRenSell", SqlDbType.VarChar,50),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@CreateUser", SqlDbType.VarChar,50),
					new SqlParameter("@FuJianList", SqlDbType.VarChar,500),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,8000),
					new SqlParameter("@NowState", SqlDbType.VarChar,50), 
                    new SqlParameter("@HTZJ", SqlDbType.VarChar,50),
                                        new SqlParameter("@YFFY", SqlDbType.VarChar,50),
                                        new SqlParameter("@SFJF", SqlDbType.VarChar,50),
                                        new SqlParameter("@SQFY", SqlDbType.VarChar,50)};
			parameters[0].Value = ID;
			parameters[1].Value = HeTongName;
			parameters[2].Value = HeTongSerils;
			parameters[3].Value = HeTongLeiXing;
			parameters[4].Value = QianYueKeHu;
			parameters[5].Value = HeTongMiaoShu;
			parameters[6].Value = HeTongTiaoKuan;
			parameters[7].Value = HeTongContent;
			parameters[8].Value = ShengXiaoDate;
			parameters[9].Value = ZhongZhiDate;
			parameters[10].Value = TiXingDate;
			parameters[11].Value = QianYueRenBuy;
			parameters[12].Value = QianYueRenSell;
			parameters[13].Value = CreateTime;
			parameters[14].Value = CreateUser;
			parameters[15].Value = FuJianList;
			parameters[16].Value = BackInfo;
			parameters[17].Value = NowState;
            parameters[18].Value = HTZJ;
            parameters[19].Value = YFFY;
            parameters[20].Value = SFJF;
            parameters[21].Value = SQFY;
			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPContract ");
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
            strSql.Append("select  top 1 ID,HeTongName,HeTongSerils,HeTongLeiXing,QianYueKeHu,HeTongMiaoShu,HeTongTiaoKuan,HeTongContent,ShengXiaoDate,ZhongZhiDate,TiXingDate,QianYueRenBuy,QianYueRenSell,CreateTime,CreateUser,FuJianList,BackInfo,NowState,HTZJ,YFFY,SFJF,SQFY ");
			strSql.Append(" FROM ERPContract ");
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
				HeTongName=ds.Tables[0].Rows[0]["HeTongName"].ToString();
				HeTongSerils=ds.Tables[0].Rows[0]["HeTongSerils"].ToString();
				HeTongLeiXing=ds.Tables[0].Rows[0]["HeTongLeiXing"].ToString();
				QianYueKeHu=ds.Tables[0].Rows[0]["QianYueKeHu"].ToString();
				HeTongMiaoShu=ds.Tables[0].Rows[0]["HeTongMiaoShu"].ToString();
				HeTongTiaoKuan=ds.Tables[0].Rows[0]["HeTongTiaoKuan"].ToString();
				HeTongContent=ds.Tables[0].Rows[0]["HeTongContent"].ToString();
				if(ds.Tables[0].Rows[0]["ShengXiaoDate"].ToString()!="")
				{
					ShengXiaoDate=DateTime.Parse(ds.Tables[0].Rows[0]["ShengXiaoDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ZhongZhiDate"].ToString()!="")
				{
					ZhongZhiDate=DateTime.Parse(ds.Tables[0].Rows[0]["ZhongZhiDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TiXingDate"].ToString()!="")
				{
					TiXingDate=DateTime.Parse(ds.Tables[0].Rows[0]["TiXingDate"].ToString());
				}
				QianYueRenBuy=ds.Tables[0].Rows[0]["QianYueRenBuy"].ToString();
				QianYueRenSell=ds.Tables[0].Rows[0]["QianYueRenSell"].ToString();
				if(ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
				CreateUser=ds.Tables[0].Rows[0]["CreateUser"].ToString();
				FuJianList=ds.Tables[0].Rows[0]["FuJianList"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				NowState=ds.Tables[0].Rows[0]["NowState"].ToString();
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPContract ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public void HZ()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ERPContract ");
            strSql.Append(" set HTZJ=(select sum(b.ZongJia) from ERPContractChanPin b where b.HeTongName=a.HeTongName),YFFY=(select sum(convert(float, c.HTJE)) from ERPYS c where c.HeTongName=a.HeTongName and c.SFDK='是' and c.NowState='S'),SQFY= HTZJ -YFFY , SFJF=(select case when exists(select * from ERPContractChanPin b where b.HeTongName=a.HeTongName and b.IFJiaoFu='未交付') then '未交付' when not exists (select * from ERPContractChanPin b where b.HeTongName=a.HeTongName) then '未交付' else '已交付' end),NowState= (select case  when  exists (select * from ERPBuyOrder F where F.OrderName=a.HeTongName and SFJF='已交付') and NowState like '%通过审核%'  then '完成采购' else NowState end) from ERPContract a");
          
            DbHelperSQL.Query(strSql.ToString());
        }



        public string GetSerils()
        {
            DateTime dt = DateTime.Today;
           string sPreFix = "YL-" + dt.Year.ToString() + dt.Month.ToString().PadLeft(2, '0') + "-X-";
            // string sPreFix = "RWCC-" + dt.Year.ToString() + dt.Month.ToString().PadLeft(2, '0') + "-X-";
            string sSql = "select HeTongSerils from ERPContract where HeTongSerils like @PreFix order by ID desc ";
            SqlParameter[] parameters = {
					new SqlParameter("@PreFix", SqlDbType.VarChar,50)};
            parameters[0].Value = sPreFix + "%";
            DataSet ds = DbHelperSQL.Query(sSql, parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                string sSerils = ds.Tables[0].Rows[0]["HeTongSerils"].ToString();
                return sPreFix + (Int32.Parse(sSerils.Substring(12)) + 1).ToString().PadLeft(4, '0');
                //return sPreFix + (Int32.Parse(sSerils.Substring(14)) + 1).ToString().PadLeft(4, '0');
            }
            return sPreFix + "0001";
        }
		#endregion  成员方法
	}
}

