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

namespace SchedulingDesktopUserInterfaceApp
{
    public partial class LoginVerification : Form
    {
        public LoginVerification()
        {
            InitializeComponent();
            _ = GetLocation.GetLocationDetails();
        }
    }
}