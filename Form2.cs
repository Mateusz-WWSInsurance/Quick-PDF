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
using iText.Kernel.Utils;

namespace WWS_Trimmer
{
    public partial class Form2 : Form
    {
        private string? firstPdfFile = null;
        private string? secondPdfFile = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void FirstPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki PDF|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                firstPdfFile = openFileDialog.FileName;
                labelFirstPdf.Text = "Wybrany PDF: " + Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void SecondPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki PDF|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                secondPdfFile = openFileDialog.FileName;
                labelSecondPdf.Text = "Wybrany PDF: " + Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void ButtonMergePdf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstPdfFile) || string.IsNullOrEmpty(secondPdfFile))
            {
                MessageBox.Show("Proszę wybrać oba pliki PDF do połączenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki PDF|*.pdf";
            saveFileDialog.Title = "Wybierz miejsce do zapisu połączonego pliku PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPdfPath = saveFileDialog.FileName;

                using (var pdfWriter = new PdfWriter(outputPdfPath))
                {
                    using (var pdfDocument = new PdfDocument(pdfWriter))
                    {
                        PdfMerger merger = new PdfMerger(pdfDocument);

                        // Dodaj pierwszy plik PDF
                        using (var firstPdfReader = new PdfReader(firstPdfFile))
                        {
                            PdfDocument firstPdfDocument = new PdfDocument(firstPdfReader);
                            merger.Merge(firstPdfDocument, 1, firstPdfDocument.GetNumberOfPages());
                        }

                        // Dodaj drugi plik PDF
                        using (var secondPdfReader = new PdfReader(secondPdfFile))
                        {
                            PdfDocument secondPdfDocument = new PdfDocument(secondPdfReader);
                            merger.Merge(secondPdfDocument, 1, secondPdfDocument.GetNumberOfPages());
                        }
                    }
                }

                MessageBox.Show("Pliki PDF zostały połączone i zapisane.");

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
