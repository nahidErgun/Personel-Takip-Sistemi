using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;

namespace PROJE
{
    public partial class Muhasebee : Form
    {
        public Muhasebee()
        {
            InitializeComponent();
        }
        MaasEkle maasekleform = new MaasEkle();
        PersonelListele personellisteleform = new PersonelListele();
        MaasGuncelle maasguncelleform = new MaasGuncelle();
        ButceGuncelle butceguncelleform = new ButceGuncelle();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            maasguncelleform.Show();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            personellisteleform.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Muhasebee_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            maasekleform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            butceguncelleform.Show();
        }
    }
}
