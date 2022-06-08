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
    public partial class Edit_referee : UserControl
    {
        public Edit_referee()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtEditReferee = new DataTable();

        private void Edit_referee_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM REFEREE";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEditReferee);

            dGV_edit_referee.DataSource = dtEditReferee;
        }

        private void round_btn_deleteReferee_Click(object sender, EventArgs e)
        {
            int selectedData = dGV_edit_referee.SelectedRows[0].Index;
            string selectedRefereeID = dtEditReferee.Rows[selectedData][0].ToString();
            string selectedRefereeName = dtEditReferee.Rows[selectedData][1].ToString();
            sqlQuery = $"UPDATE REFEREE SET delete_referee='1' WHERE referee_id='{selectedRefereeID}' and referee_name='{selectedRefereeName}'; DELETE FROM REFEREE WHERE delete_referee='1';";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data Berhasil di delete");

            dGV_edit_referee.Rows.RemoveAt(dGV_edit_referee.SelectedRows[0].Index);
        }
    }
}
