using System;
using System.Web.UI;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using dhmi.EntityClasses;
using System.Web;

namespace Dhmi.Web
{
    public partial class ParTurParametreleri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["menu_sec"] = "Parametrik İşlemler";

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

            if (IsPostBack != true)
            {
                Session["guncel_yap"] = "0";

                MenuCollection CollMenu = new MenuCollection();
                IPredicateExpression ExpMenu = new PredicateExpression();
                ExpMenu.AddWithAnd(MenuFields.MenuAd == "Parametrik İşlemler");
                CollMenu.GetMulti(ExpMenu);

                AltMenuCollection CollAlt1 = new AltMenuCollection();
                IPredicateExpression ExpAlt1 = new PredicateExpression();
                ExpAlt1.AddWithAnd(AltMenuFields.AltMenuAd == "Parametre Bilgileri");
                CollAlt1.GetMulti(ExpAlt1);

                AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                IPredicateExpression ExpAlt2 = new PredicateExpression();
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Tür Parametreleri");
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

                Session["id_leri"] = "";

                cb_parametre.Items.Clear();

                TurBankCollection CollBank = new TurBankCollection();
                ISortExpression sortbank = new SortExpression();
                sortbank.Add(new SortClause(TurBankFields.TurBanksAd, SortOperator.Ascending));
                CollBank.GetMulti(null, 0, sortbank);

                for (int i = 0; i < CollBank.Count; i++)
                {
                    cb_parametre.Items.Add(CollBank[i].TurBanksAd);
                }

                cb_parametre.Focus();
            }
        }

        protected void doldur()
        {
            lb_benden.Items.Clear();
            btn_deger_sil.Enabled = false;

            if (cb_parametre.Text == "Rapor Türü")
            {
                RaporTuruCollection CollAsker = new RaporTuruCollection();
                IPredicateExpression ExpAsker = new PredicateExpression();
                ExpAsker.AddWithAnd(RaporTuruFields.RaporTuruDurum == true);
                ISortExpression sorted = new SortExpression();
                sorted.Add(new SortClause(RaporTuruFields.RaporTuruAd, SortOperator.Ascending));
                CollAsker.GetMulti(ExpAsker, 0, sorted);

                for (int i = 0; i < CollAsker.Count; i++)
                {
                    lb_benden.Items.Add(CollAsker[i].RaporTuruAd);
                }
            }

            if (cb_parametre.Text == "Köpük Çağrı Türü")
            {
                KopukCagriTuruCollection CollAsker = new KopukCagriTuruCollection();
                IPredicateExpression ExpAsker = new PredicateExpression();
                ExpAsker.AddWithAnd(KopukCagriTuruFields.KopukCagriTuruDurum == true);
                ISortExpression sorted = new SortExpression();
                sorted.Add(new SortClause(KopukCagriTuruFields.KopukCagriTuruAd, SortOperator.Ascending));
                CollAsker.GetMulti(ExpAsker, 0, sorted);

                for (int i = 0; i < CollAsker.Count; i++)
                {
                    lb_benden.Items.Add(CollAsker[i].KopukCagriTuruAd);
                }
            }

            else if (cb_parametre.Text == "Havalimanı")
            {
                HavalimaniCollection CollAsker = new HavalimaniCollection();
                IPredicateExpression ExpAsker = new PredicateExpression();
                ExpAsker.AddWithAnd(HavalimaniFields.HavalimaniDurum == true);
                ISortExpression sorted = new SortExpression();
                sorted.Add(new SortClause(HavalimaniFields.HavalimaniAd, SortOperator.Ascending));
                CollAsker.GetMulti(ExpAsker, 0, sorted);

                for (int i = 0; i < CollAsker.Count; i++)
                {
                    lb_benden.Items.Add(CollAsker[i].HavalimaniAd);
                }
            }

            else if (cb_parametre.Text == "Gizli Soru Türü")
            {
                GizliSoruTuruCollection CollAsker = new GizliSoruTuruCollection();
                IPredicateExpression ExpAsker = new PredicateExpression();
                ExpAsker.AddWithAnd(GizliSoruTuruFields.GizliSoruTuruDurum == true);
                ISortExpression sorted = new SortExpression();
                sorted.Add(new SortClause(GizliSoruTuruFields.GizliSoruTuruAd, SortOperator.Ascending));
                CollAsker.GetMulti(ExpAsker, 0, sorted);

                for (int i = 0; i < CollAsker.Count; i++)
                {
                    lb_benden.Items.Add(CollAsker[i].GizliSoruTuruAd);
                }
            }

            else if (cb_parametre.Text == "Çağrı Tipi")
            {
                CagriTipiCollection CollAsker = new CagriTipiCollection();
                IPredicateExpression ExpAsker = new PredicateExpression();
                ExpAsker.AddWithAnd(CagriTipiFields.CagriTipiDurum == true);
                ISortExpression sorted = new SortExpression();
                sorted.Add(new SortClause(CagriTipiFields.CagriTipiAd, SortOperator.Ascending));
                CollAsker.GetMulti(ExpAsker, 0, sorted);

                for (int i = 0; i < CollAsker.Count; i++)
                {
                    lb_benden.Items.Add(CollAsker[i].CagriTipiAd);
                }
            }

            else if (cb_parametre.Text == "Bildirim Geri Dönüş Türü")
            {
                BildirimGeriDonuCollection CollAsker = new BildirimGeriDonuCollection();
                ISortExpression sorted = new SortExpression();
                sorted.Add(new SortClause(BildirimGeriDonuFields.BildirimGeriDonusAd, SortOperator.Ascending));
                CollAsker.GetMulti(null, 0, sorted);

                for (int i = 0; i < CollAsker.Count; i++)
                {
                    lb_benden.Items.Add(CollAsker[i].BildirimGeriDonusAd);
                }
            }

            else if (cb_parametre.Text == "Bildirim İşlem Türü")
            {
                BildirimIslemCollection CollAsker = new BildirimIslemCollection();
                IPredicateExpression ExpAsker = new PredicateExpression();
                ExpAsker.AddWithAnd(BildirimIslemFields.BildirimIslemDurum == true);
                ISortExpression sorted = new SortExpression();
                sorted.Add(new SortClause(BildirimIslemFields.BildirimIslemAd, SortOperator.Ascending));
                CollAsker.GetMulti(ExpAsker, 0, sorted);

                for (int i = 0; i < CollAsker.Count; i++)
                {
                    lb_benden.Items.Add(CollAsker[i].BildirimIslemAd);
                }
            }

            else if (cb_parametre.Text == "Bildirim Sonuç Türü")
            {
                BildirimSonucCollection CollAsker = new BildirimSonucCollection();
                IPredicateExpression ExpAsker = new PredicateExpression();
                ExpAsker.AddWithAnd(BildirimSonucFields.BildirimSonucDurum == true);
                ISortExpression sorted = new SortExpression();
                sorted.Add(new SortClause(BildirimSonucFields.BildirimSonucAd, SortOperator.Ascending));
                CollAsker.GetMulti(ExpAsker, 0, sorted);

                for (int i = 0; i < CollAsker.Count; i++)
                {
                    lb_benden.Items.Add(CollAsker[i].BildirimSonucAd);
                }
            }

            else if (cb_parametre.Text == "Bilgi Bankasi Türü")
            {
                BilgiBankasiTurCollection CollAsker = new BilgiBankasiTurCollection();
                IPredicateExpression ExpAsker = new PredicateExpression();
                ExpAsker.AddWithAnd(BilgiBankasiTurFields.BilgiBankasiTurDurum == true);
                ISortExpression sorted = new SortExpression();
                sorted.Add(new SortClause(BilgiBankasiTurFields.BilgiBankasiTurAd, SortOperator.Ascending));
                CollAsker.GetMulti(ExpAsker, 0, sorted);

                for (int i = 0; i < CollAsker.Count; i++)
                {
                    lb_benden.Items.Add(CollAsker[i].BilgiBankasiTurAd);
                }
            }

            else if (cb_parametre.Text == "Görev Türü")
            {
                GorevCollection CollAsker = new GorevCollection();
                IPredicateExpression ExpAsker = new PredicateExpression();
                ExpAsker.AddWithAnd(GorevFields.GorevDurum == true);
                ISortExpression sorted = new SortExpression();
                sorted.Add(new SortClause(GorevFields.GorevAd, SortOperator.Ascending));
                CollAsker.GetMulti(ExpAsker, 0, sorted);

                for (int i = 0; i < CollAsker.Count; i++)
                {
                    lb_benden.Items.Add(CollAsker[i].GorevAd);
                }
            }

            else if (cb_parametre.Text == "Hiyerarşi Türü")
            {
                HiyerarsiTurCollection CollAsker = new HiyerarsiTurCollection();
                IPredicateExpression ExpAsker = new PredicateExpression();
                ExpAsker.AddWithAnd(HiyerarsiTurFields.HiyerarsiTurDurum == true);
                ISortExpression sorted = new SortExpression();
                sorted.Add(new SortClause(HiyerarsiTurFields.HiyerarsiTurAd, SortOperator.Ascending));
                CollAsker.GetMulti(ExpAsker, 0, sorted);

                for (int i = 0; i < CollAsker.Count; i++)
                {
                    lb_benden.Items.Add(CollAsker[i].HiyerarsiTurAd);
                }
            }

            else if (cb_parametre.Text == "Kapatma Türü")
            {
                KapatmaTurCollection CollAsker = new KapatmaTurCollection();
                IPredicateExpression ExpAsker = new PredicateExpression();
                ExpAsker.AddWithAnd(KapatmaTurFields.KapatmaTurDurum == true);
                ISortExpression sorted = new SortExpression();
                sorted.Add(new SortClause(KapatmaTurFields.KapatmaTurAd, SortOperator.Ascending));
                CollAsker.GetMulti(ExpAsker, 0, sorted);

                for (int i = 0; i < CollAsker.Count; i++)
                {
                    lb_benden.Items.Add(CollAsker[i].KapatmaTurAd);
                }
            }

            else if (cb_parametre.Text == "Sorun Türü")
            {
                SorunTuruCollection CollAsker = new SorunTuruCollection();
                IPredicateExpression ExpAsker = new PredicateExpression();
                ExpAsker.AddWithAnd(SorunTuruFields.SorunTuruDurum == true);
                ISortExpression sorted = new SortExpression();
                sorted.Add(new SortClause(SorunTuruFields.SorunTuruAd, SortOperator.Ascending));
                CollAsker.GetMulti(ExpAsker, 0, sorted);

                for (int i = 0; i < CollAsker.Count; i++)
                {
                    lb_benden.Items.Add(CollAsker[i].SorunTuruAd);
                }
            }

            else if (cb_parametre.Text == "İşlem Türü")
            {
                IslemTuruCollection CollAsker = new IslemTuruCollection();
                IPredicateExpression ExpAsker = new PredicateExpression();
                ExpAsker.AddWithAnd(IslemTuruFields.IslemTuruDurum == true);
                ISortExpression sorted = new SortExpression();
                sorted.Add(new SortClause(IslemTuruFields.IslemTuruAd, SortOperator.Ascending));
                CollAsker.GetMulti(ExpAsker, 0, sorted);

                for (int i = 0; i < CollAsker.Count; i++)
                {
                    lb_benden.Items.Add(CollAsker[i].IslemTuruAd);
                }
            }
        }

        protected void cb_parametre_SelectedIndexChanged(object sender, EventArgs e)
        {
            doldur();
            Session["guncel_yap"] = "0";
            txt_deger.Text = "";
        }

        protected void lb_benden_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_deger_sil.Enabled = true;
            Session["id_leri"] = "";
            Session["guncel_yap"] = "1";

            try
            {
                txt_deger.Text = lb_benden.SelectedItem.ToString();

                if (cb_parametre.Text == "Rapor Türü")
                {
                    RaporTuruCollection CollAsker = new RaporTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(RaporTuruFields.RaporTuruAd == lb_benden.SelectedItem.ToString());
                    CollAsker.GetMulti(ExpAsker);

                    Session["id_leri"] = CollAsker[0].RaporTuruId.ToString();
                }

                if (cb_parametre.Text == "Köpük Çağrı Türü")
                {
                    KopukCagriTuruCollection CollAsker = new KopukCagriTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(KopukCagriTuruFields.KopukCagriTuruAd == lb_benden.SelectedItem.ToString());
                    CollAsker.GetMulti(ExpAsker);

                    Session["id_leri"] = CollAsker[0].KopukCagriTuruId.ToString();
                }

                else if (cb_parametre.Text == "Havalimanı")
                {
                    HavalimaniCollection CollAsker = new HavalimaniCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(HavalimaniFields.HavalimaniAd == lb_benden.SelectedItem.ToString());
                    CollAsker.GetMulti(ExpAsker);

                    Session["id_leri"] = CollAsker[0].HavalimaniId.ToString();
                }

                else if (cb_parametre.Text == "Gizli Soru Türü")
                {
                    GizliSoruTuruCollection CollAsker = new GizliSoruTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(GizliSoruTuruFields.GizliSoruTuruAd == lb_benden.SelectedItem.ToString());
                    CollAsker.GetMulti(ExpAsker);

                    Session["id_leri"] = CollAsker[0].GizliSoruTuruId.ToString();
                }

                else if (cb_parametre.Text == "Çağrı Tipi")
                {
                    CagriTipiCollection CollAsker = new CagriTipiCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(CagriTipiFields.CagriTipiAd == lb_benden.SelectedItem.ToString());
                    CollAsker.GetMulti(ExpAsker);

                    Session["id_leri"] = CollAsker[0].CagriTipiId.ToString();
                }

                else if (cb_parametre.Text == "Bildirim Geri Dönüş Türü")
                {
                    BildirimGeriDonuCollection CollAsker = new BildirimGeriDonuCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusAd == lb_benden.SelectedItem.ToString());
                    CollAsker.GetMulti(ExpAsker);

                    Session["id_leri"] = CollAsker[0].BildirimGeriDonusId.ToString();
                }

                else if (cb_parametre.Text == "Bildirim İşlem Türü")
                {
                    BildirimIslemCollection CollAsker = new BildirimIslemCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(BildirimIslemFields.BildirimIslemAd == lb_benden.SelectedItem.ToString());
                    CollAsker.GetMulti(ExpAsker);

                    Session["id_leri"] = CollAsker[0].BildirimIslemId.ToString();
                }

                else if (cb_parametre.Text == "Bildirim Sonuç Türü")
                {
                    BildirimSonucCollection CollAsker = new BildirimSonucCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(BildirimSonucFields.BildirimSonucAd == lb_benden.SelectedItem.ToString());
                    CollAsker.GetMulti(ExpAsker);

                    Session["id_leri"] = CollAsker[0].BildirimSonucId.ToString();
                }

                else if (cb_parametre.Text == "Bilgi Bankasi Türü")
                {
                    BilgiBankasiTurCollection CollAsker = new BilgiBankasiTurCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(BilgiBankasiTurFields.BilgiBankasiTurAd == lb_benden.SelectedItem.ToString());
                    CollAsker.GetMulti(ExpAsker);

                    Session["id_leri"] = CollAsker[0].BilgiBankasiTurId.ToString();
                }

                else if (cb_parametre.Text == "Görev Türü")
                {
                    GorevCollection CollAsker = new GorevCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(GorevFields.GorevAd == lb_benden.SelectedItem.ToString());
                    CollAsker.GetMulti(ExpAsker);

                    Session["id_leri"] = CollAsker[0].GorevId.ToString();
                }

                else if (cb_parametre.Text == "Hiyerarşi Türü")
                {
                    HiyerarsiTurCollection CollAsker = new HiyerarsiTurCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(HiyerarsiTurFields.HiyerarsiTurAd == lb_benden.SelectedItem.ToString());
                    CollAsker.GetMulti(ExpAsker);

                    Session["id_leri"] = CollAsker[0].HiyerarsiTurId.ToString();
                }

                else if (cb_parametre.Text == "Kapatma Türü")
                {
                    KapatmaTurCollection CollAsker = new KapatmaTurCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(KapatmaTurFields.KapatmaTurAd == lb_benden.SelectedItem.ToString());
                    CollAsker.GetMulti(ExpAsker);

                    Session["id_leri"] = CollAsker[0].KapatmaTurId.ToString();
                }

                else if (cb_parametre.Text == "Sorun Türü")
                {
                    SorunTuruCollection CollAsker = new SorunTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(SorunTuruFields.SorunTuruAd == lb_benden.SelectedItem.ToString());
                    CollAsker.GetMulti(ExpAsker);

                    Session["id_leri"] = CollAsker[0].SorunTuruId.ToString();
                }

                else if (cb_parametre.Text == "İşlem Türü")
                {
                    IslemTuruCollection CollAsker = new IslemTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(IslemTuruFields.IslemTuruAd == lb_benden.SelectedItem.ToString());
                    CollAsker.GetMulti(ExpAsker);

                    Session["id_leri"] = CollAsker[0].IslemTuruId.ToString();
                }
            }

            catch
            {
                Session["id_leri"] = "";
                Session["guncel_yap"] = "0";
            }
        }

        protected void btn_deger_ekle_Click(object sender, EventArgs e)
        {
            if (cb_parametre.Text == "Rapor Türü")
            {
                if (Session["guncel_yap"].ToString() == "0")
                {
                    RaporTuruCollection CollAsker = new RaporTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(RaporTuruFields.RaporTuruAd == txt_deger.Text);
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count > 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        txt_deger.Focus();
                    }

                    else
                    {
                        RaporTuruEntity EntKay = new RaporTuruEntity();
                        EntKay.RaporTuruAd = txt_deger.Text;
                        EntKay.RaporTuruTarih = DateTime.Now;
                        EntKay.RaporTuruDurum = true;
                        EntKay.Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Kayıt işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else
                {
                    RaporTuruCollection CollAsker = new RaporTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(RaporTuruFields.RaporTuruId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker[0].RaporTuruAd == txt_deger.Text)
                    {
                        CollAsker[0].RaporTuruAd = txt_deger.Text;
                        CollAsker[0].RaporTuruTarih = DateTime.Now;
                        CollAsker[0].RaporTuruDurum = true;
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }

                    else
                    {
                        RaporTuruCollection CollAra = new RaporTuruCollection();
                        IPredicateExpression ExpAra = new PredicateExpression();
                        ExpAra.AddWithAnd(RaporTuruFields.RaporTuruAd == txt_deger.Text);
                        CollAra.GetMulti(ExpAra);

                        if (CollAra.Count > 0)
                        {
                            string CloseWindow2;
                            CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                        }

                        else
                        {
                            CollAsker[0].RaporTuruAd = txt_deger.Text;
                            CollAsker[0].RaporTuruTarih = DateTime.Now;
                            CollAsker[0].RaporTuruDurum = true;
                            CollAsker[0].Save();

                            string CloseWindow2;
                            CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                            Session["guncel_yap"] = "0";

                            doldur();

                            txt_deger.Text = "";
                        }
                    }
                }
            }

            if (cb_parametre.Text == "Köpük Çağrı Türü")
            {
                if (Session["guncel_yap"].ToString() == "0")
                {
                    KopukCagriTuruCollection CollAsker = new KopukCagriTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(KopukCagriTuruFields.KopukCagriTuruAd == txt_deger.Text);
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count > 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        txt_deger.Focus();
                    }

                    else
                    {
                        KopukCagriTuruEntity EntKay = new KopukCagriTuruEntity();
                        EntKay.KopukCagriTuruAd = txt_deger.Text;
                        EntKay.KopukCagriTuruTarih = DateTime.Now;
                        EntKay.KopukCagriTuruDurum = true;
                        EntKay.Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Kayıt işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else
                {
                    KopukCagriTuruCollection CollAsker = new KopukCagriTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(KopukCagriTuruFields.KopukCagriTuruId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker[0].KopukCagriTuruAd == txt_deger.Text)
                    {
                        CollAsker[0].KopukCagriTuruAd = txt_deger.Text;
                        CollAsker[0].KopukCagriTuruTarih = DateTime.Now;
                        CollAsker[0].KopukCagriTuruDurum = true;
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }

                    else
                    {
                        KopukCagriTuruCollection CollAra = new KopukCagriTuruCollection();
                        IPredicateExpression ExpAra = new PredicateExpression();
                        ExpAra.AddWithAnd(KopukCagriTuruFields.KopukCagriTuruAd == txt_deger.Text);
                        CollAra.GetMulti(ExpAra);

                        if (CollAra.Count > 0)
                        {
                            string CloseWindow2;
                            CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                        }

                        else
                        {
                            CollAsker[0].KopukCagriTuruAd = txt_deger.Text;
                            CollAsker[0].KopukCagriTuruTarih = DateTime.Now;
                            CollAsker[0].KopukCagriTuruDurum = true;
                            CollAsker[0].Save();

                            string CloseWindow2;
                            CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                            Session["guncel_yap"] = "0";

                            doldur();

                            txt_deger.Text = "";
                        }
                    }
                }
            }

            else if (cb_parametre.Text == "Havalimanı")
            {
                if (Session["guncel_yap"].ToString() == "0")
                {
                    HavalimaniCollection CollAsker = new HavalimaniCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(HavalimaniFields.HavalimaniAd == txt_deger.Text);
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count > 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        txt_deger.Focus();
                    }

                    else
                    {
                        HavalimaniEntity EntKay = new HavalimaniEntity();
                        EntKay.HavalimaniAd = txt_deger.Text;
                        EntKay.HavalimaniTarih = DateTime.Now;
                        EntKay.HavalimaniDurum = true;
                        EntKay.Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Kayıt işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else
                {
                    HavalimaniCollection CollAsker = new HavalimaniCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(HavalimaniFields.HavalimaniId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker[0].HavalimaniAd == txt_deger.Text)
                    {
                        CollAsker[0].HavalimaniAd = txt_deger.Text;
                        CollAsker[0].HavalimaniTarih = DateTime.Now;
                        CollAsker[0].HavalimaniDurum = true;
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }

                    else
                    {
                        HavalimaniCollection CollAra = new HavalimaniCollection();
                        IPredicateExpression ExpAra = new PredicateExpression();
                        ExpAra.AddWithAnd(HavalimaniFields.HavalimaniAd == txt_deger.Text);
                        CollAra.GetMulti(ExpAra);

                        if (CollAra.Count > 0)
                        {
                            string CloseWindow2;
                            CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                        }

                        else
                        {
                            CollAsker[0].HavalimaniAd = txt_deger.Text;
                            CollAsker[0].HavalimaniTarih = DateTime.Now;
                            CollAsker[0].HavalimaniDurum = true;
                            CollAsker[0].Save();

                            string CloseWindow2;
                            CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                            Session["guncel_yap"] = "0";

                            doldur();

                            txt_deger.Text = "";
                        }
                    }
                }
            }

            else if (cb_parametre.Text == "Gizli Soru Türü")
            {
                if (Session["guncel_yap"].ToString() == "0")
                {
                    GizliSoruTuruCollection CollAsker = new GizliSoruTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(GizliSoruTuruFields.GizliSoruTuruAd == txt_deger.Text);
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count > 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        txt_deger.Focus();
                    }

                    else
                    {
                        GizliSoruTuruEntity EntKay = new GizliSoruTuruEntity();
                        EntKay.GizliSoruTuruAd = txt_deger.Text;
                        EntKay.GizliSoruTuruTarih = DateTime.Now;
                        EntKay.GizliSoruTuruDurum = true;
                        EntKay.Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Kayıt işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else
                {
                    GizliSoruTuruCollection CollAsker = new GizliSoruTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(GizliSoruTuruFields.GizliSoruTuruId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker[0].GizliSoruTuruAd == txt_deger.Text)
                    {
                        CollAsker[0].GizliSoruTuruAd = txt_deger.Text;
                        CollAsker[0].GizliSoruTuruTarih = DateTime.Now;
                        CollAsker[0].GizliSoruTuruDurum = true;
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }

                    else
                    {
                        GizliSoruTuruCollection CollAra = new GizliSoruTuruCollection();
                        IPredicateExpression ExpAra = new PredicateExpression();
                        ExpAra.AddWithAnd(GizliSoruTuruFields.GizliSoruTuruAd == txt_deger.Text);
                        CollAra.GetMulti(ExpAra);

                        if (CollAra.Count > 0)
                        {
                            string CloseWindow2;
                            CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                        }

                        else
                        {
                            CollAsker[0].GizliSoruTuruAd = txt_deger.Text;
                            CollAsker[0].GizliSoruTuruTarih = DateTime.Now;
                            CollAsker[0].GizliSoruTuruDurum = true;
                            CollAsker[0].Save();

                            string CloseWindow2;
                            CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                            Session["guncel_yap"] = "0";

                            doldur();

                            txt_deger.Text = "";
                        }
                    }
                }
            }

            else if (cb_parametre.Text == "Çağrı Tipi")
            {
                if (Session["guncel_yap"].ToString() == "0")
                {
                    CagriTipiCollection CollAsker = new CagriTipiCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(CagriTipiFields.CagriTipiAd == txt_deger.Text);
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count > 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        txt_deger.Focus();
                    }

                    else
                    {
                        CagriTipiEntity EntKay = new CagriTipiEntity();
                        EntKay.CagriTipiAd = txt_deger.Text;
                        EntKay.CagriTipiTarih = DateTime.Now;
                        EntKay.CagriTipiDurum = true;
                        EntKay.Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Kayıt işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else
                {
                    CagriTipiCollection CollAsker = new CagriTipiCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(CagriTipiFields.CagriTipiId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker[0].CagriTipiAd == txt_deger.Text)
                    {
                        CollAsker[0].CagriTipiAd = txt_deger.Text;
                        CollAsker[0].CagriTipiTarih = DateTime.Now;
                        CollAsker[0].CagriTipiDurum = true;
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }

                    else
                    {
                        CagriTipiCollection CollAra = new CagriTipiCollection();
                        IPredicateExpression ExpAra = new PredicateExpression();
                        ExpAra.AddWithAnd(CagriTipiFields.CagriTipiAd == txt_deger.Text);
                        CollAra.GetMulti(ExpAra);

                        if (CollAra.Count > 0)
                        {
                            string CloseWindow2;
                            CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                        }

                        else
                        {
                            CollAsker[0].CagriTipiAd = txt_deger.Text;
                            CollAsker[0].CagriTipiTarih = DateTime.Now;
                            CollAsker[0].CagriTipiDurum = true;
                            CollAsker[0].Save();

                            string CloseWindow2;
                            CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                            Session["guncel_yap"] = "0";

                            doldur();

                            txt_deger.Text = "";
                        }
                    }
                }
            }

            else if (cb_parametre.Text == "Bildirim Geri Dönüş Türü")
            {
                if (Session["guncel_yap"].ToString() == "0")
                {
                    BildirimGeriDonuCollection CollAsker = new BildirimGeriDonuCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusAd == txt_deger.Text);
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count > 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        txt_deger.Focus();
                    }

                    else
                    {
                        BildirimGeriDonuEntity EntKay = new BildirimGeriDonuEntity();
                        EntKay.BildirimGeriDonusAd = txt_deger.Text;
                        EntKay.BildirimGeriDonusTarih = DateTime.Now;
                        EntKay.BildirimGeriDonusTur = true;
                        EntKay.Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Kayıt işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else
                {
                    BildirimGeriDonuCollection CollAsker = new BildirimGeriDonuCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker[0].BildirimGeriDonusAd == txt_deger.Text)
                    {
                        CollAsker[0].BildirimGeriDonusAd = txt_deger.Text;
                        CollAsker[0].BildirimGeriDonusTarih = DateTime.Now;
                        CollAsker[0].BildirimGeriDonusTur = true;
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }

                    else
                    {
                        BildirimGeriDonuCollection CollAra = new BildirimGeriDonuCollection();
                        IPredicateExpression ExpAra = new PredicateExpression();
                        ExpAra.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusAd == txt_deger.Text);
                        CollAra.GetMulti(ExpAra);

                        if (CollAra.Count > 0)
                        {
                            string CloseWindow2;
                            CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                        }

                        else
                        {
                            CollAsker[0].BildirimGeriDonusAd = txt_deger.Text;
                            CollAsker[0].BildirimGeriDonusTarih = DateTime.Now;
                            CollAsker[0].BildirimGeriDonusTur = true;
                            CollAsker[0].Save();

                            string CloseWindow2;
                            CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                            Session["guncel_yap"] = "0";

                            doldur();

                            txt_deger.Text = "";
                        }
                    }
                }
            }

            else if (cb_parametre.Text == "Bildirim İşlem Türü")
            {
                if (Session["guncel_yap"].ToString() == "0")
                {
                    BildirimIslemCollection CollAsker = new BildirimIslemCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(BildirimIslemFields.BildirimIslemAd == txt_deger.Text);
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count > 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        txt_deger.Focus();
                    }

                    else
                    {
                        BildirimIslemEntity EntKay = new BildirimIslemEntity();
                        EntKay.BildirimIslemAd = txt_deger.Text;
                        EntKay.BildirimIslemTarih = DateTime.Now;
                        EntKay.BildirimIslemDurum = true;
                        EntKay.Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Kayıt işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else
                {
                    BildirimIslemCollection CollAsker = new BildirimIslemCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(BildirimIslemFields.BildirimIslemId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker[0].BildirimIslemAd == txt_deger.Text)
                    {
                        CollAsker[0].BildirimIslemAd = txt_deger.Text;
                        CollAsker[0].BildirimIslemTarih = DateTime.Now;
                        CollAsker[0].BildirimIslemDurum = true;
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }

                    else
                    {
                        BildirimIslemCollection CollAra = new BildirimIslemCollection();
                        IPredicateExpression ExpAra = new PredicateExpression();
                        ExpAra.AddWithAnd(BildirimIslemFields.BildirimIslemAd == txt_deger.Text);
                        CollAra.GetMulti(ExpAra);

                        if (CollAra.Count > 0)
                        {
                            string CloseWindow2;
                            CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                        }

                        else
                        {
                            CollAsker[0].BildirimIslemAd = txt_deger.Text;
                            CollAsker[0].BildirimIslemTarih = DateTime.Now;
                            CollAsker[0].BildirimIslemDurum = true;
                            CollAsker[0].Save();

                            string CloseWindow2;
                            CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                            Session["guncel_yap"] = "0";

                            doldur();

                            txt_deger.Text = "";
                        }
                    }
                }
            }

            else if (cb_parametre.Text == "Bildirim Sonuç Türü")
            {
                if (Session["guncel_yap"].ToString() == "0")
                {
                    BildirimSonucCollection CollAsker = new BildirimSonucCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(BildirimSonucFields.BildirimSonucAd == txt_deger.Text);
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count > 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        txt_deger.Focus();
                    }

                    else
                    {
                        BildirimSonucEntity EntKay = new BildirimSonucEntity();
                        EntKay.BildirimSonucAd = txt_deger.Text;
                        EntKay.BildirimSonucTarih = DateTime.Now;
                        EntKay.BildirimSonucDurum = true;
                        EntKay.Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Kayıt işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else
                {
                    BildirimSonucCollection CollAsker = new BildirimSonucCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(BildirimSonucFields.BildirimSonucId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker[0].BildirimSonucAd == txt_deger.Text)
                    {
                        CollAsker[0].BildirimSonucAd = txt_deger.Text;
                        CollAsker[0].BildirimSonucTarih = DateTime.Now;
                        CollAsker[0].BildirimSonucDurum = true;
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }

                    else
                    {
                        BildirimSonucCollection CollAra = new BildirimSonucCollection();
                        IPredicateExpression ExpAra = new PredicateExpression();
                        ExpAra.AddWithAnd(BildirimSonucFields.BildirimSonucAd == txt_deger.Text);
                        CollAra.GetMulti(ExpAra);

                        if (CollAra.Count > 0)
                        {
                            string CloseWindow2;
                            CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                        }

                        else
                        {
                            CollAsker[0].BildirimSonucAd = txt_deger.Text;
                            CollAsker[0].BildirimSonucTarih = DateTime.Now;
                            CollAsker[0].BildirimSonucDurum = true;
                            CollAsker[0].Save();

                            string CloseWindow2;
                            CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                            Session["guncel_yap"] = "0";

                            doldur();

                            txt_deger.Text = "";
                        }
                    }
                }
            }

            else if (cb_parametre.Text == "Bilgi Bankasi Türü")
            {
                if (Session["guncel_yap"].ToString() == "0")
                {
                    BilgiBankasiTurCollection CollAsker = new BilgiBankasiTurCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(BilgiBankasiTurFields.BilgiBankasiTurAd == txt_deger.Text);
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count > 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        txt_deger.Focus();
                    }

                    else
                    {
                        BilgiBankasiTurEntity EntKay = new BilgiBankasiTurEntity();
                        EntKay.BilgiBankasiTurAd = txt_deger.Text;
                        EntKay.BilgiBankasiTurTarih = DateTime.Now;
                        EntKay.BilgiBankasiTurDurum = true;
                        EntKay.Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Kayıt işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else
                {
                    BilgiBankasiTurCollection CollAsker = new BilgiBankasiTurCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(BilgiBankasiTurFields.BilgiBankasiTurId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker[0].BilgiBankasiTurAd == txt_deger.Text)
                    {
                        CollAsker[0].BilgiBankasiTurAd = txt_deger.Text;
                        CollAsker[0].BilgiBankasiTurTarih = DateTime.Now;
                        CollAsker[0].BilgiBankasiTurDurum = true;
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }

                    else
                    {
                        BilgiBankasiTurCollection CollAra = new BilgiBankasiTurCollection();
                        IPredicateExpression ExpAra = new PredicateExpression();
                        ExpAra.AddWithAnd(BilgiBankasiTurFields.BilgiBankasiTurAd == txt_deger.Text);
                        CollAra.GetMulti(ExpAra);

                        if (CollAra.Count > 0)
                        {
                            string CloseWindow2;
                            CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                        }

                        else
                        {
                            CollAsker[0].BilgiBankasiTurAd = txt_deger.Text;
                            CollAsker[0].BilgiBankasiTurTarih = DateTime.Now;
                            CollAsker[0].BilgiBankasiTurDurum = true;
                            CollAsker[0].Save();

                            string CloseWindow2;
                            CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                            Session["guncel_yap"] = "0";

                            doldur();

                            txt_deger.Text = "";
                        }
                    }
                }
            }

            else if (cb_parametre.Text == "Görev Türü")
            {
                if (Session["guncel_yap"].ToString() == "0")
                {
                    GorevCollection CollAsker = new GorevCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(GorevFields.GorevAd == txt_deger.Text);
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count > 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        txt_deger.Focus();
                    }

                    else
                    {
                        GorevEntity EntKay = new GorevEntity();
                        EntKay.GorevAd = txt_deger.Text;
                        EntKay.GorevTarih = DateTime.Now;
                        EntKay.GorevDurum = true;
                        EntKay.Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Kayıt işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else
                {
                    GorevCollection CollAsker = new GorevCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(GorevFields.GorevId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker[0].GorevAd == txt_deger.Text)
                    {
                        CollAsker[0].GorevAd = txt_deger.Text;
                        CollAsker[0].GorevTarih = DateTime.Now;
                        CollAsker[0].GorevDurum = true;
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }

                    else
                    {
                        GorevCollection CollAra = new GorevCollection();
                        IPredicateExpression ExpAra = new PredicateExpression();
                        ExpAra.AddWithAnd(GorevFields.GorevAd == txt_deger.Text);
                        CollAra.GetMulti(ExpAra);

                        if (CollAra.Count > 0)
                        {
                            string CloseWindow2;
                            CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                        }

                        else
                        {
                            CollAsker[0].GorevAd = txt_deger.Text;
                            CollAsker[0].GorevTarih = DateTime.Now;
                            CollAsker[0].GorevDurum = true;
                            CollAsker[0].Save();

                            string CloseWindow2;
                            CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                            Session["guncel_yap"] = "0";

                            doldur();

                            txt_deger.Text = "";
                        }
                    }
                }
            }

            else if (cb_parametre.Text == "Hiyerarşi Türü")
            {
                if (Session["guncel_yap"].ToString() == "0")
                {
                    HiyerarsiTurCollection CollAsker = new HiyerarsiTurCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(HiyerarsiTurFields.HiyerarsiTurAd == txt_deger.Text);
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count > 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        txt_deger.Focus();
                    }

                    else
                    {
                        HiyerarsiTurEntity EntKay = new HiyerarsiTurEntity();
                        EntKay.HiyerarsiTurAd = txt_deger.Text;
                        EntKay.HiyerarsiTurTarih = DateTime.Now;
                        EntKay.HiyerarsiTurSira = 1;
                        EntKay.HiyerarsiTurDurum = true;
                        EntKay.Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Kayıt işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else
                {
                    HiyerarsiTurCollection CollAsker = new HiyerarsiTurCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(HiyerarsiTurFields.HiyerarsiTurId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker[0].HiyerarsiTurAd == txt_deger.Text)
                    {
                        CollAsker[0].HiyerarsiTurAd = txt_deger.Text;
                        CollAsker[0].HiyerarsiTurTarih = DateTime.Now;
                        CollAsker[0].HiyerarsiTurDurum = true;
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }

                    else
                    {
                        HiyerarsiTurCollection CollAra = new HiyerarsiTurCollection();
                        IPredicateExpression ExpAra = new PredicateExpression();
                        ExpAra.AddWithAnd(HiyerarsiTurFields.HiyerarsiTurAd == txt_deger.Text);
                        CollAra.GetMulti(ExpAra);

                        if (CollAra.Count > 0)
                        {
                            string CloseWindow2;
                            CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                        }

                        else
                        {
                            CollAsker[0].HiyerarsiTurAd = txt_deger.Text;
                            CollAsker[0].HiyerarsiTurTarih = DateTime.Now;
                            CollAsker[0].HiyerarsiTurDurum = true;
                            CollAsker[0].Save();

                            string CloseWindow2;
                            CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                            Session["guncel_yap"] = "0";

                            doldur();

                            txt_deger.Text = "";
                        }
                    }
                }
            }

            else if (cb_parametre.Text == "Kapatma Türü")
            {
                if (Session["guncel_yap"].ToString() == "0")
                {
                    KapatmaTurCollection CollAsker = new KapatmaTurCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(KapatmaTurFields.KapatmaTurAd == txt_deger.Text);
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count > 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        txt_deger.Focus();
                    }

                    else
                    {
                        KapatmaTurEntity EntKay = new KapatmaTurEntity();
                        EntKay.KapatmaTurAd = txt_deger.Text;
                        EntKay.KapatmaTurTarih = DateTime.Now;
                        EntKay.KapatmaTurDurum = true;
                        EntKay.Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Kayıt işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else
                {
                    KapatmaTurCollection CollAsker = new KapatmaTurCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(KapatmaTurFields.KapatmaTurId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker[0].KapatmaTurAd == txt_deger.Text)
                    {
                        CollAsker[0].KapatmaTurAd = txt_deger.Text;
                        CollAsker[0].KapatmaTurTarih = DateTime.Now;
                        CollAsker[0].KapatmaTurDurum = true;
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }

                    else
                    {
                        KapatmaTurCollection CollAra = new KapatmaTurCollection();
                        IPredicateExpression ExpAra = new PredicateExpression();
                        ExpAra.AddWithAnd(KapatmaTurFields.KapatmaTurAd == txt_deger.Text);
                        CollAra.GetMulti(ExpAra);

                        if (CollAra.Count > 0)
                        {
                            string CloseWindow2;
                            CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                        }

                        else
                        {
                            CollAsker[0].KapatmaTurAd = txt_deger.Text;
                            CollAsker[0].KapatmaTurTarih = DateTime.Now;
                            CollAsker[0].KapatmaTurDurum = true;
                            CollAsker[0].Save();

                            string CloseWindow2;
                            CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                            Session["guncel_yap"] = "0";

                            doldur();

                            txt_deger.Text = "";
                        }
                    }
                }
            }

            else if (cb_parametre.Text == "Sorun Türü")
            {
                if (Session["guncel_yap"].ToString() == "0")
                {
                    SorunTuruCollection CollAsker = new SorunTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(SorunTuruFields.SorunTuruAd == txt_deger.Text);
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count > 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        txt_deger.Focus();
                    }

                    else
                    {
                        SorunTuruEntity EntKay = new SorunTuruEntity();
                        EntKay.SorunTuruAd = txt_deger.Text;
                        EntKay.SorunTuruTarih = DateTime.Now;
                        EntKay.SorunTuruDurum = true;
                        EntKay.Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Kayıt işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else
                {
                    SorunTuruCollection CollAsker = new SorunTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(SorunTuruFields.SorunTuruId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker[0].SorunTuruAd == txt_deger.Text)
                    {
                        CollAsker[0].SorunTuruAd = txt_deger.Text;
                        CollAsker[0].SorunTuruTarih = DateTime.Now;
                        CollAsker[0].SorunTuruDurum = true;
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }

                    else
                    {
                        SorunTuruCollection CollAra = new SorunTuruCollection();
                        IPredicateExpression ExpAra = new PredicateExpression();
                        ExpAra.AddWithAnd(SorunTuruFields.SorunTuruAd == txt_deger.Text);
                        CollAra.GetMulti(ExpAra);

                        if (CollAra.Count > 0)
                        {
                            string CloseWindow2;
                            CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                        }

                        else
                        {
                            CollAsker[0].SorunTuruAd = txt_deger.Text;
                            CollAsker[0].SorunTuruTarih = DateTime.Now;
                            CollAsker[0].SorunTuruDurum = true;
                            CollAsker[0].Save();

                            string CloseWindow2;
                            CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                            Session["guncel_yap"] = "0";

                            doldur();

                            txt_deger.Text = "";
                        }
                    }
                }
            }

            else if (cb_parametre.Text == "İşlem Türü")
            {
                if (Session["guncel_yap"].ToString() == "0")
                {
                    IslemTuruCollection CollAsker = new IslemTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(IslemTuruFields.IslemTuruAd == txt_deger.Text);
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count > 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        txt_deger.Focus();
                    }

                    else
                    {
                        IslemTuruEntity EntKay = new IslemTuruEntity();
                        EntKay.IslemTuruAd = txt_deger.Text;
                        EntKay.IslemTuruTarih = DateTime.Now;
                        EntKay.IslemTuruDurum = true;
                        EntKay.Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Kayıt işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else
                {
                    IslemTuruCollection CollAsker = new IslemTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(IslemTuruFields.IslemTuruId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker[0].IslemTuruAd == txt_deger.Text)
                    {
                        CollAsker[0].IslemTuruAd = txt_deger.Text;
                        CollAsker[0].IslemTuruTarih = DateTime.Now;
                        CollAsker[0].IslemTuruDurum = true;
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }

                    else
                    {
                        IslemTuruCollection CollAra = new IslemTuruCollection();
                        IPredicateExpression ExpAra = new PredicateExpression();
                        ExpAra.AddWithAnd(IslemTuruFields.IslemTuruAd == txt_deger.Text);
                        CollAra.GetMulti(ExpAra);

                        if (CollAra.Count > 0)
                        {
                            string CloseWindow2;
                            CloseWindow2 = "alert('Lütfen kayıt yapmak istediğiniz parametre değerini kontrol ediniz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                        }

                        else
                        {
                            CollAsker[0].IslemTuruAd = txt_deger.Text;
                            CollAsker[0].IslemTuruTarih = DateTime.Now;
                            CollAsker[0].IslemTuruDurum = true;
                            CollAsker[0].Save();

                            string CloseWindow2;
                            CloseWindow2 = "alert('Güncelleme işlemi tamamlanmıştır...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                            Session["guncel_yap"] = "0";

                            doldur();

                            txt_deger.Text = "";
                        }
                    }
                }
            }
        }

        protected void btn_deger_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_parametre.Text == "Rapor Türü")
                {
                    RaporTuruCollection CollAsker = new RaporTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(RaporTuruFields.RaporTuruId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count == 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen silmek istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                    }

                    else
                    {
                        CollAsker[0].Delete();
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Silme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                if (cb_parametre.Text == "Köpük Çağrı Türü")
                {
                    KopukCagriTuruCollection CollAsker = new KopukCagriTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(KopukCagriTuruFields.KopukCagriTuruId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count == 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen silmek istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                    }

                    else
                    {
                        CollAsker[0].Delete();
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Silme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else if (cb_parametre.Text == "Havalimanı")
                {
                    HavalimaniCollection CollAsker = new HavalimaniCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(HavalimaniFields.HavalimaniId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count == 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen silmek istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                    }

                    else
                    {
                        CollAsker[0].Delete();
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Silme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else if (cb_parametre.Text == "Gizli Soru Türü")
                {
                    GizliSoruTuruCollection CollAsker = new GizliSoruTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(GizliSoruTuruFields.GizliSoruTuruId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count == 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen silmek istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                    }

                    else
                    {
                        CollAsker[0].Delete();
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Silme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else if (cb_parametre.Text == "Çağrı Tipi")
                {
                    CagriTipiCollection CollAsker = new CagriTipiCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(CagriTipiFields.CagriTipiId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count == 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen silmek istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                    }

                    else
                    {
                        CollAsker[0].Delete();
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Silme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else if (cb_parametre.Text == "Bildirim Geri Dönüş Türü")
                {
                    BildirimGeriDonuCollection CollAsker = new BildirimGeriDonuCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count == 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen silmek istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                    }

                    else
                    {
                        CollAsker[0].Delete();
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Silme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        Session["guncel_yap"] = "0";

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else if (cb_parametre.Text == "Bildirim İşlem Türü")
                {
                    BildirimIslemCollection CollAsker = new BildirimIslemCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(BildirimIslemFields.BildirimIslemId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count == 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen silmek istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                    }

                    else
                    {
                        CollAsker[0].Delete();
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Silme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else if (cb_parametre.Text == "Bildirim Sonuç Türü")
                {
                    BildirimSonucCollection CollAsker = new BildirimSonucCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(BildirimSonucFields.BildirimSonucId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count == 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen silmek istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                    }

                    else
                    {
                        CollAsker[0].Delete();
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Silme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else if (cb_parametre.Text == "Bilgi Bankasi Türü")
                {
                    BilgiBankasiTurCollection CollAsker = new BilgiBankasiTurCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(BilgiBankasiTurFields.BilgiBankasiTurId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count == 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen silmek istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                    }

                    else
                    {
                        CollAsker[0].Delete();
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Silme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else if (cb_parametre.Text == "Görev Türü")
                {
                    GorevCollection CollAsker = new GorevCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(GorevFields.GorevId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count == 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen silmek istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                    }

                    else
                    {
                        CollAsker[0].Delete();
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Silme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else if (cb_parametre.Text == "Hiyerarşi Türü")
                {
                    HiyerarsiTurCollection CollAsker = new HiyerarsiTurCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(HiyerarsiTurFields.HiyerarsiTurId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count == 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen silmek istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                    }

                    else
                    {
                        CollAsker[0].Delete();
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Silme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else if (cb_parametre.Text == "Kapatma Türü")
                {
                    KapatmaTurCollection CollAsker = new KapatmaTurCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(KapatmaTurFields.KapatmaTurId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count == 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen silmek istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                    }

                    else
                    {
                        CollAsker[0].Delete();
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Silme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else if (cb_parametre.Text == "Sorun Türü")
                {
                    SorunTuruCollection CollAsker = new SorunTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(SorunTuruFields.SorunTuruId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count == 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen silmek istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                    }

                    else
                    {
                        CollAsker[0].Delete();
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Silme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        doldur();

                        txt_deger.Text = "";
                    }
                }

                else if (cb_parametre.Text == "İşlem Türü")
                {
                    IslemTuruCollection CollAsker = new IslemTuruCollection();
                    IPredicateExpression ExpAsker = new PredicateExpression();
                    ExpAsker.AddWithAnd(IslemTuruFields.IslemTuruId == Convert.ToInt16(Session["id_leri"].ToString()));
                    CollAsker.GetMulti(ExpAsker);

                    if (CollAsker.Count == 0)
                    {
                        string CloseWindow2;
                        CloseWindow2 = "alert('Lütfen silmek istediğiniz parametre değerini kontrol ediniz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
                    }

                    else
                    {
                        CollAsker[0].Delete();
                        CollAsker[0].Save();

                        string CloseWindow2;
                        CloseWindow2 = "alert('Silme işlemi tamamlanmıştır...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                        doldur();

                        txt_deger.Text = "";
                    }
                }
            }

            catch
            {
                string CloseWindow2;
                CloseWindow2 = "alert('Silmek istediğiniz parametre değeri sistemde aktif olarak kullanılmaktadır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);

                txt_deger.Text = "";
            }
        }

        protected void btn_iptal_et_Click(object sender, EventArgs e)
        {
            btn_deger_sil.Enabled = false;
            txt_deger.Text = "";
            Session["guncel_yap"] = "0";
        }
    }
}