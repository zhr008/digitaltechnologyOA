using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;

namespace FTD.BLL
{
    public class ERPReimburse
    {
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public ERPReimburse()
        {

        }

        #region 成员定义

        private int _ID;
        /// <summary>
        /// ID号
        /// </summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _UserName;
        /// <summary>
        /// 报销人员
        /// </summary>
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        private string _HeTongName;
        /// <summary>
        /// 合同名称
        /// </summary>
        public string HeTongName
        {
            get { return _HeTongName; }
            set { _HeTongName = value; }
        }

        private string _QianYueKeHu;
        /// <summary>
        /// 签约客户
        /// </summary>
        public string QianYueKeHu
        {
            get { return _QianYueKeHu; }
            set { _QianYueKeHu = value; }
        }

        private string _ReimburseContent;
        /// <summary>
        /// 报销内容
        /// </summary>
        public string ReimburseContent
        {
            get { return _ReimburseContent; }
            set { _ReimburseContent = value; }
        }

        private string _ApplyTime;
        /// <summary>
        /// 报销时间
        /// </summary>
        public string ApplyTime
        {
            get { return _ApplyTime; }
            set { _ApplyTime = value; }
        }

        private string _Memo;
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get { return _Memo; }
            set { _Memo = value; }
        }
        
        #endregion

        #region 方法定义

        public ERPReimburse(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * from ERPReimburse where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
			if(ds.Tables[0].Rows.Count > 0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString() != "")
				{
					ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
				HeTongName = ds.Tables[0].Rows[0]["HeTongName"].ToString();
				QianYueKeHu = ds.Tables[0].Rows[0]["QianYueKeHu"].ToString();
                ReimburseContent = ds.Tables[0].Rows[0]["ReimburseContent"].ToString();
                ApplyTime = ds.Tables[0].Rows[0]["ApplyTime"].ToString();
                Memo = ds.Tables[0].Rows[0]["Memo"].ToString();
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
            return DbHelperSQL.GetMaxID("ID", "ERPReimburse"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select count(1) from ERPReimburse");
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
            strSql.Append("insert into ERPReimburse( ");
            strSql.Append("  UserName, HeTongName, QianYueKeHu, ReimburseContent, ApplyTime, Memo) ");
			strSql.Append("values ( ");
            strSql.Append("  @UserName, @HeTongName, @QianYueKeHu, @ReimburseContent, @ApplyTime, @Memo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@HeTongName", SqlDbType.VarChar,200),
					new SqlParameter("@QianYueKeHu", SqlDbType.VarChar,200),
					new SqlParameter("@ReimburseContent", SqlDbType.VarChar,1000),
					new SqlParameter("@ApplyTime", SqlDbType.VarChar,30),
					new SqlParameter("@Memo", SqlDbType.VarChar,200)};
			parameters[0].Value = UserName;
			parameters[1].Value = HeTongName;
			parameters[2].Value = QianYueKeHu;
			parameters[3].Value = ReimburseContent;
			parameters[4].Value = ApplyTime;
			parameters[5].Value = Memo;

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
            strSql.Append("update ERPReimburse set ");
            strSql.Append("  UserName=@UserName,");
            strSql.Append("  HeTongName=@HeTongName,");
            strSql.Append("  QianYueKeHu=@QianYueKeHu,");
            strSql.Append("  ReimburseContent=@ReimburseContent,");
            strSql.Append("  ApplyTime=@ApplyTime,");
            strSql.Append("  Memo=@Memo ");
			strSql.Append("where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@HeTongName", SqlDbType.VarChar,200),
					new SqlParameter("@QianYueKeHu", SqlDbType.VarChar,200),
					new SqlParameter("@ReimburseContent", SqlDbType.VarChar,1000),
					new SqlParameter("@ApplyTime", SqlDbType.VarChar,30),
					new SqlParameter("@Memo", SqlDbType.VarChar,200),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = UserName;
            parameters[1].Value = HeTongName;
            parameters[2].Value = QianYueKeHu;
            parameters[3].Value = ReimburseContent;
            parameters[4].Value = ApplyTime;
            parameters[5].Value = Memo;
            parameters[6].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("delete from ERPReimburse ");
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
            strSql.Append("select top 1 ID,UserName,HeTongName,QianYueKeHu,ReimburseContent,ApplyTime,Memo ");
            strSql.Append(" from ERPReimburse ");
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
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
				HeTongName=ds.Tables[0].Rows[0]["HeTongName"].ToString();
				QianYueKeHu=ds.Tables[0].Rows[0]["QianYueKeHu"].ToString();
                ReimburseContent = ds.Tables[0].Rows[0]["ReimburseContent"].ToString();
                ApplyTime = ds.Tables[0].Rows[0]["ApplyTime"].ToString();
                Memo = ds.Tables[0].Rows[0]["Memo"].ToString();
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
            strSql.Append(" FROM ERPReimburse ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        #endregion

    }
}
