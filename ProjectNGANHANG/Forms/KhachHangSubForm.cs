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
    public partial class KhachHangSubForm : Form
    {   

        public KhachHangSubForm()
        {
            InitializeComponent();
        }

        //private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.bdsKH.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.DS1);

        //}

        private void KhachHangSubForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS1.TaiKhoan' table. You can move, or remove it, as needed.
            
            DS1.EnforceConstraints = false;
            this.KHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHTableAdapter.Fill(this.DS1.KhachHang);

            this.TKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TKTableAdapter.Fill(this.DS1.TaiKhoan);


            cbChiNhanh.DataSource = Program.bds_dspm; // sao chép bds_dspm đã tải ở form login
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
            cbChiNhanh.SelectedIndex = Program.Chinhanh;


            //cbChiNhanh1.SelectedIndex = Program.Chinhanh;
            //string strLenh = "EXEC SP_LietKeKhachHang" + 2;
            //DataTable dt = Program.ExecSqlDataTable(strLenh);
            //DataView dv = new DataView(dt);
            //if(cbChiNhanh1.SelectedIndex == 0)
            //{
            //    dv.RowFilter = "MACN=BENTHANH";
            //}
            //else if(cbChiNhanh1.SelectedIndex == 1)
            //{
            //    dv.RowFilter = "MACN=TANDINH";
            //}
            //gcKH.DataSource = dv;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            Program.severname = cbChiNhanh.SelectedValue.ToString();

            if (cbChiNhanh.SelectedIndex != Program.Chinhanh)
            {
                Program.login = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.login = Program.loginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "Lỗi!", MessageBoxButtons.OK);

            }
            else
            {
                this.KHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHTableAdapter.Fill(this.DS1.KhachHang);
                this.TKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.TKTableAdapter.Fill(this.DS1.TaiKhoan);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string cmnd = ((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString();

            int index = bdsTK.Find("CMND", cmnd);
            if (index >= 0)
            {
                if (MessageBox.Show("Khách hàng đã có tài khoản tại chi nhánh " + ((DataRowView)bdsTK[index])["MACN"].ToString()+".\nBạn có muốn tạo thêm?",
                     "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }                   
            }
            
            MainForm.TKForm.txCMND.Text = cmnd;

            this.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                this.KHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHTableAdapter.Fill(this.DS1.KhachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThemLogin_Click(object sender, EventArgs e)
        {
            string cmnd = ((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString();
            MainForm.LoginKHForm.txCMND.Text = cmnd;
            this.Close();
        }
    }
}
