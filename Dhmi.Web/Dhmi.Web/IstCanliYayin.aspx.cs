using System;
using DevExpress.XtraCharts;
using System.Drawing;
using dhmi.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.HelperClasses;
using dhmi.EntityClasses;
using System.Web;

namespace Dhmi.Web
{
    public partial class IstCanliYayin : System.Web.UI.Page
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
                ChartTitle title = new ChartTitle();
                title.TextColor = System.Drawing.Color.Maroon;
                title.Font = new Font("Calibri", 18, FontStyle.Regular);
                title.Text = "Bildirim (ATANDI)";
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

                ChartTitle titleek1 = new ChartTitle();
                titleek1.TextColor = System.Drawing.Color.Maroon;
                titleek1.Font = new Font("Calibri", 18, FontStyle.Regular);
                titleek1.Text = "Bildirim (İNCELENİYOR)";
                WebChartControl2.Titles.Add(titleek1);

                ChartTitle titleek12 = new ChartTitle();
                titleek12.TextColor = System.Drawing.Color.DarkGray;
                titleek12.Dock = ChartTitleDockStyle.Bottom;
                titleek12.Text = "DHMİ İletişim Merkezi";
                titleek12.Font = new Font("Calibri", 8, FontStyle.Regular);
                titleek12.Alignment = StringAlignment.Far;
                WebChartControl2.Titles.Add(titleek12);

                ChartTitle titleek13 = new ChartTitle();
                titleek13.TextColor = System.Drawing.Color.Brown;
                titleek13.Dock = ChartTitleDockStyle.Left;
                titleek13.Text = "Adet Bilgileri";
                titleek13.Font = new Font("Calibri", 10, FontStyle.Regular);
                titleek13.Alignment = StringAlignment.Center;
                WebChartControl2.Titles.Add(titleek13);

                ChartTitle titleek2 = new ChartTitle();
                titleek2.TextColor = System.Drawing.Color.Maroon;
                titleek2.Font = new Font("Calibri", 18, FontStyle.Regular);
                titleek2.Text = "Bildirim (İNCELENİYOR-EK SÜRE)";
                WebChartControl3.Titles.Add(titleek2);

                ChartTitle titleek22 = new ChartTitle();
                titleek22.TextColor = System.Drawing.Color.DarkGray;
                titleek22.Dock = ChartTitleDockStyle.Bottom;
                titleek22.Text = "DHMİ İletişim Merkezi";
                titleek22.Font = new Font("Calibri", 8, FontStyle.Regular);
                titleek22.Alignment = StringAlignment.Far;
                WebChartControl3.Titles.Add(titleek22);

                ChartTitle titleek23 = new ChartTitle();
                titleek23.TextColor = System.Drawing.Color.Brown;
                titleek23.Dock = ChartTitleDockStyle.Left;
                titleek23.Text = "Adet Bilgileri";
                titleek23.Font = new Font("Calibri", 10, FontStyle.Regular);
                titleek23.Alignment = StringAlignment.Center;
                WebChartControl3.Titles.Add(titleek23);

                ChartTitle titleek3 = new ChartTitle();
                titleek3.TextColor = System.Drawing.Color.Maroon;
                titleek3.Font = new Font("Calibri", 18, FontStyle.Regular);
                titleek3.Text = "Bildirim (SONUÇLANDI)";
                WebChartControl4.Titles.Add(titleek3);

                ChartTitle titleek32 = new ChartTitle();
                titleek32.TextColor = System.Drawing.Color.DarkGray;
                titleek32.Dock = ChartTitleDockStyle.Bottom;
                titleek32.Text = "DHMİ İletişim Merkezi";
                titleek32.Font = new Font("Calibri", 8, FontStyle.Regular);
                titleek32.Alignment = StringAlignment.Far;
                WebChartControl4.Titles.Add(titleek32);

                ChartTitle titleek33 = new ChartTitle();
                titleek33.TextColor = System.Drawing.Color.Brown;
                titleek33.Dock = ChartTitleDockStyle.Left;
                titleek33.Text = "Adet Bilgileri";
                titleek33.Font = new Font("Calibri", 10, FontStyle.Regular);
                titleek33.Alignment = StringAlignment.Center;
                WebChartControl4.Titles.Add(titleek33);

