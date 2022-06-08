
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
            this.round_btn_insertTeam = new Rugby_World_Cup_2019_app.RoundButton();
            this.round_btn_deleteTeam = new Rugby_World_Cup_2019_app.RoundButton();
            this.round_btn_updateTeam = new Rugby_World_Cup_2019_app.RoundButton();
            this.picBox_edit = new System.Windows.Forms.PictureBox();
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
            // round_btn_insertTeam
            // 
            this.round_btn_insertTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_insertTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_insertTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_insertTeam.Location = new System.Drawing.Point(161, 429);
            this.round_btn_insertTeam.Name = "round_btn_insertTeam";
            this.round_btn_insertTeam.Size = new System.Drawing.Size(75, 75);
            this.round_btn_insertTeam.TabIndex = 6;
            this.round_btn_insertTeam.Text = "+";
            this.round_btn_insertTeam.UseVisualStyleBackColor = false;
            // 
            // round_btn_deleteTeam
            // 
            this.round_btn_deleteTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_deleteTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_deleteTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_deleteTeam.Location = new System.Drawing.Point(875, 429);
            this.round_btn_deleteTeam.Name = "round_btn_deleteTeam";
            this.round_btn_deleteTeam.Size = new System.Drawing.Size(75, 75);
            this.round_btn_deleteTeam.TabIndex = 5;
            this.round_btn_deleteTeam.Text = "DEL";
            this.round_btn_deleteTeam.UseVisualStyleBackColor = false;
            this.round_btn_deleteTeam.Click += new System.EventHandler(this.round_btn_deleteTeam_Click);
            // 
            // round_btn_updateTeam
            // 
            this.round_btn_updateTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_updateTeam.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.available_updates_64;
            this.round_btn_updateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_updateTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_updateTeam.Location = new System.Drawing.Point(550, 434);
            this.round_btn_updateTeam.Name = "round_btn_updateTeam";
            this.round_btn_updateTeam.Size = new System.Drawing.Size(70, 70);
            this.round_btn_updateTeam.TabIndex = 4;
            this.round_btn_updateTeam.UseVisualStyleBackColor = false;
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
            // Edit_team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.round_btn_insertTeam);
            this.Controls.Add(this.round_btn_deleteTeam);
            this.Controls.Add(this.round_btn_updateTeam);
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
        private RoundButton round_btn_updateTeam;
        private RoundButton round_btn_deleteTeam;
        private RoundButton round_btn_insertTeam;
    }
}
