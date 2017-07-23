using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPRenShiHeTong。
	/// </summary>
	public class ERPRenShiHeTong
	{
		public ERPRenShiHeTong()
		{}
		#region Model
		private int _id;
		private string _hetonguser;
		private string _nowstate;
		private string _serils;
		private string _typestr;
		private string _jingye;
		private string _baomixieyi;
		private string _qianyuedate;
		private string _manyuedate;
		private string _jianzhengjiguan;
		private string _jianzhengdate;
		private string _weiyuezeren;
		private string _backinfo;
		private string _fujianlist;
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
		/// 员工用户
		/// </summary>
		public string HeTongUser
		{
			set{ _hetonguser=value;}
			get{return _hetonguser;}
		}
		/// <summary>
		/// 合同状态
		/// </summary>
		public string NowState
		{
			set{ _nowstate=value;}
			get{return _nowstate;}
		}
		/// <summary>
		/// 合同编号
		/// </summary>
		public string Serils
		{
			set{ _serils=value;}
			get{return _serils;}
		}
		/// <summary>
		/// 合同类型
		/// </summary>
		public string TypeStr
		{
			set{ _typestr=value;}
			get{return _typestr;}
		}
		/// <summary>
		/// 是否有竞业条款
		/// </summary>
		public string JingYe
		{
			set{ _jingye=value;}
			get{return _jingye;}
		}
		/// <summary>
		/// 是否有保密协议
		/// </summary>
		public string BaoMiXieYi
		{
			set{ _baomixieyi=value;}
			get{return _baomixieyi;}
		}
		/// <summary>
		/// 签约日期
		/// </summary>
		public string QianYueDate
		{
			set{ _qianyuedate=value;}
			get{return _qianyuedate;}
		}
		/// <summary>
		/// 满约日期
		/// </summary>
		public string ManYueDate
		{
			set{ _manyuedate=value;}
			get{return _manyuedate;}
		}
		/// <summary>
		/// 鉴证机关
		/// </summary>
		public string JianZhengJiGuan
		{
			set{ _jianzhengjiguan=value;}
			get{return _jianzhengjiguan;}
		}
		/// <summary>
		/// 鉴证日期
		/// </summary>
		public string JianZhengDate
		{
			set{ _jianzhengdate=value;}
			get{return _jianzhengdate;}
		}
		/// <summary>
		/// 违约责任
		/// </summary>
		public string WeiYueZeRen
		{
			set{ _weiyuezeren=value;}
			get{return _weiyuezeren;}
		}
		/// <summary>
		/// 其他事宜
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
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
		public ERPRenShiHeTong(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,HeTongUser,NowState,Serils,TypeStr,JingYe,BaoMiXieYi,QianYueDate,ManYueDate,JianZhengJiGuan,JianZhengDate,WeiYueZeRen,BackInfo,FuJianList,UserName,TimeStr ");
			strSql.Append(" FROM ERPRenShiHeTong ");
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
				HeTongUser=ds.Tables[0].Rows[0]["HeTongUser"].ToString();
				NowState=ds.Tables[0].Rows[0]["NowState"].ToString();
				Serils=ds.Tables[0].Rows[0]["Serils"].ToString();
				TypeStr=ds.Tables[0].Rows[0]["TypeStr"].ToString();
				JingYe=ds.Tables[0].Rows[0]["JingYe"].ToString();
				BaoMiXieYi=ds.Tables[0].Rows[0]["BaoMiXieYi"].ToString();
				QianYueDate=ds.Tables[0].Rows[0]["QianYueDate"].ToString();
				ManYueDate=ds.Tables[0].Rows[0]["ManYueDate"].ToString();
				JianZhengJiGuan=ds.Tables[0].Rows[0]["JianZhengJiGuan"].ToString();
				JianZhengDate=ds.Tables[0].Rows[0]["JianZhengDate"].ToString();
				WeiYueZeRen=ds.Tables[0].Rows[0]["WeiYueZeRen"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				FuJianList=ds.Tables[0].Rows[0]["FuJianList"].ToString();
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

		return DbHelperSQL.GetMaxID("ID", "ERPRenShiHeTong"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPRenShiHeTong");
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
			strSql.Append("insert into ERPRenShiHeTong(");
			strSql.Append("HeTongUser,NowState,Serils,TypeStr,JingYe,BaoMiXieYi,QianYueDate,ManYueDate,JianZhengJiGuan,JianZhengDate,WeiYueZeRen,BackInfo,FuJianList,UserName,TimeStr)");
			strSql.Append(" values (");
			strSql.Append("@HeTongUser,@NowState,@Serils,@TypeStr,@JingYe,@BaoMiXieYi,@QianYueDate,@ManYueDate,@JianZhengJiGuan,@JianZhengDate,@WeiYueZeRen,@BackInfo,@FuJianList,@UserName,@TimeStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@HeTongUser", SqlDbType.VarChar,50),
					new SqlParameter("@NowState", SqlDbType.VarChar,50),
					new SqlParameter("@Serils", SqlDbType.VarChar,50),
					new SqlParameter("@TypeStr", SqlDbType.VarChar,50),
					new SqlParameter("@JingYe", SqlDbType.VarChar,50),
					new SqlParameter("@BaoMiXieYi", SqlDbType.VarChar,50),
					new SqlParameter("@QianYueDate", SqlDbType.VarChar,50),
					new SqlParameter("@ManYueDate", SqlDbType.VarChar,50),
					new SqlParameter("@JianZhengJiGuan", SqlDbType.VarChar,50),
					new SqlParameter("@JianZhengDate", SqlDbType.VarChar,50),
					new SqlParameter("@WeiYueZeRen", SqlDbType.VarChar,5000),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@FuJianList", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = HeTongUser;
			parameters[1].Value = NowState;
			parameters[2].Value = Serils;
			parameters[3].Value = TypeStr;
			parameters[4].Value = JingYe;
			parameters[5].Value = BaoMiXieYi;
			parameters[6].Value = QianYueDate;
			parameters[7].Value = ManYueDate;
			parameters[8].Value = JianZhengJiGuan;
			parameters[9].Value = JianZhengDate;
			parameters[10].Value = WeiYueZeRen;
			parameters[11].Value = BackInfo;
			parameters[12].Value = FuJianList;
			parameters[13].Value = UserName;
			parameters[14].Value = TimeStr;

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
			strSql.Append("update ERPRenShiHeTong set ");
			strSql.Append("HeTongUser=@HeTongUser,");
			strSql.Append("NowState=@NowState,");
			strSql.Append("Serils=@Serils,");
			strSql.Append("TypeStr=@TypeStr,");
			strSql.Append("JingYe=@JingYe,");
			strSql.Append("BaoMiXieYi=@BaoMiXieYi,");
			strSql.Append("QianYueDate=@QianYueDate,");
			strSql.Append("ManYueDate=@ManYueDate,");
			strSql.Append("JianZhengJiGuan=@JianZhengJiGuan,");
			strSql.Append("JianZhengDate=@JianZhengDate,");
			strSql.Append("WeiYueZeRen=@WeiYueZeRen,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append("FuJianList=@FuJianList,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@HeTongUser", SqlDbType.VarChar,50),
					new SqlParameter("@NowState", SqlDbType.VarChar,50),
					new SqlParameter("@Serils", SqlDbType.VarChar,50),
					new SqlParameter("@TypeStr", SqlDbType.VarChar,50),
					new SqlParameter("@JingYe", SqlDbType.VarChar,50),
					new SqlParameter("@BaoMiXieYi", SqlDbType.VarChar,50),
					new SqlParameter("@QianYueDate", SqlDbType.VarChar,50),
					new SqlParameter("@ManYueDate", SqlDbType.VarChar,50),
					new SqlParameter("@JianZhengJiGuan", SqlDbType.VarChar,50),
					new SqlParameter("@JianZhengDate", SqlDbType.VarChar,50),
					new SqlParameter("@WeiYueZeRen", SqlDbType.VarChar,5000),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@FuJianList", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = ID;
			parameters[1].Value = HeTongUser;
			parameters[2].Value = NowState;
			parameters[3].Value = Serils;
			parameters[4].Value = TypeStr;
			parameters[5].Value = JingYe;
			parameters[6].Value = BaoMiXieYi;
			parameters[7].Value = QianYueDate;
			parameters[8].Value = ManYueDate;
			parameters[9].Value = JianZhengJiGuan;
			parameters[10].Value = JianZhengDate;
			parameters[11].Value = WeiYueZeRen;
			parameters[12].Value = BackInfo;
			parameters[13].Value = FuJianList;
			parameters[14].Value = UserName;
			parameters[15].Value = TimeStr;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPRenShiHeTong ");
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
			strSql.Append("select  top 1 ID,HeTongUser,NowState,Serils,TypeStr,JingYe,BaoMiXieYi,QianYueDate,ManYueDate,JianZhengJiGuan,JianZhengDate,WeiYueZeRen,BackInfo,FuJianList,UserName,TimeStr ");
			strSql.Append(" FROM ERPRenShiHeTong ");
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
				HeTongUser=ds.Tables[0].Rows[0]["HeTongUser"].ToString();
				NowState=ds.Tables[0].Rows[0]["NowState"].ToString();
				Serils=ds.Tables[0].Rows[0]["Serils"].ToString();
				TypeStr=ds.Tables[0].Rows[0]["TypeStr"].ToString();
				JingYe=ds.Tables[0].Rows[0]["JingYe"].ToString();
				BaoMiXieYi=ds.Tables[0].Rows[0]["BaoMiXieYi"].ToString();
				QianYueDate=ds.Tables[0].Rows[0]["QianYueDate"].ToString();
				ManYueDate=ds.Tables[0].Rows[0]["ManYueDate"].ToString();
				JianZhengJiGuan=ds.Tables[0].Rows[0]["JianZhengJiGuan"].ToString();
				JianZhengDate=ds.Tables[0].Rows[0]["JianZhengDate"].ToString();
				WeiYueZeRen=ds.Tables[0].Rows[0]["WeiYueZeRen"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				FuJianList=ds.Tables[0].Rows[0]["FuJianList"].ToString();
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
			strSql.Append(" FROM ERPRenShiHeTong ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

