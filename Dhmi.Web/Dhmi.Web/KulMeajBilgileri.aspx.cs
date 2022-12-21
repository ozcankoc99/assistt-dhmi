using System;
using System.Web.UI;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.CollectionClasses;
using dhmi.TypedListClasses;
using dhmi.HelperClasses;
using dhmi.EntityClasses;
using System.Web;

namespace Dhmi.Web
{
    public partial class KulMeajBilgileri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["menu_sec"] = "Kullanıcı İşlemleri";

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

            KullaniciCollection CollKim = new KullaniciCollection();
            IPredicateExpression ExpKim = new PredicateExpression();
            ExpKim.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKim.GetMulti(ExpKim);

            ListMesajTypedList mesaj_list = new ListMesajTypedList();
            ISortExpression sort = new SortExpression();
            sort.Add(new SortClause(MesajFields.MesajTarih, SortOperator.Descending));
            IPredicateExpression filter = new PredicateExpression();
            filter.AddWithAnd(MesajFields.MesajHangiKullanici == CollKim[0].KullaniciAdSoyad);
            mesaj_list.Fill(0, sort, true, filter);

            grid_mesaj.DataSource = mesaj_list;
            grid_mesaj.DataBind();

            ListMesajTypedList mesaj_list2 = new ListMesajTypedList();
            ISortExpression sort22 = new SortExpression();
            sort22.Add(new SortClause(MesajFields.MesajTarih, SortOperator.Descending));
            IPredicateExpression filter2 = new PredicateExpression();
            filter2.AddWithAnd(MesajFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            mesaj_list2.Fill(0, sort22, true, filter2);

            grid_mesaj_git.DataSource = mesaj_list2;
            grid_mesaj_git.DataBind();

            grid_mesaj_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "GELEN KUTUSU" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_mesaj_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

            grid_mesaj_git_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "GİDEN KUTUSU" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_mesaj_git_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            grid_mesaj.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_mesaj_git.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            if (IsPostBack != true)
            {
                cb_grup.Items.Clear();

                GrupCollection CollGr = new GrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(GrupFields.GrupDurum == true);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                for (int i = 0; i < CollGr.Count; i++)
                {
                    cb_grup.Items.Add(CollGr[i].GrupAd);
                }

                cb_grup.Items.Add("HEPSİ");

                MenuCollection CollMenu = new MenuCollection();
                IPredicateExpression ExpMenu = new PredicateExpression();
                ExpMenu.AddWithAnd(MenuFields.MenuAd == "Kullanıcı İşlemleri");
                CollMenu.GetMulti(ExpMenu);

                AltMenuCollection CollAlt1 = new AltMenuCollection();
                IPredicateExpression ExpAlt1 = new PredicateExpression();
                ExpAlt1.AddWithAnd(AltMenuFields.AltMenuAd == "Kullanıcı Bilgileri");
                CollAlt1.GetMulti(ExpAlt1);

                AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                IPredicateExpression ExpAlt2 = new PredicateExpression();
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Mesaj Bilgileri");
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

                cb_per_list.Items.Clear();

                KullaniciCollection CollEkle = new KullaniciCollection();
                IPredicateExpression ExpEkle = new PredicateExpression();
                ISortExpression sortekle = new SortExpression();
                ExpEkle.AddWithAnd(KullaniciFields.KullaniciId != Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                ExpEkle.AddWithAnd(KullaniciFields.KullaniciDurum == true);
                sortekle.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
                CollEkle.GetMulti(ExpEkle, 0, sortekle);

                for (int i = 0; i < CollEkle.Count; i++)
                {
                    cb_per_list.Items.Add(CollEkle[i].KullaniciAdSoyad);
                }
            }
        }

        protected void btnPdfExport_Click(object sender, EventArgs e)
        {
            string ad = "mesaj_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_mesaj_export.WritePdfToResponse(ad);
        }

        protected void btnXlsExport_Click(object sender, EventArgs e)
        {
            string ad = "mesaj_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_mesaj_export.WriteXlsToResponse(ad);
        }

        protected void btnRtfExport_Click(object sender, EventArgs e)
        {
            string ad = "mesaj_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_mesaj_export.WriteRtfToResponse(ad);
        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            int say = 0;

            for (int i = 0; i < cb_per_list.Items.Count; i++)
            {
                if (cb_per_list.Items[i].Selected == true)
                {
                    say = say + 1;
                }
            }

            if (say == 0)
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen en az bir personel seçiniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else
            {
                for (int i = 0; i < cb_per_list.Items.Count; i++)
                {
                    if (cb_per_list.Items[i].Selected == true)
                    {
                        MesajEntity EntKay = new MesajEntity();
                        EntKay.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                        EntKay.MesajBaslik = txt_aciklama.Text;
                        EntKay.MesajIcerik = txt_icerik.Text;
                        EntKay.MesajTarih = DateTime.Now;
                        EntKay.MesajHangiKullanici = cb_per_list.Items[i].Text;
                        EntKay.Save();
                    }
                }

                string CloseWindow;
                CloseWindow = "alert('Mesaj(lar)ınız gönderilmiştir...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                KullaniciCollection CollKim = new KullaniciCollection();
                IPredicateExpression ExpKim = new PredicateExpression();
                ExpKim.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollKim.GetMulti(ExpKim);

                ListMesajTypedList mesaj_list = new ListMesajTypedList();
                ISortExpression sort = new SortExpression();
                sort.Add(new SortClause(MesajFields.MesajTarih, SortOperator.Descending));
                IPredicateExpression filter = new PredicateExpression();
                filter.AddWithAnd(MesajFields.MesajHangiKullanici == CollKim[0].KullaniciAdSoyad);
                mesaj_list.Fill(0, sort, true, filter);

                grid_mesaj.DataSource = mesaj_list;
                grid_mesaj.DataBind();

                ListMesajTypedList mesaj_list2 = new ListMesajTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(MesajFields.MesajTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();
                filter2.AddWithAnd(MesajFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                mesaj_list2.Fill(0, sort22, true, filter2);

                grid_mesaj_git.DataSource = mesaj_list2;
                grid_mesaj_git.DataBind();

                for (int i = 0; i < cb_per_list.Items.Count; i++)
                {
                    cb_per_list.Items[i].Selected = false;
                }

                txt_aciklama.Text = "";
                txt_icerik.Text = "";
                cb_hepsi.Checked = false;
                cb_grup.Text = "";
                cb_grup.NullText = "Seçiniz...";
            }
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cb_per_list.Items.Count; i++)
            {
                cb_per_list.Items[i].Selected = false;
            }

            txt_aciklama.Text = "";
            txt_icerik.Text = "";
            cb_hepsi.Checked = false;
            cb_grup.Text = "";
            cb_grup.NullText = "Seçiniz...";
        }

        protected void grid_mesaj_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_mesaj.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_mesaj_git_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_mesaj_git.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void btn_pdf_al_Click(object sender, EventArgs e)
        {
            string ad = "mesaj_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_mesaj_git_export.WritePdfToResponse(ad);
        }

        protected void btn_exc_al_Click(object sender, EventArgs e)
        {
            string ad = "mesaj_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_mesaj_git_export.WriteXlsToResponse(ad);
        }

        protected void btn_doc_al_Click(object sender, EventArgs e)
        {
            string ad = "mesaj_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_mesaj_git_export.WriteRtfToResponse(ad);
        }

        protected void cb_grup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_hepsi.Checked = false;

            cb_per_list.Items.Clear();

            if (cb_grup.Text == "HEPSİ")
            {
                KullaniciCollection CollEkle = new KullaniciCollection();
                IPredicateExpression ExpEkle = new PredicateExpression();
                ISortExpression sortekle = new SortExpression();
                ExpEkle.AddWithAnd(KullaniciFields.KullaniciId != Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                ExpEkle.AddWithAnd(KullaniciFields.KullaniciDurum == true);
                sortekle.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
                CollEkle.GetMulti(ExpEkle, 0, sortekle);

                for (int i = 0; i < CollEkle.Count; i++)
                {
                    cb_per_list.Items.Add(CollEkle[i].KullaniciAdSoyad);
                }
            }

            else
            {
                GrupCollection CollGr = new GrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(GrupFields.GrupAd == cb_grup.Text);
                CollGr.GetMulti(ExpGr);

                ListGrupAtamaTypedList mesaj_list = new ListGrupAtamaTypedList();
                ISortExpression sort = new SortExpression();
                sort.Add(new SortClause(KullaniciFields.KullaniciAd, SortOperator.Descending));
                IPredicateExpression filter = new PredicateExpression();
                filter.AddWithAnd(GrupAtamaFields.FkGrupId == CollGr[0].GrupId);
                mesaj_list.Fill(0, sort, true, filter);

                for (int i = 0; i < mesaj_list.Count; i++)
                {
                    cb_per_list.Items.Add(mesaj_list[i].KullaniciAdSoyad);
                }
            }
        }

        protected void cb_hepsi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hepsi.Checked == true)
            {
                for (int i = 0; i < cb_per_list.Items.Count; i++)
                {
                    cb_per_list.Items[i].Selected = true;
                }
            }

            else
            {
                for (int i = 0; i < cb_per_list.Items.Count; i++)
                {
                    cb_per_list.Items[i].Selected = false;
                }
            }
        }
    }
}