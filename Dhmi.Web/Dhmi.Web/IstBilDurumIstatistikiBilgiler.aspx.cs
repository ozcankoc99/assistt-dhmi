using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.EntityClasses;
using DevExpress.XtraCharts;
using System.Drawing;

namespace Dhmi.Web
{
    public partial class IstBilDurumIstatistikiBilgiler : System.Web.UI.Page
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

            try
            {
                if (IsPostBack != true)
                {
                    Session["icerden_gel"] = null;

                    ChartTitle title = new ChartTitle();
                    title.TextColor = System.Drawing.Color.Maroon;
                    title.Font = new Font("Calibri", 18, FontStyle.Regular);
                    title.Text = "Bildirim Durum Türleri";
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
                    ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Bildirim Durumu İstatistik Bilgileri");
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

                    txt_bas_tarihi.Text = DateTime.Today.ToShortDateString();
                    txt_bit_tarihi.Text = DateTime.Today.ToShortDateString();
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

                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                ISortExpression sortson = new SortExpression();
                sortson.Add(new SortClause(BildirimSonucFields.BildirimSonucAd, SortOperator.Ascending));
                CollSon.GetMulti(null, 0, sortson);

                for (int i = 0; i < CollSon.Count; i++) 
                {
                    BildirimCollection CollBilgi = new BildirimCollection();
                    IPredicateExpression ExpBilgi = new PredicateExpression();
                    ExpBilgi.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[i].BildirimSonucId);

                    if (Session["icerden_gel"] != null)
                    {
                        ExpBilgi.AddWithAnd(BildirimFields.BildirimSonIslemTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                        ExpBilgi.AddWithAnd(BildirimFields.BildirimSonIslemTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
                    }

                    CollBilgi.GetMulti(ExpBilgi);

                    if (CollBilgi.Count > 0) 
                    {
                        IstatistikEntity EntKay = new IstatistikEntity();
                        EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                        EntKay.IstatistikAd = CollSon[i].BildirimSonucAd;
                        EntKay.IstatistikAlt = CollBilgi.Count.ToString() + " ADET";
                        EntKay.IstatistikSol = CollBilgi.Count;
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

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('İstatistik oluşturulacak gerekli kayıtlar mevcut değildir....')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            Session["icerden_gel"] = "0";

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

            BildirimSonucCollection CollSon = new BildirimSonucCollection();
            ISortExpression sortson = new SortExpression();
            sortson.Add(new SortClause(BildirimSonucFields.BildirimSonucAd, SortOperator.Ascending));
            CollSon.GetMulti(null, 0, sortson);

            for (int i = 0; i < CollSon.Count; i++)
            {
                BildirimCollection CollBilgi = new BildirimCollection();
                IPredicateExpression ExpBilgi = new PredicateExpression();
                ExpBilgi.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[i].BildirimSonucId);

                if (Session["icerden_gel"] != null)
                {
                    ExpBilgi.AddWithAnd(BildirimFields.BildirimSonIslemTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                    ExpBilgi.AddWithAnd(BildirimFields.BildirimSonIslemTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
                }

                CollBilgi.GetMulti(ExpBilgi);

                if (CollBilgi.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollSon[i].BildirimSonucAd;
                    EntKay.IstatistikAlt = CollBilgi.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBilgi.Count;
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

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            Session["icerden_gel"] = null;

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

            BildirimSonucCollection CollSon = new BildirimSonucCollection();
            ISortExpression sortson = new SortExpression();
            sortson.Add(new SortClause(BildirimSonucFields.BildirimSonucAd, SortOperator.Ascending));
            CollSon.GetMulti(null, 0, sortson);

            for (int i = 0; i < CollSon.Count; i++)
            {
                BildirimCollection CollBilgi = new BildirimCollection();
                IPredicateExpression ExpBilgi = new PredicateExpression();
                ExpBilgi.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon[i].BildirimSonucId);

                if (Session["icerden_gel"] != null)
                {
                    ExpBilgi.AddWithAnd(BildirimFields.BildirimSonIslemTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                    ExpBilgi.AddWithAnd(BildirimFields.BildirimSonIslemTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
                }

                CollBilgi.GetMulti(ExpBilgi);

                if (CollBilgi.Count > 0)
                {
                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollSon[i].BildirimSonucAd;
                    EntKay.IstatistikAlt = CollBilgi.Count.ToString() + " ADET";
                    EntKay.IstatistikSol = CollBilgi.Count;
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

            txt_bas_tarihi.Text = DateTime.Today.ToShortDateString();
            txt_bit_tarihi.Text = DateTime.Today.ToShortDateString();
        }
    }
}