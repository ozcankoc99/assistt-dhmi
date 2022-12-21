using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dhmi.EntityClasses;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Summary description for Helper
/// </summary>
namespace Dhmi.Web
{
    public class Helper
    {
        public Helper()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static string key = "Tüm_uyuyanları.uyandırmaya?bir-uyanık&yeter!";
        public static string Encrypt(string sifre)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(sifre);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }
        public static string Decrypt(string SifrelenmisDeger)
        {
            byte[] data = Convert.FromBase64String(SifrelenmisDeger);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }

        public static bool HasAnyCapital(string pass)
        {
            bool state = false;
            if (pass != null || pass != "")
            {
                state = pass.Any(char.IsUpper);
            }
            return state;
        }

        public static bool HasEnoughChar(string pass)
        {
            if (pass.Length >= 6 && pass.Length <=9)
                return true;
            else
                return false;
        }

        public static bool HasAnyNumber(string pass)
        {
            bool isDigitPresent = pass.Any(c => char.IsDigit(c));
            return isDigitPresent;
        }

        public static bool HasAnySpecialChar(string pass)
        {
            bool hasAny = pass.Any(ch => !Char.IsLetterOrDigit(ch));
            return hasAny;
        }

        public static int GetBilgiBankasiSiraNumarasi(short bilgiBankasiTurId)
        {
            BilgiBankasiTurEntity _bbTurEntity = new BilgiBankasiTurEntity(bilgiBankasiTurId);
            int max_Kayit = _bbTurEntity.BilgiBankasis.Count;

            return _bbTurEntity.BilgiBankasis[max_Kayit - 1].BilgiBankasiSira + 1;
        }

        public static void SendSms(string smsReceiver, string message, int bildirimId)
        {
            string username = ConfigurationManager.AppSettings["SmsUsername"];
            string password = Helper.Decrypt(ConfigurationManager.AppSettings["SmsPassword"]);
            SmsService.Service1SoapClient sms = new SmsService.Service1SoapClient();

            // origin : Mesajın hangi alfanumerik ile gideceği.
            string origin = ConfigurationManager.AppSettings["SmsSender"];

            //sd : Mesajı ileri tarihle göndermek istiyorsanız hangi tarihte göndereceğinizi ifade eder.
            //Formatı : yyyyaaggssdd şeklinde olmalıdır. Hemen göndermek isteniyorsa 0 (sıfır) olarak değer girilmelidir.
            string sd = "0";

            //Formatı : ss:dd (örnek 15:05)  Sonlanma saati girilmez ise sistem default 24 saat sonrası olarak atayacaktır. Sonlanma saati girilmeyecekse boş veya 0 (sıfır) olarak girilmelidir.
            string ed = "0";

            string strResult = string.Empty;
            try
            {
                strResult = sms.sendSingleSMS(username, password, smsReceiver, message, origin, sd, ed);
                if (strResult.StartsWith("*OK*"))
                {
                    AddSmsLog(origin, smsReceiver, message, bildirimId, strResult.Substring(4));
                }
            }
            catch (Exception exception)
            {
                strResult = exception.Message;
            }
        }

        public static void AddSmsLog(string sender, string gsmNumber, string message, int bildirimId, string smsId)
        {
            LogSmEntity sms = new LogSmEntity();
            sms.FkBildirimId = bildirimId;
            sms.LogSmsCreatedDate = DateTime.Now;
            sms.LogSmsSmsId = smsId;
            sms.LogSmsMessage = message;
            sms.LogSmsGsmNumber = gsmNumber;
            sms.LogSmsSender = sender;
            sms.Save();
        }
    }
}