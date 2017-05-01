namespace PROJE
{
    partial class MaasEkle
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
            this.maasmiktarı = new System.Windows.Forms.Label();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.maaseklebuton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // maasmiktarı
            // 
            this.maasmiktarı.AutoSize = true;
            this.maasmiktarı.Location = new System.Drawing.Point(53, 151);
            this.maasmiktarı.Name = "maasmiktarı";
            this.maasmiktarı.Size = new System.Drawing.Size(36, 13);
            this.maasmiktarı.TabIndex = 0;
            this.maasmiktarı.Text = "Miktar";
            // 
            // txtmiktar
            // 
            this.txtmiktar.Location = new System.Drawing.Point(95, 148);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(100, 20);
            this.txtmiktar.TabIndex = 1;
            // 
            // maaseklebuton
            // 
            this.maaseklebuton.Location = new System.Drawing.Point(95, 203);
            this.maaseklebuton.Name = "maaseklebuton";
            this.maaseklebuton.Size = new System.Drawing.Size(75, 23);
            this.maaseklebuton.TabIndex = 2;
            this.maaseklebuton.Text = "Onayla";
            this.maaseklebuton.UseVisualStyleBackColor = true;
            this.maaseklebuton.Click += new System.EventHandler(this.maaseklebuton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(211, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 273);
            this.dataGridView1.TabIndex = 3;
            // 
            // MaasEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 375);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maaseklebuton);
            this.Controls.Add(this.txtmiktar);
            this.Controls.Add(this.maasmiktarı);
            this.Name = "MaasEkle";
            this.Text = "MaasEkle";
            this.Load += new System.EventHandler(this.MaasEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label maasmiktarı;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.Button maaseklebuton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}