namespace Dhmi.Web
{
    using System;
    using System.Web.UI;
    using SD.LLBLGen.Pro.ORMSupportClasses;
    using dhmi.CollectionClasses;
    using dhmi.HelperClasses;
    using dhmi.TypedListClasses;
    using dhmi.EntityClasses;
    using System.IO;
    using System.Linq;
    using System.Web;

    public partial class YonBilgiBankasiBilgileri : System.Web.UI.Page
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

            grid_bilgi_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "BİLGİ BANKASI BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_bilgi_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            grid_bilgi.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_bilgi_sil.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            ListBilgiTypedList eg_snot = new ListBilgiTypedList();
            ISortExpression sortss = new SortExpression();
            sortss.Add(new SortClause(BilgiBankasiTurFields.BilgiBankasiTurAd, SortOperator.Ascending));
            sortss.Add(new SortClause(BilgiBankasiFields.BilgiBankasiAd, SortOperator.Ascending));
            eg_snot.Fill(0, sortss, true);

            grid_bilgi.DataSource = eg_snot;
            grid_bilgi.DataBind();

            grid_bilgi_sil.DataSource = eg_snot;
            grid_bilgi_sil.DataBind();

            if (IsPostBack != true)
            {
                Session["foto_path"] = null;

                ControlHelper.SetBilgiBankasiTur(cb_bilgi, -1);

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
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Bilgi Bankası Bilgileri");
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

            cb_bilgi.Focus();
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            cb_bilgi.Text = "";
            cb_bilgi.NullText = "Seçiniz...";
            txt_baslik.Text = "";
            txt_icerik.Text = "";
            txt_etiket.Text = "";
            txt_sira.Text = "";

            btn_goster.Enabled = false;

            Session["foto_path"] = null;

            cb_bilgi.Focus();
        }

        protected void btnPdfExport_Click(object sender, EventArgs e)
        {
            string ad = "bilgi_bankasi_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_bilgi_export.WritePdfToResponse(ad);
        }

        protected void btnXlsExport_Click(object sender, EventArgs e)
        {
            string ad = "bilgi_bankasi_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_bilgi_export.WriteXlsToResponse(ad);
        }

        protected void btnRtfExport_Click(object sender, EventArgs e)
        {
            string ad = "bilgi_bankasi_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_bilgi_export.WriteRtfToResponse(ad);
        }

        protected void grid_bilgi_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_bilgi.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_bilgi_sil_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_bilgi_sil.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_bilgi_sil_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = grid_bilgi_sil.GetSelectedFieldValues("BilgiBankasiId")[0].ToString();

            btn_guncelle.Enabled = true;
            btn_sil.Enabled = true;
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                BilgiBankasiCollection CollYazz = new BilgiBankasiCollection();
                IPredicateExpression ExpYazz = new PredicateExpression();
                ExpYazz.AddWithAnd(BilgiBankasiFields.BilgiBankasiId == Convert.ToInt32(txtUserName.Text));
                CollYazz.GetMulti(ExpYazz);

                CollYazz[0].Delete();
                CollYazz[0].Save();

                ListBilgiTypedList eg_snot = new ListBilgiTypedList();
                ISortExpression sortss = new SortExpression();
                sortss.Add(new SortClause(BilgiBankasiTurFields.BilgiBankasiTurAd, SortOperator.Ascending));
                sortss.Add(new SortClause(BilgiBankasiFields.BilgiBankasiAd, SortOperator.Ascending));
                eg_snot.Fill(0, sortss, true);

                grid_bilgi.DataSource = eg_snot;
                grid_bilgi.DataBind();

