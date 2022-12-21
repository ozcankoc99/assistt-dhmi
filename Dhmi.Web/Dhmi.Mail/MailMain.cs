using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Mail
{
    public class MailMain
    {
        private int mailWaitIntervalMilisecond;

        SqlConnection conn = new SqlConnection("Data Source=10.160.232.153;Initial Catalog=Dhmi;UID=dhmi;Password=Dhmi67*2801;Integrated Security=False;Max Pool Size=500;Min Pool Size=5;Connect Timeout=60;");
        public string Address { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string Password { get; set; }
        public MailMain()
        {

        }

        public void GetData()
        {
            GetEmailInfo();
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("Select Log_Email_ID,Log_Email_To,Log_Email_Subject,Log_Email_Content from Log_Email WHERE Log_Email_SendStatus='false';", conn);
            adptr.Fill(tbl);
            conn.Close();

            foreach (DataRow dr in tbl.Rows)
            {
                string id = dr["Log_Email_ID"].ToString();
                string to = dr["Log_Email_To"].ToString();
                string subject = dr["Log_Email_Subject"].ToString();
                string content = dr["Log_Email_Content"].ToString();

                SendEmail(id,to,subject,content,"");
            }            
        }

        public void GetEmailInfo()
        {
            conn.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter("Select Parametre_Ad,Parametre_Deger from Parametre where Parametre_Ad='Mail Adresi' OR Parametre_Ad='Mail Host' OR Parametre_Ad='Mail Port' OR Parametre_Ad='Mail Şifre';", conn);
            adptr.Fill(tbl);

            foreach (DataRow row in tbl.Rows)
            {
                Address = row["Parametre_Ad"].ToString() == "Mail Adresi" ? row["Parametre_Deger"].ToString() : Address;
                Host = row["Parametre_Ad"].ToString() == "Mail Host" ? row["Parametre_Deger"].ToString() : Host;
                Port = row["Parametre_Ad"].ToString() == "Mail Port" ? Convert.ToInt32(row["Parametre_Deger"]) : Port;
                Password = row["Parametre_Ad"].ToString() == "Mail Şifre" ? row["Parametre_Deger"].ToString() : Password;
            }

            conn.Close();
        }

        public bool SendEmail(string id, string to, string subject, string content, string ErrorMessage)
        {
            bool result = false;
            ErrorMessage = "";
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(to);
                mail.From = new MailAddress(this.Address);
                mail.Body = content;
                mail.Subject = subject;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = this.Host;
                smtp.Port = this.Port;

                smtp.Credentials = new System.Net.NetworkCredential(this.Address, this.Password);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                System.Threading.Thread.Sleep(mailWaitIntervalMilisecond);

                result = true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }

            try
            {
                if (result)
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand($"Update Log_Email Set Log_Email_SendDateTime='{DateTime.Now}',Log_Email_SendStatus = 'true' WHERE Log_Email_ID = {id}", conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
            }

            return result;
        }
    }
}
