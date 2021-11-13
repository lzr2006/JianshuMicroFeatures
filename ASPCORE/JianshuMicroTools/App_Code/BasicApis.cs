using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

/// <summary>
/// BasicApis 的摘要说明
/// </summary>
public class BasicApis
{
    public BasicApis()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    protected static object StaticGet(string Url)
    {
        if (Url == null)
        {
            throw new ArgumentNullException(nameof(Url));
        }

        try
        {
            HttpWebRequest req = WebRequest.CreateHttp(Url);
            req.Method = "GET";
            //req.Headers = Headers.Jianshu_request_header;
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream resStream = resp.GetResponseStream();
            StreamReader reader = new StreamReader(resStream, Encoding.UTF8);
            string result = reader.ReadToEnd();
            reader.Close();
            if (result == null)
            {
                result = "";
            }
            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"简书出现技术错误{ex.Message}。");
            return "";
        }
    }

    /// <summary>
    /// 获取用户信息。
    /// </summary>
    /// <param name="user_url">用户的Url</param>
    /// <returns>获取的用户信息。</returns>
    public static string GetUserJsonDataApi(string user_url)
    {
        string request_url = user_url.Replace
            ("https://www.jianshu.com/u/", "https://www.jianshu.com/asimov/users/slug/");
        string result = StaticGet(request_url).ToString();
        return result;
    }

    /// <summary>
    /// 获取用户在PC端的Html信息。
    /// </summary>
    /// <param name="user_url">用户的Url</param>
    /// <returns>获取的用户在PC段的Html信息。</returns>
    public static string GetUserPCHtmlDataApi(string user_url)
    {
        string request_url = user_url;
        string result = StaticGet(request_url).ToString();
        return result;
    }


}