using CDMS.Class.Entity;
using CDMS.Class.Function;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CDMS.Process.Management
{
    public partial class EmployeeHistorySicknessForm : DevExpress.XtraEditors.XtraForm
    {
        int emp_id = 0;
        public EmployeeHistorySicknessForm(int _emp_id)
        {
            InitializeComponent();
            emp_id = _emp_id;
        }


        private void EmployeeHistorySicknessForm_Load(object sender, EventArgs e)
        {
            historySicknessFamilyBindingSource.DataSource = new List<HistorySickness_Family>();
            historySicknessSickInjuryBindingSource.DataSource = new List<HistorySickness_SickInjury>();
        }

        private void EmployeeHistorySicknessForm_Shown(object sender, EventArgs e)
        {
            try
            {
                var db = new CDMSDBDataContext(Program.conStr);
                var get_hissink = (from i in db.HistorySicknesses where i.Emp_Key == this.emp_id select i).FirstOrDefault();

                if (get_hissink != null)
                {
                    //Open
                    historySicknessSickInjuryBindingSource.DataSource = get_hissink.HistorySickness_SickInjuries.ToList();

                    radioGroupDiseaseChronic2.EditValue = get_hissink.Hts_DiseaseChronic;
                    tbDiseaseChronic2.EditValue = get_hissink.Hts_DiseaseChronic_Specify;

                    radioGroupSergery3.EditValue = get_hissink.Hts_Sergery;
                    tbSergery3.EditValue = get_hissink.Hts_Sergery_Specify;

                    radioGroupImmunity4.EditValue = get_hissink.Hts_Immunity;
                    tbImmunity4.EditValue = get_hissink.Hts_Immunity_Specify;

                    radioGroupFamily5.EditValue = get_hissink.Hts_Family;
                    historySicknessFamilyBindingSource.DataSource = get_hissink.HistorySickness_Families.ToList();

                    radioGroupMedicine6.EditValue = get_hissink.Hts_Medicine;
                    tbMedicine6.EditValue = get_hissink.Hts_Medicine_Specify;

                    radioGroupMedicineAllergic7.EditValue = get_hissink.Hts_MedicineAllergic;
                    tbMedicineAllergic7.EditValue = get_hissink.Hts_MedicineAllergic_Specify;

                    radioGroupSmoking8.EditValue = get_hissink.Hts_Smoking;
                    tbPresentCount8.EditValue = get_hissink.Hts_Smoking_PresentCount;
                    tbQuitMonth8.EditValue = get_hissink.Hts_Smoking_QuitMonth;
                    tbQuitYear8.EditValue = get_hissink.Hts_Smoking_QuitYear;
                    tbBeforeQuitCount8.EditValue = get_hissink.Hts_Somking_BeforeQuitCount;

                    radioGroupDrinking9.EditValue = get_hissink.Hts_Drinking;
                    tbQuitMonth9.EditValue = get_hissink.Hts_Drinking_QuitMonth;
                    tbQuitYear9.EditValue = get_hissink.Hts_Drinking_QuitYear;

                    radioGroupAddictive10.EditValue = get_hissink.Hts_Addictive;
                    tbAddictive10.EditValue = get_hissink.Hts_Addictive_Specify;

                    tbOthers11.EditValue = get_hissink.Hts_Others;
                }
            }
            catch (Exception ex)
            {
                MssBox.Error(ex);
            }
        }

        private void btSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!dxValidationProvider10.Validate())
                {
                    return;
                }

                if (!CheckBefore()) { return; }
                var db = new CDMSDBDataContext(Program.conStr);
                gv_sicklnjury.CloseEditor();
                gvSickness_Family.CloseEditor();
                var date_sv = MssBox.GetDateServer(db);

                #region Save_sickness_and_detail and Update

                MssBox.iWaitForm(splashScreenManager1);
                #region เตียมข้อมูล
                var getdatafor_sickness = (from i in db.HistorySicknesses where i.Emp_Key == this.emp_id select i).FirstOrDefault();

                var sickn_ls = (List<HistorySickness_SickInjury>)historySicknessSickInjuryBindingSource.DataSource;
                string[] for_del_sickn = { "0" };
                if (sickn_ls.Count > 0)
                {
                    string[] not_del_sickn = sickn_ls.Select(x => x.Htss_Key.ToString()).ToArray();
                    for_del_sickn = (from i in db.HistorySickness_SickInjuries where (i.Hts_Key == getdatafor_sickness.Hts_Key && !not_del_sickn.Contains(i.Htss_Key.ToString())) select i.Htss_Key.ToString()).ToArray();
                }

                var family_ls = (List<HistorySickness_Family>)historySicknessFamilyBindingSource.DataSource;
                string[] for_del_fam = { "0" }; ;
                if (family_ls.Count > 0)
                {
                    string[] not_del_fam = family_ls.Select(x => x.Htsf_Key.ToString()).ToArray();
                    for_del_fam = (from i in db.HistorySickness_Families where (i.Hts_Key == getdatafor_sickness.Hts_Key && !not_del_fam.Contains(i.Htsf_Key.ToString())) select i.Htsf_Key.ToString()).ToArray();
                }
                #endregion

                using (var ts = new System.Transactions.TransactionScope())
                {
                    int EHS_id = 0;
                    if (getdatafor_sickness == null)
                    {
                        //Save
                        var EHS = new HistorySickness();
                        EHS.Hts_DiseaseChronic = Convert.ToBoolean(radioGroupDiseaseChronic2.EditValue);
                        EHS.Hts_DiseaseChronic_Specify = tbDiseaseChronic2.Text;
                        EHS.Hts_Sergery = Convert.ToBoolean(radioGroupSergery3.EditValue);
                        EHS.Hts_Sergery_Specify = tbSergery3.Text;
                        EHS.Hts_Immunity = Convert.ToBoolean(radioGroupImmunity4.EditValue);
                        EHS.Hts_Immunity_Specify = tbImmunity4.Text;
                        EHS.Hts_Family = Convert.ToBoolean(radioGroupFamily5.EditValue);
                        EHS.Hts_Family_Specify = string.Empty;
                        EHS.Hts_Medicine = Convert.ToBoolean(radioGroupMedicine6.EditValue);
                        EHS.Hts_Medicine_Specify = tbMedicine6.Text;
                        EHS.Hts_MedicineAllergic = Convert.ToBoolean(radioGroupMedicineAllergic7.EditValue);
                        EHS.Hts_MedicineAllergic_Specify = tbMedicineAllergic7.Text;
                        EHS.Hts_Smoking = Convert.ToInt32(radioGroupSmoking8.EditValue);
                        EHS.Hts_Smoking_PresentCount = Convert.ToInt32(tbPresentCount8.EditValue ?? "0");
                        EHS.Hts_Smoking_QuitYear = Convert.ToInt32(tbQuitYear8.EditValue ?? "0");
                        EHS.Hts_Smoking_QuitMonth = Convert.ToInt32(tbQuitMonth8.EditValue ?? "0");
                        EHS.Hts_Somking_BeforeQuitCount = Convert.ToInt32(tbBeforeQuitCount8.EditValue ?? "0");
                        EHS.Hts_Drinking = Convert.ToInt32(radioGroupDrinking9.EditValue);
                        EHS.Hts_Drinking_QuitYear = Convert.ToInt32(tbQuitYear9.EditValue ?? "0");
                        EHS.Hts_Drinking_QuitMonth = Convert.ToInt32(tbQuitMonth9.EditValue ?? "0");
                        EHS.Hts_Addictive = Convert.ToBoolean(radioGroupAddictive10.EditValue);
                        EHS.Hts_Addictive_Specify = tbAddictive10.Text;
                        EHS.Hts_Others = tbOthers11.Text;
                        EHS.Hts_Rem = "Remark";
                        EHS.Hts_CreateBy = 0;
                        EHS.Hts_ModifyDateTime = date_sv;
                        EHS.Hts_ModifyBy = 0;
                        EHS.Hts_Status = 0;
                        EHS.Hts_Del = 0;
                        EHS.Emp_Key = this.emp_id;
                        db.HistorySicknesses.InsertOnSubmit(EHS);
                        db.SubmitChanges();

                        EHS_id = EHS.Hts_Key;
                    }
                    else
                    {
                        //Update
                        MssBox.iWaitForm(splashScreenManager1);
                        if (MssBox.QuestionYesNo("คุณต้องการอัพเดตข้อมูลประวัติการป่วย ใช่หรือไม่") == System.Windows.Forms.DialogResult.No)
                        { return; }
                        MssBox.iWaitForm(splashScreenManager1);

                        EHS_id = getdatafor_sickness.Hts_Key;

                        getdatafor_sickness.Hts_DiseaseChronic = Convert.ToBoolean(radioGroupDiseaseChronic2.EditValue);
                        getdatafor_sickness.Hts_DiseaseChronic_Specify = tbDiseaseChronic2.Text;
                        getdatafor_sickness.Hts_Sergery = Convert.ToBoolean(radioGroupSergery3.EditValue);
                        getdatafor_sickness.Hts_Sergery_Specify = tbSergery3.Text;
                        getdatafor_sickness.Hts_Immunity = Convert.ToBoolean(radioGroupImmunity4.EditValue);
                        getdatafor_sickness.Hts_Immunity_Specify = tbImmunity4.Text;
                        getdatafor_sickness.Hts_Family = Convert.ToBoolean(radioGroupFamily5.EditValue);
                        getdatafor_sickness.Hts_Family_Specify = string.Empty;
                        getdatafor_sickness.Hts_Medicine = Convert.ToBoolean(radioGroupMedicine6.EditValue);
                        getdatafor_sickness.Hts_Medicine_Specify = tbMedicine6.Text;
                        getdatafor_sickness.Hts_MedicineAllergic = Convert.ToBoolean(radioGroupMedicineAllergic7.EditValue);
                        getdatafor_sickness.Hts_MedicineAllergic_Specify = tbMedicineAllergic7.Text;
                        getdatafor_sickness.Hts_Smoking = Convert.ToInt32(radioGroupSmoking8.EditValue);
                        getdatafor_sickness.Hts_Smoking_PresentCount = Convert.ToInt32(tbPresentCount8.EditValue ?? "0");
                        getdatafor_sickness.Hts_Smoking_QuitYear = Convert.ToInt32(tbQuitYear8.EditValue ?? "0");
                        getdatafor_sickness.Hts_Smoking_QuitMonth = Convert.ToInt32(tbQuitMonth8.EditValue ?? "0");
                        getdatafor_sickness.Hts_Somking_BeforeQuitCount = Convert.ToInt32(tbBeforeQuitCount8.EditValue ?? "0");
                        getdatafor_sickness.Hts_Drinking = Convert.ToInt32(radioGroupDrinking9.EditValue);
                        getdatafor_sickness.Hts_Drinking_QuitYear = Convert.ToInt32(tbQuitYear9.EditValue ?? "0");
                        getdatafor_sickness.Hts_Drinking_QuitMonth = Convert.ToInt32(tbQuitMonth9.EditValue ?? "0");
                        getdatafor_sickness.Hts_Addictive = Convert.ToBoolean(radioGroupAddictive10.EditValue);
                        getdatafor_sickness.Hts_Addictive_Specify = tbAddictive10.Text;
                        getdatafor_sickness.Hts_Others = tbOthers11.Text;
                        getdatafor_sickness.Hts_Rem = "Remark";
                        getdatafor_sickness.Hts_CreateBy = 0;
                        getdatafor_sickness.Hts_ModifyDateTime = date_sv;
                        getdatafor_sickness.Hts_ModifyBy = 0;
                        getdatafor_sickness.Hts_Status = 0;
                        getdatafor_sickness.Hts_Del = 0;
                        getdatafor_sickness.Emp_Key = this.emp_id;
                        db.SubmitChanges();
                    }

                    if (sickn_ls.Count > 0)
                    {
                        var _Sicklnjury = new List<HistorySickness_SickInjury>();
                        foreach (var item in sickn_ls)
                        {
                            if (item.Htss_Key == 0)
                            {
                                var set_data = new HistorySickness_SickInjury()
                                {
                                    Htss_SicknessInjury = item.Htss_SicknessInjury,
                                    Htss_OnYear = item.Htss_OnYear,
                                    Htss_Rem = "Remark",
                                    Htss_CreateBy = 0,
                                    Htss_ModifyDateTime = date_sv,
                                    Htss_ModifyBy = 0,
                                    Htss_Status = 0,
                                    Htss_Del = 0,
                                    Hts_Key = EHS_id
                                };
                                _Sicklnjury.Add(set_data);
                            }
                            else
                            {
                                var get_Update = (from i in db.HistorySickness_SickInjuries where i.Htss_Key == item.Htss_Key select i).FirstOrDefault();
                                get_Update.Htss_SicknessInjury = item.Htss_SicknessInjury;
                                get_Update.Htss_OnYear = item.Htss_OnYear;
                                get_Update.Htss_Rem = "Remark";
                                get_Update.Htss_CreateBy = 0;
                                get_Update.Htss_ModifyDateTime = date_sv;
                                get_Update.Htss_ModifyBy = 0;
                                get_Update.Htss_Status = 0;
                                get_Update.Htss_Del = 0;
                                db.SubmitChanges();
                            }
                        }
                        db.HistorySickness_SickInjuries.InsertAllOnSubmit(_Sicklnjury);
                    }

                    if (family_ls.Count > 0)
                    {
                        var _Family = new List<HistorySickness_Family>();
                        foreach (var item in family_ls)
                        {
                            if (item.Htsf_Key == 0)
                            {
                                var set_data = new HistorySickness_Family()
                                {
                                    Htsf_Relation = item.Htsf_Relation,
                                    Htsf_Disease = item.Htsf_Disease,
                                    Htsf_Rem = "Remark",
                                    Htsf_CreateBy = 0,
                                    Htsf_ModifyDateTime = date_sv,
                                    Htsf_ModifyBy = 0,
                                    Htsf_Status = 0,
                                    Htsf_Del = 0,
                                    Hts_Key = EHS_id
                                };
                                _Family.Add(set_data);
                            }
                            else
                            {
                                var get_Update = (from i in db.HistorySickness_Families where i.Htsf_Key == item.Htsf_Key select i).FirstOrDefault();
                                get_Update.Htsf_Relation = item.Htsf_Relation;
                                get_Update.Htsf_Disease = item.Htsf_Disease;
                                get_Update.Htsf_Rem = "Remark";
                                get_Update.Htsf_CreateBy = 0;
                                get_Update.Htsf_ModifyDateTime = date_sv;
                                get_Update.Htsf_ModifyBy = 0;
                                get_Update.Htsf_Status = 0;
                                get_Update.Htsf_Del = 0;
                                db.SubmitChanges();
                            }
                        }
                        db.HistorySickness_Families.InsertAllOnSubmit(_Family);
                    }

                    #region Delete Detail sickness && family
                    var get_del_sikn = (from i in db.HistorySickness_SickInjuries where for_del_sickn.Contains(i.Htss_Key.ToString()) select i).ToList();
                    if (get_del_sikn.Count > 0)
                    {
                        db.HistorySickness_SickInjuries.DeleteAllOnSubmit(get_del_sikn);
                        db.SubmitChanges();
                    }

                    var get_del_fami = (from i in db.HistorySickness_Families where for_del_fam.Contains(i.Htsf_Key.ToString()) select i).ToList();
                    if (get_del_fami.Count > 0)
                    {
                        db.HistorySickness_Families.DeleteAllOnSubmit(get_del_fami);
                        db.SubmitChanges();
                    }
                    #endregion

                    db.SubmitChanges();
                    ts.Complete();
                    MssBox.iWaitForm(splashScreenManager1);
                    MssBox.Success();
                }
                #endregion
            }
            catch (Exception ex)
            {
                MssBox.iWaitForm(splashScreenManager1);
                MssBox.Error(ex);
            }
        }

        bool CheckBefore()
        {
            dxValidationProvider1.RemoveControlError(tbDiseaseChronic2);
            dxValidationProvider2.RemoveControlError(tbSergery3);
            dxValidationProvider3.RemoveControlError(tbImmunity4);
            dxValidationProvider4.RemoveControlError(tbMedicine6);
            dxValidationProvider5.RemoveControlError(tbMedicineAllergic7);
            dxValidationProvider6.RemoveControlError(tbPresentCount8);
            dxValidationProvider7.RemoveControlError(tbQuitYear8);
            dxValidationProvider7.RemoveControlError(tbBeforeQuitCount8);
            dxValidationProvider7.RemoveControlError(tbQuitMonth8);
            dxValidationProvider8.RemoveControlError(tbQuitMonth9);
            dxValidationProvider8.RemoveControlError(tbQuitYear9);
            dxValidationProvider9.RemoveControlError(tbAddictive10);

            int _errcount = 0;
            if (Convert.ToBoolean(radioGroupDiseaseChronic2.EditValue))
            {
                if (!dxValidationProvider1.Validate())
                {
                    _errcount++;
                }
            }
            if (Convert.ToBoolean(radioGroupSergery3.EditValue))
            {
                if (!dxValidationProvider2.Validate())
                {
                    _errcount++;
                }
            }
            if (Convert.ToBoolean(radioGroupImmunity4.EditValue))
            {
                if (!dxValidationProvider3.Validate())
                {
                    _errcount++;
                }
            }
            if (Convert.ToBoolean(radioGroupFamily5.EditValue))
            {
                var ls = (List<HistorySickness_Family>)historySicknessFamilyBindingSource.DataSource;
                if (ls.Count == 0)
                {
                    MssBox.Warning("กรุณาระบุความสัมพันธ์และโรค ในข้อ (5)");
                }
            }
            if (Convert.ToBoolean(radioGroupMedicine6.EditValue))
            {
                if (!dxValidationProvider4.Validate())
                {
                    _errcount++;
                }
            }
            if (Convert.ToBoolean(radioGroupMedicineAllergic7.EditValue))
            {
                if (!dxValidationProvider5.Validate())
                {
                    _errcount++;
                }
            }
            if (Convert.ToInt32(radioGroupSmoking8.EditValue) == 1)
            {
                if (!dxValidationProvider6.Validate())
                {
                    _errcount++;
                }
            }
            if (Convert.ToInt32(radioGroupSmoking8.EditValue) == 2)
            {
                if (!dxValidationProvider7.Validate())
                {
                    _errcount++;
                }
            }
            if (Convert.ToInt32(radioGroupDrinking9.EditValue) == 5)
            {
                if (!dxValidationProvider8.Validate())
                {
                    _errcount++;
                }
            }
            if (Convert.ToBoolean(radioGroupAddictive10.EditValue))
            {
                if (!dxValidationProvider9.Validate())
                {
                    _errcount++;
                }
            }

            if (_errcount > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void radioGroupDiseaseChronic2_EditValueChanged(object sender, EventArgs e)
        {
            CheckRadioForTxt(sender, tbDiseaseChronic2);
        }

        void CheckRadioForTxt(object sender, MemoEdit tb)
        {
            var x = sender as RadioGroup;
            bool _rdo = Convert.ToBoolean(x.EditValue);
            if (_rdo)
            {
                tb.Enabled = true;
            }
            else
            {
                tb.Enabled = false;
            }
        }

        private void radioGroupSergery3_EditValueChanged(object sender, EventArgs e)
        {
            CheckRadioForTxt(sender, tbSergery3);
        }

        private void radioGroupImmunity4_EditValueChanged(object sender, EventArgs e)
        {
            CheckRadioForTxt(sender, tbImmunity4);
        }

        private void radioGroupFamily5_EditValueChanged(object sender, EventArgs e)
        {
            var x = sender as RadioGroup;
            bool _rdo = Convert.ToBoolean(x.EditValue);
            if (_rdo)
            {
                gvSickness_Family.OptionsBehavior.Editable = true;
            }
            else
            {
                gvSickness_Family.OptionsBehavior.Editable = false;
            }
        }

        private void radioGroupMedicine6_EditValueChanged(object sender, EventArgs e)
        {
            CheckRadioForTxt(sender, tbMedicine6);
        }

        private void radioGroupMedicineAllergic7_EditValueChanged(object sender, EventArgs e)
        {
            CheckRadioForTxt(sender, tbMedicineAllergic7);
        }

        private void radioGroupSmoking8_EditValueChanged(object sender, EventArgs e)
        {
            var x = sender as RadioGroup;
            int _rdo = Convert.ToInt32(x.EditValue);
            if (_rdo == 0)
            {
                tbPresentCount8.Enabled = false;
                tbQuitYear8.Enabled = false;
                tbQuitMonth8.Enabled = false;
                tbBeforeQuitCount8.Enabled = false;
            }
            else if (_rdo == 1)
            {

                tbPresentCount8.Enabled = true;
                tbQuitYear8.Enabled = false;
                tbQuitMonth8.Enabled = false;
                tbBeforeQuitCount8.Enabled = false;
            }
            else
            {
                tbPresentCount8.Enabled = false;
                tbQuitYear8.Enabled = true;
                tbQuitMonth8.Enabled = true;
                tbBeforeQuitCount8.Enabled = true;
            }
        }

        private void radioGroupAddictive10_EditValueChanged(object sender, EventArgs e)
        {
            CheckRadioForTxt(sender, tbAddictive10);
        }

        private void radioGroupDrinking9_EditValueChanged(object sender, EventArgs e)
        {
            var x = sender as RadioGroup;
            int _rdo = Convert.ToInt32(x.EditValue);
            if (_rdo == 5)
            {
                tbQuitYear9.Enabled = true;
                tbQuitMonth9.Enabled = true;
            }
            else
            {
                tbQuitYear9.Enabled = false;
                tbQuitMonth9.Enabled = false;
            }
        }

    }
}