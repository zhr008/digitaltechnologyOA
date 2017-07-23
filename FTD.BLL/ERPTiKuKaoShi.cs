using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//�����������
namespace FTD.BLL
{
    /// <summary>
    /// ��ERPTiKuKaoShi��
    /// </summary>
    public class ERPTiKuKaoShi
    {
        public ERPTiKuKaoShi()
        { }
        #region Model
        private int _id;
        private string _username;
        private DateTime? _timestr;
        private int? _shijuanid;
        private string _shijuanname;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// �û���
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// �ύʱ��
        /// </summary>
        public DateTime? TimeStr
        {
            set { _timestr = value; }
            get { return _timestr; }
        }
        /// <summary>
        /// �����Ծ�ID
        /// </summary>
        public int? ShiJuanID
        {
            set { _shijuanid = value; }
            get { return _shijuanid; }
        }
        /// <summary>
        /// �Ծ�����
        /// </summary>
        public string ShiJuanName
        {
            set { _shijuanname = value; }
            get { return _shijuanname; }
        }
        #endregion Model


        #region  ��Ա����

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public ERPTiKuKaoShi(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,UserName,TimeStr,ShiJuanID,ShiJuanName ");
            strSql.Append(" FROM ERPTiKuKaoShi ");
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
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ShiJuanID"].ToString() != "")
                {
                    ShiJuanID = int.Parse(ds.Tables[0].Rows[0]["ShiJuanID"].ToString());
                }
                ShiJuanName = ds.Tables[0].Rows[0]["ShiJuanName"].ToString();
            }
        }
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPTiKuKaoShi");
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
            strSql.Append("insert into ERPTiKuKaoShi(");
            strSql.Append("UserName,TimeStr,ShiJuanID,ShiJuanName)");
            strSql.Append(" values (");
            strSql.Append("@UserName,@TimeStr,@ShiJuanID,@ShiJuanName)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@ShiJuanID", SqlDbType.Int,4),
					new SqlParameter("@ShiJuanName", SqlDbType.VarChar,500)};
            parameters[0].Value = UserName;
            parameters[1].Value = TimeStr;
            parameters[2].Value = ShiJuanID;
            parameters[3].Value = ShiJuanName;

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
            strSql.Append("update ERPTiKuKaoShi set ");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TimeStr=@TimeStr,");
            strSql.Append("ShiJuanID=@ShiJuanID,");
            strSql.Append("ShiJuanName=@ShiJuanName");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@ShiJuanID", SqlDbType.Int,4),
					new SqlParameter("@ShiJuanName", SqlDbType.VarChar,500)};
            parameters[0].Value = ID;
            parameters[1].Value = UserName;
            parameters[2].Value = TimeStr;
            parameters[3].Value = ShiJuanID;
            parameters[4].Value = ShiJuanName;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPTiKuKaoShi ");
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
            strSql.Append("select  top 1 ID,UserName,TimeStr,ShiJuanID,ShiJuanName ");
            strSql.Append(" FROM ERPTiKuKaoShi ");
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
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ShiJuanID"].ToString() != "")
                {
                    ShiJuanID = int.Parse(ds.Tables[0].Rows[0]["ShiJuanID"].ToString());
                }
                ShiJuanName = ds.Tables[0].Rows[0]["ShiJuanName"].ToString();
            }
        }

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ERPTiKuKaoShi ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  ��Ա����
    }
}

