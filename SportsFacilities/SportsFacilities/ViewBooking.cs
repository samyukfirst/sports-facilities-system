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
    public partial class ViewBooking : Form
    {
        SportsAllEntities sports;
        string cancelBook;
        List<CancelledBooking> cb;
        public ViewBooking()
        {
            InitializeComponent();
        }

        public ViewBooking(string cancel)
        {
            InitializeComponent();
            this.cancelBook = cancel;
        }

        public List<CancelledBooking> collectList
        {
            get
            {
                cb = new List<CancelledBooking>();
                return cb;
            }
            set
            {
                cb = value;
            }
        }

        private void ViewBooking_Load(object sender, EventArgs e)
        {
            sports = new SportsAllEntities();

            if (cancelBook.Equals("Cancel"))
            {
                bookingGrid.DataSource = cb;
            }
            else
            {
                var selectAll = from x in sports.CurrentBookings select x;
                bookingGrid.DataSource = selectAll.ToList();
            }
            bookingGrid.Columns[0].HeaderText = "Booking Id";
            bookingGrid.Columns[1].HeaderText = "Member Name";
            bookingGrid.Columns[2].HeaderText = "Start Time";
            bookingGrid.Columns[3].HeaderText = "End Time";
            bookingGrid.Columns[4].HeaderText = "Facility Name";
            bookingGrid.Columns[5].HeaderText = "Date Of Use";

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }
}
