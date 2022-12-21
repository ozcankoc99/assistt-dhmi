using System;
using System.Web.UI;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using System.Web;

namespace Dhmi.Web
{
    public partial class KulEkstraBilgi : System.Web.UI.Page
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

        protected void btn_coz_Click(object sender, EventArgs e)
        {
            if (txt_sifre.Text == "")
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen geçerli bir şifre giriniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else
            {
                try
                {
                    string ana_sifre = txt_sifre.Text;
                    string cozulmus = "";
                    //string ara_deger = "";

                    int kal = 0;
                    int kal2 = 0;
                    int kal3 = 0;
                    int kal4 = 0;
                    int kal5 = 0;
                    int kal6 = 0;
                    int kal7 = 0;
                    int kal8 = 0;
                    int kal9 = 0;
                    int kal10 = 0;

                    for (int i = 0; i < ana_sifre.Length; i++)
                    {
                        AltKarakterCollection CollAlt = new AltKarakterCollection();
                        IPredicateExpression ExpAlt = new PredicateExpression();
                        ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterNo == ana_sifre[i].ToString());
                        CollAlt.GetMulti(ExpAlt);

                        if (CollAlt.Count > 0)
                        {
                            kal = i;
                            i = ana_sifre.Length;
                        }
                    }

                    KarakterCollection CollKar = new KarakterCollection();
                    IPredicateExpression ExpKar = new PredicateExpression();
                    ExpKar.AddWithAnd(KarakterFields.KarakterNo == ana_sifre.Substring(0, kal));
                    CollKar.GetMulti(ExpKar);

                    cozulmus = cozulmus + CollKar[0].KarakterAd.ToString();

                    for (int i = kal + 1; i < ana_sifre.Length; i++)
                    {
                        AltKarakterCollection CollAlt = new AltKarakterCollection();
                        IPredicateExpression ExpAlt = new PredicateExpression();
                        ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterNo == ana_sifre[i].ToString());
                        CollAlt.GetMulti(ExpAlt);

                        if (CollAlt.Count > 0)
                        {
                            kal2 = i;
                            i = ana_sifre.Length;
                        }
                    }

                    KarakterCollection CollKar2 = new KarakterCollection();
                    IPredicateExpression ExpKar2 = new PredicateExpression();
                    ExpKar2.AddWithAnd(KarakterFields.KarakterNo == ana_sifre.Substring(kal + 1, kal2 - kal - 1));
                    CollKar2.GetMulti(ExpKar2);

                    cozulmus = cozulmus + CollKar2[0].KarakterAd.ToString();

                    for (int i = kal2 + 1; i < ana_sifre.Length; i++)
                    {
                        AltKarakterCollection CollAlt = new AltKarakterCollection();
                        IPredicateExpression ExpAlt = new PredicateExpression();
                        ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterNo == ana_sifre[i].ToString());
                        CollAlt.GetMulti(ExpAlt);

                        if (CollAlt.Count > 0)
                        {
                            kal3 = i;
                            i = ana_sifre.Length;
                        }
                    }

                    KarakterCollection CollKar3 = new KarakterCollection();
                    IPredicateExpression ExpKar3 = new PredicateExpression();
                    ExpKar3.AddWithAnd(KarakterFields.KarakterNo == ana_sifre.Substring(kal2 + 1, kal3 - kal2 - 1));
                    CollKar3.GetMulti(ExpKar3);

                    cozulmus = cozulmus + CollKar3[0].KarakterAd.ToString();

                    for (int i = kal3 + 1; i < ana_sifre.Length; i++)
                    {
                        AltKarakterCollection CollAlt = new AltKarakterCollection();
                        IPredicateExpression ExpAlt = new PredicateExpression();
                        ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterNo == ana_sifre[i].ToString());
                        CollAlt.GetMulti(ExpAlt);

