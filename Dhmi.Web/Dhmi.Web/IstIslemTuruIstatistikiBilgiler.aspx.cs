using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using DevExpress.XtraCharts;
using System.Drawing;
using System.Globalization;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using dhmi.EntityClasses;
using System.Web;

namespace Dhmi.Web
{
    public partial class IstIslemTuruIstatistikiBilgiler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
                if (yetki == "Admin" || yetki == "Takım Lideri" || yetki == "Kurum Sistem Yöneticisi" || yetki == "Kurum Makam")
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
                txt_bas_tarihi.Text = DateTime.Today.ToShortDateString();
                txt_bit_tarihi.Text = DateTime.Today.ToShortDateString();

                cb_yil.Items.Add("2015");
                cb_yil.Items.Add("2016");

                cb_ay.Items.Add("01 - Ocak");
                cb_ay.Items.Add("02 - Şubat");
                cb_ay.Items.Add("03 - Mart");
                cb_ay.Items.Add("04 - Nisan");
                cb_ay.Items.Add("05 - Mayıs");
                cb_ay.Items.Add("06 - Haziran");
                cb_ay.Items.Add("07 - Temmuz");
                cb_ay.Items.Add("08 - Ağustos");
                cb_ay.Items.Add("09 - Eylül");
                cb_ay.Items.Add("10 - Ekim");
                cb_ay.Items.Add("11 - Kasım");
                cb_ay.Items.Add("12 - Aralık");

                cb_saat.Items.Add("00:00");
                cb_saat.Items.Add("01:00");
                cb_saat.Items.Add("02:00");
                cb_saat.Items.Add("03:00");
                cb_saat.Items.Add("04:00");
                cb_saat.Items.Add("05:00");
                cb_saat.Items.Add("06:00");
                cb_saat.Items.Add("07:00");
                cb_saat.Items.Add("08:00");
                cb_saat.Items.Add("09:00");
                cb_saat.Items.Add("10:00");
                cb_saat.Items.Add("11:00");
                cb_saat.Items.Add("12:00");
                cb_saat.Items.Add("13:00");
                cb_saat.Items.Add("14:00");
                cb_saat.Items.Add("15:00");
                cb_saat.Items.Add("16:00");
                cb_saat.Items.Add("17:00");
                cb_saat.Items.Add("18:00");
                cb_saat.Items.Add("19:00");
                cb_saat.Items.Add("20:00");
                cb_saat.Items.Add("21:00");
                cb_saat.Items.Add("22:00");
                cb_saat.Items.Add("23:00");

                Session["icerden_gel_tarih"] = null;
                Session["icerden_gel_saat"] = null;

