using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPSupplys。
	/// </summary>
	public class ERPSupplys
	{
		public ERPSupplys()
		{}
		#region Model
		private int _id;
		private string _supplysname;
		private string _serils;
		private string _jiancheng;
		private string _dianhua;
		private string _mobtel;
		private string _chuanzhen;
		private string _urlstr;
		private string _emailstr;
		private string _diqu;
		private string _youbian;
		private string _address;
		private string _kaihuhang;
		private string _zhanghao;
		private string _backinfo;
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
		/// 供应商名称
		/// </summary>
		public string SupplysName
		{
			set{ _supplysname=value;}
			get{return _supplysname;}
		}
		/// <summary>
		/// 供应商编码
		/// </summary>
		public string Serils
		{
			set{ _serils=value;}
			get{return _serils;}
		}
		/// <summary>
		/// 供应商简称
		/// </summary>
		public string JianCheng
		{
			set{ _jiancheng=value;}
			get{return _jiancheng;}
		}
		/// <summary>
		/// 固定电话
		/// </summary>
		public string DianHua
		{
			set{ _dianhua=value;}
			get{return _dianhua;}
		}
		/// <summary>
		/// 手机号码
		/// </summary>
		public string MobTel
		{
			set{ _mobtel=value;}
			get{return _mobtel;}
		}
		/// <summary>
		/// 传真号码
		/// </summary>
		public string ChuanZhen
		{
			set{ _chuanzhen=value;}
			get{return _chuanzhen;}
		}
		/// <summary>
		/// 网址
		/// </summary>
		public string URLStr
		{
			set{ _urlstr=value;}
			get{return _urlstr;}
		}
		/// <summary>
		/// 电子邮件
		/// </summary>
		public string EmailStr
		{
			set{ _emailstr=value;}
			get{return _emailstr;}
		}
		/// <summary>
		/// 地区
		/// </summary>
		public string DiQu
		{
			set{ _diqu=value;}
			get{return _diqu;}
		}
		/// <summary>
		/// 邮政编码
		/// </summary>
		public string YouBian
		{
			set{ _youbian=value;}
			get{return _youbian;}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 开户行
		/// </summary>
		public string KaiHuHang
		{
			set{ _kaihuhang=value;}
			get{return _kaihuhang;}
		}
		/// <summary>
		/// 帐号
		/// </summary>
		public string ZhangHao
		{
			set{ _zhanghao=value;}
			get{return _zhanghao;}
		}
		/// <summary>
		/// 备注说明
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		/// <summary>
		/// 记录人
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 记录时间
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
		public ERPSupplys(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,SupplysName,Serils,JianCheng,DianHua,MobTel,ChuanZhen,URLStr,EmailStr,DiQu,YouBian,Address,KaiHuHang,ZhangHao,BackInfo,UserName,TimeStr ");
			strSql.Append(" FROM ERPSupplys ");
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
				SupplysName=ds.Tables[0].Rows[0]["SupplysName"].ToString();
				Serils=ds.Tables[0].Rows[0]["Serils"].ToString();
				JianCheng=ds.Tables[0].Rows[0]["JianCheng"].ToString();
				DianHua=ds.Tables[0].Rows[0]["DianHua"].ToString();
				MobTel=ds.Tables[0].Rows[0]["MobTel"].ToString();
				ChuanZhen=ds.Tables[0].Rows[0]["ChuanZhen"].ToString();
				URLStr=ds.Tables[0].Rows[0]["URLStr"].ToString();
				EmailStr=ds.Tables[0].Rows[0]["EmailStr"].ToString();
				DiQu=ds.Tables[0].Rows[0]["DiQu"].ToString();
				YouBian=ds.Tables[0].Rows[0]["YouBian"].ToString();
				Address=ds.Tables[0].Rows[0]["Address"].ToString();
				KaiHuHang=ds.Tables[0].Rows[0]["KaiHuHang"].ToString();
				ZhangHao=ds.Tables[0].Rows[0]["ZhangHao"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPSupplys"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPSupplys");
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
			strSql.Append("insert into ERPSupplys(");
			strSql.Append("SupplysName,Serils,JianCheng,DianHua,MobTel,ChuanZhen,URLStr,EmailStr,DiQu,YouBian,Address,KaiHuHang,ZhangHao,BackInfo,UserName,TimeStr)");
			strSql.Append(" values (");
			strSql.Append("@SupplysName,@Serils,@JianCheng,@DianHua,@MobTel,@ChuanZhen,@URLStr,@EmailStr,@DiQu,@YouBian,@Address,@KaiHuHang,@ZhangHao,@BackInfo,@UserName,@TimeStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SupplysName", SqlDbType.VarChar,50),
					new SqlParameter("@Serils", SqlDbType.VarChar,50),
					new SqlParameter("@JianCheng", SqlDbType.VarChar,50),
					new SqlParameter("@DianHua", SqlDbType.VarChar,50),
					new SqlParameter("@MobTel", SqlDbType.VarChar,50),
					new SqlParameter("@ChuanZhen", SqlDbType.VarChar,50),
					new SqlParameter("@URLStr", SqlDbType.VarChar,50),
					new SqlParameter("@EmailStr", SqlDbType.VarChar,50),
					new SqlParameter("@DiQu", SqlDbType.VarChar,50),
					new SqlParameter("@YouBian", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@KaiHuHang", SqlDbType.VarChar,200),
					new SqlParameter("@ZhangHao", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,8000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = SupplysName;
			parameters[1].Value = Serils;
			parameters[2].Value = JianCheng;
			parameters[3].Value = DianHua;
			parameters[4].Value = MobTel;
			parameters[5].Value = ChuanZhen;
			parameters[6].Value = URLStr;
			parameters[7].Value = EmailStr;
			parameters[8].Value = DiQu;
			parameters[9].Value = YouBian;
			parameters[10].Value = Address;
			parameters[11].Value = KaiHuHang;
			parameters[12].Value = ZhangHao;
			parameters[13].Value = BackInfo;
			parameters[14].Value = UserName;
			parameters[15].Value = TimeStr;

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
			strSql.Append("update ERPSupplys set ");
			strSql.Append("SupplysName=@SupplysName,");
			strSql.Append("Serils=@Serils,");
			strSql.Append("JianCheng=@JianCheng,");
			strSql.Append("DianHua=@DianHua,");
			strSql.Append("MobTel=@MobTel,");
			strSql.Append("ChuanZhen=@ChuanZhen,");
			strSql.Append("URLStr=@URLStr,");
			strSql.Append("EmailStr=@EmailStr,");
			strSql.Append("DiQu=@DiQu,");
			strSql.Append("YouBian=@YouBian,");
			strSql.Append("Address=@Address,");
			strSql.Append("KaiHuHang=@KaiHuHang,");
			strSql.Append("ZhangHao=@ZhangHao,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@SupplysName", SqlDbType.VarChar,50),
					new SqlParameter("@Serils", SqlDbType.VarChar,50),
					new SqlParameter("@JianCheng", SqlDbType.VarChar,50),
					new SqlParameter("@DianHua", SqlDbType.VarChar,50),
					new SqlParameter("@MobTel", SqlDbType.VarChar,50),
					new SqlParameter("@ChuanZhen", SqlDbType.VarChar,50),
					new SqlParameter("@URLStr", SqlDbType.VarChar,50),
					new SqlParameter("@EmailStr", SqlDbType.VarChar,50),
					new SqlParameter("@DiQu", SqlDbType.VarChar,50),
					new SqlParameter("@YouBian", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@KaiHuHang", SqlDbType.VarChar,200),
					new SqlParameter("@ZhangHao", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,8000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = ID;
			parameters[1].Value = SupplysName;
			parameters[2].Value = Serils;
			parameters[3].Value = JianCheng;
			parameters[4].Value = DianHua;
			parameters[5].Value = MobTel;
			parameters[6].Value = ChuanZhen;
			parameters[7].Value = URLStr;
			parameters[8].Value = EmailStr;
			parameters[9].Value = DiQu;
			parameters[10].Value = YouBian;
			parameters[11].Value = Address;
			parameters[12].Value = KaiHuHang;
			parameters[13].Value = ZhangHao;
			parameters[14].Value = BackInfo;
			parameters[15].Value = UserName;
			parameters[16].Value = TimeStr;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPSupplys ");
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
			strSql.Append("select  top 1 ID,SupplysName,Serils,JianCheng,DianHua,MobTel,ChuanZhen,URLStr,EmailStr,DiQu,YouBian,Address,KaiHuHang,ZhangHao,BackInfo,UserName,TimeStr ");
			strSql.Append(" FROM ERPSupplys ");
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
				SupplysName=ds.Tables[0].Rows[0]["SupplysName"].ToString();
				Serils=ds.Tables[0].Rows[0]["Serils"].ToString();
				JianCheng=ds.Tables[0].Rows[0]["JianCheng"].ToString();
				DianHua=ds.Tables[0].Rows[0]["DianHua"].ToString();
				MobTel=ds.Tables[0].Rows[0]["MobTel"].ToString();
				ChuanZhen=ds.Tables[0].Rows[0]["ChuanZhen"].ToString();
				URLStr=ds.Tables[0].Rows[0]["URLStr"].ToString();
				EmailStr=ds.Tables[0].Rows[0]["EmailStr"].ToString();
				DiQu=ds.Tables[0].Rows[0]["DiQu"].ToString();
				YouBian=ds.Tables[0].Rows[0]["YouBian"].ToString();
				Address=ds.Tables[0].Rows[0]["Address"].ToString();
				KaiHuHang=ds.Tables[0].Rows[0]["KaiHuHang"].ToString();
				ZhangHao=ds.Tables[0].Rows[0]["ZhangHao"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
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
			strSql.Append(" FROM ERPSupplys ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

