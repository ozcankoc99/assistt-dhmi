using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using SD.LLBLGen.Pro.ORMSupportClasses;
using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using dhmi.EntityClasses;

namespace Dhmi.Web
{
    public static class Mail
    {
        public static string Address { get; set; }
        public static string Host { get; set; }
        public static int Port { get; set; }
        public static string Password { get; set; }

        static string mail_durum;

        static Mail()
        {
            try
            {
                ParametreCollection CollAdres = new ParametreCollection();
                IPredicateExpression ExpAdres = new PredicateExpression();
                ExpAdres.AddWithAnd(ParametreFields.ParametreAd == "Mail Adresi");
                CollAdres.GetMulti(ExpAdres);

                ParametreCollection CollHost = new ParametreCollection();
                IPredicateExpression ExpHost = new PredicateExpression();
                ExpHost.AddWithAnd(ParametreFields.ParametreAd == "Mail Host");
                CollHost.GetMulti(ExpHost);

                ParametreCollection CollPort = new ParametreCollection();
                IPredicateExpression ExpPort = new PredicateExpression();
                ExpPort.AddWithAnd(ParametreFields.ParametreAd == "Mail Port");
                CollPort.GetMulti(ExpPort);

                ParametreCollection CollSifre = new ParametreCollection();
                IPredicateExpression ExpSifre = new PredicateExpression();
                ExpSifre.AddWithAnd(ParametreFields.ParametreAd == "Mail Şifre");
                CollSifre.GetMulti(ExpSifre);

                Address = CollAdres[0].ParametreDeger;
                Host = CollHost[0].ParametreDeger;
                Port = Convert.ToInt32(CollPort[0].ParametreDeger);
                Password = CollSifre[0].ParametreDeger;
            }
            catch
            {
            }
        }

        public static void MailGonder(int k_id, string mail_adresi, string konu)
        {
            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == k_id);
            CollKul.GetMulti(ExpKul);

            string cozulmus = Kullanici.sifre_coz(CollKul[0].KullaniciPassword);

            string body = "LÜTFEN BU MAİLE GERİ DÖNÜŞ YAPMAYINIZ...<br/><br/>Devlet Hava Meydanları İşletmesi Genel Müdürlüğü (DHMİ) İletişim Merkezi üzerinden şifre hatırlatma isteği yapıldı. Lütfen şifrenizi 3. kişiler ile paylaşmayınız:<br/><br/>Kullanıcı Adı: " + CollKul[0].KullaniciUsername + "<br/><br/>Şifre: " + cozulmus + "<br/><br/> İyi çalışmalar...";

            AddMailLog(000000, Mail.Address, mail_adresi, konu, body);
        }

        public static void MailGonderYardim(int k_id, string mail_adresi, string konu, string sorun, string oneri, string aciklama, string iletisim)
        {
            KullaniciCollection CollKul = new KullaniciCollection();
            IPredicateExpression ExpKul = new PredicateExpression();
            ExpKul.AddWithAnd(KullaniciFields.KullaniciId == k_id);
            CollKul.GetMulti(ExpKul);

            string body = "LÜTFEN BU MAİLE GERİ DÖNÜŞ YAPMAYINIZ...<br/><br/>Devlet Hava Meydanları İşletmesi Genel Müdürlüğü (DHMİ) İletişim Merkezi üzerinden bir sorun bildirildi. Ayrıntılar aşağıda belirtilmiştir...<br/><br/>Sorun: " + sorun + "<br/><br/>Öneri: " + oneri + "<br/><br/>Açıklama: " + aciklama + "<br/><br/>İletişim: " + iletisim + "<br/><br/> İyi çalışmalar...";

            AddMailLog(000000, Mail.Address, mail_adresi, konu, body);
        }

        public static void MailGonderBildirim(string mail_adresi, string konu, string bildirim)
        {
            string body = "LÜTFEN BU MAİLE GERİ DÖNÜŞ YAPMAYINIZ...<br/><br/>Bildiriminiz, Devlet Hava Meydanları İşletmesi Genel Müdürlüğü (DHMİ) İletişim Merkezi tarafından " + bildirim + " Bildirim Numarası ile kayıt altına alınmıştır. Bildiriminiz Yetkililer tarafından en kısa zamanda sonuçlandırılacaktır.<br/><br/>Bildirim sonucunuzu, TC Kimlik Numaranız ve Başvuru Numaranız ile birlikte www.alo.dhmi.gov.tr adresinden sorgulayabilirsiniz..." + "<br/><br/>İyi günler dileriz...";

            AddMailLog(Convert.ToInt32(bildirim), Mail.Address, mail_adresi, konu, body);
        }

