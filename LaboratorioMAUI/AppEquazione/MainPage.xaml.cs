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
                        Risultato.TextColor = Colors.Green;
                        double x1= (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2= (-b - Math.Sqrt(delta)) / (2 * a);
                        Risultato.Text = string.Format($"Due Soluzioni Reali Distinte: x1 = {0:F3}, x2 = {1:F3}", x1, x2);
                    }
                    else if (delta == 0) 
                    {
                        Risultato.TextColor = Colors.Blue;
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        Risultato.Text = string.Format($"Solo una soluzione x = {0:F3}", x1);
                    }
                    else 
                    {
                        Risultato.TextColor = Colors.Red;
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
