using BusinessLogicLayers;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE
{
    public partial class personelekleme : Form
    {
        public personelekleme()
        {
            InitializeComponent();
        }
        public void PersonelListele()
        {
            List<EPERSONEL> personellistesi = BLLPERSONEL.SelectList();
            dataGridView1.DataSource = personellistesi;
            dataGridView1.Columns.Remove("bolumId");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EPERSONEL item = new EPERSONEL();
            item.ad = adtxt.Text;
            item.soyad = soyadtxt.Text;
            item.tel = teltxt.Text;
            item.bolumId = Convert.ToInt32(bolumtxt.Text);
            item.maasId = Convert.ToInt32(maastxt.Text);
            BLLPERSONEL.Insert(item);
            PersonelListele();

        }

        private void personelekleme_Load(object sender, EventArgs e)
        {
            PersonelListele();
        }
    }
}