        public static void MailGonderBildirimEng(string mail_adresi, string konu, string bildirim)
        {
            string body = "PLEASE DO NOT RETURN THIS MAIL...<br/><br/>Your request registered with " + bildirim + " registration number by General Directorate Of State Airports Authority (DHMI) Call Center. Your request will be finalized as soon as possible by the Authorities.<br/><br/>You can query your result with passport number and registration number from www.alo.dhmi.gov.tr..." + "<br/><br/>Have a nice day...";

            AddMailLog(Convert.ToInt32(bildirim), Mail.Address, mail_adresi, konu, body);
        }

        public static void MailGonderBildirimSonuc(string mail_adresi, string konu, string bildirim, string karar)
        {
            string body = "LÜTFEN BU MAİLE GERİ DÖNÜŞ YAPMAYINIZ...<br/><br/>" + bildirim + " numaralı bildiriminiz, Devlet Hava Meydanları İşletmesi Genel Müdürlüğü (DHMİ) İletişim Merkezi tarafından sonuçlandırılmıştır.  <br/><br/>" + karar + "<br/><br/>Ayrıntılı bildirim sonucunuzu, TC Kimlik Numaranız ve Başvuru Numaranız ile birlikte www.alo.dhmi.gov.tr adresinden sorgulayabilirsiniz..." + "<br/><br/>İyi günler dileriz...";

            AddMailLog(Convert.ToInt32(bildirim), Mail.Address, mail_adresi, konu, body);
        }

        public static void MailGonderBildirimSonucEng(string mail_adresi, string konu, string bildirim, string karar)
        {
            string body = "PLEASE DO NOT RETURN THIS MAIL...<br/><br/>Your request which " + bildirim + " registration number finalized by General Directorate Of State Airports Authority (DHMI) Call Center. <br/><br/>" + karar + "<br/><br/>You can query your result details with passport number and registration number from www.alo.dhmi.gov.tr..." + "<br/><br/>Have a nice day...";

            AddMailLog(Convert.ToInt32(bildirim), Mail.Address, mail_adresi, konu, body);
        }

        public static void MailLinkGonder(string bildirim, string link, string mail_adresi, string konu, string icerik)
        {
            string body = "LÜTFEN BU MAİLE GERİ DÖNÜŞ YAPMAYINIZ...<br/><br/>Devlet Hava Meydanları İşletmesi Genel Müdürlüğü (DHMİ) İletişim Merkezi tarafından grubunuza/adınıza yeni bir bildirim atanmıştır. Bildirim ayrıntılarını incelemek için lütfen aşağıdaki linke tıklayınız...<br/><br/><a href='http://www.alo.dhmi.gov.tr/McCallCenterLinkControlAsLogin.aspx?" + link + "'>www.alo.dhmi.gov.tr/McCallCenterLinkControlAsLogin.aspx?" + link + "</a>" + "<br/><br/>" + icerik + "<br/><br/>İyi günler dileriz...";

            AddMailLog(Convert.ToInt32(bildirim), Mail.Address, mail_adresi, konu, body);
        }

        public static void MailGonder(string ad_soyad, string mail_adresi, string konu, string icerik)
        {                    
            string body = string.Format("Merhabalar ben {0},{1}", ad_soyad, System.Environment.NewLine);
            body += icerik;
            body += "<br/>İyi çalışmalar.";

            AddMailLog(000000, Mail.Address, "iletisimmerkezi@dhmi.gov.tr", konu, body);
        }

        public static void AddMailLog(int bildirimId, string from, string to, string subject, string content)
        {
            try
            {
                LogEmailEntity mail = new LogEmailEntity();
                mail.FkBildirimId = bildirimId;
                mail.LogEmailFrom = from;
                mail.LogEmailTo = to;
                mail.LogEmailSubject = subject;
                mail.LogEmailContent = content;
                mail.LogEmailCreatedDateTime = DateTime.Now;
                mail.LogEmailSendStatus = false;
                mail.Save(); 
            }

            catch
            {

            }                      
        }
    }
}