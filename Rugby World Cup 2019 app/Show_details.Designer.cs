
namespace Rugby_World_Cup_2019_app
{
    partial class Show_details
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
            this.dGV_ShowDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ShowDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_ShowDetails
            // 
            this.dGV_ShowDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ShowDetails.Location = new System.Drawing.Point(50, 75);
            this.dGV_ShowDetails.Name = "dGV_ShowDetails";
            this.dGV_ShowDetails.RowHeadersWidth = 62;
            this.dGV_ShowDetails.RowTemplate.Height = 28;
            this.dGV_ShowDetails.Size = new System.Drawing.Size(709, 347);
            this.dGV_ShowDetails.TabIndex = 0;
            // 
            // Show_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGV_ShowDetails);
            this.Name = "Show_details";
            this.Text = "Show_details";
            this.Load += new System.EventHandler(this.Show_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ShowDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_ShowDetails;
    }
}