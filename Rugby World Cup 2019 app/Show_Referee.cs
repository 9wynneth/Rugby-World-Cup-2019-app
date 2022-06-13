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
            sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dBd_07_rwc2019");
            sqlQuery = $"SELECT r.referee_id as 'REFEREE ID', r.referee_name as 'REFEREE NAME', n.country_name as NATIONALITY, n.country_code as ABV FROM referee r, nationality n WHERE n.nationality_id = r.nationality_id; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtReferee);

            List<Panel> refereeList = new List<Panel>();
            for (int i = 0; i <= dtReferee.Rows.Count-1; i++)
            {
                
                Label refereeID = new Label();
                refereeID.Text = dtReferee.Rows[i][0].ToString();
                refereeID.Location = new Point(10, refereeID.Location.Y + 5);
                refereeID.BackColor = Color.Transparent;
                refereeID.ForeColor = Color.White;
                
                Label refereeName = new Label();
                refereeName.Text = dtReferee.Rows[i][1].ToString();
                refereeName.Location = new Point(10,refereeName.Location.Y+35);
                refereeName.BackColor = Color.Transparent;
                refereeName.ForeColor = Color.White;

                Label refereeNationality = new Label();
                refereeNationality.Text = dtReferee.Rows[i][2].ToString();
                refereeNationality.Location = new Point(25, refereeName.Location.Y+25);
                refereeNationality.BackColor = Color.Transparent;
                refereeNationality.ForeColor = Color.White;

                Label refereeNationABV = new Label();
                refereeNationABV.Text = dtReferee.Rows[i][3].ToString();
                refereeNationABV.Location = new Point(450, refereeName.Location.Y);
                refereeNationABV.BackColor = Color.Transparent;
                refereeNationABV.ForeColor = Color.White;

                PictureBox nationalityPic = new PictureBox();
                nationalityPic.Name = "picBox_flag"+i;
                nationalityPic.Size = new Size(50, 50);
                nationalityPic.Location = new Point(350, refereeNationABV.Location.Y-10);

                string getPic = $"Referee_{refereeID.Text}";
                object O = Properties.Resources.ResourceManager.GetObject(getPic); //Return an object from the image chan1.png in the project
                nationalityPic.Image = (Image)O;
                nationalityPic.BackColor = Color.Transparent;
                nationalityPic.SizeMode = PictureBoxSizeMode.StretchImage;

                Panel pnl_refereeList = new Panel();
                pnl_refereeList.Name = "pnl_referee" + i;
                refereeList.Add(pnl_refereeList);
                pnl_refereeList.Location = new Point(80, i * 100);
                pnl_refereeList.Size = new Size(500, 90);  
                pnl_refereeList.Controls.Add(refereeID);
                pnl_refereeList.Controls.Add(refereeName);
                pnl_refereeList.Controls.Add(refereeNationality);
                pnl_refereeList.Controls.Add(refereeNationABV);
                pnl_refereeList.Controls.Add(nationalityPic);
                pnl_refereeList.BackgroundImage = Properties.Resources.image_2_;
                
                this.Controls.Add(pnl_refereeList);
            }
        }

        public void DataTeamDetail(int DataKe)
        {
           

        }
    }
}
