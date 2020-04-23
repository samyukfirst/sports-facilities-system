using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SportsFacilities
{
    public partial class OccupancyChartForm : Form
    {
        public OccupancyChartForm()
        {
            InitializeComponent();
        }

        private void OccupancyChartViewer_Load(object sender, EventArgs e)
        {
            sportsDataSet ds = new sportsDataSet();
            sportsDataSetTableAdapters.occupancyTableAdapter ta = new sportsDataSetTableAdapters.occupancyTableAdapter();
            ta.Fill(ds.occupancy);
            OccupancyChartReport cr = new OccupancyChartReport();
            cr.SetDataSource(ds);
            OccupancyChartViewer.ReportSource = cr;
        }

        


    }
}
