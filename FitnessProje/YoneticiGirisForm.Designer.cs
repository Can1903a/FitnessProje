﻿namespace Fitness
{
    partial class YoneticiGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiGirisForm));
            this.KullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.SifreTextBox = new System.Windows.Forms.TextBox();
            this.GirisButon = new System.Windows.Forms.Button();
            this.GeriButon8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon8)).BeginInit();
            this.SuspendLayout();
            // 
            // KullaniciAdiTextBox
            // 
            this.KullaniciAdiTextBox.Location = new System.Drawing.Point(197, 104);
            this.KullaniciAdiTextBox.Name = "KullaniciAdiTextBox";
            this.KullaniciAdiTextBox.Size = new System.Drawing.Size(80, 20);
            this.KullaniciAdiTextBox.TabIndex = 0;
            // 
            // SifreTextBox
            // 
            this.SifreTextBox.Location = new System.Drawing.Point(197, 146);
            this.SifreTextBox.Name = "SifreTextBox";
            this.SifreTextBox.Size = new System.Drawing.Size(80, 20);
            this.SifreTextBox.TabIndex = 1;
            // 
            // GirisButon
            // 
            this.GirisButon.Location = new System.Drawing.Point(197, 190);
            this.GirisButon.Name = "GirisButon";
            this.GirisButon.Size = new System.Drawing.Size(67, 40);
            this.GirisButon.TabIndex = 2;
            this.GirisButon.Text = "button1";
            this.GirisButon.UseVisualStyleBackColor = true;
            this.GirisButon.Click += new System.EventHandler(this.GirisButon_Click);
            // 
            // GeriButon8
            // 
            this.GeriButon8.Image = ((System.Drawing.Image)(resources.GetObject("GeriButon8.Image")));
            this.GeriButon8.Location = new System.Drawing.Point(37, 56);
            this.GeriButon8.Name = "GeriButon8";
            this.GeriButon8.Size = new System.Drawing.Size(57, 36);
            this.GeriButon8.TabIndex = 9;
            this.GeriButon8.TabStop = false;
            this.GeriButon8.Click += new System.EventHandler(this.GeriButon8_Click);
            // 
            // YoneticiGirisForm
            // 
            this.ClientSize = new System.Drawing.Size(607, 459);
            this.Controls.Add(this.GeriButon8);
            this.Controls.Add(this.GirisButon);
            this.Controls.Add(this.SifreTextBox);
            this.Controls.Add(this.KullaniciAdiTextBox);
            this.Name = "YoneticiGirisForm";
            this.Load += new System.EventHandler(this.YoneticiGirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KullaniciAdiTextBox;
        private System.Windows.Forms.TextBox SifreTextBox;
        private System.Windows.Forms.Button GirisButon;
        private System.Windows.Forms.PictureBox GeriButon8;
    }
}