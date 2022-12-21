using System;
using System.Web.UI;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using dhmi.TypedListClasses;
using dhmi.EntityClasses;
using System.Web;

namespace Dhmi.Web
{
    public partial class VipListeBilgileri : System.Web.UI.Page
    {
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

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            grid_vip_export.PageHeader.Center = Environment.NewLine + "  " + Environment.NewLine + "  " + Environment.NewLine + "   " + Environment.NewLine + "DEVLET HAVA MEYDANLARI İŞLETMESİ GENEL MÜDÜRLÜĞÜ (DHMİ)" + Environment.NewLine + "İLETİŞİM MERKEZİ SİSTEMİ" + Environment.NewLine + "VIP LİSTE BİLGİLERİ" + Environment.NewLine + "  " + Environment.NewLine + "  ";
            grid_vip_export.PageFooter.Center = System.DateTime.Now.ToString("dd.MM.yyyy");

            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            grid_vip.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);
            grid_vip_sil.SettingsPager.PageSize = Convert.ToInt32(CollParam[0].ParametreDeger);

            ListVipTypedList list_vip = new ListVipTypedList();
            ISortExpression sortvip = new SortExpression();
            sortvip.Add(new SortClause(VipListeFields.VipListeIslemTarih, SortOperator.Descending));
            list_vip.Fill(0, sortvip, true);

            grid_vip.DataSource = list_vip;
            grid_vip.DataBind();

            grid_vip_sil.DataSource = list_vip;
            grid_vip_sil.DataBind();

            if (IsPostBack != true)
            {
                if (Session["vat_id"] != null)
                {
                    VatandaCollection CollVat = new VatandaCollection();
                    IPredicateExpression ExpVat = new PredicateExpression();
                    ExpVat.AddWithAnd(VatandaFields.VatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                    CollVat.GetMulti(ExpVat);

                    txt_ad.Text = CollVat[0].VatandasAdSoyad;
                    txt_tel_no.Text = CollVat[0].VatandasTel1;
                }

                txt_bas_tarihi.Text = DateTime.Today.ToShortDateString();
                txt_bit_tarihi.Text = DateTime.Today.ToShortDateString();

                cb_bas_saat.Items.Clear();
                cb_bit_saat.Items.Clear();

                cb_bas_saat.Items.Add("00:00");
                cb_bas_saat.Items.Add("01:00");
                cb_bas_saat.Items.Add("02:00");
                cb_bas_saat.Items.Add("03:00");
                cb_bas_saat.Items.Add("04:00");
                cb_bas_saat.Items.Add("05:00");
                cb_bas_saat.Items.Add("06:00");
                cb_bas_saat.Items.Add("07:00");
                cb_bas_saat.Items.Add("08:00");
                cb_bas_saat.Items.Add("09:00");
                cb_bas_saat.Items.Add("10:00");
                cb_bas_saat.Items.Add("11:00");
                cb_bas_saat.Items.Add("12:00");
                cb_bas_saat.Items.Add("13:00");
                cb_bas_saat.Items.Add("14:00");
                cb_bas_saat.Items.Add("15:00");
                cb_bas_saat.Items.Add("16:00");
                cb_bas_saat.Items.Add("17:00");
                cb_bas_saat.Items.Add("18:00");
                cb_bas_saat.Items.Add("19:00");
                cb_bas_saat.Items.Add("20:00");
                cb_bas_saat.Items.Add("21:00");
                cb_bas_saat.Items.Add("22:00");
                cb_bas_saat.Items.Add("23:00");

                cb_bit_saat.Items.Add("00:00");
                cb_bit_saat.Items.Add("01:00");
                cb_bit_saat.Items.Add("02:00");
                cb_bit_saat.Items.Add("03:00");
                cb_bit_saat.Items.Add("04:00");
                cb_bit_saat.Items.Add("05:00");
                cb_bit_saat.Items.Add("06:00");
                cb_bit_saat.Items.Add("07:00");
                cb_bit_saat.Items.Add("08:00");
                cb_bit_saat.Items.Add("09:00");
                cb_bit_saat.Items.Add("10:00");
                cb_bit_saat.Items.Add("11:00");
                cb_bit_saat.Items.Add("12:00");
                cb_bit_saat.Items.Add("13:00");
                cb_bit_saat.Items.Add("14:00");
                cb_bit_saat.Items.Add("15:00");
                cb_bit_saat.Items.Add("16:00");
                cb_bit_saat.Items.Add("17:00");
                cb_bit_saat.Items.Add("18:00");
                cb_bit_saat.Items.Add("19:00");
                cb_bit_saat.Items.Add("20:00");
                cb_bit_saat.Items.Add("21:00");
                cb_bit_saat.Items.Add("22:00");
                cb_bit_saat.Items.Add("23:00");

                MenuCollection CollMenu = new MenuCollection();
                IPredicateExpression ExpMenu = new PredicateExpression();
                ExpMenu.AddWithAnd(MenuFields.MenuAd == "Çağrı İşlemleri");
                CollMenu.GetMulti(ExpMenu);

                AltMenuCollection CollAlt1 = new AltMenuCollection();
                IPredicateExpression ExpAlt1 = new PredicateExpression();
                ExpAlt1.AddWithAnd(AltMenuFields.AltMenuAd == "VIP Liste Bilgileri");
                CollAlt1.GetMulti(ExpAlt1);

                AltAltMenuCollection CollAlt2 = new AltAltMenuCollection();
                IPredicateExpression ExpAlt2 = new PredicateExpression();
                ExpAlt2.AddWithAnd(AltAltMenuFields.AltAltMenuAd == "VIP Liste Bilgileri");
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
            }

            txt_bas_tarihi.Focus();
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_aciklama.Text = "";
            txt_bas_tarihi.Text = DateTime.Today.ToShortDateString();
            txt_bit_tarihi.Text = DateTime.Today.ToShortDateString();
            cb_bas_saat.Text = "";
            cb_bas_saat.NullText = "Seçiniz...";
            cb_bit_saat.Text = "";
            cb_bit_saat.NullText = "Seçiniz...";

            txt_bas_tarihi.Focus();
        }

