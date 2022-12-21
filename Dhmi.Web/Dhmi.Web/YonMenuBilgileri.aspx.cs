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

    public partial class YonMenuBilgileri : System.Web.UI.Page
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

            MenuCollection CollMenus = new MenuCollection();
            IPredicateExpression ExpMenus = new PredicateExpression();
            ISortExpression sortmenus = new SortExpression();
            ExpMenus.AddWithAnd(MenuFields.MenuAd != "BOS");
            sortmenus.Add(new SortClause(MenuFields.MenuSira, SortOperator.Ascending));
            CollMenus.GetMulti(ExpMenus, 0, sortmenus);

            grid_menu.DataSource = CollMenus;
            grid_menu.DataBind();

            ListMenuAltTypedList list_alt = new ListMenuAltTypedList();
            IPredicateExpression filter = new PredicateExpression();
            ISortExpression sortalt = new SortExpression();
            filter.AddWithAnd(AltMenuFields.AltMenuAd != "BOS");
            sortalt.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
            sortalt.Add(new SortClause(AltMenuFields.AltMenuSira, SortOperator.Ascending));
            list_alt.Fill(0, sortalt, true, filter);

            grid_menu_alt.DataSource = list_alt;
            grid_menu_alt.DataBind();

            ListAltIkiMenuTypedList list_a = new ListAltIkiMenuTypedList();
            IPredicateExpression filtera = new PredicateExpression();
            ISortExpression sorta = new SortExpression();
            filtera.AddWithAnd(AltAltMenuFields.AltAltMenuAd != "BOS");
            sorta.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
            sorta.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
            sorta.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
            list_a.Fill(0, sorta, true, filtera);

            grid_a_menu.DataSource = list_a;
            grid_a_menu.DataBind();

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            grid_menu.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_menu_alt.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_a_menu.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            if (IsPostBack != true)
            {
                MenuCollection CollEkle = new MenuCollection();
                IPredicateExpression ExpEkle = new PredicateExpression();
                ISortExpression sortekle = new SortExpression();
                ExpEkle.AddWithAnd(MenuFields.MenuAd != "BOS");
                sortekle.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                CollEkle.GetMulti(ExpEkle, 0, sortekle);

                cb_menu.Items.Clear();

                for (int i = 0; i < CollEkle.Count; i++)
                {
                    cb_menu.Items.Add(CollEkle[i].MenuAd);
                    cb_a_menu.Items.Add(CollEkle[i].MenuAd);
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
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Menü Bilgileri");
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

                Session["guncel_ver_menu"] = "0";
                Session["guncel_ver_alt_menu"] = "0";
                Session["guncel_ver_a_menu"] = "0";
            }
        }

        protected void btn_a_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["guncel_ver_a_menu"].ToString() == "0")
                {
                    MenuCollection CollMenu = new MenuCollection();
                    IPredicateExpression ExpMenu = new PredicateExpression();
                    ExpMenu.AddWithAnd(MenuFields.MenuAd == cb_a_menu.Text);
                    CollMenu.GetMulti(ExpMenu);

                    AltMenuCollection CollAlti = new AltMenuCollection();
                    IPredicateExpression ExpAlti = new PredicateExpression();
                    ExpAlti.AddWithAnd(AltMenuFields.FkMenuId == CollMenu[0].MenuId);
                    ExpAlti.AddWithAnd(AltMenuFields.AltMenuAd == cb_a_alt_menu.Text);
                    CollAlti.GetMulti(ExpAlti);

                    AltAltMenuCollection Coll2Alti = new AltAltMenuCollection();
                    IPredicateExpression Exp2Alti = new PredicateExpression();
                    Exp2Alti.AddWithAnd(AltAltMenuFields.FkAltMenuId == CollAlti[0].AltMenuId);
                    Exp2Alti.AddWithAnd(AltAltMenuFields.AltAltMenuAd == txt_a_alt_alt_menuu.Text);
                    Exp2Alti.AddWithAnd(AltAltMenuFields.AltAltMenuSira == Convert.ToInt16(txt_a_sira.Text));
                    Coll2Alti.GetMulti(Exp2Alti);

                    AltAltMenuCollection CollMenuSira = new AltAltMenuCollection();
                    IPredicateExpression ExpMenuSira = new PredicateExpression();
                    ExpMenuSira.AddWithAnd(AltAltMenuFields.FkAltMenuId == CollAlti[0].AltMenuId);
                    ExpMenuSira.AddWithAnd(AltAltMenuFields.AltAltMenuAd != "BOS");
                    ExpMenuSira.AddWithAnd(AltAltMenuFields.AltAltMenuSira == Convert.ToInt16(txt_a_sira.Text));
                    CollMenuSira.GetMulti(ExpMenuSira);

                    if (Coll2Alti.Count > 0)
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Alt Alt Menü sistemde kayıtlıdır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                    }

                    else
                    {
                        if (CollMenuSira.Count > 0)
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Sistemde sıra numaralı başka bir alt alt menü kayıtlıdır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                        }

                        else
                        {
                            AltAltMenuEntity EntVer = new AltAltMenuEntity();
                            EntVer.FkAltMenuId = CollAlti[0].AltMenuId;
                            EntVer.AltAltMenuAciklama = txt_a_aciklama.Text;
                            EntVer.AltAltMenuAd = txt_a_alt_alt_menuu.Text;
                            EntVer.AltAltMenuDurum = true;
                            EntVer.AltAltMenuLink = txt_a_link.Text;
                            EntVer.AltAltMenuSira = Convert.ToInt16(txt_a_sira.Text);
                            EntVer.AltAltMenuSonLink = txt_a_link.Text;
                            EntVer.AltAltMenuTarih = DateTime.Now;
                            EntVer.Save();

                            string CloseWindow;
                            CloseWindow = "alert('Kayıt işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            ListAltIkiMenuTypedList list_a = new ListAltIkiMenuTypedList();
                            IPredicateExpression filtera = new PredicateExpression();
                            ISortExpression sorta = new SortExpression();
                            filtera.AddWithAnd(AltAltMenuFields.AltAltMenuAd != "BOS");
                            sorta.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                            sorta.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
                            sorta.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
                            list_a.Fill(0, sorta, true, filtera);

                            grid_a_menu.DataSource = list_a;
                            grid_a_menu.DataBind();

                            cb_a_menu.Text = "";
                            cb_a_menu.NullText = "Seçiniz...";
                            cb_a_alt_menu.Text = "";
                            cb_a_alt_menu.NullText = "Seçiniz...";
                            txt_a_aciklama.Text = "";
                            txt_a_alt_alt_menuu.Text = "";
                            txt_a_link.Text = "";
                            txt_a_sira.Text = "";
                            cb_a_alt_menu.Enabled = false;

                            cb_a_menu.Focus();
                        }
                    }
                }

                else
                {
                    MenuCollection CollMenu = new MenuCollection();
                    IPredicateExpression ExpMenu = new PredicateExpression();
                    ExpMenu.AddWithAnd(MenuFields.MenuAd == cb_a_menu.Text);
                    CollMenu.GetMulti(ExpMenu);

                    AltMenuCollection CollAlti = new AltMenuCollection();
                    IPredicateExpression ExpAlti = new PredicateExpression();
                    ExpAlti.AddWithAnd(AltMenuFields.FkMenuId == CollMenu[0].MenuId);
                    ExpAlti.AddWithAnd(AltMenuFields.AltMenuAd == cb_a_alt_menu.Text);
                    CollAlti.GetMulti(ExpAlti);

                    AltAltMenuCollection Coll2Alti = new AltAltMenuCollection();
                    IPredicateExpression Exp2Alti = new PredicateExpression();
                    Exp2Alti.AddWithAnd(AltAltMenuFields.FkAltMenuId == CollAlti[0].AltMenuId);
                    Exp2Alti.AddWithAnd(AltAltMenuFields.AltAltMenuAd == txt_a_alt_alt_menuu.Text);
                    Coll2Alti.GetMulti(Exp2Alti);

                    AltAltMenuCollection CollMenuEx = new AltAltMenuCollection();
                    IPredicateExpression ExpMenuEx = new PredicateExpression();
                    ExpMenuEx.AddWithAnd(AltAltMenuFields.AltAltMenuId == Convert.ToInt16(txtUserName3.Text));
                    CollMenuEx.GetMulti(ExpMenuEx);

                    if (Coll2Alti.Count == 0)
                    {
                        AltAltMenuCollection CollMenuSira = new AltAltMenuCollection();
                        IPredicateExpression ExpMenuSira = new PredicateExpression();
                        ExpMenuSira.AddWithAnd(AltAltMenuFields.FkAltMenuId == CollAlti[0].AltMenuId);
                        ExpMenuSira.AddWithAnd(AltAltMenuFields.AltAltMenuAd != "BOS");
                        ExpMenuSira.AddWithAnd(AltAltMenuFields.AltAltMenuSira == Convert.ToInt16(txt_a_sira.Text));
                        CollMenuSira.GetMulti(ExpMenuSira);

                        if (CollMenuSira.Count == 1)
                        {
                            CollMenuEx[0].FkAltMenuId = CollAlti[0].AltMenuId;
                            CollMenuEx[0].AltAltMenuAciklama = txt_a_aciklama.Text;
                            CollMenuEx[0].AltAltMenuAd = txt_a_alt_alt_menuu.Text;
                            CollMenuEx[0].AltAltMenuDurum = true;
                            CollMenuEx[0].AltAltMenuLink = txt_a_link.Text;
                            CollMenuEx[0].AltAltMenuSira = Convert.ToInt16(txt_a_sira.Text);
                            CollMenuEx[0].AltAltMenuSonLink = txt_a_link.Text;
                            CollMenuEx[0].AltAltMenuTarih = DateTime.Now;
                            CollMenuEx[0].Save();

                            string CloseWindow;
                            CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            Session["guncel_ver_a_menu"] = "0";

                            ListAltIkiMenuTypedList list_a = new ListAltIkiMenuTypedList();
                            IPredicateExpression filtera = new PredicateExpression();
                            ISortExpression sorta = new SortExpression();
                            filtera.AddWithAnd(AltAltMenuFields.AltAltMenuAd != "BOS");
                            sorta.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                            sorta.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
                            sorta.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
                            list_a.Fill(0, sorta, true, filtera);

                            grid_a_menu.DataSource = list_a;
                            grid_a_menu.DataBind();

                            cb_a_menu.Text = "";
                            cb_a_menu.NullText = "Seçiniz...";
                            cb_a_alt_menu.Text = "";
                            cb_a_alt_menu.NullText = "Seçiniz...";
                            txt_a_aciklama.Text = "";
                            txt_a_alt_alt_menuu.Text = "";
                            txt_a_link.Text = "";
                            txt_a_sira.Text = "";
                            cb_a_alt_menu.Enabled = false;

                            cb_a_menu.Focus();
                        }

                        else
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Sistemde sıra numaralı başka bir menü kayıtlıdır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                        }
                    }

                    else
                    {
                        if (Coll2Alti[0].AltAltMenuId == CollMenuEx[0].AltAltMenuId && (txt_a_sira.Text == CollMenuEx[0].AltAltMenuSira.ToString()))
                        {
                            CollMenuEx[0].FkAltMenuId = CollAlti[0].AltMenuId;
                            CollMenuEx[0].AltAltMenuAciklama = txt_a_aciklama.Text;
                            CollMenuEx[0].AltAltMenuAd = txt_a_alt_alt_menuu.Text;
                            CollMenuEx[0].AltAltMenuDurum = true;
                            CollMenuEx[0].AltAltMenuLink = txt_a_link.Text;
                            CollMenuEx[0].AltAltMenuSira = Convert.ToInt16(txt_a_sira.Text);
                            CollMenuEx[0].AltAltMenuSonLink = txt_a_link.Text;
                            CollMenuEx[0].AltAltMenuTarih = DateTime.Now;
                            CollMenuEx[0].Save();

                            string CloseWindow;
                            CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            Session["guncel_ver_a_menu"] = "0";

                            ListAltIkiMenuTypedList list_a = new ListAltIkiMenuTypedList();
                            IPredicateExpression filtera = new PredicateExpression();
                            ISortExpression sorta = new SortExpression();
                            filtera.AddWithAnd(AltAltMenuFields.AltAltMenuAd != "BOS");
                            sorta.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                            sorta.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
                            sorta.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
                            list_a.Fill(0, sorta, true, filtera);

                            grid_a_menu.DataSource = list_a;
                            grid_a_menu.DataBind();

                            cb_a_menu.Text = "";
                            cb_a_menu.NullText = "Seçiniz...";
                            cb_a_alt_menu.Text = "";
                            cb_a_alt_menu.NullText = "Seçiniz...";
                            txt_a_aciklama.Text = "";
                            txt_a_alt_alt_menuu.Text = "";
                            txt_a_link.Text = "";
                            txt_a_sira.Text = "";
                            cb_a_alt_menu.Enabled = false;

                            cb_a_menu.Focus();
                        }

                        else if (Coll2Alti[0].AltAltMenuId != CollMenuEx[0].AltAltMenuId && (txt_a_sira.Text == CollMenuEx[0].AltAltMenuSira.ToString()))
                        {
                            if (Coll2Alti.Count == 0)
                            {
                                CollMenuEx[0].FkAltMenuId = CollAlti[0].AltMenuId;
                                CollMenuEx[0].AltAltMenuAciklama = txt_a_aciklama.Text;
                                CollMenuEx[0].AltAltMenuAd = txt_a_alt_alt_menuu.Text;
                                CollMenuEx[0].AltAltMenuDurum = true;
                                CollMenuEx[0].AltAltMenuLink = txt_a_link.Text;
                                CollMenuEx[0].AltAltMenuSira = Convert.ToInt16(txt_a_sira.Text);
                                CollMenuEx[0].AltAltMenuSonLink = txt_a_link.Text;
                                CollMenuEx[0].AltAltMenuTarih = DateTime.Now;
                                CollMenuEx[0].Save();

                                string CloseWindow;
                                CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                Session["guncel_ver_a_menu"] = "0";

                                ListAltIkiMenuTypedList list_a = new ListAltIkiMenuTypedList();
                                IPredicateExpression filtera = new PredicateExpression();
                                ISortExpression sorta = new SortExpression();
                                filtera.AddWithAnd(AltAltMenuFields.AltAltMenuAd != "BOS");
                                sorta.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                                sorta.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
                                sorta.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
                                list_a.Fill(0, sorta, true, filtera);

                                grid_a_menu.DataSource = list_a;
                                grid_a_menu.DataBind();

                                cb_a_menu.Text = "";
                                cb_a_menu.NullText = "Seçiniz...";
                                cb_a_alt_menu.Text = "";
                                cb_a_alt_menu.NullText = "Seçiniz...";
                                txt_a_aciklama.Text = "";
                                txt_a_alt_alt_menuu.Text = "";
                                txt_a_link.Text = "";
                                txt_a_sira.Text = "";
                                cb_a_alt_menu.Enabled = false;

                                cb_a_menu.Focus();
                            }

                            else
                            {
                                string CloseWindow;
                                CloseWindow = "alert('Alt Alt Menü sistemde kayıtlıdır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                            }
                        }

                        else if (Coll2Alti[0].AltAltMenuId != CollMenuEx[0].AltAltMenuId && (txt_a_sira.Text != CollMenuEx[0].AltAltMenuSira.ToString()))
                        {
                            AltAltMenuCollection CollMenuSira = new AltAltMenuCollection();
                            IPredicateExpression ExpMenuSira = new PredicateExpression();
                            ExpMenuSira.AddWithAnd(AltAltMenuFields.FkAltMenuId == CollAlti[0].AltMenuId);
                            ExpMenuSira.AddWithAnd(AltAltMenuFields.AltAltMenuAd != "BOS");
                            ExpMenuSira.AddWithAnd(AltAltMenuFields.AltAltMenuSira == Convert.ToInt16(txt_a_sira.Text));
                            CollMenuSira.GetMulti(ExpMenuSira);

                            if (CollMenuSira.Count == 0)
                            {
                                CollMenuEx[0].FkAltMenuId = CollAlti[0].AltMenuId;
                                CollMenuEx[0].AltAltMenuAciklama = txt_a_aciklama.Text;
                                CollMenuEx[0].AltAltMenuAd = txt_a_alt_alt_menuu.Text;
                                CollMenuEx[0].AltAltMenuDurum = true;
                                CollMenuEx[0].AltAltMenuLink = txt_a_link.Text;
                                CollMenuEx[0].AltAltMenuSira = Convert.ToInt16(txt_a_sira.Text);
                                CollMenuEx[0].AltAltMenuSonLink = txt_a_link.Text;
                                CollMenuEx[0].AltAltMenuTarih = DateTime.Now;
                                CollMenuEx[0].Save();

                                string CloseWindow;
                                CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                Session["guncel_ver_a_menu"] = "0";

                                ListAltIkiMenuTypedList list_a = new ListAltIkiMenuTypedList();
                                IPredicateExpression filtera = new PredicateExpression();
                                ISortExpression sorta = new SortExpression();
                                filtera.AddWithAnd(AltAltMenuFields.AltAltMenuAd != "BOS");
                                sorta.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                                sorta.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
                                sorta.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
                                list_a.Fill(0, sorta, true, filtera);

                                grid_a_menu.DataSource = list_a;
                                grid_a_menu.DataBind();

                                cb_a_menu.Text = "";
                                cb_a_menu.NullText = "Seçiniz...";
                                cb_a_alt_menu.Text = "";
                                cb_a_alt_menu.NullText = "Seçiniz...";
                                txt_a_aciklama.Text = "";
                                txt_a_alt_alt_menuu.Text = "";
                                txt_a_link.Text = "";
                                txt_a_sira.Text = "";
                                cb_a_alt_menu.Enabled = false;

                                cb_a_menu.Focus();
                            }

                            else
                            {
                                string CloseWindow;
                                CloseWindow = "alert('Sistemde sıra numaralı başka bir menü kayıtlıdır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                            }
                        }

                        else if (Coll2Alti[0].AltAltMenuId == CollMenuEx[0].AltAltMenuId && (txt_a_sira.Text != CollMenuEx[0].AltAltMenuSira.ToString()))
                        {
                            AltAltMenuCollection CollMenuSira = new AltAltMenuCollection();
                            IPredicateExpression ExpMenuSira = new PredicateExpression();
                            ExpMenuSira.AddWithAnd(AltAltMenuFields.FkAltMenuId == CollAlti[0].AltMenuId);
                            ExpMenuSira.AddWithAnd(AltAltMenuFields.AltAltMenuAd != "BOS");
                            ExpMenuSira.AddWithAnd(AltAltMenuFields.AltAltMenuSira == Convert.ToInt16(txt_a_sira.Text));
                            CollMenuSira.GetMulti(ExpMenuSira);

                            if (CollMenuSira.Count == 0)
                            {
                                CollMenuEx[0].FkAltMenuId = CollAlti[0].AltMenuId;
                                CollMenuEx[0].AltAltMenuAciklama = txt_a_aciklama.Text;
                                CollMenuEx[0].AltAltMenuAd = txt_a_alt_alt_menuu.Text;
                                CollMenuEx[0].AltAltMenuDurum = true;
                                CollMenuEx[0].AltAltMenuLink = txt_a_link.Text;
                                CollMenuEx[0].AltAltMenuSira = Convert.ToInt16(txt_a_sira.Text);
                                CollMenuEx[0].AltAltMenuSonLink = txt_a_link.Text;
                                CollMenuEx[0].AltAltMenuTarih = DateTime.Now;
                                CollMenuEx[0].Save();

                                string CloseWindow;
                                CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                Session["guncel_ver_a_menu"] = "0";

                                ListAltIkiMenuTypedList list_a = new ListAltIkiMenuTypedList();
                                IPredicateExpression filtera = new PredicateExpression();
                                ISortExpression sorta = new SortExpression();
                                filtera.AddWithAnd(AltAltMenuFields.AltAltMenuAd != "BOS");
                                sorta.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                                sorta.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
                                sorta.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
                                list_a.Fill(0, sorta, true, filtera);

                                grid_a_menu.DataSource = list_a;
                                grid_a_menu.DataBind();

                                cb_a_menu.Text = "";
                                cb_a_menu.NullText = "Seçiniz...";
                                cb_a_alt_menu.Text = "";
                                cb_a_alt_menu.NullText = "Seçiniz...";
                                txt_a_aciklama.Text = "";
                                txt_a_alt_alt_menuu.Text = "";
                                txt_a_link.Text = "";
                                txt_a_sira.Text = "";
                                cb_a_alt_menu.Enabled = false;

                                cb_a_menu.Focus();
                            }

                            else
                            {
                                string CloseWindow;
                                CloseWindow = "alert('Sistemde sıra numaralı başka bir menü kayıtlıdır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                            }
                        }
                    }
                }
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen sıra bilgisini kontrol ediniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                txt_a_sira.Focus();
            }
        }

        protected void btn_kayit_alt_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["guncel_ver_alt_menu"].ToString() == "0")
                {
                    MenuCollection CollMenu = new MenuCollection();
                    IPredicateExpression ExpMenu = new PredicateExpression();
                    ExpMenu.AddWithAnd(MenuFields.MenuAd == cb_menu.Text);
                    CollMenu.GetMulti(ExpMenu);

                    AltMenuCollection CollAlti = new AltMenuCollection();
                    IPredicateExpression ExpAlti = new PredicateExpression();
                    ExpAlti.AddWithAnd(AltMenuFields.FkMenuId == CollMenu[0].MenuId);
                    ExpAlti.AddWithAnd(AltMenuFields.AltMenuAd == txt_menu_alt.Text);
                    CollAlti.GetMulti(ExpAlti);

                    AltMenuCollection CollMenuSira = new AltMenuCollection();
                    IPredicateExpression ExpMenuSira = new PredicateExpression();
                    ExpMenuSira.AddWithAnd(AltMenuFields.FkMenuId == CollMenu[0].MenuId);
                    ExpMenuSira.AddWithAnd(AltMenuFields.AltMenuAd != "BOS");
                    ExpMenuSira.AddWithAnd(AltMenuFields.AltMenuSira == Convert.ToInt16(txt_sira_alt.Text));
                    CollMenuSira.GetMulti(ExpMenuSira);

                    if (CollAlti.Count > 0)
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Alt Menü sistemde kayıtlıdır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                    }

                    else
                    {
                        if (CollMenuSira.Count > 0)
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Sistemde sıra numaralı başka bir alt menü kayıtlıdır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                        }

                        else
                        {
                            AltMenuEntity EntKay = new AltMenuEntity();
                            EntKay.FkMenuId = CollMenu[0].MenuId;
                            EntKay.AltMenuAciklama = txt_aciklama_alt.Text;
                            EntKay.AltMenuAd = txt_menu_alt.Text;
                            EntKay.AltMenuDurum = true;
                            EntKay.AltMenuLink = "bos.aspx";
                            EntKay.AltMenuSira = Convert.ToInt16(txt_sira_alt.Text);
                            EntKay.AltMenuSonLink = "bos.aspx";
                            EntKay.AltMenuTarih = DateTime.Now;
                            EntKay.Save();

                            string CloseWindow;
                            CloseWindow = "alert('Kayıt işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            ListMenuAltTypedList list_alt = new ListMenuAltTypedList();
                            IPredicateExpression filter = new PredicateExpression();
                            ISortExpression sortalt = new SortExpression();
                            filter.AddWithAnd(AltMenuFields.AltMenuAd != "BOS");
                            sortalt.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                            sortalt.Add(new SortClause(AltMenuFields.AltMenuSira, SortOperator.Ascending));
                            list_alt.Fill(0, sortalt, true, filter);

                            grid_menu_alt.DataSource = list_alt;
                            grid_menu_alt.DataBind();

                            cb_menu.Text = "";
                            cb_menu.NullText = "Seçiniz...";
                            txt_aciklama_alt.Text = "";
                            txt_menu_alt.Text = "";
                            txt_sira_alt.Text = "";

                            cb_menu.Focus();
                        }
                    }
                }

                else
                {
                    MenuCollection CollMenu = new MenuCollection();
                    IPredicateExpression ExpMenu = new PredicateExpression();
                    ExpMenu.AddWithAnd(MenuFields.MenuAd == cb_menu.Text);
                    CollMenu.GetMulti(ExpMenu);

                    AltMenuCollection CollAlti = new AltMenuCollection();
                    IPredicateExpression ExpAlti = new PredicateExpression();
                    ExpAlti.AddWithAnd(AltMenuFields.FkMenuId == CollMenu[0].MenuId);
                    ExpAlti.AddWithAnd(AltMenuFields.AltMenuAd == txt_menu_alt.Text);
                    CollAlti.GetMulti(ExpAlti);

                    AltMenuCollection CollMenuEx = new AltMenuCollection();
                    IPredicateExpression ExpMenuEx = new PredicateExpression();
                    ExpMenuEx.AddWithAnd(AltMenuFields.AltMenuId == Convert.ToInt16(txtUserName2.Text));
                    CollMenuEx.GetMulti(ExpMenuEx);

                    if (CollAlti.Count == 0)
                    {
                        AltMenuCollection CollMenuSira = new AltMenuCollection();
                        IPredicateExpression ExpMenuSira = new PredicateExpression();
                        ExpMenuSira.AddWithAnd(AltMenuFields.FkMenuId == CollMenu[0].MenuId);
                        ExpMenuSira.AddWithAnd(AltMenuFields.AltMenuAd != "BOS");
                        ExpMenuSira.AddWithAnd(AltMenuFields.AltMenuSira == Convert.ToInt16(txt_sira_alt.Text));
                        CollMenuSira.GetMulti(ExpMenuSira);

                        if (CollMenuSira.Count == 1)
                        {
                            CollMenuEx[0].FkMenuId = CollMenu[0].MenuId;
                            CollMenuEx[0].AltMenuAciklama = txt_aciklama_alt.Text;
                            CollMenuEx[0].AltMenuAd = txt_menu_alt.Text;
                            CollMenuEx[0].AltMenuDurum = true;
                            CollMenuEx[0].AltMenuSira = Convert.ToInt16(txt_sira_alt.Text);
                            CollMenuEx[0].AltMenuTarih = DateTime.Now;
                            CollMenuEx[0].Save();

                            Session["guncel_ver_alt_menu"] = "0";

                            string CloseWindow;
                            CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            ListMenuAltTypedList list_alt = new ListMenuAltTypedList();
                            IPredicateExpression filter = new PredicateExpression();
                            ISortExpression sortalt = new SortExpression();
                            filter.AddWithAnd(AltMenuFields.AltMenuAd != "BOS");
                            sortalt.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                            sortalt.Add(new SortClause(AltMenuFields.AltMenuSira, SortOperator.Ascending));
                            list_alt.Fill(0, sortalt, true, filter);

                            grid_menu_alt.DataSource = list_alt;
                            grid_menu_alt.DataBind();

                            cb_menu.Text = "";
                            cb_menu.NullText = "Seçiniz...";
                            txt_aciklama_alt.Text = "";
                            txt_menu_alt.Text = "";
                            txt_sira_alt.Text = "";

                            cb_menu.Focus();
                        }

                        else
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Sistemde sıra numaralı başka bir menü kayıtlıdır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                        }
                    }

                    else
                    {
                        if (CollAlti[0].AltMenuId == CollMenuEx[0].AltMenuId && (txt_sira_alt.Text == CollMenuEx[0].AltMenuSira.ToString()))
                        {
                            CollMenuEx[0].FkMenuId = CollMenu[0].MenuId;
                            CollMenuEx[0].AltMenuAciklama = txt_aciklama_alt.Text;
                            CollMenuEx[0].AltMenuAd = txt_menu_alt.Text;
                            CollMenuEx[0].AltMenuDurum = true;
                            CollMenuEx[0].AltMenuSira = Convert.ToInt16(txt_sira_alt.Text);
                            CollMenuEx[0].AltMenuTarih = DateTime.Now;
                            CollMenuEx[0].Save();

                            Session["guncel_ver_alt_menu"] = "0";

                            string CloseWindow;
                            CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            ListMenuAltTypedList list_alt = new ListMenuAltTypedList();
                            IPredicateExpression filter = new PredicateExpression();
                            ISortExpression sortalt = new SortExpression();
                            filter.AddWithAnd(AltMenuFields.AltMenuAd != "BOS");
                            sortalt.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                            sortalt.Add(new SortClause(AltMenuFields.AltMenuSira, SortOperator.Ascending));
                            list_alt.Fill(0, sortalt, true, filter);

                            grid_menu_alt.DataSource = list_alt;
                            grid_menu_alt.DataBind();

                            cb_menu.Text = "";
                            cb_menu.NullText = "Seçiniz...";
                            txt_aciklama_alt.Text = "";
                            txt_menu_alt.Text = "";
                            txt_sira_alt.Text = "";

                            cb_menu.Focus();
                        }

                        else if (CollAlti[0].AltMenuId != CollMenuEx[0].AltMenuId && (txt_sira_alt.Text == CollMenuEx[0].AltMenuSira.ToString()))
                        {
                            if (CollAlti.Count == 0)
                            {
                                CollMenuEx[0].FkMenuId = CollMenu[0].MenuId;
                                CollMenuEx[0].AltMenuAciklama = txt_aciklama_alt.Text;
                                CollMenuEx[0].AltMenuAd = txt_menu_alt.Text;
                                CollMenuEx[0].AltMenuDurum = true;
                                CollMenuEx[0].AltMenuSira = Convert.ToInt16(txt_sira_alt.Text);
                                CollMenuEx[0].AltMenuTarih = DateTime.Now;
                                CollMenuEx[0].Save();

                                Session["guncel_ver_alt_menu"] = "0";

                                string CloseWindow;
                                CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                ListMenuAltTypedList list_alt = new ListMenuAltTypedList();
                                IPredicateExpression filter = new PredicateExpression();
                                ISortExpression sortalt = new SortExpression();
                                filter.AddWithAnd(AltMenuFields.AltMenuAd != "BOS");
                                sortalt.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                                sortalt.Add(new SortClause(AltMenuFields.AltMenuSira, SortOperator.Ascending));
                                list_alt.Fill(0, sortalt, true, filter);

                                grid_menu_alt.DataSource = list_alt;
                                grid_menu_alt.DataBind();

                                cb_menu.Text = "";
                                cb_menu.NullText = "Seçiniz...";
                                txt_aciklama_alt.Text = "";
                                txt_menu_alt.Text = "";
                                txt_sira_alt.Text = "";

                                cb_menu.Focus();
                            }

                            else
                            {
                                string CloseWindow;
                                CloseWindow = "alert('Alt Menü sistemde kayıtlıdır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                            }
                        }

                        else if (CollAlti[0].AltMenuId != CollMenuEx[0].AltMenuId && (txt_sira_alt.Text != CollMenuEx[0].AltMenuSira.ToString()))
                        {
                            AltMenuCollection CollMenuSira = new AltMenuCollection();
                            IPredicateExpression ExpMenuSira = new PredicateExpression();
                            ExpMenuSira.AddWithAnd(AltMenuFields.FkMenuId == CollMenu[0].MenuId);
                            ExpMenuSira.AddWithAnd(AltMenuFields.AltMenuAd != "BOS");
                            ExpMenuSira.AddWithAnd(AltMenuFields.AltMenuSira == Convert.ToInt16(txt_sira_alt.Text));
                            CollMenuSira.GetMulti(ExpMenuSira);

                            if (CollMenuSira.Count == 0)
                            {
                                CollMenuEx[0].FkMenuId = CollMenu[0].MenuId;
                                CollMenuEx[0].AltMenuAciklama = txt_aciklama_alt.Text;
                                CollMenuEx[0].AltMenuAd = txt_menu_alt.Text;
                                CollMenuEx[0].AltMenuDurum = true;
                                CollMenuEx[0].AltMenuSira = Convert.ToInt16(txt_sira_alt.Text);
                                CollMenuEx[0].AltMenuTarih = DateTime.Now;
                                CollMenuEx[0].Save();

                                Session["guncel_ver_alt_menu"] = "0";

                                string CloseWindow;
                                CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                ListMenuAltTypedList list_alt = new ListMenuAltTypedList();
                                IPredicateExpression filter = new PredicateExpression();
                                ISortExpression sortalt = new SortExpression();
                                filter.AddWithAnd(AltMenuFields.AltMenuAd != "BOS");
                                sortalt.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                                sortalt.Add(new SortClause(AltMenuFields.AltMenuSira, SortOperator.Ascending));
                                list_alt.Fill(0, sortalt, true, filter);

                                grid_menu_alt.DataSource = list_alt;
                                grid_menu_alt.DataBind();

                                cb_menu.Text = "";
                                cb_menu.NullText = "Seçiniz...";
                                txt_aciklama_alt.Text = "";
                                txt_menu_alt.Text = "";
                                txt_sira_alt.Text = "";

                                cb_menu.Focus();
                            }

                            else
                            {
                                string CloseWindow;
                                CloseWindow = "alert('Sistemde sıra numaralı başka bir menü kayıtlıdır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                            }
                        }

                        else if (CollAlti[0].AltMenuId == CollMenuEx[0].AltMenuId && (txt_sira_alt.Text != CollMenuEx[0].AltMenuSira.ToString()))
                        {
                            AltMenuCollection CollMenuSira = new AltMenuCollection();
                            IPredicateExpression ExpMenuSira = new PredicateExpression();
                            ExpMenuSira.AddWithAnd(AltMenuFields.FkMenuId == CollMenu[0].MenuId);
                            ExpMenuSira.AddWithAnd(AltMenuFields.AltMenuAd != "BOS");
                            ExpMenuSira.AddWithAnd(AltMenuFields.AltMenuSira == Convert.ToInt16(txt_sira_alt.Text));
                            CollMenuSira.GetMulti(ExpMenuSira);

                            if (CollMenuSira.Count == 0)
                            {
                                CollMenuEx[0].FkMenuId = CollMenu[0].MenuId;
                                CollMenuEx[0].AltMenuAciklama = txt_aciklama_alt.Text;
                                CollMenuEx[0].AltMenuAd = txt_menu_alt.Text;
                                CollMenuEx[0].AltMenuDurum = true;
                                CollMenuEx[0].AltMenuSira = Convert.ToInt16(txt_sira_alt.Text);
                                CollMenuEx[0].AltMenuTarih = DateTime.Now;
                                CollMenuEx[0].Save();

                                Session["guncel_ver_alt_menu"] = "0";

                                string CloseWindow;
                                CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                ListMenuAltTypedList list_alt = new ListMenuAltTypedList();
                                IPredicateExpression filter = new PredicateExpression();
                                ISortExpression sortalt = new SortExpression();
                                filter.AddWithAnd(AltMenuFields.AltMenuAd != "BOS");
                                sortalt.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                                sortalt.Add(new SortClause(AltMenuFields.AltMenuSira, SortOperator.Ascending));
                                list_alt.Fill(0, sortalt, true, filter);

                                grid_menu_alt.DataSource = list_alt;
                                grid_menu_alt.DataBind();

                                cb_menu.Text = "";
                                cb_menu.NullText = "Seçiniz...";
                                txt_aciklama_alt.Text = "";
                                txt_menu_alt.Text = "";
                                txt_sira_alt.Text = "";

                                cb_menu.Focus();
                            }

                            else
                            {
                                string CloseWindow;
                                CloseWindow = "alert('Sistemde sıra numaralı başka bir menü kayıtlıdır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                            }
                        }
                    }
                }
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen sıra bilgisini kontrol ediniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                txt_sira.Focus();
            }
        }

        protected void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["guncel_ver_menu"].ToString() == "0")
                {
                    MenuCollection CollMenu = new MenuCollection();
                    IPredicateExpression ExpMenu = new PredicateExpression();
                    ExpMenu.AddWithAnd(MenuFields.MenuAd == txt_menu.Text);
                    CollMenu.GetMulti(ExpMenu);

                    MenuCollection CollMenuSira = new MenuCollection();
                    IPredicateExpression ExpMenuSira = new PredicateExpression();
                    ExpMenuSira.AddWithAnd(MenuFields.MenuAd != "BOS");
                    ExpMenuSira.AddWithAnd(MenuFields.MenuSira == Convert.ToInt16(txt_sira.Text));
                    CollMenuSira.GetMulti(ExpMenuSira);

                    if (CollMenu.Count > 0)
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Menü sistemde kayıtlıdır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                    }

                    else
                    {
                        if (CollMenuSira.Count > 0)
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Sistemde sıra numaralı başka bir menü kayıtlıdır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                        }

                        else
                        {
                            MenuEntity EntKay = new MenuEntity();

                            if (txt_aciklama.Text != "")
                            {
                                EntKay.MenuAciklama = txt_aciklama.Text;
                            }

                            else
                            {
                                EntKay.MenuAciklama = "-";
                            }

                            EntKay.MenuAd = txt_menu.Text;
                            EntKay.MenuDurum = true;
                            EntKay.MenuLink = txt_link.Text;
                            EntKay.MenuSira = Convert.ToInt16(txt_sira.Text);
                            EntKay.MenuSonLink = txt_link.Text;
                            EntKay.MenuTarih = DateTime.Now;
                            EntKay.Save();

                            string CloseWindow;
                            CloseWindow = "alert('Kayıt işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            MenuCollection CollMenus = new MenuCollection();
                            IPredicateExpression ExpMenus = new PredicateExpression();
                            ISortExpression sortmenus = new SortExpression();
                            ExpMenus.AddWithAnd(MenuFields.MenuAd != "BOS");
                            sortmenus.Add(new SortClause(MenuFields.MenuSira, SortOperator.Ascending));
                            CollMenus.GetMulti(ExpMenus, 0, sortmenus);

                            grid_menu.DataSource = CollMenus;
                            grid_menu.DataBind();

                            txt_aciklama.Text = "";
                            txt_link.Text = "";
                            txt_menu.Text = "";
                            txt_sira.Text = "";

                            txt_menu.Focus();
                        }
                    }
                }

                else
                {
                    MenuCollection CollBul = new MenuCollection();
                    IPredicateExpression ExpBul = new PredicateExpression();
                    ExpBul.AddWithAnd(MenuFields.MenuAd == txt_menu.Text);
                    CollBul.GetMulti(ExpBul);

                    MenuCollection CollMenuEx = new MenuCollection();
                    IPredicateExpression ExpMenuEx = new PredicateExpression();
                    ExpMenuEx.AddWithAnd(MenuFields.MenuId == Convert.ToInt16(txtUserName.Text));
                    CollMenuEx.GetMulti(ExpMenuEx);

                    if (CollBul.Count == 0)
                    {
                        MenuCollection CollMenuSira = new MenuCollection();
                        IPredicateExpression ExpMenuSira = new PredicateExpression();
                        ExpMenuSira.AddWithAnd(MenuFields.MenuAd != "BOS");
                        ExpMenuSira.AddWithAnd(MenuFields.MenuSira == Convert.ToInt16(txt_sira.Text));
                        CollMenuSira.GetMulti(ExpMenuSira);

                        if (CollMenuSira.Count == 1)
                        {
                            if (txt_aciklama.Text != "")
                            {
                                CollMenuEx[0].MenuAciklama = txt_aciklama.Text;
                            }

                            else
                            {
                                CollMenuEx[0].MenuAciklama = "-";
                            }

                            CollMenuEx[0].MenuAd = txt_menu.Text;
                            CollMenuEx[0].MenuDurum = true;
                            CollMenuEx[0].MenuLink = txt_link.Text;
                            CollMenuEx[0].MenuSira = Convert.ToInt16(txt_sira.Text);
                            CollMenuEx[0].MenuSonLink = txt_link.Text;
                            CollMenuEx[0].MenuTarih = DateTime.Now;
                            CollMenuEx[0].Save();

                            Session["guncel_ver_menu"] = "0";

                            string CloseWindow;
                            CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            MenuCollection CollMenus = new MenuCollection();
                            IPredicateExpression ExpMenus = new PredicateExpression();
                            ISortExpression sortmenus = new SortExpression();
                            ExpMenus.AddWithAnd(MenuFields.MenuAd != "BOS");
                            sortmenus.Add(new SortClause(MenuFields.MenuSira, SortOperator.Ascending));
                            CollMenus.GetMulti(ExpMenus, 0, sortmenus);

                            grid_menu.DataSource = CollMenus;
                            grid_menu.DataBind();

                            txt_aciklama.Text = "";
                            txt_link.Text = "";
                            txt_menu.Text = "";
                            txt_sira.Text = "";

                            txt_menu.Focus();
                        }

                        else
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Sistemde sıra numaralı başka bir menü kayıtlıdır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                        }
                    }

                    else
                    {
                        if (CollBul[0].MenuId == CollMenuEx[0].MenuId && (txt_sira.Text == CollMenuEx[0].MenuSira.ToString()))
                        {
                            if (txt_aciklama.Text != "")
                            {
                                CollMenuEx[0].MenuAciklama = txt_aciklama.Text;
                            }

                            else
                            {
                                CollMenuEx[0].MenuAciklama = "-";
                            }

                            CollMenuEx[0].MenuAd = txt_menu.Text;
                            CollMenuEx[0].MenuDurum = true;
                            CollMenuEx[0].MenuLink = txt_link.Text;
                            CollMenuEx[0].MenuSira = Convert.ToInt16(txt_sira.Text);
                            CollMenuEx[0].MenuSonLink = txt_link.Text;
                            CollMenuEx[0].MenuTarih = DateTime.Now;
                            CollMenuEx[0].Save();

                            Session["guncel_ver_menu"] = "0";

                            string CloseWindow;
                            CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            MenuCollection CollMenus = new MenuCollection();
                            IPredicateExpression ExpMenus = new PredicateExpression();
                            ISortExpression sortmenus = new SortExpression();
                            ExpMenus.AddWithAnd(MenuFields.MenuAd != "BOS");
                            sortmenus.Add(new SortClause(MenuFields.MenuSira, SortOperator.Ascending));
                            CollMenus.GetMulti(ExpMenus, 0, sortmenus);

                            grid_menu.DataSource = CollMenus;
                            grid_menu.DataBind();

                            txt_aciklama.Text = "";
                            txt_link.Text = "";
                            txt_menu.Text = "";
                            txt_sira.Text = "";

                            txt_menu.Focus();
                        }

                        else if (CollBul[0].MenuId != CollMenuEx[0].MenuId && (txt_sira.Text == CollMenuEx[0].MenuSira.ToString()))
                        {
                            if (CollBul.Count == 0)
                            {
                                if (txt_aciklama.Text != "")
                                {
                                    CollMenuEx[0].MenuAciklama = txt_aciklama.Text;
                                }

                                else
                                {
                                    CollMenuEx[0].MenuAciklama = "-";
                                }

                                CollMenuEx[0].MenuAd = txt_menu.Text;
                                CollMenuEx[0].MenuDurum = true;
                                CollMenuEx[0].MenuLink = txt_link.Text;
                                CollMenuEx[0].MenuSira = Convert.ToInt16(txt_sira.Text);
                                CollMenuEx[0].MenuSonLink = txt_link.Text;
                                CollMenuEx[0].MenuTarih = DateTime.Now;
                                CollMenuEx[0].Save();

                                Session["guncel_ver_menu"] = "0";

                                string CloseWindow;
                                CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                MenuCollection CollMenus = new MenuCollection();
                                IPredicateExpression ExpMenus = new PredicateExpression();
                                ISortExpression sortmenus = new SortExpression();
                                ExpMenus.AddWithAnd(MenuFields.MenuAd != "BOS");
                                sortmenus.Add(new SortClause(MenuFields.MenuSira, SortOperator.Ascending));
                                CollMenus.GetMulti(ExpMenus, 0, sortmenus);

                                grid_menu.DataSource = CollMenus;
                                grid_menu.DataBind();

                                txt_aciklama.Text = "";
                                txt_link.Text = "";
                                txt_menu.Text = "";
                                txt_sira.Text = "";

                                txt_menu.Focus();
                            }

                            else
                            {
                                string CloseWindow;
                                CloseWindow = "alert('Alt Alt Menü sistemde kayıtlıdır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                            }
                        }

                        else if (CollBul[0].MenuId != CollMenuEx[0].MenuId && (txt_sira.Text != CollMenuEx[0].MenuSira.ToString()))
                        {
                            MenuCollection CollMenuSira = new MenuCollection();
                            IPredicateExpression ExpMenuSira = new PredicateExpression();
                            ExpMenuSira.AddWithAnd(MenuFields.MenuAd != "BOS");
                            ExpMenuSira.AddWithAnd(MenuFields.MenuSira == Convert.ToInt16(txt_sira.Text));
                            CollMenuSira.GetMulti(ExpMenuSira);

                            if (CollMenuSira.Count == 0)
                            {
                                if (txt_aciklama.Text != "")
                                {
                                    CollMenuEx[0].MenuAciklama = txt_aciklama.Text;
                                }

                                else
                                {
                                    CollMenuEx[0].MenuAciklama = "-";
                                }

                                CollMenuEx[0].MenuAd = txt_menu.Text;
                                CollMenuEx[0].MenuDurum = true;
                                CollMenuEx[0].MenuLink = txt_link.Text;
                                CollMenuEx[0].MenuSira = Convert.ToInt16(txt_sira.Text);
                                CollMenuEx[0].MenuSonLink = txt_link.Text;
                                CollMenuEx[0].MenuTarih = DateTime.Now;
                                CollMenuEx[0].Save();

                                Session["guncel_ver_menu"] = "0";

                                string CloseWindow;
                                CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                MenuCollection CollMenus = new MenuCollection();
                                IPredicateExpression ExpMenus = new PredicateExpression();
                                ISortExpression sortmenus = new SortExpression();
                                ExpMenus.AddWithAnd(MenuFields.MenuAd != "BOS");
                                sortmenus.Add(new SortClause(MenuFields.MenuSira, SortOperator.Ascending));
                                CollMenus.GetMulti(ExpMenus, 0, sortmenus);

                                grid_menu.DataSource = CollMenus;
                                grid_menu.DataBind();

                                txt_aciklama.Text = "";
                                txt_link.Text = "";
                                txt_menu.Text = "";
                                txt_sira.Text = "";

                                txt_menu.Focus();
                            }

                            else
                            {
                                string CloseWindow;
                                CloseWindow = "alert('Sistemde sıra numaralı başka bir menü kayıtlıdır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                            }
                        }

                        else if (CollBul[0].MenuId == CollMenuEx[0].MenuId && (txt_sira.Text != CollMenuEx[0].MenuSira.ToString()))
                        {
                            MenuCollection CollMenuSira = new MenuCollection();
                            IPredicateExpression ExpMenuSira = new PredicateExpression();
                            ExpMenuSira.AddWithAnd(MenuFields.MenuAd != "BOS");
                            ExpMenuSira.AddWithAnd(MenuFields.MenuSira == Convert.ToInt16(txt_sira.Text));
                            CollMenuSira.GetMulti(ExpMenuSira);

                            if (CollMenuSira.Count == 0)
                            {
                                if (txt_aciklama.Text != "")
                                {
                                    CollMenuEx[0].MenuAciklama = txt_aciklama.Text;
                                }

                                else
                                {
                                    CollMenuEx[0].MenuAciklama = "-";
                                }

                                CollMenuEx[0].MenuAd = txt_menu.Text;
                                CollMenuEx[0].MenuDurum = true;
                                CollMenuEx[0].MenuLink = txt_link.Text;
                                CollMenuEx[0].MenuSira = Convert.ToInt16(txt_sira.Text);
                                CollMenuEx[0].MenuSonLink = txt_link.Text;
                                CollMenuEx[0].MenuTarih = DateTime.Now;
                                CollMenuEx[0].Save();

                                Session["guncel_ver_menu"] = "0";

                                string CloseWindow;
                                CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                MenuCollection CollMenus = new MenuCollection();
                                IPredicateExpression ExpMenus = new PredicateExpression();
                                ISortExpression sortmenus = new SortExpression();
                                ExpMenus.AddWithAnd(MenuFields.MenuAd != "BOS");
                                sortmenus.Add(new SortClause(MenuFields.MenuSira, SortOperator.Ascending));
                                CollMenus.GetMulti(ExpMenus, 0, sortmenus);

                                grid_menu.DataSource = CollMenus;
                                grid_menu.DataBind();

                                txt_aciklama.Text = "";
                                txt_link.Text = "";
                                txt_menu.Text = "";
                                txt_sira.Text = "";

                                txt_menu.Focus();
                            }

                            else
                            {
                                string CloseWindow;
                                CloseWindow = "alert('Sistemde sıra numaralı başka bir menü kayıtlıdır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                            }
                        }
                    }
                }
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen sıra bilgisini kontrol ediniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                txt_sira.Focus();
            }
        }

        protected void btn_a_sil_Click(object sender, EventArgs e)
        {
            try
            {
                AltAltMenuCollection CollMenuEx = new AltAltMenuCollection();
                IPredicateExpression ExpMenuEx = new PredicateExpression();
                ExpMenuEx.AddWithAnd(AltAltMenuFields.AltAltMenuId == Convert.ToInt16(txtUserName3.Text));
                CollMenuEx.GetMulti(ExpMenuEx);

                CollMenuEx[0].Delete();
                CollMenuEx[0].Save();

                string CloseWindow;
                CloseWindow = "alert('Silme işlemi tamamlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                ListAltIkiMenuTypedList list_a = new ListAltIkiMenuTypedList();
                IPredicateExpression filtera = new PredicateExpression();
                ISortExpression sorta = new SortExpression();
                filtera.AddWithAnd(AltAltMenuFields.AltAltMenuAd != "BOS");
                sorta.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                sorta.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
                sorta.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
                list_a.Fill(0, sorta, true, filtera);

                grid_a_menu.DataSource = list_a;
                grid_a_menu.DataBind();

                cb_a_menu.Text = "";
                cb_a_menu.NullText = "Seçiniz...";
                cb_a_alt_menu.Text = "";
                cb_a_alt_menu.NullText = "Seçiniz...";
                txt_a_aciklama.Text = "";
                txt_a_alt_alt_menuu.Text = "";
                txt_a_link.Text = "";
                txt_a_sira.Text = "";
                cb_a_alt_menu.Enabled = false;

                cb_a_menu.Focus();
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Sistemde aktif olarak kullanılan alt alt menüyü silemezsiniz..')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void btn_sil2_Click(object sender, EventArgs e)
        {
            try
            {
                AltMenuCollection CollMenuEx = new AltMenuCollection();
                IPredicateExpression ExpMenuEx = new PredicateExpression();
                ExpMenuEx.AddWithAnd(AltMenuFields.AltMenuId == Convert.ToInt16(txtUserName2.Text));
                CollMenuEx.GetMulti(ExpMenuEx);

                CollMenuEx[0].Delete();
                CollMenuEx[0].Save();

                string CloseWindow;
                CloseWindow = "alert('Silme işlemi tamamlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                ListMenuAltTypedList list_alt = new ListMenuAltTypedList();
                IPredicateExpression filter = new PredicateExpression();
                ISortExpression sortalt = new SortExpression();
                filter.AddWithAnd(AltMenuFields.AltMenuAd != "BOS");
                sortalt.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                sortalt.Add(new SortClause(AltMenuFields.AltMenuSira, SortOperator.Ascending));
                list_alt.Fill(0, sortalt, true, filter);

                grid_menu_alt.DataSource = list_alt;
                grid_menu_alt.DataBind();

                txt_aciklama.Text = "";
                txt_link.Text = "";
                txt_menu.Text = "";
                txt_sira.Text = "";

                txt_menu.Focus();
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Sistemde aktif olarak kullanılan alt menüyü silemezsiniz..')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                MenuCollection CollMenuEx = new MenuCollection();
                IPredicateExpression ExpMenuEx = new PredicateExpression();
                ExpMenuEx.AddWithAnd(MenuFields.MenuId == Convert.ToInt16(txtUserName.Text));
                CollMenuEx.GetMulti(ExpMenuEx);

                CollMenuEx[0].Delete();
                CollMenuEx[0].Save();

                string CloseWindow;
                CloseWindow = "alert('Silme işlemi tamamlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                MenuCollection CollMenus = new MenuCollection();
                IPredicateExpression ExpMenus = new PredicateExpression();
                ISortExpression sortmenus = new SortExpression();
                ExpMenus.AddWithAnd(MenuFields.MenuAd != "BOS");
                sortmenus.Add(new SortClause(MenuFields.MenuSira, SortOperator.Ascending));
                CollMenus.GetMulti(ExpMenus, 0, sortmenus);

                grid_menu.DataSource = CollMenus;
                grid_menu.DataBind();

                txt_aciklama.Text = "";
                txt_link.Text = "";
                txt_menu.Text = "";
                txt_sira.Text = "";

                txt_menu.Focus();
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Sistemde aktif olarak kullanılan menüyü silemezsiniz..')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void btn_a_guncelle_Click(object sender, EventArgs e)
        {
            Session["guncel_ver_a_menu"] = "1";

            Int32 idsi = Convert.ToInt32(txtUserName3.Text);

            AltAltMenuCollection CollAAMenu = new AltAltMenuCollection();
            IPredicateExpression ExpAAMenu = new PredicateExpression();
            ExpAAMenu.AddWithAnd(AltAltMenuFields.AltAltMenuId == Convert.ToInt16(txtUserName3.Text));
            CollAAMenu.GetMulti(ExpAAMenu);

            AltMenuCollection CollAMenu = new AltMenuCollection();
            IPredicateExpression ExpAMenu = new PredicateExpression();
            ExpAMenu.AddWithAnd(AltMenuFields.AltMenuId == CollAAMenu[0].FkAltMenuId);
            CollAMenu.GetMulti(ExpAMenu);

            MenuCollection CollMenu = new MenuCollection();
            IPredicateExpression ExpMenu = new PredicateExpression();
            ExpMenu.AddWithAnd(MenuFields.MenuId == CollAMenu[0].FkMenuId);
            CollMenu.GetMulti(ExpMenu);

            cb_a_menu.Text = CollMenu[0].MenuAd;
            cb_a_alt_menu.Text = CollAMenu[0].AltMenuAd;
            txt_a_aciklama.Text = CollAAMenu[0].AltAltMenuAciklama;
            txt_a_alt_alt_menuu.Text = CollAAMenu[0].AltAltMenuAd;
            txt_a_link.Text = CollAAMenu[0].AltAltMenuLink;
            txt_a_sira.Text = CollAAMenu[0].AltAltMenuSira.ToString();

            cb_a_menu.Focus();
        }

        protected void btn_guncelle2_Click(object sender, EventArgs e)
        {
            Session["guncel_ver_alt_menu"] = "1";

            Int32 idsi = Convert.ToInt32(txtUserName2.Text);

            AltMenuCollection CollMenuEx = new AltMenuCollection();
            IPredicateExpression ExpMenuEx = new PredicateExpression();
            ExpMenuEx.AddWithAnd(AltMenuFields.AltMenuId == Convert.ToInt16(txtUserName2.Text));
            CollMenuEx.GetMulti(ExpMenuEx);

            MenuCollection CollMenu = new MenuCollection();
            IPredicateExpression ExpMenu = new PredicateExpression();
            ExpMenu.Add(MenuFields.MenuId == CollMenuEx[0].FkMenuId);
            CollMenu.GetMulti(ExpMenu);

            cb_menu.Text = CollMenu[0].MenuAd;
            txt_menu_alt.Text = CollMenuEx[0].AltMenuAd;
            txt_sira_alt.Text = CollMenuEx[0].AltMenuSira.ToString();
            txt_aciklama_alt.Text = CollMenuEx[0].AltMenuAciklama;

            cb_menu.Focus();
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            Session["guncel_ver_menu"] = "1";

            Int32 idsi = Convert.ToInt32(txtUserName.Text);

            MenuCollection CollMenuEx = new MenuCollection();
            IPredicateExpression ExpMenuEx = new PredicateExpression();
            ExpMenuEx.AddWithAnd(MenuFields.MenuId == Convert.ToInt16(txtUserName.Text));
            CollMenuEx.GetMulti(ExpMenuEx);

            txt_aciklama.Text = CollMenuEx[0].MenuAciklama;
            txt_link.Text = CollMenuEx[0].MenuLink;
            txt_menu.Text = CollMenuEx[0].MenuAd;
            txt_sira.Text = CollMenuEx[0].MenuSira.ToString();

            txt_menu.Focus();
        }

        protected void grid_menu_alt_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_menu_alt.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_menu_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_menu.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_a_menu_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_a_menu.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_menu_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = grid_menu.GetSelectedFieldValues("MenuId")[0].ToString();

            btn_sil.Enabled = true;
            btn_guncelle.Enabled = true;
        }

        protected void grid_menu_alt_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName2.Text = grid_menu_alt.GetSelectedFieldValues("AltMenuId")[0].ToString();

            btn_sil2.Enabled = true;
            btn_guncelle2.Enabled = true;
        }

        protected void grid_a_menu_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName3.Text = grid_a_menu.GetSelectedFieldValues("AltAltMenuId")[0].ToString();

            btn_a_sil.Enabled = true;
            btn_a_guncelle.Enabled = true;
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_aciklama.Text = "";
            txt_link.Text = "";
            txt_menu.Text = "";
            txt_sira.Text = "";

            txt_menu.Focus();
        }

        protected void btn_temizle_alt_Click(object sender, EventArgs e)
        {
            cb_menu.Text = "";
            cb_menu.NullText = "Seçiniz...";
            txt_aciklama_alt.Text = "";
            txt_menu_alt.Text = "";
            txt_sira_alt.Text = "";

            cb_menu.Focus();
        }

        protected void btn_a_temizle_Click(object sender, EventArgs e)
        {
            cb_a_menu.Text = "";
            cb_a_menu.NullText = "Seçiniz...";
            cb_a_alt_menu.Text = "";
            cb_a_alt_menu.NullText = "Seçiniz...";
            txt_a_aciklama.Text = "";
            txt_a_alt_alt_menuu.Text = "";
            txt_a_link.Text = "";
            txt_a_sira.Text = "";
            cb_a_alt_menu.Enabled = false;

            cb_a_menu.Focus();
        }

        protected void cb_a_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuCollection CollMenu = new MenuCollection();
            IPredicateExpression ExpMenu = new PredicateExpression();
            ExpMenu.AddWithAnd(MenuFields.MenuAd == cb_a_menu.Text);
            CollMenu.GetMulti(ExpMenu);

            AltMenuCollection CollAlt = new AltMenuCollection();
            ISortExpression sortalt = new SortExpression();
            IPredicateExpression ExpAlt = new PredicateExpression();
            ExpAlt.AddWithAnd(AltMenuFields.FkMenuId == CollMenu[0].MenuId);
            sortalt.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
            CollAlt.GetMulti(ExpAlt, 0, sortalt);

            cb_a_alt_menu.Items.Clear();

            for (int i = 0; i < CollAlt.Count; i++)
            {
                cb_a_alt_menu.Items.Add(CollAlt[i].AltMenuAd);
            }

            cb_a_alt_menu.Enabled = true;
        }
    }
}