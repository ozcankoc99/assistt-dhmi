using dhmi.CollectionClasses;
using dhmi.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Net.Mail;

namespace Dhmi.WinService
{
    public class MailMain
    {
        public string Address { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string Password { get; set; }
        public MailMain()
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

        public bool Send(string To, string Body, string Subject, out string ErrorMessage)
        {
            bool result = false;
            ErrorMessage = "";
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(To);
                mail.From = new MailAddress(this.Address);                
                mail.Body = Body;
                mail.Subject = Subject;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = this.Host;
                smtp.Port = this.Port;

                smtp.Credentials = new System.Net.NetworkCredential(this.Address, this.Password);
                smtp.EnableSsl = true;
                smtp.Send(mail);

                result = true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }

            return result;
        }
    }
}
