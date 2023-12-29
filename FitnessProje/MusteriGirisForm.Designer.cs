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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TcTextBox
            // 
            this.TcTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TcTextBox.Location = new System.Drawing.Point(151, 93);
            this.TcTextBox.Name = "TcTextBox";
            this.TcTextBox.Size = new System.Drawing.Size(131, 22);
            this.TcTextBox.TabIndex = 3;
            // 
            // SifreTextBox
            // 
            this.SifreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreTextBox.Location = new System.Drawing.Point(151, 129);
            this.SifreTextBox.Name = "SifreTextBox";
            this.SifreTextBox.Size = new System.Drawing.Size(131, 22);
            this.SifreTextBox.TabIndex = 1;
            this.SifreTextBox.UseSystemPasswordChar = true;
            // 
            // GirisButon2
            // 
            this.GirisButon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisButon2.Location = new System.Drawing.Point(167, 174);
            this.GirisButon2.Name = "GirisButon2";
            this.GirisButon2.Size = new System.Drawing.Size(95, 36);
            this.GirisButon2.TabIndex = 2;
            this.GirisButon2.Text = "Giriş ";
            this.GirisButon2.UseVisualStyleBackColor = true;
            this.GirisButon2.Click += new System.EventHandler(this.GirisButon2_Click_1);
            // 
            // GeriButon3
            // 
            this.GeriButon3.BackColor = System.Drawing.Color.Cyan;
            this.GeriButon3.Image = ((System.Drawing.Image)(resources.GetObject("GeriButon3.Image")));
            this.GeriButon3.Location = new System.Drawing.Point(12, 10);
            this.GeriButon3.Name = "GeriButon3";
            this.GeriButon3.Size = new System.Drawing.Size(57, 36);
            this.GeriButon3.TabIndex = 9;
            this.GeriButon3.TabStop = false;
            this.GeriButon3.Click += new System.EventHandler(this.GeriButon3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(55, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(55, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(96, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Müşteri Giriş";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.GeriButon3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 50);
            this.panel2.TabIndex = 20;
            // 
            // MusteriGirisForm
            // 
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(363, 274);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GirisButon2);
            this.Controls.Add(this.SifreTextBox);
            this.Controls.Add(this.TcTextBox);
            this.MaximumSize = new System.Drawing.Size(379, 313);
            this.MinimumSize = new System.Drawing.Size(379, 313);
            this.Name = "MusteriGirisForm";
            this.Load += new System.EventHandler(this.MusteriGirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TcTextBox;
        private System.Windows.Forms.TextBox SifreTextBox;
        private System.Windows.Forms.Button GirisButon2;
        private System.Windows.Forms.PictureBox GeriButon3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
    }
}