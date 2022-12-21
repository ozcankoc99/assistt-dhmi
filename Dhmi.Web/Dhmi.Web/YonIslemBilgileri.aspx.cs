namespace Dhmi.Web
{
    using System;
    using System.Web.UI;
    using SD.LLBLGen.Pro.ORMSupportClasses;
    using dhmi.TypedListClasses;
    using dhmi.HelperClasses;
    using dhmi.EntityClasses;
    using dhmi.CollectionClasses;
    using System.Web;

    public partial class YonIslemBilgileri : System.Web.UI.Page
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

            ListIslemTypedList eg_snot = new ListIslemTypedList();
            ISortExpression sortss = new SortExpression();
            sortss.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
            sortss.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
            sortss.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
            sortss.Add(new SortClause(IslemFields.IslemSira, SortOperator.Ascending));
            eg_snot.Fill(0, sortss, true);

            grid_islem.DataSource = eg_snot;
            grid_islem.DataBind();

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            grid_islem.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

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
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "İşlem Bilgileri");
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

                cb_menu.Items.Clear();

                MenuCollection CollMenus = new MenuCollection();
                ISortExpression sortmenus = new SortExpression();
                sortmenus.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                IPredicateExpression ExpMenus = new PredicateExpression();
                ExpMenus.AddWithAnd(MenuFields.MenuAd != "BOS");
                ExpMenus.AddWithAnd(MenuFields.MenuAd != "Duyurular");
                CollMenus.GetMulti(ExpMenus, 0, sortmenus);

                for (int i = 0; i < CollMenus.Count; i++)
                {
                    cb_menu.Items.Add(CollMenus[i].MenuAd);
                }

                Session["guncel_ver"] = "0";
            }
        }

        protected void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["guncel_ver"].ToString() == "0")
                {
                    MenuCollection CollMenu = new MenuCollection();
                    IPredicateExpression ExpMenu = new PredicateExpression();
                    ExpMenu.AddWithAnd(MenuFields.MenuAd == cb_menu.Text);
                    CollMenu.GetMulti(ExpMenu);

                    AltMenuCollection CollAlt = new AltMenuCollection();
                    IPredicateExpression ExpAlt = new PredicateExpression();
                    ExpAlt.AddWithAnd(AltMenuFields.AltMenuAd == cb_alt_menu.Text);
                    CollAlt.GetMulti(ExpAlt);

                    AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                    IPredicateExpression ExpAlt2 = new PredicateExpression();
                    ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == cb_alt_alt_menu.Text);
                    CollAlt2.GetMulti(ExpAlt2);

                    IslemTuruCollection CollTur = new IslemTuruCollection();
                    IPredicateExpression ExpTur = new PredicateExpression();
                    ExpTur.AddWithAnd(IslemTuruFields.IslemTuruAd == cb_islem.Text);
                    CollTur.GetMulti(ExpTur);

                    IslemCollection CollIs = new IslemCollection();
                    IPredicateExpression ExpIs = new PredicateExpression();
                    ExpIs.AddWithAnd(IslemFields.FkMenuId == CollMenu[0].MenuId);
                    ExpIs.AddWithAnd(IslemFields.FkAltMenuId == CollAlt[0].AltMenuId);
                    ExpIs.AddWithAnd(IslemFields.FkAltAltMenuId == CollAlt2[0].AltAltMenuId);
                    ExpIs.AddWithAnd(IslemFields.FkIslemTuruId == CollTur[0].IslemTuruId);
                    CollIs.GetMulti(ExpIs);

                    if (CollIs.Count > 0)
                    {
                        string CloseWindow;
                        CloseWindow = "alert('İşlem sistemde kayıtlıdır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                    }

                    else
                    {
                        IslemCollection CollIsMenu = new IslemCollection();
                        IPredicateExpression ExpIsMenu = new PredicateExpression();
                        ExpIsMenu.AddWithAnd(IslemFields.FkMenuId == CollMenu[0].MenuId);
                        ExpIsMenu.AddWithAnd(IslemFields.FkAltMenuId == CollAlt[0].AltMenuId);
                        ExpIsMenu.AddWithAnd(IslemFields.FkAltAltMenuId == CollAlt2[0].AltAltMenuId);
                        ExpIsMenu.AddWithAnd(IslemFields.IslemSira == Convert.ToInt16(txt_sira.Text));
                        CollIsMenu.GetMulti(ExpIsMenu);

                        if (CollIsMenu.Count > 0)
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Sistemde sıra numaralı başka bir işlem kayıtlıdır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                        }

                        else
                        {
                            IslemEntity EntKay = new IslemEntity();
                            EntKay.FkMenuId = CollMenu[0].MenuId;
                            EntKay.FkAltMenuId = CollAlt[0].AltMenuId;
                            EntKay.FkAltAltMenuId = CollAlt2[0].AltAltMenuId;
                            EntKay.FkIslemTuruId = CollTur[0].IslemTuruId;
                            EntKay.IslemAd = CollTur[0].IslemTuruAd;
                            EntKay.IslemSira = Convert.ToInt16(txt_sira.Text);
                            EntKay.IslemTarih = DateTime.Now;
                            EntKay.Save();

                            string CloseWindow;
                            CloseWindow = "alert('Kayıt işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            ListIslemTypedList eg_snot = new ListIslemTypedList();
                            ISortExpression sortss = new SortExpression();
                            sortss.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                            sortss.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
                            sortss.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
                            sortss.Add(new SortClause(IslemFields.IslemSira, SortOperator.Ascending));
                            eg_snot.Fill(0, sortss, true);

                            grid_islem.DataSource = eg_snot;
                            grid_islem.DataBind();

                            txt_sira.Text = "";
                            Session["menu_al"] = "0";
                            Session["alt_menu_al"] = "0";
                            Session["guncel_ver"] = "0";

                            cb_menu.Text = "";
                            cb_alt_menu.Text = "";
                            cb_alt_alt_menu.Text = "";
                            cb_islem.Text = "";

                            cb_menu.NullText = "Seçiniz...";
                            cb_alt_menu.NullText = "Seçiniz...";
                            cb_alt_alt_menu.NullText = "Seçiniz...";
                            cb_islem.NullText = "Seçiniz...";

                            cb_alt_menu.Enabled = false;
                            cb_alt_alt_menu.Enabled = false;
                            cb_islem.Enabled = false;

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

                    AltMenuCollection CollAlt = new AltMenuCollection();
                    IPredicateExpression ExpAlt = new PredicateExpression();
                    ExpAlt.AddWithAnd(AltMenuFields.AltMenuAd == cb_alt_menu.Text);
                    CollAlt.GetMulti(ExpAlt);

                    AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                    IPredicateExpression ExpAlt2 = new PredicateExpression();
                    ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == cb_alt_alt_menu.Text);
                    CollAlt2.GetMulti(ExpAlt2);

                    IslemTuruCollection CollTur = new IslemTuruCollection();
                    IPredicateExpression ExpTur = new PredicateExpression();
                    ExpTur.AddWithAnd(IslemTuruFields.IslemTuruAd == cb_islem.Text);
                    CollTur.GetMulti(ExpTur);

                    IslemCollection CollIs = new IslemCollection();
                    IPredicateExpression ExpIs = new PredicateExpression();
                    ExpIs.AddWithAnd(IslemFields.FkMenuId == CollMenu[0].MenuId);
                    ExpIs.AddWithAnd(IslemFields.FkAltMenuId == CollAlt[0].AltMenuId);
                    ExpIs.AddWithAnd(IslemFields.FkAltAltMenuId == CollAlt2[0].AltAltMenuId);
                    ExpIs.AddWithAnd(IslemFields.FkIslemTuruId == CollTur[0].IslemTuruId);
                    CollIs.GetMulti(ExpIs);

                    IslemCollection CollIsEx = new IslemCollection();
                    IPredicateExpression ExpIsEx = new PredicateExpression();
                    ExpIsEx.AddWithAnd(IslemFields.IslemId == Convert.ToInt16(txtUserName.Text));
                    CollIsEx.GetMulti(ExpIsEx);

                    if (CollIs.Count == 0)
                    {
                        IslemCollection CollIsSira = new IslemCollection();
                        IPredicateExpression ExpIsSira = new PredicateExpression();
                        ExpIsSira.AddWithAnd(IslemFields.FkMenuId == CollMenu[0].MenuId);
                        ExpIsSira.AddWithAnd(IslemFields.FkAltMenuId == CollAlt[0].AltMenuId);
                        ExpIsSira.AddWithAnd(IslemFields.FkAltAltMenuId == CollAlt2[0].AltAltMenuId);
                        ExpIsSira.AddWithAnd(IslemFields.IslemSira == Convert.ToInt16(txt_sira.Text));
                        CollIsSira.GetMulti(ExpIsSira);

                        if (CollIsSira.Count == 1)
                        {
                            CollIsEx[0].FkMenuId = CollMenu[0].MenuId;
                            CollIsEx[0].FkAltMenuId = CollAlt[0].AltMenuId;
                            CollIsEx[0].FkAltAltMenuId = CollAlt2[0].AltAltMenuId;
                            CollIsEx[0].FkIslemTuruId = CollTur[0].IslemTuruId;
                            CollIsEx[0].IslemAd = CollTur[0].IslemTuruAd;
                            CollIsEx[0].IslemSira = Convert.ToInt16(txt_sira.Text);
                            CollIsEx[0].IslemTarih = DateTime.Now;
                            CollIsEx[0].Save();

                            Session["guncel_ver"] = "0";

                            string CloseWindow;
                            CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            ListIslemTypedList eg_snot = new ListIslemTypedList();
                            ISortExpression sortss = new SortExpression();
                            sortss.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                            sortss.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
                            sortss.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
                            sortss.Add(new SortClause(IslemFields.IslemSira, SortOperator.Ascending));
                            eg_snot.Fill(0, sortss, true);

                            grid_islem.DataSource = eg_snot;
                            grid_islem.DataBind();

                            txt_sira.Text = "";
                            Session["menu_al"] = "0";
                            Session["alt_menu_al"] = "0";
                            Session["guncel_ver"] = "0";

                            cb_menu.Text = "";
                            cb_alt_menu.Text = "";
                            cb_alt_alt_menu.Text = "";
                            cb_islem.Text = "";

                            cb_menu.NullText = "Seçiniz...";
                            cb_alt_menu.NullText = "Seçiniz...";
                            cb_alt_alt_menu.NullText = "Seçiniz...";
                            cb_islem.NullText = "Seçiniz...";

                            cb_alt_menu.Enabled = false;
                            cb_alt_alt_menu.Enabled = false;
                            cb_islem.Enabled = false;

                            cb_menu.Focus();
                        }

                        else
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Sistemde sıra numaralı başka bir işlem kayıtlıdır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                        }
                    }

                    else
                    {
                        if (CollIs[0].IslemId == CollIsEx[0].IslemId && (txt_sira.Text == CollIsEx[0].IslemSira.ToString()))
                        {
                            CollIsEx[0].FkMenuId = CollMenu[0].MenuId;
                            CollIsEx[0].FkAltMenuId = CollAlt[0].AltMenuId;
                            CollIsEx[0].FkAltAltMenuId = CollAlt2[0].AltAltMenuId;
                            CollIsEx[0].FkIslemTuruId = CollTur[0].IslemTuruId;
                            CollIsEx[0].IslemAd = CollTur[0].IslemTuruAd;
                            CollIsEx[0].IslemSira = Convert.ToInt16(txt_sira.Text);
                            CollIsEx[0].IslemTarih = DateTime.Now;
                            CollIsEx[0].Save();

                            Session["guncel_ver"] = "0";

                            string CloseWindow;
                            CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                            ListIslemTypedList eg_snot = new ListIslemTypedList();
                            ISortExpression sortss = new SortExpression();
                            sortss.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                            sortss.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
                            sortss.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
                            sortss.Add(new SortClause(IslemFields.IslemSira, SortOperator.Ascending));
                            eg_snot.Fill(0, sortss, true);

                            grid_islem.DataSource = eg_snot;
                            grid_islem.DataBind();

                            txt_sira.Text = "";
                            Session["menu_al"] = "0";
                            Session["alt_menu_al"] = "0";
                            Session["guncel_ver"] = "0";

                            cb_menu.Text = "";
                            cb_alt_menu.Text = "";
                            cb_alt_alt_menu.Text = "";
                            cb_islem.Text = "";

                            cb_menu.NullText = "Seçiniz...";
                            cb_alt_menu.NullText = "Seçiniz...";
                            cb_alt_alt_menu.NullText = "Seçiniz...";
                            cb_islem.NullText = "Seçiniz...";

                            cb_alt_menu.Enabled = false;
                            cb_alt_alt_menu.Enabled = false;
                            cb_islem.Enabled = false;

                            cb_menu.Focus();
                        }

                        else if (CollIs[0].IslemId != CollIsEx[0].IslemId && (txt_sira.Text == CollIsEx[0].IslemSira.ToString()))
                        {
                            if (CollIs.Count == 0)
                            {
                                CollIsEx[0].FkMenuId = CollMenu[0].MenuId;
                                CollIsEx[0].FkAltMenuId = CollAlt[0].AltMenuId;
                                CollIsEx[0].FkAltAltMenuId = CollAlt2[0].AltAltMenuId;
                                CollIsEx[0].FkIslemTuruId = CollTur[0].IslemTuruId;
                                CollIsEx[0].IslemAd = CollTur[0].IslemTuruAd;
                                CollIsEx[0].IslemSira = Convert.ToInt16(txt_sira.Text);
                                CollIsEx[0].IslemTarih = DateTime.Now;
                                CollIsEx[0].Save();

                                Session["guncel_ver"] = "0";

                                string CloseWindow;
                                CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                ListIslemTypedList eg_snot = new ListIslemTypedList();
                                ISortExpression sortss = new SortExpression();
                                sortss.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                                sortss.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
                                sortss.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
                                sortss.Add(new SortClause(IslemFields.IslemSira, SortOperator.Ascending));
                                eg_snot.Fill(0, sortss, true);

                                grid_islem.DataSource = eg_snot;
                                grid_islem.DataBind();

                                txt_sira.Text = "";
                                Session["menu_al"] = "0";
                                Session["alt_menu_al"] = "0";
                                Session["guncel_ver"] = "0";

                                cb_menu.Text = "";
                                cb_alt_menu.Text = "";
                                cb_alt_alt_menu.Text = "";
                                cb_islem.Text = "";

                                cb_menu.NullText = "Seçiniz...";
                                cb_alt_menu.NullText = "Seçiniz...";
                                cb_alt_alt_menu.NullText = "Seçiniz...";
                                cb_islem.NullText = "Seçiniz...";

                                cb_alt_menu.Enabled = false;
                                cb_alt_alt_menu.Enabled = false;
                                cb_islem.Enabled = false;

                                cb_menu.Focus();
                            }

                            else
                            {
                                string CloseWindow;
                                CloseWindow = "alert('İşlem sistemde kayıtlıdır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                            }
                        }

                        else if (CollIs[0].IslemId != CollIsEx[0].IslemId && (txt_sira.Text != CollIsEx[0].IslemSira.ToString()))
                        {
                            IslemCollection CollIsSira = new IslemCollection();
                            IPredicateExpression ExpIsSira = new PredicateExpression();
                            ExpIsSira.AddWithAnd(IslemFields.FkMenuId == CollMenu[0].MenuId);
                            ExpIsSira.AddWithAnd(IslemFields.FkAltMenuId == CollAlt[0].AltMenuId);
                            ExpIsSira.AddWithAnd(IslemFields.FkAltAltMenuId == CollAlt2[0].AltAltMenuId);
                            ExpIsSira.AddWithAnd(IslemFields.IslemSira == Convert.ToInt16(txt_sira.Text));
                            CollIsSira.GetMulti(ExpIsSira);

                            if (CollIsSira.Count == 0)
                            {
                                CollIsEx[0].FkMenuId = CollMenu[0].MenuId;
                                CollIsEx[0].FkAltMenuId = CollAlt[0].AltMenuId;
                                CollIsEx[0].FkAltAltMenuId = CollAlt2[0].AltAltMenuId;
                                CollIsEx[0].FkIslemTuruId = CollTur[0].IslemTuruId;
                                CollIsEx[0].IslemAd = CollTur[0].IslemTuruAd;
                                CollIsEx[0].IslemSira = Convert.ToInt16(txt_sira.Text);
                                CollIsEx[0].IslemTarih = DateTime.Now;
                                CollIsEx[0].Save();

                                Session["guncel_ver"] = "0";

                                string CloseWindow;
                                CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                ListIslemTypedList eg_snot = new ListIslemTypedList();
                                ISortExpression sortss = new SortExpression();
                                sortss.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                                sortss.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
                                sortss.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
                                sortss.Add(new SortClause(IslemFields.IslemSira, SortOperator.Ascending));
                                eg_snot.Fill(0, sortss, true);

                                grid_islem.DataSource = eg_snot;
                                grid_islem.DataBind();

                                txt_sira.Text = "";
                                Session["menu_al"] = "0";
                                Session["alt_menu_al"] = "0";
                                Session["guncel_ver"] = "0";

                                cb_menu.Text = "";
                                cb_alt_menu.Text = "";
                                cb_alt_alt_menu.Text = "";
                                cb_islem.Text = "";

                                cb_menu.NullText = "Seçiniz...";
                                cb_alt_menu.NullText = "Seçiniz...";
                                cb_alt_alt_menu.NullText = "Seçiniz...";
                                cb_islem.NullText = "Seçiniz...";

                                cb_alt_menu.Enabled = false;
                                cb_alt_alt_menu.Enabled = false;
                                cb_islem.Enabled = false;

                                cb_menu.Focus();
                            }

                            else
                            {
                                string CloseWindow;
                                CloseWindow = "alert('Sistemde sıra numaralı başka bir işlem kayıtlıdır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                            }
                        }

                        else if (CollIs[0].IslemId == CollIsEx[0].IslemId && (txt_sira.Text != CollIsEx[0].IslemSira.ToString()))
                        {
                            IslemCollection CollIsSira = new IslemCollection();
                            IPredicateExpression ExpIsSira = new PredicateExpression();
                            ExpIsSira.AddWithAnd(IslemFields.FkMenuId == CollMenu[0].MenuId);
                            ExpIsSira.AddWithAnd(IslemFields.FkAltMenuId == CollAlt[0].AltMenuId);
                            ExpIsSira.AddWithAnd(IslemFields.FkAltAltMenuId == CollAlt2[0].AltAltMenuId);
                            ExpIsSira.AddWithAnd(IslemFields.IslemSira == Convert.ToInt16(txt_sira.Text));
                            CollIsSira.GetMulti(ExpIsSira);

                            if (CollIsSira.Count == 0)
                            {
                                CollIsEx[0].FkMenuId = CollMenu[0].MenuId;
                                CollIsEx[0].FkAltMenuId = CollAlt[0].AltMenuId;
                                CollIsEx[0].FkAltAltMenuId = CollAlt2[0].AltAltMenuId;
                                CollIsEx[0].FkIslemTuruId = CollTur[0].IslemTuruId;
                                CollIsEx[0].IslemAd = CollTur[0].IslemTuruAd;
                                CollIsEx[0].IslemSira = Convert.ToInt16(txt_sira.Text);
                                CollIsEx[0].IslemTarih = DateTime.Now;
                                CollIsEx[0].Save();

                                Session["guncel_ver"] = "0";

                                string CloseWindow;
                                CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                ListIslemTypedList eg_snot = new ListIslemTypedList();
                                ISortExpression sortss = new SortExpression();
                                sortss.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                                sortss.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
                                sortss.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
                                sortss.Add(new SortClause(IslemFields.IslemSira, SortOperator.Ascending));
                                eg_snot.Fill(0, sortss, true);

                                grid_islem.DataSource = eg_snot;
                                grid_islem.DataBind();

                                txt_sira.Text = "";
                                Session["menu_al"] = "0";
                                Session["alt_menu_al"] = "0";
                                Session["guncel_ver"] = "0";

                                cb_menu.Text = "";
                                cb_alt_menu.Text = "";
                                cb_alt_alt_menu.Text = "";
                                cb_islem.Text = "";

                                cb_menu.NullText = "Seçiniz...";
                                cb_alt_menu.NullText = "Seçiniz...";
                                cb_alt_alt_menu.NullText = "Seçiniz...";
                                cb_islem.NullText = "Seçiniz...";

                                cb_alt_menu.Enabled = false;
                                cb_alt_alt_menu.Enabled = false;
                                cb_islem.Enabled = false;

                                cb_menu.Focus();
                            }

                            else
                            {
                                string CloseWindow;
                                CloseWindow = "alert('Sistemde sıra numaralı başka bir işlem kayıtlıdır...')";
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
            }
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                IslemCollection CollIs = new IslemCollection();
                IPredicateExpression ExpIs = new PredicateExpression();
                ExpIs.AddWithAnd(IslemFields.IslemId == Convert.ToInt32(txtUserName.Text));
                CollIs.GetMulti(ExpIs);

                CollIs[0].Delete();
                CollIs[0].Save();

                ListIslemTypedList eg_snot = new ListIslemTypedList();
                ISortExpression sortss = new SortExpression();
                sortss.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
                sortss.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
                sortss.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
                sortss.Add(new SortClause(IslemFields.IslemSira, SortOperator.Ascending));
                eg_snot.Fill(0, sortss, true);

                grid_islem.DataSource = eg_snot;
                grid_islem.DataBind();

                txt_sira.Text = "";
                Session["menu_al"] = "0";
                Session["alt_menu_al"] = "0";
                Session["guncel_ver"] = "0";

                cb_menu.Text = "";
                cb_alt_menu.Text = "";
                cb_alt_alt_menu.Text = "";
                cb_islem.Text = "";

                cb_menu.NullText = "Seçiniz...";
                cb_alt_menu.NullText = "Seçiniz...";
                cb_alt_alt_menu.NullText = "Seçiniz...";
                cb_islem.NullText = "Seçiniz...";

                cb_alt_menu.Enabled = false;
                cb_alt_alt_menu.Enabled = false;
                cb_islem.Enabled = false;

                cb_menu.Focus();

                string CloseWindow;
                CloseWindow = "alert('Silme işlemi tamamlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Sistemde aktif olarak kullanılan işlemi silemezsiniz..')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            Session["guncel_ver"] = "1";

            Int32 idsi = Convert.ToInt32(txtUserName.Text);

            carTabPage.ActiveTabIndex = 0;

            IslemCollection CollIs = new IslemCollection();
            IPredicateExpression ExpIs = new PredicateExpression();
            ExpIs.AddWithAnd(IslemFields.IslemId == Convert.ToInt32(txtUserName.Text));
            CollIs.GetMulti(ExpIs);

            MenuCollection CollMenu = new MenuCollection();
            IPredicateExpression ExpMenu = new PredicateExpression();
            ExpMenu.AddWithAnd(MenuFields.MenuId == CollIs[0].FkMenuId);
            CollMenu.GetMulti(ExpMenu);

            AltMenuCollection CollAlt = new AltMenuCollection();
            IPredicateExpression ExpAlt = new PredicateExpression();
            ExpAlt.AddWithAnd(AltMenuFields.AltMenuId == CollIs[0].FkAltMenuId);
            CollAlt.GetMulti(ExpAlt);

            AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
            IPredicateExpression ExpAlt2 = new PredicateExpression();
            ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuId == CollIs[0].FkAltAltMenuId);
            CollAlt2.GetMulti(ExpAlt2);

            IslemTuruCollection CollTur = new IslemTuruCollection();
            IPredicateExpression ExpTur = new PredicateExpression();
            ExpTur.AddWithAnd(IslemTuruFields.IslemTuruId == CollIs[0].FkIslemTuruId);
            CollTur.GetMulti(ExpTur);

            cb_alt_menu.Items.Clear();
            cb_alt_alt_menu.Items.Clear();
            cb_islem.Items.Clear();

            AltMenuCollection CollAltEk = new AltMenuCollection();
            IPredicateExpression ExpAltEk = new PredicateExpression();
            ISortExpression sort1 = new SortExpression();
            sort1.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
            ExpAltEk.AddWithAnd(AltMenuFields.AltMenuAd != "BOS");
            CollAltEk.GetMulti(ExpAltEk, 0, sort1);

            for (int a = 0; a < CollAltEk.Count; a++)
            {
                cb_alt_menu.Items.Add(CollAltEk[a].AltMenuAd);
            }

            AltAltMenuCollection CollAlt2Ek = new AltAltMenuCollection();
            ISortExpression sort2 = new SortExpression();
            IPredicateExpression ExpAlt2Ek = new PredicateExpression();
            sort2.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
            ExpAlt2Ek.AddWithAnd(AltAltMenuFields.AltAltMenuAd != "BOS");
            CollAlt2Ek.GetMulti(ExpAlt2Ek, 0, sort2);

            for (int b = 0; b < CollAlt2Ek.Count; b++)
            {
                cb_alt_alt_menu.Items.Add(CollAlt2Ek[b].AltAltMenuAd);
            }

            IslemTuruCollection CollTurEk = new IslemTuruCollection();
            ISortExpression sort3 = new SortExpression();
            sort3.Add(new SortClause(IslemTuruFields.IslemTuruAd, SortOperator.Ascending));
            CollTurEk.GetMulti(null, 0, sort3);

            for (int c = 0; c < CollTurEk.Count; c++)
            {
                cb_islem.Items.Add(CollTurEk[c].IslemTuruAd);
            }

            cb_alt_menu.Enabled = true;
            cb_alt_alt_menu.Enabled = true;
            cb_islem.Enabled = true;

            cb_menu.Text = CollMenu[0].MenuAd;
            cb_alt_menu.Text = CollAlt[0].AltMenuAd;
            cb_alt_alt_menu.Text = CollAlt2[0].AltAltMenuAd;
            cb_islem.Text = CollTur[0].IslemTuruAd;
            txt_sira.Text = CollIs[0].IslemSira.ToString();

            cb_menu.Focus();
        }

        protected void grid_islem_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_islem.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_islem_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = grid_islem.GetSelectedFieldValues("IslemId")[0].ToString();

            btn_sil.Enabled = true;
            btn_guncelle.Enabled = true;
        }

        protected void cb_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_alt_menu.Items.Clear();

            MenuCollection CollMenu = new MenuCollection();
            IPredicateExpression ExpMenu = new PredicateExpression();
            ISortExpression sortmenu = new SortExpression();
            ExpMenu.AddWithAnd(MenuFields.MenuAd == cb_menu.Text);
            sortmenu.Add(new SortClause(MenuFields.MenuAd, SortOperator.Ascending));
            CollMenu.GetMulti(ExpMenu, 0, sortmenu);

            Session["menu_al"] = CollMenu[0].MenuId.ToString();

            AltMenuCollection CollAlt = new AltMenuCollection();
            IPredicateExpression ExpAlt = new PredicateExpression();
            ISortExpression sortalt = new SortExpression();
            ExpAlt.AddWithAnd(AltMenuFields.FkMenuId == CollMenu[0].MenuId);
            sortalt.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
            CollAlt.GetMulti(ExpAlt, 0, sortalt);

            for (int i = 0; i < CollAlt.Count; i++)
            {
                cb_alt_menu.Items.Add(CollAlt[i].AltMenuAd);
            }

            cb_alt_menu.Enabled = true;
            cb_alt_menu.Text = "";
            cb_alt_menu.Focus();
        }

        protected void cb_alt_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_alt_alt_menu.Items.Clear();

            AltMenuCollection CollAlt = new AltMenuCollection();
            IPredicateExpression ExpAlt = new PredicateExpression();
            ISortExpression sortalt = new SortExpression();
            ExpAlt.AddWithAnd(AltMenuFields.AltMenuAd == cb_alt_menu.Text);
            sortalt.Add(new SortClause(AltMenuFields.AltMenuAd, SortOperator.Ascending));
            CollAlt.GetMulti(ExpAlt, 0, sortalt);

            Session["alt_menu_al"] = CollAlt[0].AltMenuId.ToString();

            AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
            IPredicateExpression ExpAlt2 = new PredicateExpression();
            ISortExpression sortalt2 = new SortExpression();
            ExpAlt2.AddWithAnd(AltAltMenuFields.FkAltMenuId == CollAlt[0].AltMenuId);
            sortalt2.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
            CollAlt2.GetMulti(ExpAlt2, 0, sortalt2);

            for (int i = 0; i < CollAlt2.Count; i++)
            {
                cb_alt_alt_menu.Items.Add(CollAlt2[i].AltAltMenuAd);
            }

            cb_alt_alt_menu.Enabled = true;
            cb_alt_alt_menu.Text = "";
            cb_alt_alt_menu.Focus();
        }

        protected void cb_alt_alt_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_islem.Items.Clear();

            AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
            IPredicateExpression ExpAlt2 = new PredicateExpression();
            ISortExpression sortalt2 = new SortExpression();
            ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == cb_alt_alt_menu.Text);
            sortalt2.Add(new SortClause(AltAltMenuFields.AltAltMenuAd, SortOperator.Ascending));
            CollAlt2.GetMulti(ExpAlt2, 0, sortalt2);

            IslemTuruCollection CollIslem = new IslemTuruCollection();
            ISortExpression sortislem = new SortExpression();
            sortislem.Add(new SortClause(IslemTuruFields.IslemTuruAd, SortOperator.Ascending));
            CollIslem.GetMulti(null, 0, sortislem);

            for (int i = 0; i < CollIslem.Count; i++)
            {
                cb_islem.Items.Add(CollIslem[i].IslemTuruAd);
            }

            cb_islem.Enabled = true;
            cb_islem.Text = "";
            cb_islem.Focus();
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_sira.Text = "";
            Session["menu_al"] = "0";
            Session["alt_menu_al"] = "0";
            Session["guncel_ver"] = "0";

            cb_menu.Text = "";
            cb_alt_menu.Text = "";
            cb_alt_alt_menu.Text = "";
            cb_islem.Text = "";

            cb_menu.NullText = "Seçiniz...";
            cb_alt_menu.NullText = "Seçiniz...";
            cb_alt_alt_menu.NullText = "Seçiniz...";
            cb_islem.NullText = "Seçiniz...";

            cb_alt_menu.Enabled = false;
            cb_alt_alt_menu.Enabled = false;
            cb_islem.Enabled = false;

            cb_menu.Focus();
        }
    }
}