
namespace Jigsaw01
{
    partial class form_Register
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
            this.txt_regUsername = new System.Windows.Forms.TextBox();
            this.txt_regPassword = new System.Windows.Forms.TextBox();
            this.btn_regRegister = new System.Windows.Forms.Button();
            this.btn_regBack = new System.Windows.Forms.Button();
            this.txt_regConPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_regUsername
            // 
            this.txt_regUsername.Location = new System.Drawing.Point(370, 126);
            this.txt_regUsername.Name = "txt_regUsername";
            this.txt_regUsername.Size = new System.Drawing.Size(100, 20);
            this.txt_regUsername.TabIndex = 0;
            // 
            // txt_regPassword
            // 
            this.txt_regPassword.Location = new System.Drawing.Point(370, 152);
            this.txt_regPassword.Name = "txt_regPassword";
            this.txt_regPassword.PasswordChar = '*';
            this.txt_regPassword.Size = new System.Drawing.Size(100, 20);
            this.txt_regPassword.TabIndex = 1;
            // 
            // btn_regRegister
            // 
            this.btn_regRegister.Location = new System.Drawing.Point(395, 204);
            this.btn_regRegister.Name = "btn_regRegister";
            this.btn_regRegister.Size = new System.Drawing.Size(75, 23);
            this.btn_regRegister.TabIndex = 2;
            this.btn_regRegister.Text = "Register";
            this.btn_regRegister.UseVisualStyleBackColor = true;
            this.btn_regRegister.Click += new System.EventHandler(this.btn_regRegister_Click);
            // 
            // btn_regBack
            // 
            this.btn_regBack.Location = new System.Drawing.Point(713, 415);
            this.btn_regBack.Name = "btn_regBack";
            this.btn_regBack.Size = new System.Drawing.Size(75, 23);
            this.btn_regBack.TabIndex = 3;
            this.btn_regBack.Text = "Back";
            this.btn_regBack.UseVisualStyleBackColor = true;
            this.btn_regBack.Click += new System.EventHandler(this.btn_regBack_Click);
            // 
            // txt_regConPassword
            // 
            this.txt_regConPassword.Location = new System.Drawing.Point(370, 178);
            this.txt_regConPassword.Name = "txt_regConPassword";
            this.txt_regConPassword.PasswordChar = '*';
            this.txt_regConPassword.Size = new System.Drawing.Size(100, 20);
            this.txt_regConPassword.TabIndex = 4;
            // 
            // form_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_regConPassword);
            this.Controls.Add(this.btn_regBack);
            this.Controls.Add(this.btn_regRegister);
            this.Controls.Add(this.txt_regPassword);
            this.Controls.Add(this.txt_regUsername);
            this.Name = "form_Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_regUsername;
        private System.Windows.Forms.TextBox txt_regPassword;
        private System.Windows.Forms.Button btn_regRegister;
        private System.Windows.Forms.Button btn_regBack;
        private System.Windows.Forms.TextBox txt_regConPassword;
    }
}