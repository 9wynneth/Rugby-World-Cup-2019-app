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
            show_stadium1.Visible = false;
            show_Referee1.Visible = false;
            show_Team1.Visible = false;
            show_Player1.Visible = false;
            show_Matches1.Visible = false;
            show_MorePlayerStats1.Visible = false;
            show_MoreTeamStats1.Visible = false;
        }
        private void btn_tournamentStats_Click(object sender, EventArgs e)
        {
            hide();
            NormalColor();
            show_tournamentStats1.Visible = true;
            btn_tournamentStats.BackColor = Color.FromArgb(131, 65, 164);

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Intro formIntro = new Form_Intro();
            formIntro.Show();
        }
        private void NormalColor()
        {
            btn_stadium.BackColor = Color.FromArgb(123, 51, 144);
            btn_referee.BackColor = Color.FromArgb(123, 51, 144);
            btn_team.BackColor = Color.FromArgb(123, 51, 144);
            btn_player.BackColor = Color.FromArgb(123, 51, 144);
            btn_tournamentStats.BackColor = Color.FromArgb(123, 51, 144);
            btn_match.BackColor = Color.FromArgb(123, 51, 144);
            btn_morePlayers.BackColor = Color.FromArgb(123, 51, 144);
            btn_moreTeams.BackColor = Color.FromArgb(123, 51, 144);

        }

        private void btn_stadium_Click(object sender, EventArgs e)
        {
            hide();
            NormalColor();
            show_stadium1.Visible = true;
            btn_stadium.BackColor = Color.FromArgb(131, 65, 164);
        }

        private void btn_referee_Click(object sender, EventArgs e)
        {
            hide();
            NormalColor();
            show_Referee1.Visible = true;
            btn_referee.BackColor = Color.FromArgb(131, 65, 164);
        }

        private void btn_team_Click(object sender, EventArgs e)
        {
            hide();
            NormalColor();
            show_Team1.Visible = true;
            btn_team.BackColor = Color.FromArgb(131, 65, 164);
        }

        private void btn_player_Click(object sender, EventArgs e)
        {
            hide();
            NormalColor();
            show_Player1.Visible = true;
            btn_player.BackColor = Color.FromArgb(131, 65, 164);
        }

        private void btn_match_Click(object sender, EventArgs e)
        {
            hide();
            NormalColor();
            show_Matches1.Visible = true;
            btn_match.BackColor = Color.FromArgb(131, 65, 164);
        }

        private void btn_morePlayers_Click(object sender, EventArgs e)
        {
            hide();
            NormalColor();
            show_MorePlayerStats1.Visible = true;
            btn_morePlayers.BackColor = Color.FromArgb(131, 65, 164);
        }

        private void btn_moreTeams_Click(object sender, EventArgs e)
        {
            hide();
            NormalColor();
            show_MoreTeamStats1.Visible = true;
            btn_moreTeams.BackColor = Color.FromArgb(131, 65, 164);
        }
    }
}
