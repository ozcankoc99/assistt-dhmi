using System;
using System.Web.UI;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using dhmi.TypedListClasses;
using dhmi.EntityClasses;
using System.Web;

namespace Dhmi.Web
{
    public partial class KpkCagriBilgileri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["menu_sec"] = "Çağrı İşlemleri";

            if ((Session["kullanici_var_mi"] == null) || (Session["kullanici_rastgele"] == null))
            {
                Response.Redirect("Account/Login.aspx");
            }

            HttpCookie cookie = Request.Cookies["userC"];
            HttpCookie cookieYetki = Request.Cookies["aJ4lOu784TyfdEsd4FIoi"];
            if (cookie != null && cookieYetki != null)
            {
                string yetki = Helper.Decrypt(cookieYetki.Value);
                if (yetki == "Admin" || yetki == "İletişim Merkezi Temsilcisi" || yetki == "Takım Lideri" || yetki == "Kurum Sistem Yöneticisi")
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

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            grid_kopuk_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "KÖPÜK ÇAĞRI BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_kopuk_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            grid_kopuk.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_kopuk_sil.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            ListKopukTypedList eg_snot = new ListKopukTypedList();
            ISortExpression sortss = new SortExpression();
            sortss.Add(new SortClause(KopukCagriFields.KopukCagriTarih, SortOperator.Descending));
            sortss.Add(new SortClause(KopukCagriTuruFields.KopukCagriTuruAd, SortOperator.Ascending));
            eg_snot.Fill(0, sortss, true);

            grid_kopuk.DataSource = eg_snot;
            grid_kopuk.DataBind();

            grid_kopuk_sil.DataSource = eg_snot;
            grid_kopuk_sil.DataBind();

            if (IsPostBack != true)
            {
                Session["foto_path"] = null;

                KopukCagriTuruCollection CollTur = new KopukCagriTuruCollection();
                ISortExpression sortbil = new SortExpression();
                sortbil.Add(new SortClause(KopukCagriTuruFields.KopukCagriTuruAd, SortOperator.Ascending));
                CollTur.GetMulti(null, 0, sortbil);

                cb_tur.Items.Clear();

                for (int i = 0; i < CollTur.Count; i++)
                {
                    cb_tur.Items.Add(CollTur[i].KopukCagriTuruAd);
                }

                MenuCollection CollMenu = new MenuCollection();
                IPredicateExpression ExpMenu = new PredicateExpression();
                ExpMenu.AddWithAnd(MenuFields.MenuAd == "Çağrı İşlemleri");
                CollMenu.GetMulti(ExpMenu);

                AltMenuCollection CollAlt1 = new AltMenuCollection();
                IPredicateExpression ExpAlt1 = new PredicateExpression();
                ExpAlt1.AddWithAnd(AltMenuFields.AltMenuAd == "Köpük Çağrı Bilgileri");
                CollAlt1.GetMulti(ExpAlt1);

                AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                IPredicateExpression ExpAlt2 = new PredicateExpression();
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Köpük Çağrı Bilgileri");
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

            cb_tur.Focus();
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            cb_tur.Text = "";
            cb_tur.NullText = "Seçiniz...";
            txt_tel_no.Text = "";
            txt_aciklama.Text = "";

            cb_tur.Focus();
        }

        protected void btnPdfExport_Click(object sender, EventArgs e)
        {
            Session["rapor_adi"] = "Köpük Bilgileri";

            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McAraRapor.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void grid_kopuk_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_kopuk.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_kopuk_sil_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_kopuk_sil.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_kopuk_sil_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = grid_kopuk_sil.GetSelectedFieldValues("KopukCagriId")[0].ToString();

            btn_guncelle.Enabled = true;
            btn_sil.Enabled = true;
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                KopukCagriCollection CollYazz = new KopukCagriCollection();
                IPredicateExpression ExpYazz = new PredicateExpression();
                ExpYazz.AddWithAnd(KopukCagriFields.KopukCagriId == Convert.ToInt32(txtUserName.Text));
                CollYazz.GetMulti(ExpYazz);

                CollYazz[0].Delete();
                CollYazz[0].Save();

                ListKopukTypedList eg_snot = new ListKopukTypedList();
                ISortExpression sortss = new SortExpression();
                sortss.Add(new SortClause(KopukCagriFields.KopukCagriTarih, SortOperator.Descending));
                sortss.Add(new SortClause(KopukCagriTuruFields.KopukCagriTuruAd, SortOperator.Ascending));
                eg_snot.Fill(0, sortss, true);

                grid_kopuk.DataSource = eg_snot;
                grid_kopuk.DataBind();

                grid_kopuk_sil.DataSource = eg_snot;
                grid_kopuk_sil.DataBind();

                btn_guncelle.Enabled = false;
                btn_sil.Enabled = false;

                string CloseWindow;
                CloseWindow = "alert('Silme işlemi tamamlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen bir kayıt seçiniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }
        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            KopukCagriTuruCollection CollTur = new KopukCagriTuruCollection();
            IPredicateExpression ExpTur = new PredicateExpression();
            ExpTur.AddWithAnd(KopukCagriTuruFields.KopukCagriTuruAd == cb_tur.Text);
            CollTur.GetMulti(ExpTur);

            string telli = txt_tel_no.Text;

            int dene = 0;
            int topla = 0;
            string basla = telli[0].ToString();

            for (int i = 0; i < telli.Length; i++)
            {
                topla = topla + Convert.ToInt16(telli[i].ToString());

                if (telli[i].ToString() == basla)
                {
                    dene = dene + 1;
                }
            }

            if (dene == telli.Length || topla <= 11)
            {
                string CloseWindow;
                CloseWindow = "alert('Telefon Numarası hatalıdır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                txt_tel_no.Focus();
            }

            else
            {
                if (Session["par_guncelle_mi"].ToString() == "0")
                {
                    KopukCagriEntity EntKay = new KopukCagriEntity();
                    EntKay.FkKopukCagriTuruId = CollTur[0].KopukCagriTuruId;
                    EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntKay.KopukCagriTelNo = txt_tel_no.Text;
                    EntKay.KopukCagriAciklama = txt_aciklama.Text;
                    EntKay.KopukCagriTarih = DateTime.Now;
                    EntKay.Save();

                    string CloseWindow;
                    CloseWindow = "alert('Kayıt işlemi tamamlanmıştır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                    ListKopukTypedList eg_snot = new ListKopukTypedList();
                    ISortExpression sortss = new SortExpression();
                    sortss.Add(new SortClause(KopukCagriFields.KopukCagriTarih, SortOperator.Descending));
                    sortss.Add(new SortClause(KopukCagriTuruFields.KopukCagriTuruAd, SortOperator.Ascending));
                    eg_snot.Fill(0, sortss, true);

                    grid_kopuk.DataSource = eg_snot;
                    grid_kopuk.DataBind();

                    grid_kopuk_sil.DataSource = eg_snot;
                    grid_kopuk_sil.DataBind();

                    cb_tur.Text = "";
                    cb_tur.NullText = "Seçiniz...";
                    txt_tel_no.Text = "";
                    txt_aciklama.Text = "";

                    cb_tur.Focus();
                }

                else
                {
                    KopukCagriCollection CollEx = new KopukCagriCollection();
                    IPredicateExpression ExpEx = new PredicateExpression();
                    ExpEx.AddWithAnd(KopukCagriFields.KopukCagriId == Convert.ToInt16(txtUserName.Text));
                    CollEx.GetMulti(ExpEx);

                    CollEx[0].FkKopukCagriTuruId = CollTur[0].KopukCagriTuruId;
                    CollEx[0].FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    CollEx[0].KopukCagriTelNo = txt_tel_no.Text;
                    CollEx[0].KopukCagriAciklama = txt_aciklama.Text;
                    CollEx[0].KopukCagriTarih = DateTime.Now;
                    CollEx[0].Save();

                    string CloseWindow;
                    CloseWindow = "alert('Güncelleme işlemi tamamlanmıştır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                    ListKopukTypedList eg_snot = new ListKopukTypedList();
                    ISortExpression sortss = new SortExpression();
                    sortss.Add(new SortClause(KopukCagriFields.KopukCagriTarih, SortOperator.Descending));
                    sortss.Add(new SortClause(KopukCagriTuruFields.KopukCagriTuruAd, SortOperator.Ascending));
                    eg_snot.Fill(0, sortss, true);

                    grid_kopuk.DataSource = eg_snot;
                    grid_kopuk.DataBind();

                    grid_kopuk_sil.DataSource = eg_snot;
                    grid_kopuk_sil.DataBind();

                    cb_tur.Text = "";
                    cb_tur.NullText = "Seçiniz...";
                    txt_tel_no.Text = "";
                    txt_aciklama.Text = "";

                    cb_tur.Focus();
                }
            }
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            Session["par_guncelle_mi"] = "1";

            Int32 idsi = Convert.ToInt32(txtUserName.Text);

            carTabPage.ActiveTabIndex = 0;

            KopukCagriCollection CollBil = new KopukCagriCollection();
            IPredicateExpression ExpBil = new PredicateExpression();
            ExpBil.AddWithAnd(KopukCagriFields.KopukCagriId == Convert.ToInt32(txtUserName.Text));
            CollBil.GetMulti(ExpBil);

            KopukCagriTuruCollection CollTur = new KopukCagriTuruCollection();
            IPredicateExpression ExpTur = new PredicateExpression();
            ExpTur.AddWithAnd(KopukCagriTuruFields.KopukCagriTuruId == CollBil[0].FkKopukCagriTuruId);
            CollTur.GetMulti(ExpTur);

            cb_tur.Text = CollTur[0].KopukCagriTuruAd;
            txt_aciklama.Text = CollBil[0].KopukCagriAciklama;
            txt_tel_no.Text = CollBil[0].KopukCagriTelNo;

            cb_tur.Focus();
        }
    }
}