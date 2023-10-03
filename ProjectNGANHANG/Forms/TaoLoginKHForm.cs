using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNGANHANG.Forms
{
    public partial class TaoLoginKHForm : Form
    {
        public TaoLoginKHForm()
        {
            InitializeComponent();
        }

        private void TaoLoginKHForm_Load(object sender, EventArgs e)
        {
            txNhom.Text = "KHACHHANG";
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txTK.Text = "";
            txMK.Text = "";
            txNhom.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCMND_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "KhachHangSubForm")
                {
                    frm.Close();
                    KhachHangSubForm form = new KhachHangSubForm();
                    form.btnThemLogin.Visible = true;
                    form.btnThem.Visible = false;
                    form.cbChiNhanh.Enabled = false;
                    form.Show();
                    return;
                }
            }
            KhachHangSubForm f = new KhachHangSubForm();
            f.btnThemLogin.Visible = true;
            f.btnThem.Visible = false;
            f.cbChiNhanh.Enabled=false;
            f.Show();
        }

        private void btnTaoLogin_Click(object sender, EventArgs e)
        {
            if (txTK.Text.Trim() == "")
            {
                MessageBox.Show("Tên tài khoản không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txTK.Focus();
                return;
            }

            if (txMK.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txMK.Focus();
                return;
            }

            if (txCMND.Text.Trim() == "")
            {
                MessageBox.Show("CMND không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txCMND.Focus();
                return;
            }

            string strLenh = "EXEC SP_TaoLogin '" + txTK.Text + "','" + txMK.Text + "','" + txCMND.Text + "','" + txNhom.Text + "'";
            int result;
            SqlDataReader LoginReader = Program.ExecSqlDataReader(strLenh);

            if (LoginReader == null) { return; }

            LoginReader.Read();
            result = LoginReader.GetInt32(0);
            LoginReader.Close();

            //if(result == 2)
            //{
            //    MessageBox.Show("Nhân viên này đã có tài khoản hệ thống!", "Lỗi!", MessageBoxButtons.OK);
            //    txMANV.Text = "";
            //    return;
            //}
            //else if (result == 1)
            //{
            //    MessageBox.Show("Tên tài khoản đã tồn tại!", "Lỗi!", MessageBoxButtons.OK);
            //    txTK.Text = "";
            //    txTK.Focus();
            //    return;
            //}
            //else

            if (result == 0)
            {
                MessageBox.Show("Tạo login thành công!", "Thông báo", MessageBoxButtons.OK);
                txTK.Text = "";
                txMK.Text = "";
                txCMND.Text = "";
            }
        }
    }
}
