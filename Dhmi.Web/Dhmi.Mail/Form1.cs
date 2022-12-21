using System;
using System.Configuration;
using System.Windows.Forms;

namespace Mail
{
    public partial class Form1 : Form
    {
        private MailMain mail;
        public Form1()
        {
            InitializeComponent();
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMinutes(Convert.ToDouble(ConfigurationManager.AppSettings["SendMailInterval"]));

            var timer = new System.Threading.Timer((e) =>
            {
                Start();
            }, null, startTimeSpan, periodTimeSpan);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }   

        public void Start()
        {
            //timer.Stop();
            mail = new MailMain();
            mail.GetData();
            //sendMailTimer.Start();
        }

        //private void GetIntervalRunMailTimer()
        //{
        //    if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings["IntervalType"]) &&
        //        !String.IsNullOrEmpty(ConfigurationManager.AppSettings["SendMailInterval"]) && ConfigurationManager.AppSettings["SendMailInterval"] != "0")
        //    {
        //        if (ConfigurationManager.AppSettings["IntervalType"].ToLower() == "s")
        //        {
        //            sendMailTimer.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["SendMailInterval"]) * 1000;
        //            sendMailTimer.Tick += new System.EventHandler(timer1_Tick);
        //        }
        //        if (ConfigurationManager.AppSettings["IntervalType"].ToLower() == "m")
        //        {
        //            sendMailTimeSpan = TimeSpan.FromMinutes(Convert.ToDouble(ConfigurationManager.AppSettings["SendMailInterval"]));

        //            sendMailTimer.Interval = sendMailTimeSpan.Minutes * 60000;
        //            sendMailTimer.Tick += new System.EventHandler(timer1_Tick);
        //        }
        //    }
        //}
    }
}
