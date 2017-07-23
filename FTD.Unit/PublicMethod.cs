using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Xml;
using System.Text;
using FTD.DBUnit;

namespace FTD.Unit
{
    /// <summary>
    /// PublicMethod 的摘要说明
    /// </summary>
    public class PublicMethod
    {

        public PublicMethod()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        /// <summary>
        /// 将树形菜单的各个节点对应的权限加载进入指定的CheckBoxList中
        /// </summary>
        /// <param name="MYCHK"></param>
        public static void AddItmesInCheCKList(CheckBoxList MYCHK)
        {
            DataSet MYDT = FTD.DBUnit.DbHelperSQL.GetDataSet("select * from ERPTreeList where NavigateUrlStr!='' and NavigateUrlStr is not null order by PaiXuStr asc,ParentID asc,ID asc");
            for (int i = 0; i < MYDT.Tables[0].Rows.Count; i++)
            {
                string[] CheckItems = new string[8] { "", "", "", "", "", "", "", "" };
                CheckItems[0] = MYDT.Tables[0].Rows[i]["ValueStr"].ToString() + "_" + FTD.DBUnit.DbHelperSQL.GetSHSL("select top 1 TextStr from ERPTreeList where ID=" + MYDT.Tables[0].Rows[i]["ParentID"].ToString()) + "--" + MYDT.Tables[0].Rows[i]["TextStr"].ToString() + "--查看";

                string[] QuanXianList = MYDT.Tables[0].Rows[i]["QuanXianList"].ToString().Split('|');
                for (int j = 0; j < QuanXianList.Length; j++)
                {
                    CheckItems[j + 1] = QuanXianList[j];
                }

                //将前面设置好的CheckItems数组加入到CheckBoxList中
                for (int k = 0; k < CheckItems.Length; k++)
                {
                    if (CheckItems[k].Trim().Length <= 0)
                    {
                        ListItem ItemsTemp = new ListItem("", "");
                        MYCHK.Items.Add(ItemsTemp);
                    }
                    else
                    {
                        if (k == 0)
                        {
                            ListItem ItemsTemp = new ListItem(CheckItems[k].Split('_')[1], CheckItems[k].Split('_')[0]);
                            MYCHK.Items.Add(ItemsTemp);
                        }
                        else
                        {
                            ListItem ItemsTemp = new ListItem(CheckItems[k].Split('_')[1], MYDT.Tables[0].Rows[i]["ValueStr"].ToString() + CheckItems[k].Split('_')[0]);
                            MYCHK.Items.Add(ItemsTemp);
                        }
                    }
                }
            }

        }
        /// <summary>
        /// 将传入的用户名列表，按照工作委托的要求，自动置换成受委托后的用户名字符串，然后返回
        /// </summary>
        /// <param name="UserList"></param>
        /// <returns></returns>
        public static string WorkWeiTuoUserList(string UserList)
        {
            string ReturnList = "";
            string[] UserArray = UserList.Split(',');
            for (int i = 0; i < UserArray.Length; i++)
            {
                if (UserArray[i].ToString().Trim().Length > 0)
                {
                    string WeiTuoUser = FTD.DBUnit.DbHelperSQL.GetSHSL("select top 1 ToUser from ERPNWorkFlowWT where FromUser='" + UserArray[i].ToString() + "'");
                    if (WeiTuoUser.Trim().Length > 0)
                    {
                        if (ReturnList.Trim().Length > 0)
                        {
                            if (StrIFIn("," + WeiTuoUser + ",", "," + ReturnList + ",") == false)
                            {
                                ReturnList = ReturnList + "," + WeiTuoUser;
                            }
                        }
                        else
                        {
                            ReturnList = WeiTuoUser;
                        }
                    }
                    else
                    {
                        if (ReturnList.Trim().Length > 0)
                        {
                            if (StrIFIn("," + UserArray[i].ToString() + ",", "," + ReturnList + ",") == false)
                            {
                                ReturnList = ReturnList + "," + UserArray[i].ToString();
                            }
                        }
                        else
                        {
                            ReturnList = UserArray[i].ToString();
                        }
                    }
                }
            }
            return ReturnList;
        }
        //修改web.config节点的值
        public static void EditAppValue(string KeyNameStr, string SetValueStr)
        {
            //修改web.config
            XmlDocument xDoc = new XmlDocument();
            try
            {
                //打开web.config
                xDoc.Load(System.Web.HttpContext.Current.Request.MapPath("../Web.config"));
                //string key;
                XmlNode app;
                app = xDoc.SelectSingleNode("/configuration/appSettings/add[@key='" + KeyNameStr + "']");
                app.Attributes["value"].Value = SetValueStr;
                //关闭
                xDoc.Save(System.Web.HttpContext.Current.Request.MapPath("../web.config"));
                System.Web.HttpContext.Current.Response.Write("<script>alert('配置数据修改完成！');</script>");
            }
            catch (Exception ex)
            {
                System.Web.HttpContext.Current.Response.Write("<script>alert('" + ex.Message.ToString() + "');</script>");
            }
            finally
            {
                xDoc = null;
            }
        }

