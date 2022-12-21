using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using dhmi.EntityClasses;
using dhmi.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.HelperClasses;
using DevExpress.Web.ASPxMenu;

namespace Dhmi.Web
{
    public partial class CkbAcikCagriIslemleri : System.Web.UI.Page
    {
        public KullaniciEntity AktifKullanici
        {
            get
            {
                if (Session["kullanici_var_mi"] == null)
                {
                    Response.Redirect("Account/Login.aspx");
                    return null;
                }
                else
                {
                    if (ViewState["AktifKullanici"] == null)
                    {
                        ViewState["AktifKullanici"] = new KullaniciEntity(Convert.ToInt16(Session["kullanici_var_mi"]));
                    }

                    return (KullaniciEntity)ViewState["AktifKullanici"];
                }
            }

            set
            {
                ViewState["AktifKullanici"] = new KullaniciEntity(Convert.ToInt16(Session["kullanici_var_mi"]));
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["menu_sec"] = "Çağrı İşlemleri";

            if (Session["kullanici_rastgele"] == null)
            {
                Response.Redirect("Account/Login.aspx");
            }

            HttpCookie cookie = Request.Cookies["userC"];
            HttpCookie cookieYetki = Request.Cookies["aJ4lOu784TyfdEsd4FIoi"];
            if (cookie != null && cookieYetki != null)
            {
                string yetki = Helper.Decrypt(cookieYetki.Value);
                if (yetki == "Admin" || yetki == "Takım Lideri" || yetki == "Kurum Makam")
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

            if (IsPostBack != true)
            {
                ParametreCollection CollParam = new ParametreCollection();
                IPredicateExpression ExpParam = new PredicateExpression();
                ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
                ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollParam.GetMulti(ExpParam);
                
                grid_ayrinti.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
                grid_genel.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

                KullaniciCollection CollKul = new KullaniciCollection();
                IPredicateExpression ExpKul = new PredicateExpression();
                ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollKul.GetMulti(ExpKul);

                MenuCollection CollMenu = new MenuCollection();
                IPredicateExpression ExpMenu = new PredicateExpression();
                ExpMenu.AddWithAnd(MenuFields.MenuAd == "Çağrı İşlemleri");
                CollMenu.GetMulti(ExpMenu);

                AltMenuCollection CollAlt1 = new AltMenuCollection();
                IPredicateExpression ExpAlt1 = new PredicateExpression();
                ExpAlt1.AddWithAnd(AltMenuFields.AltMenuAd == "Çağrı Kayıt Bilgileri");
                CollAlt1.GetMulti(ExpAlt1);

                AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                IPredicateExpression ExpAlt2 = new PredicateExpression();
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Açık Çağrı İşlemleri");
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
                        IslemCollection CollIslem = new IslemCollection();
                        IPredicateExpression ExpIslem = new PredicateExpression();
                        ExpIslem.AddWithAnd(IslemFields.IslemId == CollIs[d].IslemId);
                        CollIslem.GetMulti(ExpIslem);

                        Menu1.Items.Add(CollIslem[0].IslemAd);
                    }

                    else
                    {

                    }
                }

                string hexValue2 = "#C0D9E7";
                Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);

                AcikBildirimCollection CollAcik = new AcikBildirimCollection();
                CollAcik.GetMulti(null);

                for (int i = 0; i < CollAcik.Count; i++) 
                {
                    CollAcik[i].Delete();
                    CollAcik[i].Save();
                }

                AcikBildirimAyrintiCollection CollAyr = new AcikBildirimAyrintiCollection();
                CollAyr.GetMulti(null);

                for (int i = 0; i < CollAyr.Count; i++) 
                {
                    CollAyr[i].Delete();
                    CollAyr[i].Save();
                }

                Int16 atandi = 0;
                Int16 incele = 0;
                Int16 incele_ek = 0;

                BildirimSonucCollection CollSon1 = new BildirimSonucCollection();
                IPredicateExpression ExpSon1 = new PredicateExpression();
                ExpSon1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                CollSon1.GetMulti(ExpSon1);

                BildirimSonucCollection CollSon2 = new BildirimSonucCollection();
                IPredicateExpression ExpSon2 = new PredicateExpression();
                ExpSon2.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
                CollSon2.GetMulti(ExpSon2);

                BildirimSonucCollection CollSon3 = new BildirimSonucCollection();
                IPredicateExpression ExpSon3 = new PredicateExpression();
                ExpSon3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
                CollSon3.GetMulti(ExpSon3);

                BildirimCollection CollBil1 = new BildirimCollection();
                IPredicateExpression ExpBil1 = new PredicateExpression();
                ExpBil1.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon1[0].BildirimSonucId);
                CollBil1.GetMulti(ExpBil1);

                for (int i = 0; i < CollBil1.Count; i++) 
                {
                    BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                    IPredicateExpression ExpGr = new PredicateExpression();                    
                    ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil1[i].BildirimId);
                    ISortExpression sortgr = new SortExpression();                    
                    sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                    CollGr.GetMulti(ExpGr, 0, sortgr);

                    GrupCollection CollNe = new GrupCollection();
                    IPredicateExpression ExpNe = new PredicateExpression();
                    ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                    CollNe.GetMulti(ExpNe);

                    AcikBildirimCollection CollVar = new AcikBildirimCollection();
                    IPredicateExpression ExpVar = new PredicateExpression();
                    ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                    CollVar.GetMulti(ExpVar);

                    if (CollVar.Count == 0)
                    {
                        AcikBildirimEntity EntKay = new AcikBildirimEntity();
                        EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                        EntKay.AcikBildirimAtandiSayi = 1;
                        EntKay.AcikBildirimInceleniyorSayi = 0;
                        EntKay.AcikBildirimInceleniyorEkSureSayi = 0;
                        EntKay.Save();
                    }

                    else
                    {
                        CollVar[0].AcikBildirimAtandiSayi = Convert.ToInt16(CollVar[0].AcikBildirimAtandiSayi + 1);
                        CollVar[0].Save();
                    }

                    atandi = Convert.ToInt16(atandi + 1);

                    AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                    EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                    EntKay2.AcikBildirimAyrintiDurum = "Atandı";
                    EntKay2.AcikBildirimAyrintiIcerik = CollBil1[i].BildirimMetin;
                    EntKay2.AcikBildirimAyrintiNo = CollBil1[i].BildirimId;
                    EntKay2.AcikBildirimAyrintiSonDurum = CollBil1[i].BildirimAtanmaDurumu;
                    EntKay2.AcikBildirimAyrintiSure = CollBil1[i].BildirimToplamSure;
                    EntKay2.Save();                    
                }

