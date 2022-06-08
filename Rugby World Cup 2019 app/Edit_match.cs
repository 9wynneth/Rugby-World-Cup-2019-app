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

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;


        DataTable dtEditMatch = new DataTable();

        private void Edit_match_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM `match`";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEditMatch);

            dGV_edit_match.DataSource = dtEditMatch;
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
    }
}
