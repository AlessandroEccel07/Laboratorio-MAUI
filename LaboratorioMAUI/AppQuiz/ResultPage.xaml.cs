
using System.Xml.Serialization;

namespace AppQuiz;

public partial class ResultPage : ContentPage
    {
    private static readonly string _filePath = Path.Combine
    (
        FileSystem.AppDataDirectory,
        "bestscore.txt"
    );

	int _score = 0;
	public ResultPage(int score)
	{
		_score = score;
		InitializeComponent();
        SaveBestScore(score);
		ShowGUI();
	}

	private void ShowGUI()
	{
		lableScore.Text = _score.ToString();
        BestScore.Text = "Miglior Punteggio:"+ LoadBestScore().ToString();
	}
    private void SaveBestScore(int score)
    {
        int best = LoadBestScore();

        if (score > best)
        {
            try
            {
                File.WriteAllText(_filePath, score.ToString());
            }
            catch (Exception ex)
            {
                DisplayAlert("Errore", "Impossibile salvare il punteggio" + ex.Message, "");
            }
        }
    }
    private int LoadBestScore()
    {
        if (File.Exists(_filePath)) { }

        try
        {
            //Leggere il contenuto del file txt
            string content = File.ReadAllText(_filePath);
            //Variabile locale per contenere il best score
            int best;
            if (int.TryParse(content, out best))
            {
                return best;
            }
            else
            {
                DisplayAlert("Errore", "Il file del punteggio contiene un valore non valido", "OK");
                return 0;
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Errore", "Impossibile leggere il punteggio: "+ ex.Message, "OK");
            return 0;
        }
    }


}