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
    public partial class PersonelListele : Form
    {
        public PersonelListele()
        {
            InitializeComponent();
        }
       
        private void maaseklebuton_Click(object sender, EventArgs e)
        {
            

        }
        private void personellistelead()
        {
            List<EPERSONEL> personellistelead = BLLPERSONEL.SelectList();
            dataGridView1.DataSource = personellistelead;
            dataGridView1.Columns.Remove("personelId");
            dataGridView1.Columns.Remove("maasId");
            dataGridView1.Columns.Remove("bolumId");
            dataGridView1.Columns.Remove("tel");
            

        }
        private void personellistelebolumegore()
        {
            List<EPERSONEL> personellistesibolum = BLLPERSONEL.SelectList1();
            dataGridView1.DataSource = personellistesibolum;
            dataGridView1.Columns.Remove("personelId");
            dataGridView1.Columns.Remove("maasId");
            dataGridView1.Columns.Remove("bolumId");
            dataGridView1.Columns.Remove("tel");
            


        }

        private void PersonelListele_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            personellistelead();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            personellistelebolumegore();
        }
    }
}
