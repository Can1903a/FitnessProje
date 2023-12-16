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
            this.SuspendLayout();
            // 
            // YoneticiGirisiButton
            // 
            this.YoneticiGirisiButton.Location = new System.Drawing.Point(32, 97);
            this.YoneticiGirisiButton.Name = "YoneticiGirisiButton";
            this.YoneticiGirisiButton.Size = new System.Drawing.Size(113, 73);
            this.YoneticiGirisiButton.TabIndex = 0;
            this.YoneticiGirisiButton.Text = "Yönetici";
            this.YoneticiGirisiButton.UseVisualStyleBackColor = true;
            this.YoneticiGirisiButton.Click += new System.EventHandler(this.YoneticiGirisiButton_Click_1);
            // 
            // MusteriGirisiButton
            // 
            this.MusteriGirisiButton.Location = new System.Drawing.Point(166, 97);
            this.MusteriGirisiButton.Name = "MusteriGirisiButton";
            this.MusteriGirisiButton.Size = new System.Drawing.Size(113, 73);
            this.MusteriGirisiButton.TabIndex = 1;
            this.MusteriGirisiButton.Text = "Müşteri";
            this.MusteriGirisiButton.UseVisualStyleBackColor = true;
            this.MusteriGirisiButton.Click += new System.EventHandler(this.MusteriGirisiButton_Click_1);
            // 
            // FitnessProje
            // 
            this.ClientSize = new System.Drawing.Size(326, 242);
            this.Controls.Add(this.MusteriGirisiButton);
            this.Controls.Add(this.YoneticiGirisiButton);
            this.Name = "FitnessProje";
            this.Load += new System.EventHandler(this.FitnessProje_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YoneticiGirisiButton;
        private System.Windows.Forms.Button MusteriGirisiButton;
    }
}

