using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesajUygulama
{
    public partial class SifreSoket : Form
    {
        public SifreSoket()
        {
            InitializeComponent();
        }

        private void SifreSoket_Load(object sender, EventArgs e)
        {

        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            string uc = textBox2.Text;
            if (uc.Length == 8)
            {
                Class1 a = new Class1();
                textBox3.Text = a.encrypt(textBox1.Text, textBox2.Text);


            }
            else
            {
                MessageBox.Show("8 HANELİ ŞİFRE GİRİNİZ");

            }
        }

        private void btnCoz_Click(object sender, EventArgs e)
        {
            Class3 b = new Class3();
            textBox4.Text = b.decrypt(textBox3.Text, textBox2.Text, textBox1.Text);
        }
    }
}
