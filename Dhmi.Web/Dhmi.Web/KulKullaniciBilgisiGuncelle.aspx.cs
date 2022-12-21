using System;
using System.Web.UI;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using System.Web;

namespace Dhmi.Web
{
    public partial class KulKullaniciBilgisiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["menu_sec"] = "Kullanıcı İşlemleri";

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

            if (IsPostBack != true)
            {
                MenuCollection CollMenu = new MenuCollection();
                IPredicateExpression ExpMenu = new PredicateExpression();
                ExpMenu.AddWithAnd(MenuFields.MenuAd == "Kullanıcı İşlemleri");
                CollMenu.GetMulti(ExpMenu);

                AltMenuCollection CollAlt1 = new AltMenuCollection();
                IPredicateExpression ExpAlt1 = new PredicateExpression();
                ExpAlt1.AddWithAnd(AltMenuFields.AltMenuAd == "Kullanıcı Bilgileri");
                CollAlt1.GetMulti(ExpAlt1);

                AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                IPredicateExpression ExpAlt2 = new PredicateExpression();
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Kullanıcı Bilgisi Güncelle");
                CollAlt2.GetMulti(ExpAlt2);

                KullaniciCollection CollKul2 = new KullaniciCollection();
                IPredicateExpression ExpKul2 = new PredicateExpression();
                ExpKul2.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollKul2.GetMulti(ExpKul2);

                YetkiCollection CollYet = new YetkiCollection();
                IPredicateExpression ExpYet = new PredicateExpression();
                ExpYet.AddWithAnd(YetkiFields.YetkiId == CollKul2[0].FkYetkiId);
                CollYet.GetMulti(ExpYet);

                IslemCollection CollIs = new IslemCollection();
                ISortExpression sortis = new SortExpression();
                IPredicateExpression ExpIs = new PredicateExpression();
                ExpIs.AddWithAnd(IslemFields.FkMenuId == CollMenu[0].MenuId);
                ExpIs.AddWithAnd(IslemFields.FkAltMenuId == CollAlt1[0].AltMenuId);
                ExpIs.AddWithAnd(IslemFields.FkAltAltMenuId == CollAlt2[0].AltAltMenuId);
                sortis.Add(new SortClause(IslemFields.IslemSira, SortOperator.Ascending));
                CollIs.GetMulti(ExpIs, 0, sortis);

                for (int d = 0; d < CollIs.Count; d++)
                {
                    IslemOlusturCollection CollOl = new IslemOlusturCollection();
                    IPredicateExpression ExpOl = new PredicateExpression();
                    ExpOl.AddWithAnd(IslemOlusturFields.FkIslemId == CollIs[d].IslemId);
                    ExpOl.AddWithAnd(IslemOlusturFields.FkYetkiId == CollYet[0].YetkiId);
                    CollOl.GetMulti(ExpOl);

                    if (CollOl.Count > 0)
                    {
                        carTabPage.TabPages[d].Visible = true;

                        IslemCollection CollIslem = new IslemCollection();
                        IPredicateExpression ExpIslem = new PredicateExpression();
                        ExpIslem.AddWithAnd(IslemFields.IslemId == CollIs[d].IslemId);
                        CollIslem.GetMulti(ExpIslem);

                        carTabPage.TabPages[d].Text = CollIslem[0].IslemAd;
                    }

                    else
                    {
                        carTabPage.TabPages[d].Visible = false;
                    }
                }

                KullaniciCollection CollKul = new KullaniciCollection();
                IPredicateExpression ExpKul = new PredicateExpression();
                ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollKul.GetMulti(ExpKul);

                txt_ad.Text = CollKul[0].KullaniciAd.ToString();
                txt_soyad.Text = CollKul[0].KullaniciSoyad;
                txt_kullaniciadi.Text = CollKul[0].KullaniciUsername;
                txt_birim.Text = CollKul[0].KullaniciBirim;

                GorevCollection CollGor = new GorevCollection();
                IPredicateExpression ExpGor = new PredicateExpression();
                ExpGor.AddWithAnd(GorevFields.GorevId == CollKul[0].FkGorevId);
                CollGor.GetMulti(ExpGor);

                txt_gorev.Text = CollGor[0].GorevAd;

                //string sifresi = Kullanici.sifre_coz(CollKul[0].KullaniciPassword);

                //txt_sifre.Text = sifresi;
                txt_mail.Text = CollKul[0].KullaniciMail;

                GizliSoruTuruCollection CollSor = new GizliSoruTuruCollection();
                IPredicateExpression ExpSor = new PredicateExpression();
                ISortExpression sortsor = new SortExpression();
                ExpSor.AddWithAnd(GizliSoruTuruFields.GizliSoruTuruDurum == true);
                sortsor.Add(new SortClause(GizliSoruTuruFields.GizliSoruTuruAd, SortOperator.Ascending));
                CollSor.GetMulti(ExpSor, 0, sortsor);

                for (int i = 0; i < CollSor.Count; i++)
                {
                    cb_soru.Items.Add(CollSor[i].GizliSoruTuruAd);
                }

                cb_soru.Text = CollKul[0].KullaniciGizliSoru;
                txt_soru_cevap.Text = CollKul[0].KullaniciGizliSoruCevap;

                Session["kullanici_adi"] = CollKul[0].KullaniciUsername;
            }
        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            int saydi = 0;

