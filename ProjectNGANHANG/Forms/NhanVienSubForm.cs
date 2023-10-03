using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNGANHANG.Forms
{
    public partial class NhanVienSubForm : Form
    {
        public NhanVienSubForm()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS2);

        }

        private void NhanVienSubForm_Load(object sender, EventArgs e)
        {
            DS2.EnforceConstraints = false; //bỏ qua kiểm tra khóa ngoại chưa có
            this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr; //tài khoản nào tải dữ liệu đó tránh th tk mặc định đổi pass
            this.NHANVIENTableAdapter.Fill(this.DS2.NhanVien);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //string manv = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();
            //string trangthaixoa = ((DataRowView)bdsNV[bdsNV.Position])["Trang Thai Xoa"].ToString();

            //if (trangthaixoa == "1")
            //{
            //    MessageBox.Show("Nhân viên này đã bị chuyển sang chi nhánh khác!","Thông báo", MessageBoxButtons.OK);
            //    return;

            //}

            //MainForm.NVForm.txMANV.Text = manv;

            //this.Close();

            string manv = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();
            MainForm.LoginNVForm.txMANV.Text = manv;
            this.Close();

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NHANVIENTableAdapter.Fill(this.DS2.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
