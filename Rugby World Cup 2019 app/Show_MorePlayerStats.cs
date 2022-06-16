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
    public partial class Show_MorePlayerStats : UserControl
    {
        public Show_MorePlayerStats()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtPlayerStatsPoints = new DataTable();
        DataTable dtPlayerStatsTries = new DataTable();
        DataTable dtPlayerStatsPenalties = new DataTable();
        DataTable dtPlayerStatsConversion = new DataTable();

        private void Show_MorePlayerStats_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");

            sqlQuery = $"SELECT p.player_name, sum(if(md.type_matchDetail = 'PENALTY',3,0))+sum(if(md.type_matchDetail  = 'TRY',5,0))+ sum(if (md.type_matchDetail = 'CONVERSION',2,0)) +sum(if (md.type_matchDetail = 'DROP GOAL',3,0)) as 'MOST POINTS' FROM matchdetail md, player p WHERE p.player_id = md.player_id  GROUP BY 1 ORDER BY 2 DESC; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayerStatsPoints);
            DGV_PlayerPoints.DataSource = dtPlayerStatsPoints;
            DGV_PlayerPoints.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            sqlQuery = $"SELECT p.player_name, t.team_name, Count(md.type_matchDetail) FROM player p,  matchDetail md, team t WHERE p.player_id = md.player_id and t.team_id=p.team_id and md.type_matchDetail = 'TRY'  group by 1 order by 3 desc; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayerStatsTries);
            DGV_PlayerTries.DataSource = dtPlayerStatsTries;
            DGV_PlayerTries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            sqlQuery = $"SELECT p.player_name, T.TEAM_NAME, Count(md.type_matchDetail) FROM player p, TEAM T, matchDetail md WHERE p.player_id=md.player_id and T.TEAM_ID=P.TEAM_ID and md.type_matchDetail='PENALTY' group by 1 order by 3 desc ; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayerStatsPenalties);
            DGV_PlayerPenalties.DataSource= dtPlayerStatsPenalties;
            DGV_PlayerPenalties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            sqlQuery = $"SELECT p.player_name, t.team_name, count(md.type_matchDetail) FROM MATCHDETAIL md, player p, team t WHERE md.player_id=p.player_id and t.team_id=p.team_id and md.type_matchDetail='CONVERSION'  group by 1 order by 3 desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayerStatsConversion);
            DGV_PlayerConversions.DataSource = dtPlayerStatsConversion;
            DGV_PlayerConversions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
