using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4Lab
{
	internal class ReversalGame
	{
		Random Random = new Random();
		private bool GuessedCorrectly = false;
		private int NumGuesses = 0;

		private int LowestGuess = 0;
		private int Guess;
		private int HighestGuess = 101;

		public ReversalGame()
		{

		}

		public void PlayGame()
		{
			do
			{
				MakeGuess();
				string userResponse = Console.ReadLine();
				EvaluateGuess(userResponse);
			}
			while (!GuessedCorrectly);
		}

		private void EvaluateGuess(string userResponse)
		{
			switch (userResponse)
			{
				case "correct":
					Console.WriteLine($"Fantastic! That only took me {NumGuesses} guesses!");
					GuessedCorrectly = true;
					break;

				case "low":
					LowestGuess = Guess;
					break;

				case "high":
					HighestGuess = Guess;
					break;
			}
		}
		private void SetGuess()
		{
			NumGuesses++;
			Guess = Random.Next(LowestGuess + 1, HighestGuess - 1);
		}

		private void MakeGuess()
		{
			try
			{
				SetGuess();
				Console.WriteLine($"My lowest guess was: {LowestGuess}, and my highest guess was {HighestGuess}.");
				Console.Write($"I guess {Guess}. Am I right? ");
			}
			catch (ArgumentOutOfRangeException)
			{
				Console.WriteLine($"You liar! You cheated! You said {LowestGuess} was too low and {HighestGuess} was too high!");
				GuessedCorrectly = true;
				return;
			}
		}
	}
}
