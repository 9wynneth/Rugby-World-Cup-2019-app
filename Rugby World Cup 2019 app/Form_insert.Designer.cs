
namespace Rugby_World_Cup_2019_app
{
    partial class Form_Edit_Referee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBox_refereeID = new System.Windows.Forms.TextBox();
            this.tBox_refereeName = new System.Windows.Forms.TextBox();
            this.cBox_nationality = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.roundButton_back = new Rugby_World_Cup_2019_app.RoundButton();
            this.btn_insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "REFEREE ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "REFEREE NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "NATIONALITY:";
            // 
            // tBox_refereeID
            // 
            this.tBox_refereeID.Location = new System.Drawing.Point(262, 52);
            this.tBox_refereeID.Name = "tBox_refereeID";
            this.tBox_refereeID.Size = new System.Drawing.Size(155, 26);
            this.tBox_refereeID.TabIndex = 3;
            // 
            // tBox_refereeName
            // 
            this.tBox_refereeName.Location = new System.Drawing.Point(262, 102);
            this.tBox_refereeName.Name = "tBox_refereeName";
            this.tBox_refereeName.Size = new System.Drawing.Size(366, 26);
            this.tBox_refereeName.TabIndex = 4;
            // 
            // cBox_nationality
            // 
            this.cBox_nationality.FormattingEnabled = true;
            this.cBox_nationality.Location = new System.Drawing.Point(262, 154);
            this.cBox_nationality.Name = "cBox_nationality";
            this.cBox_nationality.Size = new System.Drawing.Size(155, 28);
            this.cBox_nationality.TabIndex = 5;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(120, 221);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(86, 29);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(262, 221);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(86, 29);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // roundButton_back
            // 
            this.roundButton_back.Image = global::Rugby_World_Cup_2019_app.Properties.Resources.imageedit_4_4530618903_1__1_1;
            this.roundButton_back.Location = new System.Drawing.Point(769, 221);
            this.roundButton_back.Name = "roundButton_back";
            this.roundButton_back.Size = new System.Drawing.Size(50, 50);
            this.roundButton_back.TabIndex = 9;
            this.roundButton_back.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(396, 219);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(101, 31);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // Form_Edit_Referee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 283);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.roundButton_back);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cBox_nationality);
            this.Controls.Add(this.tBox_refereeName);
            this.Controls.Add(this.tBox_refereeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Edit_Referee";
            this.Text = "Form_Edit_Referee";
            this.Load += new System.EventHandler(this.Form_Edit_Referee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBox_refereeID;
        private System.Windows.Forms.TextBox tBox_refereeName;
        private System.Windows.Forms.ComboBox cBox_nationality;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_update;
        private RoundButton roundButton_back;
        private System.Windows.Forms.Button btn_insert;
    }
}