        //得到文件列表--真实文件名
        public static string GetWenJian(string WenJianList, string DirStr)
        {
            if (!string.IsNullOrEmpty(WenJianList))
            {
                string[] MyRange = WenJianList.Split('|');
                string MyReturn = string.Empty;
                for (int i = 0; i < MyRange.Length; i++)
                {
                    if (MyRange[i].ToString().Trim().Length > 0)
                    {
                        if (MyReturn.Trim().Length > 0)
                        {
                            if (MyRange[i].ToString().IndexOf("MailAttachments/") >= 0)
                            {
                                MyReturn = MyReturn + "&nbsp;&nbsp;&nbsp;&nbsp;<img src=../../images/ico_clip.gif /><a target=\"_blank\" href='" + DirStr + MyRange[i].ToString() + "'>" + MyRange[i].ToString().Replace("MailAttachments/", "") + "</a>";
                            }
                            else
                            {
                                string OldNameStr = FTD.DBUnit.DbHelperSQL.GetSHSL("select OldName from ERPSaveFileName where NowName='" + MyRange[i].ToString().Replace("MailAttachments/", "") + "'");
                                if (OldNameStr.Trim().Length <= 0)
                                {
                                    OldNameStr = MyRange[i].ToString().Replace("MailAttachments/", "");
                                }
                                MyReturn = MyReturn + "&nbsp;&nbsp;&nbsp;&nbsp;<img src=../../images/ico_clip.gif /><a href=\"javascript:DownloadFile('" + DirStr + MyRange[i].ToString() + "')\" >" + OldNameStr + "</a>&nbsp;<a href='../DsoFramer/ReadFile.aspx?FilePath=" + MyRange[i].ToString() + "' target='_blank'><img border=0 src=../../images/Button/ReadFile.gif /></a>";
                            }
                        }
                        else
                        {
                            if (MyRange[i].ToString().IndexOf("MailAttachments/") >= 0)
                            {
                                MyReturn = "<img src=../../images/ico_clip.gif /><a target=\"_blank\" href='" + DirStr + MyRange[i].ToString() + "'>" + MyRange[i].ToString().Replace("MailAttachments/", "") + "</a>";
                            }
                            else
                            {
                                string OldNameStr = FTD.DBUnit.DbHelperSQL.GetSHSL("select OldName from ERPSaveFileName where NowName='" + MyRange[i].ToString().Replace("MailAttachments/", "") + "'");
                                if (OldNameStr.Trim().Length <= 0)
                                {
                                    OldNameStr = MyRange[i].ToString().Replace("MailAttachments/", "");
                                }
                                MyReturn = "<img src=../../images/ico_clip.gif /><a href=\"javascript:DownloadFile('" + DirStr + MyRange[i].ToString() + "')\" >" + OldNameStr + "</a>&nbsp;<a href='../DsoFramer/ReadFile.aspx?FilePath=" + MyRange[i].ToString() + "' target='_blank'><img border=0 src=../../images/Button/ReadFile.gif /></a>";
                            }
                        }
                    }
                }
                if (MyReturn.ToString().Trim().Length <= 0)
                {
                    MyReturn = MyReturn + "无文件！";
                }
                return MyReturn;
            }
            return "无文件！";
        }
        //得到文件列表--32位数字串
        public static string GetWenJian111(string WenJianList, string DirStr)
        {
            if (!string.IsNullOrEmpty(WenJianList))
            {
                string[] MyRange = WenJianList.Split('|');
                string MyReturn = string.Empty;
                for (int i = 0; i < MyRange.Length; i++)
                {
                    if (MyRange[i].ToString().Trim().Length > 0)
                    {
                        if (MyReturn.Trim().Length > 0)
                        {
                            if (MyRange[i].ToString().IndexOf("MailAttachments/") >= 0)
                            {
                                MyReturn = MyReturn + "&nbsp;&nbsp;&nbsp;&nbsp;<img src=../../images/ico_clip.gif /><a target=\"_blank\" href='" + DirStr + MyRange[i].ToString() + "'>" + MyRange[i].ToString().Replace("MailAttachments/", "") + "</a>";
                            }
                            else
                            {
                                string OldNameStr = FTD.DBUnit.DbHelperSQL.GetSHSL("select OldName from ERPSaveFileName where NowName='" + MyRange[i].ToString().Replace("MailAttachments/", "") + "'");
                                if (OldNameStr.Trim().Length <= 0)
                                {
                                    OldNameStr = MyRange[i].ToString().Replace("MailAttachments/", "");
                                }
                                MyReturn = MyReturn + "&nbsp;&nbsp;&nbsp;&nbsp;<img src=../../images/ico_clip.gif /><a target=\"_blank\" href='" + DirStr + MyRange[i].ToString() + "'>" + OldNameStr + "</a>&nbsp;<a href='../DsoFramer/ReadFile.aspx?FilePath=" + MyRange[i].ToString() + "' target='_blank'><img border=0 src=../../images/Button/ReadFile.gif /></a>";
                            }
                        }
                        else
                        {
                            if (MyRange[i].ToString().IndexOf("MailAttachments/") >= 0)
                            {
                                MyReturn = "<img src=../../images/ico_clip.gif /><a target=\"_blank\" href='" + DirStr + MyRange[i].ToString() + "'>" + MyRange[i].ToString().Replace("MailAttachments/", "") + "</a>";
                            }
                            else
                            {
                                string OldNameStr = FTD.DBUnit.DbHelperSQL.GetSHSL("select OldName from ERPSaveFileName where NowName='" + MyRange[i].ToString().Replace("MailAttachments/", "") + "'");
                                if (OldNameStr.Trim().Length <= 0)
                                {
                                    OldNameStr = MyRange[i].ToString().Replace("MailAttachments/", "");
                                }
                                MyReturn = "<img src=../../images/ico_clip.gif /><a target=\"_blank\" href='" + DirStr + MyRange[i].ToString() + "'>" + OldNameStr + "</a>&nbsp;<a href='../DsoFramer/ReadFile.aspx?FilePath=" + MyRange[i].ToString() + "' target='_blank'><img border=0 src=../../images/Button/ReadFile.gif /></a>";
                            }
                        }
                    }
                }
                if (MyReturn.ToString().Trim().Length <= 0)
                {
                    MyReturn = MyReturn + "无文件！";
                }
                return MyReturn;
            }
            return "无文件！";
        }



