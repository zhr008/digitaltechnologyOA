using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
	/// <summary>
	/// ��ERPMianShi��
	/// </summary>
	public class ERPMianShi
	{
		public ERPMianShi()
		{}
		#region Model
		private int _id;
		private string _msname;
		private string _msdate;
		private string _mssex;
		private string _msage;
		private string _xueli;
		private string _zhuanye;
		private string _mszhiwei;
		private string _msjieguo;
		private string _backinfo;
		private string _fujianstr;
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
		/// ����������
		/// </summary>
		public string MSName
		{
			set{ _msname=value;}
			get{return _msname;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string MSDate
		{
			set{ _msdate=value;}
			get{return _msdate;}
		}
		/// <summary>
		/// �Ա�
		/// </summary>
		public string MSSex
		{
			set{ _mssex=value;}
			get{return _mssex;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string MSAge
		{
			set{ _msage=value;}
			get{return _msage;}
		}
		/// <summary>
		/// ѧ��
		/// </summary>
		public string XueLi
		{
			set{ _xueli=value;}
			get{return _xueli;}
		}
		/// <summary>
		/// רҵ
		/// </summary>
		public string ZhuanYe
		{
			set{ _zhuanye=value;}
			get{return _zhuanye;}
		}
		/// <summary>
		/// ����ְλ
		/// </summary>
		public string MSZhiWei
		{
			set{ _mszhiwei=value;}
			get{return _mszhiwei;}
		}
		/// <summary>
		/// ���Խ��
		/// </summary>
		public string MSJieGuo
		{
			set{ _msjieguo=value;}
			get{return _msjieguo;}
		}
		/// <summary>
		/// ��ע˵��
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		/// <summary>
		/// ����ļ�
		/// </summary>
		public string FuJianStr
		{
			set{ _fujianstr=value;}
			get{return _fujianstr;}
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
		#endregion Model


		#region  ��Ա����

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ERPMianShi(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,MSName,MSDate,MSSex,MSAge,XueLi,ZhuanYe,MSZhiWei,MSJieGuo,BackInfo,FuJianStr,UserName,TimeStr ");
			strSql.Append(" FROM ERPMianShi ");
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
				MSName=ds.Tables[0].Rows[0]["MSName"].ToString();
				MSDate=ds.Tables[0].Rows[0]["MSDate"].ToString();
				MSSex=ds.Tables[0].Rows[0]["MSSex"].ToString();
				MSAge=ds.Tables[0].Rows[0]["MSAge"].ToString();
				XueLi=ds.Tables[0].Rows[0]["XueLi"].ToString();
				ZhuanYe=ds.Tables[0].Rows[0]["ZhuanYe"].ToString();
				MSZhiWei=ds.Tables[0].Rows[0]["MSZhiWei"].ToString();
				MSJieGuo=ds.Tables[0].Rows[0]["MSJieGuo"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				FuJianStr=ds.Tables[0].Rows[0]["FuJianStr"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
			}
		}

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPMianShi"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPMianShi");
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
			strSql.Append("insert into ERPMianShi(");
			strSql.Append("MSName,MSDate,MSSex,MSAge,XueLi,ZhuanYe,MSZhiWei,MSJieGuo,BackInfo,FuJianStr,UserName,TimeStr)");
			strSql.Append(" values (");
			strSql.Append("@MSName,@MSDate,@MSSex,@MSAge,@XueLi,@ZhuanYe,@MSZhiWei,@MSJieGuo,@BackInfo,@FuJianStr,@UserName,@TimeStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MSName", SqlDbType.VarChar,50),
					new SqlParameter("@MSDate", SqlDbType.VarChar,50),
					new SqlParameter("@MSSex", SqlDbType.VarChar,50),
					new SqlParameter("@MSAge", SqlDbType.VarChar,50),
					new SqlParameter("@XueLi", SqlDbType.VarChar,50),
					new SqlParameter("@ZhuanYe", SqlDbType.VarChar,50),
					new SqlParameter("@MSZhiWei", SqlDbType.VarChar,50),
					new SqlParameter("@MSJieGuo", SqlDbType.VarChar,100),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@FuJianStr", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = MSName;
			parameters[1].Value = MSDate;
			parameters[2].Value = MSSex;
			parameters[3].Value = MSAge;
			parameters[4].Value = XueLi;
			parameters[5].Value = ZhuanYe;
			parameters[6].Value = MSZhiWei;
			parameters[7].Value = MSJieGuo;
			parameters[8].Value = BackInfo;
			parameters[9].Value = FuJianStr;
			parameters[10].Value = UserName;
			parameters[11].Value = TimeStr;

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
			strSql.Append("update ERPMianShi set ");
			strSql.Append("MSName=@MSName,");
			strSql.Append("MSDate=@MSDate,");
			strSql.Append("MSSex=@MSSex,");
			strSql.Append("MSAge=@MSAge,");
			strSql.Append("XueLi=@XueLi,");
			strSql.Append("ZhuanYe=@ZhuanYe,");
			strSql.Append("MSZhiWei=@MSZhiWei,");
			strSql.Append("MSJieGuo=@MSJieGuo,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append("FuJianStr=@FuJianStr,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MSName", SqlDbType.VarChar,50),
					new SqlParameter("@MSDate", SqlDbType.VarChar,50),
					new SqlParameter("@MSSex", SqlDbType.VarChar,50),
					new SqlParameter("@MSAge", SqlDbType.VarChar,50),
					new SqlParameter("@XueLi", SqlDbType.VarChar,50),
					new SqlParameter("@ZhuanYe", SqlDbType.VarChar,50),
					new SqlParameter("@MSZhiWei", SqlDbType.VarChar,50),
					new SqlParameter("@MSJieGuo", SqlDbType.VarChar,100),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@FuJianStr", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = ID;
			parameters[1].Value = MSName;
			parameters[2].Value = MSDate;
			parameters[3].Value = MSSex;
			parameters[4].Value = MSAge;
			parameters[5].Value = XueLi;
			parameters[6].Value = ZhuanYe;
			parameters[7].Value = MSZhiWei;
			parameters[8].Value = MSJieGuo;
			parameters[9].Value = BackInfo;
			parameters[10].Value = FuJianStr;
			parameters[11].Value = UserName;
			parameters[12].Value = TimeStr;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPMianShi ");
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
			strSql.Append("select  top 1 ID,MSName,MSDate,MSSex,MSAge,XueLi,ZhuanYe,MSZhiWei,MSJieGuo,BackInfo,FuJianStr,UserName,TimeStr ");
			strSql.Append(" FROM ERPMianShi ");
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
				MSName=ds.Tables[0].Rows[0]["MSName"].ToString();
				MSDate=ds.Tables[0].Rows[0]["MSDate"].ToString();
				MSSex=ds.Tables[0].Rows[0]["MSSex"].ToString();
				MSAge=ds.Tables[0].Rows[0]["MSAge"].ToString();
				XueLi=ds.Tables[0].Rows[0]["XueLi"].ToString();
				ZhuanYe=ds.Tables[0].Rows[0]["ZhuanYe"].ToString();
				MSZhiWei=ds.Tables[0].Rows[0]["MSZhiWei"].ToString();
				MSJieGuo=ds.Tables[0].Rows[0]["MSJieGuo"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				FuJianStr=ds.Tables[0].Rows[0]["FuJianStr"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPMianShi ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}

