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


namespace MesajUygulama
{
    public partial class Sha256Form : Form
    {
        public Sha256Form()
        {
            InitializeComponent();
        }

        private void btnSifrele_Click(object sender, EventArgs e)
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

        private void Sha256Form_Load(object sender, EventArgs e)
        {

        }
    }
}
