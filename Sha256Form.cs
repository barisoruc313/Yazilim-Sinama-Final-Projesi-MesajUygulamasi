using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using ComponentFactory.Krypton.Toolkit;


namespace MesajUygulama
{
    public partial class Sha256Form : KryptonForm
    {
        public Sha256Form()
        {
            InitializeComponent();
        }

   

        private void Sha256Form_Load(object sender, EventArgs e)
        {

        }

        private void txtMesaj_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSifrele_Click_1(object sender, EventArgs e)
        {
            SHA256Managed sha256 = new SHA256Managed();

            byte[] sifrelerDizi = Encoding.UTF8.GetBytes(txtMesaj.Text);

            sifrelerDizi = sha256.ComputeHash(sifrelerDizi);

            StringBuilder sb = new StringBuilder();

            foreach (byte b in sifrelerDizi)
            {
                sb.Append(b.ToString("X2"));
            }

            txtSifrelenen.Text = sb.ToString();
        }
    }
}
