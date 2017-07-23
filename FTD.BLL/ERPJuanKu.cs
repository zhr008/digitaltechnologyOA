using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
    /// <summary>
    /// ��ERPJuanKu��
    /// </summary>
    public class ERPJuanKu
    {
        public ERPJuanKu()
        { }
        #region Model
        private int _id;
        private string _juankuname;
        private string _juankuserils;
        private string _suoshubumen;
        private string _backinfo;
        private string _username;
        private DateTime? _timestr;
        private string _canviewuserlist;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// �������
        /// </summary>
        public string JuanKuName
        {
            set { _juankuname = value; }
            get { return _juankuname; }
        }
        /// <summary>
        /// �����
        /// </summary>
        public string JuanKuSerils
        {
            set { _juankuserils = value; }
            get { return _juankuserils; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string SuoShuBuMen
        {
            set { _suoshubumen = value; }
            get { return _suoshubumen; }
        }
        /// <summary>
        /// ��ע˵��
        /// </summary>
        public string BackInfo
        {
            set { _backinfo = value; }
            get { return _backinfo; }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? TimeStr
        {
            set { _timestr = value; }
            get { return _timestr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CanViewUserList
        {
            set { _canviewuserlist = value; }
            get { return _canviewuserlist; }
        }
        #endregion Model


        #region  ��Ա����

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public ERPJuanKu(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,JuanKuName,JuanKuSerils,SuoShuBuMen,BackInfo,UserName,TimeStr,CanViewUserList ");
            strSql.Append(" FROM ERPJuanKu ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                JuanKuName = ds.Tables[0].Rows[0]["JuanKuName"].ToString();
                JuanKuSerils = ds.Tables[0].Rows[0]["JuanKuSerils"].ToString();
                SuoShuBuMen = ds.Tables[0].Rows[0]["SuoShuBuMen"].ToString();
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                CanViewUserList = ds.Tables[0].Rows[0]["CanViewUserList"].ToString();
            }
        }
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPJuanKu");
            strSql.Append(" where ID=@ID ");

            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ERPJuanKu(");
            strSql.Append("JuanKuName,JuanKuSerils,SuoShuBuMen,BackInfo,UserName,TimeStr,CanViewUserList)");
            strSql.Append(" values (");
            strSql.Append("@JuanKuName,@JuanKuSerils,@SuoShuBuMen,@BackInfo,@UserName,@TimeStr,@CanViewUserList)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@JuanKuName", SqlDbType.VarChar,50),
					new SqlParameter("@JuanKuSerils", SqlDbType.VarChar,50),
					new SqlParameter("@SuoShuBuMen", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@CanViewUserList", SqlDbType.VarChar,8000)};
            parameters[0].Value = JuanKuName;
            parameters[1].Value = JuanKuSerils;
            parameters[2].Value = SuoShuBuMen;
            parameters[3].Value = BackInfo;
            parameters[4].Value = UserName;
            parameters[5].Value = TimeStr;
            parameters[6].Value = CanViewUserList;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ERPJuanKu set ");
            strSql.Append("JuanKuName=@JuanKuName,");
            strSql.Append("JuanKuSerils=@JuanKuSerils,");
            strSql.Append("SuoShuBuMen=@SuoShuBuMen,");
            strSql.Append("BackInfo=@BackInfo,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TimeStr=@TimeStr,");
            strSql.Append("CanViewUserList=@CanViewUserList");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@JuanKuName", SqlDbType.VarChar,50),
					new SqlParameter("@JuanKuSerils", SqlDbType.VarChar,50),
					new SqlParameter("@SuoShuBuMen", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@CanViewUserList", SqlDbType.VarChar,8000)};
            parameters[0].Value = ID;
            parameters[1].Value = JuanKuName;
            parameters[2].Value = JuanKuSerils;
            parameters[3].Value = SuoShuBuMen;
            parameters[4].Value = BackInfo;
            parameters[5].Value = UserName;
            parameters[6].Value = TimeStr;
            parameters[7].Value = CanViewUserList;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPJuanKu ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public void GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,JuanKuName,JuanKuSerils,SuoShuBuMen,BackInfo,UserName,TimeStr,CanViewUserList ");
            strSql.Append(" FROM ERPJuanKu ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                JuanKuName = ds.Tables[0].Rows[0]["JuanKuName"].ToString();
                JuanKuSerils = ds.Tables[0].Rows[0]["JuanKuSerils"].ToString();
                SuoShuBuMen = ds.Tables[0].Rows[0]["SuoShuBuMen"].ToString();
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                CanViewUserList = ds.Tables[0].Rows[0]["CanViewUserList"].ToString();
            }
        }

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ERPJuanKu ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  ��Ա����
    }
}

