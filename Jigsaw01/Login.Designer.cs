
namespace Jigsaw01
{
    partial class form_Login
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
            this.txt_LoginUsername = new System.Windows.Forms.TextBox();
            this.txt_LoginPassword = new System.Windows.Forms.TextBox();
            this.btn_logLogin = new System.Windows.Forms.Button();
            this.btn_logRegister = new System.Windows.Forms.Button();
            this.btn_logExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_LoginUsername
            // 
            this.txt_LoginUsername.Location = new System.Drawing.Point(338, 83);
            this.txt_LoginUsername.Name = "txt_LoginUsername";
            this.txt_LoginUsername.Size = new System.Drawing.Size(100, 20);
            this.txt_LoginUsername.TabIndex = 0;
            this.txt_LoginUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_LoginPassword
            // 
            this.txt_LoginPassword.Location = new System.Drawing.Point(338, 122);
            this.txt_LoginPassword.Name = "txt_LoginPassword";
            this.txt_LoginPassword.PasswordChar = '*';
            this.txt_LoginPassword.Size = new System.Drawing.Size(100, 20);
            this.txt_LoginPassword.TabIndex = 1;
            this.txt_LoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_logLogin
            // 
            this.btn_logLogin.Location = new System.Drawing.Point(363, 148);
            this.btn_logLogin.Name = "btn_logLogin";
            this.btn_logLogin.Size = new System.Drawing.Size(75, 23);
            this.btn_logLogin.TabIndex = 2;
            this.btn_logLogin.Text = "Login";
            this.btn_logLogin.UseVisualStyleBackColor = true;
            this.btn_logLogin.Click += new System.EventHandler(this.btn_logLogin_Click);
            // 
            // btn_logRegister
            // 
            this.btn_logRegister.Location = new System.Drawing.Point(363, 177);
            this.btn_logRegister.Name = "btn_logRegister";
            this.btn_logRegister.Size = new System.Drawing.Size(75, 23);
            this.btn_logRegister.TabIndex = 3;
            this.btn_logRegister.Text = "Register";
            this.btn_logRegister.UseVisualStyleBackColor = true;
            this.btn_logRegister.Click += new System.EventHandler(this.btn_logRegister_Click);
            // 
            // btn_logExit
            // 
            this.btn_logExit.Location = new System.Drawing.Point(697, 396);
            this.btn_logExit.Name = "btn_logExit";
            this.btn_logExit.Size = new System.Drawing.Size(75, 23);
            this.btn_logExit.TabIndex = 4;
            this.btn_logExit.Text = "Exit";
            this.btn_logExit.UseVisualStyleBackColor = true;
            this.btn_logExit.Click += new System.EventHandler(this.btn_logExit_Click);
            // 
            // form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_logExit);
            this.Controls.Add(this.btn_logRegister);
            this.Controls.Add(this.btn_logLogin);
            this.Controls.Add(this.txt_LoginPassword);
            this.Controls.Add(this.txt_LoginUsername);
            this.Name = "form_Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_LoginUsername;
        private System.Windows.Forms.TextBox txt_LoginPassword;
        private System.Windows.Forms.Button btn_logLogin;
        private System.Windows.Forms.Button btn_logRegister;
        private System.Windows.Forms.Button btn_logExit;
    }
}

