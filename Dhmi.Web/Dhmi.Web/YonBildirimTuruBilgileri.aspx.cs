namespace Dhmi.Web
{
    using System;
    using System.Web.UI;
    using SD.LLBLGen.Pro.ORMSupportClasses;
    using dhmi.CollectionClasses;
    using dhmi.HelperClasses;
    using dhmi.EntityClasses;
    using System.Web;

    public partial class YonBildirimTuruBilgileri : System.Web.UI.Page
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

            BildirimTuruCollection CollYettt = new BildirimTuruCollection();
            ISortExpression sort = new SortExpression();
            sort.Add(new SortClause(BildirimTuruFields.BildirimTuruAd, SortOperator.Ascending));
            CollYettt.GetMulti(null, 0, sort);

            grid_bildirim.DataSource = CollYettt;
            grid_bildirim.DataBind();

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            grid_bildirim.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            if (IsPostBack != true)
            {
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
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Bildirim Türü Bilgileri");
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

                cb_durum.Items.Clear();                
                cb_sms.Items.Clear();
                cb_mail.Items.Clear();
                cb_hat_adet.Items.Clear();
                cb_top_adet.Items.Clear();

                cb_durum.Items.Add("Aktif");
                cb_durum.Items.Add("Pasif");               
                cb_sms.Items.Add("Evet");
                cb_sms.Items.Add("Hayır");
                cb_mail.Items.Add("Evet");
                cb_mail.Items.Add("Hayır");

                ZamanCollection CollZam = new ZamanCollection();
                ISortExpression sortzam = new SortExpression();
                sortzam.Add(new SortClause(ZamanFields.ZamanSira, SortOperator.Ascending));
                CollZam.GetMulti(null, 0, sortzam);

                for (int i = 0; i < CollZam.Count; i++)
                {
                    cb_hat_adet.Items.Add(CollZam[i].ZamanAd);
                    cb_top_adet.Items.Add(CollZam[i].ZamanAd);
                }

                Session["guncel_ver"] = "0";
            }
        }

        protected void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                BildirimTuruCollection CollBil = new BildirimTuruCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd(BildirimTuruFields.BildirimTuruAd == txt_bildirim_adi.Text);
                CollBil.GetMulti(ExpBil);

                ZamanCollection CollZam1 = new ZamanCollection();
                IPredicateExpression ExpZam1 = new PredicateExpression();
                ExpZam1.AddWithAnd(ZamanFields.ZamanAd == cb_top_adet.Text);
                CollZam1.GetMulti(ExpZam1);

                Int64 zaman1 = CollZam1[0].ZamanSaat;
                zaman1 = zaman1 * Convert.ToInt64(txt_top_adet.Text);

                ZamanCollection CollZam2 = new ZamanCollection();
                IPredicateExpression ExpZam2 = new PredicateExpression();
                ExpZam2.AddWithAnd(ZamanFields.ZamanAd == cb_hat_adet.Text);
                CollZam2.GetMulti(ExpZam2);

                Int64 zaman2 = CollZam2[0].ZamanSaat;
                zaman2 = zaman2 * Convert.ToInt64(txt_hat_adet.Text);

                if (Session["guncel_ver"].ToString() == "0")
                {
                    if (CollBil.Count > 0)
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Bildirim adı sistemde kayıtlıdır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                    }

                    else
                    {
                        BildirimTuruEntity EntKay = new BildirimTuruEntity();
                        EntKay.BildirimTuruAd = txt_bildirim_adi.Text;

                        if (cb_durum.Text == "Aktif")
                        {
                            EntKay.BildirimTuruDurum = true;
                        }

                        else
                        {
                            EntKay.BildirimTuruDurum = false;
                        }

                        EntKay.BildirimTuruIslemAlSure = txt_top_adet.Text + " " + cb_top_adet.Text;
                        EntKay.BildirimTuruInclemeSure = txt_hat_adet.Text + " " + cb_hat_adet.Text;
                        EntKay.BildirimTuruIslemAlSaatZaman = zaman1;
                        EntKay.BildirimTuruIncelemeSaatZaman = zaman2;
                        EntKay.BildirimTuruTarih = DateTime.Now;
                        EntKay.BildirimTuruIcerik = true;

                        if (cb_sms.Text == "Evet")
                        {
                            EntKay.BildirimTuruSms = true;
                        }

                        else
                        {
                            EntKay.BildirimTuruSms = false;
                        }

                        if (cb_mail.Text == "Evet")
                        {
                            EntKay.BildirimTuruMail = true;
                        }

                        else
                        {
                            EntKay.BildirimTuruMail = false;
                        }

                        EntKay.Save();

                        string CloseWindow;
                        CloseWindow = "alert('Kayıt işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                        BildirimTuruCollection CollYettt = new BildirimTuruCollection();
                        ISortExpression sort = new SortExpression();
                        sort.Add(new SortClause(BildirimTuruFields.BildirimTuruAd, SortOperator.Ascending));
                        CollYettt.GetMulti(null, 0, sort);

                        grid_bildirim.DataSource = CollYettt;
                        grid_bildirim.DataBind();

                        txt_bildirim_adi.Text = "";
                        txt_hat_adet.Text = "";
                        txt_top_adet.Text = "";
                        cb_durum.Text = "";
                        cb_hat_adet.Text = "";
                        cb_top_adet.Text = "";
                        cb_sms.Text = "";
                        cb_mail.Text = "";                        
                        cb_durum.NullText = "Seçiniz...";
                        cb_hat_adet.NullText = "Seçiniz...";
                        cb_top_adet.NullText = "Seçiniz...";
                        cb_sms.NullText = "Seçiniz...";
                        cb_mail.NullText = "Seçiniz...";                        

                        txt_bildirim_adi.Focus();
                    }
                }

                else
                {
                    if (CollBil.Count > 1)
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Bildirim adı sistemde kayıtlıdır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                    }

                    else
                    {
                        BildirimTuruCollection CollBul = new BildirimTuruCollection();
                        IPredicateExpression ExpBul = new PredicateExpression();
                        ExpBul.AddWithAnd(BildirimTuruFields.BildirimTuruId == Convert.ToInt32(txtUserName.Text));
                        CollBul.GetMulti(ExpBul);

                        int son_bak = 0;

                        if (CollBil.Count > 0)
                        {
                            if (CollBil[0].BildirimTuruId == CollBul[0].BildirimTuruId)
                            {
                                son_bak = 0;
                            }

                            else
                            {
                                if (CollBil.Count > 0)
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
                            CollBul[0].BildirimTuruAd = txt_bildirim_adi.Text;

                            if (cb_durum.Text == "Aktif")
                            {
                                CollBul[0].BildirimTuruDurum = true;
                            }

                            else
                            {
                                CollBul[0].BildirimTuruDurum = false;
                            }

                            CollBul[0].BildirimTuruIslemAlSure = txt_top_adet.Text + " " + cb_top_adet.Text;
                            CollBul[0].BildirimTuruInclemeSure = txt_hat_adet.Text + " " + cb_hat_adet.Text;
                            CollBul[0].BildirimTuruIslemAlSaatZaman = zaman1;
                            CollBul[0].BildirimTuruIncelemeSaatZaman = zaman2;
                            CollBul[0].BildirimTuruTarih = DateTime.Now;

                            if (cb_sms.Text == "Evet")
                            {
                                CollBul[0].BildirimTuruSms = true;
                            }

                            else
                            {
                                CollBul[0].BildirimTuruSms = false;
                            }

                            if (cb_mail.Text == "Evet")
                            {
                                CollBul[0].BildirimTuruMail = true;
                            }

                            else
                            {
                                CollBul[0].BildirimTuruMail = false;
                            }

                            CollBul[0].Save();

                            string CloseWindow;
                            CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            Session["guncel_ver"] = "0";

                            BildirimTuruCollection CollYettt = new BildirimTuruCollection();
                            ISortExpression sort = new SortExpression();
                            sort.Add(new SortClause(BildirimTuruFields.BildirimTuruAd, SortOperator.Ascending));
                            CollYettt.GetMulti(null, 0, sort);

                            grid_bildirim.DataSource = CollYettt;
                            grid_bildirim.DataBind();

                            txt_bildirim_adi.Text = "";
                            txt_hat_adet.Text = "";
                            txt_top_adet.Text = "";
                            cb_durum.Text = "";
                            cb_hat_adet.Text = "";
                            cb_top_adet.Text = "";
                            cb_sms.Text = "";
                            cb_mail.Text = "";                            
                            cb_durum.NullText = "Seçiniz...";
                            cb_hat_adet.NullText = "Seçiniz...";
                            cb_top_adet.NullText = "Seçiniz...";
                            cb_sms.NullText = "Seçiniz...";
                            cb_mail.NullText = "Seçiniz...";                            

                            txt_bildirim_adi.Focus();
                        }

                        else
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Bildirim adı sistemde kayıtlıdır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                        }
                    }
                }
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen zaman bilgilerini kontrol ediniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            int sildi = 0;

            try
            {                
                BildirimTuruCollection CollYazz = new BildirimTuruCollection();
                IPredicateExpression ExpYazz = new PredicateExpression();
                ExpYazz.AddWithAnd(BildirimTuruFields.BildirimTuruId == Convert.ToInt32(txtUserName.Text));
                CollYazz.GetMulti(ExpYazz);

                CollYazz[0].Delete();
                CollYazz[0].Save();

                sildi = 1;

                BildirimTuruCollection CollYettt = new BildirimTuruCollection();
                ISortExpression sort = new SortExpression();
                sort.Add(new SortClause(BildirimTuruFields.BildirimTuruAd, SortOperator.Ascending));
                CollYettt.GetMulti(null, 0, sort);

                grid_bildirim.DataSource = CollYettt;
                grid_bildirim.DataBind();

                txt_bildirim_adi.Text = "";
                txt_hat_adet.Text = "";
                txt_top_adet.Text = "";
                cb_durum.Text = "";
                cb_hat_adet.Text = "";
                cb_top_adet.Text = "";
                cb_sms.Text = "";
                cb_mail.Text = "";                
                cb_durum.NullText = "Seçiniz...";
                cb_hat_adet.NullText = "Seçiniz...";
                cb_top_adet.NullText = "Seçiniz...";
                cb_sms.NullText = "Seçiniz...";
                cb_mail.NullText = "Seçiniz...";                

                txt_bildirim_adi.Focus();

                string CloseWindow;
                CloseWindow = "alert('Silme işlemi tamamlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            catch
            {
                if (sildi == 0)
                {
                    string CloseWindow;
                    CloseWindow = "alert('Sistemde aktif olarak kullanılan bildirim türünü silemezsiniz..')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else 
                {
                    string CloseWindow;
                    CloseWindow = "alert('Silme işlemi tamamlanmıştır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }                
            }
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {            
            Session["guncel_ver"] = "1";

            Int32 idsi = Convert.ToInt32(txtUserName.Text);

            carTabPage.ActiveTabIndex = 0;

            BildirimTuruCollection CollYazz = new BildirimTuruCollection();
            IPredicateExpression ExpYazz = new PredicateExpression();
            ExpYazz.AddWithAnd(BildirimTuruFields.BildirimTuruId == Convert.ToInt32(txtUserName.Text));
            CollYazz.GetMulti(ExpYazz);

            string top_zaman = CollYazz[0].BildirimTuruIslemAlSure;
            int yah = 0;

            for (int i = 0; i < top_zaman.Length; i++)
            {
                if (top_zaman[i].ToString() == " ")
                {
                    yah = i;
                }
            }

            string hat_zaman = CollYazz[0].BildirimTuruInclemeSure;
            int tah = 0;

            for (int j = 0; j < hat_zaman.Length; j++)
            {
                if (hat_zaman[j].ToString() == " ")
                {
                    tah = j;
                }
            }

            txt_bildirim_adi.Text = CollYazz[0].BildirimTuruAd;
            txt_top_adet.Text = top_zaman.Substring(0, yah);
            txt_hat_adet.Text = hat_zaman.Substring(0, tah);
            cb_top_adet.Text = top_zaman.Substring(yah + 1, top_zaman.Length - 1 - yah);
            cb_hat_adet.Text = hat_zaman.Substring(tah + 1, hat_zaman.Length - 1 - tah);

            if (CollYazz[0].BildirimTuruDurum == true)
            {
                cb_durum.Text = "Aktif";
            }

            else
            {
                cb_durum.Text = "Pasif";
            }

            if (CollYazz[0].BildirimTuruSms == true)
            {
                cb_sms.Text = "Evet";
            }

            else
            {
                cb_sms.Text = "Hayır";
            }

            if (CollYazz[0].BildirimTuruMail == true)
            {
                cb_mail.Text = "Evet";
            }

            else
            {
                cb_mail.Text = "Hayır";
            }

            txt_bildirim_adi.Focus();
        }

        protected void grid_bildirim_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_bildirim.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_bildirim_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = grid_bildirim.GetSelectedFieldValues("BildirimTuruId")[0].ToString();

            btn_sil.Enabled = true;
            btn_guncelle.Enabled = true;
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_bildirim_adi.Text = "";
            txt_hat_adet.Text = "";
            txt_top_adet.Text = "";
            cb_durum.Text = "";
            cb_hat_adet.Text = "";
            cb_top_adet.Text = "";
            cb_sms.Text = "";
            cb_mail.Text = "";            
            cb_durum.NullText = "Seçiniz...";
            cb_hat_adet.NullText = "Seçiniz...";
            cb_top_adet.NullText = "Seçiniz...";
            cb_sms.NullText = "Seçiniz...";
            cb_mail.NullText = "Seçiniz...";            

            Session["guncel_ver"] = "0";
        }
    }
}