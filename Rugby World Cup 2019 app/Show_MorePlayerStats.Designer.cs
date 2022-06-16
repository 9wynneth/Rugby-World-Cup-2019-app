
namespace Rugby_World_Cup_2019_app
{
    partial class Show_MorePlayerStats
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
            this.DGV_PlayerPoints = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_PlayerPenalties = new System.Windows.Forms.DataGridView();
            this.DGV_PlayerTries = new System.Windows.Forms.DataGridView();
            this.DGV_PlayerConversions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PlayerPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PlayerPenalties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PlayerTries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PlayerConversions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "POINTS SCORED";
            // 
            // DGV_PlayerPoints
            // 
            this.DGV_PlayerPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PlayerPoints.Location = new System.Drawing.Point(19, 61);
            this.DGV_PlayerPoints.Name = "DGV_PlayerPoints";
            this.DGV_PlayerPoints.RowHeadersWidth = 62;
            this.DGV_PlayerPoints.RowTemplate.Height = 28;
            this.DGV_PlayerPoints.Size = new System.Drawing.Size(449, 213);
            this.DGV_PlayerPoints.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "TRIED SCORED";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "PENALTIES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "CONVERSIONS";
            // 
            // DGV_PlayerPenalties
            // 
            this.DGV_PlayerPenalties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PlayerPenalties.Location = new System.Drawing.Point(19, 347);
            this.DGV_PlayerPenalties.Name = "DGV_PlayerPenalties";
            this.DGV_PlayerPenalties.RowHeadersWidth = 62;
            this.DGV_PlayerPenalties.RowTemplate.Height = 28;
            this.DGV_PlayerPenalties.Size = new System.Drawing.Size(449, 213);
            this.DGV_PlayerPenalties.TabIndex = 5;
            // 
            // DGV_PlayerTries
            // 
            this.DGV_PlayerTries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PlayerTries.Location = new System.Drawing.Point(587, 61);
            this.DGV_PlayerTries.Name = "DGV_PlayerTries";
            this.DGV_PlayerTries.RowHeadersWidth = 62;
            this.DGV_PlayerTries.RowTemplate.Height = 28;
            this.DGV_PlayerTries.Size = new System.Drawing.Size(449, 213);
            this.DGV_PlayerTries.TabIndex = 6;
            // 
            // DGV_PlayerConversions
            // 
            this.DGV_PlayerConversions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PlayerConversions.Location = new System.Drawing.Point(587, 347);
            this.DGV_PlayerConversions.Name = "DGV_PlayerConversions";
            this.DGV_PlayerConversions.RowHeadersWidth = 62;
            this.DGV_PlayerConversions.RowTemplate.Height = 28;
            this.DGV_PlayerConversions.Size = new System.Drawing.Size(449, 213);
            this.DGV_PlayerConversions.TabIndex = 7;
            // 
            // Show_MorePlayerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DGV_PlayerConversions);
            this.Controls.Add(this.DGV_PlayerTries);
            this.Controls.Add(this.DGV_PlayerPenalties);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_PlayerPoints);
            this.Controls.Add(this.label1);
            this.Name = "Show_MorePlayerStats";
            this.Size = new System.Drawing.Size(1109, 774);
            this.Load += new System.EventHandler(this.Show_MorePlayerStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PlayerPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PlayerPenalties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PlayerTries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PlayerConversions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_PlayerPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV_PlayerPenalties;
        private System.Windows.Forms.DataGridView DGV_PlayerTries;
        private System.Windows.Forms.DataGridView DGV_PlayerConversions;
    }
}
