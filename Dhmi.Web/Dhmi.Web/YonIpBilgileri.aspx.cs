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

    public partial class YonIpBilgileri : System.Web.UI.Page
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

            grid_ipler_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "IP BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_ipler_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            grid_ipler.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_ipler_sil.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            ListIpTypedList eg_snot = new ListIpTypedList();
            ISortExpression sortss = new SortExpression();
            sortss.Add(new SortClause(IpBankFields.IpBanksAd, SortOperator.Descending));
            eg_snot.Fill(0, sortss, true);

            grid_ipler.DataSource = eg_snot;
            grid_ipler.DataBind();

            grid_ipler_sil.DataSource = eg_snot;
            grid_ipler_sil.DataBind();

            if (IsPostBack != true)
            {
                cb_durum.Items.Clear();

                cb_durum.Items.Add("Aktif");
                cb_durum.Items.Add("Pasif");

                MenuCollection CollMenu = new MenuCollection();
                IPredicateExpression ExpMenu = new PredicateExpression();
                ExpMenu.AddWithAnd(MenuFields.MenuAd == "Yönetici İşlemleri");
                CollMenu.GetMulti(ExpMenu);

                AltMenuCollection CollAlt1 = new AltMenuCollection();
                IPredicateExpression ExpAlt1 = new PredicateExpression();
                ExpAlt1.AddWithAnd(AltMenuFields.AltMenuAd == "Güvenlik Yönetimi");
                CollAlt1.GetMulti(ExpAlt1);

                AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                IPredicateExpression ExpAlt2 = new PredicateExpression();
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "IP Bilgileri");
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

            txt_ip_adres.Focus();
        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            IpBankCollection CollBank = new IpBankCollection();
            IPredicateExpression ExpBank = new PredicateExpression();
            ExpBank.AddWithAnd(IpBankFields.IpBanksAd == txt_ip_adres.Text);
            CollBank.GetMulti(ExpBank);

            if (Session["par_guncelle_mi"].ToString() == "0")
            {
                if (CollBank.Count > 0)
                {
                    string CloseWindow;
                    CloseWindow = "alert('IP adresi sistemde kayıtlıdır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else
                {
                    IpBankEntity EntKay = new IpBankEntity();
                    EntKay.IpBanksAd = txt_ip_adres.Text;
                    EntKay.IpBanksAciklama = txt_aciklama.Text;

                    if (cb_durum.Text == "Aktif")
                    {
                        EntKay.IpBanksDurum = true;
                    }

                    else
                    {
                        EntKay.IpBanksDurum = false;
                    }

                    EntKay.IpBanksTarih = DateTime.Now;
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.Save();

                    string CloseWindow;
                    CloseWindow = "alert('Kayıt işlemi tamamlanmıştır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                    ListIpTypedList eg_snot = new ListIpTypedList();
                    ISortExpression sortss = new SortExpression();
                    sortss.Add(new SortClause(IpBankFields.IpBanksAd, SortOperator.Descending));
                    eg_snot.Fill(0, sortss, true);

                    grid_ipler.DataSource = eg_snot;
                    grid_ipler.DataBind();

                    grid_ipler_sil.DataSource = eg_snot;
                    grid_ipler_sil.DataBind();

                    txt_ip_adres.Text = "";
                    txt_aciklama.Text = "";
                    cb_durum.Text = "";
                    cb_durum.NullText = "Seçiniz...";

                    txt_ip_adres.Focus();
                }
            }

            else
            {
                if (CollBank.Count > 1)
                {
                    string CloseWindow;
                    CloseWindow = "alert('IP adresi sistemde kayıtlıdır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else
                {
                    IpBankCollection CollYaz = new IpBankCollection();
                    IPredicateExpression ExpYaz = new PredicateExpression();
                    ExpYaz.AddWithAnd(IpBankFields.IpBanksId == Convert.ToInt32(txtUserName.Text));
                    CollYaz.GetMulti(ExpYaz);

                    int son_bak = 0;

                    if (CollBank[0].IpBanksId == CollYaz[0].IpBanksId)
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

                    if (son_bak == 0)
                    {
                        CollYaz[0].IpBanksAd = txt_ip_adres.Text;
                        CollYaz[0].IpBanksAciklama = txt_aciklama.Text;

                        if (cb_durum.Text == "Aktif")
                        {
                            CollYaz[0].IpBanksDurum = true;
                        }

                        else
                        {
                            CollYaz[0].IpBanksDurum = false;
                        }

                        CollYaz[0].IpBanksTarih = DateTime.Now;
                        CollYaz[0].FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                        CollYaz[0].Save();

                        Session["par_guncelle_mi"] = "0";

                        string CloseWindow;
                        CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        ListIpTypedList eg_snot = new ListIpTypedList();
                        ISortExpression sortss = new SortExpression();
                        sortss.Add(new SortClause(IpBankFields.IpBanksAd, SortOperator.Descending));
                        eg_snot.Fill(0, sortss, true);

                        grid_ipler.DataSource = eg_snot;
                        grid_ipler.DataBind();

                        grid_ipler_sil.DataSource = eg_snot;
                        grid_ipler_sil.DataBind();

                        txt_ip_adres.Text = "";
                        txt_aciklama.Text = "";
                        cb_durum.Text = "";
                        cb_durum.NullText = "Seçiniz...";

                        txt_ip_adres.Focus();
                    }

                    else
                    {
                        string CloseWindow;
                        CloseWindow = "alert('IP adresi sistemde kayıtlıdır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                    }
                }
            }
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_ip_adres.Text = "";
            txt_aciklama.Text = "";
            cb_durum.Text = "";
            cb_durum.NullText = "Seçiniz...";
        }

        protected void btnPdfExport_Click(object sender, EventArgs e)
        {
            string ad = "ip_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_ipler_export.WritePdfToResponse(ad);
        }

        protected void btnXlsExport_Click(object sender, EventArgs e)
        {
            string ad = "ip_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_ipler_export.WriteXlsToResponse(ad);
        }

        protected void btnRtfExport_Click(object sender, EventArgs e)
        {
            string ad = "ip_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_ipler_export.WriteRtfToResponse(ad);
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            Session["par_guncelle_mi"] = "1";

            Int32 idsi = Convert.ToInt32(txtUserName.Text);

            carTabPage.ActiveTabIndex = 0;

            IpBankCollection CollYaz = new IpBankCollection();
            IPredicateExpression ExpYaz = new PredicateExpression();
            ExpYaz.AddWithAnd(IpBankFields.IpBanksId == Convert.ToInt32(txtUserName.Text));
            CollYaz.GetMulti(ExpYaz);

            txt_ip_adres.Text = CollYaz[0].IpBanksAd;
            txt_aciklama.Text = CollYaz[0].IpBanksAciklama;

            if (CollYaz[0].IpBanksDurum == true)
            {
                cb_durum.Text = "Aktif";
            }

            else
            {
                cb_durum.Text = "Pasif";
            }

            txt_ip_adres.Focus();
        }

        protected void grid_ipler_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_ipler.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_ipler_sil_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_ipler_sil.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_ipler_sil_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = grid_ipler_sil.GetSelectedFieldValues("IpBanksId")[0].ToString();

            btn_guncelle.Enabled = true;
            btn_sil.Enabled = true;
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                IpBankCollection CollYazz = new IpBankCollection();
                IPredicateExpression ExpYazz = new PredicateExpression();
                ExpYazz.AddWithAnd(IpBankFields.IpBanksId == Convert.ToInt32(txtUserName.Text));
                CollYazz.GetMulti(ExpYazz);

                CollYazz[0].Delete();
                CollYazz[0].Save();

                ListIpTypedList eg_snot = new ListIpTypedList();
                ISortExpression sortss = new SortExpression();
                sortss.Add(new SortClause(IpBankFields.IpBanksAd, SortOperator.Ascending));
                eg_snot.Fill(0, sortss, true);

                grid_ipler.DataSource = eg_snot;
                grid_ipler.DataBind();

                grid_ipler_sil.DataSource = eg_snot;
                grid_ipler_sil.DataBind();

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
    }
}