using AppDiario.Models;

namespace AppDiario
{
    public partial class MainPage : ContentPage
    {
        string percorsoFile = Path.Combine(FileSystem.AppDataDirectory, "note.txt");

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSalva_Clicked(object sender, EventArgs e)
        {
            Nota nuovaNota = new Nota();
            nuovaNota.Titolo = entTitolo.Text;
            nuovaNota.Testo = entTesto.Text;
            if (string.IsNullOrEmpty(nuovaNota.Titolo))
            {
                await DisplayAlert("Errore", "Inserisci almeno il titolo", "OK");
                return;
            }

            string rigaDaScrivere = nuovaNota.DaRigaAOggetto();

            File.AppendAllText(percorsoFile, rigaDaScrivere+ Environment.NewLine);
            entTitolo.Text="";
            entTesto.Text = "";

            await DisplayAlert("Fatto", "Nota salvata correttamente","OK");
        }

        private void OnLeggi_Clicked(object sender, EventArgs e)
        {
            if (File.Exists(percorsoFile))
            {
                string[] righe = File.ReadAllLines(percorsoFile);
                editDisplay.Text = "";
                foreach (string riga in righe)
                {
                    Nota n = Nota.DaRigaAOggetto(riga);

                    if (n != null)
                    {
                        editDisplay.Text = editDisplay.Text + "Titolo: " + n.Titolo + "\n";
                        editDisplay.Text = editDisplay.Text + "Testo: " + n.Testo + "\n";
                        editDisplay.Text = editDisplay.Text + "--------------------\n";
                    }

                }
            }
            else 
            {
                DisplayAlert("Errore", "Il file non esiste", "OK");
            }
        }
    }
}
