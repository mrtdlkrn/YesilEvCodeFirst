﻿namespace YesilEvCodeFirst.UIWinForm.Raporlar
{
    partial class Rapor04Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRaporuGetir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUrunSayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(134, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Son 1 ayda girilen, ama adminin onaylamadığı ürünlerin sayısı";
            // 
            // buttonRaporuGetir
            // 
            this.buttonRaporuGetir.Location = new System.Drawing.Point(12, 12);
            this.buttonRaporuGetir.Name = "buttonRaporuGetir";
            this.buttonRaporuGetir.Size = new System.Drawing.Size(116, 45);
            this.buttonRaporuGetir.TabIndex = 6;
            this.buttonRaporuGetir.Text = "Raporu Getir";
            this.buttonRaporuGetir.UseVisualStyleBackColor = true;
            this.buttonRaporuGetir.Click += new System.EventHandler(this.buttonRaporuGetir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 387);
            this.dataGridView1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Urun Sayisi:";
            // 
            // labelUrunSayisi
            // 
            this.labelUrunSayisi.AutoSize = true;
            this.labelUrunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUrunSayisi.Location = new System.Drawing.Point(114, 85);
            this.labelUrunSayisi.Name = "labelUrunSayisi";
            this.labelUrunSayisi.Size = new System.Drawing.Size(14, 17);
            this.labelUrunSayisi.TabIndex = 10;
            this.labelUrunSayisi.Text = "-";
            // 
            // Rapor04Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 516);
            this.Controls.Add(this.labelUrunSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRaporuGetir);
            this.Name = "Rapor04Form";
            this.Text = "Rapor4Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRaporuGetir;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUrunSayisi;
    }
}