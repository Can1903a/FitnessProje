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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AntrenorGirisForm));
            this.antrenorTCTextBox = new System.Windows.Forms.TextBox();
            this.antrenorSifreTextBox = new System.Windows.Forms.TextBox();
            this.GirisButon2 = new System.Windows.Forms.Button();
            this.GeriButon2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // antrenorTCTextBox
            // 
            this.antrenorTCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.antrenorTCTextBox.Location = new System.Drawing.Point(151, 92);
            this.antrenorTCTextBox.Name = "antrenorTCTextBox";
            this.antrenorTCTextBox.Size = new System.Drawing.Size(131, 22);
            this.antrenorTCTextBox.TabIndex = 0;
            this.antrenorTCTextBox.TextChanged += new System.EventHandler(this.antrenorTCTextBox_TextChanged);
            // 
            // antrenorSifreTextBox
            // 
            this.antrenorSifreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.antrenorSifreTextBox.Location = new System.Drawing.Point(151, 129);
            this.antrenorSifreTextBox.Name = "antrenorSifreTextBox";
            this.antrenorSifreTextBox.Size = new System.Drawing.Size(131, 22);
            this.antrenorSifreTextBox.TabIndex = 1;
            // 
            // GirisButon2
            // 
            this.GirisButon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisButon2.Location = new System.Drawing.Point(169, 171);
            this.GirisButon2.Name = "GirisButon2";
            this.GirisButon2.Size = new System.Drawing.Size(95, 36);
            this.GirisButon2.TabIndex = 2;
            this.GirisButon2.Text = "Giriş";
            this.GirisButon2.UseVisualStyleBackColor = true;
            this.GirisButon2.Click += new System.EventHandler(this.GirisButon2_Click);
            // 
            // GeriButon2
            // 
            this.GeriButon2.Image = ((System.Drawing.Image)(resources.GetObject("GeriButon2.Image")));
            this.GeriButon2.Location = new System.Drawing.Point(12, 10);
            this.GeriButon2.Name = "GeriButon2";
            this.GeriButon2.Size = new System.Drawing.Size(57, 36);
            this.GeriButon2.TabIndex = 3;
            this.GeriButon2.TabStop = false;
            this.GeriButon2.Click += new System.EventHandler(this.GeriButon2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.GeriButon2);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 54);
            this.panel2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(96, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Antrenör Giriş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(56, 135);
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
            this.label1.Location = new System.Drawing.Point(56, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "TC Kimlik No";
            // 
            // AntrenorGirisForm
            // 
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(363, 274);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GirisButon2);
            this.Controls.Add(this.antrenorSifreTextBox);
            this.Controls.Add(this.antrenorTCTextBox);
            this.MaximumSize = new System.Drawing.Size(379, 313);
            this.MinimumSize = new System.Drawing.Size(379, 313);
            this.Name = "AntrenorGirisForm";
            this.Load += new System.EventHandler(this.AntrenorGirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox antrenorTCTextBox;
        private System.Windows.Forms.TextBox antrenorSifreTextBox;
        private System.Windows.Forms.Button GirisButon2;
        private System.Windows.Forms.PictureBox GeriButon2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}