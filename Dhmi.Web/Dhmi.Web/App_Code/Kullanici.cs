using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Web.UI;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;

namespace Dhmi.Web
{
    public class Kullanici
    {
        static int idsi = 0;        

        public static int KullaniciGetirUnuttum(string k_adi, string mail)
        {
            KullaniciCollection CollKull = new KullaniciCollection();
            IPredicateExpression ExpKull = new PredicateExpression();
            ExpKull.AddWithAnd(KullaniciFields.KullaniciUsername == k_adi);
            ExpKull.AddWithAnd(KullaniciFields.KullaniciMail == mail);
            ExpKull.AddWithAnd(KullaniciFields.KullaniciDurum == true);
            CollKull.GetMulti(ExpKull);

            if (CollKull.Count > 0)
            {
                idsi = CollKull[0].KullaniciId;
            }

            else
            {
                idsi = 0;
            }

            return idsi;
        }

        public static int KullaniciGetirKullaniciAdi(string k_adi)
        {
            KullaniciCollection CollKull = new KullaniciCollection();
            IPredicateExpression ExpKull = new PredicateExpression();
            ExpKull.AddWithAnd(KullaniciFields.KullaniciUsername == k_adi);
            ExpKull.AddWithAnd(KullaniciFields.KullaniciDurum == true);
            CollKull.GetMulti(ExpKull);

            if (CollKull.Count > 0)
            {
                idsi = CollKull[0].KullaniciId;
            }

            else
            {
                idsi = 0;
            }

            return idsi;
        }

        public static int KullaniciGetir(string k_adi, string sifre)
        {
            KullaniciCollection CollKull = new KullaniciCollection();
            IPredicateExpression ExpKull = new PredicateExpression();
            ExpKull.AddWithAnd(KullaniciFields.KullaniciUsername == k_adi);
            ExpKull.AddWithAnd(KullaniciFields.KullaniciDurum == true);
            CollKull.GetMulti(ExpKull);

            if (CollKull.Count > 0)
            {
                string passi = sifre_coz(CollKull[0].KullaniciPassword);

                int arkadan_gelen = 0;

                for (int i = 0; i < sifre.Length; i++)
                {
                    if (sifre[i].ToString() == "ı" || sifre[i].ToString() == "ş" || sifre[i].ToString() == "Ş" || sifre[i].ToString() == "ğ" || sifre[i].ToString() == "Ğ")
                    {
                        arkadan_gelen = arkadan_gelen + 1;
                    }
                }

                if (arkadan_gelen != 0)
                {
                    sifre = sifre.ToLower();
                }

                if (passi == sifre)
                {
                    idsi = CollKull[0].KullaniciId;
                }

                else
                {
                    idsi = 0;
                }
            }

            else
            {
                idsi = 0;
            }

            return idsi;
        }

        public static int KullaniciGetirYetki(int k_id)
        {
            KullaniciCollection CollKull = new KullaniciCollection();
            IPredicateExpression ExpKull = new PredicateExpression();
            ExpKull.AddWithAnd(KullaniciFields.KullaniciId == k_id);
            ExpKull.AddWithAnd(KullaniciFields.KullaniciDurum == true);
            CollKull.GetMulti(ExpKull);

            if (CollKull.Count > 0)
            {
                idsi = CollKull[0].FkYetkiId;
            }

            else
            {
                idsi = 0;
            }

            return idsi;
        }

        public static string sifre_olustur(string sifre)
        {
            string bas = sifre;
            string hash = "";

            try
            {
                Random rastgele = new Random();
                Int32 sayi = 0;

                if (sifre.Length > 0)
                {
                    DbFunctionCall collatedCast = new DbFunctionCall("CAST({0} AS varchar) COLLATE SQL_Latin1_General_CP1_CS_AS", new object[] { KarakterFields.KarakterAd });

                    KarakterCollection CollKart = new KarakterCollection();
                    IPredicateExpression ExpKart = new PredicateExpression();

                    if (bas[0].ToString() == "i" || bas[0].ToString() == "ı" || bas[0].ToString() == "ş" || bas[0].ToString() == "Ş" || bas[0].ToString() == "ğ" || bas[0].ToString() == "Ğ")
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

                if (sifre.Length > 1)
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

                if (sifre.Length > 2)
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

                if (sifre.Length > 3)
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

                if (sifre.Length > 4)
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

                if (sifre.Length > 5)
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

                    if (sifre.Length != 6)
                    {
                        hash = hash + CollAlt[0].AltKarakterNo;
                    }
                }

                if (sifre.Length > 6)
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

                    if (sifre.Length != 7)
                    {
                        hash = hash + CollAlt[0].AltKarakterNo;
                    }
                }

                if (sifre.Length > 7)
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

                    if (sifre.Length != 8)
                    {
                        hash = hash + CollAlt[0].AltKarakterNo;
                    }
                }

                if (sifre.Length > 8)
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

                    if (sifre.Length != 9)
                    {
                        hash = hash + CollAlt[0].AltKarakterNo;
                    }
                }

                if (sifre.Length > 9)
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

                    if (sifre.Length != 10)
                    {
                        hash = hash + CollAlt[0].AltKarakterNo;
                    }
                }

                return hash;
            }

            catch
            {
                hash = "";
                return hash;
            }
        }

        public static string sifre_coz(string sifre)
        {
            string ana_sifre = sifre;
            string cozulmus = "";
            int ana_say = 0;

            try
            {
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
                        ana_say = ana_say + 1;
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
                        ana_say = ana_say + 1;
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

                return cozulmus;
            }

            catch
            {
                if (ana_say != 2)
                {
                    cozulmus = "";
                }                

                return cozulmus;
            }
        }
    }
}