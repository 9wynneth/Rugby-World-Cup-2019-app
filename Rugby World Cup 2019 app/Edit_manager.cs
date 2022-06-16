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

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=RWC2019");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtEditManager = new DataTable();
        DataTable dtNationality = new DataTable();
        DataTable dtManager = new DataTable();

        private int selectedData;
        private int isInsert = 1;

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

            sqlQuery = "SELECT m.manager_id, m.manager_name, m.birthdate, n.country_name as nationality, n.nationality_id, m.status_manager FROM manager m, nationality n WHERE n.nationality_id=m.nationality_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtManager);

            sqlQuery = "SELECT nationality_id, country_name as nationality FROM nationality";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNationality);

            cBox_nationality.DisplayMember = "nationality";
            cBox_nationality.ValueMember = "nationality_id";
            cBox_nationality.DataSource = dtNationality;
            tBox_managerID.Enabled = false;

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

        private void getData()
        {
            dtManager = new DataTable();
            dtNationality = new DataTable();
            dtEditManager = new DataTable();
            dGV_edit_manager.DataSource = dtEditManager;
            cBox_nationality.DataSource = dtNationality;
            tBox_managerID.Clear();
            tBox_managerName.Clear();

            sqlQuery = "SELECT * FROM manager";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEditManager);

            sqlQuery = "SELECT m.manager_id, m.manager_name, m.birthdate, n.country_name as nationality, n.nationality_id, m.status_manager FROM manager m, nationality n WHERE n.nationality_id=m.nationality_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtManager);

            sqlQuery = "SELECT nationality_id, country_name as nationality FROM nationality";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNationality);

            dGV_edit_manager.DataSource = dtEditManager;
            tBox_managerID.Text = dtManager.Rows[selectedData][0].ToString();
            tBox_managerName.Text = dtManager.Rows[selectedData][1].ToString();
            cBox_nationality.DisplayMember = "nationality";
            cBox_nationality.ValueMember = "nationality_id";
            cBox_nationality.DataSource = dtNationality;
            cBox_nationality.SelectedValue = dtManager.Rows[selectedData][4].ToString();
        }


        private void round_btn_insertManager_Click(object sender, EventArgs e)
        {
            tBox_managerID.Clear();
            tBox_managerName.Clear();
            tBox_managerID.Enabled = false;
            isInsert = 1;
            dGV_edit_manager.DataSource = new DataTable();
        }

        private void round_btn_updateManager_Click(object sender, EventArgs e)
        {
            tBox_managerID.Enabled = true;
            isInsert = 0;
            dGV_edit_manager.DataSource = dtEditManager;
        }

        private void dGV_edit_manager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isInsert == 0)
            {
                selectedData = dGV_edit_manager.CurrentCell.RowIndex;
                tBox_managerID.Text = dtManager.Rows[selectedData][0].ToString();
                tBox_managerName.Text = dtManager.Rows[selectedData][1].ToString();
                dtPicker_birthdate.Value = DateTime.Parse(dtManager.Rows[selectedData][2].ToString());
                cBox_nationality.SelectedValue = dtManager.Rows[selectedData][4].ToString();
                cBox_status.Text = dtManager.Rows[selectedData][5].ToString();
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string name = tBox_managerName.Text;
            string n_id = cBox_nationality.SelectedValue.ToString();
            string fchr = name.Substring(0, 1);
            string date = $"{dtPicker_birthdate.Value.Year.ToString()}-{dtPicker_birthdate.Value.Month.ToString()}-{dtPicker_birthdate.Value.Day.ToString()}";
            string stts = cBox_status.Text;
            if (isInsert == 1)
            {

                DataTable dt = new DataTable();

                sqlQuery = $"SELECT manager_name FROM manager WHERE manager_name LIKE '{fchr}%'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dt);

                int count = dt.Rows.Count + 1;
                string r_id = fchr;

                if (count <= 999 && count > 99)
                {
                    r_id += count.ToString();
                }
                else if (count <= 99 && count > 9)
                {
                    r_id += $"0{count.ToString()}";
                }
                else
                {
                    r_id += $"00{count.ToString()}";
                }

                sqlQuery = $"INSERT INTO manager (manager_id, manager_name, birthdate, nationality_id, status_manager, delete_manager) VALUES('{r_id}', '{name}', '{date}', '{n_id}', '{stts}', 0)";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                getData();

                MessageBox.Show("berhasil menambahkan data!");
            }
            else
            {
                string m_id = tBox_managerID.Text;

                sqlQuery = $"UPDATE manager SET manager_name='{name}',nationality_id='{n_id}', birthdate='{date}', status_manager='{stts}' WHERE manager_id='{m_id}'";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                getData();

                MessageBox.Show("Data Berhasil disunting");
            }
        }
    }
}