                BildirimCollection CollBil2 = new BildirimCollection();
                IPredicateExpression ExpBil2 = new PredicateExpression();
                ExpBil2.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon2[0].BildirimSonucId);
                CollBil2.GetMulti(ExpBil2);

                for (int i = 0; i < CollBil2.Count; i++)
                {
                    BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                    IPredicateExpression ExpGr = new PredicateExpression();
                    ISortExpression sortgr = new SortExpression();
                    sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                    ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil2[i].BildirimId);
                    CollGr.GetMulti(ExpGr, 0, sortgr);

                    GrupCollection CollNe = new GrupCollection();
                    IPredicateExpression ExpNe = new PredicateExpression();
                    ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                    CollNe.GetMulti(ExpNe);

                    AcikBildirimCollection CollVar = new AcikBildirimCollection();
                    IPredicateExpression ExpVar = new PredicateExpression();
                    ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                    CollVar.GetMulti(ExpVar);

                    if (CollVar.Count == 0)
                    {
                        AcikBildirimEntity EntKay = new AcikBildirimEntity();
                        EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                        EntKay.AcikBildirimAtandiSayi = 0;
                        EntKay.AcikBildirimInceleniyorSayi = 1;
                        EntKay.AcikBildirimInceleniyorEkSureSayi = 0;
                        EntKay.Save();
                    }

                    else
                    {
                        CollVar[0].AcikBildirimInceleniyorSayi = Convert.ToInt16(CollVar[0].AcikBildirimInceleniyorSayi + 1);
                        CollVar[0].Save();
                    }

                    incele = Convert.ToInt16(incele + 1);

                    AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                    EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                    EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor";
                    EntKay2.AcikBildirimAyrintiIcerik = CollBil2[i].BildirimMetin;
                    EntKay2.AcikBildirimAyrintiNo = CollBil2[i].BildirimId;
                    EntKay2.AcikBildirimAyrintiSonDurum = CollBil2[i].BildirimAtanmaDurumu;
                    EntKay2.AcikBildirimAyrintiSure = CollBil2[i].BildirimToplamSure;
                    EntKay2.Save();
                }

                BildirimCollection CollBil3 = new BildirimCollection();
                IPredicateExpression ExpBil3 = new PredicateExpression();
                ExpBil3.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon3[0].BildirimSonucId);
                CollBil3.GetMulti(ExpBil3);

                for (int i = 0; i < CollBil3.Count; i++)
                {
                    BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                    IPredicateExpression ExpGr = new PredicateExpression();
                    ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil3[i].BildirimId);
                    ISortExpression sortgr = new SortExpression();
                    sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                    CollGr.GetMulti(ExpGr, 0, sortgr);

                    GrupCollection CollNe = new GrupCollection();
                    IPredicateExpression ExpNe = new PredicateExpression();
                    ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                    CollNe.GetMulti(ExpNe);

                    AcikBildirimCollection CollVar = new AcikBildirimCollection();
                    IPredicateExpression ExpVar = new PredicateExpression();
                    ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                    CollVar.GetMulti(ExpVar);

                    if (CollVar.Count == 0)
                    {
                        AcikBildirimEntity EntKay = new AcikBildirimEntity();
                        EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                        EntKay.AcikBildirimAtandiSayi = 0;
                        EntKay.AcikBildirimInceleniyorSayi = 0;
                        EntKay.AcikBildirimInceleniyorEkSureSayi = 1;
                        EntKay.Save();
                    }

                    else
                    {
                        CollVar[0].AcikBildirimInceleniyorEkSureSayi = Convert.ToInt16(CollVar[0].AcikBildirimInceleniyorEkSureSayi + 1);
                        CollVar[0].Save();
                    }

                    incele_ek = Convert.ToInt16(incele_ek + 1);

                    AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                    EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                    EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor- Ek Süre";
                    EntKay2.AcikBildirimAyrintiIcerik = CollBil3[i].BildirimMetin;
                    EntKay2.AcikBildirimAyrintiNo = CollBil3[i].BildirimId;
                    EntKay2.AcikBildirimAyrintiSonDurum = CollBil3[i].BildirimAtanmaDurumu;
                    EntKay2.AcikBildirimAyrintiSure = CollBil3[i].BildirimToplamSure;
                    EntKay2.Save();
                }

                AcikBildirimEntity EntSon = new AcikBildirimEntity();
                EntSon.AcikBildirimBirim = "TOPLAM";
                EntSon.AcikBildirimAtandiSayi = atandi;
                EntSon.AcikBildirimInceleniyorSayi = incele;
                EntSon.AcikBildirimInceleniyorEkSureSayi = incele_ek;
                EntSon.Save();

                AcikBildirimCollection CollD1 = new AcikBildirimCollection();
                CollD1.GetMulti(null);

                AcikBildirimAyrintiCollection CollD2 = new AcikBildirimAyrintiCollection();
                CollD2.GetMulti(null);

                grid_genel.DataSource = CollD1;
                grid_genel.DataBind();

                grid_ayrinti.DataSource = CollD2;
                grid_ayrinti.DataBind();
            }
        }

        protected void Menu1_MenuItemClick(object sender, MenuItemEventArgs e)
        {
            int index = 0;

            string hexValue = "#FFFFFF";
            string hexValue2 = "#C0D9E7";

            if (e.Item.ToString() == "Genel Durum")
            {
                index = 0;

                foreach (MenuItem item in Menu1.Items)
                {
                    item.ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                }

                Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);

                AcikBildirimCollection CollAcik = new AcikBildirimCollection();
                CollAcik.GetMulti(null);

                for (int i = 0; i < CollAcik.Count; i++)
                {
                    CollAcik[i].Delete();
                    CollAcik[i].Save();
                }

                Int16 atandi = 0;
                Int16 incele = 0;
                Int16 incele_ek = 0;

                BildirimSonucCollection CollSon1 = new BildirimSonucCollection();
                IPredicateExpression ExpSon1 = new PredicateExpression();
                ExpSon1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                CollSon1.GetMulti(ExpSon1);

                BildirimSonucCollection CollSon2 = new BildirimSonucCollection();
                IPredicateExpression ExpSon2 = new PredicateExpression();
                ExpSon2.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
                CollSon2.GetMulti(ExpSon2);

                BildirimSonucCollection CollSon3 = new BildirimSonucCollection();
                IPredicateExpression ExpSon3 = new PredicateExpression();
                ExpSon3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
                CollSon3.GetMulti(ExpSon3);

                BildirimCollection CollBil1 = new BildirimCollection();
                IPredicateExpression ExpBil1 = new PredicateExpression();
                ExpBil1.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon1[0].BildirimSonucId);
                CollBil1.GetMulti(ExpBil1);

                for (int i = 0; i < CollBil1.Count; i++)
                {
                    BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                    IPredicateExpression ExpGr = new PredicateExpression();
                    ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil1[i].BildirimId);
                    ISortExpression sortgr = new SortExpression();
                    sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                    CollGr.GetMulti(ExpGr, 0, sortgr);

                    GrupCollection CollNe = new GrupCollection();
                    IPredicateExpression ExpNe = new PredicateExpression();
                    ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                    CollNe.GetMulti(ExpNe);

                    AcikBildirimCollection CollVar = new AcikBildirimCollection();
                    IPredicateExpression ExpVar = new PredicateExpression();
                    ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                    CollVar.GetMulti(ExpVar);

                    if (CollVar.Count == 0)
                    {
                        AcikBildirimEntity EntKay = new AcikBildirimEntity();
                        EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                        EntKay.AcikBildirimAtandiSayi = 1;
                        EntKay.AcikBildirimInceleniyorSayi = 0;
                        EntKay.AcikBildirimInceleniyorEkSureSayi = 0;
                        EntKay.Save();
                    }

                    else
                    {
                        CollVar[0].AcikBildirimAtandiSayi = Convert.ToInt16(CollVar[0].AcikBildirimAtandiSayi + 1);
                        CollVar[0].Save();
                    }

                    atandi = Convert.ToInt16(atandi + 1);

                    AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                    EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                    EntKay2.AcikBildirimAyrintiDurum = "Atandı";
                    EntKay2.AcikBildirimAyrintiIcerik = CollBil1[i].BildirimMetin;
                    EntKay2.AcikBildirimAyrintiNo = CollBil1[i].BildirimId;
                    EntKay2.AcikBildirimAyrintiSonDurum = CollBil1[i].BildirimAtanmaDurumu;
                    EntKay2.AcikBildirimAyrintiSure = CollBil1[i].BildirimToplamSure;
                    EntKay2.Save();
                }

                BildirimCollection CollBil2 = new BildirimCollection();
                IPredicateExpression ExpBil2 = new PredicateExpression();
                ExpBil2.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon2[0].BildirimSonucId);
                CollBil2.GetMulti(ExpBil2);

                for (int i = 0; i < CollBil2.Count; i++)
                {
                    BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                    IPredicateExpression ExpGr = new PredicateExpression();
                    ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil2[i].BildirimId);
                    ISortExpression sortgr = new SortExpression();
                    sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                    CollGr.GetMulti(ExpGr, 0, sortgr);

                    GrupCollection CollNe = new GrupCollection();
                    IPredicateExpression ExpNe = new PredicateExpression();
                    ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                    CollNe.GetMulti(ExpNe);

                    AcikBildirimCollection CollVar = new AcikBildirimCollection();
                    IPredicateExpression ExpVar = new PredicateExpression();
                    ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                    CollVar.GetMulti(ExpVar);

                    if (CollVar.Count == 0)
                    {
                        AcikBildirimEntity EntKay = new AcikBildirimEntity();
                        EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                        EntKay.AcikBildirimAtandiSayi = 0;
                        EntKay.AcikBildirimInceleniyorSayi = 1;
                        EntKay.AcikBildirimInceleniyorEkSureSayi = 0;
                        EntKay.Save();
                    }

                    else
                    {
                        CollVar[0].AcikBildirimInceleniyorSayi = Convert.ToInt16(CollVar[0].AcikBildirimInceleniyorSayi + 1);
                        CollVar[0].Save();
                    }

                    incele = Convert.ToInt16(incele + 1);

                    AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                    EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                    EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor";
                    EntKay2.AcikBildirimAyrintiIcerik = CollBil2[i].BildirimMetin;
                    EntKay2.AcikBildirimAyrintiNo = CollBil2[i].BildirimId;
                    EntKay2.AcikBildirimAyrintiSonDurum = CollBil2[i].BildirimAtanmaDurumu;
                    EntKay2.AcikBildirimAyrintiSure = CollBil2[i].BildirimToplamSure;
                    EntKay2.Save();
                }

                BildirimCollection CollBil3 = new BildirimCollection();
                IPredicateExpression ExpBil3 = new PredicateExpression();
                ExpBil3.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon3[0].BildirimSonucId);
                CollBil3.GetMulti(ExpBil3);

                for (int i = 0; i < CollBil3.Count; i++)
                {
                    BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                    IPredicateExpression ExpGr = new PredicateExpression();
                    ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil3[i].BildirimId);
                    ISortExpression sortgr = new SortExpression();
                    sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                    CollGr.GetMulti(ExpGr, 0, sortgr);

                    GrupCollection CollNe = new GrupCollection();
                    IPredicateExpression ExpNe = new PredicateExpression();
                    ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                    CollNe.GetMulti(ExpNe);

                    AcikBildirimCollection CollVar = new AcikBildirimCollection();
                    IPredicateExpression ExpVar = new PredicateExpression();
                    ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                    CollVar.GetMulti(ExpVar);

                    if (CollVar.Count == 0)
                    {
                        AcikBildirimEntity EntKay = new AcikBildirimEntity();
                        EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                        EntKay.AcikBildirimAtandiSayi = 0;
                        EntKay.AcikBildirimInceleniyorSayi = 0;
                        EntKay.AcikBildirimInceleniyorEkSureSayi = 1;
                        EntKay.Save();
                    }

                    else
                    {
                        CollVar[0].AcikBildirimInceleniyorEkSureSayi = Convert.ToInt16(CollVar[0].AcikBildirimInceleniyorEkSureSayi + 1);
                        CollVar[0].Save();
                    }

                    incele_ek = Convert.ToInt16(incele_ek + 1);

                    AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                    EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                    EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor- Ek Süre";
                    EntKay2.AcikBildirimAyrintiIcerik = CollBil3[i].BildirimMetin;
                    EntKay2.AcikBildirimAyrintiNo = CollBil3[i].BildirimId;
                    EntKay2.AcikBildirimAyrintiSonDurum = CollBil3[i].BildirimAtanmaDurumu;
                    EntKay2.AcikBildirimAyrintiSure = CollBil3[i].BildirimToplamSure;
                    EntKay2.Save();
                }

                AcikBildirimEntity EntSon = new AcikBildirimEntity();
                EntSon.AcikBildirimBirim = "TOPLAM";
                EntSon.AcikBildirimAtandiSayi = atandi;
                EntSon.AcikBildirimInceleniyorSayi = incele;
                EntSon.AcikBildirimInceleniyorEkSureSayi = incele_ek;
                EntSon.Save();

                AcikBildirimCollection CollD1 = new AcikBildirimCollection();
                CollD1.GetMulti(null);               

                grid_genel.DataSource = CollD1;
                grid_genel.DataBind();                
            }

            else if (e.Item.ToString() == "Ayrıntılar")
            {
                index = 1;

                foreach (MenuItem item in Menu1.Items)
                {
                    item.ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                }

                Menu1.Items[1].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
              
                AcikBildirimAyrintiCollection CollAyr = new AcikBildirimAyrintiCollection();
                CollAyr.GetMulti(null);

                for (int i = 0; i < CollAyr.Count; i++)
                {
                    CollAyr[i].Delete();
                    CollAyr[i].Save();
                }

                BildirimSonucCollection CollSon1 = new BildirimSonucCollection();
                IPredicateExpression ExpSon1 = new PredicateExpression();
                ExpSon1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                CollSon1.GetMulti(ExpSon1);

                BildirimSonucCollection CollSon2 = new BildirimSonucCollection();
                IPredicateExpression ExpSon2 = new PredicateExpression();
                ExpSon2.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
                CollSon2.GetMulti(ExpSon2);

                BildirimSonucCollection CollSon3 = new BildirimSonucCollection();
                IPredicateExpression ExpSon3 = new PredicateExpression();
                ExpSon3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
                CollSon3.GetMulti(ExpSon3);

                BildirimCollection CollBil1 = new BildirimCollection();
                IPredicateExpression ExpBil1 = new PredicateExpression();
                ExpBil1.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon1[0].BildirimSonucId);
                CollBil1.GetMulti(ExpBil1);

                for (int i = 0; i < CollBil1.Count; i++)
                {
                    BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                    IPredicateExpression ExpGr = new PredicateExpression();
                    ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil1[i].BildirimId);
                    ISortExpression sortgr = new SortExpression();
                    sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                    CollGr.GetMulti(ExpGr, 0, sortgr);

                    GrupCollection CollNe = new GrupCollection();
                    IPredicateExpression ExpNe = new PredicateExpression();
                    ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                    CollNe.GetMulti(ExpNe);

                    AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                    EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                    EntKay2.AcikBildirimAyrintiDurum = "Atandı";
                    EntKay2.AcikBildirimAyrintiIcerik = CollBil1[i].BildirimMetin;
                    EntKay2.AcikBildirimAyrintiNo = CollBil1[i].BildirimId;
                    EntKay2.AcikBildirimAyrintiSonDurum = CollBil1[i].BildirimAtanmaDurumu;
                    EntKay2.AcikBildirimAyrintiSure = CollBil1[i].BildirimToplamSure;
                    EntKay2.Save();
                }

                BildirimCollection CollBil2 = new BildirimCollection();
                IPredicateExpression ExpBil2 = new PredicateExpression();
                ExpBil2.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon2[0].BildirimSonucId);
                CollBil2.GetMulti(ExpBil2);

                for (int i = 0; i < CollBil2.Count; i++)
                {
                    BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                    IPredicateExpression ExpGr = new PredicateExpression();
                    ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil2[i].BildirimId);
                    ISortExpression sortgr = new SortExpression();
                    sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                    CollGr.GetMulti(ExpGr, 0, sortgr);

                    GrupCollection CollNe = new GrupCollection();
                    IPredicateExpression ExpNe = new PredicateExpression();
                    ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                    CollNe.GetMulti(ExpNe);

                    AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                    EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                    EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor";
                    EntKay2.AcikBildirimAyrintiIcerik = CollBil2[i].BildirimMetin;
                    EntKay2.AcikBildirimAyrintiNo = CollBil2[i].BildirimId;
                    EntKay2.AcikBildirimAyrintiSonDurum = CollBil2[i].BildirimAtanmaDurumu;
                    EntKay2.AcikBildirimAyrintiSure = CollBil2[i].BildirimToplamSure;
                    EntKay2.Save();
                }

                BildirimCollection CollBil3 = new BildirimCollection();
                IPredicateExpression ExpBil3 = new PredicateExpression();
                ExpBil3.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon3[0].BildirimSonucId);
                CollBil3.GetMulti(ExpBil3);

                for (int i = 0; i < CollBil3.Count; i++)
                {
                    BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                    IPredicateExpression ExpGr = new PredicateExpression();
                    ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil3[i].BildirimId);
                    ISortExpression sortgr = new SortExpression();
                    sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                    CollGr.GetMulti(ExpGr, 0, sortgr);

                    GrupCollection CollNe = new GrupCollection();
                    IPredicateExpression ExpNe = new PredicateExpression();
                    ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                    CollNe.GetMulti(ExpNe);

                    AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                    EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                    EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor- Ek Süre";
                    EntKay2.AcikBildirimAyrintiIcerik = CollBil3[i].BildirimMetin;
                    EntKay2.AcikBildirimAyrintiNo = CollBil3[i].BildirimId;
                    EntKay2.AcikBildirimAyrintiSonDurum = CollBil3[i].BildirimAtanmaDurumu;
                    EntKay2.AcikBildirimAyrintiSure = CollBil3[i].BildirimToplamSure;
                    EntKay2.Save();
                }        

                AcikBildirimAyrintiCollection CollD2 = new AcikBildirimAyrintiCollection();
                CollD2.GetMulti(null);

                grid_ayrinti.DataSource = CollD2;
                grid_ayrinti.DataBind();
            }

            MultiView1.ActiveViewIndex = index;
        }

        protected void btnPdfExport_Click(object sender, EventArgs e)
        {
            Session["rapor_adi"] = "Açık Çağrı Bilgileri";

            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McAraRapor.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void btnPdfExportayr_Click(object sender, EventArgs e)
        {
            Session["rapor_adi"] = "Açık Çağrı Bilgileri Ayrıntılı";

            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McAraRapor.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void grid_genel_PageSizeChanged(object sender, EventArgs e)
        {
            AcikBildirimCollection CollAcik = new AcikBildirimCollection();
            CollAcik.GetMulti(null);

            for (int i = 0; i < CollAcik.Count; i++)
            {
                CollAcik[i].Delete();
                CollAcik[i].Save();
            }

            Int16 atandi = 0;
            Int16 incele = 0;
            Int16 incele_ek = 0;

            BildirimSonucCollection CollSon1 = new BildirimSonucCollection();
            IPredicateExpression ExpSon1 = new PredicateExpression();
            ExpSon1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
            CollSon1.GetMulti(ExpSon1);

            BildirimSonucCollection CollSon2 = new BildirimSonucCollection();
            IPredicateExpression ExpSon2 = new PredicateExpression();
            ExpSon2.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
            CollSon2.GetMulti(ExpSon2);

            BildirimSonucCollection CollSon3 = new BildirimSonucCollection();
            IPredicateExpression ExpSon3 = new PredicateExpression();
            ExpSon3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
            CollSon3.GetMulti(ExpSon3);

            BildirimCollection CollBil1 = new BildirimCollection();
            IPredicateExpression ExpBil1 = new PredicateExpression();
            ExpBil1.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon1[0].BildirimSonucId);
            CollBil1.GetMulti(ExpBil1);

            for (int i = 0; i < CollBil1.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil1[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimCollection CollVar = new AcikBildirimCollection();
                IPredicateExpression ExpVar = new PredicateExpression();
                ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                CollVar.GetMulti(ExpVar);

                if (CollVar.Count == 0)
                {
                    AcikBildirimEntity EntKay = new AcikBildirimEntity();
                    EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                    EntKay.AcikBildirimAtandiSayi = 1;
                    EntKay.AcikBildirimInceleniyorSayi = 0;
                    EntKay.AcikBildirimInceleniyorEkSureSayi = 0;
                    EntKay.Save();
                }

                else
                {
                    CollVar[0].AcikBildirimAtandiSayi = Convert.ToInt16(CollVar[0].AcikBildirimAtandiSayi + 1);
                    CollVar[0].Save();
                }

                atandi = Convert.ToInt16(atandi + 1);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "Atandı";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil1[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil1[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil1[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil1[i].BildirimToplamSure;
                EntKay2.Save();
            }

            BildirimCollection CollBil2 = new BildirimCollection();
            IPredicateExpression ExpBil2 = new PredicateExpression();
            ExpBil2.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon2[0].BildirimSonucId);
            CollBil2.GetMulti(ExpBil2);

            for (int i = 0; i < CollBil2.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil2[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimCollection CollVar = new AcikBildirimCollection();
                IPredicateExpression ExpVar = new PredicateExpression();
                ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                CollVar.GetMulti(ExpVar);

                if (CollVar.Count == 0)
                {
                    AcikBildirimEntity EntKay = new AcikBildirimEntity();
                    EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                    EntKay.AcikBildirimAtandiSayi = 0;
                    EntKay.AcikBildirimInceleniyorSayi = 1;
                    EntKay.AcikBildirimInceleniyorEkSureSayi = 0;
                    EntKay.Save();
                }

                else
                {
                    CollVar[0].AcikBildirimInceleniyorSayi = Convert.ToInt16(CollVar[0].AcikBildirimInceleniyorSayi + 1);
                    CollVar[0].Save();
                }

                incele = Convert.ToInt16(incele + 1);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil2[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil2[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil2[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil2[i].BildirimToplamSure;
                EntKay2.Save();
            }

            BildirimCollection CollBil3 = new BildirimCollection();
            IPredicateExpression ExpBil3 = new PredicateExpression();
            ExpBil3.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon3[0].BildirimSonucId);
            CollBil3.GetMulti(ExpBil3);

            for (int i = 0; i < CollBil3.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil3[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimCollection CollVar = new AcikBildirimCollection();
                IPredicateExpression ExpVar = new PredicateExpression();
                ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                CollVar.GetMulti(ExpVar);

                if (CollVar.Count == 0)
                {
                    AcikBildirimEntity EntKay = new AcikBildirimEntity();
                    EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                    EntKay.AcikBildirimAtandiSayi = 0;
                    EntKay.AcikBildirimInceleniyorSayi = 0;
                    EntKay.AcikBildirimInceleniyorEkSureSayi = 1;
                    EntKay.Save();
                }

                else
                {
                    CollVar[0].AcikBildirimInceleniyorEkSureSayi = Convert.ToInt16(CollVar[0].AcikBildirimInceleniyorEkSureSayi + 1);
                    CollVar[0].Save();
                }

                incele_ek = Convert.ToInt16(incele_ek + 1);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor- Ek Süre";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil3[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil3[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil3[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil3[i].BildirimToplamSure;
                EntKay2.Save();
            }

            AcikBildirimEntity EntSon = new AcikBildirimEntity();
            EntSon.AcikBildirimBirim = "TOPLAM";
            EntSon.AcikBildirimAtandiSayi = atandi;
            EntSon.AcikBildirimInceleniyorSayi = incele;
            EntSon.AcikBildirimInceleniyorEkSureSayi = incele_ek;
            EntSon.Save();

            AcikBildirimCollection CollD1 = new AcikBildirimCollection();
            CollD1.GetMulti(null);

            grid_genel.DataSource = CollD1;
            grid_genel.DataBind(); 

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_genel.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_genel_ProcessColumnAutoFilter(object sender, EventArgs e)
        {
            AcikBildirimCollection CollAcik = new AcikBildirimCollection();
            CollAcik.GetMulti(null);

            for (int i = 0; i < CollAcik.Count; i++)
            {
                CollAcik[i].Delete();
                CollAcik[i].Save();
            }

            Int16 atandi = 0;
            Int16 incele = 0;
            Int16 incele_ek = 0;

            BildirimSonucCollection CollSon1 = new BildirimSonucCollection();
            IPredicateExpression ExpSon1 = new PredicateExpression();
            ExpSon1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
            CollSon1.GetMulti(ExpSon1);

            BildirimSonucCollection CollSon2 = new BildirimSonucCollection();
            IPredicateExpression ExpSon2 = new PredicateExpression();
            ExpSon2.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
            CollSon2.GetMulti(ExpSon2);

            BildirimSonucCollection CollSon3 = new BildirimSonucCollection();
            IPredicateExpression ExpSon3 = new PredicateExpression();
            ExpSon3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
            CollSon3.GetMulti(ExpSon3);

            BildirimCollection CollBil1 = new BildirimCollection();
            IPredicateExpression ExpBil1 = new PredicateExpression();
            ExpBil1.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon1[0].BildirimSonucId);
            CollBil1.GetMulti(ExpBil1);

            for (int i = 0; i < CollBil1.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil1[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimCollection CollVar = new AcikBildirimCollection();
                IPredicateExpression ExpVar = new PredicateExpression();
                ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                CollVar.GetMulti(ExpVar);

                if (CollVar.Count == 0)
                {
                    AcikBildirimEntity EntKay = new AcikBildirimEntity();
                    EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                    EntKay.AcikBildirimAtandiSayi = 1;
                    EntKay.AcikBildirimInceleniyorSayi = 0;
                    EntKay.AcikBildirimInceleniyorEkSureSayi = 0;
                    EntKay.Save();
                }

                else
                {
                    CollVar[0].AcikBildirimAtandiSayi = Convert.ToInt16(CollVar[0].AcikBildirimAtandiSayi + 1);
                    CollVar[0].Save();
                }

                atandi = Convert.ToInt16(atandi + 1);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "Atandı";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil1[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil1[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil1[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil1[i].BildirimToplamSure;
                EntKay2.Save();
            }

            BildirimCollection CollBil2 = new BildirimCollection();
            IPredicateExpression ExpBil2 = new PredicateExpression();
            ExpBil2.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon2[0].BildirimSonucId);
            CollBil2.GetMulti(ExpBil2);

            for (int i = 0; i < CollBil2.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil2[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimCollection CollVar = new AcikBildirimCollection();
                IPredicateExpression ExpVar = new PredicateExpression();
                ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                CollVar.GetMulti(ExpVar);

                if (CollVar.Count == 0)
                {
                    AcikBildirimEntity EntKay = new AcikBildirimEntity();
                    EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                    EntKay.AcikBildirimAtandiSayi = 0;
                    EntKay.AcikBildirimInceleniyorSayi = 1;
                    EntKay.AcikBildirimInceleniyorEkSureSayi = 0;
                    EntKay.Save();
                }

                else
                {
                    CollVar[0].AcikBildirimInceleniyorSayi = Convert.ToInt16(CollVar[0].AcikBildirimInceleniyorSayi + 1);
                    CollVar[0].Save();
                }

                incele = Convert.ToInt16(incele + 1);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil2[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil2[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil2[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil2[i].BildirimToplamSure;
                EntKay2.Save();
            }

            BildirimCollection CollBil3 = new BildirimCollection();
            IPredicateExpression ExpBil3 = new PredicateExpression();
            ExpBil3.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon3[0].BildirimSonucId);
            CollBil3.GetMulti(ExpBil3);

            for (int i = 0; i < CollBil3.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil3[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimCollection CollVar = new AcikBildirimCollection();
                IPredicateExpression ExpVar = new PredicateExpression();
                ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                CollVar.GetMulti(ExpVar);

                if (CollVar.Count == 0)
                {
                    AcikBildirimEntity EntKay = new AcikBildirimEntity();
                    EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                    EntKay.AcikBildirimAtandiSayi = 0;
                    EntKay.AcikBildirimInceleniyorSayi = 0;
                    EntKay.AcikBildirimInceleniyorEkSureSayi = 1;
                    EntKay.Save();
                }

                else
                {
                    CollVar[0].AcikBildirimInceleniyorEkSureSayi = Convert.ToInt16(CollVar[0].AcikBildirimInceleniyorEkSureSayi + 1);
                    CollVar[0].Save();
                }

                incele_ek = Convert.ToInt16(incele_ek + 1);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor- Ek Süre";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil3[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil3[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil3[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil3[i].BildirimToplamSure;
                EntKay2.Save();
            }

            AcikBildirimEntity EntSon = new AcikBildirimEntity();
            EntSon.AcikBildirimBirim = "TOPLAM";
            EntSon.AcikBildirimAtandiSayi = atandi;
            EntSon.AcikBildirimInceleniyorSayi = incele;
            EntSon.AcikBildirimInceleniyorEkSureSayi = incele_ek;
            EntSon.Save();

            AcikBildirimCollection CollD1 = new AcikBildirimCollection();
            CollD1.GetMulti(null);

            grid_genel.DataSource = CollD1;
            grid_genel.DataBind();
        }

        protected void grid_genel_CustomCollback(object sender, EventArgs e)
        {
            try
            {
                txtUserName.Text = grid_genel.GetSelectedFieldValues("AcikBildirimId")[0].ToString();

                grid_genel.Selection.UnselectAll();
            }

            catch
            {

            }
        }

        protected void grid_genel_PageIndexChanged(object sender, EventArgs e)
        {
            AcikBildirimCollection CollAcik = new AcikBildirimCollection();
            CollAcik.GetMulti(null);

            for (int i = 0; i < CollAcik.Count; i++)
            {
                CollAcik[i].Delete();
                CollAcik[i].Save();
            }

            Int16 atandi = 0;
            Int16 incele = 0;
            Int16 incele_ek = 0;

            BildirimSonucCollection CollSon1 = new BildirimSonucCollection();
            IPredicateExpression ExpSon1 = new PredicateExpression();
            ExpSon1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
            CollSon1.GetMulti(ExpSon1);

            BildirimSonucCollection CollSon2 = new BildirimSonucCollection();
            IPredicateExpression ExpSon2 = new PredicateExpression();
            ExpSon2.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
            CollSon2.GetMulti(ExpSon2);

            BildirimSonucCollection CollSon3 = new BildirimSonucCollection();
            IPredicateExpression ExpSon3 = new PredicateExpression();
            ExpSon3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
            CollSon3.GetMulti(ExpSon3);

            BildirimCollection CollBil1 = new BildirimCollection();
            IPredicateExpression ExpBil1 = new PredicateExpression();
            ExpBil1.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon1[0].BildirimSonucId);
            CollBil1.GetMulti(ExpBil1);

            for (int i = 0; i < CollBil1.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil1[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimCollection CollVar = new AcikBildirimCollection();
                IPredicateExpression ExpVar = new PredicateExpression();
                ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                CollVar.GetMulti(ExpVar);

                if (CollVar.Count == 0)
                {
                    AcikBildirimEntity EntKay = new AcikBildirimEntity();
                    EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                    EntKay.AcikBildirimAtandiSayi = 1;
                    EntKay.AcikBildirimInceleniyorSayi = 0;
                    EntKay.AcikBildirimInceleniyorEkSureSayi = 0;
                    EntKay.Save();
                }

                else
                {
                    CollVar[0].AcikBildirimAtandiSayi = Convert.ToInt16(CollVar[0].AcikBildirimAtandiSayi + 1);
                    CollVar[0].Save();
                }

                atandi = Convert.ToInt16(atandi + 1);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "Atandı";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil1[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil1[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil1[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil1[i].BildirimToplamSure;
                EntKay2.Save();
            }

            BildirimCollection CollBil2 = new BildirimCollection();
            IPredicateExpression ExpBil2 = new PredicateExpression();
            ExpBil2.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon2[0].BildirimSonucId);
            CollBil2.GetMulti(ExpBil2);

            for (int i = 0; i < CollBil2.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil2[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimCollection CollVar = new AcikBildirimCollection();
                IPredicateExpression ExpVar = new PredicateExpression();
                ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                CollVar.GetMulti(ExpVar);

                if (CollVar.Count == 0)
                {
                    AcikBildirimEntity EntKay = new AcikBildirimEntity();
                    EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                    EntKay.AcikBildirimAtandiSayi = 0;
                    EntKay.AcikBildirimInceleniyorSayi = 1;
                    EntKay.AcikBildirimInceleniyorEkSureSayi = 0;
                    EntKay.Save();
                }

                else
                {
                    CollVar[0].AcikBildirimInceleniyorSayi = Convert.ToInt16(CollVar[0].AcikBildirimInceleniyorSayi + 1);
                    CollVar[0].Save();
                }

                incele = Convert.ToInt16(incele + 1);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil2[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil2[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil2[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil2[i].BildirimToplamSure;
                EntKay2.Save();
            }

            BildirimCollection CollBil3 = new BildirimCollection();
            IPredicateExpression ExpBil3 = new PredicateExpression();
            ExpBil3.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon3[0].BildirimSonucId);
            CollBil3.GetMulti(ExpBil3);

            for (int i = 0; i < CollBil3.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil3[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimCollection CollVar = new AcikBildirimCollection();
                IPredicateExpression ExpVar = new PredicateExpression();
                ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                CollVar.GetMulti(ExpVar);

                if (CollVar.Count == 0)
                {
                    AcikBildirimEntity EntKay = new AcikBildirimEntity();
                    EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                    EntKay.AcikBildirimAtandiSayi = 0;
                    EntKay.AcikBildirimInceleniyorSayi = 0;
                    EntKay.AcikBildirimInceleniyorEkSureSayi = 1;
                    EntKay.Save();
                }

                else
                {
                    CollVar[0].AcikBildirimInceleniyorEkSureSayi = Convert.ToInt16(CollVar[0].AcikBildirimInceleniyorEkSureSayi + 1);
                    CollVar[0].Save();
                }

                incele_ek = Convert.ToInt16(incele_ek + 1);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor- Ek Süre";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil3[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil3[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil3[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil3[i].BildirimToplamSure;
                EntKay2.Save();
            }

            AcikBildirimEntity EntSon = new AcikBildirimEntity();
            EntSon.AcikBildirimBirim = "TOPLAM";
            EntSon.AcikBildirimAtandiSayi = atandi;
            EntSon.AcikBildirimInceleniyorSayi = incele;
            EntSon.AcikBildirimInceleniyorEkSureSayi = incele_ek;
            EntSon.Save();

            AcikBildirimCollection CollD1 = new AcikBildirimCollection();
            CollD1.GetMulti(null);

            grid_genel.DataSource = CollD1;
            grid_genel.DataBind(); 
        }

        protected void grid_genel_BeforeColumnSortingGrouping(object sender, EventArgs e) 
        {
            AcikBildirimCollection CollAcik = new AcikBildirimCollection();
            CollAcik.GetMulti(null);

            for (int i = 0; i < CollAcik.Count; i++)
            {
                CollAcik[i].Delete();
                CollAcik[i].Save();
            }
            Int16 atandi = 0;
            Int16 incele = 0;
            Int16 incele_ek = 0;

            BildirimSonucCollection CollSon1 = new BildirimSonucCollection();
            IPredicateExpression ExpSon1 = new PredicateExpression();
            ExpSon1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
            CollSon1.GetMulti(ExpSon1);

            BildirimSonucCollection CollSon2 = new BildirimSonucCollection();
            IPredicateExpression ExpSon2 = new PredicateExpression();
            ExpSon2.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
            CollSon2.GetMulti(ExpSon2);

            BildirimSonucCollection CollSon3 = new BildirimSonucCollection();
            IPredicateExpression ExpSon3 = new PredicateExpression();
            ExpSon3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
            CollSon3.GetMulti(ExpSon3);

            BildirimCollection CollBil1 = new BildirimCollection();
            IPredicateExpression ExpBil1 = new PredicateExpression();
            ExpBil1.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon1[0].BildirimSonucId);
            CollBil1.GetMulti(ExpBil1);

            for (int i = 0; i < CollBil1.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil1[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimCollection CollVar = new AcikBildirimCollection();
                IPredicateExpression ExpVar = new PredicateExpression();
                ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                CollVar.GetMulti(ExpVar);

                if (CollVar.Count == 0)
                {
                    AcikBildirimEntity EntKay = new AcikBildirimEntity();
                    EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                    EntKay.AcikBildirimAtandiSayi = 1;
                    EntKay.AcikBildirimInceleniyorSayi = 0;
                    EntKay.AcikBildirimInceleniyorEkSureSayi = 0;
                    EntKay.Save();
                }

                else
                {
                    CollVar[0].AcikBildirimAtandiSayi = Convert.ToInt16(CollVar[0].AcikBildirimAtandiSayi + 1);
                    CollVar[0].Save();
                }

                atandi = Convert.ToInt16(atandi + 1);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "Atandı";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil1[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil1[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil1[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil1[i].BildirimToplamSure;
                EntKay2.Save();
            }

            BildirimCollection CollBil2 = new BildirimCollection();
            IPredicateExpression ExpBil2 = new PredicateExpression();
            ExpBil2.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon2[0].BildirimSonucId);
            CollBil2.GetMulti(ExpBil2);

            for (int i = 0; i < CollBil2.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil2[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimCollection CollVar = new AcikBildirimCollection();
                IPredicateExpression ExpVar = new PredicateExpression();
                ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                CollVar.GetMulti(ExpVar);

                if (CollVar.Count == 0)
                {
                    AcikBildirimEntity EntKay = new AcikBildirimEntity();
                    EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                    EntKay.AcikBildirimAtandiSayi = 0;
                    EntKay.AcikBildirimInceleniyorSayi = 1;
                    EntKay.AcikBildirimInceleniyorEkSureSayi = 0;
                    EntKay.Save();
                }

                else
                {
                    CollVar[0].AcikBildirimInceleniyorSayi = Convert.ToInt16(CollVar[0].AcikBildirimInceleniyorSayi + 1);
                    CollVar[0].Save();
                }

                incele = Convert.ToInt16(incele + 1);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil2[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil2[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil2[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil2[i].BildirimToplamSure;
                EntKay2.Save();
            }

            BildirimCollection CollBil3 = new BildirimCollection();
            IPredicateExpression ExpBil3 = new PredicateExpression();
            ExpBil3.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon3[0].BildirimSonucId);
            CollBil3.GetMulti(ExpBil3);

            for (int i = 0; i < CollBil3.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil3[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimCollection CollVar = new AcikBildirimCollection();
                IPredicateExpression ExpVar = new PredicateExpression();
                ExpVar.AddWithAnd(AcikBildirimFields.AcikBildirimBirim == CollNe[0].GrupAd);
                CollVar.GetMulti(ExpVar);

                if (CollVar.Count == 0)
                {
                    AcikBildirimEntity EntKay = new AcikBildirimEntity();
                    EntKay.AcikBildirimBirim = CollNe[0].GrupAd;
                    EntKay.AcikBildirimAtandiSayi = 0;
                    EntKay.AcikBildirimInceleniyorSayi = 0;
                    EntKay.AcikBildirimInceleniyorEkSureSayi = 1;
                    EntKay.Save();
                }

                else
                {
                    CollVar[0].AcikBildirimInceleniyorEkSureSayi = Convert.ToInt16(CollVar[0].AcikBildirimInceleniyorEkSureSayi + 1);
                    CollVar[0].Save();
                }

                incele_ek = Convert.ToInt16(incele_ek + 1);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor- Ek Süre";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil3[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil3[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil3[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil3[i].BildirimToplamSure;
                EntKay2.Save();
            }

            AcikBildirimEntity EntSon = new AcikBildirimEntity();
            EntSon.AcikBildirimBirim = "TOPLAM";
            EntSon.AcikBildirimAtandiSayi = atandi;
            EntSon.AcikBildirimInceleniyorSayi = incele;
            EntSon.AcikBildirimInceleniyorEkSureSayi = incele_ek;
            EntSon.Save();

            AcikBildirimCollection CollD1 = new AcikBildirimCollection();
            CollD1.GetMulti(null);

            grid_genel.DataSource = CollD1;
            grid_genel.DataBind(); 
        }

        protected void grid_ayrinti_PageSizeChanged(object sender, EventArgs e)
        {
            AcikBildirimAyrintiCollection CollAyr = new AcikBildirimAyrintiCollection();
            CollAyr.GetMulti(null);

            for (int i = 0; i < CollAyr.Count; i++)
            {
                CollAyr[i].Delete();
                CollAyr[i].Save();
            }

            BildirimSonucCollection CollSon1 = new BildirimSonucCollection();
            IPredicateExpression ExpSon1 = new PredicateExpression();
            ExpSon1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
            CollSon1.GetMulti(ExpSon1);

            BildirimSonucCollection CollSon2 = new BildirimSonucCollection();
            IPredicateExpression ExpSon2 = new PredicateExpression();
            ExpSon2.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
            CollSon2.GetMulti(ExpSon2);

            BildirimSonucCollection CollSon3 = new BildirimSonucCollection();
            IPredicateExpression ExpSon3 = new PredicateExpression();
            ExpSon3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
            CollSon3.GetMulti(ExpSon3);

            BildirimCollection CollBil1 = new BildirimCollection();
            IPredicateExpression ExpBil1 = new PredicateExpression();
            ExpBil1.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon1[0].BildirimSonucId);
            CollBil1.GetMulti(ExpBil1);

            for (int i = 0; i < CollBil1.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil1[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "Atandı";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil1[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil1[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil1[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil1[i].BildirimToplamSure;
                EntKay2.Save();
            }

            BildirimCollection CollBil2 = new BildirimCollection();
            IPredicateExpression ExpBil2 = new PredicateExpression();
            ExpBil2.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon2[0].BildirimSonucId);
            CollBil2.GetMulti(ExpBil2);

            for (int i = 0; i < CollBil2.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil2[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil2[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil2[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil2[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil2[i].BildirimToplamSure;
                EntKay2.Save();
            }

            BildirimCollection CollBil3 = new BildirimCollection();
            IPredicateExpression ExpBil3 = new PredicateExpression();
            ExpBil3.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon3[0].BildirimSonucId);
            CollBil3.GetMulti(ExpBil3);

            for (int i = 0; i < CollBil3.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil3[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor- Ek Süre";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil3[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil3[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil3[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil3[i].BildirimToplamSure;
                EntKay2.Save();
            }    

            AcikBildirimAyrintiCollection CollD2 = new AcikBildirimAyrintiCollection();
            CollD2.GetMulti(null);

            grid_ayrinti.DataSource = CollD2;
            grid_ayrinti.DataBind();

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_ayrinti.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_ayrinti_ProcessColumnAutoFilter(object sender, EventArgs e)
        {
            AcikBildirimAyrintiCollection CollAyr = new AcikBildirimAyrintiCollection();
            CollAyr.GetMulti(null);

            for (int i = 0; i < CollAyr.Count; i++)
            {
                CollAyr[i].Delete();
                CollAyr[i].Save();
            }

            BildirimSonucCollection CollSon1 = new BildirimSonucCollection();
            IPredicateExpression ExpSon1 = new PredicateExpression();
            ExpSon1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
            CollSon1.GetMulti(ExpSon1);

            BildirimSonucCollection CollSon2 = new BildirimSonucCollection();
            IPredicateExpression ExpSon2 = new PredicateExpression();
            ExpSon2.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
            CollSon2.GetMulti(ExpSon2);

            BildirimSonucCollection CollSon3 = new BildirimSonucCollection();
            IPredicateExpression ExpSon3 = new PredicateExpression();
            ExpSon3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
            CollSon3.GetMulti(ExpSon3);

            BildirimCollection CollBil1 = new BildirimCollection();
            IPredicateExpression ExpBil1 = new PredicateExpression();
            ExpBil1.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon1[0].BildirimSonucId);
            CollBil1.GetMulti(ExpBil1);

            for (int i = 0; i < CollBil1.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil1[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "Atandı";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil1[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil1[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil1[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil1[i].BildirimToplamSure;
                EntKay2.Save();
            }

            BildirimCollection CollBil2 = new BildirimCollection();
            IPredicateExpression ExpBil2 = new PredicateExpression();
            ExpBil2.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon2[0].BildirimSonucId);
            CollBil2.GetMulti(ExpBil2);

            for (int i = 0; i < CollBil2.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil2[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil2[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil2[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil2[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil2[i].BildirimToplamSure;
                EntKay2.Save();
            }

            BildirimCollection CollBil3 = new BildirimCollection();
            IPredicateExpression ExpBil3 = new PredicateExpression();
            ExpBil3.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon3[0].BildirimSonucId);
            CollBil3.GetMulti(ExpBil3);

            for (int i = 0; i < CollBil3.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil3[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor- Ek Süre";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil3[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil3[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil3[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil3[i].BildirimToplamSure;
                EntKay2.Save();
            }

            AcikBildirimAyrintiCollection CollD2 = new AcikBildirimAyrintiCollection();
            CollD2.GetMulti(null);

            grid_ayrinti.DataSource = CollD2;
            grid_ayrinti.DataBind();
        }

        protected void grid_ayrinti_CustomCollback(object sender, EventArgs e)
        {
            try
            {
                txtUserNameayr.Text = grid_ayrinti.GetSelectedFieldValues("AcikBildirimAyrintiId")[0].ToString();

                grid_ayrinti.Selection.UnselectAll();
            }

            catch
            {

            }
        }

        protected void grid_ayrinti_PageIndexChanged(object sender, EventArgs e)
        {
            AcikBildirimAyrintiCollection CollAyr = new AcikBildirimAyrintiCollection();
            CollAyr.GetMulti(null);

            for (int i = 0; i < CollAyr.Count; i++)
            {
                CollAyr[i].Delete();
                CollAyr[i].Save();
            }

            BildirimSonucCollection CollSon1 = new BildirimSonucCollection();
            IPredicateExpression ExpSon1 = new PredicateExpression();
            ExpSon1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
            CollSon1.GetMulti(ExpSon1);

            BildirimSonucCollection CollSon2 = new BildirimSonucCollection();
            IPredicateExpression ExpSon2 = new PredicateExpression();
            ExpSon2.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
            CollSon2.GetMulti(ExpSon2);

            BildirimSonucCollection CollSon3 = new BildirimSonucCollection();
            IPredicateExpression ExpSon3 = new PredicateExpression();
            ExpSon3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
            CollSon3.GetMulti(ExpSon3);

            BildirimCollection CollBil1 = new BildirimCollection();
            IPredicateExpression ExpBil1 = new PredicateExpression();
            ExpBil1.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon1[0].BildirimSonucId);
            CollBil1.GetMulti(ExpBil1);

            for (int i = 0; i < CollBil1.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil1[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "Atandı";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil1[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil1[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil1[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil1[i].BildirimToplamSure;
                EntKay2.Save();
            }

            BildirimCollection CollBil2 = new BildirimCollection();
            IPredicateExpression ExpBil2 = new PredicateExpression();
            ExpBil2.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon2[0].BildirimSonucId);
            CollBil2.GetMulti(ExpBil2);

            for (int i = 0; i < CollBil2.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil2[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil2[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil2[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil2[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil2[i].BildirimToplamSure;
                EntKay2.Save();
            }

            BildirimCollection CollBil3 = new BildirimCollection();
            IPredicateExpression ExpBil3 = new PredicateExpression();
            ExpBil3.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon3[0].BildirimSonucId);
            CollBil3.GetMulti(ExpBil3);

            for (int i = 0; i < CollBil3.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil3[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor- Ek Süre";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil3[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil3[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil3[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil3[i].BildirimToplamSure;
                EntKay2.Save();
            }    

            AcikBildirimAyrintiCollection CollD2 = new AcikBildirimAyrintiCollection();
            CollD2.GetMulti(null);

            grid_ayrinti.DataSource = CollD2;
            grid_ayrinti.DataBind();
        }

        protected void grid_ayrinti_BeforeColumnSortingGrouping(object sender, EventArgs e)
        {
            AcikBildirimAyrintiCollection CollAyr = new AcikBildirimAyrintiCollection();
            CollAyr.GetMulti(null);

            for (int i = 0; i < CollAyr.Count; i++)
            {
                CollAyr[i].Delete();
                CollAyr[i].Save();
            }

            BildirimSonucCollection CollSon1 = new BildirimSonucCollection();
            IPredicateExpression ExpSon1 = new PredicateExpression();
            ExpSon1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
            CollSon1.GetMulti(ExpSon1);

            BildirimSonucCollection CollSon2 = new BildirimSonucCollection();
            IPredicateExpression ExpSon2 = new PredicateExpression();
            ExpSon2.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
            CollSon2.GetMulti(ExpSon2);

            BildirimSonucCollection CollSon3 = new BildirimSonucCollection();
            IPredicateExpression ExpSon3 = new PredicateExpression();
            ExpSon3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
            CollSon3.GetMulti(ExpSon3);

            BildirimCollection CollBil1 = new BildirimCollection();
            IPredicateExpression ExpBil1 = new PredicateExpression();
            ExpBil1.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon1[0].BildirimSonucId);
            CollBil1.GetMulti(ExpBil1);

            for (int i = 0; i < CollBil1.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil1[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "Atandı";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil1[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil1[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil1[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil1[i].BildirimToplamSure;
                EntKay2.Save();
            }

            BildirimCollection CollBil2 = new BildirimCollection();
            IPredicateExpression ExpBil2 = new PredicateExpression();
            ExpBil2.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon2[0].BildirimSonucId);
            CollBil2.GetMulti(ExpBil2);

            for (int i = 0; i < CollBil2.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil2[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil2[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil2[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil2[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil2[i].BildirimToplamSure;
                EntKay2.Save();
            }

            BildirimCollection CollBil3 = new BildirimCollection();
            IPredicateExpression ExpBil3 = new PredicateExpression();
            ExpBil3.AddWithAnd(BildirimFields.FkBildirimSonucId == CollSon3[0].BildirimSonucId);
            CollBil3.GetMulti(ExpBil3);

            for (int i = 0; i < CollBil3.Count; i++)
            {
                BildirimAtamaGrupCollection CollGr = new BildirimAtamaGrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(BildirimAtamaGrupFields.FkBildirimId == CollBil3[i].BildirimId);
                ISortExpression sortgr = new SortExpression();
                sortgr.Add(new SortClause(BildirimAtamaGrupFields.BildirimAtamaGrupId, SortOperator.Descending));
                CollGr.GetMulti(ExpGr, 0, sortgr);

                GrupCollection CollNe = new GrupCollection();
                IPredicateExpression ExpNe = new PredicateExpression();
                ExpNe.AddWithAnd(GrupFields.GrupId == CollGr[0].FkGrupId);
                CollNe.GetMulti(ExpNe);

                AcikBildirimAyrintiEntity EntKay2 = new AcikBildirimAyrintiEntity();
                EntKay2.AcikBildirimAyrintiBirim = CollNe[0].GrupAd;
                EntKay2.AcikBildirimAyrintiDurum = "İnceleniyor- Ek Süre";
                EntKay2.AcikBildirimAyrintiIcerik = CollBil3[i].BildirimMetin;
                EntKay2.AcikBildirimAyrintiNo = CollBil3[i].BildirimId;
                EntKay2.AcikBildirimAyrintiSonDurum = CollBil3[i].BildirimAtanmaDurumu;
                EntKay2.AcikBildirimAyrintiSure = CollBil3[i].BildirimToplamSure;
                EntKay2.Save();
            }

            AcikBildirimAyrintiCollection CollD2 = new AcikBildirimAyrintiCollection();
            CollD2.GetMulti(null);

            grid_ayrinti.DataSource = CollD2;
            grid_ayrinti.DataBind();
        }
    }
}