                ChartTitle titleek4 = new ChartTitle();
                titleek4.TextColor = System.Drawing.Color.Maroon;
                titleek4.Font = new Font("Calibri", 18, FontStyle.Regular);
                titleek4.Text = "Bildirim (REDDEDİLDİ)";
                WebChartControl5.Titles.Add(titleek4);

                ChartTitle titleek42 = new ChartTitle();
                titleek42.TextColor = System.Drawing.Color.DarkGray;
                titleek42.Dock = ChartTitleDockStyle.Bottom;
                titleek42.Text = "DHMİ İletişim Merkezi";
                titleek42.Font = new Font("Calibri", 8, FontStyle.Regular);
                titleek42.Alignment = StringAlignment.Far;
                WebChartControl5.Titles.Add(titleek42);

                ChartTitle titleek43 = new ChartTitle();
                titleek43.TextColor = System.Drawing.Color.Brown;
                titleek43.Dock = ChartTitleDockStyle.Left;
                titleek43.Text = "Adet Bilgileri";
                titleek43.Font = new Font("Calibri", 10, FontStyle.Regular);
                titleek43.Alignment = StringAlignment.Center;
                WebChartControl5.Titles.Add(titleek43);

                ChartTitle titleek5 = new ChartTitle();
                titleek5.TextColor = System.Drawing.Color.Maroon;
                titleek5.Font = new Font("Calibri", 18, FontStyle.Regular);
                titleek5.Text = "Bildirim (SINIR AŞILDI)";
                WebChartControl6.Titles.Add(titleek5);

                ChartTitle titleek52 = new ChartTitle();
                titleek52.TextColor = System.Drawing.Color.DarkGray;
                titleek52.Dock = ChartTitleDockStyle.Bottom;
                titleek52.Text = "DHMİ İletişim Merkezi";
                titleek52.Font = new Font("Calibri", 8, FontStyle.Regular);
                titleek52.Alignment = StringAlignment.Far;
                WebChartControl6.Titles.Add(titleek52);

                ChartTitle titleek53 = new ChartTitle();
                titleek53.TextColor = System.Drawing.Color.Brown;
                titleek53.Dock = ChartTitleDockStyle.Left;
                titleek53.Text = "Adet Bilgileri";
                titleek53.Font = new Font("Calibri", 10, FontStyle.Regular);
                titleek53.Alignment = StringAlignment.Center;
                WebChartControl6.Titles.Add(titleek53);

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
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Canlı (Başkanlık-Genel Bildirim)");
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

            GrupCollection CollGr = new GrupCollection();
            IPredicateExpression ExpGr = new PredicateExpression();
            ISortExpression sortgr = new SortExpression();
            sortgr.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGr.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Başkan%")));
            CollGr.GetMulti(ExpGr, 0, sortgr);

            for (int i = 0; i < CollGr.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGr[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0) 
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGr[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Atandı";
                    EntKay.Save();
                }
            }       
     
            GrupCollection CollGr2 = new GrupCollection();
            IPredicateExpression ExpGr2 = new PredicateExpression();
            ISortExpression sortgr2 = new SortExpression();
            sortgr2.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGr2.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Basın%")));
            CollGr2.GetMulti(ExpGr2, 0, sortgr2);

