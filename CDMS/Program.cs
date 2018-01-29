using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using CDMS.Process.Management;
using DevExpress.LookAndFeel;
using System.Threading;

namespace CDMS
{
    static class Program
    {
        public static string conStr = string.Empty;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            string skinname = Properties.Settings.Default.Skinname;
            UserLookAndFeel.Default.SetSkinStyle(skinname);

            var culture = new System.Globalization.CultureInfo("th-TH");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CDMSForm());
        }
    }
}
