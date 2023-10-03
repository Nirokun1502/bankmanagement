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
    public partial class NhanVienForm : Form
    {
        int vitri = 0;
        string macn = "";
        string mode = "";
        

        public NhanVienForm()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
           
            DS.EnforceConstraints = false; //bỏ qua kiểm tra khóa ngoại chưa có
            this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr; //tài khoản nào tải dữ liệu đó tránh th tk mặc định đổi pass
            this.NHANVIENTableAdapter.Fill(this.DS.NhanVien);

            this.CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);
            
            this.GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);

            //note: dòng code dưới vẫn tiềm ẩn lỗi, tự sửa         
            //macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
        

            cbChiNhanh.DataSource = Program.bds_dspm; // sao chép bds_dspm đã tải ở form login
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
            cbChiNhanh.SelectedIndex = Program.Chinhanh;

            macn = cbChiNhanh.Text;

           
            btnGhi.Enabled = btnUndo.Enabled = false;


            //phân quyền bật tắt btn
            if (Program.Group == "NGANHANG") 
            {
                cbChiNhanh.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnChuyenCN.Enabled = false;
            }
            else cbChiNhanh.Enabled = false;

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

      

       

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            mode = "add";

            panelControl2.Enabled = true;
            txMANV.Enabled = true;
            txCMND.Enabled = true;
            bdsNV.AddNew();
            txMACN.Text = macn;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcNhanVien.Enabled = false;

            trangThaiXoaCheckBox.CheckState = CheckState.Unchecked;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            if(btnThem.Enabled == false) { bdsNV.Position = vitri; }
            

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;       
            panelControl2.Enabled = false;
            gcNhanVien.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            mode = "edit";

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            panelControl2.Enabled = true;
            txMANV.Enabled = false;
            txCMND.Enabled = false;
            gcNhanVien.Enabled = false;

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NHANVIENTableAdapter.Fill(this.DS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString(); // giữ lại để phục hồi nếu k xóa đc trên csdl gốc va ktra khoa ngoai 
            if (bdsCHUYENTIEN.Find("MANV", manv) >= 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã thực hiện giao dịch chuyển tiền", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if(bdsGOIRUT.Find("MANV", manv) >= 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã thực hiện giao dịch gởi rút", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if(MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                     
                    if(manv == Program.mainForm.MANV.Text) {MessageBox.Show("Bạn không thể xóa chính bản thân mình!", "Thông báo", MessageBoxButtons.OK); return;}
                    bdsNV.RemoveCurrent();
                    this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NHANVIENTableAdapter.Update(this.DS.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    this.NHANVIENTableAdapter.Fill(this.DS.NhanVien);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                    return;
                }
            }

            if (bdsNV.Count == 0) { btnXoa.Enabled = false; }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   
            if(txMANV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txMANV.Focus();
                return;
            }

            if (txHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txHo.Focus();
                return;
            }

            if (txTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txTen.Focus();
                return;
            }
            // viết tiếp kiểm tra trống  phái, địa chỉ, cmnd, sdt

            if(cbPhai.Text.Trim() == "")
            {
                MessageBox.Show("Phái của nhân viên không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                cbPhai.Focus();
                return;
            }

            if (txDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ của nhân viên không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txDiaChi.Focus();
                return;
            }

            if (txCMND.Text.Trim() == "")
            {
                MessageBox.Show("CMND nhân viên không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txCMND.Focus();
                return;
            }

            if (txSDT.Text.Trim() == "")
            {
                MessageBox.Show("SĐT nhân viên không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txSDT.Focus();
                return;
            }

            // chạy sp tìm mã nv trùng, sp tìm cmnd trùng (trên các phân mảnh)

            if (mode == "add")
            {
                // check MANV trùng
                string strLenh = "EXEC SP_CheckMANV '" + txMANV.Text + "'";
                string manv;
                SqlDataReader MANVreader = Program.ExecSqlDataReader(strLenh);
                if (MANVreader == null) { return; }
                MANVreader.Read();
                manv = MANVreader.GetInt32(0).ToString();
                MANVreader.Close();
                if (manv == "1")
                {
                    MessageBox.Show("Mã nhân viên bị trùng ở chi nhánh hiện tại!", "Lỗi!", MessageBoxButtons.OK);
                    return;
                }
                else if (manv == "2")
                {
                    MessageBox.Show("Mã nhân viên bị trùng ở chi nhánh khác!", "Lỗi!", MessageBoxButtons.OK);
                    return;
                }
                else if (manv != "0")
                {
                    MessageBox.Show("Lỗi không xác định, bạn hãy thử lại", "Lỗi!", MessageBoxButtons.OK);
                    return;
                }
                // check MANV trùng

                // check CMND trùng
                strLenh = "EXEC SP_CheckCMND_NV '" + txCMND.Text + "'";
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
                bdsNV.EndEdit();
                bdsNV.ResetCurrentItem();

                this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NHANVIENTableAdapter.Update(this.DS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi ghi nhân viên.\n" + ex.Message, "lỗi!", MessageBoxButtons.OK);
                return;
            }
            gcNhanVien.Enabled = true;
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

            if(cbChiNhanh.SelectedIndex != Program.Chinhanh)
            {
                Program.login = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.login = Program.loginDN;
                Program.password = Program.passwordDN;
            }

            if(Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "Lỗi!", MessageBoxButtons.OK);
            }
            else
            {
                this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NHANVIENTableAdapter.Fill(this.DS.NhanVien);
                this.CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);
                this.GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
            }
        }

        private void gcNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void mANVLabel_Click(object sender, EventArgs e)
        {

        }

        private void hOLabel_Click(object sender, EventArgs e)
        {

        }

        private void cMNDLabel_Click(object sender, EventArgs e)
        {

        }

        private void dIACHILabel_Click(object sender, EventArgs e)
        {

        }

        private void mACNLabel_Click(object sender, EventArgs e)
        {

        }

        private void sODTLabel_Click(object sender, EventArgs e)
        {

        }

        private void trangThaiXoaLabel_Click(object sender, EventArgs e)
        {

        }

        private void pHAILabel_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barDockControlTop_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlBottom_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlLeft_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlRight_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bdsNV_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cbPhai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trangThaiXoaCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txSDT_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txMACN_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txDiaChi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txCMND_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txTen_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txHo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txMANV_EditValueChanged(object sender, EventArgs e)
        {

        }

   

        

        private void btnChuyenCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (trangThaiXoaCheckBox.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Nhân viên này đã bị đánh dấu xóa hoặc chuyển qua chi nhánh khác!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (txMANV.Text.Trim() == "")
            {
                MessageBox.Show("Hãy chọn nhân viên để tiến hành chuyển chi nhánh", "Lỗi!", MessageBoxButtons.OK);
                txMANV.Focus();
                return;
            }

            btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            gcNhanVien.Enabled = false;

            string macnchuyen = "";
            if (cbChiNhanh.SelectedIndex == 0)
            {
                macnchuyen = "TANDINH";
            }
            else if (cbChiNhanh.SelectedIndex == 1)
            {
                macnchuyen = "BENTHANH";
            }

            if(macnchuyen == "")
            {
                MessageBox.Show("Lỗi lấy thông tin chi nhánh! ", "Lỗi", MessageBoxButtons.OK);
                btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                gcNhanVien.Enabled = true;
                return;
            }

            if (MessageBox.Show("Tiến hành chuyển nhân viên: "+txMANV.Text +txHo.Text+" "+txTen.Text +
                                " từ chi nhánh: "+txMACN.Text+" qua chi nhánh: " + macnchuyen,
                                "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string strLenh = "EXEC SP_ChuyenCN '" + txMANV.Text + "','" + macnchuyen + "'";
                string type;
                SqlDataReader ChuyenCNreader = Program.ExecSqlDataReader(strLenh);
                if (ChuyenCNreader == null) { return; }
                ChuyenCNreader.Read();
                type = ChuyenCNreader.GetInt32(0).ToString();
                ChuyenCNreader.Close();
                if (type == "0")
                {
                    MessageBox.Show("Chuyển chi nhánh thất bại, vui lòng thử lại!", "Lỗi!", MessageBoxButtons.OK);
                    btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                    gcNhanVien.Enabled = true;
                    return;
                }
                else if (type == "1")
                {
                    MessageBox.Show("Chuyển chi nhánh cho nhân viên thành công!", "Thông báo", MessageBoxButtons.OK);
                    btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                    gcNhanVien.Enabled = true;
                    return;
                }
            }

            btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            gcNhanVien.Enabled = true;



        }
    }
}
