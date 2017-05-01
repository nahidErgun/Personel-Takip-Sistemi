using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntityLayer;
using BusinessLogicLayers;

namespace PROJE
{
    public partial class UrunSil : Form
    {
        public UrunSil()
        {
            InitializeComponent();
        }

        private void urunListele1()
        {
            List<EURUN> urunlistesii = BLLURUN.SelectList2();
            dgvurunn.DataSource = urunlistesii;

        }
        public void sil()
        {
            BLLURUN.Delete(Convert.ToInt32(urunsiltxt.Text));
            urunListele1();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void UrunSil_Load(object sender, EventArgs e)
        {
            urunListele1();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sil();
            
        }
        private void UrunSil_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
