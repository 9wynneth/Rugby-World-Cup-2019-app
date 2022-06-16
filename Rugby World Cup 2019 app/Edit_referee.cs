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

        //Form_Intro formAwal = new Form_Intro();

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;



        DataTable dtReferee = new DataTable();
        DataTable dtNationality = new DataTable();
        DataTable dtEditReferee = new DataTable();
        public int selectedData;
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

        private void round_btn_updateReferee_Click(object sender, EventArgs e)
        {

        }

        private void dGV_edit_referee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedData = dGV_edit_referee.CurrentCell.RowIndex;
            getData();
        }


        private void getData()
        {
            sqlQuery = "SELECT r.referee_id, r.referee_name, n.country_name as nationality FROM REFEREE r, nationality n WHERE n.nationality_id=r.nationality_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtReferee);

            tBox_refereeID.Text = dtReferee.Rows[selectedData][0].ToString();
            tBox_refereeName.Text = dtReferee.Rows[selectedData][1].ToString();
            cBox_nationality.DisplayMember = "nationality";

            sqlQuery = "SELECT nationality_id, country_name as nationality FROM NATIONALITY";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNationality);

            cBox_nationality.DataSource = dtNationality;
        }

        /*
        private void round_btn_updateReferee_Click(object sender, EventArgs e)
        {
            
            formReferee.selectedData=dGV_edit_referee.CurrentCell.RowIndex;
           formReferee.Show();
        }

       private void dGV_edit_referee_SelectionChanged(object sender, EventArgs e)
        {
    
            formReferee.selectedData = dGV_edit_referee.CurrentCell.RowIndex;
            //formReferee.load();
        }*/
    }
}
