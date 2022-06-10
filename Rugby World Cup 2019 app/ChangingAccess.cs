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
    public partial class ChangingAccess : UserControl
    {
        public ChangingAccess()
        {
            InitializeComponent();
        }

        private void btn_cont_Click(object sender, EventArgs e)
        {
            Form_Security formAccess = new Form_Security();
            formAccess.username = tBoxUsername.Text;
            formAccess.password = tBoxPass.Text;
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
