namespace Dhmi.Web
{
    using System;
    using System.Web.UI;
    using SD.LLBLGen.Pro.ORMSupportClasses;
    using dhmi.CollectionClasses;
    using dhmi.HelperClasses;
    using System.Web;

    public partial class YonFabrikaAyarlari : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["menu_sec"] = "Yönetici İşlemleri";

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
        }

        protected void btn_fabrika_don_Click(object sender, EventArgs e)
        {
            comp_sil();
        }

        void comp_sil()
        {
            BilgiBankasiCollection CollBan = new BilgiBankasiCollection();
            CollBan.DeleteMulti(null);

            BilgiBankasiTurCollection CollBag = new BilgiBankasiTurCollection();
            CollBag.DeleteMulti(null);

            BilgilendirmeCollection CollGer = new BilgilendirmeCollection();
            CollGer.DeleteMulti(null);

            BildirimAtamaGrupCollection CollGru = new BildirimAtamaGrupCollection();
            CollGru.DeleteMulti(null);

            BildirimAtamaKullaniciCollection CollKr = new BildirimAtamaKullaniciCollection();
            CollKr.DeleteMulti(null);

            BildirimHistoryCollection CollHis = new BildirimHistoryCollection();
            CollHis.DeleteMulti(null);

            DuyuruCollection CollDuy = new DuyuruCollection();
            CollDuy.DeleteMulti(null);

            EkSureCollection CollEk = new EkSureCollection();
            CollEk.DeleteMulti(null);

            GecenSureCollection CollSur = new GecenSureCollection();
            CollSur.DeleteMulti(null);

            GrupAtamaCollection CollFad = new GrupAtamaCollection();
            CollFad.DeleteMulti(null);

            GrupCollection CollAta = new GrupCollection();
            CollAta.DeleteMulti(null);

            IpBankCollection CollBank = new IpBankCollection();
            CollBank.DeleteMulti(null);

            IstatistikCollection CollIs = new IstatistikCollection();
            CollIs.DeleteMulti(null);

            KaraListeCollection CollKara = new KaraListeCollection();
            CollKara.DeleteMulti(null);

            KpsArsivCollection CollArs = new KpsArsivCollection();
            CollArs.DeleteMulti(null);

            KpsBilgiCollection CollBil = new KpsBilgiCollection();
            CollBil.DeleteMulti(null);

            KulTcNoCollection CollTc = new KulTcNoCollection();
            CollTc.DeleteMulti(null);

            LogCollection CollLog = new LogCollection();
            CollLog.DeleteMulti(null);

            MesajCollection CollMes = new MesajCollection();
            CollMes.DeleteMulti(null);

            SorunCollection CollSor = new SorunCollection();
            CollSor.DeleteMulti(null);

            SureTakipCollection CollTak = new SureTakipCollection();
            CollTak.DeleteMulti(null);

            VatandasArsivCollection CollDas = new VatandasArsivCollection();
            CollDas.DeleteMulti(null);

            VipListeCollection CollVip = new VipListeCollection();
            CollVip.DeleteMulti(null);

            BildirimCollection CollBir = new BildirimCollection();
            CollBir.DeleteMulti(null);

            VatandaCollection CollVat = new VatandaCollection();
            CollVat.DeleteMulti(null);

            KullaniciCollection CollKap = new KullaniciCollection();
            IPredicateExpression ExpKap = new PredicateExpression();
            ExpKap.AddWithAnd(KullaniciFields.KullaniciUsername == "vip_admin");
            CollKap.GetMulti(ExpKap);

            ParametreGenelArsivCollection CollSs = new ParametreGenelArsivCollection();
            IPredicateExpression ExpSs = new PredicateExpression();
            ExpSs.AddWithAnd(ParametreGenelArsivFields.FkKullaniciId != CollKap[0].KullaniciId);
            CollSs.GetMulti(ExpSs);

            for (int i = 0; i < CollSs.Count; i++)
            {
                CollSs[i].Delete();
                CollSs[i].Save();
            }

            ParametreCollection CollPar = new ParametreCollection();
            IPredicateExpression ExpPar = new PredicateExpression();
            ExpPar.AddWithAnd(ParametreFields.FkKullaniciId != CollKap[0].KullaniciId);
            CollPar.GetMulti(ExpPar);

            for (int i = 0; i < CollPar.Count; i++)
            {
                CollPar[i].Delete();
                CollPar[i].Save();
            }

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId != CollKap[0].KullaniciId);
            CollKul.GetMulti(ExpKul);

            for (int i = 0; i < CollKul.Count; i++)
            {
                CollKul[i].Delete();
                CollKul[i].Save();
            }

            string CloseWindow;
            CloseWindow = "alert('Sistem, fabrika ayarlarına döndürülmüştür...')";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
        }
    }
}