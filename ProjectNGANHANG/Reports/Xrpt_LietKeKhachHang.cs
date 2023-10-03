using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ProjectNGANHANG.Reports
{
    public partial class Xrpt_LietKeKhachHang : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_LietKeKhachHang()
        {

        }

        public Xrpt_LietKeKhachHang(int type)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = type;
            this.sqlDataSource1.Fill();
        }
    }
}
