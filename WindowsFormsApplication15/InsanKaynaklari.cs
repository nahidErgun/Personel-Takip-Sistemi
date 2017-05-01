using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PROJE
{
    public partial class InsanKaynaklari : Form
    {
        public InsanKaynaklari()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            personelekleme personelekleform = new personelekleme();
             personelekleform.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            BolumEkle bolumekleform = new BolumEkle();
            bolumekleform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeletePersonel deletepersonelform = new DeletePersonel();
            deletepersonelform.Show();
        }
    }
}
