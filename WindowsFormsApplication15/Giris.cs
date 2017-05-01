using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLogicLayers;

namespace PROJE
{
    public partial class Giris : Form
    {

        
        public Giris()
        {
            InitializeComponent();
        }

        Uretim uretimformu = new Uretim();
        InsanKaynaklari insankaynaklariformu = new InsanKaynaklari();
        Muhasebee muhasebeformu = new Muhasebee();
         

        private void Form1_Load(object sender, EventArgs e)
        {
           
            bolumlerial();
            
            

        }
        private void bolumlerial()
        {
            List<EBOLUM> bolumlistesi = BLLBOLUM.SelectList();
            comboBox1.DataSource = bolumlistesi;
            comboBox1.DisplayMember = "ad";
            comboBox1.ValueMember = "bolumId";
            

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = false;
            result = BLLLOGIN.Login(Convert.ToInt32(textBox1.Text),Convert.ToInt32(comboBox1.SelectedValue));

            if (result == false)
            {
                textBox1.BackColor = Color.Red;
                comboBox1.BackColor = Color.Red;
            }
            if (result == true)
            {
                textBox1.BackColor = Color.Green;
                comboBox1.BackColor = Color.Green;
                if (comboBox1.Text == "İnsan kaynakları")
                {
                    this.Hide();
                    insankaynaklariformu.Show();
                }
                else if (comboBox1.Text == "Muhasebe")
                {
                    this.Hide();
                    muhasebeformu.Show();
                }
                else if (comboBox1.Text == "Üretim")
                {
                    this.Hide();
                    uretimformu.Show();
                }
            }

           




            /* private void ButtonGiris_Click(object sender, EventArgs e)
         {
             bool result = false;
             result = BLLLOGIN.Login(TextBox1.Text,  Convert.ToInt32(ComboBox1.SelectedValue));

             if (result == false)
             {
                 formWorks.FailedColoring(TextNo);
                 formWorks.FailedColoring(TextParola);
                 formWorks.FailedColoring(ComboBoxSirket);
             }
             if (result == true)
             {
                 MainFrame main = new MainFrame();
                 Hide();
                 main.ShowDialog();
                 formWorks.ClearScreen(this);
             }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                     

        }

        private void Giris_Load(object sender, EventArgs e)
        {
            bolumlerial();
        }
    }
}
