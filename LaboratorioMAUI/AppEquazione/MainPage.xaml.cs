namespace AppEquazione
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
        
            count++;

            if (count == 1)
            {
                if (double.TryParse(EntA.Text, out double a) && double.TryParse(EntB.Text, out double b) && double.TryParse(EntC.Text, out double c))
                {
                    double delta = b * b - 4 * a * c;
                    if (delta > 0) 
                    { 
                        double x1= (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2= (-b - Math.Sqrt(delta)) / (2 * a);
                        Risultato.Text = $"Due Soluzioni Reali Distinte: x1 = {x1}, x2 = {x2}";
                    }
                    else if (delta == 0) 
                    { 
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        Risultato.Text = $"Solo una soluzione x = {x1}";
                    }
                    else 
                    { 
                        Risultato.Text = $"Nessuna soluzione nell'insieme dei numeri reali";
                    }
                }
                else
                {
                    Risultato.Text = $"Valori Invalido";
                }
                count = 0;
            }
        }
    }

}
