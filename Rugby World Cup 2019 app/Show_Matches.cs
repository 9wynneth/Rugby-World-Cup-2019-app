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
    public partial class Show_Matches : UserControl
    {
        public Show_Matches()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtMatches = new DataTable();

        private void Show_Matches_Load(object sender, EventArgs e)
        {
            dataGridView_allMatches.Visible = false;
            sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");
            sqlQuery = $"SELECT m.match_id, m.match_date, Concat((SELECT t.team_name FROM team t WHERE t.team_id = m.teamHome_id), ' VS ',  (SELECT t.team_name FROM team t WHERE t.team_id = m.teamAway_id)) as `MATCH`, m.goal_home, m.goal_away, r.referee_name, s.stadium_name, sum(if (md.type_matchDetail = 'PENALTY',1,0)) as PENALTY, sum(if (md.type_matchDetail = 'TRY',1,0)) as TRY, sum(if (md.type_matchDetail = 'YELLOW CARD',1,0)) as YELLOWCARD, sum(if (md.type_matchDetail = 'RED CARD',1,0)) as REDCARD, sum(if (md.type_matchDetail = 'CONVERSION',1,0)) as CONVERSION, sum(if (md.type_matchDetail = 'MISSED CONVERSION',1,0)) as MISSEDCONVERSION,sum(if (md.type_matchDetail = 'DROP GOAL',1,0)) as DROPGOAL FROM `MATCH` m, referee r, stadium s, matchdetail md WHERE r.referee_id = m.referee_id and s.stadium_id = m.stadium_id and m.match_id = md.match_id GROUP BY 1; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatches);
            //listOfMatches();
        }

        //Panel pnl_matchesList = new Panel();
        //private void listOfMatches()
        //{
        //    List<Panel> matchesList = new List<Panel>();
        //    for (int i = 0; i <= dtMatches.Rows.Count - 1; i++)
        //    {
        //        //Label refereeID = new Label();
        //        //refereeID.Text = dtReferee.Rows[i][0].ToString();
        //        //refereeID.Location = new Point(10, refereeID.Location.Y + 5);
        //        //refereeID.BackColor = Color.Transparent;
        //        //refereeID.ForeColor = Color.White;

        //        //Label refereeName = new Label();
        //        //refereeName.Text = dtReferee.Rows[i][1].ToString();
        //        //refereeName.Location = new Point(10, refereeName.Location.Y + 35);
        //        //refereeName.BackColor = Color.Transparent;
        //        //refereeName.ForeColor = Color.White;

        //        //Label refereeNationality = new Label();
        //        //refereeNationality.Text = dtReferee.Rows[i][2].ToString();
        //        //refereeNationality.Location = new Point(25, refereeName.Location.Y + 25);
        //        //refereeNationality.BackColor = Color.Transparent;
        //        //refereeNationality.ForeColor = Color.White;

        //        //Label refereeNationABV = new Label();
        //        //refereeNationABV.Text = dtReferee.Rows[i][3].ToString();
        //        //refereeNationABV.Location = new Point(450, refereeName.Location.Y);
        //        //refereeNationABV.BackColor = Color.Transparent;
        //        //refereeNationABV.ForeColor = Color.White;

        //        //PictureBox refereePic = new PictureBox();
        //        //refereePic.Name = "picBox_referee" + i;
        //        //refereePic.Size = new Size(80, 80);
        //        //refereePic.Location = new Point(150, refereeNationABV.Location.Y - 30);
        //        //string picNameReferee = $"Referee_{refereeID.Text}";
        //        //object getPicReferee = Properties.Resources.ResourceManager.GetObject(picNameReferee); ; //Return an object from the image chan1.png in the project
        //        //refereePic.Image = (Image)getPicReferee;
        //        //refereePic.BackColor = Color.Transparent;
        //        //refereePic.SizeMode = PictureBoxSizeMode.StretchImage;

             

        //        pnl_matchesList = new Panel();
        //        pnl_matchesList.Name = "pnl_referee" + i;
        //        matchesList.Add(pnl_matchesList);
        //        pnl_matchesList.Location = new Point(80, i * 100 + 30);
        //        pnl_matchesList.Size = new Size(500, 90);
        //        //pnl_matchesList.Controls.Add(refereeID);
        //        //pnl_matchesList.Controls.Add(refereeName);
        //        //pnl_matchesList.Controls.Add(refereeNationality);
        //        //pnl_matchesList.Controls.Add(refereeNationABV);
        //        //pnl_matchesList.Controls.Add(refereePic);
        //        //pnl_matchesList.Controls.Add(nationalityPic);
        //        pnl_matchesList.BackgroundImage = Properties.Resources.image_2_;

        //        this.Controls.Add(pnl_matchesList);
        //    }
        //}

        private void btn_matchesTable_Click(object sender, EventArgs e)
        {
           // pnl_matchesList.Visible = false;

            dataGridView_allMatches.DataSource = dtMatches;
            dataGridView_allMatches.Visible = true;
            dataGridView_allMatches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
