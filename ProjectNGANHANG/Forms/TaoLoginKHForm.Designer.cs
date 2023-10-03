namespace ProjectNGANHANG.Forms
{
    partial class TaoLoginKHForm
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
            this.btnCMND = new DevExpress.XtraEditors.SimpleButton();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaoLogin = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txCMND = new DevExpress.XtraEditors.TextEdit();
            this.txNhom = new DevExpress.XtraEditors.TextEdit();
            this.txMK = new DevExpress.XtraEditors.TextEdit();
            this.txTK = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txTK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCMND
            // 
            this.btnCMND.Location = new System.Drawing.Point(447, 334);
            this.btnCMND.Name = "btnCMND";
            this.btnCMND.Size = new System.Drawing.Size(33, 32);
            this.btnCMND.TabIndex = 23;
            this.btnCMND.Text = "...";
            this.btnCMND.Click += new System.EventHandler(this.btnCMND_Click);
            // 
            // btnReload
            // 
            this.btnReload.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(159)))), ((int)(((byte)(199)))));
            this.btnReload.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Appearance.ForeColor = System.Drawing.Color.IndianRed;
            this.btnReload.Appearance.Options.UseBackColor = true;
            this.btnReload.Appearance.Options.UseFont = true;
            this.btnReload.Appearance.Options.UseForeColor = true;
            this.btnReload.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_reload_40;
            this.btnReload.Location = new System.Drawing.Point(821, 545);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(125, 69);
            this.btnReload.TabIndex = 22;
            this.btnReload.Text = "Hủy";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Appearance.Options.UseBackColor = true;
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Appearance.Options.UseForeColor = true;
            this.btnThoat.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_x_50;
            this.btnThoat.Location = new System.Drawing.Point(962, 545);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 69);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaoLogin
            // 
            this.btnTaoLogin.Appearance.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTaoLogin.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoLogin.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnTaoLogin.Appearance.Options.UseBackColor = true;
            this.btnTaoLogin.Appearance.Options.UseFont = true;
            this.btnTaoLogin.Appearance.Options.UseForeColor = true;
            this.btnTaoLogin.ImageOptions.Image = global::ProjectNGANHANG.Properties.Resources.icons8_add_50;
            this.btnTaoLogin.Location = new System.Drawing.Point(642, 545);
            this.btnTaoLogin.Name = "btnTaoLogin";
            this.btnTaoLogin.Size = new System.Drawing.Size(162, 69);
            this.btnTaoLogin.TabIndex = 20;
            this.btnTaoLogin.Text = "Tạo Login";
            this.btnTaoLogin.Click += new System.EventHandler(this.btnTaoLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(547, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nhóm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "CMND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên tài khoản";
            // 
            // txCMND
            // 
            this.txCMND.Location = new System.Drawing.Point(221, 334);
            this.txCMND.Name = "txCMND";
            this.txCMND.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCMND.Properties.Appearance.Options.UseFont = true;
            this.txCMND.Properties.ReadOnly = true;
            this.txCMND.Size = new System.Drawing.Size(220, 32);
            this.txCMND.TabIndex = 15;
            // 
            // txNhom
            // 
            this.txNhom.Location = new System.Drawing.Point(652, 337);
            this.txNhom.Name = "txNhom";
            this.txNhom.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNhom.Properties.Appearance.Options.UseFont = true;
            this.txNhom.Properties.ReadOnly = true;
            this.txNhom.Size = new System.Drawing.Size(220, 32);
            this.txNhom.TabIndex = 14;
            // 
            // txMK
            // 
            this.txMK.Location = new System.Drawing.Point(652, 133);
            this.txMK.Name = "txMK";
            this.txMK.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMK.Properties.Appearance.Options.UseFont = true;
            this.txMK.Size = new System.Drawing.Size(220, 32);
            this.txMK.TabIndex = 13;
            // 
            // txTK
            // 
            this.txTK.Location = new System.Drawing.Point(221, 136);
            this.txTK.Name = "txTK";
            this.txTK.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTK.Properties.Appearance.Options.UseFont = true;
            this.txTK.Size = new System.Drawing.Size(220, 32);
            this.txTK.TabIndex = 12;
            // 
            // TaoLoginKHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.btnCMND);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaoLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txCMND);
            this.Controls.Add(this.txNhom);
            this.Controls.Add(this.txMK);
            this.Controls.Add(this.txTK);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TaoLoginKHForm";
            this.Text = "TaoLoginKHForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TaoLoginKHForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txTK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCMND;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        public DevExpress.XtraEditors.SimpleButton btnTaoLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.TextEdit txCMND;
        private DevExpress.XtraEditors.TextEdit txNhom;
        private DevExpress.XtraEditors.TextEdit txMK;
        private DevExpress.XtraEditors.TextEdit txTK;
    }
}