using DevExpress.XtraReports.UI;
using ProjectNGANHANG.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNGANHANG.Forms
{
    public partial class SaoKeGD_Frpt : Form
    {
        public SaoKeGD_Frpt()
        {
            InitializeComponent();
        }

        private void SaoKeGD_Frpt_Load(object sender, EventArgs e)
        {

            DS1.EnforceConstraints = false;
            this.TKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TKTableAdapter.Fill(this.DS1.TaiKhoan);

            this.HOTENKHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.HOTENKHTableAdapter.Fill(this.DS1.HOTENKH);

            cbSaoKeChiNhanh.DataSource = Program.bds_dspm; // sao chép bds_dspm đã tải ở form login
            cbSaoKeChiNhanh.DisplayMember = "TENCN";
            cbSaoKeChiNhanh.ValueMember = "TENSERVER";
            cbSaoKeChiNhanh.SelectedIndex = Program.Chinhanh;

            //if (Program.Group == "NGANHANG") cbSaoKeChiNhanh.Enabled = true;
            //else cbSaoKeChiNhanh.Enabled = false;

            //cbHoTen.SelectedIndex = 0;
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSaoKeChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }
            Program.severname = cbSaoKeChiNhanh.SelectedValue.ToString();

            if (cbSaoKeChiNhanh.SelectedIndex != Program.Chinhanh)
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

                this.HOTENKHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.HOTENKHTableAdapter.Fill(this.DS1.HOTENKH);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            if (txSTK.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn 1 khách hàng có số tài khoản", "Lỗi!", MessageBoxButtons.OK);
                return;
            }

            if (dtTuNgay.Text.Trim() == "")
            {
                MessageBox.Show("Ngày bắt đầu không được để trống", "Lỗi!", MessageBoxButtons.OK);
                dtTuNgay.Focus();
                return;
            }

            if (dtDenNgay.Text.Trim() == "")
            {
                MessageBox.Show("Ngày kết thúc không được để trống", "Lỗi!", MessageBoxButtons.OK);
                dtDenNgay.Focus();
                return;
            }

            if (DateTime.ParseExact(dtTuNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture) > DateTime.ParseExact(dtDenNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture))

            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi!", MessageBoxButtons.OK);
                dtTuNgay.Focus();
                return;
            }

            string sotk = txSTK.Text;
            Xrpt_SaoKeGD rpt = new Xrpt_SaoKeGD(sotk, dtTuNgay.Text, dtDenNgay.Text);

            rpt.lbHoTen.Text = cbHoTen.Text;
            rpt.lbSTK.Text = sotk;
            rpt.lbDiaChi.Text = txDiaChi.Text;
            rpt.lbTuNgay.Text = dtTuNgay.Text;
            rpt.lbDenNgay.Text = dtDenNgay.Text;
            rpt.dtNgayThucHien.Text = DateTime.Today.ToString("dd/MM/yyyy");
            if(cbSaoKeChiNhanh.SelectedIndex != Program.Chinhanh)
            {
                if(cbSaoKeChiNhanh.SelectedIndex == 1)
                {
                    rpt.lbChiNhanh.Text = "BENTHANH";
                }
                else
                {
                    rpt.lbChiNhanh.Text = "TANDINH";
                }
            }
            else
            {
                rpt.lbChiNhanh.Text = cbSaoKeChiNhanh.Text;
            }

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void cbHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string hoten = cbHoTen.Text;
                int index = bdsHOTENKH.Find("HOTEN", hoten);
                string diachi = ((DataRowView)bdsHOTENKH[index])["DIACHI"].ToString();
                string cmnd = ((DataRowView)bdsHOTENKH[index])["CMND"].ToString();
               
                index = bdsTK.Find("CMND", cmnd);
                string sotk = ((DataRowView)bdsTK[index])["SOTK"].ToString();

                txDiaChi.Text = diachi;
                txSTK.Text = sotk;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khách hàng này chưa có tài khoản!" + ex.Message,  "Thông báo", MessageBoxButtons.OK);
                txSTK.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
