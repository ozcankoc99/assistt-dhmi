using System;
using System.Web.UI;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using dhmi.TypedListClasses;
using System.Web;

namespace Dhmi.Web
{
    public partial class McYrBilgiBankasiIslemleri : System.Web.UI.Page
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
                cb_bil_tur.Items.Clear();

                KullaniciCollection CollKul = new KullaniciCollection();
                IPredicateExpression ExpKul = new PredicateExpression();
                ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
                CollKul.GetMulti(ExpKul);

                ListBilgiTypedList eg_bil = new ListBilgiTypedList();
                ISortExpression sortss = new SortExpression();
                IPredicateExpression expbil = new PredicateExpression();
                sortss.Add(new SortClause(BilgiBankasiTurFields.BilgiBankasiTurAd, SortOperator.Ascending));
                sortss.Add(new SortClause(BilgiBankasiFields.BilgiBankasiAd, SortOperator.Ascending));

                if (CollKul[0].KullaniciBirim.IndexOf("Havalim") != -1)
                {
                    cb_bil_tur.Items.Add("Doküman Arşivi");
                    expbil.AddWithAnd(BilgiBankasiTurFields.BilgiBankasiTurAd == "Doküman Arşivi");
                    eg_bil.Fill(0, sortss, true, expbil);
                }

                else if (CollKul[0].KullaniciBirim == "" || CollKul[0].KullaniciBirim == "Backoffice")
                {
                    BilgiBankasiTurCollection CollTur = new BilgiBankasiTurCollection();
                    ISortExpression sorttur = new SortExpression();
                    sorttur.Add(new SortClause(BilgiBankasiTurFields.BilgiBankasiTurAd, SortOperator.Ascending));
                    CollTur.GetMulti(null, 0, sorttur);

                    cb_bil_tur.Items.Clear();

                    for (int i = 0; i < CollTur.Count; i++)
                    {
                        cb_bil_tur.Items.Add(CollTur[i].BilgiBankasiTurAd);
                    }

                    eg_bil.Fill(0, sortss, true);
                }

                else
                {
                    expbil.AddWithAnd(BilgiBankasiTurFields.BilgiBankasiTurAd == CollKul[0].KullaniciBirim);

                    cb_bil_tur.Items.Add(CollKul[0].KullaniciBirim);
                    cb_bil_tur.Items.Add("Doküman Arşivi");

                    eg_bil.Fill(0, sortss, true, expbil);
                }

