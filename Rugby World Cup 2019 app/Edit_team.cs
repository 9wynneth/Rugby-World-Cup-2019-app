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


        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtEditTeam = new DataTable();


        private void Edit_team_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM TEAM";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEditTeam);

            dGV_edit_team.DataSource = dtEditTeam;
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
    }
}
