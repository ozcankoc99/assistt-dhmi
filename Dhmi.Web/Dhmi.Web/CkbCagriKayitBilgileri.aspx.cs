using System;
using System.Web.UI;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Threading;
using dhmi.EntityClasses;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using dhmi.TypedListClasses;
using System.Configuration;
using DevExpress.Web.ASPxMenu;
using DevExpress.Web.ASPxGridView;
using DevExpress.Data;
using System.Web;

namespace Dhmi.Web
{
    public partial class CkbCagriKayitBilgileri : System.Web.UI.Page
    {
        public KullaniciEntity AktifKullanici
        {
            get
            {
                if (Session["kullanici_var_mi"] == null)
                {
                    Response.Redirect("Account/Login.aspx");
                    return null;
                }
                else
                {
                    if (ViewState["AktifKullanici"] == null)
                    {
                        ViewState["AktifKullanici"] = new KullaniciEntity(Convert.ToInt16(Session["kullanici_var_mi"]));
                    }

                    return (KullaniciEntity)ViewState["AktifKullanici"];
                }
            }
            set
            {
                ViewState["AktifKullanici"] = new KullaniciEntity(Convert.ToInt16(Session["kullanici_var_mi"]));
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["menu_sec"] = "Çağrı İşlemleri";

            if ((Session["kullanici_var_mi"] == null) || (Session["kullanici_rastgele"] == null))
            {
                Response.Redirect("Account/Login.aspx");                
            }

            HttpCookie cookie = Request.Cookies["userC"];
            HttpCookie cookieYetki = Request.Cookies["aJ4lOu784TyfdEsd4FIoi"];
            if (cookie != null && cookieYetki != null)
            {
                string yetki = Helper.Decrypt(cookieYetki.Value);
                if (yetki == "Admin" || yetki == "İletişim Merkezi Temsilcisi" || yetki == "Takım Lideri" || yetki == "Kurum Sistem Yöneticisi")
                {
                    cookie.Expires = DateTime.Now.AddMinutes(15);
                    cookie.Secure = true;
                    //cookie.SameSite = SameSiteMode.Lax;
                    cookie.HttpOnly = true;
                    Response.Cookies.Add(cookie);
                }
                else
                {
                    Response.Redirect("McTumDuyurular.aspx");
                }

            }
            else
            {
                Response.Redirect("Account/Login.aspx");
            }

            if (IsPostBack != true)
            {
                Session["sorgula_ana"] = null;
                Session["sorgula_2"] = null;

                string gun = DateTime.Now.Day.ToString();
                string ay = DateTime.Now.Month.ToString();
                string yil = DateTime.Now.Year.ToString();

                if (gun.Length == 1)
                {
                    gun = "0" + gun;
                }

                if (ay.Length == 1)
                {
                    ay = "0" + ay;
                }

                if (Session["sorgula_2"] == null)
                {
                    txt_bas_tarihi_2.Text = gun + "." + ay + "." + yil;
                    txt_bit_tarihi_2.Text = gun + "." + ay + "." + yil;
                }

                if (Session["sorgula_ana"] == null)
                {
                    txt_bas_tarihi.Text = gun + "." + ay + "." + yil;
                    txt_bit_tarihi.Text = gun + "." + ay + "." + yil;
                }                                                

                ParametreCollection CollParam = new ParametreCollection();
                IPredicateExpression ExpParam = new PredicateExpression();
                ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
                ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollParam.GetMulti(ExpParam);

                if (CollParam.Count > 0)
                {
                    grid_bildirim.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
                    grid_bildirim_sil.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
                }
                                

                KullaniciCollection CollKul = new KullaniciCollection();
                IPredicateExpression ExpKul = new PredicateExpression();
                ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollKul.GetMulti(ExpKul);

                grid_bildirim_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "ÇAĞRI BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
                grid_bildirim_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

                ParametreCollection CollPrm = new ParametreCollection();
                IPredicateExpression ExpPrm = new PredicateExpression();
                ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
                CollPrm.GetMulti(ExpPrm);

                DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                bil_list.Fill(0, sort22, true, filter2);

                grid_bildirim.DataSource = bil_list;
                grid_bildirim.DataBind();                

                grid_bildirim_sil.DataSource = bil_list;
                grid_bildirim_sil.DataBind();                

                HavalimaniCollection CollHav = new HavalimaniCollection();
                ISortExpression sorthav = new SortExpression();
                sorthav.Add(new SortClause(HavalimaniFields.HavalimaniAd, SortOperator.Ascending));
                CollHav.GetMulti(null, 0, sorthav);

                cb_havalimani.Items.Add("");

                for (int i = 0; i < CollHav.Count; i++)
                {
                    cb_havalimani.Items.Add(CollHav[i].HavalimaniAd);
                }

                CagriTipiCollection CollTis = new CagriTipiCollection();
                ISortExpression sorttis = new SortExpression();
                sorttis.Add(new SortClause(CagriTipiFields.CagriTipiAd, SortOperator.Ascending));
                CollTis.GetMulti(null, 0, sorttis);

                for (int i = 0; i < CollTis.Count; i++)
                {
                    cb_cag_tip.Items.Add(CollTis[i].CagriTipiAd);
                }

                cb_cinsiyet.Items.Clear();
                cb_cinsiyet.Items.Add("Erkek");
                cb_cinsiyet.Items.Add("Kadın");

                cb_kayit_tur.Items.Clear();
                cb_kayit_tur.Items.Add("Gerçek Kişi");
                cb_kayit_tur.Items.Add("Gerçek Kişi (Yabancı)");
                cb_kayit_tur.Items.Add("Tüzel Kişi");

                txt_dogum_tarihi.Text = "01.01.1900";

                BildirimSonucCollection CollTur1 = new BildirimSonucCollection();
                IPredicateExpression ExpTur1 = new PredicateExpression();
                ExpTur1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Reddedildi");
                CollTur1.GetMulti(ExpTur1);

                BildirimSonucCollection CollTur2 = new BildirimSonucCollection();
                IPredicateExpression ExpTur2 = new PredicateExpression();
                ExpTur2.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Sonuçlandı");
                CollTur2.GetMulti(ExpTur2);                                

                Session["say_kac"] = "0";

                CagriMerkezCollection CollMer = new CagriMerkezCollection();
                IPredicateExpression ExpMer = new PredicateExpression();
                ExpMer.AddWithAnd(CagriMerkezFields.CagriMerkezDurum == true);
                CollMer.GetMulti(ExpMer);

                cb_sistem.Items.Clear();

                for (int i = 0; i < CollMer.Count; i++)
                {
                    cb_sistem.Items.Add(CollMer[i].CagriMerkezNo);
                }

                cb_sistem.SelectedIndex = 1;

                BildirimTuruCollection CollBil = new BildirimTuruCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ISortExpression sortbil = new SortExpression();
                ExpBil.AddWithAnd(BildirimTuruFields.BildirimTuruDurum == true);
                sortbil.Add(new SortClause(BildirimTuruFields.BildirimTuruAd, SortOperator.Ascending));
                CollBil.GetMulti(ExpBil, 0, sortbil);

                cb_tur.Items.Clear();

                for (int i = 0; i < CollBil.Count; i++)
                {
                    cb_tur.Items.Add(CollBil[i].BildirimTuruAd);
                }

                BildirimGeriDonuCollection CollDon = new BildirimGeriDonuCollection();
                IPredicateExpression ExpDon = new PredicateExpression();
                ISortExpression sortdon = new SortExpression();
                ExpDon.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusTur == true);
                sortdon.Add(new SortClause(BildirimGeriDonuFields.BildirimGeriDonusAd, SortOperator.Ascending));
                CollDon.GetMulti(ExpDon, 0, sortdon);

                cb_sekil.Items.Clear();

                for (int i = 0; i < CollDon.Count; i++)
                {
                    cb_sekil.Items.Add(CollDon[i].BildirimGeriDonusAd);
                }

                AltKonuCollection CollKon = new AltKonuCollection();
                IPredicateExpression ExpKon = new PredicateExpression();
                ExpKon.AddWithAnd(AltKonuFields.AltKonuDurum == true);
                ISortExpression sortkon = new SortExpression();
                sortkon.Add(new SortClause(AltKonuFields.AltKonuAd, SortOperator.Ascending));
                CollKon.GetMulti(ExpKon, 0, sortkon);

                cb_konu.Items.Clear();

                for (int i = 0; i < CollKon.Count; i++)
                {
                    cb_konu.Items.Add(CollKon[i].AltKonuAd);
                }

                GrupCollection CollGr = new GrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ISortExpression sortgr = new SortExpression();
                ExpGr.AddWithAnd(GrupFields.GrupDurum == true);
                ExpGr.AddWithAnd(!(new FieldLikePredicate(GrupFields.GrupAd, null, "%Havali%")));
                sortgr.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                cb_grup_list.Items.Clear();

                for (int i = 0; i < CollGr.Count; i++)
                {
                    cb_grup_list.Items.Add(CollGr[i].GrupAd);
                }

                KullaniciCollection CollKull = new KullaniciCollection();
                IPredicateExpression ExpKull = new PredicateExpression();
                ISortExpression sortkull = new SortExpression();
                ExpKull.AddWithAnd(KullaniciFields.KullaniciDurum == true);                
                ExpKull.AddWithAnd(!(new FieldLikePredicate(KullaniciFields.KullaniciBirim, "%Havali%")));
                sortkull.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
                CollKull.GetMulti(ExpKull, 0, sortkull);

                cb_per_list.Items.Clear();

                for (int i = 0; i < CollKull.Count; i++)
                {
                    cb_per_list.Items.Add(CollKull[i].KullaniciAdSoyad);
                }                

                MenuCollection CollMenu = new MenuCollection();
                IPredicateExpression ExpMenu = new PredicateExpression();
                ExpMenu.AddWithAnd(MenuFields.MenuAd == "Çağrı İşlemleri");
                CollMenu.GetMulti(ExpMenu);

                AltMenuCollection CollAlt1 = new AltMenuCollection();
                IPredicateExpression ExpAlt1 = new PredicateExpression();
                ExpAlt1.AddWithAnd(AltMenuFields.AltMenuAd == "Çağrı Kayıt Bilgileri");
                CollAlt1.GetMulti(ExpAlt1);

                AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                IPredicateExpression ExpAlt2 = new PredicateExpression();
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Çağrı Kayıt Bilgileri");
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
                        IslemCollection CollIslem = new IslemCollection();
                        IPredicateExpression ExpIslem = new PredicateExpression();
                        ExpIslem.AddWithAnd(IslemFields.IslemId == CollIs[d].IslemId);
                        CollIslem.GetMulti(ExpIslem);

                        Menu1.Items.Add(CollIslem[0].IslemAd);
                    }

                    else
                    {
                        
                    }
                }

                Session["par_guncelle_mi"] = "0";

                if (Session["vat_id"] == null)
                {                    
                    cb_kayit_tur.Text = "";
                    cb_kayit_tur.NullText = "Seçiniz...";
                    txt_tc_no.Text = "";
                    txt_tc_no.Enabled = true;
                    btn_kps.Enabled = true;
                    txt_ad.Text = "";
                    txt_soyad.Text = "";
                    txt_soyad.Enabled = true;
                    cb_cinsiyet.Text = "";
                    cb_cinsiyet.NullText = "Seçiniz...";
                    cb_cinsiyet.Enabled = true;
                    txt_dogum_tarihi.Text = "01.01.1900";
                    txt_dogum_tarihi.Enabled = true;
                    txt_mail.Text = "";
                    txt_tel_no.Text = "";
                    txt_adres.Text = "";
                    txt_pasaport.Text = "";
                    txt_vergi_no.Text = "";
                    txt_uyruk.Text = "";

                    if (Session["vat_gelen"] != null) 
                    {
                        txt_tel_no.Text = Session["vat_gelen"].ToString();
                    }

                    cb_kayit_tur.Focus();
                }

                else
                {
                    VatandaCollection CollBul = new VatandaCollection();
                    IPredicateExpression ExpBul = new PredicateExpression();
                    ExpBul.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                    CollBul.GetMulti(ExpBul);

                    BildirimCollection CollBill = new BildirimCollection();
                    IPredicateExpression ExpBill = new PredicateExpression();
                    ExpBill.AddWithAnd(BildirimFields.FkVatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                    CollBill.GetMulti(ExpBill);

                    txt_cagri_sayisi.Text = CollBill.Count.ToString();

                    if (CollBill.Count > 0)
                    {
                        btn_gor.Enabled = true;
                    }

                    else
                    {
                        btn_gor.Enabled = false;
                    }

                    cb_kayit_tur.Text = CollBul[0].VatandasTur;
                    txt_tc_no.Text = CollBul[0].VatandasTcNo;
                    txt_tc_no.Enabled = true;
                    btn_kps.Enabled = true;
                    txt_ad.Text = CollBul[0].VatandasAd;
                    txt_soyad.Text = CollBul[0].VatandasSoyad;
                    txt_soyad.Enabled = true;
                    cb_cinsiyet.Text = CollBul[0].VatandasCinsiyet;
                    cb_cinsiyet.Enabled = true;
                    txt_pasaport.Text = CollBul[0].VatandasPasaportNo;
                    txt_uyruk.Text = CollBul[0].VatandasUyruk;

                    if (CollBul[0].VatandasDogumTarihi != null)
                    {
                        txt_dogum_tarihi.Text = CollBul[0].VatandasDogumTarihi.ToString();
                    }

                    txt_dogum_tarihi.Enabled = true;
                    txt_mail.Text = CollBul[0].VatandasMail;
                    txt_tel_no.Text = CollBul[0].VatandasTel1;
                    txt_adres.Text = CollBul[0].VatandasAdres;

                    cb_kayit_tur.Focus();
                }

                string hexValue2 = "#C0D9E7";
                Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
            }                      

            cb_tur.Focus();
        }

