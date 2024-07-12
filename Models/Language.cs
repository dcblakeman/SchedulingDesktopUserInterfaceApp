using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace SchedulingDesktopUserInterfaceApp.Models
{
    internal class Language
    {
        public Language()
        {
            //CultureInfo culture = new CultureInfo("en-US");
            //Thread.CurrentThread.CurrentCulture = culture;
            //Thread.CurrentThread.CurrentUICulture = culture;
            //Console.WriteLine("Language set to: " + culture.DisplayName);
        }
        public void ChangeLanguageTo(string language)
        {
            try
            {
                CultureInfo culture = new CultureInfo(language);
                Thread.CurrentThread.CurrentCulture = culture;
                Thread.CurrentThread.CurrentUICulture = culture;
                Console.WriteLine("Language set to: " + culture.DisplayName);
            }
            catch (CultureNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


