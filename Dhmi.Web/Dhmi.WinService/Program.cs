using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dhmi.WinService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.ServiceProcess.ServiceBase[] ServiceToRun;
            ServiceToRun = new System.ServiceProcess.ServiceBase[] { new MailService() };
            System.ServiceProcess.ServiceBase.Run(ServiceToRun);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestForm());
        }
    }
}
