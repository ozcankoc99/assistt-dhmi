using System;
using System.Web.UI;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Threading;
using dhmi.EntityClasses;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using System.Web;

namespace Dhmi.Web
{
    public partial class VtnVatandasBilgileri : System.Web.UI.Page
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
                if (yetki != "Back Office" || yetki != "Kurum Makam")
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
            //KullaniciCollection CollKul = new KullaniciCollection();
            //IPredicateExpression ExpKul = new PredicateExpression();
            //ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            //CollKul.GetMulti(ExpKul);

            grid_vatandas_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "VATANDAŞ BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_vatandas_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

            //Int16 ssss = Convert.ToInt16(Session["kullanici_var_mi"].ToString());

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            int sdsdsd = CollParam.Count;

            grid_vatandas.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_vatandas_sil.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_gecmis.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_liste.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_v_k.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            VatandaCollection CollVat = new VatandaCollection();
            ISortExpression sortss = new SortExpression();
            sortss.Add(new SortClause(VatandaFields.VatandasAdSoyad, SortOperator.Ascending));
            CollVat.GetMulti(null, 0, sortss);

            grid_vatandas.DataSource = CollVat;
            grid_vatandas.DataBind();

            grid_vatandas_sil.DataSource = CollVat;
            grid_vatandas_sil.DataBind();

            grid_gecmis.DataSource = CollVat;
            grid_gecmis.DataBind();

            if (Session["vat_id"] == null)
            {
                grid_v_k.DataSource = CollVat;
                grid_v_k.DataBind();
            }

            else 
            {
                VatandaCollection CollVat2 = new VatandaCollection();
                IPredicateExpression ExpVat2 = new PredicateExpression();
                ExpVat2.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                CollVat2.GetMulti(ExpVat2);

                grid_v_k.DataSource = CollVat2;
                grid_v_k.DataBind();
            }            

            grid_liste.DataSource = CollVat;
            grid_liste.DataBind();

            if (IsPostBack != true)
            {                
                cb_cinsiyet.Items.Clear();
                cb_cinsiyet.Items.Add("Erkek");
                cb_cinsiyet.Items.Add("Kadın");

                cb_kayit_tur.Items.Clear();
                cb_kayit_tur.Items.Add("Gerçek Kişi");
                cb_kayit_tur.Items.Add("Gerçek Kişi (Yabancı)");
                cb_kayit_tur.Items.Add("Tüzel Kişi");

                txt_dogum_tarihi.Text = "01.01.1900";

                txt_uyruk.Text = "T.C.";

                MenuCollection CollMenu = new MenuCollection();
                IPredicateExpression ExpMenu = new PredicateExpression();
                ExpMenu.AddWithAnd(MenuFields.MenuAd == "Çağrı İşlemleri");
                CollMenu.GetMulti(ExpMenu);

                AltMenuCollection CollAlt1 = new AltMenuCollection();
                IPredicateExpression ExpAlt1 = new PredicateExpression();
                ExpAlt1.AddWithAnd(AltMenuFields.AltMenuAd == "Vatandaş Bilgileri");
                CollAlt1.GetMulti(ExpAlt1);

                AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                IPredicateExpression ExpAlt2 = new PredicateExpression();
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Vatandaş Bilgileri");
                CollAlt2.GetMulti(ExpAlt2);

                //KullaniciCollection CollKul2 = new KullaniciCollection();
                //IPredicateExpression ExpKul2 = new PredicateExpression();
                //ExpKul2.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                //CollKul2.GetMulti(ExpKul2);

                //YetkiCollection CollYet = new YetkiCollection();
                //IPredicateExpression ExpYet = new PredicateExpression();
                //ExpYet.AddWithAnd(YetkiFields.YetkiId == CollKul2[0].FkYetkiId);
                //CollYet.GetMulti(ExpYet);

                //YetkiEntity _yetki = AktifKullanici.Yetki;

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
                    //ExpOl.AddWithAnd(IslemOlusturFields.FkYetkiId == CollYet[0].YetkiId);
                    ExpOl.AddWithAnd(IslemOlusturFields.FkYetkiId == AktifKullanici.FkYetkiId);
                    CollOl.GetMulti(ExpOl);

                    if (CollOl.Count > 0)
                    {
                        tab_bas.Tabs[d].Visible = true;

                        IslemCollection CollIslem = new IslemCollection();
                        IPredicateExpression ExpIslem = new PredicateExpression();
                        ExpIslem.AddWithAnd(IslemFields.IslemId == CollIs[d].IslemId);
                        CollIslem.GetMulti(ExpIslem);

                        tab_bas.Tabs[d].HeaderText = CollIslem[0].IslemAd;
                    }

                    else
                    {
                        tab_bas.Tabs[d].Visible = false;
                    }
                }

                Session["par_guncelle_mi"] = "0";
                CollAlt1 = null;
                CollAlt2 = null;
                //CollKul = null;
                //CollKul2 = null;
                CollMenu = null;
                CollParam = null;
                CollVat = null;
                //CollYet = null;

                kara_liste_takip();
                vip_liste_takip();
                atama_sure_takip();
                inceleme_sure_takip();
                inceleme_ek_sure_takip();

                if (Session["vat_gelen"] != null)
                {
                    txt_tel_no.Text = Session["vat_gelen"].ToString();                                        
                }

                else if (Session["vat_id"] != null)
                {
                    Session["par_guncelle_mi"] = "1";
                    txtUserName.Text = Session["vat_id"].ToString();

                    VatandaCollection CollBul = new VatandaCollection();
                    IPredicateExpression ExpBul = new PredicateExpression();
                    ExpBul.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                    CollBul.GetMulti(ExpBul);

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
            }            

            cb_kayit_tur.Focus();
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
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
            txt_tel_no2.Text = "";
            txt_adres.Text = "";
            txt_uyruk.Text = "T.C.";
            txt_pasaport.Text = "";
            txt_vergi_no.Text = "";
            txt_not.Text = "";

