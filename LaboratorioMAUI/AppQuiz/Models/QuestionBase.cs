using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuiz.Models
{
    internal abstract class QuestionBase
    {
		private string _text;

		public string Text
		{
			get 
			{
				return _text; 
			}
			set 
			{
				_text = value; 
			}
		}
		private int _points;

		public int Points
		{
			get 
			{
				return _points; 
			}
			set 
			{
				if (value < 0)
				{
					_points = 0;
				}
				else
				{
					_points = value;
				}
			}
		}
		public QuestionBase(string text, int points)
		{
			_text = text;
			_points = points;

		}
		public abstract bool CheckAnswer(bool userAnswer);
	}	
}
