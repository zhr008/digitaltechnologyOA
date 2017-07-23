using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 类ERPTiKuShiJuan。
    /// </summary>
    public class ERPTiKuShiJuan
    {
        public ERPTiKuShiJuan()
        { }
        #region Model
        private int _id;
        private string _shijuantitle;
        private string _ifsuijichuti;
        private string _fenleishunxu;
        private int? _kaoshixianshi;
        private string _panduantilist;
        private string _danxuantilist;
        private string _duoxuantilist;
        private string _tiankongtilist;
        private string _jiandatilist;
        private decimal? _panduanfenshu;
        private decimal? _danxuanfenshu;
        private decimal? _duoxuanfenshu;
        private decimal? _tiankongfenshu;
        private decimal? _jiandafenshu;
        private string _backinfo;
        private string _username;
        private DateTime? _timestr;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 试卷标题
        /// </summary>
        public string ShiJuanTitle
        {
            set { _shijuantitle = value; }
            get { return _shijuantitle; }
        }
        /// <summary>
        /// 是否随机出题
        /// </summary>
        public string IFSuiJiChuTi
        {
            set { _ifsuijichuti = value; }
            get { return _ifsuijichuti; }
        }
        /// <summary>
        /// 题目显示顺序
        /// </summary>
        public string FenLeiShunXu
        {
            set { _fenleishunxu = value; }
            get { return _fenleishunxu; }
        }
        /// <summary>
        /// 考试限时（分）
        /// </summary>
        public int? KaoShiXianShi
        {
            set { _kaoshixianshi = value; }
            get { return _kaoshixianshi; }
        }
        /// <summary>
        /// 判断题
        /// </summary>
        public string PanDuanTiList
        {
            set { _panduantilist = value; }
            get { return _panduantilist; }
        }
        /// <summary>
        /// 单选题
        /// </summary>
        public string DanXuanTiList
        {
            set { _danxuantilist = value; }
            get { return _danxuantilist; }
        }
        /// <summary>
        /// 多选题
        /// </summary>
        public string DuoXuanTiList
        {
            set { _duoxuantilist = value; }
            get { return _duoxuantilist; }
        }
        /// <summary>
        /// 填空题
        /// </summary>
        public string TianKongTiList
        {
            set { _tiankongtilist = value; }
            get { return _tiankongtilist; }
        }
        /// <summary>
        /// 简答题
        /// </summary>
        public string JianDaTiList
        {
            set { _jiandatilist = value; }
            get { return _jiandatilist; }
        }
        /// <summary>
        /// 判断题每题分数
        /// </summary>
        public decimal? PanDuanFenShu
        {
            set { _panduanfenshu = value; }
            get { return _panduanfenshu; }
        }
        /// <summary>
        /// 单选题每题分数
        /// </summary>
        public decimal? DanXuanFenShu
        {
            set { _danxuanfenshu = value; }
            get { return _danxuanfenshu; }
        }
        /// <summary>
        /// 多选题每题分数
        /// </summary>
        public decimal? DuoXuanFenShu
        {
            set { _duoxuanfenshu = value; }
            get { return _duoxuanfenshu; }
        }
        /// <summary>
        /// 填空题每题分数
        /// </summary>
        public decimal? TianKongFenShu
        {
            set { _tiankongfenshu = value; }
            get { return _tiankongfenshu; }
        }
        /// <summary>
        /// 简答题每题分数
        /// </summary>
        public decimal? JianDaFenShu
        {
            set { _jiandafenshu = value; }
            get { return _jiandafenshu; }
        }
        /// <summary>
        /// 备注说明
        /// </summary>
        public string BackInfo
        {
            set { _backinfo = value; }
            get { return _backinfo; }
        }
        /// <summary>
        /// 录入人
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 录入时间
        /// </summary>
        public DateTime? TimeStr
        {
            set { _timestr = value; }
            get { return _timestr; }
        }
        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPTiKuShiJuan(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,ShiJuanTitle,IFSuiJiChuTi,FenLeiShunXu,KaoShiXianShi,PanDuanTiList,DanXuanTiList,DuoXuanTiList,TianKongTiList,JianDaTiList,PanDuanFenShu,DanXuanFenShu,DuoXuanFenShu,TianKongFenShu,JianDaFenShu,BackInfo,UserName,TimeStr ");
            strSql.Append(" FROM ERPTiKuShiJuan ");
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
                ShiJuanTitle = ds.Tables[0].Rows[0]["ShiJuanTitle"].ToString();
                IFSuiJiChuTi = ds.Tables[0].Rows[0]["IFSuiJiChuTi"].ToString();
                FenLeiShunXu = ds.Tables[0].Rows[0]["FenLeiShunXu"].ToString();
                if (ds.Tables[0].Rows[0]["KaoShiXianShi"].ToString() != "")
                {
                    KaoShiXianShi = int.Parse(ds.Tables[0].Rows[0]["KaoShiXianShi"].ToString());
                }
                PanDuanTiList = ds.Tables[0].Rows[0]["PanDuanTiList"].ToString();
                DanXuanTiList = ds.Tables[0].Rows[0]["DanXuanTiList"].ToString();
                DuoXuanTiList = ds.Tables[0].Rows[0]["DuoXuanTiList"].ToString();
                TianKongTiList = ds.Tables[0].Rows[0]["TianKongTiList"].ToString();
                JianDaTiList = ds.Tables[0].Rows[0]["JianDaTiList"].ToString();
                if (ds.Tables[0].Rows[0]["PanDuanFenShu"].ToString() != "")
                {
                    PanDuanFenShu = decimal.Parse(ds.Tables[0].Rows[0]["PanDuanFenShu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DanXuanFenShu"].ToString() != "")
                {
                    DanXuanFenShu = decimal.Parse(ds.Tables[0].Rows[0]["DanXuanFenShu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DuoXuanFenShu"].ToString() != "")
                {
                    DuoXuanFenShu = decimal.Parse(ds.Tables[0].Rows[0]["DuoXuanFenShu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TianKongFenShu"].ToString() != "")
                {
                    TianKongFenShu = decimal.Parse(ds.Tables[0].Rows[0]["TianKongFenShu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["JianDaFenShu"].ToString() != "")
                {
                    JianDaFenShu = decimal.Parse(ds.Tables[0].Rows[0]["JianDaFenShu"].ToString());
                }
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPTiKuShiJuan");
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
            strSql.Append("insert into ERPTiKuShiJuan(");
            strSql.Append("ShiJuanTitle,IFSuiJiChuTi,FenLeiShunXu,KaoShiXianShi,PanDuanTiList,DanXuanTiList,DuoXuanTiList,TianKongTiList,JianDaTiList,PanDuanFenShu,DanXuanFenShu,DuoXuanFenShu,TianKongFenShu,JianDaFenShu,BackInfo,UserName,TimeStr)");
            strSql.Append(" values (");
            strSql.Append("@ShiJuanTitle,@IFSuiJiChuTi,@FenLeiShunXu,@KaoShiXianShi,@PanDuanTiList,@DanXuanTiList,@DuoXuanTiList,@TianKongTiList,@JianDaTiList,@PanDuanFenShu,@DanXuanFenShu,@DuoXuanFenShu,@TianKongFenShu,@JianDaFenShu,@BackInfo,@UserName,@TimeStr)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ShiJuanTitle", SqlDbType.VarChar,100),
					new SqlParameter("@IFSuiJiChuTi", SqlDbType.VarChar,50),
					new SqlParameter("@FenLeiShunXu", SqlDbType.VarChar,200),
					new SqlParameter("@KaoShiXianShi", SqlDbType.Int,4),
					new SqlParameter("@PanDuanTiList", SqlDbType.VarChar,2000),
					new SqlParameter("@DanXuanTiList", SqlDbType.VarChar,2000),
					new SqlParameter("@DuoXuanTiList", SqlDbType.VarChar,2000),
					new SqlParameter("@TianKongTiList", SqlDbType.VarChar,2000),
					new SqlParameter("@JianDaTiList", SqlDbType.VarChar,2000),
					new SqlParameter("@PanDuanFenShu", SqlDbType.Decimal,9),
					new SqlParameter("@DanXuanFenShu", SqlDbType.Decimal,9),
					new SqlParameter("@DuoXuanFenShu", SqlDbType.Decimal,9),
					new SqlParameter("@TianKongFenShu", SqlDbType.Decimal,9),
					new SqlParameter("@JianDaFenShu", SqlDbType.Decimal,9),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = ShiJuanTitle;
            parameters[1].Value = IFSuiJiChuTi;
            parameters[2].Value = FenLeiShunXu;
            parameters[3].Value = KaoShiXianShi;
            parameters[4].Value = PanDuanTiList;
            parameters[5].Value = DanXuanTiList;
            parameters[6].Value = DuoXuanTiList;
            parameters[7].Value = TianKongTiList;
            parameters[8].Value = JianDaTiList;
            parameters[9].Value = PanDuanFenShu;
            parameters[10].Value = DanXuanFenShu;
            parameters[11].Value = DuoXuanFenShu;
            parameters[12].Value = TianKongFenShu;
            parameters[13].Value = JianDaFenShu;
            parameters[14].Value = BackInfo;
            parameters[15].Value = UserName;
            parameters[16].Value = TimeStr;

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
            strSql.Append("update ERPTiKuShiJuan set ");
            strSql.Append("ShiJuanTitle=@ShiJuanTitle,");
            strSql.Append("IFSuiJiChuTi=@IFSuiJiChuTi,");
            strSql.Append("FenLeiShunXu=@FenLeiShunXu,");
            strSql.Append("KaoShiXianShi=@KaoShiXianShi,");            
            strSql.Append("PanDuanFenShu=@PanDuanFenShu,");
            strSql.Append("DanXuanFenShu=@DanXuanFenShu,");
            strSql.Append("DuoXuanFenShu=@DuoXuanFenShu,");
            strSql.Append("TianKongFenShu=@TianKongFenShu,");
            strSql.Append("JianDaFenShu=@JianDaFenShu,");
            strSql.Append("BackInfo=@BackInfo,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TimeStr=@TimeStr");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@ShiJuanTitle", SqlDbType.VarChar,100),
					new SqlParameter("@IFSuiJiChuTi", SqlDbType.VarChar,50),
					new SqlParameter("@FenLeiShunXu", SqlDbType.VarChar,200),
					new SqlParameter("@KaoShiXianShi", SqlDbType.Int,4),					
					new SqlParameter("@PanDuanFenShu", SqlDbType.Decimal,9),
					new SqlParameter("@DanXuanFenShu", SqlDbType.Decimal,9),
					new SqlParameter("@DuoXuanFenShu", SqlDbType.Decimal,9),
					new SqlParameter("@TianKongFenShu", SqlDbType.Decimal,9),
					new SqlParameter("@JianDaFenShu", SqlDbType.Decimal,9),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,500),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime)};
            parameters[0].Value = ID;
            parameters[1].Value = ShiJuanTitle;
            parameters[2].Value = IFSuiJiChuTi;
            parameters[3].Value = FenLeiShunXu;
            parameters[4].Value = KaoShiXianShi;            
            parameters[5].Value = PanDuanFenShu;
            parameters[6].Value = DanXuanFenShu;
            parameters[7].Value = DuoXuanFenShu;
            parameters[8].Value = TianKongFenShu;
            parameters[9].Value = JianDaFenShu;
            parameters[10].Value = BackInfo;
            parameters[11].Value = UserName;
            parameters[12].Value = TimeStr;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPTiKuShiJuan ");
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
            strSql.Append("select  top 1 ID,ShiJuanTitle,IFSuiJiChuTi,FenLeiShunXu,KaoShiXianShi,PanDuanTiList,DanXuanTiList,DuoXuanTiList,TianKongTiList,JianDaTiList,PanDuanFenShu,DanXuanFenShu,DuoXuanFenShu,TianKongFenShu,JianDaFenShu,BackInfo,UserName,TimeStr ");
            strSql.Append(" FROM ERPTiKuShiJuan ");
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
                ShiJuanTitle = ds.Tables[0].Rows[0]["ShiJuanTitle"].ToString();
                IFSuiJiChuTi = ds.Tables[0].Rows[0]["IFSuiJiChuTi"].ToString();
                FenLeiShunXu = ds.Tables[0].Rows[0]["FenLeiShunXu"].ToString();
                if (ds.Tables[0].Rows[0]["KaoShiXianShi"].ToString() != "")
                {
                    KaoShiXianShi = int.Parse(ds.Tables[0].Rows[0]["KaoShiXianShi"].ToString());
                }
                PanDuanTiList = ds.Tables[0].Rows[0]["PanDuanTiList"].ToString();
                DanXuanTiList = ds.Tables[0].Rows[0]["DanXuanTiList"].ToString();
                DuoXuanTiList = ds.Tables[0].Rows[0]["DuoXuanTiList"].ToString();
                TianKongTiList = ds.Tables[0].Rows[0]["TianKongTiList"].ToString();
                JianDaTiList = ds.Tables[0].Rows[0]["JianDaTiList"].ToString();
                if (ds.Tables[0].Rows[0]["PanDuanFenShu"].ToString() != "")
                {
                    PanDuanFenShu = decimal.Parse(ds.Tables[0].Rows[0]["PanDuanFenShu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DanXuanFenShu"].ToString() != "")
                {
                    DanXuanFenShu = decimal.Parse(ds.Tables[0].Rows[0]["DanXuanFenShu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DuoXuanFenShu"].ToString() != "")
                {
                    DuoXuanFenShu = decimal.Parse(ds.Tables[0].Rows[0]["DuoXuanFenShu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TianKongFenShu"].ToString() != "")
                {
                    TianKongFenShu = decimal.Parse(ds.Tables[0].Rows[0]["TianKongFenShu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["JianDaFenShu"].ToString() != "")
                {
                    JianDaFenShu = decimal.Parse(ds.Tables[0].Rows[0]["JianDaFenShu"].ToString());
                }
                BackInfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
                UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    TimeStr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ERPTiKuShiJuan ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

