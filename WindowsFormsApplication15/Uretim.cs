using System;
using System.Windows.Forms;

namespace PROJE
{
    public partial class Uretim : Form
    {
        public Uretim()
        {
            InitializeComponent();
        }
        UrunEkle urunekleform = new UrunEkle();
        UrunSil urunsilform = new UrunSil();
        UrunListesi urunlistform = new UrunListesi();
        UrunFiyatGuncellemecs fiyatguncekke = new UrunFiyatGuncellemecs();

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            urunlistform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            urunekleform.Show();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            urunsilform.Show();

        }

        private void Uretim_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            fiyatguncekke.Show();
        }
    }
}
