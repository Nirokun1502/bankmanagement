using ProjectNGANHANG;
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

namespace NGANHANG.Forms
{
    public partial class LoginForm : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();

            
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if(conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cbChinhanh.DataSource = Program.bds_dspm;
            cbChinhanh.DisplayMember = "TENCN";
            cbChinhanh.ValueMember = "TENSERVER";

          
        }


      
        public LoginForm()
        {
            InitializeComponent();
        }

       

       

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            //        Environment.Exit(0);
            //    }
            //    else
            //    {
            //        e.Cancel = true;
            //    }
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu gốc. \nBạn xem lại Tên Server của Publisher, và tên CSDL trong chuỗi kết nối.\n" + e.Message);
                return 0;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM Get_Subscribers");
            cbChinhanh.SelectedIndex = 1;
            cbChinhanh.SelectedIndex = 0;
        }

        private void cbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.severname = cbChinhanh.SelectedValue.ToString();

            }
            catch (Exception) { }

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if( txLogin.Text.Trim() == "" || txPassword.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            Program.login = txLogin.Text;
            Program.password = txPassword.Text;
            if (Program.KetNoi() == 0) return;

            Program.Chinhanh = cbChinhanh.SelectedIndex;
            Program.loginDN = Program.login;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_Lay_Thong_Tin_KH_Tu_Login '" + Program.login + "'";
       
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();



            //MessageBox.Show(Program.myReader[0].ToString());

            if (Program.myReader[1].ToString() == "" )
            {
                Program.myReader.Close();
                strLenh = "EXEC SP_Lay_Thong_Tin_NV_Tu_Login '" + Program.login + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();

                if(Program.myReader[1].ToString() == "")
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "Lỗi", MessageBoxButtons.OK);
                    return;
                }
            }

            //Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            //if (Convert.IsDBNull(Program.username))
            //{
            //    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "Lỗi", MessageBoxButtons.OK);
            //    return;
            //}
            Program.Hoten = Program.myReader.GetString(1);
            Program.Group = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.mainForm.MANV.Text = "Mã: " + Program.username;
            Program.mainForm.HOTEN.Text = "Họ tên: " + Program.Hoten;
            Program.mainForm.NHOM.Text = "Nhóm: " + Program.Group;
            Program.mainForm.HienThiMenu();
            this.Close();
        }
    }
}
