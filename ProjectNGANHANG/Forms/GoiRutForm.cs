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
    public partial class GoiRutForm : Form
    {
        //public static int numbtn = 0;
        public static string macn = "";
        public GoiRutForm()
        {
            InitializeComponent();
        }

        //private void gD_GOIRUTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.bdsGOIRUT.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.DS2);

        //}

        private void GoiRutForm_Load(object sender, EventArgs e)
        {
            DS2.EnforceConstraints = false;
            this.GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GOIRUTTableAdapter.Fill(this.DS2.GD_GOIRUT);


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
                this.GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GOIRUTTableAdapter.Fill(this.DS2.GD_GOIRUT);
              
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl2.Enabled = true;          
            txMANV.Text = Program.username;
            //bdsGOIRUT.AddNew();

            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcGoiRut.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl2.Enabled = false;
            txMANV.Text = "";
            txSTK1.Text = "";
            txLoaiGD.SelectedIndex = -1;
            txSoTien.Text = "0";
            //bdsGOIRUT.AddNew();

            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            gcGoiRut.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txSTK1.Text.Trim() == "")
            {
                MessageBox.Show("Số tài khoản không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txSTK1.Focus();
                return;
            }

            if (txLoaiGD.Text.Trim() == "")
            {
                MessageBox.Show("Loại giao dịch không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txLoaiGD.Focus();
                return;
            }
            
            string sotien = txSoTien.Text;
            //if (sotien.Length < 7)
            //{
            //    MessageBox.Show("Số tiền nhập vào không hợp lệ!", "Lỗi!", MessageBoxButtons.OK);
            //    txSoTien.Focus();
            //    return;
            //}

            if (sotien.Length < 8)
            {
                MessageBox.Show("Hãy nhập số tiền tối thiểu là 100.000", "Lỗi!", MessageBoxButtons.OK);
                txSoTien.Focus();
                return;
            }

            string[] gd = { "GT", "RT" };
            string loaigd = gd[txLoaiGD.SelectedIndex];
            string strLenh = "EXEC SP_GDGoiRut '"+txSTK1.Text +"','"+loaigd+"','"+txSoTien.Text+"','"+txMANV.Text+"'";
            int result;
            SqlDataReader GOIRUTreader = Program.ExecSqlDataReader(strLenh);

            if (GOIRUTreader == null) { return; }
            GOIRUTreader.Read();
            result = GOIRUTreader.GetInt32(0);
            GOIRUTreader.Close();



           switch (result)
            {
                case -1:
                    MessageBox.Show("Tài khoản đã bị xóa hoặc thay đổi, reload lại để kiểm tra!", "Lỗi!", MessageBoxButtons.OK);
                    return;
                case 0:
                    MessageBox.Show("Giao dịch thất bại, vui lòng kiểm tra lại thông tin!", "Lỗi!", MessageBoxButtons.OK);
                    return;
                case 2:
                    MessageBox.Show("Số dư trong tài khoản không đủ để thực hiện rút tiền!", "Lỗi!", MessageBoxButtons.OK);
                    return;
                case 1:
                    MessageBox.Show("Giao dịch thành công!", "Thông báo", MessageBoxButtons.OK);
                    break;

                default:
                    MessageBox.Show("Lỗi không xác định, vui lòng thử lại!", "Lỗi!", MessageBoxButtons.OK);
                    return;
            }

            try
            {
                bdsGOIRUT.ResetCurrentItem();
                this.GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GOIRUTTableAdapter.Update(this.DS2.GD_GOIRUT);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi ghi thông tin giao dịch.\n" + ex.Message, "lỗi!", MessageBoxButtons.OK);
                return;
            }

            gcGoiRut.Enabled = true;
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GOIRUTTableAdapter.Fill(this.DS2.GD_GOIRUT);
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
    }
}
