using System;
using System.Web.UI;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Net;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using dhmi.EntityClasses;
using System.Web;
using System.Threading;
using System.Web.Security;

namespace Dhmi.Web
{
    public partial class Register : System.Web.UI.Page
    {
        private readonly DateTime _sessionTimeOut = DateTime.Now.AddSeconds(30);
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["register_cookie"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddSeconds(30);
                cookie.Secure = true;
                //cookie.SameSite = SameSiteMode.None;
                cookie.HttpOnly = true;
                Response.Cookies.Add(cookie);
                LoadMethod();
            }
            else
            {
                CreateRegisterCookie();
                Response.Redirect("/Account/Register.aspx");
            }
        }

        public void CreateRegisterCookie()
        {
            Response.Cookies.Clear();
            Request.Cookies.Clear();
            Session.Clear();
            HttpCookie registerCookie;
            registerCookie = new HttpCookie("register_cookie", "fjkR5jh8SLL|vNmk?&3d4F")
            {
                Expires = _sessionTimeOut,
                HttpOnly = true,
                //SameSite = SameSiteMode.Strict,
                Secure = true
            };
            Response.Cookies.Add(registerCookie);

        }

        public void LoadMethod()
        {
            if (IsPostBack != true)
            {
                Random rastgele = new Random();
                Int32 sayi = rastgele.Next(100000, 999999);
                lbl_guvenlik_no.Text = sayi.ToString();
                lbl_guvenlik_no2.Text = sayi.ToString();

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
            }
        }

        protected void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (Response.Cookies["register_cookie"] != null)
            {
                string k_adi = tbUserName.Text;
                string mail = tbEmail.Text;
                int sonuc = 0;

                sonuc = Kullanici.KullaniciGetirUnuttum(k_adi, mail);

                if (lbl_guvenlik_no.Text != tbGuvenlik.Text)
                {
                    tbGuvenlik.ErrorText = "Güvenlik kodunuz hatalı...";
                    tbGuvenlik.IsValid = false;
                }

                if (sonuc == 0)
                {
                    tbUserName.ErrorText = "Kullanıcı adınız hatalı...";
                    tbUserName.IsValid = false;
                    tbEmail.ErrorText = "Mail adresiniz hatalı...";
                    tbEmail.IsValid = false;
                }

                else if ((sonuc != 0) && (lbl_guvenlik_no.Text == tbGuvenlik.Text))
                {
                    string konu = "DHMİ İletişim Merkezi Şifre Hatırlatma İsteği";
                    Mail.MailGonder(sonuc, tbEmail.Text, konu);

                    string CloseWindow;
                    CloseWindow = "alert('Şifreniz, sistemde kayıtlı mail adresinize gönderilmiştir. Lütfen mailinizi kontrol ediniz...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                    KullaniciCollection CollKul = new KullaniciCollection();
                    IPredicateExpression ExpKul = new PredicateExpression();
                    ExpKul.AddWithAnd(KullaniciFields.KullaniciUsername == tbUserName.Text);
                    CollKul.GetMulti(ExpKul);

                    tbEmail.Text = "";
                    tbUserName.Text = "";
                    tbGuvenlik.Text = "";
                    Random rastgele = new Random();
                    Int32 sayi = rastgele.Next(100000, 999999);
                    lbl_guvenlik_no.Text = sayi.ToString();
                    Response.Cookies.Clear();
                    Request.Cookies.Clear();
                    CreateRegisterCookie();
                    LoadMethod();
                }
            }
            else
            {
                Response.Redirect("/Account/Register.aspx");
            }
        }

        protected void btnCreateUser2_Click(object sender, EventArgs e)
        {
            if (Response.Cookies["register_cookie"] != null)
            {
                string k_adi = tbUserName2.Text;
                string soru = cb_soru.Text;
                string cevap = txt_cevap.Text;
                string guvenlik = lbl_guvenlik_no2.Text;

                KullaniciCollection CollKul = new KullaniciCollection();
                IPredicateExpression ExpKul = new PredicateExpression();
                ExpKul.AddWithAnd(KullaniciFields.KullaniciUsername == k_adi);
                ExpKul.AddWithAnd(KullaniciFields.KullaniciGizliSoru == soru);
                ExpKul.AddWithAnd(KullaniciFields.KullaniciGizliSoruCevap == cevap);
                CollKul.GetMulti(ExpKul);

                if (lbl_guvenlik_no2.Text != tbGuvenlik2.Text)
                {
                    tbGuvenlik2.ErrorText = "Güvenlik kodunuz hatalı...";
                    tbGuvenlik2.IsValid = false;
                }

                if (CollKul.Count == 0)
                {
                    tbUserName2.ErrorText = "Kullanıcı adınız hatalı...";
                    tbUserName2.IsValid = false;
                    cb_soru.ErrorText = "Gizli sorunuz hatalı...";
                    cb_soru.IsValid = false;
                    txt_cevap.ErrorText = "Cevabınız hatalı...";
                    txt_cevap.IsValid = false;
                }

                else if ((CollKul.Count > 0) && (lbl_guvenlik_no2.Text == tbGuvenlik2.Text))
                {
                    string kayit = Kullanici.sifre_olustur("123456");

                    CollKul[0].KullaniciPassword = kayit;
                    CollKul[0].Save();

                    string CloseWindow;
                    CloseWindow = "alert('Şifre sıfırlama işleminiz tamamlanmıştır. Şifreniz '123456' olarak belirlenmiştir. Güvenliğiniz için sisteme giriş yaptıktan sonra lütfen şifrenizi değiştiriniz...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                    tbUserName2.Text = "";
                    cb_soru.Text = "";
                    cb_soru.NullText = "Seçiniz...";
                    txt_cevap.Text = "";
                    tbGuvenlik2.Text = "";
                    Random rastgele = new Random();
                    Int32 sayi = rastgele.Next(100000, 999999);
                    lbl_guvenlik_no2.Text = sayi.ToString();
                    Response.Cookies.Clear();
                    Request.Cookies.Clear();
                    CreateRegisterCookie();
                    LoadMethod();
                }
            }
            else
            {
                Response.Redirect("/Account/Register.aspx");
            }
        }
    }
}