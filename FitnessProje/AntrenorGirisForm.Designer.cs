namespace FitnessProje
{
    partial class AntrenorGirisForm
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
            this.antrenorSifreTextBox = new System.Windows.Forms.TextBox();
            this.antrenorTCTextBox = new System.Windows.Forms.TextBox();
            this.GirisButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // antrenorSifreTextBox
            // 
            this.antrenorSifreTextBox.Location = new System.Drawing.Point(224, 110);
            this.antrenorSifreTextBox.Name = "antrenorSifreTextBox";
            this.antrenorSifreTextBox.Size = new System.Drawing.Size(135, 20);
            this.antrenorSifreTextBox.TabIndex = 0;
            // 
            // antrenorTCTextBox
            // 
            this.antrenorTCTextBox.Location = new System.Drawing.Point(224, 72);
            this.antrenorTCTextBox.Name = "antrenorTCTextBox";
            this.antrenorTCTextBox.Size = new System.Drawing.Size(135, 20);
            this.antrenorTCTextBox.TabIndex = 1;
            // 
            // GirisButon
            // 
            this.GirisButon.Location = new System.Drawing.Point(248, 146);
            this.GirisButon.Name = "GirisButon";
            this.GirisButon.Size = new System.Drawing.Size(88, 41);
            this.GirisButon.TabIndex = 0;
            this.GirisButon.Text = "Giriş Yap";
            this.GirisButon.Click += new System.EventHandler(this.GirisButon_Click_1);
            // 
            // AntrenorGirisForm
            // 
            this.ClientSize = new System.Drawing.Size(652, 338);
            this.Controls.Add(this.GirisButon);
            this.Controls.Add(this.antrenorTCTextBox);
            this.Controls.Add(this.antrenorSifreTextBox);
            this.Name = "AntrenorGirisForm";
            this.Load += new System.EventHandler(this.AntrenorGirisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox antrenorSifreTextBox;
        private System.Windows.Forms.TextBox antrenorTCTextBox;
        private System.Windows.Forms.Button GirisButon;
    }
}