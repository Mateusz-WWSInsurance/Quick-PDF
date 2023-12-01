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
    public partial class Form1 : Form
    {
        private string? inputFile = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki PDF|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFile = openFileDialog.FileName;
                label5.Text = ("Wybrany PDF: ") + openFileDialog.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // SprawdŸ, czy textboxy s¹ uzupe³nione

            if (string.IsNullOrEmpty(inputFile))
            {
                MessageBox.Show("Najpierw wybierz plik do przyciêcia.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBoxRotateRv.Checked)
            {
                checkBoxRotateRv.Checked = false;
                RotatePictureBox90Degrees(pictureBoxS);
            }

            if (checkBoxRotate.Checked)
            {
                checkBoxRotate.Checked = false;
                RotatePictureBox90DegreesRv(pictureBoxS);
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki PDF|*.pdf";
            saveFileDialog.Title = "Wybierz miejsce do zapisu przyciêtego pliku";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;

                using (var pdfReader = new PdfReader(inputFile))
                {
                    using (var pdfWriter = new PdfWriter(outputPath))
                    {
                        using (var pdfDocument = new PdfDocument(pdfReader, pdfWriter))
                        {
                            var document = new Document(pdfDocument);


                            // Iteruj przez strony i usuñ te spoza zakresu
                            for (int i = pdfDocument.GetNumberOfPages(); i > 0; i--)
                            {
                                var page = pdfDocument.GetPage(i);

                                int startPage = string.IsNullOrEmpty(textBox1.Text) ? 1 : int.Parse(textBox1.Text);
                                int endPage = string.IsNullOrEmpty(textBox2.Text) ? pdfDocument.GetNumberOfPages() : int.Parse(textBox2.Text);

                                if (i < startPage || i > endPage)
                                {
                                    pdfDocument.RemovePage(i);
                                }
                                else if (checkBoxRotate.Checked)
                                {
                                    if (page != null)
                                    {
                                        page.SetRotation((page.GetRotation() + 90) % 360);
                                    }
                                }
                                else if (checkBoxRotateRv.Checked)
                                {
                                    page.SetRotation((page.GetRotation() - 90) % 360);
                                }


                            }

                            MessageBox.Show("Plik PDF zosta³ zapisany");
                        }
                    }
                }
            }
        }


        private void RotatePictureBox90Degrees(PictureBox pictureBox)
        {
            // Obróæ obraz o 90 stopni w prawo
            pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            // Ustaw obraz po obróceniu
            pictureBox.Invalidate();
        }

        private void RotatePictureBox90DegreesRv(PictureBox pictureBox)
        {
            // Obróæ obraz o 90 stopni w prawo
            pictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);

            // Ustaw obraz po obróceniu
            pictureBox.Invalidate();
        }

        private void checkBoxRotateRv_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRotateRv.Checked)
            {
                checkBoxRotate.Checked = false;
                RotatePictureBox90DegreesRv(pictureBoxS);
            }
        }

        private void checkBoxRotate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRotate.Checked)
            {
                checkBoxRotateRv.Checked = false;
                RotatePictureBox90Degrees(pictureBoxS);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Tutaj ustaw adres URL, który chcesz otworzyæ
            string url = "https://wws-insurance.pl/report";

            // Otwórz link URL w domyœlnej przegl¹darce
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wyst¹pi³ b³¹d podczas otwierania linku URL: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

