using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPNWorkToDo。
	/// </summary>
	public class ERPNWorkToDo
	{
		public ERPNWorkToDo()
		{}
		#region Model
		private int _id;
		private string _workname;
		private int? _formid;
		private int? _workflowid;
		private string _username;
		private DateTime? _timestr;
		private string _formcontent;
		private string _fujianlist;
		private string _shenpiyijian;
		private int? _jiedianid;
		private string _jiedianname;
		private string _shenpiuserlist;
		private string _okuserlist;
		private string _statenow;
		private DateTime? _latetime;
        private string _chaosonguserlist;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 工作名称
		/// </summary>
		public string WorkName
		{
			set{ _workname=value;}
			get{return _workname;}
		}
		/// <summary>
		/// 所用表单
		/// </summary>
		public int? FormID
		{
			set{ _formid=value;}
			get{return _formid;}
		}
		/// <summary>
		/// 所用工作流程
		/// </summary>
		public int? WorkFlowID
		{
			set{ _workflowid=value;}
			get{return _workflowid;}
		}
		/// <summary>
		/// 发起人
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 发起时间
		/// </summary>
		public DateTime? TimeStr
		{
			set{ _timestr=value;}
			get{return _timestr;}
		}
		/// <summary>
		/// 表单内容
		/// </summary>
		public string FormContent
		{
			set{ _formcontent=value;}
			get{return _formcontent;}
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
		/// 签注审批
		/// </summary>
		public string ShenPiYiJian
		{
			set{ _shenpiyijian=value;}
			get{return _shenpiyijian;}
		}
		/// <summary>
		/// 当前所在节点
		/// </summary>
		public int? JieDianID
		{
			set{ _jiedianid=value;}
			get{return _jiedianid;}
		}
		/// <summary>
		/// 当前节点名称
		/// </summary>
		public string JieDianName
		{
			set{ _jiedianname=value;}
			get{return _jiedianname;}
		}
		/// <summary>
		/// 当前审批用户（可以多个人）
		/// </summary>
		public string ShenPiUserList
		{
			set{ _shenpiuserlist=value;}
			get{return _shenpiuserlist;}
		}
		/// <summary>
		/// 当前已审批通过的用户（可以多个人）
		/// </summary>
		public string OKUserList
		{
			set{ _okuserlist=value;}
			get{return _okuserlist;}
		}
		/// <summary>
		/// 当前状态
		/// </summary>
		public string StateNow
		{
			set{ _statenow=value;}
			get{return _statenow;}
		}
		/// <summary>
		/// 超时时间（何时超时）
		/// </summary>
		public DateTime? LateTime
		{
			set{ _latetime=value;}
			get{return _latetime;}
		}
        /// <summary>
        /// 抄送用户（可以多个人）
        /// </summary>
        public string ChaoSongUserList
        {
            set { _chaosonguserlist = value; }
            get { return _chaosonguserlist; }
        }
		#endregion Model


		#region  成员方法

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateBD()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ERPNWorkToDo set ");
            strSql.Append("FormContent=@FormContent ");
            strSql.Append(" where ID=" + ID + " ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@FormContent", SqlDbType.Text)};
            parameters[0].Value = ID;
            parameters[1].Value = FormContent;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPNWorkToDo(int ID)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select ID,WorkName,FormID,WorkFlowID,UserName,TimeStr,FormContent,FuJianList,ShenPiYiJian,JieDianID,JieDianName,ShenPiUserList,OKUserList,StateNow,LateTime,ChaoSongUserList ");
			strSql.Append(" FROM ERPNWorkToDo ");
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
				WorkName=ds.Tables[0].Rows[0]["WorkName"].ToString();
				if(ds.Tables[0].Rows[0]["FormID"].ToString()!="")
				{
					FormID=int.Parse(ds.Tables[0].Rows[0]["FormID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["WorkFlowID"].ToString()!="")
				{
					WorkFlowID=int.Parse(ds.Tables[0].Rows[0]["WorkFlowID"].ToString());
				}
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				FormContent=ds.Tables[0].Rows[0]["FormContent"].ToString();
				FuJianList=ds.Tables[0].Rows[0]["FuJianList"].ToString();
				ShenPiYiJian=ds.Tables[0].Rows[0]["ShenPiYiJian"].ToString();
				if(ds.Tables[0].Rows[0]["JieDianID"].ToString()!="")
				{
					JieDianID=int.Parse(ds.Tables[0].Rows[0]["JieDianID"].ToString());
				}
				JieDianName=ds.Tables[0].Rows[0]["JieDianName"].ToString();
				ShenPiUserList=ds.Tables[0].Rows[0]["ShenPiUserList"].ToString();
				OKUserList=ds.Tables[0].Rows[0]["OKUserList"].ToString();
				StateNow=ds.Tables[0].Rows[0]["StateNow"].ToString();
                ChaoSongUserList = ds.Tables[0].Rows[0]["ChaoSongUserList"].ToString();
				if(ds.Tables[0].Rows[0]["LateTime"].ToString()!="")
				{
					LateTime=DateTime.Parse(ds.Tables[0].Rows[0]["LateTime"].ToString());
				}
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPNWorkToDo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPNWorkToDo");
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
			strSql.Append("insert into ERPNWorkToDo(");
            strSql.Append("WorkName,FormID,WorkFlowID,UserName,TimeStr,FormContent,FuJianList,ShenPiYiJian,JieDianID,JieDianName,ShenPiUserList,OKUserList,StateNow,LateTime,ChaoSongUserList)");
			strSql.Append(" values (");
            strSql.Append("@WorkName,@FormID,@WorkFlowID,@UserName,@TimeStr,@FormContent,@FuJianList,@ShenPiYiJian,@JieDianID,@JieDianName,@ShenPiUserList,@OKUserList,@StateNow,@LateTime,@ChaoSongUserList)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkName", SqlDbType.VarChar,200),
					new SqlParameter("@FormID", SqlDbType.Int,4),
					new SqlParameter("@WorkFlowID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@FormContent", SqlDbType.Text),
					new SqlParameter("@FuJianList", SqlDbType.VarChar,5000),
					new SqlParameter("@ShenPiYiJian", SqlDbType.Text),
					new SqlParameter("@JieDianID", SqlDbType.Int,4),
					new SqlParameter("@JieDianName", SqlDbType.VarChar,50),
					new SqlParameter("@ShenPiUserList", SqlDbType.VarChar,8000),
					new SqlParameter("@OKUserList", SqlDbType.VarChar,8000),
					new SqlParameter("@StateNow", SqlDbType.VarChar,50),
					new SqlParameter("@LateTime", SqlDbType.DateTime),
                    new SqlParameter("@ChaoSongUserList", SqlDbType.VarChar,8000)};
			parameters[0].Value = WorkName;
			parameters[1].Value = FormID;
			parameters[2].Value = WorkFlowID;
			parameters[3].Value = UserName;
			parameters[4].Value = TimeStr;
			parameters[5].Value = FormContent;
			parameters[6].Value = FuJianList;
			parameters[7].Value = ShenPiYiJian;
			parameters[8].Value = JieDianID;
			parameters[9].Value = JieDianName;
			parameters[10].Value = ShenPiUserList;
			parameters[11].Value = OKUserList;
			parameters[12].Value = StateNow;
			parameters[13].Value = LateTime;
            parameters[14].Value = ChaoSongUserList;

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
			strSql.Append("update ERPNWorkToDo set ");
			strSql.Append("WorkName=@WorkName,");
			strSql.Append("FormID=@FormID,");
			strSql.Append("WorkFlowID=@WorkFlowID,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr,");
			strSql.Append("FormContent=@FormContent,");
			strSql.Append("FuJianList=@FuJianList,");
			strSql.Append("ShenPiYiJian=@ShenPiYiJian,");
			strSql.Append("JieDianID=@JieDianID,");
			strSql.Append("JieDianName=@JieDianName,");
			strSql.Append("ShenPiUserList=@ShenPiUserList,");
			strSql.Append("OKUserList=@OKUserList,");
			strSql.Append("StateNow=@StateNow,");
			strSql.Append("LateTime=@LateTime,");
            strSql.Append("ChaoSongUserList=@ChaoSongUserList");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@WorkName", SqlDbType.VarChar,200),
					new SqlParameter("@FormID", SqlDbType.Int,4),
					new SqlParameter("@WorkFlowID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@FormContent", SqlDbType.Text),
					new SqlParameter("@FuJianList", SqlDbType.VarChar,5000),
					new SqlParameter("@ShenPiYiJian", SqlDbType.Text),
					new SqlParameter("@JieDianID", SqlDbType.Int,4),
					new SqlParameter("@JieDianName", SqlDbType.VarChar,50),
					new SqlParameter("@ShenPiUserList", SqlDbType.VarChar,8000),
					new SqlParameter("@OKUserList", SqlDbType.VarChar,8000),
					new SqlParameter("@StateNow", SqlDbType.VarChar,50),
					new SqlParameter("@LateTime", SqlDbType.DateTime),
                    new SqlParameter("@ChaoSongUserList", SqlDbType.VarChar,8000)};
			parameters[0].Value = ID;
			parameters[1].Value = WorkName;
			parameters[2].Value = FormID;
			parameters[3].Value = WorkFlowID;
			parameters[4].Value = UserName;
			parameters[5].Value = TimeStr;
			parameters[6].Value = FormContent;
			parameters[7].Value = FuJianList;
			parameters[8].Value = ShenPiYiJian;
			parameters[9].Value = JieDianID;
			parameters[10].Value = JieDianName;
			parameters[11].Value = ShenPiUserList;
			parameters[12].Value = OKUserList;
			parameters[13].Value = StateNow;
			parameters[14].Value = LateTime;
            parameters[15].Value = ChaoSongUserList;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPNWorkToDo ");
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
            strSql.Append("select  top 1 ID,WorkName,FormID,WorkFlowID,UserName,TimeStr,FormContent,FuJianList,ShenPiYiJian,JieDianID,JieDianName,ShenPiUserList,OKUserList,StateNow,LateTime,ChaoSongUserList ");
			strSql.Append(" FROM ERPNWorkToDo ");
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
				WorkName=ds.Tables[0].Rows[0]["WorkName"].ToString();
				if(ds.Tables[0].Rows[0]["FormID"].ToString()!="")
				{
					FormID=int.Parse(ds.Tables[0].Rows[0]["FormID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["WorkFlowID"].ToString()!="")
				{
					WorkFlowID=int.Parse(ds.Tables[0].Rows[0]["WorkFlowID"].ToString());
				}
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				FormContent=ds.Tables[0].Rows[0]["FormContent"].ToString();
				FuJianList=ds.Tables[0].Rows[0]["FuJianList"].ToString();
				ShenPiYiJian=ds.Tables[0].Rows[0]["ShenPiYiJian"].ToString();
				if(ds.Tables[0].Rows[0]["JieDianID"].ToString()!="")
				{
					JieDianID=int.Parse(ds.Tables[0].Rows[0]["JieDianID"].ToString());
				}
				JieDianName=ds.Tables[0].Rows[0]["JieDianName"].ToString();
				ShenPiUserList=ds.Tables[0].Rows[0]["ShenPiUserList"].ToString();
				OKUserList=ds.Tables[0].Rows[0]["OKUserList"].ToString();
				StateNow=ds.Tables[0].Rows[0]["StateNow"].ToString();
                ChaoSongUserList = ds.Tables[0].Rows[0]["ChaoSongUserList"].ToString();
				if(ds.Tables[0].Rows[0]["LateTime"].ToString()!="")
				{
					LateTime=DateTime.Parse(ds.Tables[0].Rows[0]["LateTime"].ToString());
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
			strSql.Append(" FROM ERPNWorkToDo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

