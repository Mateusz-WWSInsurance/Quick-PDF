using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
    public partial class Form6 : Form
    {
        private string? inputFile = null;
        private Point mouseOffset;
        private bool isMouseDown = false;


        public Form6()
        {
            InitializeComponent();
            this.panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            this.panel1.MouseMove += new MouseEventHandler(Panel1_MouseMove);
            this.panel1.MouseUp += new MouseEventHandler(Panel1_MouseUp);

            // Dodaj obsługę zdarzeń dla przeciągania plików na formularz
            this.AllowDrop = true;
            this.DragDrop += new DragEventHandler(Form6_DragDrop);
            this.DragEnter += new DragEventHandler(Form6_DragEnter);
        }

        private void Form6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        // Obsługa zdarzenia upuszczenia pliku na formularz
        private void Form6_DragDrop(object sender, DragEventArgs e)
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
                MessageBox.Show("Najpierw wybierz plik.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki PDF|*.pdf";
            saveFileDialog.Title = "Wybierz miejsce do zapisu pliku";

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


                            // Iteruj przez strony i usuń te spoza zakresu
                            for (int i = pdfDocument.GetNumberOfPages(); i > 0; i--)
                            {
                                var page = pdfDocument.GetPage(i);


                                if (checkBoxRotate.Checked)
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

                            MessageBox.Show("Plik PDF został zapisany");
                        }
                    }
                }
            }


            if (checkBoxRotateRv.Checked)
            {
                checkBoxRotateRv.Checked = false;
            }

            if (checkBoxRotate.Checked)
            {
                checkBoxRotate.Checked = false;

            }
        }


        private void RotatePictureBox90Degrees(PictureBox pictureBox)
        {
            // Obróć obraz o 90 stopni w prawo
            pictureBoxS.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            // Ustaw obraz po obróceniu
            pictureBoxS.Invalidate();
        }

        private void RotatePictureBox90DegreesRv(PictureBox pictureBox)
        {
            // Obróć obraz o 90 stopni w prawo
            pictureBoxS.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);

            // Ustaw obraz po obróceniu
            pictureBoxS.Invalidate();
        }

        private void checkBoxRotateRv_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRotateRv.Checked)
            {
                checkBoxRotate.Checked = false;
                RotatePictureBox90DegreesRv(pictureBoxS);
            }
            else
            {
                RotatePictureBox90Degrees(pictureBoxS);
            }
        }

        private void checkBoxRotate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRotate.Checked)
            {
                checkBoxRotateRv.Checked = false;
                RotatePictureBox90Degrees(pictureBoxS);
            }
            else
            {
                RotatePictureBox90DegreesRv(pictureBoxS);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
