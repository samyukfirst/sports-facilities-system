using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SportsFacilities
{
    public partial class OccupancyReportForm : Form
    {
        public OccupancyReportForm()
        {
            InitializeComponent();
        }

        private void OccupancyReportViewer_Load(object sender, EventArgs e)
        {
            sportsDataSet ds = new sportsDataSet();
            sportsDataSetTableAdapters.occupancyTableAdapter ta = new sportsDataSetTableAdapters.occupancyTableAdapter();
            ta.Fill(ds.occupancy);
            OccupancyCrystalReport cr = new OccupancyCrystalReport();
            cr.SetDataSource(ds);
            OccupancyReportViewer.ReportSource = cr;
        }

       










    }
}
