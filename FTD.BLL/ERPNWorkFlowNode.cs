using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPNWorkFlowNode。
	/// </summary>
	public class ERPNWorkFlowNode
	{
		public ERPNWorkFlowNode()
		{}
		#region Model
		private int _id;
		private int? _workflowid;
		private string _nodeserils;
		private string _nodename;
		private string _nodeaddr;
		private string _nextnode;
		private string _ifcanjump;
		private string _ifcanview;
		private string _ifcanedit;
		private string _ifcandel;
		private int? _jieshuhours;
		private string _pstype;
		private string _sptype;
		private string _spdefaultlist;
		private string _canwriteset;
		private string _secretset;
		private string _conditionset;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 工作流程
		/// </summary>
		public int? WorkFlowID
		{
			set{ _workflowid=value;}
			get{return _workflowid;}
		}
		/// <summary>
		/// 节点序号
		/// </summary>
		public string NodeSerils
		{
			set{ _nodeserils=value;}
			get{return _nodeserils;}
		}
		/// <summary>
		/// 节点名称
		/// </summary>
		public string NodeName
		{
			set{ _nodename=value;}
			get{return _nodename;}
		}
		/// <summary>
		/// 节点位置
		/// </summary>
		public string NodeAddr
		{
			set{ _nodeaddr=value;}
			get{return _nodeaddr;}
		}
		/// <summary>
		/// 下一结点
		/// </summary>
		public string NextNode
		{
			set{ _nextnode=value;}
			get{return _nextnode;}
		}
		/// <summary>
		/// 是否允许强制跳转
		/// </summary>
		public string IFCanJump
		{
			set{ _ifcanjump=value;}
			get{return _ifcanjump;}
		}
		/// <summary>
		/// 是否允许查看附件
		/// </summary>
		public string IFCanView
		{
			set{ _ifcanview=value;}
			get{return _ifcanview;}
		}
		/// <summary>
		/// 是否允许编辑附件
		/// </summary>
		public string IFCanEdit
		{
			set{ _ifcanedit=value;}
			get{return _ifcanedit;}
		}
		/// <summary>
		/// 是否允许删除附件
		/// </summary>
		public string IFCanDel
		{
			set{ _ifcandel=value;}
			get{return _ifcandel;}
		}
		/// <summary>
		/// 超时设置
		/// </summary>
		public int? JieShuHours
		{
			set{ _jieshuhours=value;}
			get{return _jieshuhours;}
		}
		/// <summary>
		/// 评审模式（一人通过可向下流转、全部通过可向下流转）)
		/// </summary>
		public string PSType
		{
			set{ _pstype=value;}
			get{return _pstype;}
		}
		/// <summary>
		/// 审批人选择模式(审批时自由指定、从默认审批人中选择、从默认审批部门中选择、从默认审批角色中选择、自动选择流程发起人、自动选择本部门主管、自动选择上一级部门主管)
		/// </summary>
		public string SPType
		{
			set{ _sptype=value;}
			get{return _sptype;}
		}
		/// <summary>
		/// 默认待选值（人、部门、角色）支持多个
		/// </summary>
		public string SPDefaultList
		{
			set{ _spdefaultlist=value;}
			get{return _spdefaultlist;}
		}
		/// <summary>
		/// 可写字段设置
		/// </summary>
		public string CanWriteSet
		{
			set{ _canwriteset=value;}
			get{return _canwriteset;}
		}
		/// <summary>
		/// 保密字段设置
		/// </summary>
		public string SecretSet
		{
			set{ _secretset=value;}
			get{return _secretset;}
		}
		/// <summary>
		/// 条件字段设置
		/// </summary>
		public string ConditionSet
		{
			set{ _conditionset=value;}
			get{return _conditionset;}
		}
		#endregion Model


		#region  成员方法

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPNWorkFlowNode(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,WorkFlowID,NodeSerils,NodeName,NodeAddr,NextNode,IFCanJump,IFCanView,IFCanEdit,IFCanDel,JieShuHours,PSType,SPType,SPDefaultList,CanWriteSet,SecretSet,ConditionSet ");
			strSql.Append(" FROM ERPNWorkFlowNode ");
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
				if(ds.Tables[0].Rows[0]["WorkFlowID"].ToString()!="")
				{
					WorkFlowID=int.Parse(ds.Tables[0].Rows[0]["WorkFlowID"].ToString());
				}
				NodeSerils=ds.Tables[0].Rows[0]["NodeSerils"].ToString();
				NodeName=ds.Tables[0].Rows[0]["NodeName"].ToString();
				NodeAddr=ds.Tables[0].Rows[0]["NodeAddr"].ToString();
				NextNode=ds.Tables[0].Rows[0]["NextNode"].ToString();
				IFCanJump=ds.Tables[0].Rows[0]["IFCanJump"].ToString();
				IFCanView=ds.Tables[0].Rows[0]["IFCanView"].ToString();
				IFCanEdit=ds.Tables[0].Rows[0]["IFCanEdit"].ToString();
				IFCanDel=ds.Tables[0].Rows[0]["IFCanDel"].ToString();
				if(ds.Tables[0].Rows[0]["JieShuHours"].ToString()!="")
				{
					JieShuHours=int.Parse(ds.Tables[0].Rows[0]["JieShuHours"].ToString());
				}
				PSType=ds.Tables[0].Rows[0]["PSType"].ToString();
				SPType=ds.Tables[0].Rows[0]["SPType"].ToString();
				SPDefaultList=ds.Tables[0].Rows[0]["SPDefaultList"].ToString();
				CanWriteSet=ds.Tables[0].Rows[0]["CanWriteSet"].ToString();
				SecretSet=ds.Tables[0].Rows[0]["SecretSet"].ToString();
				ConditionSet=ds.Tables[0].Rows[0]["ConditionSet"].ToString();
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPNWorkFlowNode"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPNWorkFlowNode");
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
			strSql.Append("insert into ERPNWorkFlowNode(");
			strSql.Append("WorkFlowID,NodeSerils,NodeName,NodeAddr,NextNode,IFCanJump,IFCanView,IFCanEdit,IFCanDel,JieShuHours,PSType,SPType,SPDefaultList,CanWriteSet,SecretSet,ConditionSet)");
			strSql.Append(" values (");
			strSql.Append("@WorkFlowID,@NodeSerils,@NodeName,@NodeAddr,@NextNode,@IFCanJump,@IFCanView,@IFCanEdit,@IFCanDel,@JieShuHours,@PSType,@SPType,@SPDefaultList,@CanWriteSet,@SecretSet,@ConditionSet)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkFlowID", SqlDbType.Int,4),
					new SqlParameter("@NodeSerils", SqlDbType.VarChar,50),
					new SqlParameter("@NodeName", SqlDbType.VarChar,50),
					new SqlParameter("@NodeAddr", SqlDbType.VarChar,50),
					new SqlParameter("@NextNode", SqlDbType.VarChar,50),
					new SqlParameter("@IFCanJump", SqlDbType.VarChar,50),
					new SqlParameter("@IFCanView", SqlDbType.VarChar,50),
					new SqlParameter("@IFCanEdit", SqlDbType.VarChar,50),
					new SqlParameter("@IFCanDel", SqlDbType.VarChar,50),
					new SqlParameter("@JieShuHours", SqlDbType.Int,4),
					new SqlParameter("@PSType", SqlDbType.VarChar,50),
					new SqlParameter("@SPType", SqlDbType.VarChar,50),
					new SqlParameter("@SPDefaultList", SqlDbType.VarChar,8000),
					new SqlParameter("@CanWriteSet", SqlDbType.VarChar,8000),
					new SqlParameter("@SecretSet", SqlDbType.VarChar,8000),
					new SqlParameter("@ConditionSet", SqlDbType.VarChar,8000)};
			parameters[0].Value = WorkFlowID;
			parameters[1].Value = NodeSerils;
			parameters[2].Value = NodeName;
			parameters[3].Value = NodeAddr;
			parameters[4].Value = NextNode;
			parameters[5].Value = IFCanJump;
			parameters[6].Value = IFCanView;
			parameters[7].Value = IFCanEdit;
			parameters[8].Value = IFCanDel;
			parameters[9].Value = JieShuHours;
			parameters[10].Value = PSType;
			parameters[11].Value = SPType;
			parameters[12].Value = SPDefaultList;
			parameters[13].Value = CanWriteSet;
			parameters[14].Value = SecretSet;
			parameters[15].Value = ConditionSet;

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
			strSql.Append("update ERPNWorkFlowNode set ");
			strSql.Append("WorkFlowID=@WorkFlowID,");
			strSql.Append("NodeSerils=@NodeSerils,");
			strSql.Append("NodeName=@NodeName,");
			strSql.Append("NodeAddr=@NodeAddr,");
			strSql.Append("NextNode=@NextNode,");
			strSql.Append("IFCanJump=@IFCanJump,");
			strSql.Append("IFCanView=@IFCanView,");
			strSql.Append("IFCanEdit=@IFCanEdit,");
			strSql.Append("IFCanDel=@IFCanDel,");
			strSql.Append("JieShuHours=@JieShuHours,");
			strSql.Append("PSType=@PSType,");
			strSql.Append("SPType=@SPType,");
			strSql.Append("SPDefaultList=@SPDefaultList");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@WorkFlowID", SqlDbType.Int,4),
					new SqlParameter("@NodeSerils", SqlDbType.VarChar,50),
					new SqlParameter("@NodeName", SqlDbType.VarChar,50),
					new SqlParameter("@NodeAddr", SqlDbType.VarChar,50),
					new SqlParameter("@NextNode", SqlDbType.VarChar,50),
					new SqlParameter("@IFCanJump", SqlDbType.VarChar,50),
					new SqlParameter("@IFCanView", SqlDbType.VarChar,50),
					new SqlParameter("@IFCanEdit", SqlDbType.VarChar,50),
					new SqlParameter("@IFCanDel", SqlDbType.VarChar,50),
					new SqlParameter("@JieShuHours", SqlDbType.Int,4),
					new SqlParameter("@PSType", SqlDbType.VarChar,50),
					new SqlParameter("@SPType", SqlDbType.VarChar,50),
					new SqlParameter("@SPDefaultList", SqlDbType.VarChar,8000)};
			parameters[0].Value = ID;
			parameters[1].Value = WorkFlowID;
			parameters[2].Value = NodeSerils;
			parameters[3].Value = NodeName;
			parameters[4].Value = NodeAddr;
			parameters[5].Value = NextNode;
			parameters[6].Value = IFCanJump;
			parameters[7].Value = IFCanView;
			parameters[8].Value = IFCanEdit;
			parameters[9].Value = IFCanDel;
			parameters[10].Value = JieShuHours;
			parameters[11].Value = PSType;
			parameters[12].Value = SPType;
			parameters[13].Value = SPDefaultList;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPNWorkFlowNode ");
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
			strSql.Append("select  top 1 ID,WorkFlowID,NodeSerils,NodeName,NodeAddr,NextNode,IFCanJump,IFCanView,IFCanEdit,IFCanDel,JieShuHours,PSType,SPType,SPDefaultList,CanWriteSet,SecretSet,ConditionSet ");
			strSql.Append(" FROM ERPNWorkFlowNode ");
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
				if(ds.Tables[0].Rows[0]["WorkFlowID"].ToString()!="")
				{
					WorkFlowID=int.Parse(ds.Tables[0].Rows[0]["WorkFlowID"].ToString());
				}
				NodeSerils=ds.Tables[0].Rows[0]["NodeSerils"].ToString();
				NodeName=ds.Tables[0].Rows[0]["NodeName"].ToString();
				NodeAddr=ds.Tables[0].Rows[0]["NodeAddr"].ToString();
				NextNode=ds.Tables[0].Rows[0]["NextNode"].ToString();
				IFCanJump=ds.Tables[0].Rows[0]["IFCanJump"].ToString();
				IFCanView=ds.Tables[0].Rows[0]["IFCanView"].ToString();
				IFCanEdit=ds.Tables[0].Rows[0]["IFCanEdit"].ToString();
				IFCanDel=ds.Tables[0].Rows[0]["IFCanDel"].ToString();
				if(ds.Tables[0].Rows[0]["JieShuHours"].ToString()!="")
				{
					JieShuHours=int.Parse(ds.Tables[0].Rows[0]["JieShuHours"].ToString());
				}
				PSType=ds.Tables[0].Rows[0]["PSType"].ToString();
				SPType=ds.Tables[0].Rows[0]["SPType"].ToString();
				SPDefaultList=ds.Tables[0].Rows[0]["SPDefaultList"].ToString();
				CanWriteSet=ds.Tables[0].Rows[0]["CanWriteSet"].ToString();
				SecretSet=ds.Tables[0].Rows[0]["SecretSet"].ToString();
				ConditionSet=ds.Tables[0].Rows[0]["ConditionSet"].ToString();
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPNWorkFlowNode ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

