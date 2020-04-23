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
    public partial class Maintain : Form
    {
        public Maintain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            memberController mc = new memberController();
            this.textBox1.Text = Convert.ToString(mc.GetAllmember().Count() + 1);
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.radioButton1.Checked = false;
            this.radioButton2.Checked = false;
            this.dateTimePicker1.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            memberController mc = new memberController();
            if (this.textBox1.Text == Convert.ToString(mc.GetAllmember().Count() + 1))
            {
                member1 newmember = new member1();
                newmember.MemberId = Convert.ToInt32(this.textBox1.Text);
                newmember.MemberName = this.textBox2.Text;
                string G = "";
                if (this.radioButton1.Checked)
                {
                    G = "M";
                }
                else
                {
                    G = "F";
                }
                newmember.Gender = G;
                newmember.DateOfBirth = this.dateTimePicker1.Value.Date.ToString();
                newmember.Address1 = this.textBox3.Text;
                newmember.Phone = this.textBox4.Text;

                mc.Addmember(newmember);

                MessageBox.Show("saved");
                button1_Click(null, null);

            }
            else
            {
                member1 a = mc.Getmember(Convert.ToInt32(this.textBox1.Text));

                a.MemberName = this.textBox2.Text;
                string G = "";
                if (this.radioButton1.Checked)
                {
                    G = "M";
                }
                else
                {
                    G = "F";
                }
                a.Gender = G;
                a.DateOfBirth = this.dateTimePicker1.Value.Date.ToString();
                a.Address1 = this.textBox3.Text;
                a.Phone = this.textBox4.Text;

                mc.ModifymemberInfo(a);

                MessageBox.Show("update successfully");
                button1_Click(null, null);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            DialogResult dia_result = f2.ShowDialog();

            if (dia_result == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox1.Text = f2.MemberId;
                memberController mc = new memberController();
                mc.Getmember(Convert.ToInt32(this.textBox1.Text));
                this.textBox2.Text = mc.Getmember(Convert.ToInt32(this.textBox1.Text)).MemberName;
                if (mc.Getmember(Convert.ToInt32(this.textBox1.Text)).Gender == "M")
                {
                    this.radioButton1.Checked = true;
                }
                else
                {
                    this.radioButton2.Checked = true;
                }
                // IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
                // DateTime dt2 = DateTime.Parse(mc.GetMember(Convert.ToInt32(this.textBox1.Text)).DateOfBirth, culture, System.Globalization.DateTimeStyles.AssumeLocal);
                //this.dateTimePicker1.Value = dt2;
                this.dateTimePicker1.Value = Convert.ToDateTime(mc.Getmember(Convert.ToInt32(this.textBox1.Text)).DateOfBirth);
                this.textBox3.Text = mc.Getmember(Convert.ToInt32(this.textBox1.Text)).Address1;
                this.textBox4.Text = mc.Getmember(Convert.ToInt32(this.textBox1.Text)).Phone;
            }
            f2.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            memberController mc = new memberController();
            mc.Deletemember(Convert.ToInt32(this.textBox1.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maintain_Load(object sender, EventArgs e)
        {

        }
    }
}
