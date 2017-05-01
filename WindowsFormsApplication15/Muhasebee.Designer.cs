namespace PROJE
{
    partial class Muhasebee
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
            this.maaseklee = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maaseklee
            // 
            this.maaseklee.Location = new System.Drawing.Point(24, 75);
            this.maaseklee.Name = "maaseklee";
            this.maaseklee.Size = new System.Drawing.Size(124, 44);
            this.maaseklee.TabIndex = 0;
            this.maaseklee.Text = "Maaş Ekle";
            this.maaseklee.UseVisualStyleBackColor = true;
            this.maaseklee.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Maaş Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Bütçe Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Personel Listele";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Muhasebee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 409);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maaseklee);
            this.Name = "Muhasebee";
            this.Text = "Muhasebe";
            this.Load += new System.EventHandler(this.Muhasebee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button maaseklee;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
       
    }
}