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
    public partial class AnaMenuForm : Form
    {
        
        public AnaMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sha256Form ekle = new Sha256Form();
            ekle.MdiParent = this;
            ekle.FormBorderStyle = FormBorderStyle.None;
            ekle.Show();
        }

        private void AnaMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SifreliDosyaForm sifre = new SifreliDosyaForm();
            sifre.MdiParent = this;
            sifre.FormBorderStyle = FormBorderStyle.None;
            sifre.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SifreSoket skt = new SifreSoket();
            skt.MdiParent = this;
            skt.FormBorderStyle = FormBorderStyle.None;
            skt.Show();


        }
    }
}
