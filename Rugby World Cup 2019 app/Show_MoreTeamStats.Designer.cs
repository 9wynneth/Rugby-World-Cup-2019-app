
namespace Rugby_World_Cup_2019_app
{
    partial class Show_MoreTeamStats
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
            this.DGV_TeamConversions = new System.Windows.Forms.DataGridView();
            this.DGV_TeamTries = new System.Windows.Forms.DataGridView();
            this.DGV_TeamPenalties = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_TeamPoints = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TeamConversions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TeamTries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TeamPenalties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TeamPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_TeamConversions
            // 
            this.DGV_TeamConversions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TeamConversions.Location = new System.Drawing.Point(599, 349);
            this.DGV_TeamConversions.Name = "DGV_TeamConversions";
            this.DGV_TeamConversions.RowHeadersWidth = 62;
            this.DGV_TeamConversions.RowTemplate.Height = 28;
            this.DGV_TeamConversions.Size = new System.Drawing.Size(449, 213);
            this.DGV_TeamConversions.TabIndex = 15;
            // 
            // DGV_TeamTries
            // 
            this.DGV_TeamTries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TeamTries.Location = new System.Drawing.Point(599, 63);
            this.DGV_TeamTries.Name = "DGV_TeamTries";
            this.DGV_TeamTries.RowHeadersWidth = 62;
            this.DGV_TeamTries.RowTemplate.Height = 28;
            this.DGV_TeamTries.Size = new System.Drawing.Size(449, 213);
            this.DGV_TeamTries.TabIndex = 14;
            // 
            // DGV_TeamPenalties
            // 
            this.DGV_TeamPenalties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TeamPenalties.Location = new System.Drawing.Point(31, 349);
            this.DGV_TeamPenalties.Name = "DGV_TeamPenalties";
            this.DGV_TeamPenalties.RowHeadersWidth = 62;
            this.DGV_TeamPenalties.RowTemplate.Height = 28;
            this.DGV_TeamPenalties.Size = new System.Drawing.Size(449, 213);
            this.DGV_TeamPenalties.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "CONVERSIONS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "PENALTIES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "TRIED SCORED";
            // 
            // DGV_TeamPoints
            // 
            this.DGV_TeamPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TeamPoints.Location = new System.Drawing.Point(31, 63);
            this.DGV_TeamPoints.Name = "DGV_TeamPoints";
            this.DGV_TeamPoints.RowHeadersWidth = 62;
            this.DGV_TeamPoints.RowTemplate.Height = 28;
            this.DGV_TeamPoints.Size = new System.Drawing.Size(449, 213);
            this.DGV_TeamPoints.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "POINTS SCORED";
            // 
            // Show_MoreTeamStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DGV_TeamConversions);
            this.Controls.Add(this.DGV_TeamTries);
            this.Controls.Add(this.DGV_TeamPenalties);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_TeamPoints);
            this.Controls.Add(this.label1);
            this.Name = "Show_MoreTeamStats";
            this.Size = new System.Drawing.Size(1109, 774);
            this.Load += new System.EventHandler(this.Show_MoreTeamStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TeamConversions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TeamTries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TeamPenalties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TeamPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_TeamConversions;
        private System.Windows.Forms.DataGridView DGV_TeamTries;
        private System.Windows.Forms.DataGridView DGV_TeamPenalties;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_TeamPoints;
        private System.Windows.Forms.Label label1;
    }
}
