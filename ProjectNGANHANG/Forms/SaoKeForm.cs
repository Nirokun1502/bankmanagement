using DevExpress.Utils.Extensions;
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
    public partial class SaoKeForm : Form
    {
        public SaoKeForm()
        {
            InitializeComponent();
        }

        private void btnSTK_Click(object sender, EventArgs e)
        {   
            
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "TaiKhoanSubForm")
                {   
                    frm.Close();
                    TaiKhoanSubForm form = new TaiKhoanSubForm();
                    form.btnThemSaoKe.Visible = true;
                    form.btnThem.Visible = false;
                    form.Show();
                    return;
                }
            }
            TaiKhoanSubForm f = new TaiKhoanSubForm();
            f.btnThemSaoKe.Visible = true;
            f.btnThem.Visible = false;
            f.Show();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (txSTK.Text.Trim() == "")
            {
                MessageBox.Show("Số tài khoản không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                txSTK.Focus();
                return;
            }

            if (dtTuNgay.Text.Trim() == "")
            {
                MessageBox.Show("Ngày bắt đầu không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                dtTuNgay.Focus();
                return;
            }

            if (dtDenNgay.Text.Trim() == "")
            {
                MessageBox.Show("Ngày kết thúc không được để trống!", "Lỗi!", MessageBoxButtons.OK);
                dtTuNgay.Focus();
                return;
            }

            string strLenh = "EXEC SP_SaoKeGD '" + txSTK.Text + "','" + dtTuNgay.Text + "','" + dtDenNgay.Text + "'";            
            DataTable dt = Program.ExecSqlDataTable(strLenh);   
            //DataTable dtall = new DataTable();
            //dtall.Merge(dt);
            //dtall.Merge(dt);
            gcSaoKe.DataSource = dt;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
