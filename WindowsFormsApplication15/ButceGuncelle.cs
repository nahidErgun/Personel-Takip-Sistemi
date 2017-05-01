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
    public partial class ButceGuncelle : Form
    {
        public ButceGuncelle()
        {
            InitializeComponent();
        }
        private void ButceGuncelle_Load(object sender, EventArgs e)
        {
            butcelistele();
        }

        private void butcelistele()
        {
            List<EBUTCE> butcelistesi =  BLLBUTCE.SelectList();
            dataGridView1.DataSource = butcelistesi;
            dataGridView1.Columns.Remove("butceId");
            dataGridView1.Columns.Remove("sirketId");
            dataGridView1.Columns.Remove("vergiNo");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EBUTCE item = new EBUTCE();
            item.gelir = Convert.ToDecimal(gelirttxtb.Text);
            item.gider = Convert.ToDecimal(giderxtx.Text);
            BLLBUTCE.Update(item);
            butcelistele();
           
        }

        private void ButceGuncelle_Load_1(object sender, EventArgs e)
        {
            butcelistele();
        }
    }
}
