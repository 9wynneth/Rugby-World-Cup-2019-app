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

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtEditMatchDetail = new DataTable();

        private void Edit_matchDetail_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM matchDetail";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEditMatchDetail);

            dGV_edit_matchDetail.DataSource = dtEditMatchDetail;
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
    }
}
