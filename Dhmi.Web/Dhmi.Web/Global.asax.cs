using System;
using System.Diagnostics;
using System.IO;
using System.Web;
using System.Web.Security;

namespace Dhmi.Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Response.Cookies.Clear();
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session.Timeout = 15;
            if (Request.IsSecureConnection == true)
                Response.Cookies["ASP.NET_SessionID"].Secure = true;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception excp = Server.GetLastError().GetBaseException();

            Server.ClearError();
            Server.Transfer("/Hata.aspx?msg=" + excp.Message.Replace(@"\r", @"<br/>") + "&trace=" + excp.StackTrace.Replace(@"\r", @"<br/>"));
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Session["menu_sec"] = null;
            Session["kullanici_var_mi"] = null;
            Session["kullanici_rastgele"] = null;
            Session["vat_id"] = null;
            Session["rapor_adi"] = null;
            Session["bildirim_iceri"] = null;
            Session["saat"] = null;
            Response.Cookies.Clear();
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Session["menu_sec"] = null;
            Session["kullanici_var_mi"] = null;
            Session["kullanici_rastgele"] = null;
            Session["vat_id"] = null;
            Session["rapor_adi"] = null;
            Session["bildirim_iceri"] = null;
            Session["saat"] = null;
            Response.Cookies.Clear();
            Session.Abandon();
        }

        protected void Application_PreSendRequestHeaders()
        {
            if (HttpContext.Current != null)
            {
                HttpContext.Current.Response.Headers.Remove("Server");
            }
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            if (Response.Cookies.Count > 0)
            {
                foreach (string s in Response.Cookies.AllKeys)
                {
                    if (s == FormsAuthentication.FormsCookieName || "asp.net_sessionid".Equals(s, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Response.Cookies[s].Secure = true;
                    }
                }
            }
        }
    }
}