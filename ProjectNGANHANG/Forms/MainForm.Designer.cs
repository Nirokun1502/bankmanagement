namespace ProjectNGANHANG
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoLoginNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnGoiRut = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenTien = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaoKe1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLKKH1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLKTK1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoLoginKH = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaoKe = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.NghiepVuPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.GiaoDichPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ThongKePage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(47, 41, 47, 41);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangNhap,
            this.btnTaoLoginNV,
            this.btnNhanVien,
            this.btnKhachHang,
            this.btnTaiKhoan,
            this.btnGoiRut,
            this.btnChuyenTien,
            this.btnSaoKe1,
            this.btnLKKH1,
            this.btnLKTK1,
            this.btnTaoLoginKH,
            this.btnSaoKe,
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnDangXuat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ribbonControl1.MaxItemId = 22;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 519;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.NghiepVuPage,
            this.GiaoDichPage,
            this.ThongKePage,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(1540, 183);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_login_40;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnTaoLoginNV
            // 
            this.btnTaoLoginNV.Caption = "Tạo Login Nhân Viên\r\n";
            this.btnTaoLoginNV.Enabled = false;
            this.btnTaoLoginNV.Id = 3;
            this.btnTaoLoginNV.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_employee_40;
            this.btnTaoLoginNV.Name = "btnTaoLoginNV";
            this.btnTaoLoginNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTaoLoginNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoLoginNV_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân Viên";
            this.btnNhanVien.Id = 4;
            this.btnNhanVien.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_employee_40;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Khách Hàng\r\n";
            this.btnKhachHang.Id = 8;
            this.btnKhachHang.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_person_male_skin_type_3_40__2_;
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachHang_ItemClick);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Caption = "Tài Khoản";
            this.btnTaiKhoan.Id = 9;
            this.btnTaiKhoan.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_bank_account_40;
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaiKhoan_ItemClick);
            // 
            // btnGoiRut
            // 
            this.btnGoiRut.Caption = "Gởi tiền/ Rút tiền";
            this.btnGoiRut.Id = 10;
            this.btnGoiRut.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_currency_40;
            this.btnGoiRut.Name = "btnGoiRut";
            this.btnGoiRut.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnGoiRut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGoiRut_ItemClick);
            // 
            // btnChuyenTien
            // 
            this.btnChuyenTien.Caption = "Chuyển tiền\r\n";
            this.btnChuyenTien.Id = 11;
            this.btnChuyenTien.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_payment_64__1_;
            this.btnChuyenTien.Name = "btnChuyenTien";
            this.btnChuyenTien.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnChuyenTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnSaoKe1
            // 
            this.btnSaoKe1.Caption = "Sao kê GD";
            this.btnSaoKe1.Id = 12;
            this.btnSaoKe1.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_add_50;
            this.btnSaoKe1.Name = "btnSaoKe1";
            this.btnSaoKe1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSaoKe1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaoKe_ItemClick);
            // 
            // btnLKKH1
            // 
            this.btnLKKH1.Caption = "Liệt kê khách hàng\r\n";
            this.btnLKKH1.Id = 15;
            this.btnLKKH1.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_bank_account_40;
            this.btnLKKH1.Name = "btnLKKH1";
            this.btnLKKH1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLKKH1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLKKH_ItemClick);
            // 
            // btnLKTK1
            // 
            this.btnLKTK1.Caption = "Liệt kê tài khoản\r\n";
            this.btnLKTK1.Id = 16;
            this.btnLKTK1.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_male_female_user_group_40;
            this.btnLKTK1.Name = "btnLKTK1";
            this.btnLKTK1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLKTK1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLKTK_ItemClick);
            // 
            // btnTaoLoginKH
            // 
            this.btnTaoLoginKH.Caption = "Tạo Login Khách Hàng\r\n";
            this.btnTaoLoginKH.Enabled = false;
            this.btnTaoLoginKH.Id = 17;
            this.btnTaoLoginKH.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_male_female_user_group_40;
            this.btnTaoLoginKH.Name = "btnTaoLoginKH";
            this.btnTaoLoginKH.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTaoLoginKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoLoginKH_ItemClick);
            // 
            // btnSaoKe
            // 
            this.btnSaoKe.Caption = "Sao kê giao dịch\r\n\r\n\r\n";
            this.btnSaoKe.Id = 18;
            this.btnSaoKe.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_account_statement_50;
            this.btnSaoKe.Name = "btnSaoKe";
            this.btnSaoKe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSaoKe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaoKe_ItemClick_1);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Liệt kê khách hàng\r\n";
            this.barButtonItem1.Id = 19;
            this.barButtonItem1.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_male_female_user_group_50;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Liệt kê tài khoản\r\n";
            this.barButtonItem2.Id = 20;
            this.barButtonItem2.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_bank_account_40;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick_1);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Enabled = false;
            this.btnDangXuat.Id = 21;
            this.btnDangXuat.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_shutdown_40;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.ImageOptions.Image")));
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaoLoginNV, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaoLoginKH, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // NghiepVuPage
            // 
            this.NghiepVuPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.NghiepVuPage.Name = "NghiepVuPage";
            this.NghiepVuPage.Text = "Nghiệp vụ";
            this.NghiepVuPage.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnKhachHang, true, "", "", false, false);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTaiKhoan, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // GiaoDichPage
            // 
            this.GiaoDichPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.GiaoDichPage.Name = "GiaoDichPage";
            this.GiaoDichPage.Text = "Giao dịch";
            this.GiaoDichPage.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnGoiRut);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnChuyenTien, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ThongKePage
            // 
            this.ThongKePage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ThongKePage.Name = "ThongKePage";
            this.ThongKePage.Text = "Xtra Thống kê";
            this.ThongKePage.Visible = false;
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnSaoKe);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem1, true);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem2, true);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Thống kê";
            this.ribbonPage4.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSaoKe1);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLKKH1, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLKTK1, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 848);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 22, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1540, 28);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(68, 22);
            this.MANV.Text = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(76, 22);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(69, 22);
            this.NHOM.Text = "NHOM";
            // 
            // MainForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 876);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MANV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnGoiRut;
        private DevExpress.XtraBars.BarButtonItem btnChuyenTien;
        private DevExpress.XtraBars.BarButtonItem btnSaoKe1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnLKKH1;
        private DevExpress.XtraBars.BarButtonItem btnLKTK1;
        private DevExpress.XtraBars.BarButtonItem btnSaoKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        public DevExpress.XtraBars.BarButtonItem btnDangNhap;
        public DevExpress.XtraBars.Ribbon.RibbonPage NghiepVuPage;
        public DevExpress.XtraBars.BarButtonItem btnTaoLoginNV;
        public DevExpress.XtraBars.Ribbon.RibbonPage GiaoDichPage;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        public DevExpress.XtraBars.BarButtonItem btnTaoLoginKH;
        public DevExpress.XtraBars.Ribbon.RibbonPage ThongKePage;
        public DevExpress.XtraBars.BarButtonItem btnDangXuat;
    }
}

