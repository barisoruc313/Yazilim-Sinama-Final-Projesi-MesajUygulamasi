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



namespace MesajUygulama
{
    public partial class SifreliDosyaForm : Form
    {
        byte[] abc;
        byte[,] table;
        public SifreliDosyaForm()
        {
            InitializeComponent();
        }

        static public void showMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void SifreliDosyaForm_Load(object sender, EventArgs e)
        {
            rbSifrele.Checked = true;
            abc = new byte[256];
            for (int i = 0; i < 256; i++)
                abc[i] = Convert.ToByte(i);

            table = new byte[256, 256];
            for(int i = 0; i<256; i++)
                for(int j = 0; j<256; j++)
                {
                    table[i, j] = abc[(i + j) % 256];
                }
        }
        OpenFileDialog file = new OpenFileDialog();
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
            file.InitialDirectory = "C:";
            file.Filter = "All Files (*.*)|*.*";
            file.FileName = "";
            if(file.ShowDialog()==DialogResult.Cancel)
            {

            }
            else
            {
                txtInput.Text = file.FileName;
            }

        }
        
        private void btnCompress_Click(object sender, EventArgs e)
        {
            
            string filePath = file.FileName;         // save the path of file from open dialogue box into string variable
            string binPath = filePath;                          // set the path for .bin file
            string codingSchemePath = filePath;

            // Remove the existing extension of input file and change it intp _codingScheme.txt
            int index = codingSchemePath.IndexOf(".");
            if (index > 0)
            {
                codingSchemePath = codingSchemePath.Substring(0, index);
            }
            codingSchemePath = codingSchemePath + "_codingScheme.txt";      // concate the string

            index = binPath.IndexOf(".");
            if (index > 0)
            {
                binPath = binPath.Substring(0, index);
            }
            binPath = binPath + ".bin";         // concate the string with .bin
            txtInput.Text = filePath;
            txtOutput.Text = binPath;            // new path

            // Get the extension of input file
            string extension = Path.GetExtension(filePath);
            if (extension == ".docx")
            {
                // call the function CompressDocxFile for compressing the .docx file using given .bn file
                Program.CompressDocxFile(filePath, binPath, codingSchemePath);

            }
            else if (extension == ".txt")
            {
                // Call the function to compress the text file
                Program.CompressTextFile(filePath, binPath, codingSchemePath);
            }
            else if (extension == ".pdf")
            {
                // Call the function to compress the pdf file
                Program.CompressPdfFile(filePath, binPath, codingSchemePath);
            }
        }

        private void rbSifrele_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSifrele.Checked)
            {
                rbCoz.Checked = false;
            }
        }

        private void rbCoz_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCoz.Checked)
            {
                rbSifrele.Checked = false;
            }

        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            if(!File.Exists(txtInput.Text))
            {
                MessageBox.Show("Dosya Bulunamadı.");
                return;
           
            }
            if(string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Şifre boş tekrar deneyin.");
                return;
            }

            try
            {
                byte[] fileContent = File.ReadAllBytes(txtInput.Text);
                byte[] passwordTmp = Encoding.ASCII.GetBytes(txtSifre.Text);
                byte[] keys = new byte[fileContent.Length];
                for (int i = 0; i < fileContent.Length; i++)
                    keys[i] = passwordTmp[i % passwordTmp.Length];
                //şifreleme
                byte[] result = new byte[fileContent.Length];
                if (rbSifrele.Checked)
                {

                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        result[i] = table[keyIndex, valueIndex];


                    }
                }
                else
                {
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;
                        
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }

                        for (int j = 0; j < 256; j++)
                            if (table[keyIndex,j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        result[i] = abc[valueIndex];
                    }
                }
                string fileExt = Path.GetExtension(txtInput.Text);
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Files(*" + fileExt + ") | *" + fileExt;
                if(sd.ShowDialog()==DialogResult.OK)
                {
                    File.WriteAllBytes(sd.FileName, result);
                }
            }
            catch
            {
                MessageBox.Show("Dosya Kullanımda.");
                return;
            }
        }
    }
}
