
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
            this.round_btn_insertReferee = new Rugby_World_Cup_2019_app.RoundButton();
            this.round_btn_deleteReferee = new Rugby_World_Cup_2019_app.RoundButton();
            this.dGV_edit_referee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.round_btn_updateReferee = new Rugby_World_Cup_2019_app.RoundButton();
            this.picBox_edit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_referee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // round_btn_insertReferee
            // 
            this.round_btn_insertReferee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_insertReferee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_insertReferee.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_insertReferee.Location = new System.Drawing.Point(179, 542);
            this.round_btn_insertReferee.Name = "round_btn_insertReferee";
            this.round_btn_insertReferee.Size = new System.Drawing.Size(75, 75);
            this.round_btn_insertReferee.TabIndex = 30;
            this.round_btn_insertReferee.Text = "+";
            this.round_btn_insertReferee.UseVisualStyleBackColor = false;
            // 
            // round_btn_deleteReferee
            // 
            this.round_btn_deleteReferee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_deleteReferee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_deleteReferee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_deleteReferee.Location = new System.Drawing.Point(893, 542);
            this.round_btn_deleteReferee.Name = "round_btn_deleteReferee";
            this.round_btn_deleteReferee.Size = new System.Drawing.Size(75, 75);
            this.round_btn_deleteReferee.TabIndex = 29;
            this.round_btn_deleteReferee.Text = "DEL";
            this.round_btn_deleteReferee.UseVisualStyleBackColor = false;
            this.round_btn_deleteReferee.Click += new System.EventHandler(this.round_btn_deleteReferee_Click);
            // 
            // dGV_edit_referee
            // 
            this.dGV_edit_referee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_edit_referee.Location = new System.Drawing.Point(70, 181);
            this.dGV_edit_referee.Name = "dGV_edit_referee";
            this.dGV_edit_referee.RowHeadersWidth = 62;
            this.dGV_edit_referee.RowTemplate.Height = 28;
            this.dGV_edit_referee.Size = new System.Drawing.Size(1007, 338);
            this.dGV_edit_referee.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "REFEREE";
            // 
            // round_btn_updateReferee
            // 
            this.round_btn_updateReferee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_updateReferee.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.available_updates_64;
            this.round_btn_updateReferee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_updateReferee.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_updateReferee.Location = new System.Drawing.Point(568, 547);
            this.round_btn_updateReferee.Name = "round_btn_updateReferee";
            this.round_btn_updateReferee.Size = new System.Drawing.Size(70, 70);
            this.round_btn_updateReferee.TabIndex = 28;
            this.round_btn_updateReferee.UseVisualStyleBackColor = false;
            // 
            // picBox_edit
            // 
            this.picBox_edit.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.edit_24;
            this.picBox_edit.Location = new System.Drawing.Point(32, 125);
            this.picBox_edit.Name = "picBox_edit";
            this.picBox_edit.Size = new System.Drawing.Size(25, 24);
            this.picBox_edit.TabIndex = 25;
            this.picBox_edit.TabStop = false;
            // 
            // Edit_referee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.round_btn_insertReferee);
            this.Controls.Add(this.round_btn_deleteReferee);
            this.Controls.Add(this.round_btn_updateReferee);
            this.Controls.Add(this.dGV_edit_referee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_edit);
            this.Name = "Edit_referee";
            this.Size = new System.Drawing.Size(1109, 743);
            this.Load += new System.EventHandler(this.Edit_referee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_referee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton round_btn_insertReferee;
        private RoundButton round_btn_deleteReferee;
        private RoundButton round_btn_updateReferee;
        private System.Windows.Forms.DataGridView dGV_edit_referee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox_edit;
    }
}
