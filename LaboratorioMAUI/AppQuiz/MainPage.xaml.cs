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
            btnResult.IsVisible = false;
            
            _questions.Add(new TrueFalseQuestion("Sotiris é greco?", 10, true));
            _questions.Add(new TrueFalseQuestion("Sotiris é Bello?", 15, true));
            _questions.Add(new TrueFalseQuestion("Sotiris é Bhodan?", 15, false));
            _questions.Add(new OpenQuestion("Come si scrive il nome di Birbas", 15, "Sotiris"));
            Kind_Of_Question();
            ShowQuestion();

        }

        private void Kind_Of_Question()
        {
            if (_questions[_currentIndex] is TrueFalseQuestion) 
            {
                TrueButton.IsVisible = true;
                FalseButton.IsVisible = true;
                EntryText.IsVisible = false;
                SendButton.IsVisible = false;
            }
            else
            {
                TrueButton.IsVisible = false;
                FalseButton.IsVisible = false;
                EntryText.IsVisible = true;
                SendButton.IsVisible = true;
            }
        }
        private void OnAnswer_Clicked(object sender, EventArgs e) 
        {
            if(_currentIndex < _questions.Count-1)
            {
                Button btn = (Button)sender;
                string userAnswer = btn.CommandParameter.ToString();

                if (_questions[_currentIndex].CheckAnswer(userAnswer))
                {
                    _score += _questions[_currentIndex].Points;
                }
                _maxscore += _questions[_currentIndex].Points;
                _currentIndex++;
                Kind_Of_Question();
                ShowQuestion();
            }
            else
            {
                Button btn = (Button)sender;
                string userAnswer = btn.CommandParameter.ToString();
                if (_questions[_currentIndex].CheckAnswer(userAnswer))
                {
                    _score += _questions[_currentIndex].Points;
                }
                _maxscore += _questions[_currentIndex].Points;
                ScoreLabel.Text = "Test finito";
                Domanda.IsVisible = false;
                QuestionTextLabel.IsVisible = false;
                TrueButton.IsVisible = false;
                FalseButton.IsVisible = false;
                ResetButton.IsVisible = true;
                btnResult.IsVisible = true;
                EntryText.IsVisible = false;
                SendButton.IsVisible = false;



            }
            
        }
        private void OnSendButton_Clicked(object sender, EventArgs e) 
        {
            if(_currentIndex < _questions.Count-1)
            {
                Button btn = (Button)sender;
                string userAnswer = EntryText.Text;

                if (_questions[_currentIndex].CheckAnswer(userAnswer))
                {
                    _score += _questions[_currentIndex].Points;
                }
                _maxscore += _questions[_currentIndex].Points;
                _currentIndex++;
                Kind_Of_Question();
                ShowQuestion();
            }
            else
            {
                Button btn = (Button)sender;
                string userAnswer = EntryText.Text;
                if (_questions[_currentIndex].CheckAnswer(userAnswer))
                {
                    _score += _questions[_currentIndex].Points;
                }
                _maxscore += _questions[_currentIndex].Points;
                ScoreLabel.Text = "Test finito";
                Domanda.IsVisible = false;
                QuestionTextLabel.IsVisible = false;
                TrueButton.IsVisible = false;
                FalseButton.IsVisible = false;
                ResetButton.IsVisible = true;
                btnResult.IsVisible = true; 
                EntryText.IsVisible = false;
                SendButton.IsVisible = false;



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

        private async void ResetButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
           
        }
        private void btnResult_Clicked(object sender, EventArgs e)
        {
            OnQuizFinished();
        }
        private async void OnQuizFinished()
        {
            //Richiamiamo il metodo PushAsync e gli passiamo il nuovo oggetto ResultPage
            //Attendiamo senzabloccare la pagina grazie ad await e async
            await Navigation.PushAsync(new ResultPage(_score));
        }
    }

}       
    


