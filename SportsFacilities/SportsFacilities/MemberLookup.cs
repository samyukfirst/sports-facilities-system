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
    public partial class frmMemberLookup : Form
    {
        SportsAllEntities sports;
        string cancelBook;
        List<member> bm = new List<member>();

        public frmMemberLookup()
        {
            InitializeComponent();
        }



        public string GetMemberId
        {
            get
            {
                return MemberGrid.CurrentRow.Cells["MemberId"].Value.ToString();
            }
        }

        public string GetMemberName
        {
            get
            {
                return MemberGrid.CurrentRow.Cells["MemberName"].Value.ToString();
            }
        }

        public string GetBookingType
        {
            get
            {
                return cancelBook;
            }
            set
            {
                cancelBook = value;
            }
        }



        public List<member> collectList
        {
            get
            {

                return bm;
            }
            set
            {
                bm = value;
            }
        }


        private void frmMemberLookup_Load(object sender, EventArgs e)
        {
            sports = new SportsAllEntities();
            if (GetBookingType.Equals("cancel"))
            {

                var selectAll = collectList;
                MemberGrid.DataSource = selectAll.ToList();
            }
            else
            {
                var selectAll = from x in sports.members orderby x.MemberId select x;
                MemberGrid.DataSource = selectAll.ToList();
            }
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