        /// <summary>
        /// 获取文件链接，同时加上阅读、编辑
        /// </summary>
        /// <param name="WenJianList"></param>
        /// <param name="DirStr"></param>
        /// <returns></returns>
        public static string GetWenJian2(string WenJianList, string DirStr)
        {
            if (!string.IsNullOrEmpty(WenJianList))
            {
                string[] MyRange = WenJianList.Split('|');
                string MyReturn = string.Empty;
                for (int i = 0; i < MyRange.Length; i++)
                {
                    if (MyRange[i].ToString().Trim().Length > 0)
                    {
                        if (MyReturn.Trim().Length > 0)
                        {
                            if (MyRange[i].ToString().IndexOf("MailAttachments/") >= 0)
                            {
                                MyReturn = MyReturn + "&nbsp;&nbsp;&nbsp;&nbsp;<img src=../../images/ico_clip.gif /><a target=\"_blank\" href='" + DirStr + MyRange[i].ToString() + "'>" + MyRange[i].ToString().Replace("MailAttachments/", "") + "</a>";
                            }
                            else
                            {
                                string OldNameStr = FTD.DBUnit.DbHelperSQL.GetSHSL("select OldName from ERPSaveFileName where NowName='" + MyRange[i].ToString().Replace("MailAttachments/", "") + "'");
                                if (OldNameStr.Trim().Length <= 0)
                                {
                                    OldNameStr = MyRange[i].ToString().Replace("MailAttachments/", "");
                                }
                                MyReturn = MyReturn + "&nbsp;&nbsp;&nbsp;&nbsp;<img src=../../images/ico_clip.gif /><a target=\"_blank\" href='" + DirStr + MyRange[i].ToString() + "'>" + OldNameStr + "</a>&nbsp;<a href='../DsoFramer/ReadFile.aspx?FilePath=" + MyRange[i].ToString() + "' target='_blank'><img border=0 src=../../images/Button/ReadFile.gif /></a>&nbsp;<a href='../DsoFramer/EditFile.aspx?FilePath=" + MyRange[i].ToString() + "' target='_blank'><img border=0 src=../images/Button/EditFile.gif /></a>";
                            }
                        }
                        else
                        {
                            if (MyRange[i].ToString().IndexOf("MailAttachments/") >= 0)
                            {
                                MyReturn = "<img src=../../images/ico_clip.gif /><a target=\"_blank\" href='" + DirStr + MyRange[i].ToString() + "'>" + MyRange[i].ToString().Replace("MailAttachments/", "") + "</a>";
                            }
                            else
                            {
                                string OldNameStr = FTD.DBUnit.DbHelperSQL.GetSHSL("select OldName from ERPSaveFileName where NowName='" + MyRange[i].ToString().Replace("MailAttachments/", "") + "'");
                                if (OldNameStr.Trim().Length <= 0)
                                {
                                    OldNameStr = MyRange[i].ToString().Replace("MailAttachments/", "");
                                }
                                MyReturn = "<img src=../../images/ico_clip.gif /><a target=\"_blank\" href='" + DirStr + MyRange[i].ToString() + "'>" + OldNameStr + "</a>&nbsp;<a href='../DsoFramer/ReadFile.aspx?FilePath=" + MyRange[i].ToString() + "' target='_blank'><img border=0 src=../../images/Button/ReadFile.gif /></a>&nbsp;<a href='../DsoFramer/EditFile.aspx?FilePath=" + MyRange[i].ToString() + "' target='_blank'><img border=0 src=../images/Button/EditFile.gif /></a>";
                            }
                        }
                    }
                }
                if (MyReturn.ToString().Trim().Length <= 0)
                {
                    MyReturn = MyReturn + "无文件！";

                }
                return MyReturn;
            }
            return "无文件！";
        }


