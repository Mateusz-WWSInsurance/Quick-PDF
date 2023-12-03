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
        private Point mouseOffset;
        private bool isMouseDown = false;

        public Form3()
        {
            InitializeComponent();
            this.panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            this.panel1.MouseMove += new MouseEventHandler(Panel1_MouseMove);
            this.panel1.MouseUp += new MouseEventHandler(Panel1_MouseUp);

            // Dodaj obsługę zdarzeń dla przeciągania plików na formularz
            this.AllowDrop = true;
            this.DragDrop += new DragEventHandler(Form3_DragDrop);
            this.DragEnter += new DragEventHandler(Form3_DragEnter);
        }

        private void Form3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        // Obsługa zdarzenia upuszczenia pliku na formularz
        private void Form3_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                string filePath = files[0];

                if (Path.GetExtension(filePath).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    inputFile = filePath;
                    label2.Text = "Wybrany PDF: " + Path.GetFileName(filePath);
                }
                else
                {
                    MessageBox.Show("Proszę przeciągnąć tylko pliki PDF.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
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

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki PDF|*.pdf";
            saveFileDialog.FileName = Path.GetFileNameWithoutExtension(inputFile) + "_quickPDF_compressed.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;

                CompressPdf(inputFile, outputPath);

                MessageBox.Show("Plik PDF został skompresowany i zapisany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label2.Text = " ";
            }
        }

        private void maxCompressButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputFile))
            {
                MessageBox.Show("Najpierw wybierz plik do maksymalnej kompresji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki PDF|*.pdf";
            saveFileDialog.FileName = Path.GetFileNameWithoutExtension(inputFile) + "_quickPDF_maxCompressed.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;

                MaxCompressPdf(inputFile, outputPath);

                MessageBox.Show("Plik PDF został skompresowany i zapisany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label2.Text = " ";
            }
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