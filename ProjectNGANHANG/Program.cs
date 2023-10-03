using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using NGANHANG.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ProjectNGANHANG
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=LAPTOP-PBBBNCOI;Initial Catalog=NGANHANG;Integrated Security=True";

        public static SqlDataReader myReader;
        public static String severname = "";
        public static String username = "";
        public static String login = "";
        public static String password = "";

        public static String database = "NGANHANG";
        public static String remotelogin = "htkn";
        public static String remotepassword = "123456";
        public static String loginDN = "";
        public static String passwordDN = "";
        public static String Group = "";
        public static String Hoten = "";
        public static int Chinhanh = 0;

        public static BindingSource bds_dspm = new BindingSource();
        public static MainForm mainForm;
        
        
        
        
        public static int KetNoi()
        {
          
            if(Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                Program.connstr = "Data Source=" + Program.severname + ";Initial Catalog=" +
                    Program.database + ";User ID=" +
                    Program.login + ";Password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nKiểm tra lại tài khoản và mật khẩu.\n" + e.Message, "Lỗi", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static int KetNoi_CSDLGOC()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                conn.ConnectionString = Program.connstr_publisher;
                conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu gốc. \nBạn xem lại Tên Server của Publisher, và tên CSDL trong chuỗi kết nối.\n" + e.Message);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (Exception ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strLenh)
        {
            SqlCommand sqlcmd = new SqlCommand(strLenh, conn);
            sqlcmd.CommandType=CommandType.Text;
            sqlcmd.CommandTimeout = 600; //600 giay
            if(conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch(SqlException ex)
            {
                if(ex.Message.Contains("Error converting data type varchar to int"))
                {
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày\" qua kiểu Number hoặc mở File Excel.");
                } else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // hiển thị lỗi gửi từ lệnh RAISERROR trong SQL Sever
            }

        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}
