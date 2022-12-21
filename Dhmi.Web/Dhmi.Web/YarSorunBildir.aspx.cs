using System;
using System.Web.UI;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.TypedListClasses;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using dhmi.EntityClasses;
using System.Web;

namespace Dhmi.Web
{
    public partial class YarSorunBildir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["menu_sec"] = "Yardım";

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

            ListSorunTypedList borc_list = new ListSorunTypedList();
            ISortExpression sort = new SortExpression();
            sort.Add(new SortClause(SorunFields.SorunTarih, SortOperator.Descending));
            borc_list.Fill(0, sort);

            grid_sorun.DataSource = borc_list;
            grid_sorun.DataBind();

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            grid_sorun_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "SORUN LİSTESİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_sorun_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            grid_sorun.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            if (IsPostBack != true)
            {
                MenuCollection CollMenu = new MenuCollection();
                IPredicateExpression ExpMenu = new PredicateExpression();
                ExpMenu.AddWithAnd(MenuFields.MenuAd == "Yardım");
                CollMenu.GetMulti(ExpMenu);

                AltMenuCollection CollAlt1 = new AltMenuCollection();
                IPredicateExpression ExpAlt1 = new PredicateExpression();
                ExpAlt1.AddWithAnd(AltMenuFields.AltMenuAd == "İletişim Merkezi Yardım");
                CollAlt1.GetMulti(ExpAlt1);

                AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                IPredicateExpression ExpAlt2 = new PredicateExpression();
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Sorun Bildir");
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

                SorunTuruCollection CollTur = new SorunTuruCollection();
                ISortExpression sorttur = new SortExpression();
                sorttur.Add(new SortClause(SorunTuruFields.SorunTuruAd, SortOperator.Ascending));
                CollTur.GetMulti(null, 0, sorttur);

                for (int i = 0; i < CollTur.Count; i++)
                {
                    cb_sorun.Items.Add(CollTur[i].SorunTuruAd);
                }

                cb_sorun.Focus();
            }
        }

        protected void btn_gonder_Click(object sender, EventArgs e)
        {
            Int16 sonuc = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
            string konu = "DHMİ İletişim Merkezi Sorun Bildirme";

            ParametreCollection CollPara = new ParametreCollection();
            IPredicateExpression ExpPara = new PredicateExpression();
            ExpPara.AddWithAnd(ParametreFields.ParametreAd == "Sorun Mail Adresi");
            CollPara.GetMulti(ExpPara);

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            string actimmm = txt_aciklama.Text;

            txt_aciklama.Text = txt_aciklama.Text + "---" + CollKul[0].KullaniciAdSoyad;

            Mail.MailGonderYardim(sonuc, CollPara[0].ParametreDeger, konu, cb_sorun.Text, txt_öneri.Text, txt_aciklama.Text, txt_irtibat.Text);
            
            SorunTuruCollection CollTur = new SorunTuruCollection();
            IPredicateExpression ExpTur = new PredicateExpression();
            ExpTur.AddWithAnd(SorunTuruFields.SorunTuruAd == cb_sorun.Text);
            CollTur.GetMulti(ExpTur);

            SorunEntity EntKay = new SorunEntity();
            EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
            EntKay.FkSorunTuruId = CollTur[0].SorunTuruId;
            EntKay.SorunAciklama = actimmm;
            EntKay.SorunCevaplandiMi = "Hayır";
            EntKay.SorunCozum = "-";
            EntKay.SorunIrtibat = txt_irtibat.Text;
            EntKay.SorunOneri = txt_öneri.Text;
            EntKay.SorunTarih = DateTime.Today;
            EntKay.Save();

            string CloseWindow;
            CloseWindow = "alert('Sorun bildirme işlemi tamamlanmıştır. Sistem yöneticimiz en kısa sürede size dönüş yapacaktır...')";

            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            cb_sorun.Text = "";
            cb_sorun.NullText = "Seçiniz...";
            txt_aciklama.Text = "";
            txt_irtibat.Text = "";
            txt_öneri.Text = "";

            ListSorunTypedList borc_list = new ListSorunTypedList();
            ISortExpression sort = new SortExpression();
            sort.Add(new SortClause(SorunFields.SorunTarih, SortOperator.Descending));
            borc_list.Fill(0, sort);

            grid_sorun.DataSource = borc_list;
            grid_sorun.DataBind();

            cb_sorun.Focus();
        }

        protected void btn_iptal_Click(object sender, EventArgs e)
        {
            cb_sorun.Text = "";
            cb_sorun.NullText = "Seçiniz...";
            txt_aciklama.Text = "";
            txt_irtibat.Text = "";
            txt_öneri.Text = "";

            cb_sorun.Focus();
        }

        protected void btnPdfExport_Click(object sender, EventArgs e)
        {
            string ad = "sorun_listesi_pdf_" + DateTime.Now.ToShortDateString();
            grid_sorun_export.WritePdfToResponse(ad);
        }

        protected void btnXlsExport_Click(object sender, EventArgs e)
        {
            string ad = "sorun_listesi_xls_" + DateTime.Now.ToShortDateString();
            grid_sorun_export.WriteXlsToResponse(ad);
        }

        protected void btnRtfExport_Click(object sender, EventArgs e)
        {
            string ad = "sorun_listesi_rtf_" + DateTime.Now.ToShortDateString();
            grid_sorun_export.WriteRtfToResponse(ad);
        }

        protected void grid_sorun_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_sorun.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }
    }
}