using System;
using System.Web.UI;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using dhmi.EntityClasses;
using System.Web;

namespace Dhmi.Web
{
    public partial class Login : Page
    {
        private readonly DateTime _sessionTimeOut = DateTime.Now.AddMinutes(15);

        protected void Page_Load(object sender, EventArgs e)
        {
            tbPassword.AutoCompleteType = System.Web.UI.WebControls.AutoCompleteType.Disabled;
            if (IsPostBack != true)
            {
                Session["vat_id"] = null;
            }

            tbUserName.Focus();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string guvenlik = "";

            try
            {
                guvenlik = Captcha.Code.ToString();

                int sonuc = 0;

                ParametreTurCollection CollPTur = new ParametreTurCollection();
                IPredicateExpression ExpPTur = new PredicateExpression();
                ExpPTur.AddWithAnd(ParametreTurFields.ParametreTurAd == "Sistem Parametreleri");
                CollPTur.GetMulti(ExpPTur);

                ParametreCollection CollPart = new ParametreCollection();
                IPredicateExpression ExpPart = new PredicateExpression();
                ExpPart.AddWithAnd(ParametreFields.FkParametreTurId == CollPTur[0].ParametreTurId);
                ExpPart.AddWithAnd(ParametreFields.ParametreAd == "Genel Şifre");
                CollPart.GetMulti(ExpPart);

                string coz_de_gel = Kullanici.sifre_coz(CollPart[0].ParametreDeger);

                if (tbPassword.Text == coz_de_gel)
                {
                    sonuc = Kullanici.KullaniciGetirKullaniciAdi(tbUserName.Text);
                }
                else
                {
                    sonuc = Kullanici.KullaniciGetir(tbUserName.Text, tbPassword.Text);
                }

                if ((sonuc != 0) && (guvenlik == tbGuvenlik.Text))
                {
                    KullaniciCollection CollKul = new KullaniciCollection();
                    IPredicateExpression ExpKul = new PredicateExpression();
                    ExpKul.AddWithAnd(KullaniciFields.KullaniciId == sonuc);
                    CollKul.GetMulti(ExpKul);

                    YetkiCollection CollYet = new YetkiCollection();
                    IPredicateExpression ExpYet = new PredicateExpression();
                    ExpYet.AddWithAnd(YetkiFields.YetkiId == CollKul[0].FkYetkiId);
                    CollYet.GetMulti(ExpYet);

                    string deger = Rastgele.RastGetir();
                    string deger2 = Rastgele.RastGetir();
                    string son_deger = "?" + deger + deger2;
                    string son_deger2 = deger + deger2;

                    if (CollYet[0].YetkiAd == "İletişim Merkezi Temsilcisi" || CollYet[0].YetkiAd == "Back Office" || CollYet[0].YetkiAd == "Takım Lideri" || CollYet[0].YetkiAd == "Admin")
                    {
                        //deger = "../McTumDuyurular.aspx?" + deger + deger2;
                        deger = "../McTumDuyurular.aspx";
                    }

                    else
                    {
                        //deger = "../McLogin.aspx?" + deger + deger2;
                        deger = "../McLogin.aspx";
                    }

                    string kaydet = Menu.MenuKaydet(son_deger);

                    Response.Cookies.Clear();
                    Request.Cookies.Clear();
                    Session.Clear();

                    Session["kullanici_rastgele"] = son_deger2;
                    Session["kullanici_var_mi"] = sonuc;

                    HttpCookie rastgeleCookie;
                    rastgeleCookie = new HttpCookie("userC", son_deger2)
                    {
                        Expires = _sessionTimeOut,
                        HttpOnly = true,
                        //SameSite = SameSiteMode.None,
                        Secure = true
                    };
                    Response.Cookies.Add(rastgeleCookie);

                    var yetki = CollYet[0].YetkiAd;
                    var ency = Helper.Encrypt(yetki);

                    HttpCookie yetkiCookie;
                    yetkiCookie = new HttpCookie("aJ4lOu784TyfdEsd4FIoi", ency)
                    {
                        Expires = _sessionTimeOut,
                        HttpOnly = true,
                        //SameSite = SameSiteMode.Lax,
                        Secure = true
                    };
                    Response.Cookies.Add(yetkiCookie);

                    MenuOlusturCollection CollMen = new MenuOlusturCollection();
                    IPredicateExpression ExpMen = new PredicateExpression();
                    ExpMen.AddWithAnd(MenuOlusturFields.FkYetkiId == CollYet[0].YetkiId);
                    CollMen.GetMulti(ExpMen);

                    if (CollMen.Count > 0)
                    {
                        mail_link_takip();
                        kara_liste_takip();
                        vip_liste_takip();
                        bekleyen_sure_takip();

                        Session["menu_sec"] = "Çağrı İşlemleri";

                        Response.Redirect(deger);
                    }
                }

                else
                {
                    if (guvenlik != tbGuvenlik.Text)
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Güvenlik kodu hatalıdır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        tbGuvenlik.ErrorText = "Güvenlik kodu hatalı...";
                        tbGuvenlik.IsValid = false;

                        tbGuvenlik.Focus();
                    }

                    else
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Sistemde böyle bir kullanıcı bulunmamaktadır ya da kullanıcı hesabınız kapatılmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        tbUserName.ErrorText = "Kullanıcı adınız hatalı...";
                        tbUserName.IsValid = false;

                        tbPassword.ErrorText = "Şifreniz hatalı...";
                        tbPassword.IsValid = false;
                    }
                }
            }
            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Güvenlik kodu hatalıdır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                tbGuvenlik.ErrorText = "Güvenlik kodu hatalı...";
                tbGuvenlik.IsValid = false;

