﻿namespace ProjectNGANHANG.Forms
{
    partial class NhanVienForm
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.Windows.Forms.Label pHAILabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenCN = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
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
            this.DS = new ProjectNGANHANG.DS();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.NHANVIENTableAdapter = new ProjectNGANHANG.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new ProjectNGANHANG.DSTableAdapters.TableAdapterManager();
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cbPhai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.trangThaiXoaCheckBox = new System.Windows.Forms.CheckBox();
            this.txSDT = new DevExpress.XtraEditors.TextEdit();
            this.txMACN = new DevExpress.XtraEditors.TextEdit();
            this.txDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txCMND = new DevExpress.XtraEditors.TextEdit();
            this.txTen = new DevExpress.XtraEditors.TextEdit();
            this.txHo = new DevExpress.XtraEditors.TextEdit();
            this.txMANV = new DevExpress.XtraEditors.TextEdit();
            this.bdsGOIRUT = new System.Windows.Forms.BindingSource(this.components);
            this.GOIRUTTableAdapter = new ProjectNGANHANG.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.bdsCHUYENTIEN = new System.Windows.Forms.BindingSource(this.components);
            this.CHUYENTIENTableAdapter = new ProjectNGANHANG.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPhai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMACN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGOIRUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCHUYENTIEN)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(26, 35);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(116, 22);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã nhân viên";
            mANVLabel.Click += new System.EventHandler(this.mANVLabel_Click);
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(356, 35);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(62, 22);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ tên";
            hOLabel.Click += new System.EventHandler(this.hOLabel_Click);
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(26, 103);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(74, 22);
            cMNDLabel.TabIndex = 6;
            cMNDLabel.Text = "CMND:";
            cMNDLabel.Click += new System.EventHandler(this.cMNDLabel_Click);
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(354, 104);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(68, 22);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "Địa chỉ";
            dIACHILabel.Click += new System.EventHandler(this.dIACHILabel_Click);
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(857, 35);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(88, 22);
            mACNLabel.TabIndex = 10;
            mACNLabel.Text = "Chi nhánh";
            mACNLabel.Click += new System.EventHandler(this.mACNLabel_Click);
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODTLabel.Location = new System.Drawing.Point(26, 174);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(114, 22);
            sODTLabel.TabIndex = 14;
            sODTLabel.Text = "Số điện thoại";
            sODTLabel.Click += new System.EventHandler(this.sODTLabel_Click);
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trangThaiXoaLabel.Location = new System.Drawing.Point(352, 174);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(122, 22);
            trangThaiXoaLabel.TabIndex = 16;
            trangThaiXoaLabel.Text = "Trạng thái xóa";
            trangThaiXoaLabel.Click += new System.EventHandler(this.trangThaiXoaLabel_Click);
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pHAILabel.Location = new System.Drawing.Point(857, 103);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(45, 22);
            pHAILabel.TabIndex = 17;
            pHAILabel.Text = "Phái";
            pHAILabel.Click += new System.EventHandler(this.pHAILabel_Click);
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
            this.btnPrint,
            this.btnThoat,
            this.btnChuyenCN});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChuyenCN),
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
            // btnChuyenCN
            // 
            this.btnChuyenCN.Caption = "Chuyển chi nhánh nhân viên";
            this.btnChuyenCN.Id = 10;
            this.btnChuyenCN.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_plus_30;
            this.btnChuyenCN.Name = "btnChuyenCN";
            this.btnChuyenCN.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnChuyenCN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenCN_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In danh sách nhân viên";
            this.btnPrint.Id = 8;
            this.btnPrint.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_print_30;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
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
            this.barDockControlTop.Click += new System.EventHandler(this.barDockControlTop_Click);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 607);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1171, 20);
            this.barDockControlBottom.Click += new System.EventHandler(this.barDockControlBottom_Click);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 68);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 539);
            this.barDockControlLeft.Click += new System.EventHandler(this.barDockControlLeft_Click);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1171, 68);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 539);
            this.barDockControlRight.Click += new System.EventHandler(this.barDockControlRight_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 68);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1171, 52);
            this.panelControl1.TabIndex = 4;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NhanVien";
            this.bdsNV.DataSource = this.DS;
            this.bdsNV.CurrentChanged += new System.EventHandler(this.bdsNV_CurrentChanged);
            // 
            // NHANVIENTableAdapter
            // 
            this.NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.NHANVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjectNGANHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcNhanVien
            // 
            this.gcNhanVien.DataSource = this.bdsNV;
            this.gcNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNhanVien.Location = new System.Drawing.Point(0, 120);
            this.gcNhanVien.MainView = this.gridView1;
            this.gcNhanVien.MenuManager = this.barManager1;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Size = new System.Drawing.Size(1171, 214);
            this.gcNhanVien.TabIndex = 6;
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcNhanVien.Click += new System.EventHandler(this.gcNhanVien_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colCMND,
            this.colDIACHI,
            this.colPHAI,
            this.colSODT,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.GridControl = this.gcNhanVien;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 3;
            this.colCMND.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 5;
            this.colPHAI.Width = 94;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 25;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 94;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 25;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 8;
            this.colTrangThaiXoa.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(pHAILabel);
            this.panelControl2.Controls.Add(this.cbPhai);
            this.panelControl2.Controls.Add(trangThaiXoaLabel);
            this.panelControl2.Controls.Add(this.trangThaiXoaCheckBox);
            this.panelControl2.Controls.Add(sODTLabel);
            this.panelControl2.Controls.Add(this.txSDT);
            this.panelControl2.Controls.Add(mACNLabel);
            this.panelControl2.Controls.Add(this.txMACN);
            this.panelControl2.Controls.Add(dIACHILabel);
            this.panelControl2.Controls.Add(this.txDiaChi);
            this.panelControl2.Controls.Add(cMNDLabel);
            this.panelControl2.Controls.Add(this.txCMND);
            this.panelControl2.Controls.Add(this.txTen);
            this.panelControl2.Controls.Add(hOLabel);
            this.panelControl2.Controls.Add(this.txHo);
            this.panelControl2.Controls.Add(mANVLabel);
            this.panelControl2.Controls.Add(this.txMANV);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(0, 334);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1171, 273);
            this.panelControl2.TabIndex = 7;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // cbPhai
            // 
            this.cbPhai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "PHAI", true));
            this.cbPhai.Location = new System.Drawing.Point(951, 101);
            this.cbPhai.MenuManager = this.barManager1;
            this.cbPhai.Name = "cbPhai";
            this.cbPhai.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhai.Properties.Appearance.Options.UseFont = true;
            this.cbPhai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPhai.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbPhai.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbPhai.Size = new System.Drawing.Size(172, 28);
            this.cbPhai.TabIndex = 18;
            this.cbPhai.SelectedIndexChanged += new System.EventHandler(this.cbPhai_SelectedIndexChanged);
            // 
            // trangThaiXoaCheckBox
            // 
            this.trangThaiXoaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsNV, "TrangThaiXoa", true));
            this.trangThaiXoaCheckBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangThaiXoaCheckBox.Location = new System.Drawing.Point(480, 176);
            this.trangThaiXoaCheckBox.Name = "trangThaiXoaCheckBox";
            this.trangThaiXoaCheckBox.Size = new System.Drawing.Size(128, 23);
            this.trangThaiXoaCheckBox.TabIndex = 17;
            this.trangThaiXoaCheckBox.UseVisualStyleBackColor = true;
            this.trangThaiXoaCheckBox.CheckedChanged += new System.EventHandler(this.trangThaiXoaCheckBox_CheckedChanged);
            // 
            // txSDT
            // 
            this.txSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "SODT", true));
            this.txSDT.Location = new System.Drawing.Point(146, 171);
            this.txSDT.MenuManager = this.barManager1;
            this.txSDT.Name = "txSDT";
            this.txSDT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSDT.Properties.Appearance.Options.UseFont = true;
            this.txSDT.Size = new System.Drawing.Size(171, 28);
            this.txSDT.TabIndex = 15;
            this.txSDT.EditValueChanged += new System.EventHandler(this.txSDT_EditValueChanged);
            // 
            // txMACN
            // 
            this.txMACN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MACN", true));
            this.txMACN.Location = new System.Drawing.Point(951, 29);
            this.txMACN.MenuManager = this.barManager1;
            this.txMACN.Name = "txMACN";
            this.txMACN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMACN.Properties.Appearance.Options.UseFont = true;
            this.txMACN.Properties.ReadOnly = true;
            this.txMACN.Size = new System.Drawing.Size(172, 28);
            this.txMACN.TabIndex = 11;
            this.txMACN.EditValueChanged += new System.EventHandler(this.txMACN_EditValueChanged);
            // 
            // txDiaChi
            // 
            this.txDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "DIACHI", true));
            this.txDiaChi.Location = new System.Drawing.Point(424, 100);
            this.txDiaChi.MenuManager = this.barManager1;
            this.txDiaChi.Name = "txDiaChi";
            this.txDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txDiaChi.Size = new System.Drawing.Size(404, 28);
            this.txDiaChi.TabIndex = 9;
            this.txDiaChi.EditValueChanged += new System.EventHandler(this.txDiaChi_EditValueChanged);
            // 
            // txCMND
            // 
            this.txCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "CMND", true));
            this.txCMND.Location = new System.Drawing.Point(148, 100);
            this.txCMND.MenuManager = this.barManager1;
            this.txCMND.Name = "txCMND";
            this.txCMND.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCMND.Properties.Appearance.Options.UseFont = true;
            this.txCMND.Size = new System.Drawing.Size(170, 28);
            this.txCMND.TabIndex = 7;
            this.txCMND.EditValueChanged += new System.EventHandler(this.txCMND_EditValueChanged);
            // 
            // txTen
            // 
            this.txTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TEN", true));
            this.txTen.Location = new System.Drawing.Point(703, 29);
            this.txTen.MenuManager = this.barManager1;
            this.txTen.Name = "txTen";
            this.txTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTen.Properties.Appearance.Options.UseFont = true;
            this.txTen.Size = new System.Drawing.Size(124, 28);
            this.txTen.TabIndex = 5;
            this.txTen.EditValueChanged += new System.EventHandler(this.txTen_EditValueChanged);
            // 
            // txHo
            // 
            this.txHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "HO", true));
            this.txHo.Location = new System.Drawing.Point(424, 29);
            this.txHo.MenuManager = this.barManager1;
            this.txHo.Name = "txHo";
            this.txHo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txHo.Properties.Appearance.Options.UseFont = true;
            this.txHo.Size = new System.Drawing.Size(273, 28);
            this.txHo.TabIndex = 3;
            this.txHo.EditValueChanged += new System.EventHandler(this.txHo_EditValueChanged);
            // 
            // txMANV
            // 
            this.txMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MANV", true));
            this.txMANV.Location = new System.Drawing.Point(148, 29);
            this.txMANV.MenuManager = this.barManager1;
            this.txMANV.Name = "txMANV";
            this.txMANV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMANV.Properties.Appearance.Options.UseFont = true;
            this.txMANV.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txMANV.Size = new System.Drawing.Size(170, 28);
            this.txMANV.TabIndex = 1;
            this.txMANV.EditValueChanged += new System.EventHandler(this.txMANV_EditValueChanged);
            // 
            // bdsGOIRUT
            // 
            this.bdsGOIRUT.DataMember = "GD_GOIRUT";
            this.bdsGOIRUT.DataSource = this.DS;
            // 
            // GOIRUTTableAdapter
            // 
            this.GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCHUYENTIEN
            // 
            this.bdsCHUYENTIEN.DataMember = "GD_CHUYENTIEN";
            this.bdsCHUYENTIEN.DataSource = this.DS;
            // 
            // CHUYENTIENTableAdapter
            // 
            this.CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // NhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 627);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcNhanVien);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhanVienForm";
            this.Text = "NhanVienForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhanVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPhai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMACN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGOIRUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCHUYENTIEN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsNV;
        private DS DS;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.NhanVienTableAdapter NHANVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txSDT;
        private DevExpress.XtraEditors.TextEdit txMACN;
        private DevExpress.XtraEditors.TextEdit txDiaChi;
        private DevExpress.XtraEditors.TextEdit txCMND;
        private DevExpress.XtraEditors.TextEdit txTen;
        private DevExpress.XtraEditors.TextEdit txHo;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private System.Windows.Forms.CheckBox trangThaiXoaCheckBox;
        private DevExpress.XtraEditors.ComboBoxEdit cbPhai;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsGOIRUT;
        private DSTableAdapters.GD_GOIRUTTableAdapter GOIRUTTableAdapter;
        private System.Windows.Forms.BindingSource bdsCHUYENTIEN;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter CHUYENTIENTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnChuyenCN;
        public DevExpress.XtraEditors.TextEdit txMANV;
    }
}