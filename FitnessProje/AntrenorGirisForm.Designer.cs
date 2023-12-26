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
            this.antrenorTCTextBox = new System.Windows.Forms.TextBox();
            this.antrenorSifreTextBox = new System.Windows.Forms.TextBox();
            this.GirisButon2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // antrenorTCTextBox
            // 
            this.antrenorTCTextBox.Location = new System.Drawing.Point(242, 71);
            this.antrenorTCTextBox.Name = "antrenorTCTextBox";
            this.antrenorTCTextBox.Size = new System.Drawing.Size(100, 22);
            this.antrenorTCTextBox.TabIndex = 0;
            this.antrenorTCTextBox.TextChanged += new System.EventHandler(this.antrenorTCTextBox_TextChanged);
            // 
            // antrenorSifreTextBox
            // 
            this.antrenorSifreTextBox.Location = new System.Drawing.Point(242, 120);
            this.antrenorSifreTextBox.Name = "antrenorSifreTextBox";
            this.antrenorSifreTextBox.Size = new System.Drawing.Size(100, 22);
            this.antrenorSifreTextBox.TabIndex = 1;
            // 
            // GirisButon2
            // 
            this.GirisButon2.Location = new System.Drawing.Point(253, 188);
            this.GirisButon2.Name = "GirisButon2";
            this.GirisButon2.Size = new System.Drawing.Size(75, 23);
            this.GirisButon2.TabIndex = 2;
            this.GirisButon2.Text = "GirisButon2";
            this.GirisButon2.UseVisualStyleBackColor = true;
            this.GirisButon2.Click += new System.EventHandler(this.GirisButon2_Click);
            // 
            // AntrenorGirisForm
            // 
            this.ClientSize = new System.Drawing.Size(561, 361);
            this.Controls.Add(this.GirisButon2);
            this.Controls.Add(this.antrenorSifreTextBox);
            this.Controls.Add(this.antrenorTCTextBox);
            this.Name = "AntrenorGirisForm";
            this.Load += new System.EventHandler(this.AntrenorGirisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox antrenorTCTextBox;
        private System.Windows.Forms.TextBox antrenorSifreTextBox;
        private System.Windows.Forms.Button GirisButon2;
    }
}