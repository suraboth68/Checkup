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
    public partial class EmployeeManageForm : DevExpress.XtraEditors.XtraForm
    {
        int EmpID;
        public EmployeeManageForm(int empid)
        {
            InitializeComponent();
            EmpID = empid;
        }

        private void EmployeeManageForm_Load(object sender, EventArgs e)
        {
            var db = new CDMSDBDataContext(Program.conStr);

            factoryBindingSource.DataSource = db.Factories.ToList();
            branchBindingSource.DataSource = db.Branches.ToList();
            sectionBindingSource.DataSource = db.Sections.ToList();
            deptBindingSource.DataSource = db.Depts.ToList();
            employeeTitleBindingSource.DataSource = db.EmployeeTitles.ToList();

            thailandDistrictBindingSource.DataSource = db.ThailandDistricts.ToList();
            thailandAmphurBindingSource.DataSource = db.ThailandAmphurs.ToList();
            thailandProvinceBindingSource.DataSource = db.ThailandProvinces.ToList();

            if (EmpID != 0)
            {
                ShowDataEmployee();
                btnOpenExp.Visible = true;
            }
            else
            {
                btnOpenExp.Visible = false;
            }
        }

        private void ShowDataEmployee()
        {
            var db = new CDMSDBDataContext(Program.conStr);

            var Emp = (from x in db.Employees
                       where x.Emp_Key == EmpID
                       select x).FirstOrDefault();

            txtIDCard.Text = Emp.IDCard;
            //Emp.EmployeeID
            txtFName.Text = Emp.Emp_Fname;
            txtSName.Text = Emp.Emp_Surname;
            lbAge.Text = Emp.Age.ToString();
            dateOfBirth.DateTime = Emp.Birthday.Value;
            dateOfWork.DateTime = Emp.StartDayWork.Value;
            LookTitle.EditValue = Emp.Title_Key;
            radioGender.SelectedIndex = (Emp.Gender_Key == 1) ? 0 : 1;            
            //if (Emp.Gender_Key == 1){radioGender.SelectedIndex = 0;}else{radioGender.SelectedIndex = 1;}
            LookDept.EditValue = Emp.Dept_Key;
            LookSec.EditValue = Emp.Sec_Key;
            LookBrn.EditValue = Emp.Brn_Key;
            LookFac.EditValue = Emp.Fact_Key;
            memoREM.Text = Emp.Emp_REM.ToString();

            txtAddIDNo.Text = Emp.AddressByIDCard.AddrIDCard_Address_NO;
            txtAddIDMoo.Text = Emp.AddressByIDCard.AddrIDCard_Address_Moo;
            txtAddIDSoi.Text = Emp.AddressByIDCard.AddrIDCard_Address_Soi;
            txtAddIDStreet.Text = Emp.AddressByIDCard.AddrIDCard_Address_Street;
            LookAddIDDistrict.EditValue = Emp.AddressByIDCard.AddrIDCard_Address_District;
            txtAddIDTel.Text = Emp.AddressByIDCard.AddrIDCard_Telelphone;

            txtAddConNo.Text = Emp.AddressByContact.AddrCont_Address_NO;
            txtAddConMoo.Text = Emp.AddressByContact.AddrCont_Address_Moo;
            txtAddConSoi.Text = Emp.AddressByContact.AddrCont_Address_Soi;
            txtAddConStreet.Text = Emp.AddressByContact.AddrCont_Address_Street;
            LookAddConDistrict.EditValue = Emp.AddressByContact.AddrCont_Address_District;
            txtAddConTel.Text = Emp.AddressByContact.AddrCont_Telelphone;

            txtAddFacName.Text = Emp.AddressByCompany.AddrCom_Name;
            txtAddFacNo.Text = Emp.AddressByCompany.AddrCom_Address_NO;
            txtAddFacMoo.Text = Emp.AddressByCompany.AddrCom_Address_Moo;
            txtAddFacSoi.Text = Emp.AddressByCompany.AddrCom_Address_Soi;
            txtAddFacStreet.Text = Emp.AddressByCompany.AddrCom_Address_Street;
            LookAddFacDistrict.EditValue = Emp.AddressByCompany.AddrCom_Address_District;
            txtAddFacTel.Text = Emp.AddressByCompany.AddrCom_Telelphone;
        }

        private void LookAddIDDistrict_EditValueChanged(object sender, EventArgs e)
        {
            var db = new CDMSDBDataContext(Program.conStr);

            txtAddIDZipCode.Text = (from i in db.ThailandDistricts where i.Dis_Key == Convert.ToInt32(LookAddIDDistrict.EditValue) select i.Dis_Zip).FirstOrDefault().ToString();

            LookAddIDAmphur.EditValue = (from i in db.ThailandDistricts where i.Dis_Key == Convert.ToInt32(LookAddIDDistrict.EditValue) select i.Amp_Key).FirstOrDefault();

            LookAddIDProvince.EditValue = (from i in db.ThailandAmphurs where i.Amp_Key == Convert.ToInt32(LookAddIDAmphur.EditValue) select i.Prov_Key).FirstOrDefault();
        }

        private void LookAddConDistrict_EditValueChanged(object sender, EventArgs e)
        {
            var db = new CDMSDBDataContext(Program.conStr);
            txtAddConZipCode.Text = (from i in db.ThailandDistricts where i.Dis_Key == Convert.ToInt32(LookAddConDistrict.EditValue) select i.Dis_Zip).FirstOrDefault().ToString();

            LookAddConAmphur.EditValue = (from i in db.ThailandDistricts where i.Dis_Key == Convert.ToInt32(LookAddConDistrict.EditValue) select i.Amp_Key).FirstOrDefault();

            LookAddConProvince.EditValue = (from i in db.ThailandAmphurs where i.Amp_Key == Convert.ToInt32(LookAddConAmphur.EditValue) select i.Prov_Key).FirstOrDefault();
        }

        private void ChkAddSameIDCard_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAddSameIDCard.Checked == true)
            {
                txtAddConNo.Text = txtAddIDNo.Text;
                txtAddConMoo.Text = txtAddIDMoo.Text;
                txtAddConSoi.Text = txtAddIDSoi.Text;
                txtAddConStreet.Text = txtAddIDStreet.Text;
                txtAddConZipCode.Text = txtAddIDZipCode.Text;
                LookAddConDistrict.EditValue = LookAddIDDistrict.EditValue;
                LookAddConAmphur.EditValue = LookAddIDAmphur.EditValue;
                LookAddConProvince.EditValue = LookAddIDProvince.EditValue;
                txtAddConTel.Text = txtAddIDTel.Text;
            }
            else
            {
                txtAddConNo.Text = "";
                txtAddConMoo.Text = "";
                txtAddConSoi.Text = "";
                txtAddConStreet.Text = "";
                txtAddConZipCode.Text = "";
                LookAddConDistrict.EditValue = null;
                LookAddConAmphur.EditValue = null;
                LookAddConProvince.EditValue = null;
                txtAddConTel.Text = "";
            }
        }

        private void LookAddFacDistrict_EditValueChanged(object sender, EventArgs e)
        {
            var db = new CDMSDBDataContext(Program.conStr);

            txtAddFacZipCode.Text = (from i in db.ThailandDistricts where i.Dis_Key == Convert.ToInt32(LookAddFacDistrict.EditValue) select i.Dis_Zip).FirstOrDefault().ToString();

            LookAddFacAmphur.EditValue = (from i in db.ThailandDistricts where i.Dis_Key == Convert.ToInt32(LookAddFacDistrict.EditValue) select i.Amp_Key).FirstOrDefault();

            LookAddFacProvince.EditValue = (from i in db.ThailandAmphurs where i.Amp_Key == Convert.ToInt32(LookAddFacAmphur.EditValue) select i.Prov_Key).FirstOrDefault();
        }

        private void LookFac_EditValueChanged(object sender, EventArgs e)
        {
            var db = new CDMSDBDataContext(Program.conStr);

            branchBindingSource.DataSource = db.Branches.ToList();

            branchBindingSource.DataSource = (from x in db.Branches where x.Fact_Key == (int)LookFac.EditValue select x).ToList();

            sectionBindingSource.DataSource = (from x in db.Sections where x.Fact_Key == (int)LookFac.EditValue select x).ToList();

            deptBindingSource.DataSource = (from x in db.Depts where x.Fact_Key == (int)LookFac.EditValue select x).ToList();
        }

        private void LookBrn_EditValueChanged(object sender, EventArgs e)
        {
            var db = new CDMSDBDataContext(Program.conStr);

            sectionBindingSource.DataSource = db.Sections.ToList();

            sectionBindingSource.DataSource = (from x in db.Sections where x.Brn_Key == (int)LookBrn.EditValue select x).ToList();

            deptBindingSource.DataSource = (from x in db.Depts where x.Brn_Key == (int)LookBrn.EditValue select x).ToList();
        }

        private void LookSec_EditValueChanged(object sender, EventArgs e)
        {
            var db = new CDMSDBDataContext(Program.conStr);

            deptBindingSource.DataSource = db.Depts.ToList();

            deptBindingSource.DataSource = (from x in db.Depts where x.Sec_Key == (int)LookSec.EditValue select x).ToList();
        }

        public static int CalculateAge(DateTime birthDay)
        {
            DateTime DT = GetMasterDataClass.GetDateServer();

            int Years = DT.Year - birthDay.Year;

            if ((birthDay.Month > DT.Month) || (birthDay.Month == DT.Month && birthDay.Day > DT.Day))
                Years--;

            return Years;
        }

        private void dateOfBirth_EditValueChanged(object sender, EventArgs e)
        {
            lbAge.Text = CalculateAge(dateOfBirth.DateTime).ToString();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MssBox.QuestionYesNo("คุณต้องการบันทึกข้อมูลพนักงาน ใช่ หรือ ไม่ ?") == DialogResult.Yes)
                {
                    MssBox.iWaitForm(splashScreenManager1);

                    var db = new CDMSDBDataContext(Program.conStr);

                    var ChkKey = (from x in db.Employees
                                  where x.Emp_Key == EmpID
                                  select x).FirstOrDefault();

                    if (ChkKey == null)
                    {
                        using (var tran = new System.Transactions.TransactionScope())
                        {
                            var AddID = new AddressByIDCard();
                            AddID.AddrIDCard_Address_NO = txtAddIDNo.Text;
                            AddID.AddrIDCard_Address_Moo = txtAddIDMoo.Text;
                            AddID.AddrIDCard_Address_Soi = txtAddIDSoi.Text;
                            AddID.AddrIDCard_Address_Street = txtAddIDStreet.Text;
                            AddID.AddrIDCard_Address_District = Convert.ToInt32(LookAddIDDistrict.EditValue);
                            AddID.AddrIDCard_Address_Amphur = Convert.ToInt32(LookAddIDAmphur.EditValue);
                            AddID.AddrIDCard_Address_Province = Convert.ToInt32(LookAddIDProvince.EditValue);
                            AddID.AddrIDCard_Address_ZipCode = Convert.ToInt32(txtAddIDZipCode.Text);
                            AddID.AddrIDCard_Telelphone = txtAddIDTel.Text;
                            AddID.AddrIDCard_Status = 1;
                            AddID.AddrIDCard_Del = 0;
                            db.AddressByIDCards.InsertOnSubmit(AddID);
                            db.SubmitChanges();

                            var AddCon = new AddressByContact();
                            AddCon.AddrCont_Address_NO = txtAddConNo.Text;
                            AddCon.AddrCont_Address_Moo = txtAddConMoo.Text;
                            AddCon.AddrCont_Address_Soi = txtAddConSoi.Text;
                            AddCon.AddrCont_Address_Street = txtAddConStreet.Text;
                            AddCon.AddrCont_Address_District = Convert.ToInt32(LookAddConDistrict.EditValue);
                            AddCon.AddrCont_Address_Amphur = Convert.ToInt32(LookAddConAmphur.EditValue);
                            AddCon.AddrCont_Address_Province = Convert.ToInt32(LookAddConProvince.EditValue);
                            AddCon.AddrCont_Address_ZipCode = Convert.ToInt32(txtAddConZipCode.Text);
                            AddCon.AddrCont_Telelphone = txtAddConTel.Text;
                            AddCon.AddrCont_Status = 1;
                            AddCon.AddrCont_Del = 0;
                            db.AddressByContacts.InsertOnSubmit(AddCon);
                            db.SubmitChanges();

                            var AddFac = new AddressByCompany();
                            AddFac.AddrCom_Name = txtAddFacName.Text;
                            AddFac.AddrCom_Address_NO = txtAddFacNo.Text;
                            AddFac.AddrCom_Address_Moo = txtAddFacMoo.Text;
                            AddFac.AddrCom_Address_Soi = txtAddFacSoi.Text;
                            AddFac.AddrCom_Address_Street = txtAddFacStreet.Text;
                            AddFac.AddrCom_Address_District = Convert.ToInt32(LookAddFacDistrict.EditValue);
                            AddFac.AddrCom_Address_Amphur = Convert.ToInt32(LookAddFacAmphur.EditValue);
                            AddFac.AddrCom_Address_Province = Convert.ToInt32(LookAddFacProvince.EditValue);
                            AddFac.AddrCom_Address_ZipCode = Convert.ToInt32(txtAddFacZipCode.Text);
                            AddFac.AddrCom_Telelphone = txtAddFacTel.Text;
                            AddFac.AddrCom_Status = 1;
                            AddFac.AddrCom_Del = 0;
                            db.AddressByCompanies.InsertOnSubmit(AddFac);
                            db.SubmitChanges();

                            var Emp = new Employee();
                            Emp.Birthday = dateOfBirth.DateTime.Date;
                            Emp.StartDayWork = dateOfWork.DateTime.Date;
                            Emp.IDCard = txtIDCard.Text;
                            //Emp.EmployeeID
                            Emp.Emp_Fname = txtFName.Text;
                            Emp.Emp_Name = txtFName.Text + "  " + txtSName.Text;
                            Emp.Emp_Surname = txtSName.Text;
                            Emp.Age = Convert.ToInt32(lbAge.Text);
                            Emp.Title_Key = Convert.ToInt32(LookTitle.EditValue);
                            Emp.Gender_Key = Convert.ToInt32(radioGender.EditValue);
                            Emp.Dept_Key = Convert.ToInt32(LookDept.EditValue);
                            Emp.Sec_Key = Convert.ToInt32(LookSec.EditValue);
                            Emp.Brn_Key = Convert.ToInt32(LookBrn.EditValue);
                            Emp.Fact_Key = Convert.ToInt32(LookFac.EditValue);
                            Emp.AddrIDCard_Key = AddID.AddrIDCard_Key;
                            Emp.AddrCont_Key = AddCon.AddrCont_Key;
                            Emp.AddrCom_Key = AddFac.AddrCom_Key;
                            Emp.Emp_REM = memoREM.Text;
                            Emp.Emp_Status = 1;
                            Emp.Emp_Del = 0;
                            db.Employees.InsertOnSubmit(Emp);
                            db.SubmitChanges();

                            tran.Complete();
                        }
                    }
                    else
                    {
                        using (var tran = new System.Transactions.TransactionScope())
                        {
                            var AddID = (from x in db.AddressByIDCards
                                         where x.AddrIDCard_Key == ChkKey.AddrIDCard_Key
                                         select x).FirstOrDefault();

                            AddID.AddrIDCard_Address_NO = txtAddIDNo.Text;
                            AddID.AddrIDCard_Address_Moo = txtAddIDMoo.Text;
                            AddID.AddrIDCard_Address_Soi = txtAddIDSoi.Text;
                            AddID.AddrIDCard_Address_Street = txtAddIDStreet.Text;
                            AddID.AddrIDCard_Address_District = Convert.ToInt32(LookAddIDDistrict.EditValue);
                            AddID.AddrIDCard_Address_Amphur = Convert.ToInt32(LookAddIDAmphur.EditValue);
                            AddID.AddrIDCard_Address_Province = Convert.ToInt32(LookAddIDProvince.EditValue);
                            AddID.AddrIDCard_Address_ZipCode = Convert.ToInt32(txtAddIDZipCode.Text);
                            AddID.AddrIDCard_Telelphone = txtAddIDTel.Text;
                            AddID.AddrIDCard_Status = 1;
                            AddID.AddrIDCard_Del = 0;
                            db.SubmitChanges();

                            var AddCon = (from x in db.AddressByContacts
                                          where x.AddrCont_Key == ChkKey.AddrCont_Key
                                          select x).FirstOrDefault();

                            AddCon.AddrCont_Address_NO = txtAddConNo.Text;
                            AddCon.AddrCont_Address_Moo = txtAddConMoo.Text;
                            AddCon.AddrCont_Address_Soi = txtAddConSoi.Text;
                            AddCon.AddrCont_Address_Street = txtAddConStreet.Text;
                            AddCon.AddrCont_Address_District = Convert.ToInt32(LookAddConDistrict.EditValue);
                            AddCon.AddrCont_Address_Amphur = Convert.ToInt32(LookAddConAmphur.EditValue);
                            AddCon.AddrCont_Address_Province = Convert.ToInt32(LookAddConProvince.EditValue);
                            AddCon.AddrCont_Address_ZipCode = Convert.ToInt32(txtAddConZipCode.Text);
                            AddCon.AddrCont_Telelphone = txtAddConTel.Text;
                            AddCon.AddrCont_Status = 1;
                            AddCon.AddrCont_Del = 0;
                            db.SubmitChanges();

                            var AddFac = (from x in db.AddressByCompanies
                                          where x.AddrCom_Key == ChkKey.AddrCom_Key
                                          select x).FirstOrDefault();

                            AddFac.AddrCom_Name = txtAddFacName.Text;
                            AddFac.AddrCom_Address_NO = txtAddFacNo.Text;
                            AddFac.AddrCom_Address_Moo = txtAddFacMoo.Text;
                            AddFac.AddrCom_Address_Soi = txtAddFacSoi.Text;
                            AddFac.AddrCom_Address_Street = txtAddFacStreet.Text;
                            AddFac.AddrCom_Address_District = Convert.ToInt32(LookAddFacDistrict.EditValue);
                            AddFac.AddrCom_Address_Amphur = Convert.ToInt32(LookAddFacAmphur.EditValue);
                            AddFac.AddrCom_Address_Province = Convert.ToInt32(LookAddFacProvince.EditValue);
                            AddFac.AddrCom_Address_ZipCode = Convert.ToInt32(txtAddFacZipCode.Text);
                            AddFac.AddrCom_Telelphone = txtAddFacTel.Text;
                            AddFac.AddrCom_Status = 1;
                            AddFac.AddrCom_Del = 0;
                            db.SubmitChanges();

                            var Emp = (from x in db.Employees
                                       where x.Emp_Key == ChkKey.Emp_Key
                                       select x).FirstOrDefault();

                            Emp.Birthday = dateOfBirth.DateTime.Date;
                            Emp.StartDayWork = dateOfWork.DateTime.Date;
                            Emp.IDCard = txtIDCard.Text;
                            //Emp.EmployeeID
                            Emp.Emp_Fname = txtFName.Text;
                            Emp.Emp_Name = txtFName.Text + "  " + txtSName.Text;
                            Emp.Emp_Surname = txtSName.Text;
                            Emp.Age = Convert.ToInt32(lbAge.Text);
                            Emp.Title_Key = Convert.ToInt32(LookTitle.EditValue);
                            Emp.Gender_Key = Convert.ToInt32(radioGender.EditValue);
                            Emp.Dept_Key = Convert.ToInt32(LookDept.EditValue);
                            Emp.Sec_Key = Convert.ToInt32(LookSec.EditValue);
                            Emp.Brn_Key = Convert.ToInt32(LookBrn.EditValue);
                            Emp.Fact_Key = Convert.ToInt32(LookFac.EditValue);
                            Emp.AddrIDCard_Key = AddID.AddrIDCard_Key;
                            Emp.AddrCont_Key = AddCon.AddrCont_Key;
                            Emp.AddrCom_Key = AddFac.AddrCom_Key;
                            Emp.Emp_REM = memoREM.Text;
                            Emp.Emp_Status = 1;
                            Emp.Emp_Del = 0;
                            db.SubmitChanges();

                            tran.Complete();
                        }
                    }
                    MssBox.iWaitForm(splashScreenManager1);
                    MssBox.Success("คุณได้ทำการบันทึกข้อมูลพนักงานเรียบร้อยแล้ว");
                    this.Close();
                }
                else { return; }
            }
            catch (Exception ex)
            {
                MssBox.iWaitForm(splashScreenManager1);
                MssBox.Error(ex.Message);
            }
        }

        private void btnOpenExp_Click(object sender, EventArgs e)
        {
            var ShowForm = new EmployeeHisWorkForm(EmpID);
            ShowForm.ShowDialog();
        }

        private void btnOpenSick_Click(object sender, EventArgs e)
        {
            var ShowForm = new EmployeeHistorySicknessForm(EmpID);
            ShowForm.ShowDialog();
        }
    }
}