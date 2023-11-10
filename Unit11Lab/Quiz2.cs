using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit11Lab
{
    struct QuizQuestion
    {
        public string Question;
        public string Answer;
        public string[] PossibleAnswers;
    }
    public class Quiz2
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
        QuizQuestion[] quizQuestions = new QuizQuestion[NumQuestions];

        private void GenerateQuizQuestions()
        {
            Questions = new string[NumQuestions]
{
                "What is the official language of the USA?",
                "How many questions are in this quiz?",
                "What's my favorite brand of crisps?"
};
            Answers = new string[NumQuestions]
            {
                "3", "2", "2"
            };
            for(int i = 0; i<NumQuestions; i++)
            {
                QuizQuestion q = new QuizQuestion();
                q.Question = Questions[i];
                q.Answer = Answers[i];
                switch (i)
                {
                    case 0:
                        q.PossibleAnswers = new string[] { "English", "Spanish", "None" };
                        break;
                    case 1:
                        q.PossibleAnswers = new string[] { "5", "3", "4", "2" };
                        break;
                    case 2:
                        q.PossibleAnswers = new string[] { "Cheetos", "Doritos", "Pringles", "Funyuns", "Bugles" };
                        break;
                }
                quizQuestions[i] = q;
            }
        }
        public Quiz2()
        {
            CorrectAnswerMessage = $"That's correct. Your score is: {UserScore}/{NumQuestions}";
            WrongAnswerMessage = $"That's wrong. Your score is: {UserScore}/{NumQuestions}";
            FollowUp = "Enter your answer: ";

        }
        private void UpdateMessages()
        {
            CorrectAnswerMessage = $"That's correct. Your score is: {UserScore}/{NumQuestions}";
            WrongAnswerMessage = $"That's wrong. Your score is: {UserScore}/{NumQuestions}";
        }
        private void LaunchQuiz()
        {
            Console.WriteLine("Welcome to my quiz!\n\n");
            GenerateQuizQuestions();
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
        private void DisplayQuestion(QuizQuestion q)
        {
            Console.WriteLine(q.Question);
            for(int i = 0; i<q.PossibleAnswers.Length; i++)
            {
                Console.WriteLine($"{i+1}. {q.PossibleAnswers[i]}");
            }
        }
        public void PlayQuiz()
        {
            LaunchQuiz();
            for (int i = 0; i < NumQuestions; i++)
            {
                DisplayQuestion(quizQuestions[i]);
                Console.WriteLine(FollowUp);
                string userAnswer = Console.ReadLine().ToUpper();
                if (userAnswer == quizQuestions[i].Answer)
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
