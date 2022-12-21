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

    public partial class SrpRaporBilgileri : System.Web.UI.Page
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

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);
                        
            grid_rapor.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);                        

            if (IsPostBack != true)
            {
                Session["guncel_ekle"] = "0";

                cb_son_durum.Items.Clear();

                cb_son_durum.Items.Add("Aktif");
                cb_son_durum.Items.Add("Pasif");

                RaporTuruCollection CollRap = new RaporTuruCollection();
                IPredicateExpression ExpRap = new PredicateExpression();
                ISortExpression sortrap = new SortExpression();
                ExpRap.AddWithAnd(RaporTuruFields.RaporTuruDurum == true);
                sortrap.Add(new SortClause(RaporTuruFields.RaporTuruAd, SortOperator.Ascending));
                CollRap.GetMulti(ExpRap, 0, sortrap);

                for (int i = 0; i < CollRap.Count; i++) 
                {
                    cb_tur.Items.Add(CollRap[i].RaporTuruAd);
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
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Rapor Bilgileri");
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
        }

        protected void cb_tur_SelectedIndexChanged(object sender, EventArgs e)
        {
            RaporTuruCollection CollTur = new RaporTuruCollection();
            IPredicateExpression ExpTur = new PredicateExpression();
            ExpTur.AddWithAnd(RaporTuruFields.RaporTuruAd == cb_tur.Text);
            CollTur.GetMulti(ExpTur);

            RaporYetkiCollection CollA = new RaporYetkiCollection();
            IPredicateExpression ExpA = new PredicateExpression();
            ExpA.AddWithAnd(RaporYetkiFields.FkRaporTuruId == CollTur[0].RaporTuruId);
            CollA.GetMulti(ExpA);

            int ggg = CollA.Count;

            ListRaporTypedList rapor_list = new ListRaporTypedList();
            ISortExpression sort = new SortExpression();
            sort.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
            IPredicateExpression filter = new PredicateExpression();
            filter.AddWithAnd(RaporYetkiFields.FkRaporTuruId == CollTur[0].RaporTuruId);
            rapor_list.Fill(0, sort);
            //rapor_list.Fill(0, sort, true, filter);

            grid_rapor.DataSource = rapor_list;
            grid_rapor.DataBind();

            int dddd = rapor_list.Count;

            cb_kim.Items.Clear();

            KullaniciCollection CollKul = new KullaniciCollection();
            ISortExpression sortkul = new SortExpression();
            sortkul.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
            CollKul.GetMulti(null, 0, sortkul);

            for (int h = 0; h < CollKul.Count; h++)
            {
                int basla = 0;

                for (int i = 0; i < rapor_list.Count; i++)
                {
                    if (CollKul[h].KullaniciAdSoyad == rapor_list[i].KullaniciAdSoyad)
                    {
                        basla = 1;
                    }
                }

                if (basla == 0)
                {
                    cb_kim.Items.Add(CollKul[h].KullaniciAdSoyad);
                }
            }

            panel3.Visible = true;
        }

        protected void btn_guncelle2_Click(object sender, EventArgs e)
        {
            RaporYetkiCollection CollRap = new RaporYetkiCollection();
            IPredicateExpression ExpRap = new PredicateExpression();
            ExpRap.AddWithAnd(RaporYetkiFields.RaporYetkiId == Convert.ToInt64(txtUserName22.Text));
            CollRap.GetMulti(ExpRap);            

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == CollRap[0].FkKullaniciId);
            CollKul.GetMulti(ExpKul);

            Session["guncel_ekle"] = "1";

            cb_kim.Text = CollKul[0].KullaniciAdSoyad;

            if (CollRap[0].RaporYetkiDurum == true)
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
                RaporYetkiCollection CollRap = new RaporYetkiCollection();
                IPredicateExpression ExpRap = new PredicateExpression();
                ExpRap.AddWithAnd(RaporYetkiFields.RaporYetkiId == Convert.ToInt64(txtUserName22.Text));
                CollRap.GetMulti(ExpRap);

                CollRap[0].Delete();
                CollRap[0].Save();

                string CloseWindow;
                CloseWindow = "alert('Silme işlemi tamamlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                cb_kim.Text = "";
                cb_kim.NullText = "Seçiniz...";
                cb_son_durum.Text = "";
                cb_son_durum.NullText = "Seçiniz...";

                RaporTuruCollection CollTur = new RaporTuruCollection();
                IPredicateExpression ExpTur = new PredicateExpression();
                ExpTur.AddWithAnd(RaporTuruFields.RaporTuruAd == cb_tur.Text);
                CollTur.GetMulti(ExpTur);

                ListRaporTypedList rapor_list = new ListRaporTypedList();
                ISortExpression sort = new SortExpression();
                sort.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
                IPredicateExpression filter = new PredicateExpression();
                filter.AddWithAnd(RaporYetkiFields.FkRaporTuruId == CollTur[0].RaporTuruId);
                rapor_list.Fill(0, sort, true, filter);

                grid_rapor.DataSource = rapor_list;
                grid_rapor.DataBind();

                cb_kim.Items.Clear();

                KullaniciCollection CollKul = new KullaniciCollection();
                ISortExpression sortkul = new SortExpression();
                sortkul.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
                CollKul.GetMulti(null, 0, sortkul);

                for (int h = 0; h < CollKul.Count; h++)
                {
                    int basla = 0;

                    for (int i = 0; i < rapor_list.Count; i++)
                    {
                        if (CollKul[h].KullaniciAdSoyad == rapor_list[i].KullaniciAdSoyad)
                        {
                            basla = 1;
                        }
                    }

                    if (basla == 0)
                    {
                        cb_kim.Items.Add(CollKul[h].KullaniciAdSoyad);
                    }
                }
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen bir kayıt seçiniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
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

        protected void grid_rapor_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName22.Text = grid_rapor.GetSelectedFieldValues("RaporYetkiId")[0].ToString();

            btn_guncelle2.Enabled = true;
            btn_sil2.Enabled = true;
        }

        protected void btn_kayit_ekle_Click(object sender, EventArgs e)
        {
            if (Session["guncel_ekle"].ToString() == "0")
            {
                RaporTuruCollection CollTur = new RaporTuruCollection();
                IPredicateExpression ExpTur = new PredicateExpression();
                ExpTur.AddWithAnd(RaporTuruFields.RaporTuruAd == cb_tur.Text);
                CollTur.GetMulti(ExpTur);

                KullaniciCollection CollKull = new KullaniciCollection();
                IPredicateExpression ExpKull = new PredicateExpression();
                ExpKull.AddWithAnd(KullaniciFields.KullaniciAdSoyad == cb_kim.Text);
                CollKull.GetMulti(ExpKull);

                RaporYetkiEntity EntKay = new RaporYetkiEntity();
                EntKay.FkRaporTuruId = CollTur[0].RaporTuruId;
                EntKay.FkKullaniciId = CollKull[0].KullaniciId;
                EntKay.RaporYetkiTarih = DateTime.Now;

                if (cb_son_durum.Text == "Aktif")
                {
                    EntKay.RaporYetkiDurum = true;
                }

                else
                {
                    EntKay.RaporYetkiDurum = false;
                }

                EntKay.Save();
            }

            else
            {
                RaporYetkiCollection CollRap = new RaporYetkiCollection();
                IPredicateExpression ExpRap = new PredicateExpression();
                ExpRap.AddWithAnd(RaporYetkiFields.RaporYetkiId == Convert.ToInt64(txtUserName22.Text));
                CollRap.GetMulti(ExpRap);

                if (cb_son_durum.Text == "Aktif")
                {
                    CollRap[0].RaporYetkiDurum = true;
                }

                else
                {
                    CollRap[0].RaporYetkiDurum = false;
                }

                CollRap[0].Save();
            }

            cb_kim.Text = "";
            cb_kim.NullText = "Seçiniz...";
            cb_son_durum.Text = "";
            cb_son_durum.NullText = "Seçiniz...";

            RaporTuruCollection CollTur3 = new RaporTuruCollection();
            IPredicateExpression ExpTur3 = new PredicateExpression();
            ExpTur3.AddWithAnd(RaporTuruFields.RaporTuruAd == cb_tur.Text);
            CollTur3.GetMulti(ExpTur3);

            ListRaporTypedList rapor_list = new ListRaporTypedList();
            ISortExpression sort = new SortExpression();
            sort.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
            IPredicateExpression filter = new PredicateExpression();
            filter.AddWithAnd(RaporYetkiFields.FkRaporTuruId == CollTur3[0].RaporTuruId);
            rapor_list.Fill(0, sort, true, filter);

            grid_rapor.DataSource = rapor_list;
            grid_rapor.DataBind();

            cb_kim.Items.Clear();

            KullaniciCollection CollKul = new KullaniciCollection();
            ISortExpression sortkul = new SortExpression();
            sortkul.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
            CollKul.GetMulti(null, 0, sortkul);

            for (int h = 0; h < CollKul.Count; h++)
            {
                int basla = 0;

                for (int i = 0; i < rapor_list.Count; i++)
                {
                    if (CollKul[h].KullaniciAdSoyad == rapor_list[i].KullaniciAdSoyad)
                    {
                        basla = 1;
                    }
                }

                if (basla == 0)
                {
                    cb_kim.Items.Add(CollKul[h].KullaniciAdSoyad);
                }
            }

            cb_kim.Enabled = true;

            string CloseWindow;
            CloseWindow = "alert('Kayıt/Güncelleme işlemi tamamlanmıştır...')";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
        }
    }
}