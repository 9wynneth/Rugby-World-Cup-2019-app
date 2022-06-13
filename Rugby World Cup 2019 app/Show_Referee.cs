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
            sqlQuery = $"SELECT * FROM REFEREE ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtReferee);

            List<Panel> refereeList = new List<Panel>();
            for (int i = 0; i <= dtReferee.Rows.Count - 1; i++)
            {
                Panel pnl_refereeList = new Panel();
                pnl_refereeList.Name = "panel" + i;
                refereeList.Add(pnl_refereeList);
                Label refereeName = new Label();
                refereeName.Text = dtReferee.Rows[i][1].ToString();
                refereeName.BackColor = Color.Transparent;
                refereeName.ForeColor = Color.White;
                Label referee = new Label();
                referee.Text = dtReferee.Rows[i][2].ToString();
                referee.Location = new Point(10,refereeName.Location.Y+25);
                referee.BackColor = Color.Transparent;
                referee.ForeColor = Color.White;

                pnl_refereeList.Location = new Point(10, i * 100);
                pnl_refereeList.Size = new Size(200, 90);  // just an example
                pnl_refereeList.Controls.Add(refereeName);
                pnl_refereeList.Controls.Add(referee);
                pnl_refereeList.BackColor = Color.Black;
               

                this.Controls.Add(pnl_refereeList);

            }
        }

        public void DataTeamDetail(int DataKe)
        {
           

        }
    }
}