        //将ListItem1中的选中项加入ListItem2中，或者从ListItem2中减去选中项,CanShu1代表是添加，或者去除，CanShu2代表是全部选中项
        public static string GetListStr(ListBox List1, ListBox List2, string CanShu1, string CanShu2)
        {
            if (CanShu1 == "添加")
            {
                if (CanShu2 == "全部")
                {
                    //全部添加
                    for (int i = 0; i < List1.Items.Count; i++)
                    {
                        if (List2.Items.IndexOf(List1.Items[i]) < 0)
                        {
                            List2.Items.Add(List1.Items[i]);
                        }
                    }
                }
                else
                {
                    //部分添加
                    for (int i = 0; i < List1.Items.Count; i++)
                    {
                        if (List1.Items[i].Selected == true)
                        {
                            if (List2.Items.IndexOf(List1.Items[i]) < 0)
                            {
                                List2.Items.Add(List1.Items[i]);
                            }
                        }
                    }
                }
            }
            else
            {
                if (CanShu2 == "全部")
                {
                    //全部去除
                    List2.Items.Clear();
                }
                else
                {
                    //部分去除
                    for (int i = 0; i < List2.Items.Count; i++)
                    {
                        if (List2.Items[i].Selected == true)
                        {
                            List2.Items.Remove(List2.Items[i]);
                            i = i - 1;
                        }
                    }
                }
            }
            //返回选中项的构建字符串
            string ReturnStr = string.Empty;
            for (int j = 0; j < List2.Items.Count; j++)
            {
                if (ReturnStr.Trim().Length > 0)
                {
                    ReturnStr = ReturnStr + "," + List2.Items[j].Value.Trim();
                }
                else
                {
                    ReturnStr = List2.Items[j].Value.Trim();
                }
            }
            return ReturnStr;
        }
        //从checkBoxList里面读取选中的值
        public static string GetStringFromCheckList(CheckBoxList MyChk)
        {
            string ReturnStr = string.Empty;
            for (int i = 0; i < MyChk.Items.Count; i++)
            {
                if (MyChk.Items[i].Selected == true)
                {
                    ReturnStr = ReturnStr + "|" + MyChk.Items[i].Value.ToString() + "|";
                }
            }
            return ReturnStr;
        }
        //从checkBoxList里面读中字符串中有的值
        public static void GetCheckList(CheckBoxList MyChk, string PerStr)
        {
            for (int i = 0; i < MyChk.Items.Count; i++)
            {
                if (StrIFIn("|" + MyChk.Items[i].Value.ToString() + "|", PerStr) == true)
                {
                    MyChk.Items[i].Selected = true;
                }
                else
                {
                    MyChk.Items[i].Selected = false;
                }
            }
        }
        //绑定字符串分隔开的到CheckBoxList--获得真实文件名
        public static void BindDDL(CheckBoxList MyDDL, string FenGeStr)
        {
            MyDDL.Items.Clear();
            string[] MyRange = FenGeStr.Split('|');
            for (int i = 0; i < MyRange.Length; i++)
            {
                if (MyRange[i].ToString().Trim().Length > 0)
                {
                    //将附件显示的text改为真实文件名
                    //string OldNameStr = FTD.DBUnit.DbHelperSQL.GetSHSL("select OldName from ERPSaveFileName where NowName='" + MyRange[i].ToString().Replace("MailAttachments/", "") + "'");
                    string OldName = FTD.DBUnit.DbHelperSQL.GetSHSL("select OldName from ERPSaveFileName where NowName = '" + MyRange[i].ToString().Trim() + "'");
                    ListItem MyListItem = new ListItem();
                    //MyListItem.Text = MyRange[i].ToString().Replace("MailAttachments/", "");
                    MyListItem.Text = OldName;
                    MyListItem.Value = MyRange[i].ToString();
                    MyDDL.Items.Add(MyListItem);
                }
            }
        }
        //绑定字符串分隔开的到dropdownlist
        public static void BindDDLForEmPty(DropDownList MyDDL, string FenGeStr)
        {
            ListItem MyListItem1 = new ListItem();
            MyListItem1.Text = "";
            MyListItem1.Value = "";
            MyDDL.Items.Add(MyListItem1);
            string[] MyRange = FenGeStr.Split('|');
            for (int i = 0; i < MyRange.Length; i++)
            {
                if (MyRange[i].ToString().Trim().Length > 0)
                {
                    ListItem MyListItem = new ListItem();
                    MyListItem.Text = MyRange[i].ToString();
                    MyListItem.Value = MyRange[i].ToString();
                    MyDDL.Items.Add(MyListItem);
                }
            }
        }
        //绑定字符串分隔开的到CheckBoxList
        public static void BindDDL(DropDownList MyDDL, string FenGeStr)
        {
            MyDDL.Items.Clear();
            ListItem MyListItem1 = new ListItem();
            string[] MyRange = FenGeStr.Split('|');
            for (int i = 0; i < MyRange.Length; i++)
            {
                if (MyRange[i].ToString().Trim().Length > 0)
                {
                    ListItem MyListItem = new ListItem();
                    MyListItem.Text = MyRange[i].ToString();
                    MyListItem.Value = MyRange[i].ToString();
                    MyDDL.Items.Add(MyListItem);
                }
            }
        }
        //在RowDataBound事件时使用
        public static void GridViewRowDataBound(GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#E4F4FF'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=c;");
            }
        }
        //判断GridView里面被选中的ID
        public static string CheckCbx(GridView GVData, string CheckBoxName, string LabID)
        {
            string str = "";
            for (int i = 0; i < GVData.Rows.Count; i++)
            {
                GridViewRow row = GVData.Rows[i];
                CheckBox Chk = (CheckBox)row.FindControl(CheckBoxName);
                Label LabVis = (Label)row.FindControl(LabID);
                if (Chk.Checked == true)
                {
                    if (str == "")
                    {
                        str = LabVis.Text.ToString();
                    }
                    else
                    {
                        str = str + "," + LabVis.Text.ToString();
                    }
                }
            }
            return str;
        }
        //判断Str1是否是在Str2这个长的字符串中
        public static bool StrIFIn(string Str1, string Str2)
        {
            if (Str2.IndexOf(Str1) < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //将长字符串取前面250个，然后返回
        public static string LongToShortStr(string LongStr, int StrNum)
        {
            try
            {
                return LongStr.Substring(0, StrNum);
            }
            catch
            {
                return LongStr;
            }
        }
        //提取Html中的文字信息
        public static string StripHTML(string strHtml)
        {
            string[] aryReg = { @"<script[^>]*?>.*?</script>", @"<(\/\s*)?!?((\w+:)?\w+)(\w+(\s*=?\s*(([""'])(\\[""'tbnr]|[^\7])*?\7|\w+)|.{0})|\s)*?(\/\s*)?>", @"([\r\n])[\s]+", @"&(quot|#34);", @"&(amp|#38);", @"&(lt|#60);", @"&(gt|#62);", @"&(nbsp|#160);", @"&(iexcl|#161);", @"&(cent|#162);", @"&(pound|#163);", @"&(copy|#169);", @"&#(\d+);", @"-->", @"<!--.*\n" };
            string[] aryRep = { "", "", "", "\"", "&", "<", ">", " ", "\xa1", "\xa2", "\xa3", "\xa9", "", "\r\n", "" };
            string newReg = aryReg[0];
            string strOutput = strHtml;
            for (int i = 0; i < aryReg.Length; i++)
            {
                Regex regex = new Regex(aryReg[i], RegexOptions.IgnoreCase);
                strOutput = regex.Replace(strOutput, aryRep[i]);
            }
            strOutput.Replace("<", "");
            strOutput.Replace(">", "");
            strOutput.Replace("\r\n", "");
            return strOutput;
        }
        //判断文件是否在允许的范围内
        public static bool IfOkFile(string DirName)
        {
            bool ReturnIF = true;
            try
            {
                string FileExd = DirName.Split('.')[1].ToString();
                string JKL = FTD.DBUnit.DbHelperSQL.GetSHSL("select FileType from ERPSystemSetting where FileType like '%|" + FileExd + "|%'");
                if (JKL.Length < 1)
                {
                    ReturnIF = false;
                }
            }
            catch
            {
                ReturnIF = false;
            }
            return ReturnIF;
        }
        //上传文件
        public static string UploadFileIntoDir(FileUpload MyFile, string DirName)
        {
            if (IfOkFile(DirName) == true)
            {
                string ReturnStr = string.Empty;
                if (MyFile.FileContent.Length > 0)
                {
                    MyFile.SaveAs(System.Web.HttpContext.Current.Request.MapPath("../../UploadFile/") + DirName);


                    //将原文件名与现在文件名写入ERPSaveFileName表中
                    string NowName = DirName;
                    string OldName = MyFile.FileName;
                    string SqlTempStr = "insert into ERPSaveFileName(NowName,OldName) values ('" + NowName + "','" + OldName + "')";
                    FTD.DBUnit.DbHelperSQL.ExecuteSQL(SqlTempStr);


                    return DirName;
                }
                else
                {
                    return ReturnStr;
                }
            }
            else
            {
                if (MyFile.FileName.Length > 0)
                {
                    System.Web.HttpContext.Current.Response.Write("<script>alert('不允许上传此类型文件！');</script>");
                    return "";
                }
                else
                {
                    return "";
                }
            }
        }
        //下载文件
        public static void DownloadFile(string ServerPath, string FileUrl)
        {
            System.IO.FileInfo file = new System.IO.FileInfo(ServerPath + FileUrl);
            bool bIsExist = false;
            if (file.Exists)
            {
                bIsExist = true;
            }
            else
            {
                file = new System.IO.FileInfo(ServerPath + FileUrl.Replace("../", ""));
                if (file.Exists)
                {
                    bIsExist = true;
                }
            }
            if (bIsExist)
            {
                string fileoldname = FTD.DBUnit.DbHelperSQL.GetSHSL("select OldName from ERPSaveFileName where NowName = '" + file.Name + "'");
                System.Web.HttpContext.Current.Response.Clear();
                System.Web.HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" + System.Web.HttpUtility.UrlEncode(fileoldname, System.Text.Encoding.UTF8));
                System.Web.HttpContext.Current.Response.AddHeader("Content-Length", file.Length.ToString());
                System.Web.HttpContext.Current.Response.ContentType = "application/octet-stream";
                System.Web.HttpContext.Current.Response.Charset = "UTF-8";
                System.Web.HttpContext.Current.Response.Filter.Close();
                System.Web.HttpContext.Current.Response.WriteFile(file.FullName);
                System.Web.HttpContext.Current.Response.End();
            }
        }
        //判断Session是否有效
        public static void CheckSession()
        {
            //测试的时候注释掉
            try
            {
                if (System.Web.HttpContext.Current.Session["UserName"] == null)
                {
                    //检查Cookies
                    string adminname = GetCookie("AdminName", "DTcms"); //解密用户名
                    string adminpwd = GetCookie("AdminPwd", "DTcms");
                    if (adminname != "" && adminpwd != "")
                    {
                        string SqlSTr = "select * from ERPUser where UserName='" + adminname + "'";
                         DataRow MyDataRow = DbHelperSQL.GetDataRow(SqlSTr);
                         if (MyDataRow == null)
                         {
                             System.Web.HttpContext.Current.Response.Write("<script>alert('登录信息安全时限过期，请重新登录！');top.location='../login.aspx'</script>");
                         }
                         else
                         {
                             if (adminpwd == FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "UserPwd"))
                             {
                                 if (FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "IfLogin").Trim() == "是")
                                 {
                                     System.Web.HttpContext.Current.Session["UserID"] = FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "ID");
                                     System.Web.HttpContext.Current.Session["UserName"] = FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "UserName");
                                     System.Web.HttpContext.Current.Session["Password"] = FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "UserPwd");
                                     System.Web.HttpContext.Current.Session["JiaoSe"] = FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "JiaoSe");
                                     System.Web.HttpContext.Current.Session["Department"] = FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "Department");
                                     System.Web.HttpContext.Current.Session["TrueName"] = FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "TrueName");
                                     System.Web.HttpContext.Current.Session["ZhiWei"] = FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "ZhiWei");
                                     System.Web.HttpContext.Current.Session["QuanXian"] = FTD.DBUnit.DbHelperSQL.GetStringList("select QuanXian from ERPJiaoSe where JiaoSeName in(" + "'" + FTD.Unit.DataValidate.ValidateDataRow_S(MyDataRow, "JiaoSe").Replace(",", "','") + "'" + ")");
                                 }
                             }
                         }
                    }
                }
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Write("<script>alert('登录信息安全时限过期，请重新登录！');top.location='../login.aspx'</script>");
            }
        }
        //获得Session中的值
        public static string GetSessionValue(string SessionKey)
        {
            //测试时候使用，不掉线
            try
            {
                CheckSession();
                return System.Web.HttpContext.Current.Session[SessionKey].ToString();
            }
            catch
            {
                System.Web.HttpContext.Current.Response.Write("<script>alert('登录信息安全时限过期，请重新登录！');top.location='../login.aspx'</script>");
                return "NoLogin";                
            }
        }
        //设置Session中的值
        public static void SetSessionValue(string SessionKey, string ValueStr)
        {
            System.Web.HttpContext.Current.Session[SessionKey] = ValueStr;
        }
        //根据投票的选项和的分数，生成界面的Table
        public static string GetVoteTable(string ContentStr, string ScoreStr, string IDStr, bool IFTouGuo)
        {
            string StartStr = "<table>";
            string EndStr = "</table>";
            string MidStr = string.Empty;
            string[] ContentList = ContentStr.Split('|');
            string[] ScoreList = ScoreStr.Split('|');

            //总票数
            double TotalPiao = 0;
            for (int j = 0; j < ScoreList.Length; j++)
            {
                double MaxTouPiao = double.Parse(ScoreList[j]);
                if (MaxTouPiao > TotalPiao)
                {
                    TotalPiao = MaxTouPiao;
                }
            }
            if (TotalPiao == 0)
            {
                TotalPiao = 1;
            }

            for (int i = 0; i < ContentList.Length; i++)
            {
                double PicWidth = (double.Parse(ScoreList[i]) / TotalPiao) * 250;
                if (IFTouGuo == true)
                {
                    MidStr = MidStr + "<tr><td><img src=\"../../images/ShiWuSmall.jpg\" /></td><td>" + (i + 1).ToString() + "：" + ContentList[i] + "&nbsp;&nbsp;&nbsp;&nbsp;</td><td>得票：<img src=\"../../images/vote_bg.gif\" height=10 width=" + PicWidth.ToString() + "  />&nbsp;&nbsp;" + ScoreList[i] + "&nbsp;&nbsp;&nbsp;&nbsp;</td><td></td></tr>";
                }
                else
                {
                    MidStr = MidStr + "<tr><td><img src=\"../../images/ShiWuSmall.jpg\" /></td><td>" + (i + 1).ToString() + "：" + ContentList[i] + "&nbsp;&nbsp;&nbsp;&nbsp;</td><td>得票：<img src=\"../../images/vote_bg.gif\" height=10 width=" + PicWidth.ToString() + "  />&nbsp;&nbsp;" + ScoreList[i] + "&nbsp;&nbsp;&nbsp;&nbsp;</td><td><a href=VoteYiPiao.aspx?TouPiaoTextID=" + i.ToString() + "&ID=" + IDStr + "><img border=\"0\" src=\"../images/Button/vote.gif\" /></a></td></tr>";
                }
            }
            return StartStr + MidStr + EndStr;
        }
        //判断是否已经存在该项 列名称，表名称，去除的ID名称
        public static bool IFExists(string LieName, string TableName, int ExceptID, string TextStr)
        {
            bool ReturnIF = false;
            try
            {
                string JKL = FTD.DBUnit.DbHelperSQL.GetSHSLInt("select count(*) from " + TableName + " where " + LieName + "='" + TextStr + "' and ID !=" + ExceptID.ToString());
                if (int.Parse(JKL) < 1)
                {
                    ReturnIF = true;
                }
            }
            catch
            {
                ReturnIF = true;
            }
            return ReturnIF;
        }

        #region 读取或写入cookie
        /// <summary>
        /// 写cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <param name="strValue">值</param>
        public static void WriteCookie(string strName, string strValue)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
            if (cookie == null)
            {
                cookie = new HttpCookie(strName);
            }
            cookie.Value = UrlEncode(strValue);
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        /// <summary>
        /// 写cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <param name="strValue">值</param>
        public static void WriteCookie(string strName, string key, string strValue)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
            if (cookie == null)
            {
                cookie = new HttpCookie(strName);
            }
            cookie[key] = UrlEncode(strValue);
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        /// <summary>
        /// 写cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <param name="strValue">值</param>
        public static void WriteCookie(string strName, string key, string strValue, int expires)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
            if (cookie == null)
            {
                cookie = new HttpCookie(strName);
            }
            cookie[key] = UrlEncode(strValue);
            cookie.Expires = DateTime.Now.AddMinutes(expires);
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        /// <summary>
        /// 写cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <param name="strValue">值</param>
        /// <param name="strValue">过期时间(分钟)</param>
        public static void WriteCookie(string strName, string strValue, int expires)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[strName];
            if (cookie == null)
            {
                cookie = new HttpCookie(strName);
            }
            cookie.Value = UrlEncode(strValue);
            cookie.Expires = DateTime.Now.AddMinutes(expires);
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        /// <summary>
        /// 读cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <returns>cookie值</returns>
        public static string GetCookie(string strName)
        {
            if (HttpContext.Current.Request.Cookies != null && HttpContext.Current.Request.Cookies[strName] != null)
                return UrlDecode(HttpContext.Current.Request.Cookies[strName].Value.ToString());
            return "";
        }

        /// <summary>
        /// 读cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <returns>cookie值</returns>
        public static string GetCookie(string strName, string key)
        {
            if (HttpContext.Current.Request.Cookies != null && HttpContext.Current.Request.Cookies[strName] != null && HttpContext.Current.Request.Cookies[strName][key] != null)
                return UrlDecode(HttpContext.Current.Request.Cookies[strName][key].ToString());

            return "";
        }
        #endregion

        #region URL处理
        /// <summary>
        /// URL字符编码
        /// </summary>
        public static string UrlEncode(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            str = str.Replace("'", "");
            return HttpContext.Current.Server.UrlEncode(str);
        }

        /// <summary>
        /// URL字符解码
        /// </summary>
        public static string UrlDecode(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            return HttpContext.Current.Server.UrlDecode(str);
        }

        /// <summary>
        /// 组合URL参数
        /// </summary>
        /// <param name="_url">页面地址</param>
        /// <param name="_keys">参数名称</param>
        /// <param name="_values">参数值</param>
        /// <returns>String</returns>
        public static string CombUrlTxt(string _url, string _keys, params string[] _values)
        {
            StringBuilder urlParams = new StringBuilder();
            try
            {
                string[] keyArr = _keys.Split(new char[] { '&' });
                for (int i = 0; i < keyArr.Length; i++)
                {
                    if (!string.IsNullOrEmpty(_values[i]) && _values[i] != "0")
                    {
                        _values[i] = UrlEncode(_values[i]);
                        urlParams.Append(string.Format(keyArr[i], _values) + "&");
                    }
                }
                if (!string.IsNullOrEmpty(urlParams.ToString()) && _url.IndexOf("?") == -1)
                    urlParams.Insert(0, "?");
            }
            catch
            {
                return _url;
            }
            return _url + DelLastChar(urlParams.ToString(), "&");
        }
        #endregion

        #region 删除最后结尾的指定字符后的字符
        /// <summary>
        /// 删除最后结尾的指定字符后的字符
        /// </summary>
        public static string DelLastChar(string str, string strchar)
        {
            if (string.IsNullOrEmpty(str))
                return "";
            if (str.LastIndexOf(strchar) >= 0 && str.LastIndexOf(strchar) == str.Length - 1)
            {
                return str.Substring(0, str.LastIndexOf(strchar));
            }
            return str;
        }
        #endregion
    }
}