            if (txt_sifre2.Text == "" && txt_sifre3.Text == "")
            {
                KullaniciCollection CollKul = new KullaniciCollection();
                IPredicateExpression ExpKul = new PredicateExpression();
                ExpKul.AddWithAnd(KullaniciFields.KullaniciUsername == txt_kullaniciadi.Text);
                CollKul.GetMulti(ExpKul);

                if (Session["kullanici_adi"].ToString() == txt_kullaniciadi.Text)
                {
                    if (CollKul.Count > 1)
                    {
                        saydi = 1;
                    }
                }

                if (saydi > 0)
                {
                    string CloseWindow;
                    CloseWindow = "alert('Kullanıcı adı sistemde kayıtlıdır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else
                {
                    KullaniciCollection CollKul2 = new KullaniciCollection();
                    IPredicateExpression ExpKul2 = new PredicateExpression();
                    ExpKul2.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                    CollKul2.GetMulti(ExpKul2);

                    CollKul2[0].KullaniciAd = txt_ad.Text;
                    CollKul2[0].KullaniciSoyad = txt_soyad.Text.ToUpper();
                    CollKul2[0].KullaniciUsername = txt_kullaniciadi.Text;
                    CollKul2[0].KullaniciMail = txt_mail.Text;

                    CollKul2[0].KullaniciGizliSoru = cb_soru.Text;
                    CollKul2[0].KullaniciGizliSoruCevap = txt_soru_cevap.Text;

                    CollKul2[0].Save();

                    string CloseWindow2;
                    CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                    KullaniciCollection CollKul3 = new KullaniciCollection();
                    IPredicateExpression ExpKul3 = new PredicateExpression();
                    ExpKul3.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                    CollKul3.GetMulti(ExpKul3);

                    txt_ad.Text = CollKul3[0].KullaniciAd.ToString();
                    txt_soyad.Text = CollKul3[0].KullaniciSoyad;
                    txt_kullaniciadi.Text = CollKul3[0].KullaniciUsername;

                    string getir = Kullanici.sifre_coz(CollKul3[0].KullaniciPassword);

                    txt_sifre.Text = getir;
                    txt_mail.Text = CollKul3[0].KullaniciMail;

                    Session["kullanici_adi"] = CollKul3[0].KullaniciUsername;
                }
            }

            else if (txt_sifre2.Text != "" && txt_sifre3.Text != "")
            {
                if (txt_sifre2.Text == txt_sifre3.Text)
                {
                    KullaniciCollection CollKul = new KullaniciCollection();
                    IPredicateExpression ExpKul = new PredicateExpression();
                    ExpKul.AddWithAnd(KullaniciFields.KullaniciUsername == txt_kullaniciadi.Text);
                    CollKul.GetMulti(ExpKul);

                    if (Session["kullanici_adi"].ToString() == txt_kullaniciadi.Text)
                    {
                        if (CollKul.Count > 1)
                        {
                            saydi = 1;
                        }
                    }

                    if (saydi > 0)
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Kullanıcı adı sistemde kayıtlıdır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                    }
                    else
                    {
                        if (!Helper.HasAnyCapital(txt_sifre2.Text) || !Helper.HasEnoughChar(txt_sifre2.Text) || !Helper.HasAnyNumber(txt_sifre2.Text) || !Helper.HasAnySpecialChar(txt_sifre2.Text))
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Kullanıcı şifresi 6 ile 9 karakter aralığında olmalı, özel karakter içermeli, Büyük-Küçük harf içermeli ve Rakam içermelidir...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                        }

                        else
                        {
                            KullaniciCollection CollKul2 = new KullaniciCollection();
                            IPredicateExpression ExpKul2 = new PredicateExpression();
                            ExpKul2.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                            CollKul2.GetMulti(ExpKul2);

                            CollKul2[0].KullaniciAd = txt_ad.Text;
                            CollKul2[0].KullaniciSoyad = txt_soyad.Text.ToUpper();
                            CollKul2[0].KullaniciUsername = txt_kullaniciadi.Text;
                            CollKul2[0].KullaniciMail = txt_mail.Text;

                            string olustur = Kullanici.sifre_olustur(txt_sifre3.Text);

                            CollKul2[0].KullaniciPassword = olustur;

                            CollKul2[0].KullaniciGizliSoru = cb_soru.Text;
                            CollKul2[0].KullaniciGizliSoruCevap = txt_soru_cevap.Text;

                            CollKul2[0].Save();

                            string CloseWindow2;
                            CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                            Session["kullanici_rastgele"] = null;
                            Response.Cookies.Clear();
                            Response.Redirect("Account/Login.aspx");
                        }
                    }
                }

                else
                {
                    string CloseWindow;
                    CloseWindow = "alert('Yeni Şifre bilgileri tutarsızdır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }
            }

            else if (txt_sifre2.Text == "" && txt_sifre3.Text != "")
            {
                string CloseWindow;
                CloseWindow = "alert('Yeni Şifre bilgileri tutarsızdır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else if (txt_sifre2.Text != "" && txt_sifre3.Text == "")
            {
                string CloseWindow;
                CloseWindow = "alert('Yeni Şifre bilgileri tutarsızdır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }
    }
}