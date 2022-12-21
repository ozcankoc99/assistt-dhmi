namespace Dhmi.Web
{
    using System;
    using System.Web.UI;
    using SD.LLBLGen.Pro.ORMSupportClasses;
    using dhmi.CollectionClasses;
    using dhmi.HelperClasses;
    using dhmi.TypedListClasses;
    using dhmi.EntityClasses;
    using System.Web;

    public partial class YonKullaniciYonetimi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txt_sifre.Enabled = true;
            txt_sifre2.Enabled = true;

            Session["menu_sec"] = "Yönetici İşlemleri";

            if ((Session["kullanici_var_mi"] == null) || (Session["kullanici_rastgele"] == null))
            {
                Response.Redirect("Account/Login.aspx");
            }

            HttpCookie cookie = Request.Cookies["userC"];
            HttpCookie cookieYetki = Request.Cookies["aJ4lOu784TyfdEsd4FIoi"];
            if (cookie != null && cookieYetki != null)
            {
                if (Helper.Decrypt(cookieYetki.Value) == "Admin")
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

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            gr_kul_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "KULLANICI BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            gr_kul_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

            ListKulTypedList eg_snot = new ListKulTypedList();
            ISortExpression sortss = new SortExpression();
            sortss.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
            eg_snot.Fill(0, sortss, true);

            grid_kul.DataSource = eg_snot;
            grid_kul.DataBind();

            grid_kul_sil.DataSource = eg_snot;
            grid_kul_sil.DataBind();

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            grid_kul.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_kul_sil.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            if (IsPostBack != true)
            {
                cb_birim.Items.Clear();

                GrupCollection CollTa = new GrupCollection();
                IPredicateExpression ExpTa = new PredicateExpression();
                ISortExpression sortpa = new SortExpression();
                ExpTa.AddWithAnd(GrupFields.GrupAd != "Diğer");
                sortpa.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
                CollTa.GetMulti(ExpTa, 0, sortpa);

                for (int i = 0; i < CollTa.Count; i++) 
                {
                    cb_birim.Items.Add(CollTa[i].GrupAd);
                }

                cb_per_bul.Items.Clear();

                KullaniciCollection CollVer = new KullaniciCollection();
                IPredicateExpression ExpVer = new PredicateExpression();
                ISortExpression sortv = new SortExpression();
                ExpVer.AddWithAnd(KullaniciFields.KullaniciDurum == true);
                sortv.Add(new SortClause(KullaniciFields.KullaniciAd, SortOperator.Ascending));
                CollVer.GetMulti(ExpVer, 0, sortv);

                for (int i = 0; i < CollVer.Count; i++)
                {
                    cb_per_bul.Items.Add(CollVer[i].KullaniciUsername);
                }

                cb_durum.Items.Add("Aktif");
                cb_durum.Items.Add("Pasif");

                MenuCollection CollMenu = new MenuCollection();
                IPredicateExpression ExpMenu = new PredicateExpression();
                ExpMenu.AddWithAnd(MenuFields.MenuAd == "Yönetici İşlemleri");
                CollMenu.GetMulti(ExpMenu);

                AltMenuCollection CollAlt1 = new AltMenuCollection();
                IPredicateExpression ExpAlt1 = new PredicateExpression();
                ExpAlt1.AddWithAnd(AltMenuFields.AltMenuAd == "Hesap Yönetimi");
                CollAlt1.GetMulti(ExpAlt1);

                AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                IPredicateExpression ExpAlt2 = new PredicateExpression();
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Kullanıcı Yönetimi");
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

                Session["kul_guncelle_mi"] = "0";

                YetkiCollection CollYetki = new YetkiCollection();
                ISortExpression sort = new SortExpression();
                sort.Add(new SortClause(YetkiFields.YetkiAd, SortOperator.Ascending));
                CollYetki.GetMulti(null, 0, sort);

                for (int i = 0; i < CollYetki.Count; i++)
                {
                    cb_yetki.Items.Add(CollYetki[i].YetkiAd);
                }

                GorevCollection CollUnv = new GorevCollection();
                ISortExpression sortunv = new SortExpression();
                sortunv.Add(new SortClause(GorevFields.GorevAd, SortOperator.Ascending));
                CollUnv.GetMulti(null, 0, sortunv);

                for (int i = 0; i < CollUnv.Count; i++)
                {
                    cb_gorev.Items.Add(CollUnv[i].GorevAd);
                }

                HiyerarsiTurCollection CollHi = new HiyerarsiTurCollection();
                ISortExpression sorthi = new SortExpression();
                sorthi.Add(new SortClause(HiyerarsiTurFields.HiyerarsiTurAd, SortOperator.Ascending));
                CollHi.GetMulti(null, 0, sorthi);

                for (int i = 0; i < CollHi.Count; i++)
                {
                    cb_hiyerarsi.Items.Add(CollHi[i].HiyerarsiTurAd);
                }

                cb_gorev.Focus();
            }
        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["kul_guncelle_mi"].ToString() == "0")
                {
                    if (txt_sifre.Text == txt_sifre2.Text)
                    {
                        KullaniciCollection CollKul = new KullaniciCollection();
                        IPredicateExpression ExpKul = new PredicateExpression();
                        ExpKul.AddWithAnd(KullaniciFields.KullaniciUsername == txt_kullaniciadi.Text);
                        CollKul.GetMulti(ExpKul);

                        if (CollKul.Count > 0)
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Kullanıcı adı sistemde kayıtlıdır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                        }

                        else
                        {
                            KullaniciCollection CollKul22 = new KullaniciCollection();
                            IPredicateExpression ExpKul22 = new PredicateExpression();

                            if (txt_mail.Text == "")
                            {
                                ExpKul22.AddWithAnd(KullaniciFields.KullaniciMail == "kjasklndlcnjdskdlnvjdflvjfdljvdfvdfv");
                            }

                            else
                            {
                                ExpKul22.AddWithAnd(KullaniciFields.KullaniciMail == txt_mail.Text);
                            }

                            CollKul22.GetMulti(ExpKul22);

                            if (CollKul22.Count > 0 || (txt_mail.Text.Length < 4 && txt_mail.Text != ""))
                            {
                                if (CollKul22.Count > 0)
                                {
                                    string CloseWindow;
                                    CloseWindow = "alert('Mail adresi sistemde kayıtlıdır...')";
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                                }

                                else
                                {
                                    string CloseWindow;
                                    CloseWindow = "alert('Mail adresi hatalıdır...')";
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                                }
                            }

                            else
                            {
                                KullaniciCollection CollKulAs = new KullaniciCollection();
                                IPredicateExpression ExpKulAs = new PredicateExpression();
                                ExpKulAs.AddWithAnd(KullaniciFields.KullaniciAdSoyad == txt_ad.Text + " " + txt_soyad.Text);
                                CollKulAs.GetMulti(ExpKulAs);

                                if (CollKulAs.Count > 0)
                                {
                                    string CloseWindow;
                                    CloseWindow = "alert('Ad Soyad sistemde kayıtlıdır...')";
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                                }

                                else
                                {
                                    if (!Helper.HasAnyCapital(txt_sifre.Text) || !Helper.HasEnoughChar(txt_sifre.Text) || !Helper.HasAnyNumber(txt_sifre.Text) || !Helper.HasAnySpecialChar(txt_sifre.Text))
                                    {
                                        string CloseWindow;
                                        CloseWindow = "alert('Kullanıcı şifresi 6 ile 9 karakter aralığında olmalı, özel karakter içermeli, Büyük-Küçük harf içermeli ve Rakam içermelidir...')";
                                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                                    }
                                    else
                                    {
                                        GorevCollection CollBir = new GorevCollection();
                                        IPredicateExpression ExpBir = new PredicateExpression();
                                        ExpBir.AddWithAnd(GorevFields.GorevAd == cb_gorev.Text);
                                        CollBir.GetMulti(ExpBir);

                                        HiyerarsiTurCollection CollHi = new HiyerarsiTurCollection();
                                        IPredicateExpression ExpHi = new PredicateExpression();
                                        ExpHi.AddWithAnd(HiyerarsiTurFields.HiyerarsiTurAd == cb_hiyerarsi.Text);
                                        CollHi.GetMulti(ExpHi);

                                        YetkiCollection CollYet = new YetkiCollection();
                                        IPredicateExpression ExpYet = new PredicateExpression();
                                        ExpYet.AddWithAnd(YetkiFields.YetkiAd == cb_yetki.Text);
                                        CollYet.GetMulti(ExpYet);

                                        KullaniciEntity EntKul = new KullaniciEntity();
                                        EntKul.FkGorevId = CollBir[0].GorevId;
                                        EntKul.FkYetkiId = Convert.ToInt16(CollYet[0].YetkiId);
                                        EntKul.FkHiyerarsiTurId = CollHi[0].HiyerarsiTurId;
                                        EntKul.KullaniciAciklama = "";
                                        EntKul.KullaniciAd = txt_ad.Text;
                                        EntKul.KullaniciDurum = true;
                                        EntKul.KullaniciMail = txt_mail.Text;
                                                                                
                                        string kayit = Kullanici.sifre_olustur(txt_sifre.Text);                                                                                                                        

                                        EntKul.KullaniciPassword = kayit;
                                        EntKul.KullaniciSoyad = txt_soyad.Text.ToUpper();
                                        EntKul.KullaniciAdSoyad = txt_ad.Text + " " + txt_soyad.Text.ToUpper();
                                        EntKul.KullaniciTarih = DateTime.Now;
                                        EntKul.KullaniciUsername = txt_kullaniciadi.Text;
                                        EntKul.KullaniciAciklama = txt_aciklama.Text;
                                        EntKul.TcKimlikNo = txt_tc_no.Text;
                                        EntKul.AvayaLoginId = txt_avaya.Text;
                                        EntKul.Extension = txt_exs.Text;

                                        if (cb_birim.Text != "") 
                                        {
                                            EntKul.KullaniciBirim = cb_birim.Text;
                                        }

                                        if (cb_durum.Text == "Aktif")
                                        {
                                            EntKul.KullaniciDurum = true;
                                        }

                                        else
                                        {
                                            EntKul.KullaniciDurum = false;
                                        }

                                        EntKul.Save();

                                        KullaniciCollection CollBul = new KullaniciCollection();
                                        IPredicateExpression ExpBul = new PredicateExpression();
                                        ExpBul.AddWithAnd(KullaniciFields.KullaniciUsername == txt_kullaniciadi.Text);
                                        CollBul.GetMulti(ExpBul);

                                        string CloseWindow;
                                        CloseWindow = "alert('Kayıt işlemi tamamlanmıştır...')";
                                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                        ListKulTypedList eg_snot = new ListKulTypedList();
                                        ISortExpression sortss = new SortExpression();
                                        sortss.Add(new SortClause(KullaniciFields.KullaniciAd, SortOperator.Ascending));
                                        eg_snot.Fill(0, sortss, true);

                                        grid_kul.DataSource = eg_snot;
                                        grid_kul.DataBind();

                                        grid_kul_sil.DataSource = eg_snot;
                                        grid_kul_sil.DataBind();

                                        ParametreCollection CollPar = new ParametreCollection();
                                        IPredicateExpression ExpPar = new PredicateExpression();
                                        ExpPar.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
                                        CollPar.GetMulti(ExpPar);

                                        ParametreEntity EntGir = new ParametreEntity();
                                        EntGir.FkKullaniciId = CollBul[0].KullaniciId;
                                        EntGir.FkParametreTurId = CollPar[0].FkParametreTurId;
                                        EntGir.ParametreAd = CollPar[0].ParametreAd;
                                        EntGir.ParametreBasTarih = CollPar[0].ParametreBasTarih;
                                        EntGir.ParametreBitTarih = CollPar[0].ParametreBitTarih;
                                        EntGir.ParametreDeger = CollPar[0].ParametreDeger;
                                        EntGir.ParametreIslemTarih = DateTime.Today;
                                        EntGir.Save();

                                        cb_gorev.Text = "";
                                        cb_gorev.NullText = "Seçiniz...";
                                        cb_durum.Text = "";
                                        cb_durum.NullText = "Seçiniz...";
                                        cb_hiyerarsi.Text = "";
                                        cb_hiyerarsi.NullText = "Seçiniz...";
                                        txt_aciklama.Text = "";
                                        cb_yetki.Text = "";
                                        cb_yetki.NullText = "Seçiniz...";
                                        cb_birim.Text = "";
                                        cb_birim.NullText = "Seçiniz...";
                                        txt_ad.Text = "";
                                        txt_kullaniciadi.Text = "";
                                        txt_mail.Text = "";
                                        txt_sifre.Text = "";
                                        txt_sifre2.Text = "";
                                        txt_soyad.Text = "";
                                        txt_tc_no.Text = "";
                                        txt_avaya.Text = "";
                                        txt_exs.Text = "";

                                        cb_gorev.Focus();
                                    }
                                }
                            }
                        }
                    }

                    else
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Şifre bilgileri tutarsızdır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                    }
                }

                else
                {
                    KullaniciCollection CollKulBas = new KullaniciCollection();
                    IPredicateExpression ExpKulBas = new PredicateExpression();
                    ExpKulBas.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt32(txtUserName.Text));
                    CollKulBas.GetMulti(ExpKulBas);

                    KullaniciCollection CollKul = new KullaniciCollection();
                    IPredicateExpression ExpKul = new PredicateExpression();
                    ExpKul.AddWithAnd(KullaniciFields.KullaniciUsername == txt_kullaniciadi.Text);
                    CollKul.GetMulti(ExpKul);

                    if (CollKul.Count > 1)
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Kullanıcı adı sistemde kayıtlıdır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        txt_sifre.Enabled = false;
                        txt_sifre2.Enabled = false;
                    }

                    else
                    {
                        string gelme = "";

                        if (txt_mail.Text == "")
                        {
                            gelme = "asdascwewcwec0w8r3";
                        }

                        else 
                        {
                            gelme = txt_mail.Text;
                        }

                        KullaniciCollection CollKul22 = new KullaniciCollection();
                        IPredicateExpression ExpKul22 = new PredicateExpression();
                        ExpKul22.AddWithAnd(KullaniciFields.KullaniciMail == gelme);
                        CollKul22.GetMulti(ExpKul22);

                        if (CollKul22.Count > 1 || gelme.Length < 8)
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Mail adresi sistemde kayıtlıdır ya da hatalıdır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            txt_sifre.Enabled = false;
                            txt_sifre2.Enabled = false;
                        }

                        else
                        {
                            KullaniciCollection CollKulAs = new KullaniciCollection();
                            IPredicateExpression ExpKulAs = new PredicateExpression();
                            ExpKulAs.AddWithAnd(KullaniciFields.KullaniciAdSoyad == txt_ad.Text + " " + txt_soyad.Text);
                            CollKulAs.GetMulti(ExpKulAs);

                            if (CollKulAs.Count > 1)
                            {
                                string CloseWindow;
                                CloseWindow = "alert('Ad Soyad sistemde kayıtlıdır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                txt_sifre.Enabled = false;
                                txt_sifre2.Enabled = false;
                            }

                            else
                            {
                                int son_bak = 0;

                                if (CollKulBas[0].KullaniciId == CollKul[0].KullaniciId)
                                {
                                    son_bak = 0;
                                }

                                else
                                {
                                    if (CollKul.Count > 0)
                                    {
                                        son_bak = 1;
                                    }

                                    else if (CollKul22.Count > 0)
                                    {
                                        son_bak = 1;
                                    }

                                    else
                                    {
                                        son_bak = 0;
                                    }
                                }

                                if (son_bak == 0)
                                {
                                    GorevCollection CollBir = new GorevCollection();
                                    IPredicateExpression ExpBir = new PredicateExpression();
                                    ExpBir.AddWithAnd(GorevFields.GorevAd == cb_gorev.Text);
                                    CollBir.GetMulti(ExpBir);

                                    HiyerarsiTurCollection CollHi = new HiyerarsiTurCollection();
                                    IPredicateExpression ExpHi = new PredicateExpression();
                                    ExpHi.AddWithAnd(HiyerarsiTurFields.HiyerarsiTurAd == cb_hiyerarsi.Text);
                                    CollHi.GetMulti(ExpHi);

                                    YetkiCollection CollYet = new YetkiCollection();
                                    IPredicateExpression ExpYet = new PredicateExpression();
                                    ExpYet.AddWithAnd(YetkiFields.YetkiAd == cb_yetki.Text);
                                    CollYet.GetMulti(ExpYet);

                                    CollKulBas[0].FkGorevId = CollBir[0].GorevId;
                                    CollKulBas[0].FkHiyerarsiTurId = CollHi[0].HiyerarsiTurId;
                                    CollKulBas[0].FkYetkiId = Convert.ToInt16(CollYet[0].YetkiId);
                                    CollKulBas[0].KullaniciAd = txt_ad.Text;
                                    CollKulBas[0].KullaniciMail = txt_mail.Text;
                                    CollKulBas[0].KullaniciSoyad = txt_soyad.Text.ToUpper();
                                    CollKulBas[0].KullaniciAdSoyad = txt_ad.Text + " " + txt_soyad.Text.ToUpper();
                                    CollKulBas[0].KullaniciTarih = DateTime.Now;
                                    CollKulBas[0].KullaniciUsername = txt_kullaniciadi.Text;
                                    CollKulBas[0].KullaniciAciklama = txt_aciklama.Text;
                                    CollKulBas[0].TcKimlikNo = txt_tc_no.Text;
                                    CollKulBas[0].AvayaLoginId = txt_avaya.Text;
                                    CollKulBas[0].Extension = txt_exs.Text;

                                    if (cb_birim.Text != "")
                                    {
                                        CollKulBas[0].KullaniciBirim = cb_birim.Text;
                                    }

                                    if (cb_durum.Text == "Aktif")
                                    {
                                        CollKulBas[0].KullaniciDurum = true;
                                    }

                                    else
                                    {
                                        CollKulBas[0].KullaniciDurum = false;
                                    }

                                    CollKulBas[0].Save();

                                    Session["kul_guncelle_mi"] = "0";

                                    string CloseWindow;
                                    CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                    ListKulTypedList eg_snot = new ListKulTypedList();
                                    ISortExpression sortss = new SortExpression();
                                    sortss.Add(new SortClause(KullaniciFields.KullaniciAd, SortOperator.Ascending));
                                    eg_snot.Fill(0, sortss, true);

                                    grid_kul.DataSource = eg_snot;
                                    grid_kul.DataBind();

                                    grid_kul_sil.DataSource = eg_snot;
                                    grid_kul_sil.DataBind();

                                    cb_gorev.Text = "";
                                    cb_gorev.NullText = "Seçiniz...";
                                    cb_durum.Text = "";
                                    cb_durum.NullText = "Seçiniz...";
                                    cb_hiyerarsi.Text = "";
                                    cb_hiyerarsi.NullText = "Seçiniz...";
                                    txt_aciklama.Text = "";
                                    cb_yetki.Text = "";
                                    cb_yetki.NullText = "Seçiniz...";
                                    cb_birim.Text = "";
                                    cb_birim.NullText = "Seçiniz...";
                                    txt_ad.Text = "";
                                    txt_kullaniciadi.Text = "";
                                    txt_mail.Text = "";
                                    txt_sifre.Text = "";
                                    txt_sifre2.Text = "";
                                    txt_soyad.Text = "";
                                    txt_tc_no.Text = "";
                                    txt_avaya.Text = "";
                                    txt_exs.Text = "";

                                    cb_gorev.Focus();
                                }

                                else
                                {
                                    string CloseWindow;
                                    CloseWindow = "alert('Kullanıcı Adı ya da Mail adresi sistemde kayıtlıdır...')";
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                    txt_sifre.Enabled = false;
                                    txt_sifre2.Enabled = false;
                                }
                            }
                        }
                    }
                }
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('İzin bilgilerini kontrol ediniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            cb_gorev.Text = "";
            cb_gorev.NullText = "Seçiniz...";
            cb_durum.Text = "";
            cb_durum.NullText = "Seçiniz...";
            cb_hiyerarsi.Text = "";
            cb_hiyerarsi.NullText = "Seçiniz...";
            txt_aciklama.Text = "";
            cb_yetki.Text = "";
            cb_yetki.NullText = "Seçiniz...";
            cb_birim.Text = "";
            cb_birim.NullText = "Seçiniz...";
            txt_ad.Text = "";
            txt_kullaniciadi.Text = "";
            txt_mail.Text = "";
            txt_sifre.Text = "";
            txt_sifre2.Text = "";
            txt_soyad.Text = "";
            txt_tc_no.Text = "";
            txt_avaya.Text = "";
            txt_exs.Text = "";

            cb_gorev.Focus();
        }

        protected void grid_kul_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_kul.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void btnPdfExport_Click(object sender, EventArgs e)
        {
            string ad = "kullanici_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            gr_kul_export.WritePdfToResponse(ad);
        }

        protected void btnXlsExport_Click(object sender, EventArgs e)
        {
            string ad = "kullanici_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            gr_kul_export.WriteXlsToResponse(ad);
        }

        protected void btnRtfExport_Click(object sender, EventArgs e)
        {
            string ad = "kullanici_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            gr_kul_export.WriteRtfToResponse(ad);
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            Session["kul_guncelle_mi"] = "1";

            Int32 idsi = Convert.ToInt32(txtUserName.Text);

            carTabPage.ActiveTabIndex = 0;

            KullaniciCollection CollNot = new KullaniciCollection();
            IPredicateExpression ExpNot = new PredicateExpression();
            ExpNot.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt32(txtUserName.Text));
            CollNot.GetMulti(ExpNot);

            GorevCollection CollBir = new GorevCollection();
            IPredicateExpression ExpBir = new PredicateExpression();
            ExpBir.AddWithAnd(GorevFields.GorevId == CollNot[0].FkGorevId);
            CollBir.GetMulti(ExpBir);

            HiyerarsiTurCollection CollHi = new HiyerarsiTurCollection();
            IPredicateExpression ExpHi = new PredicateExpression();
            ExpHi.AddWithAnd(HiyerarsiTurFields.HiyerarsiTurId == CollNot[0].FkHiyerarsiTurId);
            CollHi.GetMulti(ExpHi);

            YetkiCollection CollYet = new YetkiCollection();
            IPredicateExpression ExpYet = new PredicateExpression();
            ExpYet.AddWithAnd(YetkiFields.YetkiId == CollNot[0].FkYetkiId);
            CollYet.GetMulti(ExpYet);

            cb_gorev.Text = CollBir[0].GorevAd;
            cb_yetki.Text = CollYet[0].YetkiAd;
            cb_hiyerarsi.Text = CollHi[0].HiyerarsiTurAd;
            txt_aciklama.Text = CollNot[0].KullaniciAciklama;

            txt_ad.Text = CollNot[0].KullaniciAd;
            txt_soyad.Text = CollNot[0].KullaniciSoyad;
            txt_kullaniciadi.Text = CollNot[0].KullaniciUsername;
            txt_mail.Text = CollNot[0].KullaniciMail;
            txt_tc_no.Text = CollNot[0].TcKimlikNo;
            txt_avaya.Text = CollNot[0].AvayaLoginId;
            txt_exs.Text = CollNot[0].Extension;

            if (CollNot[0].KullaniciBirim != "" && CollNot[0].KullaniciBirim != null) 
            {
                cb_birim.Text = CollNot[0].KullaniciBirim;
            }

            txt_sifre.Enabled = false;
            txt_sifre2.Enabled = false;

            if (CollNot[0].KullaniciDurum == true)
            {
                cb_durum.Text = "Aktif";
            }

            else
            {
                cb_durum.Text = "Pasif";
            }

            cb_gorev.Focus();
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                KullaniciCollection CollNot = new KullaniciCollection();
                IPredicateExpression ExpNot = new PredicateExpression();
                ExpNot.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt32(txtUserName.Text));
                CollNot.GetMulti(ExpNot);

                ParametreCollection CollPar = new ParametreCollection();
                IPredicateExpression ExpPar = new PredicateExpression();
                ExpPar.AddWithAnd(ParametreFields.FkKullaniciId == CollNot[0].KullaniciId);
                CollPar.GetMulti(ExpPar);

                for (int m = 0; m < CollPar.Count; m++)
                {
                    CollPar[m].Delete();
                    CollPar[m].Save();
                }

                LogCollection CollLog = new LogCollection();
                IPredicateExpression ExpLog = new PredicateExpression();
                ExpLog.AddWithAnd(LogFields.FkKullaniciId == CollNot[0].KullaniciId);
                CollLog.GetMulti(ExpLog);

                for (int m = 0; m < CollLog.Count; m++)
                {
                    CollLog[m].Delete();
                    CollLog[m].Save();
                }

                CollNot[0].Delete();
                CollNot[0].Save();

                ListKulTypedList eg_snot = new ListKulTypedList();
                ISortExpression sortss = new SortExpression();
                sortss.Add(new SortClause(KullaniciFields.KullaniciAd, SortOperator.Ascending));
                eg_snot.Fill(0, sortss, true);

                grid_kul.DataSource = eg_snot;
                grid_kul.DataBind();

                grid_kul_sil.DataSource = eg_snot;
                grid_kul_sil.DataBind();

                btn_guncelle.Enabled = false;
                btn_sil.Enabled = false;

                cb_per_bul.Items.Clear();

                KullaniciCollection CollVer = new KullaniciCollection();
                IPredicateExpression ExpVer = new PredicateExpression();
                ISortExpression sortv = new SortExpression();
                ExpVer.AddWithAnd(KullaniciFields.KullaniciDurum == true);
                sortv.Add(new SortClause(KullaniciFields.KullaniciAd, SortOperator.Ascending));
                CollVer.GetMulti(ExpVer, 0, sortv);

                for (int i = 0; i < CollVer.Count; i++)
                {
                    cb_per_bul.Items.Add(CollVer[i].KullaniciUsername);
                }

                string CloseWindow;
                CloseWindow = "alert('Silme işlemi tamamlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Sistemde aktif olarak kullanılan bir kullanıcıyı silemezsiniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void grid_kul_sil_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = grid_kul_sil.GetSelectedFieldValues("KullaniciId")[0].ToString();

            btn_guncelle.Enabled = true;
            btn_sil.Enabled = true;
        }

        protected void grid_kul_sil_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_kul_sil.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void btn_per_bul_Click(object sender, EventArgs e)
        {
            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciUsername == cb_per_bul.Text);
            CollKul.GetMulti(ExpKul);

            txt_yetki_ad.Text = CollKul[0].KullaniciAd;
            txt_yetki_soyad.Text = CollKul[0].KullaniciSoyad;

            Random rastgele = new Random();
            Int32 sayi = rastgele.Next(100000, 999999);

            txt_yet_sifre.Text = sayi.ToString();

            btn_son_kay.Enabled = true;
        }

        protected void btn_son_kay_Click(object sender, EventArgs e)
        {
            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciUsername == cb_per_bul.Text);
            CollKul.GetMulti(ExpKul);

            string neee = Kullanici.sifre_olustur(txt_yet_sifre.Text);

            CollKul[0].KullaniciPassword = neee;
            CollKul[0].KullaniciTarih = DateTime.Today;
            CollKul[0].Save();

            string CloseWindow;
            CloseWindow = "alert('Şifre(parola) sıfırlama işlemi tamamlanmıştır...')";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

            LogIslemCollection CollLog = new LogIslemCollection();
            IPredicateExpression ExpLog = new PredicateExpression();
            ExpLog.AddWithAnd(LogIslemFields.LogIslemAd == "Şifre Sıfırlama");
            CollLog.GetMulti(ExpLog);

            /*
            LogEntity EntLog = new LogEntity();
            EntLog.FkLogIslemId = CollLog[0].LogIslemId;
            EntLog.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
            EntLog.LogAciklama = cb_per_bul.Text + " kullanıcısının şifresi sıfırlandı.";
            EntLog.LogIpsi = Session["dolasan_ip"].ToString();
            EntLog.LogTarih = DateTime.Now;
            EntLog.Save();*/

            txt_yetki_ad.Text = "";
            txt_yetki_soyad.Text = "";
            txt_yet_sifre.Text = "";

            btn_son_kay.Enabled = false;

            cb_per_bul.Text = "";
            cb_per_bul.Focus();
        }

        protected void k_ad_CheckedChanged(object sender, EventArgs e)
        {
            if (k_ad.Checked == true)
            {
                grid_kul.Columns[2].Visible = true;
            }

            else
            {
                grid_kul.Columns[2].Visible = false;
            }
        }

        protected void k_soyad_CheckedChanged(object sender, EventArgs e)
        {
            if (k_soyad.Checked == true)
            {
                grid_kul.Columns[3].Visible = true;
            }

            else
            {
                grid_kul.Columns[3].Visible = false;
            }
        }

        protected void k_birt_CheckedChanged(object sender, EventArgs e)
        {
            if (k_birt.Checked == true)
            {
                grid_kul.Columns[4].Visible = true;
            }

            else
            {
                grid_kul.Columns[4].Visible = false;
            }
        }

        protected void k_gorev_CheckedChanged(object sender, EventArgs e)
        {
            if (k_gorev.Checked == true)
            {
                grid_kul.Columns[5].Visible = true;
            }

            else
            {
                grid_kul.Columns[5].Visible = false;
            }
        }

        protected void k_yetki_CheckedChanged(object sender, EventArgs e)
        {
            if (k_yetki.Checked == true)
            {
                grid_kul.Columns[6].Visible = true;
            }

            else
            {
                grid_kul.Columns[6].Visible = false;
            }
        }

        protected void k_hiyerarsi_CheckedChanged(object sender, EventArgs e)
        {
            if (k_hiyerarsi.Checked == true)
            {
                grid_kul.Columns[7].Visible = true;
            }

            else
            {
                grid_kul.Columns[7].Visible = false;
            }
        }

        protected void k_kadi_CheckedChanged(object sender, EventArgs e)
        {
            if (k_kadi.Checked == true)
            {
                grid_kul.Columns[8].Visible = true;
            }

            else
            {
                grid_kul.Columns[8].Visible = false;
            }
        }

        protected void k_mail_CheckedChanged(object sender, EventArgs e)
        {
            if (k_mail.Checked == true)
            {
                grid_kul.Columns[9].Visible = true;
            }

            else
            {
                grid_kul.Columns[9].Visible = false;
            }
        }

        protected void k_tcsino_CheckedChanged(object sender, EventArgs e)
        {
            if (k_tcsino.Checked == true)
            {
                grid_kul.Columns[10].Visible = true;
            }

            else
            {
                grid_kul.Columns[10].Visible = false;
            }
        }

        protected void k_avayasi_CheckedChanged(object sender, EventArgs e)
        {
            if (k_avayasi.Checked == true)
            {
                grid_kul.Columns[11].Visible = true;
            }

            else
            {
                grid_kul.Columns[11].Visible = false;
            }
        }

        protected void k_exs_CheckedChanged(object sender, EventArgs e)
        {
            if (k_exs.Checked == true)
            {
                grid_kul.Columns[12].Visible = true;
            }

            else
            {
                grid_kul.Columns[12].Visible = false;
            }
        }

        protected void k_aciklama_CheckedChanged(object sender, EventArgs e)
        {
            if (k_aciklama.Checked == true)
            {
                grid_kul.Columns[13].Visible = true;
            }

            else
            {
                grid_kul.Columns[13].Visible = false;
            }
        }

        protected void k_tar_CheckedChanged(object sender, EventArgs e)
        {
            if (k_tar.Checked == true)
            {
                grid_kul.Columns[14].Visible = true;
            }

            else
            {
                grid_kul.Columns[14].Visible = false;
            }
        }

        protected void k_durum_CheckedChanged(object sender, EventArgs e)
        {
            if (k_durum.Checked == true)
            {
                grid_kul.Columns[15].Visible = true;
            }

            else
            {
                grid_kul.Columns[15].Visible = false;
            }
        }
    }
}