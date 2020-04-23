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
    public partial class BookingReceipt : Form
    {
        int bookId;
        public BookingReceipt()
        {
            InitializeComponent();
        }

        public int GetSetBookingId
        {
            get
            {
                return bookId;
            }
            set
            {
                bookId = value;
            }
        }
        private void BookingReceipt_Load(object sender, EventArgs e)
        {
            SportsDataSet1 ds = new SportsDataSet1();
            SportsDataSet1TableAdapters.bookingreceipt2TableAdapter tab
                = new SportsDataSet1TableAdapters.bookingreceipt2TableAdapter();

            tab.Fill(ds.bookingreceipt2, GetSetBookingId);
            BookingReceiptPrint cr = new BookingReceiptPrint();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }

    }
}
