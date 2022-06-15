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
    public partial class Show_Player : UserControl
    {
        public Show_Player()
        {
            InitializeComponent();
        }


        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtPlayer = new DataTable();

        private void Show_Player_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");
            sqlQuery = $"SELECT r.referee_id as 'REFEREE ID', r.referee_name as 'REFEREE NAME', n.country_name as NATIONALITY, n.country_code as ABV FROM referee r, nationality n WHERE n.nationality_id = r.nationality_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            listOfPlayer();
            
        }

        private void listOfPlayer()
        {

        }
    }
}
