using System;
using System.Data;
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

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=RWC2019");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtReferee = new DataTable();
        DataTable dtNationality = new DataTable();
        DataTable dtEditReferee = new DataTable();
        private int selectedData;
        private int isInsert = 1;
        private void Edit_referee_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM referee";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEditReferee);

            sqlQuery = "SELECT r.referee_id, r.referee_name, n.country_name as nationality, n.nationality_id FROM referee r, nationality n WHERE n.nationality_id=r.nationality_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtReferee);

            sqlQuery = "SELECT nationality_id, country_name as nationality FROM nationality";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNationality);

            cBox_nationality.DisplayMember = "nationality";
            cBox_nationality.ValueMember = "nationality_id";
            cBox_nationality.DataSource = dtNationality;
            tBox_refereeID.Enabled = false;
        }

        private void round_btn_deleteReferee_Click(object sender, EventArgs e)
        {
            string selectedRefereeID = dtEditReferee.Rows[selectedData][0].ToString();
            string selectedRefereeName = dtEditReferee.Rows[selectedData][1].ToString();
            sqlQuery = $"UPDATE REFEREE SET delete_referee='1' WHERE referee_id='{selectedRefereeID}' and referee_name='{selectedRefereeName}'; DELETE FROM referee WHERE delete_referee='1';";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data Berhasil di delete");

            dGV_edit_referee.Rows.RemoveAt(selectedData);
        }

        private void getData()
        {
            dtReferee = new DataTable();
            dtNationality = new DataTable();
            dtEditReferee = new DataTable();
            dGV_edit_referee.DataSource = dtEditReferee;
            cBox_nationality.DataSource = dtNationality;
            tBox_refereeID.Clear();
            tBox_refereeName.Clear();

            sqlQuery = "SELECT * FROM referee";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEditReferee);

            sqlQuery = "SELECT r.referee_id, r.referee_name, n.country_name as nationality, n.nationality_id FROM referee r, nationality n WHERE n.nationality_id=r.nationality_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtReferee);

            sqlQuery = "SELECT nationality_id, country_name as nationality FROM nationality";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNationality);

            dGV_edit_referee.DataSource = dtEditReferee;
            tBox_refereeID.Text = dtReferee.Rows[selectedData][0].ToString();
            tBox_refereeName.Text = dtReferee.Rows[selectedData][1].ToString();
            cBox_nationality.DisplayMember = "nationality";
            cBox_nationality.ValueMember = "nationality_id";
            cBox_nationality.DataSource = dtNationality;
            cBox_nationality.SelectedValue = dtReferee.Rows[selectedData][3].ToString();
        }

        private void dGV_edit_referee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isInsert == 0)
            {
                selectedData = dGV_edit_referee.CurrentCell.RowIndex;
                tBox_refereeID.Text = dtReferee.Rows[selectedData][0].ToString();
                tBox_refereeName.Text = dtReferee.Rows[selectedData][1].ToString();
                cBox_nationality.SelectedValue = dtReferee.Rows[selectedData][3].ToString();
            }
        }

        private void round_btn_insertManager_Click(object sender, EventArgs e)
        {
            tBox_refereeID.Clear();
            tBox_refereeName.Clear();
            tBox_refereeID.Enabled = false;
            isInsert = 1;
            dGV_edit_referee.DataSource = new DataTable();
        }

        private void round_btn_updateReferee_Click(object sender, EventArgs e)
        {
            tBox_refereeID.Enabled = true;
            isInsert = 0;
            dGV_edit_referee.DataSource = dtEditReferee;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (isInsert == 1)
            {
                string name = tBox_refereeName.Text;
                string n_id = cBox_nationality.SelectedValue.ToString();
                string fchr = name.Substring(0, 1);

                DataTable dt = new DataTable();

                sqlQuery = $"SELECT referee_name FROM referee WHERE referee_name LIKE '{fchr}%'";
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

                sqlQuery = $"INSERT INTO referee (referee_id, referee_name, nationality_id, delete_referee) VALUES('{r_id}', '{name}', '{n_id}', 0)";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                getData();

                MessageBox.Show("berhasil menambahkan data!");
            }
            else
            {
                string name = tBox_refereeName.Text;
                string n_id = cBox_nationality.SelectedValue.ToString();
                string r_id = tBox_refereeID.Text;

                sqlQuery = $"UPDATE referee SET referee_name='{name}',nationality_id='{n_id}' WHERE referee_id='{r_id}'";
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
