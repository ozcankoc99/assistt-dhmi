namespace Dhmi.Web
{
    using System;
    using System.Web.UI;
    using SD.LLBLGen.Pro.ORMSupportClasses;
    using dhmi.CollectionClasses;
    using dhmi.HelperClasses;
    using dhmi.TypedListClasses;
    using System.Web;

    public partial class RapSistemRaporlari : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["menu_sec"] = "Raporlar";

            if ((Session["kullanici_var_mi"] == null) || (Session["kullanici_rastgele"] == null))
            {
                Response.Redirect("Account/Login.aspx");
            }

            HttpCookie cookie = Request.Cookies["userC"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddMinutes(15);
                cookie.Secure = true;
                //cookie.SameSite = SameSiteMode.Lax;
                cookie.HttpOnly = true;
                Response.Cookies.Add(cookie);
            }
            else
            {
                Response.Redirect("Account/Login.aspx");
            }

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            grid_bildirim.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_bilgi.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_duyuru.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_rapor.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_vip.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_kopuk.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_kul.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_vatandas.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_vip.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            grid_bildirim_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "BİLDİRİM BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_bildirim_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");
            grid_bilgi_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "BİLGİ BANKASI BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_bilgi_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");
            grid_duyuru_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "DUYURU BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_duyuru_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");
            grid_rapor_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "GRUP - KULLANICI BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_rapor_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");
            grid_vip_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "KARA LİSTE BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_vip_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");
            grid_kopuk_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "KÖPÜK ÇAĞRI BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_kopuk_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");
            gr_kul_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "KULLANICI BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            gr_kul_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");
            grid_vatandas_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "VATANDAŞ/FİRMA BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_vatandas_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");
            grid_vips_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "VIP LİSTE BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_vips_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

            if (cb_tur.Text == "Bildirim Raporları")
            {
                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();
                bil_list.Fill(0, sort22);

                grid_bildirim.DataSource = bil_list;
                grid_bildirim.DataBind();

                YetkiCollection CollYets = new YetkiCollection();
                IPredicateExpression ExpYets = new PredicateExpression();
                ExpYets.AddWithAnd(YetkiFields.YetkiId == CollKul[0].FkYetkiId);
                CollYets.GetMulti(ExpYets);

                Session["yetki_durum"] = CollYets[0].YetkiAciklama;

                if (Session["yetki_durum"].ToString() == "Evet")
                {
                    grid_bildirim.Columns[2].Visible = true;
                    grid_bildirim.Columns[3].Visible = true;
                    grid_bildirim.Columns[4].Visible = true;
                    grid_bildirim.Columns[5].Visible = true;
                }

                else 
                {
                    grid_bildirim.Columns[2].Visible = false;
                    grid_bildirim.Columns[3].Visible = false;
                    grid_bildirim.Columns[4].Visible = false;
                    grid_bildirim.Columns[5].Visible = false;
                }

                GrupCollection CollGr = new GrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(GrupFields.GrupAd == "Hukuk Müşavirliği");
                CollGr.GetMulti(ExpGr);

                GrupAtamaCollection CollAta = new GrupAtamaCollection();
                IPredicateExpression ExpAta = new PredicateExpression();
                ExpAta.AddWithAnd(GrupAtamaFields.FkGrupId == CollGr[0].GrupId);
                ExpAta.AddWithAnd(GrupAtamaFields.FkKullaniciId == CollKul[0].KullaniciId);
                CollAta.GetMulti(ExpAta);

                if (CollAta.Count > 0)
                {
                    grid_bildirim.Columns[16].Visible = true;
                    grid_bildirim.Columns[17].Visible = true;
                    grid_bildirim.Columns[18].Visible = true;
                    grid_bildirim.Columns[19].Visible = true;
                }

                else 
                {
                    grid_bildirim.Columns[16].Visible = false;
                    grid_bildirim.Columns[17].Visible = false;
                    grid_bildirim.Columns[18].Visible = false;
                    grid_bildirim.Columns[19].Visible = false;
                }
            }

            else if (cb_tur.Text == "Bilgi Bankası Raporları")
            {
                ListBilgiTypedList eg_snot = new ListBilgiTypedList();
                ISortExpression sortss = new SortExpression();
                sortss.Add(new SortClause(BilgiBankasiTurFields.BilgiBankasiTurAd, SortOperator.Ascending));
                sortss.Add(new SortClause(BilgiBankasiFields.BilgiBankasiAd, SortOperator.Ascending));
                eg_snot.Fill(0, sortss, true);

                grid_bilgi.DataSource = eg_snot;
                grid_bilgi.DataBind();
            }

            else if (cb_tur.Text == "Duyuru Raporları")
            {
                ListDuyuruTypedList eg_snot2 = new ListDuyuruTypedList();
                ISortExpression sortss2 = new SortExpression();
                sortss2.Add(new SortClause(DuyuruFields.DuyuruYayinTarih, SortOperator.Descending));
                eg_snot2.Fill(0, sortss2, true);

                grid_duyuru.DataSource = eg_snot2;
                grid_duyuru.DataBind();
            }

            else if (cb_tur.Text == "Grup-Kullanıcı Raporları")
            {
                ListGrupAtamaTypedList atama_list = new ListGrupAtamaTypedList();
                ISortExpression sortatama = new SortExpression();
                sortatama.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
                IPredicateExpression filteratama = new PredicateExpression();
                filteratama.AddWithAnd(GrupAtamaFields.GrupAtamaDurum == true);
                atama_list.Fill(0, sortatama, true, filteratama);

                grid_rapor.DataSource = atama_list;
                grid_rapor.DataBind();
            }

            else if (cb_tur.Text == "Kara Liste Raporları")
            {
                ListKaraTypedList list_vip = new ListKaraTypedList();
                ISortExpression sortvip = new SortExpression();
                sortvip.Add(new SortClause(KaraListeFields.KaraListeIslemTarih, SortOperator.Descending));
                list_vip.Fill(0, sortvip, true);

                grid_vip.DataSource = list_vip;
                grid_vip.DataBind();
            }

            else if (cb_tur.Text == "Köpük Çağrı Raporları")
            {
                ListKopukTypedList eg_snott = new ListKopukTypedList();
                ISortExpression sortsst = new SortExpression();
                sortsst.Add(new SortClause(KopukCagriFields.KopukCagriTarih, SortOperator.Descending));
                sortsst.Add(new SortClause(KopukCagriTuruFields.KopukCagriTuruAd, SortOperator.Ascending));
                eg_snott.Fill(0, sortsst, true);

                grid_kopuk.DataSource = eg_snott;
                grid_kopuk.DataBind();
            }

            else if (cb_tur.Text == "Kullanıcı Raporları")
            {
                ListKulTypedList eg_snotj = new ListKulTypedList();
                ISortExpression sortssj = new SortExpression();
                sortssj.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
                eg_snotj.Fill(0, sortssj, true);

                grid_kul.DataSource = eg_snotj;
                grid_kul.DataBind();
            }

            else if (cb_tur.Text == "Vatandaş/Firma Raporları")
            {
                VatandaCollection CollVat = new VatandaCollection();
                ISortExpression sortssvt = new SortExpression();
                sortssvt.Add(new SortClause(VatandaFields.VatandasAdSoyad, SortOperator.Ascending));
                CollVat.GetMulti(null, 0, sortssvt);

                grid_vatandas.DataSource = CollVat;
                grid_vatandas.DataBind(); 
            }

            else if (cb_tur.Text == "VIP Liste Raporları")
            {
                ListVipTypedList list_vips = new ListVipTypedList();
                ISortExpression sortvips = new SortExpression();
                sortvips.Add(new SortClause(VipListeFields.VipListeIslemTarih, SortOperator.Descending));
                list_vips.Fill(0, sortvips, true);

                grid_vips.DataSource = list_vips;
                grid_vips.DataBind();
            }            

            if (IsPostBack != true)
            {
                Session["Bildirim"] = null;
                Session["Bilgi"] = null;
                Session["Duyuru"] = null;
                Session["Grup"] = null;
                Session["Kara"] = null;
                Session["Kopuk"] = null;
                Session["Kullanici"] = null;
                Session["Vatandas"] = null;
                Session["VIP"] = null;

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
                ExpMenu.AddWithAnd(MenuFields.MenuAd == "Raporlar");
                CollMenu.GetMulti(ExpMenu);

                AltMenuCollection CollAlt1 = new AltMenuCollection();
                IPredicateExpression ExpAlt1 = new PredicateExpression();
                ExpAlt1.AddWithAnd(AltMenuFields.AltMenuAd == "Raporlar");
                CollAlt1.GetMulti(ExpAlt1);

                AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                IPredicateExpression ExpAlt2 = new PredicateExpression();
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Sistem Raporları");
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
            ExpA.AddWithAnd(RaporYetkiFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollA.GetMulti(ExpA);

            if (CollA.Count > 0)
            {
                pnl_bildirim.Visible = false;
                pnl_bilgi_bankasi.Visible = false;
                pnl_duyuru.Visible = false;
                pnl_grup_kullanici.Visible = false;
                pnl_kara_liste.Visible = false;
                pnl_kopuk.Visible = false;
                pnl_kullanici.Visible = false;
                pnl_vatandas.Visible = false;
                pnl_vip.Visible = false;

                if (cb_tur.Text == "Bildirim Raporları") 
                {
                    pnl_bildirim.Visible = true;
                    Session["Bildirim"] = "Evet";

                    ListBildirimTypedList bil_list = new ListBildirimTypedList();
                    ISortExpression sort22 = new SortExpression();
                    sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filter2 = new PredicateExpression();
                    bil_list.Fill(0, sort22);

                    grid_bildirim.DataSource = bil_list;
                    grid_bildirim.DataBind();

                    KullaniciCollection CollKul = new KullaniciCollection();
                    IPredicateExpression ExpKul = new PredicateExpression();
                    ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                    CollKul.GetMulti(ExpKul);

                    YetkiCollection CollYets = new YetkiCollection();
                    IPredicateExpression ExpYets = new PredicateExpression();
                    ExpYets.AddWithAnd(YetkiFields.YetkiId == CollKul[0].FkYetkiId);
                    CollYets.GetMulti(ExpYets);

                    Session["yetki_durum"] = CollYets[0].YetkiAciklama;

                    if (Session["yetki_durum"].ToString() == "Evet")
                    {
                        grid_bildirim.Columns[2].Visible = true;
                        grid_bildirim.Columns[3].Visible = true;
                        grid_bildirim.Columns[4].Visible = true;
                        grid_bildirim.Columns[5].Visible = true;
                    }

                    else
                    {
                        grid_bildirim.Columns[2].Visible = false;
                        grid_bildirim.Columns[3].Visible = false;
                        grid_bildirim.Columns[4].Visible = false;
                        grid_bildirim.Columns[5].Visible = false;
                    }

                    GrupCollection CollGr = new GrupCollection();
                    IPredicateExpression ExpGr = new PredicateExpression();
                    ExpGr.AddWithAnd(GrupFields.GrupAd == "Hukuk Müşavirliği");
                    CollGr.GetMulti(ExpGr);

                    GrupAtamaCollection CollAta = new GrupAtamaCollection();
                    IPredicateExpression ExpAta = new PredicateExpression();
                    ExpAta.AddWithAnd(GrupAtamaFields.FkGrupId == CollGr[0].GrupId);
                    ExpAta.AddWithAnd(GrupAtamaFields.FkKullaniciId == CollKul[0].KullaniciId);
                    CollAta.GetMulti(ExpAta);

                    if (CollAta.Count > 0)
                    {
                        grid_bildirim.Columns[16].Visible = true;
                        grid_bildirim.Columns[17].Visible = true;
                        grid_bildirim.Columns[18].Visible = true;
                        grid_bildirim.Columns[19].Visible = true;
                    }

                    else
                    {
                        grid_bildirim.Columns[16].Visible = false;
                        grid_bildirim.Columns[17].Visible = false;
                        grid_bildirim.Columns[18].Visible = false;
                        grid_bildirim.Columns[19].Visible = false;
                    }
                }

                else if (cb_tur.Text == "Bilgi Bankası Raporları")
                {                    
                    pnl_bilgi_bankasi.Visible = true;
                    Session["Bilgi"] = "Evet";

                    ListBilgiTypedList eg_snot = new ListBilgiTypedList();
                    ISortExpression sortss = new SortExpression();
                    sortss.Add(new SortClause(BilgiBankasiTurFields.BilgiBankasiTurAd, SortOperator.Ascending));
                    sortss.Add(new SortClause(BilgiBankasiFields.BilgiBankasiAd, SortOperator.Ascending));
                    eg_snot.Fill(0, sortss, true);

                    grid_bilgi.DataSource = eg_snot;
                    grid_bilgi.DataBind();
                }

                else if (cb_tur.Text == "Duyuru Raporları")
                {                                        
                    pnl_duyuru.Visible = true;
                    Session["Duyuru"] = "Evet";

                    ListDuyuruTypedList eg_snot2 = new ListDuyuruTypedList();
                    ISortExpression sortss2 = new SortExpression();
                    sortss2.Add(new SortClause(DuyuruFields.DuyuruYayinTarih, SortOperator.Descending));
                    eg_snot2.Fill(0, sortss2, true);

                    grid_duyuru.DataSource = eg_snot2;
                    grid_duyuru.DataBind();
                }

                else if (cb_tur.Text == "Grup-Kullanıcı Raporları")
                {
                    pnl_grup_kullanici.Visible = true;
                    Session["Grup"] = "Evet";

                    ListGrupAtamaTypedList atama_list = new ListGrupAtamaTypedList();
                    ISortExpression sortatama = new SortExpression();
                    sortatama.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
                    IPredicateExpression filteratama = new PredicateExpression();
                    filteratama.AddWithAnd(GrupAtamaFields.GrupAtamaDurum == true);
                    atama_list.Fill(0, sortatama, true, filteratama);

                    grid_rapor.DataSource = atama_list;
                    grid_rapor.DataBind();
                }

                else if (cb_tur.Text == "Kara Liste Raporları")
                {
                    pnl_kara_liste.Visible = true;
                    Session["Kara"] = "Evet";

                    ListKaraTypedList list_vip = new ListKaraTypedList();
                    ISortExpression sortvip = new SortExpression();
                    sortvip.Add(new SortClause(KaraListeFields.KaraListeIslemTarih, SortOperator.Descending));
                    list_vip.Fill(0, sortvip, true);

                    grid_vip.DataSource = list_vip;
                    grid_vip.DataBind();
                }

                else if (cb_tur.Text == "Köpük Çağrı Raporları")
                {
                    pnl_kopuk.Visible = true;
                    Session["Kopuk"] = "Evet";

                    ListKopukTypedList eg_snott = new ListKopukTypedList();
                    ISortExpression sortsst = new SortExpression();
                    sortsst.Add(new SortClause(KopukCagriFields.KopukCagriTarih, SortOperator.Descending));
                    sortsst.Add(new SortClause(KopukCagriTuruFields.KopukCagriTuruAd, SortOperator.Ascending));
                    eg_snott.Fill(0, sortsst, true);

                    grid_kopuk.DataSource = eg_snott;
                    grid_kopuk.DataBind();
                }

                else if (cb_tur.Text == "Kullanıcı Raporları")
                {
                    pnl_kullanici.Visible = true;
                    Session["Kullanici"] = "Evet";

                    ListKulTypedList eg_snotj = new ListKulTypedList();
                    ISortExpression sortssj = new SortExpression();
                    sortssj.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
                    eg_snotj.Fill(0, sortssj, true);

                    grid_kul.DataSource = eg_snotj;
                    grid_kul.DataBind();
                }

                else if (cb_tur.Text == "Vatandaş/Firma Raporları")
                {
                    pnl_vatandas.Visible = true;
                    Session["Vatandas"] = "Evet";

                    VatandaCollection CollVat = new VatandaCollection();
                    ISortExpression sortssvt = new SortExpression();
                    sortssvt.Add(new SortClause(VatandaFields.VatandasAdSoyad, SortOperator.Ascending));
                    CollVat.GetMulti(null, 0, sortssvt);

                    grid_vatandas.DataSource = CollVat;
                    grid_vatandas.DataBind(); 
                }

                else if (cb_tur.Text == "VIP Liste Raporları")
                {
                    pnl_vip.Visible = true;
                    Session["VIP"] = "Evet";

                    ListVipTypedList list_vips = new ListVipTypedList();
                    ISortExpression sortvips = new SortExpression();
                    sortvips.Add(new SortClause(VipListeFields.VipListeIslemTarih, SortOperator.Descending));
                    list_vips.Fill(0, sortvips, true);

                    grid_vips.DataSource = list_vips;
                    grid_vips.DataBind();
                }
            }

            else 
            {
                string CloseWindow;
                CloseWindow = "alert('Raporu görme yetkiniz bulunmamaktadır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                pnl_bildirim.Visible = false;
                pnl_bilgi_bankasi.Visible = false;
                pnl_duyuru.Visible = false;
                pnl_grup_kullanici.Visible = false;
                pnl_kara_liste.Visible = false;
                pnl_kopuk.Visible = false;
                pnl_kullanici.Visible = false;
                pnl_vatandas.Visible = false;
                pnl_vip.Visible = false;

                cb_tur.Focus();
            }
        }

        protected void btn_pdf_cagri_Click(object sender, EventArgs e)
        {
            string ad = "bildirim_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_bildirim_export.WritePdfToResponse(ad);
        }

        protected void btn_xls_cagri_Click(object sender, EventArgs e)
        {
            string ad = "bildirim_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_bildirim_export.WriteXlsToResponse(ad);
        }

        protected void btn_doc_cagri_Click(object sender, EventArgs e)
        {
            string ad = "bildirim_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_bildirim_export.WriteRtfToResponse(ad);
        }

        protected void k_bil_no_CheckedChanged(object sender, EventArgs e)
        {
            if (k_bil_no.Checked == true)
            {
                grid_bildirim.Columns[1].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[1].Visible = false;
            }
        }

        protected void k_ad222_CheckedChanged(object sender, EventArgs e)
        {
            if (k_ad222.Checked == true)
            {
                grid_bildirim.Columns[2].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[2].Visible = false;
            }
        }

        protected void k_tcsi_CheckedChanged(object sender, EventArgs e)
        {
            if (k_tcsi.Checked == true)
            {
                grid_bildirim.Columns[3].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[3].Visible = false;
            }
        }

        protected void kk_pasaport_CheckedChanged(object sender, EventArgs e)
        {
            if (kk_pasaport.Checked == true)
            {
                grid_bildirim.Columns[4].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[4].Visible = false;
            }
        }

        protected void k_tel22_CheckedChanged(object sender, EventArgs e)
        {
            if (k_tel22.Checked == true)
            {
                grid_bildirim.Columns[5].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[5].Visible = false;
            }
        }

        protected void k_cag_sis_CheckedChanged(object sender, EventArgs e)
        {
            if (k_cag_sis.Checked == true)
            {
                grid_bildirim.Columns[6].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[6].Visible = false;
            }
        }

        protected void k_bil_tur_CheckedChanged(object sender, EventArgs e)
        {
            if (k_bil_tur.Checked == true)
            {
                grid_bildirim.Columns[7].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[7].Visible = false;
            }
        }

        protected void k_bil_sekil_CheckedChanged(object sender, EventArgs e)
        {
            if (k_bil_sekil.Checked == true)
            {
                grid_bildirim.Columns[8].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[8].Visible = false;
            }
        }

        protected void k_konu_CheckedChanged(object sender, EventArgs e)
        {
            if (k_konu.Checked == true)
            {
                grid_bildirim.Columns[9].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[9].Visible = false;
            }
        }

        protected void k_aciklama_CheckedChanged(object sender, EventArgs e)
        {
            if (k_aciklama.Checked == true)
            {
                grid_bildirim.Columns[10].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[10].Visible = false;
            }
        }

        protected void k_notte_CheckedChanged(object sender, EventArgs e)
        {
            if (k_notte.Checked == true)
            {
                grid_bildirim.Columns[11].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[11].Visible = false;
            }
        }

        protected void k_son_tar_CheckedChanged(object sender, EventArgs e)
        {
            if (k_son_tar.Checked == true)
            {
                grid_bildirim.Columns[12].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[12].Visible = false;
            }
        }

        protected void k_sonuc_CheckedChanged(object sender, EventArgs e)
        {
            if (k_sonuc.Checked == true)
            {
                grid_bildirim.Columns[13].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[13].Visible = false;
            }
        }

        protected void k_atanma_CheckedChanged(object sender, EventArgs e)
        {
            if (k_atanma.Checked == true)
            {
                grid_bildirim.Columns[14].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[14].Visible = false;
            }
        }

        protected void k_hav_1_CheckedChanged(object sender, EventArgs e)
        {
            if (k_hav_1.Checked == true)
            {
                grid_bildirim.Columns[15].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[15].Visible = false;
            }
        }

        protected void k_dava_ad_soyad_CheckedChanged(object sender, EventArgs e)
        {
            if (k_dava_ad_soyad.Checked == true)
            {
                grid_bildirim.Columns[16].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[16].Visible = false;
            }
        }

        protected void k_dava_mahkeme_CheckedChanged(object sender, EventArgs e)
        {
            if (k_dava_mahkeme.Checked == true)
            {
                grid_bildirim.Columns[17].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[17].Visible = false;
            }
        }

        protected void k_dava_dosya_no_CheckedChanged(object sender, EventArgs e)
        {
            if (k_dava_dosya_no.Checked == true)
            {
                grid_bildirim.Columns[18].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[18].Visible = false;
            }
        }

        protected void k_dava_konu_CheckedChanged(object sender, EventArgs e)
        {
            if (k_dava_konu.Checked == true)
            {
                grid_bildirim.Columns[19].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[19].Visible = false;
            }
        }

        protected void k_sure_CheckedChanged(object sender, EventArgs e)
        {
            if (k_sure.Checked == true)
            {
                grid_bildirim.Columns[20].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[20].Visible = false;
            }
        }

        protected void k_kar_vatd_CheckedChanged(object sender, EventArgs e)
        {
            if (k_kar_vatd.Checked == true)
            {
                grid_bildirim.Columns[21].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[21].Visible = false;
            }
        }

        protected void k_k_geri_CheckedChanged(object sender, EventArgs e)
        {
            if (k_k_geri.Checked == true)
            {
                grid_bildirim.Columns[22].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[22].Visible = false;
            }
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

        protected void btnPdfExport_d_Click(object sender, EventArgs e)
        {
            string ad = "duyuru_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_duyuru_export.WritePdfToResponse(ad);
        }

        protected void btnXlsExport_d_Click(object sender, EventArgs e)
        {
            string ad = "duyuru_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_duyuru_export.WriteXlsToResponse(ad);
        }

        protected void btnRtfExport_d_Click(object sender, EventArgs e)
        {
            string ad = "duyuru_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_duyuru_export.WriteRtfToResponse(ad);
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

        protected void btnPdfExport_ka_Click(object sender, EventArgs e)
        {
            string ad = "kara_liste_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_vip_export.WritePdfToResponse(ad);
        }

        protected void btnXlsExport_ka_Click(object sender, EventArgs e)
        {
            string ad = "kara_liste_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_vip_export.WriteXlsToResponse(ad);
        }

        protected void btnRtfExport_ka_Click(object sender, EventArgs e)
        {
            string ad = "kara_liste_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_vip_export.WriteRtfToResponse(ad);
        }

        protected void k_ad_soyad_CheckedChanged(object sender, EventArgs e)
        {
            if (k_ad_soyad.Checked == true)
            {
                grid_vip.Columns[1].Visible = true;
            }

            else
            {
                grid_vip.Columns[1].Visible = false;
            }
        }

        protected void k_telefon_CheckedChanged(object sender, EventArgs e)
        {
            if (k_telefon.Checked == true)
            {
                grid_vip.Columns[2].Visible = true;
            }

            else
            {
                grid_vip.Columns[2].Visible = false;
            }
        }

        protected void k_is_kul_CheckedChanged(object sender, EventArgs e)
        {
            if (k_is_kul.Checked == true)
            {
                grid_vip.Columns[3].Visible = true;
            }

            else
            {
                grid_vip.Columns[3].Visible = false;
            }
        }

        protected void k_islem_tar_CheckedChanged(object sender, EventArgs e)
        {
            if (k_islem_tar.Checked == true)
            {
                grid_vip.Columns[4].Visible = true;
            }

            else
            {
                grid_vip.Columns[4].Visible = false;
            }
        }

        protected void k_bas_tar_CheckedChanged(object sender, EventArgs e)
        {
            if (k_bas_tar.Checked == true)
            {
                grid_vip.Columns[5].Visible = true;
            }

            else
            {
                grid_vip.Columns[5].Visible = false;
            }
        }

        protected void k_bit_tar_CheckedChanged(object sender, EventArgs e)
        {
            if (k_bit_tar.Checked == true)
            {
                grid_vip.Columns[6].Visible = true;
            }

            else
            {
                grid_vip.Columns[6].Visible = false;
            }
        }

        protected void k_aciklama_k_CheckedChanged(object sender, EventArgs e)
        {
            if (k_aciklama_k.Checked == true)
            {
                grid_vip.Columns[7].Visible = true;
            }

            else
            {
                grid_vip.Columns[7].Visible = false;
            }
        }

        protected void k_durum_CheckedChanged(object sender, EventArgs e)
        {
            if (k_durum.Checked == true)
            {
                grid_vip.Columns[8].Visible = true;
            }

            else
            {
                grid_vip.Columns[8].Visible = false;
            }
        }

        protected void k_iptal_tar_CheckedChanged(object sender, EventArgs e)
        {
            if (k_iptal_tar.Checked == true)
            {
                grid_vip.Columns[9].Visible = true;
            }

            else
            {
                grid_vip.Columns[9].Visible = false;
            }
        }

        protected void k_iptal_kul_CheckedChanged(object sender, EventArgs e)
        {
            if (k_iptal_kul.Checked == true)
            {
                grid_vip.Columns[10].Visible = true;
            }

            else
            {
                grid_vip.Columns[10].Visible = false;
            }
        }

        protected void grid_vip_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_vip.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void kopuk_pdf_Click(object sender, EventArgs e)
        {
            string ad = "kopuk_cagri_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_kopuk_export.WritePdfToResponse(ad);
        }

        protected void kopuk_xls_Click(object sender, EventArgs e)
        {
            string ad = "kopuk_cagri_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_kopuk_export.WriteXlsToResponse(ad);
        }

        protected void kopuk_doc_Click(object sender, EventArgs e)
        {
            string ad = "kopuk_cagri_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_kopuk_export.WriteRtfToResponse(ad);
        }

        protected void btnPdfExport_kul_Click(object sender, EventArgs e)
        {
            string ad = "kullanici_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            gr_kul_export.WritePdfToResponse(ad);
        }

        protected void btnXlsExport_kul_Click(object sender, EventArgs e)
        {
            string ad = "kullanici_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            gr_kul_export.WriteXlsToResponse(ad);
        }

        protected void btnRtfExport_kul_Click(object sender, EventArgs e)
        {
            string ad = "kullanici_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            gr_kul_export.WriteRtfToResponse(ad);
        }

        protected void grid_kul_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_kul.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void k_ad_CheckedChanged(object sender, EventArgs e)
        {
            if (k_ad.Checked == true)
            {
                grid_kul.Columns[1].Visible = true;
            }

            else
            {
                grid_kul.Columns[1].Visible = false;
            }
        }

        protected void k_soyad_CheckedChanged(object sender, EventArgs e)
        {
            if (k_soyad.Checked == true)
            {
                grid_kul.Columns[2].Visible = true;
            }

            else
            {
                grid_kul.Columns[2].Visible = false;
            }
        }

        protected void k_birt_CheckedChanged(object sender, EventArgs e)
        {
            if (k_birt.Checked == true)
            {
                grid_kul.Columns[3].Visible = true;
            }

            else
            {
                grid_kul.Columns[3].Visible = false;
            }
        }

        protected void k_gorev_CheckedChanged(object sender, EventArgs e)
        {
            if (k_gorev.Checked == true)
            {
                grid_kul.Columns[4].Visible = true;
            }

            else
            {
                grid_kul.Columns[4].Visible = false;
            }
        }

        protected void k_yetki_CheckedChanged(object sender, EventArgs e)
        {
            if (k_yetki.Checked == true)
            {
                grid_kul.Columns[5].Visible = true;
            }

            else
            {
                grid_kul.Columns[5].Visible = false;
            }
        }

        protected void k_hiyerarsi_CheckedChanged(object sender, EventArgs e)
        {
            if (k_hiyerarsi.Checked == true)
            {
                grid_kul.Columns[6].Visible = true;
            }

            else
            {
                grid_kul.Columns[6].Visible = false;
            }
        }

        protected void k_kadi_CheckedChanged(object sender, EventArgs e)
        {
            if (k_kadi.Checked == true)
            {
                grid_kul.Columns[7].Visible = true;
            }

            else
            {
                grid_kul.Columns[7].Visible = false;
            }
        }

        protected void k_mail_CheckedChanged(object sender, EventArgs e)
        {
            if (k_mail.Checked == true)
            {
                grid_kul.Columns[8].Visible = true;
            }

            else
            {
                grid_kul.Columns[8].Visible = false;
            }
        }

        protected void k_aciklama_j_CheckedChanged(object sender, EventArgs e)
        {
            if (k_aciklama_j.Checked == true)
            {
                grid_kul.Columns[9].Visible = true;
            }

            else
            {
                grid_kul.Columns[9].Visible = false;
            }
        }

        protected void k_tar_CheckedChanged(object sender, EventArgs e)
        {
            if (k_tar.Checked == true)
            {
                grid_kul.Columns[10].Visible = true;
            }

            else
            {
                grid_kul.Columns[10].Visible = false;
            }
        }

        protected void k_durum_j_CheckedChanged(object sender, EventArgs e)
        {
            if (k_durum_j.Checked == true)
            {
                grid_kul.Columns[11].Visible = true;
            }

            else
            {
                grid_kul.Columns[11].Visible = false;
            }
        }

        protected void btnPdfExport_vat_Click(object sender, EventArgs e)
        {
            string ad = "vatandas_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_vatandas_export.WritePdfToResponse(ad);
        }

        protected void btnXlsExport_vat_Click(object sender, EventArgs e)
        {
            string ad = "vatandas_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_vatandas_export.WriteXlsToResponse(ad);
        }

        protected void btnRtfExport_vat_Click(object sender, EventArgs e)
        {
            string ad = "vatandas_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_vatandas_export.WriteRtfToResponse(ad);
        }

        protected void k_k_no_CheckedChanged(object sender, EventArgs e)
        {
            if (k_k_no.Checked == true)
            {
                grid_vatandas.Columns[1].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[1].Visible = false;
            }
        }

        protected void k_kay_tur_CheckedChanged(object sender, EventArgs e)
        {
            if (k_kay_tur.Checked == true)
            {
                grid_vatandas.Columns[2].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[2].Visible = false;
            }
        }

        protected void k_tc_no_CheckedChanged(object sender, EventArgs e)
        {
            if (k_tc_no.Checked == true)
            {
                grid_vatandas.Columns[3].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[3].Visible = false;
            }
        }

        protected void k_pasaport_CheckedChanged(object sender, EventArgs e)
        {
            if (k_pasaport.Checked == true)
            {
                grid_vatandas.Columns[4].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[4].Visible = false;
            }
        }

        protected void k_uyruk_CheckedChanged(object sender, EventArgs e)
        {
            if (k_uyruk.Checked == true)
            {
                grid_vatandas.Columns[5].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[5].Visible = false;
            }
        }

        protected void k_ad_vt_CheckedChanged(object sender, EventArgs e)
        {
            if (k_ad_vt.Checked == true)
            {
                grid_vatandas.Columns[6].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[6].Visible = false;
            }
        }

        protected void k_cinsiyet_CheckedChanged(object sender, EventArgs e)
        {
            if (k_cinsiyet.Checked == true)
            {
                grid_vatandas.Columns[7].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[7].Visible = false;
            }
        }

        protected void k_d_tarih_CheckedChanged(object sender, EventArgs e)
        {
            if (k_d_tarih.Checked == true)
            {
                grid_vatandas.Columns[8].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[8].Visible = false;
            }
        }

        protected void k_mail_vt_CheckedChanged(object sender, EventArgs e)
        {
            if (k_mail_vt.Checked == true)
            {
                grid_vatandas.Columns[9].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[9].Visible = false;
            }
        }

        protected void k_tel_CheckedChanged(object sender, EventArgs e)
        {
            if (k_tel.Checked == true)
            {
                grid_vatandas.Columns[10].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[10].Visible = false;
            }
        }

        protected void k_tel_2_CheckedChanged(object sender, EventArgs e)
        {
            if (k_tel_2.Checked == true)
            {
                grid_vatandas.Columns[11].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[11].Visible = false;
            }
        }

        protected void k_not_CheckedChanged(object sender, EventArgs e)
        {
            if (k_not.Checked == true)
            {
                grid_vatandas.Columns[12].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[12].Visible = false;
            }
        }

        protected void k_adres_CheckedChanged(object sender, EventArgs e)
        {
            if (k_adres.Checked == true)
            {
                grid_vatandas.Columns[13].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[13].Visible = false;
            }
        }

        protected void k_i_tarih_CheckedChanged(object sender, EventArgs e)
        {
            if (k_i_tarih.Checked == true)
            {
                grid_vatandas.Columns[14].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[14].Visible = false;
            }
        }

        protected void btnPdfExport_vi_Click(object sender, EventArgs e)
        {
            string ad = "vip_liste_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_vips_export.WritePdfToResponse(ad);
        }

        protected void btnXlsExport_vi_Click(object sender, EventArgs e)
        {
            string ad = "vip_liste_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_vips_export.WriteXlsToResponse(ad);
        }

        protected void btnRtfExport_vi_Click(object sender, EventArgs e)
        {
            string ad = "vip_liste_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_vips_export.WriteRtfToResponse(ad);
        }

        protected void grid_vips_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_vips.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void k_ad_soyadss_CheckedChanged(object sender, EventArgs e)
        {
            if (k_ad_soyadss.Checked == true)
            {
                grid_vips.Columns[1].Visible = true;
            }

            else
            {
                grid_vips.Columns[1].Visible = false;
            }
        }

        protected void k_telefonss_CheckedChanged(object sender, EventArgs e)
        {
            if (k_telefonss.Checked == true)
            {
                grid_vips.Columns[2].Visible = true;
            }

            else
            {
                grid_vips.Columns[2].Visible = false;
            }
        }

        protected void k_is_kulss_CheckedChanged(object sender, EventArgs e)
        {
            if (k_is_kulss.Checked == true)
            {
                grid_vips.Columns[3].Visible = true;
            }

            else
            {
                grid_vips.Columns[3].Visible = false;
            }
        }

        protected void k_islem_tarss_CheckedChanged(object sender, EventArgs e)
        {
            if (k_islem_tarss.Checked == true)
            {
                grid_vips.Columns[4].Visible = true;
            }

            else
            {
                grid_vips.Columns[4].Visible = false;
            }
        }

        protected void k_bas_tarss_CheckedChanged(object sender, EventArgs e)
        {
            if (k_bas_tarss.Checked == true)
            {
                grid_vips.Columns[5].Visible = true;
            }

            else
            {
                grid_vips.Columns[5].Visible = false;
            }
        }

        protected void k_bit_tarss_CheckedChanged(object sender, EventArgs e)
        {
            if (k_bit_tarss.Checked == true)
            {
                grid_vips.Columns[6].Visible = true;
            }

            else
            {
                grid_vips.Columns[6].Visible = false;
            }
        }

        protected void k_aciklamass_CheckedChanged(object sender, EventArgs e)
        {
            if (k_aciklamass.Checked == true)
            {
                grid_vips.Columns[7].Visible = true;
            }

            else
            {
                grid_vips.Columns[7].Visible = false;
            }
        }

        protected void k_durumss_CheckedChanged(object sender, EventArgs e)
        {
            if (k_durumss.Checked == true)
            {
                grid_vips.Columns[8].Visible = true;
            }

            else
            {
                grid_vips.Columns[8].Visible = false;
            }
        }

        protected void k_iptal_tarss_CheckedChanged(object sender, EventArgs e)
        {
            if (k_iptal_tarss.Checked == true)
            {
                grid_vips.Columns[9].Visible = true;
            }

            else
            {
                grid_vips.Columns[9].Visible = false;
            }
        }

        protected void k_iptal_kulss_CheckedChanged(object sender, EventArgs e)
        {
            if (k_iptal_kulss.Checked == true)
            {
                grid_vips.Columns[10].Visible = true;
            }

            else
            {
                grid_vips.Columns[10].Visible = false;
            }
        }
    }
}