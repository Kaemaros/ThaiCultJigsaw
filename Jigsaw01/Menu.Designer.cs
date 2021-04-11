
namespace Jigsaw01
{
    partial class form_Menu
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
            this.btn_menuSelect = new System.Windows.Forms.Button();
            this.btn_menuAbout = new System.Windows.Forms.Button();
            this.btn_menuScore = new System.Windows.Forms.Button();
            this.btn_menuExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_menuSelect
            // 
            this.btn_menuSelect.Location = new System.Drawing.Point(529, 97);
            this.btn_menuSelect.Name = "btn_menuSelect";
            this.btn_menuSelect.Size = new System.Drawing.Size(99, 23);
            this.btn_menuSelect.TabIndex = 0;
            this.btn_menuSelect.Text = "Select Stage";
            this.btn_menuSelect.UseVisualStyleBackColor = true;
            this.btn_menuSelect.Click += new System.EventHandler(this.btn_menuSelect_Click);
            // 
            // btn_menuAbout
            // 
            this.btn_menuAbout.Location = new System.Drawing.Point(529, 127);
            this.btn_menuAbout.Name = "btn_menuAbout";
            this.btn_menuAbout.Size = new System.Drawing.Size(98, 23);
            this.btn_menuAbout.TabIndex = 1;
            this.btn_menuAbout.Text = "About Us";
            this.btn_menuAbout.UseVisualStyleBackColor = true;
            this.btn_menuAbout.Click += new System.EventHandler(this.btn_menuAbout_Click);
            // 
            // btn_menuScore
            // 
            this.btn_menuScore.Location = new System.Drawing.Point(529, 156);
            this.btn_menuScore.Name = "btn_menuScore";
            this.btn_menuScore.Size = new System.Drawing.Size(98, 23);
            this.btn_menuScore.TabIndex = 2;
            this.btn_menuScore.Text = "Score";
            this.btn_menuScore.UseVisualStyleBackColor = true;
            this.btn_menuScore.Click += new System.EventHandler(this.btn_menuScore_Click);
            // 
            // btn_menuExit
            // 
            this.btn_menuExit.Location = new System.Drawing.Point(529, 185);
            this.btn_menuExit.Name = "btn_menuExit";
            this.btn_menuExit.Size = new System.Drawing.Size(98, 23);
            this.btn_menuExit.TabIndex = 3;
            this.btn_menuExit.Text = "Exit";
            this.btn_menuExit.UseVisualStyleBackColor = true;
            this.btn_menuExit.Click += new System.EventHandler(this.btn_menuExit_Click);
            // 
            // form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_menuExit);
            this.Controls.Add(this.btn_menuScore);
            this.Controls.Add(this.btn_menuAbout);
            this.Controls.Add(this.btn_menuSelect);
            this.Name = "form_Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_menuSelect;
        private System.Windows.Forms.Button btn_menuAbout;
        private System.Windows.Forms.Button btn_menuScore;
        private System.Windows.Forms.Button btn_menuExit;
    }
}