            for (int i = 0; i < CollGr2.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGr2[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGr2[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Atandı";
                    EntKay.Save();
                }
            }

            GrupCollection CollGr3 = new GrupCollection();
            IPredicateExpression ExpGr3 = new PredicateExpression();
            ISortExpression sortgr3 = new SortExpression();
            sortgr3.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGr3.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Hukuk%")));
            CollGr3.GetMulti(ExpGr3, 0, sortgr3);

            for (int i = 0; i < CollGr3.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGr3[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGr3[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Atandı";
                    EntKay.Save();
                }
            }

            IstatistikCollection CollMenAtandi = new IstatistikCollection();
            IPredicateExpression ExpMenAtandi = new PredicateExpression();
            ExpMenAtandi.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            ExpMenAtandi.AddWithAnd(IstatistikFields.IstatistikCanliAd == "Atandı");
            CollMenAtandi.GetMulti(ExpMenAtandi);

            WebChartControl1.SeriesDataMember = "IstatistikAd";
            WebChartControl1.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
            WebChartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
            WebChartControl1.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
            WebChartControl1.SeriesTemplate.ToolTipSeriesPattern = "{S}: {V}";
            WebChartControl1.SeriesTemplate.ToolTipPointPattern = "{S}: {V}";
            WebChartControl1.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";

            WebChartControl1.DataSource = CollMenAtandi;
            WebChartControl1.DataBind();

            GrupCollection CollGrr = new GrupCollection();
            IPredicateExpression ExpGrr = new PredicateExpression();
            ISortExpression sortgrr = new SortExpression();
            sortgrr.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrr.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Başkan%")));
            CollGrr.GetMulti(ExpGrr, 0, sortgrr);

            for (int i = 0; i < CollGrr.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrr[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrr[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "İnceleniyor";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrr2 = new GrupCollection();
            IPredicateExpression ExpGrr2 = new PredicateExpression();
            ISortExpression sortgrr2 = new SortExpression();
            sortgrr2.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrr2.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Basın%")));
            CollGrr2.GetMulti(ExpGrr2, 0, sortgrr2);

            for (int i = 0; i < CollGrr2.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrr2[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrr2[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "İnceleniyor";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrr3 = new GrupCollection();
            IPredicateExpression ExpGrr3 = new PredicateExpression();
            ISortExpression sortgrr3 = new SortExpression();
            sortgrr3.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrr3.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Hukuk%")));
            CollGrr3.GetMulti(ExpGrr3, 0, sortgrr3);

            for (int i = 0; i < CollGrr3.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrr3[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrr3[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "İnceleniyor";
                    EntKay.Save();
                }
            }

            IstatistikCollection CollMenIncele = new IstatistikCollection();
            IPredicateExpression ExpMenIncele = new PredicateExpression();
            ExpMenIncele.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            ExpMenIncele.AddWithAnd(IstatistikFields.IstatistikCanliAd == "İnceleniyor");
            CollMenIncele.GetMulti(ExpMenIncele);

            WebChartControl2.SeriesDataMember = "IstatistikAd";
            WebChartControl2.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
            WebChartControl2.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
            WebChartControl2.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
            WebChartControl2.SeriesTemplate.ToolTipSeriesPattern = "{S}: {V}";
            WebChartControl2.SeriesTemplate.ToolTipPointPattern = "{S}: {V}";
            WebChartControl2.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";

            WebChartControl2.DataSource = CollMenIncele;
            WebChartControl2.DataBind();

            GrupCollection CollGrrr = new GrupCollection();
            IPredicateExpression ExpGrrr = new PredicateExpression();
            ISortExpression sortgrrr = new SortExpression();
            sortgrrr.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrr.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Başkan%")));
            CollGrrr.GetMulti(ExpGrrr, 0, sortgrrr);

            for (int i = 0; i < CollGrrr.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrr[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrr[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "İnceleniyor - Ek Süre";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrrr2 = new GrupCollection();
            IPredicateExpression ExpGrrr2 = new PredicateExpression();
            ISortExpression sortgrrr2 = new SortExpression();
            sortgrrr2.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrr2.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Basın%")));
            CollGrrr2.GetMulti(ExpGrrr2, 0, sortgrrr2);

            for (int i = 0; i < CollGrrr2.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrr2[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrr2[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "İnceleniyor - Ek Süre";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrrr3 = new GrupCollection();
            IPredicateExpression ExpGrrr3 = new PredicateExpression();
            ISortExpression sortgrrr3 = new SortExpression();
            sortgrrr3.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrr3.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Hukuk%")));
            CollGrrr3.GetMulti(ExpGrrr3, 0, sortgrrr3);

            for (int i = 0; i < CollGrrr3.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrr3[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrr3[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "İnceleniyor - Ek Süre";
                    EntKay.Save();
                }
            }

            IstatistikCollection CollMenInceleEk = new IstatistikCollection();
            IPredicateExpression ExpMenInceleEk = new PredicateExpression();
            ExpMenInceleEk.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            ExpMenInceleEk.AddWithAnd(IstatistikFields.IstatistikCanliAd == "İnceleniyor - Ek Süre");
            CollMenInceleEk.GetMulti(ExpMenInceleEk);

            WebChartControl3.SeriesDataMember = "IstatistikAd";
            WebChartControl3.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
            WebChartControl3.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
            WebChartControl3.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
            WebChartControl3.SeriesTemplate.ToolTipSeriesPattern = "{S}: {V}";
            WebChartControl3.SeriesTemplate.ToolTipPointPattern = "{S}: {V}";
            WebChartControl3.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";

            WebChartControl3.DataSource = CollMenInceleEk;
            WebChartControl3.DataBind();

            GrupCollection CollGrrrrr = new GrupCollection();
            IPredicateExpression ExpGrrrrr = new PredicateExpression();
            ISortExpression sortgrrrrr = new SortExpression();
            sortgrrrrr.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrrrr.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Başkan%")));
            CollGrrrrr.GetMulti(ExpGrrrrr, 0, sortgrrrrr);

            for (int i = 0; i < CollGrrrrr.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Sonuçlandı");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrrrr[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrrrr[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Sonuçlandı";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrrrrr2 = new GrupCollection();
            IPredicateExpression ExpGrrrrr2 = new PredicateExpression();
            ISortExpression sortgrrrrr2 = new SortExpression();
            sortgrrrrr2.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrrrr2.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Basın%")));
            CollGrrrrr2.GetMulti(ExpGrrrrr2, 0, sortgrrrrr2);

            for (int i = 0; i < CollGrrrrr2.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Sonuçlandı");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrrrr2[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrrrr2[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Sonuçlandı";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrrrrr3 = new GrupCollection();
            IPredicateExpression ExpGrrrrr3 = new PredicateExpression();
            ISortExpression sortgrrrrr3 = new SortExpression();
            sortgrrrrr3.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrrrr3.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Hukuk%")));
            CollGrrrrr3.GetMulti(ExpGrrrrr3, 0, sortgrrrrr3);

            for (int i = 0; i < CollGrrrrr3.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Sonuçlandı");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrrrr3[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrrrr3[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Sonuçlandı";
                    EntKay.Save();
                }
            }

            IstatistikCollection CollMenSon = new IstatistikCollection();
            IPredicateExpression ExpMenSon = new PredicateExpression();
            ExpMenSon.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            ExpMenSon.AddWithAnd(IstatistikFields.IstatistikCanliAd == "Sonuçlandı");
            CollMenSon.GetMulti(ExpMenSon);

            WebChartControl4.SeriesDataMember = "IstatistikAd";
            WebChartControl4.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
            WebChartControl4.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
            WebChartControl4.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
            WebChartControl4.SeriesTemplate.ToolTipSeriesPattern = "{S}: {V}";
            WebChartControl4.SeriesTemplate.ToolTipPointPattern = "{S}: {V}";
            WebChartControl4.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";

            WebChartControl4.DataSource = CollMenSon;
            WebChartControl4.DataBind();

            GrupCollection CollGrrrr = new GrupCollection();
            IPredicateExpression ExpGrrrr = new PredicateExpression();
            ISortExpression sortgrrrr = new SortExpression();
            sortgrrrr.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrrr.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Başkan%")));
            CollGrrrr.GetMulti(ExpGrrrr, 0, sortgrrrr);

            for (int i = 0; i < CollGrrrr.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Reddedildi");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrrr[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrrr[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Reddedildi";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrrrr2 = new GrupCollection();
            IPredicateExpression ExpGrrrr2 = new PredicateExpression();
            ISortExpression sortgrrrr2 = new SortExpression();
            sortgrrrr2.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrrr2.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Basın%")));
            CollGrrrr2.GetMulti(ExpGrrrr2, 0, sortgrrrr2);

            for (int i = 0; i < CollGrrrr2.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Reddedildi");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrrr2[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrrr2[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Reddedildi";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrrrr3 = new GrupCollection();
            IPredicateExpression ExpGrrrr3 = new PredicateExpression();
            ISortExpression sortgrrrr3 = new SortExpression();
            sortgrrrr3.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrrr3.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Hukuk%")));
            CollGrrrr3.GetMulti(ExpGrrrr3, 0, sortgrrrr3);

            for (int i = 0; i < CollGrrrr3.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Reddedildi");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrrr3[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrrr3[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Reddedildi";
                    EntKay.Save();
                }
            }

            IstatistikCollection CollMenRed = new IstatistikCollection();
            IPredicateExpression ExpMenRed = new PredicateExpression();
            ExpMenRed.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            ExpMenRed.AddWithAnd(IstatistikFields.IstatistikCanliAd == "Reddedildi");
            CollMenRed.GetMulti(ExpMenRed);

            WebChartControl5.SeriesDataMember = "IstatistikAd";
            WebChartControl5.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
            WebChartControl5.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
            WebChartControl5.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
            WebChartControl5.SeriesTemplate.ToolTipSeriesPattern = "{S}: {V}";
            WebChartControl5.SeriesTemplate.ToolTipPointPattern = "{S}: {V}";
            WebChartControl5.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";

            WebChartControl5.DataSource = CollMenRed;
            WebChartControl5.DataBind();

            GrupCollection CollGrrrrrr = new GrupCollection();
            IPredicateExpression ExpGrrrrrr = new PredicateExpression();
            ISortExpression sortgrrrrrr = new SortExpression();
            sortgrrrrrr.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrrrrr.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Başkan%")));
            CollGrrrrrr.GetMulti(ExpGrrrrrr, 0, sortgrrrrrr);

            for (int i = 0; i < CollGrrrrrr.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrrrrr[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    int top_sayi = 0;

                    for (int j = 0; j < CollBil.Count; j++) 
                    {
                        SureTakipCollection CollTak = new SureTakipCollection();
                        IPredicateExpression ExpTak = new PredicateExpression();
                        ExpTak.AddWithAnd(SureTakipFields.FkBildirimId == CollBil[j].BildirimId);
                        ExpTak.AddWithAnd(SureTakipFields.SureTakipTuru == "İncelemeye Alma Süresi");
                        CollTak.GetMulti(ExpTak);

                        if (CollTak.Count > 0) 
                        {
                            if (CollTak[0].SureTakipSaat >= 72)
                            {
                                top_sayi = top_sayi + 1;
                            } 
                        }                                               
                    }

                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrrrrr[i].GrupAd;
                    EntKay.IstatistikAlt = top_sayi.ToString() + " ADET";
                    EntKay.IstatistikSol = top_sayi;
                    EntKay.IstatistikCanliAd = "Atandı-Sınır";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrrrrrr2 = new GrupCollection();
            IPredicateExpression ExpGrrrrrr2 = new PredicateExpression();
            ISortExpression sortgrrrrrr2 = new SortExpression();
            sortgrrrrrr2.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrrrrr2.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Basın%")));
            CollGrrrrrr2.GetMulti(ExpGrrrrrr2, 0, sortgrrrrrr2);

            for (int i = 0; i < CollGrrrrrr2.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrrrrr2[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    int top_sayi = 0;

                    for (int j = 0; j < CollBil.Count; j++)
                    {
                        SureTakipCollection CollTak = new SureTakipCollection();
                        IPredicateExpression ExpTak = new PredicateExpression();
                        ExpTak.AddWithAnd(SureTakipFields.FkBildirimId == CollBil[j].BildirimId);
                        ExpTak.AddWithAnd(SureTakipFields.SureTakipTuru == "İncelemeye Alma Süresi");
                        CollTak.GetMulti(ExpTak);

                        if (CollTak.Count > 0)
                        {
                            if (CollTak[0].SureTakipSaat >= 72)
                            {
                                top_sayi = top_sayi + 1;
                            }
                        }
                    }

                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrrrrr[i].GrupAd;
                    EntKay.IstatistikAlt = top_sayi.ToString() + " ADET";
                    EntKay.IstatistikSol = top_sayi;
                    EntKay.IstatistikCanliAd = "Atandı-Sınır";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrrrrrr3 = new GrupCollection();
            IPredicateExpression ExpGrrrrrr3 = new PredicateExpression();
            ISortExpression sortgrrrrrr3 = new SortExpression();
            sortgrrrrrr3.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrrrrr3.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Hukuk%")));
            CollGrrrrrr3.GetMulti(ExpGrrrrrr3, 0, sortgrrrrrr3);

            for (int i = 0; i < CollGrrrrrr3.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrrrrr3[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    int top_sayi = 0;

                    for (int j = 0; j < CollBil.Count; j++)
                    {
                        SureTakipCollection CollTak = new SureTakipCollection();
                        IPredicateExpression ExpTak = new PredicateExpression();
                        ExpTak.AddWithAnd(SureTakipFields.FkBildirimId == CollBil[j].BildirimId);
                        ExpTak.AddWithAnd(SureTakipFields.SureTakipTuru == "İncelemeye Alma Süresi");
                        CollTak.GetMulti(ExpTak);

                        if (CollTak.Count > 0)
                        {
                            if (CollTak[0].SureTakipSaat >= 72)
                            {
                                top_sayi = top_sayi + 1;
                            }
                        }
                    }

                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrrrrr[i].GrupAd;
                    EntKay.IstatistikAlt = top_sayi.ToString() + " ADET";
                    EntKay.IstatistikSol = top_sayi;
                    EntKay.IstatistikCanliAd = "Atandı-Sınır";
                    EntKay.Save();
                }
            }

            IstatistikCollection CollMenBekle = new IstatistikCollection();
            IPredicateExpression ExpMenBekle = new PredicateExpression();
            ExpMenBekle.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            ExpMenBekle.AddWithAnd(IstatistikFields.IstatistikCanliAd == "Atandı-Sınır");
            CollMenBekle.GetMulti(ExpMenBekle);

            WebChartControl6.SeriesDataMember = "IstatistikAd";
            WebChartControl6.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
            WebChartControl6.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
            WebChartControl6.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
            WebChartControl6.SeriesTemplate.ToolTipSeriesPattern = "{S}: {V}";
            WebChartControl6.SeriesTemplate.ToolTipPointPattern = "{S}: {V}";
            WebChartControl6.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";

            WebChartControl6.DataSource = CollMenBekle;
            WebChartControl6.DataBind();  
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
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

            GrupCollection CollGr = new GrupCollection();
            IPredicateExpression ExpGr = new PredicateExpression();
            ISortExpression sortgr = new SortExpression();
            sortgr.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGr.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Başkan%")));
            CollGr.GetMulti(ExpGr, 0, sortgr);

            for (int i = 0; i < CollGr.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGr[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGr[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Atandı";
                    EntKay.Save();
                }
            }

            GrupCollection CollGr2 = new GrupCollection();
            IPredicateExpression ExpGr2 = new PredicateExpression();
            ISortExpression sortgr2 = new SortExpression();
            sortgr2.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGr2.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Basın%")));
            CollGr2.GetMulti(ExpGr2, 0, sortgr2);

            for (int i = 0; i < CollGr2.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGr2[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGr2[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Atandı";
                    EntKay.Save();
                }
            }

            GrupCollection CollGr3 = new GrupCollection();
            IPredicateExpression ExpGr3 = new PredicateExpression();
            ISortExpression sortgr3 = new SortExpression();
            sortgr3.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGr3.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Hukuk%")));
            CollGr3.GetMulti(ExpGr3, 0, sortgr3);

            for (int i = 0; i < CollGr3.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGr3[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGr3[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Atandı";
                    EntKay.Save();
                }
            }

            IstatistikCollection CollMenAtandi = new IstatistikCollection();
            IPredicateExpression ExpMenAtandi = new PredicateExpression();
            ExpMenAtandi.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            ExpMenAtandi.AddWithAnd(IstatistikFields.IstatistikCanliAd == "Atandı");
            CollMenAtandi.GetMulti(ExpMenAtandi);

            WebChartControl1.SeriesDataMember = "IstatistikAd";
            WebChartControl1.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
            WebChartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
            WebChartControl1.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
            WebChartControl1.SeriesTemplate.ToolTipSeriesPattern = "{S}: {V}";
            WebChartControl1.SeriesTemplate.ToolTipPointPattern = "{S}: {V}";
            WebChartControl1.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";

            WebChartControl1.DataSource = CollMenAtandi;
            WebChartControl1.DataBind();

            GrupCollection CollGrr = new GrupCollection();
            IPredicateExpression ExpGrr = new PredicateExpression();
            ISortExpression sortgrr = new SortExpression();
            sortgrr.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrr.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Başkan%")));
            CollGrr.GetMulti(ExpGrr, 0, sortgrr);

            for (int i = 0; i < CollGrr.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrr[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrr[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "İnceleniyor";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrr2 = new GrupCollection();
            IPredicateExpression ExpGrr2 = new PredicateExpression();
            ISortExpression sortgrr2 = new SortExpression();
            sortgrr2.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrr2.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Basın%")));
            CollGrr2.GetMulti(ExpGrr2, 0, sortgrr2);

            for (int i = 0; i < CollGrr2.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrr2[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrr2[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "İnceleniyor";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrr3 = new GrupCollection();
            IPredicateExpression ExpGrr3 = new PredicateExpression();
            ISortExpression sortgrr3 = new SortExpression();
            sortgrr3.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrr3.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Hukuk%")));
            CollGrr3.GetMulti(ExpGrr3, 0, sortgrr3);

            for (int i = 0; i < CollGrr3.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrr3[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrr3[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "İnceleniyor";
                    EntKay.Save();
                }
            }

            IstatistikCollection CollMenIncele = new IstatistikCollection();
            IPredicateExpression ExpMenIncele = new PredicateExpression();
            ExpMenIncele.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            ExpMenIncele.AddWithAnd(IstatistikFields.IstatistikCanliAd == "İnceleniyor");
            CollMenIncele.GetMulti(ExpMenIncele);

            WebChartControl2.SeriesDataMember = "IstatistikAd";
            WebChartControl2.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
            WebChartControl2.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
            WebChartControl2.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
            WebChartControl2.SeriesTemplate.ToolTipSeriesPattern = "{S}: {V}";
            WebChartControl2.SeriesTemplate.ToolTipPointPattern = "{S}: {V}";
            WebChartControl2.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";

            WebChartControl2.DataSource = CollMenIncele;
            WebChartControl2.DataBind();

            GrupCollection CollGrrr = new GrupCollection();
            IPredicateExpression ExpGrrr = new PredicateExpression();
            ISortExpression sortgrrr = new SortExpression();
            sortgrrr.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrr.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Başkan%")));
            CollGrrr.GetMulti(ExpGrrr, 0, sortgrrr);

            for (int i = 0; i < CollGrrr.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrr[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrr[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "İnceleniyor - Ek Süre";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrrr2 = new GrupCollection();
            IPredicateExpression ExpGrrr2 = new PredicateExpression();
            ISortExpression sortgrrr2 = new SortExpression();
            sortgrrr2.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrr2.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Basın%")));
            CollGrrr2.GetMulti(ExpGrrr2, 0, sortgrrr2);

            for (int i = 0; i < CollGrrr2.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrr2[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrr2[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "İnceleniyor - Ek Süre";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrrr3 = new GrupCollection();
            IPredicateExpression ExpGrrr3 = new PredicateExpression();
            ISortExpression sortgrrr3 = new SortExpression();
            sortgrrr3.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrr3.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Hukuk%")));
            CollGrrr3.GetMulti(ExpGrrr3, 0, sortgrrr3);

            for (int i = 0; i < CollGrrr3.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrr3[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrr3[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "İnceleniyor - Ek Süre";
                    EntKay.Save();
                }
            }

            IstatistikCollection CollMenInceleEk = new IstatistikCollection();
            IPredicateExpression ExpMenInceleEk = new PredicateExpression();
            ExpMenInceleEk.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            ExpMenInceleEk.AddWithAnd(IstatistikFields.IstatistikCanliAd == "İnceleniyor - Ek Süre");
            CollMenInceleEk.GetMulti(ExpMenInceleEk);

            WebChartControl3.SeriesDataMember = "IstatistikAd";
            WebChartControl3.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
            WebChartControl3.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
            WebChartControl3.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
            WebChartControl3.SeriesTemplate.ToolTipSeriesPattern = "{S}: {V}";
            WebChartControl3.SeriesTemplate.ToolTipPointPattern = "{S}: {V}";
            WebChartControl3.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";

            WebChartControl3.DataSource = CollMenInceleEk;
            WebChartControl3.DataBind();

            GrupCollection CollGrrrrr = new GrupCollection();
            IPredicateExpression ExpGrrrrr = new PredicateExpression();
            ISortExpression sortgrrrrr = new SortExpression();
            sortgrrrrr.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrrrr.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Başkan%")));
            CollGrrrrr.GetMulti(ExpGrrrrr, 0, sortgrrrrr);

            for (int i = 0; i < CollGrrrrr.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Sonuçlandı");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrrrr[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrrrr[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Sonuçlandı";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrrrrr2 = new GrupCollection();
            IPredicateExpression ExpGrrrrr2 = new PredicateExpression();
            ISortExpression sortgrrrrr2 = new SortExpression();
            sortgrrrrr2.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrrrr2.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Basın%")));
            CollGrrrrr2.GetMulti(ExpGrrrrr2, 0, sortgrrrrr2);

            for (int i = 0; i < CollGrrrrr2.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Sonuçlandı");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrrrr2[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrrrr2[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Sonuçlandı";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrrrrr3 = new GrupCollection();
            IPredicateExpression ExpGrrrrr3 = new PredicateExpression();
            ISortExpression sortgrrrrr3 = new SortExpression();
            sortgrrrrr3.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrrrr3.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Hukuk%")));
            CollGrrrrr3.GetMulti(ExpGrrrrr3, 0, sortgrrrrr3);

            for (int i = 0; i < CollGrrrrr3.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Sonuçlandı");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrrrr3[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrrrr3[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Sonuçlandı";
                    EntKay.Save();
                }
            }

            IstatistikCollection CollMenSon = new IstatistikCollection();
            IPredicateExpression ExpMenSon = new PredicateExpression();
            ExpMenSon.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            ExpMenSon.AddWithAnd(IstatistikFields.IstatistikCanliAd == "Sonuçlandı");
            CollMenSon.GetMulti(ExpMenSon);

            WebChartControl4.SeriesDataMember = "IstatistikAd";
            WebChartControl4.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
            WebChartControl4.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
            WebChartControl4.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
            WebChartControl4.SeriesTemplate.ToolTipSeriesPattern = "{S}: {V}";
            WebChartControl4.SeriesTemplate.ToolTipPointPattern = "{S}: {V}";
            WebChartControl4.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";

            WebChartControl4.DataSource = CollMenSon;
            WebChartControl4.DataBind();

            GrupCollection CollGrrrr = new GrupCollection();
            IPredicateExpression ExpGrrrr = new PredicateExpression();
            ISortExpression sortgrrrr = new SortExpression();
            sortgrrrr.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrrr.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Başkan%")));
            CollGrrrr.GetMulti(ExpGrrrr, 0, sortgrrrr);

            for (int i = 0; i < CollGrrrr.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Reddedildi");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrrr[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrrr[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Reddedildi";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrrrr2 = new GrupCollection();
            IPredicateExpression ExpGrrrr2 = new PredicateExpression();
            ISortExpression sortgrrrr2 = new SortExpression();
            sortgrrrr2.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrrr2.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Basın%")));
            CollGrrrr2.GetMulti(ExpGrrrr2, 0, sortgrrrr2);

            for (int i = 0; i < CollGrrrr2.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Reddedildi");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrrr2[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrrr2[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Reddedildi";
                    EntKay.Save();
                }
            }

            GrupCollection CollGrrrr3 = new GrupCollection();
            IPredicateExpression ExpGrrrr3 = new PredicateExpression();
            ISortExpression sortgrrrr3 = new SortExpression();
            sortgrrrr3.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
            ExpGrrrr3.AddWithAnd((new FieldLikePredicate(GrupFields.GrupAd, null, "%Hukuk%")));
            CollGrrrr3.GetMulti(ExpGrrrr3, 0, sortgrrrr3);

            for (int i = 0; i < CollGrrrr3.Count; i++)
            {
                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Reddedildi");
                CollSon.GetMulti(ExpSon);

                string basladim = CollGrrrr3[i].GrupAd.Substring(0, 10);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd((new FieldLikePredicate(BildirimFields.BildirimAtanmaDurumu, "%" + basladim + "%")));
                ExpBil.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[0].BildirimSonucId);
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollGrrrr3[i].GrupAd;
                    EntKay.IstatistikAlt = CollBil.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "Reddedildi";
                    EntKay.Save();
                }
            }

            IstatistikCollection CollMenRed = new IstatistikCollection();
            IPredicateExpression ExpMenRed = new PredicateExpression();
            ExpMenRed.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            ExpMenRed.AddWithAnd(IstatistikFields.IstatistikCanliAd == "Reddedildi");
            CollMenRed.GetMulti(ExpMenRed);

            WebChartControl5.SeriesDataMember = "IstatistikAd";
            WebChartControl5.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
            WebChartControl5.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
            WebChartControl5.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
            WebChartControl5.SeriesTemplate.ToolTipSeriesPattern = "{S}: {V}";
            WebChartControl5.SeriesTemplate.ToolTipPointPattern = "{S}: {V}";
            WebChartControl5.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";

            WebChartControl5.DataSource = CollMenRed;
            WebChartControl5.DataBind();
        }
    }
}