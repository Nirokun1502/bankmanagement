﻿namespace ProjectNGANHANG.Forms
{
    partial class GoiRutForm
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
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS2 = new ProjectNGANHANG.DS2();
            this.bdsGOIRUT = new System.Windows.Forms.BindingSource(this.components);
            this.GOIRUTTableAdapter = new ProjectNGANHANG.DS2TableAdapters.GD_GOIRUTTableAdapter();
            this.tableAdapterManager = new ProjectNGANHANG.DS2TableAdapters.TableAdapterManager();
            this.gcGoiRut = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAIGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.numbtn = new DevExpress.XtraEditors.TextEdit();
            this.txSTK2 = new DevExpress.XtraEditors.TextEdit();
            this.btnSTK1 = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txLoaiGD = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txMANV = new DevExpress.XtraEditors.TextEdit();
            this.txSTK1 = new DevExpress.XtraEditors.TextEdit();
            this.txSoTien = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGOIRUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGoiRut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbtn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSTK2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txLoaiGD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSTK1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSoTien.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.btnGhi,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm giao dịch";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_plus_30;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_save_30;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
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
            // btnPrint
            // 
            this.btnPrint.Caption = "In danh sách nhân viên";
            this.btnPrint.Id = 8;
            this.btnPrint.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_print_30;
            this.btnPrint.Name = "btnPrint";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.Name = "barButtonItem7";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1171, 68);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 607);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1171, 20);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1171, 68);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 539);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 68);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1171, 52);
            this.panelControl1.TabIndex = 5;
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(120, 16);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(401, 24);
            this.cbChiNhanh.TabIndex = 1;
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // DS2
            // 
            this.DS2.DataSetName = "DS2";
            this.DS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = this.GOIRUTTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectNGANHANG.DS2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcGoiRut
            // 
            this.gcGoiRut.DataSource = this.bdsGOIRUT;
            this.gcGoiRut.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcGoiRut.Location = new System.Drawing.Point(0, 120);
            this.gcGoiRut.MainView = this.gridView1;
            this.gcGoiRut.MenuManager = this.barManager1;
            this.gcGoiRut.Name = "gcGoiRut";
            this.gcGoiRut.Size = new System.Drawing.Size(1171, 228);
            this.gcGoiRut.TabIndex = 6;
            this.gcGoiRut.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGD,
            this.colSOTK,
            this.colLOAIGD,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colMANV});
            this.gridView1.GridControl = this.gcGoiRut;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGD
            // 
            this.colMAGD.FieldName = "MAGD";
            this.colMAGD.MinWidth = 25;
            this.colMAGD.Name = "colMAGD";
            this.colMAGD.Visible = true;
            this.colMAGD.VisibleIndex = 0;
            this.colMAGD.Width = 94;
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 1;
            this.colSOTK.Width = 94;
            // 
            // colLOAIGD
            // 
            this.colLOAIGD.FieldName = "LOAIGD";
            this.colLOAIGD.MinWidth = 25;
            this.colLOAIGD.Name = "colLOAIGD";
            this.colLOAIGD.Visible = true;
            this.colLOAIGD.VisibleIndex = 2;
            this.colLOAIGD.Width = 94;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYGD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.GroupFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYGD.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYGD.MinWidth = 25;
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 3;
            this.colNGAYGD.Width = 94;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.DisplayFormat.FormatString = "n0";
            this.colSOTIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 25;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 4;
            this.colSOTIEN.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 5;
            this.colMANV.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.numbtn);
            this.panelControl2.Controls.Add(this.txSTK2);
            this.panelControl2.Controls.Add(this.btnSTK1);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.txLoaiGD);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.txMANV);
            this.panelControl2.Controls.Add(this.txSTK1);
            this.panelControl2.Controls.Add(this.txSoTien);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(0, 348);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1171, 259);
            this.panelControl2.TabIndex = 11;
            // 
            // numbtn
            // 
            this.numbtn.Location = new System.Drawing.Point(0, 19);
            this.numbtn.MenuManager = this.barManager1;
            this.numbtn.Name = "numbtn";
            this.numbtn.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbtn.Properties.Appearance.Options.UseFont = true;
            this.numbtn.Properties.ReadOnly = true;
            this.numbtn.Size = new System.Drawing.Size(10, 28);
            this.numbtn.TabIndex = 21;
            // 
            // txSTK2
            // 
            this.txSTK2.Location = new System.Drawing.Point(0, -3);
            this.txSTK2.MenuManager = this.barManager1;
            this.txSTK2.Name = "txSTK2";
            this.txSTK2.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSTK2.Properties.Appearance.Options.UseFont = true;
            this.txSTK2.Properties.ReadOnly = true;
            this.txSTK2.Size = new System.Drawing.Size(10, 28);
            this.txSTK2.TabIndex = 22;
            // 
            // btnSTK1
            // 
            this.btnSTK1.Location = new System.Drawing.Point(335, 57);
            this.btnSTK1.Name = "btnSTK1";
            this.btnSTK1.Size = new System.Drawing.Size(29, 29);
            this.btnSTK1.TabIndex = 20;
            this.btnSTK1.Text = "...";
            this.btnSTK1.Click += new System.EventHandler(this.btnSTK1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Loại giao dịch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(711, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số tiền";
            // 
            // txLoaiGD
            // 
            this.txLoaiGD.Location = new System.Drawing.Point(527, 58);
            this.txLoaiGD.MenuManager = this.barManager1;
            this.txLoaiGD.Name = "txLoaiGD";
            this.txLoaiGD.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLoaiGD.Properties.Appearance.Options.UseFont = true;
            this.txLoaiGD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txLoaiGD.Properties.Items.AddRange(new object[] {
            "Gởi tiền",
            "Rút tiền"});
            this.txLoaiGD.Size = new System.Drawing.Size(139, 28);
            this.txLoaiGD.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã nhân viên GD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Số tài khoản";
            // 
            // txMANV
            // 
            this.txMANV.Location = new System.Drawing.Point(184, 153);
            this.txMANV.MenuManager = this.barManager1;
            this.txMANV.Name = "txMANV";
            this.txMANV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMANV.Properties.Appearance.Options.UseFont = true;
            this.txMANV.Properties.ReadOnly = true;
            this.txMANV.Size = new System.Drawing.Size(145, 28);
            this.txMANV.TabIndex = 13;
            // 
            // txSTK1
            // 
            this.txSTK1.Location = new System.Drawing.Point(184, 58);
            this.txSTK1.MenuManager = this.barManager1;
            this.txSTK1.Name = "txSTK1";
            this.txSTK1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSTK1.Properties.Appearance.Options.UseFont = true;
            this.txSTK1.Properties.ReadOnly = true;
            this.txSTK1.Size = new System.Drawing.Size(145, 28);
            this.txSTK1.TabIndex = 1;
            // 
            // txSoTien
            // 
            this.txSoTien.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txSoTien.Location = new System.Drawing.Point(782, 58);
            this.txSoTien.MenuManager = this.barManager1;
            this.txSoTien.Name = "txSoTien";
            this.txSoTien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSoTien.Properties.Appearance.Options.UseFont = true;
            this.txSoTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txSoTien.Properties.DisplayFormat.FormatString = "n0";
            this.txSoTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txSoTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txSoTien.Size = new System.Drawing.Size(161, 28);
            this.txSoTien.TabIndex = 0;
            // 
            // GoiRutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 627);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcGoiRut);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GoiRutForm";
            this.Text = "GoiRutForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GoiRutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGOIRUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGoiRut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbtn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSTK2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txLoaiGD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSTK1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSoTien.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
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
        private System.Windows.Forms.BindingSource bdsGOIRUT;
        private DS2 DS2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.Label label1;
        private DS2TableAdapters.GD_GOIRUTTableAdapter GOIRUTTableAdapter;
        private DS2TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcGoiRut;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAIGD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txMANV;
        private DevExpress.XtraEditors.SimpleButton btnSTK1;
        public DevExpress.XtraEditors.TextEdit numbtn;
        public DevExpress.XtraEditors.TextEdit txSTK1;
        public DevExpress.XtraEditors.TextEdit txSTK2;
        private DevExpress.XtraEditors.SpinEdit txSoTien;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ComboBoxEdit txLoaiGD;
    }
}