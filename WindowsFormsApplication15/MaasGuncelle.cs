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
    public partial class MaasGuncelle : Form
    {
        public MaasGuncelle()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void maasListele()
        {
            List<EMAAS> maaslistesi = BLLMAAS.SelectList();
            dataGridView1.DataSource = maaslistesi;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EMAAS item = new EMAAS();
            item.maasId = Convert.ToInt32(maasıdtxt.Text);
            item.miktar = Convert.ToDecimal(miktartxt.Text);
            BLLMAAS.Update(item);
            maasListele();
        }

        private void MaasGuncelle_Load(object sender, EventArgs e)
        {
            maasListele();
        }
    }
}
