namespace PROJE
{
    partial class UrunSil
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
            this.urunsiltxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvurunn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvurunn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silinecek Ürünün ID\'si";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // urunsiltxt
            // 
            this.urunsiltxt.Location = new System.Drawing.Point(129, 71);
            this.urunsiltxt.Name = "urunsiltxt";
            this.urunsiltxt.Size = new System.Drawing.Size(30, 20);
            this.urunsiltxt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgvurunn
            // 
            this.dgvurunn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvurunn.Location = new System.Drawing.Point(176, 60);
            this.dgvurunn.Name = "dgvurunn";
            this.dgvurunn.Size = new System.Drawing.Size(295, 222);
            this.dgvurunn.TabIndex = 3;
            // 
            // UrunSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 323);
            this.Controls.Add(this.dgvurunn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.urunsiltxt);
            this.Controls.Add(this.label1);
            this.Name = "UrunSil";
            this.Text = "UrunSil";
            this.Load += new System.EventHandler(this.UrunSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvurunn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urunsiltxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvurunn;
    }
}