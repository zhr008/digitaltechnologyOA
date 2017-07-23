using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPFileList。
    /// </summary>
    public class ERPFileList
    {
        public ERPFileList()
        { }
        #region Model
        private int _id;
        private string _filename;
        private string _bianhao;
        private string _backinfo;
        private int? _daxiao;
        private string _filetype;
        private int? _dirid;
        private DateTime? _shangchuantime;
        private string _filepath;
        private string _username;
        private string _ifdel;
        private string _typename;
        private string _ifshare;
        private int? _dirorfile;
        private string _canadd;
        private string _canmod;
        private string _candel;
        private string _canview;
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
        public string FileName
        {
            set { _filename = value; }
            get { return _filename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BianHao
        {
            set { _bianhao = value; }
            get { return _bianhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BackInfo
        {
            set { _backinfo = value; }
            get { return _backinfo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? DaXiao
        {
            set { _daxiao = value; }
            get { return _daxiao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FileType
        {
            set { _filetype = value; }
            get { return _filetype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? DirID
        {
            set { _dirid = value; }
            get { return _dirid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ShangChuanTime
        {
            set { _shangchuantime = value; }
            get { return _shangchuantime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FilePath
        {
            set { _filepath = value; }
            get { return _filepath; }
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
        public string IFDel
        {
            set { _ifdel = value; }
            get { return _ifdel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TypeName
        {
            set { _typename = value; }
            get { return _typename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IfShare
        {
            set { _ifshare = value; }
            get { return _ifshare; }
        }
        /// <summary>
        /// 0代表文件，1代表文件夹
        /// </summary>
        public int? DirOrFile
        {
            set { _dirorfile = value; }
            get { return _dirorfile; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CanAdd
        {
            set { _canadd = value; }
            get { return _canadd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CanMod
        {
            set { _canmod = value; }
            get { return _canmod; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CanDel
        {
            set { _candel = value; }
            get { return _candel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CanView
        {
            set { _canview = value; }
            get { return _canview; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPFileList(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,FileName,BianHao,BackInfo,DaXiao,FileType,DirID,ShangChuanTime,FilePath,UserName,IFDel,TypeName,IfShare,DirOrFile,CanAdd,CanMod,CanDel,CanView ");
            strSql.Append(" FROM ERPFileList ");
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
                FileName = ds.Tables[0].Rows[0]["FileName"].ToString();
                BianHao = ds.Tables[0].Rows[0]["BianHao"].ToString();
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
                if (ds.Tables[0].Rows[0]["DaXiao"].ToString() != "")
                {
                    DaXiao = int.Parse(ds.Tables[0].Rows[0]["DaXiao"].ToString());
                }
                FileType = ds.Tables[0].Rows[0]["FileType"].ToString();
                if (ds.Tables[0].Rows[0]["DirID"].ToString() != "")
                {
                    DirID = int.Parse(ds.Tables[0].Rows[0]["DirID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ShangChuanTime"].ToString() != "")
                {
                    ShangChuanTime = DateTime.Parse(ds.Tables[0].Rows[0]["ShangChuanTime"].ToString());
                }
                FilePath = ds.Tables[0].Rows[0]["FilePath"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                IFDel = ds.Tables[0].Rows[0]["IFDel"].ToString();
                TypeName = ds.Tables[0].Rows[0]["TypeName"].ToString();
                IfShare = ds.Tables[0].Rows[0]["IfShare"].ToString();
                if (ds.Tables[0].Rows[0]["DirOrFile"].ToString() != "")
                {
                    DirOrFile = int.Parse(ds.Tables[0].Rows[0]["DirOrFile"].ToString());
                }
                CanAdd = ds.Tables[0].Rows[0]["CanAdd"].ToString();
                CanMod = ds.Tables[0].Rows[0]["CanMod"].ToString();
                CanDel = ds.Tables[0].Rows[0]["CanDel"].ToString();
                CanView = ds.Tables[0].Rows[0]["CanView"].ToString();
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPFileList");
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
            strSql.Append("insert into ERPFileList(");
            strSql.Append("FileName,BianHao,BackInfo,DaXiao,FileType,DirID,ShangChuanTime,FilePath,UserName,IFDel,TypeName,IfShare,DirOrFile,CanAdd,CanMod,CanDel,CanView)");
            strSql.Append(" values (");
            strSql.Append("@FileName,@BianHao,@BackInfo,@DaXiao,@FileType,@DirID,@ShangChuanTime,@FilePath,@UserName,@IFDel,@TypeName,@IfShare,@DirOrFile,@CanAdd,@CanMod,@CanDel,@CanView)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@FileName", SqlDbType.VarChar,50),
					new SqlParameter("@BianHao", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.Text),
					new SqlParameter("@DaXiao", SqlDbType.Int,4),
					new SqlParameter("@FileType", SqlDbType.VarChar,50),
					new SqlParameter("@DirID", SqlDbType.Int,4),
					new SqlParameter("@ShangChuanTime", SqlDbType.DateTime),
					new SqlParameter("@FilePath", SqlDbType.VarChar,200),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@IFDel", SqlDbType.VarChar,50),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@IfShare", SqlDbType.VarChar,50),
					new SqlParameter("@DirOrFile", SqlDbType.Int,4),
					new SqlParameter("@CanAdd", SqlDbType.VarChar,5000),
					new SqlParameter("@CanMod", SqlDbType.VarChar,5000),
					new SqlParameter("@CanDel", SqlDbType.VarChar,5000),
					new SqlParameter("@CanView", SqlDbType.VarChar,5000)};
            parameters[0].Value = FileName;
            parameters[1].Value = BianHao;
            parameters[2].Value = BackInfo;
            parameters[3].Value = DaXiao;
            parameters[4].Value = FileType;
            parameters[5].Value = DirID;
            parameters[6].Value = ShangChuanTime;
            parameters[7].Value = FilePath;
            parameters[8].Value = UserName;
            parameters[9].Value = IFDel;
            parameters[10].Value = TypeName;
            parameters[11].Value = IfShare;
            parameters[12].Value = DirOrFile;
            parameters[13].Value = CanAdd;
            parameters[14].Value = CanMod;
            parameters[15].Value = CanDel;
            parameters[16].Value = CanView;

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
            strSql.Append("update ERPFileList set ");
            strSql.Append("FileName=@FileName,");
            strSql.Append("BianHao=@BianHao,");
            strSql.Append("BackInfo=@BackInfo,");
            strSql.Append("DaXiao=@DaXiao,");
            strSql.Append("FileType=@FileType,");
            strSql.Append("DirID=@DirID,");
            strSql.Append("ShangChuanTime=@ShangChuanTime,");
            strSql.Append("FilePath=@FilePath,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("IFDel=@IFDel,");
            strSql.Append("TypeName=@TypeName,");
            strSql.Append("IfShare=@IfShare,");
            strSql.Append("DirOrFile=@DirOrFile,");
            strSql.Append("CanAdd=@CanAdd,");
            strSql.Append("CanMod=@CanMod,");
            strSql.Append("CanDel=@CanDel,");
            strSql.Append("CanView=@CanView");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@FileName", SqlDbType.VarChar,50),
					new SqlParameter("@BianHao", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.Text),
					new SqlParameter("@DaXiao", SqlDbType.Int,4),
					new SqlParameter("@FileType", SqlDbType.VarChar,50),
					new SqlParameter("@DirID", SqlDbType.Int,4),
					new SqlParameter("@ShangChuanTime", SqlDbType.DateTime),
					new SqlParameter("@FilePath", SqlDbType.VarChar,200),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@IFDel", SqlDbType.VarChar,50),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@IfShare", SqlDbType.VarChar,50),
					new SqlParameter("@DirOrFile", SqlDbType.Int,4),
					new SqlParameter("@CanAdd", SqlDbType.VarChar,5000),
					new SqlParameter("@CanMod", SqlDbType.VarChar,5000),
					new SqlParameter("@CanDel", SqlDbType.VarChar,5000),
					new SqlParameter("@CanView", SqlDbType.VarChar,5000)};
            parameters[0].Value = ID;
            parameters[1].Value = FileName;
            parameters[2].Value = BianHao;
            parameters[3].Value = BackInfo;
            parameters[4].Value = DaXiao;
            parameters[5].Value = FileType;
            parameters[6].Value = DirID;
            parameters[7].Value = ShangChuanTime;
            parameters[8].Value = FilePath;
            parameters[9].Value = UserName;
            parameters[10].Value = IFDel;
            parameters[11].Value = TypeName;
            parameters[12].Value = IfShare;
            parameters[13].Value = DirOrFile;
            parameters[14].Value = CanAdd;
            parameters[15].Value = CanMod;
            parameters[16].Value = CanDel;
            parameters[17].Value = CanView;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPFileList ");
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
            strSql.Append("select  top 1 ID,FileName,BianHao,BackInfo,DaXiao,FileType,DirID,ShangChuanTime,FilePath,UserName,IFDel,TypeName,IfShare,DirOrFile,CanAdd,CanMod,CanDel,CanView ");
            strSql.Append(" FROM ERPFileList ");
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
                FileName = ds.Tables[0].Rows[0]["FileName"].ToString();
                BianHao = ds.Tables[0].Rows[0]["BianHao"].ToString();
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
                if (ds.Tables[0].Rows[0]["DaXiao"].ToString() != "")
                {
                    DaXiao = int.Parse(ds.Tables[0].Rows[0]["DaXiao"].ToString());
                }
                FileType = ds.Tables[0].Rows[0]["FileType"].ToString();
                if (ds.Tables[0].Rows[0]["DirID"].ToString() != "")
                {
                    DirID = int.Parse(ds.Tables[0].Rows[0]["DirID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ShangChuanTime"].ToString() != "")
                {
                    ShangChuanTime = DateTime.Parse(ds.Tables[0].Rows[0]["ShangChuanTime"].ToString());
                }
                FilePath = ds.Tables[0].Rows[0]["FilePath"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                IFDel = ds.Tables[0].Rows[0]["IFDel"].ToString();
                TypeName = ds.Tables[0].Rows[0]["TypeName"].ToString();
                IfShare = ds.Tables[0].Rows[0]["IfShare"].ToString();
                if (ds.Tables[0].Rows[0]["DirOrFile"].ToString() != "")
                {
                    DirOrFile = int.Parse(ds.Tables[0].Rows[0]["DirOrFile"].ToString());
                }
                CanAdd = ds.Tables[0].Rows[0]["CanAdd"].ToString();
                CanMod = ds.Tables[0].Rows[0]["CanMod"].ToString();
                CanDel = ds.Tables[0].Rows[0]["CanDel"].ToString();
                CanView = ds.Tables[0].Rows[0]["CanView"].ToString();
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ERPFileList ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

