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
    public partial class SlotLookUpForm : Form
    {
        SportsAllEntities sports;
        facility fac;
        int SelFac;
        public SlotLookUpForm()
        {
            InitializeComponent();

        }

        public int GetSetFacilitySel
        {
            get
            {
                return SelFac;
            }
            set
            {
                SelFac = value;
            }
        }
        public string GetStartTime
        {
            get
            {
                return SlotGrid.CurrentRow.Cells["StartTime"].Value.ToString();
            }
        }

        public string GetEndTime
        {
            get
            {
                return SlotGrid.CurrentRow.Cells["EndTime"].Value.ToString();
            }
        }

        public string GetSlotID
        {
            get
            {
                return SlotGrid.CurrentRow.Cells["SlotId"].Value.ToString();
            }
        }

        private void SlotLookUpForm_Load(object sender, EventArgs e)
        {


            sports = new SportsAllEntities();
            fac = new facility();

            var selectAll = from f in sports.facilities
                            join svsf in sports.slotvsFacilities on f.FacilityId equals svsf.FacilityId
                            where svsf.Available == "Y" && svsf.FacilityId == SelFac
                            join s in sports.slots on svsf.SlotId equals s.SlotId
                            select new { s.SlotId, s.StartTime, s.EndTime };

            SlotGrid.DataSource = selectAll.ToList();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
