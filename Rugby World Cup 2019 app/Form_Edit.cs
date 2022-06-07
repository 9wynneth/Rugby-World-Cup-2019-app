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
    public partial class Form_Edit : Form
    {
        Form_Security formAccess = new Form_Security();
        FormChange formChange = new FormChange();
        public Form_Edit()
        {
            InitializeComponent();
            formChange.FormClosing += formChange_FormClosing;
        }

      

        private void Form_Edit_Load(object sender, EventArgs e)
        {
            hide();

        }

 

        void formChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formChange.checker==true)
            {
                changingAccess2.Visible = true;
            }
            
        }

        private void hide()
        {
            changingAccess2.Visible = false;
            edit_team1.Visible = false;
            edit_player1.Visible = false;
            edit_match1.Visible = false;
            edit_matchDetail1.Visible = false;
            edit_manager1.Visible = false;
            edit_referee1.Visible = false;

        }

        bool sidebarExpand;

        private void timer_sideMenu_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //minimize
                flowLayoutPanelLeftSide.Width -= 10;
                if (flowLayoutPanelLeftSide.Width == flowLayoutPanelLeftSide.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timer_sideMenu.Stop();
                }
            }
            else
            {
                flowLayoutPanelLeftSide.Width += 10;
                if (flowLayoutPanelLeftSide.Width == flowLayoutPanelLeftSide.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timer_sideMenu.Stop();
                }
            }
        }

        private void picBox_menu_Click(object sender, EventArgs e)
        {
            timer_sideMenu.Start();
        }

        bool homeShrink;

        private void timer_edit_Tick(object sender, EventArgs e)
        {
            if (homeShrink)
            {
                pnl_editContainer.Height += 10;
                if (pnl_editContainer.Height == pnl_editContainer.MaximumSize.Height)
                {
                    homeShrink = false;
                    timer_edit.Stop();
                }
            }
            else
            {
                pnl_editContainer.Height -= 10;
                if (pnl_editContainer.Height == pnl_editContainer.MinimumSize.Height)
                {
                    homeShrink = true;
                    timer_edit.Stop();
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            timer_edit.Start();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            timer_setting.Start();
        }

        bool settingShrink;
        private void timer_setting_Tick(object sender, EventArgs e)
        {
            if (settingShrink)
            {
                pnl_settingContainer.Height += 10;
                if (pnl_settingContainer.Height == pnl_settingContainer.MaximumSize.Height)
                {
                    settingShrink = false;
                    timer_setting.Stop();
                }
            }
            else
            {
                pnl_settingContainer.Height -= 10;
                if (pnl_settingContainer.Height == pnl_settingContainer.MinimumSize.Height)
                {
                    settingShrink = true;
                    timer_setting.Stop();
                }
            }
        }

        private void btn_chngUsername_Click(object sender, EventArgs e)
        {
            formChange.ShowDialog();
        }

        private void changingAccess2_Load(object sender, EventArgs e)
        {

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_team_Click(object sender, EventArgs e)
        {
            edit_team1.Visible = true;
        }

        private void edit_player1_Load(object sender, EventArgs e)
        {

        }

        private void btn_player_Click(object sender, EventArgs e)
        {
            edit_player1.Visible = true;
        }

        private void btn_match_Click(object sender, EventArgs e)
        {
            edit_match1.Visible = true;
        }

        private void btn_matchDetail_Click(object sender, EventArgs e)
        {
            edit_matchDetail1.Visible = true;
        }

        private void btn_referee_Click(object sender, EventArgs e)
        {
           
            edit_referee1.Visible = true;
        }

        private void btn_manager_Click(object sender, EventArgs e)
        {
            edit_manager1.Visible = true;
        }
    }
}
