using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace Qlks
{
    public partial class inhoadon : Form
    {
        public inhoadon()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        DataTable dt = new DataTable();
        public static int makh;
        private void inhoadon_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            dt = cl.taoreport(makh);
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Tu Tu\Documents\Visual Studio 2013\Projects\Qlks\Qlks\rp.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource newDataSource = new ReportDataSource("ds",dt);
            reportViewer1.LocalReport.DataSources.Add(newDataSource);
            reportViewer1.RefreshReport();
        }
    }
}
