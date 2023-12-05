using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
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
        private const string UpdateCodeNode = "updateCode";
        private readonly FirebaseClient firebaseClient = new FirebaseClient(FirebaseUrl);
        private const string ExpectedActivationCode = "512325468";
        private const string UpdateAvailableCode = "1"; // jeśli jest aktualizacja zmienić kod w firebase na 1, w nowej apce zmienić kod tutaj w visual na 2
        public Form7()
        {
            InitializeComponent();
            timer1.Tick += Timer1_Tick;
            timer1.Start();

        }

        private void ShowExitMessageBox()
        {
            
            DialogResult result = MessageBox.Show(
                "Nie można zautoryzować twojej wersji aplikacji, sprawdź połączenie z internetem lub skontaktuj się z obsługą techniczną WWS Insurance",
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

            label2.Text = ("Łączenie z usługami WWS Insurance");

            try
            {
                // Sprawdzanie kodu w Firebase
                string firebaseActivationCode = await GetFirebaseActivationCode();
                string firebaseUpdateCode = await GetFirebaseUpdateCode();

                if (string.Equals(firebaseUpdateCode, UpdateAvailableCode, StringComparison.OrdinalIgnoreCase))
                {
                    ShowUpdateMessageBox();
                }

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
            catch (HttpRequestException ex)
            {
                // Obsługa błędu braku połączenia z internetem
                Debug.WriteLine($"Błąd HTTP: {ex.Message}");

                // Wyświetlenie MessageBox informującego użytkownika o problemie z połączeniem
                MessageBox.Show(
                    "Błąd połączenia z internetem. Sprawdź swoje połączenie i spróbuj ponownie.",
                    "Błąd",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                // Zamknięcie całej aplikacji
                Application.Exit();
            }
            catch (Exception ex)
            {
                // Obsługa innych nieoczekiwanych błędów
                Debug.WriteLine($"Nieoczekiwany błąd: {ex.Message}");

                // Wyświetlenie MessageBox informującego użytkownika o nieoczekiwanym błędzie
                MessageBox.Show(
                    "Wystąpił nieoczekiwany błąd. Sprawdź swoje połączenie z internetem lub skontaktuj się z obsługą techniczną WWS Insurance",
                    "Błąd",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                // Zamknięcie całej aplikacji
                Application.Exit();
            }
        }



        private void ShowUpdateMessageBox()
        {
            DialogResult result = MessageBox.Show(
                "Dostępna jest nowa wersja aplikacji. Czy chcesz ją pobrać?",
                "Nowa aktualizacja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

        
            if (result == DialogResult.Yes)
            {

                try
                {
                    System.Diagnostics.Process.Start(new ProcessStartInfo
                    {
                        FileName = "https://wws-insurance.pl/quickpdf",
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Błąd otwierania linku: {ex.Message}");
                }

            }
        }
        private async Task<string> GetFirebaseActivationCode()
        {
            var activationCodeSnapshot = await firebaseClient
                .Child(ActivationCodeNode)
                .OnceSingleAsync<string>();

            return activationCodeSnapshot ?? string.Empty;
        }

        private async Task<string> GetFirebaseUpdateCode()
        {
            var activationCodeSnapshot = await firebaseClient
                .Child(UpdateCodeNode)
                .OnceSingleAsync<string>();

            return activationCodeSnapshot ?? string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
