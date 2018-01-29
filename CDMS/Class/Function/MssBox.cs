using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CDMS.Class.Function
{
    public static class MssBox
    {        
        public static void Error()
        {                
            DevExpress.XtraEditors.XtraMessageBox.Show("Error!", "เกิดปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Error(string txtError)
        {            
            DevExpress.XtraEditors.XtraMessageBox.Show(txtError, "เกิดปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Error(Exception ex)
        {
            if (ex.InnerException != null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Warning(string txtWarning)
        {            
            DevExpress.XtraEditors.XtraMessageBox.Show(txtWarning, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Success()
        {
            DevExpress.XtraEditors.XtraMessageBox.Show("บันทึกข้อมูลสำเร็จ...", "บันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Success(string txtSuccess)
        {            
            DevExpress.XtraEditors.XtraMessageBox.Show(txtSuccess, "บันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Success(string Caption,string txtSuccess)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(txtSuccess, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ErrorYesNo(string txtQuestion)
        {            
            return DevExpress.XtraEditors.XtraMessageBox.Show(txtQuestion, "Error ?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        public static DialogResult QuestionYesNo(string txt)
        {
            return DevExpress.XtraEditors.XtraMessageBox.Show(txt, "Question ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void iWaitForm(this DevExpress.XtraSplashScreen.SplashScreenManager spmg)
        {
            if (spmg.IsSplashFormVisible) { spmg.CloseWaitForm();}
            else
            {
                spmg.ShowWaitForm();
            }
        }

        public static DateTime GetDateServer(System.Data.Linq.DataContext db)
        {
            return db.ExecuteQuery<DateTime>("select getdate()").FirstOrDefault();
        }
    }
}
