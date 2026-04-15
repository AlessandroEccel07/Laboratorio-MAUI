using HelloList.Models;

namespace HelloList
{
    public partial class MainPage : ContentPage
    {
        List<Frutto> frutti;

        public MainPage()
        {
            InitializeComponent();
            ShowGUI();

        }

        private void ShowGUI()
        {
            frutti = new List<Frutto>();
            frutti.Add(new Frutto("mela", "Italia"));
            frutti.Add(new Frutto("kiwi", "Groelandia"));
            frutti.Add(new Frutto("ananas", "Svizzera"));
            MyPicker.ItemsSource = frutti;
        }
    }
}