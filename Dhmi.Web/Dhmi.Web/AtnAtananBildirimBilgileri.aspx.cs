using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using SD.LLBLGen.Pro.ORMSupportClasses;
using DevExpress.Web.ASPxGridView;
using System.Drawing;
using dhmi.EntityClasses;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using dhmi.TypedListClasses;
using System.Configuration;
using DevExpress.Web.ASPxMenu;
using System.Web;

namespace Dhmi.Web
{
    public partial class AtnAtananBildirimBilgileri : System.Web.UI.Page
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

            if ((Session["kullanici_var_mi"] == null) || (Session["kullanici_rastgele"] == null))
            {
                Response.Redirect("Account/Login.aspx");
            }

            HttpCookie cookie = Request.Cookies["userC"];
            HttpCookie cookieYetki = Request.Cookies["aJ4lOu784TyfdEsd4FIoi"];
            if (cookie != null && cookieYetki != null)
            {
                string yetki = Helper.Decrypt(cookieYetki.Value);
                if (yetki == "Admin" || yetki == "Back Office" || yetki == "Takım Lideri" || yetki == "Kurum Sistem Yöneticisi" || yetki == "Kurum Makam")
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

            YetkiCollection CollYets = new YetkiCollection();
            IPredicateExpression ExpYets = new PredicateExpression();
            ExpYets.AddWithAnd(YetkiFields.YetkiId == AktifKullanici.FkYetkiId);
            CollYets.GetMulti(ExpYets);
            
            Session["yetki_durum"] = CollYets[0].YetkiAciklama;                    

            cb_sonuckul.Items.Clear();
            cb_sonuckul.Items.Add("Sonuçlandı");
            cb_sonuckul.Items.Add("Reddedildi");                 

            cb_yon_grupkul.Items.Clear();
            cb_yon_grupkul.Items.Add("----------");

            if (CollYets[0].YetkiAd == "Back Office")
            {
                cb_yon_grupkul.Items.Add("Backoffice");
            }

            else
            {
                if (CollYets[0].YetkiAd != "Takım Lideri")
                {
                    cb_yon_grupkul.Items.Add("Backoffice");
                }

                GrupCollection CollGr2 = new GrupCollection();
                IPredicateExpression ExpGr2 = new PredicateExpression();
                ISortExpression sortgr2 = new SortExpression();
                sortgr2.Add(new SortClause(GrupFields.GrupAd, SortOperator.Ascending));
                ExpGr2.AddWithAnd(GrupFields.GrupAd != "Backoffice");
                CollGr2.GetMulti(ExpGr2, 0, sortgr2);

                for (int i = 0; i < CollGr2.Count; i++)
                {
                    cb_yon_grupkul.Items.Add(CollGr2[i].GrupAd);
                }
            }

            cb_yon_kullanicikul.Items.Clear();

            cb_yon_kullanicikul.Items.Add("----------");

            GrupAtamaCollection CollAta = new GrupAtamaCollection();
            IPredicateExpression ExpAta = new PredicateExpression();
            ExpAta.AddWithAnd(GrupAtamaFields.FkKullaniciId == AktifKullanici.KullaniciId);
            CollAta.GetMulti(ExpAta);

            for (int i = 0; i < CollAta.Count; i++)
            {
                GrupAtamaCollection CollAtasi = new GrupAtamaCollection();
                IPredicateExpression ExpAtasi = new PredicateExpression();
                ExpAtasi.AddWithAnd(GrupAtamaFields.FkGrupId == CollAta[i].FkGrupId);
                ExpAtasi.AddWithAnd(GrupAtamaFields.FkKullaniciId != CollAta[i].FkKullaniciId);
                CollAtasi.GetMulti(ExpAtasi);

                for (int j = 0; j < CollAtasi.Count; j++)
                {
                    KullaniciCollection CollBul = new KullaniciCollection();
                    IPredicateExpression ExpBul = new PredicateExpression();
                    ExpBul.AddWithAnd(KullaniciFields.KullaniciId == CollAtasi[j].FkKullaniciId);
                    CollBul.GetMulti(ExpBul);

                    int sdsd = CollBul.Count;

                    cb_yon_kullanicikul.Items.Add(CollBul[0].KullaniciAdSoyad);
                }
            }

            cb_gunkul.Items.Clear();
            cb_saatkul.Items.Clear();

            for (int i = 0; i < 3; i++)
            {
                cb_gunkul.Items.Add((i + 1).ToString());
            }

            for (int i = 0; i < 24; i++)
            {
                cb_saatkul.Items.Add((i + 1).ToString());
            }

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == AktifKullanici.KullaniciId);//Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            grid_bildirim.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_bildirim_incele.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_bildirim_kul_incele.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_bildirim_yon_incele.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            if (IsPostBack != true)
            {
                Session["say_bak"] = "0";
                Session["say_bak2"] = "0";
                Session["say_bak3"] = "0";
                Session["say_bak4"] = "0"; 

                Session["sorgula_ana"] = null;
                Session["sorgula_2"] = null;

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

                if (Session["sorgula_2"] == null)
                {
                    txt_bas_tarihi_2.Text = gun + "." + ay + "." + yil;
                    txt_bit_tarihi_2.Text = gun + "." + ay + "." + yil;
                }

                if (Session["sorgula_ana"] == null)
                {
                    txt_bas_tarihi.Text = gun + "." + ay + "." + yil;
                    txt_bit_tarihi.Text = gun + "." + ay + "." + yil;
                } 
        
                Session["vat_id"] = null;              

                MenuCollection CollMenu = new MenuCollection();
                IPredicateExpression ExpMenu = new PredicateExpression();
                ExpMenu.AddWithAnd(MenuFields.MenuAd == "Çağrı İşlemleri");
                CollMenu.GetMulti(ExpMenu);

                AltMenuCollection CollAlt1 = new AltMenuCollection();
                IPredicateExpression ExpAlt1 = new PredicateExpression();
                ExpAlt1.AddWithAnd(AltMenuFields.AltMenuAd == "Atanan Bildirim Bilgileri");
                CollAlt1.GetMulti(ExpAlt1);

                AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                IPredicateExpression ExpAlt2 = new PredicateExpression();
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Atanan Bildirim Bilgileri");
                CollAlt2.GetMulti(ExpAlt2);

                YetkiCollection CollYet = new YetkiCollection();
                IPredicateExpression ExpYet = new PredicateExpression();
                ExpYet.AddWithAnd(YetkiFields.YetkiId == AktifKullanici.FkYetkiId);
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
                
                grid_doldur_yeni();
                grid_doldur_islem();
                grid_doldur_ek_sure();
                grid_doldur_full();
                baslangic_hesap(); 

                pcSonucKull.Focus();
            }                                 
        }

        protected void btnPdfExport_Click(object sender, EventArgs e)
        {
            Session["rapor_adi"] = "Atama Bilgileri";

            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McAraRapor.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void grid_bildirim_ProcessColumnAutoFilter(object sender, EventArgs e)
        {
            grid_doldur_full();
        }

        protected void grid_bildirim_PageSizeChanged(object sender, EventArgs e)
        {
            grid_doldur_full();

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == AktifKullanici.KullaniciId);//Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_bildirim.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_bildirim_yon_incele_PageSizeChanged(object sender, EventArgs e)
        {
            grid_doldur_ek_sure();

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == AktifKullanici.KullaniciId);//Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_bildirim_yon_incele.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_bildirim_incele_PageSizeChanged(object sender, EventArgs e)
        {
            grid_doldur_yeni();

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == AktifKullanici.KullaniciId);//Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_bildirim_incele.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_bildirim_incele_PageIndexChanged(object sender, EventArgs e)
        {
            grid_doldur_yeni();
        }

        protected void grid_bildirim_incele_ProcessColumnAutoFilter(object sender, EventArgs e)
        {
            try
            {
                grid_doldur_yeni();
            }

            catch { }
        }

        protected void grid_bildirim_kul_incele_PageSizeChanged(object sender, EventArgs e)
        {
            grid_doldur_islem();

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == AktifKullanici.KullaniciId);//Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_bildirim_kul_incele.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_bildirim_yon_incele_ProcessColumnAutoFilter(object sender, EventArgs e)
        {
            grid_doldur_ek_sure();
        }

        protected void grid_bildirim_yon_incele_PageIndexChanged(object sender, EventArgs e)
        {
            grid_doldur_ek_sure();
        }

        protected void grid_bildirim_PageIndexChanged(object sender, EventArgs e)
        {
            grid_doldur_full();
        }

        protected void grid_bildirim_yon_incele_BeforeColumnSortingGrouping(object sender, EventArgs e)
        {
            grid_doldur_ek_sure();
        }

        protected void grid_bildirim_yon_incele_CustomCollback(object sender, EventArgs e)
        {
            try
            {
                txtUserNameyon.Text = grid_bildirim_yon_incele.GetSelectedFieldValues("BildirimId")[0].ToString();

                Session["bildirim_iceri"] = txtUserNameyon.Text;

                lbl_ozet_adi.Text = txtUserNameyon.Text;

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserNameyon.Text));
                CollBil.GetMulti(ExpBil);

                Session["vatandas_iceri"] = CollBil[0].FkVatandasId.ToString();

                btn_bilgi_gecmis4.Enabled = true;

                DosyaCollection CollDos = new DosyaCollection();
                IPredicateExpression ExpDos = new PredicateExpression();
                ExpDos.AddWithAnd(DosyaFields.DosyaBildirimi == Convert.ToInt64(txtUserNameyon.Text));
                CollDos.GetMulti(ExpDos);

                btn_dosyasi3.Enabled = false;

                if (CollDos.Count > 0)
                {
                    Session["file_path_1"] = CollDos[0].DosyaIcerikPath;
                    btn_dosyasi3.Enabled = true;
                }

                if (CollDos.Count > 1)
                {
                    Session["file_path_2"] = CollDos[1].DosyaIcerikPath;
                    btn_dosyasi3.Enabled = true;
                }

                if (CollDos.Count > 2)
                {
                    Session["file_path_3"] = CollDos[2].DosyaIcerikPath;
                    btn_dosyasi3.Enabled = true;
                }

                grid_bildirim_yon_incele.Selection.UnselectAll();
            }

            catch 
            {

            }            
        }

        protected void tab_bas_ActiveTabChanged(object sender, EventArgs e)
        {           
            if (Session["girilmis"] != null)
            {
                grid_doldur_islem();
                Session["girilmis"] = null;
            }

            else if (Session["bitmis"] != null)
            {
                grid_doldur_full();
                Session["bitmis"] = null;
            }
        }

        protected void grid_bildirim_incele_CustomCollback(object sender, EventArgs e)
        {
            try
            {
                Session["girilmis"] = "evet";

                List<object> obj = grid_bildirim_incele.GetSelectedFieldValues("BildirimId");

                txtUserName.Text = obj.Count > 0 ? obj[0].ToString() : "-1";

                //txtUserName.Text = grid_bildirim_incele.GetSelectedFieldValues("BildirimId")[0].ToString();

                Session["bildirim_iceri"] = txtUserName.Text;

                lbl_secilen.Text = txtUserName.Text;

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserName.Text));
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    Session["vatandas_iceri"] = CollBil[0].FkVatandasId.ToString();

                    BildirimSonucCollection CollSon = new BildirimSonucCollection();
                    IPredicateExpression ExpSon = new PredicateExpression();
                    ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucId == CollBil[0].FkBildirimSonucId);
                    CollSon.GetMulti(ExpSon);

                    if (CollSon[0].BildirimSonucAd == "Atandı")
                    {
                        btn_incele.Enabled = true;
                    }

                    else
                    {
                        btn_incele.Enabled = false;
                    }

                    btn_bilgi_gecmis.Enabled = true;

                    BildirimTuruCollection CollTur = new BildirimTuruCollection();
                    IPredicateExpression ExpTur = new PredicateExpression();
                    ExpTur.AddWithAnd(BildirimTuruFields.BildirimTuruId == CollBil[0].FkBildirimTuruId);
                    CollTur.GetMulti(ExpTur);

                    Session["saat"] = CollTur[0].BildirimTuruIncelemeSaatZaman;

                    DosyaCollection CollDos = new DosyaCollection();
                    IPredicateExpression ExpDos = new PredicateExpression();
                    ExpDos.AddWithAnd(DosyaFields.DosyaBildirimi == Convert.ToInt64(txtUserName.Text));
                    CollDos.GetMulti(ExpDos);

                    btn_dosyasi.Enabled = false;

                    if (CollDos.Count > 0)
                    {
                        Session["file_path_1"] = CollDos[0].DosyaIcerikPath;
                        btn_dosyasi.Enabled = true;
                    }

                    if (CollDos.Count > 1)
                    {
                        Session["file_path_2"] = CollDos[1].DosyaIcerikPath;
                        btn_dosyasi.Enabled = true;
                    }

                    if (CollDos.Count > 2)
                    {
                        Session["file_path_3"] = CollDos[2].DosyaIcerikPath;
                        btn_dosyasi.Enabled = true;
                    }

                    grid_bildirim_incele.Selection.UnselectAll();
                } 
            }

            catch 
            {

            }                      
        }

        protected void btn_dosyasi_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McDosyaDurumu.aspx', null, 'height=160,width=1000,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void btn_dosyasi2_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McDosyaDurumu.aspx', null, 'height=160,width=1000,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void btn_dosyasi3_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McDosyaDurumu.aspx', null, 'height=160,width=1000,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void grid_bildirim_kul_incele_ProcessColumnAutoFilter(object sender, EventArgs e)
        {
            grid_doldur_islem();
        }

        protected void grid_bildirim_kul_incele_PageIndexChanged(object sender, EventArgs e)
        {
            grid_doldur_islem();
        }

        protected void grid_bildirim_kul_incele_BeforeColumnSortingGrouping(object sender, EventArgs e)
        {
            grid_doldur_islem();
        }

        protected void grid_bildirim_kul_incele_CustomCollback(object sender, EventArgs e)
        {
            try
            {
                List<object> obj = grid_bildirim_kul_incele.GetSelectedFieldValues("BildirimId");

                txtUserNamekul.Text = obj.Count > 0 ? obj[0].ToString() : "-1";

                Session["bildirim_iceri"] = txtUserNamekul.Text;

                lbl_sec_ikinci.Text = txtUserNamekul.Text;

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserNamekul.Text));
                CollBil.GetMulti(ExpBil);

                if (CollBil.Count > 0)
                {
                    Session["vatandas_iceri"] = CollBil[0].FkVatandasId.ToString();

                    BildirimSonucCollection CollSon = new BildirimSonucCollection();
                    IPredicateExpression ExpSon = new PredicateExpression();
                    ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucId == CollBil[0].FkBildirimSonucId);
                    CollSon.GetMulti(ExpSon);

                    btn_bilgi_gecmis2.Enabled = true;

                    if (CollSon[0].BildirimSonucAd == "Atandı")
                    {
                        btn_not_ekle_kull.Enabled = true;
                        btn_yonlendir_kull.Enabled = true;
                        btn_ek_sure_kull.Enabled = false;
                        btn_sonuclandir_kull.Enabled = false;
                    }

                    else if (CollSon[0].BildirimSonucAd == "İnceleniyor")
                    {
                        btn_not_ekle_kull.Enabled = true;
                        btn_yonlendir_kull.Enabled = true;
                        btn_ek_sure_kull.Enabled = true;
                        btn_sonuclandir_kull.Enabled = true;
                    }

                    else if (CollSon[0].BildirimSonucAd == "İnceleniyor - Ek Süre")
                    {
                        btn_not_ekle_kull.Enabled = true;
                        btn_yonlendir_kull.Enabled = true;
                        btn_ek_sure_kull.Enabled = false;
                        btn_sonuclandir_kull.Enabled = true;
                    }

                    else
                    {
                        btn_not_ekle_kull.Enabled = true;
                        btn_yonlendir_kull.Enabled = false;
                        btn_ek_sure_kull.Enabled = false;
                    }

                    btn_bilgi_gecmis2.Enabled = true;

                    //cb_yon_kullanicikul.Items.Clear();

                    BildirimCollection CollBir = new BildirimCollection();
                    IPredicateExpression ExpBir = new PredicateExpression();
                    ExpBir.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserNamekul.Text));
                    CollBir.GetMulti(ExpBir);

                    KullaniciCollection CollKl = new KullaniciCollection();
                    IPredicateExpression ExpKl = new PredicateExpression();
                    ISortExpression sortkl = new SortExpression();
                    ExpKl.AddWithAnd(KullaniciFields.KullaniciId != Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                    sortkl.Add(new SortClause(KullaniciFields.KullaniciAdSoyad, SortOperator.Ascending));
                    CollKl.GetMulti(ExpKl, 0, sortkl);

                    /*for (int i = 0; i < CollKl.Count; i++)
                    {
                        cb_yon_kullanicikul.Items.Add(CollKl[i].KullaniciAdSoyad);
                    }*/

                    BildirimTuruCollection CollTur = new BildirimTuruCollection();
                    IPredicateExpression ExpTur = new PredicateExpression();
                    ExpTur.AddWithAnd(BildirimTuruFields.BildirimTuruId == CollBil[0].FkBildirimTuruId);
                    CollTur.GetMulti(ExpTur);

                    Session["saat"] = CollTur[0].BildirimTuruIncelemeSaatZaman;

                    double neresi = Convert.ToDouble(CollTur[0].BildirimTuruIncelemeSaatZaman) / 24.00;

                    DosyaCollection CollDos = new DosyaCollection();
                    IPredicateExpression ExpDos = new PredicateExpression();
                    ExpDos.AddWithAnd(DosyaFields.DosyaBildirimi == Convert.ToInt64(txtUserNamekul.Text));
                    CollDos.GetMulti(ExpDos);

                    btn_dosyasi2.Enabled = true;                   

                    grid_bildirim_kul_incele.Selection.UnselectAll();
                }
            }

            catch 
            {

            }            
        }

        protected void btn_incele_kull_Click(object sender, EventArgs e)
        {
            BildirimCollection CollBil = new BildirimCollection();
            IPredicateExpression ExpBil = new PredicateExpression();
            ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserNamekul.Text));
            CollBil.GetMulti(ExpBil);

            //KullaniciCollection CollKul = new KullaniciCollection();
            //IPredicateExpression ExpKul = new PredicateExpression();
            //ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            //CollKul.GetMulti(ExpKul);

            BildirimSonucCollection CollSon = new BildirimSonucCollection();
            IPredicateExpression ExpSon = new PredicateExpression();
            ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
            CollSon.GetMulti(ExpSon);

            CollBil[0].FkBildirimSonucId = CollSon[0].BildirimSonucId;
            CollBil[0].BildirimSonIslemTarih = DateTime.Now;
            CollBil[0].FkKullaniciId = AktifKullanici.KullaniciId;//Convert.ToInt16(Session["kullanici_var_mi"].ToString());
            CollBil[0].BildirimAtanmaDurumu = CollBil[0].BildirimAtanmaDurumu + " " + AktifKullanici.KullaniciAdSoyad + " tarafından incelemeye alındı.";
            CollBil[0].Save();

            BildirimIslemCollection CollIs = new BildirimIslemCollection();
            IPredicateExpression ExpIs = new PredicateExpression();
            ExpIs.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "İncelemeye Alındı");
            CollIs.GetMulti(ExpIs);

            BildirimHistoryEntity EntHis = new BildirimHistoryEntity();
            EntHis.FkBildirimId = CollBil[0].BildirimId;
            EntHis.FkBildirimIslemId = CollIs[0].BildirimIslemId;
            EntHis.FkKullaniciId = AktifKullanici.KullaniciId;//Convert.ToInt16(Session["kullanici_var_mi"].ToString());
            EntHis.BildirimHistoryTarih = DateTime.Now;
            EntHis.BildirimHistorySure = "0";

            BildirimTuruCollection CollTur = new BildirimTuruCollection();
            IPredicateExpression ExpTur = new PredicateExpression();
            ExpTur.AddWithAnd(BildirimTuruFields.BildirimTuruId == CollBil[0].FkBildirimTuruId);
            CollTur.GetMulti(ExpTur);

            /*string message = CollBil[0].BildirimId.ToString() + " numaralı bildirim tarafınızca incelemeye alındı. İnceleme süresi: " + CollTur[0].BildirimTuruInclemeSure;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());*/

            string CloseWindow;
            CloseWindow = "alert('Bildirim tarafınızca incelemeye alındı...')";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            
            btn_yonlendir_kull.Enabled = true;
            btn_ek_sure_kull.Enabled = true;
            btn_sonuclandir_kull.Enabled = true;

            BildirimAtamaKullaniciCollection CollAta = new BildirimAtamaKullaniciCollection();
            IPredicateExpression ExpAta = new PredicateExpression();
            ExpAta.AddWithAnd(BildirimAtamaKullaniciFields.FkBildirimId == CollBil[0].BildirimId);
            CollAta.GetMulti(ExpAta);

            for (int i = 0; i < CollAta.Count; i++)
            {
                if (CollAta[i].FkKullaniciId != AktifKullanici.KullaniciId)
                {
                    CollAta[i].BildirimAtamaKullaniciBittiMi = true;
                    CollAta[i].BildirimAtamaKullaniciBittiTarih = DateTime.Now;
                    CollAta[i].Save();
                }
            }            

            grid_doldur_yeni();
            grid_doldur_islem();
            grid_doldur_ek_sure();
            grid_doldur_full();
            baslangic_hesap();

            GecenSureEntity EntGec = new GecenSureEntity();
            EntGec.FkKullaniciId = AktifKullanici.KullaniciId;//Convert.ToInt16(Session["kullanici_var_mi"].ToString());
            EntGec.FkBildirimId = CollBil[0].BildirimId;
            EntGec.GecenSureAciklama = "Atama-İnceleme Kabul Süresi";
            EntGec.GecenSureTarih = DateTime.Now;

            TimeSpan fark_bak1 = DateTime.Now - CollBil[0].BildirimTarih;

            string duzle = (fark_bak1.TotalHours).ToString();

            double arasi = Convert.ToDouble(duzle);

            Int16 ana_fark = Convert.ToInt16(arasi);

            EntGec.GecenSureTotal = ana_fark;

            Int16 saat = 0;
            Int16 gun = 0;
            Int16 ay = 0;
            Int16 yil = 0;

            string fark_olustur = "";

            if (ana_fark > 8760)
            {
                double bul = ana_fark / 8760;

                yil = Convert.ToInt16(bul);

                fark_olustur = yil.ToString() + " Yıl";

                double arada = ((ana_fark % 8760) / 720);

                if (arada > 1)
                {
                    ay = Convert.ToInt16(arada);

                    fark_olustur = fark_olustur + ", " + ay.ToString() + " Ay";

                    double eks = (((ana_fark % 8760) % 720) / 24);

                    if (eks > 1)
                    {
                        gun = Convert.ToInt16(eks);

                        fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                        double eksson = (((ana_fark % 8760) % 720) % 24);

                        saat = Convert.ToInt16(eksson);

                        fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                    }

                    else
                    {
                        double eksson = (((ana_fark % 8760) % 720) % 24);

                        saat = Convert.ToInt16(eksson);

                        fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                    }
                }

                else
                {
                    double eks = (((ana_fark % 8760) % 720) / 24);

                    if (eks > 1)
                    {
                        gun = Convert.ToInt16(eks);

                        fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                        double eksson = (((ana_fark % 8760) % 720) % 24);

                        saat = Convert.ToInt16(eksson);

                        fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                    }

                    else
                    {
                        double eksson = (((ana_fark % 8760) % 720) % 24);

                        saat = Convert.ToInt16(eksson);

                        fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                    }
                }
            }

            else
            {
                if (ana_fark > 720)
                {
                    double bul = ana_fark / 720;

                    ay = Convert.ToInt16(bul);

                    fark_olustur = ay.ToString() + " Ay";

                    double eks = ((ana_fark % 720) / 24);

                    if (eks > 1)
                    {
                        gun = Convert.ToInt16(eks);

                        fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                        double eksson = ((ana_fark % 720) % 24);

                        saat = Convert.ToInt16(eksson);

                        fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                    }

                    else
                    {
                        double eksson = ((ana_fark % 720) % 24);

                        saat = Convert.ToInt16(eksson);

                        fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                    }
                }

                else
                {
                    if (ana_fark > 24)
                    {
                        double eksss = ((ana_fark % 720) / 24);

                        gun = Convert.ToInt16(eksss);

                        fark_olustur = gun.ToString() + " Gün";

                        double eksson = ((ana_fark % 720) % 24);

                        saat = Convert.ToInt16(eksson);

                        fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                    }

                    else
                    {
                        double eksson = ((ana_fark % 720) % 24);

                        saat = Convert.ToInt16(eksson);

                        if (saat == 0)
                        {
                            string duzle2 = (fark_bak1.TotalMinutes).ToString();
                            double arasi2 = Convert.ToDouble(duzle2);
                            Int16 ana_fark2 = Convert.ToInt16(arasi2);

                            fark_olustur = ana_fark2.ToString() + " Dakika";
                        }

                        else
                        {
                            fark_olustur = saat.ToString() + " Saat";
                        }
                    }
                }
            }

            EntGec.GecenSureZaman = fark_olustur;
            EntGec.Save();

            SureTakipEntity EntSure = new SureTakipEntity();
            EntSure.FkBildirimId = CollBil[0].BildirimId;
            EntSure.SureTakipTuru = "İncelemeye Alma Süresi";
            EntSure.SureTakipTarih = DateTime.Now;
            EntSure.SureTakipSaat = ana_fark;

            double arayaz = Convert.ToDouble(Convert.ToDouble(ana_fark) / 24);

            string ara_gelver = arayaz.ToString("0.##");
            arayaz = Convert.ToDouble(ara_gelver);

            EntSure.SureTakipGun = arayaz;
            EntSure.Save();

            EntHis.BildirimHistoryAciklama = AktifKullanici.KullaniciAdSoyad + " tarafından incelemeye alındı (" + fark_olustur + ").";
            EntHis.Save();
        }

        protected void btn_incele_Click(object sender, EventArgs e)
        {
            BildirimCollection CollBil = new BildirimCollection();
            IPredicateExpression ExpBil = new PredicateExpression();
            ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserName.Text));
            CollBil.GetMulti(ExpBil);

            //KullaniciCollection CollKul = new KullaniciCollection();
            //IPredicateExpression ExpKul = new PredicateExpression();
            //ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            //CollKul.GetMulti(ExpKul);

            BildirimSonucCollection CollSon = new BildirimSonucCollection();
            IPredicateExpression ExpSon = new PredicateExpression();
            ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
            CollSon.GetMulti(ExpSon);

            CollBil[0].FkBildirimSonucId = CollSon[0].BildirimSonucId;
            CollBil[0].BildirimSonIslemTarih = DateTime.Now;
            CollBil[0].FkKullaniciId = AktifKullanici.KullaniciId;//Convert.ToInt16(Session["kullanici_var_mi"].ToString());
            CollBil[0].BildirimAtanmaDurumu = CollBil[0].BildirimAtanmaDurumu + " " + AktifKullanici.KullaniciAdSoyad + " tarafından incelemeye alındı.";
            CollBil[0].Save();

            BildirimIslemCollection CollIs = new BildirimIslemCollection();
            IPredicateExpression ExpIs = new PredicateExpression();
            ExpIs.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "İncelemeye Alındı");
            CollIs.GetMulti(ExpIs);

            BildirimHistoryEntity EntHis = new BildirimHistoryEntity();
            EntHis.FkBildirimId = CollBil[0].BildirimId;
            EntHis.FkBildirimIslemId = CollIs[0].BildirimIslemId;
            EntHis.FkKullaniciId = AktifKullanici.KullaniciId;//Convert.ToInt16(Session["kullanici_var_mi"].ToString());
            EntHis.BildirimHistoryTarih = DateTime.Now;
            EntHis.BildirimHistorySure = "0";

            BildirimTuruCollection CollTur = new BildirimTuruCollection();
            IPredicateExpression ExpTur = new PredicateExpression();
            ExpTur.AddWithAnd(BildirimTuruFields.BildirimTuruId == CollBil[0].FkBildirimTuruId);
            CollTur.GetMulti(ExpTur);

            /*string message = CollBil[0].BildirimId.ToString() + " numaralı bildirim tarafınızca incelemeye alındı. İnceleme süresi: " + CollTur[0].BildirimTuruInclemeSure;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());*/

            string CloseWindow;
            CloseWindow = "alert('Bildirim tarafınızca incelemeye alındı...')";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

            btn_incele.Enabled = false;
            btn_bilgi_gecmis.Enabled = false;

            BildirimAtamaKullaniciCollection CollAta = new BildirimAtamaKullaniciCollection();
            IPredicateExpression ExpAta = new PredicateExpression();
            ExpAta.AddWithAnd(BildirimAtamaKullaniciFields.FkBildirimId == CollBil[0].BildirimId);
            CollAta.GetMulti(ExpAta);

            for (int i = 0; i < CollAta.Count; i++)
            {
                if (CollAta[i].FkKullaniciId != AktifKullanici.KullaniciId)
                {
                    CollAta[i].BildirimAtamaKullaniciBittiMi = true;
                    CollAta[i].BildirimAtamaKullaniciBittiTarih = DateTime.Now;
                    CollAta[i].Save();
                }
            }            

            grid_doldur_yeni();
            grid_doldur_islem();
            grid_doldur_ek_sure();
            grid_doldur_full();
            baslangic_hesap();

            GecenSureEntity EntGec = new GecenSureEntity();
            EntGec.FkKullaniciId = AktifKullanici.KullaniciId;//Convert.ToInt16(Session["kullanici_var_mi"].ToString());
            EntGec.FkBildirimId = CollBil[0].BildirimId;
            EntGec.GecenSureAciklama = "Atama-İnceleme Kabul Süresi";
            EntGec.GecenSureTarih = DateTime.Now;

            TimeSpan fark_bak1 = DateTime.Now - CollBil[0].BildirimTarih;

            string duzle = (fark_bak1.TotalHours).ToString();

            double arasi = Convert.ToDouble(duzle);

            Int16 ana_fark = Convert.ToInt16(arasi);

            EntGec.GecenSureTotal = ana_fark;

            Int16 saat = 0;
            Int16 gun = 0;
            Int16 ay = 0;
            Int16 yil = 0;

            string fark_olustur = "";

            if (ana_fark > 8760)
            {
                double bul = ana_fark / 8760;

                yil = Convert.ToInt16(bul);

                fark_olustur = yil.ToString() + " Yıl";

                double arada = ((ana_fark % 8760) / 720);

                if (arada > 1)
                {
                    ay = Convert.ToInt16(arada);

                    fark_olustur = fark_olustur + ", " + ay.ToString() + " Ay";

                    double eks = (((ana_fark % 8760) % 720) / 24);

                    if (eks > 1)
                    {
                        gun = Convert.ToInt16(eks);

                        fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                        double eksson = (((ana_fark % 8760) % 720) % 24);

                        saat = Convert.ToInt16(eksson);

                        fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                    }

                    else
                    {
                        double eksson = (((ana_fark % 8760) % 720) % 24);

                        saat = Convert.ToInt16(eksson);

                        fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                    }
                }

                else
                {
                    double eks = (((ana_fark % 8760) % 720) / 24);

                    if (eks > 1)
                    {
                        gun = Convert.ToInt16(eks);

                        fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                        double eksson = (((ana_fark % 8760) % 720) % 24);

                        saat = Convert.ToInt16(eksson);

                        fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                    }

                    else
                    {
                        double eksson = (((ana_fark % 8760) % 720) % 24);

                        saat = Convert.ToInt16(eksson);

                        fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                    }
                }
            }

            else
            {
                if (ana_fark > 720)
                {
                    double bul = ana_fark / 720;

                    ay = Convert.ToInt16(bul);

                    fark_olustur = ay.ToString() + " Ay";

                    double eks = ((ana_fark % 720) / 24);

                    if (eks > 1)
                    {
                        gun = Convert.ToInt16(eks);

                        fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                        double eksson = ((ana_fark % 720) % 24);

                        saat = Convert.ToInt16(eksson);

                        fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                    }

                    else
                    {
                        double eksson = ((ana_fark % 720) % 24);

                        saat = Convert.ToInt16(eksson);

                        fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                    }
                }

                else
                {
                    if (ana_fark > 24)
                    {
                        double eksss = ((ana_fark % 720) / 24);

                        gun = Convert.ToInt16(eksss);

                        fark_olustur = gun.ToString() + " Gün";

                        double eksson = ((ana_fark % 720) % 24);

                        saat = Convert.ToInt16(eksson);

                        fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                    }

                    else
                    {
                        double eksson = ((ana_fark % 720) % 24);

                        saat = Convert.ToInt16(eksson);

                        if (saat == 0)
                        {
                            string duzle2 = (fark_bak1.TotalMinutes).ToString();
                            double arasi2 = Convert.ToDouble(duzle2);
                            Int16 ana_fark2 = Convert.ToInt16(arasi2);

                            fark_olustur = ana_fark2.ToString() + " Dakika";
                        }

                        else
                        {
                            fark_olustur = saat.ToString() + " Saat";
                        }
                    }
                }
            }

            EntGec.GecenSureZaman = fark_olustur;
            EntGec.Save();

            SureTakipEntity EntSure = new SureTakipEntity();
            EntSure.FkBildirimId = CollBil[0].BildirimId;
            EntSure.SureTakipTuru = "İncelemeye Alma Süresi";
            EntSure.SureTakipTarih = DateTime.Now;
            EntSure.SureTakipSaat = ana_fark;

            double arayaz = Convert.ToDouble(Convert.ToDouble(ana_fark) / 24);

            string ara_gelver = arayaz.ToString("0.##");
            arayaz = Convert.ToDouble(ara_gelver);

            EntSure.SureTakipGun = arayaz;
            EntSure.Save();

            EntHis.BildirimHistoryAciklama = AktifKullanici.KullaniciAdSoyad + " tarafından incelemeye alındı (" + fark_olustur + ").";
            EntHis.Save();

            lbl_secilen.Text = "-";
        }

        protected void btn_onaylakul_Click(object sender, EventArgs e)
        {
            if (cb_gunkul.Text == "" && cb_saatkul.Text == "")
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen geçerli bir zaman türü seçiniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                pcEkSureKull.ShowOnPageLoad = false;

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserNamekul.Text));
                CollBil.GetMulti(ExpBil);

                BildirimTuruCollection CollTur = new BildirimTuruCollection();
                IPredicateExpression ExpTur = new PredicateExpression();
                ExpTur.AddWithAnd(BildirimTuruFields.BildirimTuruId == CollBil[0].FkBildirimTuruId);
                CollTur.GetMulti(ExpTur);

                Session["saat"] = CollTur[0].BildirimTuruIncelemeSaatZaman;

                double neresi = Convert.ToDouble(CollTur[0].BildirimTuruIncelemeSaatZaman) / 24.00;
                /*
                if (neresi > 0)
                {
                    for (int i = 0; i < neresi; i++)
                    {
                        cb_gunkul.Items.Add((i + 1).ToString());
                    }

                    for (int i = 0; i < 24; i++)
                    {
                        cb_saatkul.Items.Add((i + 1).ToString());
                    }
                }

                else
                {
                    for (int i = 0; i < CollTur[0].BildirimTuruIncelemeSaatZaman; i++)
                    {
                        cb_saatkul.Items.Add((i + 1).ToString());
                    }
                }*/
            }

            else
            {
                int aradag = 0;
                string sure_text = "";

                if (cb_gunkul.Text != "" && cb_saatkul.Text != "")
                {
                    sure_text = sure_text + cb_gunkul.Text + " Gün, " + cb_saatkul.Text + " Saat";

                    aradag = (Convert.ToInt16(cb_gunkul.Text) * 24) + Convert.ToInt16(cb_saatkul.Text);
                }

                else if (cb_gunkul.Text == "" && cb_saatkul.Text != "")
                {
                    sure_text = cb_saatkul.Text + " Saat";

                    aradag = Convert.ToInt16(cb_saatkul.Text);
                }

                else if (cb_gunkul.Text != "" && cb_saatkul.Text == "")
                {
                    sure_text = sure_text + cb_gunkul.Text + " Gün";

                    aradag = (Convert.ToInt16(cb_gunkul.Text) * 24);
                }

                if (aradag > Convert.ToInt16(Session["saat"].ToString()))
                {
                    string CloseWindow;
                    CloseWindow = "alert('Maksimum süre talep sınırı aşılmaktadır...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                    pcEkSureKull.ShowOnPageLoad = false;

                    BildirimCollection CollBil = new BildirimCollection();
                    IPredicateExpression ExpBil = new PredicateExpression();
                    ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserNamekul.Text));
                    CollBil.GetMulti(ExpBil);

                    BildirimTuruCollection CollTur = new BildirimTuruCollection();
                    IPredicateExpression ExpTur = new PredicateExpression();
                    ExpTur.AddWithAnd(BildirimTuruFields.BildirimTuruId == CollBil[0].FkBildirimTuruId);
                    CollTur.GetMulti(ExpTur);

                    Session["saat"] = CollTur[0].BildirimTuruIncelemeSaatZaman;

                    double neresi = Convert.ToDouble(CollTur[0].BildirimTuruIncelemeSaatZaman) / 24.00;
                    /*
                    if (neresi > 0)
                    {
                        for (int i = 0; i < neresi; i++)
                        {
                            cb_gunkul.Items.Add((i + 1).ToString());
                        }

                        for (int i = 0; i < 24; i++)
                        {
                            cb_saatkul.Items.Add((i + 1).ToString());
                        }
                    }

                    else
                    {
                        for (int i = 0; i < CollTur[0].BildirimTuruIncelemeSaatZaman; i++)
                        {
                            cb_saatkul.Items.Add((i + 1).ToString());
                        }
                    }*/
                }

                else
                {
                    BildirimCollection CollBil = new BildirimCollection();
                    IPredicateExpression ExpBil = new PredicateExpression();
                    ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserNamekul.Text));
                    CollBil.GetMulti(ExpBil);

                    //KullaniciCollection CollKul = new KullaniciCollection();
                    //IPredicateExpression ExpKul = new PredicateExpression();
                    //ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                    //CollKul.GetMulti(ExpKul);

                    BildirimSonucCollection CollSon = new BildirimSonucCollection();
                    IPredicateExpression ExpSon = new PredicateExpression();
                    ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
                    CollSon.GetMulti(ExpSon);

                    CollBil[0].FkBildirimSonucId = CollSon[0].BildirimSonucId;
                    CollBil[0].FkKullaniciId = AktifKullanici.KullaniciId;//Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    CollBil[0].BildirimAtanmaDurumu = CollBil[0].BildirimAtanmaDurumu + " " + AktifKullanici.KullaniciAdSoyad + " tarafından ek süre talep edildi.";
                    CollBil[0].Save();

                    BildirimIslemCollection CollIs = new BildirimIslemCollection();
                    IPredicateExpression ExpIs = new PredicateExpression();
                    ExpIs.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "İnceleme İçin Ek Süre  Talep Edildi");
                    CollIs.GetMulti(ExpIs);

                    BildirimHistoryEntity EntHis = new BildirimHistoryEntity();
                    EntHis.FkBildirimId = CollBil[0].BildirimId;
                    EntHis.FkBildirimIslemId = CollIs[0].BildirimIslemId;
                    EntHis.FkKullaniciId = AktifKullanici.KullaniciId;//Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntHis.BildirimHistoryTarih = DateTime.Now;
                    EntHis.BildirimHistorySure = "0";

                    EkSureEntity EntSu = new EkSureEntity();
                    EntSu.FkBildirimId = CollBil[0].BildirimId;
                    EntSu.FkKullaniciId = AktifKullanici.KullaniciId;

                    if (cb_gunkul.Text != "")
                    {
                        EntSu.EkSureGun = Convert.ToInt16(cb_gunkul.Text);
                    }

                    else
                    {
                        EntSu.EkSureGun = 0;
                    }

                    if (cb_saatkul.Text != "")
                    {
                        EntSu.EkSureSaat = Convert.ToInt16(cb_saatkul.Text);
                    }

                    else
                    {
                        EntSu.EkSureSaat = 0;
                    }

                    EntSu.EkSureTarih = DateTime.Now;
                    EntSu.EkSureTotal = Convert.ToInt16(aradag);
                    EntSu.Save();

                    btn_yonlendir_kull.Enabled = false;
                    btn_ek_sure_kull.Enabled = false;
                    btn_sonuclandir_kull.Enabled = true;
                    btn_bilgi_gecmis.Enabled = false;

                    /*string message = CollBil[0].BildirimId.ToString() + " numaralı bildirim incelemesi için tarafınızca ek süre talebinde bulunuldu. İnceleme süresi: " + sure_text;
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("<script type = 'text/javascript'>");
                    sb.Append("window.onload=function(){");
                    sb.Append("alert('");
                    sb.Append(message);
                    sb.Append("')};");
                    sb.Append("</script>");
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());*/

                    string CloseWindow;
                    CloseWindow = "alert('Bildirim incelemesi için ek süre talebinde bulundunuz...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);                    

                    grid_doldur_yeni();
                    grid_doldur_islem();
                    grid_doldur_ek_sure();
                    grid_doldur_full();
                    baslangic_hesap();

                    cb_gunkul.Text = "";
                    cb_saatkul.Text = "";

                    GecenSureCollection CollSur = new GecenSureCollection();
                    IPredicateExpression ExpSur = new PredicateExpression();
                    ExpSur.AddWithAnd(GecenSureFields.FkBildirimId == CollBil[0].BildirimId);
                    ExpSur.AddWithAnd(GecenSureFields.GecenSureAciklama == "Atama-İnceleme Kabul Süresi");
                    CollSur.GetMulti(ExpSur);

                    GecenSureEntity EntGec = new GecenSureEntity();
                    EntGec.FkKullaniciId = AktifKullanici.KullaniciId;//Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                    EntGec.FkBildirimId = CollBil[0].BildirimId;
                    EntGec.GecenSureAciklama = "İnceleme-İnceleme Ek Süre Talebi";
                    EntGec.GecenSureTarih = DateTime.Now;

                    TimeSpan fark_bak1 = DateTime.Now - CollSur[0].GecenSureTarih;

                    string duzle = (fark_bak1.TotalHours).ToString();

                    double arasi = Convert.ToDouble(duzle);

                    Int16 ana_fark = Convert.ToInt16(arasi);

                    EntGec.GecenSureTotal = ana_fark;

                    Int16 saat = 0;
                    Int16 gun = 0;
                    Int16 ay = 0;
                    Int16 yil = 0;

                    string fark_olustur = "";

                    if (ana_fark > 8760)
                    {
                        double bul = ana_fark / 8760;

                        yil = Convert.ToInt16(bul);

                        fark_olustur = yil.ToString() + " Yıl";

                        double arada = ((ana_fark % 8760) / 720);

                        if (arada > 1)
                        {
                            ay = Convert.ToInt16(arada);

                            fark_olustur = fark_olustur + ", " + ay.ToString() + " Ay";

                            double eks = (((ana_fark % 8760) % 720) / 24);

                            if (eks > 1)
                            {
                                gun = Convert.ToInt16(eks);

                                fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                                double eksson = (((ana_fark % 8760) % 720) % 24);

                                saat = Convert.ToInt16(eksson);

                                fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                            }

                            else
                            {
                                double eksson = (((ana_fark % 8760) % 720) % 24);

                                saat = Convert.ToInt16(eksson);

                                fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                            }
                        }

                        else
                        {
                            double eks = (((ana_fark % 8760) % 720) / 24);

                            if (eks > 1)
                            {
                                gun = Convert.ToInt16(eks);

                                fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                                double eksson = (((ana_fark % 8760) % 720) % 24);

                                saat = Convert.ToInt16(eksson);

                                fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                            }

                            else
                            {
                                double eksson = (((ana_fark % 8760) % 720) % 24);

                                saat = Convert.ToInt16(eksson);

                                fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                            }
                        }
                    }

                    else
                    {
                        if (ana_fark > 720)
                        {
                            double bul = ana_fark / 720;

                            ay = Convert.ToInt16(bul);

                            fark_olustur = ay.ToString() + " Ay";

                            double eks = ((ana_fark % 720) / 24);

                            if (eks > 1)
                            {
                                gun = Convert.ToInt16(eks);

                                fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                                double eksson = ((ana_fark % 720) % 24);

                                saat = Convert.ToInt16(eksson);

                                fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                            }

                            else
                            {
                                double eksson = ((ana_fark % 720) % 24);

                                saat = Convert.ToInt16(eksson);

                                fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                            }
                        }

                        else
                        {
                            if (ana_fark > 24)
                            {
                                double eksss = ((ana_fark % 720) / 24);

                                gun = Convert.ToInt16(eksss);

                                fark_olustur = gun.ToString() + " Gün";

                                double eksson = ((ana_fark % 720) % 24);

                                saat = Convert.ToInt16(eksson);

                                fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                            }

                            else
                            {
                                double eksson = ((ana_fark % 720) % 24);

                                saat = Convert.ToInt16(eksson);

                                if (saat == 0)
                                {
                                    string duzle2 = (fark_bak1.TotalMinutes).ToString();
                                    double arasi2 = Convert.ToDouble(duzle2);
                                    Int16 ana_fark2 = Convert.ToInt16(arasi2);

                                    fark_olustur = ana_fark2.ToString() + " Dakika";
                                }

                                else
                                {
                                    fark_olustur = saat.ToString() + " Saat";
                                }
                            }
                        }
                    }

                    EntGec.GecenSureZaman = fark_olustur;
                    EntGec.Save();

                    EntHis.BildirimHistoryAciklama = AktifKullanici.KullaniciAdSoyad + " tarafından inceleme için ek süre talep edildi (" + fark_olustur + ").";
                    EntHis.Save();

                    btn_bilgi_gecmis2.Enabled = false;
                    btn_not_ekle_kull.Enabled = false;
                    btn_yonlendir_kull.Enabled = false;
                    btn_ek_sure_kull.Enabled = false;
                    btn_sonuclandir_kull.Enabled = false;
                    lbl_sec_ikinci.Text = "-";

                    pcEkSureKull.ShowOnPageLoad = false;
                }
            }
        }       

        protected void btn_sonuc_okkul_Click(object sender, EventArgs e)
        {
            if (cb_sonuckul.Text == "" || txt_aciklamakul.Text == "")
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen Sonuç ve Açıklama bilgilerini kontrol ediniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                pcSonucKull.ShowOnPageLoad = false;
            }

            else
            {
                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserNamekul.Text));
                CollBil.GetMulti(ExpBil);

                //KullaniciCollection CollKul = new KullaniciCollection();
                //IPredicateExpression ExpKul = new PredicateExpression();
                //ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                //CollKul.GetMulti(ExpKul);

                BildirimSonucCollection CollSon = new BildirimSonucCollection();
                IPredicateExpression ExpSon = new PredicateExpression();
                ExpSon.AddWithAnd(BildirimSonucFields.BildirimSonucAd == cb_sonuckul.Text);
                CollSon.GetMulti(ExpSon);

                CollBil[0].FkBildirimSonucId = CollSon[0].BildirimSonucId;
                CollBil[0].BildirimSonIslemTarih = DateTime.Now;                

                if (cb_sonuckul.Text == "Sonuçlandı")
                {
                    CollBil[0].BildirimAtanmaDurumu = CollBil[0].BildirimAtanmaDurumu + " " + AktifKullanici.KullaniciAdSoyad + " tarafından sonuçlandı (" + txt_aciklamakul.Text + ").";
                }

                else
                {
                    CollBil[0].BildirimAtanmaDurumu = CollBil[0].BildirimAtanmaDurumu + " " + AktifKullanici.KullaniciAdSoyad + " tarafından reddedildi (" + txt_aciklamakul.Text + ").";
                }

                CollBil[0].BildirimKimBitirdi = AktifKullanici.KullaniciId;
                CollBil[0].BildirimVatandasKarar = txt_aciklamakul.Text;
                CollBil[0].Save();

                BildirimGeriDonuCollection CollDon = new BildirimGeriDonuCollection();
                IPredicateExpression ExpDon = new PredicateExpression();
                ExpDon.AddWithAnd(BildirimGeriDonuFields.BildirimGeriDonusId == CollBil[0].FkBildirimGeriDonusId);
                CollDon.GetMulti(ExpDon);

                if (CollDon[0].BildirimGeriDonusAd == "E-Posta") 
                {
                    VatandaCollection CollVat = new VatandaCollection();
                    IPredicateExpression ExpVat = new PredicateExpression();
                    ExpVat.AddWithAnd(VatandaFields.VatandasId == CollBil[0].FkVatandasId);
                    CollVat.GetMulti(ExpVat);

                    BildirimTuruCollection CollBilTur = new BildirimTuruCollection();
                    IPredicateExpression ExpBilTur = new PredicateExpression();
                    ExpBilTur.AddWithAnd(BildirimTuruFields.BildirimTuruId == CollBil[0].FkBildirimTuruId);
                    CollBilTur.GetMulti(ExpBilTur);

                    if (CollBilTur[0].BildirimTuruMail == true && CollVat[0].VatandasMail != "")
                    {
                        string konusu = "DHMİ İletişim Merkezi Bildirim Talebi Sonucu";
                        string maili = CollVat[0].VatandasMail;
                        string bil_git = CollBil[0].BildirimId.ToString();
                        string karar = CollBil[0].BildirimVatandasKarar;

                        if (CollVat[0].VatandasTur == "Gerçek Kişi (Yabancı)")
                        {
                            Mail.MailGonderBildirimSonucEng(maili, "General Directorate Of State Airports Authority (DHMI) Call Center", bil_git, karar);
                        }

                        else 
                        {
                            Mail.MailGonderBildirimSonuc(maili, konusu, bil_git, karar);
                        }                        
                    }                  
                }

                else if (CollDon[0].BildirimGeriDonusAd == "SMS")
                {
                    VatandaCollection CollVat = new VatandaCollection();
                    IPredicateExpression ExpVat = new PredicateExpression();
                    ExpVat.AddWithAnd(VatandaFields.VatandasId == CollBil[0].FkVatandasId);
                    CollVat.GetMulti(ExpVat);

                    BildirimTuruCollection CollBilTur = new BildirimTuruCollection();
                    IPredicateExpression ExpBilTur = new PredicateExpression();
                    ExpBilTur.AddWithAnd(BildirimTuruFields.BildirimTuruId == CollBil[0].FkBildirimTuruId);
                    CollBilTur.GetMulti(ExpBilTur);

                    if (CollBilTur[0].BildirimTuruSms == true && CollVat[0].VatandasTel1 != "")
                    {
                        try
                        {
                            string gsmNo = CollVat[0].VatandasTel1;
                            gsmNo = gsmNo.TrimStart('0');
                            string tarih = CollBil[0].BildirimTarih.ToShortDateString();
                            Int32 bildirim_nosu = Convert.ToInt32(CollBil[0].BildirimId.ToString());

                            if (CollVat[0].VatandasTur == "Gerçek Kişi (Yabancı)")
                            {
                                string smsMessage = string.Format(ConfigurationManager.AppSettings["SmsEndRecordContentEng"], tarih, bildirim_nosu);
                                Helper.SendSms(gsmNo, smsMessage, bildirim_nosu);
                            }

                            else 
                            {
                                string smsMessage = string.Format(ConfigurationManager.AppSettings["SmsEndRecordContent"], tarih, bildirim_nosu);
                                Helper.SendSms(gsmNo, smsMessage, bildirim_nosu);
                            }                            
                        }

                        catch
                        {
                            
                        }
                    }
                }

                TimeSpan fark_bak1 = CollBil[0].BildirimSonIslemTarih - CollBil[0].BildirimTarih;

                string duzle = (fark_bak1.TotalHours).ToString();

                double arasi = Convert.ToDouble(duzle);

                Int16 ana_fark = Convert.ToInt16(arasi);
                Int16 saat = 0;
                Int16 gun = 0;
                Int16 ay = 0;
                Int16 yil = 0;

                string fark_olustur = "";

                if (ana_fark > 8760)
                {
                    double bul = ana_fark / 8760;

                    yil = Convert.ToInt16(bul);

                    fark_olustur = yil.ToString() + " Yıl";

                    double arada = ((ana_fark % 8760) / 720);

                    if (arada > 1)
                    {
                        ay = Convert.ToInt16(arada);

                        fark_olustur = fark_olustur + ", " + ay.ToString() + " Ay";

                        double eks = (((ana_fark % 8760) % 720) / 24);

                        if (eks > 1)
                        {
                            gun = Convert.ToInt16(eks);

                            fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                            double eksson = (((ana_fark % 8760) % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }

                        else
                        {
                            double eksson = (((ana_fark % 8760) % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }
                    }

                    else
                    {
                        double eks = (((ana_fark % 8760) % 720) / 24);

                        if (eks > 1)
                        {
                            gun = Convert.ToInt16(eks);

                            fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                            double eksson = (((ana_fark % 8760) % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }

                        else
                        {
                            double eksson = (((ana_fark % 8760) % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }
                    }
                }

                else
                {
                    if (ana_fark > 720)
                    {
                        double bul = ana_fark / 720;

                        ay = Convert.ToInt16(bul);

                        fark_olustur = ay.ToString() + " Ay";

                        double eks = ((ana_fark % 720) / 24);

                        if (eks > 1)
                        {
                            gun = Convert.ToInt16(eks);

                            fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                            double eksson = ((ana_fark % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }

                        else
                        {
                            double eksson = ((ana_fark % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }
                    }

                    else
                    {
                        if (ana_fark > 24)
                        {
                            double eksss = ((ana_fark % 720) / 24);

                            gun = Convert.ToInt16(eksss);

                            fark_olustur = gun.ToString() + " Gün";

                            double eksson = ((ana_fark % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }

                        else
                        {
                            double eksson = ((ana_fark % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            if (saat == 0)
                            {
                                string duzle2 = (fark_bak1.TotalMinutes).ToString();
                                double arasi2 = Convert.ToDouble(duzle2);
                                Int16 ana_fark2 = Convert.ToInt16(arasi2);

                                fark_olustur = ana_fark2.ToString() + " Dakika";
                            }

                            else
                            {
                                fark_olustur = saat.ToString() + " Saat";
                            }
                        }
                    }
                }

                BildirimIslemCollection CollIs = new BildirimIslemCollection();
                IPredicateExpression ExpIs = new PredicateExpression();
                ExpIs.AddWithAnd(BildirimIslemFields.BildirimIslemAd == cb_sonuckul.Text);
                CollIs.GetMulti(ExpIs);

                BildirimHistoryEntity EntHis = new BildirimHistoryEntity();
                EntHis.FkBildirimId = CollBil[0].BildirimId;
                EntHis.FkBildirimIslemId = CollIs[0].BildirimIslemId;
                EntHis.FkKullaniciId = AktifKullanici.KullaniciId;//Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                EntHis.BildirimHistoryTarih = DateTime.Now;
                EntHis.BildirimHistorySure = "0";

                string CloseWindow;
                CloseWindow = "alert('Bildirim tarafınızca sonlandırıldı...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                /*string message = CollBil[0].BildirimId.ToString() + " numaralı bildirim tarafınızca " + cb_sonuc.Text.ToUpper() +".";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());*/

                CollBil[0].BildirimToplamSure = fark_olustur;
                CollBil[0].Save();

                BildirimAtamaKullaniciCollection CollHap = new BildirimAtamaKullaniciCollection();
                IPredicateExpression ExpHap = new PredicateExpression();
                ExpHap.AddWithAnd(BildirimAtamaKullaniciFields.FkBildirimId == CollBil[0].BildirimId);
                ExpHap.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == AktifKullanici.KullaniciId);//CollKul[0].KullaniciId);
                CollHap.GetMulti(ExpHap);

                CollHap[0].BildirimAtamaKullaniciBittiMi = true;
                CollHap[0].BildirimAtamaKullaniciBittiTarih = DateTime.Now;
                CollHap[0].Save();

                GecenSureCollection CollSur = new GecenSureCollection();
                IPredicateExpression ExpSur = new PredicateExpression();
                ExpSur.AddWithAnd(GecenSureFields.FkBildirimId == CollBil[0].BildirimId);
                ExpSur.AddWithAnd(GecenSureFields.GecenSureAciklama == "Atama-İnceleme Kabul Süresi");
                CollSur.GetMulti(ExpSur);

                GecenSureCollection CollSur2 = new GecenSureCollection();
                IPredicateExpression ExpSur2 = new PredicateExpression();
                ExpSur2.AddWithAnd(GecenSureFields.FkBildirimId == CollBil[0].BildirimId);
                ExpSur2.AddWithAnd(GecenSureFields.GecenSureAciklama == "İnceleme-İnceleme Ek Süre Talebi");
                CollSur2.GetMulti(ExpSur2);

                GecenSureEntity EntGec = new GecenSureEntity();
                EntGec.FkKullaniciId = AktifKullanici.KullaniciId;//Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                EntGec.FkBildirimId = CollBil[0].BildirimId;
                EntGec.GecenSureTarih = DateTime.Now;

                if (CollSur2.Count > 0)
                {
                    fark_bak1 = DateTime.Now - CollSur2[0].GecenSureTarih;
                    EntGec.GecenSureAciklama = "İnceleme Ek Süre-Kapanış";
                }

                else
                {
                    fark_bak1 = DateTime.Now - CollSur[0].GecenSureTarih;
                    EntGec.GecenSureAciklama = "İnceleme-Kapanış";
                }

                duzle = (fark_bak1.TotalHours).ToString();

                arasi = Convert.ToDouble(duzle);

                ana_fark = Convert.ToInt16(arasi);

                EntGec.GecenSureTotal = ana_fark;

                btn_bilgi_gecmis2.Enabled = false;
                btn_not_ekle_kull.Enabled = false;
                btn_yonlendir_kull.Enabled = false;
                btn_ek_sure_kull.Enabled = false;
                btn_sonuclandir_kull.Enabled = false;
                lbl_sec_ikinci.Text = "-";

                saat = 0;
                gun = 0;
                ay = 0;
                yil = 0;

                fark_olustur = "";

                if (ana_fark > 8760)
                {
                    double bul = ana_fark / 8760;

                    yil = Convert.ToInt16(bul);

                    fark_olustur = yil.ToString() + " Yıl";

                    double arada = ((ana_fark % 8760) / 720);

                    if (arada > 1)
                    {
                        ay = Convert.ToInt16(arada);

                        fark_olustur = fark_olustur + ", " + ay.ToString() + " Ay";

                        double eks = (((ana_fark % 8760) % 720) / 24);

                        if (eks > 1)
                        {
                            gun = Convert.ToInt16(eks);

                            fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                            double eksson = (((ana_fark % 8760) % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }

                        else
                        {
                            double eksson = (((ana_fark % 8760) % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }
                    }

                    else
                    {
                        double eks = (((ana_fark % 8760) % 720) / 24);

                        if (eks > 1)
                        {
                            gun = Convert.ToInt16(eks);

                            fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                            double eksson = (((ana_fark % 8760) % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }

                        else
                        {
                            double eksson = (((ana_fark % 8760) % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }
                    }
                }

                else
                {
                    if (ana_fark > 720)
                    {
                        double bul = ana_fark / 720;

                        ay = Convert.ToInt16(bul);

                        fark_olustur = ay.ToString() + " Ay";

                        double eks = ((ana_fark % 720) / 24);

                        if (eks > 1)
                        {
                            gun = Convert.ToInt16(eks);

                            fark_olustur = fark_olustur + ", " + gun.ToString() + " Gün";

                            double eksson = ((ana_fark % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }

                        else
                        {
                            double eksson = ((ana_fark % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }
                    }

                    else
                    {
                        if (ana_fark > 24)
                        {
                            double eksss = ((ana_fark % 720) / 24);

                            gun = Convert.ToInt16(eksss);

                            fark_olustur = gun.ToString() + " Gün";

                            double eksson = ((ana_fark % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            fark_olustur = fark_olustur + ", " + saat.ToString() + " Saat";
                        }

                        else
                        {
                            double eksson = ((ana_fark % 720) % 24);

                            saat = Convert.ToInt16(eksson);

                            if (saat == 0)
                            {
                                string duzle2 = (fark_bak1.TotalMinutes).ToString();
                                double arasi2 = Convert.ToDouble(duzle2);
                                Int16 ana_fark2 = Convert.ToInt16(arasi2);

                                fark_olustur = ana_fark2.ToString() + " Dakika";
                            }

                            else
                            {
                                fark_olustur = saat.ToString() + " Saat";
                            }
                        }
                    }
                }

                EntGec.GecenSureZaman = fark_olustur;
                EntGec.Save();

                SureTakipEntity EntSure = new SureTakipEntity();
                EntSure.FkBildirimId = CollBil[0].BildirimId;
                EntSure.SureTakipTuru = "İncelenme Süresi";
                EntSure.SureTakipTarih = DateTime.Now;
                EntSure.SureTakipSaat = ana_fark;

                double arayaz = Convert.ToDouble(Convert.ToDouble(ana_fark) / 24);

                string ara_gelver = arayaz.ToString("0.##");
                arayaz = Convert.ToDouble(ara_gelver);

                EntSure.SureTakipGun = arayaz;
                EntSure.Save();

                if (cb_sonuckul.Text == "Sonuçlandı")
                {
                    EntHis.BildirimHistoryAciklama = AktifKullanici.KullaniciAdSoyad + " tarafından sonuçlandı (" + txt_aciklamakul.Text + ") (" + fark_olustur + ").";
                }

                else
                {
                    EntHis.BildirimHistoryAciklama = AktifKullanici.KullaniciAdSoyad + " tarafından reddedildi (" + txt_aciklamakul.Text + ") (" + fark_olustur + ").";
                }

                EntHis.Save();                

                grid_doldur_yeni();
                grid_doldur_islem();
                grid_doldur_ek_sure();
                grid_doldur_full();
                baslangic_hesap();

                pcSonucKull.ShowOnPageLoad = false;
            }
        }             

        //yon_geldi
        protected void btn_yon_okkul_Click(object sender, EventArgs e)
        {
            if (cb_yon_kullanicikul.Text == "" && cb_yon_grupkul.Text == "")
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen geçerli bir grup/kullanıcı seçiniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else if (cb_yon_kullanicikul.Text == "----------" && cb_yon_grupkul.Text == "----------")
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen geçerli bir grup/kullanıcı seçiniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else if (cb_yon_kullanicikul.Text != "----------" && cb_yon_grupkul.Text != "----------" && cb_yon_kullanicikul.Text != "" && cb_yon_grupkul.Text != "")
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen grup ya da kullanıcı seçimlerinden bir tanesini seçiniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else
            {
                BildirimSonucCollection CollSonda = new BildirimSonucCollection();
                IPredicateExpression ExpSonda = new PredicateExpression();
                ExpSonda.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
                CollSonda.GetMulti(ExpSonda);

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserNamekul.Text));
                CollBil.GetMulti(ExpBil);

                string kul_toplam = "";
                int ayya = 1;

                if (cb_yon_kullanicikul.Text != "" && cb_yon_kullanicikul.Text != "----------")
                {
                    KullaniciCollection CollKul = new KullaniciCollection();
                    IPredicateExpression ExpKul = new PredicateExpression();
                    ExpKul.AddWithAnd(KullaniciFields.KullaniciAdSoyad == cb_yon_kullanicikul.Text);
                    CollKul.GetMulti(ExpKul);

                    BildirimAtamaKullaniciCollection CollBek = new BildirimAtamaKullaniciCollection();
                    IPredicateExpression ExpBek = new PredicateExpression();
                    ExpBek.AddWithAnd(BildirimAtamaKullaniciFields.FkBildirimId == CollBil[0].BildirimId);
                    ExpBek.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciYonMu == "Hayır");
                    //ExpBek.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == AktifKullanici.KullaniciId);//Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                    CollBek.GetMulti(ExpBek);

                    for (int i = 0; i < CollBek.Count; i++)
                    {
                        CollBek[i].BildirimAtamaKullaniciYonMu = "Evet";
                        CollBek[i].BildirimAtamaKullaniciBittiMi = true;
                        CollBek[i].Save();
                    }

                    BildirimAtamaKullaniciEntity EntKay = new BildirimAtamaKullaniciEntity();
                    EntKay.FkBildirimId = CollBil[0].BildirimId;
                    EntKay.FkKullaniciId = CollKul[0].KullaniciId;
                    EntKay.BildirimAtamaKullaniciBittiMi = false;
                    EntKay.BildirimAtamaKullaniciTarih = DateTime.Now;
                    EntKay.BildirimAtamaKullaniciYonMu = "Hayır";
                    EntKay.Save();

                    CollBil[0].FkBildirimSonucId = CollSonda[0].BildirimSonucId;
                    CollBil[0].Save();

                    try
                    {
                        if (CollKul[0].KullaniciMail != "" && CollKul[0].KullaniciMail != null)
                        {
                            string konusu = "DHMİ İletişim Merkezi Bildirim Talebi";
                            string maili = CollKul[0].KullaniciMail;
                            string bsl = "www.alo.dhmi.gov.tr/McCallCenterLinkControlAsLogin.aspx?";
                            string bas_coz = "dhmi";
                            string bit_coz = "callcenter";
                            string dhmi_bas = Kullanici.sifre_olustur(bas_coz);
                            string dhmi_bit = Kullanici.sifre_olustur(bit_coz);
                            string aradaki_kul = CollKul[0].KullaniciId.ToString();
                            aradaki_kul = Kullanici.sifre_olustur(aradaki_kul);
                            string linki = dhmi_bas + aradaki_kul + dhmi_bit;

                            string kayit_link = bsl + linki;

                            Mail.MailLinkGonder(CollBil[0].BildirimId.ToString(), linki, maili, konusu, CollBil[0].BildirimMetin);

                            MailBankEntity EntBan = new MailBankEntity();
                            EntBan.MailBanksLink = kayit_link;
                            EntBan.MailBanksBildirim = CollBil[0].BildirimId;
                            EntBan.MailBanksKullanici = CollKul[0].KullaniciId;
                            EntBan.MailBanksTikAdet = 0;
                            EntBan.MailBanksTarih = DateTime.Now;
                            EntBan.MailBanksDurum = true;
                            EntBan.Save();
                        }
                    }

                    catch
                    {
                        //Mail Adresinde Sorun Varsa Direkt Geç...
                    }

                    kul_toplam = cb_yon_kullanicikul.Text;
                }

                if (cb_yon_grupkul.Text != "" && cb_yon_grupkul.Text != "----------")
                {
                    ayya = ayya + 1;

                    GrupCollection CollGrsi = new GrupCollection();
                    IPredicateExpression ExpGrsi = new PredicateExpression();
                    ExpGrsi.AddWithAnd(GrupFields.GrupAd == cb_yon_grupkul.Text);
                    CollGrsi.GetMulti(ExpGrsi);

                    GrupAtamaCollection CollAta = new GrupAtamaCollection();
                    IPredicateExpression ExpAta = new PredicateExpression();
                    ExpAta.AddWithAnd(GrupAtamaFields.FkGrupId == CollGrsi[0].GrupId);
                    CollAta.GetMulti(ExpAta);

                    BildirimAtamaKullaniciCollection CollBul2 = new BildirimAtamaKullaniciCollection();
                    IPredicateExpression ExpBul2 = new PredicateExpression();
                    ExpBul2.AddWithAnd(BildirimAtamaKullaniciFields.FkBildirimId == CollBil[0].BildirimId);
                    ExpBul2.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciYonMu == "Hayır");
                    CollBul2.GetMulti(ExpBul2);

                    for (int j = 0; j < CollBul2.Count; j++)
                    {
                        CollBul2[j].BildirimAtamaKullaniciBittiMi = true;
                        CollBul2[j].BildirimAtamaKullaniciYonMu = "Evet";
                        CollBul2[j].Save();
                    }

                    for (int i = 0; i < CollAta.Count; i++)
                    {
                        BildirimAtamaKullaniciCollection CollBul = new BildirimAtamaKullaniciCollection();
                        IPredicateExpression ExpBul = new PredicateExpression();
                        ExpBul.AddWithAnd(BildirimAtamaKullaniciFields.FkBildirimId == CollBil[0].BildirimId);
                        ExpBul.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciYonMu == "Hayır");
                        CollBul.GetMulti(ExpBul);

                        KullaniciCollection CollKat = new KullaniciCollection();
                        IPredicateExpression ExpKat = new PredicateExpression();
                        ExpKat.AddWithAnd(KullaniciFields.KullaniciId == CollAta[i].FkKullaniciId);
                        CollKat.GetMulti(ExpKat);

                        BildirimAtamaKullaniciEntity EntKay = new BildirimAtamaKullaniciEntity();
                        EntKay.FkBildirimId = CollBil[0].BildirimId;
                        EntKay.FkKullaniciId = CollKat[0].KullaniciId;
                        EntKay.BildirimAtamaKullaniciBittiMi = false;
                        EntKay.BildirimAtamaKullaniciTarih = DateTime.Now;
                        EntKay.BildirimAtamaKullaniciYonMu = "Hayır";
                        EntKay.Save();

                        kul_toplam = kul_toplam + ", " + CollKat[0].KullaniciAdSoyad;

                        string konusu = "DHMİ İletişim Merkezi Bildirim Talebi";
                        string maili = CollKat[0].KullaniciMail;
                        string bsl = "www.alo.dhmi.gov.tr/McCallCenterLinkControlAsLogin.aspx?";
                        string bas_coz = "dhmi";
                        string bit_coz = "callcenter";
                        string dhmi_bas = Kullanici.sifre_olustur(bas_coz);
                        string dhmi_bit = Kullanici.sifre_olustur(bit_coz);
                        string aradaki_kul = CollKat[0].KullaniciId.ToString();
                        aradaki_kul = Kullanici.sifre_olustur(aradaki_kul);
                        string linki = dhmi_bas + aradaki_kul + dhmi_bit;

                        string kayit_link = bsl + linki;

                        Mail.MailLinkGonder(CollBil[0].BildirimId.ToString(), linki, maili, konusu, CollBil[0].BildirimMetin);

                        MailBankEntity EntBan = new MailBankEntity();
                        EntBan.MailBanksLink = kayit_link;
                        EntBan.MailBanksBildirim = CollBil[0].BildirimId;
                        EntBan.MailBanksKullanici = CollKat[0].KullaniciId;
                        EntBan.MailBanksTikAdet = 0;
                        EntBan.MailBanksTarih = DateTime.Now;
                        EntBan.MailBanksDurum = true;
                        EntBan.Save();
                    }

                    BildirimAtamaGrupEntity EntGy = new BildirimAtamaGrupEntity();
                    EntGy.FkGrupId = CollGrsi[0].GrupId;
                    EntGy.FkBildirimId = CollBil[0].BildirimId;
                    EntGy.BildirimAtamaGrupTarih = DateTime.Now;
                    EntGy.BildirimAtamaGrupYonMu = "Hayır";
                    EntGy.Save();

                    CollBil[0].FkBildirimSonucId = CollSonda[0].BildirimSonucId;
                    CollBil[0].Save();
                }

                string CloseWindow;

                if (ayya == 1)
                {
                    CloseWindow = "alert('Bildirim kullanıcıya yönlendirilmiştir...')";
                }

                else
                {
                    CloseWindow = "alert('Bildirim gruba yönlendirilmiştir...')";
                }

                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                BildirimIslemCollection CollIs = new BildirimIslemCollection();
                IPredicateExpression ExpIs = new PredicateExpression();
                ExpIs.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "Yönlendirildi");
                CollIs.GetMulti(ExpIs);

                BildirimHistoryEntity EntHis = new BildirimHistoryEntity();
                EntHis.FkBildirimId = CollBil[0].BildirimId;
                EntHis.FkBildirimIslemId = CollIs[0].BildirimIslemId;
                EntHis.FkKullaniciId = AktifKullanici.KullaniciId;//Convert.ToInt16(Session["kullanici_var_mi"].ToString());
                EntHis.BildirimHistoryTarih = DateTime.Now;
                EntHis.BildirimHistorySure = "0";

                string eskisi = CollBil[0].BildirimAciklama;
                CollBil[0].BildirimAciklama = eskisi + AktifKullanici.KullaniciAdSoyad + " - '" + txt_gerekcesi.Text + "'.";

                if (ayya == 1)
                {
                    EntHis.BildirimHistoryAciklama = AktifKullanici.KullaniciAdSoyad + " tarafından bildirim " + cb_yon_kullanicikul.Text + " adlı kullanıcıya yönlendirildi.";
                    CollBil[0].BildirimAtanmaDurumu = CollBil[0].BildirimAtanmaDurumu + " " + AktifKullanici.KullaniciAdSoyad + " tarafından bildirim " + cb_yon_kullanicikul.Text + " adlı kullanıcıya yönlendirildi.";
                }

                else
                {
                    EntHis.BildirimHistoryAciklama = AktifKullanici.KullaniciAdSoyad + " tarafından bildirim " + cb_yon_grupkul.Text + " adlı gruba yönlendirildi.";
                    CollBil[0].BildirimAtanmaDurumu = CollBil[0].BildirimAtanmaDurumu + " " + AktifKullanici.KullaniciAdSoyad + " tarafından bildirim " + cb_yon_grupkul.Text + " adlı gruba yönlendirildi.";
                }

                CollBil[0].Save();

                EntHis.Save();

                cb_yon_grupkul.Text = "";
                cb_yon_kullanicikul.Text = "";

                btn_bilgi_gecmis2.Enabled = false;
                btn_not_ekle_kull.Enabled = false;
                btn_yonlendir_kull.Enabled = false;
                btn_ek_sure_kull.Enabled = false;
                btn_sonuclandir_kull.Enabled = false;
                lbl_sec_ikinci.Text = "-";                

                grid_doldur_yeni();
                grid_doldur_islem();
                grid_doldur_ek_sure();
                grid_doldur_full();
                baslangic_hesap();
            }

            pcYonKull.ShowOnPageLoad = false;

            lbl_sec_ikinci.Text = "-";
        }

        protected void lbl_atanmis_Click(object sender, EventArgs e)
        {
            if (lbl_atanmis.Text == "0")
            {
                string CloseWindow;
                CloseWindow = "alert('Bildirim bulunmamaktadır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else
            {
                MultiView1.ActiveViewIndex = 1;

                string hexValue2 = "#C0D9E7";
                Menu1.Items[1].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);

                string hexValue = "#FFFFFF";
                Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);

                grid_doldur_yeni();
            }
        }

        protected void lbl_incelenen_Click(object sender, EventArgs e)
        {
            if (lbl_incelenen.Text == "0")
            {
                string CloseWindow;
                CloseWindow = "alert('Bildirim bulunmamaktadır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else
            {
                MultiView1.ActiveViewIndex = 2;

                string hexValue2 = "#C0D9E7";
                Menu1.Items[2].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);

                string hexValue = "#FFFFFF";
                Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);

                grid_doldur_islem();
            }
        }

        protected void lbl_ek_sureli_Click(object sender, EventArgs e)
        {
            if (lbl_kapatilan.Text == "0")
            {
                string CloseWindow;
                CloseWindow = "alert('Bildirim bulunmamaktadır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else
            {
                MultiView1.ActiveViewIndex = 3;

                string hexValue2 = "#C0D9E7";
                Menu1.Items[3].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);

                string hexValue = "#FFFFFF";
                Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);

                grid_doldur_ek_sure();
            }
        }

        protected void lbl_sayi_ben_Click(object sender, EventArgs e)
        {
            if (lbl_sayi_ben.Text == "0")
            {
                string CloseWindow;
                CloseWindow = "alert('Bildirim bulunmamaktadır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else
            {
                MultiView1.ActiveViewIndex = 4;

                string hexValue2 = "#C0D9E7";
                Menu1.Items[4].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);

                string hexValue = "#FFFFFF";
                Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);

                grid_doldur_full();
            }
        }

        protected void btn_not_ekle_Click(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            baslangic_hesap();

            grid_doldur_f5();
        }

        protected void btn_bilgi_bankasi_sonda_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McYrBilgiBankasiIslemleri.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void btn_bilgi_bankasi_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McYrBilgiBankasiIslemleri.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void btn_bilgi_bankasi_kull_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McYrBilgiBankasiIslemleri.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void btn_bilgi_gecmis_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McCagriGenisOzet.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void btn_bilgi_gecmis2_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McCagriGenisOzet.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }              

        protected void btn_bilgi_gecmis4_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McCagriGenisOzet.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void btn_not_ekle_sonda_Click(object sender, EventArgs e)
        {
            if (txt_bg_son.Text == "")
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen geçerli bir not giriniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                pcNotSon.ShowOnPageLoad = false;
            }

            else
            {
                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(Session["bildirim_iceri"].ToString()));
                CollBil.GetMulti(ExpBil);

                //KullaniciCollection CollKul = new KullaniciCollection();
                //IPredicateExpression ExpKul = new PredicateExpression();
                //ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                //CollKul.GetMulti(ExpKul);

                string eskisi = CollBil[0].BildirimAciklama;

                CollBil[0].BildirimAciklama = eskisi + AktifKullanici.KullaniciAdSoyad + " - '" + txt_bg_son.Text + "'.";
                CollBil[0].Save();

                string CloseWindow;
                CloseWindow = "alert('Notunuz ilgili bildirime eklenmiştir...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                txt_bg_son.Text = "";                

                grid_doldur_yeni();
                grid_doldur_islem();
                grid_doldur_ek_sure();
                grid_doldur_full();
                baslangic_hesap();

                pcNotSon.ShowOnPageLoad = false;
            }
        }

        protected void btn_not_ekle_ustunekul_Click(object sender, EventArgs e)
        {
            if (txt_bgkul.Text == "")
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen geçerli bir not giriniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                pcNotKull.ShowOnPageLoad = false;
            }

            else
            {
                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(Session["bildirim_iceri"].ToString()));
                CollBil.GetMulti(ExpBil);

                //KullaniciCollection CollKul = new KullaniciCollection();
                //IPredicateExpression ExpKul = new PredicateExpression();
                //ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                //CollKul.GetMulti(ExpKul);

                string eskisi = CollBil[0].BildirimAciklama;

                CollBil[0].BildirimAciklama = eskisi + AktifKullanici.KullaniciAdSoyad + " - '" + txt_bgkul.Text + "'.";
                CollBil[0].Save();

                string CloseWindow;
                CloseWindow = "alert('Notunuz ilgili bildirime eklenmiştir...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                txt_bgkul.Text = "";
            }

            btn_bilgi_gecmis2.Enabled = false;
            btn_not_ekle_kull.Enabled = false;
            btn_yonlendir_kull.Enabled = false;
            btn_ek_sure_kull.Enabled = false;
            btn_sonuclandir_kull.Enabled = false;
            lbl_sec_ikinci.Text = "-";            

            grid_doldur_yeni();
            grid_doldur_islem();
            grid_doldur_ek_sure();
            grid_doldur_full();
            baslangic_hesap();

            pcNotKull.ShowOnPageLoad = false;
        }       

        protected void grid_bildirim_kul_incele_HtmlRowPrepared(object sender, ASPxGridViewTableRowEventArgs e)
        {
            if (e.RowType != GridViewRowType.Data)
                return;
            
            try
            {
                if (Session["say_bak2"].ToString() == "0")
                {
                    grid_doldur_islem();
                }

                string hexValueaaa = "#F6B433";
                string hexpem = "#EE97F8";

                if ((string)e.GetValue("BildirimSonucAd") == "Atandı")
                {
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValueaaa);
                }

                if ((string)e.GetValue("BildirimSonucAd") == "İnceleniyor")
                {
                    e.Row.BackColor = Color.LightBlue;
                }

                if ((string)e.GetValue("BildirimSonucAd") == "İnceleniyor - Ek Süre")
                {
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hexpem);
                }

                Int32 say = Convert.ToInt32(Session["say_bak2"].ToString());
                say = say + 1;
                Session["say_bak2"] = say.ToString();
            }

            catch { }            
        }

        protected void grid_bildirim_incele_HtmlRowPrepared(object sender, ASPxGridViewTableRowEventArgs e)
        {
            if (e.RowType != GridViewRowType.Data)
                return;

            try
            {
                if (Session["say_bak"].ToString() == "0")
                {
                    grid_doldur_yeni();
                }

                string hexValueaaa = "#F6B433";
                string hexpem = "#EE97F8";

                if ((string)e.GetValue("BildirimSonucAd") == "Atandı")
                {
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValueaaa);
                }

                if ((string)e.GetValue("BildirimSonucAd") == "İnceleniyor")
                {
                    e.Row.BackColor = Color.LightBlue;
                }

                if ((string)e.GetValue("BildirimSonucAd") == "İnceleniyor - Ek Süre")
                {
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hexpem);
                }

                Int32 say = Convert.ToInt32(Session["say_bak"].ToString());
                say = say + 1;
                Session["say_bak"] = say.ToString();
            }

            catch { }
        }

        protected void grid_bildirim_yon_incele_HtmlRowPrepared(object sender, ASPxGridViewTableRowEventArgs e)
        {
            if (e.RowType != GridViewRowType.Data)
                return;

            try
            {
                if (Session["say_bak3"].ToString() == "0")
                {
                    grid_doldur_ek_sure();
                }

                string hexValue = "#F33622";
                if ((string)e.GetValue("BildirimSonucAd") == "Reddedildi")
                {
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                }

                if ((string)e.GetValue("BildirimSonucAd") == "Sonuçlandı")
                {
                    e.Row.BackColor = Color.LightGray;
                }

                Int32 say = Convert.ToInt32(Session["say_bak3"].ToString());
                say = say + 1;
                Session["say_bak3"] = say.ToString();
            }
            catch { } 
        }

        protected void grid_bildirim_HtmlRowPrepared(object sender, ASPxGridViewTableRowEventArgs e)
        {
            if (e.RowType != GridViewRowType.Data)
                return;

            try
            {
                if (Session["say_bak4"].ToString() == "0")
                {
                    grid_doldur_full();
                }

                string hexValue = "#F33622";
                string hexValueaaa = "#FBD264";
                string hexpem = "#EE97F8";

                if ((string)e.GetValue("BildirimSonucAd") == "Atandı")
                {
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValueaaa);
                }

                if ((string)e.GetValue("BildirimSonucAd") == "İnceleniyor")
                {
                    e.Row.BackColor = Color.LightBlue;
                }

                if ((string)e.GetValue("BildirimSonucAd") == "İnceleniyor - Ek Süre")
                {
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hexpem);
                }

                if ((string)e.GetValue("BildirimSonucAd") == "Reddedildi")
                {
                    e.Row.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                }

                if ((string)e.GetValue("BildirimSonucAd") == "Sonuçlandı")
                {
                    e.Row.BackColor = Color.LightGray;
                }

                Int32 say = Convert.ToInt32(Session["say_bak4"].ToString());
                say = say + 1;
                Session["say_bak4"] = say.ToString();
            }
            catch { }         
        }

        void grid_doldur_yeni()
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

            grid_bildirim_incele.DataSource = bil_list3;
            grid_bildirim_incele.DataBind();

            if (Session["yetki_durum"].ToString() == "Evet")
            {
                grid_bildirim_incele.Columns[8].Visible = true;
                grid_bildirim_incele.Columns[9].Visible = true;
            }

            else
            {
                grid_bildirim_incele.Columns[8].Visible = false;
                grid_bildirim_incele.Columns[9].Visible = false;
            }

            KullaniciCollection CollKim = new KullaniciCollection();
            IPredicateExpression ExpKim = new PredicateExpression();
            ExpKim.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKim.GetMulti(ExpKim);

            GrupCollection CollGr = new GrupCollection();
            IPredicateExpression ExpGr = new PredicateExpression();
            ExpGr.AddWithAnd(GrupFields.GrupAd == "Hukuk Müşavirliği");
            CollGr.GetMulti(ExpGr);

            GrupAtamaCollection CollAta = new GrupAtamaCollection();
            IPredicateExpression ExpAta = new PredicateExpression();
            ExpAta.AddWithAnd(GrupAtamaFields.FkGrupId == CollGr[0].GrupId);
            ExpAta.AddWithAnd(GrupAtamaFields.FkKullaniciId == CollKim[0].KullaniciId);
            CollAta.GetMulti(ExpAta);

            if (CollAta.Count > 0)
            {
                grid_bildirim_incele.Columns[14].Visible = true;
                grid_bildirim_incele.Columns[15].Visible = true;
                grid_bildirim_incele.Columns[16].Visible = true;
                grid_bildirim_incele.Columns[17].Visible = true;
            }

            else 
            {
                grid_bildirim_incele.Columns[14].Visible = false;
                grid_bildirim_incele.Columns[15].Visible = false;
                grid_bildirim_incele.Columns[16].Visible = false;
                grid_bildirim_incele.Columns[17].Visible = false;
            }

            Session["atanmis"] = grid_bildirim_incele.VisibleRowCount.ToString();
        }

        void grid_doldur_islem() 
        {            
            ListTakipTypedList bil_list4 = new ListTakipTypedList();
            ISortExpression sortbil4 = new SortExpression();
            sortbil4.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filterbil4 = new PredicateExpression();
            filterbil4.AddWithAnd(BildirimSonucFields.BildirimSonucAd != "Kayıt Altına Alındı");
            filterbil4.AddWithAnd(BildirimSonucFields.BildirimSonucAd != "Reddedildi");
            filterbil4.AddWithAnd(BildirimSonucFields.BildirimSonucAd != "Sonuçlandı");
            filterbil4.AddWithAnd(BildirimSonucFields.BildirimSonucAd != "Atandı");
            filterbil4.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == AktifKullanici.KullaniciId);//Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            filterbil4.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciBittiMi == false);
            filterbil4.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciYonMu == "Hayır");            
            bil_list4.Fill(0, sortbil4, true, filterbil4);

            grid_bildirim_kul_incele.DataSource = bil_list4;
            grid_bildirim_kul_incele.DataBind();

            if (Session["yetki_durum"].ToString() == "Evet")
            {
                grid_bildirim_kul_incele.Columns[8].Visible = true;
                grid_bildirim_kul_incele.Columns[9].Visible = true;
            }

            else
            {
                grid_bildirim_kul_incele.Columns[8].Visible = false;
                grid_bildirim_kul_incele.Columns[9].Visible = false;
            }

            KullaniciCollection CollKim = new KullaniciCollection();
            IPredicateExpression ExpKim = new PredicateExpression();
            ExpKim.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKim.GetMulti(ExpKim);

            GrupCollection CollGr = new GrupCollection();
            IPredicateExpression ExpGr = new PredicateExpression();
            ExpGr.AddWithAnd(GrupFields.GrupAd == "Hukuk Müşavirliği");
            CollGr.GetMulti(ExpGr);

            GrupAtamaCollection CollAta = new GrupAtamaCollection();
            IPredicateExpression ExpAta = new PredicateExpression();
            ExpAta.AddWithAnd(GrupAtamaFields.FkGrupId == CollGr[0].GrupId);
            ExpAta.AddWithAnd(GrupAtamaFields.FkKullaniciId == CollKim[0].KullaniciId);
            CollAta.GetMulti(ExpAta);

            if (CollAta.Count > 0)
            {
                grid_bildirim_kul_incele.Columns[14].Visible = true;
                grid_bildirim_kul_incele.Columns[15].Visible = true;
                grid_bildirim_kul_incele.Columns[16].Visible = true;
                grid_bildirim_kul_incele.Columns[17].Visible = true;
            }

            else 
            {
                grid_bildirim_kul_incele.Columns[14].Visible = false;
                grid_bildirim_kul_incele.Columns[15].Visible = false;
                grid_bildirim_kul_incele.Columns[16].Visible = false;
                grid_bildirim_kul_incele.Columns[17].Visible = false;
            }

            Session["incelenen"] = grid_bildirim_kul_incele.VisibleRowCount.ToString();
        }

        protected void grid_bildirim_incele_BeforeColumnSortingGrouping(object sender, EventArgs e)
        {
            grid_doldur_yeni();
        }

        protected void grid_bildirim_BeforeColumnSortingGrouping(object sender, ASPxGridViewBeforeColumnGroupingSortingEventArgs e)
        {
            grid_doldur_full();
        }

        void grid_doldur_ek_sure() 
        {
            try 
            {
                ParametreCollection CollPrm = new ParametreCollection();
                IPredicateExpression ExpPrm = new PredicateExpression();
                ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
                CollPrm.GetMulti(ExpPrm);

                DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

                if (Session["sorgula_2"] == null)
                {
                    string[] strBildirimSonuc = { "Reddedildi", "Kapatıldı" };
                    ListTakipTypedList bil_list5 = new ListTakipTypedList();
                    ISortExpression sortbil5 = new SortExpression();
                    sortbil5.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filterbil5 = new PredicateExpression();
                    filterbil5.AddWithAnd(BildirimFields.BildirimKimBitirdi == AktifKullanici.KullaniciId);
                    filterbil5.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciYonMu == "Hayır");
                    filterbil5.AddWithAnd(BildirimFields.BildirimSonIslemTarih >= zaman);
                    bil_list5.Fill(0, sortbil5, true, filterbil5);

                    grid_bildirim_yon_incele.DataSource = bil_list5.GroupBy(q => q.BildirimId).Select(group => group.First());
                    grid_bildirim_yon_incele.DataBind();
                }

                else
                {
                    string[] strBildirimSonuc = { "Reddedildi", "Kapatıldı" };
                    ListTakipTypedList bil_list5 = new ListTakipTypedList();
                    ISortExpression sortbil5 = new SortExpression();
                    sortbil5.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filterbil5 = new PredicateExpression();
                    filterbil5.AddWithAnd(BildirimFields.BildirimKimBitirdi == AktifKullanici.KullaniciId);
                    filterbil5.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciYonMu == "Hayır");
                    filterbil5.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi_2.Text));
                    filterbil5.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi_2.Text));
                    bil_list5.Fill(0, sortbil5, true, filterbil5);

                    grid_bildirim_yon_incele.DataSource = bil_list5.GroupBy(q => q.BildirimId).Select(group => group.First());
                    grid_bildirim_yon_incele.DataBind();
                }

                if (Session["yetki_durum"].ToString() == "Evet")
                {
                    grid_bildirim_yon_incele.Columns[8].Visible = true;
                    grid_bildirim_yon_incele.Columns[9].Visible = true;
                }

                else
                {
                    grid_bildirim_yon_incele.Columns[8].Visible = false;
                    grid_bildirim_yon_incele.Columns[9].Visible = false;
                }

                KullaniciCollection CollKim = new KullaniciCollection();
                IPredicateExpression ExpKim = new PredicateExpression();
                ExpKim.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollKim.GetMulti(ExpKim);

                GrupCollection CollGr = new GrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(GrupFields.GrupAd == "Hukuk Müşavirliği");
                CollGr.GetMulti(ExpGr);

                GrupAtamaCollection CollAta = new GrupAtamaCollection();
                IPredicateExpression ExpAta = new PredicateExpression();
                ExpAta.AddWithAnd(GrupAtamaFields.FkGrupId == CollGr[0].GrupId);
                ExpAta.AddWithAnd(GrupAtamaFields.FkKullaniciId == CollKim[0].KullaniciId);
                CollAta.GetMulti(ExpAta);

                if (CollAta.Count > 0)
                {
                    grid_bildirim_yon_incele.Columns[14].Visible = true;
                    grid_bildirim_yon_incele.Columns[15].Visible = true;
                    grid_bildirim_yon_incele.Columns[16].Visible = true;
                    grid_bildirim_yon_incele.Columns[17].Visible = true;
                }

                else
                {
                    grid_bildirim_yon_incele.Columns[14].Visible = false;
                    grid_bildirim_yon_incele.Columns[15].Visible = false;
                    grid_bildirim_yon_incele.Columns[16].Visible = false;
                    grid_bildirim_yon_incele.Columns[17].Visible = false;
                }

                Session["islem"] = grid_bildirim_yon_incele.VisibleRowCount.ToString();
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen tarih aralıklarını kontrol ediniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }            
        }

        void grid_doldur_full() 
        {
            try 
            {
                ParametreCollection CollPrm = new ParametreCollection();
                IPredicateExpression ExpPrm = new PredicateExpression();
                ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
                CollPrm.GetMulti(ExpPrm);

                DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

                if (Session["sorgula_ana"] == null)
                {
                    ListTakipTypedList bil_list2 = new ListTakipTypedList();
                    ISortExpression sortbil2 = new SortExpression();
                    sortbil2.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filterbil2 = new PredicateExpression();
                    filterbil2.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == AktifKullanici.KullaniciId);//Convert.ToInt16(Session["kullanici_var_mi"].ToString()));        
                    filterbil2.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciYonMu == "Hayır");
                    filterbil2.AddWithAnd(BildirimFields.BildirimSonIslemTarih >= zaman);
                    bil_list2.Fill(0, sortbil2, true, filterbil2);

                    grid_bildirim.DataSource = bil_list2;
                    grid_bildirim.DataBind();
                }

                else
                {
                    ListTakipTypedList bil_list2 = new ListTakipTypedList();
                    ISortExpression sortbil2 = new SortExpression();
                    sortbil2.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filterbil2 = new PredicateExpression();
                    filterbil2.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == AktifKullanici.KullaniciId);//Convert.ToInt16(Session["kullanici_var_mi"].ToString()));        
                    filterbil2.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciYonMu == "Hayır");
                    filterbil2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                    filterbil2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
                    bil_list2.Fill(0, sortbil2, true, filterbil2);

                    grid_bildirim.DataSource = bil_list2;
                    grid_bildirim.DataBind();
                }

                if (Session["yetki_durum"].ToString() == "Evet")
                {
                    grid_bildirim.Columns[8].Visible = true;
                    grid_bildirim.Columns[9].Visible = true;
                }

                else
                {
                    grid_bildirim.Columns[8].Visible = false;
                    grid_bildirim.Columns[9].Visible = false;
                }

                KullaniciCollection CollKim = new KullaniciCollection();
                IPredicateExpression ExpKim = new PredicateExpression();
                ExpKim.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollKim.GetMulti(ExpKim);

                GrupCollection CollGr = new GrupCollection();
                IPredicateExpression ExpGr = new PredicateExpression();
                ExpGr.AddWithAnd(GrupFields.GrupAd == "Hukuk Müşavirliği");
                CollGr.GetMulti(ExpGr);

                GrupAtamaCollection CollAta = new GrupAtamaCollection();
                IPredicateExpression ExpAta = new PredicateExpression();
                ExpAta.AddWithAnd(GrupAtamaFields.FkGrupId == CollGr[0].GrupId);
                ExpAta.AddWithAnd(GrupAtamaFields.FkKullaniciId == CollKim[0].KullaniciId);
                CollAta.GetMulti(ExpAta);

                if (CollAta.Count > 0)
                {
                    grid_bildirim.Columns[14].Visible = true;
                    grid_bildirim.Columns[15].Visible = true;
                    grid_bildirim.Columns[16].Visible = true;
                    grid_bildirim.Columns[17].Visible = true;
                }

                else
                {
                    grid_bildirim.Columns[14].Visible = false;
                    grid_bildirim.Columns[15].Visible = false;
                    grid_bildirim.Columns[16].Visible = false;
                    grid_bildirim.Columns[17].Visible = false;
                }

                Session["toplam"] = grid_bildirim.VisibleRowCount.ToString();
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen tarih aralıklarını kontrol ediniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }            
        }        

        void baslangic_hesap()
        {/*
            int atandi = 0;
            int incele = 0;
            int bitti = 0;
    
            BildirimAtamaKullaniciCollection CollBasla = new BildirimAtamaKullaniciCollection();
            IPredicateExpression ExpBasla = new PredicateExpression();
            ExpBasla.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollBasla.GetMulti(ExpBasla);

            BildirimSonucCollection CollB1 = new BildirimSonucCollection();
            IPredicateExpression ExpB1 = new PredicateExpression();
            ExpB1.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
            CollB1.GetMulti(ExpB1);

            BildirimSonucCollection CollB2 = new BildirimSonucCollection();
            IPredicateExpression ExpB2 = new PredicateExpression();
            ExpB2.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor");
            CollB2.GetMulti(ExpB2);

            BildirimSonucCollection CollB3 = new BildirimSonucCollection();
            IPredicateExpression ExpB3 = new PredicateExpression();
            ExpB3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "İnceleniyor - Ek Süre");
            CollB3.GetMulti(ExpB3);

            BildirimSonucCollection CollB4 = new BildirimSonucCollection();
            IPredicateExpression ExpB4 = new PredicateExpression();
            ExpB4.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Reddedildi");
            CollB4.GetMulti(ExpB4);

            BildirimSonucCollection CollB5 = new BildirimSonucCollection();
            IPredicateExpression ExpB5 = new PredicateExpression();
            ExpB5.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Sonuçlandı");
            CollB5.GetMulti(ExpB5);
           
            for (int i = 0; i < CollBasla.Count; i++)
            {
                BildirimCollection CollAfa = new BildirimCollection();
                IPredicateExpression ExpAfa = new PredicateExpression();
                ExpAfa.AddWithAnd(BildirimFields.BildirimId == CollBasla[i].FkBildirimId);
                CollAfa.GetMulti(ExpAfa);         

                if (CollAfa.Count > 0)
                {
                    if (CollAfa[0].FkBildirimSonucId == CollB1[0].BildirimSonucId)
                    {
                        if (CollBasla[i].BildirimAtamaKullaniciYonMu == "Hayır" && CollBasla[i].BildirimAtamaKullaniciBittiMi == false)
                        {
                            atandi = atandi + 1;
                        }
                    }

                    else if (CollAfa[0].FkBildirimSonucId == CollB2[0].BildirimSonucId)
                    {
                        if (CollBasla[i].BildirimAtamaKullaniciBittiMi == false)
                        {
                            incele = incele + 1;
                        }
                    }

                    else if (CollAfa[0].FkBildirimSonucId == CollB3[0].BildirimSonucId)
                    {
                        if (CollBasla[i].BildirimAtamaKullaniciBittiMi == false)
                        {
                            incele = incele + 1;
                        }
                    }

                    else if (CollAfa[0].FkBildirimSonucId == CollB4[0].BildirimSonucId)
                    {
                        BildirimAtamaKullaniciCollection CollSah = new BildirimAtamaKullaniciCollection();
                        IPredicateExpression ExpSah = new PredicateExpression();
                        ISortExpression sortsah = new SortExpression();
                        sortsah.Add(new SortClause(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciTarih, SortOperator.Descending));
                        ExpSah.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == AktifKullanici.KullaniciId);//Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                        ExpSah.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciBittiMi == true);
                        ExpSah.AddWithAnd(BildirimAtamaKullaniciFields.FkBildirimId == CollAfa[0].BildirimId);
                        CollSah.GetMulti(ExpSah, 0, sortsah);

                        if (CollSah.Count > 0)
                        {
                            if (CollSah[0].FkKullaniciId == AktifKullanici.KullaniciId)//Convert.ToInt16(Session["kullanici_var_mi"].ToString()))
                            {
                                bitti = bitti + 1;
                            }
                        }
                    }

                    else if (CollAfa[0].FkBildirimSonucId == CollB5[0].BildirimSonucId)
                    {
                        BildirimAtamaKullaniciCollection CollSah = new BildirimAtamaKullaniciCollection();
                        IPredicateExpression ExpSah = new PredicateExpression();
                        ISortExpression sortsah = new SortExpression();
                        sortsah.Add(new SortClause(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciTarih, SortOperator.Descending));
                        ExpSah.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == AktifKullanici.KullaniciId);//Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                        ExpSah.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciBittiMi == true);
                        ExpSah.AddWithAnd(BildirimAtamaKullaniciFields.FkBildirimId == CollAfa[0].BildirimId);
                        CollSah.GetMulti(ExpSah, 0, sortsah);

                        if (CollSah.Count > 0)
                        {
                            if (CollSah[0].FkKullaniciId == AktifKullanici.KullaniciId) //Convert.ToInt16(Session["kullanici_var_mi"].ToString()))
                            {
                                bitti = bitti + 1;
                            }
                        }
                    }
                }
            }*/

            lbl_atanmis.Text = Session["atanmis"].ToString();
            lbl_incelenen.Text = Session["incelenen"].ToString();
            lbl_kapatilan.Text = Session["islem"].ToString();
            lbl_sayi_ben.Text = Session["toplam"].ToString();
        }

        void grid_doldur_f5()
        {
            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            ListTakipTypedList bil_list3 = new ListTakipTypedList();
            ISortExpression sortbil3 = new SortExpression();
            sortbil3.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filterbil3 = new PredicateExpression();
            filterbil3.AddWithAnd(BildirimSonucFields.BildirimSonucAd == "Atandı");
            filterbil3.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == AktifKullanici.KullaniciId);//Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            filterbil3.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciYonMu == "Hayır");
            filterbil3.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciBittiMi == false);
            filterbil3.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
            bil_list3.Fill(0, sortbil3, true, filterbil3);

            grid_bildirim_incele.DataSource = bil_list3;
            grid_bildirim_incele.DataBind();

            if (Session["yetki_durum"].ToString() == "Evet")
            {
                grid_bildirim_incele.Columns[8].Visible = true;
                grid_bildirim_incele.Columns[9].Visible = true;
            }

            else
            {
                grid_bildirim_incele.Columns[8].Visible = false;
                grid_bildirim_incele.Columns[9].Visible = false;
            }
        }

        protected void Menu1_MenuItemClick(object sender, MenuItemEventArgs e)
        {
            int index = 0;

            string hexValue = "#FFFFFF";
            string hexValue2 = "#C0D9E7";

            if (e.Item.ToString() == "İşlem Özeti")
            {
                index = 0;
                grid_doldur_f5();

                Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                Menu1.Items[1].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                Menu1.Items[2].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                Menu1.Items[3].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                Menu1.Items[4].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
            }

            else if (e.Item.ToString() == "Yeni Bildirimler")
            {
                index = 1;
                grid_doldur_yeni();

                Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                Menu1.Items[1].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                Menu1.Items[2].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                Menu1.Items[3].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                Menu1.Items[4].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
            }

            else if (e.Item.ToString() == "Üzerimdeki Bildirimler")
            {
                index = 2;
                grid_doldur_islem();

                Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                Menu1.Items[1].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                Menu1.Items[2].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                Menu1.Items[3].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                Menu1.Items[4].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
            }

            else if (e.Item.ToString() == "İşlem Yaptığım Bildirimler")
            {
                index = 3;
                grid_doldur_ek_sure();

                Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                Menu1.Items[1].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                Menu1.Items[2].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                Menu1.Items[3].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                Menu1.Items[4].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
            }

            else if (e.Item.ToString() == "Kayıt Listele - Raporla")
            {
                index = 4;
                grid_doldur_full();

                Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                Menu1.Items[1].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                Menu1.Items[2].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                Menu1.Items[3].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                Menu1.Items[4].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
            }

            MultiView1.ActiveViewIndex = index;
        }

        protected void btn_sorgula_Click(object sender, EventArgs e)
        {
            try
            {                
                DateTime zaman1 = Convert.ToDateTime(txt_bas_tarihi.Text);
                DateTime zaman2 = Convert.ToDateTime(txt_bit_tarihi.Text);

                ListTakipTypedList bil_list2 = new ListTakipTypedList();
                ISortExpression sortbil2 = new SortExpression();
                sortbil2.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filterbil2 = new PredicateExpression();
                filterbil2.AddWithAnd(BildirimAtamaKullaniciFields.FkKullaniciId == AktifKullanici.KullaniciId);
                filterbil2.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciYonMu == "Hayır");
                filterbil2.AddWithAnd(BildirimFields.BildirimTarih > zaman1);
                filterbil2.AddWithAnd(BildirimFields.BildirimTarih < zaman2);
                bil_list2.Fill(0, sortbil2, true, filterbil2);

                grid_bildirim.DataSource = bil_list2;
                grid_bildirim.DataBind();

                Session["sorgula_ana"] = "1";
            }

            catch 
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen tarih aralıklarını kontrol ediniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }            
        }

        protected void btn_sorgula_2_Click(object sender, EventArgs e)
        {
            try 
            {                
                DateTime zaman1 = Convert.ToDateTime(txt_bas_tarihi_2.Text);
                DateTime zaman2 = Convert.ToDateTime(txt_bit_tarihi_2.Text);

                string[] strBildirimSonuc = { "Reddedildi", "Kapatıldı" };
                ListTakipTypedList bil_list5 = new ListTakipTypedList();
                ISortExpression sortbil5 = new SortExpression();
                sortbil5.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filterbil5 = new PredicateExpression();
                filterbil5.AddWithAnd(BildirimFields.BildirimKimBitirdi == AktifKullanici.KullaniciId);
                filterbil5.AddWithAnd(BildirimAtamaKullaniciFields.BildirimAtamaKullaniciYonMu == "Hayır");
                filterbil5.AddWithAnd(BildirimFields.BildirimTarih > zaman1);
                filterbil5.AddWithAnd(BildirimFields.BildirimTarih < zaman2);
                bil_list5.Fill(0, sortbil5, true, filterbil5);

                grid_bildirim_yon_incele.DataSource = bil_list5.GroupBy(q => q.BildirimId).Select(group => group.First());
                grid_bildirim_yon_incele.DataBind();

                Session["sorgula_2"] = "1";
            }

            catch
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen tarih aralıklarını kontrol ediniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }            
        }
    }    
}