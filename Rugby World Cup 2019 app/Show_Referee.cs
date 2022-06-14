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
    public partial class Show_Referee : UserControl
    {
        public Show_Referee()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtReferee = new DataTable();

        private void Show_Referee_Load(object sender, EventArgs e)
        {
            tBox_refereeSearch.Hide();
            sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");
            sqlQuery = $"SELECT r.referee_id as 'REFEREE ID', r.referee_name as 'REFEREE NAME', n.country_name as NATIONALITY, n.country_code as ABV FROM referee r, nationality n WHERE n.nationality_id = r.nationality_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtReferee);
            listOfReferee();
        
        }

        private void listOfReferee()
        {
            List<Panel> refereeList = new List<Panel>();
            for (int i = 0; i <= dtReferee.Rows.Count - 1; i++)
            {
                Label refereeID = new Label();
                refereeID.Text = dtReferee.Rows[i][0].ToString();
                refereeID.Location = new Point(10, refereeID.Location.Y + 5);
                refereeID.BackColor = Color.Transparent;
                refereeID.ForeColor = Color.White;

                Label refereeName = new Label();
                refereeName.Text = dtReferee.Rows[i][1].ToString();
                refereeName.Location = new Point(10, refereeName.Location.Y + 35);
                refereeName.BackColor = Color.Transparent;
                refereeName.ForeColor = Color.White;

                Label refereeNationality = new Label();
                refereeNationality.Text = dtReferee.Rows[i][2].ToString();
                refereeNationality.Location = new Point(25, refereeName.Location.Y + 25);
                refereeNationality.BackColor = Color.Transparent;
                refereeNationality.ForeColor = Color.White;

                Label refereeNationABV = new Label();
                refereeNationABV.Text = dtReferee.Rows[i][3].ToString();
                refereeNationABV.Location = new Point(450, refereeName.Location.Y);
                refereeNationABV.BackColor = Color.Transparent;
                refereeNationABV.ForeColor = Color.White;

                PictureBox refereePic = new PictureBox();
                refereePic.Name = "picBox_referee" + i;
                refereePic.Size = new Size(80, 80);
                refereePic.Location = new Point(150, refereeNationABV.Location.Y - 30);
                string picNameReferee = $"Referee_{refereeID.Text}";
                object getPicReferee = Properties.Resources.ResourceManager.GetObject(picNameReferee); ; //Return an object from the image chan1.png in the project
                refereePic.Image = (Image)getPicReferee;
                refereePic.BackColor = Color.Transparent;
                refereePic.SizeMode = PictureBoxSizeMode.StretchImage;

                PictureBox nationalityPic = new PictureBox();
                nationalityPic.Name = "picBox_flag" + i;
                nationalityPic.Size = new Size(100, 50);
                nationalityPic.Location = new Point(300, refereeNationABV.Location.Y - 15);
                string picNameFlag = refereeNationality.Text;
                picNameFlag =  picNameFlag.Replace(" ", "_");
                object getPicFlag = Properties.Resources.ResourceManager.GetObject(picNameFlag); //Return an object from the image chan1.png in the project
                nationalityPic.Image = (Image)getPicFlag;
                nationalityPic.BackColor = Color.Transparent;
                nationalityPic.SizeMode = PictureBoxSizeMode.StretchImage;

                Panel pnl_refereeList = new Panel();
                pnl_refereeList.Name = "pnl_referee" + i;
                refereeList.Add(pnl_refereeList);
                pnl_refereeList.Location = new Point(80, i * 100 + 30);
                pnl_refereeList.Size = new Size(500, 90);
                pnl_refereeList.Controls.Add(refereeID);
                pnl_refereeList.Controls.Add(refereeName);
                pnl_refereeList.Controls.Add(refereeNationality);
                pnl_refereeList.Controls.Add(refereeNationABV);
                pnl_refereeList.Controls.Add(refereePic);
                pnl_refereeList.Controls.Add(nationalityPic);
                pnl_refereeList.BackgroundImage = Properties.Resources.image_2_;

                this.Controls.Add(pnl_refereeList);
            }
        }
        public static string check = "";

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tBox_refereeSearch.Show();
            tBox_refereeSearch.Enabled = false;
        }

        private void iDToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tBox_refereeSearch.Show();
            tBox_refereeSearch.Enabled = true;
            check = "Search_ID";
            
        }

        private void tBox_refereeSearch_TextChanged(object sender, EventArgs e)
        {
            if (check=="Search_ID")
            sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");
            sqlQuery = $"SELECT r.referee_id as 'REFEREE ID', r.referee_name as 'REFEREE NAME', n.country_name as NATIONALITY, n.country_code as ABV FROM referee r, nationality n WHERE n.nationality_id = r.nationality_id and r.referee_id like '{tBox_refereeSearch.Text}%';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtReferee);
            listOfReferee();
        }
    }
}