        protected void btnPdfExport_Click(object sender, EventArgs e)
        {
            string ad = "vip_liste_bilgileri_pdf_" + DateTime.Now.ToShortDateString();
            grid_vip_export.WritePdfToResponse(ad);
        }

        protected void btnXlsExport_Click(object sender, EventArgs e)
        {
            string ad = "vip_liste_bilgileri_xls_" + DateTime.Now.ToShortDateString();
            grid_vip_export.WriteXlsToResponse(ad);
        }

        protected void btnRtfExport_Click(object sender, EventArgs e)
        {
            string ad = "vip_liste_bilgileri_rtf_" + DateTime.Now.ToShortDateString();
            grid_vip_export.WriteRtfToResponse(ad);
        }

        protected void grid_vip_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_vip.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_vip_sil_PageSizeChanged(object sender, EventArgs e)
        {
            ParametreCollection CollParam = new ParametreCollection();
            IPredicateExpression ExpParam = new PredicateExpression();
            ExpParam.AddWithAnd(ParametreFields.ParametreAd == "Rapor Sayı");
            ExpParam.AddWithAnd(ParametreFields.FkKullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollParam.GetMulti(ExpParam);

            CollParam[0].ParametreDeger = grid_vip_sil.SettingsPager.PageSize.ToString();
            CollParam[0].Save();
        }

        protected void grid_vip_sil_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = grid_vip_sil.GetSelectedFieldValues("VipListeId")[0].ToString();

            btn_iptal_et.Enabled = true;
        }

