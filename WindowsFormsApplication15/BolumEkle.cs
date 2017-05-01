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
    public partial class BolumEkle : Form
    {
        public BolumEkle()
        {
            InitializeComponent();
        }
        InsanKaynaklari insankanyaklarıformu = new InsanKaynaklari();
        private void bolumlistele()
        {
            List<EBOLUM> bolumlistesi = BLLBOLUM.SelectList();
            dataGridView1.DataSource = bolumlistesi;
            dataGridView1.Columns.Remove("sirketId");
            

        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            EBOLUM item = new EBOLUM();

            item.ad = textBox1.Text;
            BLLBOLUM.Insert(item);
            bolumlistele();

        }

        private void BolumEkle_Load(object sender, EventArgs e)
        {
            bolumlistele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // this.Hide();
           // insankanyaklarıformu.Show();
        }
    }
}
