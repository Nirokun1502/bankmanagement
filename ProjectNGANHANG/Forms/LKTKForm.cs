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
    public partial class LKTKForm : Form
    {
        public LKTKForm()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cbChiNhanh.SelectedIndex < 0)
            {
                MessageBox.Show("Chi nhánh không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                cbChiNhanh.Focus();
                return;
            }

            if (dtTuNgay.Text == "")
            {
                MessageBox.Show("Ngày bắt đầu không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                dtTuNgay.Focus();
                return;
            }

            if (dtDenNgay.Text == "")
            {
                MessageBox.Show("Ngày bắt đầu không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                dtTuNgay.Focus();
                return;
            }

            int index = cbChiNhanh.SelectedIndex;

            string strLenh = "EXEC SP_LietKeTaiKhoan'" + dtTuNgay.Text + "','" + dtDenNgay.Text + "'";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            DataView dv = new DataView(dt);
            
            if(index == 0)
            {
                dv.RowFilter = "MACN='BENTHANH'";
                gcLKTK.DataSource = dv;
            }
            else if (index == 1) 
            {
                dv.RowFilter = "MACN='TANDINH'";
                gcLKTK.DataSource = dv;
            }
            else if (index == 2) 
            {
                gcLKTK.DataSource = dv;
            }

           

        }
    }
}
