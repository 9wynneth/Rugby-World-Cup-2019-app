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
    public partial class Show_MoreTeamStats : UserControl
    {
        public Show_MoreTeamStats()
        {
            InitializeComponent();
        }


        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtTeamStatsPoints = new DataTable();
        DataTable dtTeamStatsTries = new DataTable();
        DataTable dtTeamStatsPenalties = new DataTable();
        DataTable dtTeamStatsConversion = new DataTable();

        private void Show_MoreTeamStats_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");

            sqlQuery = $"SELECT t.team_name, sum(if(md.type_matchDetail = 'PENALTY',3,0))+sum(if(md.type_matchDetail  = 'TRY',5,0))+ sum(if (md.type_matchDetail = 'CONVERSION',2,0)) +sum(if (md.type_matchDetail = 'DROP GOAL',3,0)) as 'MOST POINTS' FROM matchdetail md, player p, team t WHERE p.player_id = md.player_id and t.team_id = p.team_id  GROUP BY 1 ORDER BY 2 DESC;   ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamStatsPoints);
            DGV_TeamPoints.DataSource = dtTeamStatsPoints;
            DGV_TeamPoints.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            sqlQuery = $"SELECT t.team_name, Count(md.type_matchDetail) FROM matchDetail md, team t, player p WHERE t.team_id=p.team_id and p.player_id=md.player_id and md.type_matchDetail = 'TRY' group by 1 order by 2 desc; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamStatsTries);
            DGV_TeamTries.DataSource = dtTeamStatsTries;
            DGV_TeamTries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            sqlQuery = $"SELECT T.TEAM_NAME, Count(md.type_matchDetail) FROM player p, TEAM T, matchDetail md WHERE p.player_id=md.player_id and T.TEAM_ID=P.TEAM_ID and md.type_matchDetail='PENALTY' group by 1 order by 2 desc,1 ; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamStatsPenalties);
            DGV_TeamPenalties.DataSource = dtTeamStatsPenalties;
            DGV_TeamPenalties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            sqlQuery = $"SELECT  t.team_name, count(md.type_matchDetail) FROM MATCHDETAIL md, player p, team t WHERE md.player_id=p.player_id and t.team_id=p.team_id and md.type_matchDetail='CONVERSION'  group by 1 order by 2 desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamStatsConversion);
            DGV_TeamConversions.DataSource = dtTeamStatsConversion;
            DGV_TeamConversions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
