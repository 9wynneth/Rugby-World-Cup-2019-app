
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
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // round_btn_insertPlayer
            // 
            this.round_btn_insertPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_insertPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_insertPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_insertPlayer.Location = new System.Drawing.Point(179, 542);
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
            this.round_btn_deletePlayer.Location = new System.Drawing.Point(893, 542);
            this.round_btn_deletePlayer.Name = "round_btn_deletePlayer";
            this.round_btn_deletePlayer.Size = new System.Drawing.Size(75, 75);
            this.round_btn_deletePlayer.TabIndex = 11;
            this.round_btn_deletePlayer.Text = "DEL";
            this.round_btn_deletePlayer.UseVisualStyleBackColor = false;
            // 
            // dGV_edit_player
            // 
            this.dGV_edit_player.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_edit_player.Location = new System.Drawing.Point(70, 181);
            this.dGV_edit_player.Name = "dGV_edit_player";
            this.dGV_edit_player.RowHeadersWidth = 62;
            this.dGV_edit_player.RowTemplate.Height = 28;
            this.dGV_edit_player.Size = new System.Drawing.Size(1007, 338);
            this.dGV_edit_player.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 125);
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
            this.round_btn_updatePlayer.Location = new System.Drawing.Point(568, 547);
            this.round_btn_updatePlayer.Name = "round_btn_updatePlayer";
            this.round_btn_updatePlayer.Size = new System.Drawing.Size(70, 70);
            this.round_btn_updatePlayer.TabIndex = 10;
            this.round_btn_updatePlayer.UseVisualStyleBackColor = false;
            // 
            // picBox_edit
            // 
            this.picBox_edit.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.edit_24;
            this.picBox_edit.Location = new System.Drawing.Point(32, 125);
            this.picBox_edit.Name = "picBox_edit";
            this.picBox_edit.Size = new System.Drawing.Size(25, 24);
            this.picBox_edit.TabIndex = 7;
            this.picBox_edit.TabStop = false;
            // 
            // Edit_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.round_btn_insertPlayer);
            this.Controls.Add(this.round_btn_deletePlayer);
            this.Controls.Add(this.round_btn_updatePlayer);
            this.Controls.Add(this.dGV_edit_player);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_edit);
            this.Name = "Edit_player";
            this.Size = new System.Drawing.Size(1109, 743);
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
    }
}
