using CDMS.Class.Entity;
using CDMS.Class.Function;
using CDMS.Process.Management;
using CDMS.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CDMS
{
    public partial class CDMSForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CDMSForm()
        {
            InitializeComponent();
        }

        private void CDMSForm_Load(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGalleryDropDown(galleryDropDown1);
                loadMenu();

                string iVersion;
                if (ApplicationDeployment.IsNetworkDeployed)
                    iVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
                else
                    iVersion = Application.ProductVersion;
                lbVersion.Caption = string.Format("Version {0}", iVersion);
            }
            catch (Exception ex)
            {
                MssBox.Error(ex);
            }
        }

        private void CDMSForm_Shown(object sender, EventArgs e)
        {
            #region old
            //try
            //{
            //    GT:
            //    MssBox.iWaitForm(splashScreenManager1);               
            //    string HostDB = Properties.Settings.Default.Host;
            //    string DBName = Properties.Settings.Default.DBName;
            //    string User = Properties.Settings.Default.Username;
            //    string Pass = OneSecurity.Decryption(Properties.Settings.Default.Password);

            //    var ConStr = new System.Data.SqlClient.SqlConnectionStringBuilder()
            //    {
            //        DataSource = HostDB,
            //        InitialCatalog = DBName,
            //        UserID = User,
            //        Password = Pass,
            //        PersistSecurityInfo = true,
            //    }.ConnectionString;

            //    Program.conStr = ConStr;

            //    try
            //    {
            //        var condb = new CDMSDBDataContext(Program.conStr);
            //        condb.Connection.Open();
            //        condb.Connection.Close();
            //    }
            //    catch (Exception)
            //    {
            //        MssBox.iWaitForm(splashScreenManager1);
            //        if (MssBox.Question("เชื่อมต่อฐานข้อมูลไม่สำเร็จ !") == DialogResult.Yes)
            //        {
            //            var x = new SettingForm();
            //            x.ShowDialog();

            //            goto GT;
            //        }
            //        return;
            //    }
            //    MssBox.iWaitForm(splashScreenManager1);
            //}
            //catch (Exception ex)
            //{
            //    MssBox.iWaitForm(splashScreenManager1);
            //    MssBox.Error(ex.Message);
            //}
            #endregion
            if (loadDB())
            {
                var df = Properties.Settings.Default;
                lbSvDetail.Caption = string.Format("Server Host: {0} | Database Name: {1}", df.Host, df.DBName);
            }
            else
            {
                var Setting = new SettingForm();
                Setting.ShowDialog();
            }
        }

        bool loadDB()
        {
            try
            {
                var df = Properties.Settings.Default;
                MssBox.iWaitForm(splashScreenManager1);
                splashScreenManager1.SetWaitFormDescription(string.Format("Connecting {0}", df.Host));

                string conString = new System.Data.SqlClient.SqlConnectionStringBuilder()
                {
                    DataSource = df.Host,
                    InitialCatalog = df.DBName,
                    UserID = df.Username,
                    Password = OneSecurity.Decryption(df.Password),
                    PersistSecurityInfo = true,

                }.ConnectionString;

                using (var db = new CDMSDBDataContext(conString))
                {
                    db.Connection.Open();
                    splashScreenManager1.SetWaitFormDescription(string.Format("Connected {0}", df.Host));
                }
                Program.conStr = conString;
                MssBox.iWaitForm(splashScreenManager1);
                return true;
            }
            catch (Exception ex)
            {
                MssBox.iWaitForm(splashScreenManager1);
                MssBox.Error(ex);
                return false;
            }
        }

        private void navBarEmployee_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormManager<EmployeeForm>.Show(this);
        }

        private void btnSkin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            galleryDropDown1.ShowPopup(Control.MousePosition);
        }

        private void galleryDropDown1_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            Properties.Settings.Default.Skinname = e.Item.Caption;
            Properties.Settings.Default.Save();
        }

        private void navBarFactory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void btnSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ShowForm = new SettingForm();
            ShowForm.ShowDialog();
        }

        private void btMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int numMenu = Properties.Settings.Default.menuSet;
            numMenu++;

            Properties.Settings.Default.menuSet = numMenu;
            Properties.Settings.Default.Save();

            loadMenu();
        }

        void loadMenu()
        {
            int numMenu = Properties.Settings.Default.menuSet;

            if (numMenu == 1)
            {
                dockMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            }
            else if (numMenu == 2)
            {
                dockMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            }
            else if (numMenu == 3)
            {
                dockMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            }
            else
            {
                Properties.Settings.Default.menuSet = 1;
                Properties.Settings.Default.Save();
                dockMenu.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            }

        }
    }
}
