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
    public partial class frmBookingFacility : Form
    {
        SportsAllEntities sports;
        booking book;
        facility fac;
        slotvsFacility svf;
        BookingFacilityControl bfc;
        int selectedFacility;

        public frmBookingFacility()
        {
            InitializeComponent();
        }

        public int GetSelectedFacility
        {
            get
            {
                return selectedFacility;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            displayControlValues();
        }

        public void displayControlValues()
        {
            bfc = new BookingFacilityControl();
            txtbookingId.Text = bfc.display();
            txtMemId.Text = "";
            txttimeFrom.Text = "";
            txtTimeTo.Text = "";
            FacilityNamecombobox.Items.Clear();
            MemNamelabel.Visible = false;
            btnSave.Enabled = true;
            List<facility> facilitynames = new List<facility>();
            foreach (facility f in bfc.getFacilities().ToList<facility>())
            {
                FacilityNamecombobox.Items.Add(f.FacilityId + "  " + f.FacilityName);
            }
        }


        private void frmBookingFacility_Load(object sender, EventArgs e)
        {
            sports = new SportsAllEntities();
            book = new booking();
            fac = new facility();
            svf = new slotvsFacility();
            dateOfUseddtp.Value = DateTime.Now.AddDays(1);
        }

        private void memberLookupBtn_Click(object sender, EventArgs e)
        {
            frmMemberLookup memLookUp = new frmMemberLookup();
            memLookUp.GetBookingType = "bookFacility";
            DialogResult r = memLookUp.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                txtMemId.Text = memLookUp.GetMemberId;
                MemNamelabel.Visible = true;
                MemNamelabel.Text = memLookUp.GetMemberName;
            }
        }

        private void slotLookupBtn_Click(object sender, EventArgs e)
        {
            SlotLookUpForm slk = new SlotLookUpForm();
            slk.GetSetFacilitySel = GetSelectedFacility;
            DialogResult r = slk.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                txttimeFrom.Text = slk.GetStartTime;
                txtTimeTo.Text = slk.GetEndTime;
                HiddenSlotIdLabel.Text = slk.GetSlotID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bfc = new BookingFacilityControl();
                sports = new SportsAllEntities();
                book = new booking();
                svf = new slotvsFacility();

                book.BookingId = Convert.ToInt32(txtbookingId.Text);
                book.MemberId = Convert.ToInt32(txtMemId.Text);
                book.FacilityId = GetSelectedFacility;
                book.SlotID = Convert.ToInt32(HiddenSlotIdLabel.Text);
                book.DateOfUse = dateOfUseddtp.Value.ToShortDateString();
                book.WeekdayName = dateOfUseddtp.Value.DayOfWeek.ToString();
                book.confirmed = "Y";
                bfc.saveBooking(book);
                DialogResult r = MessageBox.Show("Do you want a Booking Receipt", "Booking Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == System.Windows.Forms.DialogResult.Yes)
                {
                    bfc.showBookingReceipt(book.BookingId);

                }
                displayControlValues();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FacilityNamecombobox_SelectedValueChanged(object sender, EventArgs e)
        {

            string facilitySelected = FacilityNamecombobox.Text;
            string[] IdName = facilitySelected.Split(' ');
            for (int i = 0; i < 1; i++)
            {
                selectedFacility = Convert.ToInt32(IdName[i]);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewBooking vb = new ViewBooking("Booking");
            DialogResult r = vb.ShowDialog();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            //Print done while saving the record
        }
    }
}
