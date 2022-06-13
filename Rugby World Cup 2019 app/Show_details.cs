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
    public partial class Show_details : Form
    {
        public Show_details()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        //Show_tournamentStats showStats = new Show_tournamentStats();
        //Show_stadium showStadium = new Show_stadium();

        DataTable dtRedCardDetail = new DataTable();
        DataTable dtStadium = new DataTable();


        void StyleDatagridview()
        {
            dGV_ShowDetails.BorderStyle = BorderStyle.None;
            dGV_ShowDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dGV_ShowDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dGV_ShowDetails.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dGV_ShowDetails.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dGV_ShowDetails.BackgroundColor = Color.FromArgb(30, 30, 30);
            //dGV_ShowDetails.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dGV_ShowDetails.EnableHeadersVisualStyles = false;
            dGV_ShowDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dGV_ShowDetails.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dGV_ShowDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dGV_ShowDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public  DataGridView dGV = new DataGridView();

        private void showDetailMatch()
        {
            DataTable dtStadium = new DataTable();
            sqlQuery = $"SELECT right(m.match_id, 2) as `MATCH NO.  ` , m.match_date as DATE, r.referee_name as REFEREE, Concat((SELECT t.team_name FROM team t WHERE t.team_id = m.teamHome_id), ' VS ',  (SELECT t.team_name FROM team t WHERE t.team_id = m.teamAway_id)) as `MATCH`,  concat(m.goal_home, ' - ', m.goal_away) as SCORE FROM stadium s, `match` m, referee r WHERE m.referee_id = r.referee_id and s.stadium_id = m.stadium_id and s.stadium_id = '{Show_stadium.ID}' group by 1;  ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStadium);

            dGV_ShowDetails.DataSource = dtStadium;
            dGV_ShowDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
        }

        private void Show_details_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");
            StyleDatagridview();
            sqlQuery = "SELECT p.player_name as Player, n.country_name as Nationality ,Count(md.type_matchDetail) as 'Red Card' FROM player p, matchDetail md, nationality n WHERE p.player_id = md.player_id and n.nationality_id = p.nationality_id and md.type_matchDetail = 'RED CARD' group by 1 order by 2 desc; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtRedCardDetail);

            sqlQuery = $"SELECT stadium_id, stadium_name FROM stadium;  ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStadium);

            if (Show_tournamentStats.detailRedCards == false)
            {
                lbl_topicDetails.Text = $"Top Red Cards ({dtRedCardDetail.Rows.Count-1})";
                dGV_ShowDetails.DataSource = dtRedCardDetail;
                Show_tournamentStats.detailRedCards = true;
            }
            else if (Show_stadium.sapporo == false)
            {
                lbl_topicDetails.Text = $"All matches in {dtStadium.Rows[9][1].ToString()}";
                Show_stadium.ID = dtStadium.Rows[9][0].ToString();
                showDetailMatch();
                Show_stadium.sapporo = true;
            }
            else if (Show_stadium.kamaishi == false)
            {
                lbl_topicDetails.Text = $"All matches in {dtStadium.Rows[4][1].ToString()}";
                Show_stadium.ID = dtStadium.Rows[4][0].ToString();
                showDetailMatch();
                Show_stadium.kamaishi = true;
            }
            else if (Show_stadium.kugamaya == false)
            {
                lbl_topicDetails.Text = $"All matches in {dtStadium.Rows[6][1].ToString()}";
                Show_stadium.ID = dtStadium.Rows[6][0].ToString();
                showDetailMatch();
                Show_stadium.kugamaya = true;
            }
            else if (Show_stadium.tokyo == false)
            {
                lbl_topicDetails.Text = $"All matches in {dtStadium.Rows[dtStadium.Rows.Count - 1][1].ToString()}";
                Show_stadium.ID = dtStadium.Rows[dtStadium.Rows.Count - 1][0].ToString();
                showDetailMatch();
                Show_stadium.tokyo = true;
            }
            else if (Show_stadium.yokohama == false)
            {
                lbl_topicDetails.Text = $"All matches in {dtStadium.Rows[3][1].ToString()}";
                Show_stadium.ID = dtStadium.Rows[3][0].ToString();
                showDetailMatch();
                Show_stadium.yokohama = true;
            }
            else if (Show_stadium.fukuroi == false)
            {
                lbl_topicDetails.Text = $"All matches in {dtStadium.Rows[dtStadium.Rows.Count - 2][1].ToString()}";
                Show_stadium.ID = dtStadium.Rows[dtStadium.Rows.Count - 2][0].ToString();
                showDetailMatch();
                Show_stadium.fukuroi = true;
            }
            else if (Show_stadium.toyota == false)
            {
                lbl_topicDetails.Text = $"All matches in {dtStadium.Rows[0][1].ToString()}";
                Show_stadium.ID = dtStadium.Rows[0][0].ToString();
                showDetailMatch();
                Show_stadium.toyota = true;
            }
            else if (Show_stadium.hanazona == false)
            {
                lbl_topicDetails.Text = $"All matches in {dtStadium.Rows[2][1].ToString()}";
                Show_stadium.ID = dtStadium.Rows[2][0].ToString();
                showDetailMatch();
                Show_stadium.hanazona = true;
            }
            else if (Show_stadium.kobe == false)
            {
                lbl_topicDetails.Text = $"All matches in {dtStadium.Rows[5][1].ToString()}";
                Show_stadium.ID = dtStadium.Rows[5][0].ToString();
                showDetailMatch();
                Show_stadium.kobe = true;
            }
            else if (Show_stadium.oita == false)
            {
                lbl_topicDetails.Text = $"All matches in {dtStadium.Rows[dtStadium.Rows.Count - 4][1].ToString()}";
                Show_stadium.ID = dtStadium.Rows[dtStadium.Rows.Count - 4][0].ToString();
                showDetailMatch();
                Show_stadium.oita = true;
            }
            else if (Show_stadium.kumamoto == false)
            {
                lbl_topicDetails.Text = $"All matches in {dtStadium.Rows[dtStadium.Rows.Count - 5][1].ToString()}";
                Show_stadium.ID = dtStadium.Rows[dtStadium.Rows.Count - 5][0].ToString();
                showDetailMatch();
                Show_stadium.kumamoto = true;
            }
            else if (Show_stadium.fukuoka == false)
            {
                lbl_topicDetails.Text = $"All matches in {dtStadium.Rows[1][1].ToString()}";
                Show_stadium.ID = dtStadium.Rows[1][0].ToString();
                showDetailMatch();
                Show_stadium.fukuoka = true;
            }
            else
                MessageBox.Show("You haven't selected any venue");
         
            
        }
    }
}
