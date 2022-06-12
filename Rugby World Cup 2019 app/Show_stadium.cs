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
    public partial class Show_stadium : UserControl
    {
        public Show_stadium()
        {
            InitializeComponent();
        }



        public MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dbd_07_rwc2019");
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtStadium = new DataTable();

        private void Show_stadium_Load(object sender, EventArgs e)
        {
            hide();
            sqlQuery = "SELECT s.stadium_name, s.city, Concat(left(s.capacity, 3), ',',right(s.capacity,3)) as capacity, s.stadium_id FROM stadium s; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStadium);

        }

        private void hide()
        {
            pnl_popUp.Visible = false;
            picBox_stadium.Visible = false;
        }

        private void btn_sapporo_MouseHover(object sender, EventArgs e)
        {
            hide();
            lbl_city.Text = dtStadium.Rows[9][1].ToString();
            lbl_name.Text = dtStadium.Rows[9][0].ToString();
            lbl_capacity.Text = dtStadium.Rows[9][2].ToString();
            picBox_stadium.Image = Properties.Resources.Sapporo_Dome;
            picBox_stadium.Refresh();
            pnl_popUp.Location = new Point(303, 72);
            picBox_stadium.Visible = true;
            pnl_popUp.Visible = true;
        }

        private void btn_sapporo_MouseLeave(object sender, EventArgs e)
        {
            hide();
        }

        private void btn_kamaishi_MouseHover(object sender, EventArgs e)
        {
            hide();
            lbl_city.Text = dtStadium.Rows[4][1].ToString();
            lbl_name.Text = dtStadium.Rows[4][0].ToString();
            lbl_capacity.Text = dtStadium.Rows[4][2].ToString();
            picBox_stadium.Image = Properties.Resources.Kamaishi_Recovery_Memorial_Stadium;
            picBox_stadium.Refresh();
            pnl_popUp.Location = new Point(477, 130);
            picBox_stadium.Visible = true;
            pnl_popUp.Visible = true;
        }

        private void btn_kamaishi_MouseLeave(object sender, EventArgs e)
        {
            hide();
           
        }

        private void btn_kugamaya_MouseHover(object sender, EventArgs e)
        {
            hide();
            lbl_city.Text = dtStadium.Rows[6][1].ToString();
            lbl_name.Text = dtStadium.Rows[6][0].ToString();
            lbl_capacity.Text = dtStadium.Rows[6][2].ToString();
            picBox_stadium.Image = Properties.Resources.Kumagaya_Rugby_Stadium;
            picBox_stadium.Refresh();
            pnl_popUp.Location = new Point(477, 185);
            picBox_stadium.Visible = true;
            pnl_popUp.Visible = true;
        }

        private void btn_kugamaya_MouseLeave(object sender, EventArgs e)
        {
            hide();
        }

        private void btn_tokyo_MouseHover(object sender, EventArgs e)
        {
            hide();
            lbl_city.Text = dtStadium.Rows[dtStadium.Rows.Count-1][1].ToString();
            lbl_name.Text = dtStadium.Rows[dtStadium.Rows.Count - 1][0].ToString();
            lbl_capacity.Text = dtStadium.Rows[dtStadium.Rows.Count - 1][2].ToString();
            picBox_stadium.Image = Properties.Resources.Tokyo_Stadium;
            picBox_stadium.Refresh();
            pnl_popUp.Location = new Point(477, 225);
            picBox_stadium.Visible = true;
            pnl_popUp.Visible = true;
        }

        private void btn_tokyo_MouseLeave(object sender, EventArgs e)
        {
            hide();
        }

        private void btn_yokohama_MouseHover(object sender, EventArgs e)
        {
            hide();
            lbl_city.Text = dtStadium.Rows[3][1].ToString();
            lbl_name.Text = dtStadium.Rows[3][0].ToString();
            lbl_capacity.Text = dtStadium.Rows[3][2].ToString();
            picBox_stadium.Image = Properties.Resources._375px_Nissan_International_Stadium_Yokohama;
            picBox_stadium.Refresh();
            pnl_popUp.Location = new Point(477, 269);
            picBox_stadium.Visible = true;
            pnl_popUp.Visible = true;
        }

        private void btn_yokohama_MouseLeave(object sender, EventArgs e)
        {
            hide();
        }

        private void btn_fukuroi_MouseHover(object sender, EventArgs e)
        {
            hide();
            lbl_city.Text = dtStadium.Rows[dtStadium.Rows.Count - 2][1].ToString();
            lbl_name.Text = dtStadium.Rows[dtStadium.Rows.Count - 2][0].ToString();
            lbl_capacity.Text = dtStadium.Rows[dtStadium.Rows.Count - 2][2].ToString();
            picBox_stadium.Image = Properties.Resources.Shizuoka_Stadium_Ecopa;
            picBox_stadium.Refresh();
            pnl_popUp.Location = new Point(477, 300);
            picBox_stadium.Visible = true;
            pnl_popUp.Visible = true;
        }

        private void btn_fukuroi_MouseLeave(object sender, EventArgs e)
        {
            hide();
        }

       
        private void btn_toyota_MouseHover(object sender, EventArgs e)
        {
            hide();
            lbl_city.Text = dtStadium.Rows[0][1].ToString();
            lbl_name.Text = dtStadium.Rows[0][0].ToString();
            lbl_capacity.Text = dtStadium.Rows[0][2].ToString();
            picBox_stadium.Image = Properties.Resources.city_of_toyota;
            picBox_stadium.Refresh();
            pnl_popUp.Location = new Point(313, 300);
            picBox_stadium.Visible = true;
            pnl_popUp.Visible = true;
        }

        private void btn_toyota_MouseLeave(object sender, EventArgs e)
        {
            hide();
        }

        private void btn_hanazona_MouseHover(object sender, EventArgs e)
        {
            hide();
            lbl_city.Text = dtStadium.Rows[2][1].ToString();
            lbl_name.Text = dtStadium.Rows[2][0].ToString();
            lbl_capacity.Text = dtStadium.Rows[2][2].ToString();
            picBox_stadium.Image = Properties.Resources.Hanazono_Rugby_Stadium;
            picBox_stadium.Refresh();
            pnl_popUp.Location = new Point(219, 300);
            picBox_stadium.Visible = true;
            pnl_popUp.Visible = true;
        }

        private void btn_hanazona_MouseLeave(object sender, EventArgs e)
        {
            hide();
        }

        private void btn_kobe_MouseHover(object sender, EventArgs e)
        {
            hide();
            lbl_city.Text = dtStadium.Rows[5][1].ToString();
            lbl_name.Text = dtStadium.Rows[5][0].ToString();
            lbl_capacity.Text = dtStadium.Rows[5][2].ToString();
            picBox_stadium.Image = Properties.Resources.Kobe_Misaki_Stadium;
            picBox_stadium.Refresh();
            pnl_popUp.Location = new Point(198, 120);
            picBox_stadium.Visible = true;
            pnl_popUp.Visible = true;
        }

        private void btn_oita_MouseHover(object sender, EventArgs e)
        {
            hide();
            lbl_city.Text = dtStadium.Rows[dtStadium.Rows.Count - 4][1].ToString();
            lbl_name.Text = dtStadium.Rows[dtStadium.Rows.Count - 4][0].ToString();
            lbl_capacity.Text = dtStadium.Rows[dtStadium.Rows.Count - 4][2].ToString();
            picBox_stadium.Image = Properties.Resources.Oita_Stadium;
            picBox_stadium.Refresh();
            pnl_popUp.Location = new Point(168, 284);
            picBox_stadium.Visible = true;
            pnl_popUp.Visible = true;
        }

        private void btn_kobe_MouseLeave(object sender, EventArgs e)
        {
            hide();
        }

        private void btn_oita_MouseLeave(object sender, EventArgs e)
        {
            hide();
        }
        
        private void btn_kumamoto_MouseHover(object sender, EventArgs e)
        {
            hide();
            lbl_city.Text = dtStadium.Rows[dtStadium.Rows.Count - 5][1].ToString();
            lbl_name.Text = dtStadium.Rows[dtStadium.Rows.Count - 5][0].ToString();
            lbl_capacity.Text = dtStadium.Rows[dtStadium.Rows.Count - 5][2].ToString();
            picBox_stadium.Image = Properties.Resources.Kumamoto_Stadium;
            picBox_stadium.Refresh();
            pnl_popUp.Location = new Point(76, 300);
            picBox_stadium.Visible = true;
            pnl_popUp.Visible = true;
        }

        private void btn_kumamoto_MouseLeave(object sender, EventArgs e)
        {
            hide();
        }

        private void btn_fukuoka_MouseHover(object sender, EventArgs e)
        {
            hide();
            lbl_city.Text = dtStadium.Rows[1][1].ToString();
            lbl_name.Text = dtStadium.Rows[1][0].ToString();
            lbl_capacity.Text = dtStadium.Rows[1][2].ToString();
            picBox_stadium.Image = Properties.Resources.Fukuoka_Hakatanomori_Stadium;
            picBox_stadium.Refresh();
            pnl_popUp.Location = new Point(102, 146);
            picBox_stadium.Visible = true;
            pnl_popUp.Visible = true;
        }

        private void btn_fukuoka_MouseLeave(object sender, EventArgs e)
        {
            hide();
        }

        Show_details showDetails = new Show_details();

        public static bool sapporo=true;
        public static string sapporoID="";
      
        public void btn_sapporo_Click(object sender, EventArgs e)
        {
            sapporo = false;
            sapporoID= dtStadium.Rows[9][3].ToString();
            
            showDetails.ShowDialog();
          
        }
    }
}
