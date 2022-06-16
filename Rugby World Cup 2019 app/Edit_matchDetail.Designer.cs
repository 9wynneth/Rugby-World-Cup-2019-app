
namespace Rugby_World_Cup_2019_app
{
    partial class Edit_matchDetail
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
            this.round_btn_insertMatchDetail = new Rugby_World_Cup_2019_app.RoundButton();
            this.dGV_edit_matchDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.round_btn_updateMatchDetail = new Rugby_World_Cup_2019_app.RoundButton();
            this.picBox_edit = new System.Windows.Forms.PictureBox();
            this.cBox_match = new System.Windows.Forms.ComboBox();
            this.udNumeric_duration = new System.Windows.Forms.NumericUpDown();
            this.cBox_type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBox_player = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.udNumeric_detailID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.round_btn_deleteMatchDetail = new Rugby_World_Cup_2019_app.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_matchDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumeric_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumeric_detailID)).BeginInit();
            this.SuspendLayout();
            // 
            // round_btn_insertMatchDetail
            // 
            this.round_btn_insertMatchDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_insertMatchDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_insertMatchDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_insertMatchDetail.Location = new System.Drawing.Point(47, 268);
            this.round_btn_insertMatchDetail.Margin = new System.Windows.Forms.Padding(2);
            this.round_btn_insertMatchDetail.Name = "round_btn_insertMatchDetail";
            this.round_btn_insertMatchDetail.Size = new System.Drawing.Size(50, 49);
            this.round_btn_insertMatchDetail.TabIndex = 24;
            this.round_btn_insertMatchDetail.Text = "+";
            this.round_btn_insertMatchDetail.UseVisualStyleBackColor = false;
            this.round_btn_insertMatchDetail.Click += new System.EventHandler(this.round_btn_insertMatchDetail_Click);
            // 
            // dGV_edit_matchDetail
            // 
            this.dGV_edit_matchDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_edit_matchDetail.Location = new System.Drawing.Point(47, 38);
            this.dGV_edit_matchDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dGV_edit_matchDetail.Name = "dGV_edit_matchDetail";
            this.dGV_edit_matchDetail.RowHeadersWidth = 62;
            this.dGV_edit_matchDetail.RowTemplate.Height = 28;
            this.dGV_edit_matchDetail.Size = new System.Drawing.Size(671, 220);
            this.dGV_edit_matchDetail.TabIndex = 21;
            this.dGV_edit_matchDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_edit_matchDetail_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "MATCH DETAIL";
            // 
            // round_btn_updateMatchDetail
            // 
            this.round_btn_updateMatchDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_updateMatchDetail.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.available_updates_64;
            this.round_btn_updateMatchDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_updateMatchDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_updateMatchDetail.Location = new System.Drawing.Point(113, 272);
            this.round_btn_updateMatchDetail.Margin = new System.Windows.Forms.Padding(2);
            this.round_btn_updateMatchDetail.Name = "round_btn_updateMatchDetail";
            this.round_btn_updateMatchDetail.Size = new System.Drawing.Size(47, 46);
            this.round_btn_updateMatchDetail.TabIndex = 22;
            this.round_btn_updateMatchDetail.UseVisualStyleBackColor = false;
            this.round_btn_updateMatchDetail.Click += new System.EventHandler(this.round_btn_updateMatchDetail_Click);
            // 
            // picBox_edit
            // 
            this.picBox_edit.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.edit_24;
            this.picBox_edit.Location = new System.Drawing.Point(21, 12);
            this.picBox_edit.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_edit.Name = "picBox_edit";
            this.picBox_edit.Size = new System.Drawing.Size(17, 16);
            this.picBox_edit.TabIndex = 19;
            this.picBox_edit.TabStop = false;
            // 
            // cBox_match
            // 
            this.cBox_match.FormattingEnabled = true;
            this.cBox_match.Location = new System.Drawing.Point(382, 272);
            this.cBox_match.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_match.Name = "cBox_match";
            this.cBox_match.Size = new System.Drawing.Size(105, 21);
            this.cBox_match.TabIndex = 111;
            // 
            // udNumeric_duration
            // 
            this.udNumeric_duration.Location = new System.Drawing.Point(382, 300);
            this.udNumeric_duration.Margin = new System.Windows.Forms.Padding(2);
            this.udNumeric_duration.Name = "udNumeric_duration";
            this.udNumeric_duration.Size = new System.Drawing.Size(80, 20);
            this.udNumeric_duration.TabIndex = 109;
            // 
            // cBox_type
            // 
            this.cBox_type.FormattingEnabled = true;
            this.cBox_type.Location = new System.Drawing.Point(382, 359);
            this.cBox_type.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_type.Name = "cBox_type";
            this.cBox_type.Size = new System.Drawing.Size(160, 21);
            this.cBox_type.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 364);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 107;
            this.label7.Text = "TYPE MATCH DETAIL";
            // 
            // cBox_player
            // 
            this.cBox_player.FormattingEnabled = true;
            this.cBox_player.Location = new System.Drawing.Point(382, 332);
            this.cBox_player.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_player.Name = "cBox_player";
            this.cBox_player.Size = new System.Drawing.Size(105, 21);
            this.cBox_player.TabIndex = 106;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 334);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 105;
            this.label8.Text = "PLAYER ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 302);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 101;
            this.label9.Text = "MATCH DURATION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "MATCH ID:";
            // 
            // udNumeric_detailID
            // 
            this.udNumeric_detailID.Location = new System.Drawing.Point(382, 389);
            this.udNumeric_detailID.Margin = new System.Windows.Forms.Padding(2);
            this.udNumeric_detailID.Name = "udNumeric_detailID";
            this.udNumeric_detailID.Size = new System.Drawing.Size(80, 20);
            this.udNumeric_detailID.TabIndex = 113;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 391);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "MATCH DETAIL ID";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(382, 414);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 114;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // round_btn_deleteMatchDetail
            // 
            this.round_btn_deleteMatchDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_deleteMatchDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_deleteMatchDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_deleteMatchDetail.Location = new System.Drawing.Point(668, 268);
            this.round_btn_deleteMatchDetail.Margin = new System.Windows.Forms.Padding(2);
            this.round_btn_deleteMatchDetail.Name = "round_btn_deleteMatchDetail";
            this.round_btn_deleteMatchDetail.Size = new System.Drawing.Size(50, 49);
            this.round_btn_deleteMatchDetail.TabIndex = 23;
            this.round_btn_deleteMatchDetail.Text = "DEL";
            this.round_btn_deleteMatchDetail.UseVisualStyleBackColor = false;
            this.round_btn_deleteMatchDetail.Click += new System.EventHandler(this.round_btn_deleteMatchDetail_Click);
            // 
            // Edit_matchDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.udNumeric_detailID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBox_match);
            this.Controls.Add(this.udNumeric_duration);
            this.Controls.Add(this.cBox_type);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cBox_player);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.round_btn_insertMatchDetail);
            this.Controls.Add(this.round_btn_deleteMatchDetail);
            this.Controls.Add(this.round_btn_updateMatchDetail);
            this.Controls.Add(this.dGV_edit_matchDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_edit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Edit_matchDetail";
            this.Size = new System.Drawing.Size(739, 483);
            this.Load += new System.EventHandler(this.Edit_matchDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_matchDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumeric_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumeric_detailID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton round_btn_insertMatchDetail;
        private RoundButton round_btn_updateMatchDetail;
        private System.Windows.Forms.DataGridView dGV_edit_matchDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox_edit;
        private System.Windows.Forms.ComboBox cBox_match;
        private System.Windows.Forms.NumericUpDown udNumeric_duration;
        private System.Windows.Forms.ComboBox cBox_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBox_player;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown udNumeric_detailID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitButton;
        private RoundButton round_btn_deleteMatchDetail;
    }
}
