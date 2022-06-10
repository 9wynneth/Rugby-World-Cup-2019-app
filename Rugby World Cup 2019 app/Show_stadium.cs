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
            sqlQuery = "SELECT s.stadium_name, s.city, Concat(left(s.capacity, 3), ',',right(s.capacity,3)) as capacity FROM stadium s; ";
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
    }
}
