using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Rugby_World_Cup_2019_app
{
    public partial class Show_Team : UserControl
    {
        public Show_Team()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtTeam = new DataTable();

        private void Show_Team_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");
            sqlQuery = $"SELECT t.team_id, t.team_name, t.world_ranking, (SELECT m.manager_name from manager m where t.manager_id = m.manager_id) as MANAGER, (SELECT m.manager_name from manager m where t.assmanager_id = m.manager_id) as 'ASSISTANT MANAGER', (SELECT m.manager_id from manager m where t.manager_id = m.manager_id) as MANAGERID, t.assmanager_id as ASSID FROM team t; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            listOfTeam();
        }

        private void listOfTeam()
        {
            List<Panel> teamList = new List<Panel>();
            for (int i = 0; i <= dtTeam.Rows.Count - 1; i++)
            {
                Label teamID = new Label();
                teamID.Text = dtTeam.Rows[i][0].ToString();
                teamID.Location = new Point(10, teamID.Location.Y + 5);
                teamID.BackColor = Color.Transparent;
                teamID.ForeColor = Color.White;

                Label teamName = new Label();
                teamName.Text = dtTeam.Rows[i][1].ToString();
                teamName.Location = new Point(10, teamName.Location.Y+35);
                teamName.BackColor = Color.Transparent;
                teamName.ForeColor = Color.White;

                Label teamRank = new Label();
                teamRank.Text = dtTeam.Rows[i][2].ToString();
                teamRank.Location = new Point(10, teamName.Location.Y+30);
                teamRank.BackColor = Color.Transparent;
                teamRank.ForeColor = Color.White;
                teamRank.Font = new Font("Arial", 12, FontStyle.Regular);


                Label lbl_wordManager = new Label();
                lbl_wordManager.Text = "MANAGER:";
                lbl_wordManager.Location = new Point(200, teamID.Location.Y);
                lbl_wordManager.BackColor = Color.Transparent;
                lbl_wordManager.ForeColor = Color.White;

                Label teamManager = new Label();
                teamManager.Text = dtTeam.Rows[i][3].ToString();
                teamManager.Location = new Point(200, lbl_wordManager.Location.Y + 15);
                teamManager.BackColor = Color.Transparent;
                teamManager.ForeColor = Color.White;

                PictureBox managerPic = new PictureBox();
                managerPic.Name = "picBox_referee" + i;
                managerPic.Size = new Size(80, 80);
                managerPic.Location = new Point(200, teamManager.Location.Y + 10);
                string managerID = dtTeam.Rows[i][5].ToString();
                string picManager = $"Manager_{managerID}.png";
                object getPicManager = Properties.Resources.ResourceManager.GetObject(picManager); 
                managerPic.Image = (Image)getPicManager;
                managerPic.BackColor = Color.Transparent;
                managerPic.SizeMode = PictureBoxSizeMode.StretchImage;


                Label lbl_wordAss = new Label();
                lbl_wordAss.Text = "ASSISTANT:";
                lbl_wordAss.Location = new Point(300, lbl_wordManager.Location.Y);
                lbl_wordAss.BackColor = Color.Transparent;
                lbl_wordAss.ForeColor = Color.White;


                Label teamAssManager = new Label();
                teamAssManager.Text = dtTeam.Rows[i][4].ToString();
                teamAssManager.Location = new Point(300, lbl_wordAss.Location.Y+15);
                teamAssManager.BackColor = Color.Transparent;
                teamAssManager.ForeColor = Color.White;


                Panel pnl_teamList = new Panel();
                pnl_teamList.Name = "pnl_referee" + i;
                teamList.Add(pnl_teamList);
                pnl_teamList.Location = new Point(80, i * 100 + 30);
                pnl_teamList.Size = new Size(450, 90);
                pnl_teamList.Controls.Add(teamID);
                pnl_teamList.Controls.Add(teamName);
                pnl_teamList.Controls.Add(teamRank);
                pnl_teamList.Controls.Add(teamAssManager);
                pnl_teamList.Controls.Add(teamManager);
                pnl_teamList.Controls.Add(lbl_wordAss);
                pnl_teamList.Controls.Add(lbl_wordManager);
             
                pnl_teamList.BackgroundImage = Properties.Resources.image_2_;

                this.Controls.Add(pnl_teamList);
            }
        }
    }
}
