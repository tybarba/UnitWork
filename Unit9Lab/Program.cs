using System.IO;
using Unit5Lab;
using Unit6Lab;

namespace Unit9Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GuessWordGame game = new GuessWordGame();
            game.PlayGame();

            //StreamWriter outputHandle = new StreamWriter("output.txt");
            //outputHandle.WriteLine("Line 1");
            //outputHandle.WriteLine("Line 2!");
            //outputHandle.Close();

            //BottleSong bottleSong = new BottleSong();
            //bottleSong.SingSong();

            //ImprovedQuiz quiz = new ImprovedQuiz();
            //quiz.PlayQuiz();

            //IOReader reader = new IOReader();
            //reader.Read();

            //NewCinema cinema = new NewCinema();
            //cinema.GoToCinema();
        }
    }
}