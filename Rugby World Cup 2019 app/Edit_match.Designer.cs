
namespace Rugby_World_Cup_2019_app
{
    partial class Edit_match
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
            this.round_btn_insert = new Rugby_World_Cup_2019_app.RoundButton();
            this.round_btn_delete = new Rugby_World_Cup_2019_app.RoundButton();
            this.dGV_edit_match = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.round_btn_update = new Rugby_World_Cup_2019_app.RoundButton();
            this.picBox_edit = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBox_home = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPicker_date = new System.Windows.Forms.DateTimePicker();
            this.cBox_away = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBox_stadium = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBox_referee = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.udNumeric_home = new System.Windows.Forms.NumericUpDown();
            this.udNumeric_away = new System.Windows.Forms.NumericUpDown();
            this.submitButton = new System.Windows.Forms.Button();
            this.tBox_matchID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_match)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumeric_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumeric_away)).BeginInit();
            this.SuspendLayout();
            // 
            // round_btn_insert
            // 
            this.round_btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_insert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.round_btn_insert.Location = new System.Drawing.Point(81, 241);
            this.round_btn_insert.Margin = new System.Windows.Forms.Padding(2);
            this.round_btn_insert.Name = "round_btn_insert";
            this.round_btn_insert.Size = new System.Drawing.Size(45, 49);
            this.round_btn_insert.TabIndex = 18;
            this.round_btn_insert.Text = "+";
            this.round_btn_insert.UseVisualStyleBackColor = false;
            this.round_btn_insert.Click += new System.EventHandler(this.round_btn_insert_Click);
            // 
            // round_btn_delete
            // 
            this.round_btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_delete.Location = new System.Drawing.Point(603, 241);
            this.round_btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.round_btn_delete.Name = "round_btn_delete";
            this.round_btn_delete.Size = new System.Drawing.Size(50, 49);
            this.round_btn_delete.TabIndex = 17;
            this.round_btn_delete.Text = "DEL";
            this.round_btn_delete.UseVisualStyleBackColor = false;
            this.round_btn_delete.Click += new System.EventHandler(this.round_btn_delete_Click);
            // 
            // dGV_edit_match
            // 
            this.dGV_edit_match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_edit_match.Location = new System.Drawing.Point(81, 40);
            this.dGV_edit_match.Margin = new System.Windows.Forms.Padding(2);
            this.dGV_edit_match.Name = "dGV_edit_match";
            this.dGV_edit_match.RowHeadersWidth = 62;
            this.dGV_edit_match.RowTemplate.Height = 28;
            this.dGV_edit_match.Size = new System.Drawing.Size(572, 190);
            this.dGV_edit_match.TabIndex = 15;
            this.dGV_edit_match.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_edit_match_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "MATCH";
            // 
            // round_btn_update
            // 
            this.round_btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_update.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.available_updates_64;
            this.round_btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_update.Location = new System.Drawing.Point(154, 246);
            this.round_btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.round_btn_update.Name = "round_btn_update";
            this.round_btn_update.Size = new System.Drawing.Size(41, 44);
            this.round_btn_update.TabIndex = 16;
            this.round_btn_update.UseVisualStyleBackColor = false;
            this.round_btn_update.Click += new System.EventHandler(this.round_btn_update_Click);
            // 
            // picBox_edit
            // 
            this.picBox_edit.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.edit_24;
            this.picBox_edit.Location = new System.Drawing.Point(9, 14);
            this.picBox_edit.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_edit.Name = "picBox_edit";
            this.picBox_edit.Size = new System.Drawing.Size(17, 16);
            this.picBox_edit.TabIndex = 13;
            this.picBox_edit.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(243, 348);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 81;
            this.label9.Text = "GOAL HOME";
            // 
            // cBox_home
            // 
            this.cBox_home.FormattingEnabled = true;
            this.cBox_home.Location = new System.Drawing.Point(366, 291);
            this.cBox_home.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_home.Name = "cBox_home";
            this.cBox_home.Size = new System.Drawing.Size(105, 21);
            this.cBox_home.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 377);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "GOAL AWAY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "TEAM HOME ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "MATCH DATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "MATCH ID:";
            // 
            // dtPicker_date
            // 
            this.dtPicker_date.Location = new System.Drawing.Point(366, 265);
            this.dtPicker_date.Margin = new System.Windows.Forms.Padding(2);
            this.dtPicker_date.Name = "dtPicker_date";
            this.dtPicker_date.Size = new System.Drawing.Size(135, 20);
            this.dtPicker_date.TabIndex = 86;
            // 
            // cBox_away
            // 
            this.cBox_away.FormattingEnabled = true;
            this.cBox_away.Location = new System.Drawing.Point(366, 317);
            this.cBox_away.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_away.Name = "cBox_away";
            this.cBox_away.Size = new System.Drawing.Size(105, 21);
            this.cBox_away.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 322);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "TEAM AWAY ID";
            // 
            // cBox_stadium
            // 
            this.cBox_stadium.FormattingEnabled = true;
            this.cBox_stadium.Location = new System.Drawing.Point(366, 431);
            this.cBox_stadium.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_stadium.Name = "cBox_stadium";
            this.cBox_stadium.Size = new System.Drawing.Size(105, 21);
            this.cBox_stadium.TabIndex = 92;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 436);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "STADIUM ID";
            // 
            // cBox_referee
            // 
            this.cBox_referee.FormattingEnabled = true;
            this.cBox_referee.Location = new System.Drawing.Point(366, 404);
            this.cBox_referee.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_referee.Name = "cBox_referee";
            this.cBox_referee.Size = new System.Drawing.Size(105, 21);
            this.cBox_referee.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 404);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 89;
            this.label8.Text = "REFEREE ID";
            // 
            // udNumeric_home
            // 
            this.udNumeric_home.Location = new System.Drawing.Point(366, 344);
            this.udNumeric_home.Margin = new System.Windows.Forms.Padding(2);
            this.udNumeric_home.Name = "udNumeric_home";
            this.udNumeric_home.Size = new System.Drawing.Size(80, 20);
            this.udNumeric_home.TabIndex = 93;
            // 
            // udNumeric_away
            // 
            this.udNumeric_away.Location = new System.Drawing.Point(366, 373);
            this.udNumeric_away.Margin = new System.Windows.Forms.Padding(2);
            this.udNumeric_away.Name = "udNumeric_away";
            this.udNumeric_away.Size = new System.Drawing.Size(80, 20);
            this.udNumeric_away.TabIndex = 94;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(366, 460);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 96;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // tBox_matchID
            // 
            this.tBox_matchID.Location = new System.Drawing.Point(366, 238);
            this.tBox_matchID.Margin = new System.Windows.Forms.Padding(2);
            this.tBox_matchID.Name = "tBox_matchID";
            this.tBox_matchID.ReadOnly = true;
            this.tBox_matchID.Size = new System.Drawing.Size(90, 20);
            this.tBox_matchID.TabIndex = 97;
            // 
            // Edit_match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.image_1_;
            this.Controls.Add(this.tBox_matchID);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.udNumeric_away);
            this.Controls.Add(this.udNumeric_home);
            this.Controls.Add(this.cBox_stadium);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cBox_referee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cBox_away);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtPicker_date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cBox_home);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.round_btn_insert);
            this.Controls.Add(this.round_btn_delete);
            this.Controls.Add(this.round_btn_update);
            this.Controls.Add(this.dGV_edit_match);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_edit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Edit_match";
            this.Size = new System.Drawing.Size(739, 483);
            this.Load += new System.EventHandler(this.Edit_match_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_match)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumeric_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumeric_away)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton round_btn_insert;
        private RoundButton round_btn_delete;
        private RoundButton round_btn_update;
        private System.Windows.Forms.DataGridView dGV_edit_match;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox_edit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBox_home;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtPicker_date;
        private System.Windows.Forms.ComboBox cBox_away;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBox_stadium;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBox_referee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown udNumeric_home;
        private System.Windows.Forms.NumericUpDown udNumeric_away;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox tBox_matchID;
    }
}
