namespace Fitness
{
    partial class Anasayfa
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
            this.YoneticiGirisiButton = new System.Windows.Forms.Button();
            this.MusteriGirisiButton = new System.Windows.Forms.Button();
            this.Btn_Antrenor = new System.Windows.Forms.Button();
            this.btnMusteriKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YoneticiGirisiButton
            // 
            this.YoneticiGirisiButton.Location = new System.Drawing.Point(329, 60);
            this.YoneticiGirisiButton.Name = "YoneticiGirisiButton";
            this.YoneticiGirisiButton.Size = new System.Drawing.Size(125, 57);
            this.YoneticiGirisiButton.TabIndex = 0;
            this.YoneticiGirisiButton.Text = "Yönetici Giriş";
            this.YoneticiGirisiButton.UseVisualStyleBackColor = true;
            this.YoneticiGirisiButton.Click += new System.EventHandler(this.YoneticiGirisiButton_Click);
            // 
            // MusteriGirisiButton
            // 
            this.MusteriGirisiButton.Location = new System.Drawing.Point(329, 132);
            this.MusteriGirisiButton.Name = "MusteriGirisiButton";
            this.MusteriGirisiButton.Size = new System.Drawing.Size(125, 57);
            this.MusteriGirisiButton.TabIndex = 0;
            this.MusteriGirisiButton.Text = "Müşteri Giriş";
            this.MusteriGirisiButton.UseVisualStyleBackColor = true;
            this.MusteriGirisiButton.Click += new System.EventHandler(this.MusteriGirisiButton_Click);
            // 
            // Btn_Antrenor
            // 
            this.Btn_Antrenor.Location = new System.Drawing.Point(329, 218);
            this.Btn_Antrenor.Name = "Btn_Antrenor";
            this.Btn_Antrenor.Size = new System.Drawing.Size(125, 57);
            this.Btn_Antrenor.TabIndex = 0;
            this.Btn_Antrenor.Text = "Antrenor Giriş";
            this.Btn_Antrenor.UseVisualStyleBackColor = true;
            this.Btn_Antrenor.Click += new System.EventHandler(this.Btn_Antrenor_Click);
            // 
            // btnMusteriKayit
            // 
            this.btnMusteriKayit.Location = new System.Drawing.Point(329, 298);
            this.btnMusteriKayit.Name = "btnMusteriKayit";
            this.btnMusteriKayit.Size = new System.Drawing.Size(125, 57);
            this.btnMusteriKayit.TabIndex = 0;
            this.btnMusteriKayit.Text = "Müşteri Kayıt";
            this.btnMusteriKayit.UseVisualStyleBackColor = true;
            this.btnMusteriKayit.Click += new System.EventHandler(this.btnMusteriKayit_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMusteriKayit);
            this.Controls.Add(this.Btn_Antrenor);
            this.Controls.Add(this.MusteriGirisiButton);
            this.Controls.Add(this.YoneticiGirisiButton);
            this.Name = "Anasayfa";
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YoneticiGirisiButton;
        private System.Windows.Forms.Button MusteriGirisiButton;
        private System.Windows.Forms.Button Btn_Antrenor;
        private System.Windows.Forms.Button btnMusteriKayit;
    }
}