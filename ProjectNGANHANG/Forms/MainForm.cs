using NGANHANG.Forms;
using ProjectNGANHANG.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectNGANHANG
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public static TaiKhoanForm TKForm;
        public static GoiRutForm GRForm;
        public static ChuyenTienForm CTForm;
        public static SaoKeForm SKForm;
        public static NhanVienForm NVForm;
        public static TaoLoginNVForm LoginNVForm;
        public static TaoLoginKHForm LoginKHForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach ( Form f in this.MdiChildren)
            {
                if (ftype == f.GetType() ) { return f;}

            }
            return null;
        }

        public static Boolean CheckExitedForm(String type)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == type)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "LoginForm")
                {
                    frm.Activate();
                    return;
                }
            }

            LoginForm f = new LoginForm();
            f.Show();
            
        }

        public void HienThiMenu()
        {
            MANV.Text = "Mã: " + Program.username;
            HOTEN.Text = "Họ tên: " + Program.Hoten;
            NHOM.Text = "Nhóm: " + Program.Group;
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            
            //Phân quyền
            // tiếp tục phân quyền dựa trên Group để ẩn/hiện các nút lệnh trên menu
            if(Program.Group == "CHINHANH")
            {
                btnTaoLoginNV.Enabled = btnTaoLoginKH.Enabled = true;
                NghiepVuPage.Visible = GiaoDichPage.Visible = ThongKePage.Visible = true;               
            }
            else if(Program.Group == "NGANHANG")
            {
                btnTaoLoginNV.Enabled = true;
                NghiepVuPage.Visible = ThongKePage.Visible = true;
            }
            else if(Program.Group == "KHACHHANG")
            {
                ThongKePage.Visible = true;
            }
        }

      

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(NhanVienForm));
            if (frm != null) { frm.Activate(); }
            else
            {
                NVForm = new NhanVienForm();
                NVForm.MdiParent = this;
                NVForm.Show();
            }
        }


        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(KhachHangForm));
            if (frm != null) { frm.Activate(); }
            else
            {
                KhachHangForm f = new KhachHangForm();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Form frm = this.CheckExists(typeof(TaiKhoanForm));
            if (frm != null) { frm.Activate(); }
            else
            {
                TKForm = new TaiKhoanForm();
                TKForm.MdiParent = this;
                TKForm.Show();
            }
        }

        private void btnGoiRut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(GoiRutForm));
            if (frm != null) { frm.Activate(); }
            else
            {
                GRForm = new GoiRutForm();
                GRForm.MdiParent = this;
                GRForm.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(ChuyenTienForm));
            if (frm != null) { frm.Activate(); }
            else
            {
                CTForm = new ChuyenTienForm();
                CTForm.MdiParent = this;
                CTForm.Show();
            }
        }

        private void btnSaoKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(SaoKeForm));
            if (frm != null) { frm.Activate(); }
            else
            {
                SKForm = new SaoKeForm();
                SKForm.MdiParent = this;
                SKForm.Show();
            }
        }

        private void btnLKKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(LKKHForm));
            if (frm != null) { frm.Activate(); }
            else
            {
                LKKHForm f = new LKKHForm();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLKTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(LKTKForm));
            if (frm != null) { frm.Activate(); }
            else
            {
                LKTKForm f = new LKTKForm();
                f.MdiParent = this;
                f.Show();
            }
        }


        private void btnTaoLoginNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(TaoLoginNVForm));
            if (frm != null) { frm.Activate(); }
            else
            {
                LoginNVForm = new TaoLoginNVForm();
                LoginNVForm.MdiParent = this;
                LoginNVForm.Show();
            }
        }

        private void btnTaoLoginKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(TaoLoginKHForm));
            if (frm != null) { frm.Activate(); }
            else
            {
                LoginKHForm = new TaoLoginKHForm();
                LoginKHForm.MdiParent = this;
                LoginKHForm.Show();
            }
        }

        private void btnSaoKe_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(SaoKeGD_Frpt));
            if (frm != null) { frm.Activate(); }
            else
            {
                SaoKeGD_Frpt f = new SaoKeGD_Frpt();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(LietKeKhachHang_Frpt));
            if (frm != null) { frm.Activate(); }
            else
            {
                LietKeKhachHang_Frpt f = new LietKeKhachHang_Frpt();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(LietKeTaiKhoan_Frpt));
            if (frm != null) { frm.Activate(); }
            else
            {
                LietKeTaiKhoan_Frpt f = new LietKeTaiKhoan_Frpt();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Restart();
            this.Close();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất tài khoản?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Restart();
                this.Close();
            }           
        }
    }
}
