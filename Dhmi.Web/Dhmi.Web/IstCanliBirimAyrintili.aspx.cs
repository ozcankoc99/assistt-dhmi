using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraCharts;
using System.Drawing;
using dhmi.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.HelperClasses;
using dhmi.EntityClasses;
using dhmi.TypedListClasses;

namespace Dhmi.Web
{
    public partial class IstCanliBirimAyrintili : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Session["menu_sec"] = "İstatistiki İşlemler";

                if ((Session["kullanici_var_mi"] == null) || (Session["kullanici_rastgele"] == null))
                {
                    Response.Redirect("Account/Login.aspx");
                }

                HttpCookie cookie = Request.Cookies["userC"];
                HttpCookie cookieYetki = Request.Cookies["aJ4lOu784TyfdEsd4FIoi"];
                if (cookie != null && cookieYetki != null)
                {
                    string yetki = Helper.Decrypt(cookieYetki.Value);
                    if (yetki == "Admin" || yetki == "Kurum Sistem Yöneticisi" || yetki == "Kurum Makam")
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

                KullaniciCollection CollKul2 = new KullaniciCollection();
                IPredicateExpression ExpKul2 = new PredicateExpression();
                ExpKul2.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollKul2.GetMulti(ExpKul2);

                if (IsPostBack != true)
                {
                    ChartTitle title2 = new ChartTitle();
                    title2.TextColor = System.Drawing.Color.DarkGray;
                    title2.Dock = ChartTitleDockStyle.Bottom;
                    title2.Text = "DHMİ İletişim Merkezi";
                    title2.Font = new Font("Calibri", 8, FontStyle.Regular);
                    title2.Alignment = StringAlignment.Far;
                    WebChartControl1.Titles.Add(title2);

                    ChartTitle title3 = new ChartTitle();
                    title3.TextColor = System.Drawing.Color.Brown;
                    title3.Dock = ChartTitleDockStyle.Left;
                    title3.Text = "Adet Verileri";
                    title3.Font = new Font("Calibri", 10, FontStyle.Regular);
                    title3.Alignment = StringAlignment.Center;
                    WebChartControl1.Titles.Add(title3);

                    MenuCollection CollMenu = new MenuCollection();
                    IPredicateExpression ExpMenu = new PredicateExpression();
                    ExpMenu.AddWithAnd(MenuFields.MenuAd == "İstatistiki İşlemler");
                    CollMenu.GetMulti(ExpMenu);

                    AltMenuCollection CollAlt1 = new AltMenuCollection();
                    IPredicateExpression ExpAlt1 = new PredicateExpression();
                    ExpAlt1.AddWithAnd(AltMenuFields.AltMenuAd == "İstatistik Bilgileri");
                    CollAlt1.GetMulti(ExpAlt1);

                    AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                    IPredicateExpression ExpAlt2 = new PredicateExpression();
                    ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Canlı (Başkanlık-Ayrıntı)");
                    CollAlt2.GetMulti(ExpAlt2);

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

                    GrupAtamaCollection CollAtaaa = new GrupAtamaCollection();
                    IPredicateExpression ExpAtaaa = new PredicateExpression();
                    ExpAtaaa.AddWithAnd(GrupAtamaFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                    CollAtaaa.GetMulti(ExpAtaaa);

                    GrupCollection CollGruppp = new GrupCollection();
                    IPredicateExpression ExpGruppp = new PredicateExpression();
                    ExpGruppp.AddWithAnd(GrupFields.GrupId == CollAtaaa[0].FkGrupId);
                    CollGruppp.GetMulti(ExpGruppp);

                    ChartTitle title = new ChartTitle();
                    title.TextColor = System.Drawing.Color.Maroon;
                    title.Font = new Font("Calibri", 18, FontStyle.Regular);
                    title.Text = CollGruppp[0].GrupAd;
                    WebChartControl1.Titles.Add(title);
                }

                ParametreCollection CollParam = new ParametreCollection();
                IPredicateExpression ExpParam = new PredicateExpression();
                ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
                ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollParam.GetMulti(ExpParam);

                grid_diger.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
                grid_ayrinti.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
                grid_konu.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

                GrupAtamaCollection CollAta = new GrupAtamaCollection();
                IPredicateExpression ExpAta = new PredicateExpression();
                ExpAta.AddWithAnd(GrupAtamaFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollAta.GetMulti(ExpAta);

                GrupCollection CollGrup = new GrupCollection();
                IPredicateExpression ExpGrup = new PredicateExpression();
                ExpGrup.AddWithAnd(GrupFields.GrupId == CollAta[0].FkGrupId);
                CollGrup.GetMulti(ExpGrup);

                DigerBirimlerCollection CollMen = new DigerBirimlerCollection();
                IPredicateExpression ExpMen = new PredicateExpression();
                ExpMen.AddWithAnd(DigerBirimlerFields.DigerBirimlerKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollMen.GetMulti(ExpMen);

                CollMen.DeleteMulti();
                CollMen.SaveMulti();

                DigerBirimlerAyrintiCollection CollYaz = new DigerBirimlerAyrintiCollection();
                IPredicateExpression ExpYaz = new PredicateExpression();
                ExpYaz.AddWithAnd(DigerBirimlerAyrintiFields.DigerBirimlerAyrintiKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollYaz.GetMulti(ExpYaz);

                CollYaz.DeleteMulti();
                CollYaz.SaveMulti();

                KonusalDagilimCollection CollKo = new KonusalDagilimCollection();
                IPredicateExpression ExpKo = new PredicateExpression();
                ExpKo.AddWithAnd(KonusalDagilimFields.KonusalDagilimKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollKo.GetMulti(ExpKo);

                CollKo.DeleteMulti();
                CollKo.SaveMulti();

                BaskanlikCollection CollMena = new BaskanlikCollection();
                IPredicateExpression ExpMena = new PredicateExpression();
                ExpMena.AddWithAnd(BaskanlikFields.BaskanlikKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollMena.GetMulti(ExpMena);

                CollMena.DeleteMulti();
                CollMena.SaveMulti();

                BildirimSonucCollection CollSon1 = new BildirimSonucCollection();
                IPredicateExpression ExpSon1 = new PredicateExpression();
                ExpSon1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                CollSon1.GetMulti(ExpSon1);

                BildirimSonucCollection CollSon2 = new BildirimSonucCollection();
                IPredicateExpression ExpSon2 = new PredicateExpression();
                ExpSon2.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
                CollSon2.GetMulti(ExpSon2);

                BildirimSonucCollection CollSon3 = new BildirimSonucCollection();
                IPredicateExpression ExpSon3 = new PredicateExpression();
                ExpSon3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
                CollSon3.GetMulti(ExpSon3);

                BildirimSonucCollection CollSon4 = new BildirimSonucCollection();
                IPredicateExpression ExpSon4 = new PredicateExpression();
                ExpSon4.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Sonuçlandı");
                CollSon4.GetMulti(ExpSon4);

                BildirimSonucCollection CollSon5 = new BildirimSonucCollection();
                IPredicateExpression ExpSon5 = new PredicateExpression();
                ExpSon5.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Reddedildi");
                CollSon5.GetMulti(ExpSon5);

                GrupAtamaCollection CollNe = new GrupAtamaCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupAtamaFields.FkKullaniciId == CollKul2[0].KullaniciId);
                CollNe.GetMulti(ExpNe);

                if (CollNe.Count > 0)
                {
                    GrupCollection CollAna = new GrupCollection();
                    IPredicateExpression ExpAna = new PredicateExpression();
                    ExpAna.AddWithAnd(GrupFields.GrupId == CollNe[0].FkGrupId);
                    CollAna.GetMulti(ExpAna);

                    GrupCollection CollTem = new GrupCollection();
                    IPredicateExpression ExpTem = new PredicateExpression();
                    ISortExpression sorttem = new SortExpression();
                    ExpTem.AddWithAnd(GrupFields.GrupDurum == true);
                    sorttem.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
                    CollTem.GetMulti(ExpTem, 0, sorttem);

                    Int16 atandi = 0;
                    Int16 incele = 0;
                    Int16 incele_ek = 0;
                    Int16 sonuclandi = 0;
                    Int16 reddedildi = 0;

                    for (int k = 0; k < CollTem.Count; k++)
                    {
                        if (CollTem[k].GrupAd != CollAna[0].GrupAd && CollTem[k].GrupAd != "Backoffice")
                        {
                            ListBilGrupTypedList bil_list_ana = new ListBilGrupTypedList();
                            ISortExpression sortbil_ana = new SortExpression();
                            sortbil_ana.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupTarih, SortOperator.Descending));
                            IPredicateExpression filterbil_ana = new PredicateExpression();
                            filterbil_ana.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                            filterbil_ana.AddWithAnd(BildirimAtamaGrupFields.FkGrupId == CollTem[k].GrupId);
                            filterbil_ana.AddWithAnd(BildirimAtamaGrupFields.BildirimAtamaGrupYonMu == "Hayır");
                            bil_list_ana.Fill(0, sortbil_ana, true, filterbil_ana);

                            ListBilGrupTypedList bil_list_ana2 = new ListBilGrupTypedList();
                            ISortExpression sortbil_ana2 = new SortExpression();
                            sortbil_ana2.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupTarih, SortOperator.Descending));
                            IPredicateExpression filterbil_ana2 = new PredicateExpression();
                            filterbil_ana2.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
                            filterbil_ana2.AddWithAnd(BildirimAtamaGrupFields.FkGrupId == CollTem[k].GrupId);
                            filterbil_ana2.AddWithAnd(BildirimAtamaGrupFields.BildirimAtamaGrupYonMu == "Hayır");
                            bil_list_ana2.Fill(0, sortbil_ana2, true, filterbil_ana2);

                            ListBilGrupTypedList bil_list_ana3 = new ListBilGrupTypedList();
                            ISortExpression sortbil_ana3 = new SortExpression();
                            sortbil_ana3.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupTarih, SortOperator.Descending));
                            IPredicateExpression filterbil_ana3 = new PredicateExpression();
                            filterbil_ana3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
                            filterbil_ana3.AddWithAnd(BildirimAtamaGrupFields.FkGrupId == CollTem[k].GrupId);
                            filterbil_ana3.AddWithAnd(BildirimAtamaGrupFields.BildirimAtamaGrupYonMu == "Hayır");
                            bil_list_ana3.Fill(0, sortbil_ana3, true, filterbil_ana3);

                            ListBilGrupTypedList bil_list_ana4 = new ListBilGrupTypedList();
                            ISortExpression sortbil_ana4 = new SortExpression();
                            sortbil_ana4.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupTarih, SortOperator.Descending));
                            IPredicateExpression filterbil_ana4 = new PredicateExpression();
                            filterbil_ana4.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Sonuçlandı");
                            filterbil_ana4.AddWithAnd(BildirimAtamaGrupFields.FkGrupId == CollTem[k].GrupId);
                            filterbil_ana4.AddWithAnd(BildirimAtamaGrupFields.BildirimAtamaGrupYonMu == "Hayır");
                            bil_list_ana4.Fill(0, sortbil_ana4, true, filterbil_ana4);

                            ListBilGrupTypedList bil_list_ana5 = new ListBilGrupTypedList();
                            ISortExpression sortbil_ana5 = new SortExpression();
                            sortbil_ana5.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupTarih, SortOperator.Descending));
                            IPredicateExpression filterbil_ana5 = new PredicateExpression();
                            filterbil_ana5.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Reddedildi");
                            filterbil_ana5.AddWithAnd(BildirimAtamaGrupFields.FkGrupId == CollTem[k].GrupId);
                            filterbil_ana5.AddWithAnd(BildirimAtamaGrupFields.BildirimAtamaGrupYonMu == "Hayır");
                            bil_list_ana5.Fill(0, sortbil_ana5, true, filterbil_ana5);

                            BildirimCollection CollHav1 = new BildirimCollection();
                            IPredicateExpression ExpHav1 = new PredicateExpression();
                            ExpHav1.AddWithAnd(BildirimFields.BildirimHavalimani == CollTem[k].GrupAd);
                            ExpHav1.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon1[0].BildirimSonucId);
                            CollHav1.GetMulti(ExpHav1);

                            BildirimCollection CollHav2 = new BildirimCollection();
                            IPredicateExpression ExpHav2 = new PredicateExpression();
                            ExpHav2.AddWithAnd(BildirimFields.BildirimHavalimani == CollTem[k].GrupAd);
                            ExpHav2.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon2[0].BildirimSonucId);
                            CollHav2.GetMulti(ExpHav2);

                            BildirimCollection CollHav3 = new BildirimCollection();
                            IPredicateExpression ExpHav3 = new PredicateExpression();
                            ExpHav3.AddWithAnd(BildirimFields.BildirimHavalimani == CollTem[k].GrupAd);
                            ExpHav3.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon3[0].BildirimSonucId);
                            CollHav3.GetMulti(ExpHav3);

                            BildirimCollection CollHav4 = new BildirimCollection();
                            IPredicateExpression ExpHav4 = new PredicateExpression();
                            ExpHav4.AddWithAnd(BildirimFields.BildirimHavalimani == CollTem[k].GrupAd);
                            ExpHav4.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon4[0].BildirimSonucId);
                            CollHav4.GetMulti(ExpHav4);

                            BildirimCollection CollHav5 = new BildirimCollection();
                            IPredicateExpression ExpHav5 = new PredicateExpression();
                            ExpHav5.AddWithAnd(BildirimFields.BildirimHavalimani == CollTem[k].GrupAd);
                            ExpHav5.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon5[0].BildirimSonucId);
                            CollHav5.GetMulti(ExpHav5);

                            DigerBirimlerEntity EntKay = new DigerBirimlerEntity();
                            EntKay.DigerBirimlerKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                            EntKay.DigerBirimlerAtandiSayi = Convert.ToInt16(Convert.ToInt16(bil_list_ana.Count) + Convert.ToInt16(CollHav1.Count));
                            EntKay.DigerBirimlerBirim = CollTem[k].GrupAd;
                            EntKay.DigerBirimlerInceleniyorSayi = Convert.ToInt16(Convert.ToInt16(bil_list_ana2.Count) + Convert.ToInt16(CollHav2.Count));
                            EntKay.DigerBirimlerInceleniyorEkSureSayi = Convert.ToInt16(Convert.ToInt16(bil_list_ana3.Count) + Convert.ToInt16(CollHav3.Count));
                            EntKay.DigerBirimlerSonuclandiSayi = Convert.ToInt16(Convert.ToInt16(bil_list_ana4.Count) + Convert.ToInt16(CollHav4.Count));
                            EntKay.DigerBirimlerReddedildiSayi = Convert.ToInt16(Convert.ToInt16(bil_list_ana5.Count) + Convert.ToInt16(CollHav5.Count));
                            EntKay.Save();
                        }

                        else if (CollTem[k].GrupAd == CollAna[0].GrupAd && CollTem[k].GrupAd != "Backoffice")
                        {
                            ListBilGrupTypedList bil_list_ana = new ListBilGrupTypedList();
                            ISortExpression sortbil_ana = new SortExpression();
                            sortbil_ana.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupTarih, SortOperator.Descending));
                            IPredicateExpression filterbil_ana = new PredicateExpression();
                            filterbil_ana.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                            filterbil_ana.AddWithAnd(BildirimAtamaGrupFields.FkGrupId == CollTem[k].GrupId);
                            filterbil_ana.AddWithAnd(BildirimAtamaGrupFields.BildirimAtamaGrupYonMu == "Hayır");
                            bil_list_ana.Fill(0, sortbil_ana, true, filterbil_ana);

                            for (int j = 0; j < bil_list_ana.Count; j++)
                            {
                                atandi = Convert.ToInt16(atandi + 1);

                                AltKonuCollection CollAlt = new AltKonuCollection();
                                IPredicateExpression ExpAlt = new PredicateExpression();
                                ExpAlt.AddWithAnd(AltKonuFields.AltKonuId == bil_list_ana[j].FkAltKonuId);
                                CollAlt.GetMulti(ExpAlt);

                                KonusalDagilimEntity EntKayt = new KonusalDagilimEntity();
                                EntKayt.KonusalDagilimKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                EntKayt.KonusalDagilimDurum = "Atandı";
                                EntKayt.KonusalDagilimIcerik = bil_list_ana[j].BildirimMetin;
                                EntKayt.KonusalDagilimNo = bil_list_ana[j].BildirimId;
                                EntKayt.KonusalDagilimSonDurum = bil_list_ana[j].BildirimAtanmaDurumu;
                                EntKayt.KonusalDagilimKonu = CollAlt[0].AltKonuAd;
                                EntKayt.KonusalDagilimSure = bil_list_ana[j].BildirimToplamSure;
                                EntKayt.Save();
                            }

                            BildirimCollection CollHav1 = new BildirimCollection();
                            IPredicateExpression ExpHav1 = new PredicateExpression();
                            ExpHav1.AddWithAnd(BildirimFields.BildirimHavalimani == CollTem[k].GrupAd);
                            ExpHav1.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon1[0].BildirimSonucId);
                            CollHav1.GetMulti(ExpHav1);

                            for (int p = 0; p < CollHav1.Count; p++)
                            {
                                atandi = Convert.ToInt16(atandi + 1);

                                AltKonuCollection CollAlt = new AltKonuCollection();
                                IPredicateExpression ExpAlt = new PredicateExpression();
                                ExpAlt.AddWithAnd(AltKonuFields.AltKonuId == CollHav1[p].FkAltKonuId);
                                CollAlt.GetMulti(ExpAlt);

                                KonusalDagilimEntity EntKayt = new KonusalDagilimEntity();
                                EntKayt.KonusalDagilimKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                EntKayt.KonusalDagilimDurum = "Atandı";
                                EntKayt.KonusalDagilimIcerik = CollHav1[p].BildirimMetin;
                                EntKayt.KonusalDagilimNo = CollHav1[p].BildirimId;
                                EntKayt.KonusalDagilimSonDurum = CollHav1[p].BildirimAtanmaDurumu;
                                EntKayt.KonusalDagilimKonu = CollAlt[0].AltKonuAd;
                                EntKayt.KonusalDagilimSure = CollHav1[p].BildirimToplamSure;
                                EntKayt.Save();
                            }

                            BaskanlikEntity EntKay = new BaskanlikEntity();
                            EntKay.BaskanlikKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                            EntKay.BaskanlikAd = "Atandı";
                            EntKay.BaskanlikAlt = atandi.ToString() + " ADET";
                            EntKay.BaskanlikSol = atandi;
                            EntKay.Save();

                            ListBilGrupTypedList bil_list_ana2 = new ListBilGrupTypedList();
                            ISortExpression sortbil_ana2 = new SortExpression();
                            sortbil_ana2.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupTarih, SortOperator.Descending));
                            IPredicateExpression filterbil_ana2 = new PredicateExpression();
                            filterbil_ana2.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
                            filterbil_ana2.AddWithAnd(BildirimAtamaGrupFields.FkGrupId == CollTem[k].GrupId);
                            filterbil_ana2.AddWithAnd(BildirimAtamaGrupFields.BildirimAtamaGrupYonMu == "Hayır");
                            bil_list_ana2.Fill(0, sortbil_ana2, true, filterbil_ana2);

                            for (int j = 0; j < bil_list_ana2.Count; j++)
                            {
                                incele = Convert.ToInt16(incele + 1);

                                AltKonuCollection CollAlt = new AltKonuCollection();
                                IPredicateExpression ExpAlt = new PredicateExpression();
                                ExpAlt.AddWithAnd(AltKonuFields.AltKonuId == bil_list_ana2[j].FkAltKonuId);
                                CollAlt.GetMulti(ExpAlt);

                                KonusalDagilimEntity EntKayt = new KonusalDagilimEntity();
                                EntKayt.KonusalDagilimKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                EntKayt.KonusalDagilimDurum = "İnceleniyor";
                                EntKayt.KonusalDagilimIcerik = bil_list_ana2[j].BildirimMetin;
                                EntKayt.KonusalDagilimNo = bil_list_ana2[j].BildirimId;
                                EntKayt.KonusalDagilimSonDurum = bil_list_ana2[j].BildirimAtanmaDurumu;
                                EntKayt.KonusalDagilimKonu = CollAlt[0].AltKonuAd;
                                EntKayt.KonusalDagilimSure = bil_list_ana2[j].BildirimToplamSure;
                                EntKayt.Save();
                            }

                            BildirimCollection CollHav2 = new BildirimCollection();
                            IPredicateExpression ExpHav2 = new PredicateExpression();
                            ExpHav2.AddWithAnd(BildirimFields.BildirimHavalimani == CollTem[k].GrupAd);
                            ExpHav2.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon2[0].BildirimSonucId);
                            CollHav2.GetMulti(ExpHav2);

                            for (int p = 0; p < CollHav2.Count; p++)
                            {
                                incele = Convert.ToInt16(incele + 1);

                                AltKonuCollection CollAlt = new AltKonuCollection();
                                IPredicateExpression ExpAlt = new PredicateExpression();
                                ExpAlt.AddWithAnd(AltKonuFields.AltKonuId == CollHav2[p].FkAltKonuId);
                                CollAlt.GetMulti(ExpAlt);

                                KonusalDagilimEntity EntKayt = new KonusalDagilimEntity();
                                EntKayt.KonusalDagilimKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                EntKayt.KonusalDagilimDurum = "İnceleniyor";
                                EntKayt.KonusalDagilimIcerik = CollHav2[p].BildirimMetin;
                                EntKayt.KonusalDagilimNo = CollHav2[p].BildirimId;
                                EntKayt.KonusalDagilimSonDurum = CollHav2[p].BildirimAtanmaDurumu;
                                EntKayt.KonusalDagilimKonu = CollAlt[0].AltKonuAd;
                                EntKayt.KonusalDagilimSure = CollHav2[p].BildirimToplamSure;
                                EntKayt.Save();
                            }

                            BaskanlikEntity EntKay2 = new BaskanlikEntity();
                            EntKay2.BaskanlikKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                            EntKay2.BaskanlikAd = "İnceleniyor";
                            EntKay2.BaskanlikAlt = incele.ToString() + " ADET";
                            EntKay2.BaskanlikSol = incele;
                            EntKay2.Save();

                            ListBilGrupTypedList bil_list_ana3 = new ListBilGrupTypedList();
                            ISortExpression sortbil_ana3 = new SortExpression();
                            sortbil_ana3.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupTarih, SortOperator.Descending));
                            IPredicateExpression filterbil_ana3 = new PredicateExpression();
                            filterbil_ana3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
                            filterbil_ana3.AddWithAnd(BildirimAtamaGrupFields.FkGrupId == CollTem[k].GrupId);
                            filterbil_ana3.AddWithAnd(BildirimAtamaGrupFields.BildirimAtamaGrupYonMu == "Hayır");
                            bil_list_ana3.Fill(0, sortbil_ana3, true, filterbil_ana3);

                            for (int j = 0; j < bil_list_ana3.Count; j++)
                            {
                                incele_ek = Convert.ToInt16(incele_ek + 1);

                                AltKonuCollection CollAlt = new AltKonuCollection();
                                IPredicateExpression ExpAlt = new PredicateExpression();
                                ExpAlt.AddWithAnd(AltKonuFields.AltKonuId == bil_list_ana3[j].FkAltKonuId);
                                CollAlt.GetMulti(ExpAlt);

                                KonusalDagilimEntity EntKayt = new KonusalDagilimEntity();
                                EntKayt.KonusalDagilimKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                EntKayt.KonusalDagilimDurum = "İnceleniyor - Ek Süre";
                                EntKayt.KonusalDagilimIcerik = bil_list_ana3[j].BildirimMetin;
                                EntKayt.KonusalDagilimNo = bil_list_ana3[j].BildirimId;
                                EntKayt.KonusalDagilimSonDurum = bil_list_ana3[j].BildirimAtanmaDurumu;
                                EntKayt.KonusalDagilimKonu = CollAlt[0].AltKonuAd;
                                EntKayt.KonusalDagilimSure = bil_list_ana3[j].BildirimToplamSure;
                                EntKayt.Save();
                            }

                            BildirimCollection CollHav3 = new BildirimCollection();
                            IPredicateExpression ExpHav3 = new PredicateExpression();
                            ExpHav3.AddWithAnd(BildirimFields.BildirimHavalimani == CollTem[k].GrupAd);
                            ExpHav3.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon3[0].BildirimSonucId);
                            CollHav3.GetMulti(ExpHav3);

                            for (int p = 0; p < CollHav3.Count; p++)
                            {
                                incele_ek = Convert.ToInt16(incele_ek + 1);

                                AltKonuCollection CollAlt = new AltKonuCollection();
                                IPredicateExpression ExpAlt = new PredicateExpression();
                                ExpAlt.AddWithAnd(AltKonuFields.AltKonuId == CollHav3[p].FkAltKonuId);
                                CollAlt.GetMulti(ExpAlt);

                                KonusalDagilimEntity EntKayt = new KonusalDagilimEntity();
                                EntKayt.KonusalDagilimKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                EntKayt.KonusalDagilimDurum = "İnceleniyor - Ek Süre";
                                EntKayt.KonusalDagilimIcerik = CollHav3[p].BildirimMetin;
                                EntKayt.KonusalDagilimNo = CollHav3[p].BildirimId;
                                EntKayt.KonusalDagilimSonDurum = CollHav3[p].BildirimAtanmaDurumu;
                                EntKayt.KonusalDagilimKonu = CollAlt[0].AltKonuAd;
                                EntKayt.KonusalDagilimSure = CollHav3[p].BildirimToplamSure;
                                EntKayt.Save();
                            }

                            BaskanlikEntity EntKay3 = new BaskanlikEntity();
                            EntKay3.BaskanlikKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                            EntKay3.BaskanlikAd = "İnceleniyor - Ek Süre";
                            EntKay3.BaskanlikAlt = incele_ek.ToString() + " ADET";
                            EntKay3.BaskanlikSol = incele_ek;
                            EntKay3.Save();

                            ListBilGrupTypedList bil_list_ana4 = new ListBilGrupTypedList();
                            ISortExpression sortbil_ana4 = new SortExpression();
                            sortbil_ana4.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupTarih, SortOperator.Descending));
                            IPredicateExpression filterbil_ana4 = new PredicateExpression();
                            filterbil_ana4.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Sonuçlandı");
                            filterbil_ana4.AddWithAnd(BildirimAtamaGrupFields.FkGrupId == CollTem[k].GrupId);
                            filterbil_ana4.AddWithAnd(BildirimAtamaGrupFields.BildirimAtamaGrupYonMu == "Hayır");
                            bil_list_ana4.Fill(0, sortbil_ana4, true, filterbil_ana4);

                            for (int j = 0; j < bil_list_ana4.Count; j++)
                            {
                                sonuclandi = Convert.ToInt16(sonuclandi + 1);

                                AltKonuCollection CollAlt = new AltKonuCollection();
                                IPredicateExpression ExpAlt = new PredicateExpression();
                                ExpAlt.AddWithAnd(AltKonuFields.AltKonuId == bil_list_ana4[j].FkAltKonuId);
                                CollAlt.GetMulti(ExpAlt);

                                KonusalDagilimEntity EntKayt = new KonusalDagilimEntity();
                                EntKayt.KonusalDagilimKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                EntKayt.KonusalDagilimDurum = "Sonuçlandı";
                                EntKayt.KonusalDagilimIcerik = bil_list_ana4[j].BildirimMetin;
                                EntKayt.KonusalDagilimNo = bil_list_ana4[j].BildirimId;
                                EntKayt.KonusalDagilimSonDurum = bil_list_ana4[j].BildirimAtanmaDurumu;
                                EntKayt.KonusalDagilimKonu = CollAlt[0].AltKonuAd;
                                EntKayt.KonusalDagilimSure = bil_list_ana4[j].BildirimToplamSure;
                                EntKayt.Save();
                            }

                            BildirimCollection CollHav4 = new BildirimCollection();
                            IPredicateExpression ExpHav4 = new PredicateExpression();
                            ExpHav4.AddWithAnd(BildirimFields.BildirimHavalimani == CollTem[k].GrupAd);
                            ExpHav4.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon4[0].BildirimSonucId);
                            CollHav4.GetMulti(ExpHav4);

                            for (int p = 0; p < CollHav4.Count; p++)
                            {
                                sonuclandi = Convert.ToInt16(sonuclandi + 1);

                                AltKonuCollection CollAlt = new AltKonuCollection();
                                IPredicateExpression ExpAlt = new PredicateExpression();
                                ExpAlt.AddWithAnd(AltKonuFields.AltKonuId == CollHav4[p].FkAltKonuId);
                                CollAlt.GetMulti(ExpAlt);

                                KonusalDagilimEntity EntKayt = new KonusalDagilimEntity();
                                EntKayt.KonusalDagilimKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                EntKayt.KonusalDagilimDurum = "Sonuçlandı";
                                EntKayt.KonusalDagilimIcerik = CollHav4[p].BildirimMetin;
                                EntKayt.KonusalDagilimNo = CollHav4[p].BildirimId;
                                EntKayt.KonusalDagilimSonDurum = CollHav4[p].BildirimAtanmaDurumu;
                                EntKayt.KonusalDagilimKonu = CollAlt[0].AltKonuAd;
                                EntKayt.KonusalDagilimSure = CollHav4[p].BildirimToplamSure;
                                EntKayt.Save();
                            }

                            BaskanlikEntity EntKay4 = new BaskanlikEntity();
                            EntKay4.BaskanlikKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                            EntKay4.BaskanlikAd = "Sonuçlandı";
                            EntKay4.BaskanlikAlt = sonuclandi.ToString() + " ADET";
                            EntKay4.BaskanlikSol = sonuclandi;
                            EntKay4.Save();

                            ListBilGrupTypedList bil_list_ana5 = new ListBilGrupTypedList();
                            ISortExpression sortbil_ana5 = new SortExpression();
                            sortbil_ana5.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupTarih, SortOperator.Descending));
                            IPredicateExpression filterbil_ana5 = new PredicateExpression();
                            filterbil_ana5.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Reddedildi");
                            filterbil_ana5.AddWithAnd(BildirimAtamaGrupFields.FkGrupId == CollTem[k].GrupId);
                            filterbil_ana5.AddWithAnd(BildirimAtamaGrupFields.BildirimAtamaGrupYonMu == "Hayır");
                            bil_list_ana5.Fill(0, sortbil_ana5, true, filterbil_ana5);

                            for (int j = 0; j < bil_list_ana5.Count; j++)
                            {
                                reddedildi = Convert.ToInt16(reddedildi + 1);

                                AltKonuCollection CollAlt = new AltKonuCollection();
                                IPredicateExpression ExpAlt = new PredicateExpression();
                                ExpAlt.AddWithAnd(AltKonuFields.AltKonuId == bil_list_ana5[j].FkAltKonuId);
                                CollAlt.GetMulti(ExpAlt);

                                KonusalDagilimEntity EntKayt = new KonusalDagilimEntity();
                                EntKayt.KonusalDagilimKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                EntKayt.KonusalDagilimDurum = "Reddedildi";
                                EntKayt.KonusalDagilimIcerik = bil_list_ana5[j].BildirimMetin;
                                EntKayt.KonusalDagilimNo = bil_list_ana5[j].BildirimId;
                                EntKayt.KonusalDagilimSonDurum = bil_list_ana5[j].BildirimAtanmaDurumu;
                                EntKayt.KonusalDagilimKonu = CollAlt[0].AltKonuAd;
                                EntKayt.KonusalDagilimSure = bil_list_ana5[j].BildirimToplamSure;
                                EntKayt.Save();
                            }

                            BildirimCollection CollHav5 = new BildirimCollection();
                            IPredicateExpression ExpHav5 = new PredicateExpression();
                            ExpHav5.AddWithAnd(BildirimFields.BildirimHavalimani == CollTem[k].GrupAd);
                            ExpHav5.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon5[0].BildirimSonucId);
                            CollHav5.GetMulti(ExpHav5);

                            for (int p = 0; p < CollHav5.Count; p++)
                            {
                                reddedildi = Convert.ToInt16(reddedildi + 1);

                                AltKonuCollection CollAlt = new AltKonuCollection();
                                IPredicateExpression ExpAlt = new PredicateExpression();
                                ExpAlt.AddWithAnd(AltKonuFields.AltKonuId == CollHav5[p].FkAltKonuId);
                                CollAlt.GetMulti(ExpAlt);

                                KonusalDagilimEntity EntKayt = new KonusalDagilimEntity();
                                EntKayt.KonusalDagilimKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                EntKayt.KonusalDagilimDurum = "Reddedildi";
                                EntKayt.KonusalDagilimIcerik = CollHav5[p].BildirimMetin;
                                EntKayt.KonusalDagilimNo = CollHav5[p].BildirimId;
                                EntKayt.KonusalDagilimSonDurum = CollHav5[p].BildirimAtanmaDurumu;
                                EntKayt.KonusalDagilimKonu = CollAlt[0].AltKonuAd;
                                EntKayt.KonusalDagilimSure = CollHav5[p].BildirimToplamSure;
                                EntKayt.Save();
                            }

                            BaskanlikEntity EntKay5 = new BaskanlikEntity();
                            EntKay5.BaskanlikKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                            EntKay5.BaskanlikAd = "Reddedildi";
                            EntKay5.BaskanlikAlt = reddedildi.ToString() + " ADET";
                            EntKay5.BaskanlikSol = reddedildi;
                            EntKay5.Save();
                        }
                    }

                    BaskanlikCollection CollMen2 = new BaskanlikCollection();
                    IPredicateExpression ExpMen2 = new PredicateExpression();
                    ExpMen2.AddWithAnd(BaskanlikFields.BaskanlikKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                    CollMen2.GetMulti(ExpMen2);

                    WebChartControl1.SeriesDataMember = "BaskanlikAd";
                    WebChartControl1.SeriesTemplate.ArgumentDataMember = "BaskanlikAlt";
                    WebChartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "BaskanlikSol" });
                    WebChartControl1.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
                    WebChartControl1.SeriesTemplate.ToolTipSeriesPattern = "{S}: {V}";
                    WebChartControl1.SeriesTemplate.ToolTipPointPattern = "{S}: {V}";
                    WebChartControl1.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";

                    WebChartControl1.DataSource = CollMen2;
                    WebChartControl1.DataBind();

                    KonusalDagilimCollection CollYeti = new KonusalDagilimCollection();
                    IPredicateExpression ExpYeti = new PredicateExpression();
                    ExpYeti.AddWithAnd(KonusalDagilimFields.KonusalDagilimKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                    CollYeti.GetMulti(ExpYeti);

                    grid_konu.DataSource = CollYeti;
                    grid_konu.DataBind();

                    DigerBirimlerCollection CollTop = new DigerBirimlerCollection();
                    IPredicateExpression ExpTop = new PredicateExpression();
                    ExpTop.AddWithAnd(DigerBirimlerFields.DigerBirimlerKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                    CollTop.GetMulti(ExpTop);

                    grid_diger.DataSource = CollTop;
                    grid_diger.DataBind();
                    
                    BildirimAtamaGrupCollection CollGray = new BildirimAtamaGrupCollection();
                    IPredicateExpression ExpGray = new PredicateExpression();
                    ExpGray.AddWithAnd(BildirimAtamaGrupFields.FkGrupId == CollAna[0].GrupId);
                    ExpGray.AddWithAnd(BildirimAtamaGrupFields.BildirimAtamaGrupYonMu == "Hayır");
                    ISortExpression sortgray = new SortExpression();
                    sortgray.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupTarih, SortOperator.Descending));
                    CollGray.GetMulti(ExpGray, 0, sortgray);

                    for (int g = 0; g < CollGray.Count; g++)
                    {
                        if (CollGray[g].FkGrupId == CollAna[0].GrupId)
                        {
                            BildirimCollection CollHan = new BildirimCollection();
                            IPredicateExpression ExpHan = new PredicateExpression();
                            ExpHan.AddWithAnd(BildirimFields.BildirimId == CollGray[g].FkBildirimId);
                            CollHan.GetMulti(ExpHan);

                            if (CollHan.Count > 0)
                            {
                                if (CollHan[0].FkBildirimSonucId == CollSon1[0].BildirimSonucId)
                                {
                                    DigerBirimlerAyrintiEntity EntKayt = new DigerBirimlerAyrintiEntity();
                                    EntKayt.DigerBirimlerAyrintiDurum = "Atandı";
                                    EntKayt.DigerBirimlerAyrintiKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                    EntKayt.DigerBirimlerAyrintiIcerik = CollHan[0].BildirimMetin;
                                    EntKayt.DigerBirimlerAyrintiNo = CollHan[0].BildirimId;
                                    EntKayt.DigerBirimlerAyrintiSonDurum = CollHan[0].BildirimAtanmaDurumu;
                                    EntKayt.DigerBirimlerAyrintiSure = CollHan[0].BildirimToplamSure;
                                    EntKayt.Save();
                                }

                                else if (CollHan[0].FkBildirimSonucId == CollSon2[0].BildirimSonucId)
                                {
                                    DigerBirimlerAyrintiEntity EntKayt = new DigerBirimlerAyrintiEntity();
                                    EntKayt.DigerBirimlerAyrintiDurum = "İnceleniyor";
                                    EntKayt.DigerBirimlerAyrintiKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                    EntKayt.DigerBirimlerAyrintiIcerik = CollHan[0].BildirimMetin;
                                    EntKayt.DigerBirimlerAyrintiNo = CollHan[0].BildirimId;
                                    EntKayt.DigerBirimlerAyrintiSonDurum = CollHan[0].BildirimAtanmaDurumu;
                                    EntKayt.DigerBirimlerAyrintiSure = CollHan[0].BildirimToplamSure;
                                    EntKayt.Save();
                                }

                                else if (CollHan[0].FkBildirimSonucId == CollSon3[0].BildirimSonucId)
                                {
                                    DigerBirimlerAyrintiEntity EntKayt = new DigerBirimlerAyrintiEntity();
                                    EntKayt.DigerBirimlerAyrintiKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                                    EntKayt.DigerBirimlerAyrintiDurum = "İnceleniyor-Ek Süre";
                                    EntKayt.DigerBirimlerAyrintiIcerik = CollHan[0].BildirimMetin;
                                    EntKayt.DigerBirimlerAyrintiNo = CollHan[0].BildirimId;
                                    EntKayt.DigerBirimlerAyrintiSonDurum = CollHan[0].BildirimAtanmaDurumu;
                                    EntKayt.DigerBirimlerAyrintiSure = CollHan[0].BildirimToplamSure;
                                    EntKayt.Save();
                                }
                            }
                        }
                    }

                    DigerBirimlerAyrintiCollection CollSan = new DigerBirimlerAyrintiCollection();
                    IPredicateExpression ExpSan = new PredicateExpression();
                    ExpSan.AddWithAnd(DigerBirimlerAyrintiFields.DigerBirimlerAyrintiKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                    CollSan.GetMulti(ExpSan);

                    grid_ayrinti.DataSource = CollSan;
                    grid_ayrinti.DataBind();
                }
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen Sistem Yöneticisi ile görüşünüz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void grid_diger_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_diger.SettingsPager.PageSize.ToString();
            CollParam[0].Save();

            DigerBirimlerCollection CollTop = new DigerBirimlerCollection();
            IPredicateExpression ExpTop = new PredicateExpression();
            ExpTop.AddWithAnd(DigerBirimlerFields.DigerBirimlerKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollTop.GetMulti(ExpTop);

            grid_diger.DataSource = CollTop;
            grid_diger.DataBind();
        }

        protected void grid_ayrinti_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_ayrinti.SettingsPager.PageSize.ToString();
            CollParam[0].Save();

            DigerBirimlerAyrintiCollection CollAyr = new DigerBirimlerAyrintiCollection();
            IPredicateExpression ExpAyr = new PredicateExpression();
            ExpAyr.AddWithAnd(DigerBirimlerAyrintiFields.DigerBirimlerAyrintiKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollAyr.GetMulti(ExpAyr);

            grid_ayrinti.DataSource = CollAyr;
            grid_ayrinti.DataBind();
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

            KonusalDagilimCollection CollYet = new KonusalDagilimCollection();
            IPredicateExpression ExpYet = new PredicateExpression();
            ExpYet.AddWithAnd(KonusalDagilimFields.KonusalDagilimKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollYet.GetMulti(ExpYet);

            grid_konu.DataSource = CollYet;
            grid_konu.DataBind();
        }

        protected void grid_diger_PageIndexChanged(object sender, EventArgs e)
        {
            DigerBirimlerCollection CollTop = new DigerBirimlerCollection();
            IPredicateExpression ExpTop = new PredicateExpression();
            ExpTop.AddWithAnd(DigerBirimlerFields.DigerBirimlerKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollTop.GetMulti(ExpTop);

            grid_diger.DataSource = CollTop;
            grid_diger.DataBind();
        }

        protected void grid_ayrinti_PageIndexChanged(object sender, EventArgs e)
        {
            DigerBirimlerAyrintiCollection CollAyr = new DigerBirimlerAyrintiCollection();
            IPredicateExpression ExpAyr = new PredicateExpression();
            ExpAyr.AddWithAnd(DigerBirimlerAyrintiFields.DigerBirimlerAyrintiKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollAyr.GetMulti(ExpAyr);

            grid_ayrinti.DataSource = CollAyr;
            grid_ayrinti.DataBind();
        }
        
        //TRYYYYYYYYYYYYYYYYYYY
        //CATCHHHHHHHHHHHHHHHHH
        //EKLEDİK SON ALINAN HATA İLE İLGİLİ
        //TRYYYYYYYYYYYYYYYYYYY
        //CATCHHHHHHHHHHHHHHHHH
        //EKLEDİK SON ALINAN HATA İLE İLGİLİ
        //TRYYYYYYYYYYYYYYYYYYY
        //CATCHHHHHHHHHHHHHHHHH
        //EKLEDİK SON ALINAN HATA İLE İLGİLİ
        //TRYYYYYYYYYYYYYYYYYYY
        //CATCHHHHHHHHHHHHHHHHH
        //EKLEDİK SON ALINAN HATA İLE İLGİLİ
        //TRYYYYYYYYYYYYYYYYYYY
        //CATCHHHHHHHHHHHHHHHHH
        //EKLEDİK SON ALINAN HATA İLE İLGİLİ
        //TRYYYYYYYYYYYYYYYYYYY
        //CATCHHHHHHHHHHHHHHHHH
        //EKLEDİK SON ALINAN HATA İLE İLGİLİ
        //TRYYYYYYYYYYYYYYYYYYY
        //CATCHHHHHHHHHHHHHHHHH
        //EKLEDİK SON ALINAN HATA İLE İLGİLİ
        //TRYYYYYYYYYYYYYYYYYYY
        //CATCHHHHHHHHHHHHHHHHH
        //EKLEDİK SON ALINAN HATA İLE İLGİLİ
        //TRYYYYYYYYYYYYYYYYYYY
        //CATCHHHHHHHHHHHHHHHHH
        //EKLEDİK SON ALINAN HATA İLE İLGİLİ
        //TRYYYYYYYYYYYYYYYYYYY
        //CATCHHHHHHHHHHHHHHHHH
        //EKLEDİK SON ALINAN HATA İLE İLGİLİ
        //TRYYYYYYYYYYYYYYYYYYY
        //CATCHHHHHHHHHHHHHHHHH
        //EKLEDİK SON ALINAN HATA İLE İLGİLİ

        protected void grid_konu_PageIndexChanged(object sender, EventArgs e)
        {
            KonusalDagilimCollection CollYet = new KonusalDagilimCollection();
            IPredicateExpression ExpYet = new PredicateExpression();
            ExpYet.AddWithAnd(KonusalDagilimFields.KonusalDagilimKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollYet.GetMulti(ExpYet);

            grid_konu.DataSource = CollYet;
            grid_konu.DataBind();
        }

        protected void grid_diger_ProcessColumnAutoFilter(object sender, EventArgs e)
        {
            DigerBirimlerCollection CollTop = new DigerBirimlerCollection();
            IPredicateExpression ExpTop = new PredicateExpression();
            ExpTop.AddWithAnd(DigerBirimlerFields.DigerBirimlerKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollTop.GetMulti(ExpTop);

            grid_diger.DataSource = CollTop;
            grid_diger.DataBind();
        }

        protected void grid_ayrinti_ProcessColumnAutoFilter(object sender, EventArgs e)
        {
            DigerBirimlerAyrintiCollection CollAyr = new DigerBirimlerAyrintiCollection();
            IPredicateExpression ExpAyr = new PredicateExpression();
            ExpAyr.AddWithAnd(DigerBirimlerAyrintiFields.DigerBirimlerAyrintiKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollAyr.GetMulti(ExpAyr);

            grid_ayrinti.DataSource = CollAyr;
            grid_ayrinti.DataBind();
        }

        protected void grid_konu_ProcessColumnAutoFilter(object sender, EventArgs e)
        {
            KonusalDagilimCollection CollYet = new KonusalDagilimCollection();
            IPredicateExpression ExpYet = new PredicateExpression();
            ExpYet.AddWithAnd(KonusalDagilimFields.KonusalDagilimKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollYet.GetMulti(ExpYet);

            grid_konu.DataSource = CollYet;
            grid_konu.DataBind();
        }

        protected void grid_diger_BeforeColumnSortingGrouping(object sender, EventArgs e)
        {
            DigerBirimlerCollection CollTop = new DigerBirimlerCollection();
            IPredicateExpression ExpTop = new PredicateExpression();
            ExpTop.AddWithAnd(DigerBirimlerFields.DigerBirimlerKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollTop.GetMulti(ExpTop);

            grid_diger.DataSource = CollTop;
            grid_diger.DataBind();
        }

        protected void grid_ayrinti_BeforeColumnSortingGrouping(object sender, EventArgs e)
        {
            DigerBirimlerAyrintiCollection CollAyr = new DigerBirimlerAyrintiCollection();
            IPredicateExpression ExpAyr = new PredicateExpression();
            ExpAyr.AddWithAnd(DigerBirimlerAyrintiFields.DigerBirimlerAyrintiKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollAyr.GetMulti(ExpAyr);

            grid_ayrinti.DataSource = CollAyr;
            grid_ayrinti.DataBind();
        }

        protected void grid_konu_BeforeColumnSortingGrouping(object sender, EventArgs e)
        {
            KonusalDagilimCollection CollYet = new KonusalDagilimCollection();
            IPredicateExpression ExpYet = new PredicateExpression();
            ExpYet.AddWithAnd(KonusalDagilimFields.KonusalDagilimKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollYet.GetMulti(ExpYet);

            grid_konu.DataSource = CollYet;
            grid_konu.DataBind();
        }
    }
}