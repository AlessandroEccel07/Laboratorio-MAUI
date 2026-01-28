namespace AppEsempio
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
                CounterBtn.Text = $"Clicked Mussi {count} time";
            else
                CounterBtn.Text = $"Clicked Mussi {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void OnMussiClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked Mussi {count} time";
            else
                CounterBtn.Text = $"Clicked Mussi {count} times";

            SemanticScreenReader.Announce(MussiCounterButton.Text);
        }
    }

}
