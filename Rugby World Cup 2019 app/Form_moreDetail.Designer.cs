
namespace Rugby_World_Cup_2019_app
{
    partial class Form_moreDetail
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_moreDetail = new System.Windows.Forms.DataGridView();
            this.lbl_moreDetail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_moreDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_moreDetail
            // 
            this.dataGridView_moreDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_moreDetail.Location = new System.Drawing.Point(43, 82);
            this.dataGridView_moreDetail.Name = "dataGridView_moreDetail";
            this.dataGridView_moreDetail.RowHeadersWidth = 62;
            this.dataGridView_moreDetail.RowTemplate.Height = 28;
            this.dataGridView_moreDetail.Size = new System.Drawing.Size(720, 297);
            this.dataGridView_moreDetail.TabIndex = 0;
            // 
            // lbl_moreDetail
            // 
            this.lbl_moreDetail.AutoSize = true;
            this.lbl_moreDetail.Location = new System.Drawing.Point(43, 13);
            this.lbl_moreDetail.Name = "lbl_moreDetail";
            this.lbl_moreDetail.Size = new System.Drawing.Size(51, 20);
            this.lbl_moreDetail.TabIndex = 1;
            this.lbl_moreDetail.Text = "label1";
            // 
            // Form_moreDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_moreDetail);
            this.Controls.Add(this.dataGridView_moreDetail);
            this.Name = "Form_moreDetail";
            this.Text = "Form_moreDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_moreDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_moreDetail;
        private System.Windows.Forms.Label lbl_moreDetail;
    }
}