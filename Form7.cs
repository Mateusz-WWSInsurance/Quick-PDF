using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;

namespace WWS_Trimmer
{
    public partial class Form7 : Form
    {
        private const string FirebaseUrl = "https://quick-pdf-auth-default-rtdb.europe-west1.firebasedatabase.app/";
        private const string ActivationCodeNode = "activationCode";
        private readonly FirebaseClient firebaseClient = new FirebaseClient(FirebaseUrl);
        private const string ExpectedActivationCode = "512325468";
        public Form7()
        {
            InitializeComponent();
            timer1.Tick += Timer1_Tick;
            timer1.Start();

        }

        private void ShowExitMessageBox()
        {
            
            DialogResult result = MessageBox.Show(
                "Nie można zautoryzować twojej wersji aplikacji, skontaktuj się z WWS Insurance",
                "Błąd autoryzacji",
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error 
            );

            // Sprawdzenie, czy użytkownik nacisnął OK
            if (result == DialogResult.OK)
            {
                // Zamknięcie całej aplikacji
                Application.Exit();
            }
        }

        // Uwaga! Kod odpowiadajacy za weryfikację aktualizacji z bazą danych WWS Insurance jest ukryty na potrzeby opubblikowania pozostałego kodu źródłowego w GitHub
        private async void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            // Sprawdzanie kodu w Firebase
            string firebaseActivationCode = await GetFirebaseActivationCode();

            if (string.Equals(firebaseActivationCode, ExpectedActivationCode, StringComparison.OrdinalIgnoreCase))
            {
                Hide();
                Form1 mainForm = new Form1();
                mainForm.ShowDialog();
                Close();
            }
            else
            {
                ShowExitMessageBox();
            }

            
        }

        private async Task<string> GetFirebaseActivationCode()
        {
            var activationCodeSnapshot = await firebaseClient
                .Child(ActivationCodeNode)
                .OnceSingleAsync<string>();

            return activationCodeSnapshot ?? string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
