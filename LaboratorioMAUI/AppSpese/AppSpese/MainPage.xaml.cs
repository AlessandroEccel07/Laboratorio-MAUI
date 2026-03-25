using AppSpese.Models;
using System.Xml;

namespace AppSpese
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();

        }
        private async void OnFinished()
        {
            await Navigation.PushAsync(new DettaglioPage(EntNomeLista.Text));
        }
        private async void OnSalvaClicked(object sender, EventArgs e)
        {
            string percorsoFile = Path.Combine(FileSystem.AppDataDirectory, EntNomeLista.Text);

            Spesa nuovaSpesa = new Spesa();

            nuovaSpesa.Descrizione = EntDescrizione.Text;
            nuovaSpesa.Importo = EntImporto.Text;

            if (string.IsNullOrEmpty(nuovaSpesa.Descrizione))
            {
                await DisplayAlert("Errore", "Inserisci almeno la descrizione", "OK");
                return;
            }


            string rigaDaScrivere = nuovaSpesa.DaOggettoARiga();

            File.AppendAllText(percorsoFile, rigaDaScrivere + Environment.NewLine);

            nuovaSpesa.Descrizione = "";
            nuovaSpesa.Importo = "";

            await DisplayAlert("Fatto", "Spesa salvata correttamente", "OK");
        }
        private void OnVediClicked(object sender, EventArgs e)
        {
            
            if (File.Exists(Path.Combine(FileSystem.AppDataDirectory, EntNomeLista.Text)))
            {
                string[] righe = File.ReadAllLines(Path.Combine(FileSystem.AppDataDirectory, EntNomeLista.Text));
                EdiDisplay.Text = "";
                foreach(string riga in righe)
                {
                    Spesa s = Spesa.DaRigaAOggetto(riga);
                    if(s!=null)
                    {
                        EdiDisplay.Text += "DESCRIZIONE: " + s.Descrizione + "\n";
                        EdiDisplay.Text += "IMPORTO: " + s.Importo + "\n";
                        EdiDisplay.Text += "---------------------\n";
                    }
                }
            }
            else
            {
                DisplayAlert("Errore", "File non esistente", "OK");

            }
        }
    }

}
