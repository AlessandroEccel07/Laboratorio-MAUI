
using System.Xml.Serialization;

namespace AppQuiz;

public partial class ResultPage : ContentPage
{
	int _score = 0;
	public ResultPage(int score)
	{
		_score = score;
		InitializeComponent();
		ShowGUI();
	}

	private void ShowGUI()
	{
		lableScore.Text = _score.ToString();
	}

    
}