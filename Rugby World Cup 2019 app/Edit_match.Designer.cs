
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
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_match)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // round_btn_insert
            // 
            this.round_btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_insert.Location = new System.Drawing.Point(179, 542);
            this.round_btn_insert.Name = "round_btn_insert";
            this.round_btn_insert.Size = new System.Drawing.Size(75, 75);
            this.round_btn_insert.TabIndex = 18;
            this.round_btn_insert.Text = "+";
            this.round_btn_insert.UseVisualStyleBackColor = true;
            // 
            // round_btn_delete
            // 
            this.round_btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_delete.Location = new System.Drawing.Point(893, 542);
            this.round_btn_delete.Name = "round_btn_delete";
            this.round_btn_delete.Size = new System.Drawing.Size(75, 75);
            this.round_btn_delete.TabIndex = 17;
            this.round_btn_delete.Text = "DEL";
            this.round_btn_delete.UseVisualStyleBackColor = true;
            // 
            // dGV_edit_match
            // 
            this.dGV_edit_match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_edit_match.Location = new System.Drawing.Point(70, 181);
            this.dGV_edit_match.Name = "dGV_edit_match";
            this.dGV_edit_match.RowHeadersWidth = 62;
            this.dGV_edit_match.RowTemplate.Height = 28;
            this.dGV_edit_match.Size = new System.Drawing.Size(1007, 338);
            this.dGV_edit_match.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "MATCH";
            // 
            // round_btn_update
            // 
            this.round_btn_update.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.available_updates_64;
            this.round_btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_update.Location = new System.Drawing.Point(568, 547);
            this.round_btn_update.Name = "round_btn_update";
            this.round_btn_update.Size = new System.Drawing.Size(70, 70);
            this.round_btn_update.TabIndex = 16;
            this.round_btn_update.UseVisualStyleBackColor = true;
            // 
            // picBox_edit
            // 
            this.picBox_edit.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.edit_24;
            this.picBox_edit.Location = new System.Drawing.Point(32, 125);
            this.picBox_edit.Name = "picBox_edit";
            this.picBox_edit.Size = new System.Drawing.Size(25, 24);
            this.picBox_edit.TabIndex = 13;
            this.picBox_edit.TabStop = false;
            // 
            // Edit_match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(200)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.round_btn_insert);
            this.Controls.Add(this.round_btn_delete);
            this.Controls.Add(this.round_btn_update);
            this.Controls.Add(this.dGV_edit_match);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_edit);
            this.Name = "Edit_match";
            this.Size = new System.Drawing.Size(1109, 743);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_match)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).EndInit();
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
    }
}
