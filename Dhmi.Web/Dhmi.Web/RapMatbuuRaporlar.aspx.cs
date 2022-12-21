using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using System.Web;

namespace Dhmi.Web
{
    public partial class RapMatbuuRaporlar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["menu_sec"] = "Raporlar";

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

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            if (IsPostBack != true)
            {

            }
        }
    }
}