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
    public partial class Form_Edit_Referee : Form
    {
        public Form_Edit_Referee()
        {
            InitializeComponent();
        }
        string sqlQuery;
        public int selectedData;

        Form_Intro formAwal = new Form_Intro();
       

        DataTable dtReferee = new DataTable();
        DataTable dtNationality = new DataTable();

        private void Form_Edit_Referee_Load(object sender, EventArgs e)
        {

            sqlQuery = $"SELECT r.referee_id, r.referee_name, n.country_name as nationality FROM REFEREE r, nationality n WHERE n.nationality_id=r.nationality_id";
            formAwal.sqlCommand = new MySqlCommand(sqlQuery, formAwal.sqlConnect);
            formAwal.sqlAdapter = new MySqlDataAdapter(formAwal.sqlCommand);
            formAwal.sqlAdapter.Fill(dtReferee);

            tBox_refereeID.Text = dtReferee.Rows[selectedData][0].ToString();
            tBox_refereeName.Text = dtReferee.Rows[selectedData][1].ToString();
            cBox_nationality.DisplayMember = "nationality";

            sqlQuery = "SELECT nationality_id, country_name as nationality FROM NATIONALITY";
            formAwal.sqlCommand = new MySqlCommand(sqlQuery, formAwal.sqlConnect);
            formAwal.sqlAdapter = new MySqlDataAdapter(formAwal.sqlCommand);
            formAwal.sqlAdapter.Fill(dtNationality);

            cBox_nationality.DataSource = dtNationality;

        }
    }
}
