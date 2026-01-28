namespace AppConvertitore
{
    public partial class MainPage : ContentPage
    {
        
        int count = 0;
        double result = 0.0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            



            if (count == 1) {
                if(double.TryParse(franchi.Text, out double fr))
                {
                    double eu = fr * 0.93;
                    Risultato.Text = $"Risultato: {eu} €";
                }
                else
                {
                    Risultato.Text = $"Valore Invalido";
                }
                    count = 0;
        }
             

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
