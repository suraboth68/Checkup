namespace CDMS
{
    partial class CDMSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDMSForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lbVersion = new DevExpress.XtraBars.BarButtonItem();
            this.btnSetting = new DevExpress.XtraBars.BarButtonItem();
            this.btnSkin = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.btMenu = new DevExpress.XtraBars.BarButtonItem();
            this.lbSvDetail = new DevExpress.XtraBars.BarButtonItem();
            this.HomePage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemColorEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorEdit();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::CDMS.Setting.WaitForm1), true, true);
            this.navBarEmployee = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarFactory = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarBranch = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSection = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarDepartment = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockMenu = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.nativeMdiView1 = new DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView(this.components);
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockMenu.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nativeMdiView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.lbVersion,
            this.btnSetting,
            this.btnSkin,
            this.ribbonGalleryBarItem1,
            this.btMenu,
            this.lbSvDetail,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HomePage,
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemColorEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(890, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // lbVersion
            // 
            this.lbVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lbVersion.Caption = "เวอร์ชั่น 1.0.0.0";
            this.lbVersion.Id = 1;
            this.lbVersion.Name = "lbVersion";
            // 
            // btnSetting
            // 
            this.btnSetting.Caption = "ตั้งค่า";
            this.btnSetting.Id = 3;
            this.btnSetting.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.ImageOptions.Image")));
            this.btnSetting.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.ImageOptions.LargeImage")));
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSetting_ItemClick);
            // 
            // btnSkin
            // 
            this.btnSkin.Caption = "รูปแบบ";
            this.btnSkin.Id = 4;
            this.btnSkin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSkin.ImageOptions.Image")));
            this.btnSkin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSkin.ImageOptions.LargeImage")));
            this.btnSkin.Name = "btnSkin";
            this.btnSkin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSkin_ItemClick);
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "InplaceGallery1";
            this.ribbonGalleryBarItem1.Id = 5;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // btMenu
            // 
            this.btMenu.Caption = "เมนู";
            this.btMenu.Id = 7;
            this.btMenu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btMenu.ImageOptions.Image")));
            this.btMenu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btMenu.ImageOptions.LargeImage")));
            this.btMenu.Name = "btMenu";
            this.btMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btMenu_ItemClick);
            // 
            // lbSvDetail
            // 
            this.lbSvDetail.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lbSvDetail.Caption = "Server Detail";
            this.lbSvDetail.Id = 8;
            this.lbSvDetail.Name = "lbSvDetail";
            // 
            // HomePage
            // 
            this.HomePage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.HomePage.MergeOrder = 0;
            this.HomePage.Name = "HomePage";
            this.HomePage.Text = "ไฟล์";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btMenu);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "จัดการ";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ตั้งค่า";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSetting);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSkin);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // repositoryItemColorEdit1
            // 
            this.repositoryItemColorEdit1.AutoHeight = false;
            this.repositoryItemColorEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorEdit1.Name = "repositoryItemColorEdit1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.lbVersion);
            this.ribbonStatusBar1.ItemLinks.Add(this.lbSvDetail, true);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 464);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(890, 31);
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Name = "galleryDropDown1";
            this.galleryDropDown1.Ribbon = this.ribbonControl1;
            this.galleryDropDown1.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.galleryDropDown1_GalleryItemClick);
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // navBarEmployee
            // 
            this.navBarEmployee.Caption = "ข้อมูลพนักงาน";
            this.navBarEmployee.Name = "navBarEmployee";
            this.navBarEmployee.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarEmployee_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "ฐานข้อมูลหลัก";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarEmployee),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarFactory),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarBranch),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSection),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDepartment)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarFactory
            // 
            this.navBarFactory.Caption = "ข้อมูลกิจการ";
            this.navBarFactory.Name = "navBarFactory";
            this.navBarFactory.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarFactory_LinkClicked);
            // 
            // navBarBranch
            // 
            this.navBarBranch.Caption = "ข้อมูลสาขา";
            this.navBarBranch.Name = "navBarBranch";
            // 
            // navBarSection
            // 
            this.navBarSection.Caption = "ข้อมูลหน่วยงาน";
            this.navBarSection.Name = "navBarSection";
            // 
            // navBarDepartment
            // 
            this.navBarDepartment.Caption = "ข้อมูลแผนก";
            this.navBarDepartment.Name = "navBarDepartment";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarEmployee,
            this.navBarFactory,
            this.navBarBranch,
            this.navBarSection,
            this.navBarDepartment});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 191;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(191, 294);
            this.navBarControl1.TabIndex = 2;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockMenu});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // dockMenu
            // 
            this.dockMenu.Controls.Add(this.dockPanel1_Container);
            this.dockMenu.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockMenu.ID = new System.Guid("57f08cdf-5f60-4435-bada-e3cf9ebcd05a");
            this.dockMenu.Location = new System.Drawing.Point(0, 143);
            this.dockMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockMenu.Name = "dockMenu";
            this.dockMenu.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockMenu.Size = new System.Drawing.Size(200, 321);
            this.dockMenu.Text = "เมนู";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(191, 294);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.nativeMdiView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.nativeMdiView1});
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.MergeOrder = 9;
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ระบบ";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "ปิดโปรแกรม";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // CDMSForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 495);
            this.Controls.Add(this.dockMenu);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "CDMSForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Checkup Data Management System (CDMS) - โปรแกรมตรวจเช็คสุขภาพ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CDMSForm_Load);
            this.Shown += new System.EventHandler(this.CDMSForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockMenu.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nativeMdiView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage HomePage;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem lbVersion;
        private DevExpress.XtraBars.BarButtonItem btnSetting;
        private DevExpress.XtraBars.BarButtonItem btnSkin;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarEmployee;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorEdit repositoryItemColorEdit1;
        private DevExpress.XtraNavBar.NavBarItem navBarFactory;
        private DevExpress.XtraNavBar.NavBarItem navBarBranch;
        private DevExpress.XtraNavBar.NavBarItem navBarSection;
        private DevExpress.XtraNavBar.NavBarItem navBarDepartment;
        private DevExpress.XtraBars.BarButtonItem btMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockMenu;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView nativeMdiView1;
        private DevExpress.XtraBars.BarButtonItem lbSvDetail;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}

