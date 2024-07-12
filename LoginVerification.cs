using SchedulingDesktopUserInterfaceApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.ComponentModel.Design;
using System.Configuration;

namespace SchedulingDesktopUserInterfaceApp
{
    public partial class LoginVerification : Form
    {
        public LoginVerification()
        {
            InitializeComponent();
            _ = GetLocation.GetLocationDetails();
            
        }

        private void LoginVerification_Load(object sender, EventArgs e)
        {
            InputLanguageCollection languages = InputLanguage.InstalledInputLanguages;
            languages.Cast<InputLanguage>();
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US"));
            languages.Contains(InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US")));
            languages.Contains(InputLanguage.FromCulture(new System.Globalization.CultureInfo("es-ES")));
        }

        //private void EnglishButton_Click(object sender, EventArgs e)
        //{
        //    Language language = new Language();
        //    string englishLanguage = ConfigurationManager.AppSettings["en-US"] = "en-US";
        //    language.ChangeLanguageTo(englishLanguage);
        //    EnglishButton.EnabledChanged += new EventHandler(this.EnglishButton_Click);
        //    EnglishButton.Click += new EventHandler(this.EnglishButton_Click);
        //    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US"));
        //    LoginVerification loginVerification = new LoginVerification();
        //    loginVerification.LoginVerification_Load(sender, e);
        //    loginVerification.Show();
        //    Visible = false;
        //}

        //private void SpanishButton_Click(object sender, EventArgs e)
        //{
        //    Language language = new Language();
        //    string spanishLanguage = ConfigurationManager.AppSettings["es-ES"] = "es-ES";
        //    language.ChangeLanguageTo(spanishLanguage);
        //    //SpanishButton.EnabledChanged += new EventHandler(this.SpanishButton_Click);
        //    //SpanishButton.Click += new EventHandler(this.SpanishButton_Click);
        //    //InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("es-ES"));
        //    LoginVerification loginVerification = new LoginVerification();
        //    loginVerification.LoginVerification_Load(sender, e);
        //    loginVerification.Show();
        //    Visible = false;

            
        //}

        private void EnglishButton_Click_1(object sender, EventArgs e)
        {
            Language language = new Language();
            string englishLanguage = ConfigurationManager.AppSettings["en-US"] = "en-US";
            language.ChangeLanguageTo(englishLanguage);
            //EnglishButton.EnabledChanged += new EventHandler(this.EnglishButton_Click);
            //EnglishButton.Click += new EventHandler(this.EnglishButton_Click);
            //InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US"));
            LoginVerification loginVerification = new LoginVerification();
            loginVerification.LoginVerification_Load(sender, e);
            loginVerification.Show();
            Visible = false;
        }

        private void SpanishButton_Click_1(object sender, EventArgs e)
        {
            Language language = new Language();
            string spanishLanguage = ConfigurationManager.AppSettings["es-ES"] = "es-ES";
            language.ChangeLanguageTo(spanishLanguage);
            //SpanishButton.EnabledChanged += new EventHandler(this.SpanishButton_Click);
            //SpanishButton.Click += new EventHandler(this.SpanishButton_Click);
            //InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("es-ES"));
            LoginVerification loginVerification = new LoginVerification();
            loginVerification.LoginVerification_Load(sender, e);
            loginVerification.Show();
            Visible = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }
    }
}