namespace FitnessProje
{
    partial class MusteriIslem
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.KatilimYapButton = new System.Windows.Forms.Button();
            this.musteriAntrenman = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.musteriAntrenman)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "Beslenme Takip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 139);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 66);
            this.button2.TabIndex = 4;
            this.button2.Text = "Beslenme Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KatilimYapButton
            // 
            this.KatilimYapButton.Location = new System.Drawing.Point(573, 278);
            this.KatilimYapButton.Name = "KatilimYapButton";
            this.KatilimYapButton.Size = new System.Drawing.Size(143, 72);
            this.KatilimYapButton.TabIndex = 6;
            this.KatilimYapButton.Text = "Antrenmana Katıl";
            this.KatilimYapButton.UseVisualStyleBackColor = true;
            this.KatilimYapButton.Click += new System.EventHandler(this.KatilimYapButton_Click_1);
            // 
            // musteriAntrenman
            // 
            this.musteriAntrenman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriAntrenman.Location = new System.Drawing.Point(381, 53);
            this.musteriAntrenman.Name = "musteriAntrenman";
            this.musteriAntrenman.RowHeadersWidth = 51;
            this.musteriAntrenman.RowTemplate.Height = 24;
            this.musteriAntrenman.Size = new System.Drawing.Size(483, 219);
            this.musteriAntrenman.TabIndex = 7;
            // 
            // MusteriIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 554);
            this.Controls.Add(this.musteriAntrenman);
            this.Controls.Add(this.KatilimYapButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusteriIslem";
            this.Text = "MusteriIslem";
            this.Load += new System.EventHandler(this.MusteriIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriAntrenman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button KatilimYapButton;
        private System.Windows.Forms.DataGridView musteriAntrenman;
    }
}