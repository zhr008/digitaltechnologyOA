<%@ WebHandler  Language="C#"  Class="getContent" %>
/**
 * Created by visual studio 2010
 * User: xuheng
 * Date: 12-3-6
 * Time: ����21:23
 * To get the value of editor and output the value .
 */
using System;
using System.Web;

public class getContent : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";

        //��ȡ����
        string content = context.Server.HtmlEncode(context.Request.Form["myEditor"]);
        string content1 = context.Server.HtmlEncode(context.Request.Form["myEditor1"]);
        
        //�������ݿ������������
        //-------------

        //��ʾ
        context.Response.Write("<script src='../uparse.js' type='text/javascript'></script>");
        context.Response.Write(
            "<script>uParse('.content',{"+
                  "'highlightJsUrl':'../third-party/SyntaxHighlighter/shCore.js',"+
                  "'highlightCssUrl':'../third-party/SyntaxHighlighter/shCoreDefault.css'"+
              "})"+
            "</script>");

        context.Response.Write("��1���༭����ֵ");
        context.Response.Write("<div class='content'>" + context.Server.HtmlDecode(content) + "</div>");
        context.Response.Write("<br/>��2���༭����ֵ<br/>");
        context.Response.Write("<textarea class='content' style='width:500px;height:300px;'>"+context.Server.HtmlDecode(content1)+"</textarea><br/>");
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}