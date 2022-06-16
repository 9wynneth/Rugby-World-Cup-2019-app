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
    public partial class Edit_match : UserControl
    {
        public Edit_match()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=RWC2019");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;


        DataTable dtEditMatch = new DataTable();
        DataTable dtMatch = new DataTable();
        DataTable dtTeamHome = new DataTable();
        DataTable dtTeamAway = new DataTable();
        DataTable dtReferee = new DataTable();
        DataTable dtStadium = new DataTable();

        private int selectedData;
        private int isInsert = 1;

        private void Edit_match_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM `match`";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEditMatch);

            sqlQuery = "SELECT m.match_id, m.match_date, m.teamHome_id, m.teamAway_id, m.goal_home, m.goal_away, m.referee_id, m.stadium_id FROM `match` m";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatch);

            sqlQuery = "SELECT team_id, team_name FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamHome);
            sqlAdapter.Fill(dtTeamAway);

            sqlQuery = "SELECT referee_id, referee_name FROM referee";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtReferee);

            sqlQuery = "SELECT stadium_id, stadium_name FROM stadium";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStadium);

            cBox_home.DisplayMember = "team_name";
            cBox_home.ValueMember = "team_id";
            cBox_home.DataSource = dtTeamHome;

            cBox_away.DisplayMember = "team_name";
            cBox_away.ValueMember = "team_id";
            cBox_away.DataSource = dtTeamAway;

            cBox_referee.DisplayMember = "referee_name";
            cBox_referee.ValueMember = "referee_id";
            cBox_referee.DataSource = dtReferee;

            cBox_stadium.DisplayMember = "stadium_name";
            cBox_stadium.ValueMember = "stadium_id";
            cBox_stadium.DataSource = dtStadium;

            tBox_matchID.Enabled = false;
        }

        private void round_btn_delete_Click(object sender, EventArgs e)
        {
            int selectedData = dGV_edit_match.SelectedRows[0].Index;
            string selectedMatchID = dtEditMatch.Rows[selectedData][0].ToString();
            sqlQuery = $"UPDATE `match` SET delete_match='1' WHERE match_id='{selectedMatchID}'; DELETE FROM `match` WHERE delete_match='1';";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data Berhasil di delete");

            dGV_edit_match.Rows.RemoveAt(dGV_edit_match.SelectedRows[0].Index);
        }

        private void getData()
        {
            dtMatch = new DataTable();
            dtEditMatch = new DataTable();
            dGV_edit_match.DataSource = dtEditMatch;
            tBox_matchID.Clear();

            sqlQuery = "SELECT * FROM `match`";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEditMatch);

            sqlQuery = "SELECT m.match_id, m.match_date, m.teamHome_id, m.teamAway_id, m.goal_home, m.goal_away, m.referee_id, m.stadium_id FROM `match` m";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatch);

            dGV_edit_match.DataSource = dtEditMatch;
            tBox_matchID.Text = dtMatch.Rows[selectedData][0].ToString();
        }

        private void round_btn_insert_Click(object sender, EventArgs e)
        {
            tBox_matchID.Clear();
            tBox_matchID.Enabled = false;
            isInsert = 1;
            dGV_edit_match.DataSource = new DataTable();
        }

        private void round_btn_update_Click(object sender, EventArgs e)
        {
            tBox_matchID.Enabled = true;
            isInsert = 0;
            dGV_edit_match.DataSource = dtEditMatch;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string date = $"{dtPicker_date.Value.Year.ToString()}-{dtPicker_date.Value.Month.ToString()}-{dtPicker_date.Value.Day.ToString()}";
            string th_id = cBox_home.SelectedValue.ToString();
            string ta_id = cBox_away.SelectedValue.ToString();
            int home_goal = int.Parse(udNumeric_home.Value.ToString());
            int away_goal = int.Parse(udNumeric_away.Value.ToString());
            string r_id = cBox_referee.SelectedValue.ToString();
            string s_id = cBox_stadium.SelectedValue.ToString();

            if (isInsert == 1)
            {

                DataTable dt = new DataTable();

                sqlQuery = $"SELECT * FROM `match`";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dt);

                int count = dt.Rows.Count + 1;
                string m_id = dtPicker_date.Value.Year.ToString().Substring(2, 2);

                if (count <= 999 && count > 99)
                {
                    m_id += count.ToString();
                }
                else if (count <= 99 && count > 9)
                {
                    m_id += $"0{count.ToString()}";
                }
                else
                {
                    m_id += $"00{count.ToString()}";
                }

                sqlQuery = $"INSERT INTO `match` (match_id, match_date, teamHome_id, teamAway_id, goal_home, goal_away, referee_id, stadium_id, delete_match) VALUES('{m_id}', '{date}', '{th_id}', '{ta_id}', {home_goal}, {away_goal}, '{r_id}', '{s_id}', 0)";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                getData();

                MessageBox.Show("berhasil menambahkan data!");
            }
            else
            {
                string m_id = tBox_matchID.Text;

                sqlQuery = $"UPDATE `match` SET match_date='{date}', teamHome_id='{th_id}', teamAway_id='{ta_id}', goal_home='{home_goal}', goal_away='{away_goal}', referee_id='{r_id}', stadium_id='{s_id}' WHERE match_id='{m_id}'";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                getData();

                MessageBox.Show("Data Berhasil disunting");
            }
        }

        private void dGV_edit_match_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isInsert == 0)
            {
                selectedData = dGV_edit_match.CurrentCell.RowIndex;
                tBox_matchID.Text = dtMatch.Rows[selectedData][0].ToString();
                dtPicker_date.Value = DateTime.Parse(dtMatch.Rows[selectedData][1].ToString());
                cBox_home.SelectedValue = dtMatch.Rows[selectedData][2].ToString();
                cBox_away.SelectedValue = dtMatch.Rows[selectedData][3].ToString();
                udNumeric_away.Value = int.Parse(dtMatch.Rows[selectedData][4].ToString());
                udNumeric_home.Value = int.Parse(dtMatch.Rows[selectedData][5].ToString());
                cBox_referee.SelectedValue = dtMatch.Rows[selectedData][6].ToString();
                cBox_stadium.SelectedValue = dtMatch.Rows[selectedData][7].ToString();
            }
        }
    }
}
