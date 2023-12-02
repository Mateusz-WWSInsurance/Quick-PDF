using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWS_Trimmer
{
    public partial class Form4 : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;
        public Form4()
        {
            InitializeComponent();
            this.panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
            this.panel1.MouseMove += new MouseEventHandler(Panel1_MouseMove);
            this.panel1.MouseUp += new MouseEventHandler(Panel1_MouseUp);
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
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Mateusz-WWSInsurance/Quick-PDF";

            // Otwórz link URL w domyślnej przeglądarce
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
                MessageBox.Show($"Wystąpił błąd podczas otwierania linku URL: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
