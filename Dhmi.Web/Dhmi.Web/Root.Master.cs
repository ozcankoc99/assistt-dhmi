namespace Dhmi.Web
{
    using System;
    using SD.LLBLGen.Pro.ORMSupportClasses;
    using dhmi.CollectionClasses;
    using dhmi.HelperClasses;
    using dhmi.EntityClasses;
    using DevExpress.Web;
    using dhmi.TypedListClasses;
    public partial class Root : System.Web.UI.MasterPage
    {
        int sonuc = 0;

        protected void Page_Load(object sender, EventArgs e)
        {            
            if (IsPostBack != true)
            {
                KullaniciCollection CollKul = new KullaniciCollection();
                IPredicateExpression ExpKul = new PredicateExpression();
                ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt32(Session["kullanici_var_mi"].ToString()));
                CollKul.GetMulti(ExpKul);

                GorevCollection CollGrup = new GorevCollection();
                IPredicateExpression ExpGrup = new PredicateExpression();
                ExpGrup.AddWithAnd(GorevFields.GorevId == CollKul[0].FkGorevId);
                CollGrup.GetMulti(ExpGrup);

                ASPxLabel43.Text = CollKul[0].KullaniciAdSoyad + " / " + CollGrup[0].GorevAd;

                menu_belirle();
                menu_belirle_drop();

                DuyuruCollection CollDuy = new DuyuruCollection();
                IPredicateExpression ExpDuy = new PredicateExpression();
                ExpDuy.AddWithAnd(DuyuruFields.DuyuruYayinTarih <= DateTime.Now);
                ExpDuy.AddWithAnd(DuyuruFields.DuyuruDurum == true);
                ISortExpression sortduy = new SortExpression();
                sortduy.Add(new SortClause(DuyuruFields.DuyuruYayinTarih, SortOperator.Descending));
                CollDuy.GetMulti(ExpDuy, 0, sortduy);

                if (CollDuy.Count > 0)
                {
                    lbl_duyuru_tarih.Text = CollDuy[0].DuyuruYayinTarih.ToShortDateString();
                    lbl_duyuru_ana.Text = " - " + CollDuy[0].DuyuruBaslik;
                    txt_duyuru_aciklama.Text = CollDuy[0].DuyuruIcerik;
                }

                else
                {
                    lbl_duyuru_tarih.Text = DateTime.Now.ToShortDateString();
                    lbl_duyuru_ana.Text = " - Güncel duyuru bulunmamaktadır...";
                    txt_duyuru_aciklama.Text = " - Güncel duyuru bulunmamaktadır...";
                }                
            }
        }

        void menu_belirle()
        {
            sonuc = Kullanici.KullaniciGetirYetki(Convert.ToInt32(Session["kullanici_var_mi"].ToString()));

            MenuOlusturCollection CollMenu = new MenuOlusturCollection();
            IPredicateExpression ExpMenu = new PredicateExpression();
            ISortExpression sortmenu = new SortExpression();
            sortmenu.Add(new SortClause(MenuOlusturFields.MenuOlusturSayi, SortOperator.Ascending));
            ExpMenu.AddWithAnd(MenuOlusturFields.FkYetkiId == sonuc);
            ExpMenu.AddWithAnd(MenuOlusturFields.FkAltMenuId == 27);
            ExpMenu.AddWithAnd(MenuOlusturFields.FkAltAltMenuId == 28);
            CollMenu.GetMulti(ExpMenu, 0, sortmenu);

            for (int i = 0; i < CollMenu.Count; i++)
            {
                MenuCollection CollMe = new MenuCollection();
                IPredicateExpression ExpMe = new PredicateExpression();
                ExpMe.AddWithAnd(MenuFields.MenuId == CollMenu[i].FkMenuId);
                CollMe.GetMulti(ExpMe);

                KullaniciCollection CollKul = new KullaniciCollection();
                IPredicateExpression ExpKul = new PredicateExpression();
                ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollKul.GetMulti(ExpKul);

                if (CollMe[0].MenuAd == "Çağrı İşlemleri")
                {                    
                    ListTakipTypedList bil_list3 = new ListTakipTypedList();
                    ISortExpression sortbil3 = new SortExpression();
                    sortbil3.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filterbil3 = new PredicateExpression();
                    filterbil3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                    filterbil3.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                    filterbil3.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciYonMu == "Hayır");
                    filterbil3.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciBittiMi == false);
                    bil_list3.Fill(0, sortbil3, true, filterbil3);                    

                    BilgilendirmeCollection CollBil = new BilgilendirmeCollection();
                    IPredicateExpression ExpBil = new PredicateExpression();
                    ExpBil.AddWithAnd(BilgilendirmeFields.BilgilendirmeGidenKullanici == CollKul[0].KullaniciAdSoyad);
                    CollBil.GetMulti(ExpBil);
                    

                    ASPxMenu1.Items.Add(CollMe[0].MenuAd + " - { " + bil_list3.Count.ToString() + " } / { " + CollBil.Count + " }");
                }

                else if (CollMe[0].MenuAd == "Kullanıcı İşlemleri")
                {
                    MesajCollection CollMes = new MesajCollection();
                    IPredicateExpression ExpMes = new PredicateExpression();
                    ExpMes.AddWithAnd(MesajFields.MesajHangiKullanici == CollKul[0].KullaniciAdSoyad);
                    CollMes.GetMulti(ExpMes);
                    
                    ASPxMenu1.Items.Add(CollMe[0].MenuAd + " - { " + CollMes.Count + " }");
                }

                else
                {
                    ASPxMenu1.Items.Add(CollMe[0].MenuAd);
                }

                if (CollMe[0].MenuAd == "Duyurular" || CollMe[0].MenuAd == "Bilgi Bankası")
                {
                    ASPxMenu1.Items[i].NavigateUrl = CollMe[0].MenuSonLink;
                }                
            }
        }

        protected void btn_cikis_Click(object sender, EventArgs e)
        {
            Session["kullanici_var_mi"] = null;
            Session["kullanici_rastgele"] = null;
            Session["menu_sec"] = null;
            Response.Cookies.Clear();
            Request.Cookies.Clear();
            Session.Clear();
            
            Response.Redirect("Account/Login.aspx");
        }

        void menu_belirle_drop()
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
            ExpMenu.AddWithAnd(MenuOlusturFields.FkAltMenuId == 27);
            ExpMenu.AddWithAnd(MenuOlusturFields.FkAltAltMenuId == 28);
            sortmenu.Add(new SortClause(MenuOlusturFields.MenuOlusturSayi, SortOperator.Ascending));
            CollMenu.GetMulti(ExpMenu, 0, sortmenu);

            for (int i = 0; i < CollMenu.Count; i++)
            {
                AltMenuCollection CollMe = new AltMenuCollection();
                IPredicateExpression ExpMe = new PredicateExpression();
                ExpMe.AddWithAnd(AltMenuFields.AltMenuId == CollMenu[i].FkAltMenuId);
                CollMe.GetMulti(ExpMe);

                KullaniciCollection CollKul = new KullaniciCollection();
                IPredicateExpression ExpKul = new PredicateExpression();
                ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollKul.GetMulti(ExpKul);

                YetkiCollection CollYet = new YetkiCollection();
                IPredicateExpression ExpYet = new PredicateExpression();
                ExpYet.AddWithAnd(YetkiFields.YetkiId == CollKul[0].FkYetkiId);
                CollYet.GetMulti(ExpYet);

                int altmenu_id = CollMe[0].AltMenuId;

                MenuOlusturCollection CollMenu2 = new MenuOlusturCollection();
                IPredicateExpression ExpMenu2 = new PredicateExpression();
                ISortExpression sortben = new SortExpression();
                ExpMenu2.AddWithAnd(MenuOlusturFields.FkYetkiId == sonuc);
                ExpMenu2.AddWithAnd(MenuOlusturFields.FkMenuId == CollMenu[i].FkMenuId);
                ExpMenu2.AddWithAnd(MenuOlusturFields.FkAltMenuId != 27);
                ExpMenu2.AddWithAnd(MenuOlusturFields.FkAltAltMenuId != 28);
                sortben.Add(new SortClause(MenuOlusturFields.MenuOlusturSayi, SortOperator.Ascending));
                CollMenu2.GetMulti(ExpMenu2, 0, sortben);

                for (int j = 0; j < CollMenu2.Count; j++)
                {
                    AltAltMenuCollection CollAlt = new AltAltMenuCollection();
                    IPredicateExpression ExpAlt = new PredicateExpression();
                    ExpAlt.AddWithAnd(AltAltMenuFields.AltAltMenuId == CollMenu2[j].FkAltAltMenuId);
                    CollAlt.GetMulti(ExpAlt);                    

                    if (CollAlt[0].AltAltMenuAd == "Sistem Uyarıları")
                    {
                        BilgilendirmeCollection CollBil = new BilgilendirmeCollection();
                        IPredicateExpression ExpBil = new PredicateExpression();
                        ExpBil.AddWithAnd(BilgilendirmeFields.BilgilendirmeGidenKullanici == CollKul[0].KullaniciAdSoyad);
                        CollBil.GetMulti(ExpBil);

                        ASPxMenu1.Items[i].Items.Add(CollAlt[0].AltAltMenuAd + " - { " + CollBil.Count + " }");
                    }                  

                    else if (CollAlt[0].AltAltMenuAd == "Atanan Bildirim Bilgileri")
                    {
                        ListTakipTypedList bil_list3 = new ListTakipTypedList();
                        ISortExpression sortbil3 = new SortExpression();
                        sortbil3.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                        IPredicateExpression filterbil3 = new PredicateExpression();
                        filterbil3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                        filterbil3.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                        filterbil3.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciYonMu == "Hayır");
                        filterbil3.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciBittiMi == false);
                        bil_list3.Fill(0, sortbil3, true, filterbil3);

                        ASPxMenu1.Items[i].Items.Add(CollAlt[0].AltAltMenuAd + " - { " + bil_list3.Count.ToString() + " }");
                    }

                    else if (CollAlt[0].AltAltMenuAd == "Mesaj Bilgileri")
                    {
                        MesajCollection CollMes = new MesajCollection();
                        IPredicateExpression ExpMes = new PredicateExpression();
                        ExpMes.AddWithAnd(MesajFields.MesajHangiKullanici == CollKul[0].KullaniciAdSoyad);
                        CollMes.GetMulti(ExpMes);

                        ASPxMenu1.Items[i].Items.Add(CollAlt[0].AltAltMenuAd + " - { " + CollMes.Count + " }");
                    }

                    else
                    {
                        ASPxMenu1.Items[i].Items.Add(CollAlt[0].AltAltMenuAd);
                    }

                    ASPxMenu1.Items[i].Items[j].NavigateUrl = CollAlt[0].AltAltMenuSonLink;
                    ASPxMenu1.Items[i].Items[j].Image.Url = "Content/images/menu_button.png";
                }
            }
        }
    }
}