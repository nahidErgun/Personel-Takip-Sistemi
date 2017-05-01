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
    public partial class MaasEkle : Form
    {
        public MaasEkle()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            



        }

        private void maasListele()
        {
            List<EMAAS> maaslistesi = BLLMAAS.SelectList();
            dataGridView1.DataSource = maaslistesi;
            
        }
        private void maaseklebuton_Click(object sender, EventArgs e)
        {
            EMAAS item = new EMAAS();
            
            item.miktar = Convert.ToInt32(txtmiktar.Text);
            BLLMAAS.Insert(item);
            maasListele();
           
        }

        private void MaasEkle_Load(object sender, EventArgs e)
        {
            maasListele();
        }
    }
}
