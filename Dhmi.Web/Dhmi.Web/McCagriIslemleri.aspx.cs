using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using dhmi.EntityClasses;
using dhmi.TypedListClasses;
using System.Web;

namespace Dhmi.Web
{
    public partial class McCagriIslemleri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["vat_id"] = null;
            Session["vat_gelen"] = null;
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
                atama_sure_takip();
                inceleme_sure_takip();
                inceleme_ek_sure_takip();                
            }
        }                

        void atama_sure_takip()
        {
            ListAtamaTypedList list1 = new ListAtamaTypedList();
            IPredicateExpression filter1 = new PredicateExpression();
            filter1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
            filter1.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciBittiMi == false);
            filter1.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            list1.Fill(0, null, true, filter1);

            for (int i = 0; i < list1.Count; i++)
            {
                BildirimTuruCollection CollBilTur = new BildirimTuruCollection();
                IPredicateExpression ExpBilTur = new PredicateExpression();
                ExpBilTur.AddWithAnd(BildirimTuruFields.BildirimTuruId == list1[i].FkBildirimTuruId);
                CollBilTur.GetMulti(ExpBilTur);

                Int64 saati = CollBilTur[0].BildirimTuruIslemAlSaatZaman;

                TimeSpan fark_bak1 = DateTime.Now - list1[i].BildirimAtamaKullaniciTarih;

                string duzle = (fark_bak1.TotalHours).ToString();

                double arasi = Convert.ToDouble(duzle);

                Int64 ana_fark = Convert.ToInt16(arasi);

                if (ana_fark > saati)
                {
                    KullaniciCollection CollKula = new KullaniciCollection();
                    IPredicateExpression ExpKula = new PredicateExpression();
                    ExpKula.AddWithAnd(KullaniciFields.KullaniciId == list1[i].FkKullaniciId_);
                    CollKula.GetMulti(ExpKula);

                    BildirimCollection CollBilBul = new BildirimCollection();
                    IPredicateExpression ExpBilBul = new PredicateExpression();
                    ExpBilBul.AddWithAnd(BildirimFields.BildirimId == list1[i].FkBildirimId);
                    CollBilBul.GetMulti(ExpBilBul);

                    BilgilendirmeCollection CollHa = new BilgilendirmeCollection();
                    IPredicateExpression ExpHa = new PredicateExpression();
                    ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeGelenKullanici == "SİSTEM");
                    ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeGidenKullanici == CollKula[0].KullaniciAdSoyad);
                    ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeIcerik == CollBilBul[0].BildirimId + " kayıt numaralı bildirim için 'İNCELEMEYE ALMA' işlemi maksimum süresini (" + CollBilTur[0].BildirimTuruIslemAlSure + ") aşmış bulunmaktasınız.");
                    ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeTarih >= DateTime.Today);
                    CollHa.GetMulti(ExpHa);

                    if (CollHa.Count == 0)
                    {
                        BilgilendirmeEntity EntMe = new BilgilendirmeEntity();
                        EntMe.BilgilendirmeGelenKullanici = "SİSTEM";
                        EntMe.BilgilendirmeGidenKullanici = CollKula[0].KullaniciAdSoyad;
                        EntMe.BilgilendirmeIcerik = CollBilBul[0].BildirimId + " kayıt numaralı bildirim için 'İNCELEMEYE ALMA' işlemi maksimum süresini (" + CollBilTur[0].BildirimTuruIslemAlSure + ") aşmış bulunmaktasınız.";
                        EntMe.BilgilendirmeTarih = DateTime.Now;
                        EntMe.Save();
                    }
                }
            }
        }

        void inceleme_sure_takip()
        {
            ListAtamaTypedList list1 = new ListAtamaTypedList();
            IPredicateExpression filter1 = new PredicateExpression();
            filter1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
            filter1.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciBittiMi == false);
            filter1.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            list1.Fill(0, null, true, filter1);

            for (int i = 0; i < list1.Count; i++)
            {
                BildirimTuruCollection CollBilTur = new BildirimTuruCollection();
                IPredicateExpression ExpBilTur = new PredicateExpression();
                ExpBilTur.AddWithAnd(BildirimTuruFields.BildirimTuruId == list1[i].FkBildirimTuruId);
                CollBilTur.GetMulti(ExpBilTur);

                Int64 saati = CollBilTur[0].BildirimTuruIslemAlSaatZaman;

                TimeSpan fark_bak1 = DateTime.Now - list1[i].BildirimAtamaKullaniciTarih;

                string duzle = (fark_bak1.TotalHours).ToString();

                double arasi = Convert.ToDouble(duzle);

                Int64 ana_fark = Convert.ToInt64(arasi);

                if (ana_fark > saati)
                {
                    KullaniciCollection CollKula = new KullaniciCollection();
                    IPredicateExpression ExpKula = new PredicateExpression();
                    ExpKula.AddWithAnd(KullaniciFields.KullaniciId == list1[i].FkKullaniciId_);
                    CollKula.GetMulti(ExpKula);

                    BildirimCollection CollBilBul = new BildirimCollection();
                    IPredicateExpression ExpBilBul = new PredicateExpression();
                    ExpBilBul.AddWithAnd(BildirimFields.BildirimId == list1[i].FkBildirimId);
                    CollBilBul.GetMulti(ExpBilBul);

                    BilgilendirmeCollection CollHa = new BilgilendirmeCollection();
                    IPredicateExpression ExpHa = new PredicateExpression();
                    ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeGelenKullanici == "SİSTEM");
                    ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeGidenKullanici == CollKula[0].KullaniciAdSoyad);
                    ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeIcerik == CollBilBul[0].BildirimId + " kayıt numaralı bildirim için 'İNCELEME' işlemi maksimum süresini (" + CollBilTur[0].BildirimTuruIslemAlSure + ") aşmış bulunmaktasınız.");
                    ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeTarih >= DateTime.Today);
                    CollHa.GetMulti(ExpHa);

                    if (CollHa.Count == 0)
                    {
                        BilgilendirmeEntity EntMe = new BilgilendirmeEntity();
                        EntMe.BilgilendirmeGelenKullanici = "SİSTEM";
                        EntMe.BilgilendirmeGidenKullanici = CollKula[0].KullaniciAdSoyad;
                        EntMe.BilgilendirmeIcerik = CollBilBul[0].BildirimId + " kayıt numaralı bildirim için 'İNCELEME' işlemi maksimum süresini (" + CollBilTur[0].BildirimTuruIslemAlSure + ") aşmış bulunmaktasınız.";
                        EntMe.BilgilendirmeTarih = DateTime.Now;
                        EntMe.Save();
                    }
                }
            }
        }

        void inceleme_ek_sure_takip()
        {
            ListAtamaTypedList list1 = new ListAtamaTypedList();
            IPredicateExpression filter1 = new PredicateExpression();
            filter1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
            filter1.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciBittiMi == false);
            filter1.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            list1.Fill(0, null, true, filter1);

            for (int i = 0; i < list1.Count; i++)
            {
                BildirimTuruCollection CollBilTur = new BildirimTuruCollection();
                IPredicateExpression ExpBilTur = new PredicateExpression();
                ExpBilTur.AddWithAnd(BildirimTuruFields.BildirimTuruId == list1[i].FkBildirimTuruId);
                CollBilTur.GetMulti(ExpBilTur);

                Int64 saati = CollBilTur[0].BildirimTuruIslemAlSaatZaman;

                TimeSpan fark_bak1 = DateTime.Now - list1[i].BildirimAtamaKullaniciTarih;

                string duzle = (fark_bak1.TotalHours).ToString();

                double arasi = Convert.ToDouble(duzle);

                Int64 ana_fark = Convert.ToInt16(arasi);

                if (ana_fark > saati)
                {
                    KullaniciCollection CollKula = new KullaniciCollection();
                    IPredicateExpression ExpKula = new PredicateExpression();
                    ExpKula.AddWithAnd(KullaniciFields.KullaniciId == list1[i].FkKullaniciId_);
                    CollKula.GetMulti(ExpKula);

                    BildirimCollection CollBilBul = new BildirimCollection();
                    IPredicateExpression ExpBilBul = new PredicateExpression();
                    ExpBilBul.AddWithAnd(BildirimFields.BildirimId == list1[i].FkBildirimId);
                    CollBilBul.GetMulti(ExpBilBul);

                    BilgilendirmeCollection CollHa = new BilgilendirmeCollection();
                    IPredicateExpression ExpHa = new PredicateExpression();
                    ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeGelenKullanici == "SİSTEM");
                    ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeGidenKullanici == CollKula[0].KullaniciAdSoyad);
                    ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeIcerik == CollBilBul[0].BildirimId + " kayıt numaralı bildirim için 'İNCELEME EK SÜRESİ' maksimum süresini (" + CollBilTur[0].BildirimTuruIslemAlSure + ") aşmış bulunmaktasınız.");
                    ExpHa.AddWithAnd(BilgilendirmeFields.BilgilendirmeTarih >= DateTime.Today);
                    CollHa.GetMulti(ExpHa);

                    if (CollHa.Count == 0)
                    {
                        BilgilendirmeEntity EntMe = new BilgilendirmeEntity();
                        EntMe.BilgilendirmeGelenKullanici = "SİSTEM";
                        EntMe.BilgilendirmeGidenKullanici = CollKula[0].KullaniciAdSoyad;
                        EntMe.BilgilendirmeIcerik = CollBilBul[0].BildirimId + " kayıt numaralı bildirim için 'İNCELEME EK SÜRESİ' maksimum süresini (" + CollBilTur[0].BildirimTuruIslemAlSure + ") aşmış bulunmaktasınız.";
                        EntMe.BilgilendirmeTarih = DateTime.Now;
                        EntMe.Save();
                    }
                }
            }
        }
    }
}