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
    public partial class TaoLoginNVForm : Form
    {
        public TaoLoginNVForm()
        {
            InitializeComponent();
        }

        private void btnMANV_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "NhanVienSubForm")
                {
                    frm.Activate();
                    return;
                }
            }

            NhanVienSubForm f = new NhanVienSubForm();
            f.Show();
        }

        private void TaoLoginNVForm_Load(object sender, EventArgs e)
        {
            txNhom.Text = Program.Group;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txTK.Text = "";
            txMK.Text = "";
            txMANV.Text = "";
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

            if (txMANV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txMANV.Focus();
                return;
            }

            string strLenh = "EXEC SP_TaoLogin '" + txTK.Text + "','" + txMK.Text + "','" + txMANV.Text + "','" + txNhom.Text + "'";
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

            if(result == 0)
            {
                MessageBox.Show("Tạo login thành công!", "Thông báo", MessageBoxButtons.OK);
                txTK.Text = "";
                txMK.Text = "";
                txMANV.Text = "";
            }

        }
    }
}
