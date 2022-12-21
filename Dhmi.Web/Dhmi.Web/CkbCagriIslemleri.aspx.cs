using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using dhmi.EntityClasses;
using dhmi.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.HelperClasses;
using dhmi.TypedListClasses;
using DevExpress.Web.ASPxGridView;
using DevExpress.Data;
using DevExpress.Web.ASPxMenu;

namespace Dhmi.Web
{
    public partial class CkbCagriIslemleri : System.Web.UI.Page
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

            YetkiCollection CollYets = new YetkiCollection();
            IPredicateExpression ExpYets = new PredicateExpression();
            ExpYets.AddWithAnd(YetkiFields.YetkiId == AktifKullanici.FkYetkiId);
            CollYets.GetMulti(ExpYets);

            Session["yetki_durum"] = CollYets[0].YetkiAciklama;

            if (IsPostBack != true)
            {
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

                txt_bas_tarihi.Text = gun + "." + ay + "." + yil;
                txt_bit_tarihi.Text = gun + "." + ay + "." + yil;

                txt_bas_tarihi_2.Text = gun + "." + ay + "." + yil;
                txt_bit_tarihi_2.Text = gun + "." + ay + "." + yil;

                ParametreCollection CollParam = new ParametreCollection();
                IPredicateExpression ExpParam = new PredicateExpression();
                ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
                ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollParam.GetMulti(ExpParam);

                grid_gecmis.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
                grid_sonuc.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

                KullaniciCollection CollKul = new KullaniciCollection();
                IPredicateExpression ExpKul = new PredicateExpression();
                ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollKul.GetMulti(ExpKul);

                ParametreCollection CollPrm = new ParametreCollection();
                IPredicateExpression ExpPrm = new PredicateExpression();
                ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
                CollPrm.GetMulti(ExpPrm);

                DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

                if (Session["sorgula_ana"] == null)
                {
                    ListBildirimTypedList bil_list = new ListBildirimTypedList();
                    ISortExpression sort22 = new SortExpression();
                    sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filter2 = new PredicateExpression();
                    filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                    bil_list.Fill(0, sort22, true, filter2);

                    grid_gecmis.DataSource = bil_list;
                    grid_gecmis.DataBind();
                }

                else 
                {
                    ListBildirimTypedList bil_list = new ListBildirimTypedList();
                    ISortExpression sort22 = new SortExpression();
                    sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filter2 = new PredicateExpression();
                    filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                    filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
                    bil_list.Fill(0, sort22, true, filter2);

                    grid_gecmis.DataSource = bil_list;
                    grid_gecmis.DataBind();
                }

                if (Session["yetki_durum"].ToString() == "Evet")
                {                    
                    grid_gecmis.Columns[8].Visible = true;
                    grid_gecmis.Columns[9].Visible = true;
                    grid_gecmis.Columns[10].Visible = true;
                    grid_gecmis.Columns[11].Visible = true;
                    grid_gecmis.Columns[12].Visible = true;
                }

                else 
                {                    
                    grid_gecmis.Columns[8].Visible = false;
                    grid_gecmis.Columns[9].Visible = false;
                    grid_gecmis.Columns[10].Visible = false;
                    grid_gecmis.Columns[11].Visible = false;
                    grid_gecmis.Columns[12].Visible = false;
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
                    grid_gecmis.Columns[19].Visible = true;
                    grid_gecmis.Columns[20].Visible = true;
                    grid_gecmis.Columns[21].Visible = true;
                    grid_gecmis.Columns[22].Visible = true;
                }

                else 
                {
                    grid_gecmis.Columns[19].Visible = false;
                    grid_gecmis.Columns[20].Visible = false;
                    grid_gecmis.Columns[21].Visible = false;
                    grid_gecmis.Columns[22].Visible = false;
                }

                if (Session["sorgula_2"] == null)
                {
                    ListBildirimTypedList uc_list = new ListBildirimTypedList();
                    ISortExpression sortuc = new SortExpression();
                    sortuc.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filteruc = new PredicateExpression();
                    filteruc.AddWithAnd(BildirimFields.BildirimVatandasKarar != "");
                    filteruc.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                    uc_list.Fill(0, sortuc, true, filteruc);

                    grid_sonuc.DataSource = uc_list;
                    grid_sonuc.DataBind();
                }

                else 
                {
                    ListBildirimTypedList uc_list = new ListBildirimTypedList();
                    ISortExpression sortuc = new SortExpression();
                    sortuc.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filteruc = new PredicateExpression();
                    filteruc.AddWithAnd(BildirimFields.BildirimVatandasKarar != "");
                    filteruc.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi_2.Text));
                    filteruc.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi_2.Text));
                    uc_list.Fill(0, sortuc, true, filteruc);

                    grid_sonuc.DataSource = uc_list;
                    grid_sonuc.DataBind();
                }                

                if (Session["yetki_durum"].ToString() == "Evet")
                {
                    grid_sonuc.Columns[8].Visible = true;
                    grid_sonuc.Columns[9].Visible = true;
                    grid_sonuc.Columns[10].Visible = true;
                    grid_sonuc.Columns[11].Visible = true;
                    grid_sonuc.Columns[12].Visible = true;
                }

                else
                {
                    grid_sonuc.Columns[8].Visible = false;
                    grid_sonuc.Columns[9].Visible = false;
                    grid_sonuc.Columns[10].Visible = false;
                    grid_sonuc.Columns[11].Visible = false;
                    grid_sonuc.Columns[12].Visible = false;
                }

                if (CollAta.Count > 0)
                {
                    grid_sonuc.Columns[19].Visible = true;
                    grid_sonuc.Columns[20].Visible = true;
                    grid_sonuc.Columns[21].Visible = true;
                    grid_sonuc.Columns[22].Visible = true;
                }

                else
                {
                    grid_sonuc.Columns[19].Visible = false;
                    grid_sonuc.Columns[20].Visible = false;
                    grid_sonuc.Columns[21].Visible = false;
                    grid_sonuc.Columns[22].Visible = false;
                }

                Session["say_kac"] = "0";

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
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "Çağrı İşlemleri");
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
            }
        }        

        protected void grid_sonuc_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            if (Session["sorgula_2"] == null)
            {
                ListBildirimTypedList uc_list = new ListBildirimTypedList();
                ISortExpression sortuc = new SortExpression();
                sortuc.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filteruc = new PredicateExpression();
                filteruc.AddWithAnd(BildirimFields.BildirimVatandasKarar != "");
                filteruc.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                uc_list.Fill(0, sortuc, true, filteruc);

                grid_sonuc.DataSource = uc_list;
                grid_sonuc.DataBind();
            }

            else
            {
                ListBildirimTypedList uc_list = new ListBildirimTypedList();
                ISortExpression sortuc = new SortExpression();
                sortuc.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filteruc = new PredicateExpression();
                filteruc.AddWithAnd(BildirimFields.BildirimVatandasKarar != "");
                filteruc.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi_2.Text));
                filteruc.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi_2.Text));
                uc_list.Fill(0, sortuc, true, filteruc);

                grid_sonuc.DataSource = uc_list;
                grid_sonuc.DataBind();
            }  

            if (Session["yetki_durum"].ToString() == "Evet")
            {
                grid_sonuc.Columns[8].Visible = true;
                grid_sonuc.Columns[9].Visible = true;
                grid_sonuc.Columns[10].Visible = true;
                grid_sonuc.Columns[11].Visible = true;
                grid_sonuc.Columns[12].Visible = true;
            }

            else
            {
                grid_sonuc.Columns[8].Visible = false;
                grid_sonuc.Columns[9].Visible = false;
                grid_sonuc.Columns[10].Visible = false;
                grid_sonuc.Columns[11].Visible = false;
                grid_sonuc.Columns[12].Visible = false;
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
                grid_sonuc.Columns[19].Visible = true;
                grid_sonuc.Columns[20].Visible = true;
                grid_sonuc.Columns[21].Visible = true;
                grid_sonuc.Columns[22].Visible = true;
            }

            else
            {
                grid_sonuc.Columns[19].Visible = false;
                grid_sonuc.Columns[20].Visible = false;
                grid_sonuc.Columns[21].Visible = false;
                grid_sonuc.Columns[22].Visible = false;
            }

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_sonuc.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_sonuc_BeforeColumnSortingGrouping(object sender, EventArgs e)
        {
            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            if (Session["sorgula_2"] == null)
            {
                ListBildirimTypedList uc_list = new ListBildirimTypedList();
                ISortExpression sortuc = new SortExpression();
                sortuc.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filteruc = new PredicateExpression();
                filteruc.AddWithAnd(BildirimFields.BildirimVatandasKarar != "");
                filteruc.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                uc_list.Fill(0, sortuc, true, filteruc);

                grid_sonuc.DataSource = uc_list;
                grid_sonuc.DataBind();
            }

            else
            {
                ListBildirimTypedList uc_list = new ListBildirimTypedList();
                ISortExpression sortuc = new SortExpression();
                sortuc.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filteruc = new PredicateExpression();
                filteruc.AddWithAnd(BildirimFields.BildirimVatandasKarar != "");
                filteruc.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi_2.Text));
                filteruc.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi_2.Text));
                uc_list.Fill(0, sortuc, true, filteruc);

                grid_sonuc.DataSource = uc_list;
                grid_sonuc.DataBind();
            }  

            if (Session["yetki_durum"].ToString() == "Evet")
            {
                grid_sonuc.Columns[8].Visible = true;
                grid_sonuc.Columns[9].Visible = true;
                grid_sonuc.Columns[10].Visible = true;
                grid_sonuc.Columns[11].Visible = true;
                grid_sonuc.Columns[12].Visible = true;
            }

            else
            {
                grid_sonuc.Columns[8].Visible = false;
                grid_sonuc.Columns[9].Visible = false;
                grid_sonuc.Columns[10].Visible = false;
                grid_sonuc.Columns[11].Visible = false;
                grid_sonuc.Columns[12].Visible = false;
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
                grid_sonuc.Columns[19].Visible = true;
                grid_sonuc.Columns[20].Visible = true;
                grid_sonuc.Columns[21].Visible = true;
                grid_sonuc.Columns[22].Visible = true;
            }

            else
            {
                grid_sonuc.Columns[19].Visible = false;
                grid_sonuc.Columns[20].Visible = false;
                grid_sonuc.Columns[21].Visible = false;
                grid_sonuc.Columns[22].Visible = false;
            }
        }

        protected void grid_sonuc_PageIndexChanged(object sender, EventArgs e)
        {
            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            if (Session["sorgula_2"] == null)
            {
                ListBildirimTypedList uc_list = new ListBildirimTypedList();
                ISortExpression sortuc = new SortExpression();
                sortuc.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filteruc = new PredicateExpression();
                filteruc.AddWithAnd(BildirimFields.BildirimVatandasKarar != "");
                filteruc.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                uc_list.Fill(0, sortuc, true, filteruc);

                grid_sonuc.DataSource = uc_list;
                grid_sonuc.DataBind();
            }

            else
            {
                ListBildirimTypedList uc_list = new ListBildirimTypedList();
                ISortExpression sortuc = new SortExpression();
                sortuc.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filteruc = new PredicateExpression();
                filteruc.AddWithAnd(BildirimFields.BildirimVatandasKarar != "");
                filteruc.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi_2.Text));
                filteruc.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi_2.Text));
                uc_list.Fill(0, sortuc, true, filteruc);

                grid_sonuc.DataSource = uc_list;
                grid_sonuc.DataBind();
            }  

            if (Session["yetki_durum"].ToString() == "Evet")
            {
                grid_sonuc.Columns[8].Visible = true;
                grid_sonuc.Columns[9].Visible = true;
                grid_sonuc.Columns[10].Visible = true;
                grid_sonuc.Columns[11].Visible = true;
                grid_sonuc.Columns[12].Visible = true;
            }

            else
            {
                grid_sonuc.Columns[8].Visible = false;
                grid_sonuc.Columns[9].Visible = false;
                grid_sonuc.Columns[10].Visible = false;
                grid_sonuc.Columns[11].Visible = false;
                grid_sonuc.Columns[12].Visible = false;
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
                grid_sonuc.Columns[19].Visible = true;
                grid_sonuc.Columns[20].Visible = true;
                grid_sonuc.Columns[21].Visible = true;
                grid_sonuc.Columns[22].Visible = true;
            }

            else
            {
                grid_sonuc.Columns[19].Visible = false;
                grid_sonuc.Columns[20].Visible = false;
                grid_sonuc.Columns[21].Visible = false;
                grid_sonuc.Columns[22].Visible = false;
            }
        }

        protected void grid_sonuc_CustomCollback(object sender, EventArgs e)
        {
            try
            {
                txtUserName33.Text = grid_sonuc.GetSelectedFieldValues("BildirimId")[0].ToString();

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserName33.Text));
                CollBil.GetMulti(ExpBil);

                Session["vatandas_iceri"] = CollBil[0].FkVatandasId.ToString();
                Session["bildirim_iceri"] = txtUserName33.Text;

                txt_vatandas_sonuc.Text = CollBil[0].BildirimVatandasKarar;

                btn_sonuc_degistir.Enabled = true;
                btn_bilgi_gecmis3.Enabled = true;

                grid_sonuc.Selection.UnselectAll();
            }

            catch
            {

            }
        }

        protected void btn_sorgula_2_Click(object sender, EventArgs e)
        {
            DateTime zaman1 = Convert.ToDateTime(txt_bas_tarihi_2.Text);
            DateTime zaman2 = Convert.ToDateTime(txt_bit_tarihi_2.Text);

            ListBildirimTypedList uc_list = new ListBildirimTypedList();
            ISortExpression sortuc = new SortExpression();
            sortuc.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filteruc = new PredicateExpression();
            filteruc.AddWithAnd(BildirimFields.BildirimVatandasKarar != "");
            filteruc.AddWithAnd(BildirimFields.BildirimTarih > zaman1);
            filteruc.AddWithAnd(BildirimFields.BildirimTarih < zaman2);
            uc_list.Fill(0, sortuc, true, filteruc);

            grid_sonuc.DataSource = uc_list;
            grid_sonuc.DataBind();

            if (Session["yetki_durum"].ToString() == "Evet")
            {
                grid_sonuc.Columns[8].Visible = true;
                grid_sonuc.Columns[9].Visible = true;
                grid_sonuc.Columns[10].Visible = true;
                grid_sonuc.Columns[11].Visible = true;
                grid_sonuc.Columns[12].Visible = true;
            }

            else
            {
                grid_sonuc.Columns[8].Visible = false;
                grid_sonuc.Columns[9].Visible = false;
                grid_sonuc.Columns[10].Visible = false;
                grid_sonuc.Columns[11].Visible = false;
                grid_sonuc.Columns[12].Visible = false;
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
                grid_sonuc.Columns[19].Visible = true;
                grid_sonuc.Columns[20].Visible = true;
                grid_sonuc.Columns[21].Visible = true;
                grid_sonuc.Columns[22].Visible = true;
            }

            else
            {
                grid_sonuc.Columns[19].Visible = false;
                grid_sonuc.Columns[20].Visible = false;
                grid_sonuc.Columns[21].Visible = false;
                grid_sonuc.Columns[22].Visible = false;
            }

            Session["sorgula_2"] = "1";
        }

        protected void btn_sorgula_Click(object sender, EventArgs e)
        {
            DateTime zaman1 = Convert.ToDateTime(txt_bas_tarihi.Text);
            DateTime zaman2 = Convert.ToDateTime(txt_bit_tarihi.Text);

            ListBildirimTypedList bil_list = new ListBildirimTypedList();
            ISortExpression sort22 = new SortExpression();
            sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
            IPredicateExpression filter2 = new PredicateExpression();
            filter2.AddWithAnd(BildirimFields.BildirimTarih > zaman1);
            filter2.AddWithAnd(BildirimFields.BildirimTarih < zaman2);
            bil_list.Fill(0, sort22, true, filter2);

            grid_gecmis.DataSource = bil_list;
            grid_gecmis.DataBind();

            if (Session["yetki_durum"].ToString() == "Evet")
            {
                grid_gecmis.Columns[8].Visible = true;
                grid_gecmis.Columns[9].Visible = true;
                grid_gecmis.Columns[10].Visible = true;
                grid_gecmis.Columns[11].Visible = true;
                grid_gecmis.Columns[12].Visible = true;
            }

            else
            {
                grid_gecmis.Columns[8].Visible = false;
                grid_gecmis.Columns[9].Visible = false;
                grid_gecmis.Columns[10].Visible = false;
                grid_gecmis.Columns[11].Visible = false;
                grid_gecmis.Columns[12].Visible = false;
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
                grid_gecmis.Columns[19].Visible = true;
                grid_gecmis.Columns[20].Visible = true;
                grid_gecmis.Columns[21].Visible = true;
                grid_gecmis.Columns[22].Visible = true;
            }

            else
            {
                grid_gecmis.Columns[19].Visible = false;
                grid_gecmis.Columns[20].Visible = false;
                grid_gecmis.Columns[21].Visible = false;
                grid_gecmis.Columns[22].Visible = false;
            }

            Session["sorgula_ana"] = "1";
        }

        protected void btn_son_guncel_Click(object sender, EventArgs e)
        {
            BildirimCollection CollBil = new BildirimCollection();
            IPredicateExpression ExpBil = new PredicateExpression();
            ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserName33.Text));
            CollBil.GetMulti(ExpBil);

            CollBil[0].BildirimVatandasKarar = txt_vatandas_sonuc.Text;
            CollBil[0].Save();

            BildirimIslemCollection CollIs = new BildirimIslemCollection();
            IPredicateExpression ExpIs = new PredicateExpression();
            ExpIs.AddWithAnd(BildirimIslemFields.BildirimIslemAd == "Kayıtları Güncellendi");
            CollIs.GetMulti(ExpIs);

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            BildirimHistoryEntity EntHis = new BildirimHistoryEntity();
            EntHis.FkBildirimId = CollBil[0].BildirimId;
            EntHis.FkBildirimIslemId = CollIs[0].BildirimIslemId;
            EntHis.FkKullaniciId = Convert.ToInt16(Session["kullanici_var_mi"].ToString());
            EntHis.BildirimHistoryTarih = DateTime.Now;
            EntHis.BildirimHistorySure = "0";
            EntHis.BildirimHistoryAciklama = CollKul[0].KullaniciAdSoyad + " tarafından kayıtları (vatandaş karar) güncellendi.";
            EntHis.Save();

            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            if (Session["sorgula_ana"] == null)
            {
                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                bil_list.Fill(0, sort22, true, filter2);

                grid_gecmis.DataSource = bil_list;
                grid_gecmis.DataBind();
            }

            else
            {
                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
                bil_list.Fill(0, sort22, true, filter2);

                grid_gecmis.DataSource = bil_list;
                grid_gecmis.DataBind();
            }

            if (Session["yetki_durum"].ToString() == "Evet")
            {
                grid_gecmis.Columns[8].Visible = true;
                grid_gecmis.Columns[9].Visible = true;
                grid_gecmis.Columns[10].Visible = true;
                grid_gecmis.Columns[11].Visible = true;
                grid_gecmis.Columns[12].Visible = true;
            }

            else
            {
                grid_gecmis.Columns[8].Visible = false;
                grid_gecmis.Columns[9].Visible = false;
                grid_gecmis.Columns[10].Visible = false;
                grid_gecmis.Columns[11].Visible = false;
                grid_gecmis.Columns[12].Visible = false;
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
                grid_gecmis.Columns[19].Visible = true;
                grid_gecmis.Columns[20].Visible = true;
                grid_gecmis.Columns[21].Visible = true;
                grid_gecmis.Columns[22].Visible = true;
            }

            else
            {
                grid_gecmis.Columns[19].Visible = false;
                grid_gecmis.Columns[20].Visible = false;
                grid_gecmis.Columns[21].Visible = false;
                grid_gecmis.Columns[22].Visible = false;
            }

            if (Session["sorgula_2"] == null)
            {
                ListBildirimTypedList uc_list = new ListBildirimTypedList();
                ISortExpression sortuc = new SortExpression();
                sortuc.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filteruc = new PredicateExpression();
                filteruc.AddWithAnd(BildirimFields.BildirimVatandasKarar != "");
                filteruc.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                uc_list.Fill(0, sortuc, true, filteruc);

                grid_sonuc.DataSource = uc_list;
                grid_sonuc.DataBind();
            }

            else
            {
                ListBildirimTypedList uc_list = new ListBildirimTypedList();
                ISortExpression sortuc = new SortExpression();
                sortuc.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filteruc = new PredicateExpression();
                filteruc.AddWithAnd(BildirimFields.BildirimVatandasKarar != "");
                filteruc.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi_2.Text));
                filteruc.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi_2.Text));
                uc_list.Fill(0, sortuc, true, filteruc);

                grid_sonuc.DataSource = uc_list;
                grid_sonuc.DataBind();
            }  

            if (Session["yetki_durum"].ToString() == "Evet")
            {
                grid_sonuc.Columns[8].Visible = true;
                grid_sonuc.Columns[9].Visible = true;
                grid_sonuc.Columns[10].Visible = true;
                grid_sonuc.Columns[11].Visible = true;
                grid_sonuc.Columns[12].Visible = true;
            }

            else
            {
                grid_sonuc.Columns[8].Visible = false;
                grid_sonuc.Columns[9].Visible = false;
                grid_sonuc.Columns[10].Visible = false;
                grid_sonuc.Columns[11].Visible = false;
                grid_sonuc.Columns[12].Visible = false;
            }

            if (CollAta.Count > 0)
            {
                grid_sonuc.Columns[19].Visible = true;
                grid_sonuc.Columns[20].Visible = true;
                grid_sonuc.Columns[21].Visible = true;
                grid_sonuc.Columns[22].Visible = true;
            }

            else
            {
                grid_sonuc.Columns[19].Visible = false;
                grid_sonuc.Columns[20].Visible = false;
                grid_sonuc.Columns[21].Visible = false;
                grid_sonuc.Columns[22].Visible = false;
            }

            string CloseWindow;
            CloseWindow = "alert('Bildirim bilgileri güncellenmiştir. ...')";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

            pcDegistir.ShowOnPageLoad = false;
        }

        protected void grid_sonuc_ProcessColumnAutoFilter(object sender, EventArgs e)
        {
            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            if (Session["sorgula_2"] == null)
            {
                ListBildirimTypedList uc_list = new ListBildirimTypedList();
                ISortExpression sortuc = new SortExpression();
                sortuc.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filteruc = new PredicateExpression();
                filteruc.AddWithAnd(BildirimFields.BildirimVatandasKarar != "");
                filteruc.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                uc_list.Fill(0, sortuc, true, filteruc);

                grid_sonuc.DataSource = uc_list;
                grid_sonuc.DataBind();
            }

            else
            {
                ListBildirimTypedList uc_list = new ListBildirimTypedList();
                ISortExpression sortuc = new SortExpression();
                sortuc.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filteruc = new PredicateExpression();
                filteruc.AddWithAnd(BildirimFields.BildirimVatandasKarar != "");
                filteruc.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi_2.Text));
                filteruc.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi_2.Text));
                uc_list.Fill(0, sortuc, true, filteruc);

                grid_sonuc.DataSource = uc_list;
                grid_sonuc.DataBind();
            }  

            if (Session["yetki_durum"].ToString() == "Evet")
            {
                grid_sonuc.Columns[8].Visible = true;
                grid_sonuc.Columns[9].Visible = true;
                grid_sonuc.Columns[10].Visible = true;
                grid_sonuc.Columns[11].Visible = true;
                grid_sonuc.Columns[12].Visible = true;
            }

            else
            {
                grid_sonuc.Columns[8].Visible = false;
                grid_sonuc.Columns[9].Visible = false;
                grid_sonuc.Columns[10].Visible = false;
                grid_sonuc.Columns[11].Visible = false;
                grid_sonuc.Columns[12].Visible = false;
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
                grid_sonuc.Columns[19].Visible = true;
                grid_sonuc.Columns[20].Visible = true;
                grid_sonuc.Columns[21].Visible = true;
                grid_sonuc.Columns[22].Visible = true;
            }

            else
            {
                grid_sonuc.Columns[19].Visible = false;
                grid_sonuc.Columns[20].Visible = false;
                grid_sonuc.Columns[21].Visible = false;
                grid_sonuc.Columns[22].Visible = false;
            }
        }      

        protected void grid_gecmis_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            if (Session["sorgula_ana"] == null)
            {
                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                bil_list.Fill(0, sort22, true, filter2);

                grid_gecmis.DataSource = bil_list;
                grid_gecmis.DataBind();
            }

            else
            {
                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
                bil_list.Fill(0, sort22, true, filter2);

                grid_gecmis.DataSource = bil_list;
                grid_gecmis.DataBind();
            }

            if (Session["yetki_durum"].ToString() == "Evet")
            {
                grid_gecmis.Columns[8].Visible = true;
                grid_gecmis.Columns[9].Visible = true;
                grid_gecmis.Columns[10].Visible = true;
                grid_gecmis.Columns[11].Visible = true;
                grid_gecmis.Columns[12].Visible = true;
            }

            else
            {
                grid_gecmis.Columns[8].Visible = false;
                grid_gecmis.Columns[9].Visible = false;
                grid_gecmis.Columns[10].Visible = false;
                grid_gecmis.Columns[11].Visible = false;
                grid_gecmis.Columns[12].Visible = false;
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
                grid_gecmis.Columns[19].Visible = true;
                grid_gecmis.Columns[20].Visible = true;
                grid_gecmis.Columns[21].Visible = true;
                grid_gecmis.Columns[22].Visible = true;
            }

            else
            {
                grid_gecmis.Columns[19].Visible = false;
                grid_gecmis.Columns[20].Visible = false;
                grid_gecmis.Columns[21].Visible = false;
                grid_gecmis.Columns[22].Visible = false;
            }

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_gecmis.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_gecmis_ProcessColumnAutoFilter(object sender, EventArgs e)
        {
            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            if (Session["sorgula_ana"] == null)
            {
                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                bil_list.Fill(0, sort22, true, filter2);

                grid_gecmis.DataSource = bil_list;
                grid_gecmis.DataBind();
            }

            else
            {
                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
                bil_list.Fill(0, sort22, true, filter2);

                grid_gecmis.DataSource = bil_list;
                grid_gecmis.DataBind();
            }

            if (Session["yetki_durum"].ToString() == "Evet")
            {
                grid_gecmis.Columns[8].Visible = true;
                grid_gecmis.Columns[9].Visible = true;
                grid_gecmis.Columns[10].Visible = true;
                grid_gecmis.Columns[11].Visible = true;
                grid_gecmis.Columns[12].Visible = true;
            }

            else
            {
                grid_gecmis.Columns[8].Visible = false;
                grid_gecmis.Columns[9].Visible = false;
                grid_gecmis.Columns[10].Visible = false;
                grid_gecmis.Columns[11].Visible = false;
                grid_gecmis.Columns[12].Visible = false;
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
                grid_gecmis.Columns[19].Visible = true;
                grid_gecmis.Columns[20].Visible = true;
                grid_gecmis.Columns[21].Visible = true;
                grid_gecmis.Columns[22].Visible = true;
            }

            else
            {
                grid_gecmis.Columns[19].Visible = false;
                grid_gecmis.Columns[20].Visible = false;
                grid_gecmis.Columns[21].Visible = false;
                grid_gecmis.Columns[22].Visible = false;
            }
        }

        protected void btn_bilgi_gecmis2_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McCagriGenisOzet.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void btn_bilgi_gecmis3_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "var Mleft = (screen.width/2)-(760/2)-100;var Mtop = (screen.height/2)-(700/2)-30;window.open( 'McCagriGenisOzet.aspx', null, 'height=640,width=1100,status=yes,toolbar=no,scrollbars=yes,menubar=no,resizable=no,location=no,top=\'+Mtop+\', left=\'+Mleft+\'' );", true);
        }

        protected void grid_gecmis_CustomCollback(object sender, EventArgs e)
        {
            try
            {
                txtUserName2.Text = grid_gecmis.GetSelectedFieldValues("BildirimId")[0].ToString();

                btn_bilgi_gecmis.Enabled = true;
                btn_bilgi_gecmis2.Enabled = true;

                BildirimCollection CollBil = new BildirimCollection();
                IPredicateExpression ExpBil = new PredicateExpression();
                ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserName2.Text));
                CollBil.GetMulti(ExpBil);

                Session["vatandas_iceri"] = CollBil[0].FkVatandasId.ToString();

                Session["bildirim_iceri"] = txtUserName2.Text;

                lb_gecmis.Items.Clear();

                BildirimHistoryCollection CollArsiv = new BildirimHistoryCollection();
                IPredicateExpression ExpArsiv = new PredicateExpression();
                ISortExpression sortarsiv = new SortExpression();
                ExpArsiv.AddWithAnd(BildirimHistoryFields.FkBildirimId == Convert.ToInt64(txtUserName2.Text));
                sortarsiv.Add(new SortClause(BildirimHistoryFields.BildirimHistoryId, SortOperator.Ascending));
                CollArsiv.GetMulti(ExpArsiv, 0, sortarsiv);

                for (int i = 0; i < CollArsiv.Count; i++)
                {
                    lb_gecmis.Items.Add("- " + CollArsiv[i].BildirimHistoryTarih.ToShortDateString() + " " + CollArsiv[i].BildirimHistoryTarih.ToShortTimeString() + " - " + CollArsiv[i].BildirimHistoryAciklama);
                }

                grid_gecmis.Selection.UnselectAll();
            }

            catch
            {

            }
        }

        protected void grid_gecmis_BeforeColumnSortingGrouping(object sender, ASPxGridViewBeforeColumnGroupingSortingEventArgs e)
        {
            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            if (Session["sorgula_ana"] == null)
            {
                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                bil_list.Fill(0, sort22, true, filter2);

                grid_gecmis.DataSource = bil_list;
                grid_gecmis.DataBind();
            }

            else
            {
                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
                bil_list.Fill(0, sort22, true, filter2);

                grid_gecmis.DataSource = bil_list;
                grid_gecmis.DataBind();
            }

            if (Session["yetki_durum"].ToString() == "Evet")
            {
                grid_gecmis.Columns[8].Visible = true;
                grid_gecmis.Columns[9].Visible = true;
                grid_gecmis.Columns[10].Visible = true;
                grid_gecmis.Columns[11].Visible = true;
                grid_gecmis.Columns[12].Visible = true;
            }

            else
            {
                grid_gecmis.Columns[8].Visible = false;
                grid_gecmis.Columns[9].Visible = false;
                grid_gecmis.Columns[10].Visible = false;
                grid_gecmis.Columns[11].Visible = false;
                grid_gecmis.Columns[12].Visible = false;
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
                grid_gecmis.Columns[19].Visible = true;
                grid_gecmis.Columns[20].Visible = true;
                grid_gecmis.Columns[21].Visible = true;
                grid_gecmis.Columns[22].Visible = true;
            }

            else
            {
                grid_gecmis.Columns[19].Visible = false;
                grid_gecmis.Columns[20].Visible = false;
                grid_gecmis.Columns[21].Visible = false;
                grid_gecmis.Columns[22].Visible = false;
            }

            string sort_tur = e.Column.SortOrder.ToString();

            if (sort_tur == "Ascending")
            {
                grid_gecmis.SortBy(e.Column, ColumnSortOrder.Ascending);
            }

            else
            {
                grid_gecmis.SortBy(e.Column, ColumnSortOrder.Descending);
            }
        }

        protected void grid_gecmis_PageIndexChanged(object sender, EventArgs e)
        {
            ParametreCollection CollPrm = new ParametreCollection();
            IPredicateExpression ExpPrm = new PredicateExpression();
            ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
            CollPrm.GetMulti(ExpPrm);

            DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

            if (Session["sorgula_ana"] == null)
            {
                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                bil_list.Fill(0, sort22, true, filter2);

                grid_gecmis.DataSource = bil_list;
                grid_gecmis.DataBind();
            }

            else
            {
                ListBildirimTypedList bil_list = new ListBildirimTypedList();
                ISortExpression sort22 = new SortExpression();
                sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                IPredicateExpression filter2 = new PredicateExpression();
                filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
                bil_list.Fill(0, sort22, true, filter2);

                grid_gecmis.DataSource = bil_list;
                grid_gecmis.DataBind();
            }

            if (Session["yetki_durum"].ToString() == "Evet")
            {
                grid_gecmis.Columns[8].Visible = true;
                grid_gecmis.Columns[9].Visible = true;
                grid_gecmis.Columns[10].Visible = true;
                grid_gecmis.Columns[11].Visible = true;
                grid_gecmis.Columns[12].Visible = true;
            }

            else
            {
                grid_gecmis.Columns[8].Visible = false;
                grid_gecmis.Columns[9].Visible = false;
                grid_gecmis.Columns[10].Visible = false;
                grid_gecmis.Columns[11].Visible = false;
                grid_gecmis.Columns[12].Visible = false;
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
                grid_gecmis.Columns[19].Visible = true;
                grid_gecmis.Columns[20].Visible = true;
                grid_gecmis.Columns[21].Visible = true;
                grid_gecmis.Columns[22].Visible = true;
            }

            else
            {
                grid_gecmis.Columns[19].Visible = false;
                grid_gecmis.Columns[20].Visible = false;
                grid_gecmis.Columns[21].Visible = false;
                grid_gecmis.Columns[22].Visible = false;
            }
        }       

        protected void grid_sonuc_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName33.Text = grid_sonuc.GetSelectedFieldValues("BildirimId")[0].ToString();

            BildirimCollection CollBil = new BildirimCollection();
            IPredicateExpression ExpBil = new PredicateExpression();
            ExpBil.AddWithAnd(BildirimFields.BildirimId == Convert.ToInt64(txtUserName33.Text));
            CollBil.GetMulti(ExpBil);

            txt_vatandas_sonuc.Text = CollBil[0].BildirimVatandasKarar;

            btn_sonuc_degistir.Enabled = true;
        }

        protected void grid_gecmis_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName2.Text = grid_gecmis.GetSelectedFieldValues("BildirimId")[0].ToString();

            btn_bilgi_gecmis.Enabled = true;

            lb_gecmis.Items.Clear();

            BildirimHistoryCollection CollArsiv = new BildirimHistoryCollection();
            IPredicateExpression ExpArsiv = new PredicateExpression();
            ISortExpression sortarsiv = new SortExpression();
            ExpArsiv.AddWithAnd(BildirimHistoryFields.FkBildirimId == Convert.ToInt64(txtUserName2.Text));
            sortarsiv.Add(new SortClause(BildirimHistoryFields.BildirimHistoryId, SortOperator.Ascending));
            CollArsiv.GetMulti(ExpArsiv, 0, sortarsiv);

            for (int i = 0; i < CollArsiv.Count; i++)
            {
                lb_gecmis.Items.Add("- " + CollArsiv[i].BildirimHistoryTarih.ToShortDateString() + " " + CollArsiv[i].BildirimHistoryTarih.ToShortTimeString() + " - " + CollArsiv[i].BildirimHistoryAciklama);
            }
        }                                 

        protected void Menu1_MenuItemClick(object sender, MenuItemEventArgs e)
        {
            int index = 0;

            string hexValue = "#FFFFFF";
            string hexValue2 = "#C0D9E7";           

            if (e.Item.ToString() == "Çağrı Geçmişi Görüntüle")
            {
                index = 0;

                foreach (MenuItem item in Menu1.Items)
                {
                    item.ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                }
                Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);

                //Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                //Menu1.Items[1].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                //Menu1.Items[2].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                //Menu1.Items[3].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);
                //Menu1.Items[4].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);

                ParametreCollection CollPrm = new ParametreCollection();
                IPredicateExpression ExpPrm = new PredicateExpression();
                ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
                CollPrm.GetMulti(ExpPrm);

                DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

                if (Session["sorgula_ana"] == null)
                {
                    ListBildirimTypedList bil_list = new ListBildirimTypedList();
                    ISortExpression sort22 = new SortExpression();
                    sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filter2 = new PredicateExpression();
                    filter2.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                    bil_list.Fill(0, sort22, true, filter2);

                    grid_gecmis.DataSource = bil_list;
                    grid_gecmis.DataBind();
                }

                else
                {
                    ListBildirimTypedList bil_list = new ListBildirimTypedList();
                    ISortExpression sort22 = new SortExpression();
                    sort22.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filter2 = new PredicateExpression();
                    filter2.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi.Text));
                    filter2.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi.Text));
                    bil_list.Fill(0, sort22, true, filter2);

                    grid_gecmis.DataSource = bil_list;
                    grid_gecmis.DataBind();
                }

                if (Session["yetki_durum"].ToString() == "Evet")
                {
                    grid_gecmis.Columns[8].Visible = true;
                    grid_gecmis.Columns[9].Visible = true;
                    grid_gecmis.Columns[10].Visible = true;
                    grid_gecmis.Columns[11].Visible = true;
                    grid_gecmis.Columns[12].Visible = true;
                }

                else
                {
                    grid_gecmis.Columns[8].Visible = false;
                    grid_gecmis.Columns[9].Visible = false;
                    grid_gecmis.Columns[10].Visible = false;
                    grid_gecmis.Columns[11].Visible = false;
                    grid_gecmis.Columns[12].Visible = false;
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
                    grid_gecmis.Columns[19].Visible = true;
                    grid_gecmis.Columns[20].Visible = true;
                    grid_gecmis.Columns[21].Visible = true;
                    grid_gecmis.Columns[22].Visible = true;
                }

                else
                {
                    grid_gecmis.Columns[19].Visible = false;
                    grid_gecmis.Columns[20].Visible = false;
                    grid_gecmis.Columns[21].Visible = false;
                    grid_gecmis.Columns[22].Visible = false;
                }
            }

            else if (e.Item.ToString() == "Çağrı Sonuç İşlemleri")
            {
                index = 1;

                foreach (MenuItem item in Menu1.Items)
                {
                    item.ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                }
                Menu1.Items[1].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);

                //Menu1.Items[0].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                //Menu1.Items[1].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                //Menu1.Items[2].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                //Menu1.Items[3].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue);
                //Menu1.Items[4].ItemStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hexValue2);

                ParametreCollection CollPrm = new ParametreCollection();
                IPredicateExpression ExpPrm = new PredicateExpression();
                ExpPrm.AddWithAnd(ParametreFields.ParametreAd == "Yükleme Zamanı");
                CollPrm.GetMulti(ExpPrm);

                DateTime zaman = DateTime.Now.AddDays(Convert.ToDouble(CollPrm[0].ParametreDeger.ToString()));

                if (Session["sorgula_2"] == null)
                {
                    ListBildirimTypedList uc_list = new ListBildirimTypedList();
                    ISortExpression sortuc = new SortExpression();
                    sortuc.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filteruc = new PredicateExpression();
                    filteruc.AddWithAnd(BildirimFields.BildirimVatandasKarar != "");
                    filteruc.AddWithAnd(BildirimFields.BildirimTarih >= zaman);
                    uc_list.Fill(0, sortuc, true, filteruc);

                    grid_sonuc.DataSource = uc_list;
                    grid_sonuc.DataBind();
                }

                else
                {
                    ListBildirimTypedList uc_list = new ListBildirimTypedList();
                    ISortExpression sortuc = new SortExpression();
                    sortuc.Add(new SortClause(BildirimFields.BildirimTarih, SortOperator.Descending));
                    IPredicateExpression filteruc = new PredicateExpression();
                    filteruc.AddWithAnd(BildirimFields.BildirimVatandasKarar != "");
                    filteruc.AddWithAnd(BildirimFields.BildirimTarih >= Convert.ToDateTime(txt_bas_tarihi_2.Text));
                    filteruc.AddWithAnd(BildirimFields.BildirimTarih <= Convert.ToDateTime(txt_bit_tarihi_2.Text));
                    uc_list.Fill(0, sortuc, true, filteruc);

                    grid_sonuc.DataSource = uc_list;
                    grid_sonuc.DataBind();
                }  

                if (Session["yetki_durum"].ToString() == "Evet")
                {
                    grid_sonuc.Columns[8].Visible = true;
                    grid_sonuc.Columns[9].Visible = true;
                    grid_sonuc.Columns[10].Visible = true;
                    grid_sonuc.Columns[11].Visible = true;
                    grid_sonuc.Columns[12].Visible = true;
                }

                else
                {
                    grid_sonuc.Columns[8].Visible = false;
                    grid_sonuc.Columns[9].Visible = false;
                    grid_sonuc.Columns[10].Visible = false;
                    grid_sonuc.Columns[11].Visible = false;
                    grid_sonuc.Columns[12].Visible = false;
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
                    grid_sonuc.Columns[19].Visible = true;
                    grid_sonuc.Columns[20].Visible = true;
                    grid_sonuc.Columns[21].Visible = true;
                    grid_sonuc.Columns[22].Visible = true;
                }

                else
                {
                    grid_sonuc.Columns[19].Visible = false;
                    grid_sonuc.Columns[20].Visible = false;
                    grid_sonuc.Columns[21].Visible = false;
                    grid_sonuc.Columns[22].Visible = false;
                }
            }

            MultiView1.ActiveViewIndex = index;
        }
    }
}