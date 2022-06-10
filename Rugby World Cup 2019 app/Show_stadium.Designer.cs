
namespace Rugby_World_Cup_2019_app
{
    partial class Show_stadium
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
            this.pnl_maps = new System.Windows.Forms.Panel();
            this.btn_kugamaya = new System.Windows.Forms.Button();
            this.btn_sapporo = new System.Windows.Forms.Button();
            this.pnl_popUp = new System.Windows.Forms.Panel();
            this.picBox_stadium = new System.Windows.Forms.PictureBox();
            this.lbl_capacity = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.btn_kamaishi = new System.Windows.Forms.Button();
            this.pnl_maps.SuspendLayout();
            this.pnl_popUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_stadium)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_maps
            // 
            this.pnl_maps.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.image_4_;
            this.pnl_maps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_maps.Controls.Add(this.btn_kugamaya);
            this.pnl_maps.Controls.Add(this.btn_sapporo);
            this.pnl_maps.Controls.Add(this.pnl_popUp);
            this.pnl_maps.Controls.Add(this.btn_kamaishi);
            this.pnl_maps.Location = new System.Drawing.Point(47, 41);
            this.pnl_maps.Name = "pnl_maps";
            this.pnl_maps.Size = new System.Drawing.Size(1022, 565);
            this.pnl_maps.TabIndex = 0;
            // 
            // btn_kugamaya
            // 
            this.btn_kugamaya.BackColor = System.Drawing.Color.Red;
            this.btn_kugamaya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kugamaya.Location = new System.Drawing.Point(554, 375);
            this.btn_kugamaya.Name = "btn_kugamaya";
            this.btn_kugamaya.Size = new System.Drawing.Size(21, 20);
            this.btn_kugamaya.TabIndex = 3;
            this.btn_kugamaya.UseVisualStyleBackColor = false;
            this.btn_kugamaya.MouseLeave += new System.EventHandler(this.btn_kugamaya_MouseLeave);
            this.btn_kugamaya.MouseHover += new System.EventHandler(this.btn_kugamaya_MouseHover);
            // 
            // btn_sapporo
            // 
            this.btn_sapporo.BackColor = System.Drawing.Color.Red;
            this.btn_sapporo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sapporo.Location = new System.Drawing.Point(718, 105);
            this.btn_sapporo.Name = "btn_sapporo";
            this.btn_sapporo.Size = new System.Drawing.Size(21, 20);
            this.btn_sapporo.TabIndex = 0;
            this.btn_sapporo.UseVisualStyleBackColor = false;
            this.btn_sapporo.MouseLeave += new System.EventHandler(this.btn_sapporo_MouseLeave);
            this.btn_sapporo.MouseHover += new System.EventHandler(this.btn_sapporo_MouseHover);
            // 
            // pnl_popUp
            // 
            this.pnl_popUp.Controls.Add(this.picBox_stadium);
            this.pnl_popUp.Controls.Add(this.lbl_capacity);
            this.pnl_popUp.Controls.Add(this.lbl_name);
            this.pnl_popUp.Controls.Add(this.lbl_city);
            this.pnl_popUp.Location = new System.Drawing.Point(477, 128);
            this.pnl_popUp.Name = "pnl_popUp";
            this.pnl_popUp.Size = new System.Drawing.Size(285, 80);
            this.pnl_popUp.TabIndex = 1;
            // 
            // picBox_stadium
            // 
            this.picBox_stadium.Image = global::Rugby_World_Cup_2019_app.Properties.Resources.Kumagaya_Rugby_Stadium;
            this.picBox_stadium.Location = new System.Drawing.Point(187, 4);
            this.picBox_stadium.Name = "picBox_stadium";
            this.picBox_stadium.Size = new System.Drawing.Size(95, 72);
            this.picBox_stadium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_stadium.TabIndex = 3;
            this.picBox_stadium.TabStop = false;
            this.picBox_stadium.Visible = false;
            // 
            // lbl_capacity
            // 
            this.lbl_capacity.AutoSize = true;
            this.lbl_capacity.Location = new System.Drawing.Point(3, 56);
            this.lbl_capacity.Name = "lbl_capacity";
            this.lbl_capacity.Size = new System.Drawing.Size(51, 20);
            this.lbl_capacity.TabIndex = 2;
            this.lbl_capacity.Text = "label3";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(3, 28);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(51, 20);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "label2";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city.Location = new System.Drawing.Point(3, 3);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(57, 20);
            this.lbl_city.TabIndex = 0;
            this.lbl_city.Text = "label1";
            // 
            // btn_kamaishi
            // 
            this.btn_kamaishi.BackColor = System.Drawing.Color.Red;
            this.btn_kamaishi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kamaishi.Location = new System.Drawing.Point(679, 244);
            this.btn_kamaishi.Name = "btn_kamaishi";
            this.btn_kamaishi.Size = new System.Drawing.Size(21, 20);
            this.btn_kamaishi.TabIndex = 2;
            this.btn_kamaishi.UseVisualStyleBackColor = false;
            this.btn_kamaishi.MouseLeave += new System.EventHandler(this.btn_kamaishi_MouseLeave);
            this.btn_kamaishi.MouseHover += new System.EventHandler(this.btn_kamaishi_MouseHover);
            // 
            // Show_stadium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_maps);
            this.Name = "Show_stadium";
            this.Size = new System.Drawing.Size(1109, 743);
            this.Load += new System.EventHandler(this.Show_stadium_Load);
            this.pnl_maps.ResumeLayout(false);
            this.pnl_popUp.ResumeLayout(false);
            this.pnl_popUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_stadium)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_maps;
        private System.Windows.Forms.Button btn_sapporo;
        private System.Windows.Forms.Panel pnl_popUp;
        private System.Windows.Forms.PictureBox picBox_stadium;
        private System.Windows.Forms.Label lbl_capacity;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Button btn_kamaishi;
        private System.Windows.Forms.Button btn_kugamaya;
    }
}