                for (int i = 0; i < eg_bil.Count; i++)
                {
                    string baslik = eg_bil[i].BilgiBankasiTurAd + " - " + eg_bil[i].BilgiBankasiAd;

                    ASPxNavBar1.Groups.Add(baslik);
                    ASPxNavBar1.Groups[i].Items.Add(eg_bil[i].BilgiBankasiIcerik);

                    int say = 0;

                    if (eg_bil[i].BilgiBankasiEtiket != "-")
                    {
                        ASPxNavBar1.Groups[i].Items.Add(eg_bil[i].BilgiBankasiEtiket);
                        ASPxNavBar1.Groups[i].Items[1].Image.Url = "~/Content/Images/load.png";
                        ASPxNavBar1.Groups[i].Items[1].ToolTip = "Etiketler";

                        say = 1;
                    }

                    if (eg_bil[i].BilgiBankasiDosya != "-")
                    {
                        ASPxNavBar1.Groups[i].Items.Add(eg_bil[i].BilgiBankasiDosya);
                        ASPxNavBar1.Groups[i].Items[say + 1].Image.Url = "~/Content/Images/ekivar.png";
                        ASPxNavBar1.Groups[i].Items[say + 1].NavigateUrl = "~/Content/Information/" + eg_bil[i].BilgiBankasiDosya;
                        ASPxNavBar1.Groups[i].Items[say + 1].ToolTip = "Dosya";
                    }
                }
            }
        }

        protected void btn_sorgula_Click(object sender, EventArgs e)
        {
            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            if (cb_bil_tur.Text == "" && txt_anahtar_kelime.Text == "")
            {
                string CloseWindow2;
                CloseWindow2 = "alert('Lütfen geçerli bir Anahtar Kelime yazınız ya da Bilgi Bankası Türü seçiniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow2, true);
            }

            else
            {
                string aradim = "%" + txt_anahtar_kelime.Text + "%";

                int bas_ekle = 0;

                ListBilgiTypedList eg_bil2 = new ListBilgiTypedList();
                ISortExpression sortss2 = new SortExpression();
                IPredicateExpression filter2 = new PredicateExpression();
                sortss2.Add(new SortClause(BilgiBankasiTurFields.BilgiBankasiTurAd, SortOperator.Ascending));
                sortss2.Add(new SortClause(BilgiBankasiFields.BilgiBankasiAd, SortOperator.Ascending));

                if (cb_bil_tur.Text != "")
                {
                    filter2.AddWithAnd(BilgiBankasiTurFields.BilgiBankasiTurAd == cb_bil_tur.Text);
                }

                filter2.AddWithAnd(new FieldLikePredicate(BilgiBankasiFields.BilgiBankasiAd, null, aradim));
                eg_bil2.Fill(0, sortss2, true, filter2);

                for (int i = 0; i < eg_bil2.Count; i++)
                {
                    if (CollKul[0].KullaniciBirim.IndexOf("Havalim") != -1)
                    {
                        if (eg_bil2[i].BilgiBankasiTurAd == "Doküman Arşivi")
                        {
                            string baslik = eg_bil2[i].BilgiBankasiTurAd + " - " + eg_bil2[i].BilgiBankasiAd;

                            ASPxNavBar1.Groups.Add(baslik);
                            ASPxNavBar1.Groups[bas_ekle].Items.Add(eg_bil2[i].BilgiBankasiIcerik);

                            int say = 0;

                            if (eg_bil2[i].BilgiBankasiEtiket != "-")
                            {
                                ASPxNavBar1.Groups[bas_ekle].Items.Add(eg_bil2[i].BilgiBankasiEtiket);
                                ASPxNavBar1.Groups[bas_ekle].Items[1].Image.Url = "~/Content/Images/load.png";
                                ASPxNavBar1.Groups[bas_ekle].Items[1].ToolTip = "Etiketler";

                                say = say + 1;
                            }

                            if (eg_bil2[i].BilgiBankasiDosya != "-")
                            {
                                ASPxNavBar1.Groups[bas_ekle].Items.Add(eg_bil2[i].BilgiBankasiDosya);
                                ASPxNavBar1.Groups[bas_ekle].Items[say + 1].Image.Url = "~/Content/Images/ekivar.png";
                                ASPxNavBar1.Groups[bas_ekle].Items[say + 1].NavigateUrl = "~/Content/Information/" + eg_bil2[i].BilgiBankasiDosya;
                                ASPxNavBar1.Groups[bas_ekle].Items[say + 1].ToolTip = "Dosya";
                            }

                            bas_ekle = bas_ekle + 1;
                        }
                    }

                    else if (CollKul[0].KullaniciBirim == "" || CollKul[0].KullaniciBirim == "Backoffice")
                    {
                        string baslik = eg_bil2[i].BilgiBankasiTurAd + " - " + eg_bil2[i].BilgiBankasiAd;

                        ASPxNavBar1.Groups.Add(baslik);
                        ASPxNavBar1.Groups[bas_ekle].Items.Add(eg_bil2[i].BilgiBankasiIcerik);

                        int say = 0;

                        if (eg_bil2[i].BilgiBankasiEtiket != "-")
                        {
                            ASPxNavBar1.Groups[bas_ekle].Items.Add(eg_bil2[i].BilgiBankasiEtiket);
                            ASPxNavBar1.Groups[bas_ekle].Items[1].Image.Url = "~/Content/Images/load.png";
                            ASPxNavBar1.Groups[bas_ekle].Items[1].ToolTip = "Etiketler";

                            say = say + 1;
                        }

                        if (eg_bil2[i].BilgiBankasiDosya != "-")
                        {
                            ASPxNavBar1.Groups[bas_ekle].Items.Add(eg_bil2[i].BilgiBankasiDosya);
                            ASPxNavBar1.Groups[bas_ekle].Items[say + 1].Image.Url = "~/Content/Images/ekivar.png";
                            ASPxNavBar1.Groups[bas_ekle].Items[say + 1].NavigateUrl = "~/Content/Information/" + eg_bil2[i].BilgiBankasiDosya;
                            ASPxNavBar1.Groups[bas_ekle].Items[say + 1].ToolTip = "Dosya";
                        }

                        bas_ekle = bas_ekle + 1;
                    }

                    else
                    {
                        if (eg_bil2[i].BilgiBankasiTurAd == "Doküman Arşivi" || eg_bil2[i].BilgiBankasiTurAd == CollKul[0].KullaniciBirim)
                        {
                            string baslik = eg_bil2[i].BilgiBankasiTurAd + " - " + eg_bil2[i].BilgiBankasiAd;

                            ASPxNavBar1.Groups.Add(baslik);
                            ASPxNavBar1.Groups[bas_ekle].Items.Add(eg_bil2[i].BilgiBankasiIcerik);

                            int say = 0;

                            if (eg_bil2[i].BilgiBankasiEtiket != "-")
                            {
                                ASPxNavBar1.Groups[bas_ekle].Items.Add(eg_bil2[i].BilgiBankasiEtiket);
                                ASPxNavBar1.Groups[bas_ekle].Items[1].Image.Url = "~/Content/Images/load.png";
                                ASPxNavBar1.Groups[bas_ekle].Items[1].ToolTip = "Etiketler";

                                say = say + 1;
                            }

                            if (eg_bil2[i].BilgiBankasiDosya != "-")
                            {
                                ASPxNavBar1.Groups[bas_ekle].Items.Add(eg_bil2[i].BilgiBankasiDosya);
                                ASPxNavBar1.Groups[bas_ekle].Items[say + 1].Image.Url = "~/Content/Images/ekivar.png";
                                ASPxNavBar1.Groups[bas_ekle].Items[say + 1].NavigateUrl = "~/Content/Information/" + eg_bil2[i].BilgiBankasiDosya;
                                ASPxNavBar1.Groups[bas_ekle].Items[say + 1].ToolTip = "Dosya";
                            }

                            bas_ekle = bas_ekle + 1;
                        }
                    }
                }

                //ikinciyi ekledim

                ListBilgiTypedList eg_bil = new ListBilgiTypedList();
                ISortExpression sortss = new SortExpression();
                IPredicateExpression filter = new PredicateExpression();
                sortss.Add(new SortClause(BilgiBankasiTurFields.BilgiBankasiTurAd, SortOperator.Ascending));
                sortss.Add(new SortClause(BilgiBankasiFields.BilgiBankasiAd, SortOperator.Ascending));

                if (cb_bil_tur.Text != "")
                {
                    filter.AddWithAnd(BilgiBankasiTurFields.BilgiBankasiTurAd == cb_bil_tur.Text);
                }

                filter.AddWithAnd(new FieldLikePredicate(BilgiBankasiFields.BilgiBankasiIcerik, null, aradim));
                eg_bil.Fill(0, sortss, true, filter);

                int aradaki = 0;

                for (int i = 0; i < eg_bil.Count; i++)
                {
                    if (CollKul[0].KullaniciBirim.IndexOf("Havalim") != -1)
                    {
                        if (cb_bil_tur.Text == "")
                        {
                            if (eg_bil[i].BilgiBankasiTurAd == "Doküman Arşivi")
                            {
                                string baslik = eg_bil[i].BilgiBankasiTurAd + " - " + eg_bil[i].BilgiBankasiAd;

                                int y = 0;

                                for (int j = 0; j < ASPxNavBar1.Groups.Count; j++)
                                {
                                    if (ASPxNavBar1.Groups[j].Items[0].Text == eg_bil[i].BilgiBankasiIcerik)
                                    {
                                        y = y + 1;
                                    }
                                }

                                if (y == 0)
                                {
                                    ASPxNavBar1.Groups.Add(baslik);
                                    ASPxNavBar1.Groups[aradaki + bas_ekle].Items.Add(eg_bil[i].BilgiBankasiIcerik);

                                    int say = 0;

                                    if (eg_bil[i].BilgiBankasiEtiket != "-")
                                    {
                                        ASPxNavBar1.Groups[aradaki + bas_ekle].Items.Add(eg_bil[i].BilgiBankasiEtiket);
                                        ASPxNavBar1.Groups[aradaki + bas_ekle].Items[1].Image.Url = "~/Content/Images/load.png";
                                        ASPxNavBar1.Groups[aradaki + bas_ekle].Items[1].ToolTip = "Etiketler";

                                        say = say + 1;
                                    }

                                    if (eg_bil[i].BilgiBankasiDosya != "-")
                                    {
                                        ASPxNavBar1.Groups[aradaki + bas_ekle].Items.Add(eg_bil[i].BilgiBankasiDosya);
                                        ASPxNavBar1.Groups[aradaki + bas_ekle].Items[say + 1].Image.Url = "~/Content/Images/ekivar.png";
                                        ASPxNavBar1.Groups[aradaki + bas_ekle].Items[say + 1].NavigateUrl = "~/Content/Information/" + eg_bil[i].BilgiBankasiDosya;
                                        ASPxNavBar1.Groups[aradaki + bas_ekle].Items[say + 1].ToolTip = "Dosya";
                                    }

                                    aradaki = aradaki + 1;
                                }
                            }
                        }
                    }

                    else if (CollKul[0].KullaniciBirim == "" || CollKul[0].KullaniciBirim == "Backoffice")
                    {
                        string baslik = eg_bil[i].BilgiBankasiTurAd + " - " + eg_bil[i].BilgiBankasiAd;

                        int y = 0;

                        for (int j = 0; j < ASPxNavBar1.Groups.Count; j++)
                        {
                            if (ASPxNavBar1.Groups[j].Items[0].Text == eg_bil[i].BilgiBankasiIcerik)
                            {
                                y = y + 1;
                            }
                        }

                        if (y == 0)
                        {
                            ASPxNavBar1.Groups.Add(baslik);
                            ASPxNavBar1.Groups[aradaki + bas_ekle].Items.Add(eg_bil[i].BilgiBankasiIcerik);

                            int say = 0;

                            if (eg_bil[i].BilgiBankasiEtiket != "-")
                            {
                                ASPxNavBar1.Groups[aradaki + bas_ekle].Items.Add(eg_bil[i].BilgiBankasiEtiket);
                                ASPxNavBar1.Groups[aradaki + bas_ekle].Items[1].Image.Url = "~/Content/Images/load.png";
                                ASPxNavBar1.Groups[aradaki + bas_ekle].Items[1].ToolTip = "Etiketler";

                                say = say + 1;
                            }

                            if (eg_bil[i].BilgiBankasiDosya != "-")
                            {
                                ASPxNavBar1.Groups[aradaki + bas_ekle].Items.Add(eg_bil[i].BilgiBankasiDosya);
                                ASPxNavBar1.Groups[aradaki + bas_ekle].Items[say + 1].Image.Url = "~/Content/Images/ekivar.png";
                                ASPxNavBar1.Groups[aradaki + bas_ekle].Items[say + 1].NavigateUrl = "~/Content/Information/" + eg_bil[i].BilgiBankasiDosya;
                                ASPxNavBar1.Groups[aradaki + bas_ekle].Items[say + 1].ToolTip = "Dosya";
                            }

                            aradaki = aradaki + 1;
                        }
                    }

                    else
                    {
                        if (eg_bil[i].BilgiBankasiTurAd == "Doküman Arşivi" || eg_bil[i].BilgiBankasiTurAd == CollKul[0].KullaniciBirim)
                        {
                            string baslik = eg_bil[i].BilgiBankasiTurAd + " - " + eg_bil[i].BilgiBankasiAd;

                            int y = 0;

                            for (int j = 0; j < ASPxNavBar1.Groups.Count; j++)
                            {
                                if (ASPxNavBar1.Groups[j].Items[0].Text == eg_bil[i].BilgiBankasiIcerik)
                                {
                                    y = y + 1;
                                }
                            }

                            if (y == 0)
                            {
                                ASPxNavBar1.Groups.Add(baslik);
                                ASPxNavBar1.Groups[aradaki + bas_ekle].Items.Add(eg_bil[i].BilgiBankasiIcerik);

                                int say = 0;

                                if (eg_bil[i].BilgiBankasiEtiket != "-")
                                {
                                    ASPxNavBar1.Groups[aradaki + bas_ekle].Items.Add(eg_bil[i].BilgiBankasiEtiket);
                                    ASPxNavBar1.Groups[aradaki + bas_ekle].Items[1].Image.Url = "~/Content/Images/load.png";
                                    ASPxNavBar1.Groups[aradaki + bas_ekle].Items[1].ToolTip = "Etiketler";

                                    say = say + 1;
                                }

                                if (eg_bil[i].BilgiBankasiDosya != "-")
                                {
                                    ASPxNavBar1.Groups[aradaki + bas_ekle].Items.Add(eg_bil[i].BilgiBankasiDosya);
                                    ASPxNavBar1.Groups[aradaki + bas_ekle].Items[say + 1].Image.Url = "~/Content/Images/ekivar.png";
                                    ASPxNavBar1.Groups[aradaki + bas_ekle].Items[say + 1].NavigateUrl = "~/Content/Information/" + eg_bil[i].BilgiBankasiDosya;
                                    ASPxNavBar1.Groups[aradaki + bas_ekle].Items[say + 1].ToolTip = "Dosya";
                                }

                                aradaki = aradaki + 1;
                            }
                        }
                    }
                }
            }
        }

        protected void btn_temizle_Click(object sender, EventArgs e)
        {
            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == Convert.ToInt16(Session["kullanici_var_mi"].ToString()));
            CollKul.GetMulti(ExpKul);

            ListBilgiTypedList eg_bil = new ListBilgiTypedList();
            ISortExpression sortss = new SortExpression();
            IPredicateExpression expbil = new PredicateExpression();
            sortss.Add(new SortClause(BilgiBankasiTurFields.BilgiBankasiTurAd, SortOperator.Ascending));
            sortss.Add(new SortClause(BilgiBankasiFields.BilgiBankasiAd, SortOperator.Ascending));

            if (CollKul[0].KullaniciBirim.IndexOf("Havalim") != -1)
            {
                expbil.AddWithAnd(BilgiBankasiTurFields.BilgiBankasiTurAd == "Doküman Arşivi");
                eg_bil.Fill(0, sortss, true, expbil);
            }

            else if (CollKul[0].KullaniciBirim == "" || CollKul[0].KullaniciBirim == "Backoffice")
            {
                eg_bil.Fill(0, sortss, true);
            }

            else
            {
                expbil.AddWithAnd(BilgiBankasiTurFields.BilgiBankasiTurAd == CollKul[0].KullaniciBirim);
                eg_bil.Fill(0, sortss, true, expbil);
            }

            for (int i = 0; i < eg_bil.Count; i++)
            {
                string baslik = eg_bil[i].BilgiBankasiTurAd + " - " + eg_bil[i].BilgiBankasiAd;

                ASPxNavBar1.Groups.Add(baslik);
                ASPxNavBar1.Groups[i].Items.Add(eg_bil[i].BilgiBankasiIcerik);

                int say = 0;

                if (eg_bil[i].BilgiBankasiEtiket != "-")
                {
                    ASPxNavBar1.Groups[i].Items.Add(eg_bil[i].BilgiBankasiEtiket);
                    ASPxNavBar1.Groups[i].Items[1].Image.Url = "~/Content/Images/load.png";
                    ASPxNavBar1.Groups[i].Items[1].ToolTip = "Etiketler";

                    say = say + 1;
                }

                if (eg_bil[i].BilgiBankasiDosya != "-")
                {
                    ASPxNavBar1.Groups[i].Items.Add(eg_bil[i].BilgiBankasiDosya);
                    ASPxNavBar1.Groups[i].Items[say + 1].Image.Url = "~/Content/Images/ekivar.png";
                    ASPxNavBar1.Groups[i].Items[say + 1].NavigateUrl = "~/Content/Information/" + eg_bil[i].BilgiBankasiDosya;
                    ASPxNavBar1.Groups[i].Items[say + 1].ToolTip = "Dosya";
                }
            }

            txt_anahtar_kelime.Text = "";
            cb_bil_tur.Text = "";
            cb_bil_tur.NullText = "Seçiniz...";
        }

        protected void cb_bil_tur_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBilgiTypedList eg_bil = new ListBilgiTypedList();
            ISortExpression sortss = new SortExpression();
            IPredicateExpression filter = new PredicateExpression();
            sortss.Add(new SortClause(BilgiBankasiTurFields.BilgiBankasiTurAd, SortOperator.Ascending));
            sortss.Add(new SortClause(BilgiBankasiFields.BilgiBankasiAd, SortOperator.Ascending));
            filter.AddWithAnd(BilgiBankasiTurFields.BilgiBankasiTurAd == cb_bil_tur.Text);
            eg_bil.Fill(0, sortss, true, filter);

            for (int i = 0; i < eg_bil.Count; i++)
            {
                string baslik = eg_bil[i].BilgiBankasiTurAd + " - " + eg_bil[i].BilgiBankasiAd;

                ASPxNavBar1.Groups.Add(baslik);
                ASPxNavBar1.Groups[i].Items.Add(eg_bil[i].BilgiBankasiIcerik);

                int say = 0;

                if (eg_bil[i].BilgiBankasiEtiket != "-")
                {
                    ASPxNavBar1.Groups[i].Items.Add(eg_bil[i].BilgiBankasiEtiket);
                    ASPxNavBar1.Groups[i].Items[1].Image.Url = "~/Content/Images/load.png";
                    ASPxNavBar1.Groups[i].Items[1].ToolTip = "Etiketler";

                    say = say + 1;
                }

                if (eg_bil[i].BilgiBankasiDosya != "-")
                {
                    ASPxNavBar1.Groups[i].Items.Add(eg_bil[i].BilgiBankasiDosya);
                    ASPxNavBar1.Groups[i].Items[say + 1].Image.Url = "~/Content/Images/ekivar.png";
                    ASPxNavBar1.Groups[i].Items[say + 1].NavigateUrl = "~/Content/Information/" + eg_bil[i].BilgiBankasiDosya;
                    ASPxNavBar1.Groups[i].Items[say + 1].ToolTip = "Dosya";
                }
            }
        }
    }
}