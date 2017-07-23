using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPBuyChanPin。
	/// </summary>
	public class ERPBuyChanPin
	{
		public ERPBuyChanPin()
		{}
		#region Model
		private int _id;
		private string _ordername;
		private string _productname;
		private string _productserils;
		private string _gongyingshang;
		private string _producttype;
		private string _xinghao;
		private string _danwei;
		private decimal? _danjia;
		private decimal? _shuliang;
		private decimal? _zongjia;
		private decimal? _yifukuan;
		private decimal? _qiankuanshu;
		private string _ifjiaofu;
		private string _chanpinmiaoshu;
		private string _username;
		private DateTime? _timestr;
		private string _backinfo;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 订单名称
		/// </summary>
		public string OrderName
		{
			set{ _ordername=value;}
			get{return _ordername;}
		}
		/// <summary>
		/// 产品名称
		/// </summary>
		public string ProductName
		{
			set{ _productname=value;}
			get{return _productname;}
		}
		/// <summary>
		/// 产品编码
		/// </summary>
		public string ProductSerils
		{
			set{ _productserils=value;}
			get{return _productserils;}
		}
		/// <summary>
		/// 产品供应商
		/// </summary>
		public string GongYingShang
		{
			set{ _gongyingshang=value;}
			get{return _gongyingshang;}
		}
		/// <summary>
		/// 产品类别
		/// </summary>
		public string ProductType
		{
			set{ _producttype=value;}
			get{return _producttype;}
		}
		/// <summary>
		/// 产品型号
		/// </summary>
		public string XingHao
		{
			set{ _xinghao=value;}
			get{return _xinghao;}
		}
		/// <summary>
		/// 计量单位
		/// </summary>
		public string DanWei
		{
			set{ _danwei=value;}
			get{return _danwei;}
		}
		/// <summary>
		/// 单价
		/// </summary>
		public decimal? DanJia
		{
			set{ _danjia=value;}
			get{return _danjia;}
		}
		/// <summary>
		/// 数量
		/// </summary>
		public decimal? ShuLiang
		{
			set{ _shuliang=value;}
			get{return _shuliang;}
		}
		/// <summary>
		/// 总价
		/// </summary>
		public decimal? ZongJia
		{
			set{ _zongjia=value;}
			get{return _zongjia;}
		}
		/// <summary>
		/// 已付款数
		/// </summary>
		public decimal? YiFuKuan
		{
			set{ _yifukuan=value;}
			get{return _yifukuan;}
		}
		/// <summary>
		/// 欠款数
		/// </summary>
		public decimal? QianKuanShu
		{
			set{ _qiankuanshu=value;}
			get{return _qiankuanshu;}
		}
		/// <summary>
		/// 是否交付（交付后库存添加）
		/// </summary>
		public string IFJiaoFu
		{
			set{ _ifjiaofu=value;}
			get{return _ifjiaofu;}
		}
		/// <summary>
		/// 产品描述
		/// </summary>
		public string ChanPinMiaoShu
		{
			set{ _chanpinmiaoshu=value;}
			get{return _chanpinmiaoshu;}
		}
		/// <summary>
		/// 填写人
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 填写时间
		/// </summary>
		public DateTime? TimeStr
		{
			set{ _timestr=value;}
			get{return _timestr;}
		}
		/// <summary>
		/// 备注说明
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		#endregion Model


		#region  成员方法

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPBuyChanPin(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,OrderName,ProductName,ProductSerils,GongYingShang,ProductType,XingHao,DanWei,DanJia,ShuLiang,ZongJia,YiFuKuan,QianKuanShu,IFJiaoFu,ChanPinMiaoShu,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPBuyChanPin ");
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
				OrderName=ds.Tables[0].Rows[0]["OrderName"].ToString();
				ProductName=ds.Tables[0].Rows[0]["ProductName"].ToString();
				ProductSerils=ds.Tables[0].Rows[0]["ProductSerils"].ToString();
				GongYingShang=ds.Tables[0].Rows[0]["GongYingShang"].ToString();
				ProductType=ds.Tables[0].Rows[0]["ProductType"].ToString();
				XingHao=ds.Tables[0].Rows[0]["XingHao"].ToString();
				DanWei=ds.Tables[0].Rows[0]["DanWei"].ToString();
				if(ds.Tables[0].Rows[0]["DanJia"].ToString()!="")
				{
					DanJia=decimal.Parse(ds.Tables[0].Rows[0]["DanJia"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ShuLiang"].ToString()!="")
				{
					ShuLiang=decimal.Parse(ds.Tables[0].Rows[0]["ShuLiang"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ZongJia"].ToString()!="")
				{
					ZongJia=decimal.Parse(ds.Tables[0].Rows[0]["ZongJia"].ToString());
				}
				if(ds.Tables[0].Rows[0]["YiFuKuan"].ToString()!="")
				{
					YiFuKuan=decimal.Parse(ds.Tables[0].Rows[0]["YiFuKuan"].ToString());
				}
				if(ds.Tables[0].Rows[0]["QianKuanShu"].ToString()!="")
				{
					QianKuanShu=decimal.Parse(ds.Tables[0].Rows[0]["QianKuanShu"].ToString());
				}
				IFJiaoFu=ds.Tables[0].Rows[0]["IFJiaoFu"].ToString();
				ChanPinMiaoShu=ds.Tables[0].Rows[0]["ChanPinMiaoShu"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPBuyChanPin"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPBuyChanPin");
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
			strSql.Append("insert into ERPBuyChanPin(");
			strSql.Append("OrderName,ProductName,ProductSerils,GongYingShang,ProductType,XingHao,DanWei,DanJia,ShuLiang,ZongJia,YiFuKuan,QianKuanShu,IFJiaoFu,ChanPinMiaoShu,UserName,TimeStr,BackInfo)");
			strSql.Append(" values (");
			strSql.Append("@OrderName,@ProductName,@ProductSerils,@GongYingShang,@ProductType,@XingHao,@DanWei,@DanJia,@ShuLiang,@ZongJia,@YiFuKuan,@QianKuanShu,@IFJiaoFu,@ChanPinMiaoShu,@UserName,@TimeStr,@BackInfo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@OrderName", SqlDbType.VarChar,50),
					new SqlParameter("@ProductName", SqlDbType.VarChar,50),
					new SqlParameter("@ProductSerils", SqlDbType.VarChar,50),
					new SqlParameter("@GongYingShang", SqlDbType.VarChar,50),
					new SqlParameter("@ProductType", SqlDbType.VarChar,50),
					new SqlParameter("@XingHao", SqlDbType.VarChar,50),
					new SqlParameter("@DanWei", SqlDbType.VarChar,50),
					new SqlParameter("@DanJia", SqlDbType.Decimal,9),
					new SqlParameter("@ShuLiang", SqlDbType.Decimal,9),
					new SqlParameter("@ZongJia", SqlDbType.Decimal,9),
					new SqlParameter("@YiFuKuan", SqlDbType.Decimal,9),
					new SqlParameter("@QianKuanShu", SqlDbType.Decimal,9),
					new SqlParameter("@IFJiaoFu", SqlDbType.VarChar,50),
					new SqlParameter("@ChanPinMiaoShu", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = OrderName;
			parameters[1].Value = ProductName;
			parameters[2].Value = ProductSerils;
			parameters[3].Value = GongYingShang;
			parameters[4].Value = ProductType;
			parameters[5].Value = XingHao;
			parameters[6].Value = DanWei;
			parameters[7].Value = DanJia;
			parameters[8].Value = ShuLiang;
			parameters[9].Value = ZongJia;
			parameters[10].Value = YiFuKuan;
			parameters[11].Value = QianKuanShu;
			parameters[12].Value = IFJiaoFu;
			parameters[13].Value = ChanPinMiaoShu;
			parameters[14].Value = UserName;
			parameters[15].Value = TimeStr;
			parameters[16].Value = BackInfo;

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
			strSql.Append("update ERPBuyChanPin set ");
			strSql.Append("OrderName=@OrderName,");
			strSql.Append("ProductName=@ProductName,");
			strSql.Append("ProductSerils=@ProductSerils,");
			strSql.Append("GongYingShang=@GongYingShang,");
			strSql.Append("ProductType=@ProductType,");
			strSql.Append("XingHao=@XingHao,");
			strSql.Append("DanWei=@DanWei,");
			strSql.Append("DanJia=@DanJia,");
			strSql.Append("ShuLiang=@ShuLiang,");
			strSql.Append("ZongJia=@ZongJia,");
			strSql.Append("YiFuKuan=@YiFuKuan,");
			strSql.Append("QianKuanShu=@QianKuanShu,");
			strSql.Append("IFJiaoFu=@IFJiaoFu,");
			strSql.Append("ChanPinMiaoShu=@ChanPinMiaoShu,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr,");
			strSql.Append("BackInfo=@BackInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@OrderName", SqlDbType.VarChar,50),
					new SqlParameter("@ProductName", SqlDbType.VarChar,50),
					new SqlParameter("@ProductSerils", SqlDbType.VarChar,50),
					new SqlParameter("@GongYingShang", SqlDbType.VarChar,50),
					new SqlParameter("@ProductType", SqlDbType.VarChar,50),
					new SqlParameter("@XingHao", SqlDbType.VarChar,50),
					new SqlParameter("@DanWei", SqlDbType.VarChar,50),
					new SqlParameter("@DanJia", SqlDbType.Decimal,9),
					new SqlParameter("@ShuLiang", SqlDbType.Decimal,9),
					new SqlParameter("@ZongJia", SqlDbType.Decimal,9),
					new SqlParameter("@YiFuKuan", SqlDbType.Decimal,9),
					new SqlParameter("@QianKuanShu", SqlDbType.Decimal,9),
					new SqlParameter("@IFJiaoFu", SqlDbType.VarChar,50),
					new SqlParameter("@ChanPinMiaoShu", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = ID;
			parameters[1].Value = OrderName;
			parameters[2].Value = ProductName;
			parameters[3].Value = ProductSerils;
			parameters[4].Value = GongYingShang;
			parameters[5].Value = ProductType;
			parameters[6].Value = XingHao;
			parameters[7].Value = DanWei;
			parameters[8].Value = DanJia;
			parameters[9].Value = ShuLiang;
			parameters[10].Value = ZongJia;
			parameters[11].Value = YiFuKuan;
			parameters[12].Value = QianKuanShu;
			parameters[13].Value = IFJiaoFu;
			parameters[14].Value = ChanPinMiaoShu;
			parameters[15].Value = UserName;
			parameters[16].Value = TimeStr;
			parameters[17].Value = BackInfo;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPBuyChanPin ");
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
			strSql.Append("select  top 1 ID,OrderName,ProductName,ProductSerils,GongYingShang,ProductType,XingHao,DanWei,DanJia,ShuLiang,ZongJia,YiFuKuan,QianKuanShu,IFJiaoFu,ChanPinMiaoShu,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPBuyChanPin ");
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
				OrderName=ds.Tables[0].Rows[0]["OrderName"].ToString();
				ProductName=ds.Tables[0].Rows[0]["ProductName"].ToString();
				ProductSerils=ds.Tables[0].Rows[0]["ProductSerils"].ToString();
				GongYingShang=ds.Tables[0].Rows[0]["GongYingShang"].ToString();
				ProductType=ds.Tables[0].Rows[0]["ProductType"].ToString();
				XingHao=ds.Tables[0].Rows[0]["XingHao"].ToString();
				DanWei=ds.Tables[0].Rows[0]["DanWei"].ToString();
				if(ds.Tables[0].Rows[0]["DanJia"].ToString()!="")
				{
					DanJia=decimal.Parse(ds.Tables[0].Rows[0]["DanJia"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ShuLiang"].ToString()!="")
				{
					ShuLiang=decimal.Parse(ds.Tables[0].Rows[0]["ShuLiang"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ZongJia"].ToString()!="")
				{
					ZongJia=decimal.Parse(ds.Tables[0].Rows[0]["ZongJia"].ToString());
				}
				if(ds.Tables[0].Rows[0]["YiFuKuan"].ToString()!="")
				{
					YiFuKuan=decimal.Parse(ds.Tables[0].Rows[0]["YiFuKuan"].ToString());
				}
				if(ds.Tables[0].Rows[0]["QianKuanShu"].ToString()!="")
				{
					QianKuanShu=decimal.Parse(ds.Tables[0].Rows[0]["QianKuanShu"].ToString());
				}
				IFJiaoFu=ds.Tables[0].Rows[0]["IFJiaoFu"].ToString();
				ChanPinMiaoShu=ds.Tables[0].Rows[0]["ChanPinMiaoShu"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPBuyChanPin ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

