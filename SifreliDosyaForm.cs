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
    }
}
