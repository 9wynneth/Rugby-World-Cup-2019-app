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
    public partial class Show_tournamentStats : UserControl
    {
        public Show_tournamentStats()
        {
            InitializeComponent();
            
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        Show_details showDetails = new Show_details();

        DataTable dtTotalRedCards = new DataTable();
        DataTable dtTotalYellowCards = new DataTable();
        DataTable dtMostTries = new DataTable();

        private void Show_tournamentStats_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT Count(md.type_matchDetail) FROM matchDetail md WHERE md.type_matchDetail = 'RED CARD'; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTotalRedCards);

            lbl_totalRedCards.Text = dtTotalRedCards.Rows[0][0].ToString();

            sqlQuery = "SELECT Count(md.type_matchDetail) FROM matchDetail md WHERE md.type_matchDetail = 'YELLOW CARD'; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTotalYellowCards);

            lbl_totalYellowCards.Text = dtTotalYellowCards.Rows[0][0].ToString();

            sqlQuery = "SELECT p.player_name, n.country_name, Count(md.type_matchDetail) FROM player p, nationality n, matchDetail md WHERE p.player_id = md.player_id and p.nationality_id = n.nationality_id and md.type_matchDetail = 'TRY' group by 1 order by 3 desc limit 1; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMostTries);

            linkLabel_playerMostTries.Text= dtMostTries.Rows[0][0].ToString();
            lbl_mostTriesNationality.Text= dtMostTries.Rows[0][1].ToString();
            lbl_mostTries.Text = dtMostTries.Rows[0][2].ToString();

        }
        public static bool detailRedCards=true;
    

        private void btn_details_redCards_Click(object sender, EventArgs e)
        {
            detailRedCards = false;
            
            showDetails.ShowDialog();
            
        }
    }
}
