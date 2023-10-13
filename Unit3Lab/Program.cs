namespace Unit3Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userScore = 0;

            string correctAnswerMessage = $"That's correct. Your score is: {userScore}/3";
            string wrongAnswerMessage = $"That's wrong. Your score is: {userScore}/3";

            void updateMessages()
            {
                correctAnswerMessage = $"That's correct. Your score is: {userScore}/3";
                wrongAnswerMessage = $"That's wrong. Your score is: {userScore}/3";
            }

            string followUp = "Enter your answer: ";
            string question1 = "What is the official language of the USA?\n\tA. English\n\tB. Spanish\n\tC. None";
            string question1Answer = "C";
            string question2 = "How many questions are in this quiz?\n\tA. 5\n\tB. 3\n\tC. 4";
            string question2Answer = "B";
            string question3 = "What's my favorite brand of crisps?\n\tA. Cheetos\n\tB. Doritos\n\tC. Pringles";
            string question3Answer = "B";

            Console.WriteLine("Welcome to my quiz!\n\n");

            Console.WriteLine(question1);
            Console.Write(followUp);
            string userAnswer1 = Console.ReadLine().ToUpper();
            if(userAnswer1 == question1Answer)
            {
                userScore++;
                updateMessages();
                Console.WriteLine(correctAnswerMessage);
            }
            else
            {
                Console.WriteLine(wrongAnswerMessage);
            }

            Console.WriteLine(question2);
            Console.Write(followUp);
            string userAnswer2 = Console.ReadLine().ToUpper();
            if (userAnswer2 == question2Answer)
            {
                userScore++;
                updateMessages();
                Console.WriteLine(correctAnswerMessage);
            }
            else
            {
                Console.WriteLine(wrongAnswerMessage);
            }

            Console.WriteLine(question3);
            Console.Write(followUp);
            string userAnswer3 = Console.ReadLine().ToUpper();
            if (userAnswer3 == question3Answer)
            {
                userScore++;
                updateMessages();
                Console.WriteLine(correctAnswerMessage);
            }
            else
            {
                Console.WriteLine(wrongAnswerMessage);
            }
        }
    }
}