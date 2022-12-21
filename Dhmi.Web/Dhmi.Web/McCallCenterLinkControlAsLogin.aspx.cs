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
    public partial class McCallCenterLinkControlAsLogin : System.Web.UI.Page
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
                //gelen_ad = "http://www.alo.dhmi.gov.tr/McCallCenterLinkControlAsLogin.aspx?7x48z23p211L45L691W70L400W680G680p70G387d69p13L387p33";
                string sorgula = gelen_ad;
                gelen_ad = gelen_ad.Substring(75, gelen_ad.Length - 75);

                int sirasi_al = 0;

                for (int i = 0; i < gelen_ad.Length; i++)
                {
                    if (gelen_ad[i].ToString() == "7" && gelen_ad[i + 1].ToString() == "0")
                    {
                        sirasi_al = i;
                        i = gelen_ad.Length;
                    }
                }

                string coz = gelen_ad.Substring(0, sirasi_al);
                coz = Kullanici.sifre_coz(coz);

                KullaniciCollection CollKul = new KullaniciCollection();
                IPredicateExpression ExpKul = new PredicateExpression();
                ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(coz));
                CollKul.GetMulti(ExpKul);

                if (CollKul.Count > 0)
                {
                    sorgula = sorgula.Substring(7, sorgula.Length - 7);

                    MailBankCollection CollBank = new MailBankCollection();
                    IPredicateExpression ExpBank = new PredicateExpression();
                    ExpBank.AddWithAnd(MailBankFields.MailBanksLink == sorgula);
                    CollBank.GetMulti(ExpBank);

                    if (CollBank.Count > 0)
                    {
                        ParametreCollection CollPar = new ParametreCollection();
                        IPredicateExpression ExpPar = new PredicateExpression();
                        ExpPar.AddWithAnd(ParametreFields.ParametreAd == "Link Kullanım Sayısı");
                        CollPar.GetMulti(ExpPar);

                        CollBank[0].MailBanksTikAdet = Convert.ToInt16(CollBank[0].MailBanksTikAdet + 1);
                        CollBank[0].Save();

                        if (Convert.ToInt16(CollPar[0].ParametreDeger) < CollBank[0].MailBanksTikAdet)
                        {
                            CollBank[0].MailBanksDurum = false;
                            CollBank[0].Save();
                        }

                        if (CollBank[0].MailBanksDurum == true)
                        {
                            string deger = Rastgele.RastGetir();
                            string deger2 = Rastgele.RastGetir();
                            string son_deger = "?" + deger + deger2;
                            string son_deger2 = deger + deger2;
                            deger = "AtnAtananBildirimBilgileri.aspx?" + deger + deger2;

                            Session["kullanici_var_mi"] = coz;
                            Session["kullanici_rastgele"] = son_deger2;

                            Response.Redirect(deger);
                        }

                        else
                        {
                            if (CollBank[0].MailBanksTikAdet > Convert.ToInt16(CollPar[0].ParametreDeger))
                            {
                                string CloseWindow;
                                CloseWindow = "alert('Link kullanım sayısı limitini doldurmuştur. DHMİ logosuna tıklayarak sisteme giriş yapabilirsiniz...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                            }

                            else
                            {
                                string CloseWindow;
                                CloseWindow = "alert('Link kullanım süresi doldurmuştur. DHMİ logosuna tıklayarak sisteme giriş yapabilirsiniz...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                            }
                        }
                    }

                    else
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Sistemde kayıtlı böyle bir kullanıcı linki bulunmamaktadır. DHMİ logosuna tıklayarak sisteme giriş yapabilirsiniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                    }
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