        protected void btn_ata_Click(object sender, EventArgs e)
        {
            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            BildirimCollection CollBil = new BildirimCollection();
            IPredicateExpression ExpBil = new PredicateExpression();
            ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserName.Text));
            CollBil.GetMulti(ExpBil);

            BildirimIslemCollection CollIs = new BildirimIslemCollection();
            IPredicateExpression ExpIs = new PredicateExpression();
            ExpIs.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "Yönlendirildi");
            CollIs.GetMulti(ExpIs);

            BildirimSonucCollection CollAk = new BildirimSonucCollection();
            IPredicateExpression ExpAk = new PredicateExpression();
            ExpAk.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
            CollAk.GetMulti(ExpAk);

            BildirimHistoryEntity EntHis = new BildirimHistoryEntity();
            EntHis.FkBildirimId = CollBil[0].BildirimId;
            EntHis.FkBildirimIslemId = CollIs[0].BildirimIslemId;
            EntHis.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
            EntHis.BildirimHistoryTarih = DateTime.Now;
            EntHis.BildirimHistorySure = "0";
            EntHis.BildirimHistoryAciklama = CollKul[0].KullaniciAdSoyad + " tarafından tekrar BACKOFFİCE adlı gruba atandı.";
            EntHis.Save();

            CollBil[0].BildirimAtanmaDurumu = CollBil[0].BildirimAtanmaDurumu + " Bildirim tekrar BACKOFFİCE adlı gruba atandı.";
            CollBil[0].FkBildirimSonucId = CollAk[0].BildirimSonucId;
            CollBil[0].BildirimSonIslemTarih = DateTime.Now;
            CollBil[0].Save();

            string CloseWindow;
            CloseWindow = "alert('Bildirim yeniden BACKOFFİCE adlı gruba atanmıştır. ...')";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

            BildirimAtamaKullaniciCollection CollGet = new BildirimAtamaKullaniciCollection();
            IPredicateExpression ExpGet = new PredicateExpression();
            ExpGet.AddWithAnd(BildirimAtamaKullaniciFields.FkBildirimId == CollBil[0].BildirimId);
            CollGet.GetMulti(ExpGet);

            for (int i = 0; i < CollGet.Count; i++) 
            {
                CollGet[i].Delete();
                CollGet[i].Save();
            }

            GrupCollection CollGr = new GrupCollection();
            IPredicateExpression ExpGr = new PredicateExpression();
            ExpGr.AddWithAnd(GrupFields.GrupAd == "Backoffice");
            CollGr.GetMulti(ExpGr);

            GrupAtamaCollection CollGon = new GrupAtamaCollection();
            IPredicateExpression ExpGon = new PredicateExpression();
            ExpGon.AddWithAnd(GrupAtamaFields.FkGrupId == CollGr[0].GrupId);
            CollGon.GetMulti(ExpGon);

            for (int i = 0; i < CollGon.Count; i++) 
            {
                KullaniciCollection CollAta = new KullaniciCollection();
                IPredicateExpression ExpAta = new PredicateExpression();
                ExpAta.AddWithAnd(KullaniciFields.KullaniciId == CollGon[i].FkKullaniciId);
                CollAta.GetMulti(ExpAta);

                BildirimAtamaKullaniciEntity EntAta = new BildirimAtamaKullaniciEntity();
                EntAta.FkBildirimId = CollBil[0].BildirimId;
                EntAta.FkKullaniciId = CollAta[0].KullaniciId;
                EntAta.BildirimAtamaKullaniciBittiMi = false;
                EntAta.BildirimAtamaKullaniciTarih = DateTime.Now;
                EntAta.BildirimAtamaKullaniciYonMu = "Hayır";
                EntAta.Save();

                try
                {
                    string konusu = "DHMİ İletişim Merkezi Bildirim Talebi";
                    string maili = CollAta[0].KullaniciMail;
                    string bsl = "www.alo.dhmi.gov.tr/McCallCenterLinkControlAsLogin.aspx?";
                    string bas_coz = "dhmi";
                    string bit_coz = "callcenter";
                    string dhmi_bas = Kullanici.sifre_olustur(bas_coz);
                    string dhmi_bit = Kullanici.sifre_olustur(bit_coz);
                    string aradaki_kul = CollAta[0].KullaniciId.ToString();
                    aradaki_kul = Kullanici.sifre_olustur(aradaki_kul);
                    string linki = dhmi_bas + aradaki_kul + dhmi_bit;

                    string kayit_link = bsl + linki;

                    Mail.MailLinkGonder(CollBil[0].BildirimId.ToString(), linki, maili, konusu, CollBil[0].BildirimMetin);

                    MailBankEntity EntBan = new MailBankEntity();
                    EntBan.MailBanksLink = kayit_link;
                    EntBan.MailBanksBildirim = CollBil[0].BildirimId;
                    EntBan.MailBanksKullanici = CollAta[0].KullaniciId;
                    EntBan.MailBanksTikAdet = 0;
                    EntBan.MailBanksTarih = DateTime.Now;
                    EntBan.MailBanksDurum = true;
                    EntBan.Save();
                }

                catch
                {
                    //Mail Adresinde Sorun Varsa Direkt Geç...
                }
            }

            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            if (Session["sorgula_2"] == null && Session["sorgula_ana"] == null)
            {
                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                bil_list.Fill(0, sort22, true, filter2);

                grid_bildirim.DataSource = bil_list;
                grid_bildirim.DataBind();

                grid_bildirim_sil.DataSource = bil_list;
                grid_bildirim_sil.DataBind();
            }

            else 
            {
                if (Session["sorgula_2"] != null) 
                {
                    ListBildirimTypedList bil_list = new ListBildirimTypedList();
                    ISortExpression sort22 = new SortExpression();
                    sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filter2 = new PredicateExpression();                    
                    filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi_2.Text));
                    filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi_2.Text));
                    bil_list.Fill(0, sort22, true, filter2);

                    grid_bildirim_sil.DataSource = bil_list;
                    grid_bildirim_sil.DataBind();
                }

                if (Session["sorgula_ana"] != null)
                {
                    ListBildirimTypedList bil_list = new ListBildirimTypedList();
                    ISortExpression sort22 = new SortExpression();
                    sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filter2 = new PredicateExpression();
                    filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                    filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
                    bil_list.Fill(0, sort22, true, filter2);

                    grid_bildirim.DataSource = bil_list;
                    grid_bildirim.DataBind();
                }
            }

            btn_guncelle.Enabled = false;
            btn_sil.Enabled = false;
            btn_ata.Enabled = false;
        }

        protected void btn_dosya_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McDosyaDurumu.aspx', null, 'height=160,width=1000,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            Session["say_kac"] = "0";

            txt_kisisel_measj.Text = "";
            cb_havalimani.Text = "";
            cb_havalimani.NullText = "Seçiniz...";
            pnl_sorgu.Visible = false;
            cb_tur.Text = "";
            cb_tur.NullText = "Seçiniz...";
            cb_sekil.Text = "";
            cb_sekil.NullText = "Seçiniz...";
            btn_yukle.Enabled = false;
            cb_konu.Text = "";
            cb_konu.NullText = "Seçiniz...";
            txt_not.Text = "";
            txt_dava_ad_soyad.Text = "";
            txt_dava_dosya_no.Text = "";
            txt_dava_konu.Text = "";
            txt_dava_mahkeme_adi.Text = "";
            cb_cag_tip.Text = "";
            cb_cag_tip.NullText = "Seçiniz...";
            cb_kapat.Checked = false;

            cb_kayit_tur.Text = "";
            cb_kayit_tur.NullText = "Seçiniz...";
            txt_tc_no.Text = "";
            btn_kps.Enabled = false;
            txt_ad.Text = "";
            txt_soyad.Text = "";
            cb_cinsiyet.Text = "";
            cb_cinsiyet.NullText = "Seçiniz...";
            string hexValue2 = "#FFFFFF";
            txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
            txt_pasaport.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
            txt_uyruk.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
            txt_ad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
            txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
            cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
            txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);            
            txt_dogum_tarihi.Text = "01.01.1900";
            txt_tel_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
            txt_mail.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
            txt_adres.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
            txt_tel_no.Text = "";
            txt_mail.Text = "";
            txt_adres.Text = "";
            txt_uyruk.Text = "";
            txt_pasaport.Text = "";
            txt_vergi_no.Text = "";

            for (int i = 0; i < cb_grup_list.Items.Count; i++)
            {
                cb_grup_list.Items[i].Selected = false;
            }

            for (int i = 0; i < cb_per_list.Items.Count; i++)
            {
                cb_per_list.Items[i].Selected = false;
            }

            cb_gr_hep.Checked = false;
            cb_hepsi.Checked = false;
            txt_cagri_sayisi.Text = "";
            btn_gor.Enabled = false;

            Session["vat_id"] = null;

            cb_tur.Focus();
        }

        protected void btnPdfExport_Click(object sender, EventArgs e)
        {
            Session["rapor_adi"] = "Çağrı Bilgileri";

            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McAraRapor.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void grid_bildirim_PageSizeChanged(object sender, EventArgs e)
        {            
            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));
            
            ListBildirimTypedList bil_list = new ListBildirimTypedList();
            ISortExpression sort22 = new SortExpression();
            sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filter2 = new PredicateExpression();

            if (Session["sorgula_ana"] == null)
            {
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
            }

            else 
            {
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
            }
            
            bil_list.Fill(0, sort22, true, filter2);

            grid_bildirim.DataSource = bil_list;
            grid_bildirim.DataBind();

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_bildirim.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_bildirim_sil_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            ListBildirimTypedList bil_list = new ListBildirimTypedList();
            ISortExpression sort22 = new SortExpression();
            sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filter2 = new PredicateExpression();

            if (Session["sorgula_2"] == null)
            {
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
            }

            else
            {
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
            }
            
            bil_list.Fill(0, sort22, true, filter2);

            grid_bildirim_sil.DataSource = bil_list;
            grid_bildirim_sil.DataBind();

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_bildirim_sil.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }                       

        protected void grid_bildirim_sil_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = grid_bildirim_sil.GetSelectedFieldValues("BildirimId")[0].ToString();

            btn_guncelle.Enabled = true;
        }       

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            Session["par_guncelle_mi"] = "1";

            Int32 idsi = Convert.ToInt32(txtUserName.Text);

            MultiView1.ActiveViewIndex = 0;

            string hexValue2 = "#C0D9E7";
            string hexValue = "#FFFFFF";
            Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
            Menu1.Items[2].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);

            BildirimCollection CollAna = new BildirimCollection();
            IPredicateExpression ExpAna = new PredicateExpression();
            ExpAna.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserName.Text));
            CollAna.GetMulti(ExpAna);

            Session["vat_id"] = CollAna[0].FkVatandasId.ToString();

            VatandaCollection CollVat = new VatandaCollection();
            IPredicateExpression ExpVat = new PredicateExpression();
            ExpVat.AddWithAnd(VatandaFields.VatandasId == CollAna[0].FkVatandasId);
            CollVat.GetMulti(ExpVat);

            cb_kayit_tur.Text = CollVat[0].VatandasTur;
            txt_tc_no.Text = CollVat[0].VatandasTcNo;
            txt_ad.Text = CollVat[0].VatandasAd;
            txt_soyad.Text = CollVat[0].VatandasSoyad;

            if (CollVat[0].VatandasCinsiyet != null)
            {
                cb_cinsiyet.Text = CollVat[0].VatandasCinsiyet;
            }

            if (CollVat[0].VatandasDogumTarihi != null)
            {
                txt_dogum_tarihi.Text = CollVat[0].VatandasDogumTarihi.ToString();
            }

            txt_tel_no.Text = CollVat[0].VatandasTel1;
            txt_mail.Text = CollVat[0].VatandasMail;
            txt_adres.Text = CollVat[0].VatandasAdres;
            txt_pasaport.Text = CollVat[0].VatandasPasaportNo;
            txt_uyruk.Text = CollVat[0].VatandasUyruk;

            CagriTipiCollection CollTis = new CagriTipiCollection();
            IPredicateExpression ExpTis = new PredicateExpression();
            ExpTis.AddWithAnd(CagriTipiFields.CagriTipiId == CollAna[0].FkCagriTipiId);
            CollTis.GetMulti(ExpTis);

            cb_cag_tip.Text = CollTis[0].CagriTipiAd;

            BildirimCollection CollSayi = new BildirimCollection();
            IPredicateExpression ExpSayi = new PredicateExpression();
            ExpSayi.AddWithAnd(BildirimFields.FkVatandasId == CollVat[0].VatandasId);
            CollSayi.GetMulti(ExpSayi);

            if (CollSayi.Count > 0)
            {
                btn_gor.Enabled = true;                
            }

            else
            {
                btn_gor.Enabled = false;                
            }

            txt_cagri_sayisi.Text = CollSayi.Count.ToString();
            cb_sistem.Text = CollAna[0].BildirimGelenYer;

            txt_dava_ad_soyad.Text = CollAna[0].BildirimDavaAdSoyad;
            txt_dava_dosya_no.Text = CollAna[0].BildirimDavaDosyaNo;
            txt_dava_konu.Text = CollAna[0].BildirimDavaKonu;
            txt_dava_mahkeme_adi.Text = CollAna[0].BildirimDavaMahkeme;

            BildirimTuruCollection CollBt = new BildirimTuruCollection();
            IPredicateExpression ExpBt = new PredicateExpression();
            ExpBt.AddWithAnd(BildirimTuruFields.BildirimTuruId == CollAna[0].FkBildirimTuruId);
            CollBt.GetMulti(ExpBt);

            cb_tur.Text = CollBt[0].BildirimTuruAd;

            BildirimGeriDonuCollection CollGeri = new BildirimGeriDonuCollection();
            IPredicateExpression ExpGeri = new PredicateExpression();
            ExpGeri.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusId == CollAna[0].FkBildirimGeriDonusId);
            CollGeri.GetMulti(ExpGeri);

            cb_sekil.Text = CollGeri[0].BildirimGeriDonusAd;

            AltKonuCollection CollAlt = new AltKonuCollection();
            IPredicateExpression ExpAlt = new PredicateExpression();
            ExpAlt.AddWithAnd(AltKonuFields.AltKonuId == CollAna[0].FkAltKonuId);
            CollAlt.GetMulti(ExpAlt);

            cb_konu.Text = CollAlt[0].AltKonuAd;

            txt_not.Text = CollAna[0].BildirimMetin;

            int kac_say = 0;

            for (int i = 0; i < cb_grup_list.Items.Count; i++)
            {
                GrupCollection CollBey = new GrupCollection();
                IPredicateExpression ExpBey = new PredicateExpression();
                ExpBey.AddWithAnd(GrupFields.GrupAd == cb_grup_list.Items[i].Text);
                CollBey.GetMulti(ExpBey);

                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollAna[0].BildirimId);
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkGrupId == CollBey[0].GrupId);
                CollGr.GetMulti(ExpGr);

                if (CollGr.Count > 0)
                {
                    cb_grup_list.Items[i].Selected = true;

                    kac_say = kac_say + 1;
                }

                else
                {
                    cb_grup_list.Items[i].Selected = false;
                }
            }

            for (int i = 0; i < cb_per_list.Items.Count; i++)
            {
                KullaniciCollection CollBey = new KullaniciCollection();
                IPredicateExpression ExpBey = new PredicateExpression();
                ExpBey.AddWithAnd(KullaniciFields.KullaniciAdSoyad == cb_per_list.Items[i].Text);
                CollBey.GetMulti(ExpBey);

                BildirimAtamaKullaniciCollection CollGr = new BildirimAtamaKullaniciCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaKullaniciFields.FkBildirimId == CollAna[0].BildirimId);
                ExpGr.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == CollBey[0].KullaniciId);
                CollGr.GetMulti(ExpGr);

                if (CollGr.Count > 0)
                {
                    cb_per_list.Items[i].Selected = true;

                    kac_say = kac_say + 1;
                }

                else
                {
                    cb_per_list.Items[i].Selected = false;
                }
            }

            BildirimSonucCollection CollSonuc = new BildirimSonucCollection();
            IPredicateExpression ExpSonuc = new PredicateExpression();
            ExpSonuc.AddWithAnd(BildirimSonucFields.BildirimSonucId == CollAna[0].FkBildirimSonucId);
            CollSonuc.GetMulti(ExpSonuc);

            if (CollSonuc[0].BildirimSonucAd.ToString() == "Atandı" || CollSonuc[0].BildirimSonucAd.ToString() == "Kayıt Altına Alındı")
            {
                pnl_ata.Enabled = true;
                Session["gnc_turu"] = "Ekstra";
                cb_kapat.Enabled = true;
            }

            else 
            {
                pnl_ata.Enabled = false;
                Session["gnc_turu"] = "No Update";
                cb_kapat.Enabled = false;
            }

            Session["say_kac"] = kac_say.ToString();

            if (kac_say > 0)
            {
                cb_kapat.Checked = false;
            }

            else 
            {
                cb_kapat.Checked = true;
            }

            Panel5.Enabled = true;
            Panel4.Enabled = true;

            cb_tur.Focus();
        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_tel_no.Text == "" && txt_mail.Text == "")
            {
                string CloseWindow;
                CloseWindow = "alert('Telefon Numarası ya da Mail Adresi giriniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                txt_tel_no.Focus();
            }

            else 
            {
                int say_grup = 0;
                int say_kul = 0;

                for (int i = 0; i < cb_grup_list.Items.Count; i++)
                {
                    if (cb_grup_list.Items[i].Selected == true)
                    {
                        say_grup = say_grup + 1;
                    }
                }

                for (int i = 0; i < cb_per_list.Items.Count; i++)
                {
                    if (cb_per_list.Items[i].Selected == true)
                    {
                        say_kul = say_kul + 1;
                    }
                }

                if ((cb_tur.Text == "Bilgi Talebi" || cb_tur.Text == "Şikayet" || cb_tur.Text == "Dava Bildirimi") && (say_kul == 0 && cb_kapat.Checked == false))
                {
                    string CloseWindow;
                    CloseWindow = "alert('Lütfen atanacak en az 1 (bir) kullanıcı seçiniz...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                    cb_kapat.Focus();
                }

                else
                {                    
                    if (cb_cag_tip.Text == "")
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Lütfen geçerli bir çağrı tipi giriniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        cb_cag_tip.Focus();
                    }

                    else
                    {
                        int mail_test = 0;

                        if (txt_mail.Text == "")
                        {
                            mail_test = 1;
                        }

                        if (txt_mail.Text != "" || txt_mail.Text.Length < 5)
                        {
                            for (int i = 0; i < txt_mail.Text.Length; i++)
                            {
                                if (txt_mail.Text[i].ToString() == "@")
                                {
                                    mail_test = 1;
                                }
                            }
                        }

                        else
                        {
                            mail_test = 1;
                        }

                        if (mail_test == 0)
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Lütfen geçerli bir mail adresi giriniz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            txt_mail.Focus();
                        }

                        else 
                        {
                            //vatandaş yok
                            if (Session["vat_id"] == null)
                            {
                                Int64 kullan_idsi = 0;

                                if (cb_kayit_tur.Text == "" || txt_ad.Text == "" || cb_cag_tip.Text == "")
                                {
                                    string CloseWindow;
                                    CloseWindow = "alert('Kayıt Türü, Ad ve Çağrı Tipi alanlarını kontrol ediniz...')";
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                    if (cb_kayit_tur.Text == "")
                                    {
                                        cb_kayit_tur.Focus();
                                    }

                                    else if (txt_ad.Text == "")
                                    {
                                        txt_ad.Focus();
                                    }

                                    else if (cb_cag_tip.Text == "")
                                    {
                                        cb_cag_tip.Focus();
                                    }

                                    else if (cb_cag_tip.NullText == "Seçiniz...")
                                    {
                                        cb_cag_tip.Focus();
                                    }
                                }

                                else
                                {
                                    //gerçek kişi//ommo
                                    if (cb_kayit_tur.Text == "Gerçek Kişi" || cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
                                    {
                                        if (txt_soyad.Text == "" || cb_cinsiyet.Text == "" || cb_cinsiyet.Text == "Seçiniz..." || txt_uyruk.Text == "")
                                        {
                                            string CloseWindow;
                                            CloseWindow = "alert('Soyad, Cinsiyet ve Uyruk alanlarını kontrol ediniz...')";
                                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                            if (txt_soyad.Text == "")
                                            {
                                                txt_soyad.Focus();
                                            }

                                            else if (txt_uyruk.Text == "")
                                            {
                                                txt_uyruk.Focus();
                                            }

                                            else
                                            {
                                                cb_cinsiyet.Focus();
                                            }
                                        }

                                        else
                                        {
                                            VatandaCollection CollVat = new VatandaCollection();
                                            IPredicateExpression ExpVat = new PredicateExpression();

                                            if (txt_tc_no.Text == "")
                                            {
                                                ExpVat.AddWithAnd(VatandaFields.VatandasTcNo == "11111111111");
                                            }

                                            else
                                            {
                                                ExpVat.AddWithAnd(VatandaFields.VatandasTcNo == txt_tc_no.Text);
                                            }

                                            CollVat.GetMulti(ExpVat);

                                            string telde = "";

                                            if (txt_tel_no.Text == "")
                                            {
                                                telde = "abc";
                                            }

                                            else
                                            {
                                                telde = txt_tel_no.Text.Trim().Replace(" ", string.Empty);
                                            }

                                            VatandaCollection CollVat2 = new VatandaCollection();
                                            IPredicateExpression ExpVat2 = new PredicateExpression();
                                            ExpVat2.AddWithAnd(VatandaFields.VatandasTel1 == telde);
                                            CollVat2.GetMulti(ExpVat2);

                                            VatandaCollection CollVat3 = new VatandaCollection();
                                            IPredicateExpression ExpVat3 = new PredicateExpression();
                                            ExpVat3.AddWithAnd(VatandaFields.VatandasMail == txt_mail.Text);
                                            CollVat3.GetMulti(ExpVat3);

                                            int mail_count = 0;
                                            int tel_count = 0;

                                            if (txt_mail.Text == "")
                                            {
                                                mail_count = 0;
                                            }

                                            else
                                            {
                                                mail_count = CollVat3.Count;
                                            }

                                            if (txt_tel_no.Text == "")
                                            {
                                                tel_count = 0;
                                            }

                                            else
                                            {
                                                tel_count = CollVat2.Count;
                                            }

                                            if (CollVat.Count > 0 || tel_count > 0 || mail_count > 0)
                                            {
                                                if (CollVat.Count > 0)
                                                {
                                                    string CloseWindow;
                                                    CloseWindow = "alert('TC Kimlik Numarası sistemde kayıtlıdır...')";
                                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                                    txt_tc_no.Focus();
                                                }

                                                else if (CollVat2.Count > 0)
                                                {
                                                    string CloseWindow;
                                                    CloseWindow = "alert('Telefon Numarası sistemde kayıtlıdır...')";
                                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                                    txt_tel_no.Focus();
                                                }

                                                else if (CollVat3.Count > 0)
                                                {
                                                    string CloseWindow;
                                                    CloseWindow = "alert('Mail Adresi sistemde kayıtlıdır...')";
                                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                                    txt_mail.Focus();
                                                }
                                            }

                                            else
                                            {
                                                string telli = "";

                                                if (txt_tel_no.Text == "")
                                                {
                                                    telli = "319838929832398239823";
                                                }

                                                else
                                                {
                                                    telli = txt_tel_no.Text.Trim().Replace(" ", string.Empty);
                                                }

                                                int dene = 0;
                                                int topla = 0;
                                                string basla = telli[0].ToString();

                                                try
                                                {
                                                    for (int i = 0; i < telli.Length; i++)
                                                    {
                                                        topla = topla + Convert.ToInt16(telli[i].ToString());

                                                        if (telli[i].ToString() == basla)
                                                        {
                                                            dene = dene + 1;
                                                        }
                                                    }
                                                }

                                                catch 
                                                {
                                                    dene = 100;
                                                }                                                

                                                if (dene == telli.Length || topla < 4)
                                                {
                                                    string CloseWindow;
                                                    CloseWindow = "alert('Telefon Numarası hatalıdır...')";
                                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                                    txt_tel_no.Focus();
                                                }

                                                else
                                                {
                                                    VatandaEntity EntKay = new VatandaEntity();
                                                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                                    EntKay.VatandasAd = txt_ad.Text.ToUpper();
                                                    EntKay.VatandasAdres = txt_adres.Text;
                                                    EntKay.VatandasTur = cb_kayit_tur.Text;
                                                    EntKay.VatandasIslemTarih = DateTime.Now;

                                                    if (cb_kayit_tur.Text == "Gerçek Kişi")
                                                    {
                                                        EntKay.VatandasSoyad = txt_soyad.Text.ToUpper();
                                                        EntKay.VatandasAdSoyad = txt_ad.Text.ToUpper() + " " + txt_soyad.Text.ToUpper();
                                                        EntKay.VatandasCinsiyet = cb_cinsiyet.Text;

                                                        if (txt_dogum_tarihi.Text != "01.01.1900")
                                                        {
                                                            EntKay.VatandasDogumTarihi = Convert.ToDateTime(txt_dogum_tarihi.Text);
                                                        }

                                                        EntKay.VatandasTcNo = txt_tc_no.Text;
                                                    }

                                                    else
                                                    {
                                                        EntKay.VatandasAdSoyad = txt_ad.Text.ToUpper() + " " + txt_soyad.Text.ToUpper();
                                                    }

                                                    EntKay.VatandasMail = txt_mail.Text;
                                                    EntKay.VatandasTel1 = txt_tel_no.Text.Trim().Replace(" ", string.Empty);
                                                    EntKay.VatandasUyruk = txt_uyruk.Text;
                                                    EntKay.VatandasPasaportNo = txt_pasaport.Text;

                                                    EntKay.Save();

                                                    VatandaCollection CollBul = new VatandaCollection();
                                                    IPredicateExpression ExpBul = new PredicateExpression();
                                                    ExpBul.AddWithAnd(VatandaFields.VatandasTel1 == txt_tel_no.Text.Trim().Replace(" ", string.Empty));

                                                    if (txt_mail.Text != "")
                                                    {
                                                        ExpBul.AddWithAnd(VatandaFields.VatandasMail == txt_mail.Text);
                                                    }

                                                    if (txt_tc_no.Text != "")
                                                    {
                                                        ExpBul.AddWithAnd(VatandaFields.VatandasTcNo == txt_tc_no.Text);
                                                    }

                                                    if (cb_kayit_tur.Text == "Gerçek Kişi" || cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
                                                    {
                                                        ExpBul.AddWithAnd(VatandaFields.VatandasAdSoyad == txt_ad.Text.ToUpper() + " " + txt_soyad.Text.ToUpper());
                                                    }

                                                    else
                                                    {
                                                        ExpBul.AddWithAnd(VatandaFields.VatandasAdSoyad == txt_ad.Text.ToUpper());
                                                    }

                                                    CollBul.GetMulti(ExpBul);

                                                    kullan_idsi = CollBul[0].VatandasId;
                                                    Session["vat_id"] = kullan_idsi.ToString();

                                                    KullaniciCollection CollKul = new KullaniciCollection();
                                                    IPredicateExpression ExpKul = new PredicateExpression();
                                                    ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                                                    CollKul.GetMulti(ExpKul);

                                                    VatandasArsivEntity EntAr = new VatandasArsivEntity();
                                                    EntAr.FkVatandasId = CollBul[0].VatandasId;
                                                    EntAr.VatandasArsivIslemTarih = DateTime.Now;
                                                    EntAr.VatandasArsivAciklama = CollKul[0].KullaniciAdSoyad + " tarafından kayıt altına alındı.";
                                                    EntAr.Save();

                                                    /*
                                                    txt_tc_no.Text = "";
                                                    txt_tc_no.Enabled = true;
                                                    btn_kps.Enabled = true;
                                                    txt_ad.Text = "";
                                                    txt_soyad.Text = "";
                                                    txt_soyad.Enabled = true;
                                                    cb_cinsiyet.Text = "";
                                                    cb_cinsiyet.NullText = "Seçiniz...";
                                                    string hexValue2 = "#FFFFFF";
                                                    txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                                    txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                                    cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                                    txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);

                                                    cb_cinsiyet.Enabled = true;
                                                    txt_dogum_tarihi.Text = "01.01.1900";
                                                    txt_dogum_tarihi.Enabled = true;                                                                                             
                                                    txt_adres.Text = "";
                                                    txt_pasaport.Text = "";
                                                    txt_vergi_no.Text = "";
                                                    txt_uyruk.Text = "";*/

                                                    KullaniciCollection CollKul22 = new KullaniciCollection();
                                                    IPredicateExpression ExpKul22 = new PredicateExpression();
                                                    ExpKul22.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                                                    CollKul22.GetMulti(ExpKul22);

                                                    BildirimTuruCollection CollTur = new BildirimTuruCollection();
                                                    IPredicateExpression ExpTur = new PredicateExpression();
                                                    ExpTur.AddWithAnd(BildirimTuruFields.BildirimTuruAd == cb_tur.Text);
                                                    CollTur.GetMulti(ExpTur);

                                                    BildirimSonucCollection CollSonAta = new BildirimSonucCollection();
                                                    IPredicateExpression ExpSonAta = new PredicateExpression();
                                                    ExpSonAta.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                                                    CollSonAta.GetMulti(ExpSonAta);

                                                    BildirimSonucCollection CollSonKay = new BildirimSonucCollection();
                                                    IPredicateExpression ExpSonKay = new PredicateExpression();
                                                    ExpSonKay.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Kayıt Altına Alındı");
                                                    CollSonKay.GetMulti(ExpSonKay);

                                                    BildirimSonucCollection CollBit = new BildirimSonucCollection();
                                                    IPredicateExpression ExpBit = new PredicateExpression();
                                                    ExpBit.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Sonuçlandı");
                                                    CollBit.GetMulti(ExpBit);

                                                    BildirimGeriDonuCollection CollGeri = new BildirimGeriDonuCollection();
                                                    IPredicateExpression ExpGeri = new PredicateExpression();
                                                    ExpGeri.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusAd == cb_sekil.Text);
                                                    CollGeri.GetMulti(ExpGeri);

                                                    AltKonuCollection CollAlt = new AltKonuCollection();
                                                    IPredicateExpression ExpAlt = new PredicateExpression();

                                                    if (cb_konu.Text != "")
                                                    {
                                                        ExpAlt.AddWithAnd(AltKonuFields.AltKonuAd == cb_konu.Text);
                                                    }

                                                    else
                                                    {
                                                        ExpAlt.AddWithAnd(AltKonuFields.AltKonuAd == "Diğer");
                                                    }

                                                    CollAlt.GetMulti(ExpAlt);

                                                    KonuCollection CollKon = new KonuCollection();
                                                    IPredicateExpression ExpKon = new PredicateExpression();
                                                    ExpKon.AddWithAnd(KonuFields.KonuId == CollAlt[0].FkKonuId);
                                                    CollKon.GetMulti(ExpKon);

                                                    if (Session["par_guncelle_mi"].ToString() == "0")
                                                    {
                                                        BildirimEntity EntKayy = new BildirimEntity();

                                                        CagriTipiCollection CollTit = new CagriTipiCollection();
                                                        IPredicateExpression ExpTit = new PredicateExpression();
                                                        ExpTit.AddWithAnd(CagriTipiFields.CagriTipiAd == cb_cag_tip.Text);
                                                        CollTit.GetMulti(ExpTit);

                                                        EntKayy.FkCagriTipiId = CollTit[0].CagriTipiId;

                                                        if (cb_havalimani.Text == "" || cb_havalimani.NullText == "Seçiniz...")
                                                        {
                                                            EntKayy.BildirimHavalimani = cb_havalimani.Text;
                                                        }

                                                        EntKayy.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                                        EntKayy.BildirimGeriYapildiMi = false;
                                                        EntKayy.FkVatandasId = Convert.ToInt64(Session["vat_id"].ToString());
                                                        EntKayy.FkBildirimTuruId = CollTur[0].BildirimTuruId;

                                                        if (cb_kapat.Checked == true)
                                                        {
                                                            EntKayy.FkBildirimSonucId = CollBit[0].BildirimSonucId;
                                                            EntKayy.BildirimAtanmaDurumu = "Bilgi verildi-Kapatıldı.";
                                                            EntKayy.BildirimVatandasKarar = txt_not.Text;
                                                        }

                                                        else
                                                        {
                                                            if (say_grup == 0 && say_kul == 0)
                                                            {
                                                                EntKayy.FkBildirimSonucId = CollSonKay[0].BildirimSonucId;
                                                                EntKayy.BildirimAtanmaDurumu = "Atama yapılmadı.";
                                                            }

                                                            else
                                                            {
                                                                EntKayy.FkBildirimSonucId = CollSonAta[0].BildirimSonucId;

                                                                if (say_grup == 0)
                                                                {
                                                                    EntKayy.BildirimAtanmaDurumu = say_kul.ToString() + " kullanıcıya atandı.";
                                                                }

                                                                else
                                                                {
                                                                    if (say_grup == 1)
                                                                    {
                                                                        string gr_adi = "";

                                                                        for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                                                        {
                                                                            if (cb_grup_list.Items[i].Selected == true)
                                                                            {
                                                                                gr_adi = cb_grup_list.Items[i].Text;
                                                                            }
                                                                        }

                                                                        EntKayy.BildirimAtanmaDurumu = gr_adi.ToUpper() + "-" + say_grup.ToString() + " grup, " + say_kul.ToString() + " kullanıcıya atandı.";
                                                                    }

                                                                    else
                                                                    {
                                                                        EntKayy.BildirimAtanmaDurumu = "BİRKAÇ GRUP-" + say_grup.ToString() + " grup, " + say_kul.ToString() + " kullanıcıya atandı.";
                                                                    }
                                                                }
                                                            }
                                                        }

                                                        if (CollGeri.Count > 0)
                                                        {
                                                            EntKayy.FkBildirimGeriDonusId = CollGeri[0].BildirimGeriDonusId;
                                                        }

                                                        else
                                                        {
                                                            BildirimGeriDonuCollection CollDon = new BildirimGeriDonuCollection();
                                                            IPredicateExpression ExpDon = new PredicateExpression();
                                                            ExpDon.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusAd == "Hiçbiri");
                                                            CollDon.GetMulti(ExpDon);

                                                            EntKayy.FkBildirimGeriDonusId = CollDon[0].BildirimGeriDonusId;
                                                        }

                                                        EntKayy.FkAltKonuId = CollAlt[0].AltKonuId;
                                                        EntKayy.BildirimGelenYer = cb_sistem.Text;

                                                        EntKayy.BildirimTarih = DateTime.Now;
                                                        EntKayy.BildirimSonIslemTarih = DateTime.Now;

                                                        DateTime bas_tar_al = DateTime.Now;

                                                        string tar_yil = DateTime.Now.Year.ToString();

                                                        EntKayy.BildirimYil = Convert.ToInt16(tar_yil);
                                                        EntKayy.BildirimMetin = txt_not.Text;

                                                        if (txt_kisisel_measj.Text != "")
                                                        {
                                                            EntKayy.BildirimAciklama = CollKul22[0].KullaniciAdSoyad + " - '" + txt_kisisel_measj.Text + "'.";
                                                        }

                                                        if (cb_tur.Text == "Dava Bildirimi")
                                                        {
                                                            EntKayy.BildirimDavaAdSoyad = txt_dava_ad_soyad.Text;
                                                            EntKayy.BildirimDavaDosyaNo = txt_dava_dosya_no.Text;
                                                            EntKayy.BildirimDavaKonu = txt_dava_konu.Text;
                                                            EntKayy.BildirimDavaMahkeme = txt_dava_mahkeme_adi.Text;
                                                        }

                                                        if (cb_kapat.Checked == true)
                                                        {
                                                            VatandaCollection CollVatt = new VatandaCollection();
                                                            IPredicateExpression ExpVatt = new PredicateExpression();
                                                            ExpVatt.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                                                            CollVatt.GetMulti(ExpVatt);

                                                            TimeSpan fark_bak1 = DateTime.Now - CollVatt[0].VatandasIslemTarih;
                                                            string duzle = (fark_bak1.TotalHours).ToString();
                                                            double arasi = Convert.ToDouble(duzle);
                                                            Int16 ana_fark = Convert.ToInt16(arasi);
                                                            Int16 saat = 0;
                                                            Int16 gun = 0;
                                                            Int16 ay = 0;
                                                            Int16 yil = 0;

                                                            string fark_olustur = "";

                                                            if (ana_fark > 168)
                                                            {
                                                                ana_fark = 1;
                                                            }

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

                                                            if (cb_kapat.Checked == true)
                                                            {
                                                                EntKayy.BildirimToplamSure = "5 Dakika";
                                                            }

                                                            else
                                                            {
                                                                EntKayy.BildirimToplamSure = fark_olustur;
                                                            }
                                                        }

                                                        else
                                                        {
                                                            EntKayy.BildirimToplamSure = "-";
                                                        }

                                                        EntKayy.Save();

                                                        string icerik = txt_not.Text;

                                                        BildirimCollection CollArra = new BildirimCollection();
                                                        IPredicateExpression ExpArra = new PredicateExpression();
                                                        ExpArra.AddWithAnd(BildirimFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                                                        ExpArra.AddWithAnd(BildirimFields.FkVatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                                                        ExpArra.AddWithAnd(BildirimFields.FkAltKonuId == CollAlt[0].AltKonuId);
                                                        ExpArra.AddWithAnd(BildirimFields.BildirimSonIslemTarih == bas_tar_al);
                                                        CollArra.GetMulti(ExpArra);

                                                        Int64 numarasi = CollArra[0].BildirimId;

                                                        string CloseWindow2;
                                                        CloseWindow2 = "alert('Kayıt işlemi tamamlanmıştır...')";
                                                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow2", CloseWindow2, true);

                                                        if (Session["file_path_1"] != null)
                                                        {
                                                            DosyaEntity EntDos = new DosyaEntity();
                                                            EntDos.DosyaBildirimi = numarasi;
                                                            EntDos.DosyaIcerikDurum = "1";
                                                            EntDos.DosyaIcerikPath = Session["file_path_1"].ToString();
                                                            EntDos.DosyaIcerikTarih = DateTime.Now;
                                                            EntDos.Save();
                                                        }

                                                        if (Session["file_path_2"] != null)
                                                        {
                                                            DosyaEntity EntDos = new DosyaEntity();
                                                            EntDos.DosyaBildirimi = numarasi;
                                                            EntDos.DosyaIcerikDurum = "1";
                                                            EntDos.DosyaIcerikPath = Session["file_path_2"].ToString();
                                                            EntDos.DosyaIcerikTarih = DateTime.Now;
                                                            EntDos.Save();
                                                        }

                                                        if (Session["file_path_3"] != null)
                                                        {
                                                            DosyaEntity EntDos = new DosyaEntity();
                                                            EntDos.DosyaBildirimi = numarasi;
                                                            EntDos.DosyaIcerikDurum = "1";
                                                            EntDos.DosyaIcerikPath = Session["file_path_3"].ToString();
                                                            EntDos.DosyaIcerikTarih = DateTime.Now;
                                                            EntDos.Save();
                                                        }

                                                        Panel4.Enabled = false;
                                                        Panel5.Enabled = false;

                                                        BildirimTuruCollection CollBilTur = new BildirimTuruCollection();
                                                        IPredicateExpression ExpBilTur = new PredicateExpression();
                                                        ExpBilTur.AddWithAnd(BildirimTuruFields.BildirimTuruAd == cb_tur.Text);
                                                        CollBilTur.GetMulti(ExpBilTur);

                                                        if (CollBilTur[0].BildirimTuruMail == true && cb_kapat.Checked == false && cb_sekil.Text == "E-Posta")
                                                        {
                                                            string konusu = "DHMİ İletişim Merkezi Bildirim Talebi";
                                                            string maili = txt_mail.Text;
                                                            string bil_git = numarasi.ToString();

                                                            if (txt_mail.Text != "")
                                                            {
                                                                if (cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
                                                                {
                                                                    Mail.MailGonderBildirimEng(maili, "General Directorate Of State Airports Authority (DHMI) Call Center", bil_git);
                                                                }

                                                                else
                                                                {
                                                                    Mail.MailGonderBildirim(maili, konusu, bil_git);
                                                                }
                                                            }
                                                        }

                                                        if (CollBilTur[0].BildirimTuruSms == true && cb_kapat.Checked == false && cb_sekil.Text == "SMS")
                                                        {
                                                            if (txt_tel_no.Text != "")
                                                            {
                                                                //SMSGonder
                                                                try
                                                                {
                                                                    string gsmNo = txt_tel_no.Text.Trim().Replace(" ", string.Empty);
                                                                    gsmNo = gsmNo.TrimStart('0');
                                                                    Int32 bildirim_nosu = Convert.ToInt32(numarasi);

                                                                    if (cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
                                                                    {
                                                                        string smsMessage = string.Format(ConfigurationManager.AppSettings["SmsNewRecordContentEng"], bildirim_nosu);
                                                                        Helper.SendSms(gsmNo, smsMessage, bildirim_nosu);
                                                                    }

                                                                    else
                                                                    {
                                                                        string smsMessage = string.Format(ConfigurationManager.AppSettings["SmsNewRecordContent"], bildirim_nosu);
                                                                        Helper.SendSms(gsmNo, smsMessage, bildirim_nosu);
                                                                    }
                                                                }

                                                                catch
                                                                {
                                                                    //Telefon Numarasında Sorun Varsa Direkt Geç...
                                                                }
                                                            }
                                                        }

                                                        /*
                                                        cb_kayit_tur.Text = "";
                                                        cb_kayit_tur.NullText = "Seçiniz...";
                                                        txt_tc_no.Text = "";
                                                        btn_kps.Enabled = false; ;
                                                        txt_ad.Text = "";
                                                        txt_soyad.Text = "";
                                                        cb_cinsiyet.Text = "";
                                                        cb_cinsiyet.NullText = "Seçiniz...";
                                                        string hexValue22 = "#FFFFFF";
                                                        txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue22);
                                                        txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue22);
                                                        cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue22);
                                                        txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue22);
                                                        txt_dogum_tarihi.Text = "01.01.1900";
                                                        txt_tel_no.Text = "";
                                                        txt_mail.Text = "";
                                                        txt_adres.Text = "";
                                                        txt_pasaport.Text = "";
                                                        txt_vergi_no.Text = "";
                                                        txt_uyruk.Text = "";*/

                                                        BildirimIslemCollection CollIs = new BildirimIslemCollection();
                                                        IPredicateExpression ExpIs = new PredicateExpression();
                                                        ExpIs.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "Kayıt Altına Alındı");
                                                        CollIs.GetMulti(ExpIs);

                                                        BildirimCollection CollKac = new BildirimCollection();
                                                        IPredicateExpression ExpKac = new PredicateExpression();
                                                        ExpKac.AddWithAnd(BildirimFields.BildirimId == numarasi);
                                                        CollKac.GetMulti(ExpKac);

                                                        BildirimHistoryEntity EntHis = new BildirimHistoryEntity();
                                                        EntHis.FkBildirimId = CollKac[0].BildirimId;
                                                        EntHis.FkBildirimIslemId = CollIs[0].BildirimIslemId;
                                                        EntHis.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                                        EntHis.BildirimHistoryTarih = DateTime.Now;
                                                        EntHis.BildirimHistorySure = "0";
                                                        EntHis.BildirimHistoryAciklama = CollKul22[0].KullaniciAdSoyad + " tarafından kayıt altına alındı.";
                                                        EntHis.Save();

                                                        if (say_grup != 0 || say_kul != 0)
                                                        {
                                                            string bas_ad = "";

                                                            for (int i = 0; i < cb_per_list.Items.Count; i++)
                                                            {
                                                                if (cb_per_list.Items[i].Selected == true)
                                                                {
                                                                    KullaniciCollection CollKim = new KullaniciCollection();
                                                                    IPredicateExpression ExpKim = new PredicateExpression();
                                                                    ExpKim.AddWithAnd(KullaniciFields.KullaniciAdSoyad == cb_per_list.Items[i].Text);
                                                                    CollKim.GetMulti(ExpKim);

                                                                    BildirimAtamaKullaniciEntity EntAta = new BildirimAtamaKullaniciEntity();
                                                                    EntAta.FkBildirimId = CollKac[0].BildirimId;
                                                                    EntAta.FkKullaniciId = CollKim[0].KullaniciId;
                                                                    EntAta.BildirimAtamaKullaniciBittiMi = false;
                                                                    EntAta.BildirimAtamaKullaniciTarih = DateTime.Now;
                                                                    EntAta.BildirimAtamaKullaniciYonMu = "Hayır";
                                                                    EntAta.Save();

                                                                    try
                                                                    {
                                                                        string konusu = "DHMİ İletişim Merkezi Bildirim Talebi";
                                                                        string maili = CollKim[0].KullaniciMail;
                                                                        string bsl = "www.alo.dhmi.gov.tr/McCallCenterLinkControlAsLogin.aspx?";
                                                                        string bas_coz = "dhmi";
                                                                        string bit_coz = "callcenter";
                                                                        string dhmi_bas = Kullanici.sifre_olustur(bas_coz);
                                                                        string dhmi_bit = Kullanici.sifre_olustur(bit_coz);
                                                                        string aradaki_kul = CollKim[0].KullaniciId.ToString();
                                                                        aradaki_kul = Kullanici.sifre_olustur(aradaki_kul);
                                                                        string linki = dhmi_bas + aradaki_kul + dhmi_bit;

                                                                        string kayit_link = bsl + linki;

                                                                        Mail.MailLinkGonder(CollKac[0].BildirimId.ToString(), linki, maili, konusu, icerik);

                                                                        MailBankEntity EntBan = new MailBankEntity();
                                                                        EntBan.MailBanksLink = kayit_link;
                                                                        EntBan.MailBanksBildirim = CollKac[0].BildirimId;
                                                                        EntBan.MailBanksKullanici = CollKim[0].KullaniciId;
                                                                        EntBan.MailBanksTikAdet = 0;
                                                                        EntBan.MailBanksTarih = DateTime.Now;
                                                                        EntBan.MailBanksDurum = true;
                                                                        EntBan.Save();
                                                                    }

                                                                    catch
                                                                    {
                                                                        //Mail Adresinde Sorun Varsa Direkt Geç...
                                                                    }

                                                                    if (bas_ad == "")
                                                                    {
                                                                        bas_ad = bas_ad + CollKim[0].KullaniciAdSoyad;
                                                                    }

                                                                    else
                                                                    {
                                                                        bas_ad = bas_ad + ", " + CollKim[0].KullaniciAdSoyad;
                                                                    }
                                                                }
                                                            }

                                                            for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                                            {
                                                                if (cb_grup_list.Items[i].Selected == true)
                                                                {
                                                                    GrupCollection CollGr = new GrupCollection();
                                                                    IPredicateExpression ExpGr = new PredicateExpression();
                                                                    ExpGr.AddWithAnd(GrupFields.GrupAd == cb_grup_list.Items[i].Text);
                                                                    CollGr.GetMulti(ExpGr);

                                                                    BildirimAtamaGrupEntity EntAta = new BildirimAtamaGrupEntity();
                                                                    EntAta.FkBildirimId = CollKac[0].BildirimId;
                                                                    EntAta.FkGrupId = CollGr[0].GrupId;
                                                                    EntAta.BildirimAtamaGrupTarih = DateTime.Now;
                                                                    EntAta.BildirimAtamaGrupYonMu = "Hayır";
                                                                    EntAta.Save();
                                                                }
                                                            }

                                                            BildirimIslemCollection CollIs2 = new BildirimIslemCollection();
                                                            IPredicateExpression ExpIs2 = new PredicateExpression();
                                                            ExpIs2.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "Kullanıcı/Grup Ataması Yapıldı");
                                                            CollIs2.GetMulti(ExpIs2);

                                                            BildirimHistoryEntity EntHis2 = new BildirimHistoryEntity();
                                                            EntHis2.FkBildirimId = CollKac[0].BildirimId;
                                                            EntHis2.FkBildirimIslemId = CollIs2[0].BildirimIslemId;
                                                            EntHis2.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                                            EntHis2.BildirimHistoryTarih = DateTime.Now;
                                                            EntHis2.BildirimHistorySure = "0";
                                                            EntHis2.BildirimHistoryAciklama = CollKul22[0].KullaniciAdSoyad + " tarafından bildirim " + bas_ad + "'e/a atandı.";
                                                            EntHis2.Save();

                                                            SureTakipEntity EntSure = new SureTakipEntity();
                                                            EntSure.FkBildirimId = CollKac[0].BildirimId;
                                                            EntSure.SureTakipTuru = "Kayıtta Bekleme Süresi";
                                                            EntSure.SureTakipTarih = DateTime.Now;
                                                            EntSure.SureTakipSaat = 0;
                                                            EntSure.SureTakipGun = 0;
                                                            EntSure.Save();
                                                        }

                                                        ParametreCollection CollPrm = new ParametreCollection();
                                                        IPredicateExpression ExpPrm = new PredicateExpression();
                                                        ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
                                                        CollPrm.GetMulti(ExpPrm);

                                                        DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

                                                        ListBildirimTypedList bil_list = new ListBildirimTypedList();
                                                        ISortExpression sort22 = new SortExpression();
                                                        sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                                                        IPredicateExpression filter2 = new PredicateExpression();
                                                        filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                                                        bil_list.Fill(0, sort22, true, filter2);

                                                        grid_bildirim.DataSource = bil_list;
                                                        grid_bildirim.DataBind();                                                      

                                                        grid_bildirim_sil.DataSource = bil_list;
                                                        grid_bildirim_sil.DataBind();                                                       

                                                        txt_kisisel_measj.Text = "";
                                                        cb_havalimani.Text = "";
                                                        cb_havalimani.NullText = "Seçiniz...";
                                                        pnl_sorgu.Visible = false;
                                                        cb_tur.Text = "";
                                                        cb_tur.NullText = "Seçiniz...";
                                                        cb_sekil.Text = "";
                                                        cb_sekil.NullText = "Seçiniz...";
                                                        btn_yukle.Enabled = false;
                                                        cb_konu.Text = "";
                                                        cb_konu.NullText = "Seçiniz...";
                                                        txt_not.Text = "";
                                                        txt_dava_ad_soyad.Text = "";
                                                        txt_dava_dosya_no.Text = "";
                                                        txt_dava_konu.Text = "";
                                                        txt_dava_mahkeme_adi.Text = "";
                                                        cb_cag_tip.Text = "";
                                                        cb_cag_tip.NullText = "Seçiniz...";
                                                        cb_kapat.Checked = false;
                                                        cb_kayit_tur.Text = "";
                                                        cb_kayit_tur.NullText = "Seçiniz...";
                                                        txt_tc_no.Text = "";
                                                        btn_kps.Enabled = false; ;
                                                        txt_ad.Text = "";
                                                        txt_soyad.Text = "";
                                                        cb_cinsiyet.Text = "";
                                                        cb_cinsiyet.NullText = "Seçiniz...";
                                                        string hexValue222 = "#FFFFFF";
                                                        txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue222);
                                                        txt_pasaport.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue222);
                                                        txt_uyruk.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue222);
                                                        txt_ad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue222);
                                                        txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue222);
                                                        cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue222);
                                                        txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue222);
                                                        txt_dogum_tarihi.Text = "01.01.1900";
                                                        txt_tel_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue222);
                                                        txt_mail.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue222);
                                                        txt_adres.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue222);
                                                        txt_tel_no.Text = "";
                                                        txt_mail.Text = "";
                                                        txt_adres.Text = "";
                                                        txt_pasaport.Text = "";
                                                        txt_vergi_no.Text = "";
                                                        txt_uyruk.Text = "";

                                                        for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                                        {
                                                            cb_grup_list.Items[i].Selected = false;
                                                        }

                                                        for (int i = 0; i < cb_per_list.Items.Count; i++)
                                                        {
                                                            cb_per_list.Items[i].Selected = false;
                                                        }

                                                        cb_gr_hep.Checked = false;
                                                        cb_hepsi.Checked = false;
                                                        txt_cagri_sayisi.Text = "";
                                                        btn_gor.Enabled = false;

                                                        Session["vat_id"] = null;

                                                        cb_tur.Focus();
                                                    }

                                                    else
                                                    {
                                                        BildirimCollection CollAna = new BildirimCollection();
                                                        IPredicateExpression ExpAna = new PredicateExpression();
                                                        ExpAna.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserName.Text));
                                                        CollAna.GetMulti(ExpAna);

                                                        if (Session["gnc_turu"].ToString() == "Ekstra")
                                                        {
                                                            BildirimAtamaKullaniciCollection CollSil = new BildirimAtamaKullaniciCollection();
                                                            IPredicateExpression ExpSil = new PredicateExpression();
                                                            ExpSil.AddWithAnd(BildirimAtamaKullaniciFields.FkBildirimId == CollAna[0].BildirimId);
                                                            CollSil.GetMulti(ExpSil);

                                                            for (int i = 0; i < CollSil.Count; i++)
                                                            {
                                                                CollSil[i].Delete();
                                                                CollSil[i].Save();
                                                            }

                                                            BildirimAtamaGrupCollection CollSil2 = new BildirimAtamaGrupCollection();
                                                            IPredicateExpression ExpSil2 = new PredicateExpression();
                                                            ExpSil2.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollAna[0].BildirimId);
                                                            CollSil2.GetMulti(ExpSil2);

                                                            for (int i = 0; i < CollSil2.Count; i++)
                                                            {
                                                                CollSil2[i].Delete();
                                                                CollSil2[i].Save();
                                                            }

                                                            CollAna[0].FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                                            CollAna[0].FkBildirimTuruId = CollTur[0].BildirimTuruId;

                                                            if (cb_kapat.Checked == true)
                                                            {
                                                                CollAna[0].FkBildirimSonucId = CollBit[0].BildirimSonucId;
                                                                CollAna[0].BildirimAtanmaDurumu = "Bilgi verildi-Kapatıldı.";
                                                                CollAna[0].BildirimVatandasKarar = txt_not.Text;
                                                            }

                                                            else
                                                            {
                                                                if (Session["gnc_turu"].ToString() == "Ekstra")
                                                                {
                                                                    if (say_grup == 0 && say_kul == 0)
                                                                    {
                                                                        CollAna[0].FkBildirimSonucId = CollSonKay[0].BildirimSonucId;
                                                                        CollAna[0].BildirimAtanmaDurumu = "Atama yapılmadı.";
                                                                    }

                                                                    else
                                                                    {
                                                                        CollAna[0].FkBildirimSonucId = CollSonAta[0].BildirimSonucId;

                                                                        if (say_grup == 0)
                                                                        {
                                                                            CollAna[0].BildirimAtanmaDurumu = say_kul.ToString() + " kullanıcıya atandı.";
                                                                        }

                                                                        else
                                                                        {
                                                                            if (say_grup == 1)
                                                                            {
                                                                                string gr_adi = "";

                                                                                for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                                                                {
                                                                                    if (cb_grup_list.Items[i].Selected == true)
                                                                                    {
                                                                                        gr_adi = cb_grup_list.Items[i].Text;
                                                                                    }
                                                                                }

                                                                                CollAna[0].BildirimAtanmaDurumu = gr_adi.ToUpper() + "-" + say_grup.ToString() + " grup, " + say_kul.ToString() + " kullanıcıya atandı.";
                                                                            }

                                                                            else
                                                                            {
                                                                                CollAna[0].BildirimAtanmaDurumu = "BİRKAÇ GRUP-" + say_grup.ToString() + " grup, " + say_kul.ToString() + " kullanıcıya atandı.";
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }

                                                        if (CollGeri.Count > 0)
                                                        {
                                                            CollAna[0].FkBildirimGeriDonusId = CollGeri[0].BildirimGeriDonusId;
                                                        }

                                                        else
                                                        {
                                                            BildirimGeriDonuCollection CollDon = new BildirimGeriDonuCollection();
                                                            IPredicateExpression ExpDon = new PredicateExpression();
                                                            ExpDon.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusAd == "Hiçbiri");
                                                            CollDon.GetMulti(ExpDon);

                                                            CollAna[0].FkBildirimGeriDonusId = CollDon[0].BildirimGeriDonusId;
                                                        }

                                                        CollAna[0].FkAltKonuId = CollAlt[0].AltKonuId;                                                        
                                                        CollAna[0].BildirimGelenYer = cb_sistem.Text;

                                                        if (cb_havalimani.Text == "" || cb_havalimani.NullText == "Seçiniz...")
                                                        {
                                                            CollAna[0].BildirimHavalimani = cb_havalimani.Text;
                                                        }

                                                        CollAna[0].BildirimSonIslemTarih = DateTime.Now;
                                                        CollAna[0].BildirimMetin = txt_not.Text;
                                                        CollAna[0].BildirimAciklama = txt_kisisel_measj.Text;

                                                        if (cb_kapat.Checked == true)
                                                        {
                                                            VatandaCollection CollVatt = new VatandaCollection();
                                                            IPredicateExpression ExpVatt = new PredicateExpression();
                                                            ExpVatt.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                                                            CollVatt.GetMulti(ExpVatt);

                                                            TimeSpan fark_bak1 = DateTime.Now - CollVatt[0].VatandasIslemTarih;
                                                            string duzle = (fark_bak1.TotalHours).ToString();
                                                            double arasi = Convert.ToDouble(duzle);
                                                            Int16 ana_fark = Convert.ToInt16(arasi);
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

                                                            CollAna[0].BildirimToplamSure = fark_olustur;
                                                        }

                                                        CollAna[0].Save();

                                                        BildirimIslemCollection CollIs = new BildirimIslemCollection();
                                                        IPredicateExpression ExpIs = new PredicateExpression();
                                                        ExpIs.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "Kayıtları Güncellendi");
                                                        CollIs.GetMulti(ExpIs);

                                                        BildirimHistoryEntity EntHis = new BildirimHistoryEntity();
                                                        EntHis.FkBildirimId = CollAna[0].BildirimId;
                                                        EntHis.FkBildirimIslemId = CollIs[0].BildirimIslemId;
                                                        EntHis.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                                        EntHis.BildirimHistoryTarih = DateTime.Now;
                                                        EntHis.BildirimHistorySure = "0";
                                                        EntHis.BildirimHistoryAciklama = CollKul22[0].KullaniciAdSoyad + " tarafından kayıtları güncellendi.";
                                                        EntHis.Save();

                                                        Session["par_guncelle_mi"] = "0";

                                                        if (Session["gnc_turu"].ToString() == "Ekstra")
                                                        {
                                                            if (say_grup != 0 || say_kul != 0)
                                                            {
                                                                string bas_ad = "";

                                                                for (int i = 0; i < cb_per_list.Items.Count; i++)
                                                                {
                                                                    if (cb_per_list.Items[i].Selected == true)
                                                                    {
                                                                        KullaniciCollection CollKim = new KullaniciCollection();
                                                                        IPredicateExpression ExpKim = new PredicateExpression();
                                                                        ExpKim.AddWithAnd(KullaniciFields.KullaniciAdSoyad == cb_per_list.Items[i].Text);
                                                                        CollKim.GetMulti(ExpKim);

                                                                        BildirimAtamaKullaniciEntity EntAta = new BildirimAtamaKullaniciEntity();
                                                                        EntAta.FkBildirimId = CollAna[0].BildirimId;
                                                                        EntAta.FkKullaniciId = CollKim[0].KullaniciId;
                                                                        EntAta.BildirimAtamaKullaniciBittiMi = false;
                                                                        EntAta.BildirimAtamaKullaniciTarih = DateTime.Now;
                                                                        EntAta.BildirimAtamaKullaniciYonMu = "Hayır";
                                                                        EntAta.Save();

                                                                        if (bas_ad == "")
                                                                        {
                                                                            bas_ad = bas_ad + CollKim[0].KullaniciAdSoyad;
                                                                        }

                                                                        else
                                                                        {
                                                                            bas_ad = bas_ad + ", " + CollKim[0].KullaniciAdSoyad;
                                                                        }
                                                                    }
                                                                }

                                                                for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                                                {
                                                                    if (cb_grup_list.Items[i].Selected == true)
                                                                    {
                                                                        GrupCollection CollGr = new GrupCollection();
                                                                        IPredicateExpression ExpGr = new PredicateExpression();
                                                                        ExpGr.AddWithAnd(GrupFields.GrupAd == cb_grup_list.Items[i].Text);
                                                                        CollGr.GetMulti(ExpGr);

                                                                        BildirimAtamaGrupEntity EntAta = new BildirimAtamaGrupEntity();
                                                                        EntAta.FkBildirimId = CollAna[0].BildirimId;
                                                                        EntAta.FkGrupId = CollGr[0].GrupId;
                                                                        EntAta.BildirimAtamaGrupTarih = DateTime.Now;
                                                                        EntAta.BildirimAtamaGrupYonMu = "Hayır";
                                                                        EntAta.Save();
                                                                    }
                                                                }

                                                                BildirimIslemCollection CollIs2 = new BildirimIslemCollection();
                                                                IPredicateExpression ExpIs2 = new PredicateExpression();
                                                                ExpIs2.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "Kullanıcı/Grup Ataması Yapıldı");
                                                                CollIs2.GetMulti(ExpIs2);

                                                                BildirimHistoryEntity EntHis2 = new BildirimHistoryEntity();
                                                                EntHis2.FkBildirimId = CollAna[0].BildirimId;
                                                                EntHis2.FkBildirimIslemId = CollIs2[0].BildirimIslemId;
                                                                EntHis2.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                                                EntHis2.BildirimHistoryTarih = DateTime.Now;
                                                                EntHis2.BildirimHistorySure = "0";
                                                                EntHis2.BildirimHistoryAciklama = CollKul22[0].KullaniciAdSoyad + " tarafından bildirim " + bas_ad + "'e/a atandı.";
                                                                EntHis2.Save();

                                                                string CloseWindow;
                                                                CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                                                DosyaCollection CollDos = new DosyaCollection();
                                                                IPredicateExpression ExpDos = new PredicateExpression();
                                                                ExpDos.AddWithAnd(DosyaFields.DosyaBildirimi == CollAna[0].BildirimId);
                                                                CollDos.GetMulti(ExpDos);

                                                                for (int y = 0; y < CollDos.Count; y++)
                                                                {
                                                                    CollDos[y].Delete();
                                                                    CollDos[y].Save();
                                                                }

                                                                if (Session["file_path_1"] != null)
                                                                {
                                                                    DosyaEntity EntDos = new DosyaEntity();
                                                                    EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                                    EntDos.DosyaIcerikDurum = "1";
                                                                    EntDos.DosyaIcerikPath = Session["file_path_1"].ToString();
                                                                    EntDos.DosyaIcerikTarih = DateTime.Now;
                                                                    EntDos.Save();
                                                                }

                                                                if (Session["file_path_2"] != null)
                                                                {
                                                                    DosyaEntity EntDos = new DosyaEntity();
                                                                    EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                                    EntDos.DosyaIcerikDurum = "1";
                                                                    EntDos.DosyaIcerikPath = Session["file_path_2"].ToString();
                                                                    EntDos.DosyaIcerikTarih = DateTime.Now;
                                                                    EntDos.Save();
                                                                }

                                                                if (Session["file_path_3"] != null)
                                                                {
                                                                    DosyaEntity EntDos = new DosyaEntity();
                                                                    EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                                    EntDos.DosyaIcerikDurum = "1";
                                                                    EntDos.DosyaIcerikPath = Session["file_path_3"].ToString();
                                                                    EntDos.DosyaIcerikTarih = DateTime.Now;
                                                                    EntDos.Save();
                                                                }

                                                                Panel4.Enabled = false;
                                                                Panel5.Enabled = false;

                                                                cb_kayit_tur.Text = "";
                                                                cb_kayit_tur.NullText = "Seçiniz...";
                                                                txt_tc_no.Text = "";
                                                                btn_kps.Enabled = false; ;
                                                                txt_ad.Text = "";
                                                                txt_soyad.Text = "";
                                                                cb_cinsiyet.Text = "";
                                                                cb_cinsiyet.NullText = "Seçiniz...";
                                                                string hexValue21 = "#FFFFFF";
                                                                txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue21);
                                                                txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue21);
                                                                cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue21);
                                                                txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue21);

                                                                txt_dogum_tarihi.Text = "01.01.1900";
                                                                txt_tel_no.Text = "";
                                                                txt_mail.Text = "";
                                                                txt_adres.Text = "";
                                                                txt_pasaport.Text = "";
                                                                txt_vergi_no.Text = "";
                                                                txt_uyruk.Text = "";
                                                            }

                                                            else
                                                            {
                                                                if (Session["say_kac"].ToString() != "0")
                                                                {
                                                                    BildirimIslemCollection CollIs2 = new BildirimIslemCollection();
                                                                    IPredicateExpression ExpIs2 = new PredicateExpression();
                                                                    ExpIs2.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "İptal Edildi");
                                                                    CollIs2.GetMulti(ExpIs2);

                                                                    BildirimHistoryEntity EntHis2 = new BildirimHistoryEntity();
                                                                    EntHis2.FkBildirimId = CollAna[0].BildirimId;
                                                                    EntHis2.FkBildirimIslemId = CollIs2[0].BildirimIslemId;
                                                                    EntHis2.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                                                    EntHis2.BildirimHistoryTarih = DateTime.Now;
                                                                    EntHis2.BildirimHistorySure = "0";
                                                                    EntHis2.BildirimHistoryAciklama = CollKul22[0].KullaniciAdSoyad + " tarafından atama işlemleri iptal edildi.";
                                                                    EntHis2.Save();

                                                                    string CloseWindow;
                                                                    CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                                                    DosyaCollection CollDos = new DosyaCollection();
                                                                    IPredicateExpression ExpDos = new PredicateExpression();
                                                                    ExpDos.AddWithAnd(DosyaFields.DosyaBildirimi == CollAna[0].BildirimId);
                                                                    CollDos.GetMulti(ExpDos);

                                                                    for (int y = 0; y < CollDos.Count; y++)
                                                                    {
                                                                        CollDos[y].Delete();
                                                                        CollDos[y].Save();
                                                                    }

                                                                    if (Session["file_path_1"] != null)
                                                                    {
                                                                        DosyaEntity EntDos = new DosyaEntity();
                                                                        EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                                        EntDos.DosyaIcerikDurum = "1";
                                                                        EntDos.DosyaIcerikPath = Session["file_path_1"].ToString();
                                                                        EntDos.DosyaIcerikTarih = DateTime.Now;
                                                                        EntDos.Save();
                                                                    }

                                                                    if (Session["file_path_2"] != null)
                                                                    {
                                                                        DosyaEntity EntDos = new DosyaEntity();
                                                                        EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                                        EntDos.DosyaIcerikDurum = "1";
                                                                        EntDos.DosyaIcerikPath = Session["file_path_2"].ToString();
                                                                        EntDos.DosyaIcerikTarih = DateTime.Now;
                                                                        EntDos.Save();
                                                                    }

                                                                    if (Session["file_path_3"] != null)
                                                                    {
                                                                        DosyaEntity EntDos = new DosyaEntity();
                                                                        EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                                        EntDos.DosyaIcerikDurum = "1";
                                                                        EntDos.DosyaIcerikPath = Session["file_path_3"].ToString();
                                                                        EntDos.DosyaIcerikTarih = DateTime.Now;
                                                                        EntDos.Save();
                                                                    }

                                                                    Panel4.Enabled = false;
                                                                    Panel5.Enabled = false;

                                                                    cb_kayit_tur.Text = "";
                                                                    cb_kayit_tur.NullText = "Seçiniz...";
                                                                    txt_tc_no.Text = "";
                                                                    btn_kps.Enabled = false; ;
                                                                    txt_ad.Text = "";
                                                                    txt_soyad.Text = "";
                                                                    cb_cinsiyet.Text = "";
                                                                    cb_cinsiyet.NullText = "Seçiniz...";
                                                                    string hexValue23 = "#FFFFFF";
                                                                    txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue23);
                                                                    txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue23);
                                                                    cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue23);
                                                                    txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue23);

                                                                    txt_dogum_tarihi.Text = "01.01.1900";
                                                                    txt_tel_no.Text = "";
                                                                    txt_mail.Text = "";
                                                                    txt_adres.Text = "";
                                                                    txt_pasaport.Text = "";
                                                                    txt_vergi_no.Text = "";
                                                                    txt_uyruk.Text = "";
                                                                }

                                                                else
                                                                {
                                                                    string CloseWindow;
                                                                    CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                                                    DosyaCollection CollDos = new DosyaCollection();
                                                                    IPredicateExpression ExpDos = new PredicateExpression();
                                                                    ExpDos.AddWithAnd(DosyaFields.DosyaBildirimi == CollAna[0].BildirimId);
                                                                    CollDos.GetMulti(ExpDos);

                                                                    for (int y = 0; y < CollDos.Count; y++)
                                                                    {
                                                                        CollDos[y].Delete();
                                                                        CollDos[y].Save();
                                                                    }

                                                                    if (Session["file_path_1"] != null)
                                                                    {
                                                                        DosyaEntity EntDos = new DosyaEntity();
                                                                        EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                                        EntDos.DosyaIcerikDurum = "1";
                                                                        EntDos.DosyaIcerikPath = Session["file_path_1"].ToString();
                                                                        EntDos.DosyaIcerikTarih = DateTime.Now;
                                                                        EntDos.Save();
                                                                    }

                                                                    if (Session["file_path_2"] != null)
                                                                    {
                                                                        DosyaEntity EntDos = new DosyaEntity();
                                                                        EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                                        EntDos.DosyaIcerikDurum = "1";
                                                                        EntDos.DosyaIcerikPath = Session["file_path_2"].ToString();
                                                                        EntDos.DosyaIcerikTarih = DateTime.Now;
                                                                        EntDos.Save();
                                                                    }

                                                                    if (Session["file_path_3"] != null)
                                                                    {
                                                                        DosyaEntity EntDos = new DosyaEntity();
                                                                        EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                                        EntDos.DosyaIcerikDurum = "1";
                                                                        EntDos.DosyaIcerikPath = Session["file_path_3"].ToString();
                                                                        EntDos.DosyaIcerikTarih = DateTime.Now;
                                                                        EntDos.Save();
                                                                    }

                                                                    Panel4.Enabled = false;
                                                                    Panel5.Enabled = false;

                                                                    cb_kayit_tur.Text = "";
                                                                    cb_kayit_tur.NullText = "Seçiniz...";
                                                                    txt_tc_no.Text = "";
                                                                    btn_kps.Enabled = false; ;
                                                                    txt_ad.Text = "";
                                                                    txt_soyad.Text = "";
                                                                    cb_cinsiyet.Text = "";
                                                                    cb_cinsiyet.NullText = "Seçiniz...";
                                                                    string hexValue20 = "#FFFFFF";
                                                                    txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue20);
                                                                    txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue20);
                                                                    cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue20);
                                                                    txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue20);

                                                                    txt_dogum_tarihi.Text = "01.01.1900";
                                                                    txt_tel_no.Text = "";
                                                                    txt_mail.Text = "";
                                                                    txt_adres.Text = "";
                                                                    txt_pasaport.Text = "";
                                                                    txt_vergi_no.Text = "";
                                                                    txt_uyruk.Text = "";
                                                                }
                                                            }
                                                        }

                                                        ParametreCollection CollPrm = new ParametreCollection();
                                                        IPredicateExpression ExpPrm = new PredicateExpression();
                                                        ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
                                                        CollPrm.GetMulti(ExpPrm);

                                                        DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

                                                        ListBildirimTypedList bil_list = new ListBildirimTypedList();
                                                        ISortExpression sort22 = new SortExpression();
                                                        sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                                                        IPredicateExpression filter2 = new PredicateExpression();
                                                        filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                                                        bil_list.Fill(0, sort22, true, filter2);

                                                        grid_bildirim.DataSource = bil_list;
                                                        grid_bildirim.DataBind();

                                                        grid_bildirim_sil.DataSource = bil_list;
                                                        grid_bildirim_sil.DataBind();                                                      

                                                        txt_kisisel_measj.Text = "";
                                                        cb_havalimani.Text = "";
                                                        cb_havalimani.NullText = "Seçiniz...";
                                                        pnl_sorgu.Visible = false;
                                                        cb_tur.Text = "";
                                                        cb_tur.NullText = "Seçiniz...";
                                                        cb_sekil.Text = "";
                                                        cb_sekil.NullText = "Seçiniz...";
                                                        btn_yukle.Enabled = false;
                                                        cb_konu.Text = "";
                                                        cb_konu.NullText = "Seçiniz...";
                                                        txt_not.Text = "";
                                                        txt_dava_ad_soyad.Text = "";
                                                        txt_dava_dosya_no.Text = "";
                                                        txt_dava_konu.Text = "";
                                                        txt_dava_mahkeme_adi.Text = "";
                                                        cb_cag_tip.Text = "";
                                                        cb_cag_tip.NullText = "Seçiniz...";
                                                        cb_kapat.Checked = false;
                                                        cb_kayit_tur.Text = "";
                                                        cb_kayit_tur.NullText = "Seçiniz...";
                                                        txt_tc_no.Text = "";
                                                        btn_kps.Enabled = false; ;
                                                        txt_ad.Text = "";
                                                        txt_soyad.Text = "";
                                                        cb_cinsiyet.Text = "";
                                                        cb_cinsiyet.NullText = "Seçiniz...";
                                                        string hexValue25 = "#FFFFFF";
                                                        txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                                        txt_pasaport.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                                        txt_uyruk.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                                        txt_ad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                                        txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                                        cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                                        txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                                        txt_dogum_tarihi.Text = "01.01.1900";
                                                        txt_tel_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                                        txt_mail.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                                        txt_adres.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                                        txt_tel_no.Text = "";
                                                        txt_mail.Text = "";
                                                        txt_adres.Text = "";
                                                        txt_pasaport.Text = "";
                                                        txt_vergi_no.Text = "";
                                                        txt_uyruk.Text = "";

                                                        for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                                        {
                                                            cb_grup_list.Items[i].Selected = false;
                                                        }

                                                        for (int i = 0; i < cb_per_list.Items.Count; i++)
                                                        {
                                                            cb_per_list.Items[i].Selected = false;
                                                        }

                                                        cb_gr_hep.Checked = false;
                                                        cb_hepsi.Checked = false;
                                                        txt_cagri_sayisi.Text = "";
                                                        btn_gor.Enabled = false;

                                                        Session["vat_id"] = null;

                                                        cb_tur.Focus();
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    //tüzel kişi
                                    else
                                    {
                                        VatandaCollection CollVat = new VatandaCollection();
                                        IPredicateExpression ExpVat = new PredicateExpression();

                                        if (txt_tc_no.Text == "")
                                        {
                                            ExpVat.AddWithAnd(VatandaFields.VatandasTcNo == "111");
                                        }

                                        else
                                        {
                                            ExpVat.AddWithAnd(VatandaFields.VatandasTcNo == txt_tc_no.Text);
                                        }

                                        CollVat.GetMulti(ExpVat);

                                        VatandaCollection CollVat2 = new VatandaCollection();
                                        IPredicateExpression ExpVat2 = new PredicateExpression();
                                        ExpVat2.AddWithAnd(VatandaFields.VatandasTel1 == txt_tel_no.Text.Trim().Replace(" ", string.Empty));
                                        CollVat2.GetMulti(ExpVat2);

                                        VatandaCollection CollVat3 = new VatandaCollection();
                                        IPredicateExpression ExpVat3 = new PredicateExpression();
                                        ExpVat3.AddWithAnd(VatandaFields.VatandasMail == txt_mail.Text);
                                        CollVat3.GetMulti(ExpVat3);

                                        int mail_count = 0;
                                        int tel_count = 0;

                                        if (txt_mail.Text == "")
                                        {
                                            mail_count = 0;
                                        }

                                        else
                                        {
                                            mail_count = CollVat3.Count;
                                        }

                                        if (txt_tel_no.Text == "")
                                        {
                                            tel_count = 0;
                                        }

                                        else
                                        {
                                            tel_count = CollVat2.Count;
                                        }

                                        if (CollVat.Count > 0 || tel_count > 0 || mail_count > 0)
                                        {
                                            if (CollVat.Count > 0)
                                            {
                                                string CloseWindow;
                                                CloseWindow = "alert('TC Kimlik Numarası sistemde kayıtlıdır...')";
                                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                                txt_tc_no.Focus();
                                            }

                                            else if (CollVat2.Count > 0)
                                            {
                                                string CloseWindow;
                                                CloseWindow = "alert('Telefon Numarası sistemde kayıtlıdır...')";
                                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                                txt_tel_no.Focus();
                                            }

                                            else if (CollVat3.Count > 0)
                                            {
                                                string CloseWindow;
                                                CloseWindow = "alert('Mail Adresi sistemde kayıtlıdır...')";
                                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                                txt_mail.Focus();
                                            }
                                        }

                                        else
                                        {
                                            VatandaEntity EntKay = new VatandaEntity();
                                            EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                            EntKay.VatandasAd = txt_ad.Text.ToUpper();
                                            EntKay.VatandasAdres = txt_adres.Text;
                                            EntKay.VatandasTur = cb_kayit_tur.Text;
                                            EntKay.VatandasIslemTarih = DateTime.Now;

                                            if (cb_kayit_tur.Text == "Gerçek Kişi")
                                            {
                                                EntKay.VatandasSoyad = txt_soyad.Text.ToUpper();
                                                EntKay.VatandasAdSoyad = txt_ad.Text.ToUpper() + " " + txt_soyad.Text.ToUpper();
                                                EntKay.VatandasCinsiyet = cb_cinsiyet.Text;

                                                if (txt_dogum_tarihi.Text != "01.01.1900")
                                                {
                                                    EntKay.VatandasDogumTarihi = Convert.ToDateTime(txt_dogum_tarihi.Text);
                                                }

                                                EntKay.VatandasTcNo = txt_tc_no.Text;
                                            }

                                            else
                                            {
                                                EntKay.VatandasAdSoyad = txt_ad.Text.ToUpper() + " " + txt_soyad.Text.ToUpper();
                                            }

                                            EntKay.VatandasMail = txt_mail.Text;
                                            EntKay.VatandasTel1 = txt_tel_no.Text.Trim().Replace(" ", string.Empty);
                                            EntKay.VatandasPasaportNo = txt_pasaport.Text;
                                            EntKay.VatandasUyruk = txt_uyruk.Text;
                                            EntKay.VatandasVergiNo = txt_vergi_no.Text;

                                            EntKay.Save();

                                            VatandaCollection CollBul = new VatandaCollection();
                                            IPredicateExpression ExpBul = new PredicateExpression();
                                            ExpBul.AddWithAnd(VatandaFields.VatandasTel1 == txt_tel_no.Text.Trim().Replace(" ", string.Empty));

                                            if (txt_mail.Text != "")
                                            {
                                                ExpBul.AddWithAnd(VatandaFields.VatandasMail == txt_mail.Text);
                                            }

                                            if (txt_tc_no.Text != "")
                                            {
                                                ExpBul.AddWithAnd(VatandaFields.VatandasTcNo == txt_tc_no.Text);
                                            }

                                            if (cb_kayit_tur.Text == "Gerçek Kişi" || cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
                                            {
                                                ExpBul.AddWithAnd(VatandaFields.VatandasAdSoyad == txt_ad.Text.ToUpper() + " " + txt_soyad.Text.ToUpper());
                                            }

                                            else
                                            {
                                                ExpBul.AddWithAnd(VatandaFields.VatandasAdSoyad == txt_ad.Text.ToUpper());
                                            }

                                            CollBul.GetMulti(ExpBul);

                                            kullan_idsi = CollBul[0].VatandasId;
                                            Session["vat_id"] = kullan_idsi.ToString();

                                            KullaniciCollection CollKul = new KullaniciCollection();
                                            IPredicateExpression ExpKul = new PredicateExpression();
                                            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                                            CollKul.GetMulti(ExpKul);

                                            VatandasArsivEntity EntAr = new VatandasArsivEntity();
                                            EntAr.FkVatandasId = CollBul[0].VatandasId;
                                            EntAr.VatandasArsivIslemTarih = DateTime.Now;
                                            EntAr.VatandasArsivAciklama = CollKul[0].KullaniciAdSoyad + " tarafından kayıt altına alındı.";
                                            EntAr.Save();

                                            VatandaCollection CollVat22 = new VatandaCollection();
                                            ISortExpression sortss22 = new SortExpression();
                                            sortss22.Add(new SortClause(VatandaFields.VatandasAdSoyad, SortOperator.Ascending));
                                            CollVat22.GetMulti(null, 0, sortss22);

                                            say_grup = 0;
                                            say_kul = 0;

                                            for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                            {
                                                if (cb_grup_list.Items[i].Selected == true)
                                                {
                                                    say_grup = say_grup + 1;
                                                }
                                            }

                                            for (int i = 0; i < cb_per_list.Items.Count; i++)
                                            {
                                                if (cb_per_list.Items[i].Selected == true)
                                                {
                                                    say_kul = say_kul + 1;
                                                }
                                            }

                                            KullaniciCollection CollKul22 = new KullaniciCollection();
                                            IPredicateExpression ExpKul22 = new PredicateExpression();
                                            ExpKul22.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                                            CollKul22.GetMulti(ExpKul22);

                                            BildirimTuruCollection CollTur = new BildirimTuruCollection();
                                            IPredicateExpression ExpTur = new PredicateExpression();
                                            ExpTur.AddWithAnd(BildirimTuruFields.BildirimTuruAd == cb_tur.Text);
                                            CollTur.GetMulti(ExpTur);

                                            BildirimSonucCollection CollSonAta = new BildirimSonucCollection();
                                            IPredicateExpression ExpSonAta = new PredicateExpression();
                                            ExpSonAta.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                                            CollSonAta.GetMulti(ExpSonAta);

                                            BildirimSonucCollection CollSonKay = new BildirimSonucCollection();
                                            IPredicateExpression ExpSonKay = new PredicateExpression();
                                            ExpSonKay.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Kayıt Altına Alındı");
                                            CollSonKay.GetMulti(ExpSonKay);

                                            BildirimSonucCollection CollBit = new BildirimSonucCollection();
                                            IPredicateExpression ExpBit = new PredicateExpression();
                                            ExpBit.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Sonuçlandı");
                                            CollBit.GetMulti(ExpBit);

                                            BildirimGeriDonuCollection CollGeri = new BildirimGeriDonuCollection();
                                            IPredicateExpression ExpGeri = new PredicateExpression();
                                            ExpGeri.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusAd == cb_sekil.Text);
                                            CollGeri.GetMulti(ExpGeri);

                                            AltKonuCollection CollAlt = new AltKonuCollection();
                                            IPredicateExpression ExpAlt = new PredicateExpression();

                                            if (cb_konu.Text != "")
                                            {
                                                ExpAlt.AddWithAnd(AltKonuFields.AltKonuAd == cb_konu.Text);
                                            }

                                            else
                                            {
                                                ExpAlt.AddWithAnd(AltKonuFields.AltKonuAd == "Diğer");
                                            }

                                            CollAlt.GetMulti(ExpAlt);

                                            KonuCollection CollKon = new KonuCollection();
                                            IPredicateExpression ExpKon = new PredicateExpression();
                                            ExpKon.AddWithAnd(KonuFields.KonuId == CollAlt[0].FkKonuId);
                                            CollKon.GetMulti(ExpKon);

                                            if (Session["par_guncelle_mi"].ToString() == "0")
                                            {
                                                BildirimEntity EntKayy = new BildirimEntity();

                                                CagriTipiCollection CollTit = new CagriTipiCollection();
                                                IPredicateExpression ExpTit = new PredicateExpression();
                                                ExpTit.AddWithAnd(CagriTipiFields.CagriTipiAd == cb_cag_tip.Text);
                                                CollTit.GetMulti(ExpTit);

                                                EntKayy.FkCagriTipiId = CollTit[0].CagriTipiId;

                                                if (cb_havalimani.Text == "" || cb_havalimani.NullText == "Seçiniz...")
                                                {
                                                    EntKayy.BildirimHavalimani = cb_havalimani.Text;
                                                }

                                                EntKayy.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                                EntKayy.BildirimGeriYapildiMi = false;
                                                EntKayy.FkVatandasId = Convert.ToInt64(Session["vat_id"].ToString());
                                                EntKayy.FkBildirimTuruId = CollTur[0].BildirimTuruId;

                                                if (cb_kapat.Checked == true)
                                                {
                                                    EntKayy.FkBildirimSonucId = CollBit[0].BildirimSonucId;
                                                    EntKayy.BildirimAtanmaDurumu = "Bilgi verildi-Kapatıldı.";
                                                    EntKayy.BildirimVatandasKarar = txt_not.Text;
                                                }

                                                else
                                                {
                                                    if (say_grup == 0 && say_kul == 0)
                                                    {
                                                        EntKayy.FkBildirimSonucId = CollSonKay[0].BildirimSonucId;
                                                        EntKayy.BildirimAtanmaDurumu = "Atama yapılmadı.";
                                                    }

                                                    else
                                                    {
                                                        EntKayy.FkBildirimSonucId = CollSonAta[0].BildirimSonucId;

                                                        if (say_grup == 0)
                                                        {
                                                            EntKayy.BildirimAtanmaDurumu = say_kul.ToString() + " kullanıcıya atandı.";
                                                        }

                                                        else
                                                        {
                                                            if (say_grup == 1)
                                                            {
                                                                string gr_adi = "";

                                                                for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                                                {
                                                                    if (cb_grup_list.Items[i].Selected == true)
                                                                    {
                                                                        gr_adi = cb_grup_list.Items[i].Text;
                                                                    }
                                                                }

                                                                EntKayy.BildirimAtanmaDurumu = gr_adi.ToUpper() + "-" + say_grup.ToString() + " grup, " + say_kul.ToString() + " kullanıcıya atandı.";
                                                            }

                                                            else
                                                            {
                                                                EntKayy.BildirimAtanmaDurumu = "BİRKAÇ GRUP-" + say_grup.ToString() + " grup, " + say_kul.ToString() + " kullanıcıya atandı.";
                                                            }
                                                        }
                                                    }
                                                }

                                                if (CollGeri.Count > 0)
                                                {
                                                    EntKayy.FkBildirimGeriDonusId = CollGeri[0].BildirimGeriDonusId;
                                                }

                                                else
                                                {
                                                    BildirimGeriDonuCollection CollDon = new BildirimGeriDonuCollection();
                                                    IPredicateExpression ExpDon = new PredicateExpression();
                                                    ExpDon.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusAd == "Hiçbiri");
                                                    CollDon.GetMulti(ExpDon);

                                                    EntKayy.FkBildirimGeriDonusId = CollDon[0].BildirimGeriDonusId;
                                                }

                                                EntKayy.FkAltKonuId = CollAlt[0].AltKonuId;
                                                EntKayy.BildirimGelenYer = cb_sistem.Text;

                                                EntKayy.BildirimTarih = DateTime.Now;
                                                EntKayy.BildirimSonIslemTarih = DateTime.Now;

                                                DateTime bas_tar_al = DateTime.Now;

                                                string tar_yil = DateTime.Now.Year.ToString();

                                                EntKayy.BildirimYil = Convert.ToInt16(tar_yil);
                                                EntKayy.BildirimMetin = txt_not.Text;

                                                if (cb_tur.Text == "Dava Bildirimi")
                                                {
                                                    EntKayy.BildirimDavaAdSoyad = txt_dava_ad_soyad.Text;
                                                    EntKayy.BildirimDavaDosyaNo = txt_dava_dosya_no.Text;
                                                    EntKayy.BildirimDavaKonu = txt_dava_konu.Text;
                                                    EntKayy.BildirimDavaMahkeme = txt_dava_mahkeme_adi.Text;
                                                }

                                                if (txt_kisisel_measj.Text != "")
                                                {
                                                    EntKayy.BildirimAciklama = CollKul22[0].KullaniciAdSoyad + " - '" + txt_kisisel_measj.Text + "'.";
                                                }

                                                if (cb_kapat.Checked == true)
                                                {
                                                    VatandaCollection CollVatt = new VatandaCollection();
                                                    IPredicateExpression ExpVatt = new PredicateExpression();
                                                    ExpVatt.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                                                    CollVatt.GetMulti(ExpVatt);

                                                    TimeSpan fark_bak1 = DateTime.Now - CollVatt[0].VatandasIslemTarih;
                                                    string duzle = (fark_bak1.TotalHours).ToString();
                                                    double arasi = Convert.ToDouble(duzle);
                                                    Int16 ana_fark = Convert.ToInt16(arasi);
                                                    Int16 saat = 0;
                                                    Int16 gun = 0;
                                                    Int16 ay = 0;
                                                    Int16 yil = 0;

                                                    string fark_olustur = "";

                                                    if (ana_fark > 168)
                                                    {
                                                        ana_fark = 1;
                                                    }

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

                                                    if (cb_kapat.Checked == true)
                                                    {
                                                        EntKayy.BildirimToplamSure = "5 Dakika";
                                                    }

                                                    else
                                                    {
                                                        EntKayy.BildirimToplamSure = fark_olustur;
                                                    }
                                                }

                                                else
                                                {
                                                    EntKayy.BildirimToplamSure = "-";
                                                }

                                                EntKayy.Save();

                                                string icerik = txt_not.Text;

                                                BildirimCollection CollArra = new BildirimCollection();
                                                IPredicateExpression ExpArra = new PredicateExpression();
                                                ExpArra.AddWithAnd(BildirimFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                                                ExpArra.AddWithAnd(BildirimFields.FkVatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                                                ExpArra.AddWithAnd(BildirimFields.FkAltKonuId == CollAlt[0].AltKonuId);
                                                ExpArra.AddWithAnd(BildirimFields.BildirimSonIslemTarih == bas_tar_al);
                                                CollArra.GetMulti(ExpArra);

                                                Int64 numarasi = CollArra[0].BildirimId;

                                                string CloseWindow2;
                                                CloseWindow2 = "alert('Kayıt işlemi tamamlanmıştır...')";
                                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow2", CloseWindow2, true);

                                                if (Session["file_path_1"] != null)
                                                {
                                                    DosyaEntity EntDos = new DosyaEntity();
                                                    EntDos.DosyaBildirimi = numarasi;
                                                    EntDos.DosyaIcerikDurum = "1";
                                                    EntDos.DosyaIcerikPath = Session["file_path_1"].ToString();
                                                    EntDos.DosyaIcerikTarih = DateTime.Now;
                                                    EntDos.Save();
                                                }

                                                if (Session["file_path_2"] != null)
                                                {
                                                    DosyaEntity EntDos = new DosyaEntity();
                                                    EntDos.DosyaBildirimi = numarasi;
                                                    EntDos.DosyaIcerikDurum = "1";
                                                    EntDos.DosyaIcerikPath = Session["file_path_2"].ToString();
                                                    EntDos.DosyaIcerikTarih = DateTime.Now;
                                                    EntDos.Save();
                                                }

                                                if (Session["file_path_3"] != null)
                                                {
                                                    DosyaEntity EntDos = new DosyaEntity();
                                                    EntDos.DosyaBildirimi = numarasi;
                                                    EntDos.DosyaIcerikDurum = "1";
                                                    EntDos.DosyaIcerikPath = Session["file_path_3"].ToString();
                                                    EntDos.DosyaIcerikTarih = DateTime.Now;
                                                    EntDos.Save();
                                                }

                                                BildirimTuruCollection CollBilTur = new BildirimTuruCollection();
                                                IPredicateExpression ExpBilTur = new PredicateExpression();
                                                ExpBilTur.AddWithAnd(BildirimTuruFields.BildirimTuruAd == cb_tur.Text);
                                                CollBilTur.GetMulti(ExpBilTur);

                                                if (CollBilTur[0].BildirimTuruMail == true && cb_kapat.Checked == false && cb_sekil.Text == "E-Posta")
                                                {
                                                    string konusu = "DHMİ İletişim Merkezi Bildirim Talebi";
                                                    string maili = txt_mail.Text;
                                                    string bil_git = numarasi.ToString();

                                                    if (txt_mail.Text != "")
                                                    {
                                                        if (cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
                                                        {
                                                            Mail.MailGonderBildirimEng(maili, "General Directorate Of State Airports Authority (DHMI) Call Center", bil_git);
                                                        }

                                                        else
                                                        {
                                                            Mail.MailGonderBildirim(maili, konusu, bil_git);
                                                        }
                                                    }
                                                }

                                                if (CollBilTur[0].BildirimTuruSms == true && cb_kapat.Checked == false && cb_sekil.Text == "SMS")
                                                {
                                                    if (txt_tel_no.Text != "")
                                                    {
                                                        //SMSGonder
                                                        try
                                                        {
                                                            string gsmNo = txt_tel_no.Text.Trim().Replace(" ", string.Empty);
                                                            gsmNo = gsmNo.TrimStart('0');
                                                            Int32 bildirim_nosu = Convert.ToInt32(numarasi);

                                                            if (cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
                                                            {
                                                                string smsMessage = string.Format(ConfigurationManager.AppSettings["SmsNewRecordContentEng"], bildirim_nosu);
                                                                Helper.SendSms(gsmNo, smsMessage, bildirim_nosu);
                                                            }

                                                            else
                                                            {
                                                                string smsMessage = string.Format(ConfigurationManager.AppSettings["SmsNewRecordContent"], bildirim_nosu);
                                                                Helper.SendSms(gsmNo, smsMessage, bildirim_nosu);
                                                            }
                                                        }

                                                        catch
                                                        {
                                                            //Telefon Numarasında Sorun Varsa Direkt Geç...
                                                        }
                                                    }
                                                }

                                                Panel4.Enabled = false;
                                                Panel5.Enabled = false;

                                                /*
                                                cb_kayit_tur.Text = "";
                                                cb_kayit_tur.NullText = "Seçiniz...";
                                                txt_tc_no.Text = "";
                                                btn_kps.Enabled = false; ;
                                                txt_ad.Text = "";
                                                txt_soyad.Text = "";
                                                cb_cinsiyet.Text = "";
                                                cb_cinsiyet.NullText = "Seçiniz...";
                                                string hexValue28 = "#FFFFFF";
                                                txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue28);
                                                txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue28);
                                                cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue28);
                                                txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue28);

                                                txt_dogum_tarihi.Text = "01.01.1900";
                                                txt_tel_no.Text = "";
                                                txt_mail.Text = "";
                                                txt_adres.Text = "";
                                                txt_pasaport.Text = "";
                                                txt_vergi_no.Text = "";
                                                txt_uyruk.Text = "";*/

                                                BildirimIslemCollection CollIs = new BildirimIslemCollection();
                                                IPredicateExpression ExpIs = new PredicateExpression();
                                                ExpIs.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "Kayıt Altına Alındı");
                                                CollIs.GetMulti(ExpIs);

                                                BildirimCollection CollKac = new BildirimCollection();
                                                IPredicateExpression ExpKac = new PredicateExpression();
                                                ExpKac.AddWithAnd(BildirimFields.BildirimId == numarasi);
                                                CollKac.GetMulti(ExpKac);

                                                BildirimHistoryEntity EntHis = new BildirimHistoryEntity();
                                                EntHis.FkBildirimId = CollKac[0].BildirimId;
                                                EntHis.FkBildirimIslemId = CollIs[0].BildirimIslemId;
                                                EntHis.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                                EntHis.BildirimHistoryTarih = DateTime.Now;
                                                EntHis.BildirimHistorySure = "0";
                                                EntHis.BildirimHistoryAciklama = CollKul22[0].KullaniciAdSoyad + " tarafından kayıt altına alındı.";
                                                EntHis.Save();

                                                if (say_grup != 0 || say_kul != 0)
                                                {
                                                    string bas_ad = "";

                                                    for (int i = 0; i < cb_per_list.Items.Count; i++)
                                                    {
                                                        if (cb_per_list.Items[i].Selected == true)
                                                        {
                                                            KullaniciCollection CollKim = new KullaniciCollection();
                                                            IPredicateExpression ExpKim = new PredicateExpression();
                                                            ExpKim.AddWithAnd(KullaniciFields.KullaniciAdSoyad == cb_per_list.Items[i].Text);
                                                            CollKim.GetMulti(ExpKim);

                                                            BildirimAtamaKullaniciEntity EntAta = new BildirimAtamaKullaniciEntity();
                                                            EntAta.FkBildirimId = CollKac[0].BildirimId;
                                                            EntAta.FkKullaniciId = CollKim[0].KullaniciId;
                                                            EntAta.BildirimAtamaKullaniciBittiMi = false;
                                                            EntAta.BildirimAtamaKullaniciTarih = DateTime.Now;
                                                            EntAta.BildirimAtamaKullaniciYonMu = "Hayır";
                                                            EntAta.Save();

                                                            try
                                                            {
                                                                string konusu = "DHMİ İletişim Merkezi Bildirim Talebi";
                                                                string maili = CollKim[0].KullaniciMail;
                                                                string bsl = "www.alo.dhmi.gov.tr/McCallCenterLinkControlAsLogin.aspx?";
                                                                string bas_coz = "dhmi";
                                                                string bit_coz = "callcenter";
                                                                string dhmi_bas = Kullanici.sifre_olustur(bas_coz);
                                                                string dhmi_bit = Kullanici.sifre_olustur(bit_coz);
                                                                string aradaki_kul = CollKim[0].KullaniciId.ToString();
                                                                aradaki_kul = Kullanici.sifre_olustur(aradaki_kul);
                                                                string linki = dhmi_bas + aradaki_kul + dhmi_bit;

                                                                string kayit_link = bsl + linki;

                                                                Mail.MailLinkGonder(CollKac[0].BildirimId.ToString(), linki, maili, konusu, icerik);

                                                                MailBankEntity EntBan = new MailBankEntity();
                                                                EntBan.MailBanksLink = kayit_link;
                                                                EntBan.MailBanksBildirim = CollKac[0].BildirimId;
                                                                EntBan.MailBanksKullanici = CollKim[0].KullaniciId;
                                                                EntBan.MailBanksTikAdet = 0;
                                                                EntBan.MailBanksTarih = DateTime.Now;
                                                                EntBan.MailBanksDurum = true;
                                                                EntBan.Save();
                                                            }

                                                            catch
                                                            {
                                                                //Mail Adresinde Sorun Varsa Direkt Geç...
                                                            }

                                                            if (bas_ad == "")
                                                            {
                                                                bas_ad = bas_ad + CollKim[0].KullaniciAdSoyad;
                                                            }

                                                            else
                                                            {
                                                                bas_ad = bas_ad + ", " + CollKim[0].KullaniciAdSoyad;
                                                            }
                                                        }
                                                    }

                                                    for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                                    {
                                                        if (cb_grup_list.Items[i].Selected == true)
                                                        {
                                                            GrupCollection CollGr = new GrupCollection();
                                                            IPredicateExpression ExpGr = new PredicateExpression();
                                                            ExpGr.AddWithAnd(GrupFields.GrupAd == cb_grup_list.Items[i].Text);
                                                            CollGr.GetMulti(ExpGr);

                                                            BildirimAtamaGrupEntity EntAta = new BildirimAtamaGrupEntity();
                                                            EntAta.FkBildirimId = CollKac[0].BildirimId;
                                                            EntAta.FkGrupId = CollGr[0].GrupId;
                                                            EntAta.BildirimAtamaGrupTarih = DateTime.Now;
                                                            EntAta.BildirimAtamaGrupYonMu = "Hayır";
                                                            EntAta.Save();
                                                        }
                                                    }

                                                    BildirimIslemCollection CollIs2 = new BildirimIslemCollection();
                                                    IPredicateExpression ExpIs2 = new PredicateExpression();
                                                    ExpIs2.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "Kullanıcı/Grup Ataması Yapıldı");
                                                    CollIs2.GetMulti(ExpIs2);

                                                    BildirimHistoryEntity EntHis2 = new BildirimHistoryEntity();
                                                    EntHis2.FkBildirimId = CollKac[0].BildirimId;
                                                    EntHis2.FkBildirimIslemId = CollIs2[0].BildirimIslemId;
                                                    EntHis2.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                                    EntHis2.BildirimHistoryTarih = DateTime.Now;
                                                    EntHis2.BildirimHistorySure = "0";
                                                    EntHis2.BildirimHistoryAciklama = CollKul22[0].KullaniciAdSoyad + " tarafından bildirim " + bas_ad + "'e/a atandı.";
                                                    EntHis2.Save();

                                                    SureTakipEntity EntSure = new SureTakipEntity();
                                                    EntSure.FkBildirimId = CollKac[0].BildirimId;
                                                    EntSure.SureTakipTuru = "Kayıtta Bekleme Süresi";
                                                    EntSure.SureTakipTarih = DateTime.Now;
                                                    EntSure.SureTakipSaat = 0;
                                                    EntSure.SureTakipGun = 0;
                                                    EntSure.Save();
                                                }

                                                ParametreCollection CollPrm = new ParametreCollection();
                                                IPredicateExpression ExpPrm = new PredicateExpression();
                                                ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
                                                CollPrm.GetMulti(ExpPrm);

                                                DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

                                                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                                                ISortExpression sort22 = new SortExpression();
                                                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                                                IPredicateExpression filter2 = new PredicateExpression();
                                                filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                                                bil_list.Fill(0, sort22, true, filter2);

                                                grid_bildirim.DataSource = bil_list;
                                                grid_bildirim.DataBind();
                                              
                                                grid_bildirim_sil.DataSource = bil_list;
                                                grid_bildirim_sil.DataBind();                                            

                                                txt_kisisel_measj.Text = "";
                                                cb_havalimani.Text = "";
                                                cb_havalimani.NullText = "Seçiniz...";
                                                pnl_sorgu.Visible = false;
                                                cb_tur.Text = "";
                                                cb_tur.NullText = "Seçiniz...";
                                                cb_sekil.Text = "";
                                                cb_sekil.NullText = "Seçiniz...";
                                                btn_yukle.Enabled = false;
                                                cb_konu.Text = "";
                                                cb_konu.NullText = "Seçiniz...";
                                                txt_not.Text = "";
                                                txt_dava_ad_soyad.Text = "";
                                                txt_dava_dosya_no.Text = "";
                                                txt_dava_konu.Text = "";
                                                txt_dava_mahkeme_adi.Text = "";
                                                cb_cag_tip.Text = "";
                                                cb_cag_tip.NullText = "Seçiniz...";
                                                cb_kapat.Checked = false;
                                                cb_kayit_tur.Text = "";
                                                cb_kayit_tur.NullText = "Seçiniz...";
                                                txt_tc_no.Text = "";
                                                btn_kps.Enabled = false; ;
                                                txt_ad.Text = "";
                                                txt_soyad.Text = "";
                                                cb_cinsiyet.Text = "";
                                                cb_cinsiyet.NullText = "Seçiniz...";
                                                string hexValue21 = "#FFFFFF";
                                                txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue21);
                                                txt_pasaport.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue21);
                                                txt_uyruk.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue21);
                                                txt_ad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue21);
                                                txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue21);
                                                cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue21);
                                                txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue21);
                                                txt_dogum_tarihi.Text = "01.01.1900";
                                                txt_tel_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue21);
                                                txt_mail.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue21);
                                                txt_adres.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue21);
                                                txt_tel_no.Text = "";
                                                txt_mail.Text = "";
                                                txt_adres.Text = "";
                                                txt_pasaport.Text = "";
                                                txt_vergi_no.Text = "";
                                                txt_uyruk.Text = "";

                                                for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                                {
                                                    cb_grup_list.Items[i].Selected = false;
                                                }

                                                for (int i = 0; i < cb_per_list.Items.Count; i++)
                                                {
                                                    cb_per_list.Items[i].Selected = false;
                                                }

                                                cb_gr_hep.Checked = false;
                                                cb_hepsi.Checked = false;
                                                txt_cagri_sayisi.Text = "";
                                                btn_gor.Enabled = false;

                                                Session["vat_id"] = null;

                                                cb_tur.Focus();
                                            }

                                            else
                                            {
                                                BildirimCollection CollAna = new BildirimCollection();
                                                IPredicateExpression ExpAna = new PredicateExpression();
                                                ExpAna.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserName.Text));
                                                CollAna.GetMulti(ExpAna);

                                                if (Session["gnc_turu"].ToString() == "Ekstra")
                                                {
                                                    BildirimAtamaKullaniciCollection CollSil = new BildirimAtamaKullaniciCollection();
                                                    IPredicateExpression ExpSil = new PredicateExpression();
                                                    ExpSil.AddWithAnd(BildirimAtamaKullaniciFields.FkBildirimId == CollAna[0].BildirimId);
                                                    CollSil.GetMulti(ExpSil);

                                                    for (int i = 0; i < CollSil.Count; i++)
                                                    {
                                                        CollSil[i].Delete();
                                                        CollSil[i].Save();
                                                    }

                                                    BildirimAtamaGrupCollection CollSil2 = new BildirimAtamaGrupCollection();
                                                    IPredicateExpression ExpSil2 = new PredicateExpression();
                                                    ExpSil2.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollAna[0].BildirimId);
                                                    CollSil2.GetMulti(ExpSil2);

                                                    for (int i = 0; i < CollSil2.Count; i++)
                                                    {
                                                        CollSil2[i].Delete();
                                                        CollSil2[i].Save();
                                                    }
                                                }

                                                CollAna[0].FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                                CollAna[0].FkBildirimTuruId = CollTur[0].BildirimTuruId;

                                                if (cb_kapat.Checked == true)
                                                {
                                                    CollAna[0].FkBildirimSonucId = CollBit[0].BildirimSonucId;
                                                    CollAna[0].BildirimAtanmaDurumu = "Bilgi verildi-Kapatıldı.";
                                                    CollAna[0].BildirimVatandasKarar = txt_not.Text;
                                                }

                                                else
                                                {
                                                    if (say_grup == 0 && say_kul == 0)
                                                    {
                                                        CollAna[0].FkBildirimSonucId = CollSonKay[0].BildirimSonucId;
                                                        CollAna[0].BildirimAtanmaDurumu = "Atama yapılmadı.";
                                                    }

                                                    else
                                                    {
                                                        if (Session["gnc_turu"].ToString() == "Ekstra")
                                                        {
                                                            CollAna[0].FkBildirimSonucId = CollSonAta[0].BildirimSonucId;

                                                            if (say_grup == 0)
                                                            {
                                                                CollAna[0].BildirimAtanmaDurumu = say_kul.ToString() + " kullanıcıya atandı.";
                                                            }

                                                            else
                                                            {
                                                                if (say_grup == 1)
                                                                {
                                                                    string gr_adi = "";

                                                                    for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                                                    {
                                                                        if (cb_grup_list.Items[i].Selected == true)
                                                                        {
                                                                            gr_adi = cb_grup_list.Items[i].Text;
                                                                        }
                                                                    }

                                                                    CollAna[0].BildirimAtanmaDurumu = gr_adi.ToUpper() + "-" + say_grup.ToString() + " grup, " + say_kul.ToString() + " kullanıcıya atandı.";
                                                                }

                                                                else
                                                                {
                                                                    CollAna[0].BildirimAtanmaDurumu = "BİRKAÇ GRUP-" + say_grup.ToString() + " grup, " + say_kul.ToString() + " kullanıcıya atandı.";
                                                                }
                                                            }
                                                        }
                                                    }
                                                }

                                                if (CollGeri.Count > 0)
                                                {
                                                    CollAna[0].FkBildirimGeriDonusId = CollGeri[0].BildirimGeriDonusId;
                                                }

                                                else
                                                {
                                                    BildirimGeriDonuCollection CollDon = new BildirimGeriDonuCollection();
                                                    IPredicateExpression ExpDon = new PredicateExpression();
                                                    ExpDon.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusAd == "Hiçbiri");
                                                    CollDon.GetMulti(ExpDon);

                                                    CollAna[0].FkBildirimGeriDonusId = CollDon[0].BildirimGeriDonusId;
                                                }

                                                CollAna[0].FkAltKonuId = CollAlt[0].AltKonuId;
                                                CollAna[0].BildirimGelenYer = cb_sistem.Text;

                                                if (cb_havalimani.Text == "" || cb_havalimani.NullText == "Seçiniz...")
                                                {
                                                    CollAna[0].BildirimHavalimani = cb_havalimani.Text;
                                                }

                                                CollAna[0].BildirimSonIslemTarih = DateTime.Now;
                                                CollAna[0].BildirimMetin = txt_not.Text;
                                                CollAna[0].BildirimAciklama = txt_kisisel_measj.Text;

                                                if (cb_kapat.Checked == true)
                                                {
                                                    VatandaCollection CollVatt = new VatandaCollection();
                                                    IPredicateExpression ExpVatt = new PredicateExpression();
                                                    ExpVatt.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                                                    CollVatt.GetMulti(ExpVatt);

                                                    TimeSpan fark_bak1 = DateTime.Now - CollVatt[0].VatandasIslemTarih;
                                                    string duzle = (fark_bak1.TotalHours).ToString();
                                                    double arasi = Convert.ToDouble(duzle);
                                                    Int16 ana_fark = Convert.ToInt16(arasi);
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

                                                    CollAna[0].BildirimToplamSure = fark_olustur;
                                                }

                                                CollAna[0].Save();

                                                BildirimIslemCollection CollIs = new BildirimIslemCollection();
                                                IPredicateExpression ExpIs = new PredicateExpression();
                                                ExpIs.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "Kayıtları Güncellendi");
                                                CollIs.GetMulti(ExpIs);

                                                BildirimHistoryEntity EntHis = new BildirimHistoryEntity();
                                                EntHis.FkBildirimId = CollAna[0].BildirimId;
                                                EntHis.FkBildirimIslemId = CollIs[0].BildirimIslemId;
                                                EntHis.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                                EntHis.BildirimHistoryTarih = DateTime.Now;
                                                EntHis.BildirimHistorySure = "0";
                                                EntHis.BildirimHistoryAciklama = CollKul22[0].KullaniciAdSoyad + " tarafından kayıtları güncellendi.";
                                                EntHis.Save();

                                                Session["par_guncelle_mi"] = "0";

                                                if (say_grup != 0 || say_kul != 0)
                                                {
                                                    if (Session["gnc_turu"].ToString() == "Ekstra")
                                                    {
                                                        string bas_ad = "";

                                                        for (int i = 0; i < cb_per_list.Items.Count; i++)
                                                        {
                                                            if (cb_per_list.Items[i].Selected == true)
                                                            {
                                                                KullaniciCollection CollKim = new KullaniciCollection();
                                                                IPredicateExpression ExpKim = new PredicateExpression();
                                                                ExpKim.AddWithAnd(KullaniciFields.KullaniciAdSoyad == cb_per_list.Items[i].Text);
                                                                CollKim.GetMulti(ExpKim);

                                                                BildirimAtamaKullaniciEntity EntAta = new BildirimAtamaKullaniciEntity();
                                                                EntAta.FkBildirimId = CollAna[0].BildirimId;
                                                                EntAta.FkKullaniciId = CollKim[0].KullaniciId;
                                                                EntAta.BildirimAtamaKullaniciBittiMi = false;
                                                                EntAta.BildirimAtamaKullaniciTarih = DateTime.Now;
                                                                EntAta.BildirimAtamaKullaniciYonMu = "Hayır";
                                                                EntAta.Save();

                                                                if (bas_ad == "")
                                                                {
                                                                    bas_ad = bas_ad + CollKim[0].KullaniciAdSoyad;
                                                                }

                                                                else
                                                                {
                                                                    bas_ad = bas_ad + ", " + CollKim[0].KullaniciAdSoyad;
                                                                }
                                                            }
                                                        }

                                                        for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                                        {
                                                            if (cb_grup_list.Items[i].Selected == true)
                                                            {
                                                                GrupCollection CollGr = new GrupCollection();
                                                                IPredicateExpression ExpGr = new PredicateExpression();
                                                                ExpGr.AddWithAnd(GrupFields.GrupAd == cb_grup_list.Items[i].Text);
                                                                CollGr.GetMulti(ExpGr);

                                                                BildirimAtamaGrupEntity EntAta = new BildirimAtamaGrupEntity();
                                                                EntAta.FkBildirimId = CollAna[0].BildirimId;
                                                                EntAta.FkGrupId = CollGr[0].GrupId;
                                                                EntAta.BildirimAtamaGrupTarih = DateTime.Now;
                                                                EntAta.BildirimAtamaGrupYonMu = "Hayır";
                                                                EntAta.Save();
                                                            }
                                                        }

                                                        BildirimIslemCollection CollIs2 = new BildirimIslemCollection();
                                                        IPredicateExpression ExpIs2 = new PredicateExpression();
                                                        ExpIs2.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "Kullanıcı/Grup Ataması Yapıldı");
                                                        CollIs2.GetMulti(ExpIs2);

                                                        BildirimHistoryEntity EntHis2 = new BildirimHistoryEntity();
                                                        EntHis2.FkBildirimId = CollAna[0].BildirimId;
                                                        EntHis2.FkBildirimIslemId = CollIs2[0].BildirimIslemId;
                                                        EntHis2.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                                        EntHis2.BildirimHistoryTarih = DateTime.Now;
                                                        EntHis2.BildirimHistorySure = "0";
                                                        EntHis2.BildirimHistoryAciklama = CollKul22[0].KullaniciAdSoyad + " tarafından bildirim " + bas_ad + "'e/a atandı.";
                                                        EntHis2.Save();
                                                    }

                                                    string CloseWindow;
                                                    CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                                    DosyaCollection CollDos = new DosyaCollection();
                                                    IPredicateExpression ExpDos = new PredicateExpression();
                                                    ExpDos.AddWithAnd(DosyaFields.DosyaBildirimi == CollAna[0].BildirimId);
                                                    CollDos.GetMulti(ExpDos);

                                                    for (int y = 0; y < CollDos.Count; y++)
                                                    {
                                                        CollDos[y].Delete();
                                                        CollDos[y].Save();
                                                    }

                                                    if (Session["file_path_1"] != null)
                                                    {
                                                        DosyaEntity EntDos = new DosyaEntity();
                                                        EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                        EntDos.DosyaIcerikDurum = "1";
                                                        EntDos.DosyaIcerikPath = Session["file_path_1"].ToString();
                                                        EntDos.DosyaIcerikTarih = DateTime.Now;
                                                        EntDos.Save();
                                                    }

                                                    if (Session["file_path_2"] != null)
                                                    {
                                                        DosyaEntity EntDos = new DosyaEntity();
                                                        EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                        EntDos.DosyaIcerikDurum = "1";
                                                        EntDos.DosyaIcerikPath = Session["file_path_2"].ToString();
                                                        EntDos.DosyaIcerikTarih = DateTime.Now;
                                                        EntDos.Save();
                                                    }

                                                    if (Session["file_path_3"] != null)
                                                    {
                                                        DosyaEntity EntDos = new DosyaEntity();
                                                        EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                        EntDos.DosyaIcerikDurum = "1";
                                                        EntDos.DosyaIcerikPath = Session["file_path_3"].ToString();
                                                        EntDos.DosyaIcerikTarih = DateTime.Now;
                                                        EntDos.Save();
                                                    }

                                                    Panel4.Enabled = false;
                                                    Panel5.Enabled = false;

                                                    cb_kayit_tur.Text = "";
                                                    cb_kayit_tur.NullText = "Seçiniz...";
                                                    txt_tc_no.Text = "";
                                                    btn_kps.Enabled = false; ;
                                                    txt_ad.Text = "";
                                                    txt_soyad.Text = "";
                                                    cb_cinsiyet.Text = "";
                                                    cb_cinsiyet.NullText = "Seçiniz...";
                                                    string hexValue23 = "#FFFFFF";
                                                    txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue23);
                                                    txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue23);
                                                    cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue23);
                                                    txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue23);

                                                    txt_dogum_tarihi.Text = "01.01.1900";
                                                    txt_tel_no.Text = "";
                                                    txt_mail.Text = "";
                                                    txt_adres.Text = "";
                                                    txt_pasaport.Text = "";
                                                    txt_vergi_no.Text = "";
                                                    txt_uyruk.Text = "";
                                                }

                                                else
                                                {
                                                    if (Session["say_kac"].ToString() != "0")
                                                    {
                                                        BildirimIslemCollection CollIs2 = new BildirimIslemCollection();
                                                        IPredicateExpression ExpIs2 = new PredicateExpression();
                                                        ExpIs2.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "İptal Edildi");
                                                        CollIs2.GetMulti(ExpIs2);

                                                        BildirimHistoryEntity EntHis2 = new BildirimHistoryEntity();
                                                        EntHis2.FkBildirimId = CollAna[0].BildirimId;
                                                        EntHis2.FkBildirimIslemId = CollIs2[0].BildirimIslemId;
                                                        EntHis2.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                                        EntHis2.BildirimHistoryTarih = DateTime.Now;
                                                        EntHis2.BildirimHistorySure = "0";
                                                        EntHis2.BildirimHistoryAciklama = CollKul22[0].KullaniciAdSoyad + " tarafından atama işlemleri iptal edildi.";
                                                        EntHis2.Save();

                                                        string CloseWindow;
                                                        CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                                        DosyaCollection CollDos = new DosyaCollection();
                                                        IPredicateExpression ExpDos = new PredicateExpression();
                                                        ExpDos.AddWithAnd(DosyaFields.DosyaBildirimi == CollAna[0].BildirimId);
                                                        CollDos.GetMulti(ExpDos);

                                                        for (int y = 0; y < CollDos.Count; y++)
                                                        {
                                                            CollDos[y].Delete();
                                                            CollDos[y].Save();
                                                        }

                                                        if (Session["file_path_1"] != null)
                                                        {
                                                            DosyaEntity EntDos = new DosyaEntity();
                                                            EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                            EntDos.DosyaIcerikDurum = "1";
                                                            EntDos.DosyaIcerikPath = Session["file_path_1"].ToString();
                                                            EntDos.DosyaIcerikTarih = DateTime.Now;
                                                            EntDos.Save();
                                                        }

                                                        if (Session["file_path_2"] != null)
                                                        {
                                                            DosyaEntity EntDos = new DosyaEntity();
                                                            EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                            EntDos.DosyaIcerikDurum = "1";
                                                            EntDos.DosyaIcerikPath = Session["file_path_2"].ToString();
                                                            EntDos.DosyaIcerikTarih = DateTime.Now;
                                                            EntDos.Save();
                                                        }

                                                        if (Session["file_path_3"] != null)
                                                        {
                                                            DosyaEntity EntDos = new DosyaEntity();
                                                            EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                            EntDos.DosyaIcerikDurum = "1";
                                                            EntDos.DosyaIcerikPath = Session["file_path_3"].ToString();
                                                            EntDos.DosyaIcerikTarih = DateTime.Now;
                                                            EntDos.Save();
                                                        }

                                                        Panel4.Enabled = false;
                                                        Panel5.Enabled = false;

                                                        cb_kayit_tur.Text = "";
                                                        cb_kayit_tur.NullText = "Seçiniz...";
                                                        txt_tc_no.Text = "";
                                                        btn_kps.Enabled = false; ;
                                                        txt_ad.Text = "";
                                                        txt_soyad.Text = "";
                                                        cb_cinsiyet.Text = "";
                                                        cb_cinsiyet.NullText = "Seçiniz...";
                                                        string hexValue22 = "#FFFFFF";
                                                        txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue22);
                                                        txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue22);
                                                        cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue22);
                                                        txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue22);

                                                        txt_dogum_tarihi.Text = "01.01.1900";
                                                        txt_tel_no.Text = "";
                                                        txt_mail.Text = "";
                                                        txt_adres.Text = "";
                                                        txt_pasaport.Text = "";
                                                        txt_vergi_no.Text = "";
                                                        txt_uyruk.Text = "";
                                                    }

                                                    else
                                                    {
                                                        string CloseWindow;
                                                        CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                                        DosyaCollection CollDos = new DosyaCollection();
                                                        IPredicateExpression ExpDos = new PredicateExpression();
                                                        ExpDos.AddWithAnd(DosyaFields.DosyaBildirimi == CollAna[0].BildirimId);
                                                        CollDos.GetMulti(ExpDos);

                                                        for (int y = 0; y < CollDos.Count; y++)
                                                        {
                                                            CollDos[y].Delete();
                                                            CollDos[y].Save();
                                                        }

                                                        if (Session["file_path_1"] != null)
                                                        {
                                                            DosyaEntity EntDos = new DosyaEntity();
                                                            EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                            EntDos.DosyaIcerikDurum = "1";
                                                            EntDos.DosyaIcerikPath = Session["file_path_1"].ToString();
                                                            EntDos.DosyaIcerikTarih = DateTime.Now;
                                                            EntDos.Save();
                                                        }

                                                        if (Session["file_path_2"] != null)
                                                        {
                                                            DosyaEntity EntDos = new DosyaEntity();
                                                            EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                            EntDos.DosyaIcerikDurum = "1";
                                                            EntDos.DosyaIcerikPath = Session["file_path_2"].ToString();
                                                            EntDos.DosyaIcerikTarih = DateTime.Now;
                                                            EntDos.Save();
                                                        }

                                                        if (Session["file_path_3"] != null)
                                                        {
                                                            DosyaEntity EntDos = new DosyaEntity();
                                                            EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                                            EntDos.DosyaIcerikDurum = "1";
                                                            EntDos.DosyaIcerikPath = Session["file_path_3"].ToString();
                                                            EntDos.DosyaIcerikTarih = DateTime.Now;
                                                            EntDos.Save();
                                                        }

                                                        Panel4.Enabled = false;
                                                        Panel5.Enabled = false;

                                                        cb_kayit_tur.Text = "";
                                                        cb_kayit_tur.NullText = "Seçiniz...";
                                                        txt_tc_no.Text = "";
                                                        btn_kps.Enabled = false; ;
                                                        txt_ad.Text = "";
                                                        txt_soyad.Text = "";
                                                        cb_cinsiyet.Text = "";
                                                        cb_cinsiyet.NullText = "Seçiniz...";
                                                        string hexValue20 = "#FFFFFF";
                                                        txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue20);
                                                        txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue20);
                                                        cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue20);
                                                        txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue20);
                                                        txt_dogum_tarihi.Text = "01.01.1900";
                                                        txt_tel_no.Text = "";
                                                        txt_mail.Text = "";
                                                        txt_adres.Text = "";
                                                        txt_pasaport.Text = "";
                                                        txt_vergi_no.Text = "";
                                                        txt_uyruk.Text = "";
                                                    }
                                                }

                                                ParametreCollection CollPrm = new ParametreCollection();
                                                IPredicateExpression ExpPrm = new PredicateExpression();
                                                ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
                                                CollPrm.GetMulti(ExpPrm);

                                                DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

                                                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                                                ISortExpression sort22 = new SortExpression();
                                                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                                                IPredicateExpression filter2 = new PredicateExpression();
                                                filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                                                bil_list.Fill(0, sort22, true, filter2);

                                                grid_bildirim.DataSource = bil_list;
                                                grid_bildirim.DataBind();                                               

                                                grid_bildirim_sil.DataSource = bil_list;
                                                grid_bildirim_sil.DataBind();

                                                txt_kisisel_measj.Text = "";
                                                cb_havalimani.Text = "";
                                                cb_havalimani.NullText = "Seçiniz...";
                                                pnl_sorgu.Visible = false;
                                                cb_tur.Text = "";
                                                cb_tur.NullText = "Seçiniz...";
                                                cb_sekil.Text = "";
                                                cb_sekil.NullText = "Seçiniz...";
                                                btn_yukle.Enabled = false;
                                                cb_konu.Text = "";
                                                cb_konu.NullText = "Seçiniz...";
                                                txt_not.Text = "";
                                                txt_dava_ad_soyad.Text = "";
                                                txt_dava_dosya_no.Text = "";
                                                txt_dava_konu.Text = "";
                                                txt_dava_mahkeme_adi.Text = "";
                                                cb_cag_tip.Text = "";
                                                cb_cag_tip.NullText = "Seçiniz...";
                                                cb_kapat.Checked = false;
                                                cb_kayit_tur.Text = "";
                                                cb_kayit_tur.NullText = "Seçiniz...";
                                                txt_tc_no.Text = "";
                                                btn_kps.Enabled = false; ;
                                                txt_ad.Text = "";
                                                txt_soyad.Text = "";
                                                cb_cinsiyet.Text = "";
                                                cb_cinsiyet.NullText = "Seçiniz...";
                                                string hexValue24 = "#FFFFFF";
                                                txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue24);
                                                txt_pasaport.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue24);
                                                txt_uyruk.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue24);
                                                txt_ad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue24);
                                                txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue24);
                                                cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue24);
                                                txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue24);
                                                txt_dogum_tarihi.Text = "01.01.1900";
                                                txt_tel_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue24);
                                                txt_mail.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue24);
                                                txt_adres.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue24);
                                                txt_tel_no.Text = "";
                                                txt_mail.Text = "";
                                                txt_adres.Text = "";
                                                txt_pasaport.Text = "";
                                                txt_vergi_no.Text = "";
                                                txt_uyruk.Text = "";

                                                for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                                {
                                                    cb_grup_list.Items[i].Selected = false;
                                                }

                                                for (int i = 0; i < cb_per_list.Items.Count; i++)
                                                {
                                                    cb_per_list.Items[i].Selected = false;
                                                }

                                                cb_gr_hep.Checked = false;
                                                cb_hepsi.Checked = false;
                                                txt_cagri_sayisi.Text = "";
                                                btn_gor.Enabled = false;

                                                Session["vat_id"] = null;

                                                cb_tur.Focus();
                                            }
                                        }
                                    }
                                }

                                Session["vat_id"] = null;
                            }

                            //vatandaş var
                            else
                            {
                                say_grup = 0;
                                say_kul = 0;

                                for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                {
                                    if (cb_grup_list.Items[i].Selected == true)
                                    {
                                        say_grup = say_grup + 1;
                                    }
                                }

                                for (int i = 0; i < cb_per_list.Items.Count; i++)
                                {
                                    if (cb_per_list.Items[i].Selected == true)
                                    {
                                        say_kul = say_kul + 1;
                                    }
                                }

                                KullaniciCollection CollKul = new KullaniciCollection();
                                IPredicateExpression ExpKul = new PredicateExpression();
                                ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                                CollKul.GetMulti(ExpKul);

                                BildirimTuruCollection CollTur = new BildirimTuruCollection();
                                IPredicateExpression ExpTur = new PredicateExpression();
                                ExpTur.AddWithAnd(BildirimTuruFields.BildirimTuruAd == cb_tur.Text);
                                CollTur.GetMulti(ExpTur);

                                BildirimSonucCollection CollSonAta = new BildirimSonucCollection();
                                IPredicateExpression ExpSonAta = new PredicateExpression();
                                ExpSonAta.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                                CollSonAta.GetMulti(ExpSonAta);

                                BildirimSonucCollection CollSonKay = new BildirimSonucCollection();
                                IPredicateExpression ExpSonKay = new PredicateExpression();
                                ExpSonKay.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Kayıt Altına Alındı");
                                CollSonKay.GetMulti(ExpSonKay);

                                BildirimSonucCollection CollBit = new BildirimSonucCollection();
                                IPredicateExpression ExpBit = new PredicateExpression();
                                ExpBit.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Sonuçlandı");
                                CollBit.GetMulti(ExpBit);

                                BildirimGeriDonuCollection CollGeri = new BildirimGeriDonuCollection();
                                IPredicateExpression ExpGeri = new PredicateExpression();
                                ExpGeri.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusAd == cb_sekil.Text);
                                CollGeri.GetMulti(ExpGeri);

                                AltKonuCollection CollAlt = new AltKonuCollection();
                                IPredicateExpression ExpAlt = new PredicateExpression();

                                if (cb_konu.Text != "")
                                {
                                    ExpAlt.AddWithAnd(AltKonuFields.AltKonuAd == cb_konu.Text);
                                }

                                else
                                {
                                    ExpAlt.AddWithAnd(AltKonuFields.AltKonuAd == "Diğer");
                                }

                                CollAlt.GetMulti(ExpAlt);

                                KonuCollection CollKon = new KonuCollection();
                                IPredicateExpression ExpKon = new PredicateExpression();
                                ExpKon.AddWithAnd(KonuFields.KonuId == CollAlt[0].FkKonuId);
                                CollKon.GetMulti(ExpKon);

                                if (Session["par_guncelle_mi"].ToString() == "0")
                                {
                                    BildirimEntity EntKay = new BildirimEntity();

                                    CagriTipiCollection CollTit = new CagriTipiCollection();
                                    IPredicateExpression ExpTit = new PredicateExpression();
                                    ExpTit.AddWithAnd(CagriTipiFields.CagriTipiAd == cb_cag_tip.Text);
                                    CollTit.GetMulti(ExpTit);

                                    EntKay.FkCagriTipiId = CollTit[0].CagriTipiId;

                                    if (cb_havalimani.Text == "" || cb_havalimani.NullText == "Seçiniz...")
                                    {
                                        EntKay.BildirimHavalimani = cb_havalimani.Text;
                                    }

                                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                    EntKay.BildirimGeriYapildiMi = false;
                                    EntKay.FkVatandasId = Convert.ToInt64(Session["vat_id"].ToString());
                                    EntKay.FkBildirimTuruId = CollTur[0].BildirimTuruId;

                                    if (cb_kapat.Checked == true)
                                    {
                                        EntKay.FkBildirimSonucId = CollBit[0].BildirimSonucId;
                                        EntKay.BildirimAtanmaDurumu = "Bilgi verildi-Kapatıldı.";
                                        EntKay.BildirimVatandasKarar = txt_not.Text;
                                    }

                                    else
                                    {
                                        if (say_grup == 0 && say_kul == 0)
                                        {
                                            EntKay.FkBildirimSonucId = CollSonKay[0].BildirimSonucId;
                                            EntKay.BildirimAtanmaDurumu = "Atama yapılmadı.";
                                        }

                                        else
                                        {
                                            EntKay.FkBildirimSonucId = CollSonAta[0].BildirimSonucId;

                                            if (say_grup == 0)
                                            {
                                                EntKay.BildirimAtanmaDurumu = say_kul.ToString() + " kullanıcıya atandı.";
                                            }

                                            else
                                            {
                                                if (say_grup == 1)
                                                {
                                                    string gr_adi = "";

                                                    for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                                    {
                                                        if (cb_grup_list.Items[i].Selected == true)
                                                        {
                                                            gr_adi = cb_grup_list.Items[i].Text;
                                                        }
                                                    }

                                                    EntKay.BildirimAtanmaDurumu = gr_adi.ToUpper() + "-" + say_grup.ToString() + " grup, " + say_kul.ToString() + " kullanıcıya atandı.";
                                                }

                                                else
                                                {
                                                    EntKay.BildirimAtanmaDurumu = "BİRKAÇ GRUP-" + say_grup.ToString() + " grup, " + say_kul.ToString() + " kullanıcıya atandı.";
                                                }
                                            }
                                        }
                                    }

                                    if (CollGeri.Count > 0)
                                    {
                                        EntKay.FkBildirimGeriDonusId = CollGeri[0].BildirimGeriDonusId;
                                    }

                                    else
                                    {
                                        BildirimGeriDonuCollection CollDon = new BildirimGeriDonuCollection();
                                        IPredicateExpression ExpDon = new PredicateExpression();
                                        ExpDon.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusAd == "Hiçbiri");
                                        CollDon.GetMulti(ExpDon);

                                        EntKay.FkBildirimGeriDonusId = CollDon[0].BildirimGeriDonusId;
                                    }

                                    EntKay.FkAltKonuId = CollAlt[0].AltKonuId;
                                    EntKay.BildirimGelenYer = cb_sistem.Text;

                                    EntKay.BildirimTarih = DateTime.Now;
                                    EntKay.BildirimSonIslemTarih = DateTime.Now;

                                    DateTime bas_tar_al = DateTime.Now;

                                    string tar_yil = DateTime.Now.Year.ToString();

                                    EntKay.BildirimYil = Convert.ToInt16(tar_yil);
                                    EntKay.BildirimMetin = txt_not.Text;

                                    if (cb_tur.Text == "Dava Bildirimi")
                                    {
                                        EntKay.BildirimDavaAdSoyad = txt_dava_ad_soyad.Text;
                                        EntKay.BildirimDavaDosyaNo = txt_dava_dosya_no.Text;
                                        EntKay.BildirimDavaKonu = txt_dava_konu.Text;
                                        EntKay.BildirimDavaMahkeme = txt_dava_mahkeme_adi.Text;
                                    }

                                    if (txt_kisisel_measj.Text != "")
                                    {
                                        EntKay.BildirimAciklama = CollKul[0].KullaniciAdSoyad + " - '" + txt_kisisel_measj.Text + "'.";
                                    }

                                    if (cb_kapat.Checked == true)
                                    {
                                        VatandaCollection CollVatt = new VatandaCollection();
                                        IPredicateExpression ExpVatt = new PredicateExpression();
                                        ExpVatt.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                                        CollVatt.GetMulti(ExpVatt);

                                        TimeSpan fark_bak1 = DateTime.Now - CollVatt[0].VatandasIslemTarih;
                                        string duzle = (fark_bak1.TotalHours).ToString();
                                        double arasi = Convert.ToDouble(duzle);
                                        Int16 ana_fark = Convert.ToInt16(arasi);
                                        Int16 saat = 0;
                                        Int16 gun = 0;
                                        Int16 ay = 0;
                                        Int16 yil = 0;

                                        string fark_olustur = "";

                                        if (ana_fark > 168)
                                        {
                                            ana_fark = 1;
                                        }

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

                                        if (cb_kapat.Checked == true)
                                        {
                                            EntKay.BildirimToplamSure = "5 Dakika";
                                        }

                                        else
                                        {
                                            EntKay.BildirimToplamSure = fark_olustur;
                                        }
                                    }

                                    else
                                    {
                                        EntKay.BildirimToplamSure = "-";
                                    }

                                    EntKay.Save();

                                    VatandaCollection CollBak = new VatandaCollection();
                                    IPredicateExpression ExpBak = new PredicateExpression();
                                    ExpBak.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                                    CollBak.GetMulti(ExpBak);

                                    KullaniciCollection CollKules = new KullaniciCollection();
                                    IPredicateExpression ExpKules = new PredicateExpression();
                                    ExpKules.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                                    CollKules.GetMulti(ExpKules);

                                    if (CollKules[0].KullaniciAdSoyad == "Dilek ŞAHİN" || CollKules[0].KullaniciAdSoyad == "Soner HIRAMAN" || CollKules[0].KullaniciAdSoyad == "Zafer HARTOĞLU" || CollKules[0].KullaniciAdSoyad == "Mustafa ÜNAL") 
                                    {
                                        if (txt_tc_no.Text != "")
                                        {
                                            CollBak[0].VatandasTcNo = txt_tc_no.Text;
                                        }

                                        CollBak[0].VatandasTur = cb_kayit_tur.Text;
                                        CollBak[0].VatandasAd = txt_ad.Text.ToUpper();
                                        CollBak[0].VatandasSoyad = txt_soyad.Text.ToUpper();
                                        CollBak[0].VatandasAdSoyad = txt_ad.Text.ToUpper() + " " + txt_soyad.Text.ToUpper();

                                        if (txt_uyruk.Text != "")
                                        {
                                            CollBak[0].VatandasUyruk = txt_uyruk.Text;
                                        }

                                        if (txt_pasaport.Text != "")
                                        {
                                            CollBak[0].VatandasPasaportNo = txt_pasaport.Text;
                                        }

                                        if (txt_vergi_no.Text != "")
                                        {
                                            CollBak[0].VatandasVergiNo = txt_vergi_no.Text;
                                        }

                                        if (cb_cinsiyet.Text != "")
                                        {
                                            CollBak[0].VatandasCinsiyet = cb_cinsiyet.Text;
                                        }

                                        if (txt_dogum_tarihi.Text != "01.01.1900")
                                        {
                                            CollBak[0].VatandasDogumTarihi = Convert.ToDateTime(txt_dogum_tarihi.Text);
                                        }

                                        if (txt_mail.Text != "")
                                        {
                                            CollBak[0].VatandasMail = txt_mail.Text;
                                        }

                                        if (txt_adres.Text != "")
                                        {
                                            CollBak[0].VatandasAdres = txt_adres.Text;
                                        }

                                        if (txt_tel_no.Text != "")
                                        {
                                            CollBak[0].VatandasTel1 = txt_tel_no.Text.Trim().Replace(" ", string.Empty);
                                        }

                                        CollBak[0].VatandasIslemTarih = DateTime.Now;
                                        CollBak[0].Save();
                                    }                                    

                                    string icerik = txt_not.Text;

                                    BildirimCollection CollArra = new BildirimCollection();
                                    IPredicateExpression ExpArra = new PredicateExpression();
                                    ExpArra.AddWithAnd(BildirimFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                                    ExpArra.AddWithAnd(BildirimFields.FkVatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                                    ExpArra.AddWithAnd(BildirimFields.FkAltKonuId == CollAlt[0].AltKonuId);
                                    ExpArra.AddWithAnd(BildirimFields.BildirimSonIslemTarih == bas_tar_al);
                                    CollArra.GetMulti(ExpArra);

                                    Int64 numarasi = CollArra[0].BildirimId;

                                    string CloseWindow2;
                                    CloseWindow2 = "alert('Kayıt işlemi tamamlanmıştır...')";
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow2", CloseWindow2, true);

                                    if (Session["file_path_1"] != null)
                                    {
                                        DosyaEntity EntDos = new DosyaEntity();
                                        EntDos.DosyaBildirimi = numarasi;
                                        EntDos.DosyaIcerikDurum = "1";
                                        EntDos.DosyaIcerikPath = Session["file_path_1"].ToString();
                                        EntDos.DosyaIcerikTarih = DateTime.Now;
                                        EntDos.Save();
                                    }

                                    if (Session["file_path_2"] != null)
                                    {
                                        DosyaEntity EntDos = new DosyaEntity();
                                        EntDos.DosyaBildirimi = numarasi;
                                        EntDos.DosyaIcerikDurum = "1";
                                        EntDos.DosyaIcerikPath = Session["file_path_2"].ToString();
                                        EntDos.DosyaIcerikTarih = DateTime.Now;
                                        EntDos.Save();
                                    }

                                    if (Session["file_path_3"] != null)
                                    {
                                        DosyaEntity EntDos = new DosyaEntity();
                                        EntDos.DosyaBildirimi = numarasi;
                                        EntDos.DosyaIcerikDurum = "1";
                                        EntDos.DosyaIcerikPath = Session["file_path_3"].ToString();
                                        EntDos.DosyaIcerikTarih = DateTime.Now;
                                        EntDos.Save();
                                    }

                                    BildirimTuruCollection CollBilTur = new BildirimTuruCollection();
                                    IPredicateExpression ExpBilTur = new PredicateExpression();
                                    ExpBilTur.AddWithAnd(BildirimTuruFields.BildirimTuruAd == cb_tur.Text);
                                    CollBilTur.GetMulti(ExpBilTur);

                                    if (CollBilTur[0].BildirimTuruMail == true && cb_kapat.Checked == false && cb_sekil.Text == "E-Posta")
                                    {
                                        string konusu = "DHMİ İletişim Merkezi Bildirim Talebi";
                                        string maili = txt_mail.Text;
                                        string bil_git = numarasi.ToString();

                                        if (txt_mail.Text != "")
                                        {
                                            if (cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
                                            {
                                                Mail.MailGonderBildirimEng(maili, "General Directorate Of State Airports Authority (DHMI) Call Center", bil_git);
                                            }

                                            else
                                            {
                                                Mail.MailGonderBildirim(maili, konusu, bil_git);
                                            }
                                        }
                                    }

                                    if (CollBilTur[0].BildirimTuruSms == true && cb_kapat.Checked == false && cb_sekil.Text == "SMS")
                                    {
                                        if (txt_tel_no.Text != "")
                                        {
                                            //SMSGonder
                                            try
                                            {
                                                string gsmNo = txt_tel_no.Text.Trim().Replace(" ", string.Empty);
                                                gsmNo = gsmNo.TrimStart('0');
                                                Int32 bildirim_nosu = Convert.ToInt32(numarasi);

                                                if (cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
                                                {
                                                    string smsMessage = string.Format(ConfigurationManager.AppSettings["SmsNewRecordContentEng"], bildirim_nosu);
                                                    Helper.SendSms(gsmNo, smsMessage, bildirim_nosu);
                                                }

                                                else
                                                {
                                                    string smsMessage = string.Format(ConfigurationManager.AppSettings["SmsNewRecordContent"], bildirim_nosu);
                                                    Helper.SendSms(gsmNo, smsMessage, bildirim_nosu);
                                                }
                                            }

                                            catch
                                            {
                                                //Telefon Numarasında Sorun Varsa Direkt Geç...
                                            }
                                        }
                                    }

                                    Panel4.Enabled = false;
                                    Panel5.Enabled = false;

                                    /*
                                    cb_kayit_tur.Text = "";
                                    cb_kayit_tur.NullText = "Seçiniz...";
                                    txt_tc_no.Text = "";
                                    btn_kps.Enabled = false; ;
                                    txt_ad.Text = "";
                                    txt_soyad.Text = "";
                                    cb_cinsiyet.Text = "";
                                    cb_cinsiyet.NullText = "Seçiniz...";
                                    string hexValue2 = "#FFFFFF";
                                    txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                    txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                    cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                    txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);

                                    txt_dogum_tarihi.Text = "01.01.1900";
                                    txt_tel_no.Text = "";
                                    txt_mail.Text = "";
                                    txt_adres.Text = "";*/

                                    BildirimIslemCollection CollIs = new BildirimIslemCollection();
                                    IPredicateExpression ExpIs = new PredicateExpression();
                                    ExpIs.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "Kayıt Altına Alındı");
                                    CollIs.GetMulti(ExpIs);

                                    BildirimCollection CollKac = new BildirimCollection();
                                    IPredicateExpression ExpKac = new PredicateExpression();
                                    ExpKac.AddWithAnd(BildirimFields.BildirimId == numarasi);
                                    CollKac.GetMulti(ExpKac);

                                    BildirimHistoryEntity EntHis = new BildirimHistoryEntity();
                                    EntHis.FkBildirimId = CollKac[0].BildirimId;
                                    EntHis.FkBildirimIslemId = CollIs[0].BildirimIslemId;
                                    EntHis.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                    EntHis.BildirimHistoryTarih = DateTime.Now;
                                    EntHis.BildirimHistorySure = "0";
                                    EntHis.BildirimHistoryAciklama = CollKul[0].KullaniciAdSoyad + " tarafından kayıt altına alındı.";
                                    EntHis.Save();

                                    if (say_grup != 0 || say_kul != 0)
                                    {
                                        string bas_ad = "";

                                        for (int i = 0; i < cb_per_list.Items.Count; i++)
                                        {
                                            if (cb_per_list.Items[i].Selected == true)
                                            {
                                                KullaniciCollection CollKim = new KullaniciCollection();
                                                IPredicateExpression ExpKim = new PredicateExpression();
                                                ExpKim.AddWithAnd(KullaniciFields.KullaniciAdSoyad == cb_per_list.Items[i].Text);
                                                CollKim.GetMulti(ExpKim);

                                                BildirimAtamaKullaniciEntity EntAta = new BildirimAtamaKullaniciEntity();
                                                EntAta.FkBildirimId = CollKac[0].BildirimId;
                                                EntAta.FkKullaniciId = CollKim[0].KullaniciId;
                                                EntAta.BildirimAtamaKullaniciBittiMi = false;
                                                EntAta.BildirimAtamaKullaniciTarih = DateTime.Now;
                                                EntAta.BildirimAtamaKullaniciYonMu = "Hayır";
                                                EntAta.Save();

                                                try
                                                {
                                                    string konusu = "DHMİ İletişim Merkezi Bildirim Talebi";
                                                    string maili = CollKim[0].KullaniciMail;
                                                    string bsl = "www.alo.dhmi.gov.tr/McCallCenterLinkControlAsLogin.aspx?";
                                                    string bas_coz = "dhmi";
                                                    string bit_coz = "callcenter";
                                                    string dhmi_bas = Kullanici.sifre_olustur(bas_coz);
                                                    string dhmi_bit = Kullanici.sifre_olustur(bit_coz);
                                                    string aradaki_kul = CollKim[0].KullaniciId.ToString();
                                                    aradaki_kul = Kullanici.sifre_olustur(aradaki_kul);
                                                    string linki = dhmi_bas + aradaki_kul + dhmi_bit;

                                                    string kayit_link = bsl + linki;

                                                    Mail.MailLinkGonder(CollKac[0].BildirimId.ToString(), linki, maili, konusu, icerik);

                                                    MailBankEntity EntBan = new MailBankEntity();
                                                    EntBan.MailBanksLink = kayit_link;
                                                    EntBan.MailBanksBildirim = CollKac[0].BildirimId;
                                                    EntBan.MailBanksKullanici = CollKim[0].KullaniciId;
                                                    EntBan.MailBanksTikAdet = 0;
                                                    EntBan.MailBanksTarih = DateTime.Now;
                                                    EntBan.MailBanksDurum = true;
                                                    EntBan.Save();
                                                }

                                                catch
                                                {
                                                    //Mail Adresinde Sorun Varsa Direkt Geç...
                                                }

                                                if (bas_ad == "")
                                                {
                                                    bas_ad = bas_ad + CollKim[0].KullaniciAdSoyad;
                                                }

                                                else
                                                {
                                                    bas_ad = bas_ad + ", " + CollKim[0].KullaniciAdSoyad;
                                                }
                                            }
                                        }

                                        for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                        {
                                            if (cb_grup_list.Items[i].Selected == true)
                                            {
                                                GrupCollection CollGr = new GrupCollection();
                                                IPredicateExpression ExpGr = new PredicateExpression();
                                                ExpGr.AddWithAnd(GrupFields.GrupAd == cb_grup_list.Items[i].Text);
                                                CollGr.GetMulti(ExpGr);

                                                BildirimAtamaGrupEntity EntAta = new BildirimAtamaGrupEntity();
                                                EntAta.FkBildirimId = CollKac[0].BildirimId;
                                                EntAta.FkGrupId = CollGr[0].GrupId;
                                                EntAta.BildirimAtamaGrupTarih = DateTime.Now;
                                                EntAta.BildirimAtamaGrupYonMu = "Hayır";
                                                EntAta.Save();
                                            }
                                        }

                                        BildirimIslemCollection CollIs2 = new BildirimIslemCollection();
                                        IPredicateExpression ExpIs2 = new PredicateExpression();
                                        ExpIs2.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "Kullanıcı/Grup Ataması Yapıldı");
                                        CollIs2.GetMulti(ExpIs2);

                                        BildirimHistoryEntity EntHis2 = new BildirimHistoryEntity();
                                        EntHis2.FkBildirimId = CollKac[0].BildirimId;
                                        EntHis2.FkBildirimIslemId = CollIs2[0].BildirimIslemId;
                                        EntHis2.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                        EntHis2.BildirimHistoryTarih = DateTime.Now;
                                        EntHis2.BildirimHistorySure = "0";
                                        EntHis2.BildirimHistoryAciklama = CollKul[0].KullaniciAdSoyad + " tarafından bildirim " + bas_ad + "'e/a atandı.";
                                        EntHis2.Save();

                                        SureTakipEntity EntSure = new SureTakipEntity();
                                        EntSure.FkBildirimId = CollKac[0].BildirimId;
                                        EntSure.SureTakipTuru = "Kayıtta Bekleme Süresi";
                                        EntSure.SureTakipTarih = DateTime.Now;
                                        EntSure.SureTakipSaat = 0;
                                        EntSure.SureTakipGun = 0;
                                        EntSure.Save();
                                    }

                                    ParametreCollection CollPrm = new ParametreCollection();
                                    IPredicateExpression ExpPrm = new PredicateExpression();
                                    ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
                                    CollPrm.GetMulti(ExpPrm);

                                    DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

                                    ListBildirimTypedList bil_list = new ListBildirimTypedList();
                                    ISortExpression sort22 = new SortExpression();
                                    sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                                    IPredicateExpression filter2 = new PredicateExpression();
                                    filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                                    bil_list.Fill(0, sort22, true, filter2);

                                    grid_bildirim.DataSource = bil_list;
                                    grid_bildirim.DataBind();

                                    grid_bildirim_sil.DataSource = bil_list;
                                    grid_bildirim_sil.DataBind();                                   

                                    txt_kisisel_measj.Text = "";
                                    cb_havalimani.Text = "";
                                    cb_havalimani.NullText = "Seçiniz...";
                                    pnl_sorgu.Visible = false;
                                    cb_tur.Text = "";
                                    cb_tur.NullText = "Seçiniz...";
                                    cb_sekil.Text = "";
                                    cb_sekil.NullText = "Seçiniz...";
                                    btn_yukle.Enabled = false;
                                    cb_konu.Text = "";
                                    cb_konu.NullText = "Seçiniz...";
                                    txt_not.Text = "";
                                    txt_dava_ad_soyad.Text = "";
                                    txt_dava_dosya_no.Text = "";
                                    txt_dava_konu.Text = "";
                                    txt_dava_mahkeme_adi.Text = "";
                                    cb_cag_tip.Text = "";
                                    cb_cag_tip.NullText = "Seçiniz...";
                                    cb_kapat.Checked = false;
                                    cb_kayit_tur.Text = "";
                                    cb_kayit_tur.NullText = "Seçiniz...";
                                    txt_tc_no.Text = "";
                                    btn_kps.Enabled = false; ;
                                    txt_ad.Text = "";
                                    txt_soyad.Text = "";
                                    cb_cinsiyet.Text = "";
                                    cb_cinsiyet.NullText = "Seçiniz...";
                                    string hexValue26 = "#FFFFFF";
                                    txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue26);
                                    txt_pasaport.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue26);
                                    txt_uyruk.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue26);
                                    txt_ad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue26);
                                    txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue26);
                                    cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue26);
                                    txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue26);
                                    txt_dogum_tarihi.Text = "01.01.1900";
                                    txt_tel_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue26);
                                    txt_mail.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue26);
                                    txt_adres.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue26);
                                    txt_tel_no.Text = "";
                                    txt_mail.Text = "";
                                    txt_adres.Text = "";

                                    for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                    {
                                        cb_grup_list.Items[i].Selected = false;
                                    }

                                    for (int i = 0; i < cb_per_list.Items.Count; i++)
                                    {
                                        cb_per_list.Items[i].Selected = false;
                                    }

                                    cb_gr_hep.Checked = false;
                                    cb_hepsi.Checked = false;
                                    txt_cagri_sayisi.Text = "";
                                    btn_gor.Enabled = false;

                                    Session["vat_id"] = null;

                                    cb_tur.Focus();
                                }

                                //omot
                                else
                                {
                                    BildirimCollection CollAna = new BildirimCollection();
                                    IPredicateExpression ExpAna = new PredicateExpression();
                                    ExpAna.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserName.Text));
                                    CollAna.GetMulti(ExpAna);
                                    
                                    if (Session["gnc_turu"].ToString() == "Ekstra")
                                    {
                                        BildirimAtamaKullaniciCollection CollSil = new BildirimAtamaKullaniciCollection();
                                        IPredicateExpression ExpSil = new PredicateExpression();
                                        ExpSil.AddWithAnd(BildirimAtamaKullaniciFields.FkBildirimId == CollAna[0].BildirimId);
                                        CollSil.GetMulti(ExpSil);

                                        for (int i = 0; i < CollSil.Count; i++)
                                        {
                                            CollSil[i].Delete();
                                            CollSil[i].Save();
                                        }

                                        BildirimAtamaGrupCollection CollSil2 = new BildirimAtamaGrupCollection();
                                        IPredicateExpression ExpSil2 = new PredicateExpression();
                                        ExpSil2.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollAna[0].BildirimId);
                                        CollSil2.GetMulti(ExpSil2);

                                        for (int i = 0; i < CollSil2.Count; i++)
                                        {
                                            CollSil2[i].Delete();
                                            CollSil2[i].Save();
                                        }
                                    }

                                    CollAna[0].FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                    CollAna[0].FkBildirimTuruId = CollTur[0].BildirimTuruId;

                                    if (cb_kapat.Checked == true)
                                    {
                                        CollAna[0].FkBildirimSonucId = CollBit[0].BildirimSonucId;
                                        CollAna[0].BildirimAtanmaDurumu = "Bilgi verildi-Kapatıldı.";
                                        CollAna[0].BildirimVatandasKarar = txt_not.Text;
                                    }

                                    else
                                    {
                                        if (Session["gnc_turu"].ToString() == "Ekstra")
                                        {
                                            if (say_grup == 0 && say_kul == 0)
                                            {
                                                CollAna[0].FkBildirimSonucId = CollSonKay[0].BildirimSonucId;
                                                CollAna[0].BildirimAtanmaDurumu = "Atama yapılmadı.";
                                            }

                                            else
                                            {
                                                CollAna[0].FkBildirimSonucId = CollSonAta[0].BildirimSonucId;

                                                if (say_grup == 0)
                                                {
                                                    CollAna[0].BildirimAtanmaDurumu = say_kul.ToString() + " kullanıcıya atandı.";
                                                }

                                                else
                                                {
                                                    if (say_grup == 1)
                                                    {
                                                        string gr_adi = "";

                                                        for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                                        {
                                                            if (cb_grup_list.Items[i].Selected == true)
                                                            {
                                                                gr_adi = cb_grup_list.Items[i].Text;
                                                            }
                                                        }

                                                        CollAna[0].BildirimAtanmaDurumu = gr_adi.ToUpper() + "-" + say_grup.ToString() + " grup, " + say_kul.ToString() + " kullanıcıya atandı.";
                                                    }

                                                    else
                                                    {
                                                        CollAna[0].BildirimAtanmaDurumu = "BİRKAÇ GRUP-" + say_grup.ToString() + " grup, " + say_kul.ToString() + " kullanıcıya atandı.";
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    if (CollGeri.Count > 0)
                                    {
                                        CollAna[0].FkBildirimGeriDonusId = CollGeri[0].BildirimGeriDonusId;
                                    }

                                    else
                                    {
                                        BildirimGeriDonuCollection CollDon = new BildirimGeriDonuCollection();
                                        IPredicateExpression ExpDon = new PredicateExpression();
                                        ExpDon.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusAd == "Hiçbiri");
                                        CollDon.GetMulti(ExpDon);

                                        CollAna[0].FkBildirimGeriDonusId = CollDon[0].BildirimGeriDonusId;
                                    }

                                    CollAna[0].FkAltKonuId = CollAlt[0].AltKonuId;
                                    CollAna[0].BildirimGelenYer = cb_sistem.Text;

                                    if (cb_havalimani.Text == "" || cb_havalimani.NullText == "Seçiniz...")
                                    {
                                        CollAna[0].BildirimHavalimani = cb_havalimani.Text;
                                    }

                                    CollAna[0].BildirimSonIslemTarih = DateTime.Now;
                                    CollAna[0].BildirimMetin = txt_not.Text;
                                    CollAna[0].BildirimAciklama = txt_kisisel_measj.Text;

                                    if (cb_kapat.Checked == true)
                                    {
                                        VatandaCollection CollVatt = new VatandaCollection();
                                        IPredicateExpression ExpVatt = new PredicateExpression();
                                        ExpVatt.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                                        CollVatt.GetMulti(ExpVatt);

                                        TimeSpan fark_bak1 = DateTime.Now - CollVatt[0].VatandasIslemTarih;
                                        string duzle = (fark_bak1.TotalHours).ToString();
                                        double arasi = Convert.ToDouble(duzle);
                                        Int16 ana_fark = Convert.ToInt16(arasi);
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

                                        CollAna[0].BildirimToplamSure = fark_olustur;
                                    }

                                    CollAna[0].Save();
                                    //neredeki
                                    VatandaCollection CollVatGnc = new VatandaCollection();
                                    IPredicateExpression ExpVatGnc = new PredicateExpression();
                                    ExpVatGnc.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                                    CollVatGnc.GetMulti(ExpVatGnc);

                                    KullaniciCollection CollKules = new KullaniciCollection();
                                    IPredicateExpression ExpKules = new PredicateExpression();
                                    ExpKules.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                                    CollKules.GetMulti(ExpKules);

                                    if (CollKules[0].KullaniciAdSoyad == "Dilek ŞAHİN" || CollKules[0].KullaniciAdSoyad == "Soner HIRAMAN" || CollKules[0].KullaniciAdSoyad == "Zafer HARTOĞLU" || CollKules[0].KullaniciAdSoyad == "Mustafa ÜNAL")
                                    {
                                        CollVatGnc[0].FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                        CollVatGnc[0].VatandasAd = txt_ad.Text.ToUpper();
                                        CollVatGnc[0].VatandasAdres = txt_adres.Text;
                                        CollVatGnc[0].VatandasTur = cb_kayit_tur.Text;
                                        CollVatGnc[0].VatandasIslemTarih = DateTime.Now;

                                        if (cb_kayit_tur.Text == "Gerçek Kişi")
                                        {
                                            CollVatGnc[0].VatandasSoyad = txt_soyad.Text.ToUpper();
                                            CollVatGnc[0].VatandasAdSoyad = txt_ad.Text.ToUpper() + " " + txt_soyad.Text.ToUpper();
                                            CollVatGnc[0].VatandasCinsiyet = cb_cinsiyet.Text;

                                            if (txt_dogum_tarihi.Text != "01.01.1900")
                                            {
                                                CollVatGnc[0].VatandasDogumTarihi = Convert.ToDateTime(txt_dogum_tarihi.Text);
                                            }

                                            CollVatGnc[0].VatandasTcNo = txt_tc_no.Text;
                                        }

                                        else
                                        {
                                            CollVatGnc[0].VatandasAdSoyad = txt_ad.Text.ToUpper() + " " + txt_soyad.Text.ToUpper();
                                        }

                                        CollVatGnc[0].VatandasMail = txt_mail.Text;
                                        CollVatGnc[0].VatandasTel1 = txt_tel_no.Text.Trim().Replace(" ", string.Empty);
                                        CollVatGnc[0].VatandasUyruk = txt_uyruk.Text;
                                        CollVatGnc[0].VatandasPasaportNo = txt_pasaport.Text;
                                        CollVatGnc[0].Save();
                                    }                                    
                                    
                                    BildirimIslemCollection CollIs = new BildirimIslemCollection();
                                    IPredicateExpression ExpIs = new PredicateExpression();
                                    ExpIs.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "Kayıtları Güncellendi");
                                    CollIs.GetMulti(ExpIs);

                                    BildirimHistoryEntity EntHis = new BildirimHistoryEntity();
                                    EntHis.FkBildirimId = CollAna[0].BildirimId;
                                    EntHis.FkBildirimIslemId = CollIs[0].BildirimIslemId;
                                    EntHis.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                    EntHis.BildirimHistoryTarih = DateTime.Now;
                                    EntHis.BildirimHistorySure = "0";
                                    EntHis.BildirimHistoryAciklama = CollKul[0].KullaniciAdSoyad + " tarafından kayıtları güncellendi.";
                                    EntHis.Save();

                                    Session["par_guncelle_mi"] = "0";

                                    if (Session["gnc_turu"].ToString() == "Ekstra")
                                    {
                                        if (say_grup != 0 || say_kul != 0)
                                        {
                                            string bas_ad = "";

                                            for (int i = 0; i < cb_per_list.Items.Count; i++)
                                            {
                                                if (cb_per_list.Items[i].Selected == true)
                                                {
                                                    KullaniciCollection CollKim = new KullaniciCollection();
                                                    IPredicateExpression ExpKim = new PredicateExpression();
                                                    ExpKim.AddWithAnd(KullaniciFields.KullaniciAdSoyad == cb_per_list.Items[i].Text);
                                                    CollKim.GetMulti(ExpKim);

                                                    BildirimAtamaKullaniciEntity EntAta = new BildirimAtamaKullaniciEntity();
                                                    EntAta.FkBildirimId = CollAna[0].BildirimId;
                                                    EntAta.FkKullaniciId = CollKim[0].KullaniciId;
                                                    EntAta.BildirimAtamaKullaniciBittiMi = false;
                                                    EntAta.BildirimAtamaKullaniciTarih = DateTime.Now;
                                                    EntAta.BildirimAtamaKullaniciYonMu = "Hayır";
                                                    EntAta.Save();

                                                    if (bas_ad == "")
                                                    {
                                                        bas_ad = bas_ad + CollKim[0].KullaniciAdSoyad;
                                                    }

                                                    else
                                                    {
                                                        bas_ad = bas_ad + ", " + CollKim[0].KullaniciAdSoyad;
                                                    }
                                                }
                                            }

                                            for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                            {
                                                if (cb_grup_list.Items[i].Selected == true)
                                                {
                                                    GrupCollection CollGr = new GrupCollection();
                                                    IPredicateExpression ExpGr = new PredicateExpression();
                                                    ExpGr.AddWithAnd(GrupFields.GrupAd == cb_grup_list.Items[i].Text);
                                                    CollGr.GetMulti(ExpGr);

                                                    BildirimAtamaGrupEntity EntAta = new BildirimAtamaGrupEntity();
                                                    EntAta.FkBildirimId = CollAna[0].BildirimId;
                                                    EntAta.FkGrupId = CollGr[0].GrupId;
                                                    EntAta.BildirimAtamaGrupTarih = DateTime.Now;
                                                    EntAta.BildirimAtamaGrupYonMu = "Hayır";
                                                    EntAta.Save();
                                                }
                                            }

                                            BildirimIslemCollection CollIs2 = new BildirimIslemCollection();
                                            IPredicateExpression ExpIs2 = new PredicateExpression();
                                            ExpIs2.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "Kullanıcı/Grup Ataması Yapıldı");
                                            CollIs2.GetMulti(ExpIs2);

                                            BildirimHistoryEntity EntHis2 = new BildirimHistoryEntity();
                                            EntHis2.FkBildirimId = CollAna[0].BildirimId;
                                            EntHis2.FkBildirimIslemId = CollIs2[0].BildirimIslemId;
                                            EntHis2.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                            EntHis2.BildirimHistoryTarih = DateTime.Now;
                                            EntHis2.BildirimHistorySure = "0";
                                            EntHis2.BildirimHistoryAciklama = CollKul[0].KullaniciAdSoyad + " tarafından bildirim " + bas_ad + "'e/a atandı.";
                                            EntHis2.Save();

                                            Panel4.Enabled = false;
                                            Panel5.Enabled = false;

                                            cb_kayit_tur.Text = "";
                                            cb_kayit_tur.NullText = "Seçiniz...";
                                            txt_tc_no.Text = "";
                                            btn_kps.Enabled = false; ;
                                            txt_ad.Text = "";
                                            txt_soyad.Text = "";
                                            cb_cinsiyet.Text = "";
                                            cb_cinsiyet.NullText = "Seçiniz...";
                                            string hexValue2 = "#FFFFFF";
                                            txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                            txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                            cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                            txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                            txt_dogum_tarihi.Text = "01.01.1900";
                                            txt_tel_no.Text = "";
                                            txt_mail.Text = "";
                                            txt_adres.Text = "";
                                        }

                                        else
                                        {
                                            if (Session["say_kac"].ToString() != "0")
                                            {
                                                BildirimIslemCollection CollIs2 = new BildirimIslemCollection();
                                                IPredicateExpression ExpIs2 = new PredicateExpression();
                                                ExpIs2.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "İptal Edildi");
                                                CollIs2.GetMulti(ExpIs2);

                                                BildirimHistoryEntity EntHis2 = new BildirimHistoryEntity();
                                                EntHis2.FkBildirimId = CollAna[0].BildirimId;
                                                EntHis2.FkBildirimIslemId = CollIs2[0].BildirimIslemId;
                                                EntHis2.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                                EntHis2.BildirimHistoryTarih = DateTime.Now;
                                                EntHis2.BildirimHistorySure = "0";
                                                EntHis2.BildirimHistoryAciklama = CollKul[0].KullaniciAdSoyad + " tarafından atama işlemleri iptal edildi.";
                                                EntHis2.Save();

                                                Panel4.Enabled = false;
                                                Panel5.Enabled = false;

                                                cb_kayit_tur.Text = "";
                                                cb_kayit_tur.NullText = "Seçiniz...";
                                                txt_tc_no.Text = "";
                                                btn_kps.Enabled = false; ;
                                                txt_ad.Text = "";
                                                txt_soyad.Text = "";
                                                cb_cinsiyet.Text = "";
                                                cb_cinsiyet.NullText = "Seçiniz...";
                                                string hexValue2 = "#FFFFFF";
                                                txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                                txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                                cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                                txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                                txt_dogum_tarihi.Text = "01.01.1900";
                                                txt_tel_no.Text = "";
                                                txt_mail.Text = "";
                                                txt_adres.Text = "";
                                            }

                                            else
                                            {
                                                Panel4.Enabled = false;
                                                Panel5.Enabled = false;

                                                cb_kayit_tur.Text = "";
                                                cb_kayit_tur.NullText = "Seçiniz...";
                                                txt_tc_no.Text = "";
                                                btn_kps.Enabled = false; ;
                                                txt_ad.Text = "";
                                                txt_soyad.Text = "";
                                                cb_cinsiyet.Text = "";
                                                cb_cinsiyet.NullText = "Seçiniz...";
                                                string hexValue2 = "#FFFFFF";
                                                txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                                txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                                cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                                txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                                                txt_dogum_tarihi.Text = "01.01.1900";
                                                txt_tel_no.Text = "";
                                                txt_mail.Text = "";
                                                txt_adres.Text = "";
                                            }
                                        }
                                    }

                                    string CloseWindow;
                                    CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                    DosyaCollection CollDos = new DosyaCollection();
                                    IPredicateExpression ExpDos = new PredicateExpression();
                                    ExpDos.AddWithAnd(DosyaFields.DosyaBildirimi == CollAna[0].BildirimId);
                                    CollDos.GetMulti(ExpDos);

                                    for (int y = 0; y < CollDos.Count; y++)
                                    {
                                        CollDos[y].Delete();
                                        CollDos[y].Save();
                                    }

                                    if (Session["file_path_1"] != null)
                                    {
                                        DosyaEntity EntDos = new DosyaEntity();
                                        EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                        EntDos.DosyaIcerikDurum = "1";
                                        EntDos.DosyaIcerikPath = Session["file_path_1"].ToString();
                                        EntDos.DosyaIcerikTarih = DateTime.Now;
                                        EntDos.Save();
                                    }

                                    if (Session["file_path_2"] != null)
                                    {
                                        DosyaEntity EntDos = new DosyaEntity();
                                        EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                        EntDos.DosyaIcerikDurum = "1";
                                        EntDos.DosyaIcerikPath = Session["file_path_2"].ToString();
                                        EntDos.DosyaIcerikTarih = DateTime.Now;
                                        EntDos.Save();
                                    }

                                    if (Session["file_path_3"] != null)
                                    {
                                        DosyaEntity EntDos = new DosyaEntity();
                                        EntDos.DosyaBildirimi = CollAna[0].BildirimId;
                                        EntDos.DosyaIcerikDurum = "1";
                                        EntDos.DosyaIcerikPath = Session["file_path_3"].ToString();
                                        EntDos.DosyaIcerikTarih = DateTime.Now;
                                        EntDos.Save();
                                    }

                                    ParametreCollection CollPrm = new ParametreCollection();
                                    IPredicateExpression ExpPrm = new PredicateExpression();
                                    ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
                                    CollPrm.GetMulti(ExpPrm);

                                    DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

                                    ListBildirimTypedList bil_list = new ListBildirimTypedList();
                                    ISortExpression sort22 = new SortExpression();
                                    sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                                    IPredicateExpression filter2 = new PredicateExpression();
                                    filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                                    bil_list.Fill(0, sort22, true, filter2);

                                    grid_bildirim.DataSource = bil_list;
                                    grid_bildirim.DataBind();

                                    grid_bildirim_sil.DataSource = bil_list;
                                    grid_bildirim_sil.DataBind();                                

                                    txt_kisisel_measj.Text = "";
                                    cb_havalimani.Text = "";
                                    cb_havalimani.NullText = "Seçiniz...";
                                    pnl_sorgu.Visible = false;
                                    cb_tur.Text = "";
                                    cb_tur.NullText = "Seçiniz...";
                                    cb_sekil.Text = "";
                                    cb_sekil.NullText = "Seçiniz...";
                                    btn_yukle.Enabled = false;
                                    cb_konu.Text = "";
                                    cb_konu.NullText = "Seçiniz...";
                                    txt_not.Text = "";
                                    txt_dava_ad_soyad.Text = "";
                                    txt_dava_dosya_no.Text = "";
                                    txt_dava_konu.Text = "";
                                    txt_dava_mahkeme_adi.Text = "";
                                    cb_cag_tip.Text = "";
                                    cb_cag_tip.NullText = "Seçiniz...";
                                    cb_kapat.Checked = false;
                                    cb_kayit_tur.Text = "";
                                    cb_kayit_tur.NullText = "Seçiniz...";
                                    txt_tc_no.Text = "";
                                    btn_kps.Enabled = false; ;
                                    txt_ad.Text = "";
                                    txt_soyad.Text = "";
                                    cb_cinsiyet.Text = "";
                                    cb_cinsiyet.NullText = "Seçiniz...";
                                    string hexValue25 = "#FFFFFF";
                                    txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                    txt_pasaport.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                    txt_uyruk.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                    txt_ad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                    txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                    cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                    txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                    txt_dogum_tarihi.Text = "01.01.1900";
                                    txt_tel_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                    txt_mail.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                    txt_adres.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue25);
                                    txt_tel_no.Text = "";
                                    txt_mail.Text = "";
                                    txt_adres.Text = "";

                                    for (int i = 0; i < cb_grup_list.Items.Count; i++)
                                    {
                                        cb_grup_list.Items[i].Selected = false;
                                    }

                                    for (int i = 0; i < cb_per_list.Items.Count; i++)
                                    {
                                        cb_per_list.Items[i].Selected = false;
                                    }

                                    cb_gr_hep.Checked = false;
                                    cb_hepsi.Checked = false;
                                    txt_cagri_sayisi.Text = "";
                                    btn_gor.Enabled = false;

                                    Session["vat_id"] = null;

                                    cb_tur.Focus();
                                }

                                Session["vat_id"] = null;
                            }
                        }                        
                    }
                }
            }            
        }

        protected void btn_gor_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;

            string hexValue2 = "#C0D9E7";
            string hexValue = "#FFFFFF";
            Menu1.Items[1].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
            Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);

            ListBildirimTypedList bil_list = new ListBildirimTypedList();
            ISortExpression sort22 = new SortExpression();
            sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filter2 = new PredicateExpression();
            filter2.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
            bil_list.Fill(0, sort22, true, filter2);

            grid_bildirim.DataSource = bil_list;
            grid_bildirim.DataBind();
        }

        protected void cb_kapat_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_kapat.Checked == true)
            {
                pnl_ata.Enabled = false;
            }

            else
            {
                pnl_ata.Enabled = true;
            }

            btn_kaydet.Focus();
        }

        protected void cb_gr_hep_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_gr_hep.Checked == true)
            {
                for (int i = 0; i < cb_grup_list.Items.Count; i++)
                {
                    cb_grup_list.Items[i].Selected = true;
                }

                for (int i = 0; i < cb_per_list.Items.Count; i++)
                {
                    cb_per_list.Items[i].Selected = true;
                }
            }

            else
            {
                for (int i = 0; i < cb_grup_list.Items.Count; i++)
                {
                    cb_grup_list.Items[i].Selected = false;
                }

                for (int i = 0; i < cb_per_list.Items.Count; i++)
                {
                    cb_per_list.Items[i].Selected = false;
                }
            }

            btn_kaydet.Focus();
        }

        protected void cb_hepsi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hepsi.Checked == true)
            {
                for (int i = 0; i < cb_per_list.Items.Count; i++)
                {
                    cb_per_list.Items[i].Selected = true;
                }

                for (int i = 0; i < cb_grup_list.Items.Count; i++)
                {
                    cb_grup_list.Items[i].Selected = true;
                }
            }

            else
            {

                for (int i = 0; i < cb_per_list.Items.Count; i++)
                {
                    cb_per_list.Items[i].Selected = false;
                }

                for (int i = 0; i < cb_grup_list.Items.Count; i++)
                {
                    cb_grup_list.Items[i].Selected = false;
                }
            }

            btn_kaydet.Focus();
        }

        protected void cb_grup_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_gr_hep.Checked = false;

            for (int i = 0; i < cb_grup_list.Items.Count; i++)
            {
                if (cb_grup_list.Items[i].Selected == true)
                {
                    GrupCollection CollGr = new GrupCollection();
                    IPredicateExpression ExpGr = new PredicateExpression();
                    ExpGr.AddWithAnd(GrupFields.GrupAd == cb_grup_list.Items[i].Text);
                    CollGr.GetMulti(ExpGr);

                    if (CollGr.Count > 0)
                    {
                        GrupAtamaCollection CollAta = new GrupAtamaCollection();
                        IPredicateExpression ExpAta = new PredicateExpression();
                        ExpAta.AddWithAnd(GrupAtamaFields.FkGrupId == CollGr[0].GrupId);
                        CollAta.GetMulti(ExpAta);

                        for (int j = 0; j < CollAta.Count; j++)
                        {
                            KullaniciCollection CollKul = new KullaniciCollection();
                            IPredicateExpression ExpKul = new PredicateExpression();
                            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == CollAta[j].FkKullaniciId);
                            CollKul.GetMulti(ExpKul);

                            for (int g = 0; g < cb_per_list.Items.Count; g++)
                            {
                                if (CollKul[0].KullaniciAdSoyad == cb_per_list.Items[g].Text)
                                {
                                    cb_per_list.Items[g].Selected = true;
                                }
                            }
                        }
                    }
                }

                else
                {
                    GrupCollection CollGr = new GrupCollection();
                    IPredicateExpression ExpGr = new PredicateExpression();
                    ExpGr.AddWithAnd(GrupFields.GrupAd == cb_grup_list.Items[i].Text);
                    CollGr.GetMulti(ExpGr);

                    if (CollGr.Count > 0)
                    {
                        GrupAtamaCollection CollAta = new GrupAtamaCollection();
                        IPredicateExpression ExpAta = new PredicateExpression();
                        ExpAta.AddWithAnd(GrupAtamaFields.FkGrupId == CollGr[0].GrupId);
                        CollAta.GetMulti(ExpAta);

                        for (int j = 0; j < CollAta.Count; j++)
                        {
                            KullaniciCollection CollKul = new KullaniciCollection();
                            IPredicateExpression ExpKul = new PredicateExpression();
                            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == CollAta[j].FkKullaniciId);
                            CollKul.GetMulti(ExpKul);

                            for (int g = 0; g < cb_per_list.Items.Count; g++)
                            {
                                if (CollKul[0].KullaniciAdSoyad == cb_per_list.Items[g].Text)
                                {
                                    cb_per_list.Items[g].Selected = false;
                                }
                            }
                        }
                    }
                }
            }

            btn_kaydet.Focus();
        }

        protected void cb_tur_SelectedIndexChanged(object sender, EventArgs e)
        {            
            string hexValue2 = "#FFFFFF";

            Panel4.Enabled = true;
            Panel5.Enabled = true;

            AltKonuCollection CollKon = new AltKonuCollection();
            IPredicateExpression ExpKon = new PredicateExpression();
            ExpKon.AddWithAnd(AltKonuFields.AltKonuDurum == true);
            ISortExpression sortkon = new SortExpression();
            sortkon.Add(new SortClause(AltKonuFields.AltKonuAd, SortOperator.Ascending));
            CollKon.GetMulti(ExpKon, 0, sortkon);

            cb_konu.Items.Clear();

            for (int i = 0; i < CollKon.Count; i++)
            {
                cb_konu.Items.Add(CollKon[i].AltKonuAd);
            }

            cb_sekil.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
            cb_sekil.Text = "Hiçbiri";

            if ((cb_tur.Text == "Şikayet") || (cb_tur.Text == "Bilgi Talebi") || (cb_tur.Text == "Diğer Kurumlara Yönlendirme") || (cb_tur.Text == "Öneri") || (cb_tur.Text == "Memnuniyet"))
            {                               
                pnl_sorgu.Visible = false;
                pnl_yeni_kayit.Height = 640;                                               
            }

            else if (cb_tur.Text == "Dava Bildirimi")
            {                                         
                pnl_sorgu.Visible = true;
                pnl_yeni_kayit.Height = 760;                    
            }

            cb_kayit_tur.Focus();            
        }        

        protected void btn_bilgi_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McYrBilgiBankasiIslemleri.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void cb_kayit_tur_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hexValue = "#F2EDED";
            string hexValue2 = "#FFFFFF";

            if (cb_kayit_tur.Text == "Gerçek Kişi")
            {
                txt_uyruk.Enabled = true;
                txt_uyruk.Text = "T.C.";
                txt_uyruk.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                txt_tc_no.Enabled = true;
                txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                btn_kps.Enabled = true;
                txt_soyad.Enabled = true;
                txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                cb_cinsiyet.Enabled = true;
                cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                txt_dogum_tarihi.Enabled = true;
                txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_pasaport.Enabled = false;
                txt_pasaport.Text = "";
                txt_pasaport.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_vergi_no.Enabled = false;
                txt_vergi_no.Text = "";
                txt_vergi_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_tel_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);                
                txt_mail.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_adres.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);                

                txt_tc_no.Focus();
            }

            else if (cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
            {
                txt_uyruk.Enabled = true;
                txt_uyruk.Text = "";
                txt_uyruk.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                txt_tc_no.Enabled = false;
                txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_tc_no.Text = "";
                txt_vergi_no.Enabled = false;
                txt_vergi_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_vergi_no.Text = "";
                btn_kps.Enabled = false;
                txt_soyad.Enabled = true;
                txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                cb_cinsiyet.Enabled = true;
                cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                txt_dogum_tarihi.Enabled = true;
                txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_pasaport.Enabled = true;
                txt_pasaport.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_pasaport.Text = "";
                txt_tel_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);                
                txt_mail.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_adres.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);                

                txt_pasaport.Focus();
            }

            else
            {
                txt_tc_no.Enabled = false;
                txt_tc_no.Text = "";
                txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                btn_kps.Enabled = false;
                txt_soyad.Enabled = false;
                txt_soyad.Text = "";
                txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                cb_cinsiyet.Enabled = false;
                cb_cinsiyet.Text = "";
                cb_cinsiyet.NullText = "Seçiniz...";
                cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_dogum_tarihi.Enabled = false;
                txt_dogum_tarihi.Text = "01.01.1900";
                txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_pasaport.Enabled = false;
                txt_pasaport.Text = "";
                txt_pasaport.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_uyruk.Enabled = false;
                txt_uyruk.Text = "";
                txt_vergi_no.Enabled = true;
                txt_vergi_no.Text = "";
                txt_vergi_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_uyruk.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_tel_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);                
                txt_mail.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_adres.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);                

                txt_vergi_no.Focus();
            }
        }

        protected void btn_kps_Click(object sender, EventArgs e)
        {
            try
            {
                string tc_kontrol = txt_tc_no.Text;
                Int32 toplam_1 = (Convert.ToInt32(tc_kontrol[0].ToString())) + (Convert.ToInt32(tc_kontrol[2].ToString())) + (Convert.ToInt32(tc_kontrol[4].ToString())) + (Convert.ToInt32(tc_kontrol[6].ToString())) + (Convert.ToInt32(tc_kontrol[8].ToString()));
                toplam_1 = toplam_1 * 7;
                Int32 toplam_2 = (Convert.ToInt32(tc_kontrol[1].ToString())) + (Convert.ToInt32(tc_kontrol[3].ToString())) + (Convert.ToInt32(tc_kontrol[5].ToString())) + (Convert.ToInt32(tc_kontrol[7].ToString()));
                Int32 toplam_son = toplam_1 - toplam_2;
                toplam_son = toplam_son % 10;
                Int32 toplam_ara = (Convert.ToInt32(tc_kontrol[0].ToString())) + (Convert.ToInt32(tc_kontrol[1].ToString())) + (Convert.ToInt32(tc_kontrol[2].ToString())) + (Convert.ToInt32(tc_kontrol[3].ToString())) + (Convert.ToInt32(tc_kontrol[4].ToString())) + (Convert.ToInt32(tc_kontrol[5].ToString())) + (Convert.ToInt32(tc_kontrol[6].ToString())) + (Convert.ToInt32(tc_kontrol[7].ToString())) + (Convert.ToInt32(tc_kontrol[8].ToString())) + toplam_son;
                toplam_ara = toplam_ara % 10;

                if ((toplam_son == (Convert.ToInt32(tc_kontrol[9].ToString()))) && (toplam_ara == (Convert.ToInt32(tc_kontrol[10].ToString()))))
                {
                    KulTcNoCollection CollKont = new KulTcNoCollection();
                    CollKont.GetMulti(null);

                    if (CollKont.Count > 0)
                    {
                        CollKont[0].KulTcNoNumara = txt_tc_no.Text;
                        CollKont[0].KulTcNoTarih = DateTime.Now;
                        CollKont[0].Save();
                    }

                    else
                    {
                        KulTcNoEntity EntKay = new KulTcNoEntity();
                        EntKay.KulTcNoNumara = txt_tc_no.Text;
                        EntKay.KulTcNoTarih = DateTime.Now;
                        EntKay.Save();
                    }

                    try
                    {
                        ParametreCollection CollPar = new ParametreCollection();
                        IPredicateExpression ExpPar = new PredicateExpression();
                        ExpPar.AddWithAnd(ParametreFields.ParametreAd == "KPS Path");
                        CollPar.GetMulti(ExpPar);

                        string path = CollPar[0].ParametreDeger + "mkps.exe";

                        System.Diagnostics.Process.Start(@path);
                        Thread.Sleep(10000);

                        KulTcNoCollection CollKonttt = new KulTcNoCollection();
                        CollKonttt.GetMulti(null);

                        KpsBilgiCollection CollKps = new KpsBilgiCollection();
                        IPredicateExpression ExpKps = new PredicateExpression();
                        ExpKps.AddWithAnd(KpsBilgiFields.KpsBilgiTcKimlik == CollKonttt[0].KulTcNoNumara);
                        CollKps.GetMulti(ExpKps);

                        if (CollKps.Count > 0)
                        {
                            Int32 sirasi = CollKps.Count - 1;
                            txt_ad.Text = CollKps[sirasi].KpsBilgiAd;
                            txt_soyad.Text = CollKps[sirasi].KpsBilgiSoyad;
                            txt_dogum_tarihi.Text = CollKps[sirasi].KpsBilgiDogumTarihi.ToString();
                            cb_cinsiyet.Text = CollKps[sirasi].KpsBilgiCinsiyet;

                            string arada = "";

                            if (CollKps[sirasi].KpsBilgiDis == "" && CollKps[sirasi].KpsBilgiIc == "")
                            {
                                txt_adres.Text = "";
                            }

                            else
                            {
                                if (CollKps[sirasi].KpsBilgiCaddeSokak != "")
                                {
                                    arada = arada + CollKps[sirasi].KpsBilgiCaddeSokak + " Caddesi/Sokağı. ";
                                }

                                if (CollKps[sirasi].KpsBilgiMahalle != "")
                                {
                                    arada = arada + CollKps[sirasi].KpsBilgiMahalle + " Mahallesi. ";
                                }

                                if (CollKps[sirasi].KpsBilgiDis != "" && CollKps[sirasi].KpsBilgiIc != "")
                                {
                                    arada = arada + CollKps[sirasi].KpsBilgiDis + "/" + CollKps[sirasi].KpsBilgiIc + " ";
                                }

                                if (CollKps[sirasi].KpsBilgiIlce != "" && CollKps[sirasi].KpsBilgiIlce != "")
                                {
                                    arada = arada + CollKps[sirasi].KpsBilgiIlce + "/" + CollKps[sirasi].KpsBilgiIl;
                                }

                                else if (CollKps[sirasi].KpsBilgiIlce == "" && CollKps[sirasi].KpsBilgiIlce != "")
                                {
                                    arada = arada + CollKps[sirasi].KpsBilgiIl;
                                }

                                txt_adres.Text = arada;

                                KpsArsivEntity EntEkle = new KpsArsivEntity();
                                EntEkle.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                EntEkle.KpsArsivDurum = true;
                                EntEkle.KpsArsivTarih = DateTime.Now;
                                EntEkle.KpsArsivTcNo = Convert.ToInt64(txt_tc_no.Text);
                                EntEkle.Save();
                            }
                        }

                        else
                        {
                            string CloseWindow;
                            CloseWindow = "alert('TC Kimlik Numarası KPS'ne kayıtlı değildir. Lütfen bilgileri manuel olarak giriniz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            txt_tc_no.Focus();

                            KpsArsivEntity EntEkle = new KpsArsivEntity();
                            EntEkle.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                            EntEkle.KpsArsivDurum = false;
                            EntEkle.KpsArsivTarih = DateTime.Now;
                            EntEkle.KpsArsivTcNo = Convert.ToInt64(txt_tc_no.Text);
                            EntEkle.Save();

                            txt_tc_no.Focus();
                        }
                    }

                    catch
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Bir hata oluştu. Lütfen daha sonra tekrar deneyiniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        txt_tc_no.Focus();

                        KpsArsivEntity EntEkle = new KpsArsivEntity();
                        EntEkle.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                        EntEkle.KpsArsivDurum = false;
                        EntEkle.KpsArsivTarih = DateTime.Now;
                        EntEkle.KpsArsivTcNo = Convert.ToInt64(txt_tc_no.Text);
                        EntEkle.Save();

                        txt_tc_no.Focus();
                    }
                }

                else
                {
                    string CloseWindow;
                    CloseWindow = "alert('TC Kimlik Numarası hatalıdır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                    txt_tc_no.Focus();
                }
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('TC Kimlik Numarası hatalıdır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                txt_tc_no.Focus();
            }
        }

        protected void btn_sorgula_Click(object sender, EventArgs e)
        {
            if (txt_tc_no.Text == "" && txt_pasaport.Text == "" && txt_vergi_no.Text == "" && txt_mail.Text == "" && txt_tel_no.Text == "")
            {
                string CloseWindow;
                CloseWindow = "alert('TC Kimlik Numarası, Pasaport No, Vergi Kimlik No, Mail Adresi ve Telefon Numarası bilgilerinden en az birini doldurunuz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                txt_tc_no.Focus();
            }

            else
            {
                if (txt_tc_no.Text != "")
                {
                    VatandaCollection CollVat = new VatandaCollection();
                    IPredicateExpression ExpVat = new PredicateExpression();
                    ExpVat.AddWithAnd(VatandaFields.VatandasTcNo == txt_tc_no.Text);
                    CollVat.GetMulti(ExpVat);

                    if (CollVat.Count > 0)
                    {
                        cb_kayit_tur.Text = "";
                        cb_kayit_tur.NullText = "Seçiniz...";
                        txt_tc_no.Text = "";                        
                        txt_ad.Text = "";
                        txt_soyad.Text = "";
                        cb_cinsiyet.Text = "";
                        cb_cinsiyet.NullText = "Seçiniz...";                                                
                        txt_dogum_tarihi.Text = "01.01.1900";
                        txt_tel_no.Text = "";
                        txt_mail.Text = "";
                        txt_adres.Text = "";
                        txt_pasaport.Text = "";
                        txt_vergi_no.Text = "";
                        txt_uyruk.Text = "";

                        Session["vat_id"] = CollVat[0].VatandasId.ToString();

                        cb_kayit_tur.Text = CollVat[0].VatandasTur;
                        txt_tc_no.Text = CollVat[0].VatandasTcNo;
                        txt_ad.Text = CollVat[0].VatandasAd;
                        txt_soyad.Text = CollVat[0].VatandasSoyad;
                        cb_cinsiyet.Text = CollVat[0].VatandasCinsiyet;

                        if (CollVat[0].VatandasDogumTarihi == null)
                        {
                            txt_dogum_tarihi.Text = "01.01.1900";
                        }

                        else
                        {
                            txt_dogum_tarihi.Text = CollVat[0].VatandasDogumTarihi.ToString();
                        }

                        txt_tel_no.Text = CollVat[0].VatandasTel1;
                        txt_mail.Text = CollVat[0].VatandasMail;
                        txt_adres.Text = CollVat[0].VatandasAdres;
                        txt_pasaport.Text = CollVat[0].VatandasPasaportNo;
                        txt_uyruk.Text = CollVat[0].VatandasUyruk;

                        string CloseWindow;
                        CloseWindow = "alert('Vatandaş/Firma bilgileri alınmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        txt_tc_no.Focus();
                    }

                    else
                    {
                        btn_yukle.Enabled = true;

                        Session["rapor_adi"] = "Vatandaş Seçme Bilgileri";

                        ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/4)-(700/4)-30;window.open( 'McAraRapor.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
                    }
                }

                else if ( txt_pasaport.Text != "")
                {
                    VatandaCollection CollVat = new VatandaCollection();
                    IPredicateExpression ExpVat = new PredicateExpression();
                    ExpVat.AddWithAnd(VatandaFields.VatandasPasaportNo == txt_pasaport.Text);
                    CollVat.GetMulti(ExpVat);

                    if (CollVat.Count > 0)
                    {
                        cb_kayit_tur.Text = "";
                        cb_kayit_tur.NullText = "Seçiniz...";
                        txt_tc_no.Text = "";                        
                        txt_ad.Text = "";
                        txt_soyad.Text = "";
                        cb_cinsiyet.Text = "";
                        cb_cinsiyet.NullText = "Seçiniz...";                                                
                        txt_dogum_tarihi.Text = "01.01.1900";
                        txt_tel_no.Text = "";
                        txt_mail.Text = "";
                        txt_adres.Text = "";
                        txt_pasaport.Text = "";
                        txt_vergi_no.Text = "";
                        txt_uyruk.Text = "";

                        Session["vat_id"] = CollVat[0].VatandasId.ToString();

                        cb_kayit_tur.Text = CollVat[0].VatandasTur;
                        txt_tc_no.Text = CollVat[0].VatandasTcNo;
                        txt_ad.Text = CollVat[0].VatandasAd;
                        txt_soyad.Text = CollVat[0].VatandasSoyad;
                        cb_cinsiyet.Text = CollVat[0].VatandasCinsiyet;

                        if (CollVat[0].VatandasDogumTarihi == null)
                        {
                            txt_dogum_tarihi.Text = "01.01.1900";
                        }

                        else
                        {
                            txt_dogum_tarihi.Text = CollVat[0].VatandasDogumTarihi.ToString();
                        }

                        txt_tel_no.Text = CollVat[0].VatandasTel1;
                        txt_mail.Text = CollVat[0].VatandasMail;
                        txt_adres.Text = CollVat[0].VatandasAdres;
                        txt_pasaport.Text = CollVat[0].VatandasPasaportNo;
                        txt_uyruk.Text = CollVat[0].VatandasUyruk;                        

                        string CloseWindow;
                        CloseWindow = "alert('Vatandaş/Firma bilgileri alınmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        txt_tc_no.Focus();
                    }

                    else
                    {
                        btn_yukle.Enabled = true;

                        Session["rapor_adi"] = "Vatandaş Seçme Bilgileri";

                        ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/4)-(700/4)-30;window.open( 'McAraRapor.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
                    }
                }

                else if (txt_vergi_no.Text != "")
                {
                    VatandaCollection CollVat = new VatandaCollection();
                    IPredicateExpression ExpVat = new PredicateExpression();
                    ExpVat.AddWithAnd(VatandaFields.VatandasVergiNo == txt_vergi_no.Text);
                    CollVat.GetMulti(ExpVat);

                    if (CollVat.Count > 0)
                    {
                        cb_kayit_tur.Text = "";
                        cb_kayit_tur.NullText = "Seçiniz...";
                        txt_tc_no.Text = "";
                        txt_ad.Text = "";
                        txt_soyad.Text = "";
                        cb_cinsiyet.Text = "";
                        cb_cinsiyet.NullText = "Seçiniz...";
                        txt_dogum_tarihi.Text = "01.01.1900";
                        txt_tel_no.Text = "";
                        txt_mail.Text = "";
                        txt_adres.Text = "";
                        txt_pasaport.Text = "";
                        txt_vergi_no.Text = "";
                        txt_uyruk.Text = "";

                        Session["vat_id"] = CollVat[0].VatandasId.ToString();

                        cb_kayit_tur.Text = CollVat[0].VatandasTur;
                        txt_tc_no.Text = CollVat[0].VatandasTcNo;
                        txt_ad.Text = CollVat[0].VatandasAd;
                        txt_soyad.Text = CollVat[0].VatandasSoyad;
                        cb_cinsiyet.Text = CollVat[0].VatandasCinsiyet;

                        if (CollVat[0].VatandasDogumTarihi == null)
                        {
                            txt_dogum_tarihi.Text = "01.01.1900";
                        }

                        else
                        {
                            txt_dogum_tarihi.Text = CollVat[0].VatandasDogumTarihi.ToString();
                        }

                        txt_tel_no.Text = CollVat[0].VatandasTel1;
                        txt_mail.Text = CollVat[0].VatandasMail;
                        txt_adres.Text = CollVat[0].VatandasAdres;
                        txt_pasaport.Text = CollVat[0].VatandasPasaportNo;
                        txt_uyruk.Text = CollVat[0].VatandasUyruk;                       

                        string CloseWindow;
                        CloseWindow = "alert('Vatandaş/Firma bilgileri alınmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        txt_tc_no.Focus();
                    }

                    else
                    {
                        btn_yukle.Enabled = true;

                        Session["rapor_adi"] = "Vatandaş Seçme Bilgileri";

                        ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/4)-(700/4)-30;window.open( 'McAraRapor.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
                    }
                }

                else if (txt_mail.Text != "")
                {
                    VatandaCollection CollVat = new VatandaCollection();
                    IPredicateExpression ExpVat = new PredicateExpression();
                    ExpVat.AddWithAnd(VatandaFields.VatandasMail == txt_mail.Text);
                    CollVat.GetMulti(ExpVat);

                    if (CollVat.Count > 0)
                    {
                        cb_kayit_tur.Text = "";
                        cb_kayit_tur.NullText = "Seçiniz...";
                        txt_tc_no.Text = "";                        
                        txt_ad.Text = "";
                        txt_soyad.Text = "";
                        cb_cinsiyet.Text = "";
                        cb_cinsiyet.NullText = "Seçiniz...";                    
                        txt_dogum_tarihi.Text = "01.01.1900";
                        txt_tel_no.Text = "";
                        txt_mail.Text = "";
                        txt_adres.Text = "";
                        txt_pasaport.Text = "";
                        txt_vergi_no.Text = "";
                        txt_uyruk.Text = "";

                        Session["vat_id"] = CollVat[0].VatandasId.ToString();

                        cb_kayit_tur.Text = CollVat[0].VatandasTur;
                        txt_tc_no.Text = CollVat[0].VatandasTcNo;
                        txt_ad.Text = CollVat[0].VatandasAd;
                        txt_soyad.Text = CollVat[0].VatandasSoyad;
                        cb_cinsiyet.Text = CollVat[0].VatandasCinsiyet;
                        txt_pasaport.Text = CollVat[0].VatandasPasaportNo;
                        txt_uyruk.Text = CollVat[0].VatandasUyruk;

                        if (CollVat[0].VatandasDogumTarihi == null)
                        {
                            txt_dogum_tarihi.Text = "01.01.1900";
                        }

                        else
                        {
                            txt_dogum_tarihi.Text = CollVat[0].VatandasDogumTarihi.ToString();
                        }

                        txt_tel_no.Text = CollVat[0].VatandasTel1;
                        txt_mail.Text = CollVat[0].VatandasMail;
                        txt_adres.Text = CollVat[0].VatandasAdres;                        

                        string CloseWindow;
                        CloseWindow = "alert('Vatandaş/Firma bilgileri alınmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        txt_tc_no.Focus();
                    }

                    else
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Sistemde kayıtlı böyle bir vatandaş bulunmamaktadır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        txt_tc_no.Focus();
                    }
                }

                else if (txt_tel_no.Text != "")
                {
                    VatandaCollection CollVat = new VatandaCollection();
                    IPredicateExpression ExpVat = new PredicateExpression();
                    ExpVat.AddWithAnd(VatandaFields.VatandasTel1 == txt_tel_no.Text.Trim().Replace(" ", string.Empty));
                    CollVat.GetMulti(ExpVat);

                    if (CollVat.Count > 0)
                    {
                        cb_kayit_tur.Text = "";
                        cb_kayit_tur.NullText = "Seçiniz...";
                        txt_tc_no.Text = "";                        
                        txt_ad.Text = "";
                        txt_soyad.Text = "";
                        cb_cinsiyet.Text = "";
                        cb_cinsiyet.NullText = "Seçiniz...";                      
                        txt_dogum_tarihi.Text = "01.01.1900";
                        txt_tel_no.Text = "";
                        txt_mail.Text = "";
                        txt_adres.Text = "";
                        txt_pasaport.Text = "";
                        txt_vergi_no.Text = "";
                        txt_uyruk.Text = "";

                        Session["vat_id"] = CollVat[0].VatandasId.ToString();

                        cb_kayit_tur.Text = CollVat[0].VatandasTur;
                        txt_tc_no.Text = CollVat[0].VatandasTcNo;
                        txt_ad.Text = CollVat[0].VatandasAd;
                        txt_soyad.Text = CollVat[0].VatandasSoyad;
                        cb_cinsiyet.Text = CollVat[0].VatandasCinsiyet;
                        txt_pasaport.Text = CollVat[0].VatandasPasaportNo;
                        txt_uyruk.Text = CollVat[0].VatandasUyruk;

                        if (CollVat[0].VatandasDogumTarihi == null)
                        {
                            txt_dogum_tarihi.Text = "01.01.1900";
                        }

                        else
                        {
                            txt_dogum_tarihi.Text = CollVat[0].VatandasDogumTarihi.ToString();
                        }

                        txt_tel_no.Text = CollVat[0].VatandasTel1;
                        txt_mail.Text = CollVat[0].VatandasMail;
                        txt_adres.Text = CollVat[0].VatandasAdres;

                        string CloseWindow;
                        CloseWindow = "alert('Vatandaş/Firma bilgileri alınmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        txt_tc_no.Focus();
                    }

                    else
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Sistemde kayıtlı böyle bir vatandaş bulunmamaktadır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        txt_tc_no.Focus();
                    }
                }
            }
        }

        protected void btn_yukle_Click(object sender, EventArgs e)
        {
            if (Session["vat_id"] == null)
            {
                string CloseWindow;
                CloseWindow = "alert('Geçerli bir vatandaş seçmediniz. Lütfen vatandaş bilgilerini manuel olarak giriniz..')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                txt_tc_no.Focus();
            }

            else
            {
                VatandaCollection CollVat = new VatandaCollection();
                IPredicateExpression ExpVat = new PredicateExpression();
                ExpVat.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                CollVat.GetMulti(ExpVat);

                cb_kayit_tur.Text = "";
                cb_kayit_tur.NullText = "Seçiniz...";
                txt_tc_no.Text = "";
                btn_kps.Enabled = false; ;
                txt_ad.Text = "";
                txt_soyad.Text = "";
                cb_cinsiyet.Text = "";
                cb_cinsiyet.NullText = "Seçiniz...";
                string hexValue2 = "#FFFFFF";
                txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                txt_dogum_tarihi.Text = "01.01.1900";
                txt_tel_no.Text = "";
                txt_mail.Text = "";
                txt_adres.Text = "";
                txt_pasaport.Text = "";
                txt_vergi_no.Text = "";
                txt_uyruk.Text = "";

                Session["vat_id"] = CollVat[0].VatandasId.ToString();

                cb_kayit_tur.Text = CollVat[0].VatandasTur;
                txt_tc_no.Text = CollVat[0].VatandasTcNo;
                txt_ad.Text = CollVat[0].VatandasAd;
                txt_soyad.Text = CollVat[0].VatandasSoyad;
                cb_cinsiyet.Text = CollVat[0].VatandasCinsiyet;

                if (CollVat[0].VatandasDogumTarihi == null)
                {
                    txt_dogum_tarihi.Text = "01.01.1900";
                }

                else
                {
                    txt_dogum_tarihi.Text = CollVat[0].VatandasDogumTarihi.ToString();
                }

                txt_tel_no.Text = CollVat[0].VatandasTel1;
                txt_mail.Text = CollVat[0].VatandasMail;
                txt_adres.Text = CollVat[0].VatandasAdres;
                txt_pasaport.Text = CollVat[0].VatandasPasaportNo;
                txt_uyruk.Text = CollVat[0].VatandasUyruk;

                if (CollVat[0].VatandasTur == "Gerçek Kişi")
                {
                    txt_soyad.Enabled = true;
                    txt_tc_no.Enabled = true;
                    cb_cinsiyet.Enabled = true;
                    txt_dogum_tarihi.Enabled = true;
                }

                else
                {
                    txt_soyad.Enabled = false;
                    txt_tc_no.Enabled = false;
                    cb_cinsiyet.Enabled = false;
                    txt_dogum_tarihi.Enabled = false;
                }
            }
        }        

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            Transaction transactionManager = new Transaction(System.Data.IsolationLevel.ReadCommitted, "KullaniciYonetimi");

            if (!(AktifKullanici.FkYetkiId == 1 || AktifKullanici.FkYetkiId == 12))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", "alert('Bu işlem için yetkiniz bulunmamaktadır...')", true);
            }

            try
            {
                BildirimEntity _bildirim = new BildirimEntity(Convert.ToInt32(txtUserName.Text));

                BildirimAtamaGrupCollection _bildirimAtamaGrupColl = new BildirimAtamaGrupCollection();
                BildirimAtamaKullaniciCollection _bildirimAtamaKullaniciColl = new BildirimAtamaKullaniciCollection();
                GecenSureCollection _gecenSureColl = new GecenSureCollection();
                BildirimHistoryCollection _bildirimHistoryColl = new BildirimHistoryCollection();
                SureTakipCollection _sureTakipColl = new SureTakipCollection();
                EkSureCollection _ekSureColl = new EkSureCollection();

                _bildirimAtamaGrupColl.AddRange(_bildirim.BildirimAtamaGrups);
                _bildirimAtamaKullaniciColl.AddRange(_bildirim.BildirimAtamaKullanicis);
                _gecenSureColl.AddRange(_bildirim.GecenSures);
                _bildirimHistoryColl.AddRange(_bildirim.BildirimHistories);
                _sureTakipColl.AddRange(_bildirim.SureTakips);
                _ekSureColl.AddRange(_bildirim.EkSures);

                transactionManager.Add(_bildirimAtamaGrupColl);
                transactionManager.Add(_bildirimAtamaKullaniciColl);
                transactionManager.Add(_gecenSureColl);
                transactionManager.Add(_bildirimHistoryColl);
                transactionManager.Add(_sureTakipColl);
                transactionManager.Add(_ekSureColl);

                _bildirimAtamaGrupColl.DeleteMulti();
                _bildirimAtamaKullaniciColl.DeleteMulti();
                _gecenSureColl.DeleteMulti();
                _bildirimHistoryColl.DeleteMulti();
                _sureTakipColl.DeleteMulti();
                _ekSureColl.DeleteMulti();

                transactionManager.Add(_bildirim);
                _bildirim.Delete();

                transactionManager.Commit();

                string CloseWindow;
                CloseWindow = "alert('Bildirim bilgileri silinmiştir. ...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                ParametreCollection CollPrm = new ParametreCollection();
                IPredicateExpression ExpPrm = new PredicateExpression();
                ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
                CollPrm.GetMulti(ExpPrm);

                DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

                if (Session["sorgula_2"] == null && Session["sorgula_ana"] == null)
                {
                    ListBildirimTypedList bil_list = new ListBildirimTypedList();
                    ISortExpression sort22 = new SortExpression();
                    sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filter2 = new PredicateExpression();
                    filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                    bil_list.Fill(0, sort22, true, filter2);

                    grid_bildirim.DataSource = bil_list;
                    grid_bildirim.DataBind();

                    grid_bildirim_sil.DataSource = bil_list;
                    grid_bildirim_sil.DataBind();
                }

                else 
                {
                    if (Session["sorgula_2"] != null)
                    {
                        ListBildirimTypedList bil_list = new ListBildirimTypedList();
                        ISortExpression sort22 = new SortExpression();
                        sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                        IPredicateExpression filter2 = new PredicateExpression();
                        filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi_2.Text));
                        filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi_2.Text));
                        bil_list.Fill(0, sort22, true, filter2);

                        grid_bildirim_sil.DataSource = bil_list;
                        grid_bildirim_sil.DataBind();
                    }

                    if (Session["sorgula_ana"] != null)
                    {
                        ListBildirimTypedList bil_list = new ListBildirimTypedList();
                        ISortExpression sort22 = new SortExpression();
                        sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                        IPredicateExpression filter2 = new PredicateExpression();
                        filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                        filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
                        bil_list.Fill(0, sort22, true, filter2);

                        grid_bildirim.DataSource = bil_list;
                        grid_bildirim.DataBind();
                    }
                }

                btn_guncelle.Enabled = false;
                btn_sil.Enabled = false;
                btn_ata.Enabled = false;
            }

            catch
            {
                transactionManager.Rollback();

                string CloseWindow;
                CloseWindow = "alert('Silme işlemi sırasında bir problemle karşılaşılmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            finally
            {
                transactionManager.Dispose();
            }
        }

        protected void grid_bildirim_ProcessColumnAutoFilter(object sender, EventArgs e)
        {
            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            ListBildirimTypedList bil_list = new ListBildirimTypedList();
            ISortExpression sort22 = new SortExpression();
            sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filter2 = new PredicateExpression();

            if (Session["sorgula_ana"] == null)
            {
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
            }

            else
            {
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
            }

            bil_list.Fill(0, sort22, true, filter2);

            grid_bildirim.DataSource = bil_list;
            grid_bildirim.DataBind();
        }

        protected void grid_bildirim_PageIndexChanged(object sender, EventArgs e)
        {
            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            ListBildirimTypedList bil_list = new ListBildirimTypedList();
            ISortExpression sort22 = new SortExpression();
            sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filter2 = new PredicateExpression();

            if (Session["sorgula_ana"] == null)
            {
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
            }

            else
            {
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
            }

            bil_list.Fill(0, sort22, true, filter2);

            grid_bildirim.DataSource = bil_list;
            grid_bildirim.DataBind();
        }

        protected void grid_bildirim_BeforeColumnSortingGrouping(object sender, EventArgs e)
        {
            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            ListBildirimTypedList bil_list = new ListBildirimTypedList();
            ISortExpression sort22 = new SortExpression();
            sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filter2 = new PredicateExpression();

            if (Session["sorgula_ana"] == null)
            {
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
            }

            else
            {
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
            }

            bil_list.Fill(0, sort22, true, filter2);

            grid_bildirim.DataSource = bil_list;
            grid_bildirim.DataBind();
        }

        protected void grid_bildirim_sil_ProcessColumnAutoFilter(object sender, EventArgs e)
        {
            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            ListBildirimTypedList bil_list = new ListBildirimTypedList();
            ISortExpression sort22 = new SortExpression();
            sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filter2 = new PredicateExpression();

            if (Session["sorgula_2"] == null)
            {
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
            }

            else
            {
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi_2.Text));
                filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi_2.Text));
            }

            bil_list.Fill(0, sort22, true, filter2);

            grid_bildirim_sil.DataSource = bil_list;
            grid_bildirim_sil.DataBind();
        }

        protected void grid_bildirim_sil_CustomCollback(object sender, EventArgs e)
        {
            try
            {
                txtUserName.Text = grid_bildirim_sil.GetSelectedFieldValues("BildirimId")[0].ToString();

                Session["bildirim_iceri"] = txtUserName.Text;

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserName.Text));
                CollBil.GetMulti(ExpBil);

                Session["vatandas_iceri"] = CollBil[0].FkVatandasId.ToString();

                KullaniciCollection CollKul = new KullaniciCollection();
                IPredicateExpression ExpKul = new PredicateExpression();
                ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollKul.GetMulti(ExpKul);

                YetkiCollection CollYet = new YetkiCollection();
                IPredicateExpression ExpYet = new PredicateExpression();
                ExpYet.AddWithAnd(YetkiFields.YetkiId == CollKul[0].FkYetkiId);
                CollYet.GetMulti(ExpYet);

                if (CollYet[0].YetkiAd == "Admin" || CollYet[0].YetkiAd == "Takım Lideri")
                {
                    btn_sil.Enabled = true;
                }

                else 
                {
                    btn_sil.Enabled = false;
                }               

                btn_guncelle.Enabled = true;
                
                btn_ata.Enabled = true;             

                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucId == CollBil[0].FkBildirimSonucId);
                CollSon.GetMulti(ExpSon);

                grid_bildirim_sil.Selection.UnselectAll();
            }

            catch 
            {

            }            
        }

        protected void grid_bildirim_sil_PageIndexChanged(object sender, EventArgs e)
        {
            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            ListBildirimTypedList bil_list = new ListBildirimTypedList();
            ISortExpression sort22 = new SortExpression();
            sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filter2 = new PredicateExpression();

            if (Session["sorgula_2"] == null)
            {
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
            }

            else
            {
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi_2.Text));
                filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi_2.Text));
            }

            bil_list.Fill(0, sort22, true, filter2);

            grid_bildirim_sil.DataSource = bil_list;
            grid_bildirim_sil.DataBind();
        }

        protected void grid_bildirim_sil_BeforeColumnSortingGrouping(object sender, EventArgs e)
        {
            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            ListBildirimTypedList bil_list = new ListBildirimTypedList();
            ISortExpression sort22 = new SortExpression();
            sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filter2 = new PredicateExpression();

            if (Session["sorgula_2"] == null)
            {
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
            }

            else
            {
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi_2.Text));
                filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi_2.Text));
            }

            bil_list.Fill(0, sort22, true, filter2);

            grid_bildirim_sil.DataSource = bil_list;
            grid_bildirim_sil.DataBind();
        }

        protected void Menu1_MenuItemClick(object sender, MenuItemEventArgs e)
        {
            int index = 0;

            string hexValue = "#FFFFFF";
            string hexValue2 = "#C0D9E7";

            if (e.Item.ToString() == "Yeni Kayıt")
            {
                index = 0;

                foreach (MenuItem item in Menu1.Items)
                {
                    item.ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                }
                Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                //Menu1.Items[1].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                //Menu1.Items[2].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                //Menu1.Items[3].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                //Menu1.Items[4].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
            }

            else if (e.Item.ToString() == "Kayıt Listele - Raporla")
            {
                index = 1;

                foreach (MenuItem item in Menu1.Items)
                {
                    item.ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                }
                Menu1.Items[1].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);

                //Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                //Menu1.Items[1].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                //Menu1.Items[2].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                //Menu1.Items[3].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                //Menu1.Items[4].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);

                ParametreCollection CollPrm = new ParametreCollection();
                IPredicateExpression ExpPrm = new PredicateExpression();
                ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
                CollPrm.GetMulti(ExpPrm);

                DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();

                if (Session["sorgula_ana"] == null)
                {
                    filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                }

                else
                {
                    filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                    filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
                }

                bil_list.Fill(0, sort22, true, filter2);

                grid_bildirim.DataSource = bil_list;
                grid_bildirim.DataBind();
            }

            else if (e.Item.ToString() == "Kayıt Ara - Güncelle")
            {
                index = 2;

                foreach (MenuItem item in Menu1.Items)
                {
                    item.ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                }
                Menu1.Items[2].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);

                ////Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                //Menu1.Items[1].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                //Menu1.Items[2].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                //Menu1.Items[3].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                //Menu1.Items[4].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);

                ParametreCollection CollPrm = new ParametreCollection();
                IPredicateExpression ExpPrm = new PredicateExpression();
                ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
                CollPrm.GetMulti(ExpPrm);

                DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();

                if (Session["sorgula_2"] == null)
                {
                    filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                }

                else
                {
                    filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi_2.Text));
                    filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi_2.Text));
                }

                bil_list.Fill(0, sort22, true, filter2);

                grid_bildirim_sil.DataSource = bil_list;
                grid_bildirim_sil.DataBind();

            }           

            MultiView1.ActiveViewIndex = index;
        }

        protected void btn_sorgula_ana_Click(object sender, EventArgs e)
        {
            try 
            {
                DateTime zaman1 = Convert.ToDateTime(txt_bas_tarihi.Text);
                DateTime zaman2 = Convert.ToDateTime(txt_bit_tarihi.Text);

                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();
                filter2.AddWithAnd(BildirimFields.BildirimTarih > zaman1);
                filter2.AddWithAnd(BildirimFields.BildirimTarih < zaman2);
                bil_list.Fill(0, sort22, true, filter2);

                grid_bildirim.DataSource = bil_list;
                grid_bildirim.DataBind();

                Session["sorgula_ana"] = "1";
            }

            catch 
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen tarih aralıklarını kontrol ediniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }            
        }

        protected void btn_sorgula_2_Click(object sender, EventArgs e)
        {
            try 
            {
                DateTime zaman1 = Convert.ToDateTime(txt_bas_tarihi_2.Text);
                DateTime zaman2 = Convert.ToDateTime(txt_bit_tarihi_2.Text);

                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();
                filter2.AddWithAnd(BildirimFields.BildirimTarih > zaman1);
                filter2.AddWithAnd(BildirimFields.BildirimTarih < zaman2);
                bil_list.Fill(0, sort22, true, filter2);

                grid_bildirim_sil.DataSource = bil_list;
                grid_bildirim_sil.DataBind();

                Session["sorgula_2"] = "1";
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen tarih aralıklarını kontrol ediniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }            
        }
    }
}


