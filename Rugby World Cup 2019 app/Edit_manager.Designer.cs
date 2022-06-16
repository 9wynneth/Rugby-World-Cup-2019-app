
namespace Rugby_World_Cup_2019_app
{
    partial class Edit_manager
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
            this.round_btn_insertManager = new Rugby_World_Cup_2019_app.RoundButton();
            this.round_btn_deleteManager = new Rugby_World_Cup_2019_app.RoundButton();
            this.dGV_edit_manager = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.round_btn_updateManager = new Rugby_World_Cup_2019_app.RoundButton();
            this.picBox_edit = new System.Windows.Forms.PictureBox();
            this.dtPicker_birthdate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cBox_nationality = new System.Windows.Forms.ComboBox();
            this.tBox_managerName = new System.Windows.Forms.TextBox();
            this.tBox_managerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBox_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_manager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // round_btn_insertManager
            // 
            this.round_btn_insertManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_insertManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.round_btn_insertManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_insertManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_insertManager.Location = new System.Drawing.Point(81, 237);
            this.round_btn_insertManager.Margin = new System.Windows.Forms.Padding(2);
            this.round_btn_insertManager.Name = "round_btn_insertManager";
            this.round_btn_insertManager.Size = new System.Drawing.Size(50, 49);
            this.round_btn_insertManager.TabIndex = 36;
            this.round_btn_insertManager.Text = "+";
            this.round_btn_insertManager.UseVisualStyleBackColor = false;
            this.round_btn_insertManager.Click += new System.EventHandler(this.round_btn_insertManager_Click);
            // 
            // round_btn_deleteManager
            // 
            this.round_btn_deleteManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_deleteManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_deleteManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_deleteManager.Location = new System.Drawing.Point(603, 240);
            this.round_btn_deleteManager.Margin = new System.Windows.Forms.Padding(2);
            this.round_btn_deleteManager.Name = "round_btn_deleteManager";
            this.round_btn_deleteManager.Size = new System.Drawing.Size(50, 49);
            this.round_btn_deleteManager.TabIndex = 35;
            this.round_btn_deleteManager.Text = "DEL";
            this.round_btn_deleteManager.UseVisualStyleBackColor = false;
            this.round_btn_deleteManager.Click += new System.EventHandler(this.round_btn_deleteManager_Click);
            // 
            // dGV_edit_manager
            // 
            this.dGV_edit_manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_edit_manager.Location = new System.Drawing.Point(81, 40);
            this.dGV_edit_manager.Margin = new System.Windows.Forms.Padding(2);
            this.dGV_edit_manager.Name = "dGV_edit_manager";
            this.dGV_edit_manager.RowHeadersWidth = 62;
            this.dGV_edit_manager.RowTemplate.Height = 28;
            this.dGV_edit_manager.Size = new System.Drawing.Size(572, 186);
            this.dGV_edit_manager.TabIndex = 33;
            this.dGV_edit_manager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_edit_manager_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "MANAGER";
            // 
            // round_btn_updateManager
            // 
            this.round_btn_updateManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_updateManager.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.available_updates_64;
            this.round_btn_updateManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_updateManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_updateManager.Location = new System.Drawing.Point(135, 240);
            this.round_btn_updateManager.Margin = new System.Windows.Forms.Padding(2);
            this.round_btn_updateManager.Name = "round_btn_updateManager";
            this.round_btn_updateManager.Size = new System.Drawing.Size(43, 46);
            this.round_btn_updateManager.TabIndex = 34;
            this.round_btn_updateManager.UseVisualStyleBackColor = false;
            this.round_btn_updateManager.Click += new System.EventHandler(this.round_btn_updateManager_Click);
            // 
            // picBox_edit
            // 
            this.picBox_edit.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.edit_24;
            this.picBox_edit.Location = new System.Drawing.Point(9, 14);
            this.picBox_edit.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_edit.Name = "picBox_edit";
            this.picBox_edit.Size = new System.Drawing.Size(17, 16);
            this.picBox_edit.TabIndex = 31;
            this.picBox_edit.TabStop = false;
            // 
            // dtPicker_birthdate
            // 
            this.dtPicker_birthdate.Location = new System.Drawing.Point(361, 309);
            this.dtPicker_birthdate.Margin = new System.Windows.Forms.Padding(2);
            this.dtPicker_birthdate.Name = "dtPicker_birthdate";
            this.dtPicker_birthdate.Size = new System.Drawing.Size(171, 20);
            this.dtPicker_birthdate.TabIndex = 91;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 313);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 88;
            this.label10.Text = "BIRTHDATE";
            // 
            // cBox_nationality
            // 
            this.cBox_nationality.FormattingEnabled = true;
            this.cBox_nationality.Location = new System.Drawing.Point(361, 349);
            this.cBox_nationality.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_nationality.Name = "cBox_nationality";
            this.cBox_nationality.Size = new System.Drawing.Size(152, 21);
            this.cBox_nationality.TabIndex = 84;
            // 
            // tBox_managerName
            // 
            this.tBox_managerName.Location = new System.Drawing.Point(361, 280);
            this.tBox_managerName.Margin = new System.Windows.Forms.Padding(2);
            this.tBox_managerName.Name = "tBox_managerName";
            this.tBox_managerName.Size = new System.Drawing.Size(192, 20);
            this.tBox_managerName.TabIndex = 82;
            // 
            // tBox_managerID
            // 
            this.tBox_managerID.Location = new System.Drawing.Point(361, 247);
            this.tBox_managerID.Margin = new System.Windows.Forms.Padding(2);
            this.tBox_managerID.Name = "tBox_managerID";
            this.tBox_managerID.ReadOnly = true;
            this.tBox_managerID.Size = new System.Drawing.Size(51, 20);
            this.tBox_managerID.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "NATIONALITY ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "MANAGER NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "MANAGER ID:";
            // 
            // cBox_status
            // 
            this.cBox_status.AutoCompleteCustomSource.AddRange(new string[] {
            "yes",
            "no"});
            this.cBox_status.FormattingEnabled = true;
            this.cBox_status.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cBox_status.Location = new System.Drawing.Point(361, 380);
            this.cBox_status.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_status.Name = "cBox_status";
            this.cBox_status.Size = new System.Drawing.Size(152, 21);
            this.cBox_status.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 382);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "STATUS";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(361, 425);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 94;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Edit_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.image_1_;
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.cBox_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtPicker_birthdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cBox_nationality);
            this.Controls.Add(this.tBox_managerName);
            this.Controls.Add(this.tBox_managerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.round_btn_insertManager);
            this.Controls.Add(this.round_btn_deleteManager);
            this.Controls.Add(this.round_btn_updateManager);
            this.Controls.Add(this.dGV_edit_manager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_edit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Edit_manager";
            this.Size = new System.Drawing.Size(739, 483);
            this.Load += new System.EventHandler(this.Edit_manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_manager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton round_btn_insertManager;
        private RoundButton round_btn_deleteManager;
        private RoundButton round_btn_updateManager;
        private System.Windows.Forms.DataGridView dGV_edit_manager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox_edit;
        private System.Windows.Forms.DateTimePicker dtPicker_birthdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cBox_nationality;
        private System.Windows.Forms.TextBox tBox_managerName;
        private System.Windows.Forms.TextBox tBox_managerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBox_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submitButton;
    }
}
