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
    public partial class MembersReport : Form
    {
        public MembersReport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sportsDataSet ds = new sportsDataSet();
            sportsDataSetTableAdapters.membersTableAdapter ta = new sportsDataSetTableAdapters.membersTableAdapter();
            ta.Fill(ds.members);
            MemberInfoCrystalReport cr = new MemberInfoCrystalReport();
            cr.SetDataSource(ds);
            MembersReportViewer.ReportSource = cr;
            
        }
    }
}
