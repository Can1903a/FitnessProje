namespace Fitness
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon8)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // KullaniciAdiTextBox
            // 
            this.KullaniciAdiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciAdiTextBox.Location = new System.Drawing.Point(153, 92);
            this.KullaniciAdiTextBox.Name = "KullaniciAdiTextBox";
            this.KullaniciAdiTextBox.Size = new System.Drawing.Size(125, 22);
            this.KullaniciAdiTextBox.TabIndex = 0;
            // 
            // SifreTextBox
            // 
            this.SifreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreTextBox.Location = new System.Drawing.Point(153, 134);
            this.SifreTextBox.Name = "SifreTextBox";
            this.SifreTextBox.Size = new System.Drawing.Size(125, 22);
            this.SifreTextBox.TabIndex = 1;
            // 
            // GirisButon
            // 
            this.GirisButon.Location = new System.Drawing.Point(173, 173);
            this.GirisButon.Name = "GirisButon";
            this.GirisButon.Size = new System.Drawing.Size(87, 40);
            this.GirisButon.TabIndex = 2;
            this.GirisButon.Text = "Giriş";
            this.GirisButon.UseVisualStyleBackColor = true;
            this.GirisButon.Click += new System.EventHandler(this.GirisButon_Click);
            // 
            // GeriButon8
            // 
            this.GeriButon8.Image = ((System.Drawing.Image)(resources.GetObject("GeriButon8.Image")));
            this.GeriButon8.Location = new System.Drawing.Point(17, 16);
            this.GeriButon8.Name = "GeriButon8";
            this.GeriButon8.Size = new System.Drawing.Size(57, 36);
            this.GeriButon8.TabIndex = 9;
            this.GeriButon8.TabStop = false;
            this.GeriButon8.Click += new System.EventHandler(this.GeriButon8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(95, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Yönetici Giriş";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.GeriButon8);
            this.panel2.Location = new System.Drawing.Point(-5, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 57);
            this.panel2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(53, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(53, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "TC Kimlik No";
            // 
            // YoneticiGirisForm
            // 
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(363, 274);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GirisButon);
            this.Controls.Add(this.SifreTextBox);
            this.Controls.Add(this.KullaniciAdiTextBox);
            this.MaximumSize = new System.Drawing.Size(379, 313);
            this.MinimumSize = new System.Drawing.Size(379, 313);
            this.Name = "YoneticiGirisForm";
            this.Load += new System.EventHandler(this.YoneticiGirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon8)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KullaniciAdiTextBox;
        private System.Windows.Forms.TextBox SifreTextBox;
        private System.Windows.Forms.Button GirisButon;
        private System.Windows.Forms.PictureBox GeriButon8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}