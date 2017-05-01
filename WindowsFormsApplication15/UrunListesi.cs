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
    public partial class UrunListesi : Form
    {
        public UrunListesi()
        {
            InitializeComponent();
        }
        private void urunlistelefiyatagore()
        {
            List<EURUN> urunlistfiyat = BLLURUN.SelectList();
            dataGridView1.DataSource = urunlistfiyat;
            dataGridView1.Columns.Remove("sirketId");
            


        }

        private void urunlisteleadagore()
        {
            List<EURUN> urunlistad = BLLURUN.SelectList1();
            dataGridView1.DataSource = urunlistad;
            dataGridView1.Columns.Remove("sirketId");
            


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            urunlistelefiyatagore();
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            urunlisteleadagore();
        }
        private void UrunListesi_Load(object sender, EventArgs e)
        {
           
        }

    }
}
