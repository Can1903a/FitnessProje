namespace FitnessProje
{
    partial class OdemeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdemeForm));
            this.dataGridViewOdemeBilgileri = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GeriButon11 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownOdemeMiktari = new System.Windows.Forms.NumericUpDown();
            this.comboBoxOdemeTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdemeBilgileri)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOdemeMiktari)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOdemeBilgileri
            // 
            this.dataGridViewOdemeBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdemeBilgileri.Location = new System.Drawing.Point(-2, 82);
            this.dataGridViewOdemeBilgileri.Name = "dataGridViewOdemeBilgileri";
            this.dataGridViewOdemeBilgileri.Size = new System.Drawing.Size(677, 185);
            this.dataGridViewOdemeBilgileri.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Controls.Add(this.GeriButon11);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(-2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 76);
            this.panel3.TabIndex = 22;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // GeriButon11
            // 
            this.GeriButon11.BackColor = System.Drawing.Color.Cyan;
            this.GeriButon11.Image = ((System.Drawing.Image)(resources.GetObject("GeriButon11.Image")));
            this.GeriButon11.Location = new System.Drawing.Point(14, 12);
            this.GeriButon11.Name = "GeriButon11";
            this.GeriButon11.Size = new System.Drawing.Size(57, 36);
            this.GeriButon11.TabIndex = 9;
            this.GeriButon11.TabStop = false;
            this.GeriButon11.Click += new System.EventHandler(this.GeriButon11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Cyan;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(231, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ödeme Paneli";
            // 
            // numericUpDownOdemeMiktari
            // 
            this.numericUpDownOdemeMiktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownOdemeMiktari.Location = new System.Drawing.Point(183, 314);
            this.numericUpDownOdemeMiktari.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownOdemeMiktari.Name = "numericUpDownOdemeMiktari";
            this.numericUpDownOdemeMiktari.Size = new System.Drawing.Size(129, 22);
            this.numericUpDownOdemeMiktari.TabIndex = 15;
            // 
            // comboBoxOdemeTuru
            // 
            this.comboBoxOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxOdemeTuru.FormattingEnabled = true;
            this.comboBoxOdemeTuru.Items.AddRange(new object[] {
            "Kredi Kartı",
            "Nakit"});
            this.comboBoxOdemeTuru.Location = new System.Drawing.Point(183, 359);
            this.comboBoxOdemeTuru.Name = "comboBoxOdemeTuru";
            this.comboBoxOdemeTuru.Size = new System.Drawing.Size(129, 24);
            this.comboBoxOdemeTuru.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(36, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ödeme Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(36, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Miktar";
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Location = new System.Drawing.Point(393, 328);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(127, 45);
            this.btnOdemeYap.TabIndex = 25;
            this.btnOdemeYap.Text = "Ödeme Yap";
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click_1);
            // 
            // OdemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(664, 491);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOdemeTuru);
            this.Controls.Add(this.numericUpDownOdemeMiktari);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewOdemeBilgileri);
            this.MaximumSize = new System.Drawing.Size(680, 530);
            this.MinimumSize = new System.Drawing.Size(680, 530);
            this.Name = "OdemeForm";
            this.Text = "OdemeForm";
            this.Load += new System.EventHandler(this.OdemeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdemeBilgileri)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOdemeMiktari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOdemeBilgileri;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox GeriButon11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownOdemeMiktari;
        private System.Windows.Forms.ComboBox comboBoxOdemeTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOdemeYap;
    }
}