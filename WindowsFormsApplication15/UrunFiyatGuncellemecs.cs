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
    public partial class UrunFiyatGuncellemecs : Form
    {
        public UrunFiyatGuncellemecs()
        {
            InitializeComponent();
        }


        private void urunlisteleme()
        {
            List<EURUN> urnlst = BLLURUN.SelectList2();
            dataGridView1.DataSource = urnlst;
            dataGridView1.Columns.Remove("sirketId");

        }
        private void fytgncllebuton_Click(object sender, EventArgs e)
        {
            EURUN item = new EURUN();
            item.urunId = Convert.ToInt32(urunıdtxt.Text);
            item.bedel = Convert.ToDecimal(urunmiktartxt.Text);
            BLLURUN.Update(item);
            urunlisteleme();
        }

        private void UrunFiyatGuncellemecs_Load(object sender, EventArgs e)
        {
            urunlisteleme();
        }
    }
}
