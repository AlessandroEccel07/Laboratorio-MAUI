using AppQuiz.Models;
using System.ComponentModel;

namespace AppQuiz
{
    public partial class MainPage : ContentPage
    {
        private List<QuestionBase> _questions = new List<QuestionBase>();
        private int _currentIndex = 0;
        private int _score;
        private int _maxscore = 0;
        public MainPage()
        {
            InitializeComponent();
            ResetButton.IsVisible = false;   
            _questions.Add(new TrueFalseQuestion("Sotiris é greco?", 10, true));
            _questions.Add(new TrueFalseQuestion("Sotiris é Bello?", 15, true));
            _questions.Add(new TrueFalseQuestion("Sotiris é Bhodan?", 15, false));
            ShowQuestion();

        }

        private void OnAnswer_Clicked(object sender, EventArgs e) 
        {
            if(_currentIndex < _questions.Count-1)
            {
                Button btn = (Button)sender;
                bool userAnswer = bool.Parse(btn.CommandParameter.ToString());

                if (_questions[_currentIndex].CheckAnswer(userAnswer))
                {
                    _score += _questions[_currentIndex].Points;
                }
                _maxscore += _questions[_currentIndex].Points;
                _currentIndex++;
                ShowQuestion();
            }
            else
            {
                ScoreLabel.Text = "Test finito";
                Domanda.IsVisible = false;
                QuestionTextLabel.Text = _score+"/"+_maxscore;
                TrueButton.IsVisible = false;
                FalseButton.IsVisible = false;
                ResetButton.IsVisible = true;


            }
            
        }
        private void ShowQuestion()
        {
            if (_currentIndex < _questions.Count)
            {
                QuestionBase current = _questions[_currentIndex];
                QuestionTextLabel.Text = current.Text;
                ScoreLabel.Text = _score.ToString();
            }
        }

        private void ResetButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage= new MainPage();
           
        }
    }

}       
    


