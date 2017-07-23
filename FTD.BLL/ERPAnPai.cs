﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPAnPai。
    /// </summary>
    public class ERPAnPai
    {
        public ERPAnPai()
        { }
        #region Model
        private int _id;
        private string _username;
        private string _titlestr;
        private string _contentstr;
        private DateTime? _timestart;
        private DateTime? _timeend;
        private DateTime? _timetixing;
        private string _typestr;
        private DateTime? _timestr;
        private string _gongxiangwho;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TitleStr
        {
            set { _titlestr = value; }
            get { return _titlestr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ContentStr
        {
            set { _contentstr = value; }
            get { return _contentstr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? TimeStart
        {
            set { _timestart = value; }
            get { return _timestart; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? TimeEnd
        {
            set { _timeend = value; }
            get { return _timeend; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? TimeTiXing
        {
            set { _timetixing = value; }
            get { return _timetixing; }
        }
        /// <summary>
        /// 安排类型
        /// </summary>
        public string TypeStr
        {
            set { _typestr = value; }
            get { return _typestr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? TimeStr
        {
            set { _timestr = value; }
            get { return _timestr; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GongXiangWho
        {
            set { _gongxiangwho = value; }
            get { return _gongxiangwho; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPAnPai(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,UserName,TitleStr,ContentStr,TimeStart,TimeEnd,TimeTiXing,TypeStr,TimeStr,GongXiangWho ");
            strSql.Append(" FROM ERPAnPai ");
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
                TitleStr = ds.Tables[0].Rows[0]["TitleStr"].ToString();
                ContentStr = ds.Tables[0].Rows[0]["ContentStr"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStart"].ToString() != "")
                {
                    TimeStart = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStart"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TimeEnd"].ToString() != "")
                {
                    TimeEnd = DateTime.Parse(ds.Tables[0].Rows[0]["TimeEnd"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TimeTiXing"].ToString() != "")
                {
                    TimeTiXing = DateTime.Parse(ds.Tables[0].Rows[0]["TimeTiXing"].ToString());
                }
                TypeStr = ds.Tables[0].Rows[0]["TypeStr"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                GongXiangWho = ds.Tables[0].Rows[0]["GongXiangWho"].ToString();
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPAnPai");
            strSql.Append(" where ID=@ID ");

            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ERPAnPai(");
            strSql.Append("UserName,TitleStr,ContentStr,TimeStart,TimeEnd,TimeTiXing,TypeStr,TimeStr,GongXiangWho)");
            strSql.Append(" values (");
            strSql.Append("@UserName,@TitleStr,@ContentStr,@TimeStart,@TimeEnd,@TimeTiXing,@TypeStr,@TimeStr,@GongXiangWho)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TitleStr", SqlDbType.VarChar,500),
					new SqlParameter("@ContentStr", SqlDbType.Text),
					new SqlParameter("@TimeStart", SqlDbType.DateTime),
					new SqlParameter("@TimeEnd", SqlDbType.DateTime),
					new SqlParameter("@TimeTiXing", SqlDbType.DateTime),
					new SqlParameter("@TypeStr", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@GongXiangWho", SqlDbType.VarChar,5000)};
            parameters[0].Value = UserName;
            parameters[1].Value = TitleStr;
            parameters[2].Value = ContentStr;
            parameters[3].Value = TimeStart;
            parameters[4].Value = TimeEnd;
            parameters[5].Value = TimeTiXing;
            parameters[6].Value = TypeStr;
            parameters[7].Value = TimeStr;
            parameters[8].Value = GongXiangWho;

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
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ERPAnPai set ");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TitleStr=@TitleStr,");
            strSql.Append("ContentStr=@ContentStr,");
            strSql.Append("TimeStart=@TimeStart,");
            strSql.Append("TimeEnd=@TimeEnd,");
            strSql.Append("TimeTiXing=@TimeTiXing,");
            strSql.Append("TypeStr=@TypeStr,");
            strSql.Append("TimeStr=@TimeStr,");
            strSql.Append("GongXiangWho=@GongXiangWho");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TitleStr", SqlDbType.VarChar,500),
					new SqlParameter("@ContentStr", SqlDbType.Text),
					new SqlParameter("@TimeStart", SqlDbType.DateTime),
					new SqlParameter("@TimeEnd", SqlDbType.DateTime),
					new SqlParameter("@TimeTiXing", SqlDbType.DateTime),
					new SqlParameter("@TypeStr", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@GongXiangWho", SqlDbType.VarChar,5000)};
            parameters[0].Value = ID;
            parameters[1].Value = UserName;
            parameters[2].Value = TitleStr;
            parameters[3].Value = ContentStr;
            parameters[4].Value = TimeStart;
            parameters[5].Value = TimeEnd;
            parameters[6].Value = TimeTiXing;
            parameters[7].Value = TypeStr;
            parameters[8].Value = TimeStr;
            parameters[9].Value = GongXiangWho;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete ERPAnPai ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,UserName,TitleStr,ContentStr,TimeStart,TimeEnd,TimeTiXing,TypeStr,TimeStr,GongXiangWho ");
            strSql.Append(" FROM ERPAnPai ");
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
                TitleStr = ds.Tables[0].Rows[0]["TitleStr"].ToString();
                ContentStr = ds.Tables[0].Rows[0]["ContentStr"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStart"].ToString() != "")
                {
                    TimeStart = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStart"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TimeEnd"].ToString() != "")
                {
                    TimeEnd = DateTime.Parse(ds.Tables[0].Rows[0]["TimeEnd"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TimeTiXing"].ToString() != "")
                {
                    TimeTiXing = DateTime.Parse(ds.Tables[0].Rows[0]["TimeTiXing"].ToString());
                }
                TypeStr = ds.Tables[0].Rows[0]["TypeStr"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                GongXiangWho = ds.Tables[0].Rows[0]["GongXiangWho"].ToString();
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ID],[UserName],[TitleStr],[ContentStr],[TimeStart],[TimeEnd],[TimeTiXing],[TypeStr],[TimeStr],[GongXiangWho] ");
            strSql.Append(" FROM ERPAnPai ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

