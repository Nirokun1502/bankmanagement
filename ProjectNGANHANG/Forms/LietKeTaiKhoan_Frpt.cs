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
    public partial class LietKeTaiKhoan_Frpt : Form
    {
        public LietKeTaiKhoan_Frpt()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
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

            if (DateTime.ParseExact(dtTuNgay.Text,"dd/MM/yyyy", CultureInfo.InvariantCulture) > DateTime.ParseExact(dtDenNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture))

            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi!", MessageBoxButtons.OK);
                dtTuNgay.Focus();
                return;
            }

            Xrpt_LietKeTaiKhoan rpt = new Xrpt_LietKeTaiKhoan(cbChiNhanh.SelectedIndex, dtTuNgay.Text, dtDenNgay.Text);
            rpt.lbTieuDe.Text = "THỐNG KÊ KHÁCH HÀNG Ở " + cbChiNhanh.Text;
            rpt.lbTuNgay.Text = dtTuNgay.Text;
            rpt.lbDenNgay.Text = dtDenNgay.Text;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void LietKeTaiKhoan_Frpt_Load(object sender, EventArgs e)
        {
            cbChiNhanh.SelectedIndex = Program.Chinhanh;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