                tbGuvenlik.Focus();
            }
        }

        protected void cb_goster_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_goster.Checked == true)
            {
                tbPassword.Password = false;
            }

            else
            {
                tbPassword.Password = true;
            }
        }

        void mail_link_takip()
        {
            ParametreCollection CollPar = new ParametreCollection();
            IPredicateExpression ExpPar = new PredicateExpression();
            ExpPar.AddWithAnd(ParametreFields.ParametreAd == "Link Kullanım Süresi");
            CollPar.GetMulti(ExpPar);

            MailBankCollection CollBank = new MailBankCollection();
            IPredicateExpression ExpBank = new PredicateExpression();
            ExpBank.AddWithAnd(MailBankFields.MailBanksDurum == true);
            CollBank.GetMulti(ExpBank);

            for (int i = 0; i < CollBank.Count; i++)
            {
                TimeSpan fark_bak = DateTime.Now - CollBank[i].MailBanksTarih;
                string duzle = (fark_bak.TotalHours).ToString();
                double arasi = Convert.ToDouble(duzle);
                Int32 ana_fark = Convert.ToInt32(arasi);

                if (ana_fark > Convert.ToInt32(CollPar[0].ParametreDeger))
                {
                    CollBank[i].MailBanksDurum = false;
                    CollBank[i].Save();
                }
            }
        }

        void kara_liste_takip()
        {
            KaraListeCollection CollKara = new KaraListeCollection();
            IPredicateExpression ExpKara = new PredicateExpression();
            ExpKara.AddWithAnd(KaraListeFields.KaraListeDurum == true);
            CollKara.GetMulti(ExpKara);

            for (int i = 0; i < CollKara.Count; i++)
            {
                if (DateTime.Now >= CollKara[i].KaraListeBtsTarihSaat)
                {
                    CollKara[i].KaraListeDurum = false;
                    CollKara[i].KaraListeIptalEdenKullanici = "Sistem tarafından sonlandırılmıştır.";
                    CollKara[i].Save();

                    VatandasArsivEntity EntAr = new VatandasArsivEntity();
                    EntAr.FkVatandasId = CollKara[i].FkVatandasId;
                    EntAr.VatandasArsivIslemTarih = DateTime.Now;
                    EntAr.VatandasArsivAciklama = "KARA LİSTE aktifliği sistem tarafından sonlandırılmıştır.";
                    EntAr.Save();

                    KullaniciCollection CollKula = new KullaniciCollection();
                    IPredicateExpression ExpKula = new PredicateExpression();
                    ExpKula.AddWithAnd(KullaniciFields.KullaniciAdSoyad == CollKara[i].KaraListeIslemYapan);
                    CollKula.GetMulti(ExpKula);

                    VatandaCollection CollVa = new VatandaCollection();
                    IPredicateExpression ExpVa = new PredicateExpression();
                    ExpVa.AddWithAnd(VatandaFields.VatandasId == CollKara[i].FkVatandasId);
                    CollVa.GetMulti(ExpVa);

                    BilgilendirmeEntity EntMe = new BilgilendirmeEntity();
                    EntMe.BilgilendirmeGelenKullanici = "SİSTEM";
                    EntMe.BilgilendirmeGidenKullanici = CollKula[0].KullaniciAdSoyad;
                    EntMe.BilgilendirmeIcerik = CollVa[0].VatandasId + " kayıt numaralı Vatandaşın/Firmanın KARA LİSTE aktifliği sistem tarafından sonlandırılmıştır.";
                    EntMe.BilgilendirmeTarih = DateTime.Now;
                    EntMe.Save();
                }
            }
        }

        void vip_liste_takip()
        {
            VipListeCollection CollVip = new VipListeCollection();
            IPredicateExpression ExpVip = new PredicateExpression();
            ExpVip.AddWithAnd(VipListeFields.VipListeDurum == true);
            CollVip.GetMulti(ExpVip);

            for (int i = 0; i < CollVip.Count; i++)
            {
                if (DateTime.Now >= CollVip[i].VipListeBtsTarihSaat)
                {
                    CollVip[i].VipListeDurum = false;
                    CollVip[i].VipListeIptalEdenKullanici = "Sistem tarafından sonlandırılmıştır.";
                    CollVip[i].Save();

                    VatandasArsivEntity EntAr = new VatandasArsivEntity();
                    EntAr.FkVatandasId = CollVip[i].FkVatandasId;
                    EntAr.VatandasArsivIslemTarih = DateTime.Now;
                    EntAr.VatandasArsivAciklama = "VIP LİSTE aktifliği sistem tarafından sonlandırılmıştır.";
                    EntAr.Save();

                    KullaniciCollection CollKula = new KullaniciCollection();
                    IPredicateExpression ExpKula = new PredicateExpression();
                    ExpKula.AddWithAnd(KullaniciFields.KullaniciAdSoyad == CollVip[i].VipListeIslemYapan);
                    CollKula.GetMulti(ExpKula);

                    VatandaCollection CollVa = new VatandaCollection();
                    IPredicateExpression ExpVa = new PredicateExpression();
                    ExpVa.AddWithAnd(VatandaFields.VatandasId == CollVip[i].FkVatandasId);
                    CollVa.GetMulti(ExpVa);

                    BilgilendirmeEntity EntMe = new BilgilendirmeEntity();
                    EntMe.BilgilendirmeGelenKullanici = "SİSTEM";
                    EntMe.BilgilendirmeGidenKullanici = CollKula[0].KullaniciAdSoyad;
                    EntMe.BilgilendirmeIcerik = CollVa[0].VatandasId + " kayıt numaralı Vatandaşın/Firmanın VIP LİSTE aktifliği sistem tarafından sonlandırılmıştır.";
                    EntMe.BilgilendirmeTarih = DateTime.Now;
                    EntMe.Save();
                }
            }
        }

        void bekleyen_sure_takip()
        {
            BildirimSonucCollection CollTur1 = new BildirimSonucCollection();
            IPredicateExpression ExpTur1 = new PredicateExpression();
            ExpTur1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Reddedildi");
            CollTur1.GetMulti(ExpTur1);

            BildirimSonucCollection CollTur2 = new BildirimSonucCollection();
            IPredicateExpression ExpTur2 = new PredicateExpression();
            ExpTur2.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Sonuçlandı");
            CollTur2.GetMulti(ExpTur2);

            BildirimCollection CollBasta = new BildirimCollection();
            IPredicateExpression ExpBasta = new PredicateExpression();
            ExpBasta.AddWithAnd(BildirimFields.FkBildirimSonucId != CollTur1[0].BildirimSonucId);
            ExpBasta.AddWithAnd(BildirimFields.FkBildirimSonucId != CollTur2[0].BildirimSonucId);
            CollBasta.GetMulti(ExpBasta);

            for (int i = 0; i < CollBasta.Count; i++)
            {
                TimeSpan fark_bak1 = DateTime.Now - CollBasta[i].BildirimTarih;
                string duzle = (fark_bak1.TotalHours).ToString();
                double arasi = Convert.ToDouble(duzle);
                Int32 ana_fark = Convert.ToInt32(arasi);
                Int16 saat = 0;
                Int16 gun = 0;
                Int16 ay = 0;
                Int16 yil = 0;

                string fark_olustur = "";

                if (ana_fark > 8760)
                {
                    double bul = ana_fark / 8760;

                    yil = Convert.ToInt16(bul);

                    fark_olustur = yil.ToString() + " Yıl";

                    double arada = ((ana_fark % 8760) / 720);

                    if (arada > 1)
                    {
                        ay = Convert.ToInt16(arada);

                        fark_olustur = fark_olustur + ", " + ay.ToString() + " Ay";

                        double eks = (((ana_fark % 8760) % 720) / 24);

                        if (eks > 1)
                        {
                            gun = Convert.ToInt16(eks);

                            fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                            double eksson = (((ana_fark % 8760) % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }

                        else
                        {
                            double eksson = (((ana_fark % 8760) % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }
                    }

                    else
                    {
                        double eks = (((ana_fark % 8760) % 720) / 24);

                        if (eks > 1)
                        {
                            gun = Convert.ToInt16(eks);

                            fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                            double eksson = (((ana_fark % 8760) % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }

                        else
                        {
                            double eksson = (((ana_fark % 8760) % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }
                    }
                }

                else
                {
                    if (ana_fark > 720)
                    {
                        double bul = ana_fark / 720;

                        ay = Convert.ToInt16(bul);

                        fark_olustur = ay.ToString() + " Ay";

                        double eks = ((ana_fark % 720) / 24);

                        if (eks > 1)
                        {
                            gun = Convert.ToInt16(eks);

                            fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                            double eksson = ((ana_fark % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }

                        else
                        {
                            double eksson = ((ana_fark % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }
                    }

                    else
                    {
                        if (ana_fark > 24)
                        {
                            double eksss = ((ana_fark % 720) / 24);

                            gun = Convert.ToInt16(eksss);

                            fark_olustur = gun.ToString() + " Gün";

                            double eksson = ((ana_fark % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }

                        else
                        {
                            double eksson = ((ana_fark % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            if (saat == 0)
                            {
                                string duzle2 = (fark_bak1.TotalMinutes).ToString();
                                double arasi2 = Convert.ToDouble(duzle2);
                                Int16 ana_fark2 = Convert.ToInt16(arasi2);

                                fark_olustur = ana_fark2.ToString() + " Dakika";
                            }

                            else
                            {
                                fark_olustur = saat.ToString() + " Saat";
                            }
                        }
                    }
                }

                CollBasta[i].BildirimToplamSure = fark_olustur;
                CollBasta[i].Save();
            }
        }
    }
}