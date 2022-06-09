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
    public partial class Edit_manager : UserControl
    {
        Form_Intro formIntro = new Form_Intro();
        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=dBd_07_rwc2019");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtEditManager = new DataTable();

        public Edit_manager()
        {
            InitializeComponent();
        }

        private void Edit_manager_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM manager";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEditManager);

            dGV_edit_manager.DataSource = dtEditManager;
       
        }

        private void round_btn_deleteManager_Click(object sender, EventArgs e)
        { 
            int selectedData = dGV_edit_manager.SelectedRows[0].Index;
            string selectedManagerID = dtEditManager.Rows[selectedData][0].ToString();
            string selectedManagerName = dtEditManager.Rows[selectedData][1].ToString();
            sqlQuery = $"UPDATE MANAGER SET delete_manager='1' WHERE manager_id='{selectedManagerID}' and manager_name='{selectedManagerName}'; DELETE FROM MANAGER WHERE delete_manager='1';";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data Berhasil di delete");
            
            dGV_edit_manager.Rows.RemoveAt(dGV_edit_manager.SelectedRows[0].Index);
 
        }
    }
}
