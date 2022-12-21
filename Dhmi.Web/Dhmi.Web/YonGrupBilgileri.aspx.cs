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

    public partial class YonGrupBilgileri : System.Web.UI.Page
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
                if (Helper.Decrypt(cookieYetki.Value) == "Admin" || Helper.Decrypt(cookieYetki.Value) == "Takım Lideri")
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

            grid_grup_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "GRUP BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_grup_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

            grid_rapor_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "GRUP - KULLANICI BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_rapor_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            grid_grup.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_grup_sil.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_rapor.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            GrupCollection CollGr = new GrupCollection();                       
            ISortExpression sortgr = new SortExpression();
            sortgr.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            CollGr.GetMulti(null, 0, sortgr);

            grid_grup.DataSource = CollGr;
            grid_grup.DataBind();

            grid_grup_sil.DataSource = CollGr;
            grid_grup_sil.DataBind();

            ListGrupAtamaTypedList atama_list = new ListGrupAtamaTypedList();
            ISortExpression sortatama = new SortExpression();
            sortatama.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
            IPredicateExpression filteratama = new PredicateExpression();
            filteratama.AddWithAnd(GrupAtamaFields.GrupAtamaDurum == true);
            atama_list.Fill(0, sortatama, true, filteratama);

            grid_rapor.DataSource = atama_list;
            grid_rapor.DataBind();

            if (IsPostBack != true)
            {
                Session["guncel_ekle"] = "0";

                cb_durum.Items.Clear();
                cb_son_durum.Items.Clear(); 
                cb_durum.Items.Clear();

                cb_durum.Items.Add("Aktif");
                cb_durum.Items.Add("Pasif");

                cb_son_durum.Items.Add("Aktif");
                cb_son_durum.Items.Add("Pasif");

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
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Grup Bilgileri");
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

                GrupCollection CollGr2 = new GrupCollection();
                IPredicateExpression ExpGr2 = new PredicateExpression();
                ExpGr2.AddWithAnd(GrupFields.GrupDurum == true);
                ISortExpression sortgr2 = new SortExpression();
                sortgr2.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
                CollGr2.GetMulti(ExpGr2, 0, sortgr2);

                cb_grup_adi.Items.Clear();

                for (int i = 0; i < CollGr2.Count; i++)
                {
                    cb_grup_adi.Items.Add(CollGr2[i].GrupAd);
                }
            }

            txt_ad.Focus();
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_aciklama.Text = "";
            txt_ad.Text = "";
            txt_amir.Text = "";
            txt_kisaltma.Text = "";
            cb_durum.Text = "";
            cb_durum.NullText = "Seçiniz...";

            txt_ad.Focus();
        }

        protected void btnPdfExport_Click(object sender, EventArgs e)
        {
            string ad = "grup_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_grup_export.WritePdfToResponse(ad);
        }

        protected void btnXlsExport_Click(object sender, EventArgs e)
        {
            string ad = "grup_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_grup_export.WriteXlsToResponse(ad);
        }

        protected void btnRtfExport_Click(object sender, EventArgs e)
        {
            string ad = "grup_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_grup_export.WriteRtfToResponse(ad);
        }

        protected void grid_grup_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_grup.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_rapor_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_rapor.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_grup_sil_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_grup_sil.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_atama_sil_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_atama_sil.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_grup_sil_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = grid_grup_sil.GetSelectedFieldValues("GrupId")[0].ToString();

            btn_guncelle.Enabled = true;
            btn_sil.Enabled = true;
        }

        protected void grid_atama_sil_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName2.Text = grid_atama_sil.GetSelectedFieldValues("GrupAtamaId")[0].ToString();

            btn_guncelle2.Enabled = true;
            btn_sil2.Enabled = true;
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                GrupCollection CollYazz = new GrupCollection();
                IPredicateExpression ExpYazz = new PredicateExpression();
                ExpYazz.AddWithAnd(GrupFields.GrupId == Convert.ToInt32(txtUserName.Text));
                CollYazz.GetMulti(ExpYazz);

                CollYazz[0].Delete();
                CollYazz[0].Save();

                GrupCollection CollGr = new GrupCollection();                                
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
                CollGr.GetMulti(null, 0, sortgr);

                grid_grup.DataSource = CollGr;
                grid_grup.DataBind();

                grid_grup_sil.DataSource = CollGr;
                grid_grup_sil.DataBind();

                btn_guncelle.Enabled = false;
                btn_sil.Enabled = false;

                string CloseWindow;
                CloseWindow = "alert('Silme işlemi tamamlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                GrupCollection CollGr2 = new GrupCollection();
                IPredicateExpression ExpGr2 = new PredicateExpression();
                ExpGr2.AddWithAnd(GrupFields.GrupDurum == true);
                ISortExpression sortgr2 = new SortExpression();
                sortgr2.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
                CollGr2.GetMulti(ExpGr2, 0, sortgr2);

                cb_grup_adi.Items.Clear();

                for (int i = 0; i < CollGr2.Count; i++)
                {
                    cb_grup_adi.Items.Add(CollGr2[i].GrupAd);
                }
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Sistemde aktif olarak kullanılan bir grubu silemezsiniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            GrupCollection CollBank = new GrupCollection();
            IPredicateExpression ExpBank = new PredicateExpression();
            ExpBank.AddWithAnd(GrupFields.GrupAd == txt_ad.Text);
            CollBank.GetMulti(ExpBank);

            if (Session["par_guncelle_mi"].ToString() == "0")
            {
                if (CollBank.Count > 0)
                {
                    string CloseWindow;
                    CloseWindow = "alert('Grup sistemde kayıtlıdır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else
                {
                    GrupEntity EntKay = new GrupEntity();
                    EntKay.GrupAd = txt_ad.Text;
                    EntKay.GrupAmir = txt_amir.Text;
                    EntKay.GrupAciklama = txt_aciklama.Text;
                    EntKay.GrupKisaltma = txt_kisaltma.Text;

                    if (cb_durum.Text == "Aktif")
                    {
                        EntKay.GrupDurum = true;
                    }

                    else
                    {
                        EntKay.GrupDurum = false;
                    }

                    EntKay.GrupTarih = DateTime.Now;
                    EntKay.Save();

                    string CloseWindow;
                    CloseWindow = "alert('Kayıt işlemi tamamlanmıştır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                    GrupCollection CollGr = new GrupCollection();                                        
                    ISortExpression sortgr = new SortExpression();
                    sortgr.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
                    CollGr.GetMulti(null, 0, sortgr);

                    grid_grup.DataSource = CollGr;
                    grid_grup.DataBind();

                    grid_grup_sil.DataSource = CollGr;
                    grid_grup_sil.DataBind();

                    txt_aciklama.Text = "";
                    txt_ad.Text = "";
                    txt_amir.Text = "";
                    txt_kisaltma.Text = "";
                    cb_durum.Text = "";
                    cb_durum.NullText = "Seçiniz...";

                    GrupCollection CollGr2 = new GrupCollection();
                    IPredicateExpression ExpGr2 = new PredicateExpression();
                    ExpGr2.AddWithAnd(GrupFields.GrupDurum == true);
                    ISortExpression sortgr2 = new SortExpression();
                    sortgr2.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
                    CollGr2.GetMulti(ExpGr2, 0, sortgr2);

                    cb_grup_adi.Items.Clear();

                    for (int i = 0; i < CollGr2.Count; i++)
                    {
                        cb_grup_adi.Items.Add(CollGr2[i].GrupAd);
                    }

                    txt_ad.Focus();
                }
            }

            else
            {
                if (CollBank.Count > 1)
                {
                    string CloseWindow;
                    CloseWindow = "alert('Grup sistemde kayıtlıdır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else
                {
                    GrupCollection CollYaz = new GrupCollection();
                    IPredicateExpression ExpYaz = new PredicateExpression();
                    ExpYaz.AddWithAnd(GrupFields.GrupId == Convert.ToInt32(txtUserName.Text));
                    CollYaz.GetMulti(ExpYaz);

                    int son_bak = 0;

                    if (CollBank.Count != 0)
                    {
                        if (CollBank[0].GrupId == CollYaz[0].GrupId)
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
                        CollYaz[0].GrupAd = txt_ad.Text;
                        CollYaz[0].GrupAmir = txt_amir.Text;
                        CollYaz[0].GrupAciklama = txt_aciklama.Text;
                        CollYaz[0].GrupKisaltma = txt_kisaltma.Text;

                        if (cb_durum.Text == "Aktif")
                        {
                            CollYaz[0].GrupDurum = true;
                        }

                        else
                        {
                            CollYaz[0].GrupDurum = false;
                        }

                        CollYaz[0].GrupTarih = DateTime.Now;
                        CollYaz[0].Save();

                        Session["par_guncelle_mi"] = "0";

                        string CloseWindow;
                        CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        GrupCollection CollGr = new GrupCollection();                                                
                        ISortExpression sortgr = new SortExpression();
                        sortgr.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
                        CollGr.GetMulti(null, 0, sortgr);

                        grid_grup.DataSource = CollGr;
                        grid_grup.DataBind();

                        grid_grup_sil.DataSource = CollGr;
                        grid_grup_sil.DataBind();

                        txt_aciklama.Text = "";
                        txt_ad.Text = "";
                        txt_amir.Text = "";
                        txt_kisaltma.Text = "";
                        cb_durum.Text = "";
                        cb_durum.NullText = "Seçiniz...";

                        GrupCollection CollGr2 = new GrupCollection();
                        IPredicateExpression ExpGr2 = new PredicateExpression();
                        ExpGr2.AddWithAnd(GrupFields.GrupDurum == true);
                        ISortExpression sortgr2 = new SortExpression();
                        sortgr2.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
                        CollGr2.GetMulti(ExpGr2, 0, sortgr2);

                        cb_grup_adi.Items.Clear();

                        for (int i = 0; i < CollGr2.Count; i++)
                        {
                            cb_grup_adi.Items.Add(CollGr2[i].GrupAd);
                        }

                        txt_ad.Focus();
                    }

                    else
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Grup sistemde kayıtlıdır...')";
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

            GrupCollection CollYaz = new GrupCollection();
            IPredicateExpression ExpYaz = new PredicateExpression();
            ExpYaz.AddWithAnd(GrupFields.GrupId == Convert.ToInt32(txtUserName.Text));
            CollYaz.GetMulti(ExpYaz);

            txt_aciklama.Text = CollYaz[0].GrupAciklama;
            txt_ad.Text = CollYaz[0].GrupAd;
            txt_amir.Text = CollYaz[0].GrupAmir;
            txt_kisaltma.Text = CollYaz[0].GrupKisaltma;

            if (CollYaz[0].GrupDurum == true)
            {
                cb_durum.Text = "Aktif";
            }

            else
            {
                cb_durum.Text = "Pasif";
            }

            txt_ad.Focus();
        }

        protected void btn_devam_et_Click(object sender, EventArgs e)
        {
            cb_kim.Enabled = true;

            Session["guncel_ekle"] = "0";

            ListGrupAtamaTypedList grup_list = new ListGrupAtamaTypedList();
            ISortExpression sort = new SortExpression();
            sort.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
            IPredicateExpression filter = new PredicateExpression();
            filter.AddWithAnd(GrupFields.GrupAd == cb_grup_adi.Text);
            grup_list.Fill(0, sort, true, filter);

            grid_atama_sil.DataSource = grup_list;
            grid_atama_sil.DataBind();

            cb_kim.Items.Clear();

            KullaniciCollection CollKul = new KullaniciCollection();
            ISortExpression sortkul = new SortExpression();
            sortkul.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
            CollKul.GetMulti(null, 0, sortkul);

            for (int h = 0; h < CollKul.Count; h++)
            {
                int basla = 0;

                for (int i = 0; i < grup_list.Count; i++)
                {
                    if (CollKul[h].KullaniciAdSoyad == grup_list[i].KullaniciAdSoyad)
                    {
                        basla = 1;
                    }
                }

                if (basla == 0)
                {
                    cb_kim.Items.Add(CollKul[h].KullaniciAdSoyad);
                }
            }

            pnl_sor_alt.Visible = true;
        }

        protected void btn_kayit_ekle_Click(object sender, EventArgs e)
        {
            if (Session["guncel_ekle"].ToString() == "0")
            {
                GrupCollection CollGrup = new GrupCollection();
                IPredicateExpression ExpGrup = new PredicateExpression();
                ExpGrup.AddWithAnd(GrupFields.GrupAd == cb_grup_adi.Text);
                CollGrup.GetMulti(ExpGrup);

                KullaniciCollection CollKull = new KullaniciCollection();
                IPredicateExpression ExpKull = new PredicateExpression();
                ExpKull.AddWithAnd(KullaniciFields.KullaniciAdSoyad == cb_kim.Text);
                CollKull.GetMulti(ExpKull);

                GrupAtamaEntity EntKay = new GrupAtamaEntity();
                EntKay.FkGrupId = CollGrup[0].GrupId;
                EntKay.FkKullaniciId = CollKull[0].KullaniciId;
                EntKay.GrupAtamaTarih = DateTime.Now;

                if (cb_son_durum.Text == "Aktif")
                {
                    EntKay.GrupAtamaDurum = true;
                }

                else
                {
                    EntKay.GrupAtamaDurum = false;
                }

                EntKay.Save();
            }

            else
            {
                GrupAtamaCollection CollYaz = new GrupAtamaCollection();
                IPredicateExpression ExpYaz = new PredicateExpression();
                ExpYaz.AddWithAnd(GrupAtamaFields.GrupAtamaId == Convert.ToInt32(txtUserName2.Text));
                CollYaz.GetMulti(ExpYaz);

                if (cb_son_durum.Text == "Aktif")
                {
                    CollYaz[0].GrupAtamaDurum = true;
                }

                else
                {
                    CollYaz[0].GrupAtamaDurum = false;
                }

                CollYaz[0].Save();
            }

            cb_kim.Text = "";
            cb_kim.NullText = "Seçiniz...";
            cb_son_durum.Text = "";
            cb_son_durum.NullText = "Seçiniz...";

            ListGrupAtamaTypedList grup_list = new ListGrupAtamaTypedList();
            ISortExpression sort = new SortExpression();
            sort.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
            IPredicateExpression filter = new PredicateExpression();
            filter.AddWithAnd(GrupFields.GrupAd == cb_grup_adi.Text);
            grup_list.Fill(0, sort, true, filter);

            grid_atama_sil.DataSource = grup_list;
            grid_atama_sil.DataBind();

            cb_kim.Items.Clear();

            KullaniciCollection CollKul = new KullaniciCollection();
            ISortExpression sortkul = new SortExpression();
            sortkul.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
            CollKul.GetMulti(null, 0, sortkul);

            for (int h = 0; h < CollKul.Count; h++)
            {
                int basla = 0;

                for (int i = 0; i < grup_list.Count; i++)
                {
                    if (CollKul[h].KullaniciAdSoyad == grup_list[i].KullaniciAdSoyad)
                    {
                        basla = 1;
                    }
                }

                if (basla == 0)
                {
                    cb_kim.Items.Add(CollKul[h].KullaniciAdSoyad);
                }
            }

            Session["guncel_ekle"] = "0";

            pnl_sor_alt.Visible = true;

            cb_kim.Enabled = true;

            ListGrupAtamaTypedList atama_list = new ListGrupAtamaTypedList();
            ISortExpression sortatama = new SortExpression();
            sortatama.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
            IPredicateExpression filteratama = new PredicateExpression();
            filteratama.AddWithAnd(GrupAtamaFields.GrupAtamaDurum == true);
            atama_list.Fill(0, sortatama, true, filteratama);

            grid_rapor.DataSource = atama_list;
            grid_rapor.DataBind();

            string CloseWindow;
            CloseWindow = "alert('Kayıt/Güncelleme işlemi tamamlanmıştır...')";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
        }

        protected void btn_guncelle2_Click(object sender, EventArgs e)
        {
            GrupAtamaCollection CollYaz = new GrupAtamaCollection();
            IPredicateExpression ExpYaz = new PredicateExpression();
            ExpYaz.AddWithAnd(GrupAtamaFields.GrupAtamaId == Convert.ToInt32(txtUserName2.Text));
            CollYaz.GetMulti(ExpYaz);

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == CollYaz[0].FkKullaniciId);
            CollKul.GetMulti(ExpKul);

            Session["guncel_ekle"] = "1";

            cb_kim.Text = CollKul[0].KullaniciAdSoyad;

            if (CollYaz[0].GrupAtamaDurum == true)
            {
                cb_son_durum.Text = "Aktif";
            }

            else
            {
                cb_son_durum.Text = "Pasif";
            }

            cb_kim.Enabled = false;

            cb_son_durum.Focus();
        }

        protected void btn_sil2_Click(object sender, EventArgs e)
        {
            try
            {
                GrupAtamaCollection CollYaz = new GrupAtamaCollection();
                IPredicateExpression ExpYaz = new PredicateExpression();
                ExpYaz.AddWithAnd(GrupAtamaFields.GrupAtamaId == Convert.ToInt32(txtUserName2.Text));
                CollYaz.GetMulti(ExpYaz);

                CollYaz[0].Delete();
                CollYaz[0].Save();

                string CloseWindow;
                CloseWindow = "alert('Silme işlemi tamamlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                cb_kim.Text = "";
                cb_kim.NullText = "Seçiniz...";
                cb_son_durum.Text = "";
                cb_son_durum.NullText = "Seçiniz...";

                ListGrupAtamaTypedList grup_list = new ListGrupAtamaTypedList();
                ISortExpression sort = new SortExpression();
                sort.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
                IPredicateExpression filter = new PredicateExpression();
                filter.AddWithAnd(GrupFields.GrupAd == cb_grup_adi.Text);
                grup_list.Fill(0, sort, true, filter);

                grid_atama_sil.DataSource = grup_list;
                grid_atama_sil.DataBind();

                cb_kim.Items.Clear();

                cb_kim.Enabled = true;

                KullaniciCollection CollKul = new KullaniciCollection();
                ISortExpression sortkul = new SortExpression();
                sortkul.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
                CollKul.GetMulti(null, 0, sortkul);

                for (int h = 0; h < CollKul.Count; h++)
                {
                    int basla = 0;

                    for (int i = 0; i < grup_list.Count; i++)
                    {
                        if (CollKul[h].KullaniciAdSoyad == grup_list[i].KullaniciAdSoyad)
                        {
                            basla = 1;
                        }
                    }

                    if (basla == 0)
                    {
                        cb_kim.Items.Add(CollKul[h].KullaniciAdSoyad);
                    }
                }

                ListGrupAtamaTypedList atama_list = new ListGrupAtamaTypedList();
                ISortExpression sortatama = new SortExpression();
                sortatama.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
                IPredicateExpression filteratama = new PredicateExpression();
                filteratama.AddWithAnd(GrupAtamaFields.GrupAtamaDurum == true);
                atama_list.Fill(0, sortatama, true, filteratama);

                grid_rapor.DataSource = atama_list;
                grid_rapor.DataBind();
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen bir kayıt seçiniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void btn_rap_pdf_Click(object sender, EventArgs e)
        {
            string ad = "grup_kullanici_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_rapor_export.WritePdfToResponse(ad);
        }

        protected void btn_rap_exc_Click(object sender, EventArgs e)
        {
            string ad = "grup_kullanici_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_rapor_export.WriteXlsToResponse(ad);
        }

        protected void btn_rap_doc_Click(object sender, EventArgs e)
        {
            string ad = "grup_kullanici_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_rapor_export.WriteRtfToResponse(ad);
        }
    }
}