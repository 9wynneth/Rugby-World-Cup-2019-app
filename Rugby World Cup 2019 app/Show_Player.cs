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
    public partial class Show_Player : UserControl
    {
        public Show_Player()
        {
            InitializeComponent();
        }


        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtPlayer = new DataTable();

        private void Show_Player_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");
            sqlQuery = $"SELECT p.player_id as ID, p.player_name as 'Player Name', Concat('From: ',n.country_name) as 'Nationality',  t.team_name as 'Team Name', p.player_position as Position, p.height as height, p.weight as weight, p.birthdate as birthdate FROM player p, nationality n, team t WHERE p.team_id = t.team_id and n.nationality_id = p.nationality_id and p.status_player = 'Yes'; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            listOfPlayer();
            
        }

        private void listOfPlayer()
        {
            List<Panel> playerList = new List<Panel>();
            for (int i = 0; i <= dtPlayer.Rows.Count - 1; i++)
            {
                Label playerID = new Label();
                playerID.Text = dtPlayer.Rows[i][0].ToString();
                playerID.Location = new Point(10, playerID.Location.Y + 5);
                playerID.BackColor = Color.Transparent;
                playerID.ForeColor = Color.White;


                Label playerName = new Label();
                playerName.Text = dtPlayer.Rows[i][1].ToString();
                playerName.Location = new Point(10, playerName.Location.Y + 35);
                playerName.BackColor = Color.Transparent;
                playerName.ForeColor = Color.White;

                Label playerNationality = new Label();
                playerNationality.Text = dtPlayer.Rows[i][2].ToString();
                playerNationality.Location = new Point(10, playerName.Location.Y + 30);
                playerNationality.BackColor = Color.Transparent;
                playerNationality.ForeColor = Color.White;
 

                Label playerTeam = new Label();
                playerTeam.Text = dtPlayer.Rows[i][3].ToString().ToUpper();
                playerTeam.Location = new Point(190, playerName.Location.Y + 30);
                playerTeam.BackColor = Color.Transparent;
                playerTeam.ForeColor = Color.White;

                Label playerPosition = new Label();
                playerPosition.Text = $"Player position: {dtPlayer.Rows[i][4]}";
                playerPosition.Location = new Point(180, playerID.Location.Y + 5);
                playerPosition.BackColor = Color.Transparent;
                playerPosition.ForeColor = Color.White;

                Label playerBirthdate = new Label();
                playerBirthdate.Text = $"Birth: {dtPlayer.Rows[i][7]}";
                playerBirthdate.Location = new Point(180, playerName.Location.Y );
                playerBirthdate.BackColor = Color.Transparent;
                playerBirthdate.ForeColor = Color.White;

                Label playerHeight = new Label();
                playerHeight.Text = $"Height: {dtPlayer.Rows[i][5]} cm";
                playerHeight.Location = new Point(350, playerID.Location.Y + 5);
                playerHeight.BackColor = Color.Transparent;
                playerHeight.ForeColor = Color.White;


                Label playerWeight = new Label();
                playerWeight.Text = $"Weight: {dtPlayer.Rows[i][6]} kg";
                playerWeight.Location = new Point(350, playerName.Location.Y );
                playerWeight.BackColor = Color.Transparent;
                playerWeight.ForeColor = Color.White;

                Panel pnl_playerList = new Panel();
                pnl_playerList.Name = "pnl_team" + i;
                playerList.Add(pnl_playerList);
                pnl_playerList.Location = new Point(80, i * 100 + 30);
                pnl_playerList.Size = new Size(450, 90);
                pnl_playerList.Controls.Add(playerID);
                pnl_playerList.Controls.Add(playerName);
                pnl_playerList.Controls.Add(playerNationality);
                pnl_playerList.Controls.Add(playerTeam);
                pnl_playerList.Controls.Add(playerPosition);
                pnl_playerList.Controls.Add(playerBirthdate);
                pnl_playerList.Controls.Add(playerHeight);
                pnl_playerList.Controls.Add(playerWeight);
            

                pnl_playerList.BackgroundImage = Properties.Resources.image_2_;

                this.Controls.Add(pnl_playerList);
            }
        }
    }
}
