
namespace Rugby_World_Cup_2019_app
{
    partial class Edit_player
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.round_btn_insertPlayer = new Rugby_World_Cup_2019_app.RoundButton();
            this.round_btn_deletePlayer = new Rugby_World_Cup_2019_app.RoundButton();
            this.dGV_edit_player = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.round_btn_updatePlayer = new Rugby_World_Cup_2019_app.RoundButton();
            this.picBox_edit = new System.Windows.Forms.PictureBox();
            this.cBox_captain = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBox_Assmanager = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBox_manager = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBox_refereeName = new System.Windows.Forms.TextBox();
            this.tBox_refereeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // round_btn_insertPlayer
            // 
            this.round_btn_insertPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_insertPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_insertPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_insertPlayer.Location = new System.Drawing.Point(70, 359);
            this.round_btn_insertPlayer.Name = "round_btn_insertPlayer";
            this.round_btn_insertPlayer.Size = new System.Drawing.Size(75, 75);
            this.round_btn_insertPlayer.TabIndex = 12;
            this.round_btn_insertPlayer.Text = "+";
            this.round_btn_insertPlayer.UseVisualStyleBackColor = false;
            // 
            // round_btn_deletePlayer
            // 
            this.round_btn_deletePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_deletePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_deletePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_deletePlayer.Location = new System.Drawing.Point(1002, 347);
            this.round_btn_deletePlayer.Name = "round_btn_deletePlayer";
            this.round_btn_deletePlayer.Size = new System.Drawing.Size(75, 75);
            this.round_btn_deletePlayer.TabIndex = 11;
            this.round_btn_deletePlayer.Text = "DEL";
            this.round_btn_deletePlayer.UseVisualStyleBackColor = false;
            this.round_btn_deletePlayer.Click += new System.EventHandler(this.round_btn_deletePlayer_Click);
            // 
            // dGV_edit_player
            // 
            this.dGV_edit_player.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_edit_player.Location = new System.Drawing.Point(70, 78);
            this.dGV_edit_player.Name = "dGV_edit_player";
            this.dGV_edit_player.RowHeadersWidth = 62;
            this.dGV_edit_player.RowTemplate.Height = 28;
            this.dGV_edit_player.Size = new System.Drawing.Size(1007, 263);
            this.dGV_edit_player.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "PLAYER";
            // 
            // round_btn_updatePlayer
            // 
            this.round_btn_updatePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_updatePlayer.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.available_updates_64;
            this.round_btn_updatePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_updatePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_updatePlayer.Location = new System.Drawing.Point(170, 364);
            this.round_btn_updatePlayer.Name = "round_btn_updatePlayer";
            this.round_btn_updatePlayer.Size = new System.Drawing.Size(70, 70);
            this.round_btn_updatePlayer.TabIndex = 10;
            this.round_btn_updatePlayer.UseVisualStyleBackColor = false;
            this.round_btn_updatePlayer.Click += new System.EventHandler(this.round_btn_updatePlayer_Click);
            // 
            // picBox_edit
            // 
            this.picBox_edit.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.edit_24;
            this.picBox_edit.Location = new System.Drawing.Point(32, 27);
            this.picBox_edit.Name = "picBox_edit";
            this.picBox_edit.Size = new System.Drawing.Size(25, 24);
            this.picBox_edit.TabIndex = 7;
            this.picBox_edit.TabStop = false;
            // 
            // cBox_captain
            // 
            this.cBox_captain.FormattingEnabled = true;
            this.cBox_captain.Location = new System.Drawing.Point(501, 856);
            this.cBox_captain.Name = "cBox_captain";
            this.cBox_captain.Size = new System.Drawing.Size(155, 28);
            this.cBox_captain.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 864);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "CAPTAIN ID";
            // 
            // cBox_Assmanager
            // 
            this.cBox_Assmanager.FormattingEnabled = true;
            this.cBox_Assmanager.Location = new System.Drawing.Point(559, 443);
            this.cBox_Assmanager.Name = "cBox_Assmanager";
            this.cBox_Assmanager.Size = new System.Drawing.Size(155, 28);
            this.cBox_Assmanager.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "HEIGHT";
            // 
            // cBox_manager
            // 
            this.cBox_manager.FormattingEnabled = true;
            this.cBox_manager.Location = new System.Drawing.Point(559, 672);
            this.cBox_manager.Name = "cBox_manager";
            this.cBox_manager.Size = new System.Drawing.Size(155, 28);
            this.cBox_manager.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 680);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "TEAM ID";
            // 
            // tBox_refereeName
            // 
            this.tBox_refereeName.Location = new System.Drawing.Point(559, 397);
            this.tBox_refereeName.Name = "tBox_refereeName";
            this.tBox_refereeName.Size = new System.Drawing.Size(366, 26);
            this.tBox_refereeName.TabIndex = 59;
            // 
            // tBox_refereeID
            // 
            this.tBox_refereeID.Location = new System.Drawing.Point(559, 347);
            this.tBox_refereeID.Name = "tBox_refereeID";
            this.tBox_refereeID.Size = new System.Drawing.Size(155, 26);
            this.tBox_refereeID.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "NATIONALITY ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "PLAYER NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "PLAYER ID:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(559, 493);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 26);
            this.textBox3.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(337, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "PLAYER POSITION";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(559, 536);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 26);
            this.textBox1.TabIndex = 70;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(559, 581);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 26);
            this.textBox4.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 72;
            this.label8.Text = "WEIGHT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 630);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 71;
            this.label10.Text = "BIRTHDATE";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(559, 712);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 28);
            this.comboBox1.TabIndex = 76;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 720);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 75;
            this.label11.Text = "STATUS";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(559, 624);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 77;
            // 
            // Edit_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cBox_captain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cBox_Assmanager);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBox_manager);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBox_refereeName);
            this.Controls.Add(this.tBox_refereeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.round_btn_insertPlayer);
            this.Controls.Add(this.round_btn_deletePlayer);
            this.Controls.Add(this.round_btn_updatePlayer);
            this.Controls.Add(this.dGV_edit_player);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_edit);
            this.Name = "Edit_player";
            this.Size = new System.Drawing.Size(1109, 743);
            this.Load += new System.EventHandler(this.Edit_player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton round_btn_insertPlayer;
        private RoundButton round_btn_deletePlayer;
        private RoundButton round_btn_updatePlayer;
        private System.Windows.Forms.DataGridView dGV_edit_player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox_edit;
        private System.Windows.Forms.ComboBox cBox_captain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBox_Assmanager;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBox_manager;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBox_refereeName;
        private System.Windows.Forms.TextBox tBox_refereeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
