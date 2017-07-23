using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
	/// <summary>
	/// ��ERPNWorkFlow��
	/// </summary>
	public class ERPNWorkFlow
	{
		public ERPNWorkFlow()
		{}
		#region Model
		private int _id;
		private string _workflowname;
		private int? _formid;
		private string _userlistok;
		private string _deplistok;
		private string _jiaoselistok;
		private string _paixustr;
		private string _username;
		private DateTime? _timestr;
		private string _backinfo;
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
		/// ��������
		/// </summary>
		public string WorkFlowName
		{
			set{ _workflowname=value;}
			get{return _workflowname;}
		}
		/// <summary>
		/// ���ñ�
		/// </summary>
		public int? FormID
		{
			set{ _formid=value;}
			get{return _formid;}
		}
		/// <summary>
		/// ����ʹ����
		/// </summary>
		public string UserListOK
		{
			set{ _userlistok=value;}
			get{return _userlistok;}
		}
		/// <summary>
		/// ����ʹ�ò���
		/// </summary>
		public string DepListOK
		{
			set{ _deplistok=value;}
			get{return _deplistok;}
		}
		/// <summary>
		/// ����ʹ�ý�ɫ
		/// </summary>
		public string JiaoSeListOK
		{
			set{ _jiaoselistok=value;}
			get{return _jiaoselistok;}
		}
		/// <summary>
		/// �����ַ�
		/// </summary>
		public string PaiXuStr
		{
			set{ _paixustr=value;}
			get{return _paixustr;}
		}
		/// <summary>
		/// ¼����
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// ¼��ʱ��
		/// </summary>
		public DateTime? TimeStr
		{
			set{ _timestr=value;}
			get{return _timestr;}
		}
		/// <summary>
		/// ��Ҫ˵��
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		/// <summary>
		/// �Ƿ�����
		/// </summary>
		public string IFOK
		{
			set{ _ifok=value;}
			get{return _ifok;}
		}
		#endregion Model


		#region  ��Ա����

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ERPNWorkFlow(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,WorkFlowName,FormID,UserListOK,DepListOK,JiaoSeListOK,PaiXuStr,UserName,TimeStr,BackInfo,IFOK ");
			strSql.Append(" FROM ERPNWorkFlow ");
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
				WorkFlowName=ds.Tables[0].Rows[0]["WorkFlowName"].ToString();
				if(ds.Tables[0].Rows[0]["FormID"].ToString()!="")
				{
					FormID=int.Parse(ds.Tables[0].Rows[0]["FormID"].ToString());
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
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				IFOK=ds.Tables[0].Rows[0]["IFOK"].ToString();
			}
		}

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPNWorkFlow"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPNWorkFlow");
			strSql.Append(" where ID=@ID ");

			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ERPNWorkFlow(");
			strSql.Append("WorkFlowName,FormID,UserListOK,DepListOK,JiaoSeListOK,PaiXuStr,UserName,TimeStr,BackInfo,IFOK)");
			strSql.Append(" values (");
			strSql.Append("@WorkFlowName,@FormID,@UserListOK,@DepListOK,@JiaoSeListOK,@PaiXuStr,@UserName,@TimeStr,@BackInfo,@IFOK)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkFlowName", SqlDbType.VarChar,200),
					new SqlParameter("@FormID", SqlDbType.Int,4),
					new SqlParameter("@UserListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@DepListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@JiaoSeListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@PaiXuStr", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,2000),
					new SqlParameter("@IFOK", SqlDbType.VarChar,50)};
			parameters[0].Value = WorkFlowName;
			parameters[1].Value = FormID;
			parameters[2].Value = UserListOK;
			parameters[3].Value = DepListOK;
			parameters[4].Value = JiaoSeListOK;
			parameters[5].Value = PaiXuStr;
			parameters[6].Value = UserName;
			parameters[7].Value = TimeStr;
			parameters[8].Value = BackInfo;
			parameters[9].Value = IFOK;

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
		/// ����һ������
		/// </summary>
		public void Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ERPNWorkFlow set ");
			strSql.Append("WorkFlowName=@WorkFlowName,");
			strSql.Append("FormID=@FormID,");
			strSql.Append("UserListOK=@UserListOK,");
			strSql.Append("DepListOK=@DepListOK,");
			strSql.Append("JiaoSeListOK=@JiaoSeListOK,");
			strSql.Append("PaiXuStr=@PaiXuStr,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append("IFOK=@IFOK");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@WorkFlowName", SqlDbType.VarChar,200),
					new SqlParameter("@FormID", SqlDbType.Int,4),
					new SqlParameter("@UserListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@DepListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@JiaoSeListOK", SqlDbType.VarChar,8000),
					new SqlParameter("@PaiXuStr", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,2000),
					new SqlParameter("@IFOK", SqlDbType.VarChar,50)};
			parameters[0].Value = ID;
			parameters[1].Value = WorkFlowName;
			parameters[2].Value = FormID;
			parameters[3].Value = UserListOK;
			parameters[4].Value = DepListOK;
			parameters[5].Value = JiaoSeListOK;
			parameters[6].Value = PaiXuStr;
			parameters[7].Value = UserName;
			parameters[8].Value = TimeStr;
			parameters[9].Value = BackInfo;
			parameters[10].Value = IFOK;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPNWorkFlow ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public void GetModel(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,WorkFlowName,FormID,UserListOK,DepListOK,JiaoSeListOK,PaiXuStr,UserName,TimeStr,BackInfo,IFOK ");
			strSql.Append(" FROM ERPNWorkFlow ");
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
				WorkFlowName=ds.Tables[0].Rows[0]["WorkFlowName"].ToString();
				if(ds.Tables[0].Rows[0]["FormID"].ToString()!="")
				{
					FormID=int.Parse(ds.Tables[0].Rows[0]["FormID"].ToString());
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
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				IFOK=ds.Tables[0].Rows[0]["IFOK"].ToString();
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPNWorkFlow ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}

