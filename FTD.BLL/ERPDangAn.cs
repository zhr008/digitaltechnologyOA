using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
	/// <summary>
	/// ��ERPDangAn��
	/// </summary>
	public class ERPDangAn
	{
		public ERPDangAn()
		{}
		#region Model
		private int _id;
		private string _filename;
		private string _juankuname;
		private string _fileserils;
		private string _filetitle;
		private string _fawendanwei;
		private string _fawendate;
		private string _miji;
		private string _jingji;
		private string _typestr;
		private string _gongwentype;
		private string _filepage;
		private string _fujianlist;
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
		/// �ļ�����
		/// </summary>
		public string FileName
		{
			set{ _filename=value;}
			get{return _filename;}
		}
		/// <summary>
		/// �������
		/// </summary>
		public string JuanKuName
		{
			set{ _juankuname=value;}
			get{return _juankuname;}
		}
		/// <summary>
		/// �ļ����
		/// </summary>
		public string FileSerils
		{
			set{ _fileserils=value;}
			get{return _fileserils;}
		}
		/// <summary>
		/// �ļ�����
		/// </summary>
		public string FileTitle
		{
			set{ _filetitle=value;}
			get{return _filetitle;}
		}
		/// <summary>
		/// ���ĵ�λ
		/// </summary>
		public string FaWenDanWei
		{
			set{ _fawendanwei=value;}
			get{return _fawendanwei;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string FaWenDate
		{
			set{ _fawendate=value;}
			get{return _fawendate;}
		}
		/// <summary>
		/// �ܼ�
		/// </summary>
		public string MiJi
		{
			set{ _miji=value;}
			get{return _miji;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string JingJi
		{
			set{ _jingji=value;}
			get{return _jingji;}
		}
		/// <summary>
		/// �ļ�����
		/// </summary>
		public string TypeStr
		{
			set{ _typestr=value;}
			get{return _typestr;}
		}
		/// <summary>
		/// �������
		/// </summary>
		public string GongWenType
		{
			set{ _gongwentype=value;}
			get{return _gongwentype;}
		}
		/// <summary>
		/// �ļ�ҳ��
		/// </summary>
		public string FilePage
		{
			set{ _filepage=value;}
			get{return _filepage;}
		}
		/// <summary>
		/// �����ļ�
		/// </summary>
		public string FuJianList
		{
			set{ _fujianlist=value;}
			get{return _fujianlist;}
		}
		/// <summary>
		/// ��ע��Ϣ
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
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
		public ERPDangAn(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,FileName,JuanKuName,FileSerils,FileTitle,FaWenDanWei,FaWenDate,MiJi,JingJi,TypeStr,GongWenType,FilePage,FuJianList,BackInfo,UserName,TimeStr ");
			strSql.Append(" FROM ERPDangAn ");
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
				FileName=ds.Tables[0].Rows[0]["FileName"].ToString();
				JuanKuName=ds.Tables[0].Rows[0]["JuanKuName"].ToString();
				FileSerils=ds.Tables[0].Rows[0]["FileSerils"].ToString();
				FileTitle=ds.Tables[0].Rows[0]["FileTitle"].ToString();
				FaWenDanWei=ds.Tables[0].Rows[0]["FaWenDanWei"].ToString();
				FaWenDate=ds.Tables[0].Rows[0]["FaWenDate"].ToString();
				MiJi=ds.Tables[0].Rows[0]["MiJi"].ToString();
				JingJi=ds.Tables[0].Rows[0]["JingJi"].ToString();
				TypeStr=ds.Tables[0].Rows[0]["TypeStr"].ToString();
				GongWenType=ds.Tables[0].Rows[0]["GongWenType"].ToString();
				FilePage=ds.Tables[0].Rows[0]["FilePage"].ToString();
				FuJianList=ds.Tables[0].Rows[0]["FuJianList"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
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

		return DbHelperSQL.GetMaxID("ID", "ERPDangAn"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPDangAn");
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
			strSql.Append("insert into ERPDangAn(");
			strSql.Append("FileName,JuanKuName,FileSerils,FileTitle,FaWenDanWei,FaWenDate,MiJi,JingJi,TypeStr,GongWenType,FilePage,FuJianList,BackInfo,UserName,TimeStr)");
			strSql.Append(" values (");
			strSql.Append("@FileName,@JuanKuName,@FileSerils,@FileTitle,@FaWenDanWei,@FaWenDate,@MiJi,@JingJi,@TypeStr,@GongWenType,@FilePage,@FuJianList,@BackInfo,@UserName,@TimeStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@FileName", SqlDbType.VarChar,50),
					new SqlParameter("@JuanKuName", SqlDbType.VarChar,50),
					new SqlParameter("@FileSerils", SqlDbType.VarChar,50),
					new SqlParameter("@FileTitle", SqlDbType.VarChar,50),
					new SqlParameter("@FaWenDanWei", SqlDbType.VarChar,50),
					new SqlParameter("@FaWenDate", SqlDbType.VarChar,50),
					new SqlParameter("@MiJi", SqlDbType.VarChar,50),
					new SqlParameter("@JingJi", SqlDbType.VarChar,50),
					new SqlParameter("@TypeStr", SqlDbType.VarChar,50),
					new SqlParameter("@GongWenType", SqlDbType.VarChar,50),
					new SqlParameter("@FilePage", SqlDbType.VarChar,50),
					new SqlParameter("@FuJianList", SqlDbType.VarChar,5000),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = FileName;
			parameters[1].Value = JuanKuName;
			parameters[2].Value = FileSerils;
			parameters[3].Value = FileTitle;
			parameters[4].Value = FaWenDanWei;
			parameters[5].Value = FaWenDate;
			parameters[6].Value = MiJi;
			parameters[7].Value = JingJi;
			parameters[8].Value = TypeStr;
			parameters[9].Value = GongWenType;
			parameters[10].Value = FilePage;
			parameters[11].Value = FuJianList;
			parameters[12].Value = BackInfo;
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
		/// ����һ������
		/// </summary>
		public void Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ERPDangAn set ");
			strSql.Append("FileName=@FileName,");
			strSql.Append("JuanKuName=@JuanKuName,");
			strSql.Append("FileSerils=@FileSerils,");
			strSql.Append("FileTitle=@FileTitle,");
			strSql.Append("FaWenDanWei=@FaWenDanWei,");
			strSql.Append("FaWenDate=@FaWenDate,");
			strSql.Append("MiJi=@MiJi,");
			strSql.Append("JingJi=@JingJi,");
			strSql.Append("TypeStr=@TypeStr,");
			strSql.Append("GongWenType=@GongWenType,");
			strSql.Append("FilePage=@FilePage,");
			strSql.Append("FuJianList=@FuJianList,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@FileName", SqlDbType.VarChar,50),
					new SqlParameter("@JuanKuName", SqlDbType.VarChar,50),
					new SqlParameter("@FileSerils", SqlDbType.VarChar,50),
					new SqlParameter("@FileTitle", SqlDbType.VarChar,50),
					new SqlParameter("@FaWenDanWei", SqlDbType.VarChar,50),
					new SqlParameter("@FaWenDate", SqlDbType.VarChar,50),
					new SqlParameter("@MiJi", SqlDbType.VarChar,50),
					new SqlParameter("@JingJi", SqlDbType.VarChar,50),
					new SqlParameter("@TypeStr", SqlDbType.VarChar,50),
					new SqlParameter("@GongWenType", SqlDbType.VarChar,50),
					new SqlParameter("@FilePage", SqlDbType.VarChar,50),
					new SqlParameter("@FuJianList", SqlDbType.VarChar,5000),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
			parameters[0].Value = ID;
			parameters[1].Value = FileName;
			parameters[2].Value = JuanKuName;
			parameters[3].Value = FileSerils;
			parameters[4].Value = FileTitle;
			parameters[5].Value = FaWenDanWei;
			parameters[6].Value = FaWenDate;
			parameters[7].Value = MiJi;
			parameters[8].Value = JingJi;
			parameters[9].Value = TypeStr;
			parameters[10].Value = GongWenType;
			parameters[11].Value = FilePage;
			parameters[12].Value = FuJianList;
			parameters[13].Value = BackInfo;
			parameters[14].Value = UserName;
			parameters[15].Value = TimeStr;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPDangAn ");
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
			strSql.Append("select  top 1 ID,FileName,JuanKuName,FileSerils,FileTitle,FaWenDanWei,FaWenDate,MiJi,JingJi,TypeStr,GongWenType,FilePage,FuJianList,BackInfo,UserName,TimeStr ");
			strSql.Append(" FROM ERPDangAn ");
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
				FileName=ds.Tables[0].Rows[0]["FileName"].ToString();
				JuanKuName=ds.Tables[0].Rows[0]["JuanKuName"].ToString();
				FileSerils=ds.Tables[0].Rows[0]["FileSerils"].ToString();
				FileTitle=ds.Tables[0].Rows[0]["FileTitle"].ToString();
				FaWenDanWei=ds.Tables[0].Rows[0]["FaWenDanWei"].ToString();
				FaWenDate=ds.Tables[0].Rows[0]["FaWenDate"].ToString();
				MiJi=ds.Tables[0].Rows[0]["MiJi"].ToString();
				JingJi=ds.Tables[0].Rows[0]["JingJi"].ToString();
				TypeStr=ds.Tables[0].Rows[0]["TypeStr"].ToString();
				GongWenType=ds.Tables[0].Rows[0]["GongWenType"].ToString();
				FilePage=ds.Tables[0].Rows[0]["FilePage"].ToString();
				FuJianList=ds.Tables[0].Rows[0]["FuJianList"].ToString();
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
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
			strSql.Append(" FROM ERPDangAn ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}

