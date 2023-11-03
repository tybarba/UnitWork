using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit6Lab
{
    public class ImprovedQuiz
    {
        int UserScore { get; set; } = 0;
        string UserName { get; set; }
        string CorrectAnswerMessage { get; set; }
        string WrongAnswerMessage { get; set; }
        const int NumQuestions = 3;
        string FollowUp;
        string[] Questions;
        string[] Answers;
        const string QuizFilePath = "QuizScores.txt";
        public ImprovedQuiz()
        {
            CorrectAnswerMessage = $"That's correct. Your score is: {UserScore}/{NumQuestions}";
            WrongAnswerMessage = $"That's wrong. Your score is: {UserScore}/{NumQuestions}";
            FollowUp = "Enter your answer: ";
            Questions = new string[NumQuestions]
            {
                "What is the official language of the USA?\n\tA. English\n\tB. Spanish\n\tC. None",
                "How many questions are in this quiz?\n\tA. 5\n\tB. 3\n\tC. 4",
                "What's my favorite brand of crisps?\n\tA. Cheetos\n\tB. Doritos\n\tC. Pringles"
            };
            Answers = new string[NumQuestions]
            {
                "C", "B", "B"
            };
        }
        private void UpdateMessages()
        {
            CorrectAnswerMessage = $"That's correct. Your score is: {UserScore}/{NumQuestions}";
            WrongAnswerMessage = $"That's wrong. Your score is: {UserScore}/{NumQuestions}";
        }
        private void LaunchQuiz()
        {
            Console.WriteLine("Welcome to my quiz!\n\n");
            GetUserName();
            DisplayAnyExistingScores();
        }
        private void DisplayAnyExistingScores()
        {
            if (ScoresFileExists())
            {
                StreamReader reader = new StreamReader(QuizFilePath);
                //bool keepReading = true;
                while (reader.EndOfStream == false)
                {
                    string score = reader.ReadLine();
                    //if (score == null) { break; }
                    Console.WriteLine(score);
                }
                reader.Close();
            }
        }
        private bool ScoresFileExists()
        {
            if (File.Exists(QuizFilePath))
            {
                StreamReader reader = new StreamReader(QuizFilePath);
                if (!string.IsNullOrEmpty(reader.ReadLine()))
                {
                    reader.Close();
                    return true;
                }
                reader.Close();
            }
            return false;
        }
        protected void GetUserName()
        {
            Console.Write("Please enter your name: ");
            UserName = Console.ReadLine();
        }
        public void PlayQuiz()
        {
            LaunchQuiz();
            for (int i = 0; i < NumQuestions; i++)
            {
                Console.WriteLine(Questions[i]);
                Console.WriteLine(FollowUp);
                string userAnswer = Console.ReadLine().ToUpper();
                if (userAnswer == Answers[i])
                {
                    UserScore++;
                    UpdateMessages();
                    Console.WriteLine(CorrectAnswerMessage);
                }
                else
                {
                    Console.WriteLine(WrongAnswerMessage);
                }
            }
            Console.WriteLine("Your final score:");
            Console.WriteLine($"{UserName}: {UserScore}/{NumQuestions}");
            RecordAnswers();
        }

        private void RecordAnswers()
        {
            StreamWriter writer = new StreamWriter(QuizFilePath, append: true);
            writer.WriteLine($"{UserName}: {UserScore}/{NumQuestions}");
            writer.Close();
        }
    }
}
