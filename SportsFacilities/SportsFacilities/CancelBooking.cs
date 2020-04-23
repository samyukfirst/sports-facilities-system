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
    public partial class CancelBooking : Form
    {
        CancelControl cc;
        string facilityNameSel;
        booking bookingDetails;
        public CancelBooking()
        {
            InitializeComponent();
        }

        public string GetSetFacName
        {
            get
            {
                return facilityNameSel;
            }
            set
            {
                facilityNameSel = value;
            }
        }

        private void memberLookupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BookingIdComboBox.Items.Clear();
                cc = new CancelControl();

                frmMemberLookup memLookUp = new frmMemberLookup();
                memLookUp.collectList = cc.getBookedMembers();
                memLookUp.GetBookingType = "cancel";

                DialogResult r = memLookUp.ShowDialog();
                if (r == System.Windows.Forms.DialogResult.OK)
                {
                    txtMemId.Text = memLookUp.GetMemberId;
                    MemNamelabel.Visible = true;
                    MemNamelabel.Text = memLookUp.GetMemberName;
                    List<booking> bookingIdList = cc.GetBookingIds(Convert.ToInt32(txtMemId.Text));
                    foreach (booking id in bookingIdList)
                    {
                        BookingIdComboBox.Items.Add(id.BookingId);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Are you sure you want to cancel the booking", "CancelBooking", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == System.Windows.Forms.DialogResult.Yes)
                {
                    cc = new CancelControl();
                    bookingDetails = new booking();
                    bookingDetails.BookingId = Convert.ToInt32(BookingIdComboBox.Text);
                    bool UpdateResult = cc.processCancelBooking(bookingDetails);
                    if (UpdateResult)
                    {
                        MessageBox.Show("Booking cancelled");
                    }
                    else
                    {
                        MessageBox.Show("Ensure all the entries are correct");
                    }
                    display();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter all the details to cancel");
            }
        }

        private void getFacilityName(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(BookingIdComboBox.Text);
            facNameTextBox.Text = cc.getFacilityIdAndName(bookId);
            txttimeFrom.Text = cc.getSlotIdAndTime(bookId).StartTime.ToString();
            txtTimeTo.Text = cc.getSlotIdAndTime(bookId).EndTime.ToString();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            cc = new CancelControl();
            cc.viewCancelledBooking();
        }

        private void display()
        {
            txtMemId.Text = "";
            txttimeFrom.Text = "";
            txtTimeTo.Text = "";
            BookingIdComboBox.Items.Clear();
            facNameTextBox.Text = "";
            MemNamelabel.Text = "";

        }

        private void CancelBooking_Load(object sender, EventArgs e)
        {

        }

        




    }
}
