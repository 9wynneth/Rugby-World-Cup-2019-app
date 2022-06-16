
namespace Rugby_World_Cup_2019_app
{
    partial class Edit_referee
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
            this.dGV_edit_referee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.picBox_edit = new System.Windows.Forms.PictureBox();
            this.cBox_nationality = new System.Windows.Forms.ComboBox();
            this.tBox_refereeName = new System.Windows.Forms.TextBox();
            this.tBox_refereeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.round_btn_insertManager = new Rugby_World_Cup_2019_app.RoundButton();
            this.round_btn_deleteReferee = new Rugby_World_Cup_2019_app.RoundButton();
            this.round_btn_updateReferee = new Rugby_World_Cup_2019_app.RoundButton();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_referee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_edit_referee
            // 
            this.dGV_edit_referee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_edit_referee.Location = new System.Drawing.Point(35, 40);
            this.dGV_edit_referee.Margin = new System.Windows.Forms.Padding(2);
            this.dGV_edit_referee.Name = "dGV_edit_referee";
            this.dGV_edit_referee.RowHeadersWidth = 62;
            this.dGV_edit_referee.RowTemplate.Height = 28;
            this.dGV_edit_referee.Size = new System.Drawing.Size(671, 177);
            this.dGV_edit_referee.TabIndex = 27;
            this.dGV_edit_referee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_edit_referee_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "REFEREE";
            // 
            // picBox_edit
            // 
            this.picBox_edit.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.edit_24;
            this.picBox_edit.Location = new System.Drawing.Point(10, 14);
            this.picBox_edit.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_edit.Name = "picBox_edit";
            this.picBox_edit.Size = new System.Drawing.Size(17, 16);
            this.picBox_edit.TabIndex = 25;
            this.picBox_edit.TabStop = false;
            // 
            // cBox_nationality
            // 
            this.cBox_nationality.FormattingEnabled = true;
            this.cBox_nationality.Location = new System.Drawing.Point(349, 315);
            this.cBox_nationality.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_nationality.Name = "cBox_nationality";
            this.cBox_nationality.Size = new System.Drawing.Size(105, 21);
            this.cBox_nationality.TabIndex = 35;
            // 
            // tBox_refereeName
            // 
            this.tBox_refereeName.Location = new System.Drawing.Point(349, 281);
            this.tBox_refereeName.Margin = new System.Windows.Forms.Padding(2);
            this.tBox_refereeName.Name = "tBox_refereeName";
            this.tBox_refereeName.Size = new System.Drawing.Size(245, 20);
            this.tBox_refereeName.TabIndex = 34;
            // 
            // tBox_refereeID
            // 
            this.tBox_refereeID.Location = new System.Drawing.Point(349, 249);
            this.tBox_refereeID.Margin = new System.Windows.Forms.Padding(2);
            this.tBox_refereeID.Name = "tBox_refereeID";
            this.tBox_refereeID.ReadOnly = true;
            this.tBox_refereeID.Size = new System.Drawing.Size(105, 20);
            this.tBox_refereeID.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 315);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "NATIONALITY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 283);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "REFEREE NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "REFEREE ID:";
            // 
            // round_btn_insertManager
            // 
            this.round_btn_insertManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_insertManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.round_btn_insertManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_insertManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_insertManager.Location = new System.Drawing.Point(35, 231);
            this.round_btn_insertManager.Margin = new System.Windows.Forms.Padding(2);
            this.round_btn_insertManager.Name = "round_btn_insertManager";
            this.round_btn_insertManager.Size = new System.Drawing.Size(42, 40);
            this.round_btn_insertManager.TabIndex = 38;
            this.round_btn_insertManager.Text = "+";
            this.round_btn_insertManager.UseVisualStyleBackColor = false;
            this.round_btn_insertManager.Click += new System.EventHandler(this.round_btn_insertManager_Click);
            // 
            // round_btn_deleteReferee
            // 
            this.round_btn_deleteReferee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_deleteReferee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_deleteReferee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_deleteReferee.Location = new System.Drawing.Point(657, 231);
            this.round_btn_deleteReferee.Margin = new System.Windows.Forms.Padding(2);
            this.round_btn_deleteReferee.Name = "round_btn_deleteReferee";
            this.round_btn_deleteReferee.Size = new System.Drawing.Size(50, 49);
            this.round_btn_deleteReferee.TabIndex = 29;
            this.round_btn_deleteReferee.Text = "DEL";
            this.round_btn_deleteReferee.UseVisualStyleBackColor = false;
            this.round_btn_deleteReferee.Click += new System.EventHandler(this.round_btn_deleteReferee_Click);
            // 
            // round_btn_updateReferee
            // 
            this.round_btn_updateReferee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_updateReferee.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.available_updates_64;
            this.round_btn_updateReferee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_updateReferee.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_updateReferee.Location = new System.Drawing.Point(99, 231);
            this.round_btn_updateReferee.Margin = new System.Windows.Forms.Padding(2);
            this.round_btn_updateReferee.Name = "round_btn_updateReferee";
            this.round_btn_updateReferee.Size = new System.Drawing.Size(47, 46);
            this.round_btn_updateReferee.TabIndex = 28;
            this.round_btn_updateReferee.UseVisualStyleBackColor = false;
            this.round_btn_updateReferee.Click += new System.EventHandler(this.round_btn_updateReferee_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(349, 359);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 39;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Edit_referee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.round_btn_insertManager);
            this.Controls.Add(this.cBox_nationality);
            this.Controls.Add(this.tBox_refereeName);
            this.Controls.Add(this.tBox_refereeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.round_btn_deleteReferee);
            this.Controls.Add(this.round_btn_updateReferee);
            this.Controls.Add(this.dGV_edit_referee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_edit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Edit_referee";
            this.Size = new System.Drawing.Size(739, 483);
            this.Load += new System.EventHandler(this.Edit_referee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_referee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundButton round_btn_deleteReferee;
        private RoundButton round_btn_updateReferee;
        private System.Windows.Forms.DataGridView dGV_edit_referee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox_edit;
        private System.Windows.Forms.ComboBox cBox_nationality;
        private System.Windows.Forms.TextBox tBox_refereeName;
        private System.Windows.Forms.TextBox tBox_refereeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private RoundButton round_btn_insertManager;
        private System.Windows.Forms.Button submitButton;
    }
}
