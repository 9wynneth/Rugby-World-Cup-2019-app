
namespace Rugby_World_Cup_2019_app
{
    partial class ChangingAccess
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
            this.btn_cont = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.tBoxPass = new System.Windows.Forms.TextBox();
            this.tBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cont
            // 
            this.btn_cont.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_cont.Location = new System.Drawing.Point(542, 244);
            this.btn_cont.Name = "btn_cont";
            this.btn_cont.Size = new System.Drawing.Size(112, 34);
            this.btn_cont.TabIndex = 11;
            this.btn_cont.Text = "Continue";
            this.btn_cont.UseVisualStyleBackColor = false;
            this.btn_cont.Click += new System.EventHandler(this.btn_cont_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(394, 244);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(112, 34);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // tBoxPass
            // 
            this.tBoxPass.Location = new System.Drawing.Point(542, 183);
            this.tBoxPass.Name = "tBoxPass";
            this.tBoxPass.Size = new System.Drawing.Size(218, 26);
            this.tBoxPass.TabIndex = 9;
            // 
            // tBoxUsername
            // 
            this.tBoxUsername.Location = new System.Drawing.Point(542, 132);
            this.tBoxUsername.Name = "tBoxUsername";
            this.tBoxUsername.Size = new System.Drawing.Size(329, 26);
            this.tBoxUsername.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Change Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Change Username:";
            // 
            // ChangingAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_cont);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tBoxPass);
            this.Controls.Add(this.tBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangingAccess";
            this.Size = new System.Drawing.Size(1109, 743);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cont;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox tBoxPass;
        private System.Windows.Forms.TextBox tBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
