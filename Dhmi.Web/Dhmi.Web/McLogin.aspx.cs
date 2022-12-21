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
using DevExpress.Utils;

namespace Dhmi.Web
{
    public partial class McLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["menu_sec"] = "Çağrı İşlemleri";

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

            if (IsPostBack != true)
            {
                ChartTitle title = new ChartTitle();
                title.TextColor = System.Drawing.Color.Maroon;
                title.Font = new Font("Calibri", 14, FontStyle.Regular);
                title.Text = "Bildirim Tür Durumu";
                chart_pasta.Titles.Add(title);

                ChartTitle title2 = new ChartTitle();
                title2.TextColor = System.Drawing.Color.DarkGray;
                title2.Dock = ChartTitleDockStyle.Bottom;
                title2.Text = "DHMİ İletişim Merkezi";
                title2.Font = new Font("Calibri", 8, FontStyle.Regular);
                title2.Alignment = StringAlignment.Far;
                chart_pasta.Titles.Add(title2);

                ChartTitle titlee = new ChartTitle();
                titlee.TextColor = System.Drawing.Color.Maroon;
                titlee.Font = new Font("Calibri", 14, FontStyle.Regular);
                titlee.Text = "Aylık Bildirim Durumu";
                chart_cizgi.Titles.Add(titlee);

                ChartTitle title22 = new ChartTitle();
                title22.TextColor = System.Drawing.Color.DarkGray;
                title22.Dock = ChartTitleDockStyle.Bottom;
                title22.Text = "DHMİ İletişim Merkezi";
                title22.Font = new Font("Calibri", 8, FontStyle.Regular);
                title22.Alignment = StringAlignment.Far;
                chart_cizgi.Titles.Add(title22);
               
                KullaniciCollection CollKul = new KullaniciCollection();
                IPredicateExpression ExpKul = new PredicateExpression();
                ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollKul.GetMulti(ExpKul);

                IstatistikCollection CollMen = new IstatistikCollection();
                IPredicateExpression ExpMen = new PredicateExpression();
                ExpMen.AddWithAnd(IstatistikFields.FkKullaniciId == CollKul[0].KullaniciId);
                CollMen.GetMulti(ExpMen);

                for (int i = 0; i < CollMen.Count; i++)
                {
                    CollMen[i].Delete();
                    CollMen[i].Save();
                }

                BildirimTuruCollection CollTur = new BildirimTuruCollection();
                ISortExpression sorttur = new SortExpression();
                sorttur.Add(new SortClause(BildirimTuruFields.BildirimTuruAd, SortOperator.Ascending));
                CollTur.GetMulti(null, 0, sorttur);

                for (int i = 0; i < CollTur.Count; i++) 
                {
                    BildirimCollection CollBil = new BildirimCollection();
                    IPredicateExpression ExpBil = new PredicateExpression();
                    ExpBil.AddWithAnd(BildirimFields.FkBildirimTuruId == CollTur[i].BildirimTuruId);
                    CollBil.GetMulti(ExpBil);

                    IstatistikEntity EntKay = new IstatistikEntity();
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.IstatistikAd = CollTur[i].BildirimTuruAd;
                    EntKay.IstatistikAlt = CollTur[i].BildirimTuruAd;
                    EntKay.IstatistikSol = CollBil.Count;
                    EntKay.IstatistikCanliAd = "pasta";
                    EntKay.Save();
                }

                IstatistikCollection CollMen2 = new IstatistikCollection();
                IPredicateExpression ExpMen2 = new PredicateExpression();
                ExpMen2.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                ExpMen2.AddWithAnd(IstatistikFields.IstatistikCanliAd == "pasta");
                CollMen2.GetMulti(ExpMen2);                           
                
                /*
                chart_pasta.SeriesDataMember = "IstatistikCanliAd";
                chart_pasta.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
                chart_pasta.SeriesTemplate.LegendText = "IstatistikSol";
                chart_pasta.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
                chart_pasta.SeriesTemplate.View = new SideBySideBarSeriesView();
                chart_pasta.SeriesTemplate.ToolTipSeriesPattern = "{VP}: {V}";
                chart_pasta.SeriesTemplate.ToolTipPointPattern = "{VP}: {V}";
                chart_pasta.SeriesTemplate.CrosshairLabelPattern = "{VP}: {V}";
                chart_pasta.SeriesTemplate.LegendTextPattern = "{VP}: {V}";                
                chart_pasta.SeriesTemplate.ShowInLegend = false;
                chart_pasta.SeriesTemplate.LabelsVisibility = DefaultBoolean.True;
                chart_pasta.SeriesTemplate.ToolTipEnabled = DefaultBoolean.False;
                chart_pasta.SeriesTemplate.Label.TextPattern = "{A}: {VP:P0} - {V:F0}";                                
                chart_pasta.Legend.Visible = true;
                chart_pasta.Legend.TextVisible = true;
                chart_pasta.Legend.MarkerVisible = true;*/

                chart_pasta.SeriesDataMember = "IstatistikAd";
                chart_pasta.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";                
                chart_pasta.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
                chart_pasta.SeriesTemplate.View = new SideBySideStackedBarSeriesView();
                chart_pasta.SeriesTemplate.ToolTipSeriesPattern = "{A} - {V:F0}";
                chart_pasta.SeriesTemplate.ToolTipPointPattern = "{A} - {V:F0}";
                chart_pasta.SeriesTemplate.CrosshairLabelPattern = "{A} - {V:F0}";
                chart_pasta.SeriesTemplate.LegendTextPattern = "{A} - {V:F0}";
                chart_pasta.SeriesTemplate.Label.TextPattern = "{A} - {V:F0}";
                chart_pasta.SeriesTemplate.ToolTipEnabled = DefaultBoolean.False;                
                
                chart_pasta.DataSource = CollMen2;
                chart_pasta.DataBind();                

                //ikincisi geliyor
                DateTime tarih_bts = DateTime.Now;
                DateTime tarih_bsl = Convert.ToDateTime("01.01.2015");

                for (int i = 0; i < 100; i++) 
                {
                    tarih_bsl = tarih_bsl.AddMonths(1);

                    if (tarih_bts > tarih_bsl)
                    {
                        DateTime sorgu_bts = tarih_bsl.AddMonths(1);
                        sorgu_bts = sorgu_bts.AddDays(-1);
                        
                        BildirimCollection CollBil = new BildirimCollection();
                        IPredicateExpression ExpBil = new PredicateExpression();
                        ExpBil.AddWithAnd(BildirimFields.BildirimTarih >= tarih_bsl);
                        ExpBil.AddWithAnd(BildirimFields.BildirimTarih <= sorgu_bts);
                        CollBil.GetMulti(ExpBil);

                        IstatistikEntity EntKay = new IstatistikEntity();
                        EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                        EntKay.IstatistikAd = tarih_bsl.Month.ToString() + " / " + tarih_bsl.Year.ToString();
                        EntKay.IstatistikAlt = tarih_bsl.Month.ToString() + " / " + tarih_bsl.Year.ToString();
                        EntKay.IstatistikSol = CollBil.Count;
                        EntKay.IstatistikCanliAd = "cizgi";
                        EntKay.Save();
                    }

                    else 
                    {
                        i = 100;
                    }                    
                }

                IstatistikCollection CollMen3 = new IstatistikCollection();
                IPredicateExpression ExpMen3 = new PredicateExpression();
                ExpMen3.AddWithAnd(IstatistikFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                ExpMen3.AddWithAnd(IstatistikFields.IstatistikCanliAd == "cizgi");
                CollMen3.GetMulti(ExpMen3);

                chart_cizgi.SeriesDataMember = "IstatistikCanliAd";
                chart_cizgi.SeriesTemplate.ArgumentDataMember = "IstatistikAlt";
                chart_cizgi.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "IstatistikSol" });
                chart_cizgi.SeriesTemplate.View = new LineSeriesView();
                chart_cizgi.SeriesTemplate.ToolTipSeriesPattern = "{A} - {V:F0}";
                chart_cizgi.SeriesTemplate.ToolTipPointPattern = "{A} - {V:F0}";
                chart_cizgi.SeriesTemplate.CrosshairLabelPattern = "{A} - {V:F0}";
                chart_cizgi.SeriesTemplate.LegendTextPattern = "{A} - {V:F0}";
                chart_cizgi.SeriesTemplate.Label.TextPattern = "{A} - {V:F0}";
                chart_cizgi.SeriesTemplate.ToolTipEnabled = DefaultBoolean.False;
                chart_cizgi.SeriesTemplate.ShowInLegend = false;

                chart_cizgi.DataSource = CollMen3;
                chart_cizgi.DataBind(); 
            }
        }
    }
}