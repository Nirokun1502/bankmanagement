using DevExpress.XtraReports.UI;
using ProjectNGANHANG.Reports;
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
    public partial class LietKeKhachHang_Frpt : Form
    {
        public LietKeKhachHang_Frpt()
        {
            InitializeComponent();
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LietKeKhachHang_Frpt_Load(object sender, EventArgs e)
        {
         
            cbChiNhanh.SelectedIndex = Program.Chinhanh;


            if (Program.Group == "NGANHANG") cbChiNhanh.Enabled = true;
            else cbChiNhanh.Enabled = false;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            int type = 0;
            if (cbChiNhanh.SelectedIndex == 2)
            {
                type = 2;
            }
            else if (cbChiNhanh.SelectedIndex != Program.Chinhanh)
            {
                type = 1;
            }

            Xrpt_LietKeKhachHang rpt = new Xrpt_LietKeKhachHang(type);
            rpt.lbTieuDe.Text = "THỐNG KÊ KHÁCH HÀNG Ở " + cbChiNhanh.Text;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
