using MetroFramework.Forms;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace MesajUygulama
{
    public partial class AnaMenuForm : KryptonForm
    {
        
        public AnaMenuForm()
        {
            InitializeComponent();
        }
        private void FormGetir(Form form)
        {
            kryptonPanel3.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            kryptonPanel3.Controls.Add(form);
            form.Show();
        }
        

        private void AnaMenuForm_Load(object sender, EventArgs e)
        {

        }

        

       

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            Sha256Form ekle = new Sha256Form();
            FormGetir(ekle);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            SifreSoket skt = new SifreSoket();
            FormGetir(skt);

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            SifreliDosyaForm sifre = new SifreliDosyaForm();
            FormGetir(sifre);
        }
    }
}
