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
    public partial class LoginForm : Form
    {
         
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            SportsAllEntities context = new SportsAllEntities();

            var q = from x in context.users
                    select x;

            foreach (var x in q)
            {

                if ((x.username == UsernameTextBox.Text) && (x.passwords == PasswordTextBox.Text))
                {
                    LaunchPadForm f = new LaunchPadForm();
                    f.Show();
                    this.Hide();
                }

                else


                    MessageBox.Show("The username or password you entered is incorrect");

            }

        }

    }
}
