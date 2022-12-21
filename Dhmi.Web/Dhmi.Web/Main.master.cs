using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxNavBar;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using dhmi.EntityClasses;
using dhmi.TypedListClasses;

namespace Dhmi.Web
{
    public partial class Main : System.Web.UI.MasterPage
    {
        int sonuc = 0;

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
            if ((Session["kullanici_var_mi"] == null) || (Session["kullanici_rastgele"] == null))
            {
                Response.Redirect("Account/Login.aspx");
            }
        }

        /*
        void menu_belirle()
        {
            sonuc = Kullanici.KullaniciGetirYetki(Convert.ToInt32(Session["kullanici_var_mi"].ToString()));

            string menu_b = Session["menu_sec"].ToString();

            MenuCollection CollMen = new MenuCollection();
            IPredicateExpression ExpMen = new PredicateExpression();
            ExpMen.AddWithAnd(MenuFields.MenuAd == menu_b);
            CollMen.GetMulti(ExpMen);

            MenuOlusturCollection CollMenu = new MenuOlusturCollection();
            ISortExpression sortmenu = new SortExpression();
            IPredicateExpression ExpMenu = new PredicateExpression();
            ExpMenu.AddWithAnd(MenuOlusturFields.FkYetkiId == sonuc);
            ExpMenu.AddWithAnd(MenuOlusturFields.FkMenuId == CollMen[0].MenuId);
            ExpMenu.AddWithAnd(MenuOlusturFields.FkAltMenuId != 27);
            ExpMenu.AddWithAnd(MenuOlusturFields.FkAltAltMenuId == 28);
            sortmenu.Add(new SortClause(MenuOlusturFields.MenuOlusturSayi, SortOperator.Ascending));
            CollMenu.GetMulti(ExpMenu, 0, sortmenu);

            for (int i = 0; i < CollMenu.Count; i++)
            {
                AltMenuCollection CollMe = new AltMenuCollection();
                IPredicateExpression ExpMe = new PredicateExpression();
                ExpMe.AddWithAnd(AltMenuFields.AltMenuId == CollMenu[i].FkAltMenuId);
                CollMe.GetMulti(ExpMe);

                if (CollMe[0].AltMenuAd == "Sistem Uyarıları")
                {
                    KullaniciCollection CollKul = new KullaniciCollection();
                    IPredicateExpression ExpKul = new PredicateExpression();
                    ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                    CollKul.GetMulti(ExpKul);

                    BilgilendirmeCollection CollBil = new BilgilendirmeCollection();
                    IPredicateExpression ExpBil = new PredicateExpression();
                    ExpBil.AddWithAnd(BilgilendirmeFields.BilgilendirmeGidenKullanici == CollKul[0].KullaniciAdSoyad);
                    CollBil.GetMulti(ExpBil);

                    if (CollBil.Count > 0)
                    {
                        ASPxNavBar1.Groups.Add(CollMe[0].AltMenuAd + " - { " + CollBil.Count + " }");
                    }

                    else
                    {
                        ASPxNavBar1.Groups.Add(CollMe[0].AltMenuAd + " - { 0 }");
                    }

                }

                else if (CollMe[0].AltMenuAd == "Atanan Bildirim Bilgileri")
                {
                    ListTakipTypedList bil_list3 = new ListTakipTypedList();
                    ISortExpression sortbil3 = new SortExpression();
                    sortbil3.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filterbil3 = new PredicateExpression();
                    filterbil3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                    filterbil3.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == AktifKullanici.KullaniciId);//Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                    filterbil3.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciYonMu == "Hayır");
                    filterbil3.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciBittiMi == false);
                    bil_list3.Fill(0, sortbil3, true, filterbil3);

                    if (bil_list3.Count > 0)
                    {
                        ASPxNavBar1.Groups.Add(CollMe[0].AltMenuAd + " - { " + bil_list3.Count.ToString() + " }");
                    }

                    else
                    {
                        ASPxNavBar1.Groups.Add(CollMe[0].AltMenuAd + " - { 0 }");
                    }
                }

                else
                {
                    ASPxNavBar1.Groups.Add(CollMe[0].AltMenuAd);
                }

                int altmenu_id = CollMe[0].AltMenuId;

                MenuOlusturCollection CollMenu2 = new MenuOlusturCollection();
                IPredicateExpression ExpMenu2 = new PredicateExpression();
                ISortExpression sortben = new SortExpression();
                ExpMenu2.AddWithAnd(MenuOlusturFields.FkYetkiId == sonuc);
                ExpMenu2.AddWithAnd(MenuOlusturFields.FkMenuId == CollMen[0].MenuId);
                ExpMenu2.AddWithAnd(MenuOlusturFields.FkAltMenuId == altmenu_id);
                ExpMenu2.AddWithAnd(MenuOlusturFields.FkAltAltMenuId != 28);
                sortben.Add(new SortClause(MenuOlusturFields.MenuOlusturSayi, SortOperator.Ascending));
                CollMenu2.GetMulti(ExpMenu2, 0, sortben);

                for (int j = 0; j < CollMenu2.Count; j++)
                {
                    AltAltMenuCollection CollAlt = new AltAltMenuCollection();
                    IPredicateExpression ExpAlt = new PredicateExpression();
                    ExpAlt.AddWithAnd(AltAltMenuFields.AltAltMenuId == CollMenu2[j].FkAltAltMenuId);
                    CollAlt.GetMulti(ExpAlt);

                    if (CollAlt[0].AltAltMenuAd == "Mesaj Bilgileri")
                    {
                        KullaniciCollection CollKul = new KullaniciCollection();
                        IPredicateExpression ExpKul = new PredicateExpression();
                        ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                        CollKul.GetMulti(ExpKul);

                        MesajCollection CollMes = new MesajCollection();
                        IPredicateExpression ExpMes = new PredicateExpression();
                        ExpMes.AddWithAnd(MesajFields.MesajHangiKullanici == CollKul[0].KullaniciAdSoyad);
                        CollMes.GetMulti(ExpMes);

                        if (CollMes.Count > 0)
                        {
                            ASPxNavBar1.Groups[i].Items.Add(CollAlt[0].AltAltMenuAd + " - { " + CollMes.Count + " }");
                        }

                        else
                        {
                            ASPxNavBar1.Groups[i].Items.Add(CollAlt[0].AltAltMenuAd + " - { 0 }");
                        }
                    }

                    else if (CollAlt[0].AltAltMenuAd == "Atanan Bildirim Bilgileri")
                    {
                        ListTakipTypedList bil_list3 = new ListTakipTypedList();
                        ISortExpression sortbil3 = new SortExpression();
                        sortbil3.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                        IPredicateExpression filterbil3 = new PredicateExpression();
                        filterbil3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                        filterbil3.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == AktifKullanici.KullaniciId);//Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                        filterbil3.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciYonMu == "Hayır");
                        filterbil3.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciBittiMi == false);
                        bil_list3.Fill(0, sortbil3, true, filterbil3);

                        if (bil_list3.Count > 0)
                        {
                            ASPxNavBar1.Groups[i].Items.Add(CollAlt[0].AltAltMenuAd + " - { " + bil_list3.Count + " }");
                        }

                        else
                        {
                            ASPxNavBar1.Groups[i].Items.Add(CollAlt[0].AltAltMenuAd + " - { 0 }");
                        }
                    }

                    else if (CollAlt[0].AltAltMenuAd == "Sistem Uyarıları")
                    {
                        KullaniciCollection CollKul = new KullaniciCollection();
                        IPredicateExpression ExpKul = new PredicateExpression();
                        ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                        CollKul.GetMulti(ExpKul);

                        BilgilendirmeCollection CollMes = new BilgilendirmeCollection();
                        IPredicateExpression ExpMes = new PredicateExpression();
                        ExpMes.AddWithAnd(BilgilendirmeFields.BilgilendirmeGidenKullanici == CollKul[0].KullaniciAdSoyad);
                        CollMes.GetMulti(ExpMes);

                        if (CollMes.Count > 0)
                        {
                            ASPxNavBar1.Groups[i].Items.Add(CollAlt[0].AltAltMenuAd + " - { " + CollMes.Count + " }");
                        }

                        else
                        {
                            ASPxNavBar1.Groups[i].Items.Add(CollAlt[0].AltAltMenuAd + " - { 0 }");
                        }
                    }

                    else
                    {
                        ASPxNavBar1.Groups[i].Items.Add(CollAlt[0].AltAltMenuAd);
                    }

                    ASPxNavBar1.Groups[i].Items[j].NavigateUrl = CollAlt[0].AltAltMenuSonLink;
                    ASPxNavBar1.Groups[i].Items[j].ToolTip = CollAlt[0].AltAltMenuAciklama;
                    ASPxNavBar1.Groups[i].Items[j].Image.Url = "Content/images/menu_button.png";
                }
            }
        }*/
    }
}