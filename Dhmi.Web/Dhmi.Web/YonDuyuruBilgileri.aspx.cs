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

    public partial class YonDuyuruBilgileri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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

            grid_duyuru_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "DUYURU BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_duyuru_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            grid_duyuru.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_duyuru_sil.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            ListDuyuruTypedList eg_snot = new ListDuyuruTypedList();
            ISortExpression sortss = new SortExpression();
            sortss.Add(new SortClause(DuyuruFields.DuyuruYayinTarih, SortOperator.Descending));
            eg_snot.Fill(0, sortss, true);

            grid_duyuru.DataSource = eg_snot;
            grid_duyuru.DataBind();

            grid_duyuru_sil.DataSource = eg_snot;
            grid_duyuru_sil.DataBind();

            if (IsPostBack != true)
            {
                cb_durum.Items.Clear();

                cb_durum.Items.Add("Aktif");
                cb_durum.Items.Add("Pasif");

                txt_yayintarihi.Text = DateTime.Today.ToShortDateString();

                MenuCollection CollMenu = new MenuCollection();
                IPredicateExpression ExpMenu = new PredicateExpression();
                ExpMenu.AddWithAnd(MenuFields.MenuAd == "Yönetici İşlemleri");
                CollMenu.GetMulti(ExpMenu);

                AltMenuCollection CollAlt1 = new AltMenuCollection();
                IPredicateExpression ExpAlt1 = new PredicateExpression();
                ExpAlt1.AddWithAnd(AltMenuFields.AltMenuAd == "Tanım Yönetimi");
                CollAlt1.GetMulti(ExpAlt1);

                AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                IPredicateExpression ExpAlt2 = new PredicateExpression();
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Duyuru Bilgileri");
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

                Session["par_guncelle_mi"] = "0";
            }

            txt_baslik.Focus();
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_baslik.Text = "";
            txt_icerik.Text = "";
            cb_durum.Text = "";
            cb_durum.NullText = "Seçiniz...";
            txt_yayintarihi.Text = DateTime.Today.ToShortDateString();

            txt_baslik.Focus();
        }

        protected void btnPdfExport_Click(object sender, EventArgs e)
        {
            string ad = "duyuru_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_duyuru_export.WritePdfToResponse(ad);
        }

        protected void btnXlsExport_Click(object sender, EventArgs e)
        {
            string ad = "duyuru_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_duyuru_export.WriteXlsToResponse(ad);
        }

        protected void btnRtfExport_Click(object sender, EventArgs e)
        {
            string ad = "duyuru_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_duyuru_export.WriteRtfToResponse(ad);
        }

        protected void grid_duyuru_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_duyuru.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_duyuru_sil_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_duyuru_sil.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_duyuru_sil_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = grid_duyuru_sil.GetSelectedFieldValues("DuyuruId")[0].ToString();

            btn_guncelle.Enabled = true;
            btn_sil.Enabled = true;
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                DuyuruCollection CollYazz = new DuyuruCollection();
                IPredicateExpression ExpYazz = new PredicateExpression();
                ExpYazz.AddWithAnd(DuyuruFields.DuyuruId == Convert.ToInt32(txtUserName.Text));
                CollYazz.GetMulti(ExpYazz);

                CollYazz[0].Delete();
                CollYazz[0].Save();

                ListDuyuruTypedList eg_snot = new ListDuyuruTypedList();
                ISortExpression sortss = new SortExpression();
                sortss.Add(new SortClause(DuyuruFields.DuyuruYayinTarih, SortOperator.Descending));
                eg_snot.Fill(0, sortss, true);

                grid_duyuru.DataSource = eg_snot;
                grid_duyuru.DataBind();

                grid_duyuru_sil.DataSource = eg_snot;
                grid_duyuru_sil.DataBind();

                btn_guncelle.Enabled = false;
                btn_sil.Enabled = false;

                string CloseWindow;
                CloseWindow = "alert('Silme işlemi tamamlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen bir kayıt seçiniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            DuyuruCollection CollBank = new DuyuruCollection();
            IPredicateExpression ExpBank = new PredicateExpression();
            ExpBank.AddWithAnd(DuyuruFields.DuyuruBaslik == txt_baslik.Text);
            CollBank.GetMulti(ExpBank);

            if (Session["par_guncelle_mi"].ToString() == "0")
            {
                if (CollBank.Count > 0)
                {
                    string CloseWindow;
                    CloseWindow = "alert('Duyuru sistemde kayıtlıdır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else
                {
                    DuyuruEntity EntKay = new DuyuruEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.DuyuruBaslik = txt_baslik.Text;
                    EntKay.DuyuruIcerik = txt_icerik.Text;
                    EntKay.DuyuruResim = "-";
                    EntKay.DuyuruLink = "-";

                    if (cb_durum.Text == "Aktif")
                    {
                        EntKay.DuyuruDurum = true;
                    }

                    else
                    {
                        EntKay.DuyuruDurum = false;
                    }

                    EntKay.DuyuruYayinTarih = Convert.ToDateTime(txt_yayintarihi.Text);
                    EntKay.DuyuruTarih = DateTime.Now;
                    EntKay.Save();

                    string CloseWindow;
                    CloseWindow = "alert('Kayıt işlemi tamamlanmıştır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                    ListDuyuruTypedList eg_snot = new ListDuyuruTypedList();
                    ISortExpression sortss = new SortExpression();
                    sortss.Add(new SortClause(DuyuruFields.DuyuruYayinTarih, SortOperator.Descending));
                    eg_snot.Fill(0, sortss, true);

                    grid_duyuru.DataSource = eg_snot;
                    grid_duyuru.DataBind();

                    grid_duyuru_sil.DataSource = eg_snot;
                    grid_duyuru_sil.DataBind();

                    txt_baslik.Text = "";
                    txt_icerik.Text = "";
                    cb_durum.Text = "";
                    cb_durum.NullText = "Seçiniz...";
                    txt_yayintarihi.Text = DateTime.Today.ToShortDateString();

                    txt_baslik.Focus();
                }
            }

            else
            {
                if (CollBank.Count > 1)
                {
                    string CloseWindow;
                    CloseWindow = "alert('Duyuru sistemde kayıtlıdır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else
                {
                    DuyuruCollection CollYaz = new DuyuruCollection();
                    IPredicateExpression ExpYaz = new PredicateExpression();
                    ExpYaz.AddWithAnd(DuyuruFields.DuyuruId == Convert.ToInt32(txtUserName.Text));
                    CollYaz.GetMulti(ExpYaz);

                    int son_bak = 0;

                    if (CollBank.Count > 0)
                    {
                        if (CollBank[0].DuyuruId == CollYaz[0].DuyuruId)
                        {
                            son_bak = 0;
                        }

                        else
                        {
                            if (CollBank.Count > 0)
                            {
                                son_bak = 1;
                            }

                            else
                            {
                                son_bak = 0;
                            }
                        }
                    }

                    else
                    {
                        son_bak = 0;
                    }

                    if (son_bak == 0)
                    {
                        CollYaz[0].FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                        CollYaz[0].DuyuruBaslik = txt_baslik.Text;
                        CollYaz[0].DuyuruIcerik = txt_icerik.Text;
                        CollYaz[0].DuyuruResim = "-";
                        CollYaz[0].DuyuruLink = "-";

                        if (cb_durum.Text == "Aktif")
                        {
                            CollYaz[0].DuyuruDurum = true;
                        }

                        else
                        {
                            CollYaz[0].DuyuruDurum = false;
                        }

                        CollYaz[0].DuyuruYayinTarih = Convert.ToDateTime(txt_yayintarihi.Text);
                        CollYaz[0].DuyuruTarih = DateTime.Now;
                        CollYaz[0].Save();

                        Session["par_guncelle_mi"] = "0";

                        string CloseWindow;
                        CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        ListDuyuruTypedList eg_snot = new ListDuyuruTypedList();
                        ISortExpression sortss = new SortExpression();
                        sortss.Add(new SortClause(DuyuruFields.DuyuruYayinTarih, SortOperator.Descending));
                        eg_snot.Fill(0, sortss, true);

                        grid_duyuru.DataSource = eg_snot;
                        grid_duyuru.DataBind();

                        grid_duyuru_sil.DataSource = eg_snot;
                        grid_duyuru_sil.DataBind();

                        txt_baslik.Text = "";
                        txt_icerik.Text = "";
                        cb_durum.Text = "";
                        cb_durum.NullText = "Seçiniz...";
                        txt_yayintarihi.Text = DateTime.Today.ToShortDateString();

                        txt_baslik.Focus();
                    }

                    else
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Duyuru sistemde kayıtlıdır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                    }
                }
            }
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            Session["par_guncelle_mi"] = "1";

            Int32 idsi = Convert.ToInt32(txtUserName.Text);

            carTabPage.ActiveTabIndex = 0;

            DuyuruCollection CollYaz = new DuyuruCollection();
            IPredicateExpression ExpYaz = new PredicateExpression();
            ExpYaz.AddWithAnd(DuyuruFields.DuyuruId == Convert.ToInt32(txtUserName.Text));
            CollYaz.GetMulti(ExpYaz);

            txt_baslik.Text = CollYaz[0].DuyuruBaslik;
            txt_icerik.Text = CollYaz[0].DuyuruIcerik;
            txt_yayintarihi.Text = CollYaz[0].DuyuruYayinTarih.ToShortDateString();

            if (CollYaz[0].DuyuruDurum == true)
            {
                cb_durum.Text = "Aktif";
            }

            else
            {
                cb_durum.Text = "Pasif";
            }

            txt_baslik.Focus();
        }
    }
}