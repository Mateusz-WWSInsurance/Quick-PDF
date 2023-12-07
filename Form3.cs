using System;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using System;
using System.IO;
using System.Windows.Forms;





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

                label5.Text = ("Kompresja w toku, może to chwile zająć");
                maxCompressButton.Enabled = false;

                // Utwórz nowy wątek dla operacji kompresji
                Thread compressThread = new Thread(() =>
                {
                    MaxCompressPdf(inputFile, outputPath);

                    // Aktualizuj interfejs użytkownika w głównym wątku
                    this.Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show("Plik PDF został skompresowany i zapisany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label2.Text = "Wybrany PDF: Brak - skorzystaj z poniższego przycisku";
                        label5.Text = ("   ");
                        maxCompressButton.Enabled = true;
                    });
                });

                // Uruchom wątek
                compressThread.Start();
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


        private void MaxCompressPdf(string inputPath, string outputPath)
        {
            using (var pdfLoadedDocument = new PdfLoadedDocument(inputPath))
            {
                // Utwórz nowe opcje kompresji PDF
                PdfCompressionOptions options = new PdfCompressionOptions();

                // Tutaj możesz dostosować opcje kompresji zgodnie z Twoimi potrzebami
                options.CompressImages = true;
                options.ImageQuality = 10; // Maksymalna kompresja obrazów
                options.OptimizeFont = true;
                options.OptimizePageContents = true;
                options.RemoveMetadata = true;

                // Ustaw opcje kompresji dla dokumentu
                pdfLoadedDocument.CompressionOptions = options;

                // Zapisz maksymalnie skompresowany dokument
                pdfLoadedDocument.Save(outputPath);

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}