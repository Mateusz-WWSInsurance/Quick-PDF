using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Element;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WWS_Trimmer
{
    public partial class Form5 : Form
    {
        private string? inputFile = null;
        private Point mouseOffset;
        private bool isMouseDown = false;


        public Form5()
        {
            InitializeComponent();
            this.panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            this.panel1.MouseMove += new MouseEventHandler(Panel1_MouseMove);
            this.panel1.MouseUp += new MouseEventHandler(Panel1_MouseUp);

            // Dodaj obsługę zdarzeń dla przeciągania plików na formularz
            this.AllowDrop = true;
            this.DragDrop += new DragEventHandler(Form5_DragDrop);
            this.DragEnter += new DragEventHandler(Form5_DragEnter);
        }

        private void Form5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        // Obsługa zdarzenia upuszczenia pliku na formularz
        private void Form5_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                string filePath = files[0];

                if (Path.GetExtension(filePath).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    inputFile = filePath;
                    label5.Text = "Wybrany PDF: " + Path.GetFileName(filePath);
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki PDF|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFile = openFileDialog.FileName;
                label5.Text = "Wybrany PDF: " + Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy textboxy są uzupełnione
            if (string.IsNullOrEmpty(inputFile))
            {
                MessageBox.Show("Najpierw wybierz plik do przycięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki PDF|*.pdf";
            saveFileDialog.Title = "Wybierz miejsce do zapisu przyciętego pliku";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;
                label6.Text = ("Przycinanie w toku, proszę czekać");

                // Utwórz nowy wątek dla operacji przycinania PDF
                Thread trimThread = new Thread(() =>
                {
                    TrimPdf(inputFile, outputPath);

                    // Aktualizuj interfejs użytkownika w głównym wątku
                    this.Invoke((MethodInvoker)delegate
                    {
                        label6.Text = ("  ");
                        MessageBox.Show("Plik PDF został zapisany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    });
                });

                // Uruchom wątek
                trimThread.Start();
            }
        }

        private void TrimPdf(string inputPath, string outputPath)
        {
            using (var pdfReader = new PdfReader(inputPath))
            {
                using (var pdfWriter = new PdfWriter(outputPath))
                {
                    using (var pdfDocument = new PdfDocument(pdfReader, pdfWriter))
                    {
                        var document = new Document(pdfDocument);

                        // Iteruj przez strony i usuń te spoza zakresu
                        for (int i = pdfDocument.GetNumberOfPages(); i > 0; i--)
                        {
                            var page = pdfDocument.GetPage(i);

                            int startPage = string.IsNullOrEmpty(textBox1.Text) ? 1 : int.Parse(textBox1.Text);
                            int endPage = string.IsNullOrEmpty(textBox2.Text) ? pdfDocument.GetNumberOfPages() : int.Parse(textBox2.Text);

                            if (i < startPage || i > endPage)
                            {
                                pdfDocument.RemovePage(i);
                            }
                        }
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
