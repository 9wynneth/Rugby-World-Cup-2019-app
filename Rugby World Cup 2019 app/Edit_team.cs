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
    public partial class Edit_team : UserControl
    {
        public Edit_team()
        {
            InitializeComponent();
        }


        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=RWC2019");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtEditTeam = new DataTable();
        DataTable dtTeam = new DataTable();
        DataTable dtManager = new DataTable();
        DataTable dtAssManager = new DataTable();
        DataTable dtPlayer = new DataTable();

        private int selectedData;
        private int isInsert = 1;

        private void Edit_team_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEditTeam);

            sqlQuery = "SELECT t.team_id, t.team_name, t.world_ranking, t.manager_id, t.assmanager_id, t.captain_id FROM `team` t";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);

            sqlQuery = "SELECT manager_id, manager_name FROM manager";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtManager);
            sqlAdapter.Fill(dtAssManager);

            sqlQuery = "SELECT player_id, player_name FROM player";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);

            cBox_manager.DisplayMember = "manager_name";
            cBox_manager.ValueMember = "manager_id";
            cBox_manager.DataSource = dtManager;

            cBox_Assmanager.DisplayMember = "manager_name";
            cBox_Assmanager.ValueMember = "manager_id";
            cBox_Assmanager.DataSource = dtAssManager;

            cBox_captain.DisplayMember = "player_name";
            cBox_captain.ValueMember = "player_id";
            cBox_captain.DataSource = dtPlayer;
        }

        private void round_btn_deleteTeam_Click(object sender, EventArgs e)
        {
            int selectedData = dGV_edit_team.SelectedRows[0].Index;
            string selectedTeamID = dtEditTeam.Rows[selectedData][0].ToString();
            string selectedTeamName = dtEditTeam.Rows[selectedData][1].ToString();
            sqlQuery = $"UPDATE TEAM SET delete_team='1' WHERE team_id='{selectedTeamID}' and team_name='{selectedTeamName}'; DELETE FROM TEAM WHERE delete_team='1';";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data Berhasil di delete");

            dGV_edit_team.Rows.RemoveAt(dGV_edit_team.SelectedRows[0].Index);
        }

        private void dGV_edit_team_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isInsert == 0)
            {
                selectedData = dGV_edit_team.CurrentCell.RowIndex;
                tBox_teamID.Text = dtTeam.Rows[selectedData][0].ToString();
                tBox_teamName.Text = dtTeam.Rows[selectedData][1].ToString();
                tBox_worldRanking.Text = dtTeam.Rows[selectedData][2].ToString();
                cBox_manager.SelectedValue = dtTeam.Rows[selectedData][3].ToString();
                cBox_Assmanager.SelectedValue = dtTeam.Rows[selectedData][4].ToString();
                cBox_captain.SelectedValue = dtTeam.Rows[selectedData][5].ToString();
            }
        }

        private void round_btn_insertManager_Click(object sender, EventArgs e)
        {
            tBox_teamID.Clear();
            tBox_teamID.Enabled = false;
            isInsert = 1;
            dGV_edit_team.DataSource = new DataTable();
        }

        private void round_btn_updateReferee_Click(object sender, EventArgs e)
        {
            tBox_teamID.Enabled = true;
            isInsert = 0;
            dGV_edit_team.DataSource = dtEditTeam;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string name = tBox_teamName.Text;
            string rank = tBox_worldRanking.Text;
            string m_id = cBox_manager.SelectedValue.ToString();
            string a_id = cBox_Assmanager.SelectedValue.ToString();
            string c_id = cBox_captain.SelectedValue.ToString();

            if (isInsert == 1)
            {
                string fchr = name.Substring(0, 1);
                DataTable dt = new DataTable();

                sqlQuery = $"SELECT * FROM `team` WHERE team_name LIKE '{fchr}%'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dt);

                int count = dt.Rows.Count + 1;
                string t_id = fchr;

                if (count <= 999 && count > 99)
                {
                    t_id += count.ToString();
                }
                else if (count <= 99 && count > 9)
                {
                    t_id += $"0{count.ToString()}";
                }
                else
                {
                    t_id += $"00{count.ToString()}";
                }

                sqlQuery = $"INSERT INTO `team` (team_id, team_name, world_ranking, manager_id, assmanager_id, captain_id, delete_team) VALUES('{t_id}', '{name}', '{rank}', '{m_id}', {a_id}, {c_id}, 0)";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                getData();

                MessageBox.Show("berhasil menambahkan data!");
            }
            else
            {
                string t_id = tBox_teamID.Text;

                sqlQuery = $"UPDATE `team` SET team_name='{name}', world_ranking='{rank}', manager_id='{m_id}', assmanager_id='{a_id}', captain_id='{c_id}' WHERE team_id='{t_id}'";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                getData();

                MessageBox.Show("Data Berhasil disunting");
            }
        }

        private void getData()
        {
            dtTeam = new DataTable();
            dtEditTeam = new DataTable();
            dGV_edit_team.DataSource = dtEditTeam;
            tBox_teamID.Clear();

            sqlQuery = "SELECT * FROM `team`";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEditTeam);

            sqlQuery = "SELECT t.team_id, t.team_name, t.world_ranking, t.manager_id, t.assmanager_id, t.captain_id FROM `team` t";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);

            dGV_edit_team.DataSource = dtEditTeam;
            tBox_teamID.Text = dtTeam.Rows[selectedData][0].ToString();
        }

    }
}
