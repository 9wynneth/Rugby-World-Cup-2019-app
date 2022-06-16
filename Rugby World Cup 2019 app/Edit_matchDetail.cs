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
    public partial class Edit_matchDetail : UserControl
    {
        public Edit_matchDetail()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=RWC2019");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtEditMatchDetail = new DataTable();
        DataTable dtMatchDetail = new DataTable();
        DataTable dtMatch = new DataTable();
        DataTable dtPlayer = new DataTable();

        private int selectedData;
        private int isInsert = 1;

        private void Edit_matchDetail_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM matchDetail";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEditMatchDetail);

            sqlQuery = "SELECT * FROM matchDetail m";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatchDetail);

            sqlQuery = "SELECT player_id FROM `match`";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatch);

            sqlQuery = "SELECT player_id, player_name FROM player";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);

            cBox_match.DisplayMember = "match_id";
            cBox_match.ValueMember = "match_id";
            cBox_match.DataSource = dtPlayer;

            cBox_player.DisplayMember = "player_name";
            cBox_player.ValueMember = "player_id";
            cBox_player.DataSource = dtPlayer;
        }

        private void round_btn_deleteMatchDetail_Click(object sender, EventArgs e)
        {
            int selectedData = dGV_edit_matchDetail.SelectedRows[0].Index;
            string selectedMatchDetailID = dtEditMatchDetail.Rows[selectedData][5].ToString();
            sqlQuery = $"UPDATE matchDetail SET delete_matchDetail='1' WHERE matchDetail_id='{selectedMatchDetailID}'; DELETE FROM matchDetail WHERE delete_matchDetail='1';";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data Berhasil di delete");

            dGV_edit_matchDetail.Rows.RemoveAt(dGV_edit_matchDetail.SelectedRows[0].Index);
        }

        private void dGV_edit_matchDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isInsert == 0)
            {
                selectedData = dGV_edit_matchDetail.CurrentCell.RowIndex;
                cBox_match.SelectedValue = dtMatchDetail.Rows[selectedData][0].ToString();
                udNumeric_duration.Value = int.Parse(dtMatchDetail.Rows[selectedData][1].ToString());
                cBox_player.SelectedValue = dtMatchDetail.Rows[selectedData][2].ToString();
                cBox_type.SelectedValue = dtMatchDetail.Rows[selectedData][3].ToString();
                udNumeric_detailID.Value = int.Parse(dtMatchDetail.Rows[selectedData][4].ToString());
            }
        }

        private void round_btn_insertMatchDetail_Click(object sender, EventArgs e)
        {
            udNumeric_detailID.Value = -1;
            udNumeric_detailID.Enabled = false;
            isInsert = 1;
            dGV_edit_matchDetail.DataSource = new DataTable();
        }

        private void round_btn_updateMatchDetail_Click(object sender, EventArgs e)
        {
            udNumeric_detailID.Enabled = true;
            isInsert = 0;
            dGV_edit_matchDetail.DataSource = dtEditMatchDetail;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string m_id = cBox_match.SelectedValue.ToString();
            string drtn = udNumeric_duration.Value.ToString();
            string p_id = cBox_player.SelectedValue.ToString();
            string type = cBox_type.Text;

            if (isInsert == 1)
            {
                DataTable dt = new DataTable();

                sqlQuery = $"SELECT * FROM `matchdetail`";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dt);

                int count = dt.Rows.Count + 1;

                sqlQuery = $"INSERT INTO `matchdetail` (match_id, match_duration, player_id, type_matchDetail, delete_matchDetail, matchDetail_id) VALUES('{m_id}', '{drtn}', '{p_id}', '{type}', 0, '{count}')";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                getData();

                MessageBox.Show("berhasil menambahkan data!");
            }
            else
            {
                string d_id = udNumeric_detailID.Value.ToString();

                sqlQuery = $"UPDATE `team` SET match_id='{m_id}', match_duration='{drtn}', player_id='{p_id}', type_matchDetail='{type}' WHERE matchDetail_id='{d_id}'";
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
            dtMatchDetail = new DataTable();
            dtEditMatchDetail = new DataTable();
            dGV_edit_matchDetail.DataSource = dtEditMatchDetail;
            udNumeric_detailID.Value = -1;

            sqlQuery = "SELECT * FROM `team`";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEditMatchDetail);

            sqlQuery = "SELECT t.team_id, t.team_name, t.world_ranking, t.manager_id, t.assmanager_id, t.captain_id FROM `team` t";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatchDetail);

            dGV_edit_matchDetail.DataSource = dtEditMatchDetail;
            udNumeric_detailID.Value = int.Parse(dtMatchDetail.Rows[selectedData][0].ToString());
        }
    }
}
