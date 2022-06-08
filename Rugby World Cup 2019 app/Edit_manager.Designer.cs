
namespace Rugby_World_Cup_2019_app
{
    partial class Edit_manager
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
            this.round_btn_insertManager = new Rugby_World_Cup_2019_app.RoundButton();
            this.round_btn_deleteManager = new Rugby_World_Cup_2019_app.RoundButton();
            this.dGV_edit_manager = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.round_btn_updateManager = new Rugby_World_Cup_2019_app.RoundButton();
            this.picBox_edit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_manager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // round_btn_insertManager
            // 
            this.round_btn_insertManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_insertManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.round_btn_insertManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_insertManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_insertManager.Location = new System.Drawing.Point(187, 537);
            this.round_btn_insertManager.Name = "round_btn_insertManager";
            this.round_btn_insertManager.Size = new System.Drawing.Size(75, 75);
            this.round_btn_insertManager.TabIndex = 36;
            this.round_btn_insertManager.Text = "+";
            this.round_btn_insertManager.UseVisualStyleBackColor = false;
            // 
            // round_btn_deleteManager
            // 
            this.round_btn_deleteManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_deleteManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_deleteManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_deleteManager.Location = new System.Drawing.Point(859, 537);
            this.round_btn_deleteManager.Name = "round_btn_deleteManager";
            this.round_btn_deleteManager.Size = new System.Drawing.Size(75, 75);
            this.round_btn_deleteManager.TabIndex = 35;
            this.round_btn_deleteManager.Text = "DEL";
            this.round_btn_deleteManager.UseVisualStyleBackColor = false;
            this.round_btn_deleteManager.Click += new System.EventHandler(this.round_btn_deleteManager_Click);
            // 
            // dGV_edit_manager
            // 
            this.dGV_edit_manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_edit_manager.Location = new System.Drawing.Point(122, 62);
            this.dGV_edit_manager.Name = "dGV_edit_manager";
            this.dGV_edit_manager.RowHeadersWidth = 62;
            this.dGV_edit_manager.RowTemplate.Height = 28;
            this.dGV_edit_manager.Size = new System.Drawing.Size(858, 437);
            this.dGV_edit_manager.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 32;
            this.label1.Text = "MANAGER";
            // 
            // round_btn_updateManager
            // 
            this.round_btn_updateManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(188)))));
            this.round_btn_updateManager.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.available_updates_64;
            this.round_btn_updateManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_btn_updateManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round_btn_updateManager.Location = new System.Drawing.Point(536, 542);
            this.round_btn_updateManager.Name = "round_btn_updateManager";
            this.round_btn_updateManager.Size = new System.Drawing.Size(64, 70);
            this.round_btn_updateManager.TabIndex = 34;
            this.round_btn_updateManager.UseVisualStyleBackColor = false;
            // 
            // picBox_edit
            // 
            this.picBox_edit.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.edit_24;
            this.picBox_edit.Location = new System.Drawing.Point(14, 22);
            this.picBox_edit.Name = "picBox_edit";
            this.picBox_edit.Size = new System.Drawing.Size(25, 24);
            this.picBox_edit.TabIndex = 31;
            this.picBox_edit.TabStop = false;
            // 
            // Edit_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.image_1_;
            this.Controls.Add(this.round_btn_insertManager);
            this.Controls.Add(this.round_btn_deleteManager);
            this.Controls.Add(this.round_btn_updateManager);
            this.Controls.Add(this.dGV_edit_manager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_edit);
            this.Name = "Edit_manager";
            this.Size = new System.Drawing.Size(1109, 743);
            this.Load += new System.EventHandler(this.Edit_manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_edit_manager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton round_btn_insertManager;
        private RoundButton round_btn_deleteManager;
        private RoundButton round_btn_updateManager;
        private System.Windows.Forms.DataGridView dGV_edit_manager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox_edit;
    }
}
