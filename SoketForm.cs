using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;

namespace MesajUygulama
{
    public partial class SoketForm : Form
    {
        [Obsolete]
        public SoketForm()
        {
            InitializeComponent();
            TcpListener serverSocket = new TcpListener(8888);
            serverSocket.Start();
        }
       

        TcpClient clientSocket = new TcpClient();
        private void SoketForm_Load(object sender, EventArgs e)
        {
            msg("Client Started");

            clientSocket.Connect("127.0.0.1", 8888);

            label4.Text = "Client Socket Program - Server Connected ...";
        }
        public string EncryptDecrypt(string szPlainText, int szEncryptionKey)
        {
            StringBuilder szInputStringBuild = new StringBuilder(szPlainText);
            StringBuilder szOutStringBuild = new StringBuilder(szPlainText.Length);
            char Textch;
            for (int iCount = 0; iCount < szPlainText.Length; iCount++)
            {
                Textch = szInputStringBuild[iCount];
                Textch = (char)(Textch ^ szEncryptionKey);
                szOutStringBuild.Append(Textch);
            }
            return szOutStringBuild.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            textBox2.Text = EncryptDecrypt(textBox1.Text, 200);
            textBox1.Clear();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = EncryptDecrypt(textBox2.Text, 200);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NetworkStream serverStream = clientSocket.GetStream();

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox1.Text + "$");

            serverStream.Write(outStream, 0, outStream.Length);

            serverStream.Flush();

            byte[] inStream = new byte[10025];

            serverStream.Read(inStream, 0, clientSocket.ReceiveBufferSize);

            string returndata = System.Text.Encoding.ASCII.GetString(inStream);

            msg(returndata);

            textBox3.Text = "";

            textBox3.Focus();
        }
        public void msg(string mesg)

        {

            label5.Text = " >> " + mesg;

        }
    }
}
