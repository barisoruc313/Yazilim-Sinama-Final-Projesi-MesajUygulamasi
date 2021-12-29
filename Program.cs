using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Microsoft.Office.Interop.Word;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using GemBox.Document;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MesajUygulama;

namespace MesajUygulama
{
    class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new AnaMenuForm());
        }

        static public HuffmanTree huffmanTree = new HuffmanTree();          // huffman tree class object
        static string message = "";

        [STAThread]

    

        static public void CompressTextFile(string filePath, string binFilePath, string codingSchemePath)
        {
            //Read the text file in string variable
            string inputFile = File.ReadAllText(filePath);

            // Build the Huffman tree
            huffmanTree.Build_Tree(inputFile);

            // Encode the input file in BitArray in binary form
            BitArray bit_array = huffmanTree.Encode(inputFile);

            // Byte array for storing the bits from BitArray to save in bin file
            byte[] bytes = new byte[bit_array.Length / 8 + (bit_array.Length % 8 == 0 ? 0 : 1)];
            bit_array.CopyTo(bytes, 0);

            // write all the bits from byte array in bin file
            File.WriteAllBytes(binFilePath, bytes);
            message = "Dosya Başarıyla Şifrelendi";
            SifreliDosyaForm.showMessage(message);

            var stringBuilder = new StringBuilder();

            for (int i = 0; i < bit_array.Count; i++)
            {
                char bitChar = bit_array[i] ? '1' : '0';
                stringBuilder.Append(bitChar);
            }
            var stringBuilder2 = stringBuilder.ToString();
            File.WriteAllText(codingSchemePath, stringBuilder2);
            message = "Kod Şifre Şema Dosyası Oluşturuldu";
            SifreliDosyaForm.showMessage(message);

        }
        static public void CompressPdfFile(string filePath, string binFilePath, string codingSchemePath)
        {

            string pdfString = GetTextFromPdfFile(filePath);

            // Build the Huffman tree
            huffmanTree.Build_Tree(pdfString);

            // Encode the input file in BitArray in binary form
            BitArray bit_array = huffmanTree.Encode(pdfString);

            // Byte array for storing the bits from BitArray to save in bin file
            byte[] bytes = new byte[bit_array.Length / 8 + (bit_array.Length % 8 == 0 ? 0 : 1)];
            bit_array.CopyTo(bytes, 0);

            // write all the bits from byte array in bin file
            File.WriteAllBytes(binFilePath, bytes);

            message = "Pdf File Encoded Successfully";
            SifreliDosyaForm.showMessage(message);

            var stringBuilder = new StringBuilder();

            for (int i = 0; i < bit_array.Count; i++)
            {
                char bitChar = bit_array[i] ? '1' : '0';
                stringBuilder.Append(bitChar);
            }
            var stringBuilder2 = stringBuilder.ToString();
            File.WriteAllText(codingSchemePath, stringBuilder2);
            message = "Coding Scheme File Created Successfully";
            SifreliDosyaForm.showMessage(message);

        }

        static public string GetTextFromPdfFile(string filePath)
        {
            StringBuilder text = new StringBuilder();
            using (PdfReader reader = new PdfReader(filePath))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }

            return text.ToString();
        }

        static public void CompressDocxFile(string filePath, string binFilePath, string codingSchemePath)
        {
            string docxString = GetTextFromWordFile(filePath);

            // Build the Huffman tree
            huffmanTree.Build_Tree(docxString);

            // Encode the input file in BitArray in binary form
            BitArray bit_array = huffmanTree.Encode(docxString);

            // Byte array for storing the bits from BitArray to save in bin file
            byte[] bytes = new byte[bit_array.Length / 8 + (bit_array.Length % 8 == 0 ? 0 : 1)];
            bit_array.CopyTo(bytes, 0);

            // write all the bits from byte array in bin file
            File.WriteAllBytes(binFilePath, bytes);

            message = "Docx File Encoded Successfully";
            SifreliDosyaForm.showMessage(message);

            // Creating the coding scheme file
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < bit_array.Count; i++)
            {
                char bitChar = bit_array[i] ? '1' : '0';
                stringBuilder.Append(bitChar);
            }
            var stringBuilder2 = stringBuilder.ToString();
            File.WriteAllText(codingSchemePath, stringBuilder2);
            message = "Coding Scheme File Created Successfully";
            SifreliDosyaForm.showMessage(message);
        }

        static public string GetTextFromWordFile(string filePath)
        {
            ComponentInfo.SetLicense("AKSJUY-9IUEY-2YUW7-HSGDT-6NHJY");

            // Load Word document from file's path.
            var document = DocumentModel.Load(filePath);

            // Get Word document's plain text.
            string text = document.Content.ToString();
            return text;
        }



    }
}
