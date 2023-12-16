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
            this.TcTextBox = new System.Windows.Forms.TextBox();
            this.SifreTextBox = new System.Windows.Forms.TextBox();
            this.GirisButon2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TcTextBox
            // 
            this.TcTextBox.Location = new System.Drawing.Point(136, 76);
            this.TcTextBox.Name = "TcTextBox";
            this.TcTextBox.Size = new System.Drawing.Size(131, 20);
            this.TcTextBox.TabIndex = 0;
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
            // MusteriGirisForm
            // 
            this.ClientSize = new System.Drawing.Size(442, 344);
            this.Controls.Add(this.GirisButon2);
            this.Controls.Add(this.SifreTextBox);
            this.Controls.Add(this.TcTextBox);
            this.Name = "MusteriGirisForm";
            this.Load += new System.EventHandler(this.MusteriGirisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TcTextBox;
        private System.Windows.Forms.TextBox SifreTextBox;
        private System.Windows.Forms.Button GirisButon2;
    }
}