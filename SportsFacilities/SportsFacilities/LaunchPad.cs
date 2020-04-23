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
    public partial class LaunchPadForm : Form
    {
        frmFacility form1;
        SearchFacilityForm form2;
        MembersReport form3;
        Maintain form4;
        OccupancyReportForm form5;
        OccupancyChartForm form6;
        BookingReceipt form7;
        frmBookingFacility form8;
        CancelBooking form9;


        public LaunchPadForm()
        {
            InitializeComponent();
        }
        private void MembersMenu_Click(object sender, EventArgs e)
        {
            form4 = new Maintain();
            form4.MdiParent = this;
            form4.Show();

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2 = new SearchFacilityForm();
            form2.MdiParent = this;
            form2.Show();

        }

        private void ListOfMembersMenu_Click(object sender, EventArgs e)
        {
            form3 = new MembersReport();
            form3.MdiParent = this;
            form3.Show();

        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FacilitiesMenu_Click(object sender, EventArgs e)
        {
            form1 = new frmFacility();
            form1.MdiParent = this;
            form1.Show();
        }    

       

        private void viewChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form6 = new OccupancyChartForm();
            form6.MdiParent = this;
            form6.Show();
        }

        private void viewRateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form5 = new OccupancyReportForm();
            form5.MdiParent = this;
            form5.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bookingReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //form7 = new BookingReceipt();
            //form7.MdiParent = this;
            //form7.Show();
        }

        private void MakeNewBookingMenu_Click(object sender, EventArgs e)
        {
            form8 = new frmBookingFacility();
            form8.MdiParent = this;
            form8.Show();
        }

        private void CancelBookingMenu_Click(object sender, EventArgs e)
        {
            form9 = new CancelBooking();
            form9.MdiParent = this;
            form9.Show();
        }

       


    }
}