            cb_kayit_tur.Focus();
        }

        protected void btnPdfExport_Click(object sender, EventArgs e)
        {
            Session["rapor_adi"] = "Vatandaş Bilgileri";

            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McAraRapor.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void grid_v_k_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_v_k.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_vatandas_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_vatandas.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_vatandas_sil_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_vatandas_sil.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_gecmis_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_gecmis.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_liste_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_liste.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_vatandas_sil_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = grid_vatandas_sil.GetSelectedFieldValues("VatandasId")[0].ToString();

            btn_guncelle.Enabled = true;
            btn_sil.Enabled = true;
        }

        protected void grid_v_k_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName5.Text = grid_v_k.GetSelectedFieldValues("VatandasId")[0].ToString();

            btn_white.Enabled = true;
            btn_black.Enabled = true;
        }

        protected void grid_gecmis_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName2.Text = grid_gecmis.GetSelectedFieldValues("VatandasId")[0].ToString();

            lb_gecmis.Items.Clear();

            VatandasArsivCollection CollArsiv = new VatandasArsivCollection();
            IPredicateExpression ExpArsiv = new PredicateExpression();
            ISortExpression sortarsiv = new SortExpression();
            ExpArsiv.AddWithAnd(VatandasArsivFields.FkVatandasId == Convert.ToInt64(txtUserName2.Text));
            sortarsiv.Add(new SortClause(VatandasArsivFields.VatandasArsivIslemTarih, SortOperator.Descending));
            CollArsiv.GetMulti(ExpArsiv, 0, sortarsiv);

            for (int i = 0; i < CollArsiv.Count; i++)
            {
                lb_gecmis.Items.Add("- " + CollArsiv[i].VatandasArsivIslemTarih.ToShortDateString() + " " + CollArsiv[i].VatandasArsivIslemTarih.ToShortTimeString() + " - " + CollArsiv[i].VatandasArsivAciklama);
            }

            btn_bilgi_gecmis.Enabled = true;
        }

        protected void grid_liste_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName3.Text = grid_liste.GetSelectedFieldValues("VatandasId")[0].ToString();

            btn_cagri.Enabled = true;
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
                VatandaEntity _vatandas = new VatandaEntity(Convert.ToInt32(txtUserName.Text));

                VatandasArsivCollection _vatandasArsivColl = _vatandas.VatandasArsivs;
                transactionManager.Add(_vatandasArsivColl);
                _vatandasArsivColl.DeleteMulti();

                KaraListeCollection _karalisteColl = _vatandas.KaraListes;
                transactionManager.Add(_karalisteColl);
                _karalisteColl.DeleteMulti();

                VipListeCollection _viplisteColl = _vatandas.VipListes;
                transactionManager.Add(_viplisteColl);
                _viplisteColl.DeleteMulti();


                BildirimCollection _bildirimColl = _vatandas.Bildirims;

                BildirimAtamaGrupCollection _bildirimAtamaGrupColl = new BildirimAtamaGrupCollection();
                BildirimAtamaKullaniciCollection _bildirimAtamaKullaniciColl = new BildirimAtamaKullaniciCollection();
                GecenSureCollection _gecenSureColl = new GecenSureCollection();
                BildirimHistoryCollection _bildirimHistoryColl = new BildirimHistoryCollection();
                SureTakipCollection _sureTakipColl = new SureTakipCollection();
                EkSureCollection _ekSureColl = new EkSureCollection();

                foreach (BildirimEntity bildirim in _bildirimColl)
                {
                    _bildirimAtamaGrupColl.AddRange(bildirim.BildirimAtamaGrups);
                    _bildirimAtamaKullaniciColl.AddRange(bildirim.BildirimAtamaKullanicis);
                    _gecenSureColl.AddRange(bildirim.GecenSures);
                    _bildirimHistoryColl.AddRange(bildirim.BildirimHistories);
                    _sureTakipColl.AddRange(bildirim.SureTakips);
                    _ekSureColl.AddRange(bildirim.EkSures);
                }

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

                transactionManager.Add(_bildirimColl);
                _bildirimColl.DeleteMulti();

                transactionManager.Add(_vatandas);
                _vatandas.Delete();

                transactionManager.Commit();

                string CloseWindow;
                CloseWindow = "alert('Vatandaş bilgileri ve yaptığı bildirimler silinmiştir. ...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                VatandaCollection CollVat = new VatandaCollection();
                ISortExpression sortss = new SortExpression();
                sortss.Add(new SortClause(VatandaFields.VatandasAdSoyad, SortOperator.Ascending));
                CollVat.GetMulti(null, 0, sortss);

                grid_vatandas.DataSource = CollVat;
                grid_vatandas.DataBind();

                grid_vatandas_sil.DataSource = CollVat;
                grid_vatandas_sil.DataBind();

                grid_gecmis.DataSource = CollVat;
                grid_gecmis.DataBind();

                if (Session["vat_id"] == null)
                {
                    grid_v_k.DataSource = CollVat;
                    grid_v_k.DataBind();
                }

                else
                {
                    VatandaCollection CollVat2 = new VatandaCollection();
                    IPredicateExpression ExpVat2 = new PredicateExpression();
                    ExpVat2.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                    CollVat2.GetMulti(ExpVat2);

                    grid_v_k.DataSource = CollVat2;
                    grid_v_k.DataBind();
                } 

                grid_liste.DataSource = CollVat;
                grid_liste.DataBind();

                btn_guncelle.Enabled = false;
                btn_sil.Enabled = false;
                btn_white.Enabled = false;
                btn_black.Enabled = false;
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
                if (cb_kayit_tur.Text == "Gerçek Kişi" || cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
                {
                    if (txt_soyad.Text == "" || cb_cinsiyet.Text == "" || cb_cinsiyet.Text == "Seçiniz..." || txt_uyruk.Text=="")
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
                        try
                        {
                            int kimlik_sonuc = 0;

                            if (Session["par_guncelle_mi"].ToString() == "0")
                            {
                                VatandaCollection CollVat = new VatandaCollection();
                                IPredicateExpression ExpVat = new PredicateExpression();

                                if (txt_tc_no.Text == "")
                                {
                                    ExpVat.AddWithAnd(VatandaFields.VatandasTcNo == "11111111111");
                                }

                                else
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
                                        kimlik_sonuc = 0;
                                    }

                                    else
                                    {
                                        kimlik_sonuc = 1;
                                    }

                                    ExpVat.AddWithAnd(VatandaFields.VatandasTcNo == txt_tc_no.Text);
                                }

                                if (kimlik_sonuc == 0)
                                {
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
                                        if (CollVat.Count > 0 && !string.IsNullOrEmpty(txt_tc_no.Text))
                                        {
                                            string CloseWindow;
                                            CloseWindow = "alert('TC Kimlik Numarası sistemde kayıtlıdır...')";
                                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                            txt_tc_no.Focus();
                                        }

                                        else if (CollVat2.Count > 0 && !string.IsNullOrEmpty(txt_tel_no.Text))
                                        {
                                            string CloseWindow;
                                            CloseWindow = "alert('Telefon Numarası sistemde kayıtlıdır...')";
                                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                            txt_tel_no.Focus();
                                        }

                                        else if (CollVat3.Count > 0 && !string.IsNullOrEmpty(txt_mail.Text))
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
                                        int dene = 0;
                                        int topla = 0;

                                        if (txt_tel_no.Text != "")
                                        {
                                            telli = txt_tel_no.Text.Trim().Replace(" ", string.Empty);
                                            string basla = telli[0].ToString();

                                            for (int i = 0; i < telli.Length; i++)
                                            {
                                                topla = topla + Convert.ToInt16(telli[i].ToString());

                                                if (telli[i].ToString() == basla)
                                                {
                                                    dene = dene + 1;
                                                }
                                            }
                                        }

                                        else 
                                        {
                                            dene = 100;
                                            topla = 100;
                                        }

                                        if (dene == telli.Length || topla <= 11)
                                        {
                                            string CloseWindow;
                                            CloseWindow = "alert('Telefon Numarası hatalıdır...')";
                                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                            txt_tel_no.Focus();
                                        }

                                        else
                                        {
                                            VatandaEntity EntKay = new VatandaEntity();
                                            EntKay.FkKullaniciId = AktifKullanici.KullaniciId;//Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                            EntKay.VatandasAd = txt_ad.Text.ToUpper();
                                            EntKay.VatandasAdres = txt_adres.Text;
                                            EntKay.VatandasTur = cb_kayit_tur.Text;
                                            EntKay.VatandasIslemTarih = DateTime.Now;

                                            if (cb_kayit_tur.Text == "Gerçek Kişi" || cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
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
                                                EntKay.VatandasAdSoyad = txt_ad.Text.ToUpper();
                                            }

                                            EntKay.VatandasMail = txt_mail.Text;
                                            EntKay.VatandasNotes = txt_not.Text;
                                            EntKay.VatandasTel1 = txt_tel_no.Text.Trim().Replace(" ", string.Empty);
                                            EntKay.VatandasTel2 = txt_tel_no2.Text.Trim().Replace(" ", string.Empty);
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

                                            //KullaniciCollection CollKul = new KullaniciCollection();
                                            //IPredicateExpression ExpKul = new PredicateExpression();
                                            //ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                                            //CollKul.GetMulti(ExpKul);

                                            VatandasArsivEntity EntAr = new VatandasArsivEntity();
                                            EntAr.FkVatandasId = CollBul[0].VatandasId;
                                            EntAr.VatandasArsivIslemTarih = DateTime.Now;
                                            //EntAr.VatandasArsivAciklama = CollKul[0].KullaniciAdSoyad + " tarafından kayıt altına alındı.";
                                            EntAr.VatandasArsivAciklama = AktifKullanici.KullaniciAdSoyad + " tarafından kayıt altına alındı.";
                                            EntAr.Save();

                                            VatandaCollection CollVat22 = new VatandaCollection();
                                            ISortExpression sortss22 = new SortExpression();
                                            sortss22.Add(new SortClause(VatandaFields.VatandasAdSoyad, SortOperator.Ascending));
                                            CollVat22.GetMulti(null, 0, sortss22);

                                            grid_vatandas.DataSource = CollVat22;
                                            grid_vatandas.DataBind();

                                            grid_vatandas_sil.DataSource = CollVat22;
                                            grid_vatandas_sil.DataBind();

                                            grid_gecmis.DataSource = CollVat22;
                                            grid_gecmis.DataBind();

                                            grid_liste.DataSource = CollVat22;
                                            grid_liste.DataBind();

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
                                            txt_tel_no2.Text = "";
                                            txt_adres.Text = "";
                                            txt_uyruk.Text = "T.C.";
                                            txt_pasaport.Text = "";
                                            txt_vergi_no.Text = "";
                                            txt_not.Text = "";

                                            AltAltMenuCollection CollGit = new AltAltMenuCollection();
                                            IPredicateExpression ExpGit = new PredicateExpression();
                                            ExpGit.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Çağrı Kayıt Bilgileri");
                                            CollGit.GetMulti(ExpGit);

                                            VatandaCollection CollBaa = new VatandaCollection();
                                            IPredicateExpression ExpBaa = new PredicateExpression();
                                            ExpBaa.AddWithAnd(VatandaFields.VatandasId == CollBul[0].VatandasId);
                                            CollBaa.GetMulti(ExpBaa);

                                            Session["vat_id"] = CollBaa[0].VatandasId.ToString();

                                            Response.Redirect(CollGit[0].AltAltMenuSonLink);
                                        }
                                    }
                                }

                                else
                                {
                                    string CloseWindow;
                                    CloseWindow = "alert('TC Kimlik Numarası hatalıdır...')";
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                                }
                            }

                            else
                            {
                                VatandaCollection CollVat = new VatandaCollection();
                                IPredicateExpression ExpVat = new PredicateExpression();
                                ExpVat.AddWithAnd(VatandaFields.VatandasTcNo == txt_tc_no.Text);
                                CollVat.GetMulti(ExpVat);

                                VatandaCollection CollEx = new VatandaCollection();
                                IPredicateExpression ExpEx = new PredicateExpression();
                                ExpEx.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(txtUserName.Text));
                                CollEx.GetMulti(ExpEx);

                                string telli = "";
                                int dene = 0;
                                int topla = 0;

                                if (txt_tel_no.Text != "")
                                {
                                    telli = txt_tel_no.Text;
                                    string basla = telli[0].ToString();

                                    for (int i = 0; i < telli.Length; i++)
                                    {
                                        topla = topla + Convert.ToInt16(telli[i].ToString());

                                        if (telli[i].ToString() == basla)
                                        {
                                            dene = dene + 1;
                                        }
                                    }
                                }

                                else
                                {
                                    dene = 100;
                                    topla = 100;
                                }

                                if (dene == telli.Length || topla <= 11)
                                {
                                    string CloseWindow;
                                    CloseWindow = "alert('Telefon Numarası hatalıdır...')";
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                    txt_tel_no.Focus();
                                }

                                else
                                {
                                    if (CollVat.Count > 0 && !string.IsNullOrEmpty(txt_tc_no.Text))
                                    {
                                        if (CollVat[0].VatandasId == CollEx[0].VatandasId)
                                        {
                                            CollEx[0].FkKullaniciId = AktifKullanici.KullaniciId;//Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                            CollEx[0].VatandasAd = txt_ad.Text.ToUpper();
                                            CollEx[0].VatandasAdres = txt_adres.Text;
                                            CollEx[0].VatandasTur = cb_kayit_tur.Text;
                                            CollEx[0].VatandasIslemTarih = DateTime.Now;

                                            if (cb_kayit_tur.Text == "Gerçek Kişi" || cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
                                            {
                                                CollEx[0].VatandasSoyad = txt_soyad.Text.ToUpper();
                                                CollEx[0].VatandasAdSoyad = txt_ad.Text.ToUpper() + " " + txt_soyad.Text.ToUpper();
                                                CollEx[0].VatandasCinsiyet = cb_cinsiyet.Text;

                                                if (txt_dogum_tarihi.Text != "01.01.1900")
                                                {
                                                    CollEx[0].VatandasDogumTarihi = Convert.ToDateTime(txt_dogum_tarihi.Text);
                                                }

                                                CollEx[0].VatandasTcNo = txt_tc_no.Text;
                                            }

                                            else
                                            {
                                                CollEx[0].VatandasAdSoyad = txt_ad.Text.ToUpper();
                                                CollEx[0].VatandasSoyad = "";
                                                CollEx[0].VatandasCinsiyet = "";
                                                CollEx[0].VatandasDogumTarihi = null;
                                                CollEx[0].VatandasTcNo = "";
                                            }

                                            CollEx[0].VatandasMail = txt_mail.Text;
                                            CollEx[0].VatandasNotes = txt_not.Text;
                                            CollEx[0].VatandasTel1 = txt_tel_no.Text.Trim().Replace(" ", string.Empty);
                                            CollEx[0].VatandasTel2 = txt_tel_no2.Text.Trim().Replace(" ", string.Empty);
                                            CollEx[0].VatandasUyruk = txt_uyruk.Text;
                                            CollEx[0].VatandasPasaportNo = txt_pasaport.Text;
                                            CollEx[0].Save();

                                            string CloseWindow;
                                            CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                            KullaniciCollection CollKul = new KullaniciCollection();
                                            IPredicateExpression ExpKul = new PredicateExpression();
                                            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                                            CollKul.GetMulti(ExpKul);

                                            VatandasArsivEntity EntAr = new VatandasArsivEntity();
                                            EntAr.FkVatandasId = CollEx[0].VatandasId;
                                            EntAr.VatandasArsivIslemTarih = DateTime.Now;
                                            EntAr.VatandasArsivAciklama = CollKul[0].KullaniciAdSoyad + " tarafından kayıtları güncellendi.";
                                            EntAr.Save();

                                            Session["par_guncelle_mi"] = "0";

                                            VatandaCollection CollVat22 = new VatandaCollection();
                                            ISortExpression sortss22 = new SortExpression();
                                            sortss22.Add(new SortClause(VatandaFields.VatandasAdSoyad, SortOperator.Ascending));
                                            CollVat22.GetMulti(null, 0, sortss22);

                                            grid_vatandas.DataSource = CollVat22;
                                            grid_vatandas.DataBind();

                                            grid_vatandas_sil.DataSource = CollVat22;
                                            grid_vatandas_sil.DataBind();

                                            grid_gecmis.DataSource = CollVat22;
                                            grid_gecmis.DataBind();

                                            grid_liste.DataSource = CollVat22;
                                            grid_liste.DataBind();

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
                                            txt_tel_no2.Text = "";
                                            txt_adres.Text = "";
                                            txt_uyruk.Text = "T.C.";
                                            txt_pasaport.Text = "";
                                            txt_vergi_no.Text = "";
                                            txt_not.Text = "";

                                            cb_kayit_tur.Focus();
                                        }

                                        else
                                        {
                                            string CloseWindow;
                                            CloseWindow = "alert('Vatandaş/Firma sistemde kayıtlıdır...')";
                                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                                        }
                                    }

                                    else
                                    {
                                        CollEx[0].FkKullaniciId = AktifKullanici.KullaniciId;//Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                        CollEx[0].VatandasAd = txt_ad.Text.ToUpper();
                                        CollEx[0].VatandasAdres = txt_adres.Text;
                                        CollEx[0].VatandasTur = cb_kayit_tur.Text;
                                        CollEx[0].VatandasIslemTarih = DateTime.Now;

                                        if (cb_kayit_tur.Text == "Gerçek Kişi" || cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
                                        {
                                            CollEx[0].VatandasSoyad = txt_soyad.Text.ToUpper();
                                            CollEx[0].VatandasAdSoyad = txt_ad.Text.ToUpper() + " " + txt_soyad.Text.ToUpper();
                                            CollEx[0].VatandasCinsiyet = cb_cinsiyet.Text;

                                            if (txt_dogum_tarihi.Text != "01.01.1900")
                                            {
                                                CollEx[0].VatandasDogumTarihi = Convert.ToDateTime(txt_dogum_tarihi.Text);
                                            }

                                            CollEx[0].VatandasTcNo = txt_tc_no.Text;
                                        }

                                        else
                                        {
                                            CollEx[0].VatandasAdSoyad = txt_ad.Text.ToUpper();
                                            CollEx[0].VatandasSoyad = "";
                                            CollEx[0].VatandasCinsiyet = "";
                                            CollEx[0].VatandasDogumTarihi = null;
                                            CollEx[0].VatandasTcNo = "";
                                        }

                                        CollEx[0].VatandasMail = txt_mail.Text;
                                        CollEx[0].VatandasNotes = txt_not.Text;
                                        CollEx[0].VatandasTel1 = txt_tel_no.Text.Trim().Replace(" ", string.Empty);
                                        CollEx[0].VatandasTel2 = txt_tel_no2.Text.Trim().Replace(" ", string.Empty);
                                        CollEx[0].VatandasUyruk = txt_uyruk.Text;
                                        CollEx[0].VatandasPasaportNo = txt_pasaport.Text;
                                        CollEx[0].Save();

                                        string CloseWindow;
                                        CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                        KullaniciCollection CollKul = new KullaniciCollection();
                                        IPredicateExpression ExpKul = new PredicateExpression();
                                        ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                                        CollKul.GetMulti(ExpKul);

                                        VatandasArsivEntity EntAr = new VatandasArsivEntity();
                                        EntAr.FkVatandasId = CollEx[0].VatandasId;
                                        EntAr.VatandasArsivIslemTarih = DateTime.Now;
                                        EntAr.VatandasArsivAciklama = CollKul[0].KullaniciAdSoyad + " tarafından kayıtları güncellendi.";
                                        EntAr.Save();

                                        Session["par_guncelle_mi"] = "0";

                                        VatandaCollection CollVat22 = new VatandaCollection();
                                        ISortExpression sortss22 = new SortExpression();
                                        sortss22.Add(new SortClause(VatandaFields.VatandasAdSoyad, SortOperator.Ascending));
                                        CollVat22.GetMulti(null, 0, sortss22);

                                        grid_vatandas.DataSource = CollVat22;
                                        grid_vatandas.DataBind();

                                        grid_vatandas_sil.DataSource = CollVat22;
                                        grid_vatandas_sil.DataBind();

                                        grid_gecmis.DataSource = CollVat22;
                                        grid_gecmis.DataBind();

                                        grid_liste.DataSource = CollVat22;
                                        grid_liste.DataBind();

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
                                        txt_tel_no2.Text = "";
                                        txt_adres.Text = "";
                                        txt_uyruk.Text = "T.C.";
                                        txt_pasaport.Text = "";
                                        txt_vergi_no.Text = "";
                                        txt_not.Text = "";

                                        cb_kayit_tur.Focus();
                                    }
                                }
                            }
                        }

                        catch
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Lütfen verileri kontrol ediniz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            cb_kayit_tur.Focus();
                        }
                    }
                }

                else
                {
                    if (Session["par_guncelle_mi"].ToString() == "0")
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
                            if (CollVat.Count > 0 && !string.IsNullOrEmpty(txt_tc_no.Text))
                            {
                                string CloseWindow;
                                CloseWindow = "alert('TC Kimlik Numarası sistemde kayıtlıdır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                txt_tc_no.Focus();
                            }

                            else if (CollVat2.Count > 0 && !string.IsNullOrEmpty(txt_tel_no.Text))
                            {
                                string CloseWindow;
                                CloseWindow = "alert('Telefon Numarası sistemde kayıtlıdır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                txt_tel_no.Focus();
                            }

                            else if (CollVat3.Count > 0 && !string.IsNullOrEmpty(txt_mail.Text))
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

                            if (cb_kayit_tur.Text == "Gerçek Kişi" || cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
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
                                EntKay.VatandasAdSoyad = txt_ad.Text.ToUpper();
                            }

                            EntKay.VatandasMail = txt_mail.Text;
                            EntKay.VatandasNotes = txt_not.Text;
                            EntKay.VatandasTel1 = txt_tel_no.Text.Trim().Replace(" ", string.Empty);
                            EntKay.VatandasTel2 = txt_tel_no2.Text.Trim().Replace(" ", string.Empty);
                            EntKay.VatandasUyruk = txt_uyruk.Text;
                            EntKay.VatandasPasaportNo = txt_pasaport.Text;
                            EntKay.VatandasVergiNo = txt_vergi_no.Text;
                            EntKay.Save();

                            string message = "Kayıt işlemi tamamlanmıştır. Kayıt numarası";
                            System.Text.StringBuilder sb = new System.Text.StringBuilder();
                            sb.Append("<script type = 'text/javascript'>");
                            sb.Append("window.onload=function(){");
                            sb.Append("alert('");
                            sb.Append(message);
                            sb.Append("')};");
                            sb.Append("</script>");
                            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

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

                            //KullaniciCollection CollKul = new KullaniciCollection();
                            //IPredicateExpression ExpKul = new PredicateExpression();
                            //ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                            //CollKul.GetMulti(ExpKul);

                            VatandasArsivEntity EntAr = new VatandasArsivEntity();
                            EntAr.FkVatandasId = CollBul[0].VatandasId;
                            EntAr.VatandasArsivIslemTarih = DateTime.Now;
                            EntAr.VatandasArsivAciklama = AktifKullanici.KullaniciAdSoyad + " tarafından kayıt altına alındı."; //CollKul[0].KullaniciAdSoyad + " tarafından kayıt altına alındı.";
                            EntAr.Save();

                            VatandaCollection CollVat22 = new VatandaCollection();
                            ISortExpression sortss22 = new SortExpression();
                            sortss22.Add(new SortClause(VatandaFields.VatandasAdSoyad, SortOperator.Ascending));
                            CollVat22.GetMulti(null, 0, sortss22);

                            grid_vatandas.DataSource = CollVat22;
                            grid_vatandas.DataBind();

                            grid_vatandas_sil.DataSource = CollVat22;
                            grid_vatandas_sil.DataBind();

                            grid_gecmis.DataSource = CollVat22;
                            grid_gecmis.DataBind();

                            grid_liste.DataSource = CollVat22;
                            grid_liste.DataBind();

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
                            txt_tel_no2.Text = "";
                            txt_adres.Text = "";
                            txt_uyruk.Text = "T.C.";
                            txt_pasaport.Text = "";
                            txt_vergi_no.Text = "";
                            txt_not.Text = "";

                            AltAltMenuCollection CollGit = new AltAltMenuCollection();
                            IPredicateExpression ExpGit = new PredicateExpression();
                            ExpGit.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Çağrı Kayıt Bilgileri");
                            CollGit.GetMulti(ExpGit);

                            VatandaCollection CollBaa = new VatandaCollection();
                            IPredicateExpression ExpBaa = new PredicateExpression();
                            ExpBaa.AddWithAnd(VatandaFields.VatandasId == CollBul[0].VatandasId);
                            CollBaa.GetMulti(ExpBaa);

                            Session["vat_id"] = CollBaa[0].VatandasId.ToString();

                            Response.Redirect(CollGit[0].AltAltMenuSonLink);
                        }
                    }

                    else
                    {
                        VatandaCollection CollVat = new VatandaCollection();
                        IPredicateExpression ExpVat = new PredicateExpression();

                        if (txt_tc_no.Text == "")
                        {
                            ExpVat.AddWithAnd(VatandaFields.VatandasAdSoyad == txt_ad.Text.ToUpper());
                        }

                        else
                        {
                            ExpVat.AddWithAnd(VatandaFields.VatandasTcNo == txt_tc_no.Text);
                        }

                        CollVat.GetMulti(ExpVat);

                        VatandaCollection CollEx = new VatandaCollection();
                        IPredicateExpression ExpEx = new PredicateExpression();
                        ExpEx.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(txtUserName.Text));
                        CollEx.GetMulti(ExpEx);

                        if (CollVat.Count > 0)
                        {
                            if (CollVat[0].VatandasId == CollEx[0].VatandasId)
                            {
                                CollEx[0].FkKullaniciId = AktifKullanici.KullaniciId;//Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                CollEx[0].VatandasAd = txt_ad.Text.ToUpper();
                                CollEx[0].VatandasAdres = txt_adres.Text;
                                CollEx[0].VatandasTur = cb_kayit_tur.Text;
                                CollEx[0].VatandasIslemTarih = DateTime.Now;

                                if (cb_kayit_tur.Text == "Gerçek Kişi" || cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
                                {
                                    CollEx[0].VatandasSoyad = txt_soyad.Text.ToUpper();
                                    CollEx[0].VatandasAdSoyad = txt_ad.Text.ToUpper() + " " + txt_soyad.Text.ToUpper();
                                    CollEx[0].VatandasCinsiyet = cb_cinsiyet.Text;

                                    if (txt_dogum_tarihi.Text != "01.01.1900")
                                    {
                                        CollEx[0].VatandasDogumTarihi = Convert.ToDateTime(txt_dogum_tarihi.Text);
                                    }

                                    CollEx[0].VatandasTcNo = txt_tc_no.Text;
                                }

                                else
                                {
                                    CollEx[0].VatandasAdSoyad = txt_ad.Text.ToUpper();
                                    CollEx[0].VatandasSoyad = "";
                                    CollEx[0].VatandasCinsiyet = "";
                                    CollEx[0].VatandasDogumTarihi = null;
                                    CollEx[0].VatandasTcNo = "";
                                }

                                CollEx[0].VatandasMail = txt_mail.Text;
                                CollEx[0].VatandasNotes = txt_not.Text;
                                CollEx[0].VatandasTel1 = txt_tel_no.Text.Trim().Replace(" ", string.Empty);
                                CollEx[0].VatandasTel2 = txt_tel_no2.Text.Trim().Replace(" ", string.Empty);
                                CollEx[0].VatandasUyruk = txt_uyruk.Text;
                                CollEx[0].VatandasPasaportNo = txt_pasaport.Text;
                                CollEx[0].VatandasVergiNo = txt_vergi_no.Text;
                                CollEx[0].Save();

                                string CloseWindow;
                                CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                //KullaniciCollection CollKul = new KullaniciCollection();
                                //IPredicateExpression ExpKul = new PredicateExpression();
                                //ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                                //CollKul.GetMulti(ExpKul);

                                VatandasArsivEntity EntAr = new VatandasArsivEntity();
                                EntAr.FkVatandasId = CollEx[0].VatandasId;
                                EntAr.VatandasArsivIslemTarih = DateTime.Now;
                                EntAr.VatandasArsivAciklama = AktifKullanici.KullaniciAdSoyad + " tarafından kayıtları güncellendi.";//CollKul[0].KullaniciAdSoyad + " tarafından kayıtları güncellendi.";
                                EntAr.Save();

                                Session["par_guncelle_mi"] = "0";

                                VatandaCollection CollVat22 = new VatandaCollection();
                                ISortExpression sortss22 = new SortExpression();
                                sortss22.Add(new SortClause(VatandaFields.VatandasAdSoyad, SortOperator.Ascending));
                                CollVat22.GetMulti(null, 0, sortss22);

                                grid_vatandas.DataSource = CollVat22;
                                grid_vatandas.DataBind();

                                grid_vatandas_sil.DataSource = CollVat22;
                                grid_vatandas_sil.DataBind();

                                grid_gecmis.DataSource = CollVat22;
                                grid_gecmis.DataBind();

                                grid_liste.DataSource = CollVat22;
                                grid_liste.DataBind();

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
                                txt_tel_no2.Text = "";
                                txt_adres.Text = "";
                                txt_uyruk.Text = "T.C.";
                                txt_pasaport.Text = "";
                                txt_vergi_no.Text = "";
                                txt_not.Text = "";

                                cb_kayit_tur.Focus();
                            }

                            else
                            {
                                string CloseWindow;
                                CloseWindow = "alert('Vatandaş/Firma sistemde kayıtlıdır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                            }
                        }

                        else
                        {
                            CollEx[0].FkKullaniciId = AktifKullanici.KullaniciId;//Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                            CollEx[0].VatandasAd = txt_ad.Text.ToUpper();
                            CollEx[0].VatandasAdres = txt_adres.Text;
                            CollEx[0].VatandasTur = cb_kayit_tur.Text;
                            CollEx[0].VatandasIslemTarih = DateTime.Now;

                            if (cb_kayit_tur.Text == "Gerçek Kişi" || cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
                            {
                                CollEx[0].VatandasSoyad = txt_soyad.Text.ToUpper();
                                CollEx[0].VatandasAdSoyad = txt_ad.Text.ToUpper() + " " + txt_soyad.Text.ToUpper();
                                CollEx[0].VatandasCinsiyet = cb_cinsiyet.Text;

                                if (txt_dogum_tarihi.Text != "01.01.1900")
                                {
                                    CollEx[0].VatandasDogumTarihi = Convert.ToDateTime(txt_dogum_tarihi.Text);
                                }

                                CollEx[0].VatandasTcNo = txt_tc_no.Text;
                            }

                            else
                            {
                                CollEx[0].VatandasAdSoyad = txt_ad.Text.ToUpper();
                                CollEx[0].VatandasSoyad = "";
                                CollEx[0].VatandasCinsiyet = "";
                                CollEx[0].VatandasDogumTarihi = null;
                                CollEx[0].VatandasTcNo = "";
                            }

                            CollEx[0].VatandasMail = txt_mail.Text;
                            CollEx[0].VatandasNotes = txt_not.Text;
                            CollEx[0].VatandasTel1 = txt_tel_no.Text.Trim().Replace(" ", string.Empty);
                            CollEx[0].VatandasTel2 = txt_tel_no2.Text.Trim().Replace(" ", string.Empty);
                            CollEx[0].VatandasUyruk = txt_uyruk.Text;
                            CollEx[0].VatandasPasaportNo = txt_pasaport.Text;
                            CollEx[0].VatandasVergiNo = txt_vergi_no.Text;
                            CollEx[0].Save();

                            string CloseWindow;
                            CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            Session["par_guncelle_mi"] = "0";

                            KullaniciCollection CollKul = new KullaniciCollection();
                            IPredicateExpression ExpKul = new PredicateExpression();
                            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                            CollKul.GetMulti(ExpKul);

                            VatandasArsivEntity EntAr = new VatandasArsivEntity();
                            EntAr.FkVatandasId = CollEx[0].VatandasId;
                            EntAr.VatandasArsivIslemTarih = DateTime.Now;
                            EntAr.VatandasArsivAciklama = CollKul[0].KullaniciAdSoyad + " tarafından kayıtları güncellendi.";
                            EntAr.Save();

                            VatandaCollection CollVat22 = new VatandaCollection();
                            ISortExpression sortss22 = new SortExpression();
                            sortss22.Add(new SortClause(VatandaFields.VatandasAdSoyad, SortOperator.Ascending));
                            CollVat22.GetMulti(null, 0, sortss22);

                            grid_vatandas.DataSource = CollVat22;
                            grid_vatandas.DataBind();

                            grid_vatandas_sil.DataSource = CollVat22;
                            grid_vatandas_sil.DataBind();

                            grid_gecmis.DataSource = CollVat22;
                            grid_gecmis.DataBind();

                            grid_liste.DataSource = CollVat22;
                            grid_liste.DataBind();

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
                            txt_tel_no2.Text = "";
                            txt_adres.Text = "";
                            txt_uyruk.Text = "T.C.";
                            txt_pasaport.Text = "";
                            txt_vergi_no.Text = "";
                            txt_not.Text = "";

                            cb_kayit_tur.Focus();
                        }
                    }
                }
            }            
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            Session["par_guncelle_mi"] = "1";

            string hexValue = "#F2EDED";
            string hexValue2 = "#FFFFFF";

            Int32 idsi = Convert.ToInt32(txtUserName.Text);

            tab_bas.ActiveTabIndex = 1;

            VatandaCollection CollVat = new VatandaCollection();
            IPredicateExpression ExpVat = new PredicateExpression();
            ExpVat.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt32(txtUserName.Text));
            CollVat.GetMulti(ExpVat);

            cb_kayit_tur.Text = CollVat[0].VatandasTur;

            txt_tc_no.Enabled = true;
            btn_kps.Enabled = true;
            txt_soyad.Enabled = true;
            cb_cinsiyet.Enabled = true;
            txt_dogum_tarihi.Enabled = true;

            txt_tc_no.Text = CollVat[0].VatandasTcNo;
            txt_soyad.Text = CollVat[0].VatandasSoyad;

            if (CollVat[0].VatandasDogumTarihi == null)
            {
                txt_dogum_tarihi.Text = "01.01.1900";
            }

            else 
            {
                txt_dogum_tarihi.Text = CollVat[0].VatandasDogumTarihi.ToString();
            }
            
            cb_cinsiyet.Text = CollVat[0].VatandasCinsiyet;

            txt_ad.Text = CollVat[0].VatandasAd;
            txt_adres.Text = CollVat[0].VatandasAdres;
            txt_tel_no.Text = CollVat[0].VatandasTel1;
            txt_tel_no2.Text = CollVat[0].VatandasTel2;
            txt_uyruk.Text = CollVat[0].VatandasUyruk;
            txt_pasaport.Text = CollVat[0].VatandasPasaportNo;
            txt_mail.Text = CollVat[0].VatandasMail;
            txt_not.Text = CollVat[0].VatandasNotes;
            txt_vergi_no.Text = CollVat[0].VatandasVergiNo;

            if (cb_kayit_tur.Text == "Gerçek Kişi")
            {
                txt_uyruk.Enabled = true;                
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
                txt_pasaport.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_vergi_no.Enabled = false;                
                txt_vergi_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_tel_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_tel_no2.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_mail.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_adres.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_not.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);

                txt_tc_no.Focus();
            }

            else if (cb_kayit_tur.Text == "Gerçek Kişi (Yabancı)")
            {
                txt_uyruk.Enabled = true;                
                txt_uyruk.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                txt_tc_no.Enabled = false;
                txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);                
                txt_vergi_no.Enabled = false;
                txt_vergi_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);                
                btn_kps.Enabled = false;
                txt_soyad.Enabled = true;
                txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                cb_cinsiyet.Enabled = true;
                cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                txt_dogum_tarihi.Enabled = true;
                txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_pasaport.Enabled = true;
                txt_pasaport.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);                
                txt_tel_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_tel_no2.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_mail.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_adres.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_not.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);

                txt_pasaport.Focus();
            }

            else
            {
                txt_tc_no.Enabled = false;                
                txt_tc_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                btn_kps.Enabled = false;
                txt_soyad.Enabled = false;                
                txt_soyad.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                cb_cinsiyet.Enabled = false;                                
                cb_cinsiyet.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_dogum_tarihi.Enabled = false;                
                txt_dogum_tarihi.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_pasaport.Enabled = false;                
                txt_pasaport.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_uyruk.Enabled = false;                
                txt_vergi_no.Enabled = true;                
                txt_vergi_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_uyruk.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_tel_no.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_tel_no2.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_mail.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_adres.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_not.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);                

                txt_ad.Focus();
            }

            cb_kayit_tur.Focus();
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
                txt_tel_no2.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_mail.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_adres.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_not.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);

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
                txt_tel_no2.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_mail.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_adres.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_not.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);

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
                txt_tel_no2.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_mail.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_adres.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                txt_not.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);

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

        protected void btn_white_Click(object sender, EventArgs e)
        {
            VatandaCollection CollVat = new VatandaCollection();
            IPredicateExpression ExpVat = new PredicateExpression();
            ExpVat.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(txtUserName5.Text));
            CollVat.GetMulti(ExpVat);

            VipListeCollection CollVip = new VipListeCollection();
            IPredicateExpression ExpVip = new PredicateExpression();
            ExpVip.AddWithAnd(VipListeFields.FkVatandasId == CollVat[0].VatandasId);
            ExpVip.AddWithAnd(VipListeFields.VipListeDurum == true);
            CollVip.GetMulti(ExpVip);

            if (CollVip.Count > 0)
            {
                string CloseWindow;
                CloseWindow = "alert('Mevcutta aktif bir VIP LİSTE kaydı bulunmaktadır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else
            {
                KaraListeCollection CollKara = new KaraListeCollection();
                IPredicateExpression ExpKara = new PredicateExpression();
                ExpKara.AddWithAnd(KaraListeFields.FkVatandasId == CollVat[0].VatandasId);
                ExpKara.AddWithAnd(KaraListeFields.KaraListeDurum == true);
                CollKara.GetMulti(ExpKara);

                if (CollKara.Count > 0)
                {
                    string CloseWindow;
                    CloseWindow = "alert('Mevcutta aktif bir KARA LİSTE kaydı bulunmaktadır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else
                {
                    AltAltMenuCollection CollGit = new AltAltMenuCollection();
                    IPredicateExpression ExpGit = new PredicateExpression();
                    ExpGit.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "VIP Liste Bilgileri");
                    CollGit.GetMulti(ExpGit);

                    Session["vat_id"] = txtUserName5.Text;

                    Response.Redirect(CollGit[0].AltAltMenuSonLink);
                }
            }
        }

        protected void btn_black_Click(object sender, EventArgs e)
        {
            VatandaCollection CollVat = new VatandaCollection();
            IPredicateExpression ExpVat = new PredicateExpression();
            ExpVat.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(txtUserName5.Text));
            CollVat.GetMulti(ExpVat);

            KaraListeCollection CollVip = new KaraListeCollection();
            IPredicateExpression ExpVip = new PredicateExpression();
            ExpVip.AddWithAnd(KaraListeFields.FkVatandasId == CollVat[0].VatandasId);
            ExpVip.AddWithAnd(KaraListeFields.KaraListeDurum == true);
            CollVip.GetMulti(ExpVip);

            if (CollVip.Count > 0)
            {
                string CloseWindow;
                CloseWindow = "alert('Mevcutta aktif bir KARA LİSTE kaydı bulunmaktadır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else
            {
                VipListeCollection CollKara = new VipListeCollection();
                IPredicateExpression ExpKara = new PredicateExpression();
                ExpKara.AddWithAnd(VipListeFields.FkVatandasId == CollVat[0].VatandasId);
                ExpKara.AddWithAnd(VipListeFields.VipListeDurum == true);
                CollKara.GetMulti(ExpKara);

                if (CollKara.Count > 0)
                {
                    string CloseWindow;
                    CloseWindow = "alert('Mevcutta aktif bir VIP LİSTE kaydı bulunmaktadır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else
                {
                    AltAltMenuCollection CollGit = new AltAltMenuCollection();
                    IPredicateExpression ExpGit = new PredicateExpression();
                    ExpGit.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Kara Liste Bilgileri");
                    CollGit.GetMulti(ExpGit);

                    Session["vat_id"] = txtUserName5.Text;

                    Response.Redirect(CollGit[0].AltAltMenuSonLink);
                }
            }
        }

        protected void btn_cagri_Click(object sender, EventArgs e)
        {
            AltAltMenuCollection CollGit = new AltAltMenuCollection();
            IPredicateExpression ExpGit = new PredicateExpression();
            ExpGit.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Çağrı Kayıt Bilgileri");
            CollGit.GetMulti(ExpGit);

            Session["vat_id"] = txtUserName3.Text;

            Response.Redirect(CollGit[0].AltAltMenuSonLink);
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

        void atama_sure_takip()
        {
            //	ListAtamaTypedList list1 = new ListAtamaTypedList();
            //	IPredicateExpression filter1 = new PredicateExpression();
            //	filter1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
            //	filter1.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciBittiMi == false);
            //	list1.Fill(0, null, true, filter1);

            //	for (int i = 0; i < list1.Count; i++) 
            //	{
            //		BildirimTuruCollection CollBilTur = new BildirimTuruCollection();
            //		IPredicateExpression ExpBilTur = new PredicateExpression();
            //		ExpBilTur.AddWithAnd(BildirimTuruFields.BildirimTuruId == list1[i].FkBildirimTuruId);
            //		CollBilTur.GetMulti(ExpBilTur);

            //		Int64 saati = CollBilTur[0].BildirimTuruIslemAlSaatZaman;

            //		TimeSpan fark_bak1 = DateTime.Now - list1[i].BildirimAtamaKullaniciTarih;

            //		string duzle = (fark_bak1.TotalHours).ToString();

            //		double arasi = Convert.ToDouble(duzle);

            //		Int64 ana_fark = Convert.ToInt16(arasi);

            //		if (ana_fark > saati) 
            //		{
            //			KullaniciCollection CollKula = new KullaniciCollection();
            //			IPredicateExpression ExpKula = new PredicateExpression();
            //			ExpKula.AddWithAnd(KullaniciFields.KullaniciId == list1[i].FkKullaniciId_);
            //			CollKula.GetMulti(ExpKula);

            //			BildirimCollection CollBilBul = new BildirimCollection();
            //			IPredicateExpression ExpBilBul = new PredicateExpression();
            //			ExpBilBul.AddWithAnd(BildirimFields.BildirimId == list1[i].FkBildirimId);
            //			CollBilBul.GetMulti(ExpBilBul);

            //			BilgilendirmeCollection CollHa = new BilgilendirmeCollection();
            //			IPredicateExpression ExpHa = new PredicateExpression();
            //			ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeGelenKullanici == "SİSTEM");
            //			ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeGidenKullanici == CollKula[0].KullaniciAdSoyad);
            //			ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeIcerik == CollBilBul[0].BildirimId + " kayıt numaralı bildirim için 'İNCELEMEYE ALMA' işlemi maksimum süresini (" + CollBilTur[0].BildirimTuruIslemAlSure + ") aşmış bulunmaktasınız.");                
            //			CollHa.GetMulti(ExpHa);

            //			if (CollHa.Count > 0)
            //			{
            //				for (int h = 0; h < CollHa.Count; h++)
            //				{
            //					string ara_tar = CollHa[h].BilgilendirmeTarih.ToShortDateString();
            //					string iki_tar = DateTime.Today.ToShortDateString();

            //					if (ara_tar != iki_tar)
            //					{
            //						BilgilendirmeEntity EntMe = new BilgilendirmeEntity();
            //						EntMe.BilgilendirmeGelenKullanici = "SİSTEM";
            //						EntMe.BilgilendirmeGidenKullanici = CollKula[0].KullaniciAdSoyad;
            //						EntMe.BilgilendirmeIcerik = CollBilBul[0].BildirimId + " kayıt numaralı bildirim için 'İNCELEMEYE ALMA' işlemi maksimum süresini (" + CollBilTur[0].BildirimTuruIslemAlSure + ") aşmış bulunmaktasınız.";
            //						EntMe.BilgilendirmeTarih = DateTime.Now;
            //						EntMe.Save();
            //					}
            //				}
            //			}

            //			else 
            //			{
            //				BilgilendirmeEntity EntMe = new BilgilendirmeEntity();
            //				EntMe.BilgilendirmeGelenKullanici = "SİSTEM";
            //				EntMe.BilgilendirmeGidenKullanici = CollKula[0].KullaniciAdSoyad;
            //				EntMe.BilgilendirmeIcerik = CollBilBul[0].BildirimId + " kayıt numaralı bildirim için 'İNCELEMEYE ALMA' işlemi maksimum süresini (" + CollBilTur[0].BildirimTuruIslemAlSure + ") aşmış bulunmaktasınız.";
            //				EntMe.BilgilendirmeTarih = DateTime.Now;
            //				EntMe.Save();
            //			}                                                  
            //		}
            //	}
        }

        void inceleme_sure_takip()
        {
            //	ListAtamaTypedList list1 = new ListAtamaTypedList();
            //	IPredicateExpression filter1 = new PredicateExpression();
            //	filter1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
            //	filter1.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciBittiMi == false);
            //	list1.Fill(0, null, true, filter1);

            //	for (int i = 0; i < list1.Count; i++)
            //	{
            //		BildirimTuruCollection CollBilTur = new BildirimTuruCollection();
            //		IPredicateExpression ExpBilTur = new PredicateExpression();
            //		ExpBilTur.AddWithAnd(BildirimTuruFields.BildirimTuruId == list1[i].FkBildirimTuruId);
            //		CollBilTur.GetMulti(ExpBilTur);

            //		Int64 saati = CollBilTur[0].BildirimTuruIslemAlSaatZaman;

            //		TimeSpan fark_bak1 = DateTime.Now - list1[i].BildirimAtamaKullaniciTarih;

            //		string duzle = (fark_bak1.TotalHours).ToString();

            //		double arasi = Convert.ToDouble(duzle);

            //		Int64 ana_fark = Convert.ToInt16(arasi);

            //		if (ana_fark > saati)
            //		{
            //			KullaniciCollection CollKula = new KullaniciCollection();
            //			IPredicateExpression ExpKula = new PredicateExpression();
            //			ExpKula.AddWithAnd(KullaniciFields.KullaniciId == list1[i].FkKullaniciId_);
            //			CollKula.GetMulti(ExpKula);

            //			BildirimCollection CollBilBul = new BildirimCollection();
            //			IPredicateExpression ExpBilBul = new PredicateExpression();
            //			ExpBilBul.AddWithAnd(BildirimFields.BildirimId == list1[i].FkBildirimId);
            //			CollBilBul.GetMulti(ExpBilBul);

            //			BilgilendirmeCollection CollHa = new BilgilendirmeCollection();
            //			IPredicateExpression ExpHa = new PredicateExpression();
            //			ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeGelenKullanici == "SİSTEM");
            //			ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeGidenKullanici == CollKula[0].KullaniciAdSoyad);
            //			ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeIcerik == CollBilBul[0].BildirimId + " kayıt numaralı bildirim için 'İNCELEME' işlemi maksimum süresini (" + CollBilTur[0].BildirimTuruIslemAlSure + ") aşmış bulunmaktasınız.");
            //			CollHa.GetMulti(ExpHa);

            //			if (CollHa.Count > 0)
            //			{
            //				for (int h = 0; h < CollHa.Count; h++)
            //				{
            //					string ara_tar = CollHa[h].BilgilendirmeTarih.ToShortDateString();
            //					string iki_tar = DateTime.Today.ToShortDateString();

            //					if (ara_tar != iki_tar)
            //					{
            //						BilgilendirmeEntity EntMe = new BilgilendirmeEntity();
            //						EntMe.BilgilendirmeGelenKullanici = "SİSTEM";
            //						EntMe.BilgilendirmeGidenKullanici = CollKula[0].KullaniciAdSoyad;
            //						EntMe.BilgilendirmeIcerik = CollBilBul[0].BildirimId + " kayıt numaralı bildirim için 'İNCELEME' işlemi maksimum süresini (" + CollBilTur[0].BildirimTuruIslemAlSure + ") aşmış bulunmaktasınız.";
            //						EntMe.BilgilendirmeTarih = DateTime.Now;
            //						EntMe.Save();
            //					}
            //				}
            //			}

            //			else
            //			{
            //				BilgilendirmeEntity EntMe = new BilgilendirmeEntity();
            //				EntMe.BilgilendirmeGelenKullanici = "SİSTEM";
            //				EntMe.BilgilendirmeGidenKullanici = CollKula[0].KullaniciAdSoyad;
            //				EntMe.BilgilendirmeIcerik = CollBilBul[0].BildirimId + " kayıt numaralı bildirim için 'İNCELEME' işlemi maksimum süresini (" + CollBilTur[0].BildirimTuruIslemAlSure + ") aşmış bulunmaktasınız.";
            //				EntMe.BilgilendirmeTarih = DateTime.Now;
            //				EntMe.Save();
            //			}
            //		}
            //	}
        }

        void inceleme_ek_sure_takip()
        {
            //	ListAtamaTypedList list1 = new ListAtamaTypedList();
            //	IPredicateExpression filter1 = new PredicateExpression();
            //	filter1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
            //	filter1.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciBittiMi == false);
            //	list1.Fill(0, null, true, filter1);

            //	for (int i = 0; i < list1.Count; i++)
            //	{
            //		BildirimTuruCollection CollBilTur = new BildirimTuruCollection();
            //		IPredicateExpression ExpBilTur = new PredicateExpression();
            //		ExpBilTur.AddWithAnd(BildirimTuruFields.BildirimTuruId == list1[i].FkBildirimTuruId);
            //		CollBilTur.GetMulti(ExpBilTur);

            //		Int64 saati = CollBilTur[0].BildirimTuruIslemAlSaatZaman;

            //		TimeSpan fark_bak1 = DateTime.Now - list1[i].BildirimAtamaKullaniciTarih;

            //		string duzle = (fark_bak1.TotalHours).ToString();

            //		double arasi = Convert.ToDouble(duzle);

            //		Int64 ana_fark = Convert.ToInt16(arasi);

            //		if (ana_fark > saati)
            //		{
            //			KullaniciCollection CollKula = new KullaniciCollection();
            //			IPredicateExpression ExpKula = new PredicateExpression();
            //			ExpKula.AddWithAnd(KullaniciFields.KullaniciId == list1[i].FkKullaniciId_);
            //			CollKula.GetMulti(ExpKula);

            //			BildirimCollection CollBilBul = new BildirimCollection();
            //			IPredicateExpression ExpBilBul = new PredicateExpression();
            //			ExpBilBul.AddWithAnd(BildirimFields.BildirimId == list1[i].FkBildirimId);
            //			CollBilBul.GetMulti(ExpBilBul);

            //			BilgilendirmeCollection CollHa = new BilgilendirmeCollection();
            //			IPredicateExpression ExpHa = new PredicateExpression();
            //			ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeGelenKullanici == "SİSTEM");
            //			ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeGidenKullanici == CollKula[0].KullaniciAdSoyad);
            //			ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeIcerik == CollBilBul[0].BildirimId + " kayıt numaralı bildirim için 'İNCELEME EK SÜRESİ' maksimum süresini (" + CollBilTur[0].BildirimTuruIslemAlSure + ") aşmış bulunmaktasınız.");
            //			CollHa.GetMulti(ExpHa);

            //			if (CollHa.Count > 0)
            //			{
            //				for (int h = 0; h < CollHa.Count; h++)
            //				{
            //					string ara_tar = CollHa[h].BilgilendirmeTarih.ToShortDateString();
            //					string iki_tar = DateTime.Today.ToShortDateString();

            //					if (ara_tar != iki_tar)
            //					{
            //						BilgilendirmeEntity EntMe = new BilgilendirmeEntity();
            //						EntMe.BilgilendirmeGelenKullanici = "SİSTEM";
            //						EntMe.BilgilendirmeGidenKullanici = CollKula[0].KullaniciAdSoyad;
            //						EntMe.BilgilendirmeIcerik = CollBilBul[0].BildirimId + " kayıt numaralı bildirim için 'İNCELEME EK SÜRESİ' maksimum süresini (" + CollBilTur[0].BildirimTuruIslemAlSure + ") aşmış bulunmaktasınız.";
            //						EntMe.BilgilendirmeTarih = DateTime.Now;
            //						EntMe.Save();
            //					}
            //				}
            //			}

            //			else
            //			{
            //				BilgilendirmeEntity EntMe = new BilgilendirmeEntity();
            //				EntMe.BilgilendirmeGelenKullanici = "SİSTEM";
            //				EntMe.BilgilendirmeGidenKullanici = CollKula[0].KullaniciAdSoyad;
            //				EntMe.BilgilendirmeIcerik = CollBilBul[0].BildirimId + " kayıt numaralı bildirim için 'İNCELEME EK SÜRESİ' maksimum süresini (" + CollBilTur[0].BildirimTuruIslemAlSure + ") aşmış bulunmaktasınız.";
            //				EntMe.BilgilendirmeTarih = DateTime.Now;
            //				EntMe.Save();
            //			}
            //		}
            //	}
        }
    }
}