using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4Lab
{
	internal class GuessANumberGame
	{
		protected int TargetNumber;
		Random random = new Random();
		protected bool GuessedIncorrectly = true;
		public GuessANumberGame() 
		{
			TargetNumber = random.Next(1, 101);
		}

		public void PlayGame()
		{
			Console.WriteLine("Guess a number between 1 and 100!");
			do
			{
				Console.Write("What's your guess: ");
				string userAnswerString = Console.ReadLine();
				EvaluateUserAnswer(userAnswerString);
            }
			while(GuessedIncorrectly);
		}

		private void EvaluateUserAnswer(string? userAnswerString)
		{
			try
			{
				int userAnswer = int.Parse(userAnswerString);
				if (userAnswer == TargetNumber)
				{
                    Console.WriteLine("That's correct!");
                    GuessedIncorrectly = false;
				}
				else if(userAnswer < TargetNumber)
				{
                    Console.WriteLine("Too low!");
                }
				else
				{
                    Console.WriteLine("Too high!");
                }
			}
			catch
			{
                Console.WriteLine("That was silly.");
            }
		}
	}
}
