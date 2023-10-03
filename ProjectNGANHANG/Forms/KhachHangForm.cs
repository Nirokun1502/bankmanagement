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
    public partial class KhachHangForm : Form
    {
        int vitri = 0;
        string macn = "";
        string mode = "";


        public KhachHangForm()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS1);

        }

        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            DS1.EnforceConstraints = false; //bỏ qua kiểm tra khóa ngoại chưa có
            this.KHTableAdapter.Connection.ConnectionString = Program.connstr; //tài khoản nào tải dữ liệu đó tránh th dùng tk mặc định đã đổi pass
            this.KHTableAdapter.Fill(this.DS1.KhachHang);

            this.TKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TKTableAdapter.Fill(this.DS1.TaiKhoan);


            //macn = ((DataRowView)bdsKH[0])["MACN"].ToString();
            cbChiNhanh.DataSource = Program.bds_dspm; // sao chép bds_dspm đã tải ở form login
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
            cbChiNhanh.SelectedIndex = Program.Chinhanh;

            macn = cbChiNhanh.Text;

            // bật tắt các nút lệnh theo phân quyền
            btnGhi.Enabled = btnUndo.Enabled = false;

            if (Program.Group == "NGANHANG")
            {
                cbChiNhanh.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            }
            else cbChiNhanh.Enabled = false;

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sODTLabel_Click(object sender, EventArgs e)
        {

        }

        private void dIACHILabel_Click(object sender, EventArgs e)
        {

        }

        private void hOLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            vitri = bdsKH.Position;
            mode = "add";
            panelControl2.Enabled = true;      
            //txCMND.Enabled = true;
            bdsKH.AddNew();
            txMACN.Text = macn;

            txCMND.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcKhachHang.Enabled = false;

 
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKH.CancelEdit();
            if (btnThem.Enabled == false) { bdsKH.Position = vitri; }


            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            panelControl2.Enabled = false;
            gcKhachHang.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKH.Position;
            mode = "edit";

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            panelControl2.Enabled = true;
            
            txCMND.Enabled = false;
            gcKhachHang.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cmnd = ((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString(); // giữ lại để phục hồi nếu k xóa đc trên csdl gốc và ktra tk tồn tại 
            int index = bdsTK.Find("CMND", cmnd);

            if (index >= 0)
            {
                MessageBox.Show("Không thể xóa khách hàng này vì đã có tài khoản", "Thông báo", MessageBoxButtons.OK);
                return;
            }
           

            if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng này ??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    
                    bdsKH.RemoveCurrent();
                    this.KHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KHTableAdapter.Update(this.DS1.KhachHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khách hàng. Bạn hãy xóa lại\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    this.KHTableAdapter.Fill(this.DS1.KhachHang);
                    bdsKH.Position = bdsKH.Find("CMND", cmnd);
                    return;
                }
            }

            if (bdsKH.Count == 0) { btnXoa.Enabled = false; }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            if (txHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ khách hàng không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txHo.Focus();
                return;
            }

            if (txTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên khách hàng không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txTen.Focus();
                return;
            }
            // viết tiếp kiểm tra trống  phái, địa chỉ, cmnd, sdt

            if (cbPhai.Text.Trim() == "")
            {
                MessageBox.Show("Phái của khách hàng không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                cbPhai.Focus();
                return;
            }

            if (txDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ của khách hàng không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txDiaChi.Focus();
                return;
            }

            if (txCMND.Text.Trim() == "")
            {
                MessageBox.Show("CMND khách hàng không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txCMND.Focus();
                return;
            }

            if (txSDT.Text.Trim() == "")
            {
                MessageBox.Show("SĐT khách hàng không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txSDT.Focus();
                return;
            }

            if (dtNgayCap.Text.Trim() == "")
            {
                MessageBox.Show("Ngày cấp không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                dtNgayCap.Focus();
                return;
            }

            // chạy sp tìm mã nv trùng, sp tìm cmnd trùng (trên các phân mảnh)

            if (mode == "add")
            {
              
                // check CMND trùng



                string strLenh = "EXEC SP_CheckCMND_KH '" + txCMND.Text + "'";
                string cmnd;
                SqlDataReader CMNDreader = Program.ExecSqlDataReader(strLenh);
                if (CMNDreader == null) { return; }
                CMNDreader.Read();
                cmnd = CMNDreader.GetInt32(0).ToString();
                CMNDreader.Close();
                if (cmnd == "1")
                {
                    MessageBox.Show("CMND bị trùng ở chi nhánh hiện tại!", "Lỗi!", MessageBoxButtons.OK);
                    return;
                }
                else if (cmnd == "2")
                {
                    MessageBox.Show("CMND bị trùng ở chi nhánh khác!", "Lỗi!", MessageBoxButtons.OK);
                    return;
                }
                else if (cmnd != "0")
                {
                    MessageBox.Show("Lỗi không xác định, bạn hãy thử lại", "Lỗi!", MessageBoxButtons.OK);
                    return;
                }
                // check CMND trùng
            }





            try
            {
                bdsKH.EndEdit();
                bdsKH.ResetCurrentItem();

                this.KHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHTableAdapter.Update(this.DS1.KhachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi ghi khách hàng.\n" + ex.Message, "lỗi!", MessageBoxButtons.OK);
                return;
            }
            gcKhachHang.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            panelControl2.Enabled = false;
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

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
