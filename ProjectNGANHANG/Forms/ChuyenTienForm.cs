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
    public partial class ChuyenTienForm : Form
    {
        public static string macn = "";
        public ChuyenTienForm()
        {
            InitializeComponent();
        }

        private void gD_CHUYENTIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCHUYENTIEN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS2);

        }

        private void ChuyenTienForm_Load(object sender, EventArgs e)
        {        

            DS2.EnforceConstraints = false;
            this.CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CHUYENTIENTableAdapter.Fill(this.DS2.GD_CHUYENTIEN);


            cbChiNhanh.DataSource = Program.bds_dspm; // sao chép bds_dspm đã tải ở form login
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
            cbChiNhanh.SelectedIndex = Program.Chinhanh;

            macn = cbChiNhanh.Text;

            // bật tắt các nút lệnh theo phân quyền
            btnGhi.Enabled = btnUndo.Enabled = false;


            //phân quyền bật tắt btn
            if (Program.Group == "CONGTY") cbChiNhanh.Enabled = true;
            else cbChiNhanh.Enabled = false;
        }

    

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl2.Enabled = true;
            txMANV.Text = Program.username;
            //bdsGOIRUT.AddNew();

            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcChuyenTien.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl2.Enabled = false;
            txMANV.Text = "";
            txSTK1.Text = "";
            txSTK2.Text = "";
            txSoTien.Text = "0";
          

            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            gcChuyenTien.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CHUYENTIENTableAdapter.Fill(this.DS2.GD_CHUYENTIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txSTK1.Text.Trim() == "")
            {
                MessageBox.Show("Số tài khoản không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txSTK1.Focus();
                return;
            }

            if (txSTK2.Text.Trim() == "")
            {
                MessageBox.Show("Loại giao dịch không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txSTK2.Focus();
                return;
            }

            string sotien = txSoTien.Text;
            //if (sotien.Length < 7)
            //{
            //    MessageBox.Show("Số tiền nhập vào không hợp lệ!", "Lỗi!", MessageBoxButtons.OK);
            //    txSoTien.Focus();
            //    return;
            //}

            //if (sotien.Length < 7)
            //{
            //    MessageBox.Show("Hãy nhập số tiền tối thiểu là 100.000", "Lỗi!", MessageBoxButtons.OK);
            //    txSoTien.Focus();
            //    return;
            //}

                   
            string strLenh = "EXEC SP_GDChuyenTien '" + txSTK1.Text + "','" + txSTK2.Text + "','" + txSoTien.Text + "','" + txMANV.Text + "'";
            int result;
            SqlDataReader CHUYENTIENreader = Program.ExecSqlDataReader(strLenh);

            if (CHUYENTIENreader == null) { return; }
            CHUYENTIENreader.Read();
            result = CHUYENTIENreader.GetInt32(0);
            CHUYENTIENreader.Close();



            switch (result)
            {
                case 0:
                    MessageBox.Show("Giao dịch thất bại, vui lòng kiểm tra lại thông tin!", "Lỗi!", MessageBoxButtons.OK);
                    return;
                case 1:
                    MessageBox.Show("Giao dịch thành công!", "Thông báo", MessageBoxButtons.OK);
                    break;
                case 2:
                    MessageBox.Show("Tài khoản chuyển tiền đã bị xóa hoặc thay đổi, reload lại để kiểm tra!", "Lỗi!", MessageBoxButtons.OK);
                    return;
                case 3:
                    MessageBox.Show("Tài khoản nhận tiền đã bị xóa hoặc thay đổi, reload lại để kiểm tra!", "Lỗi!", MessageBoxButtons.OK);
                    return;            
                case 4:
                    MessageBox.Show("Số dư trong tài khoản không đủ để thực hiện chuyển tiền!", "Lỗi!", MessageBoxButtons.OK);
                    return;
                

                default:
                    MessageBox.Show("Lỗi không xác định, vui lòng thử lại!", "Lỗi!", MessageBoxButtons.OK);
                    return;
            }

            try
            {
                bdsCHUYENTIEN.ResetCurrentItem();
                this.CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CHUYENTIENTableAdapter.Update(this.DS2.GD_CHUYENTIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi ghi thông tin giao dịch.\n" + ex.Message, "lỗi!", MessageBoxButtons.OK);
                return;
            }

            gcChuyenTien.Enabled = true;
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void btnSTK1_Click(object sender, EventArgs e)
        {
            numbtn.Text = "1";
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "TaiKhoanSubForm")
                {
                    frm.Close();
                    TaiKhoanSubForm form = new TaiKhoanSubForm();
                    form.Show();
                    return;
                }
            }
            TaiKhoanSubForm f = new TaiKhoanSubForm();
            f.Show();
        }

        private void btnSTK2_Click(object sender, EventArgs e)
        {
            numbtn.Text = "2";
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "TaiKhoanSubForm")
                {
                    frm.Close();
                    TaiKhoanSubForm form = new TaiKhoanSubForm();
                    form.Show();
                    return;
                }
            }
            TaiKhoanSubForm f = new TaiKhoanSubForm();
            f.Show();
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
                this.CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CHUYENTIENTableAdapter.Fill(this.DS2.GD_CHUYENTIEN);

            }
        }
    }
}
