using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Data.SqlClient;
using ComponentFactory.Krypton.Toolkit;

namespace MesajUygulama
{
    public partial class SifreSoket : KryptonForm
    {
        [Obsolete]
        public SifreSoket()
        {
            InitializeComponent();
            TcpListener serverSocket = new TcpListener(8888);
            serverSocket.Start();
        }
        TcpClient clientSocket = new TcpClient();
        SqlConnection baglanti = new SqlConnection("Data Source=pcBaro;Initial Catalog=sifrekontrol;Integrated Security=True");


        private void SifreSoket_Load(object sender, EventArgs e)
        {
            msg("Client Started");

            clientSocket.Connect("127.0.0.1", 8888);

            label6.Text = "Client Socket Program - Server Connected ...";


        }


        private void btnSifrele_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sifretable (sifre1) Values ('" + textBox2.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            


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

            textBox1.Clear();
            textBox2.Clear();

        }

        private void btnCoz_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            string query = "Select *from sifretable where sifre1 = '" + textBox5.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Class3 b = new Class3();
                textBox4.Text = b.decrypt(textBox3.Text, textBox5.Text, textBox1.Text);
            }
            else
            {
                MessageBox.Show("Hatalı şifre girdiniz!");
            }
            baglanti.Close();
            
        }

        public void msg(string mesg)

        {

            label8.Text = " >> " + mesg;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sifretable (sifre2) Values ('" + textBox5.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            

            string uc = textBox5.Text;
            if (uc.Length == 8)
            {
                Class1 a = new Class1();
                textBox3.Text = a.encrypt(textBox4.Text, textBox5.Text);


            }
            else
            {
                MessageBox.Show("8 HANELİ ŞİFRE GİRİNİZ");

            }
            
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            string query = "Select *from sifretable where sifre2 = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Class3 b = new Class3();
                textBox1.Text = b.decrypt(textBox3.Text, textBox2.Text, textBox4.Text);
            }
            else
            {
                MessageBox.Show("Hatalı şifre girdiniz!");
            }
            baglanti.Close();
            


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

      
    }
}
