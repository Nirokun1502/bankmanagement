using DevExpress.Data;
using NGANHANG.Forms;
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
    public partial class TaiKhoanForm : Form
    {
        int vitri = 0;
       
        string mode = "";


        public TaiKhoanForm()
        {
            InitializeComponent();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS2);

        }

        private void TaiKhoanForm_Load(object sender, EventArgs e)
        {
            
            DS2.EnforceConstraints = false; //bỏ qua kiểm tra khóa ngoại chưa có
            this.TKTableAdapter.Connection.ConnectionString = Program.connstr; //tài khoản nào tải dữ liệu đó tránh th tk mặc định đổi pass
            this.TKTableAdapter.Fill(this.DS2.TaiKhoan);

            this.CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CHUYENTIENTableAdapter.Fill(this.DS2.GD_CHUYENTIEN);

            this.GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GOIRUTTableAdapter.Fill(this.DS2.GD_GOIRUT);

            cbChiNhanh.DataSource = Program.bds_dspm; // sao chép bds_dspm đã tải ở form login
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
            cbChiNhanh.SelectedIndex = Program.Chinhanh;

            

            // bật tắt các nút lệnh theo phân quyền
            btnGhi.Enabled = btnUndo.Enabled = false;

            if (Program.Group == "NGANHANG")
            {
                cbChiNhanh.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            }
            else cbChiNhanh.Enabled = false;

        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            vitri = bdsTK.Position;
            mode = "add";

            panelControl2.Enabled = true;
            
            //txCMND.Enabled = true;
            bdsTK.AddNew();

            txMACN.Text = cbChiNhanh.Text;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcTaiKhoan.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsTK.Position;
            mode = "edit";

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnCMND.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            panelControl2.Enabled = true;

            //txCMND.Enabled = false;
            gcTaiKhoan.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTK.CancelEdit();
            if (btnThem.Enabled == false) { bdsTK.Position = vitri; }


            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            panelControl2.Enabled = false;
            gcTaiKhoan.Enabled = true;
          
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.TKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.TKTableAdapter.Fill(this.DS2.TaiKhoan);
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string sotk = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString(); // giữ lại để phục hồi nếu k xóa đc trên csdl gốc va ktra khoa ngoai;
            if (bdsCHUYENTIEN.Find("SOTK_CHUYEN", sotk) >= 0)
            {
                MessageBox.Show("Không thể xóa tài khoản này vì đã thực hiện giao dịch chuyển tiền", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsCHUYENTIEN.Find("SOTK_NHAN", sotk) >= 0)
            {
                MessageBox.Show("Không thể xóa tài khoản này vì đã thực hiện giao dịch chuyển tiền", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsGOIRUT.Find("SOTK", sotk) >= 0)
            {
                MessageBox.Show("Không thể xóa tài khoản này vì đã thực hiện giao dịch gởi rút", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa tài khoản này ??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    
                    bdsTK.RemoveCurrent();
                    this.TKTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.TKTableAdapter.Update(this.DS2.TaiKhoan);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa tài khoản. Bạn hãy xóa lại\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    this.TKTableAdapter.Fill(this.DS2.TaiKhoan);
                    bdsTK.Position = bdsTK.Find("SOTK", sotk);
                    return;
                }
            }

            if (bdsTK.Count == 0) { btnXoa.Enabled = false; }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txSTK.Text.Trim() == "")
            {
                MessageBox.Show("Số tài khoản không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txSTK.Focus();
                return;
            }

            if (txCMND.Text.Trim() == "")
            {
                MessageBox.Show("CMND không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txCMND.Focus();
                return;
            }

            if (dtNgayMoTK.Text.Trim() == "")
            {
                MessageBox.Show("Ngày mở tài khoản không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                dtNgayMoTK.Focus();
                return;
            }

            //if (txSoDu.Text.Trim() == "")
            //{
            //    MessageBox.Show("Số dư tài khoản không được để trống!", "Lỗi!", MessageBoxButtons.OK);
            //    txSoDu.Focus();
            //    return;
            //}

            //int sotien = Int32.Parse(txSoTien.Text);
            //if (Int32.Parse(txSoDu.Text) < 0)
            //{
            //    MessageBox.Show("Số dư nhập vào không hợp lệ!", "Lỗi!", MessageBoxButtons.OK);
            //    txSoDu.Focus();
            //    return;
            //}

            string cmnd = txCMND.Text;
            int index = bdsTK.Find("CMND", cmnd);
            //string chinhanh = ((DataRowView)bdsTK[index])["MACN"].ToString();
            //if (chinhanh != txMACN.Text)
            //{
                if (Program.KetNoi_CSDLGOC() == 0)
                {
                    MessageBox.Show("Lỗi kết nối về site chủ", "Lỗi!", MessageBoxButtons.OK);
                }
            //}
            try
            {
                bdsTK.EndEdit();
                bdsTK.ResetCurrentItem();

                this.TKTableAdapter.Connection.ConnectionString = Program.connstr_publisher;
                this.TKTableAdapter.Update(this.DS2.TaiKhoan);

                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Lỗi kết nối về server hiện tại", "Lỗi!", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi ghi tài khoản.\n" + ex.Message, "lỗi!", MessageBoxButtons.OK);
                return;
            }
            gcTaiKhoan.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            panelControl2.Enabled = false;
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
                    form.cbChiNhanh.Enabled = true;
                    form.Show();
                    return;
                }
            }
            KhachHangSubForm f = new KhachHangSubForm();
            f.cbChiNhanh.Enabled = true;
            f.Show();
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
