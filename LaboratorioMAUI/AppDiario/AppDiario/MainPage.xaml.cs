namespace AppDiario
{
    public partial class MainPage : ContentPage
    {
        string percorsoFile = Path.Combine(FileSystem.AppDataDirectory, "note.txt");

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSalva_Clicked(object sender, EventArgs e)
        {

        }

        private void OnLeggi_Clicked(object sender, EventArgs e)
        {

        }
    }
}
