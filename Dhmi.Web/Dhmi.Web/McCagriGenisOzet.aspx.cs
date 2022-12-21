using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dhmi.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.HelperClasses;

namespace Dhmi.Web
{
    public partial class McCagriGenisOzet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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

            VatandaCollection CollVat = new VatandaCollection();
            IPredicateExpression ExpVat = new PredicateExpression();
            ExpVat.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(Session["vatandas_iceri"].ToString()));
            CollVat.GetMulti(ExpVat);

            vt_kayit_turu.Text = CollVat[0].VatandasTur;
            vt_tc_kimlik_no.Text = CollVat[0].VatandasTcNo;
            vt_pasaport_no.Text = CollVat[0].VatandasPasaportNo;
            vt_uyruk.Text = CollVat[0].VatandasUyruk;

            if (CollVat[0].VatandasTur == "Tüzel Kişi")
            {
                vt_ad_soyad_firma.Text = CollVat[0].VatandasAd;
            }

            else 
            {
                vt_ad_soyad_firma.Text = CollVat[0].VatandasAdSoyad;
            }

            vt_cinsiyet.Text = CollVat[0].VatandasCinsiyet;

            if (CollVat[0].VatandasDogumTarihi.ToString() == "" && CollVat[0].VatandasDogumTarihi == null)
            {

            }

            else 
            {
                vt_dogum_tarihi.Text = CollVat[0].VatandasDogumTarihi.ToString().Substring(0, 10);
            }
            
            vt_telefon_no.Text = CollVat[0].VatandasTel1;
            vt_mail_adresi.Text = CollVat[0].VatandasMail;
            vt_adres.Text = CollVat[0].VatandasAdres;
            vt_not.Text = CollVat[0].VatandasNotes;

            BildirimCollection CollBil = new BildirimCollection();
            IPredicateExpression ExpBil = new PredicateExpression();
            ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(Session["bildirim_iceri"].ToString()));
            CollBil.GetMulti(ExpBil);

            BildirimTuruCollection CollBilTur = new BildirimTuruCollection();
            IPredicateExpression ExpBilTur = new PredicateExpression();
            ExpBilTur.AddWithAnd(BildirimTuruFields.BildirimTuruId == CollBil[0].FkBildirimTuruId);
            CollBilTur.GetMulti(ExpBilTur);

            BildirimGeriDonuCollection CollDon = new BildirimGeriDonuCollection();
            IPredicateExpression ExpDon = new PredicateExpression();
            ExpDon.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusId == CollBil[0].FkBildirimGeriDonusId);
            CollDon.GetMulti(ExpDon);

            BildirimSonucCollection CollSon = new BildirimSonucCollection();
            IPredicateExpression ExpSon = new PredicateExpression();
            ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucId == CollBil[0].FkBildirimSonucId);
            CollSon.GetMulti(ExpSon);

            AltKonuCollection CollAlt = new AltKonuCollection();
            IPredicateExpression ExpAlt = new PredicateExpression();
            ExpAlt.AddWithAnd(AltKonuFields.AltKonuId == CollBil[0].FkAltKonuId);
            CollAlt.GetMulti(ExpAlt);

            cb_bildirim_no.Text = CollBil[0].BildirimId.ToString();
            cb_bildirim_turu.Text = CollBilTur[0].BildirimTuruAd;
            cb_bilgi_sekil.Text = CollDon[0].BildirimGeriDonusAd;
            cb_sonuc.Text = CollSon[0].BildirimSonucAd;

            if (CollBil[0].BildirimSonIslemTarih.ToString() == "" && CollBil[0].BildirimSonIslemTarih == null)
            {

            }

            else
            {
                cb_son_islem_tarihi.Text = CollBil[0].BildirimSonIslemTarih.ToShortDateString();
            }
            
            cb_havalimani.Text = CollBil[0].BildirimHavalimani;
            cb_dava_ad_soyad.Text = CollBil[0].BildirimDavaAdSoyad;
            cb_dava_dosya_no.Text = CollBil[0].BildirimDavaDosyaNo;
            cb_dava_mahkeme.Text = CollBil[0].BildirimDavaMahkeme;
            cb_dava_konu.Text = CollBil[0].BildirimDavaKonu;
            cb_top_islem.Text = CollBil[0].BildirimToplamSure.ToString();
            cb_geri_donus_mu.Text = CollBil[0].BildirimGeriYapildiMi.ToString();
            cb_konu.Text = CollAlt[0].AltKonuAd;
            cb_aciklama_sikayet.Text = CollBil[0].BildirimMetin;
            cb_atanma_durumu.Text = CollBil[0].BildirimAtanmaDurumu;
            cb_not.Text = CollBil[0].BildirimAciklama;
            cb_vatandas_karar.Text = CollBil[0].BildirimVatandasKarar;

            BildirimHistoryCollection CollArsiv = new BildirimHistoryCollection();
            IPredicateExpression ExpArsiv = new PredicateExpression();
            ISortExpression sortarsiv = new SortExpression();
            ExpArsiv.AddWithAnd(BildirimHistoryFields.FkBildirimId == CollBil[0].BildirimId);
            sortarsiv.Add(new SortClause(BildirimHistoryFields.BildirimHistoryId, SortOperator.Ascending));
            CollArsiv.GetMulti(ExpArsiv, 0, sortarsiv);

            for (int i = 0; i < CollArsiv.Count; i++)
            {
                lb_gecmis.Items.Add("- " + CollArsiv[i].BildirimHistoryTarih.ToShortDateString() + " " + CollArsiv[i].BildirimHistoryTarih.ToShortTimeString() + " - " + CollArsiv[i].BildirimHistoryAciklama);
            }
        }
    }
}