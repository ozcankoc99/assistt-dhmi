using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using dhmi.TypedListClasses;
using dhmi.EntityClasses;
using System.Web;

namespace Dhmi.Web
{
    public partial class McAraRapor : System.Web.UI.Page
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

                Session["sorgula_cagri"] = null;
                Session["sorgula_kopuk"] = null;
                Session["sorgula_atama"] = null;

                string gun = DateTime.Now.Day.ToString();
                string ay = DateTime.Now.Month.ToString();
                string yil = DateTime.Now.Year.ToString();

                if (gun.Length == 1)
                {
                    gun = "0" + gun;
                }

                if (ay.Length == 1)
                {
                    ay = "0" + ay;
                }

                txt_bas_tarihi_cagri.Text = gun + "." + ay + "." + yil;
                txt_bit_tarihi_cagri.Text = gun + "." + ay + "." + yil;

                txt_bas_tarihi_kopuk.Text = gun + "." + ay + "." + yil;
                txt_bit_tarihi_kopuk.Text = gun + "." + ay + "." + yil;

                txt_bas_tarihi_atama.Text = gun + "." + ay + "." + yil;
                txt_bit_tarihi_atama.Text = gun + "." + ay + "." + yil;
            }

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            YetkiCollection CollYets = new YetkiCollection();
            IPredicateExpression ExpYets = new PredicateExpression();
            ExpYets.AddWithAnd(YetkiFields.YetkiId == CollKul[0].FkYetkiId);
            CollYets.GetMulti(ExpYets);

            Session["yetki_durum"] = CollYets[0].YetkiAciklama;

            if (Session["rapor_adi"].ToString() == "Vatandaş Bilgileri")
            {
                pnl_vatandas_bilgileri.Visible = true;
                pnl_cagri_bilgileri.Visible = false;
                pnl_kopuk_cagri.Visible = false;
                pnl_atama_bilgileri.Visible = false;
                pnl_vat_sec.Visible = false;
                pnl_acik_cagri.Visible = false;
                pnl_ayrinti.Visible = false;

                grid_vatandas_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "VATANDAŞ BİLGİLERİ/FİRMA" + Environment.NewLine + "  " + Environment.NewLine + "  ";
                grid_vatandas_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

                VatandaCollection CollVat = new VatandaCollection();
                ISortExpression sortss = new SortExpression();
                sortss.Add(new SortClause(VatandaFields.VatandasAdSoyad, SortOperator.Ascending));
                CollVat.GetMulti(null, 0, sortss);

                grid_vatandas.DataSource = CollVat;
                grid_vatandas.DataBind();
            }

            else if (Session["rapor_adi"].ToString() == "Çağrı Bilgileri")
            {                
                pnl_vatandas_bilgileri.Visible = false;
                pnl_cagri_bilgileri.Visible = true;
                pnl_kopuk_cagri.Visible = false;
                pnl_atama_bilgileri.Visible = false;
                pnl_vat_sec.Visible = false;
                pnl_acik_cagri.Visible = false;
                pnl_ayrinti.Visible = false;

                grid_bildirim_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "ÇAĞRI BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
                grid_bildirim_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

                ParametreCollection CollPrm = new ParametreCollection();
                IPredicateExpression ExpPrm = new PredicateExpression();
                ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
                CollPrm.GetMulti(ExpPrm);

                DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

                if (Session["sorgula_cagri"] == null)
                {
                    ListBildirimTypedList bil_list = new ListBildirimTypedList();
                    ISortExpression sort22 = new SortExpression();
                    sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filter2 = new PredicateExpression();
                    filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                    bil_list.Fill(0, sort22, true, filter2);

                    grid_bildirim.DataSource = bil_list;
                    grid_bildirim.DataBind();
                }

                else 
                {
                    ListBildirimTypedList bil_list = new ListBildirimTypedList();
                    ISortExpression sort22 = new SortExpression();
                    sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filter2 = new PredicateExpression();
                    filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi_cagri.Text));
                    filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi_cagri.Text));
                    bil_list.Fill(0, sort22, true, filter2);

                    grid_bildirim.DataSource = bil_list;
                    grid_bildirim.DataBind();
                }

                if (Session["yetki_durum"].ToString() == "Evet")
                {
                    grid_bildirim.Columns[2].Visible = true;
                    grid_bildirim.Columns[3].Visible = true;
                    grid_bildirim.Columns[4].Visible = true;
                    grid_bildirim.Columns[5].Visible = true;
                    grid_bildirim.Columns[6].Visible = true;
                }

                else
                {
                    grid_bildirim.Columns[2].Visible = false;
                    grid_bildirim.Columns[3].Visible = false;
                    grid_bildirim.Columns[4].Visible = false;
                    grid_bildirim.Columns[5].Visible = false;
                    grid_bildirim.Columns[6].Visible = false;
                }

                GrupCollection CollGr = new GrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(GrupFields.GrupAd == "Hukuk Müşavirliği");
                CollGr.GetMulti(ExpGr);

                GrupAtamaCollection CollAta = new GrupAtamaCollection();
                IPredicateExpression ExpAta = new PredicateExpression();
                ExpAta.AddWithAnd(GrupAtamaFields.FkGrupId == CollGr[0].GrupId);
                ExpAta.AddWithAnd(GrupAtamaFields.FkKullaniciId == CollKul[0].KullaniciId);
                CollAta.GetMulti(ExpAta);

                if (CollAta.Count > 0)
                {
                    grid_bildirim.Columns[17].Visible = true;
                    grid_bildirim.Columns[18].Visible = true;
                    grid_bildirim.Columns[19].Visible = true;
                    grid_bildirim.Columns[20].Visible = true;
                }

                else 
                {
                    grid_bildirim.Columns[17].Visible = false;
                    grid_bildirim.Columns[18].Visible = false;
                    grid_bildirim.Columns[19].Visible = false;
                    grid_bildirim.Columns[20].Visible = false;
                }
            }

            else if (Session["rapor_adi"].ToString() == "Köpük Bilgileri")
            {
                pnl_vatandas_bilgileri.Visible = false;
                pnl_cagri_bilgileri.Visible = false;
                pnl_kopuk_cagri.Visible = true;
                pnl_atama_bilgileri.Visible = false;
                pnl_vat_sec.Visible = false;
                pnl_acik_cagri.Visible = false;
                pnl_ayrinti.Visible = false;

                grid_kopuk_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "KÖPÜK ÇAĞRI BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
                grid_kopuk_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

                if (Session["sorgula_kopuk"] == null)
                {
                    ListKopukTypedList eg_snot = new ListKopukTypedList();
                    ISortExpression sortss = new SortExpression();
                    sortss.Add(new SortClause(KopukCagriFields.KopukCagriTarih, SortOperator.Descending));
                    sortss.Add(new SortClause(KopukCagriTuruFields.KopukCagriTuruAd, SortOperator.Ascending));
                    eg_snot.Fill(0, sortss, true);

                    grid_kopuk.DataSource = eg_snot;
                    grid_kopuk.DataBind();
                }

                else 
                {
                    ListKopukTypedList eg_snot = new ListKopukTypedList();
                    ISortExpression sortss = new SortExpression();
                    IPredicateExpression filter2 = new PredicateExpression();
                    sortss.Add(new SortClause(KopukCagriFields.KopukCagriTarih, SortOperator.Descending));
                    sortss.Add(new SortClause(KopukCagriTuruFields.KopukCagriTuruAd, SortOperator.Ascending));
                    filter2.AddWithAnd(KopukCagriFields.KopukCagriTarih >= Convert.ToDateTime(txt_bas_tarihi_kopuk.Text));
                    filter2.AddWithAnd(KopukCagriFields.KopukCagriTarih >= Convert.ToDateTime(txt_bit_tarihi_kopuk.Text));
                    eg_snot.Fill(0, sortss, true, filter2);

                    grid_kopuk.DataSource = eg_snot;
                    grid_kopuk.DataBind();
                }                
            }

            else if (Session["rapor_adi"].ToString() == "Atama Bilgileri")
            {
                pnl_vatandas_bilgileri.Visible = false;
                pnl_cagri_bilgileri.Visible = false;
                pnl_kopuk_cagri.Visible = false;
                pnl_atama_bilgileri.Visible = true;
                pnl_vat_sec.Visible = false;
                pnl_acik_cagri.Visible = false;
                pnl_ayrinti.Visible = false;

                if (Session["yetki_durum"].ToString() == "Evet") 
                {
                    ak_ad.Enabled = true;
                    ak_tel.Enabled = true;

                    grid_atanan.Columns[1].Visible = true;
                    grid_atanan.Columns[2].Visible = true;
                }

                else
                {
                    ak_ad.Enabled = false;
                    ak_tel.Enabled = false;

                    grid_atanan.Columns[1].Visible = false;
                    grid_atanan.Columns[2].Visible = false;
                }

                GrupCollection CollGr = new GrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(GrupFields.GrupAd == "Hukuk Müşavirliği");
                CollGr.GetMulti(ExpGr);

                GrupAtamaCollection CollAta = new GrupAtamaCollection();
                IPredicateExpression ExpAta = new PredicateExpression();
                ExpAta.AddWithAnd(GrupAtamaFields.FkGrupId == CollGr[0].GrupId);
                ExpAta.AddWithAnd(GrupAtamaFields.FkKullaniciId == CollKul[0].KullaniciId);
                CollAta.GetMulti(ExpAta);

                grid_atama_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "ATANAN BİLDİRİM BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
                grid_atama_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

                BildirimAtamaKullaniciCollection CollBilKul = new BildirimAtamaKullaniciCollection();
                IPredicateExpression ExpBilKul = new PredicateExpression();
                ExpBilKul.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollBilKul.GetMulti(ExpBilKul);

                if (CollAta.Count > 0)
                {
                    grid_atanan.Columns[14].Visible = true;
                    grid_atanan.Columns[15].Visible = true;
                    grid_atanan.Columns[16].Visible = true;
                    grid_atanan.Columns[17].Visible = true;
                }

                else 
                {
                    grid_atanan.Columns[14].Visible = false;
                    grid_atanan.Columns[15].Visible = false;
                    grid_atanan.Columns[16].Visible = false;
                    grid_atanan.Columns[17].Visible = false;
                }

                if (Session["sorgula_atama"] == null)
                {
                    ListBildirimTypedList bil_list2 = new ListBildirimTypedList();
                    ISortExpression sortbil2 = new SortExpression();
                    sortbil2.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filterbil2 = new PredicateExpression();
                    filterbil2.AddWithAnd(BildirimFields.BildirimId == CollBilKul[0].FkBildirimId);

                    for (int i = 1; i < CollBilKul.Count; i++)
                    {
                        filterbil2.AddWithOr(BildirimFields.BildirimId == CollBilKul[i].FkBildirimId);
                    }

                    bil_list2.Fill(0, sortbil2, true, filterbil2);

                    grid_atanan.DataSource = bil_list2;
                    grid_atanan.DataBind();
                }

                else 
                {
                    ListBildirimTypedList bil_list2 = new ListBildirimTypedList();
                    ISortExpression sortbil2 = new SortExpression();
                    sortbil2.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filterbil2 = new PredicateExpression();
                    filterbil2.AddWithAnd(BildirimFields.BildirimId == CollBilKul[0].FkBildirimId);

                    for (int i = 1; i < CollBilKul.Count; i++)
                    {
                        filterbil2.AddWithOr(BildirimFields.BildirimId == CollBilKul[i].FkBildirimId);
                    }

                    filterbil2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi_atama.Text));
                    filterbil2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi_atama.Text));
                    bil_list2.Fill(0, sortbil2, true, filterbil2);

                    grid_atanan.DataSource = bil_list2;
                    grid_atanan.DataBind();
                }                
            }

            else if (Session["rapor_adi"].ToString() == "Açık Çağrı Bilgileri")
            {
                pnl_vatandas_bilgileri.Visible = false;
                pnl_cagri_bilgileri.Visible = false;
                pnl_kopuk_cagri.Visible = false;
                pnl_atama_bilgileri.Visible = false;
                pnl_vat_sec.Visible = false;
                pnl_acik_cagri.Visible = true;
                pnl_ayrinti.Visible = false;

                gr_acik.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "AÇIK ÇAĞRI BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
                gr_acik.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

                AcikBildirimCollection CollD1 = new AcikBildirimCollection();
                CollD1.GetMulti(null);

                int sdsd = CollD1.Count;

                grid_acik.DataSource = CollD1;
                grid_acik.DataBind(); 
            }

            else if (Session["rapor_adi"].ToString() == "Açık Çağrı Bilgileri Ayrıntılı")
            {
                pnl_vatandas_bilgileri.Visible = false;
                pnl_cagri_bilgileri.Visible = false;
                pnl_kopuk_cagri.Visible = false;
                pnl_atama_bilgileri.Visible = false;
                pnl_vat_sec.Visible = false;
                pnl_acik_cagri.Visible = false;
                pnl_ayrinti.Visible = true;

                grid_ayrinti_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "AÇIK ÇAĞRI BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
                grid_ayrinti_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

                AcikBildirimAyrintiCollection CollD2 = new AcikBildirimAyrintiCollection();
                CollD2.GetMulti(null);

                grid_ayrinti.DataSource = CollD2;
                grid_ayrinti.DataBind();
            }

            else if (Session["rapor_adi"].ToString() == "Vatandaş Seçme Bilgileri")
            {
                pnl_vatandas_bilgileri.Visible = false;
                pnl_cagri_bilgileri.Visible = false;
                pnl_kopuk_cagri.Visible = false;
                pnl_atama_bilgileri.Visible = false;
                pnl_vat_sec.Visible = true;
                pnl_acik_cagri.Visible = false;
                pnl_ayrinti.Visible = false;

                VatandaCollection CollVat = new VatandaCollection();
                ISortExpression sortss = new SortExpression();
                sortss.Add(new SortClause(VatandaFields.VatandasAdSoyad, SortOperator.Ascending));
                CollVat.GetMulti(null, 0, sortss);

                grid_vatandas_sil.DataSource = CollVat;
                grid_vatandas_sil.DataBind();
            }
        }

        protected void k_k_no_CheckedChanged(object sender, EventArgs e)
        {
            if (k_k_no.Checked == true)
            {
                grid_vatandas.Columns[1].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[1].Visible = false;
            }
        }

        protected void k_kay_tur_CheckedChanged(object sender, EventArgs e)
        {
            if (k_kay_tur.Checked == true)
            {
                grid_vatandas.Columns[2].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[2].Visible = false;
            }
        }

        protected void k_tc_no_CheckedChanged(object sender, EventArgs e)
        {
            if (k_tc_no.Checked == true)
            {
                grid_vatandas.Columns[3].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[3].Visible = false;
            }
        }

        protected void k_pasaport_CheckedChanged(object sender, EventArgs e)
        {
            if (k_pasaport.Checked == true)
            {
                grid_vatandas.Columns[4].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[4].Visible = false;
            }
        }

        protected void k_vergi_CheckedChanged(object sender, EventArgs e)
        {
            if (k_vergi.Checked == true)
            {
                grid_vatandas.Columns[5].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[5].Visible = false;
            }
        }

        protected void k_uyruk_CheckedChanged(object sender, EventArgs e)
        {
            if (k_uyruk.Checked == true)
            {
                grid_vatandas.Columns[6].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[6].Visible = false;
            }
        }

        protected void k_ad_CheckedChanged(object sender, EventArgs e)
        {
            if (k_ad.Checked == true)
            {
                grid_vatandas.Columns[7].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[7].Visible = false;
            }
        }

        protected void k_cinsiyet_CheckedChanged(object sender, EventArgs e)
        {
            if (k_cinsiyet.Checked == true)
            {
                grid_vatandas.Columns[8].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[8].Visible = false;
            }
        }

        protected void k_d_tarih_CheckedChanged(object sender, EventArgs e)
        {
            if (k_d_tarih.Checked == true)
            {
                grid_vatandas.Columns[9].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[9].Visible = false;
            }
        }

        protected void k_mail_CheckedChanged(object sender, EventArgs e)
        {
            if (k_mail.Checked == true)
            {
                grid_vatandas.Columns[10].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[10].Visible = false;
            }
        }

        protected void k_tel_CheckedChanged(object sender, EventArgs e)
        {
            if (k_tel.Checked == true)
            {
                grid_vatandas.Columns[11].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[11].Visible = false;
            }
        }

        protected void k_tel_2_CheckedChanged(object sender, EventArgs e)
        {
            if (k_tel_2.Checked == true)
            {
                grid_vatandas.Columns[12].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[12].Visible = false;
            }
        }

        protected void k_not_CheckedChanged(object sender, EventArgs e)
        {
            if (k_not.Checked == true)
            {
                grid_vatandas.Columns[13].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[13].Visible = false;
            }
        }

        protected void k_adres_CheckedChanged(object sender, EventArgs e)
        {
            if (k_adres.Checked == true)
            {
                grid_vatandas.Columns[14].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[14].Visible = false;
            }
        }

        protected void k_i_tarih_CheckedChanged(object sender, EventArgs e)
        {
            if (k_i_tarih.Checked == true)
            {
                grid_vatandas.Columns[15].Visible = true;
            }

            else
            {
                grid_vatandas.Columns[15].Visible = false;
            }
        }

        protected void btnPdfExport_Click(object sender, EventArgs e)
        {
            string ad = "vatandas_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_vatandas_export.WritePdfToResponse(ad);
        }

        protected void btnXlsExport_Click(object sender, EventArgs e)
        {
            string ad = "vatandas_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_vatandas_export.WriteXlsToResponse(ad);
        }

        protected void btnRtfExport_Click(object sender, EventArgs e)
        {
            string ad = "vatandas_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_vatandas_export.WriteRtfToResponse(ad);
        }

        protected void k_bil_no_CheckedChanged(object sender, EventArgs e)
        {
            if (k_bil_no.Checked == true)
            {
                grid_bildirim.Columns[1].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[1].Visible = false;
            }
        }

        protected void k_ad222_CheckedChanged(object sender, EventArgs e)
        {
            if (k_ad222.Checked == true)
            {
                grid_bildirim.Columns[2].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[2].Visible = false;
            }
        }

        protected void k_tcsi_CheckedChanged(object sender, EventArgs e)
        {
            if (k_tcsi.Checked == true)
            {
                grid_bildirim.Columns[3].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[3].Visible = false;
            }
        }

        protected void kk_pasaport_CheckedChanged(object sender, EventArgs e)
        {
            if (kk_pasaport.Checked == true)
            {
                grid_bildirim.Columns[4].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[4].Visible = false;
            }
        }

        protected void kk_vergisi_CheckedChanged(object sender, EventArgs e)
        {
            if (kk_vergisi.Checked == true)
            {
                grid_bildirim.Columns[5].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[5].Visible = false;
            }
        }

        protected void k_tel22_CheckedChanged(object sender, EventArgs e)
        {
            if (k_tel22.Checked == true)
            {
                grid_bildirim.Columns[6].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[6].Visible = false;
            }
        }

        protected void k_cag_sis_CheckedChanged(object sender, EventArgs e)
        {
            if (k_cag_sis.Checked == true)
            {
                grid_bildirim.Columns[7].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[7].Visible = false;
            }
        }

        protected void k_bil_tur_CheckedChanged(object sender, EventArgs e)
        {
            if (k_bil_tur.Checked == true)
            {
                grid_bildirim.Columns[8].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[8].Visible = false;
            }
        }

        protected void k_bil_sekil_CheckedChanged(object sender, EventArgs e)
        {
            if (k_bil_sekil.Checked == true)
            {
                grid_bildirim.Columns[9].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[9].Visible = false;
            }
        }

        protected void k_konu_CheckedChanged(object sender, EventArgs e)
        {
            if (k_konu.Checked == true)
            {
                grid_bildirim.Columns[10].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[10].Visible = false;
            }
        }

        protected void k_aciklama_CheckedChanged(object sender, EventArgs e)
        {
            if (k_aciklama.Checked == true)
            {
                grid_bildirim.Columns[11].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[11].Visible = false;
            }
        }

        protected void k_notte_CheckedChanged(object sender, EventArgs e)
        {
            if (k_notte.Checked == true)
            {
                grid_bildirim.Columns[12].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[12].Visible = false;
            }
        }

        protected void k_son_tar_CheckedChanged(object sender, EventArgs e)
        {
            if (k_son_tar.Checked == true)
            {
                grid_bildirim.Columns[13].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[13].Visible = false;
            }
        }

        protected void k_sonuc_CheckedChanged(object sender, EventArgs e)
        {
            if (k_sonuc.Checked == true)
            {
                grid_bildirim.Columns[14].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[14].Visible = false;
            }
        }

        protected void k_atanma_CheckedChanged(object sender, EventArgs e)
        {
            if (k_atanma.Checked == true)
            {
                grid_bildirim.Columns[15].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[15].Visible = false;
            }
        }

        protected void k_hav_1_CheckedChanged(object sender, EventArgs e)
        {
            if (k_hav_1.Checked == true)
            {
                grid_bildirim.Columns[16].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[16].Visible = false;
            }
        }

        protected void k_dava_ad_soyad_CheckedChanged(object sender, EventArgs e)
        {
            if (k_dava_ad_soyad.Checked == true)
            {
                grid_bildirim.Columns[17].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[17].Visible = false;
            }
        }

        protected void k_dava_mahkeme_CheckedChanged(object sender, EventArgs e)
        {
            if (k_dava_mahkeme.Checked == true)
            {
                grid_bildirim.Columns[18].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[18].Visible = false;
            }
        }

        protected void k_dava_dosya_no_CheckedChanged(object sender, EventArgs e)
        {
            if (k_dava_dosya_no.Checked == true)
            {
                grid_bildirim.Columns[19].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[19].Visible = false;
            }
        }

        protected void k_dava_konu_CheckedChanged(object sender, EventArgs e)
        {
            if (k_dava_konu.Checked == true)
            {
                grid_bildirim.Columns[20].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[20].Visible = false;
            }
        }

        protected void k_sure_CheckedChanged(object sender, EventArgs e)
        {
            if (k_sure.Checked == true)
            {
                grid_bildirim.Columns[21].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[21].Visible = false;
            }
        }

        protected void k_kar_vatd_CheckedChanged(object sender, EventArgs e)
        {
            if (k_kar_vatd.Checked == true)
            {
                grid_bildirim.Columns[22].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[22].Visible = false;
            }
        }

        protected void k_k_geri_CheckedChanged(object sender, EventArgs e)
        {
            if (k_k_geri.Checked == true)
            {
                grid_bildirim.Columns[23].Visible = true;
            }

            else
            {
                grid_bildirim.Columns[23].Visible = false;
            }
        }

        protected void btn_pdf_cagri_Click(object sender, EventArgs e)
        {
            string ad = "cagri_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_bildirim_export.WritePdfToResponse(ad);
        }

        protected void btn_xls_cagri_Click(object sender, EventArgs e)
        {
            string ad = "cagri_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_bildirim_export.WriteXlsToResponse(ad);
        }

        protected void btn_doc_cagri_Click(object sender, EventArgs e)
        {
            string ad = "cagri_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_bildirim_export.WriteRtfToResponse(ad);
        }

        protected void kopuk_pdf_Click(object sender, EventArgs e)
        {
            string ad = "kopuk_cagri_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_kopuk_export.WritePdfToResponse(ad);
        }

        protected void kopuk_xls_Click(object sender, EventArgs e)
        {
            string ad = "kopuk_cagri_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_kopuk_export.WriteXlsToResponse(ad);
        }

        protected void kopuk_doc_Click(object sender, EventArgs e)
        {
            string ad = "kopuk_cagri_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_kopuk_export.WriteRtfToResponse(ad);
        }

        protected void ak_ad_CheckedChanged(object sender, EventArgs e)
        {
            if (ak_ad.Checked == true)
            {
                grid_atanan.Columns[1].Visible = true;
            }

            else
            {
                grid_atanan.Columns[1].Visible = false;
            }
        }

        protected void ak_tel_CheckedChanged(object sender, EventArgs e)
        {
            if (ak_tel.Checked == true)
            {
                grid_atanan.Columns[2].Visible = true;
            }

            else
            {
                grid_atanan.Columns[2].Visible = false;
            }
        }

        protected void ak_bil_no_CheckedChanged(object sender, EventArgs e)
        {
            if (ak_bil_no.Checked == true)
            {
                grid_atanan.Columns[3].Visible = true;
            }

            else
            {
                grid_atanan.Columns[3].Visible = false;
            }
        }

        protected void ak_cag_sis_CheckedChanged(object sender, EventArgs e)
        {
            if (ak_cag_sis.Checked == true)
            {
                grid_atanan.Columns[4].Visible = true;
            }

            else
            {
                grid_atanan.Columns[4].Visible = false;
            }
        }

        protected void ak_bil_tur_CheckedChanged(object sender, EventArgs e)
        {
            if (ak_bil_tur.Checked == true)
            {
                grid_atanan.Columns[5].Visible = true;
            }

            else
            {
                grid_atanan.Columns[5].Visible = false;
            }
        }

        protected void ak_bil_sekil_CheckedChanged(object sender, EventArgs e)
        {
            if (ak_bil_sekil.Checked == true)
            {
                grid_bildirim.Columns[6].Visible = true;
            }

            else
            {
                grid_atanan.Columns[6].Visible = false;
            }
        }

        protected void ak_konu_CheckedChanged(object sender, EventArgs e)
        {
            if (ak_konu.Checked == true)
            {
                grid_atanan.Columns[7].Visible = true;
            }

            else
            {
                grid_atanan.Columns[7].Visible = false;
            }
        }

        protected void ak_aciklama_CheckedChanged(object sender, EventArgs e)
        {
            if (ak_ad.Checked == true)
            {
                grid_atanan.Columns[8].Visible = true;
            }

            else
            {
                grid_atanan.Columns[8].Visible = false;
            }
        }

        protected void k_notbak_CheckedChanged(object sender, EventArgs e)
        {
            if (k_notbak.Checked == true)
            {
                grid_atanan.Columns[9].Visible = true;
            }

            else
            {
                grid_atanan.Columns[9].Visible = false;
            }
        }

        protected void ak_son_tar_CheckedChanged(object sender, EventArgs e)
        {
            if (ak_son_tar.Checked == true)
            {
                grid_atanan.Columns[10].Visible = true;
            }

            else
            {
                grid_atanan.Columns[10].Visible = false;
            }
        }

        protected void ak_sonuc_CheckedChanged(object sender, EventArgs e)
        {
            if (ak_sonuc.Checked == true)
            {
                grid_atanan.Columns[11].Visible = true;
            }

            else
            {
                grid_atanan.Columns[11].Visible = false;
            }
        }

        protected void ak_atanma_CheckedChanged(object sender, EventArgs e)
        {
            if (ak_atanma.Checked == true)
            {
                grid_atanan.Columns[12].Visible = true;
            }

            else
            {
                grid_atanan.Columns[12].Visible = false;
            }
        }

        protected void k_hav_2_CheckedChanged(object sender, EventArgs e)
        {
            if (k_hav_2.Checked == true)
            {
                grid_atanan.Columns[13].Visible = true;
            }

            else
            {
                grid_atanan.Columns[13].Visible = false;
            }
        }

        protected void kb_dava_ad_CheckedChanged(object sender, EventArgs e)
        {
            if (kb_dava_ad.Checked == true)
            {
                grid_atanan.Columns[14].Visible = true;
            }

            else
            {
                grid_atanan.Columns[14].Visible = false;
            }
        }

        protected void kb_dava_no_CheckedChanged(object sender, EventArgs e)
        {
            if (kb_dava_no.Checked == true)
            {
                grid_atanan.Columns[15].Visible = true;
            }

            else
            {
                grid_atanan.Columns[15].Visible = false;
            }
        }

        protected void kb_dava_mahkene_CheckedChanged(object sender, EventArgs e)
        {
            if (kb_dava_mahkene.Checked == true)
            {
                grid_atanan.Columns[16].Visible = true;
            }

            else
            {
                grid_atanan.Columns[16].Visible = false;
            }
        }

        protected void kb_dava_konu_CheckedChanged(object sender, EventArgs e)
        {
            if (kb_dava_konu.Checked == true)
            {
                grid_atanan.Columns[17].Visible = true;
            }

            else
            {
                grid_atanan.Columns[17].Visible = false;
            }
        }

        protected void ak_sure_CheckedChanged(object sender, EventArgs e)
        {
            if (ak_atanma.Checked == true)
            {
                grid_atanan.Columns[18].Visible = true;
            }

            else
            {
                grid_atanan.Columns[18].Visible = false;
            }
        }

        protected void k_kar_vat_CheckedChanged(object sender, EventArgs e)
        {
            if (k_kar_vat.Checked == true)
            {
                grid_atanan.Columns[19].Visible = true;
            }

            else
            {
                grid_atanan.Columns[19].Visible = false;
            }
        }

        protected void k_geri_don_CheckedChanged(object sender, EventArgs e)
        {
            if (k_geri_don.Checked == true)
            {
                grid_atanan.Columns[20].Visible = true;
            }

            else
            {
                grid_atanan.Columns[20].Visible = false;
            }
        }

        protected void at_pdf_Click(object sender, EventArgs e)
        {
            string ad = "atanan_cagri_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_atama_export.WritePdfToResponse(ad);
        }

        protected void at_xls_Click(object sender, EventArgs e)
        {
            string ad = "atanan_cagri_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_atama_export.WriteXlsToResponse(ad);
        }

        protected void at_doc_Click(object sender, EventArgs e)
        {
            string ad = "atanan_cagri_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_atama_export.WriteRtfToResponse(ad);
        }

        protected void grid_vatandas_sil_SelectionChanged(object sender, EventArgs e)
        {
            txtUserNameVat.Text = grid_vatandas_sil.GetSelectedFieldValues("VatandasId")[0].ToString();

            Session["vat_id"] = txtUserNameVat.Text;
        }

        protected void btn_kapat_Click(object sender, EventArgs e)
        {

        }

        protected void btn_sorgula_cagri_Click(object sender, EventArgs e)
        {
            DateTime zaman1 = Convert.ToDateTime(txt_bas_tarihi_cagri.Text);
            DateTime zaman2 = Convert.ToDateTime(txt_bit_tarihi_cagri.Text);

            ListBildirimTypedList bil_list = new ListBildirimTypedList();
            ISortExpression sort22 = new SortExpression();
            sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filter2 = new PredicateExpression();
            filter2.AddWithAnd(BildirimFields.BildirimTarih > zaman1);
            filter2.AddWithAnd(BildirimFields.BildirimTarih < zaman2);
            bil_list.Fill(0, sort22, true, filter2);

            grid_bildirim.DataSource = bil_list;
            grid_bildirim.DataBind();

            Session["sorgula_cagri"] = "1";
        }

        protected void btn_sorgula_kopuk_Click(object sender, EventArgs e)
        {
            DateTime zaman1 = Convert.ToDateTime(txt_bas_tarihi_kopuk.Text);
            DateTime zaman2 = Convert.ToDateTime(txt_bit_tarihi_kopuk.Text);

            ListKopukTypedList eg_snot = new ListKopukTypedList();
            ISortExpression sortss = new SortExpression();
            IPredicateExpression filter2 = new PredicateExpression();
            sortss.Add(new SortClause(KopukCagriFields.KopukCagriTarih, SortOperator.Descending));
            sortss.Add(new SortClause(KopukCagriTuruFields.KopukCagriTuruAd, SortOperator.Ascending));
            filter2.AddWithAnd(KopukCagriFields.KopukCagriTarih > zaman1);
            filter2.AddWithAnd(KopukCagriFields.KopukCagriTarih < zaman2);
            eg_snot.Fill(0, sortss, true, filter2);

            grid_kopuk.DataSource = eg_snot;
            grid_kopuk.DataBind();

            Session["sorgula_kopuk"] = "1";
        }       

        protected void btn_sorgula_atama_Click(object sender, EventArgs e) 
        {
            DateTime zaman1 = Convert.ToDateTime(txt_bas_tarihi_atama.Text);
            DateTime zaman2 = Convert.ToDateTime(txt_bit_tarihi_atama.Text);

            BildirimAtamaKullaniciCollection CollBilKul = new BildirimAtamaKullaniciCollection();
            IPredicateExpression ExpBilKul = new PredicateExpression();
            ExpBilKul.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollBilKul.GetMulti(ExpBilKul);

            ListBildirimTypedList bil_list2 = new ListBildirimTypedList();
            ISortExpression sortbil2 = new SortExpression();
            sortbil2.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filterbil2 = new PredicateExpression();
            filterbil2.AddWithAnd(BildirimFields.BildirimId == CollBilKul[0].FkBildirimId);

            for (int i = 1; i < CollBilKul.Count; i++)
            {
                filterbil2.AddWithOr(BildirimFields.BildirimId == CollBilKul[i].FkBildirimId);
            }

            filterbil2.AddWithAnd(BildirimFields.BildirimTarih > zaman1);
            filterbil2.AddWithAnd(BildirimFields.BildirimTarih < zaman2);
            bil_list2.Fill(0, sortbil2, true, filterbil2);

            grid_atanan.DataSource = bil_list2;
            grid_atanan.DataBind();

            Session["sorgula_atama"] = "1";
        }

        protected void acik_pdf_Click(object sender, EventArgs e)
        {
            string ad = "acik_cagri_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            gr_acik.WritePdfToResponse(ad);
        }

        protected void acik_xls_Click(object sender, EventArgs e)
        {
            string ad = "acik_cagri_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            gr_acik.WriteXlsToResponse(ad);
        }

        protected void acik_doc_Click(object sender, EventArgs e)
        {
            string ad = "acik_cagri_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            gr_acik.WriteRtfToResponse(ad);
        }

        protected void ayrinti_pdf_Click(object sender, EventArgs e)
        {
            string ad = "ayrinti_cagri_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_ayrinti_export.WritePdfToResponse(ad);
        }

        protected void ayrinti_xls_Click(object sender, EventArgs e)
        {
            string ad = "ayrinti_cagri_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_ayrinti_export.WriteXlsToResponse(ad);
        }

        protected void ayrinti_doc_Click(object sender, EventArgs e)
        {
            string ad = "ayrinti_cagri_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_ayrinti_export.WriteRtfToResponse(ad);
        }
    }
}