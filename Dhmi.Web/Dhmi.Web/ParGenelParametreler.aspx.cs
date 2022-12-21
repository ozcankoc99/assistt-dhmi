using System;
using System.Web.UI;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.TypedListClasses;
using dhmi.HelperClasses;
using dhmi.CollectionClasses;
using dhmi.EntityClasses;
using System.Web;

namespace Dhmi.Web
{
    public partial class ParGenelParametreler : System.Web.UI.Page
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

            ListParArsivTypedList borc_list = new ListParArsivTypedList();
            ISortExpression sortss = new SortExpression();
            sortss.Add(new SortClause(ParametreGenelArsivFields.ParametreGenelArsivTarih, SortOperator.Descending));
            IPredicateExpression filter = new PredicateExpression();
            filter.AddWithAnd(ParametreGenelArsivFields.ParametreGenelArsivTur == "Genel Parametreler");
            borc_list.Fill(0, sortss, true, filter);

            grid_gen_param.DataSource = borc_list;
            grid_gen_param.DataBind();

            grid_par_sil.DataSource = borc_list;
            grid_par_sil.DataBind();

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            grid_gen_param_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "GENEL PARAMETRE BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_gen_param_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            grid_gen_param.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_par_sil.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            if (IsPostBack != true)
            {
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
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Genel Parametreler");
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

                ParametreTurCollection CollTur = new ParametreTurCollection();
                IPredicateExpression ExpTur = new PredicateExpression();
                ExpTur.AddWithAnd(ParametreTurFields.ParametreTurAd == "Genel Parametreler");
                CollTur.GetMulti(ExpTur);

                ParametreCollection CollPar = new ParametreCollection();
                IPredicateExpression ExpPar = new PredicateExpression();
                ExpPar.AddWithAnd(ParametreFields.FkParametreTurId == CollTur[0].ParametreTurId);
                ExpPar.AddWithAnd(ParametreFields.ParametreAd != "Kurum");
                ExpPar.AddWithAnd(ParametreFields.ParametreAd != "Rapor Sayı");
                ISortExpression sort = new SortExpression();
                sort.Add(new SortClause(ParametreFields.ParametreAd, SortOperator.Ascending));
                CollPar.GetMulti(ExpPar, 0, sort);

                for (int i = 0; i < CollPar.Count; i++)
                {
                    cb_parametre.Items.Add(CollPar[i].ParametreAd);
                }

                cb_parametre.Focus();
            }
        }

        protected void cb_parametre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParametreTurCollection CollTur = new ParametreTurCollection();
            IPredicateExpression ExpTur = new PredicateExpression();
            ExpTur.AddWithAnd(ParametreTurFields.ParametreTurAd == "Genel Parametreler");
            CollTur.GetMulti(ExpTur);

            ParametreCollection CollPar = new ParametreCollection();
            IPredicateExpression ExpPar = new PredicateExpression();
            ExpPar.AddWithAnd(ParametreFields.FkParametreTurId == CollTur[0].ParametreTurId);
            ExpPar.AddWithAnd(ParametreFields.ParametreAd == cb_parametre.Text);
            CollPar.GetMulti(ExpPar);

            txt_deger.Text = CollPar[0].ParametreDeger;

            Session["eski_hal"] = txt_deger.Text;
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (Session["eski_hal"].ToString() == txt_deger.Text)
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen geçerli bir değer giriniz ya da işlemi iptal ediniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                txt_deger.Focus();
            }

            else
            {
                ParametreTurCollection CollTur = new ParametreTurCollection();
                IPredicateExpression ExpTur = new PredicateExpression();
                ExpTur.AddWithAnd(ParametreTurFields.ParametreTurAd == "Genel Parametreler");
                CollTur.GetMulti(ExpTur);

                ParametreCollection CollPar = new ParametreCollection();
                IPredicateExpression ExpPar = new PredicateExpression();
                ExpPar.AddWithAnd(ParametreFields.FkParametreTurId == CollTur[0].ParametreTurId);
                ExpPar.AddWithAnd(ParametreFields.ParametreAd == cb_parametre.Text);
                CollPar.GetMulti(ExpPar);

                CollPar[0].ParametreDeger = txt_deger.Text;
                CollPar[0].Save();

                KullaniciCollection CollKul = new KullaniciCollection();
                IPredicateExpression ExpKul = new PredicateExpression();
                ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollKul.GetMulti(ExpKul);

                ParametreGenelArsivEntity EntKay = new ParametreGenelArsivEntity();
                EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                EntKay.FkParametreId = CollPar[0].ParametreId;
                EntKay.ParametreGenelArsivAd = CollPar[0].ParametreAd;
                EntKay.ParametreGenelArsivKullanici = CollKul[0].KullaniciAdSoyad;
                EntKay.ParametreGenelArsivOld = Session["eski_hal"].ToString();
                EntKay.ParametreGenelArsivNew = txt_deger.Text;
                EntKay.ParametreGenelArsivTarih = DateTime.Now;
                EntKay.ParametreGenelArsivBasTarih = Convert.ToDateTime("01.01.2014");
                EntKay.ParametreGenelArsivBitTarih = Convert.ToDateTime("31.12.2020");
                EntKay.ParametreGenelArsivTur = "Genel Parametreler";
                EntKay.Save();

                string CloseWindow;
                CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                ListParArsivTypedList borc_list = new ListParArsivTypedList();
                ISortExpression sortss = new SortExpression();
                sortss.Add(new SortClause(ParametreGenelArsivFields.ParametreGenelArsivTarih, SortOperator.Descending));
                IPredicateExpression filter = new PredicateExpression();
                filter.AddWithAnd(ParametreGenelArsivFields.ParametreGenelArsivTur == "Genel Parametreler");
                borc_list.Fill(0, sortss, true, filter);

                grid_gen_param.DataSource = borc_list;
                grid_gen_param.DataBind();

                grid_par_sil.DataSource = borc_list;
                grid_par_sil.DataBind();

                txt_deger.Text = "";
                cb_parametre.Text = "";
                cb_parametre.NullText = "Seçiniz...";

                cb_parametre.Focus();
            }
        }

        protected void btn_iptal_Click(object sender, EventArgs e)
        {
            txt_deger.Text = "";
            cb_parametre.Text = "";
            cb_parametre.NullText = "Seçiniz...";
            cb_parametre.Focus();
        }

        protected void btnPdfExport_Click(object sender, EventArgs e)
        {
            string ad = "genel_parametreler_pdf_" + DateTime.Now.ToShortDateString();
            grid_gen_param_export.WritePdfToResponse(ad);
        }

        protected void btnXlsExport_Click(object sender, EventArgs e)
        {
            string ad = "genel_parametreler_xls_" + DateTime.Now.ToShortDateString();
            grid_gen_param_export.WriteXlsToResponse(ad);
        }

        protected void btnRtfExport_Click(object sender, EventArgs e)
        {
            string ad = "genel_parametreler_rtf_" + DateTime.Now.ToShortDateString();
            grid_gen_param_export.WriteRtfToResponse(ad);
        }

        protected void grid_par_sil_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = grid_par_sil.GetSelectedFieldValues("ParametreGenelArsivId")[0].ToString();

            btn_sil.Enabled = true;
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                ParametreGenelArsivCollection CollPara = new ParametreGenelArsivCollection();
                IPredicateExpression ExpPara = new PredicateExpression();
                ExpPara.AddWithAnd(ParametreGenelArsivFields.ParametreGenelArsivId == Convert.ToInt32(txtUserName.Text));
                CollPara.GetMulti(ExpPara);

                if (CollPara[0].ParametreGenelArsivOld == "----------")
                {
                    string CloseWindow;
                    CloseWindow = "alert('Ana parametre değerini silemezsiniz...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else
                {
                    ParametreTurCollection CollTur = new ParametreTurCollection();
                    IPredicateExpression ExpTur = new PredicateExpression();
                    ExpTur.AddWithAnd(ParametreTurFields.ParametreTurAd == CollPara[0].ParametreGenelArsivTur);
                    CollTur.GetMulti(ExpTur);

                    ParametreCollection CollEks = new ParametreCollection();
                    IPredicateExpression ExpEks = new PredicateExpression();
                    ExpEks.AddWithAnd(ParametreFields.FkParametreTurId == CollTur[0].ParametreTurId);
                    ExpEks.AddWithAnd(ParametreFields.ParametreAd == CollPara[0].ParametreGenelArsivAd);
                    CollEks.GetMulti(ExpEks);

                    CollEks[0].ParametreDeger = CollPara[0].ParametreGenelArsivOld;
                    CollEks[0].Save();

                    CollPara[0].Delete();
                    CollPara[0].Save();
                }

                ListParArsivTypedList borc_list = new ListParArsivTypedList();
                IPredicateExpression filter = new PredicateExpression();
                filter.AddWithAnd(ParametreGenelArsivFields.ParametreGenelArsivTur == "Genel Parametreler");
                borc_list.Fill(0, null, true, filter);

                grid_gen_param.DataSource = borc_list;
                grid_gen_param.DataBind();

                grid_par_sil.DataSource = borc_list;
                grid_par_sil.DataBind();

                btn_sil.Enabled = false;

                string CloseWindow2;
                CloseWindow2 = "alert('Silme işlemi tamamlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen bir kayıt seçiniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void grid_gen_param_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_gen_param.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_par_sil_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_par_sil.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }
    }
}