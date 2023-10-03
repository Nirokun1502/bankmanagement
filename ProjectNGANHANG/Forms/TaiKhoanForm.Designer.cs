namespace ProjectNGANHANG.Forms
{
    partial class TaiKhoanForm
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
            System.Windows.Forms.Label lbSTK;
            System.Windows.Forms.Label lbCMND;
            System.Windows.Forms.Label lbSoDu;
            System.Windows.Forms.Label lbMACN;
            System.Windows.Forms.Label lbNgayMoTK;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS2 = new ProjectNGANHANG.DS2();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.TKTableAdapter = new ProjectNGANHANG.DS2TableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new ProjectNGANHANG.DS2TableAdapters.TableAdapterManager();
            this.gcTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txSTK = new DevExpress.XtraEditors.TextEdit();
            this.txCMND = new DevExpress.XtraEditors.TextEdit();
            this.txSoDu = new DevExpress.XtraEditors.SpinEdit();
            this.dtNgayMoTK = new DevExpress.XtraEditors.DateEdit();
            this.btnCMND = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txMACN = new DevExpress.XtraEditors.TextEdit();
            this.bdsGOIRUT = new System.Windows.Forms.BindingSource(this.components);
            this.GOIRUTTableAdapter = new ProjectNGANHANG.DS2TableAdapters.GD_GOIRUTTableAdapter();
            this.bdsCHUYENTIEN = new System.Windows.Forms.BindingSource(this.components);
            this.CHUYENTIENTableAdapter = new ProjectNGANHANG.DS2TableAdapters.GD_CHUYENTIENTableAdapter();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            lbSTK = new System.Windows.Forms.Label();
            lbCMND = new System.Windows.Forms.Label();
            lbSoDu = new System.Windows.Forms.Label();
            lbMACN = new System.Windows.Forms.Label();
            lbNgayMoTK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSoDu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayMoTK.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayMoTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txMACN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGOIRUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCHUYENTIEN)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSTK
            // 
            lbSTK.AutoSize = true;
            lbSTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbSTK.Location = new System.Drawing.Point(12, 74);
            lbSTK.Name = "lbSTK";
            lbSTK.Size = new System.Drawing.Size(107, 22);
            lbSTK.TabIndex = 0;
            lbSTK.Text = "Số tài khoản";
            // 
            // lbCMND
            // 
            lbCMND.AutoSize = true;
            lbCMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbCMND.Location = new System.Drawing.Point(375, 74);
            lbCMND.Name = "lbCMND";
            lbCMND.Size = new System.Drawing.Size(74, 22);
            lbCMND.TabIndex = 2;
            lbCMND.Text = "CMND:";
            // 
            // lbSoDu
            // 
            lbSoDu.AutoSize = true;
            lbSoDu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbSoDu.Location = new System.Drawing.Point(375, 155);
            lbSoDu.Name = "lbSoDu";
            lbSoDu.Size = new System.Drawing.Size(57, 22);
            lbSoDu.TabIndex = 4;
            lbSoDu.Text = "Số dư";
            // 
            // lbMACN
            // 
            lbMACN.AutoSize = true;
            lbMACN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbMACN.Location = new System.Drawing.Point(783, 74);
            lbMACN.Name = "lbMACN";
            lbMACN.Size = new System.Drawing.Size(88, 22);
            lbMACN.TabIndex = 6;
            lbMACN.Text = "Chi nhánh";
            // 
            // lbNgayMoTK
            // 
            lbNgayMoTK.AutoSize = true;
            lbNgayMoTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbNgayMoTK.Location = new System.Drawing.Point(12, 155);
            lbNgayMoTK.Name = "lbNgayMoTK";
            lbNgayMoTK.Size = new System.Drawing.Size(81, 22);
            lbNgayMoTK.TabIndex = 8;
            lbNgayMoTK.Text = "Ngày mở";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnUndo,
            this.btnReload,
            this.barButtonItem7,
            this.btnPrint,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_add_user_male_30;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Hiệu chỉnh";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_note_30;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_save_30;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 4;
            this.btnXoa.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_x_30;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Id = 5;
            this.btnUndo.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_undo_30;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 6;
            this.btnReload.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_reload_30__1_;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In danh sách nhân viên";
            this.btnPrint.Id = 8;
            this.btnPrint.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_print_30;
            this.btnPrint.Name = "btnPrint";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 9;
            this.btnThoat.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_exit_30;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1158, 68);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 607);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1158, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 68);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 539);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1158, 68);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 539);
            // 
            // DS2
            // 
            this.DS2.DataSetName = "DS2";
            this.DS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "TaiKhoan";
            this.bdsTK.DataSource = this.DS2;
            // 
            // TKTableAdapter
            // 
            this.TKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.TKTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjectNGANHANG.DS2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcTaiKhoan
            // 
            this.gcTaiKhoan.DataSource = this.bdsTK;
            this.gcTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTaiKhoan.Location = new System.Drawing.Point(0, 68);
            this.gcTaiKhoan.MainView = this.gridView1;
            this.gcTaiKhoan.MenuManager = this.barManager1;
            this.gcTaiKhoan.Name = "gcTaiKhoan";
            this.gcTaiKhoan.Size = new System.Drawing.Size(1158, 220);
            this.gcTaiKhoan.TabIndex = 9;
            this.gcTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gridView1.GridControl = this.gcTaiKhoan;
            this.gridView1.Name = "gridView1";
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 94;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 94;
            // 
            // colSODU
            // 
            this.colSODU.DisplayFormat.FormatString = "n0";
            this.colSODU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 25;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 94;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYMOTK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.GroupFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYMOTK.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYMOTK.MinWidth = 25;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 94;
            // 
            // txSTK
            // 
            this.txSTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "SOTK", true));
            this.txSTK.Location = new System.Drawing.Point(125, 71);
            this.txSTK.MenuManager = this.barManager1;
            this.txSTK.Name = "txSTK";
            this.txSTK.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSTK.Properties.Appearance.Options.UseFont = true;
            this.txSTK.Size = new System.Drawing.Size(195, 28);
            this.txSTK.TabIndex = 1;
            // 
            // txCMND
            // 
            this.txCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "CMND", true));
            this.txCMND.Location = new System.Drawing.Point(455, 71);
            this.txCMND.MenuManager = this.barManager1;
            this.txCMND.Name = "txCMND";
            this.txCMND.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCMND.Properties.Appearance.Options.UseFont = true;
            this.txCMND.Properties.ReadOnly = true;
            this.txCMND.Size = new System.Drawing.Size(205, 28);
            this.txCMND.TabIndex = 3;
            // 
            // txSoDu
            // 
            this.txSoDu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "SODU", true));
            this.txSoDu.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txSoDu.Location = new System.Drawing.Point(455, 152);
            this.txSoDu.MenuManager = this.barManager1;
            this.txSoDu.Name = "txSoDu";
            this.txSoDu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSoDu.Properties.Appearance.Options.UseFont = true;
            this.txSoDu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txSoDu.Properties.DisplayFormat.FormatString = "n0";
            this.txSoDu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txSoDu.Properties.EditFormat.FormatString = "n0";
            this.txSoDu.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txSoDu.Size = new System.Drawing.Size(205, 28);
            this.txSoDu.TabIndex = 5;
            // 
            // dtNgayMoTK
            // 
            this.dtNgayMoTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "NGAYMOTK", true));
            this.dtNgayMoTK.EditValue = null;
            this.dtNgayMoTK.Location = new System.Drawing.Point(125, 152);
            this.dtNgayMoTK.MenuManager = this.barManager1;
            this.dtNgayMoTK.Name = "dtNgayMoTK";
            this.dtNgayMoTK.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayMoTK.Properties.Appearance.Options.UseFont = true;
            this.dtNgayMoTK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayMoTK.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayMoTK.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtNgayMoTK.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayMoTK.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtNgayMoTK.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtNgayMoTK.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dtNgayMoTK.Size = new System.Drawing.Size(195, 28);
            this.dtNgayMoTK.TabIndex = 9;
            // 
            // btnCMND
            // 
            this.btnCMND.Location = new System.Drawing.Point(666, 70);
            this.btnCMND.Name = "btnCMND";
            this.btnCMND.Size = new System.Drawing.Size(29, 29);
            this.btnCMND.TabIndex = 10;
            this.btnCMND.Text = "...";
            this.btnCMND.Click += new System.EventHandler(this.btnCMND_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnCMND);
            this.panelControl2.Controls.Add(lbNgayMoTK);
            this.panelControl2.Controls.Add(this.dtNgayMoTK);
            this.panelControl2.Controls.Add(lbMACN);
            this.panelControl2.Controls.Add(this.txMACN);
            this.panelControl2.Controls.Add(lbSoDu);
            this.panelControl2.Controls.Add(this.txSoDu);
            this.panelControl2.Controls.Add(lbCMND);
            this.panelControl2.Controls.Add(this.txCMND);
            this.panelControl2.Controls.Add(lbSTK);
            this.panelControl2.Controls.Add(this.txSTK);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(0, 288);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1158, 319);
            this.panelControl2.TabIndex = 14;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // txMACN
            // 
            this.txMACN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "MACN", true));
            this.txMACN.Location = new System.Drawing.Point(877, 71);
            this.txMACN.MenuManager = this.barManager1;
            this.txMACN.Name = "txMACN";
            this.txMACN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMACN.Properties.Appearance.Options.UseFont = true;
            this.txMACN.Properties.ReadOnly = true;
            this.txMACN.Size = new System.Drawing.Size(173, 28);
            this.txMACN.TabIndex = 7;
            // 
            // bdsGOIRUT
            // 
            this.bdsGOIRUT.DataMember = "GD_GOIRUT";
            this.bdsGOIRUT.DataSource = this.DS2;
            // 
            // GOIRUTTableAdapter
            // 
            this.GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCHUYENTIEN
            // 
            this.bdsCHUYENTIEN.DataMember = "GD_CHUYENTIEN";
            this.bdsCHUYENTIEN.DataSource = this.DS2;
            // 
            // CHUYENTIENTableAdapter
            // 
            this.CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.Enabled = false;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(1148, 607);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(10, 30);
            this.cbChiNhanh.TabIndex = 1;
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanh_SelectedIndexChanged);
            // 
            // TaiKhoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 627);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcTaiKhoan);
            this.Controls.Add(this.cbChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaiKhoanForm";
            this.Text = "TaiKhoanForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TaiKhoanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSoDu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayMoTK.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayMoTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txMACN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGOIRUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCHUYENTIEN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsTK;
        private DS2 DS2;
        private DS2TableAdapters.TaiKhoanTableAdapter TKTableAdapter;
        private DS2TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCMND;
        private DevExpress.XtraEditors.DateEdit dtNgayMoTK;
        private DevExpress.XtraEditors.SpinEdit txSoDu;
        public DevExpress.XtraEditors.TextEdit txCMND;
        private DevExpress.XtraEditors.TextEdit txSTK;
        private System.Windows.Forms.BindingSource bdsGOIRUT;
        private DS2TableAdapters.GD_GOIRUTTableAdapter GOIRUTTableAdapter;
        private System.Windows.Forms.BindingSource bdsCHUYENTIEN;
        private DS2TableAdapters.GD_CHUYENTIENTableAdapter CHUYENTIENTableAdapter;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private DevExpress.XtraEditors.TextEdit txMACN;
    }
}