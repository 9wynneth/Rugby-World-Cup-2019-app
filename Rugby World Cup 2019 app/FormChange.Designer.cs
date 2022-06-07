
namespace Rugby_World_Cup_2019_app
{
    partial class FormChange
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
            this.components = new System.ComponentModel.Container();
            this.btn_contChng = new System.Windows.Forms.Button();
            this.btn_backChng = new System.Windows.Forms.Button();
            this.tBoxPassChng = new System.Windows.Forms.TextBox();
            this.tBoxUsernameChng = new System.Windows.Forms.TextBox();
            this.label2Chng = new System.Windows.Forms.Label();
            this.label1Chng = new System.Windows.Forms.Label();
            this.errorUsernameChng = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPassChng = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorUsernameChng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassChng)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_contChng
            // 
            this.btn_contChng.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_contChng.Location = new System.Drawing.Point(220, 143);
            this.btn_contChng.Name = "btn_contChng";
            this.btn_contChng.Size = new System.Drawing.Size(112, 34);
            this.btn_contChng.TabIndex = 11;
            this.btn_contChng.Text = "Continue";
            this.btn_contChng.UseVisualStyleBackColor = false;
            this.btn_contChng.Click += new System.EventHandler(this.btn_contChng_Click);
            // 
            // btn_backChng
            // 
            this.btn_backChng.Location = new System.Drawing.Point(72, 143);
            this.btn_backChng.Name = "btn_backChng";
            this.btn_backChng.Size = new System.Drawing.Size(112, 34);
            this.btn_backChng.TabIndex = 10;
            this.btn_backChng.Text = "Back";
            this.btn_backChng.UseVisualStyleBackColor = true;
            this.btn_backChng.Click += new System.EventHandler(this.btn_backChng_Click);
            // 
            // tBoxPassChng
            // 
            this.tBoxPassChng.Location = new System.Drawing.Point(220, 82);
            this.tBoxPassChng.Name = "tBoxPassChng";
            this.tBoxPassChng.Size = new System.Drawing.Size(218, 26);
            this.tBoxPassChng.TabIndex = 9;
            this.tBoxPassChng.TextChanged += new System.EventHandler(this.tBoxPassChng_TextChanged);
            // 
            // tBoxUsernameChng
            // 
            this.tBoxUsernameChng.Location = new System.Drawing.Point(220, 31);
            this.tBoxUsernameChng.Name = "tBoxUsernameChng";
            this.tBoxUsernameChng.Size = new System.Drawing.Size(329, 26);
            this.tBoxUsernameChng.TabIndex = 8;
            this.tBoxUsernameChng.TextChanged += new System.EventHandler(this.tBoxUsernameChng_TextChanged);
            // 
            // label2Chng
            // 
            this.label2Chng.AutoSize = true;
            this.label2Chng.Location = new System.Drawing.Point(72, 82);
            this.label2Chng.Name = "label2Chng";
            this.label2Chng.Size = new System.Drawing.Size(82, 20);
            this.label2Chng.TabIndex = 7;
            this.label2Chng.Text = "Password:";
            // 
            // label1Chng
            // 
            this.label1Chng.AutoSize = true;
            this.label1Chng.Location = new System.Drawing.Point(72, 31);
            this.label1Chng.Name = "label1Chng";
            this.label1Chng.Size = new System.Drawing.Size(87, 20);
            this.label1Chng.TabIndex = 6;
            this.label1Chng.Text = "Username:";
            // 
            // errorUsernameChng
            // 
            this.errorUsernameChng.ContainerControl = this;
            // 
            // errorPassChng
            // 
            this.errorPassChng.ContainerControl = this;
            // 
            // FormChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 209);
            this.Controls.Add(this.btn_contChng);
            this.Controls.Add(this.btn_backChng);
            this.Controls.Add(this.tBoxPassChng);
            this.Controls.Add(this.tBoxUsernameChng);
            this.Controls.Add(this.label2Chng);
            this.Controls.Add(this.label1Chng);
            this.Name = "FormChange";
            this.Text = "FormChange";
            this.Load += new System.EventHandler(this.FormChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorUsernameChng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassChng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_contChng;
        private System.Windows.Forms.Button btn_backChng;
        private System.Windows.Forms.TextBox tBoxPassChng;
        private System.Windows.Forms.TextBox tBoxUsernameChng;
        private System.Windows.Forms.Label label2Chng;
        private System.Windows.Forms.Label label1Chng;
        private System.Windows.Forms.ErrorProvider errorUsernameChng;
        private System.Windows.Forms.ErrorProvider errorPassChng;
    }
}