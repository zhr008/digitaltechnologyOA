using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
	/// <summary>
	/// ��ERPContractChanPin��
	/// </summary>
	public class ERPContractChanPin
	{
		public ERPContractChanPin()
		{}
		#region Model
		private int _id;
		private string _hetongname;
		private string _chanpinname;
		private decimal? _danjia;
		private decimal? _shuliang;
		private decimal? _zongjia;
		private decimal? _yifukuan;
		private decimal? _qiankuanshu;
		private string _ifjiaofu;
		private string _username;
		private DateTime? _timestr;
		private string _backinfo;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ��ͬ����
		/// </summary>
		public string HeTongName
		{
			set{ _hetongname=value;}
			get{return _hetongname;}
		}
		/// <summary>
		/// ��Ʒ����
		/// </summary>
		public string ChanPinName
		{
			set{ _chanpinname=value;}
			get{return _chanpinname;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public decimal? DanJia
		{
			set{ _danjia=value;}
			get{return _danjia;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public decimal? ShuLiang
		{
			set{ _shuliang=value;}
			get{return _shuliang;}
		}
		/// <summary>
		/// �ܼ�
		/// </summary>
		public decimal? ZongJia
		{
			set{ _zongjia=value;}
			get{return _zongjia;}
		}
		/// <summary>
		/// �Ѹ�����
		/// </summary>
		public decimal? YiFuKuan
		{
			set{ _yifukuan=value;}
			get{return _yifukuan;}
		}
		/// <summary>
		/// Ƿ����
		/// </summary>
		public decimal? QianKuanShu
		{
			set{ _qiankuanshu=value;}
			get{return _qiankuanshu;}
		}
		/// <summary>
		/// �Ƿ񽻸�������������٣�
		/// </summary>
		public string IFJiaoFu
		{
			set{ _ifjiaofu=value;}
			get{return _ifjiaofu;}
		}
		/// <summary>
		/// ��д��
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// ��дʱ��
		/// </summary>
		public DateTime? TimeStr
		{
			set{ _timestr=value;}
			get{return _timestr;}
		}
		/// <summary>
		/// ��ע˵��
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		#endregion Model


		#region  ��Ա����

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ERPContractChanPin(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,HeTongName,ChanPinName,DanJia,ShuLiang,ZongJia,YiFuKuan,QianKuanShu,IFJiaoFu,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPContractChanPin ");
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
				HeTongName=ds.Tables[0].Rows[0]["HeTongName"].ToString();
				ChanPinName=ds.Tables[0].Rows[0]["ChanPinName"].ToString();
				if(ds.Tables[0].Rows[0]["DanJia"].ToString()!="")
				{
					DanJia=decimal.Parse(ds.Tables[0].Rows[0]["DanJia"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ShuLiang"].ToString()!="")
				{
					ShuLiang=decimal.Parse(ds.Tables[0].Rows[0]["ShuLiang"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ZongJia"].ToString()!="")
				{
					ZongJia=decimal.Parse(ds.Tables[0].Rows[0]["ZongJia"].ToString());
				}
				if(ds.Tables[0].Rows[0]["YiFuKuan"].ToString()!="")
				{
					YiFuKuan=decimal.Parse(ds.Tables[0].Rows[0]["YiFuKuan"].ToString());
				}
				if(ds.Tables[0].Rows[0]["QianKuanShu"].ToString()!="")
				{
					QianKuanShu=decimal.Parse(ds.Tables[0].Rows[0]["QianKuanShu"].ToString());
				}
				IFJiaoFu=ds.Tables[0].Rows[0]["IFJiaoFu"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
			}
		}

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPContractChanPin"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPContractChanPin");
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
			strSql.Append("insert into ERPContractChanPin(");
			strSql.Append("HeTongName,ChanPinName,DanJia,ShuLiang,ZongJia,YiFuKuan,QianKuanShu,IFJiaoFu,UserName,TimeStr,BackInfo)");
			strSql.Append(" values (");
			strSql.Append("@HeTongName,@ChanPinName,@DanJia,@ShuLiang,@ZongJia,@YiFuKuan,@QianKuanShu,@IFJiaoFu,@UserName,@TimeStr,@BackInfo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@HeTongName", SqlDbType.VarChar,50),
					new SqlParameter("@ChanPinName", SqlDbType.VarChar,50),
					new SqlParameter("@DanJia", SqlDbType.Decimal,9),
					new SqlParameter("@ShuLiang", SqlDbType.Decimal,9),
					new SqlParameter("@ZongJia", SqlDbType.Decimal,9),
					new SqlParameter("@YiFuKuan", SqlDbType.Decimal,9),
					new SqlParameter("@QianKuanShu", SqlDbType.Decimal,9),
					new SqlParameter("@IFJiaoFu", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = HeTongName;
			parameters[1].Value = ChanPinName;
			parameters[2].Value = DanJia;
			parameters[3].Value = ShuLiang;
			parameters[4].Value = ZongJia;
			parameters[5].Value = YiFuKuan;
			parameters[6].Value = QianKuanShu;
			parameters[7].Value = IFJiaoFu;
			parameters[8].Value = UserName;
			parameters[9].Value = TimeStr;
			parameters[10].Value = BackInfo;

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
			strSql.Append("update ERPContractChanPin set ");
			strSql.Append("HeTongName=@HeTongName,");
			strSql.Append("ChanPinName=@ChanPinName,");
			strSql.Append("DanJia=@DanJia,");
			strSql.Append("ShuLiang=@ShuLiang,");
			strSql.Append("ZongJia=@ZongJia,");
			strSql.Append("YiFuKuan=@YiFuKuan,");
			strSql.Append("QianKuanShu=@QianKuanShu,");
			strSql.Append("IFJiaoFu=@IFJiaoFu,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr,");
			strSql.Append("BackInfo=@BackInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@HeTongName", SqlDbType.VarChar,50),
					new SqlParameter("@ChanPinName", SqlDbType.VarChar,50),
					new SqlParameter("@DanJia", SqlDbType.Decimal,9),
					new SqlParameter("@ShuLiang", SqlDbType.Decimal,9),
					new SqlParameter("@ZongJia", SqlDbType.Decimal,9),
					new SqlParameter("@YiFuKuan", SqlDbType.Decimal,9),
					new SqlParameter("@QianKuanShu", SqlDbType.Decimal,9),
					new SqlParameter("@IFJiaoFu", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = ID;
			parameters[1].Value = HeTongName;
			parameters[2].Value = ChanPinName;
			parameters[3].Value = DanJia;
			parameters[4].Value = ShuLiang;
			parameters[5].Value = ZongJia;
			parameters[6].Value = YiFuKuan;
			parameters[7].Value = QianKuanShu;
			parameters[8].Value = IFJiaoFu;
			parameters[9].Value = UserName;
			parameters[10].Value = TimeStr;
			parameters[11].Value = BackInfo;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPContractChanPin ");
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
			strSql.Append("select  top 1 ID,HeTongName,ChanPinName,DanJia,ShuLiang,ZongJia,YiFuKuan,QianKuanShu,IFJiaoFu,UserName,TimeStr,BackInfo ");
			strSql.Append(" FROM ERPContractChanPin ");
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
				HeTongName=ds.Tables[0].Rows[0]["HeTongName"].ToString();
				ChanPinName=ds.Tables[0].Rows[0]["ChanPinName"].ToString();
				if(ds.Tables[0].Rows[0]["DanJia"].ToString()!="")
				{
					DanJia=decimal.Parse(ds.Tables[0].Rows[0]["DanJia"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ShuLiang"].ToString()!="")
				{
					ShuLiang=decimal.Parse(ds.Tables[0].Rows[0]["ShuLiang"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ZongJia"].ToString()!="")
				{
					ZongJia=decimal.Parse(ds.Tables[0].Rows[0]["ZongJia"].ToString());
				}
				if(ds.Tables[0].Rows[0]["YiFuKuan"].ToString()!="")
				{
					YiFuKuan=decimal.Parse(ds.Tables[0].Rows[0]["YiFuKuan"].ToString());
				}
				if(ds.Tables[0].Rows[0]["QianKuanShu"].ToString()!="")
				{
					QianKuanShu=decimal.Parse(ds.Tables[0].Rows[0]["QianKuanShu"].ToString());
				}
				IFJiaoFu=ds.Tables[0].Rows[0]["IFJiaoFu"].ToString();
				UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				if(ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPContractChanPin ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  ��Ա����
	}
}