                        if (CollAlt.Count > 0)
                        {
                            kal4 = i;
                            i = ana_sifre.Length;
                        }
                    }

                    KarakterCollection CollKar4 = new KarakterCollection();
                    IPredicateExpression ExpKar4 = new PredicateExpression();
                    ExpKar4.AddWithAnd(KarakterFields.KarakterNo == ana_sifre.Substring(kal3 + 1, kal4 - kal3 - 1));
                    CollKar4.GetMulti(ExpKar4);

                    cozulmus = cozulmus + CollKar4[0].KarakterAd.ToString();

                    for (int i = kal4 + 1; i < ana_sifre.Length; i++)
                    {
                        AltKarakterCollection CollAlt = new AltKarakterCollection();
                        IPredicateExpression ExpAlt = new PredicateExpression();
                        ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterNo == ana_sifre[i].ToString());
                        CollAlt.GetMulti(ExpAlt);

                        if (CollAlt.Count > 0)
                        {
                            kal5 = i;
                            i = ana_sifre.Length;
                        }
                    }

                    KarakterCollection CollKar5 = new KarakterCollection();
                    IPredicateExpression ExpKar5 = new PredicateExpression();
                    ExpKar5.AddWithAnd(KarakterFields.KarakterNo == ana_sifre.Substring(kal4 + 1, kal5 - kal4 - 1));
                    CollKar5.GetMulti(ExpKar5);

                    cozulmus = cozulmus + CollKar5[0].KarakterAd.ToString();

                    for (int i = kal5 + 1; i < ana_sifre.Length; i++)
                    {
                        AltKarakterCollection CollAlt = new AltKarakterCollection();
                        IPredicateExpression ExpAlt = new PredicateExpression();
                        ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterNo == ana_sifre[i].ToString());
                        CollAlt.GetMulti(ExpAlt);

                        if (CollAlt.Count > 0)
                        {
                            kal6 = i;
                            i = ana_sifre.Length;
                        }
                    }

                    if (kal6 > 0)
                    {
                        KarakterCollection CollKar6 = new KarakterCollection();
                        IPredicateExpression ExpKar6 = new PredicateExpression();
                        ExpKar6.AddWithAnd(KarakterFields.KarakterNo == ana_sifre.Substring(kal5 + 1, kal6 - kal5 - 1));
                        CollKar6.GetMulti(ExpKar6);

                        cozulmus = cozulmus + CollKar6[0].KarakterAd.ToString();

                        if ((kal6 + 1 < ana_sifre.Length) && kal6 != 0)
                        {
                            for (int i = kal6 + 1; i < ana_sifre.Length; i++)
                            {
                                AltKarakterCollection CollAlt = new AltKarakterCollection();
                                IPredicateExpression ExpAlt = new PredicateExpression();
                                ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterNo == ana_sifre[i].ToString());
                                CollAlt.GetMulti(ExpAlt);

                                if (CollAlt.Count > 0)
                                {
                                    kal7 = i;
                                    i = ana_sifre.Length;
                                }
                            }
                        }

                        if (kal7 > 0)
                        {
                            KarakterCollection CollKar7 = new KarakterCollection();
                            IPredicateExpression ExpKar7 = new PredicateExpression();
                            ExpKar7.AddWithAnd(KarakterFields.KarakterNo == ana_sifre.Substring(kal6 + 1, kal7 - kal6 - 1));
                            CollKar7.GetMulti(ExpKar7);

                            cozulmus = cozulmus + CollKar7[0].KarakterAd.ToString();

                            if ((kal7 + 1 < ana_sifre.Length) && kal7 != 0)
                            {
                                for (int i = kal7 + 1; i < ana_sifre.Length; i++)
                                {
                                    AltKarakterCollection CollAlt = new AltKarakterCollection();
                                    IPredicateExpression ExpAlt = new PredicateExpression();
                                    ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterNo == ana_sifre[i].ToString());
                                    CollAlt.GetMulti(ExpAlt);

                                    if (CollAlt.Count > 0)
                                    {
                                        kal8 = i;
                                        i = ana_sifre.Length;
                                    }
                                }
                            }

                            if (kal8 > 0)
                            {
                                KarakterCollection CollKar8 = new KarakterCollection();
                                IPredicateExpression ExpKar8 = new PredicateExpression();
                                ExpKar8.AddWithAnd(KarakterFields.KarakterNo == ana_sifre.Substring(kal7 + 1, kal8 - kal7 - 1));
                                CollKar8.GetMulti(ExpKar8);

                                cozulmus = cozulmus + CollKar8[0].KarakterAd.ToString();

                                if ((kal8 + 1 < ana_sifre.Length) && kal8 != 0)
                                {
                                    for (int i = kal8 + 1; i < ana_sifre.Length; i++)
                                    {
                                        AltKarakterCollection CollAlt = new AltKarakterCollection();
                                        IPredicateExpression ExpAlt = new PredicateExpression();
                                        ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterNo == ana_sifre[i].ToString());
                                        CollAlt.GetMulti(ExpAlt);

                                        if (CollAlt.Count > 0)
                                        {
                                            kal9 = i;
                                            i = ana_sifre.Length;
                                        }
                                    }
                                }

                                if (kal9 > 0)
                                {
                                    KarakterCollection CollKar9 = new KarakterCollection();
                                    IPredicateExpression ExpKar9 = new PredicateExpression();
                                    ExpKar9.AddWithAnd(KarakterFields.KarakterNo == ana_sifre.Substring(kal8 + 1, kal9 - kal8 - 1));
                                    CollKar9.GetMulti(ExpKar9);

                                    cozulmus = cozulmus + CollKar9[0].KarakterAd.ToString();

                                    if ((kal9 + 1 < ana_sifre.Length) && kal9 != 0)
                                    {
                                        for (int i = kal9 + 1; i < ana_sifre.Length; i++)
                                        {
                                            AltKarakterCollection CollAlt = new AltKarakterCollection();
                                            IPredicateExpression ExpAlt = new PredicateExpression();
                                            ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterNo == ana_sifre[i].ToString());
                                            CollAlt.GetMulti(ExpAlt);

                                            if (CollAlt.Count > 0)
                                            {
                                                kal10 = i;
                                                i = ana_sifre.Length;
                                            }
                                        }
                                    }

                                    if (kal10 > 0)
                                    {
                                        KarakterCollection CollKar10 = new KarakterCollection();
                                        IPredicateExpression ExpKar10 = new PredicateExpression();
                                        ExpKar10.AddWithAnd(KarakterFields.KarakterNo == ana_sifre.Substring(kal9 + 1, kal10 - kal9 - 1));
                                        CollKar10.GetMulti(ExpKar10);

                                        cozulmus = cozulmus + CollKar10[0].KarakterAd.ToString();
                                    }

                                    else
                                    {
                                        KarakterCollection CollKar10 = new KarakterCollection();
                                        IPredicateExpression ExpKar10 = new PredicateExpression();
                                        ExpKar10.AddWithAnd(KarakterFields.KarakterNo == ana_sifre.Substring(kal9 + 1, ana_sifre.Length - kal9 - 1));
                                        CollKar10.GetMulti(ExpKar10);

                                        cozulmus = cozulmus + CollKar10[0].KarakterAd.ToString();
                                    }
                                }

                                else
                                {
                                    KarakterCollection CollKar9 = new KarakterCollection();
                                    IPredicateExpression ExpKar9 = new PredicateExpression();
                                    ExpKar9.AddWithAnd(KarakterFields.KarakterNo == ana_sifre.Substring(kal8 + 1, ana_sifre.Length - kal8 - 1));
                                    CollKar9.GetMulti(ExpKar9);

                                    cozulmus = cozulmus + CollKar9[0].KarakterAd.ToString();
                                }
                            }

                            else
                            {
                                KarakterCollection CollKar8 = new KarakterCollection();
                                IPredicateExpression ExpKar8 = new PredicateExpression();
                                ExpKar8.AddWithAnd(KarakterFields.KarakterNo == ana_sifre.Substring(kal7 + 1, ana_sifre.Length - kal7 - 1));
                                CollKar8.GetMulti(ExpKar8);

                                cozulmus = cozulmus + CollKar8[0].KarakterAd.ToString();
                            }
                        }

                        else
                        {
                            KarakterCollection CollKar7 = new KarakterCollection();
                            IPredicateExpression ExpKar7 = new PredicateExpression();
                            ExpKar7.AddWithAnd(KarakterFields.KarakterNo == ana_sifre.Substring(kal6 + 1, ana_sifre.Length - kal6 - 1));
                            CollKar7.GetMulti(ExpKar7);

                            cozulmus = cozulmus + CollKar7[0].KarakterAd.ToString();
                        }
                    }

                    else
                    {
                        KarakterCollection CollKar6 = new KarakterCollection();
                        IPredicateExpression ExpKar6 = new PredicateExpression();
                        ExpKar6.AddWithAnd(KarakterFields.KarakterNo == ana_sifre.Substring(kal5 + 1, ana_sifre.Length - kal5 - 1));
                        CollKar6.GetMulti(ExpKar6);

                        cozulmus = cozulmus + CollKar6[0].KarakterAd.ToString();
                    }

                    txt_cozulmus_hali.Text = cozulmus;
                }

                catch
                {
                    string CloseWindow;
                    CloseWindow = "alert('Lütfen şifre bilgisini kontrol ediniz...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }
            }
        }

        protected void btn_sifrele_Click(object sender, EventArgs e)
        {
            if (txt_ham.Text == "" || txt_ham.Text.Length > 10)
            {
                string CloseWindow;
                CloseWindow = "alert('Lütfen geçerli bir şifre giriniz...')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
            }

            else
            {
                try
                {
                    Random rastgele = new Random();
                    Int32 sayi = 0;

                    string bas = txt_ham.Text;
                    string hash = "";

                    if (txt_ham.Text.Length > 0)
                    {
                        DbFunctionCall collatedCast = new DbFunctionCall("CAST({0} AS varchar) COLLATE SQL_Latin1_General_CP1_CS_AS", new object[] { KarakterFields.KarakterAd });

                        KarakterCollection CollKart = new KarakterCollection();
                        IPredicateExpression ExpKart = new PredicateExpression();

                        if (bas[0].ToString() == "ı" || bas[0].ToString() == "i" || bas[0].ToString() == "ş" || bas[0].ToString() == "ğ")
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd == bas[0].ToString());
                        }

                        else
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd.SetExpression(collatedCast) == bas[0].ToString());
                        }

                        CollKart.GetMulti(ExpKart);

                        hash = hash + CollKart[0].KarakterNo.ToString();

                        sayi = rastgele.Next(100000, 999999);
                        sayi = sayi % 10;

                        AltKarakterCollection CollAlt = new AltKarakterCollection();
                        IPredicateExpression ExpAlt = new PredicateExpression();
                        ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterAd == sayi.ToString());
                        CollAlt.GetMulti(ExpAlt);

                        hash = hash + CollAlt[0].AltKarakterNo;
                    }

                    if (txt_ham.Text.Length > 1)
                    {
                        DbFunctionCall collatedCast = new DbFunctionCall("CAST({0} AS varchar) COLLATE SQL_Latin1_General_CP1_CS_AS", new object[] { KarakterFields.KarakterAd });

                        KarakterCollection CollKart = new KarakterCollection();
                        IPredicateExpression ExpKart = new PredicateExpression();
                        if (bas[1].ToString() == "i" || bas[1].ToString() == "ı" || bas[1].ToString() == "ş" || bas[1].ToString() == "Ş" || bas[1].ToString() == "ğ" || bas[1].ToString() == "Ğ")
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd == bas[1].ToString());
                        }

                        else
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd.SetExpression(collatedCast) == bas[1].ToString());
                        }
                        CollKart.GetMulti(ExpKart);

                        hash = hash + CollKart[0].KarakterNo.ToString();

                        sayi = rastgele.Next(100000, 999999);
                        sayi = sayi % 10;

                        AltKarakterCollection CollAlt = new AltKarakterCollection();
                        IPredicateExpression ExpAlt = new PredicateExpression();
                        ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterAd == sayi.ToString());
                        CollAlt.GetMulti(ExpAlt);

                        hash = hash + CollAlt[0].AltKarakterNo;
                    }

                    if (txt_ham.Text.Length > 2)
                    {
                        DbFunctionCall collatedCast = new DbFunctionCall("CAST({0} AS varchar) COLLATE SQL_Latin1_General_CP1_CS_AS", new object[] { KarakterFields.KarakterAd });

                        KarakterCollection CollKart = new KarakterCollection();
                        IPredicateExpression ExpKart = new PredicateExpression();
                        if (bas[2].ToString() == "i" || bas[2].ToString() == "ı" || bas[2].ToString() == "ş" || bas[2].ToString() == "Ş" || bas[2].ToString() == "ğ" || bas[2].ToString() == "Ğ")
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd == bas[2].ToString());
                        }

                        else
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd.SetExpression(collatedCast) == bas[2].ToString());
                        }
                        CollKart.GetMulti(ExpKart);

                        hash = hash + CollKart[0].KarakterNo.ToString();

                        sayi = rastgele.Next(100000, 999999);
                        sayi = sayi % 10;

                        AltKarakterCollection CollAlt = new AltKarakterCollection();
                        IPredicateExpression ExpAlt = new PredicateExpression();
                        ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterAd == sayi.ToString());
                        CollAlt.GetMulti(ExpAlt);

                        hash = hash + CollAlt[0].AltKarakterNo;
                    }

                    if (txt_ham.Text.Length > 3)
                    {
                        DbFunctionCall collatedCast = new DbFunctionCall("CAST({0} AS varchar) COLLATE SQL_Latin1_General_CP1_CS_AS", new object[] { KarakterFields.KarakterAd });

                        KarakterCollection CollKart = new KarakterCollection();
                        IPredicateExpression ExpKart = new PredicateExpression();
                        if (bas[3].ToString() == "i" || bas[3].ToString() == "ı" || bas[3].ToString() == "ş" || bas[3].ToString() == "Ş" || bas[3].ToString() == "ğ" || bas[3].ToString() == "Ğ")
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd == bas[3].ToString());
                        }

                        else
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd.SetExpression(collatedCast) == bas[3].ToString());
                        }
                        CollKart.GetMulti(ExpKart);

                        hash = hash + CollKart[0].KarakterNo.ToString();

                        sayi = rastgele.Next(100000, 999999);
                        sayi = sayi % 10;

                        AltKarakterCollection CollAlt = new AltKarakterCollection();
                        IPredicateExpression ExpAlt = new PredicateExpression();
                        ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterAd == sayi.ToString());
                        CollAlt.GetMulti(ExpAlt);

                        hash = hash + CollAlt[0].AltKarakterNo;
                    }

                    if (txt_ham.Text.Length > 4)
                    {
                        DbFunctionCall collatedCast = new DbFunctionCall("CAST({0} AS varchar) COLLATE SQL_Latin1_General_CP1_CS_AS", new object[] { KarakterFields.KarakterAd });

                        KarakterCollection CollKart = new KarakterCollection();
                        IPredicateExpression ExpKart = new PredicateExpression();
                        if (bas[4].ToString() == "i" || bas[4].ToString() == "ı" || bas[4].ToString() == "ş" || bas[4].ToString() == "Ş" || bas[4].ToString() == "ğ" || bas[4].ToString() == "Ğ")
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd == bas[4].ToString());
                        }

                        else
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd.SetExpression(collatedCast) == bas[4].ToString());
                        }
                        CollKart.GetMulti(ExpKart);

                        hash = hash + CollKart[0].KarakterNo.ToString();

                        sayi = rastgele.Next(100000, 999999);
                        sayi = sayi % 10;

                        AltKarakterCollection CollAlt = new AltKarakterCollection();
                        IPredicateExpression ExpAlt = new PredicateExpression();
                        ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterAd == sayi.ToString());
                        CollAlt.GetMulti(ExpAlt);

                        hash = hash + CollAlt[0].AltKarakterNo;
                    }

                    if (txt_ham.Text.Length > 5)
                    {
                        DbFunctionCall collatedCast = new DbFunctionCall("CAST({0} AS varchar) COLLATE SQL_Latin1_General_CP1_CS_AS", new object[] { KarakterFields.KarakterAd });

                        KarakterCollection CollKart = new KarakterCollection();
                        IPredicateExpression ExpKart = new PredicateExpression();
                        if (bas[5].ToString() == "i" || bas[5].ToString() == "ı" || bas[5].ToString() == "ş" || bas[5].ToString() == "Ş" || bas[5].ToString() == "ğ" || bas[5].ToString() == "Ğ")
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd == bas[5].ToString());
                        }

                        else
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd.SetExpression(collatedCast) == bas[5].ToString());
                        }
                        CollKart.GetMulti(ExpKart);

                        hash = hash + CollKart[0].KarakterNo.ToString();

                        sayi = rastgele.Next(100000, 999999);
                        sayi = sayi % 10;

                        AltKarakterCollection CollAlt = new AltKarakterCollection();
                        IPredicateExpression ExpAlt = new PredicateExpression();
                        ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterAd == sayi.ToString());
                        CollAlt.GetMulti(ExpAlt);

                        if (txt_ham.Text.Length != 6)
                        {
                            hash = hash + CollAlt[0].AltKarakterNo;
                        }
                    }

                    if (txt_ham.Text.Length > 6)
                    {
                        DbFunctionCall collatedCast = new DbFunctionCall("CAST({0} AS varchar) COLLATE SQL_Latin1_General_CP1_CS_AS", new object[] { KarakterFields.KarakterAd });

                        KarakterCollection CollKart = new KarakterCollection();
                        IPredicateExpression ExpKart = new PredicateExpression();
                        if (bas[6].ToString() == "i" || bas[6].ToString() == "ı" || bas[6].ToString() == "ş" || bas[6].ToString() == "Ş" || bas[6].ToString() == "ğ" || bas[6].ToString() == "Ğ")
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd == bas[6].ToString());
                        }

                        else
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd.SetExpression(collatedCast) == bas[6].ToString());
                        }
                        CollKart.GetMulti(ExpKart);

                        hash = hash + CollKart[0].KarakterNo.ToString();

                        sayi = rastgele.Next(100000, 999999);
                        sayi = sayi % 10;

                        AltKarakterCollection CollAlt = new AltKarakterCollection();
                        IPredicateExpression ExpAlt = new PredicateExpression();
                        ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterAd == sayi.ToString());
                        CollAlt.GetMulti(ExpAlt);

                        if (txt_ham.Text.Length != 7)
                        {
                            hash = hash + CollAlt[0].AltKarakterNo;
                        }
                    }

                    if (txt_ham.Text.Length > 7)
                    {
                        DbFunctionCall collatedCast = new DbFunctionCall("CAST({0} AS varchar) COLLATE SQL_Latin1_General_CP1_CS_AS", new object[] { KarakterFields.KarakterAd });

                        KarakterCollection CollKart = new KarakterCollection();
                        IPredicateExpression ExpKart = new PredicateExpression();
                        if (bas[7].ToString() == "i" || bas[7].ToString() == "ı" || bas[7].ToString() == "ş" || bas[7].ToString() == "Ş" || bas[7].ToString() == "ğ" || bas[7].ToString() == "Ğ")
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd == bas[7].ToString());
                        }

                        else
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd.SetExpression(collatedCast) == bas[7].ToString());
                        }
                        CollKart.GetMulti(ExpKart);

                        hash = hash + CollKart[0].KarakterNo.ToString();

                        sayi = rastgele.Next(100000, 999999);
                        sayi = sayi % 10;

                        AltKarakterCollection CollAlt = new AltKarakterCollection();
                        IPredicateExpression ExpAlt = new PredicateExpression();
                        ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterAd == sayi.ToString());
                        CollAlt.GetMulti(ExpAlt);

                        if (txt_ham.Text.Length != 8)
                        {
                            hash = hash + CollAlt[0].AltKarakterNo;
                        }
                    }

                    if (txt_ham.Text.Length > 8)
                    {
                        DbFunctionCall collatedCast = new DbFunctionCall("CAST({0} AS varchar) COLLATE SQL_Latin1_General_CP1_CS_AS", new object[] { KarakterFields.KarakterAd });

                        KarakterCollection CollKart = new KarakterCollection();
                        IPredicateExpression ExpKart = new PredicateExpression();
                        if (bas[8].ToString() == "i" || bas[8].ToString() == "ı" || bas[8].ToString() == "ş" || bas[8].ToString() == "Ş" || bas[8].ToString() == "ğ" || bas[8].ToString() == "Ğ")
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd == bas[8].ToString());
                        }

                        else
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd.SetExpression(collatedCast) == bas[8].ToString());
                        }
                        CollKart.GetMulti(ExpKart);

                        hash = hash + CollKart[0].KarakterNo.ToString();

                        sayi = rastgele.Next(100000, 999999);
                        sayi = sayi % 10;

                        AltKarakterCollection CollAlt = new AltKarakterCollection();
                        IPredicateExpression ExpAlt = new PredicateExpression();
                        ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterAd == sayi.ToString());
                        CollAlt.GetMulti(ExpAlt);

                        if (txt_ham.Text.Length != 9)
                        {
                            hash = hash + CollAlt[0].AltKarakterNo;
                        }
                    }

                    if (txt_ham.Text.Length > 9)
                    {
                        DbFunctionCall collatedCast = new DbFunctionCall("CAST({0} AS varchar) COLLATE SQL_Latin1_General_CP1_CS_AS", new object[] { KarakterFields.KarakterAd });

                        KarakterCollection CollKart = new KarakterCollection();
                        IPredicateExpression ExpKart = new PredicateExpression();
                        if (bas[9].ToString() == "i" || bas[9].ToString() == "ı" || bas[9].ToString() == "ş" || bas[9].ToString() == "Ş" || bas[9].ToString() == "ğ" || bas[9].ToString() == "Ğ")
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd == bas[9].ToString());
                        }

                        else
                        {
                            ExpKart.AddWithAnd(KarakterFields.KarakterAd.SetExpression(collatedCast) == bas[9].ToString());
                        }
                        CollKart.GetMulti(ExpKart);

                        hash = hash + CollKart[0].KarakterNo.ToString();

                        sayi = rastgele.Next(100000, 999999);
                        sayi = sayi % 10;

                        AltKarakterCollection CollAlt = new AltKarakterCollection();
                        IPredicateExpression ExpAlt = new PredicateExpression();
                        ExpAlt.AddWithAnd(AltKarakterFields.AltKarakterAd == sayi.ToString());
                        CollAlt.GetMulti(ExpAlt);

                        if (txt_ham.Text.Length != 10)
                        {
                            hash = hash + CollAlt[0].AltKarakterNo;
                        }
                    }

                    txt_hash.Text = hash;
                }

                catch
                {
                    string CloseWindow;
                    CloseWindow = "alert('Lütfen şifre bilgisini kontrol ediniz...')";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "CloseWindow", CloseWindow, true);
                }
            }
        }
    }
}