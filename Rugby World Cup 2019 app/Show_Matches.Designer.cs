
namespace Rugby_World_Cup_2019_app
{
    partial class Show_Matches
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
            this.btn_matchesTable = new System.Windows.Forms.Button();
            this.dataGridView_allMatches = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_allMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_matchesTable
            // 
            this.btn_matchesTable.Location = new System.Drawing.Point(1022, 3);
            this.btn_matchesTable.Name = "btn_matchesTable";
            this.btn_matchesTable.Size = new System.Drawing.Size(75, 39);
            this.btn_matchesTable.TabIndex = 0;
            this.btn_matchesTable.Text = "TABLE";
            this.btn_matchesTable.UseVisualStyleBackColor = true;
            this.btn_matchesTable.Click += new System.EventHandler(this.btn_matchesTable_Click);
            // 
            // dataGridView_allMatches
            // 
            this.dataGridView_allMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_allMatches.Location = new System.Drawing.Point(27, 101);
            this.dataGridView_allMatches.Name = "dataGridView_allMatches";
            this.dataGridView_allMatches.RowHeadersWidth = 62;
            this.dataGridView_allMatches.RowTemplate.Height = 28;
            this.dataGridView_allMatches.Size = new System.Drawing.Size(1070, 474);
            this.dataGridView_allMatches.TabIndex = 1;
            // 
            // Show_Matches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_allMatches);
            this.Controls.Add(this.btn_matchesTable);
            this.Name = "Show_Matches";
            this.Size = new System.Drawing.Size(1109, 774);
            this.Load += new System.EventHandler(this.Show_Matches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_allMatches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_matchesTable;
        private System.Windows.Forms.DataGridView dataGridView_allMatches;
    }
}
