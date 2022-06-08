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
    public partial class Edit_player : UserControl
    {
        public Edit_player()
        {
            InitializeComponent();
        }


        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtEditPlayer = new DataTable();


        private void Edit_player_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM PLAYER";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEditPlayer);

            dGV_edit_player.DataSource = dtEditPlayer;
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
    }
}
