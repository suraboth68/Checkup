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
using CDMS.Class.Entity;
using CDMS.Class.Function;

namespace CDMS.Process.Management
{
    public partial class EmployeeHisWorkDetailForm : DevExpress.XtraEditors.XtraForm
    {
        int HtwID;
        bool New;
        public EmployeeHisWorkDetailForm(int htwid)
        {
            InitializeComponent();

            HtwID = htwid;
        }

        private void EmployeeHisWorkDetailForm_Load(object sender, EventArgs e)
        {            
            ShowHistD();
        }

        private void ShowHistD()
        {
            barDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            New = true;
            txtFactor.Focus();
            txtFactor.Text = null;
            txtDevice.Text = null;
            txtRem.Text = null;

            var db = new CDMSDBDataContext(Program.conStr);

            historyWorkDetailBindingSource.DataSource = new HistoryWork_Detail();

            var HtwName = (from x in db.HistoryWorks
                           where x.Htw_Key == HtwID
                           && x.Htw_Status == 1
                           && x.Htw_Del == 0
                           select x.Htw_CompanyName).FirstOrDefault().ToString();

            lbName.Text = HtwName;

            var HistD = (from x in db.HistoryWork_Details
                         where x.Htw_Key == HtwID
                         && x.Htwd_Status == 1
                         && x.Htwd_Del == 0
                         select x).ToList();

            historyWorkDetailBindingSource.DataSource = HistD;
        }

        private void barSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MssBox.QuestionYesNo("คุณค้องการลบข้อมูลประสบการณ์ทำงาน ใช่ หรือ ไม่ ?") == DialogResult.Yes)
                {
                    var db = new CDMSDBDataContext(Program.conStr);

                    if (New == true)
                    {
                        var HtwD = new HistoryWork_Detail();

                        HtwD.Htw_Key = HtwID;
                        HtwD.Htwd_Factor = txtFactor.Text;
                        HtwD.Htwd_Device = txtDevice.Text;
                        HtwD.Htwd_Rem = txtRem.Text;
                        HtwD.Htwd_CreateBy = 1;
                        HtwD.Htwd_Status = 1;
                        HtwD.Htwd_Del = 0;

                        db.HistoryWork_Details.InsertOnSubmit(HtwD);
                        db.SubmitChanges();
                    }
                    else
                    {
                        var HistDCur = (HistoryWork_Detail)historyWorkDetailBindingSource.Current;

                        var UpHtwD = (from x in db.HistoryWork_Details
                                         where x.Htw_Key == HistDCur.Htw_Key
                                         && x.Htwd_Status == 1
                                         && x.Htwd_Del == 0
                                         select x).FirstOrDefault();

                        UpHtwD.Htwd_Factor = txtFactor.Text;
                        UpHtwD.Htwd_Device = txtDevice.Text;
                        UpHtwD.Htwd_Rem = txtRem.Text;
                        UpHtwD.Htwd_ModifyBy = 1;

                        db.SubmitChanges();
                    }
                    ShowHistD();
                }
                else { return; }
            }
            catch (Exception ex)
            {
                MssBox.Error(ex.Message);
            }
        }

        private void barDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MssBox.QuestionYesNo("คุณค้องการลบข้อมูลประสบการณ์ทำงาน ใช่ หรือ ไม่ ?") == DialogResult.Yes)
                {
                    var HistDCur = (HistoryWork_Detail)historyWorkDetailBindingSource.Current;

                    var db = new CDMSDBDataContext(Program.conStr);

                    var DelHistD = (from x in db.HistoryWork_Details
                                  where x.Htwd_Key == HistDCur.Htwd_Key
                                  && x.Htwd_Status == 1
                                  && x.Htwd_Del == 0
                                  select x).FirstOrDefault();

                    if (DelHistD != null)
                    {
                        DelHistD.Htwd_Del = 1;
                    }

                    db.SubmitChanges();

                    ShowHistD();
                }
                else { return; }
            }
            catch (Exception ex)
            {
                MssBox.Error(ex.Message);
            }
        }

        private void gridVHistD_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var HistDCur = (HistoryWork_Detail)historyWorkDetailBindingSource.Current;

            barDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;            
            New = false;
            txtFactor.Text = HistDCur.Htwd_Factor.ToString();
            txtDevice.Text = HistDCur.Htwd_Device.ToString();
            txtRem.Text = HistDCur.Htwd_Rem.ToString();
        }

        private void barRef_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowHistD();
        }
    }
}