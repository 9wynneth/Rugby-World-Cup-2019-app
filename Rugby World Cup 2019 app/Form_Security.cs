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
    public partial class Form_Security : Form
    {
        public Form_Security()
        {
            InitializeComponent();
        }

        public string username = "rwc2019db";
        public string password = "ALPFINALPROJECT";


        private void Form_Security_Load(object sender, EventArgs e)
        {

        }

        public void tBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (tBoxUsername.Text == username)
            {
                errorUsername.Clear();
                tBoxPass.Enabled = true;
                btn_cont.Enabled = true;
            }
            else
            {
                errorUsername.SetError(this.tBoxUsername, "Invalid username");
                tBoxPass.Enabled = false;
                btn_cont.Enabled = false;
                return;
            }
        }


        public void tBoxPass_TextChanged(object sender, EventArgs e)
        {
            if (tBoxPass.Text == password)
            {
                errorUsername.Clear();

            }
            else
            {
                errorUsername.SetError(this.tBoxPass, "Incorrect password");
            }
        }

 

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cont_Click(object sender, EventArgs e)
        {
            if (tBoxUsername.Text != username)
            {
                MessageBox.Show("Username and password are required!");
            }
            else if (tBoxPass.Text != password)
            {
                MessageBox.Show("Password is incorrect!");
            }
            else
            {
                this.Hide();
                this.Close();
                Form_Edit formEdit = new Form_Edit();
                formEdit.ShowDialog();
            }
        }
    }
}
