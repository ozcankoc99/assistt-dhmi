using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dhmi.EntityClasses;

namespace Dhmi.Web
{
    public partial class SmsTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["userC"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddMinutes(15);
                cookie.Secure = true;
                //cookie.SameSite = SameSiteMode.Lax;
                cookie.HttpOnly = true;
                Response.Cookies.Add(cookie);
            }
            else
            {
                Response.Redirect("Account/Login.aspx");
            }

            string gsmNo = "5303283710";
            string smsMessage = string.Format(ConfigurationManager.AppSettings["SmsNewRecordContent"], 99999);
            Helper.SendSms(gsmNo, smsMessage, 99999);          
        }
    }
}