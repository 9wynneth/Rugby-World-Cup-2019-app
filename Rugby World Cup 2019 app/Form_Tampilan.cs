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
    public partial class Form_Tampilan : Form
    {
        public Form_Tampilan()
        {
            InitializeComponent();
        }
        bool sidebarExpand;

        private void timer_sideMenu_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //minimize
                flowLayoutPanelLeftSideTampilan.Width -= 10;
                if (flowLayoutPanelLeftSideTampilan.Width == flowLayoutPanelLeftSideTampilan.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timer_sideMenu.Stop();
                }
            }
            else
            {
                flowLayoutPanelLeftSideTampilan.Width += 10;
                if (flowLayoutPanelLeftSideTampilan.Width == flowLayoutPanelLeftSideTampilan.MaximumSize.Width)
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

        private void timer_home_Tick(object sender, EventArgs e)
        {
            if (homeShrink)
            {
                pnl_homeContainer.Height += 10;
                if (pnl_homeContainer.Height == pnl_homeContainer.MaximumSize.Height)
                {
                    homeShrink = false;
                    timer_home.Stop();
                }
            }
            else
            {
                pnl_homeContainer.Height -= 10;
                if (pnl_homeContainer.Height == pnl_homeContainer.MinimumSize.Height)
                {
                    homeShrink = true;
                    timer_home.Stop();
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            timer_home.Start();
        }

        bool moreShrink;

        private void timer_more_Tick(object sender, EventArgs e)
        {
            if (moreShrink)
            {
                pnl_moreContainer.Height += 10;
                if (pnl_moreContainer.Height == pnl_moreContainer.MaximumSize.Height)
                {
                    moreShrink = false;
                    timer_more.Stop();
                }
            }
            else
            {
                pnl_moreContainer.Height -= 10;
                if (pnl_moreContainer.Height == pnl_moreContainer.MinimumSize.Height)
                {
                    moreShrink = true;
                    timer_more.Stop();
                }
            }
        }

        private void btn_more_Click(object sender, EventArgs e)
        {
            timer_more.Start();
        }

        private void Form_Tampilan_Load(object sender, EventArgs e)
        {
            hide();
        }

        private void hide()
        {
            show_tournamentStats1.Visible = false;
        }
        private void btn_tournamentStats_Click(object sender, EventArgs e)
        {
            hide();
            show_tournamentStats1.Visible = true;

        }
    }
}
