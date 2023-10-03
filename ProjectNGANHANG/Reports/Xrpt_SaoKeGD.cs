//using DevExpress.DataAccess.Native.Data;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;
using DevExpress.DataAccess.Sql.DataApi;
using System.Windows.Forms;
using System.Linq;
using DevExpress.Data.Svg;

namespace ProjectNGANHANG.Reports
{
    public partial class Xrpt_SaoKeGD : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_SaoKeGD()
        {     
            
        }

        public Xrpt_SaoKeGD (string sotk, string tungay, string denngay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = sotk;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = tungay;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = denngay;
            this.sqlDataSource1.Fill();

            ITable src = sqlDataSource1.Result[0];

            DataTable dt = new DataTable();
            foreach (IColumn column in src.Columns)
                dt.Columns.Add(column.Name, column.Type);
            foreach (IRow row in src)
                dt.Rows.Add(row.ToArray());

            lbSoDuDau.Text = dt.Rows[0][0].ToString();
            lbSoDuCuoi.Text = dt.Rows[RowCount - 1][4].ToString();
            
        }






     


    }

    
}
