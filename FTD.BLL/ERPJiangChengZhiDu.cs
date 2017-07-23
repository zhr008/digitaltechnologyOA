using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
	/// <summary>
	/// ��ERPJiangChengZhiDu��
	/// </summary>
	public class ERPJiangChengZhiDu
	{
		public ERPJiangChengZhiDu()
		{}
		#region Model
		private int _id;
		private string _titlestr;
		private string _jianjie;
		private string _username;
		private DateTime? _timestr;
		private string _fujianstr;
		private string _contentstr;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// �ƶȱ���
		/// </summary>
		public string TitleStr
		{
			set{ _titlestr=value;}
			get{return _titlestr;}
		}
		/// <summary>
		/// �ƶȼ��
		/// </summary>
		public string JianJie
		{
			set{ _jianjie=value;}
			get{return _jianjie;}
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
		/// �ƶ��ļ�
		/// </summary>
		public string FuJianStr
		{
			set{ _fujianstr=value;}
			get{return _fujianstr;}
		}
		/// <summary>
		/// �ƶ�����
		/// </summary>
		public string ConTentStr
		{
			set{ _contentstr=value;}
			get{return _contentstr;}
		}
		#endregion Model


		#region  ��Ա����

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ERPJiangChengZhiDu(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,TitleStr,JianJie,UserName,TimeStr,FuJianStr,ConTentStr ");
			strSql.Append(" FROM ERPJiangChengZhiDu ");
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
				TitleStr=ds.Tables[0].Rows[0]["TitleStr"].ToString();
				JianJie=ds.Tables[0].Rows[0]["JianJie"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				FuJianStr=ds.Tables[0].Rows[0]["FuJianStr"].ToString();
				ConTentStr=ds.Tables[0].Rows[0]["ConTentStr"].ToString();
			}
		}

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPJiangChengZhiDu"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPJiangChengZhiDu");
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
			strSql.Append("insert into ERPJiangChengZhiDu(");
			strSql.Append("TitleStr,JianJie,UserName,TimeStr,FuJianStr,ConTentStr)");
			strSql.Append(" values (");
			strSql.Append("@TitleStr,@JianJie,@UserName,@TimeStr,@FuJianStr,@ConTentStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@TitleStr", SqlDbType.VarChar,200),
					new SqlParameter("@JianJie", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@FuJianStr", SqlDbType.VarChar,500),
					new SqlParameter("@ConTentStr", SqlDbType.Text)};
			parameters[0].Value = TitleStr;
			parameters[1].Value = JianJie;
			parameters[2].Value = UserName;
			parameters[3].Value = TimeStr;
			parameters[4].Value = FuJianStr;
			parameters[5].Value = ConTentStr;

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
			strSql.Append("update ERPJiangChengZhiDu set ");
			strSql.Append("TitleStr=@TitleStr,");
			strSql.Append("JianJie=@JianJie,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr,");
			strSql.Append("FuJianStr=@FuJianStr,");
			strSql.Append("ConTentStr=@ConTentStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@TitleStr", SqlDbType.VarChar,200),
					new SqlParameter("@JianJie", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@FuJianStr", SqlDbType.VarChar,500),
					new SqlParameter("@ConTentStr", SqlDbType.Text)};
			parameters[0].Value = ID;
			parameters[1].Value = TitleStr;
			parameters[2].Value = JianJie;
			parameters[3].Value = UserName;
			parameters[4].Value = TimeStr;
			parameters[5].Value = FuJianStr;
			parameters[6].Value = ConTentStr;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPJiangChengZhiDu ");
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
			strSql.Append("select  top 1 ID,TitleStr,JianJie,UserName,TimeStr,FuJianStr,ConTentStr ");
			strSql.Append(" FROM ERPJiangChengZhiDu ");
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
				TitleStr=ds.Tables[0].Rows[0]["TitleStr"].ToString();
				JianJie=ds.Tables[0].Rows[0]["JianJie"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				FuJianStr=ds.Tables[0].Rows[0]["FuJianStr"].ToString();
				ConTentStr=ds.Tables[0].Rows[0]["ConTentStr"].ToString();
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPJiangChengZhiDu ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}

