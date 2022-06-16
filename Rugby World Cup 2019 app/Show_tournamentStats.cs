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

        MySqlConnection sqlConnect ;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        Show_details showDetails = new Show_details();

        DataTable dtTotalRedCards = new DataTable();
        DataTable dtTotalYellowCards = new DataTable();
        DataTable dtMostTries = new DataTable();
        DataTable dtMostPenalties = new DataTable();
        DataTable dtTotalMatches = new DataTable();
        DataTable dtHighestScore = new DataTable();
        DataTable dtBiggestVictory = new DataTable();
        DataTable dtMostPoints = new DataTable();
        DataTable dtMostConversion = new DataTable();

        private void Show_tournamentStats_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");
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

            sqlQuery = $"SELECT p.player_name, n.country_name, Count(md.type_matchDetail) FROM player p, nationality n, matchDetail md  WHERE p.player_id = md.player_id and p.nationality_id = n.nationality_id and md.type_matchDetail = 'PENALTY' group by 1 order by 3 desc; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMostPenalties);

            lbl_penaltyScore.Text = dtMostPenalties.Rows[0][2].ToString();
            lbl_penaltyNationality.Text = dtMostPenalties.Rows[0][1].ToString();
            linkLabel_PenaltyName.Text = dtMostPenalties.Rows[0][0].ToString();


            sqlQuery = $"SELECT count(m.match_id) FROM `MATCH` m;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTotalMatches);

            lbl_totalMatches.Text= dtTotalMatches.Rows[0][0].ToString();


            sqlQuery = $"SELECT  M.GOAL_HOME, M.GOAL_AWAY, Concat((SELECT t.team_name FROM team t WHERE t.team_id = m.teamHome_id), ' VS ',  (SELECT t.team_name FROM team t WHERE t.team_id = m.teamAway_id)) as 'MATCH RESULT',(SELECT t.team_name FROM team t WHERE t.team_id = m.teamHome_id),(SELECT t.team_name FROM team t WHERE t.team_id = m.teamAway_id) FROM `MATCH` M order by CONVERT(m.goal_home,UNSIGNED INTEGER) desc LIMIT 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtHighestScore);
            lbl_statsMatchHighestScoring.Text=dtHighestScore.Rows[0][2].ToString();
            textBoxHighScoreHometeam.Text = dtHighestScore.Rows[0][0].ToString();
            textBoxHIghScoreawayTeam.Text = dtHighestScore.Rows[0][1].ToString();
            string picHIghHomeScore = dtHighestScore.Rows[0][3].ToString();
            picHIghHomeScore = picHIghHomeScore.Replace(" ", "_");
            object getPicHomeHigh = Properties.Resources.ResourceManager.GetObject(picHIghHomeScore); 
            picBoxHighHomeTeam.Image = (Image)getPicHomeHigh;
            picBoxHighHomeTeam.BackColor = Color.Transparent;
            picBoxHighHomeTeam.SizeMode = PictureBoxSizeMode.StretchImage;
            string picHighAwayScore = dtHighestScore.Rows[0][4].ToString();
            picHighAwayScore = picHighAwayScore.Replace(" ", "_");
            object getPicHighAway = Properties.Resources.ResourceManager.GetObject(picHighAwayScore);
            picBoxHighAway.Image = (Image)getPicHighAway;
            picBoxHighAway.BackColor = Color.Transparent;
            picBoxHighAway.SizeMode = PictureBoxSizeMode.StretchImage;


            sqlQuery = $"SELECT m.goal_home, m.goal_away, Concat((SELECT t.team_name FROM team t WHERE t.team_id = m.teamHome_id), ' VS ',  (SELECT t.team_name FROM team t WHERE t.team_id = m.teamAway_id)) as `MATCH`,(SELECT t.team_name FROM team t WHERE t.team_id = m.teamHome_id),(SELECT t.team_name FROM team t WHERE t.team_id = m.teamAway_id) FROM `MATCH` M order by abs(m.goal_home-m.goal_away) desc; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtBiggestVictory);
            lbl_biggestVictory.Text = dtBiggestVictory.Rows[0][2].ToString();
            textBoxBigHome.Text = dtBiggestVictory.Rows[0][0].ToString();
            textBoxBigAway.Text = dtBiggestVictory.Rows[0][1].ToString();
            string picBigHomeScore = dtBiggestVictory.Rows[0][3].ToString();
            picBigHomeScore = picBigHomeScore.Replace(" ", "_");
            object getPicHomeBig = Properties.Resources.ResourceManager.GetObject(picBigHomeScore);
            picBox_BigHome.Image = (Image)getPicHomeBig;
            picBox_BigHome.BackColor = Color.Transparent;
            picBox_BigHome.SizeMode = PictureBoxSizeMode.StretchImage;
            string picBigAwayScore = dtBiggestVictory.Rows[0][4].ToString();
            picBigAwayScore = picBigAwayScore.Replace(" ", "_");
            object getPicBigAway = Properties.Resources.ResourceManager.GetObject(picBigAwayScore);
            picBox_BigAway.Image = (Image)getPicBigAway;
            picBox_BigAway.BackColor = Color.Transparent;
            picBox_BigAway.SizeMode = PictureBoxSizeMode.StretchImage;


            sqlQuery = $"SELECT p.player_name, sum(if(md.type_matchDetail = 'PENALTY',3,0))+sum(if(md.type_matchDetail  = 'TRY',5,0))+ sum(if (md.type_matchDetail = 'CONVERSION',2,0)) +sum(if (md.type_matchDetail = 'DROP GOAL',3,0)) as 'MOST POINTS', t.team_name FROM matchdetail md, player p, team t WHERE p.player_id = md.player_id and t.team_id=p.team_id GROUP BY 1 ORDER BY 2 DESC; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMostPoints);
            lbl_MostPoints.Text = dtMostPoints.Rows[0][1].ToString();
            lbl_playerNameMostPoints.Text= dtMostPoints.Rows[0][0].ToString();
            lbl_playerTeamMostPoints.Text= dtMostPoints.Rows[0][2].ToString();
            string picMostPoints = dtMostPoints.Rows[0][2].ToString();
            picMostPoints = picMostPoints.Replace(" ", "_");
            object getPicMostPoints = Properties.Resources.ResourceManager.GetObject(picMostPoints);
            pictureBoxMostPointsTeam.Image = (Image)getPicMostPoints;
            pictureBoxMostPointsTeam.BackColor = Color.Transparent;
            pictureBoxMostPointsTeam.SizeMode = PictureBoxSizeMode.StretchImage;


            sqlQuery = $"SELECT p.player_name, count(md.type_matchDetail)AS CONVERSION, t.team_name AS team FROM MATCHDETAIL md, player p, team t WHERE md.player_id=p.player_id and t.team_id=p.team_id and md.type_matchDetail='CONVERSION' group by 1 order by 2 desc; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMostConversion);
            lbl_MostConversionPoints.Text = dtMostConversion.Rows[0][1].ToString(); 
            lbl_conversionPlayerName.Text = dtMostConversion.Rows[0][0].ToString();
            lbl_ConversionTeam.Text = dtMostConversion.Rows[0][2].ToString();
            string picMostConversion = dtMostPoints.Rows[0][2].ToString();
            picMostConversion = picMostConversion.Replace(" ", "_");
            object getPicMostConversion = Properties.Resources.ResourceManager.GetObject(picMostConversion);
            pictureBoxConversionTeam.Image = (Image)getPicMostConversion;
            pictureBoxConversionTeam.BackColor = Color.Transparent;
            pictureBoxConversionTeam.SizeMode = PictureBoxSizeMode.StretchImage;


        }
        public static bool detailRedCards=true;
        public static bool detailYellowCards = true;
        public static bool detailPenalty = true;
        private void btn_details_redCards_Click(object sender, EventArgs e)
        {
            detailRedCards = false;
            showDetails.ShowDialog();
            
        }

        private void btn_more_yellowCards_Click(object sender, EventArgs e)
        {
            detailYellowCards = false;
            showDetails.ShowDialog();
        }

        private void btn_ShowMorePenalty_Click(object sender, EventArgs e)
        {
            detailPenalty = false;
            showDetails.ShowDialog();
        }
    }
}
