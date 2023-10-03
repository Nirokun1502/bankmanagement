namespace ProjectNGANHANG.Forms
{
    partial class SaoKeGD_Frpt
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
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.cbSaoKeChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS1 = new ProjectNGANHANG.DS1();
            this.bdsHOTENKH = new System.Windows.Forms.BindingSource(this.components);
            this.HOTENKHTableAdapter = new ProjectNGANHANG.DS1TableAdapters.HOTENKHTableAdapter();
            this.tableAdapterManager = new ProjectNGANHANG.DS1TableAdapters.TableAdapterManager();
            this.txDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.cbHoTen = new System.Windows.Forms.ComboBox();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.TKTableAdapter = new ProjectNGANHANG.DS1TableAdapters.TaiKhoanTableAdapter();
            this.txSTK = new System.Windows.Forms.TextBox();
            this.dtTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.dtDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            dIACHILabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOTENKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(452, 141);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(74, 22);
            dIACHILabel.TabIndex = 5;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel.Location = new System.Drawing.Point(17, 141);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(159, 22);
            hOTENLabel.TabIndex = 6;
            hOTENLabel.Text = "Họ tên khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(17, 223);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(113, 22);
            label2.TabIndex = 8;
            label2.Text = "Số tài khoản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(452, 223);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(80, 22);
            label3.TabIndex = 10;
            label3.Text = "Từ ngày:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(792, 223);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(89, 22);
            label4.TabIndex = 12;
            label4.Text = "Đến ngày:";
            // 
            // cbSaoKeChiNhanh
            // 
            this.cbSaoKeChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSaoKeChiNhanh.FormattingEnabled = true;
            this.cbSaoKeChiNhanh.Location = new System.Drawing.Point(125, 26);
            this.cbSaoKeChiNhanh.Name = "cbSaoKeChiNhanh";
            this.cbSaoKeChiNhanh.Size = new System.Drawing.Size(401, 30);
            this.cbSaoKeChiNhanh.TabIndex = 3;
            this.cbSaoKeChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chi nhánh";
            // 
            // DS1
            // 
            this.DS1.DataSetName = "DS1";
            this.DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsHOTENKH
            // 
            this.bdsHOTENKH.DataMember = "HOTENKH";
            this.bdsHOTENKH.DataSource = this.DS1;
            // 
            // HOTENKHTableAdapter
            // 
            this.HOTENKHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectNGANHANG.DS1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txDiaChi
            // 
            this.txDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHOTENKH, "DIACHI", true));
            this.txDiaChi.Location = new System.Drawing.Point(538, 138);
            this.txDiaChi.Name = "txDiaChi";
            this.txDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txDiaChi.Properties.ReadOnly = true;
            this.txDiaChi.Size = new System.Drawing.Size(537, 28);
            this.txDiaChi.TabIndex = 6;
            // 
            // cbHoTen
            // 
            this.cbHoTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHOTENKH, "HOTEN", true));
            this.cbHoTen.DataSource = this.bdsHOTENKH;
            this.cbHoTen.DisplayMember = "HOTEN";
            this.cbHoTen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHoTen.FormattingEnabled = true;
            this.cbHoTen.Location = new System.Drawing.Point(182, 138);
            this.cbHoTen.Name = "cbHoTen";
            this.cbHoTen.Size = new System.Drawing.Size(222, 30);
            this.cbHoTen.TabIndex = 7;
            this.cbHoTen.ValueMember = "CMND";
            this.cbHoTen.SelectedIndexChanged += new System.EventHandler(this.cbHoTen_SelectedIndexChanged);
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "TaiKhoan";
            this.bdsTK.DataSource = this.DS1;
            // 
            // TKTableAdapter
            // 
            this.TKTableAdapter.ClearBeforeFill = true;
            // 
            // txSTK
            // 
            this.txSTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSTK.Location = new System.Drawing.Point(182, 220);
            this.txSTK.Name = "txSTK";
            this.txSTK.ReadOnly = true;
            this.txSTK.Size = new System.Drawing.Size(222, 30);
            this.txSTK.TabIndex = 9;
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.EditValue = null;
            this.dtTuNgay.Location = new System.Drawing.Point(538, 224);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTuNgay.Properties.Appearance.Options.UseFont = true;
            this.dtTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTuNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtTuNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtTuNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtTuNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtTuNgay.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dtTuNgay.Size = new System.Drawing.Size(212, 28);
            this.dtTuNgay.TabIndex = 13;
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.EditValue = null;
            this.dtDenNgay.Location = new System.Drawing.Point(887, 224);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDenNgay.Properties.Appearance.Options.UseFont = true;
            this.dtDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDenNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtDenNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDenNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtDenNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDenNgay.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dtDenNgay.Size = new System.Drawing.Size(188, 28);
            this.dtDenNgay.TabIndex = 14;
            // 
            // btnPreview
            // 
            this.btnPreview.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Appearance.Options.UseFont = true;
            this.btnPreview.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_binocular_30;
            this.btnPreview.Location = new System.Drawing.Point(655, 26);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(128, 39);
            this.btnPreview.TabIndex = 15;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "FK_TaiKhoan_KhachHang1";
            this.taiKhoanBindingSource.DataSource = this.bdsHOTENKH;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_exit_30;
            this.btnThoat.Location = new System.Drawing.Point(856, 26);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 39);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // SaoKeGD_Frpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 350);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.dtDenNgay);
            this.Controls.Add(this.dtTuNgay);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.txSTK);
            this.Controls.Add(label2);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.cbHoTen);
            this.Controls.Add(dIACHILabel);
            this.Controls.Add(this.txDiaChi);
            this.Controls.Add(this.cbSaoKeChiNhanh);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaoKeGD_Frpt";
            this.Text = "SaoKeGD_Frpt";
            this.Load += new System.EventHandler(this.SaoKeGD_Frpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHOTENKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DS1 DS1;
        private System.Windows.Forms.BindingSource bdsHOTENKH;
        private DS1TableAdapters.HOTENKHTableAdapter HOTENKHTableAdapter;
        private DS1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsTK;
        private DS1TableAdapters.TaiKhoanTableAdapter TKTableAdapter;
        public System.Windows.Forms.ComboBox cbSaoKeChiNhanh;
        public DevExpress.XtraEditors.TextEdit txDiaChi;
        public System.Windows.Forms.ComboBox cbHoTen;
        public System.Windows.Forms.TextBox txSTK;
        public DevExpress.XtraEditors.DateEdit dtTuNgay;
        public DevExpress.XtraEditors.DateEdit dtDenNgay;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}