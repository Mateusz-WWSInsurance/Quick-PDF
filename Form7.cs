using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWS_Trimmer
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            timer1.Tick += Timer1_Tick;
            timer1.Start();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Hide();
            Form1 mainForm = new Form1();
            mainForm.ShowDialog();
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
