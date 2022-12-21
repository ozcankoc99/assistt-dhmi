using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dhmi.EntityClasses;
using System.Configuration;
using dhmi.Linq;

namespace Dhmi.Web
{
    public static class SmsHelper
    {
        public static void SendSms(string smsReceiver, string message, int bildirimId)
        {
            string username = ConfigurationManager.AppSettings["SmsUsername"];
            string password = Helper.Decrypt(ConfigurationManager.AppSettings["SmsPassword"]);
            /*SmsService.Service1 sms = new SmsService.Service1();

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
            }*/
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