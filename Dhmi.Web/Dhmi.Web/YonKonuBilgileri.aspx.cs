namespace Dhmi.Web
{
    using System;
    using System.Web.UI;
    using SD.LLBLGen.Pro.ORMSupportClasses;
    using dhmi.CollectionClasses;
    using dhmi.TypedListClasses;
    using dhmi.HelperClasses;
    using dhmi.EntityClasses;
    using System.Web;

    public partial class YonKonuBilgileri : System.Web.UI.Page
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

            KonuCollection CollKonu = new KonuCollection();
            ISortExpression sortkonu = new SortExpression();
            sortkonu.Add(new SortClause(KonuFields.KonuAd, SortOperator.Ascending));
            CollKonu.GetMulti(null, 0, sortkonu);

            grid_konu.DataSource = CollKonu;
            grid_konu.DataBind();

            ListKonuTypedList list_konu = new ListKonuTypedList();
            ISortExpression sortli = new SortExpression();
            sortli.Add(new SortClause(AltKonuFields.AltKonuAd, SortOperator.Ascending));
            list_konu.Fill(0, sortli, true);

            grid_alt_konu.DataSource = list_konu;
            grid_alt_konu.DataBind();

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            grid_konu.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_alt_konu.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            if (IsPostBack != true)
            {
                cb_menu.Items.Clear();

                cb_durum.Items.Clear();
                cb_durum.Items.Add("Aktif");
                cb_durum.Items.Add("Pasif");

                cb_durum2.Items.Clear();
                cb_durum2.Items.Add("Aktif");
                cb_durum2.Items.Add("Pasif");

                KonuCollection CollKonuk = new KonuCollection();
                IPredicateExpression ExpKonuk = new PredicateExpression();
                ISortExpression sortkonuk = new SortExpression();
                ExpKonuk.AddWithAnd(KonuFields.KonuDurum == true);
                sortkonuk.Add(new SortClause(KonuFields.KonuAd, SortOperator.Ascending));
                CollKonuk.GetMulti(ExpKonuk, 0, sortkonuk);

                for (int i = 0; i < CollKonuk.Count; i++)
                {
                    cb_menu.Items.Add(CollKonuk[i].KonuAd);
                }

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
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Konu Bilgileri");
                CollAlt2.GetMulti(ExpAlt2);

                KullaniciCollection CollKul2 = new KullaniciCollection();
                IPredicateExpression ExpKul2 = new PredicateExpression();
                ExpKul2.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollKul2.GetMulti(ExpKul2);

                YetkiCollection CollYet11 = new YetkiCollection();
                IPredicateExpression ExpYet11 = new PredicateExpression();
                ExpYet11.AddWithAnd(YetkiFields.YetkiId == CollKul2[0].FkYetkiId);
                CollYet11.GetMulti(ExpYet11);

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
                    ExpOl.AddWithAnd(IslemOlusturFields.FkYetkiId == CollYet11[0].YetkiId);
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

                Session["guncel_ver_konu"] = "0";
                Session["guncel_ver_alt_konu"] = "0";
            }
        }

        protected void btn_kayit2_Click(object sender, EventArgs e)
        {
            KonuCollection CollKonuAra = new KonuCollection();
            IPredicateExpression ExpKonuAra = new PredicateExpression();
            ExpKonuAra.AddWithAnd(KonuFields.KonuAd == cb_menu.Text);
            CollKonuAra.GetMulti(ExpKonuAra);

            AltKonuCollection CollAlt = new AltKonuCollection();
            IPredicateExpression ExpAlt = new PredicateExpression();
            ExpAlt.AddWithAnd(AltKonuFields.AltKonuAd == cb_menu.Text + " - " + txt_alt_konu.Text);
            ExpAlt.AddWithAnd(AltKonuFields.FkKonuId == CollKonuAra[0].KonuId);
            CollAlt.GetMulti(ExpAlt);

            if (Session["guncel_ver_alt_konu"].ToString() == "0")
            {
                if (CollAlt.Count > 0)
                {
                    string CloseWindow;
                    CloseWindow = "alert('Alt Konu sistemde kayıtlıdır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else
                {
                    AltKonuEntity EntKay = new AltKonuEntity();
                    EntKay.FkKonuId = CollKonuAra[0].KonuId;
                    EntKay.AltKonuAd = CollKonuAra[0].KonuAd + " - " + txt_alt_konu.Text;

                    if (cb_durum2.Text == "Aktif")
                    {
                        EntKay.AltKonuDurum = true;
                    }

                    else
                    {
                        EntKay.AltKonuDurum = false;
                    }

                    EntKay.AltKonuTarih = DateTime.Now;
                    EntKay.Save();

                    string CloseWindow;
                    CloseWindow = "alert('Kayıt işlemi tamamlanmıştır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                    ListKonuTypedList list_konu = new ListKonuTypedList();
                    ISortExpression sortli = new SortExpression();
                    sortli.Add(new SortClause(AltKonuFields.AltKonuAd, SortOperator.Ascending));
                    list_konu.Fill(0, sortli, true);

                    grid_alt_konu.DataSource = list_konu;
                    grid_alt_konu.DataBind();

                    txt_alt_konu.Text = "";
                    cb_menu.Text = "";
                    cb_menu.NullText = "Seçiniz...";
                    cb_durum2.Text = "";
                    cb_durum2.NullText = "Seçiniz...";

                    cb_menu.Focus();
                }
            }

            else
            {
                if (CollAlt.Count > 1)
                {
                    string CloseWindow;
                    CloseWindow = "alert('Alt Konu sistemde kayıtlıdır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else
                {
                    AltKonuCollection CollKonuEx = new AltKonuCollection();
                    IPredicateExpression ExpKonuEx = new PredicateExpression();
                    ExpKonuEx.AddWithAnd(AltKonuFields.AltKonuId == Convert.ToInt16(txtUserName2.Text));
                    CollKonuEx.GetMulti(ExpKonuEx);

                    int son_bak = 0;

                    if (CollAlt.Count > 0)
                    {
                        if (CollAlt[0].AltKonuId == CollKonuEx[0].AltKonuId)
                        {
                            son_bak = 0;
                        }

                        else
                        {
                            if (CollAlt.Count > 0)
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
                        CollKonuEx[0].FkKonuId = CollKonuAra[0].KonuId;
                        CollKonuEx[0].AltKonuAd = CollKonuAra[0].KonuAd + " - " + txt_alt_konu.Text;

                        if (cb_durum2.Text == "Aktif")
                        {
                            CollKonuEx[0].AltKonuDurum = true;
                        }

                        else
                        {
                            CollKonuEx[0].AltKonuDurum = false;
                        }

                        CollKonuEx[0].AltKonuTarih = DateTime.Now;
                        CollKonuEx[0].Save();

                        string CloseWindow;
                        CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        ListKonuTypedList list_konu = new ListKonuTypedList();
                        ISortExpression sortli = new SortExpression();
                        sortli.Add(new SortClause(AltKonuFields.AltKonuAd, SortOperator.Ascending));
                        list_konu.Fill(0, sortli, true);

                        Session["guncel_ver_alt_konu"] = "0";

                        grid_alt_konu.DataSource = list_konu;
                        grid_alt_konu.DataBind();

                        txt_alt_konu.Text = "";
                        cb_menu.Text = "";
                        cb_menu.NullText = "Seçiniz...";
                        cb_durum2.Text = "";
                        cb_durum2.NullText = "Seçiniz...";

                        cb_menu.Focus();
                    }

                    else
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Alt Konu sistemde kayıtlıdır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                    }
                }
            }
        }

        protected void btn_kayit_Click(object sender, EventArgs e)
        {
            KonuCollection CollKonuAra = new KonuCollection();
            IPredicateExpression ExpKonuAra = new PredicateExpression();
            ExpKonuAra.AddWithAnd(KonuFields.KonuAd == txt_konu.Text);
            CollKonuAra.GetMulti(ExpKonuAra);

            if (Session["guncel_ver_konu"].ToString() == "0")
            {
                if (CollKonuAra.Count > 0)
                {
                    string CloseWindow;
                    CloseWindow = "alert('Konu sistemde kayıtlıdır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else
                {
                    KonuEntity EntKay = new KonuEntity();
                    EntKay.KonuAd = txt_konu.Text;

                    if (cb_durum.Text == "Aktif")
                    {
                        EntKay.KonuDurum = true;
                    }

                    else
                    {
                        EntKay.KonuDurum = false;
                    }

                    EntKay.KonuTarih = DateTime.Now;
                    EntKay.Save();

                    string CloseWindow;
                    CloseWindow = "alert('Kayıt işlemi tamamlanmıştır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                    KonuCollection CollKonu = new KonuCollection();
                    ISortExpression sortkonu = new SortExpression();
                    sortkonu.Add(new SortClause(KonuFields.KonuAd, SortOperator.Ascending));
                    CollKonu.GetMulti(null, 0, sortkonu);

                    grid_konu.DataSource = CollKonu;
                    grid_konu.DataBind();

                    txt_konu.Text = "";
                    cb_durum.Text = "";
                    cb_durum.NullText = "Seçiniz...";

                    txt_konu.Focus();
                }
            }

            else
            {
                if (CollKonuAra.Count > 1)
                {
                    string CloseWindow;
                    CloseWindow = "alert('Konu sistemde kayıtlıdır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else
                {
                    KonuCollection CollKonuEx = new KonuCollection();
                    IPredicateExpression ExpKonuEx = new PredicateExpression();
                    ExpKonuEx.AddWithAnd(KonuFields.KonuId == Convert.ToInt16(txtUserName.Text));
                    CollKonuEx.GetMulti(ExpKonuEx);

                    int son_bak = 0;

                    if (CollKonuAra.Count > 0)
                    {
                        if (CollKonuAra[0].KonuId == CollKonuEx[0].KonuId)
                        {
                            son_bak = 0;
                        }

                        else
                        {
                            if (CollKonuAra.Count > 0)
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
                        CollKonuEx[0].KonuAd = txt_konu.Text;

                        if (cb_durum.Text == "Aktif")
                        {
                            CollKonuEx[0].KonuDurum = true;
                        }

                        else
                        {
                            CollKonuEx[0].KonuDurum = false;
                        }

                        CollKonuEx[0].KonuTarih = DateTime.Now;
                        CollKonuEx[0].Save();

                        Session["guncel_ver_konu"] = "0";

                        string CloseWindow;
                        CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        KonuCollection CollKonu = new KonuCollection();
                        ISortExpression sortkonu = new SortExpression();
                        sortkonu.Add(new SortClause(KonuFields.KonuAd, SortOperator.Ascending));
                        CollKonu.GetMulti(null, 0, sortkonu);

                        grid_konu.DataSource = CollKonu;
                        grid_konu.DataBind();

                        txt_konu.Text = "";
                        cb_durum.Text = "";
                        cb_durum.NullText = "Seçiniz...";

                        txt_konu.Focus();
                    }

                    else
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Konu sistemde kayıtlıdır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                    }
                }
            }
        }


        protected void btn_sil2_Click(object sender, EventArgs e)
        {
            try
            {
                AltKonuCollection CollKonuEx = new AltKonuCollection();
                IPredicateExpression ExpKonuEx = new PredicateExpression();
                ExpKonuEx.AddWithAnd(AltKonuFields.AltKonuId == Convert.ToInt16(txtUserName2.Text));
                CollKonuEx.GetMulti(ExpKonuEx);

                CollKonuEx[0].Delete();
                CollKonuEx[0].Save();

                ListKonuTypedList list_konu = new ListKonuTypedList();
                ISortExpression sortli = new SortExpression();
                sortli.Add(new SortClause(AltKonuFields.AltKonuAd, SortOperator.Ascending));
                list_konu.Fill(0, sortli, true);

                Session["guncel_ver_alt_konu"] = "0";

                grid_alt_konu.DataSource = list_konu;
                grid_alt_konu.DataBind();

                txt_alt_konu.Text = "";
                cb_menu.Text = "";
                cb_menu.NullText = "Seçiniz...";
                cb_durum2.Text = "";
                cb_durum2.NullText = "Seçiniz...";

                cb_menu.Focus();

                string CloseWindow;
                CloseWindow = "alert('Silme işlemi tamamlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Sistemde aktif olarak kullanılan alt konuyu silemezsiniz..')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                KonuCollection CollKonuEx = new KonuCollection();
                IPredicateExpression ExpKonuEx = new PredicateExpression();
                ExpKonuEx.AddWithAnd(KonuFields.KonuId == Convert.ToInt16(txtUserName.Text));
                CollKonuEx.GetMulti(ExpKonuEx);

                CollKonuEx[0].Delete();
                CollKonuEx[0].Save();

                KonuCollection CollKonu = new KonuCollection();
                ISortExpression sortkonu = new SortExpression();
                sortkonu.Add(new SortClause(KonuFields.KonuAd, SortOperator.Ascending));
                CollKonu.GetMulti(null, 0, sortkonu);

                grid_konu.DataSource = CollKonu;
                grid_konu.DataBind();

                txt_konu.Text = "";
                cb_durum.Text = "";
                cb_durum.NullText = "Seçiniz...";

                txt_konu.Focus();

                string CloseWindow;
                CloseWindow = "alert('Silme işlemi tamamlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Sistemde aktif olarak kullanılan konuyu silemezsiniz..')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void btn_guncelle2_Click(object sender, EventArgs e)
        {
            Session["guncel_ver_alt_konu"] = "1";

            Int32 idsi = Convert.ToInt32(txtUserName2.Text);

            AltKonuCollection CollKonuEx = new AltKonuCollection();
            IPredicateExpression ExpKonuEx = new PredicateExpression();
            ExpKonuEx.AddWithAnd(AltKonuFields.AltKonuId == Convert.ToInt16(txtUserName2.Text));
            CollKonuEx.GetMulti(ExpKonuEx);

            int sirasi = 0;

            for (int i = 0; i < CollKonuEx[0].AltKonuAd.Length; i++)
            {
                if (CollKonuEx[0].AltKonuAd[i].ToString() == "-")
                {
                    sirasi = i;
                }
            }

            txt_alt_konu.Text = CollKonuEx[0].AltKonuAd.Substring(sirasi + 2, CollKonuEx[0].AltKonuAd.Length - sirasi - 2);

            KonuCollection CollBul = new KonuCollection();
            IPredicateExpression ExpBul = new PredicateExpression();
            ExpBul.AddWithAnd(KonuFields.KonuId == CollKonuEx[0].FkKonuId);
            CollBul.GetMulti(ExpBul);

            cb_menu.Text = CollBul[0].KonuAd;

            if (CollKonuEx[0].AltKonuDurum == true)
            {
                cb_durum2.Text = "Aktif";
            }

            else
            {
                cb_durum2.Text = "Pasif";
            }

            cb_menu.Focus();
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            Session["guncel_ver_konu"] = "1";

            Int32 idsi = Convert.ToInt32(txtUserName.Text);

            KonuCollection CollKonuEx = new KonuCollection();
            IPredicateExpression ExpKonuEx = new PredicateExpression();
            ExpKonuEx.AddWithAnd(KonuFields.KonuId == Convert.ToInt16(txtUserName.Text));
            CollKonuEx.GetMulti(ExpKonuEx);

            txt_konu.Text = CollKonuEx[0].KonuAd;

            if (CollKonuEx[0].KonuDurum == true)
            {
                cb_durum.Text = "Aktif";
            }

            else
            {
                cb_durum.Text = "Pasif";
            }

            txt_konu.Focus();
        }

        protected void grid_konu_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_konu.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_alt_konu_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_alt_konu.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_konu_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = grid_konu.GetSelectedFieldValues("KonuId")[0].ToString();

            btn_sil.Enabled = true;
            btn_guncelle.Enabled = true;
        }

        protected void grid_alt_konu_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName2.Text = grid_alt_konu.GetSelectedFieldValues("AltKonuId")[0].ToString();

            btn_sil2.Enabled = true;
            btn_guncelle2.Enabled = true;
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_konu.Text = "";
            cb_durum.Text = "";
            cb_durum.NullText = "Seçiniz...";

            txt_konu.Focus();
        }

        protected void btn_temizle2_Click(object sender, EventArgs e)
        {
            txt_alt_konu.Text = "";
            cb_menu.Text = "";
            cb_menu.NullText = "Seçiniz...";
            cb_durum2.Text = "";
            cb_durum2.NullText = "Seçiniz...";

            cb_menu.Focus();
        }
    }
}