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

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        Show_tournamentStats showStats = new Show_tournamentStats();
        Show_stadium showStadium = new Show_stadium();

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
            dGV_ShowDetails.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dGV_ShowDetails.EnableHeadersVisualStyles = false;
            dGV_ShowDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dGV_ShowDetails.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dGV_ShowDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dGV_ShowDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public  DataGridView dGV = new DataGridView();

        private void Show_details_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
            sqlQuery = "SELECT p.player_name as Player, n.country_name as Nationality ,Count(md.type_matchDetail) as 'Red Card' FROM player p, matchDetail md, nationality n WHERE p.player_id = md.player_id and n.nationality_id = p.nationality_id and md.type_matchDetail = 'RED CARD' group by 1 order by 2 desc; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtRedCardDetail);
          
            MessageBox.Show(Show_tournamentStats.detailRedCards.ToString());
            MessageBox.Show(Show_stadium.sapporo.ToString());


            if (Show_tournamentStats.detailRedCards==false)
            {
                dGV_ShowDetails.DataSource = dtRedCardDetail;
                Show_tournamentStats.detailRedCards = true;
            }
            else if (Show_stadium.sapporo==false)
            {
                sqlQuery = $"SELECT m.match_id, m.match_date, r.referee_name, Concat((SELECT t.team_name FROM team t WHERE t.team_id = m.teamHome_id), ' VS ',  (SELECT t.team_name FROM team t WHERE t.team_id = m.teamAway_id)) as `MATCH`,  concat(m.goal_home, ' - ', m.goal_away) FROM stadium s, `match` m, referee r WHERE m.referee_id = r.referee_id and s.stadium_id = m.stadium_id and s.stadium_id = '{Show_stadium.sapporoID}' group by 1;  ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtStadium);

                dGV_ShowDetails.DataSource = dtStadium;
            }
            
            
        }
    }
}
