namespace PROJE
{
    partial class DeletePersonel
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Onay = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silmek İstediğiniz Personelin ID\'si";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Onay
            // 
            this.Onay.Location = new System.Drawing.Point(255, 63);
            this.Onay.Name = "Onay";
            this.Onay.Size = new System.Drawing.Size(57, 24);
            this.Onay.TabIndex = 2;
            this.Onay.Text = "Onay";
            this.Onay.UseVisualStyleBackColor = true;
            this.Onay.Click += new System.EventHandler(this.Onay_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(146, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 176);
            this.dataGridView1.TabIndex = 3;
            // 
            // DeletePersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 312);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Onay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "DeletePersonel";
            this.Text = "DeletePersonel";
            this.Load += new System.EventHandler(this.DeletePersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Onay;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}