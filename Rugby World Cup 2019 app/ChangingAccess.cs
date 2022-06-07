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
        }
    }
}