                grid_bilgi_sil.DataSource = eg_snot;
                grid_bilgi_sil.DataBind();

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
            //BilgiBankasiTurCollection CollTur = new BilgiBankasiTurCollection();
            //IPredicateExpression ExpTur = new PredicateExpression();
            //ExpTur.AddWithAnd(BilgiBankasiTurFields.BilgiBankasiTurAd == cb_bilgi.Text);
            //CollTur.GetMulti(ExpTur);
            short bilgiBankasiTurId = 0;
            try
            {
                bilgiBankasiTurId = Convert.ToInt16(cb_bilgi.SelectedItem.Value);
            }
            catch (Exception)
            {
                string CloseWindow;
                CloseWindow = "alert('Bilgi Bankasi Türünü seçiniz....')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            if (txt_icerik.Text.Length > 4000)
            {
                string CloseWindow;
                CloseWindow = "alert('İçerik en fazla 4000 karakter içermelidir....')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else
            {
                if (Session["par_guncelle_mi"].ToString() == "0")
                {
                    BilgiBankasiCollection CollBul = new BilgiBankasiCollection();
                    IPredicateExpression ExpBul = new PredicateExpression();
                    ExpBul.AddWithAnd(BilgiBankasiFields.FkBilgiBankasiTurId == bilgiBankasiTurId);
                    ExpBul.AddWithAnd(BilgiBankasiFields.BilgiBankasiAd == txt_baslik.Text);
                    CollBul.GetMulti(ExpBul);

                    if (CollBul.Count > 0)
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Bilgi Bankası İşlemi sistemde kayıtlıdır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                    }

                    else
                    {
                        BilgiBankasiCollection CollBulSira = new BilgiBankasiCollection();
                        IPredicateExpression ExpBulSira = new PredicateExpression();
                        ExpBulSira.AddWithAnd(BilgiBankasiFields.FkBilgiBankasiTurId == bilgiBankasiTurId);
                        ExpBulSira.AddWithAnd(BilgiBankasiFields.BilgiBankasiSira == Convert.ToInt16(txt_sira.Text));
                        CollBulSira.GetMulti(ExpBulSira);

                        if (CollBulSira.Count > 0)
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Sistemde sıra numaralı başka bir bilgi bankası işlemi kayıtlıdır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                        }

                        else
                        {
                            BilgiBankasiEntity EntKay = new BilgiBankasiEntity();
                            EntKay.FkBilgiBankasiTurId = Convert.ToInt16(cb_bilgi.SelectedItem.Value);
                            EntKay.BilgiBankasiAd = txt_baslik.Text;
                            EntKay.BilgiBankasiIcerik = txt_icerik.Text;
                            EntKay.BilgiBankasiSira = Convert.ToInt16(txt_sira.Text);
                            EntKay.BilgiBankasiTarih = DateTime.Now;

                            if (txt_etiket.Text == "")
                            {
                                EntKay.BilgiBankasiEtiket = "-";
                            }

                            else
                            {
                                EntKay.BilgiBankasiEtiket = txt_etiket.Text;
                            }

                            if (Session["foto_path"] == null)
                            {
                                EntKay.BilgiBankasiDosya = "-";
                            }

                            else
                            {
                                EntKay.BilgiBankasiDosya = Session["foto_path"].ToString();
                            }

                            EntKay.Save();

                            string CloseWindow;
                            CloseWindow = "alert('Kayıt işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            ListBilgiTypedList eg_snot = new ListBilgiTypedList();
                            ISortExpression sortss = new SortExpression();
                            sortss.Add(new SortClause(BilgiBankasiTurFields.BilgiBankasiTurAd, SortOperator.Ascending));
                            sortss.Add(new SortClause(BilgiBankasiFields.BilgiBankasiAd, SortOperator.Ascending));
                            eg_snot.Fill(0, sortss, true);

                            grid_bilgi.DataSource = eg_snot;
                            grid_bilgi.DataBind();

                            grid_bilgi_sil.DataSource = eg_snot;
                            grid_bilgi_sil.DataBind();

                            cb_bilgi.Text = "";
                            cb_bilgi.NullText = "Seçiniz...";
                            txt_baslik.Text = "";
                            txt_icerik.Text = "";
                            txt_etiket.Text = "";
                            txt_sira.Text = "";

                            btn_goster.Enabled = false;

                            Session["foto_path"] = null;

                            cb_bilgi.Focus();
                        }
                    }
                }

                else
                {
                    BilgiBankasiCollection CollBul = new BilgiBankasiCollection();
                    IPredicateExpression ExpBul = new PredicateExpression();
                    ExpBul.AddWithAnd(BilgiBankasiFields.FkBilgiBankasiTurId == bilgiBankasiTurId);
                    ExpBul.AddWithAnd(BilgiBankasiFields.BilgiBankasiAd == txt_baslik.Text);
                    CollBul.GetMulti(ExpBul);

                    BilgiBankasiCollection CollEx = new BilgiBankasiCollection();
                    IPredicateExpression ExpEx = new PredicateExpression();
                    ExpEx.AddWithAnd(BilgiBankasiFields.BilgiBankasiId == Convert.ToInt16(txtUserName.Text));
                    CollEx.GetMulti(ExpEx);

                    if (CollBul.Count > 0)
                    {
                        if (CollBul[0].BilgiBankasiId == CollEx[0].BilgiBankasiId)
                        {
                            if (Convert.ToInt16(txt_sira.Text) == CollEx[0].BilgiBankasiSira)
                            {
                                CollEx[0].FkBilgiBankasiTurId = Convert.ToInt16(cb_bilgi.SelectedItem.Value);
                                CollEx[0].BilgiBankasiAd = txt_baslik.Text;
                                CollEx[0].BilgiBankasiIcerik = txt_icerik.Text;
                                CollEx[0].BilgiBankasiSira = Convert.ToInt16(txt_sira.Text);
                                CollEx[0].BilgiBankasiTarih = DateTime.Now;

                                if (txt_etiket.Text == "")
                                {
                                    CollEx[0].BilgiBankasiEtiket = "-";
                                }

                                else
                                {
                                    CollEx[0].BilgiBankasiEtiket = txt_etiket.Text;
                                }

                                if (Session["foto_path"] == null)
                                {
                                    CollEx[0].BilgiBankasiDosya = "-";
                                }

                                else
                                {
                                    CollEx[0].BilgiBankasiDosya = Session["foto_path"].ToString();
                                }

                                CollEx[0].Save();

                                string CloseWindow;
                                CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                Session["par_guncelle_mi"] = "0";

                                ListBilgiTypedList eg_snot = new ListBilgiTypedList();
                                ISortExpression sortss = new SortExpression();
                                sortss.Add(new SortClause(BilgiBankasiTurFields.BilgiBankasiTurAd, SortOperator.Ascending));
                                sortss.Add(new SortClause(BilgiBankasiFields.BilgiBankasiAd, SortOperator.Ascending));
                                eg_snot.Fill(0, sortss, true);

                                grid_bilgi.DataSource = eg_snot;
                                grid_bilgi.DataBind();

                                grid_bilgi_sil.DataSource = eg_snot;
                                grid_bilgi_sil.DataBind();

                                cb_bilgi.Text = "";
                                cb_bilgi.NullText = "Seçiniz...";
                                txt_baslik.Text = "";
                                txt_icerik.Text = "";
                                txt_etiket.Text = "";
                                txt_sira.Text = "";

                                btn_goster.Enabled = false;

                                Session["foto_path"] = null;

                                cb_bilgi.Focus();
                            }

                            else
                            {
                                BilgiBankasiCollection CollBulSira = new BilgiBankasiCollection();
                                IPredicateExpression ExpBulSira = new PredicateExpression();
                                ExpBulSira.AddWithAnd(BilgiBankasiFields.FkBilgiBankasiTurId == bilgiBankasiTurId);
                                ExpBulSira.AddWithAnd(BilgiBankasiFields.BilgiBankasiSira == Convert.ToInt16(txt_sira.Text));
                                ExpBulSira.AddWithAnd(BilgiBankasiFields.BilgiBankasiSira != CollEx[0].BilgiBankasiSira);
                                CollBulSira.GetMulti(ExpBulSira);

                                if (CollBulSira.Count > 0)
                                {
                                    string CloseWindow;
                                    CloseWindow = "alert('Sistemde sıra numaralı başka bir bilgi bankası işlemi kayıtlıdır...')";
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                                }

                                else
                                {
                                    CollEx[0].FkBilgiBankasiTurId = Convert.ToInt16(cb_bilgi.SelectedItem.Value);
                                    CollEx[0].BilgiBankasiAd = txt_baslik.Text;
                                    CollEx[0].BilgiBankasiIcerik = txt_icerik.Text;
                                    CollEx[0].BilgiBankasiSira = Convert.ToInt16(txt_sira.Text);
                                    CollEx[0].BilgiBankasiTarih = DateTime.Now;

                                    if (txt_etiket.Text == "")
                                    {
                                        CollEx[0].BilgiBankasiEtiket = "-";
                                    }

                                    else
                                    {
                                        CollEx[0].BilgiBankasiEtiket = txt_etiket.Text;
                                    }

                                    if (Session["foto_path"] == null)
                                    {
                                        CollEx[0].BilgiBankasiDosya = "-";
                                    }

                                    else
                                    {
                                        CollEx[0].BilgiBankasiDosya = Session["foto_path"].ToString();
                                    }

                                    CollEx[0].Save();

                                    string CloseWindow;
                                    CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                    Session["par_guncelle_mi"] = "0";

                                    ListBilgiTypedList eg_snot = new ListBilgiTypedList();
                                    ISortExpression sortss = new SortExpression();
                                    sortss.Add(new SortClause(BilgiBankasiTurFields.BilgiBankasiTurAd, SortOperator.Ascending));
                                    sortss.Add(new SortClause(BilgiBankasiFields.BilgiBankasiAd, SortOperator.Ascending));
                                    eg_snot.Fill(0, sortss, true);

                                    grid_bilgi.DataSource = eg_snot;
                                    grid_bilgi.DataBind();

                                    grid_bilgi_sil.DataSource = eg_snot;
                                    grid_bilgi_sil.DataBind();

                                    cb_bilgi.Text = "";
                                    cb_bilgi.NullText = "Seçiniz...";
                                    txt_baslik.Text = "";
                                    txt_icerik.Text = "";
                                    txt_etiket.Text = "";
                                    txt_sira.Text = "";

                                    btn_goster.Enabled = false;

                                    Session["foto_path"] = null;

                                    cb_bilgi.Focus();
                                }
                            }
                        }

                        else
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Bilgi Bankası İşlemi sistemde kayıtlıdır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                        }
                    }

                    else
                    {
                        BilgiBankasiCollection CollBulSira = new BilgiBankasiCollection();
                        IPredicateExpression ExpBulSira = new PredicateExpression();
                        ExpBulSira.AddWithAnd(BilgiBankasiFields.FkBilgiBankasiTurId == bilgiBankasiTurId);
                        ExpBulSira.AddWithAnd(BilgiBankasiFields.BilgiBankasiSira == Convert.ToInt16(txt_sira.Text));
                        CollBulSira.GetMulti(ExpBulSira);

                        if (CollBulSira.Count > 0)
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Sistemde sıra numaralı başka bir bilgi bankası işlemi kayıtlıdır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                        }

                        else
                        {
                            CollEx[0].FkBilgiBankasiTurId = Convert.ToInt16(cb_bilgi.SelectedItem.Value);
                            CollEx[0].BilgiBankasiAd = txt_baslik.Text;
                            CollEx[0].BilgiBankasiIcerik = txt_icerik.Text;
                            CollEx[0].BilgiBankasiSira = Convert.ToInt16(txt_sira.Text);
                            CollEx[0].BilgiBankasiTarih = DateTime.Now;

                            if (txt_etiket.Text == "")
                            {
                                CollEx[0].BilgiBankasiEtiket = "-";
                            }

                            else
                            {
                                CollEx[0].BilgiBankasiEtiket = txt_etiket.Text;
                            }

                            if (Session["foto_path"] == null)
                            {
                                CollEx[0].BilgiBankasiDosya = "-";
                            }

                            else
                            {
                                CollEx[0].BilgiBankasiDosya = Session["foto_path"].ToString();
                            }

                            CollEx[0].Save();

                            string CloseWindow;
                            CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            Session["par_guncelle_mi"] = "0";

                            ListBilgiTypedList eg_snot = new ListBilgiTypedList();
                            ISortExpression sortss = new SortExpression();
                            sortss.Add(new SortClause(BilgiBankasiTurFields.BilgiBankasiTurAd, SortOperator.Ascending));
                            sortss.Add(new SortClause(BilgiBankasiFields.BilgiBankasiAd, SortOperator.Ascending));
                            eg_snot.Fill(0, sortss, true);

                            grid_bilgi.DataSource = eg_snot;
                            grid_bilgi.DataBind();

                            grid_bilgi_sil.DataSource = eg_snot;
                            grid_bilgi_sil.DataBind();

                            cb_bilgi.Text = "";
                            cb_bilgi.NullText = "Seçiniz...";
                            txt_baslik.Text = "";
                            txt_icerik.Text = "";
                            txt_etiket.Text = "";
                            txt_sira.Text = "";

                            btn_goster.Enabled = false;

                            Session["foto_path"] = null;

                            cb_bilgi.Focus();
                        }
                    }
                }
            }
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            Session["par_guncelle_mi"] = "1";

            Int32 idsi = Convert.ToInt32(txtUserName.Text);

            carTabPage.ActiveTabIndex = 0;

            BilgiBankasiCollection CollBil = new BilgiBankasiCollection();
            IPredicateExpression ExpBil = new PredicateExpression();
            ExpBil.AddWithAnd(BilgiBankasiFields.BilgiBankasiId == Convert.ToInt32(txtUserName.Text));
            CollBil.GetMulti(ExpBil);

            BilgiBankasiTurCollection CollTur = new BilgiBankasiTurCollection();
            IPredicateExpression ExpTur = new PredicateExpression();
            ExpTur.AddWithAnd(BilgiBankasiTurFields.BilgiBankasiTurId == CollBil[0].FkBilgiBankasiTurId);
            CollTur.GetMulti(ExpTur);

            cb_bilgi.Text = CollTur[0].BilgiBankasiTurAd;
            txt_baslik.Text = CollBil[0].BilgiBankasiAd;
            txt_icerik.Text = CollBil[0].BilgiBankasiIcerik;
            txt_etiket.Text = CollBil[0].BilgiBankasiEtiket;
            txt_sira.Text = CollBil[0].BilgiBankasiSira.ToString();

            if (CollBil[0].BilgiBankasiDosya == "-")
            {
                btn_goster.Enabled = false;
            }

            else
            {
                btn_goster.Enabled = true;
                Session["foto_path"] = CollBil[0].BilgiBankasiDosya;
            }

            cb_bilgi.Focus();
        }

        protected void btn_yukle_Click(object sender, EventArgs e)
        {
            string fileType = System.IO.Path.GetExtension(upload_foto.FileName).ToLower();
            double filesize = Convert.ToDouble(upload_foto.PostedFile.ContentLength) / 1048576.0; // mb cinsinden
            bool isValid = IsValidImage(upload_foto.FileBytes);

            if (upload_foto.HasFile && (fileType == ".jpeg" || fileType == ".jpg" || fileType == ".png") && isValid && filesize <= 20)
            {
                Random rastgele = new Random();
                Int32 sayi = rastgele.Next(100000, 999999);

                upload_foto.SaveAs(Server.MapPath("Content/Information/" + "banks" + Session["kullanici_var_mi"].ToString() + sayi.ToString() + "_" + upload_foto.FileName + RandomString()));

                Session["foto_path"] = "banks" + Session["kullanici_var_mi"].ToString() + sayi.ToString() + "_" + upload_foto.FileName;

                btn_goster.Enabled = true;

                string CloseWindow;
                CloseWindow = "alert('Belge sisteme yüklenmiştir...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen geçerli bir dosya türü seçiniz ve dosya boyutunun 20 Mb ile sınırlı olduğunu unutmayınız..')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        public static bool IsValidImage(byte[] bytes)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    System.Drawing.Image.FromStream(ms);
                }

            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }

        private static Random randomString = new Random();

        public static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 15)
                .Select(s => s[randomString.Next(s.Length)]).ToArray());
        }

        protected void btn_goster_Click(object sender, EventArgs e)
        {
            string git = "~/Content/Information/" + Session["foto_path"].ToString();
            Response.Redirect(git, "_blank", "menubar=0,scrollbars=1,width=780,height=900,top=10");
        }

        protected void k_bilgi_tur_CheckedChanged(object sender, EventArgs e)
        {
            if (k_bilgi_tur.Checked == true)
            {
                grid_bilgi.Columns[1].Visible = true;
            }

            else
            {
                grid_bilgi.Columns[1].Visible = false;
            }
        }

        protected void k_baslik_CheckedChanged(object sender, EventArgs e)
        {
            if (k_baslik.Checked == true)
            {
                grid_bilgi.Columns[2].Visible = true;
            }

            else
            {
                grid_bilgi.Columns[2].Visible = false;
            }
        }

        protected void k_icerik_CheckedChanged(object sender, EventArgs e)
        {
            if (k_icerik.Checked == true)
            {
                grid_bilgi.Columns[3].Visible = true;
            }

            else
            {
                grid_bilgi.Columns[3].Visible = false;
            }
        }

        protected void k_dosya_CheckedChanged(object sender, EventArgs e)
        {
            if (k_dosya.Checked == true)
            {
                grid_bilgi.Columns[4].Visible = true;
            }

            else
            {
                grid_bilgi.Columns[4].Visible = false;
            }
        }

        protected void k_etiket_CheckedChanged(object sender, EventArgs e)
        {
            if (k_etiket.Checked == true)
            {
                grid_bilgi.Columns[5].Visible = true;
            }

            else
            {
                grid_bilgi.Columns[5].Visible = false;
            }
        }

        protected void k_sira_CheckedChanged(object sender, EventArgs e)
        {
            if (k_sira.Checked == true)
            {
                grid_bilgi.Columns[6].Visible = true;
            }

            else
            {
                grid_bilgi.Columns[6].Visible = false;
            }
        }

        protected void k_tarih_CheckedChanged(object sender, EventArgs e)
        {
            if (k_tarih.Checked == true)
            {
                grid_bilgi.Columns[7].Visible = true;
            }

            else
            {
                grid_bilgi.Columns[7].Visible = false;
            }
        }

        protected void cb_bilgi_SelectedIndexChanged(object sender, EventArgs e)
        {
            short value = Convert.ToInt16(cb_bilgi.SelectedItem.Value);
            if (value > 0)
            {
                txt_sira.Text = Helper.GetBilgiBankasiSiraNumarasi(value).ToString();
            }

            txt_baslik.Focus();
        }
    }
}