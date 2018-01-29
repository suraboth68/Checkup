namespace CDMS.Process.Management
{
    partial class EmployeeHisWorkDetailForm
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barSave = new DevExpress.XtraBars.BarButtonItem();
            this.barDel = new DevExpress.XtraBars.BarButtonItem();
            this.barRef = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbName = new DevExpress.XtraEditors.LabelControl();
            this.txtRem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtFactor = new DevExpress.XtraEditors.TextEdit();
            this.txtDevice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridHistD = new DevExpress.XtraGrid.GridControl();
            this.historyWorkDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridVHistD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHtwd_Factor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHtwd_Device = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHtwd_Rem = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDevice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyWorkDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVHistD)).BeginInit();
            this.SuspendLayout();
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
            this.barDockControlTop.Size = new System.Drawing.Size(584, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 461);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(584, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 430);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(584, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 430);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbName);
            this.groupControl1.Controls.Add(this.txtRem);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtFactor);
            this.groupControl1.Controls.Add(this.txtDevice);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 31);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(584, 157);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "ข้อมูล";
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(176, 35);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "lbName";
            // 
            // txtRem
            // 
            this.txtRem.Location = new System.Drawing.Point(176, 125);
            this.txtRem.MenuManager = this.barManager1;
            this.txtRem.Name = "txtRem";
            this.txtRem.Size = new System.Drawing.Size(352, 20);
            this.txtRem.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(118, 128);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "หมายเหตุ";
            // 
            // txtFactor
            // 
            this.txtFactor.Location = new System.Drawing.Point(176, 63);
            this.txtFactor.MenuManager = this.barManager1;
            this.txtFactor.Name = "txtFactor";
            this.txtFactor.Size = new System.Drawing.Size(352, 20);
            this.txtFactor.TabIndex = 0;
            // 
            // txtDevice
            // 
            this.txtDevice.Location = new System.Drawing.Point(176, 94);
            this.txtDevice.MenuManager = this.barManager1;
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(352, 20);
            this.txtDevice.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(56, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(105, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "อุปกรณ์ป้องกันอันตราย";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(67, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "ปัจจัยเสี่ยงต่อสุขภาพ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(54, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "ชื่อสถานประกอบกิจการ";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridHistD);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 188);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(584, 273);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "รายละเอียด";
            // 
            // gridHistD
            // 
            this.gridHistD.DataSource = this.historyWorkDetailBindingSource;
            this.gridHistD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHistD.Location = new System.Drawing.Point(2, 20);
            this.gridHistD.MainView = this.gridVHistD;
            this.gridHistD.MenuManager = this.barManager1;
            this.gridHistD.Name = "gridHistD";
            this.gridHistD.Size = new System.Drawing.Size(580, 251);
            this.gridHistD.TabIndex = 0;
            this.gridHistD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVHistD});
            // 
            // historyWorkDetailBindingSource
            // 
            this.historyWorkDetailBindingSource.DataSource = typeof(CDMS.Class.Entity.HistoryWork_Detail);
            // 
            // gridVHistD
            // 
            this.gridVHistD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHtwd_Factor,
            this.colHtwd_Device,
            this.colHtwd_Rem});
            this.gridVHistD.GridControl = this.gridHistD;
            this.gridVHistD.Name = "gridVHistD";
            this.gridVHistD.OptionsBehavior.Editable = false;
            this.gridVHistD.OptionsBehavior.ReadOnly = true;
            this.gridVHistD.OptionsView.ShowGroupPanel = false;
            this.gridVHistD.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridVHistD_RowCellClick);
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
            // EmployeeHisWorkDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "EmployeeHisWorkDetailForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeHisWorkDetailForm";
            this.Load += new System.EventHandler(this.EmployeeHisWorkDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDevice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHistD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyWorkDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVHistD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barSave;
        private DevExpress.XtraBars.BarButtonItem barDel;
        private DevExpress.XtraBars.BarButtonItem barRef;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridHistD;
        private System.Windows.Forms.BindingSource historyWorkDetailBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVHistD;
        private DevExpress.XtraGrid.Columns.GridColumn colHtwd_Factor;
        private DevExpress.XtraGrid.Columns.GridColumn colHtwd_Device;
        private DevExpress.XtraGrid.Columns.GridColumn colHtwd_Rem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtRem;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtFactor;
        private DevExpress.XtraEditors.TextEdit txtDevice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbName;
    }
}