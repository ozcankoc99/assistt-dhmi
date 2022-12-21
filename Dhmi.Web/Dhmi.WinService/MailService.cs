using dhmi.CollectionClasses;
using dhmi.EntityClasses;
using dhmi.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;

namespace Dhmi.WinService
{
    public partial class MailService : System.ServiceProcess.ServiceBase
    {
        #region InstanceVariables

        private System.Diagnostics.EventLog OlayLog;

        private TimeSpan sendMailTimeSpan;

        private System.Timers.Timer sendMailTimer = new System.Timers.Timer();

        private int mailWaitIntervalMilisecond;

        private MailMain mail;

        #endregion

        public MailService()
        {
            InitializeComponent();

            // Servis için log oluşturuluyor...
            CreateEventLog();

            // mail göndermek için gereken bilgiler yapıcı
            mail = new MailMain();

            mailWaitIntervalMilisecond = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["MailWaitIntervalMilisecond"]);

            // Timer bilgileri setleniyor...
            GetIntervalRunMailTimer();
        }

        /// <summary>
        /// Servisin Olay Görüntüleyicinde çıkması için log kaydı oluşturuluyor...
        /// </summary>
        private void CreateEventLog()
        {
            OlayLog = new System.Diagnostics.EventLog();

            if (!System.Diagnostics.EventLog.SourceExists("DhmiMailService"))
            {
                /* Ilk parametre ile, Log Deneme ismi altinda tutulacak Log bilgilerinin kaynak ismi belirleniyor.
                 * Daha sonra bu kaynak ismi OlayLog isimli nesnemizin Source özelligine ataniyor.*/
                System.Diagnostics.EventLog.CreateEventSource("DhmiMailService", "Dhmi.MailServiceLog");

            }
            OlayLog.Source = "DhmiMailService";
        }

        /// <summary>
        /// Bu method yordamıyla smsService in dakika yada saniye bazlı, kac dakikada bir yada kac saniyede bir calısacagı saptanarak timer a set edilir.
        /// </summary>
        private void GetIntervalRunMailTimer()
        {
            if (!String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["IntervalType"]) &&
                !String.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["SendMailInterval"]) &&
                System.Configuration.ConfigurationManager.AppSettings["SendMailInterval"] != "0")
            {
                if (System.Configuration.ConfigurationManager.AppSettings["IntervalType"].ToLower() == "s")
                {
                    sendMailTimer.Interval = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["SendMailInterval"]) * 1000;
                    sendMailTimer.Elapsed += new System.Timers.ElapsedEventHandler(SendMailTimer_Elapsed);
                }
                if (System.Configuration.ConfigurationManager.AppSettings["IntervalType"].ToLower() == "m")
                {
                    sendMailTimeSpan = TimeSpan.FromMinutes(Convert.ToDouble(System.Configuration.ConfigurationManager.AppSettings["SendMailInterval"]));

                    sendMailTimer.Interval = sendMailTimeSpan.Minutes * 60000;
                    sendMailTimer.Elapsed += new System.Timers.ElapsedEventHandler(SendMailTimer_Elapsed);
                }
            }
        }

        private void SendMailTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Start();
        }
                
        public void Start()
        {
            sendMailTimer.Stop();
            //OlayLog.WriteEntry("Mail Service Started...", System.Diagnostics.EventLogEntryType.Information);
            SendMail();
            sendMailTimer.Start();

        }
                
        /// <summary>
        /// Mail Gonderen Methodtur.
        /// </summary>
        public void SendMail()
        {
            LogEmailCollection _gonMailColl = new LogEmailCollection();

            try
            {
                IPredicateExpression filter = new PredicateExpression();
                filter.Add(LogEmailFields.LogEmailSendStatus == 0);
                filter.AddWithAnd(LogEmailFields.LogEmailCreatedDateTime >= DateTime.Now.AddDays(-1));
                _gonMailColl.GetMulti(filter);

                OlayLog.WriteEntry(string.Format("Gönderilecek mail sayısı : {0}", _gonMailColl.Count), System.Diagnostics.EventLogEntryType.Information);
            }
            catch (Exception ex)
            {
                WriteServiceLogWithException("DhmiMailService",
                    "SendMail() içerisindeki --> Gönderilecek Mail listesini cekerken HATA!!!!", ex);

            }

            bool result = false;
            string ErrorMessage = "";

            if (_gonMailColl != null && _gonMailColl.Count > 0)
            {
                foreach (LogEmailEntity item in _gonMailColl)
                {
                    try
                    {
                        result = mail.Send(item.LogEmailTo, item.LogEmailContent, item.LogEmailSubject, out ErrorMessage);

                        System.Threading.Thread.Sleep(mailWaitIntervalMilisecond);

                        if (!result)
                        {
                            OlayLog.WriteEntry("MailGonderimiBasarısız --->" + " MailReponse.success = " + result + " ErrorMessage = " + ErrorMessage, System.Diagnostics.EventLogEntryType.Error, 3, 1);
                        }
                    }
                    catch (Exception ex)
                    {
                        WriteServiceLogWithException("DhmiMailService",
                         @"SendMail() içerisindeki --> Mail.Send(item.LogEmailTo, item.LogEmailContent, item.LogEmailSubject); - Mail servisi kullanılırken HATA!!!!", ex);
                    }

                    try
                    {
                        if (result)
                        {
                            item.LogEmailSendDateTime = DateTime.Now;
                            item.LogEmailSendStatus = true;
                            item.Save();
                        }
                    }
                    catch (Exception ex)
                    {
                        WriteServiceLogWithException("DhmiMailService",
                            @"SendMail() içerisindeki --> ", ex);
                    }
                }
                OlayLog.WriteEntry("Mailler gönderildi...", System.Diagnostics.EventLogEntryType.Information, 1, 5);
            }
        }
        
        /// <summary>
        /// Method Calısırken herhangi bir hata olursa bunu log tablosuna yazmayı dener.
        /// </summary>
        /// <param name="serviceTipi">WebService</param>
        /// <param name="islem">Method Adı</param>
        /// <param name="ex">Hata</param>
        private void WriteServiceLogWithException(string serviceTipi, string islem, Exception ex)
        {
            try
            {
                LogHataEntity hata = new LogHataEntity();
                hata.Duzeltildi = false;
                hata.Ekran = serviceTipi;
                hata.Mesaj = ex.Message;
                hata.Method = islem;
                hata.Tarih = DateTime.Now;
                hata.Trace = ex.StackTrace;
                hata.Save();
            }
            catch (Exception)
            {
                OlayLog.WriteEntry("DB Log Yazarken Hata Olustu!!! ex.Message = " + ex.Message +
                                    " --- " + " ex.StackTrace = " + ex.StackTrace, System.Diagnostics.EventLogEntryType.Error, 2, 2);

                //MailClass.SendErrorMailStatic(serviceTipi + " - " + islem, ex, db);
            }
            finally
            {
            }

        }
        
        protected override void OnStart(string[] args)
        {
            OlayLog.WriteEntry("Mail Service OnStart()", System.Diagnostics.EventLogEntryType.Information);
            sendMailTimer.Start();
        }

        protected override void OnStop()
        {
            sendMailTimer.Stop();
            OlayLog.WriteEntry("Mail Service OnStop()", System.Diagnostics.EventLogEntryType.Information);
        }
    }

}