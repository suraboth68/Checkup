namespace CDMS.Process.Management
{
    partial class EmployeeHisWorkForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeHisWorkForm));
            this.gridVHtwd = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHtwd_Factor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHtwd_Device = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHtwd_Rem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHtwd_Del = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridExp = new DevExpress.XtraGrid.GridControl();
            this.historyWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridVExp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHtw_CompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHtw_CompanyDept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHtw_Category = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHtw_JobDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHtw_StartDateForWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHtw_EndDateForWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.memoRem = new DevExpress.XtraEditors.MemoEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barSave = new DevExpress.XtraBars.BarButtonItem();
            this.barDel = new DevExpress.XtraBars.BarButtonItem();
            this.barRef = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDept = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnOpenFactor = new DevExpress.XtraEditors.SimpleButton();
            this.txtWorkType = new DevExpress.XtraEditors.TextEdit();
            this.txtComType = new DevExpress.XtraEditors.TextEdit();
            this.txtComName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.StopWorkDate = new DevExpress.XtraEditors.DateEdit();
            this.StartWorkDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridVHtwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyWorkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoRem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopWorkDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopWorkDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartWorkDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartWorkDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridVHtwd
            // 
            this.gridVHtwd.ActiveFilterString = "[Htwd_Del] = \'0\'";
            this.gridVHtwd.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHtwd_Factor,
            this.colHtwd_Device,
            this.colHtwd_Rem,
            this.colHtwd_Del});
            this.gridVHtwd.GridControl = this.gridExp;
            this.gridVHtwd.Name = "gridVHtwd";
            this.gridVHtwd.OptionsBehavior.Editable = false;
            this.gridVHtwd.OptionsBehavior.ReadOnly = true;
            this.gridVHtwd.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridVHtwd.OptionsView.ShowGroupPanel = false;
            // 
            // colHtwd_Factor
            // 
            this.colHtwd_Factor.Caption = "ปัจจัยเสี่ยงต่อสุขภาพ";
            this.colHtwd_Factor.FieldName = "Htwd_Factor";
            this.colHtwd_Factor.Name = "colHtwd_Factor";
            this.colHtwd_Factor.Visible = true;
            this.colHtwd_Factor.VisibleIndex = 0;
            // 
            // colHtwd_Device
            // 
            this.colHtwd_Device.Caption = "อุปกรณ์ป้องกันอันตราย";
            this.colHtwd_Device.FieldName = "Htwd_Device";
            this.colHtwd_Device.Name = "colHtwd_Device";
            this.colHtwd_Device.Visible = true;
            this.colHtwd_Device.VisibleIndex = 1;
            // 
            // colHtwd_Rem
            // 
            this.colHtwd_Rem.Caption = "หมายเหตุ";
            this.colHtwd_Rem.FieldName = "Htwd_Rem";
            this.colHtwd_Rem.Name = "colHtwd_Rem";
            this.colHtwd_Rem.Visible = true;
            this.colHtwd_Rem.VisibleIndex = 2;
            // 
            // colHtwd_Del
            // 
            this.colHtwd_Del.FieldName = "Htwd_Del";
            this.colHtwd_Del.Name = "colHtwd_Del";
            // 
            // gridExp
            // 
            this.gridExp.DataSource = this.historyWorkBindingSource;
            this.gridExp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridExp.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridLevelNode1.LevelTemplate = this.gridVHtwd;
            gridLevelNode1.RelationName = "HistoryWork_Details";
            this.gridExp.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridExp.Location = new System.Drawing.Point(2, 25);
            this.gridExp.MainView = this.gridVExp;
            this.gridExp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridExp.Name = "gridExp";
            this.gridExp.Size = new System.Drawing.Size(907, 380);
            this.gridExp.TabIndex = 0;
            this.gridExp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVExp,
            this.gridVHtwd});
            // 
            // historyWorkBindingSource
            // 
            this.historyWorkBindingSource.DataSource = typeof(CDMS.Class.Entity.HistoryWork);
            // 
            // gridVExp
            // 
            this.gridVExp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHtw_CompanyName,
            this.colHtw_CompanyDept,
            this.colHtw_Category,
            this.colHtw_JobDescription,
            this.colHtw_StartDateForWork,
            this.colHtw_EndDateForWork});
            this.gridVExp.GridControl = this.gridExp;
            this.gridVExp.Name = "gridVExp";
            this.gridVExp.OptionsBehavior.Editable = false;
            this.gridVExp.OptionsBehavior.ReadOnly = true;
            this.gridVExp.OptionsView.ShowGroupPanel = false;
            this.gridVExp.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridVExp_RowCellClick);
            // 
            // colHtw_CompanyName
            // 
            this.colHtw_CompanyName.Caption = "ชื่อสถานประกอบกิจการ";
            this.colHtw_CompanyName.FieldName = "Htw_CompanyName";
            this.colHtw_CompanyName.Name = "colHtw_CompanyName";
            this.colHtw_CompanyName.Visible = true;
            this.colHtw_CompanyName.VisibleIndex = 0;
            // 
            // colHtw_CompanyDept
            // 
            this.colHtw_CompanyDept.Caption = "แผนก";
            this.colHtw_CompanyDept.FieldName = "Htw_CompanyDept";
            this.colHtw_CompanyDept.Name = "colHtw_CompanyDept";
            this.colHtw_CompanyDept.Visible = true;
            this.colHtw_CompanyDept.VisibleIndex = 1;
            // 
            // colHtw_Category
            // 
            this.colHtw_Category.Caption = "ประเภทกิจการ";
            this.colHtw_Category.FieldName = "Htw_Category";
            this.colHtw_Category.Name = "colHtw_Category";
            this.colHtw_Category.Visible = true;
            this.colHtw_Category.VisibleIndex = 2;
            // 
            // colHtw_JobDescription
            // 
            this.colHtw_JobDescription.Caption = "ลักษณะงานที่ทำ";
            this.colHtw_JobDescription.FieldName = "Htw_JobDescription";
            this.colHtw_JobDescription.Name = "colHtw_JobDescription";
            this.colHtw_JobDescription.Visible = true;
            this.colHtw_JobDescription.VisibleIndex = 3;
            // 
            // colHtw_StartDateForWork
            // 
            this.colHtw_StartDateForWork.Caption = "เข้าทำงาน";
            this.colHtw_StartDateForWork.FieldName = "Htw_StartDateForWork";
            this.colHtw_StartDateForWork.Name = "colHtw_StartDateForWork";
            this.colHtw_StartDateForWork.Visible = true;
            this.colHtw_StartDateForWork.VisibleIndex = 4;
            // 
            // colHtw_EndDateForWork
            // 
            this.colHtw_EndDateForWork.Caption = "ออกจากงาน";
            this.colHtw_EndDateForWork.FieldName = "Htw_EndDateForWork";
            this.colHtw_EndDateForWork.Name = "colHtw_EndDateForWork";
            this.colHtw_EndDateForWork.Visible = true;
            this.colHtw_EndDateForWork.VisibleIndex = 5;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.memoRem);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.txtDept);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.btnOpenFactor);
            this.groupControl3.Controls.Add(this.txtWorkType);
            this.groupControl3.Controls.Add(this.txtComType);
            this.groupControl3.Controls.Add(this.txtComName);
            this.groupControl3.Controls.Add(this.labelControl17);
            this.groupControl3.Controls.Add(this.StopWorkDate);
            this.groupControl3.Controls.Add(this.StartWorkDate);
            this.groupControl3.Controls.Add(this.labelControl16);
            this.groupControl3.Controls.Add(this.labelControl15);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(2, 2);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(911, 236);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "ประวัติการทำงาน";
            // 
            // memoRem
            // 
            this.memoRem.Location = new System.Drawing.Point(549, 69);
            this.memoRem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.memoRem.MenuManager = this.barManager1;
            this.memoRem.Name = "memoRem";
            this.memoRem.Size = new System.Drawing.Size(325, 124);
            this.memoRem.TabIndex = 6;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSave,
            this.barDel,
            this.barRef});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barRef, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barSave
            // 
            this.barSave.Caption = "บันทึก";
            this.barSave.Id = 0;
            this.barSave.ImageOptions.ImageUri.Uri = "Save";
            this.barSave.Name = "barSave";
            this.barSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSave_ItemClick);
            // 
            // barDel
            // 
            this.barDel.Caption = "ลบ";
            this.barDel.Id = 1;
            this.barDel.ImageOptions.ImageUri.Uri = "Delete";
            this.barDel.Name = "barDel";
            this.barDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDel_ItemClick);
            // 
            // barRef
            // 
            this.barRef.Caption = "เริ่มใหม่";
            this.barRef.Id = 2;
            this.barRef.ImageOptions.ImageUri.Uri = "Refresh";
            this.barRef.Name = "barRef";
            this.barRef.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barRef_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(915, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 690);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(915, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 651);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(915, 39);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 651);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(549, 39);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 17);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "หมายเหตุ";
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(151, 68);
            this.txtDept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(336, 22);
            this.txtDept.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(104, 71);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 17);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "แผนก";
            // 
            // btnOpenFactor
            // 
            this.btnOpenFactor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFactor.ImageOptions.Image")));
            this.btnOpenFactor.Location = new System.Drawing.Point(151, 196);
            this.btnOpenFactor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenFactor.Name = "btnOpenFactor";
            this.btnOpenFactor.Size = new System.Drawing.Size(336, 28);
            this.btnOpenFactor.TabIndex = 7;
            this.btnOpenFactor.Text = "ปัจจัยเสี่ยงและอุปกรณ์ป้องกัน";
            this.btnOpenFactor.Click += new System.EventHandler(this.btnOpenFactor_Click);
            // 
            // txtWorkType
            // 
            this.txtWorkType.Location = new System.Drawing.Point(151, 132);
            this.txtWorkType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWorkType.Name = "txtWorkType";
            this.txtWorkType.Size = new System.Drawing.Size(336, 22);
            this.txtWorkType.TabIndex = 3;
            // 
            // txtComType
            // 
            this.txtComType.Location = new System.Drawing.Point(151, 100);
            this.txtComType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComType.Name = "txtComType";
            this.txtComType.Size = new System.Drawing.Size(336, 22);
            this.txtComType.TabIndex = 2;
            // 
            // txtComName
            // 
            this.txtComName.Location = new System.Drawing.Point(151, 36);
            this.txtComName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComName.Name = "txtComName";
            this.txtComName.Size = new System.Drawing.Size(336, 22);
            this.txtComName.TabIndex = 0;
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(301, 167);
            this.labelControl17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(15, 17);
            this.labelControl17.TabIndex = 13;
            this.labelControl17.Text = "ถึง";
            // 
            // StopWorkDate
            // 
            this.StopWorkDate.EditValue = null;
            this.StopWorkDate.Location = new System.Drawing.Point(321, 164);
            this.StopWorkDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StopWorkDate.Name = "StopWorkDate";
            this.StopWorkDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StopWorkDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StopWorkDate.Size = new System.Drawing.Size(167, 22);
            this.StopWorkDate.TabIndex = 5;
            // 
            // StartWorkDate
            // 
            this.StartWorkDate.EditValue = null;
            this.StartWorkDate.Location = new System.Drawing.Point(151, 164);
            this.StartWorkDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartWorkDate.Name = "StartWorkDate";
            this.StartWorkDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartWorkDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartWorkDate.Size = new System.Drawing.Size(142, 22);
            this.StartWorkDate.TabIndex = 4;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(87, 167);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(54, 17);
            this.labelControl16.TabIndex = 12;
            this.labelControl16.Text = "ระยะเวลา";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(50, 135);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(95, 17);
            this.labelControl15.TabIndex = 11;
            this.labelControl15.Text = "ลักษณะงานที่ทำ";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(59, 103);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(82, 17);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "ประเภทกิจการ";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 39);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(133, 17);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "ชื่อสถานประกอบกิจการ";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.gridExp);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(2, 2);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(911, 407);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "รายการประวัติการทำงาน";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 39);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(915, 240);
            this.panelControl1.TabIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 279);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(915, 411);
            this.panelControl2.TabIndex = 4;
            // 
            // EmployeeHisWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 690);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeeHisWorkForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeHisWorkForm";
            this.Load += new System.EventHandler(this.EmployeeHisWorkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVHtwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyWorkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoRem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopWorkDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopWorkDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartWorkDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartWorkDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txtWorkType;
        private DevExpress.XtraEditors.TextEdit txtComType;
        private DevExpress.XtraEditors.TextEdit txtComName;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.DateEdit StopWorkDate;
        private DevExpress.XtraEditors.DateEdit StartWorkDate;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl gridExp;
        private System.Windows.Forms.BindingSource historyWorkBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVExp;
        private DevExpress.XtraGrid.Columns.GridColumn colHtw_CompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colHtw_CompanyDept;
        private DevExpress.XtraGrid.Columns.GridColumn colHtw_Category;
        private DevExpress.XtraGrid.Columns.GridColumn colHtw_JobDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colHtw_StartDateForWork;
        private DevExpress.XtraGrid.Columns.GridColumn colHtw_EndDateForWork;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnOpenFactor;
        private DevExpress.XtraEditors.TextEdit txtDept;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barSave;
        private DevExpress.XtraBars.BarButtonItem barDel;
        private DevExpress.XtraBars.BarButtonItem barRef;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.MemoEdit memoRem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVHtwd;
        private DevExpress.XtraGrid.Columns.GridColumn colHtwd_Factor;
        private DevExpress.XtraGrid.Columns.GridColumn colHtwd_Device;
        private DevExpress.XtraGrid.Columns.GridColumn colHtwd_Rem;
        private DevExpress.XtraGrid.Columns.GridColumn colHtwd_Del;
    }
}