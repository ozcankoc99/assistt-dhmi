using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dhmi.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.HelperClasses;

namespace Dhmi.Web
{
    public partial class McCallCenterAvayaAsLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
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

                string gelen_ad = Request.Url.ToString();
                //gelen_ad = "http://www.alo.dhmi.gov.tr/McCallCenterAvayaAsLogin.aspx?agentid=300100&tel=05303283710";
                string sorgula = gelen_ad;
                gelen_ad = gelen_ad.Substring(65, gelen_ad.Length - 65);

                int sirasi_al = 0;

                for (int i = 0; i < gelen_ad.Length; i++)
                {
                    if (gelen_ad[i].ToString() == "&")
                    {
                        sirasi_al = i;
                        i = gelen_ad.Length;
                    }
                }

                string avaya = gelen_ad.Substring(0, sirasi_al);
                string telefon = sorgula.Substring(65 + sirasi_al + 5, sorgula.Length - 65 - sirasi_al - 5); ;

                KullaniciCollection CollKul = new KullaniciCollection();
                IPredicateExpression ExpKul = new PredicateExpression();
                ExpKul.AddWithAnd(KullaniciFields.AvayaLoginId == avaya);
                CollKul.GetMulti(ExpKul);

                if (CollKul.Count > 0)
                {
                    VatandaCollection CollVat = new VatandaCollection();
                    IPredicateExpression ExpVat = new PredicateExpression();
                    ExpVat.AddWithAnd(VatandaFields.VatandasTel1 == telefon);
                    CollVat.GetMulti(ExpVat);

                    Session["vat_id"] = null;
                    Session["vat_gelen"] = null;

                    if (CollVat.Count > 0)
                    {
                        Session["vat_id"] = CollVat[0].VatandasId.ToString();
                        Session["vat_gelen"] = null;
                    }

                    else
                    {
                        Session["vat_id"] = null;
                        Session["vat_gelen"] = telefon;
                    }

                    string deger = Rastgele.RastGetir();
                    string deger2 = Rastgele.RastGetir();
                    string son_deger = "?" + deger + deger2;
                    string son_deger2 = deger + deger2;
                    deger = "CkbCagriKayitBilgileri.aspx?" + deger + deger2;

                    Session["kullanici_var_mi"] = CollKul[0].KullaniciId.ToString();
                    Session["kullanici_rastgele"] = son_deger2;

                    Response.Redirect(deger);
                }

                else
                {
                    string CloseWindow;
                    CloseWindow = "alert('Sistemde kayıtlı böyle bir kullanıcı bulunmamaktadır. DHMİ logosuna tıklayarak sisteme giriş yapabilirsiniz...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }
            }

            catch 
            {
                string CloseWindow;
                CloseWindow = "alert('Sistemde kayıtlı böyle bir kullanıcı bulunmamaktadır. DHMİ logosuna tıklayarak sisteme giriş yapabilirsiniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }            
        }
    }
}