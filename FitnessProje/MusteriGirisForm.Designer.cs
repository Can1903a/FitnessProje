namespace FitnessProje
{
    partial class MusteriGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriGirisForm));
            this.TcTextBox = new System.Windows.Forms.TextBox();
            this.SifreTextBox = new System.Windows.Forms.TextBox();
            this.GirisButon2 = new System.Windows.Forms.Button();
            this.GeriButon3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon3)).BeginInit();
            this.SuspendLayout();
            // 
            // TcTextBox
            // 
            this.TcTextBox.Location = new System.Drawing.Point(136, 95);
            this.TcTextBox.Name = "TcTextBox";
            this.TcTextBox.Size = new System.Drawing.Size(131, 20);
            this.TcTextBox.TabIndex = 3;
            // 
            // SifreTextBox
            // 
            this.SifreTextBox.Location = new System.Drawing.Point(136, 121);
            this.SifreTextBox.Name = "SifreTextBox";
            this.SifreTextBox.Size = new System.Drawing.Size(131, 20);
            this.SifreTextBox.TabIndex = 1;
            // 
            // GirisButon2
            // 
            this.GirisButon2.Location = new System.Drawing.Point(168, 171);
            this.GirisButon2.Name = "GirisButon2";
            this.GirisButon2.Size = new System.Drawing.Size(75, 23);
            this.GirisButon2.TabIndex = 2;
            this.GirisButon2.Text = "button1";
            this.GirisButon2.UseVisualStyleBackColor = true;
            this.GirisButon2.Click += new System.EventHandler(this.GirisButon2_Click_1);
            // 
            // GeriButon3
            // 
            this.GeriButon3.Image = ((System.Drawing.Image)(resources.GetObject("GeriButon3.Image")));
            this.GeriButon3.Location = new System.Drawing.Point(12, 44);
            this.GeriButon3.Name = "GeriButon3";
            this.GeriButon3.Size = new System.Drawing.Size(57, 36);
            this.GeriButon3.TabIndex = 9;
            this.GeriButon3.TabStop = false;
            this.GeriButon3.Click += new System.EventHandler(this.GeriButon3_Click);
            // 
            // MusteriGirisForm
            // 
            this.ClientSize = new System.Drawing.Size(442, 344);
            this.Controls.Add(this.GeriButon3);
            this.Controls.Add(this.GirisButon2);
            this.Controls.Add(this.SifreTextBox);
            this.Controls.Add(this.TcTextBox);
            this.Name = "MusteriGirisForm";
            this.Load += new System.EventHandler(this.MusteriGirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TcTextBox;
        private System.Windows.Forms.TextBox SifreTextBox;
        private System.Windows.Forms.Button GirisButon2;
        private System.Windows.Forms.PictureBox GeriButon3;
    }
}