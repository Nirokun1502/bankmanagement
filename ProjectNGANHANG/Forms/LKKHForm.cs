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
    public partial class LKKHForm : Form
    {   
        

        public LKKHForm()
        {
            InitializeComponent();
        }

        private void LKKHForm_Load(object sender, EventArgs e)
        {
            string strLenh = "EXEC SP_LietKeKhachHang";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            gcLKKH.DataSource = dt;

           
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            string strLenh = "EXEC SP_LietKeKhachHang";
            DataTable dt = Program.ExecSqlDataTable(strLenh);
            gcLKKH.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
