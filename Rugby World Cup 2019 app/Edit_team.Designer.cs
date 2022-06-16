
namespace Rugby_World_Cup_2019_app
{
    partial class Edit_team
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
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_edit_team = new System.Windows.Forms.DataGridView();
            this.round_btn_deleteTeam = new Rugby_World_Cup_2019_app.RoundButton();
            this.picBox_edit = new System.Windows.Forms.PictureBox();
            this.round_btn_insertManager = new Rugby_World_Cup_2019_app.RoundButton();
            this.tBox_refereeName = new System.Windows.Forms.TextBox();
            this.tBox_refereeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.round_btn_updateReferee = new Rugby_World_Cup_2019_app.RoundButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBox_manager = new System.Windows.Forms.ComboBox();
            this.cBox_Assmanager = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBox_captain = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_team)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "TEAM";
            // 
            // dGV_edit_team
            // 
            this.dGV_edit_team.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_edit_team.Location = new System.Drawing.Point(52, 68);
            this.dGV_edit_team.Name = "dGV_edit_team";
            this.dGV_edit_team.RowHeadersWidth = 62;
            this.dGV_edit_team.RowTemplate.Height = 28;
            this.dGV_edit_team.Size = new System.Drawing.Size(1007, 338);
            this.dGV_edit_team.TabIndex = 2;
            // 
            // round_btn_deleteTeam
            // 
            this.round_btn_deleteTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_deleteTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_deleteTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_deleteTeam.Location = new System.Drawing.Point(984, 423);
            this.round_btn_deleteTeam.Name = "round_btn_deleteTeam";
            this.round_btn_deleteTeam.Size = new System.Drawing.Size(75, 75);
            this.round_btn_deleteTeam.TabIndex = 5;
            this.round_btn_deleteTeam.Text = "DEL";
            this.round_btn_deleteTeam.UseVisualStyleBackColor = false;
            this.round_btn_deleteTeam.Click += new System.EventHandler(this.round_btn_deleteTeam_Click);
            // 
            // picBox_edit
            // 
            this.picBox_edit.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.edit_24;
            this.picBox_edit.Location = new System.Drawing.Point(14, 12);
            this.picBox_edit.Name = "picBox_edit";
            this.picBox_edit.Size = new System.Drawing.Size(25, 24);
            this.picBox_edit.TabIndex = 0;
            this.picBox_edit.TabStop = false;
            // 
            // round_btn_insertManager
            // 
            this.round_btn_insertManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_insertManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.round_btn_insertManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_insertManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_insertManager.Location = new System.Drawing.Point(50, 423);
            this.round_btn_insertManager.Name = "round_btn_insertManager";
            this.round_btn_insertManager.Size = new System.Drawing.Size(63, 61);
            this.round_btn_insertManager.TabIndex = 47;
            this.round_btn_insertManager.Text = "+";
            this.round_btn_insertManager.UseVisualStyleBackColor = false;
            // 
            // tBox_refereeName
            // 
            this.tBox_refereeName.Location = new System.Drawing.Point(521, 500);
            this.tBox_refereeName.Name = "tBox_refereeName";
            this.tBox_refereeName.Size = new System.Drawing.Size(366, 26);
            this.tBox_refereeName.TabIndex = 45;
            // 
            // tBox_refereeID
            // 
            this.tBox_refereeID.Location = new System.Drawing.Point(521, 450);
            this.tBox_refereeID.Name = "tBox_refereeID";
            this.tBox_refereeID.Size = new System.Drawing.Size(155, 26);
            this.tBox_refereeID.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "WORLD RANKING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "TEAM NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "TEAM ID:";
            // 
            // round_btn_updateReferee
            // 
            this.round_btn_updateReferee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_updateReferee.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.available_updates_64;
            this.round_btn_updateReferee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_updateReferee.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_updateReferee.Location = new System.Drawing.Point(145, 423);
            this.round_btn_updateReferee.Name = "round_btn_updateReferee";
            this.round_btn_updateReferee.Size = new System.Drawing.Size(70, 70);
            this.round_btn_updateReferee.TabIndex = 39;
            this.round_btn_updateReferee.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(521, 546);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 26);
            this.textBox1.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "MANAGER ID";
            // 
            // cBox_manager
            // 
            this.cBox_manager.FormattingEnabled = true;
            this.cBox_manager.Location = new System.Drawing.Point(521, 597);
            this.cBox_manager.Name = "cBox_manager";
            this.cBox_manager.Size = new System.Drawing.Size(155, 28);
            this.cBox_manager.TabIndex = 50;
            // 
            // cBox_Assmanager
            // 
            this.cBox_Assmanager.FormattingEnabled = true;
            this.cBox_Assmanager.Location = new System.Drawing.Point(521, 644);
            this.cBox_Assmanager.Name = "cBox_Assmanager";
            this.cBox_Assmanager.Size = new System.Drawing.Size(155, 28);
            this.cBox_Assmanager.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 652);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "ASSISTANT MANAGER ID";
            // 
            // cBox_captain
            // 
            this.cBox_captain.FormattingEnabled = true;
            this.cBox_captain.Location = new System.Drawing.Point(521, 692);
            this.cBox_captain.Name = "cBox_captain";
            this.cBox_captain.Size = new System.Drawing.Size(155, 28);
            this.cBox_captain.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 700);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "CAPTAIN ID";
            // 
            // Edit_team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.cBox_captain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cBox_Assmanager);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBox_manager);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.round_btn_insertManager);
            this.Controls.Add(this.tBox_refereeName);
            this.Controls.Add(this.tBox_refereeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.round_btn_updateReferee);
            this.Controls.Add(this.round_btn_deleteTeam);
            this.Controls.Add(this.dGV_edit_team);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_edit);
            this.Name = "Edit_team";
            this.Size = new System.Drawing.Size(1109, 743);
            this.Load += new System.EventHandler(this.Edit_team_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_team)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV_edit_team;
        private RoundButton round_btn_deleteTeam;
        private RoundButton round_btn_insertManager;
        private System.Windows.Forms.TextBox tBox_refereeName;
        private System.Windows.Forms.TextBox tBox_refereeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private RoundButton round_btn_updateReferee;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBox_manager;
        private System.Windows.Forms.ComboBox cBox_Assmanager;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBox_captain;
        private System.Windows.Forms.Label label7;
    }
}
