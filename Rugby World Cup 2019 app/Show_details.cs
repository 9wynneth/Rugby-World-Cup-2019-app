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

        DataTable dtRedCardDetail = new DataTable();

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


        private void Show_details_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
            sqlQuery = "SELECT p.player_name as Player, n.country_name as Nationality ,Count(md.type_matchDetail) as 'Red Card' FROM player p, matchDetail md, nationality n WHERE p.player_id = md.player_id and n.nationality_id = p.nationality_id and md.type_matchDetail = 'RED CARD' group by 1 order by 2 desc; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtRedCardDetail);

            Show_tournamentStats showStats = new Show_tournamentStats();
            if (showStats.detailRedCards==true)
            {
                dGV_ShowDetails.DataSource = dtRedCardDetail;
            }
        }
    }
}
