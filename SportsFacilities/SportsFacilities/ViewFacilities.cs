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
    public partial class ViewFacilities : Form
    {
        SportsAllEntities sports;
        facility fac;

        public ViewFacilities()
        {
            InitializeComponent();
        }

        public string GetFacilityId
        {
            get
            {
                return FacilityGrid.CurrentRow.Cells["FacilityId"].Value.ToString();
            }
        }

        public string GetFacilityName
        {
            get
            {
                return FacilityGrid.CurrentRow.Cells["FacilityName"].Value.ToString();
            }
        }

        private void ViewFacilities_Load(object sender, EventArgs e)
        {
            sports = new SportsAllEntities();
            fac = new facility();
            var selectAll = from x in sports.facilities orderby x.FacilityId select x;
            FacilityGrid.DataSource = selectAll.ToList();
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
