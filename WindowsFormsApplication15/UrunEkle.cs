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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void urunListele()
        {
            List<EURUN> urunlistesi = BLLURUN.SelectList2();
            dgvurun.DataSource = urunlistesi;
            dgvurun.Columns.Remove("sirketId");

        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            EURUN item = new EURUN();
            item.ad = urunad.Text;
            item.bedel = Convert.ToDecimal(urunfiyat.Text);
            /*item.sirketId = Convert.ToInt32(sirketıd.Text);*/
            BLLURUN.Insert(item);
            urunListele();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

  

        private void UrunEkle_Load_1(object sender, EventArgs e)
        {
            urunListele();
        }
    }
}