        protected void btn_iptal_et_Click(object sender, EventArgs e)
        {
            VipListeCollection CollVip = new VipListeCollection();
            IPredicateExpression ExpVip = new PredicateExpression();
            ExpVip.AddWithAnd(VipListeFields.VipListeId == Convert.ToInt64(txtUserName.Text));
            CollVip.GetMulti(ExpVip);

            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            if (CollVip[0].VipListeDurum == false)
            {
                string CloseWindow;
                CloseWindow = "alert('Kayıt daha önce iptal edilmiştir/sonlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else
            {
                CollVip[0].VipListeDurum = false;
                CollVip[0].VipListeIptalTarihi = DateTime.Now;
                CollVip[0].VipListeIptalEdenKullanici = CollKul[0].KullaniciAdSoyad;
                CollVip[0].Save();

                string CloseWindow;
                CloseWindow = "alert('İptal işlemi tamamlanmıştır...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                ListVipTypedList list_vip = new ListVipTypedList();
                ISortExpression sortvip = new SortExpression();
                sortvip.Add(new SortClause(VipListeFields.VipListeIslemTarih, SortOperator.Descending));
                list_vip.Fill(0, sortvip, true);

                grid_vip.DataSource = list_vip;
                grid_vip.DataBind();

                grid_vip_sil.DataSource = list_vip;
                grid_vip_sil.DataBind();

                Session["vat_id"] = null;

                VatandasArsivEntity EntAr = new VatandasArsivEntity();
                EntAr.FkVatandasId = CollVip[0].FkVatandasId;
                EntAr.VatandasArsivIslemTarih = DateTime.Now;
                EntAr.VatandasArsivAciklama = CollKul[0].KullaniciAdSoyad + " tarafından VIP Liste kaydı iptal edildi.";
                EntAr.Save();
            }
        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (Session["vat_id"] == null)
            {
                string CloseWindow;
                CloseWindow = "alert('VIP Liste kaydı yapabilmek için lütfen geçerli bir vatandaş seçiniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else
            {
                DateTime baslangic = Convert.ToDateTime(txt_bas_tarihi.Text);
                DateTime bitis = Convert.ToDateTime(txt_bit_tarihi.Text);

                if (baslangic > bitis)
                {
                    string CloseWindow;
                    CloseWindow = "alert('Başlangıç tarihi bitiş tarihinden küçük olamaz...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }

                else
                {
                    Int16 bas = Convert.ToInt16(cb_bas_saat.Text.Substring(0, 2));
                    Int16 bit = Convert.ToInt16(cb_bit_saat.Text.Substring(0, 2));

                    if (baslangic == bitis && bas >= bit)
                    {
                        string CloseWindow;
                        CloseWindow = "alert('Başlangıç saati bitiş saatinden küçük olamaz...')";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                    }

                    else
                    {
                        string ara_tarih = txt_bas_tarihi.Text + " " + cb_bas_saat.Text;

                        if (Convert.ToDateTime(ara_tarih) < DateTime.Now)
                        {
                            string CloseWindow;
                            CloseWindow = "alert('Başlangıç tarihi içinde bulunduğumuz tarihten küçük olamaz...')";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                        }

                        else
                        {
                            VipListeCollection CollVip = new VipListeCollection();
                            IPredicateExpression ExpVip = new PredicateExpression();
                            ExpVip.AddWithAnd(VipListeFields.FkVatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                            ExpVip.AddWithAnd(VipListeFields.VipListeDurum == true);
                            CollVip.GetMulti(ExpVip);

                            if (CollVip.Count > 0)
                            {
                                string CloseWindow;
                                CloseWindow = "alert('Vatandaşa/Firmaya ait aktif bir VIP Liste kaydı bulunmaktadır...')";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                            }

                            else
                            {
                                KaraListeCollection CollKa = new KaraListeCollection();
                                IPredicateExpression ExpKa = new PredicateExpression();
                                ExpKa.AddWithAnd(KaraListeFields.FkVatandasId == Convert.ToInt64(Session["vat_id"].ToString()));
                                ExpKa.AddWithAnd(KaraListeFields.KaraListeDurum == true);
                                CollKa.GetMulti(ExpKa);

                                if (CollKa.Count > 0)
                                {
                                    string CloseWindow;
                                    CloseWindow = "alert('Vatandaşa/Firmaya ait aktif bir Kara Liste kaydı bulunmaktadır...')";
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                                }

                                else
                                {
                                    KullaniciCollection CollKul12 = new KullaniciCollection();
                                    IPredicateExpression ExpKul12 = new PredicateExpression();
                                    ExpKul12.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                                    CollKul12.GetMulti(ExpKul12);

                                    VipListeEntity EntKay = new VipListeEntity();
                                    EntKay.VipListeIslemYapan = CollKul12[0].KullaniciAdSoyad;
                                    EntKay.FkVatandasId = Convert.ToInt64(Session["vat_id"].ToString());
                                    EntKay.VipListeAciklama = txt_aciklama.Text;
                                    EntKay.VipListeBslTarihSaat = Convert.ToDateTime(txt_bas_tarihi.Text + " " + cb_bas_saat.Text);
                                    EntKay.VipListeBtsTarihSaat = Convert.ToDateTime(txt_bit_tarihi.Text + " " + cb_bit_saat.Text);
                                    EntKay.VipListeDurum = true;
                                    EntKay.VipListeIslemTarih = DateTime.Now;
                                    EntKay.Save();

                                    string CloseWindow;
                                    CloseWindow = "alert('Kayıt işlemi tamamlanmıştır...')";
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);

                                    KullaniciCollection CollKul = new KullaniciCollection();
                                    IPredicateExpression ExpKul = new PredicateExpression();
                                    ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                                    CollKul.GetMulti(ExpKul);

                                    VatandasArsivEntity EntAr = new VatandasArsivEntity();
                                    EntAr.FkVatandasId = Convert.ToInt64(Session["vat_id"].ToString());
                                    EntAr.VatandasArsivIslemTarih = DateTime.Now;
                                    EntAr.VatandasArsivAciklama = CollKul[0].KullaniciAdSoyad + " tarafından VIP Liste kaydı yapıldı.";
                                    EntAr.Save();

                                    ListVipTypedList list_vip = new ListVipTypedList();
                                    ISortExpression sortvip = new SortExpression();
                                    sortvip.Add(new SortClause(VipListeFields.VipListeIslemTarih, SortOperator.Descending));
                                    list_vip.Fill(0, sortvip, true);

                                    grid_vip.DataSource = list_vip;
                                    grid_vip.DataBind();

                                    grid_vip_sil.DataSource = list_vip;
                                    grid_vip_sil.DataBind();

                                    txt_ad.Text = "";
                                    txt_tel_no.Text = "";
                                    txt_aciklama.Text = "";
                                    txt_bas_tarihi.Text = DateTime.Today.ToShortDateString();
                                    txt_bit_tarihi.Text = DateTime.Today.ToShortDateString();
                                    cb_bas_saat.Text = "";
                                    cb_bas_saat.NullText = "Seçiniz...";
                                    cb_bit_saat.Text = "";
                                    cb_bit_saat.NullText = "Seçiniz...";

                                    Session["vat_id"] = null;

                                    txt_bas_tarihi.Focus();
                                }
                            }
                        }
                    }
                }
            }
        }

        protected void k_ad_soyad_CheckedChanged(object sender, EventArgs e)
        {
            if (k_ad_soyad.Checked == true)
            {
                grid_vip.Columns[2].Visible = true;
            }

            else
            {
                grid_vip.Columns[2].Visible = false;
            }
        }

        protected void k_telefon_CheckedChanged(object sender, EventArgs e)
        {
            if (k_telefon.Checked == true)
            {
                grid_vip.Columns[3].Visible = true;
            }

            else
            {
                grid_vip.Columns[3].Visible = false;
            }
        }

        protected void k_is_kul_CheckedChanged(object sender, EventArgs e)
        {
            if (k_is_kul.Checked == true)
            {
                grid_vip.Columns[4].Visible = true;
            }

            else
            {
                grid_vip.Columns[4].Visible = false;
            }
        }

        protected void k_islem_tar_CheckedChanged(object sender, EventArgs e)
        {
            if (k_islem_tar.Checked == true)
            {
                grid_vip.Columns[5].Visible = true;
            }

            else
            {
                grid_vip.Columns[5].Visible = false;
            }
        }

        protected void k_bas_tar_CheckedChanged(object sender, EventArgs e)
        {
            if (k_bas_tar.Checked == true)
            {
                grid_vip.Columns[6].Visible = true;
            }

            else
            {
                grid_vip.Columns[6].Visible = false;
            }
        }

        protected void k_bit_tar_CheckedChanged(object sender, EventArgs e)
        {
            if (k_bit_tar.Checked == true)
            {
                grid_vip.Columns[7].Visible = true;
            }

            else
            {
                grid_vip.Columns[7].Visible = false;
            }
        }

        protected void k_aciklama_CheckedChanged(object sender, EventArgs e)
        {
            if (k_aciklama.Checked == true)
            {
                grid_vip.Columns[8].Visible = true;
            }

            else
            {
                grid_vip.Columns[8].Visible = false;
            }
        }

        protected void k_durum_CheckedChanged(object sender, EventArgs e)
        {
            if (k_durum.Checked == true)
            {
                grid_vip.Columns[9].Visible = true;
            }

            else
            {
                grid_vip.Columns[9].Visible = false;
            }
        }

        protected void k_iptal_tar_CheckedChanged(object sender, EventArgs e)
        {
            if (k_iptal_tar.Checked == true)
            {
                grid_vip.Columns[10].Visible = true;
            }

            else
            {
                grid_vip.Columns[10].Visible = false;
            }
        }

        protected void k_iptal_kul_CheckedChanged(object sender, EventArgs e)
        {
            if (k_iptal_kul.Checked == true)
            {
                grid_vip.Columns[11].Visible = true;
            }

            else
            {
                grid_vip.Columns[11].Visible = false;
            }
        }
    }
}