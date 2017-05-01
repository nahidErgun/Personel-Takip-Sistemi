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
    public partial class DeletePersonel : Form
    {
        public DeletePersonel()
        {
            InitializeComponent();
        }
        private void listpersonel()
        {
            List<EPERSONEL> personellistesi = BLLPERSONEL.SelectList();
            dataGridView1.DataSource = personellistesi;
            dataGridView1.Columns.Remove("bolumId");





        }
        public void sil()
        {
            BLLPERSONEL.Delete(Convert.ToInt32(textBox1.Text));
            listpersonel();
        }


        private void Onay_Click(object sender, EventArgs e)
        {
            sil();

        }

        private void DeletePersonel_Load(object sender, EventArgs e)
        {
            listpersonel();
        }
    }
}
