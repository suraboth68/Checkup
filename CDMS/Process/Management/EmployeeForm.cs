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
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using CDMS.Class.Entity;
using CDMS.Class.Function;

namespace CDMS.Process.Management
{
    public partial class EmployeeForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            ShowEmployee();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnNewEmp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ShowForm = new EmployeeManageForm(0);
            ShowForm.ShowDialog();
            ShowEmployee();
        }

        private void ShowEmployee()
        {
            employeeBindingSource.DataSource = new Employee();

            var db = new CDMSDBDataContext(Program.conStr);

            var ShowEmp = (from x in db.Employees                           
                           where x.Emp_Status == 1
                           && x.Emp_Del == 0                                                   
                           select x).ToList();

            employeeBindingSource.DataSource = ShowEmp;
        }

        private void btnEditEmp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var Emp = (Employee)employeeBindingSource.Current;
            var EmpMForm = new EmployeeManageForm(Emp.Emp_Key);
            EmpMForm.ShowDialog();
            ShowEmployee();
        }

        private void gridVEmp_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var Emp = (Employee)employeeBindingSource.Current;

            if (e.Clicks == 2)
            {
                var EmpMForm = new EmployeeManageForm(Emp.Emp_Key);
                EmpMForm.ShowDialog();
                ShowEmployee();
            }
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowEmployee();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MssBox.QuestionYesNo("คุณค้องการลบข้อมูลพนักงาน ใช่ หรือ ไม่ ?") == DialogResult.Yes)
                {
                    MssBox.iWaitForm(splashScreenManager1);

                    var Emp = (Employee)employeeBindingSource.Current;

                    var db = new CDMSDBDataContext(Program.conStr);

                    var DelEmp = (from x in db.Employees
                                  where x.Emp_Key == Emp.Emp_Key
                                  select x).FirstOrDefault();

                    if (DelEmp != null)
                    {
                        DelEmp.Emp_Del = 1;
                        db.SubmitChanges();
                    }

                    ShowEmployee();

                    MssBox.iWaitForm(splashScreenManager1);
                }
                else { return; }                
            }
            catch (Exception ex)
            {
                MssBox.iWaitForm(splashScreenManager1);
                MssBox.Error(ex.Message);
            }
        }
    }
}
