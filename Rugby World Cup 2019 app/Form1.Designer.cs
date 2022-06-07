
namespace Rugby_World_Cup_2019_app
{
    partial class Form_Intro
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
            this.pnl_Intro = new System.Windows.Forms.Panel();
            this.picBox_logo = new System.Windows.Forms.PictureBox();
            this.roundBtn_edit = new Rugby_World_Cup_2019_app.RoundButton();
            this.roundBtn_cont = new Rugby_World_Cup_2019_app.RoundButton();
            this.cBox_btn_music = new System.Windows.Forms.CheckBox();
            this.roundBtn_exit = new Rugby_World_Cup_2019_app.RoundButton();
            this.pnl_Intro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Intro
            // 
            this.pnl_Intro.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.output_onlinejpgtools_1_1;
            this.pnl_Intro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Intro.Controls.Add(this.picBox_logo);
            this.pnl_Intro.Controls.Add(this.roundBtn_edit);
            this.pnl_Intro.Controls.Add(this.roundBtn_cont);
            this.pnl_Intro.Controls.Add(this.cBox_btn_music);
            this.pnl_Intro.Controls.Add(this.roundBtn_exit);
            this.pnl_Intro.Location = new System.Drawing.Point(0, 2);
            this.pnl_Intro.Name = "pnl_Intro";
            this.pnl_Intro.Size = new System.Drawing.Size(1172, 526);
            this.pnl_Intro.TabIndex = 0;
            // 
            // picBox_logo
            // 
            this.picBox_logo.BackColor = System.Drawing.Color.Transparent;
            this.picBox_logo.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.output_onlinejpgtools_2__removebg_preview;
            this.picBox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_logo.Location = new System.Drawing.Point(502, 13);
            this.picBox_logo.Name = "picBox_logo";
            this.picBox_logo.Size = new System.Drawing.Size(173, 183);
            this.picBox_logo.TabIndex = 4;
            this.picBox_logo.TabStop = false;
            // 
            // roundBtn_edit
            // 
            this.roundBtn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(201)))));
            this.roundBtn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundBtn_edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.roundBtn_edit.Location = new System.Drawing.Point(466, 418);
            this.roundBtn_edit.Name = "roundBtn_edit";
            this.roundBtn_edit.Size = new System.Drawing.Size(237, 66);
            this.roundBtn_edit.TabIndex = 3;
            this.roundBtn_edit.Text = "EDIT";
            this.roundBtn_edit.UseVisualStyleBackColor = false;
            this.roundBtn_edit.Click += new System.EventHandler(this.roundBtn_edit_Click_1);
            // 
            // roundBtn_cont
            // 
            this.roundBtn_cont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(201)))));
            this.roundBtn_cont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundBtn_cont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.roundBtn_cont.Location = new System.Drawing.Point(466, 339);
            this.roundBtn_cont.Name = "roundBtn_cont";
            this.roundBtn_cont.Size = new System.Drawing.Size(237, 66);
            this.roundBtn_cont.TabIndex = 2;
            this.roundBtn_cont.Text = "CONTINUE";
            this.roundBtn_cont.UseVisualStyleBackColor = false;
            this.roundBtn_cont.Click += new System.EventHandler(this.roundBtn_cont_Click);
            // 
            // cBox_btn_music
            // 
            this.cBox_btn_music.Appearance = System.Windows.Forms.Appearance.Button;
            this.cBox_btn_music.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(201)))));
            this.cBox_btn_music.BackgroundImage = global::Rugby_World_Cup_2019_app.Properties.Resources.sound_off_removebg_preview_2__1_;
            this.cBox_btn_music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cBox_btn_music.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cBox_btn_music.Checked = true;
            this.cBox_btn_music.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBox_btn_music.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_btn_music.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cBox_btn_music.Location = new System.Drawing.Point(12, 10);
            this.cBox_btn_music.Name = "cBox_btn_music";
            this.cBox_btn_music.Size = new System.Drawing.Size(60, 60);
            this.cBox_btn_music.TabIndex = 1;
            this.cBox_btn_music.UseVisualStyleBackColor = false;
            this.cBox_btn_music.CheckedChanged += new System.EventHandler(this.cBox_btn_music_CheckedChanged);
            // 
            // roundBtn_exit
            // 
            this.roundBtn_exit.BackColor = System.Drawing.Color.Red;
            this.roundBtn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundBtn_exit.Location = new System.Drawing.Point(1100, 3);
            this.roundBtn_exit.Name = "roundBtn_exit";
            this.roundBtn_exit.Size = new System.Drawing.Size(60, 60);
            this.roundBtn_exit.TabIndex = 0;
            this.roundBtn_exit.Text = "X";
            this.roundBtn_exit.UseVisualStyleBackColor = false;
            this.roundBtn_exit.Click += new System.EventHandler(this.roundBtn_exit_Click);
            // 
            // Form_Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 526);
            this.Controls.Add(this.pnl_Intro);
            this.Name = "Form_Intro";
            this.Text = "Rugby World Cup 2019";
            this.Load += new System.EventHandler(this.Form_Intro_Load);
            this.pnl_Intro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Intro;
        private RoundButton roundBtn_exit;
        private System.Windows.Forms.CheckBox cBox_btn_music;
        private RoundButton roundBtn_edit;
        private RoundButton roundBtn_cont;
        private System.Windows.Forms.PictureBox picBox_logo;
    }
}

