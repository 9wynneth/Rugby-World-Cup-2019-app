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
    public partial class cBox_player : UserControl
    {
        public cBox_player()
        {
            InitializeComponent();
        }


        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=RWC2019");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtEditPlayer = new DataTable();
        DataTable dtPlayer = new DataTable();
        DataTable dtNationality = new DataTable();
        DataTable dtTeam = new DataTable();

        private int selectedData;
        private int isInsert = 1;

        private void Edit_player_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM player";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEditPlayer);

            sqlQuery = "SELECT p.player_id, t.player_name, t.nationality_id, t.player_position, t.height, t.weight FROM `player` p";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);

            sqlQuery = "SELECT nationality_id, country_name FROM nationality";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNationality);

            sqlQuery = "SELECT team_id, team_name FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);

            cBox_nationality.DisplayMember = "country_name";
            cBox_nationality.ValueMember = "nationality_id";
            cBox_nationality.DataSource = dtNationality;

            cBox_team.DisplayMember = "team_name";
            cBox_team.ValueMember = "team_id";
            cBox_team.DataSource = dtTeam;
        }

        private void round_btn_deletePlayer_Click(object sender, EventArgs e)
        {
            int selectedData = dGV_edit_player.SelectedRows[0].Index;
            string selectedPlayerID = dtEditPlayer.Rows[selectedData][0].ToString();
            string selectedPlayerName = dtEditPlayer.Rows[selectedData][1].ToString();
            sqlQuery = $"UPDATE PLAYER SET delete_player='1' WHERE player_id='{selectedPlayerID}' and player_name='{selectedPlayerName}'; DELETE FROM PLAYER WHERE delete_player='1';";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data Berhasil di delete");

            dGV_edit_player.Rows.RemoveAt(dGV_edit_player.SelectedRows[0].Index);
        }

        private void round_btn_updatePlayer_Click(object sender, EventArgs e)
        {
            tBox_playerID.Enabled = true;
            isInsert = 0;
            dGV_edit_player.DataSource = dtEditPlayer;
        }

        private void round_btn_insertPlayer_Click(object sender, EventArgs e)
        {
            tBox_playerID.Clear();
            tBox_playerID.Enabled = false;
            isInsert = 1;
            dGV_edit_player.DataSource = new DataTable();
        }

        private void dGV_edit_player_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isInsert == 0)
            {
                selectedData = dGV_edit_player.CurrentCell.RowIndex;
                tBox_playerID.Text = dtPlayer.Rows[selectedData][0].ToString();
                tBox_playerName.Text = dtPlayer.Rows[selectedData][1].ToString();
                cBox_nationality.SelectedValue = dtPlayer.Rows[selectedData][2].ToString();
                tBox_position.Text = dtPlayer.Rows[selectedData][3].ToString();
                tBox_height.Text = dtPlayer.Rows[selectedData][4].ToString();
                tBox_weight.Text = dtPlayer.Rows[selectedData][5].ToString();
                dtPicker_birthdate.Value = DateTime.Parse(dtPlayer.Rows[selectedData][6].ToString());
                cBox_team.SelectedValue = dtPlayer.Rows[selectedData][7].ToString();
                cBox_status.Text = dtPlayer.Rows[selectedData][8].ToString();
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string name = tBox_playerName.Text;
            string n_id = cBox_nationality.SelectedValue.ToString();
            string ppos = tBox_position.Text;
            string hght = tBox_height.Text;
            string wght = tBox_weight.Text;
            string date = $"{dtPicker_birthdate.Value.Year.ToString()}-{dtPicker_birthdate.Value.Month.ToString()}-{dtPicker_birthdate.Value.Day.ToString()}";
            string t_id = cBox_team.SelectedValue.ToString();
            string stts = cBox_status.Text;

            if (isInsert == 1)
            {
                string fchr = name.Substring(0, 1);
                DataTable dt = new DataTable();

                sqlQuery = $"SELECT * FROM `player` WHERE player_name LIKE '{fchr}%'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dt);

                int count = dt.Rows.Count + 1;
                string p_id = fchr;

                if (count <= 999 && count > 99)
                {
                    p_id += count.ToString();
                }
                else if (count <= 99 && count > 9)
                {
                    p_id += $"0{count.ToString()}";
                }
                else
                {
                    p_id += $"00{count.ToString()}";
                }

                sqlQuery = $"INSERT INTO `player` (player_id, player_name, nationality_id, player_position, height, weight, birthdate, team_id, status_player, delete_player) VALUES('{p_id}', '{name}', '{n_id}', '{ppos}', {hght}, {wght}, '{date}', '{t_id}', '{stts}', 0)";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                getData();

                MessageBox.Show("berhasil menambahkan data!");
            }
            else
            {
                string p_id = tBox_playerID.Text;

                sqlQuery = $"UPDATE `player` SET player_name='{name}', nationality_id='{n_id}', player_position='{ppos}', height='{hght}', weight='{wght}, birthdate='{date}', team_id='{t_id}', status_player='{stts}' WHERE player_id='{p_id}'";
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
            dtPlayer = new DataTable();
            dtEditPlayer = new DataTable();
            dGV_edit_player.DataSource = dtEditPlayer;
            tBox_playerID.Clear();

            sqlQuery = "SELECT * FROM player";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEditPlayer);

            sqlQuery = "SELECT p.player_id, t.player_name, t.nationality_id, t.player_position, t.height, t.weight FROM `player` p";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);

            dGV_edit_player.DataSource = dtEditPlayer;
            tBox_playerID.Text = dtTeam.Rows[selectedData][0].ToString();
        }
    }
}
