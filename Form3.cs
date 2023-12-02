using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;



namespace WWS_Trimmer
{
    public partial class Form3 : Form
    {
        private string inputFile = null;

        public Form3()
        {
            InitializeComponent();
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki PDF|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFile = openFileDialog.FileName;
                label2.Text = "Wybrany PDF: " + Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void compressButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputFile))
            {
                MessageBox.Show("Najpierw wybierz plik do kompresji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string outputPath = GetOutputPath("compressed");

            CompressPdf(inputFile, outputPath);

            MessageBox.Show("Plik PDF został skompresowany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label2.Text = " ";
        }

        private void maxCompressButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputFile))
            {
                MessageBox.Show("Najpierw wybierz plik do maksymalnej kompresji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string outputPath = GetOutputPath("maxCompressed");

            MaxCompressPdf(inputFile, outputPath);

            MessageBox.Show("Plik PDF został skompresowany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label2.Text = " ";
        }

        private string GetOutputPath(string suffix)
        {
            string directory = Path.GetDirectoryName(inputFile);
            string fileName = Path.GetFileNameWithoutExtension(inputFile);
            string extension = Path.GetExtension(inputFile);

            string outputPath = Path.Combine(directory, fileName + "_" + suffix + extension);

            return outputPath;
        }

        private void CompressPdf(string inputPath, string outputPath)
        {
            using (var pdfReader = new PdfReader(inputPath))
            {
                using (var pdfWriter = new PdfWriter(outputPath))
                {
                    var pdfDocument = new PdfDocument(pdfReader, pdfWriter);
                }
            }
        }

        private void MaxCompressPdf(string inputPath, string outputPath)
        {
            using (var pdfReader = new PdfReader(inputPath))
            {
                using (var pdfWriter = new PdfWriter(outputPath))
                {
                    using (var pdfDocument = new PdfDocument(pdfReader, pdfWriter))
                    {
                        // Skonfiguruj właściwości pisarza bezpośrednio na obiekcie PdfDocument
                        pdfDocument.GetWriter().SetCompressionLevel(9);
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}