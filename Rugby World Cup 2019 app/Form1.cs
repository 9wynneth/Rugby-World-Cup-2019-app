using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Media;
using MySql.Data.MySqlClient;

namespace Rugby_World_Cup_2019_app
{
    public partial class Form_Intro : Form
    {
        public Form_Intro()
        {
            InitializeComponent();
        }


        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=dbd_07_rwc2019");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        Form_Security formAccess = new Form_Security();
        Form_Tampilan formTampilan = new Form_Tampilan();
        Form_Edit formEdit = new Form_Edit();

        private void roundBtn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*
        private void playMusic()
        {
            //SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\Gwynneth Isviandhy\Music\rwcthemesong.wav");
            //Console.WriteLine(System.AppDomain.CurrentDomain.BaseDirectory);
            //string music= System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, @"..\..\asset\rwcthemesong.wav");
            //Console.WriteLine(music);
            //SoundPlayer soundPlayer = new SoundPlayer(music);
            
            if (cBox_btn_music.Checked == false)
            {
                soundPlayer.Stop();
            }
            else
            {
                soundPlayer.Play();
            }
        }
        */
        private void Form_Intro_Load(object sender, EventArgs e)
        {
          
            //playMusic();
        }

        private void cBox_btn_music_CheckedChanged(object sender, EventArgs e)
        {
           // playMusic();
        }

        private void roundBtn_cont_Click(object sender, EventArgs e)
        {
            this.Hide();
            formTampilan.ShowDialog();
        }

        private void roundBtn_edit_Click_1(object sender, EventArgs e)
        {
            formAccess.ShowDialog();
 
        }
    }
}
