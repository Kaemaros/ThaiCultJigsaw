
namespace Jigsaw01
{
    partial class form_StageSelet
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
            this.btn_seletS1 = new System.Windows.Forms.Button();
            this.btn_seletS2 = new System.Windows.Forms.Button();
            this.btn_seletS3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_seletS1
            // 
            this.btn_seletS1.Location = new System.Drawing.Point(44, 36);
            this.btn_seletS1.Name = "btn_seletS1";
            this.btn_seletS1.Size = new System.Drawing.Size(75, 23);
            this.btn_seletS1.TabIndex = 0;
            this.btn_seletS1.Text = "btn_seletS1";
            this.btn_seletS1.UseVisualStyleBackColor = true;
            this.btn_seletS1.Click += new System.EventHandler(this.btn_seletS1_Click);
            // 
            // btn_seletS2
            // 
            this.btn_seletS2.Location = new System.Drawing.Point(151, 35);
            this.btn_seletS2.Name = "btn_seletS2";
            this.btn_seletS2.Size = new System.Drawing.Size(75, 23);
            this.btn_seletS2.TabIndex = 1;
            this.btn_seletS2.Text = "btn_seletS2";
            this.btn_seletS2.UseVisualStyleBackColor = true;
            this.btn_seletS2.Click += new System.EventHandler(this.btn_seletS2_Click);
            // 
            // btn_seletS3
            // 
            this.btn_seletS3.Location = new System.Drawing.Point(261, 35);
            this.btn_seletS3.Name = "btn_seletS3";
            this.btn_seletS3.Size = new System.Drawing.Size(75, 23);
            this.btn_seletS3.TabIndex = 2;
            this.btn_seletS3.Text = "btn_seletS3";
            this.btn_seletS3.UseVisualStyleBackColor = true;
            this.btn_seletS3.Click += new System.EventHandler(this.btn_seletS3_Click);
            // 
            // form_StageSelet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_seletS3);
            this.Controls.Add(this.btn_seletS2);
            this.Controls.Add(this.btn_seletS1);
            this.Name = "form_StageSelet";
            this.Text = "StageSelet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_seletS1;
        private System.Windows.Forms.Button btn_seletS2;
        private System.Windows.Forms.Button btn_seletS3;
    }
}