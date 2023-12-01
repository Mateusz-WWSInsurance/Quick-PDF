using System;
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
                label5.Text = ("Plik ") + openFileDialog.FileName;
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

 
    }
}

