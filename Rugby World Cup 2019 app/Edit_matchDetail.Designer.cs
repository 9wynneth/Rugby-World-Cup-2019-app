
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
            this.round_btn_deleteMatchDetail = new Rugby_World_Cup_2019_app.RoundButton();
            this.dGV_edit_matchDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.round_btn_updateMatchDetail = new Rugby_World_Cup_2019_app.RoundButton();
            this.picBox_edit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_matchDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // round_btn_insertMatchDetail
            // 
            this.round_btn_insertMatchDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_insertMatchDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_insertMatchDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_insertMatchDetail.Location = new System.Drawing.Point(179, 542);
            this.round_btn_insertMatchDetail.Name = "round_btn_insertMatchDetail";
            this.round_btn_insertMatchDetail.Size = new System.Drawing.Size(75, 75);
            this.round_btn_insertMatchDetail.TabIndex = 24;
            this.round_btn_insertMatchDetail.Text = "+";
            this.round_btn_insertMatchDetail.UseVisualStyleBackColor = false;
            // 
            // round_btn_deleteMatchDetail
            // 
            this.round_btn_deleteMatchDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_deleteMatchDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_deleteMatchDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_deleteMatchDetail.Location = new System.Drawing.Point(893, 542);
            this.round_btn_deleteMatchDetail.Name = "round_btn_deleteMatchDetail";
            this.round_btn_deleteMatchDetail.Size = new System.Drawing.Size(75, 75);
            this.round_btn_deleteMatchDetail.TabIndex = 23;
            this.round_btn_deleteMatchDetail.Text = "DEL";
            this.round_btn_deleteMatchDetail.UseVisualStyleBackColor = false;
            this.round_btn_deleteMatchDetail.Click += new System.EventHandler(this.round_btn_deleteMatchDetail_Click);
            // 
            // dGV_edit_matchDetail
            // 
            this.dGV_edit_matchDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_edit_matchDetail.Location = new System.Drawing.Point(70, 181);
            this.dGV_edit_matchDetail.Name = "dGV_edit_matchDetail";
            this.dGV_edit_matchDetail.RowHeadersWidth = 62;
            this.dGV_edit_matchDetail.RowTemplate.Height = 28;
            this.dGV_edit_matchDetail.Size = new System.Drawing.Size(1007, 338);
            this.dGV_edit_matchDetail.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "MATCH DETAIL";
            // 
            // round_btn_updateMatchDetail
            // 
            this.round_btn_updateMatchDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_updateMatchDetail.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.available_updates_64;
            this.round_btn_updateMatchDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_updateMatchDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_updateMatchDetail.Location = new System.Drawing.Point(568, 547);
            this.round_btn_updateMatchDetail.Name = "round_btn_updateMatchDetail";
            this.round_btn_updateMatchDetail.Size = new System.Drawing.Size(70, 70);
            this.round_btn_updateMatchDetail.TabIndex = 22;
            this.round_btn_updateMatchDetail.UseVisualStyleBackColor = false;
            // 
            // picBox_edit
            // 
            this.picBox_edit.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.edit_24;
            this.picBox_edit.Location = new System.Drawing.Point(32, 125);
            this.picBox_edit.Name = "picBox_edit";
            this.picBox_edit.Size = new System.Drawing.Size(25, 24);
            this.picBox_edit.TabIndex = 19;
            this.picBox_edit.TabStop = false;
            // 
            // Edit_matchDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.round_btn_insertMatchDetail);
            this.Controls.Add(this.round_btn_deleteMatchDetail);
            this.Controls.Add(this.round_btn_updateMatchDetail);
            this.Controls.Add(this.dGV_edit_matchDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_edit);
            this.Name = "Edit_matchDetail";
            this.Size = new System.Drawing.Size(1109, 743);
            this.Load += new System.EventHandler(this.Edit_matchDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_matchDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton round_btn_insertMatchDetail;
        private RoundButton round_btn_deleteMatchDetail;
        private RoundButton round_btn_updateMatchDetail;
        private System.Windows.Forms.DataGridView dGV_edit_matchDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox_edit;
    }
}
