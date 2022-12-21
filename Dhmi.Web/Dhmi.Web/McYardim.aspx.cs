using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dhmi.Web
{
    public partial class McYardim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["menu_sec"] = "Yardım";

            if ((Session["kullanici_var_mi"] == null) || (Session["kullanici_rastgele"] == null))
            {
                Response.Redirect("Account/Login.aspx");
            }

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
        }
    }
}