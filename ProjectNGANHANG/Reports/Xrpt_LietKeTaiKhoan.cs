using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ProjectNGANHANG.Reports
{
    public partial class Xrpt_LietKeTaiKhoan : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_LietKeTaiKhoan()
        {
            
        }

        public Xrpt_LietKeTaiKhoan(int type, string tungay, string denngay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = type;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = tungay;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = denngay;
            this.sqlDataSource1.Fill();

        }
    }
}
