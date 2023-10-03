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
    public partial class TaiKhoanSubForm : Form
    {
        public TaiKhoanSubForm()
        {
            InitializeComponent();
        }

        //private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.taiKhoanBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dS2);

        //}

        private void TaiKhoanSubForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS2.TaiKhoan' table. You can move, or remove it, as needed.
            DS2.EnforceConstraints = false;
            this.TKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.TKTableAdapter.Fill(this.DS2.TaiKhoan);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {  

            string sotk = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();

            if(MainForm.CheckExitedForm("GoiRutForm") && MainForm.GRForm.numbtn.Text == "1")
            {
                MainForm.GRForm.numbtn.Text = "";
                MainForm.GRForm.txSTK1.Text = sotk;
                this.Close();
                return;
            }

            if (MainForm.CheckExitedForm("ChuyenTienForm") && MainForm.CTForm.numbtn.Text == "1")
            {
                MainForm.CTForm.numbtn.Text = "";
                MainForm.CTForm.txSTK1.Text = sotk;

                if (MainForm.CTForm.txSTK1.Text == MainForm.CTForm.txSTK2.Text)
                {
                    MessageBox.Show("Số tài khoản chuyển không được trùng với số tài khỏan nhận!", "Lỗi", MessageBoxButtons.OK);
                    MainForm.CTForm.txSTK1.Text = "";
                    this.Close();
                    return;
                }
                this.Close();
                return;
            }

            if (MainForm.CheckExitedForm("ChuyenTienForm") && MainForm.CTForm.numbtn.Text == "2")
            {
                MainForm.CTForm.numbtn.Text = "";
                MainForm.CTForm.txSTK2.Text = sotk;

                if (MainForm.CTForm.txSTK1.Text == MainForm.CTForm.txSTK2.Text)
                {
                    MessageBox.Show("Số tài khoản chuyển không được trùng với số tài khỏan nhận!", "Lỗi", MessageBoxButtons.OK);
                    MainForm.CTForm.txSTK2.Text = "";
                    this.Close();
                    return;
                }
                this.Close();
                return;
            }
            

            this.Close();
            return;
        }

        private void btnReload_Click(object sender, EventArgs e)
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

        private void btnThemSaoKe_Click(object sender, EventArgs e)
        {
            string sotk = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();
            MainForm.SKForm.txSTK.Text = sotk;
            this.Close();
        }
    }
}