                ChartTitle title = new ChartTitle();
                title.TextColor = System.Drawing.Color.Maroon;
                title.Font = new Font("Calibri", 18, FontStyle.Regular);
                title.Text = "İşlem Türü Sayıları";
                WebChartControl1.Titles.Add(title);

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
                title3.Text = "Adet Bilgileri";
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
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "İşlem Türü Bazlı İstatistik Bilgileri");
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
            }

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            IstatistikCollection CollMen = new IstatistikCollection();
            IPredicateExpression ExpMen = new PredicateExpression();
            ExpMen.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollMen.GetMulti(ExpMen);

            for (int i = 0; i < CollMen.Count; i++)
            {
                CollMen[i].Delete();
                CollMen[i].Save();
            }

            BildirimTuruCollection CollTur = new BildirimTuruCollection();
            IPredicateExpression ExpTur = new PredicateExpression();
            ISortExpression sorttur = new SortExpression();
            ExpTur.AddWithAnd(BildirimTuruFields.BildirimTuruDurum == true);
            sorttur.Add(new SortClause(BildirimTuruFields.BildirimTuruAd, SortOperator.Ascending));
            CollTur.GetMulti(ExpTur, 0, sorttur);

            for (int i = 0; i < CollTur.Count; i++)
            {
                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();                
                ExpBil.AddWithAnd(BildirimFields.FkBildirimTuruId == CollTur[i].BildirimTuruId);

                if (Session["icerden_gel_tarih"] != null)
                {
                    ExpBil.AddWithAnd(BildirimFields.BildirimSonIslemTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                    ExpBil.AddWithAnd(BildirimFields.BildirimSonIslemTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
                }

                if (Session["icerden_gel_saat"] != null)
                {
                    DateTime bas = DateTime.Today;
                    DateTime bit = DateTime.Today;

                    int giris = 0;

                    if (cb_yil.Text != "" && cb_ay.Text == "" && cb_gun.Text == "" && cb_saat.Text == "")
                    {
                        giris = 1;
                        bas = Convert.ToDateTime("01.01." + cb_yil.Text);
                        bit = Convert.ToDateTime("31.12." + cb_yil.Text);
                    }

                    else if (cb_yil.Text != "" && cb_ay.Text != "" && cb_gun.Text == "" && cb_saat.Text == "")
                    {
                        giris = 1;

                        int daysInJuly = System.DateTime.DaysInMonth(Convert.ToInt16(cb_yil.Text), Convert.ToInt16(cb_ay.Text.Substring(0, 2)));
                        bas = Convert.ToDateTime("01." + cb_ay.Text.Substring(0, 2) + "." + cb_yil.Text);
                        bit = Convert.ToDateTime(daysInJuly.ToString() + "." + cb_ay.Text.Substring(0, 2) + "." + cb_yil.Text);
                    }

                    else if (cb_yil.Text != "" && cb_ay.Text != "" && cb_gun.Text != "" && cb_saat.Text == "")
                    {
                        giris = 1;

                        bas = Convert.ToDateTime(cb_gun.Text.Substring(0, 2) + "." + cb_ay.Text.Substring(0, 2) + "." + cb_yil.Text);
                        bit = Convert.ToDateTime(cb_gun.Text.Substring(0, 2) + "." + cb_ay.Text.Substring(0, 2) + "." + cb_yil.Text);
                        bit = bit.AddDays(1);
                    }

                    else if (cb_yil.Text != "" && cb_ay.Text != "" && cb_gun.Text != "" && cb_saat.Text != "")
                    {
                        giris = 1;

                        bas = Convert.ToDateTime(cb_saat.Text + ":00.000 " + cb_gun.Text.Substring(0, 2) + "." + cb_ay.Text.Substring(0, 2) + "." + cb_yil.Text);
                        bit = Convert.ToDateTime(cb_saat.Text + ":00.000 " + cb_gun.Text.Substring(0, 2) + "." + cb_ay.Text.Substring(0, 2) + "." + cb_yil.Text);
                        bit = bit.AddHours(1);
                    }

                    else
                    {
                        giris = 0;
                    }

                    if (giris == 1)
                    {
                        ExpBil.AddWithAnd(BildirimFields.BildirimSonIslemTarih >= bas);
                        ExpBil.AddWithAnd(BildirimFields.BildirimSonIslemTarih <= bit);
                    }
                }

                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollTur[i].BildirimTuruAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.Save();
                }
            }

            IstatistikCollection CollMen2 = new IstatistikCollection();
            IPredicateExpression ExpMen2 = new PredicateExpression();
            ExpMen2.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollMen2.GetMulti(ExpMen2);

            WebChartControl1.SeriesDataMember = "IstatistikAd";
            WebChartControl1.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
            WebChartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
            WebChartControl1.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
            WebChartControl1.SeriesTemplate.ToolTipSeriesPattern = "{S}: {V}";
            WebChartControl1.SeriesTemplate.ToolTipPointPattern = "{S}: {V}";
            WebChartControl1.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";

            WebChartControl1.DataSource = CollMen2;
            WebChartControl1.DataBind();
        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            Session["icerden_gel_tarih"] = "0";
            Session["icerden_gel_saat"] = null;

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            IstatistikCollection CollMen = new IstatistikCollection();
            IPredicateExpression ExpMen = new PredicateExpression();
            ExpMen.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollMen.GetMulti(ExpMen);

            for (int i = 0; i < CollMen.Count; i++)
            {
                CollMen[i].Delete();
                CollMen[i].Save();
            }

            BildirimTuruCollection CollTur = new BildirimTuruCollection();
            IPredicateExpression ExpTur = new PredicateExpression();
            ISortExpression sorttur = new SortExpression();
            ExpTur.AddWithAnd(BildirimTuruFields.BildirimTuruDurum == true);
            sorttur.Add(new SortClause(BildirimTuruFields.BildirimTuruAd, SortOperator.Ascending));
            CollTur.GetMulti(ExpTur, 0, sorttur);

            for (int i = 0; i < CollTur.Count; i++)
            {
                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd(BildirimFields.BildirimToplamSure != "---");
                ExpBil.AddWithAnd(BildirimFields.FkBildirimTuruId == CollTur[i].BildirimTuruId);
                ExpBil.AddWithAnd(BildirimFields.BildirimSonIslemTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                ExpBil.AddWithAnd(BildirimFields.BildirimSonIslemTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollTur[i].BildirimTuruAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.Save();
                }
            }

            IstatistikCollection CollMen2 = new IstatistikCollection();
            IPredicateExpression ExpMen2 = new PredicateExpression();
            ExpMen2.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollMen2.GetMulti(ExpMen2);

            WebChartControl1.SeriesDataMember = "IstatistikAd";
            WebChartControl1.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
            WebChartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
            WebChartControl1.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
            WebChartControl1.SeriesTemplate.ToolTipSeriesPattern = "{S}: {V}";
            WebChartControl1.SeriesTemplate.ToolTipPointPattern = "{S}: {V}";
            WebChartControl1.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";

            WebChartControl1.DataSource = CollMen2;
            WebChartControl1.DataBind();

            cb_yil.Text = "";
            cb_yil.NullText = "Seçiniz...";
            cb_ay.Text = "";
            cb_ay.NullText = "Seçiniz...";
            cb_gun.Text = "";
            cb_gun.NullText = "Seçiniz...";
            cb_saat.Text = "";
            cb_saat.NullText = "Seçiniz...";

            cb_gun.Enabled = true;
            cb_saat.Enabled = true;
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_bas_tarihi.Text = DateTime.Today.ToShortDateString();
            txt_bit_tarihi.Text = DateTime.Today.ToShortDateString();

            Session["icerden_gel_tarih"] = null;

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            IstatistikCollection CollMen = new IstatistikCollection();
            IPredicateExpression ExpMen = new PredicateExpression();
            ExpMen.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollMen.GetMulti(ExpMen);

            for (int i = 0; i < CollMen.Count; i++)
            {
                CollMen[i].Delete();
                CollMen[i].Save();
            }

            BildirimTuruCollection CollTur = new BildirimTuruCollection();
            IPredicateExpression ExpTur = new PredicateExpression();
            ISortExpression sorttur = new SortExpression();
            ExpTur.AddWithAnd(BildirimTuruFields.BildirimTuruDurum == true);
            sorttur.Add(new SortClause(BildirimTuruFields.BildirimTuruAd, SortOperator.Ascending));
            CollTur.GetMulti(ExpTur, 0, sorttur);

            for (int i = 0; i < CollTur.Count; i++)
            {
                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd(BildirimFields.BildirimToplamSure != "---");
                ExpBil.AddWithAnd(BildirimFields.FkBildirimTuruId == CollTur[i].BildirimTuruId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollTur[i].BildirimTuruAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.Save();
                }
            }

            IstatistikCollection CollMen2 = new IstatistikCollection();
            IPredicateExpression ExpMen2 = new PredicateExpression();
            ExpMen2.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollMen2.GetMulti(ExpMen2);

            WebChartControl1.SeriesDataMember = "IstatistikAd";
            WebChartControl1.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
            WebChartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
            WebChartControl1.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
            WebChartControl1.SeriesTemplate.ToolTipSeriesPattern = "{S}: {V}";
            WebChartControl1.SeriesTemplate.ToolTipPointPattern = "{S}: {V}";
            WebChartControl1.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";

            WebChartControl1.DataSource = CollMen2;
            WebChartControl1.DataBind();
        }

        protected void btn_kaydet_ana_Click(object sender, EventArgs e)
        {
            txt_bas_tarihi.Text = DateTime.Today.ToShortDateString();
            txt_bit_tarihi.Text = DateTime.Today.ToShortDateString();

            Session["icerden_gel_saat"] = "0";
            Session["icerden_gel_tarih"] = null;

            DateTime bas = DateTime.Today;
            DateTime bit = DateTime.Today;
            int giris = 0;

            if (cb_yil.Text != "" && cb_ay.Text == "" && cb_gun.Text == "" && cb_saat.Text == "")
            {
                giris = 1;
                bas = Convert.ToDateTime("01.01." + cb_yil.Text);
                bit = Convert.ToDateTime("31.12." + cb_yil.Text);
            }

            else if (cb_yil.Text != "" && cb_ay.Text != "" && cb_gun.Text == "" && cb_saat.Text == "")
            {
                giris = 1;

                int daysInJuly = System.DateTime.DaysInMonth(Convert.ToInt16(cb_yil.Text), Convert.ToInt16(cb_ay.Text.Substring(0, 2)));
                bas = Convert.ToDateTime("01." + cb_ay.Text.Substring(0, 2) + "." + cb_yil.Text);
                bit = Convert.ToDateTime(daysInJuly.ToString() + "." + cb_ay.Text.Substring(0, 2) + "." + cb_yil.Text);
            }

            else if (cb_yil.Text != "" && cb_ay.Text != "" && cb_gun.Text != "" && cb_saat.Text == "")
            {
                giris = 1;

                bas = Convert.ToDateTime(cb_gun.Text.Substring(0, 2) + "." + cb_ay.Text.Substring(0, 2) + "." + cb_yil.Text);
                bit = Convert.ToDateTime(cb_gun.Text.Substring(0, 2) + "." + cb_ay.Text.Substring(0, 2) + "." + cb_yil.Text);
                bit = bit.AddDays(1);
            }

            else if (cb_yil.Text != "" && cb_ay.Text != "" && cb_gun.Text != "" && cb_saat.Text != "")
            {
                giris = 1;

                bas = Convert.ToDateTime(cb_saat.Text + ":00.000 " + cb_gun.Text.Substring(0, 2) + "." + cb_ay.Text.Substring(0, 2) + "." + cb_yil.Text);
                bit = Convert.ToDateTime(cb_saat.Text + ":00.000 " + cb_gun.Text.Substring(0, 2) + "." + cb_ay.Text.Substring(0, 2) + "." + cb_yil.Text);
                bit = bit.AddHours(1);
            }

            else
            {
                giris = 0;
            }

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            IstatistikCollection CollMen = new IstatistikCollection();
            IPredicateExpression ExpMen = new PredicateExpression();
            ExpMen.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollMen.GetMulti(ExpMen);

            for (int i = 0; i < CollMen.Count; i++)
            {
                CollMen[i].Delete();
                CollMen[i].Save();
            }

            BildirimTuruCollection CollTur = new BildirimTuruCollection();
            IPredicateExpression ExpTur = new PredicateExpression();
            ISortExpression sorttur = new SortExpression();
            ExpTur.AddWithAnd(BildirimTuruFields.BildirimTuruDurum == true);
            sorttur.Add(new SortClause(BildirimTuruFields.BildirimTuruAd, SortOperator.Ascending));
            CollTur.GetMulti(ExpTur, 0, sorttur);

            for (int i = 0; i < CollTur.Count; i++)
            {
                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd(BildirimFields.BildirimToplamSure != "---");
                ExpBil.AddWithAnd(BildirimFields.FkBildirimTuruId == CollTur[i].BildirimTuruId);

                if (giris == 1)
                {
                    ExpBil.AddWithAnd(BildirimFields.BildirimSonIslemTarih >= bas);
                    ExpBil.AddWithAnd(BildirimFields.BildirimSonIslemTarih <= bit);
                }

                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollTur[i].BildirimTuruAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.Save();
                }
            }

            IstatistikCollection CollMen2 = new IstatistikCollection();
            IPredicateExpression ExpMen2 = new PredicateExpression();
            ExpMen2.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollMen2.GetMulti(ExpMen2);

            WebChartControl1.SeriesDataMember = "IstatistikAd";
            WebChartControl1.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
            WebChartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
            WebChartControl1.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
            WebChartControl1.SeriesTemplate.ToolTipSeriesPattern = "{S}: {V}";
            WebChartControl1.SeriesTemplate.ToolTipPointPattern = "{S}: {V}";
            WebChartControl1.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";

            WebChartControl1.DataSource = CollMen2;
            WebChartControl1.DataBind();
        }

        protected void btn_temizle_ana_Click(object sender, EventArgs e)
        {
            Session["icerden_gel_saat"] = null;

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            IstatistikCollection CollMen = new IstatistikCollection();
            IPredicateExpression ExpMen = new PredicateExpression();
            ExpMen.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollMen.GetMulti(ExpMen);

            for (int i = 0; i < CollMen.Count; i++)
            {
                CollMen[i].Delete();
                CollMen[i].Save();
            }

            BildirimTuruCollection CollTur = new BildirimTuruCollection();
            IPredicateExpression ExpTur = new PredicateExpression();
            ISortExpression sorttur = new SortExpression();
            ExpTur.AddWithAnd(BildirimTuruFields.BildirimTuruDurum == true);
            sorttur.Add(new SortClause(BildirimTuruFields.BildirimTuruAd, SortOperator.Ascending));
            CollTur.GetMulti(ExpTur, 0, sorttur);

            for (int i = 0; i < CollTur.Count; i++)
            {
                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd(BildirimFields.BildirimToplamSure != "---");
                ExpBil.AddWithAnd(BildirimFields.FkBildirimTuruId == CollTur[i].BildirimTuruId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollTur[i].BildirimTuruAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.Save();
                }
            }

            IstatistikCollection CollMen2 = new IstatistikCollection();
            IPredicateExpression ExpMen2 = new PredicateExpression();
            ExpMen2.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollMen2.GetMulti(ExpMen2);

            WebChartControl1.SeriesDataMember = "IstatistikAd";
            WebChartControl1.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
            WebChartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
            WebChartControl1.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
            WebChartControl1.SeriesTemplate.ToolTipSeriesPattern = "{S}: {V}";
            WebChartControl1.SeriesTemplate.ToolTipPointPattern = "{S}: {V}";
            WebChartControl1.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";

            WebChartControl1.DataSource = CollMen2;
            WebChartControl1.DataBind();
        }

        protected void cb_ay_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["icerden_gel_saat"] = "0";

            cb_gun.Items.Clear();

            int daysInJuly = System.DateTime.DaysInMonth(Convert.ToInt16(cb_yil.Text), Convert.ToInt16(cb_ay.Text.Substring(0, 2)));

            for (int i = 1; i <= daysInJuly; i++)
            {
                string tar_top = cb_yil.Text + "-" + cb_ay.Text.Substring(0, 2) + "-" + i.ToString();

                string son_gun = CultureInfo.CurrentCulture.DateTimeFormat.DayNames[(int)DateTime.Parse(tar_top).DayOfWeek];

                cb_gun.Items.Add(i.ToString() + " - " + son_gun);
            }

            cb_gun.Enabled = true;
            cb_saat.Enabled = true;
        }
    }
}