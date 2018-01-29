namespace CDMS.Process.Management
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.gridEmp = new DevExpress.XtraGrid.GridControl();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridVEmp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmp_Fname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmp_Surname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDpt_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSec_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrn_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFact_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDayWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewEmp = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditEmp = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::CDMS.Setting.WaitForm1), true, true);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridEmp
            // 
            this.gridEmp.DataSource = this.employeeBindingSource;
            this.gridEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEmp.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gridEmp.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridEmp.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gridEmp.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridEmp.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridEmp.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridEmp.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gridEmp.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridEmp.EmbeddedNavigator.Buttons.NextPage.Enabled = false;
            this.gridEmp.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gridEmp.EmbeddedNavigator.Buttons.PrevPage.Enabled = false;
            this.gridEmp.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gridEmp.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gridEmp.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridEmp.Location = new System.Drawing.Point(3, 3);
            this.gridEmp.MainView = this.gridVEmp;
            this.gridEmp.MenuManager = this.mainRibbonControl;
            this.gridEmp.Name = "gridEmp";
            this.gridEmp.Size = new System.Drawing.Size(965, 446);
            this.gridEmp.TabIndex = 3;
            this.gridEmp.UseEmbeddedNavigator = true;
            this.gridEmp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVEmp});
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(CDMS.Class.Entity.Employee);
            // 
            // gridVEmp
            // 
            this.gridVEmp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeID,
            this.colEmp_Fname,
            this.colEmp_Surname,
            this.colGender,
            this.colDpt_Name,
            this.colSec_Name,
            this.colBrn_Name,
            this.colFact_Name,
            this.colStartDayWork});
            this.gridVEmp.GridControl = this.gridEmp;
            this.gridVEmp.Name = "gridVEmp";
            this.gridVEmp.OptionsBehavior.Editable = false;
            this.gridVEmp.OptionsBehavior.ReadOnly = true;
            this.gridVEmp.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridVEmp_RowCellClick);
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.Caption = "รหัสพนักงาน";
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 0;
            // 
            // colEmp_Fname
            // 
            this.colEmp_Fname.Caption = "ชื่อ";
            this.colEmp_Fname.FieldName = "Emp_Fname";
            this.colEmp_Fname.Name = "colEmp_Fname";
            this.colEmp_Fname.Visible = true;
            this.colEmp_Fname.VisibleIndex = 1;
            // 
            // colEmp_Surname
            // 
            this.colEmp_Surname.Caption = "นามสกุล";
            this.colEmp_Surname.FieldName = "Emp_Surname";
            this.colEmp_Surname.Name = "colEmp_Surname";
            this.colEmp_Surname.Visible = true;
            this.colEmp_Surname.VisibleIndex = 2;
            // 
            // colGender
            // 
            this.colGender.Caption = "เพศ";
            this.colGender.FieldName = "Gender.Gender_Name";
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 3;
            // 
            // colDpt_Name
            // 
            this.colDpt_Name.Caption = "แผนก";
            this.colDpt_Name.FieldName = "Dept.Dpt_Name";
            this.colDpt_Name.Name = "colDpt_Name";
            this.colDpt_Name.Visible = true;
            this.colDpt_Name.VisibleIndex = 4;
            // 
            // colSec_Name
            // 
            this.colSec_Name.Caption = "หน่วยงาน";
            this.colSec_Name.FieldName = "Section.Sec_Name";
            this.colSec_Name.Name = "colSec_Name";
            this.colSec_Name.Visible = true;
            this.colSec_Name.VisibleIndex = 5;
            // 
            // colBrn_Name
            // 
            this.colBrn_Name.Caption = "สาขา";
            this.colBrn_Name.FieldName = "Branch.Brn_Name";
            this.colBrn_Name.Name = "colBrn_Name";
            this.colBrn_Name.Visible = true;
            this.colBrn_Name.VisibleIndex = 6;
            // 
            // colFact_Name
            // 
            this.colFact_Name.Caption = "บริษัท";
            this.colFact_Name.FieldName = "Factory.Fact_Name";
            this.colFact_Name.Name = "colFact_Name";
            this.colFact_Name.Visible = true;
            this.colFact_Name.VisibleIndex = 7;
            // 
            // colStartDayWork
            // 
            this.colStartDayWork.Caption = "วันเริ่มงาน";
            this.colStartDayWork.FieldName = "StartDayWork";
            this.colStartDayWork.Name = "colStartDayWork";
            this.colStartDayWork.Visible = true;
            this.colStartDayWork.VisibleIndex = 8;
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose,
            this.btnNewEmp,
            this.btnEditEmp});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 12;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(971, 143);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "รีเฟรช";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiReset.ImageOptions.Image")));
            this.bbiReset.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiReset.ImageOptions.LargeImage")));
            this.bbiReset.Name = "bbiReset";
            this.bbiReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReset_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "ลบ";
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDelete.ImageOptions.Image")));
            this.bbiDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDelete.ImageOptions.LargeImage")));
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "ปิด";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiClose.ImageOptions.Image")));
            this.bbiClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiClose.ImageOptions.LargeImage")));
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // btnNewEmp
            // 
            this.btnNewEmp.Caption = "เพิ่ม";
            this.btnNewEmp.Id = 10;
            this.btnNewEmp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewEmp.ImageOptions.Image")));
            this.btnNewEmp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNewEmp.ImageOptions.LargeImage")));
            this.btnNewEmp.Name = "btnNewEmp";
            this.btnNewEmp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewEmp_ItemClick);
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.Caption = "แก้ไข";
            this.btnEditEmp.Id = 11;
            this.btnEditEmp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditEmp.ImageOptions.Image")));
            this.btnEditEmp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEditEmp.ImageOptions.LargeImage")));
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditEmp_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 1;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "ไฟล์";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.ItemLinks.Add(this.btnNewEmp);
            this.mainRibbonPageGroup.ItemLinks.Add(this.btnEditEmp);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiDelete);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiReset, true);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "ส่วนงาน";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.gridEmp);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 143);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(3);
            this.panelControl1.Size = new System.Drawing.Size(971, 452);
            this.panelControl1.TabIndex = 5;
            // 
            // EmployeeForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(971, 595);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeForm";
            this.Ribbon = this.mainRibbonControl;
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraGrid.GridControl gridEmp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVEmp;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmp_Fname;
        private DevExpress.XtraGrid.Columns.GridColumn colEmp_Surname;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colDpt_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colSec_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colBrn_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colFact_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDayWork;
        private DevExpress.XtraBars.BarButtonItem btnNewEmp;
        private DevExpress.XtraBars.BarButtonItem btnEditEmp;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}