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

namespace CDMS.Process.Management
{
    public partial class EmployeeHisWorkForm : DevExpress.XtraEditors.XtraForm
    {
        int EmpID;        
        bool New;
        public EmployeeHisWorkForm(int empid)
        {
            InitializeComponent();

            EmpID = empid;
        }

        private void EmployeeHisWorkForm_Load(object sender, EventArgs e)
        {
            ShowExp();
        }

        private void ShowExp()
        {
            txtComName.Focus();

            barDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            btnOpenFactor.Visible = false;

            New = true;
            txtComName.Text = null;
            memoRem.Text = null;
            txtDept.Text = null;
            txtComType.Text = null;
            txtWorkType.Text = null;
            StartWorkDate.DateTime = GetMasterDataClass.GetDateServer();
            StopWorkDate.DateTime = GetMasterDataClass.GetDateServer();
            
            var db = new CDMSDBDataContext(Program.conStr);

            historyWorkBindingSource.DataSource = new HistoryWork();

            var Exp = (from x in db.HistoryWorks
                       where x.Emp_Key == EmpID
                       && x.Htw_Status == 1
                       && x.Htw_Del == 0
                       select x).ToList();

            historyWorkBindingSource.DataSource = Exp;
        }   

        private void btnOpenFactor_Click(object sender, EventArgs e)
        {
            var ExpCur = (HistoryWork)historyWorkBindingSource.Current;
            var ShowForm = new EmployeeHisWorkDetailForm(ExpCur.Htw_Key);
            ShowForm.ShowDialog();
        }

        private void barSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MssBox.QuestionYesNo("คุณค้องการลบข้อมูลประสบการณ์ทำงาน ใช่ หรือ ไม่ ?") == DialogResult.Yes)
                {
                    if (New == true)
                    {
                        var db = new CDMSDBDataContext(Program.conStr);

                        var SaveExp = new HistoryWork();

                        SaveExp.Htw_CompanyName = txtComName.Text;
                        SaveExp.Htw_CompanyDept = txtDept.Text;
                        SaveExp.Htw_Category = txtComType.Text;
                        SaveExp.Htw_JobDescription = txtWorkType.Text;
                        SaveExp.Htw_StartDateForWork = StartWorkDate.DateTime;
                        SaveExp.Htw_EndDateForWork = StopWorkDate.DateTime;
                        SaveExp.Htw_Rem = memoRem.Text;
                        SaveExp.Emp_Key = EmpID;
                        SaveExp.Htw_Status = 1;
                        SaveExp.Htw_Del = 0;

                        db.HistoryWorks.InsertOnSubmit(SaveExp);
                        db.SubmitChanges();
                    }
                    else
                    {
                        var db = new CDMSDBDataContext(Program.conStr);

                        var ExpCur = (HistoryWork)historyWorkBindingSource.Current;

                        var UpdateExp = (from x in db.HistoryWorks
                                   where x.Htw_Key == ExpCur.Htw_Key
                                   && x.Htw_Status == 1
                                   && x.Htw_Del == 0
                                   select x).FirstOrDefault();

                        UpdateExp.Htw_CompanyName = txtComName.Text;
                        UpdateExp.Htw_CompanyDept = txtDept.Text;
                        UpdateExp.Htw_Category = txtComType.Text;
                        UpdateExp.Htw_JobDescription = txtWorkType.Text;
                        UpdateExp.Htw_StartDateForWork = StartWorkDate.DateTime;
                        UpdateExp.Htw_EndDateForWork = StopWorkDate.DateTime;
                        UpdateExp.Htw_Rem = memoRem.Text;
                        
                        db.SubmitChanges();
                    }

                    ShowExp();
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
                    var ExpCur = (HistoryWork)historyWorkBindingSource.Current;

                    var db = new CDMSDBDataContext(Program.conStr);

                    var DelExp = (from x in db.HistoryWorks
                               where x.Htw_Key == ExpCur.Htw_Key
                               && x.Htw_Status == 1
                               && x.Htw_Del == 0
                               select x).FirstOrDefault();

                    if (DelExp != null)
                    {
                        DelExp.Htw_Del = 1;
                    }

                    db.SubmitChanges();

                    ShowExp();
                }
                else { return; }
            }
            catch (Exception ex)
            {
                MssBox.Error(ex.Message);
            }
        }

        private void barRef_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowExp();
        }        

        private void gridVExp_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var ExpCur = (HistoryWork)historyWorkBindingSource.Current;

            barDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnOpenFactor.Visible = true;
            New = false;
            txtComName.Text = ExpCur.Htw_CompanyName.ToString();
            txtDept.Text = ExpCur.Htw_CompanyDept.ToString();
            txtComType.Text = ExpCur.Htw_Category.ToString();
            txtWorkType.Text = ExpCur.Htw_JobDescription.ToString();
            StartWorkDate.DateTime = ExpCur.Htw_StartDateForWork.Value;
            StopWorkDate.DateTime = ExpCur.Htw_EndDateForWork.Value;
            memoRem.Text = ExpCur.Htw_Rem.ToString();
        }
    }
}