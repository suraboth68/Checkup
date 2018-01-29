using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CDMS.Class.Function;
using CDMS.Class.Entity;

namespace CDMS.Setting
{
    public partial class SettingForm : DevExpress.XtraEditors.XtraForm
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            txtHost.Text = Properties.Settings.Default.Host;
            txtDatabase.Text = Properties.Settings.Default.DBName;
            txtUsername.Text = Properties.Settings.Default.Username;
            txtPassword.Text = OneSecurity.Decryption(Properties.Settings.Default.Password);

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate()) { return; }
                if (XtraMessageBox.Show("คุณต้องการเปลียนแปลง Server ใช้หรือไม่", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MssBox.iWaitForm(splashScreenManager1);
                    #region ITSDB
                    var df = Properties.Settings.Default;
                    string HostDB = df.Host;
                    string DBName = df.DBName;
                    string User = df.Username;
                    string Pass = OneSecurity.Decryption(df.Password);

                    var ConStr = new System.Data.SqlClient.SqlConnectionStringBuilder()
                    {
                        DataSource = txtHost.Text,
                        InitialCatalog = txtDatabase.Text,
                        UserID = txtUsername.Text,
                        Password = txtPassword.Text,
                        PersistSecurityInfo = true,
                    }.ConnectionString;

                    if(!MessageConnect(ConStr))
                    {
                        MssBox.iWaitForm(splashScreenManager1);
                        return;
                    }

                    #endregion
                    df.Host = txtHost.Text.Trim();
                    df.DBName = txtDatabase.Text.Trim();
                    df.Username = txtUsername.Text.Trim();
                    df.Password = OneSecurity.Encryption(txtPassword.Text.Trim());
                    df.Save();
                    Program.conStr = ConStr;
                    MssBox.iWaitForm(splashScreenManager1);
                }
            }
            catch (Exception ex)
            {
                MssBox.iWaitForm(splashScreenManager1);
                MssBox.Error(ex);
            }
        }

        bool MessageConnect(string conStr)
        {
            try
            {
                var condb = new CDMSDBDataContext(conStr);
                condb.Connection.Open();
                lbStatus.Text = "Connection Successful..";
                lbStatus.ForeColor = Color.Green;
                return true;
            }
            catch (Exception)
            {
                lbStatus.Text = "Connection failed..";
                lbStatus.ForeColor = Color.Red;
                return false;
            }
        }

        private void SettingForm_Shown(object sender, EventArgs e)
        {
            MessageConnect(Program.conStr);
        }
    }
}