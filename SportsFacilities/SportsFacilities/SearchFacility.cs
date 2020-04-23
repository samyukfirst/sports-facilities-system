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
    public partial class SearchFacilityForm : Form
    {
        SportsAllEntities context ;
        SearchFacilityForm f;
       
        public SearchFacilityForm()
        {
            InitializeComponent();
        }

        private void FacilityNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            context= new SportsAllEntities();
            FacilityNameComboBox.Items.Clear();

            var records = from x in context.facilities
                          select x;

            foreach (facility f in records.ToList())
            {
                FacilityNameComboBox.Items.Add(f.FacilityName);
            }

         
        }

        private void CheckAvailabilityButton_Click(object sender, EventArgs e)
        {
            context = new SportsAllEntities();
            FacilityNameComboBox.Items.Clear();
            string facname = FacilityNameComboBox.Text;

          

            var records = from s in context.slots
                          join sf in context.slotvsFacilities
                          on
                          s.SlotId equals sf.SlotId
                          where sf.Available=="Y" 


                          join f in context.facilities on sf.FacilityId equals f.FacilityId
                          where f.FacilityName==facname
                          select new {s.SlotId, s.StartTime, s.EndTime};

                         

            SearchDataGrid.DataSource = records.ToList();
        }

        private void SearchCloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //var selectAll = from f in sports.facilities
        //                join svsf in sports.slotvsFacilities on f.FacilityId equals svsf.FacilityId
        //                where svsf.Available == "Y" && svsf.FacilityId == SelFac
        //                join s in sports.slots on svsf.SlotId equals s.SlotId
        //                select new { s.SlotId, s.StartTime, s.EndTime };




    }
}
