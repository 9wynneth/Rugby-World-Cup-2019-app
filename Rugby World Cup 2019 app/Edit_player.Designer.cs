
namespace Rugby_World_Cup_2019_app
{
    partial class cBox_player
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
            this.cBox_nationality = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBox_team = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBox_playerName = new System.Windows.Forms.TextBox();
            this.tBox_playerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBox_position = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tBox_height = new System.Windows.Forms.TextBox();
            this.tBox_weight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cBox_status = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtPicker_birthdate = new System.Windows.Forms.DateTimePicker();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // round_btn_insertPlayer
            // 
            this.round_btn_insertPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_insertPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_insertPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_insertPlayer.Location = new System.Drawing.Point(47, 233);
            this.round_btn_insertPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.round_btn_insertPlayer.Name = "round_btn_insertPlayer";
            this.round_btn_insertPlayer.Size = new System.Drawing.Size(50, 49);
            this.round_btn_insertPlayer.TabIndex = 12;
            this.round_btn_insertPlayer.Text = "+";
            this.round_btn_insertPlayer.UseVisualStyleBackColor = false;
            this.round_btn_insertPlayer.Click += new System.EventHandler(this.round_btn_insertPlayer_Click);
            // 
            // round_btn_deletePlayer
            // 
            this.round_btn_deletePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_deletePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_deletePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_deletePlayer.Location = new System.Drawing.Point(668, 226);
            this.round_btn_deletePlayer.Margin = new System.Windows.Forms.Padding(2);
            this.round_btn_deletePlayer.Name = "round_btn_deletePlayer";
            this.round_btn_deletePlayer.Size = new System.Drawing.Size(50, 49);
            this.round_btn_deletePlayer.TabIndex = 11;
            this.round_btn_deletePlayer.Text = "DEL";
            this.round_btn_deletePlayer.UseVisualStyleBackColor = false;
            this.round_btn_deletePlayer.Click += new System.EventHandler(this.round_btn_deletePlayer_Click);
            // 
            // dGV_edit_player
            // 
            this.dGV_edit_player.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_edit_player.Location = new System.Drawing.Point(47, 51);
            this.dGV_edit_player.Margin = new System.Windows.Forms.Padding(2);
            this.dGV_edit_player.Name = "dGV_edit_player";
            this.dGV_edit_player.RowHeadersWidth = 62;
            this.dGV_edit_player.RowTemplate.Height = 28;
            this.dGV_edit_player.Size = new System.Drawing.Size(671, 171);
            this.dGV_edit_player.TabIndex = 9;
            this.dGV_edit_player.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_edit_player_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "PLAYER";
            // 
            // round_btn_updatePlayer
            // 
            this.round_btn_updatePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_updatePlayer.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.available_updates_64;
            this.round_btn_updatePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_updatePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_updatePlayer.Location = new System.Drawing.Point(113, 237);
            this.round_btn_updatePlayer.Margin = new System.Windows.Forms.Padding(2);
            this.round_btn_updatePlayer.Name = "round_btn_updatePlayer";
            this.round_btn_updatePlayer.Size = new System.Drawing.Size(47, 46);
            this.round_btn_updatePlayer.TabIndex = 10;
            this.round_btn_updatePlayer.UseVisualStyleBackColor = false;
            this.round_btn_updatePlayer.Click += new System.EventHandler(this.round_btn_updatePlayer_Click);
            // 
            // picBox_edit
            // 
            this.picBox_edit.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.edit_24;
            this.picBox_edit.Location = new System.Drawing.Point(21, 18);
            this.picBox_edit.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_edit.Name = "picBox_edit";
            this.picBox_edit.Size = new System.Drawing.Size(17, 16);
            this.picBox_edit.TabIndex = 7;
            this.picBox_edit.TabStop = false;
            // 
            // cBox_captain
            // 
            this.cBox_captain.FormattingEnabled = true;
            this.cBox_captain.Location = new System.Drawing.Point(334, 556);
            this.cBox_captain.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_captain.Name = "cBox_captain";
            this.cBox_captain.Size = new System.Drawing.Size(105, 21);
            this.cBox_captain.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 562);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "CAPTAIN ID";
            // 
            // cBox_nationality
            // 
            this.cBox_nationality.FormattingEnabled = true;
            this.cBox_nationality.Location = new System.Drawing.Point(373, 288);
            this.cBox_nationality.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_nationality.Name = "cBox_nationality";
            this.cBox_nationality.Size = new System.Drawing.Size(105, 21);
            this.cBox_nationality.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 348);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "HEIGHT";
            // 
            // cBox_team
            // 
            this.cBox_team.FormattingEnabled = true;
            this.cBox_team.Location = new System.Drawing.Point(373, 437);
            this.cBox_team.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_team.Name = "cBox_team";
            this.cBox_team.Size = new System.Drawing.Size(105, 21);
            this.cBox_team.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 442);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "TEAM ID";
            // 
            // tBox_playerName
            // 
            this.tBox_playerName.Location = new System.Drawing.Point(373, 258);
            this.tBox_playerName.Margin = new System.Windows.Forms.Padding(2);
            this.tBox_playerName.Name = "tBox_playerName";
            this.tBox_playerName.Size = new System.Drawing.Size(245, 20);
            this.tBox_playerName.TabIndex = 59;
            // 
            // tBox_playerID
            // 
            this.tBox_playerID.Location = new System.Drawing.Point(373, 226);
            this.tBox_playerID.Margin = new System.Windows.Forms.Padding(2);
            this.tBox_playerID.Name = "tBox_playerID";
            this.tBox_playerID.ReadOnly = true;
            this.tBox_playerID.Size = new System.Drawing.Size(105, 20);
            this.tBox_playerID.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "NATIONALITY ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "PLAYER NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "PLAYER ID:";
            // 
            // tBox_position
            // 
            this.tBox_position.Location = new System.Drawing.Point(373, 320);
            this.tBox_position.Margin = new System.Windows.Forms.Padding(2);
            this.tBox_position.Name = "tBox_position";
            this.tBox_position.Size = new System.Drawing.Size(105, 20);
            this.tBox_position.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 322);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "PLAYER POSITION";
            // 
            // tBox_height
            // 
            this.tBox_height.Location = new System.Drawing.Point(373, 348);
            this.tBox_height.Margin = new System.Windows.Forms.Padding(2);
            this.tBox_height.Name = "tBox_height";
            this.tBox_height.Size = new System.Drawing.Size(105, 20);
            this.tBox_height.TabIndex = 70;
            // 
            // tBox_weight
            // 
            this.tBox_weight.Location = new System.Drawing.Point(373, 378);
            this.tBox_weight.Margin = new System.Windows.Forms.Padding(2);
            this.tBox_weight.Name = "tBox_weight";
            this.tBox_weight.Size = new System.Drawing.Size(105, 20);
            this.tBox_weight.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 380);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "WEIGHT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 410);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "BIRTHDATE";
            // 
            // cBox_status
            // 
            this.cBox_status.FormattingEnabled = true;
            this.cBox_status.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cBox_status.Location = new System.Drawing.Point(373, 463);
            this.cBox_status.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_status.Name = "cBox_status";
            this.cBox_status.Size = new System.Drawing.Size(105, 21);
            this.cBox_status.TabIndex = 76;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(277, 468);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "STATUS";
            // 
            // dtPicker_birthdate
            // 
            this.dtPicker_birthdate.Location = new System.Drawing.Point(373, 406);
            this.dtPicker_birthdate.Margin = new System.Windows.Forms.Padding(2);
            this.dtPicker_birthdate.Name = "dtPicker_birthdate";
            this.dtPicker_birthdate.Size = new System.Drawing.Size(135, 20);
            this.dtPicker_birthdate.TabIndex = 77;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(543, 457);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 96;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cBox_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dtPicker_birthdate);
            this.Controls.Add(this.cBox_status);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tBox_weight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tBox_height);
            this.Controls.Add(this.tBox_position);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cBox_captain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cBox_nationality);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBox_team);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBox_playerName);
            this.Controls.Add(this.tBox_playerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.round_btn_insertPlayer);
            this.Controls.Add(this.round_btn_deletePlayer);
            this.Controls.Add(this.round_btn_updatePlayer);
            this.Controls.Add(this.dGV_edit_player);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_edit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cBox_player";
            this.Size = new System.Drawing.Size(739, 483);
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
        private System.Windows.Forms.ComboBox cBox_nationality;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBox_team;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBox_playerName;
        private System.Windows.Forms.TextBox tBox_playerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBox_position;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBox_height;
        private System.Windows.Forms.TextBox tBox_weight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cBox_status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtPicker_birthdate;
        private System.Windows.Forms.Button submitButton;
    }
}
