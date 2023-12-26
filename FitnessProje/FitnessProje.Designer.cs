namespace Fitness
{
    partial class FitnessProje
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YoneticiGirisiButton
            // 
            this.YoneticiGirisiButton.Location = new System.Drawing.Point(295, 371);
            this.YoneticiGirisiButton.Name = "YoneticiGirisiButton";
            this.YoneticiGirisiButton.Size = new System.Drawing.Size(113, 73);
            this.YoneticiGirisiButton.TabIndex = 0;
            this.YoneticiGirisiButton.Text = "Yönetici";
            this.YoneticiGirisiButton.UseVisualStyleBackColor = true;
            this.YoneticiGirisiButton.Click += new System.EventHandler(this.YoneticiGirisiButton_Click_1);
            // 
            // MusteriGirisiButton
            // 
            this.MusteriGirisiButton.Location = new System.Drawing.Point(295, 213);
            this.MusteriGirisiButton.Name = "MusteriGirisiButton";
            this.MusteriGirisiButton.Size = new System.Drawing.Size(113, 73);
            this.MusteriGirisiButton.TabIndex = 1;
            this.MusteriGirisiButton.Text = "Müşteri";
            this.MusteriGirisiButton.UseVisualStyleBackColor = true;
            this.MusteriGirisiButton.Click += new System.EventHandler(this.MusteriGirisiButton_Click_1);
            // 
            // Btn_Antrenor
            // 
            this.Btn_Antrenor.Location = new System.Drawing.Point(295, 292);
            this.Btn_Antrenor.Name = "Btn_Antrenor";
            this.Btn_Antrenor.Size = new System.Drawing.Size(113, 73);
            this.Btn_Antrenor.TabIndex = 2;
            this.Btn_Antrenor.Text = "Antrenörler";
            this.Btn_Antrenor.UseVisualStyleBackColor = true;
            this.Btn_Antrenor.Click += new System.EventHandler(this.Btn_Antrenor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "Müşteri Kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FitnessProje
            // 
            this.ClientSize = new System.Drawing.Size(670, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Antrenor);
            this.Controls.Add(this.MusteriGirisiButton);
            this.Controls.Add(this.YoneticiGirisiButton);
            this.Name = "FitnessProje";
            this.Load += new System.EventHandler(this.FitnessProje_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YoneticiGirisiButton;
        private System.Windows.Forms.Button MusteriGirisiButton;
        private System.Windows.Forms.Button Btn_Antrenor;
        private System.Windows.Forms.Button button1;
    }
}

