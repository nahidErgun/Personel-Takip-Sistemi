namespace PROJE
{
    partial class UrunEkle
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
            this.label2 = new System.Windows.Forms.Label();
            this.urunad = new System.Windows.Forms.TextBox();
            this.urunfiyat = new System.Windows.Forms.TextBox();
            this.dgvurun = new System.Windows.Forms.DataGridView();
            this.urunonayla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvurun)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Fiyatı";
            // 
            // urunad
            // 
            this.urunad.Location = new System.Drawing.Point(73, 125);
            this.urunad.Name = "urunad";
            this.urunad.Size = new System.Drawing.Size(120, 20);
            this.urunad.TabIndex = 3;
            // 
            // urunfiyat
            // 
            this.urunfiyat.Location = new System.Drawing.Point(73, 151);
            this.urunfiyat.Name = "urunfiyat";
            this.urunfiyat.Size = new System.Drawing.Size(120, 20);
            this.urunfiyat.TabIndex = 4;
            this.urunfiyat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dgvurun
            // 
            this.dgvurun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvurun.Location = new System.Drawing.Point(222, 62);
            this.dgvurun.Name = "dgvurun";
            this.dgvurun.Size = new System.Drawing.Size(335, 258);
            this.dgvurun.TabIndex = 6;
            // 
            // urunonayla
            // 
            this.urunonayla.Location = new System.Drawing.Point(91, 189);
            this.urunonayla.Name = "urunonayla";
            this.urunonayla.Size = new System.Drawing.Size(75, 23);
            this.urunonayla.TabIndex = 7;
            this.urunonayla.Text = "Onayla";
            this.urunonayla.UseVisualStyleBackColor = true;
            this.urunonayla.Click += new System.EventHandler(this.button1_Click);
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 372);
            this.Controls.Add(this.urunonayla);
            this.Controls.Add(this.dgvurun);
            this.Controls.Add(this.urunfiyat);
            this.Controls.Add(this.urunad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UrunEkle";
            this.Text = "UrunEkle";
            this.Load += new System.EventHandler(this.UrunEkle_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvurun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urunad;
        private System.Windows.Forms.TextBox urunfiyat;
        private System.Windows.Forms.DataGridView dgvurun;
        private System.Windows.Forms.Button urunonayla;
    }
}