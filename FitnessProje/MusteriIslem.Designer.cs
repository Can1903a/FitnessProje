﻿namespace FitnessProje
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
            this.dataGridViewAntrenmanlar = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAntrenmanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAntrenmanlar
            // 
            this.dataGridViewAntrenmanlar.Location = new System.Drawing.Point(234, 43);
            this.dataGridViewAntrenmanlar.Name = "dataGridViewAntrenmanlar";
            this.dataGridViewAntrenmanlar.Size = new System.Drawing.Size(387, 221);
            this.dataGridViewAntrenmanlar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Beslenme Takip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "Beslenme Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MusteriIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewAntrenmanlar);
            this.Name = "MusteriIslem";
            this.Text = "MusteriIslem";
            this.Load += new System.EventHandler(this.MusteriIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAntrenmanlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAntrenmanlar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}