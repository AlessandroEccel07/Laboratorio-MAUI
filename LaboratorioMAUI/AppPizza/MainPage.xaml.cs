using AppPizza.Models;

namespace AppPizza
{
    public partial class MainPage : ContentPage
    {
        List<Pizza> frutti;

        public MainPage()
        {
            InitializeComponent();
            ShowGUI();

        }

        private void ShowGUI()
        {
            frutti = new List<Pizza>();
            frutti.Add(new Pizza("margherita", ""));
            frutti.Add(new Pizza("kiwi", "Groelandia"));
            frutti.Add(new Pizza("ananas", "Svizzera"));
            MyPicker.ItemsSource = frutti;
        }
    }
}