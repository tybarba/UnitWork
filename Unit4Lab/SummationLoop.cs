using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4Lab
{
	internal class SummationLoop
	{
		protected bool StopConditionMet = false;
		protected const int ExpectedAnswer = 0;
		protected int CurrentSum = 0;
        public SummationLoop()
        {
        }
        public void PerformSummationLoop()
		{
			while(!StopConditionMet) 
			{
                Console.Write("Enter a number: ");
				string userAnswerString = Console.ReadLine();
				StopConditionMet = AnswerAsExpected(userAnswerString);
            }
		}

		protected bool AnswerAsExpected(string userAnswerString)
		{
			int userAnswer = int.Parse(userAnswerString);
            if (userAnswer == ExpectedAnswer)
			{
				return true;
			}
			else
            {
				CurrentSum += userAnswer;
                Console.WriteLine(CurrentSum);
                return false;
            }
        }
	}
}
