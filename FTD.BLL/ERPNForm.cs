using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPNForm。
	/// </summary>
	public class ERPNForm
	{
		public ERPNForm()
		{}
		#region Model
		private int _id;
		private string _formname;
		private int? _typeid;
		private string _userlistok;
		private string _deplistok;
		private string _jiaoselistok;
		private string _paixustr;
		private string _username;
		private DateTime? _timestr;
		private string _contentstr;
		private string _itemslist;
		private string _ifok;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 表单名称
		/// </summary>
		public string FormName
		{
			set{ _formname=value;}
			get{return _formname;}
		}
		/// <summary>
		/// 所属分类ID
		/// </summary>
		public int? TypeID
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 允许使用人
		/// </summary>
		public string UserListOK
		{
			set{ _userlistok=value;}
			get{return _userlistok;}
		}
		/// <summary>
		/// 允许使用部门
		/// </summary>
		public string DepListOK
		{
			set{ _deplistok=value;}
			get{return _deplistok;}
		}
		/// <summary>
		/// 允许使用角色
		/// </summary>
		public string JiaoSeListOK
		{
			set{ _jiaoselistok=value;}
			get{return _jiaoselistok;}
		}
		/// <summary>
		/// 排序字符
		/// </summary>
		public string PaiXuStr
		{
			set{ _paixustr=value;}
			get{return _paixustr;}
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
		/// <summary>
		/// 表单内容
		/// </summary>
		public string ContentStr
		{
			set{ _contentstr=value;}
			get{return _contentstr;}
		}
		/// <summary>
		/// 表单中数据列
		/// </summary>
		public string ItemsList
		{
			set{ _itemslist=value;}
			get{return _itemslist;}
		}
		/// <summary>
		/// 是否启用
		/// </summary>
		public string IFOK
		{
			set{ _ifok=value;}
			get{return _ifok;}
		}
		#endregion Model


		#region  成员方法

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPNForm(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,FormName,TypeID,UserListOK,DepListOK,JiaoSeListOK,PaiXuStr,UserName,TimeStr,ContentStr,ItemsList,IFOK ");
			strSql.Append(" FROM ERPNForm ");
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
				FormName=ds.Tables[0].Rows[0]["FormName"].ToString();
				if(ds.Tables[0].Rows[0]["TypeID"].ToString()!="")
				{
					TypeID=int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
				}
				UserListOK=ds.Tables[0].Rows[0]["UserListOK"].ToString();
				DepListOK=ds.Tables[0].Rows[0]["DepListOK"].ToString();
				JiaoSeListOK=ds.Tables[0].Rows[0]["JiaoSeListOK"].ToString();
				PaiXuStr=ds.Tables[0].Rows[0]["PaiXuStr"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				ContentStr=ds.Tables[0].Rows[0]["ContentStr"].ToString();
				ItemsList=ds.Tables[0].Rows[0]["ItemsList"].ToString();
				IFOK=ds.Tables[0].Rows[0]["IFOK"].ToString();
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPNForm"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPNForm");
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
			strSql.Append("insert into ERPNForm(");
			strSql.Append("FormName,TypeID,UserListOK,DepListOK,JiaoSeListOK,PaiXuStr,UserName,TimeStr,ContentStr,ItemsList,IFOK)");
			strSql.Append(" values (");
			strSql.Append("@FormName,@TypeID,@UserListOK,@DepListOK,@JiaoSeListOK,@PaiXuStr,@UserName,@TimeStr,@ContentStr,@ItemsList,@IFOK)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@FormName", SqlDbType.VarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@UserListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@DepListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@JiaoSeListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@PaiXuStr", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@ContentStr", SqlDbType.Text),
					new SqlParameter("@ItemsList", SqlDbType.VarChar,8000),
					new SqlParameter("@IFOK", SqlDbType.VarChar,50)};
			parameters[0].Value = FormName;
			parameters[1].Value = TypeID;
			parameters[2].Value = UserListOK;
			parameters[3].Value = DepListOK;
			parameters[4].Value = JiaoSeListOK;
			parameters[5].Value = PaiXuStr;
			parameters[6].Value = UserName;
			parameters[7].Value = TimeStr;
			parameters[8].Value = ContentStr;
			parameters[9].Value = ItemsList;
			parameters[10].Value = IFOK;

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
			strSql.Append("update ERPNForm set ");
			strSql.Append("FormName=@FormName,");
			strSql.Append("UserListOK=@UserListOK,");
			strSql.Append("DepListOK=@DepListOK,");
			strSql.Append("JiaoSeListOK=@JiaoSeListOK,");
			strSql.Append("PaiXuStr=@PaiXuStr,");
			strSql.Append("IFOK=@IFOK");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@FormName", SqlDbType.VarChar,50),
					new SqlParameter("@UserListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@DepListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@JiaoSeListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@PaiXuStr", SqlDbType.VarChar,50),
					new SqlParameter("@IFOK", SqlDbType.VarChar,50)};
			parameters[0].Value = ID;
			parameters[1].Value = FormName;
			parameters[2].Value = UserListOK;
			parameters[3].Value = DepListOK;
			parameters[4].Value = JiaoSeListOK;
			parameters[5].Value = PaiXuStr;
			parameters[6].Value = IFOK;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
        }
        /// <summary>
        /// 更新一条数据的表单
        /// </summary>
        public void UpdateBD()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ERPNForm set ");
            strSql.Append("ContentStr=@ContentStr,");
            strSql.Append("ItemsList=@ItemsList");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@ContentStr", SqlDbType.Text),
					new SqlParameter("@ItemsList", SqlDbType.VarChar,8000)};
            parameters[0].Value = ID;
            parameters[1].Value = ContentStr;
            parameters[2].Value = ItemsList;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPNForm ");
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
			strSql.Append("select  top 1 ID,FormName,TypeID,UserListOK,DepListOK,JiaoSeListOK,PaiXuStr,UserName,TimeStr,ContentStr,ItemsList,IFOK ");
			strSql.Append(" FROM ERPNForm ");
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
				FormName=ds.Tables[0].Rows[0]["FormName"].ToString();
				if(ds.Tables[0].Rows[0]["TypeID"].ToString()!="")
				{
					TypeID=int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
				}
				UserListOK=ds.Tables[0].Rows[0]["UserListOK"].ToString();
				DepListOK=ds.Tables[0].Rows[0]["DepListOK"].ToString();
				JiaoSeListOK=ds.Tables[0].Rows[0]["JiaoSeListOK"].ToString();
				PaiXuStr=ds.Tables[0].Rows[0]["PaiXuStr"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				ContentStr=ds.Tables[0].Rows[0]["ContentStr"].ToString();
				ItemsList=ds.Tables[0].Rows[0]["ItemsList"].ToString();
				IFOK=ds.Tables[0].Rows[0]["IFOK"].ToString();
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPNForm ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

