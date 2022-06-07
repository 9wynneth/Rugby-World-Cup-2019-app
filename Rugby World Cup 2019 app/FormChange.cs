using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rugby_World_Cup_2019_app
{
    public partial class FormChange : Form
    {
        public FormChange()
        {
            InitializeComponent();
        }


        public string username = "rwc2019db";
        public string password = "ALPFINALPROJECT";
        public bool checker = false;

        private void FormChange_Load(object sender, EventArgs e)
        {

        }

        private void tBoxUsernameChng_TextChanged(object sender, EventArgs e)
        {
            if (tBoxUsernameChng.Text == username)
            {
                errorUsernameChng.Clear();
                tBoxPassChng.Enabled = true;
                btn_contChng.Enabled = true;
            }
            else
            {
                errorUsernameChng.SetError(this.tBoxUsernameChng, "Invalid username");
                tBoxPassChng.Enabled = false;
                btn_contChng.Enabled = false;
                return;
            }
        }

        private void tBoxPassChng_TextChanged(object sender, EventArgs e)
        {
            if (tBoxPassChng.Text == password)
            {
                errorUsernameChng.Clear();

            }
            else
            {
                errorUsernameChng.SetError(this.tBoxPassChng, "Incorrect password");
            }
        }

        private void btn_backChng_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_contChng_Click(object sender, EventArgs e)
        {
            if (tBoxUsernameChng.Text != username)
            {
                MessageBox.Show("Username and password are required!");
            }
            else if (tBoxPassChng.Text != password)
            {
                MessageBox.Show("Password is incorrect!");
            }
            else
            {
                checker = true;
                this.Hide();
                this.Close();
                
            }
        }
    }
}
