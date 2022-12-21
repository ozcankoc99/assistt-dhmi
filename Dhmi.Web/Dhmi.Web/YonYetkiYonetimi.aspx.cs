namespace Dhmi.Web
{
    using System;
    using System.Web.UI;
    using SD.LLBLGen.Pro.ORMSupportClasses;
    using dhmi.CollectionClasses;
    using dhmi.HelperClasses;
    using dhmi.EntityClasses;
    using System.Web;

    public partial class YonYetkiYonetimi : System.Web.UI.Page
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

            YetkiCollection CollYettt = new YetkiCollection();
            ISortExpression sort = new SortExpression();
            sort.Add(new SortClause(YetkiFields.YetkiAd, SortOperator.Ascending));
            CollYettt.GetMulti(null, 0, sort);

            grid_yetki.DataSource = CollYettt;
            grid_yetki.DataBind();

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            grid_yetki.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            if (IsPostBack != true)
            {
                Session["gncsi"] = "0";

                cb_icerik.Items.Add("Evet");
                cb_icerik.Items.Add("Hayır");

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
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Yetki Yönetimi");
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

                cb_yetki.Items.Clear();

                YetkiCollection CollYet = new YetkiCollection();
                ISortExpression sort2 = new SortExpression();
                sort2.Add(new SortClause(YetkiFields.YetkiAd, SortOperator.Ascending));
                CollYet.GetMulti(null, 0, sort2);

                for (int i = 0; i < CollYet.Count; i++)
                {
                    cb_yetki.Items.Add(CollYet[i].YetkiAd);
                }
            }
        }

        protected void cb_yetki_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_ana_menu.Enabled = true;
            cb_ana_menu.Items.Clear();

            MenuCollection CollMen = new MenuCollection();
            ISortExpression sort = new SortExpression();
            sort.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
            CollMen.GetMulti(null, 0, sort);

            for (int i = 0; i < CollMen.Count; i++)
            {
                if (CollMen[i].MenuAd == "BOS" || CollMen[i].MenuAd == "Bilgi Bankası" || CollMen[i].MenuAd == "Duyurular")
                {

                }

                else
                {
                    cb_ana_menu.Items.Add(CollMen[i].MenuAd);
                }
            }

            cb_ana_menu.Text = "Seçiniz...";

            cb_alt_menu.Enabled = false;
            cb_alt_menu.Text = "Seçiniz...";
            pnl_bit.Visible = false;
        }

        protected void cb_ana_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_alt_menu.Enabled = true;
            cb_alt_menu.Items.Clear();

            MenuCollection CollMen = new MenuCollection();
            IPredicateExpression ExpMen = new PredicateExpression();
            ExpMen.AddWithAnd(MenuFields.MenuAd == cb_ana_menu.Text);
            CollMen.GetMulti(ExpMen);

            AltMenuCollection CollAlt = new AltMenuCollection();
            IPredicateExpression ExpAlt = new PredicateExpression();
            ISortExpression sorts = new SortExpression();
            sorts.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
            ExpAlt.AddWithAnd(AltMenuFields.FkMenuId == CollMen[0].MenuId);
            CollAlt.GetMulti(ExpAlt, 0, sorts);

            for (int i = 0; i < CollAlt.Count; i++)
            {
                cb_alt_menu.Items.Add(CollAlt[i].AltMenuAd);
            }

            cb_alt_menu.Text = "Seçiniz...";
            pnl_bit.Visible = false;
        }

        protected void cb_alt_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_menu_list.Items.Clear();
            cb_islem_turu.Items.Clear();
            cb_son_islem.Items.Clear();
            btn_alt_kaydet.Visible = false;

            AltMenuCollection CollAlt = new AltMenuCollection();
            IPredicateExpression ExpAlt = new PredicateExpression();
            ExpAlt.AddWithAnd(AltMenuFields.AltMenuAd == cb_alt_menu.Text);
            CollAlt.GetMulti(ExpAlt);

            AltAltMenuCollection CollSon = new AltAltMenuCollection();
            IPredicateExpression ExpSon = new PredicateExpression();
            ExpSon.AddWithAnd(AltAltMenuFields.FkAltMenuId == CollAlt[0].AltMenuId);
            CollSon.GetMulti(ExpSon);

            for (int i = 0; i < CollSon.Count; i++)
            {
                cb_menu_list.Items.Add(CollSon[i].AltAltMenuAd);

                YetkiCollection CollYetki = new YetkiCollection();
                IPredicateExpression ExpYetki = new PredicateExpression();
                ExpYetki.AddWithAnd(YetkiFields.YetkiAd == cb_yetki.Text);
                CollYetki.GetMulti(ExpYetki);

                MenuCollection CollMenu = new MenuCollection();
                IPredicateExpression ExpMenu = new PredicateExpression();
                ExpMenu.AddWithAnd(MenuFields.MenuAd == cb_ana_menu.Text);
                CollMenu.GetMulti(ExpMenu);

                AltMenuCollection CollAlt2 = new AltMenuCollection();
                IPredicateExpression ExpAlt2 = new PredicateExpression();
                ExpAlt2.AddWithAnd(AltMenuFields.AltMenuAd == cb_alt_menu.Text);
                CollAlt2.GetMulti(ExpAlt2);

                AltAltMenuCollection CollAlt3 = new AltAltMenuCollection();
                IPredicateExpression ExpAlt3 = new PredicateExpression();
                ExpAlt3.AddWithAnd(AltAltMenuFields.AltAltMenuAd == CollSon[i].AltAltMenuAd);
                CollAlt3.GetMulti(ExpAlt3);

                MenuOlusturCollection CollBul = new MenuOlusturCollection();
                ISortExpression sortmenu = new SortExpression();
                IPredicateExpression ExpBul = new PredicateExpression();
                ExpBul.AddWithAnd(MenuOlusturFields.FkYetkiId == CollYetki[0].YetkiId);
                ExpBul.AddWithAnd(MenuOlusturFields.FkMenuId == CollMenu[0].MenuId);
                ExpBul.AddWithAnd(MenuOlusturFields.FkAltMenuId == CollAlt2[0].AltMenuId);
                ExpBul.AddWithAnd(MenuOlusturFields.FkAltAltMenuId == CollAlt3[0].AltAltMenuId);
                sortmenu.Add(new SortClause(MenuOlusturFields.MenuOlusturSayi, SortOperator.Ascending));
                CollBul.GetMulti(ExpBul, 0, sortmenu);

                if (CollBul.Count > 0)
                {
                    cb_menu_list.Items[i].Selected = true;
                    cb_islem_turu.Items.Add(CollSon[i].AltAltMenuAd);
                }
            }

            cb_islem_turu.Text = "Seçiniz...";
            pnl_bit.Visible = true;
        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            YetkiCollection CollYet = new YetkiCollection();
            IPredicateExpression ExpYet = new PredicateExpression();
            ExpYet.AddWithAnd(YetkiFields.YetkiAd == cb_yetki.Text);
            CollYet.GetMulti(ExpYet);

            MenuCollection CollMenu = new MenuCollection();
            IPredicateExpression ExpMenu = new PredicateExpression();
            ExpMenu.AddWithAnd(MenuFields.MenuAd == cb_ana_menu.Text);
            CollMenu.GetMulti(ExpMenu);

            AltMenuCollection CollAlt = new AltMenuCollection();
            IPredicateExpression ExpAlt = new PredicateExpression();
            ExpAlt.AddWithAnd(AltMenuFields.AltMenuAd == cb_alt_menu.Text);
            CollAlt.GetMulti(ExpAlt);

            int sayac = 0;

            for (int i = 0; i < cb_menu_list.Items.Count; i++)
            {
                if (cb_menu_list.Items[i].Selected == true)
                {
                    sayac = sayac + 1;
                }
            }

            if (sayac == 0)
            {
                for (int i = 0; i < cb_menu_list.Items.Count; i++)
                {
                    AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                    IPredicateExpression ExpAlt2 = new PredicateExpression();
                    ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == cb_menu_list.Items[i].Text);
                    CollAlt2.GetMulti(ExpAlt2);

                    MenuOlusturCollection CollOlustur = new MenuOlusturCollection();
                    IPredicateExpression ExpOlustur = new PredicateExpression();
                    ISortExpression sortmenu = new SortExpression();
                    ExpOlustur.AddWithAnd(MenuOlusturFields.FkYetkiId == CollYet[0].YetkiId);
                    ExpOlustur.AddWithAnd(MenuOlusturFields.FkMenuId == CollMenu[0].MenuId);
                    ExpOlustur.AddWithAnd(MenuOlusturFields.FkAltMenuId == CollAlt[0].AltMenuId);
                    ExpOlustur.AddWithAnd(MenuOlusturFields.FkAltAltMenuId == CollAlt2[0].AltAltMenuId);
                    sortmenu.Add(new SortClause(MenuOlusturFields.MenuOlusturSayi, SortOperator.Ascending));
                    CollOlustur.GetMulti(ExpOlustur, 0, sortmenu);

                    if (CollOlustur.Count > 0)
                    {
                        for (int j = 0; j < CollOlustur.Count; j++)
                        {
                            CollOlustur[j].Delete();
                            CollOlustur[j].Save();
                        }
                    }

                    AltMenuCollection CollSon = new AltMenuCollection();
                    IPredicateExpression ExpSon = new PredicateExpression();
                    ExpSon.AddWithAnd(AltMenuFields.AltMenuAd == "BOS");
                    CollSon.GetMulti(ExpSon);

                    AltAltMenuCollection CollSon2 = new AltAltMenuCollection();
                    IPredicateExpression ExpSon2 = new PredicateExpression();
                    ExpSon2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "BOS");
                    CollSon2.GetMulti(ExpSon2);

                    MenuOlusturCollection CollOlustur2 = new MenuOlusturCollection();
                    IPredicateExpression ExpOlustur2 = new PredicateExpression();
                    ISortExpression sortmenu2 = new SortExpression();
                    ExpOlustur2.AddWithAnd(MenuOlusturFields.FkYetkiId == CollYet[0].YetkiId);
                    ExpOlustur2.AddWithAnd(MenuOlusturFields.FkMenuId == CollMenu[0].MenuId);
                    ExpOlustur2.AddWithAnd(MenuOlusturFields.FkAltMenuId == CollSon[0].AltMenuId);
                    ExpOlustur2.AddWithAnd(MenuOlusturFields.FkAltAltMenuId == CollSon2[0].AltAltMenuId);
                    sortmenu2.Add(new SortClause(MenuOlusturFields.MenuOlusturSayi, SortOperator.Ascending));
                    CollOlustur2.GetMulti(ExpOlustur2, 0, sortmenu2);

                    if (CollOlustur2.Count > 0)
                    {
                        for (int k = 0; k < CollOlustur2.Count; k++)
                        {
                            CollOlustur2[k].Delete();
                            CollOlustur2[k].Save();
                        }
                    }

                    MenuOlusturCollection CollOlustur3 = new MenuOlusturCollection();
                    IPredicateExpression ExpOlustur3 = new PredicateExpression();
                    ISortExpression sortmenu3 = new SortExpression();
                    ExpOlustur3.AddWithAnd(MenuOlusturFields.FkYetkiId == CollYet[0].YetkiId);
                    ExpOlustur3.AddWithAnd(MenuOlusturFields.FkMenuId == CollMenu[0].MenuId);
                    ExpOlustur3.AddWithAnd(MenuOlusturFields.FkAltMenuId == CollAlt[0].AltMenuId);
                    ExpOlustur3.AddWithAnd(MenuOlusturFields.FkAltAltMenuId == CollSon2[0].AltAltMenuId);
                    sortmenu3.Add(new SortClause(MenuOlusturFields.MenuOlusturSayi, SortOperator.Ascending));
                    CollOlustur3.GetMulti(ExpOlustur3, 0, sortmenu3);

                    if (CollOlustur3.Count > 0)
                    {
                        for (int m = 0; m < CollOlustur3.Count; m++)
                        {
                            CollOlustur3[m].Delete();
                            CollOlustur3[m].Save();
                        }
                    }
                }
            }

            else
            {
                AltMenuCollection CollSon = new AltMenuCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(AltMenuFields.AltMenuAd == "BOS");
                CollSon.GetMulti(ExpSon);

                AltAltMenuCollection CollSon2 = new AltAltMenuCollection();
                IPredicateExpression ExpSon2 = new PredicateExpression();
                ExpSon2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "BOS");
                CollSon2.GetMulti(ExpSon2);

                MenuOlusturCollection CollOlustur2 = new MenuOlusturCollection();
                IPredicateExpression ExpOlustur2 = new PredicateExpression();
                ExpOlustur2.AddWithAnd(MenuOlusturFields.FkYetkiId == CollYet[0].YetkiId);
                ExpOlustur2.AddWithAnd(MenuOlusturFields.FkMenuId == CollMenu[0].MenuId);
                ExpOlustur2.AddWithAnd(MenuOlusturFields.FkAltMenuId == CollSon[0].AltMenuId);
                ExpOlustur2.AddWithAnd(MenuOlusturFields.FkAltAltMenuId == CollSon2[0].AltAltMenuId);
                CollOlustur2.GetMulti(ExpOlustur2);

                if (CollOlustur2.Count == 0)
                {
                    MenuOlusturEntity EntKay1 = new MenuOlusturEntity();
                    EntKay1.FkYetkiId = CollYet[0].YetkiId;
                    EntKay1.FkMenuId = CollMenu[0].MenuId;
                    EntKay1.FkAltMenuId = CollSon[0].AltMenuId;
                    EntKay1.FkAltAltMenuId = CollSon2[0].AltAltMenuId;
                    EntKay1.MenuOlusturSayi = CollMenu[0].MenuSira;
                    EntKay1.MenuOlusturTarih = DateTime.Now;
                    EntKay1.Save();
                }

                MenuOlusturCollection CollOlustur3 = new MenuOlusturCollection();
                IPredicateExpression ExpOlustur3 = new PredicateExpression();
                ExpOlustur3.AddWithAnd(MenuOlusturFields.FkYetkiId == CollYet[0].YetkiId);
                ExpOlustur3.AddWithAnd(MenuOlusturFields.FkMenuId == CollMenu[0].MenuId);
                ExpOlustur3.AddWithAnd(MenuOlusturFields.FkAltMenuId == CollAlt[0].AltMenuId);
                ExpOlustur3.AddWithAnd(MenuOlusturFields.FkAltAltMenuId == CollSon2[0].AltAltMenuId);
                CollOlustur3.GetMulti(ExpOlustur3);

                if (CollOlustur3.Count == 0)
                {
                    MenuOlusturEntity EntKay2 = new MenuOlusturEntity();
                    EntKay2.FkYetkiId = CollYet[0].YetkiId;
                    EntKay2.FkMenuId = CollMenu[0].MenuId;
                    EntKay2.FkAltMenuId = CollAlt[0].AltMenuId;
                    EntKay2.FkAltAltMenuId = CollSon2[0].AltAltMenuId;
                    EntKay2.MenuOlusturSayi = CollAlt[0].AltMenuSira;
                    EntKay2.MenuOlusturTarih = DateTime.Now;
                    EntKay2.Save();
                }

                for (int i = 0; i < cb_menu_list.Items.Count; i++)
                {
                    if (cb_menu_list.Items[i].Selected == true)
                    {
                        AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                        IPredicateExpression ExpAlt2 = new PredicateExpression();
                        ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == cb_menu_list.Items[i].Text);
                        CollAlt2.GetMulti(ExpAlt2);

                        MenuOlusturCollection CollOlustura = new MenuOlusturCollection();
                        IPredicateExpression ExpOlustura = new PredicateExpression();
                        ExpOlustura.AddWithAnd(MenuOlusturFields.FkYetkiId == CollYet[0].YetkiId);
                        ExpOlustura.AddWithAnd(MenuOlusturFields.FkMenuId == CollMenu[0].MenuId);
                        ExpOlustura.AddWithAnd(MenuOlusturFields.FkAltMenuId == CollAlt[0].AltMenuId);
                        ExpOlustura.AddWithAnd(MenuOlusturFields.FkAltAltMenuId == CollAlt2[0].AltAltMenuId);
                        CollOlustura.GetMulti(ExpOlustura);

                        if (CollOlustura.Count == 0)
                        {
                            MenuOlusturEntity EntKay = new MenuOlusturEntity();
                            EntKay.FkYetkiId = CollYet[0].YetkiId;
                            EntKay.FkMenuId = CollMenu[0].MenuId;
                            EntKay.FkAltMenuId = CollAlt[0].AltMenuId;
                            EntKay.FkAltAltMenuId = CollAlt2[0].AltAltMenuId;
                            EntKay.MenuOlusturSayi = CollAlt2[0].AltAltMenuSira;
                            EntKay.MenuOlusturTarih = DateTime.Now;
                            EntKay.Save();
                        }
                    }

                    else
                    {
                        AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                        IPredicateExpression ExpAlt2 = new PredicateExpression();
                        ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == cb_menu_list.Items[i].Text);
                        CollAlt2.GetMulti(ExpAlt2);

                        MenuOlusturCollection CollOlustura = new MenuOlusturCollection();
                        IPredicateExpression ExpOlustura = new PredicateExpression();
                        ExpOlustura.AddWithAnd(MenuOlusturFields.FkYetkiId == CollYet[0].YetkiId);
                        ExpOlustura.AddWithAnd(MenuOlusturFields.FkMenuId == CollMenu[0].MenuId);
                        ExpOlustura.AddWithAnd(MenuOlusturFields.FkAltMenuId == CollAlt[0].AltMenuId);
                        ExpOlustura.AddWithAnd(MenuOlusturFields.FkAltAltMenuId == CollAlt2[0].AltAltMenuId);
                        CollOlustura.GetMulti(ExpOlustura);

                        if (CollOlustura.Count > 0)
                        {
                            for (int h = 0; h < CollOlustura.Count; h++)
                            {
                                CollOlustura[h].Delete();
                                CollOlustura[h].Save();
                            }
                        }
                    }
                }
            }

            string CloseWindow;
            CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

            cb_islem_turu.Items.Clear();

            AltMenuCollection CollAltt = new AltMenuCollection();
            IPredicateExpression ExpAltt = new PredicateExpression();
            ExpAltt.AddWithAnd(AltMenuFields.AltMenuAd == cb_alt_menu.Text);
            CollAltt.GetMulti(ExpAltt);

            AltAltMenuCollection CollSonn = new AltAltMenuCollection();
            IPredicateExpression ExpSonn = new PredicateExpression();
            ExpSonn.AddWithAnd(AltAltMenuFields.FkAltMenuId == CollAltt[0].AltMenuId);
            CollSonn.GetMulti(ExpSonn);

            for (int i = 0; i < CollSonn.Count; i++)
            {
                YetkiCollection CollYetki = new YetkiCollection();
                IPredicateExpression ExpYetki = new PredicateExpression();
                ExpYetki.AddWithAnd(YetkiFields.YetkiAd == cb_yetki.Text);
                CollYetki.GetMulti(ExpYetki);

                MenuCollection CollMenuu = new MenuCollection();
                IPredicateExpression ExpMenuu = new PredicateExpression();
                ExpMenuu.AddWithAnd(MenuFields.MenuAd == cb_ana_menu.Text);
                CollMenuu.GetMulti(ExpMenuu);

                AltMenuCollection CollAlt2 = new AltMenuCollection();
                IPredicateExpression ExpAlt2 = new PredicateExpression();
                ExpAlt2.AddWithAnd(AltMenuFields.AltMenuAd == cb_alt_menu.Text);
                CollAlt2.GetMulti(ExpAlt2);

                AltAltMenuCollection CollAlt3 = new AltAltMenuCollection();
                IPredicateExpression ExpAlt3 = new PredicateExpression();
                ExpAlt3.AddWithAnd(AltAltMenuFields.AltAltMenuAd == CollSonn[i].AltAltMenuAd);
                CollAlt3.GetMulti(ExpAlt3);

                MenuOlusturCollection CollBul = new MenuOlusturCollection();
                IPredicateExpression ExpBul = new PredicateExpression();
                ExpBul.AddWithAnd(MenuOlusturFields.FkYetkiId == CollYetki[0].YetkiId);
                ExpBul.AddWithAnd(MenuOlusturFields.FkMenuId == CollMenuu[0].MenuId);
                ExpBul.AddWithAnd(MenuOlusturFields.FkAltMenuId == CollAlt2[0].AltMenuId);
                ExpBul.AddWithAnd(MenuOlusturFields.FkAltAltMenuId == CollAlt3[0].AltAltMenuId);
                CollBul.GetMulti(ExpBul);

                if (CollBul.Count > 0)
                {
                    cb_islem_turu.Items.Add(CollSonn[i].AltAltMenuAd);
                }
            }

            cb_islem_turu.Text = "Seçiniz...";
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            pnl_bit.Visible = false;
            cb_yetki.Text = "Seçiniz...";
            cb_ana_menu.Text = "Seçiniz...";
            cb_alt_menu.Text = "Seçiniz...";
            cb_ana_menu.Enabled = false;
            cb_alt_menu.Enabled = false;
            Session["gncsi"] = "0";
            cb_yetki.Focus();
        }

        protected void btn_kayit_Click(object sender, EventArgs e)
        {
            if (Session["gncsi"].ToString() == "0")
            {
                YetkiCollection CollYet = new YetkiCollection();
                IPredicateExpression ExpYet = new PredicateExpression();
                ExpYet.AddWithAnd(YetkiFields.YetkiAd == txt_yetki_adi.Text);
                CollYet.GetMulti(ExpYet);

                if (CollYet.Count > 0)
                {
                    string CloseWindow;
                    CloseWindow = "alert('Lütfen yetki adını(rol) kontrol ediniz...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else
                {
                    YetkiEntity EntKay = new YetkiEntity();
                    EntKay.YetkiAd = txt_yetki_adi.Text;
                    EntKay.YetkiDurum = true;
                    EntKay.YetkiTarih = DateTime.Now;
                    EntKay.YetkiAciklama = cb_icerik.Text;
                    EntKay.Save();

                    YetkiCollection CollYet2 = new YetkiCollection();
                    IPredicateExpression ExpYet2 = new PredicateExpression();
                    ExpYet2.AddWithAnd(YetkiFields.YetkiAd == txt_yetki_adi.Text);
                    CollYet2.GetMulti(ExpYet2);

                    MenuCollection CollMen1 = new MenuCollection();
                    IPredicateExpression ExpMen1 = new PredicateExpression();
                    ExpMen1.AddWithAnd(MenuFields.MenuAd == "Bilgi Bankası");
                    CollMen1.GetMulti(ExpMen1);

                    MenuCollection CollMen2 = new MenuCollection();
                    IPredicateExpression ExpMen2 = new PredicateExpression();
                    ExpMen2.AddWithAnd(MenuFields.MenuAd == "Duyurular");
                    CollMen2.GetMulti(ExpMen2);

                    MenuOlusturEntity EntMen = new MenuOlusturEntity();
                    EntMen.FkYetkiId = Convert.ToInt16(CollYet2[0].YetkiId);
                    EntMen.FkMenuId = CollMen1[0].MenuId;
                    EntMen.FkAltMenuId = 27;
                    EntMen.FkAltAltMenuId = 28;
                    EntMen.MenuOlusturSayi = 6;
                    EntMen.MenuOlusturTarih = DateTime.Now;
                    EntMen.Save();

                    MenuOlusturEntity EntMen2 = new MenuOlusturEntity();
                    EntMen2.FkYetkiId = Convert.ToInt16(CollYet2[0].YetkiId);
                    EntMen2.FkMenuId = CollMen2[0].MenuId;
                    EntMen2.FkAltMenuId = 27;
                    EntMen2.FkAltAltMenuId = 28;
                    EntMen2.MenuOlusturSayi = 7;
                    EntMen2.MenuOlusturTarih = DateTime.Now;
                    EntMen2.Save();

                    string CloseWindow;
                    CloseWindow = "alert('Kayıt işlemi tamamlanmıştır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                    txt_yetki_adi.Text = "";
                    cb_icerik.Text = "";
                    cb_icerik.NullText = "Seçiniz...";

                    YetkiCollection CollYettt = new YetkiCollection();
                    ISortExpression sort = new SortExpression();
                    sort.Add(new SortClause(YetkiFields.YetkiAd, SortOperator.Ascending));
                    CollYettt.GetMulti(null, 0, sort);

                    grid_yetki.DataSource = CollYettt;
                    grid_yetki.DataBind();

                    cb_yetki.Items.Clear();

                    for (int i = 0; i < CollYettt.Count; i++)
                    {
                        cb_yetki.Items.Add(CollYettt[i].YetkiAd);
                    }
                }
            }

            else 
            {
                YetkiCollection CollYet = new YetkiCollection();
                IPredicateExpression ExpYet = new PredicateExpression();
                ExpYet.AddWithAnd(YetkiFields.YetkiAd == txt_yetki_adi.Text);
                CollYet.GetMulti(ExpYet);

                if (CollYet.Count > 1)
                {
                    string CloseWindow;
                    CloseWindow = "alert('Lütfen yetki adını(rol) kontrol ediniz...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else
                {
                    CollYet[0].YetkiAd = txt_yetki_adi.Text;                    
                    CollYet[0].YetkiTarih = DateTime.Now;
                    CollYet[0].YetkiAciklama = cb_icerik.Text;
                    CollYet[0].Save();
                    
                    string CloseWindow;
                    CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                    txt_yetki_adi.Text = "";
                    cb_icerik.Text = "";
                    cb_icerik.NullText = "Seçiniz...";
                    Session["gncsi"] = "0";

                    YetkiCollection CollYettt = new YetkiCollection();
                    ISortExpression sort = new SortExpression();
                    sort.Add(new SortClause(YetkiFields.YetkiAd, SortOperator.Ascending));
                    CollYettt.GetMulti(null, 0, sort);

                    grid_yetki.DataSource = CollYettt;
                    grid_yetki.DataBind();

                    cb_yetki.Items.Clear();

                    for (int i = 0; i < CollYettt.Count; i++)
                    {
                        cb_yetki.Items.Add(CollYettt[i].YetkiAd);
                    }
                }
            }            
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            int del = 0;

            try
            {
                YetkiCollection CollYet = new YetkiCollection();
                IPredicateExpression ExpYet = new PredicateExpression();
                ExpYet.AddWithAnd(YetkiFields.YetkiId == Convert.ToInt32(txtUserName.Text));
                CollYet.GetMulti(ExpYet);

                MenuOlusturCollection CollMen = new MenuOlusturCollection();
                IPredicateExpression ExpMen = new PredicateExpression();
                ExpMen.AddWithAnd(MenuOlusturFields.FkYetkiId == CollYet[0].YetkiId);
                CollMen.GetMulti(ExpMen);

                if (CollMen.Count <= 2) 
                {
                    for (int f = 0; f < CollMen.Count; f++)
                    {
                        CollMen[f].Delete();
                        CollMen[f].Save();
                    }
                }                

                CollYet[0].Delete();
                CollYet[0].Save();

                del = 1;

                YetkiCollection CollYettt = new YetkiCollection();
                ISortExpression sort = new SortExpression();
                sort.Add(new SortClause(YetkiFields.YetkiAd, SortOperator.Ascending));
                CollYettt.GetMulti(null, 0, sort);

                grid_yetki.DataSource = CollYettt;
                grid_yetki.DataBind();

                btn_sil.Enabled = false;

                cb_yetki.Items.Clear();

                for (int i = 0; i < CollYettt.Count; i++)
                {
                    cb_yetki.Items.Add(CollYettt[i].YetkiAd);
                }

                string CloseWindow;
                CloseWindow = "alert('Silme işlemi tamamlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            catch
            {
                if (del == 0)
                {
                    string CloseWindow;
                    CloseWindow = "alert('Sistemde aktif olarak kullanılan bir yetkiyi silemezsiniz...')";
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

        protected void grid_yetki_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_yetki.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_yetki_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = grid_yetki.GetSelectedFieldValues("YetkiId")[0].ToString();

            YetkiCollection CollYet = new YetkiCollection();
            IPredicateExpression ExpYet = new PredicateExpression();
            ExpYet.AddWithAnd(YetkiFields.YetkiId == Convert.ToInt16(txtUserName.Text));
            CollYet.GetMulti(ExpYet);

            Session["gncsi"] = grid_yetki.GetSelectedFieldValues("YetkiId")[0].ToString();

            txt_yetki_adi.Text = CollYet[0].YetkiAd;
            cb_icerik.Text = CollYet[0].YetkiAciklama;

            btn_sil.Enabled = true;
        }

        protected void cb_islem_turu_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_alt_kaydet.Visible = true;

            cb_son_islem.Items.Clear();

            MenuCollection CollMenu = new MenuCollection();
            IPredicateExpression ExpMenu = new PredicateExpression();
            ExpMenu.AddWithAnd(MenuFields.MenuAd == cb_ana_menu.Text);
            CollMenu.GetMulti(ExpMenu);

            AltMenuCollection CollAlt2 = new AltMenuCollection();
            IPredicateExpression ExpAlt2 = new PredicateExpression();
            ExpAlt2.AddWithAnd(AltMenuFields.AltMenuAd == cb_alt_menu.Text);
            CollAlt2.GetMulti(ExpAlt2);

            AltAltMenuCollection CollAlt3 = new AltAltMenuCollection();
            IPredicateExpression ExpAlt3 = new PredicateExpression();
            ExpAlt3.AddWithAnd(AltAltMenuFields.AltAltMenuAd == cb_islem_turu.Text);
            CollAlt3.GetMulti(ExpAlt3);

            YetkiCollection CollYetki = new YetkiCollection();
            IPredicateExpression ExpYetki = new PredicateExpression();
            ExpYetki.AddWithAnd(YetkiFields.YetkiAd == cb_yetki.Text);
            CollYetki.GetMulti(ExpYetki);

            IslemCollection CollIs = new IslemCollection();
            IPredicateExpression ExpIs = new PredicateExpression();
            ExpIs.AddWithAnd(IslemFields.FkMenuId == CollMenu[0].MenuId);
            ExpIs.AddWithAnd(IslemFields.FkAltMenuId == CollAlt2[0].AltMenuId);
            ExpIs.AddWithAnd(IslemFields.FkAltAltMenuId == CollAlt3[0].AltAltMenuId);
            CollIs.GetMulti(ExpIs);

            for (int g = 0; g < CollIs.Count; g++)
            {
                cb_son_islem.Items.Add(CollIs[g].IslemAd);

                IslemOlusturCollection CollOl = new IslemOlusturCollection();
                IPredicateExpression ExpOl = new PredicateExpression();
                ExpOl.AddWithAnd(IslemOlusturFields.FkYetkiId == CollYetki[0].YetkiId);
                ExpOl.AddWithAnd(IslemOlusturFields.FkIslemId == CollIs[g].IslemId);
                CollOl.GetMulti(ExpOl);

                if (CollOl.Count > 0)
                {
                    cb_son_islem.Items[g].Selected = true;
                }

                else
                {
                    cb_son_islem.Items[g].Selected = false;
                }
            }
        }

        protected void btn_alt_kaydet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cb_son_islem.Items.Count; i++)
            {
                MenuCollection CollMenu = new MenuCollection();
                IPredicateExpression ExpMenu = new PredicateExpression();
                ExpMenu.AddWithAnd(MenuFields.MenuAd == cb_ana_menu.Text);
                CollMenu.GetMulti(ExpMenu);

                AltMenuCollection CollAlt2 = new AltMenuCollection();
                IPredicateExpression ExpAlt2 = new PredicateExpression();
                ExpAlt2.AddWithAnd(AltMenuFields.AltMenuAd == cb_alt_menu.Text);
                CollAlt2.GetMulti(ExpAlt2);

                AltAltMenuCollection CollAlt3 = new AltAltMenuCollection();
                IPredicateExpression ExpAlt3 = new PredicateExpression();
                ExpAlt3.AddWithAnd(AltAltMenuFields.AltAltMenuAd == cb_islem_turu.Text);
                CollAlt3.GetMulti(ExpAlt3);

                YetkiCollection CollYetki = new YetkiCollection();
                IPredicateExpression ExpYetki = new PredicateExpression();
                ExpYetki.AddWithAnd(YetkiFields.YetkiAd == cb_yetki.Text);
                CollYetki.GetMulti(ExpYetki);

                IslemCollection CollIs = new IslemCollection();
                IPredicateExpression ExpIs = new PredicateExpression();
                ExpIs.AddWithAnd(IslemFields.FkMenuId == CollMenu[0].MenuId);
                ExpIs.AddWithAnd(IslemFields.FkAltMenuId == CollAlt2[0].AltMenuId);
                ExpIs.AddWithAnd(IslemFields.FkAltAltMenuId == CollAlt3[0].AltAltMenuId);
                ExpIs.AddWithAnd(IslemFields.IslemAd == cb_son_islem.Items[i].Text);
                CollIs.GetMulti(ExpIs);

                IslemOlusturCollection CollOl = new IslemOlusturCollection();
                IPredicateExpression ExpOl = new PredicateExpression();
                ExpOl.AddWithAnd(IslemOlusturFields.FkYetkiId == CollYetki[0].YetkiId);
                ExpOl.AddWithAnd(IslemOlusturFields.FkIslemId == CollIs[0].IslemId);
                CollOl.GetMulti(ExpOl);

                if (CollOl.Count > 0)
                {
                    if (cb_son_islem.Items[i].Selected == false)
                    {
                        for (int h = 0; h < CollOl.Count; h++)
                        {
                            CollOl[h].Delete();
                            CollOl[h].Save();
                        }
                    }
                }

                else
                {
                    if (cb_son_islem.Items[i].Selected == true)
                    {
                        IslemOlusturEntity EntKay = new IslemOlusturEntity();
                        EntKay.FkIslemId = CollIs[0].IslemId;
                        EntKay.FkYetkiId = CollYetki[0].YetkiId;
                        EntKay.IslemOlusturTarih = DateTime.Now;
                        EntKay.Save();
                    }
                }
            }

            string CloseWindow;
            CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
        }
    }
}