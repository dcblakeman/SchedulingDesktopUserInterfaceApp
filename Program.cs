using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;


namespace SchedulingDesktopUserInterfaceApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var language = ConfigurationManager.AppSettings["Language"];
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginVerification());
        }
    }
}
