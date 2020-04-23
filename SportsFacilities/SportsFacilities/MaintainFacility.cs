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
    public partial class frmFacility : Form
    {
        SportsAllEntities sports;
        facility fac;
        slotvsFacility svf;
        slotvsFacility svfDel;
        public frmFacility()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            display();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Facility entity class created by entity framework 
                if (txtFacName.Text == "")
                {
                    MessageBox.Show("Please enter all the fields to save");
                }
                else
                {
                    fac.FacilityId = Convert.ToInt32(txtFacilityId.Text);
                    fac.FacilityName = txtFacName.Text;
                    //DB Table name 'facilities'
                    sports.facilities.AddObject(fac);
                    var insSlotVsFacility = from x in sports.slots select x;
                    foreach (slot sf in insSlotVsFacility.ToList())
                    {
                        svf = new slotvsFacility();
                        svf.FacilityId = fac.FacilityId;
                        svf.SlotId = sf.SlotId;
                        svf.Available = "Y";
                        sports.slotvsFacilities.AddObject(svf);
                    }

                    sports.SaveChanges();

                    display();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmFacility_Load(object sender, EventArgs e)
        {
            sports = new SportsAllEntities();
            fac = new facility();
            svfDel = new slotvsFacility();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewFacilities vc = new ViewFacilities();
            DialogResult r = vc.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                txtFacilityId.Text = vc.GetFacilityId;
                txtFacName.Text = vc.GetFacilityName;
            }
            vc.Dispose();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
        }



        public void display()
        {
            var selectId = from x in sports.facilities orderby x.FacilityId descending select x;
            facility f = selectId.First<facility>();

            txtFacilityId.Text = (f.FacilityId + 1).ToString();
            txtFacName.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sports = new SportsAllEntities();
            int facId = Convert.ToInt32(txtFacilityId.Text);
            fac = new facility();
            var facilityUpdate = from x in sports.facilities
                                 where x.FacilityId == facId
                                 select x;
            fac = facilityUpdate.First<facility>();
            fac.FacilityName = txtFacName.Text;
            sports.SaveChanges();
            display();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //DialogResult r=MessageBox.Show("Are you sure you want to Deactivate", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //if (r == DialogResult.Yes)
            //{
            //    int facilityId = Convert.ToInt32(txtFacilityId.Text);
            //    var delRec = from facAlias in sports.facilities
            //                 where facAlias.FacilityId == facilityId
            //                 select facAlias;
            //    fac = delRec.First<facility>();

            //    var insSlotVsFacility = from x in sports.slotvsFacilities 
            //                            where x.FacilityId == facilityId 
            //                            select x;

            //   // slotvsFacility esf = insSlotVsFacility.First<slotvsFacility>();

            //    foreach (slotvsFacility esf in insSlotVsFacility.ToList<slotvsFacility>())
            //    {
            //        svfDel = new slotvsFacility();
            //        svfDel.FacilityId = esf.FacilityId;
            //        svfDel.SlotId = esf.SlotId;
            //        svfDel.Available = esf.Available;
            //        sports.slotvsFacilities.DeleteObject(svfDel);
            //    }

            //    sports.SaveChanges();
            //    display();
            //}
        }
    }
}
/*  Delete code not needed         
/*  //Cannot add a new column to the existing entity sports.edmx 
 * 
         public void delete()
        {
            DialogResult r = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes)
            {
                int facilityId = Convert.ToInt32(txtFacilityId.Text);
                var delRec = from facAlias in sports.facilities
                             where facAlias.FacilityId == facilityId
                             select facAlias;
                fac = delRec.First<facility>();

                //sports.slotvsFacilities.DeleteObject(svf);


                sports.facilities.DeleteObject(fac);
                var insSlotVsFacility = from x in sports.slotvsFacilities
                                        where x.FacilityId == facilityId
                                        select x;

                // slotvsFacility esf = insSlotVsFacility.First<slotvsFacility>();

                foreach (slotvsFacility esf in insSlotVsFacility.ToList<slotvsFacility>())
                {
                    svfDel = new slotvsFacility();
                    svfDel.FacilityId = esf.FacilityId;
                    svfDel.SlotId = esf.SlotId;
                    svfDel.Available = esf.Available;
                    sports.slotvsFacilities.DeleteObject(svfDel);
                }

                sports.SaveChanges();
                display();
            }
        }*/
