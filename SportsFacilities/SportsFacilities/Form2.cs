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
    public partial class Form2 : Form
    {
        public string MemberId;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            memberController mc = new memberController();
            List<member1> memlist = mc.GetAllmember();
            this.dataGridView1.DataSource = memlist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.MemberId = this.dataGridView1.CurrentRow.Cells["MemberId"].Value.ToString();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            memberController mc = new memberController();
            List<member1> memlist = mc.GetAllmember();
            this.dataGridView1.DataSource = memlist;
        }
    }
}
