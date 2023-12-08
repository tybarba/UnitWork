using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit6Lab
{
    public class GuessWordGame
    {
        public GuessWordGame()
        {
                   
        }
        //string[] PossibleWords = new string[] {"elephant", "tiger", "lion", "monkey", "zebra" };
        string FilePath = "C:\\Users\\tybar\\Desktop\\Software Programming 1\\Unit Work\\Unit9Lab\\Files\\GameWords.txt";
        //List<string> PossibleWords = new List<string>();
        string[] PossibleWords;
        string GameWord = "pool";
        string BlankWord = "";
        char[] SplitBlankWord;
        const int MaxUserGuesses = 8;
        public void PlayGame()
        {
            try
            {
                //""C:\Users\tybar\Desktop\Software Programming 1\Unit Work\Unit9Lab\Files\GameWords.txt""
                //StreamReader reader = new StreamReader();
                PossibleWords = File.ReadAllLines(FilePath);
                //while (reader.EndOfStream == false)
                //{
                //    PossibleWords.Add(reader.ReadLine());
                //}
                //reader.Close();

                bool keepPlaying = true;
                SetGameWord();
                SetBlankWord();
                SplitBlankWord = BlankWord.ToCharArray();
                bool guessedRight = false;
                int userGuesses = 0;
                while (keepPlaying)
                {
                    Console.WriteLine("Here's my word: " + BlankWord);
                    Console.Write("Guess a letter: ");
                    char guess = Console.ReadLine()[0];
                    char userGuess = CheckChar(guess);
                    for (int i = 0; i < GameWord.Length; i++)
                    {
                        if (GameWord[i] == userGuess)
                        {
                            SplitBlankWord[i] = userGuess;
                            guessedRight = true;
                        }
                    }
                    if (guessedRight) { Console.WriteLine($"{userGuess} is in my word. Nice guess!"); } else { Console.WriteLine("Sorry. That's not in my word."); }
                    guessedRight = false;
                    userGuesses++;

                    BlankWord = new string(SplitBlankWord);
                    if (GameWord == BlankWord)
                    {
                        Console.WriteLine("Congrats you won!");
                        keepPlaying = false;
                        break;
                    }
                    if (userGuesses == MaxUserGuesses)
                    {
                        Console.WriteLine("You're out of guesses. Better luck next time!");
                        break;
                    }
                    Console.WriteLine($"You have guessed {userGuesses} times. You have {MaxUserGuesses - userGuesses} remaining!");
                }
            }
            catch(Exception ex)
            {
                if(ex is IndexOutOfRangeException)
                {
                    Console.WriteLine($"There are no words in the file. Please go to {this.FilePath} and add some words.");
                }
                else if(ex is FileNotFoundException)
                {
                    Console.WriteLine("There's no existing file that contains the words for this game.");
                }
                else
                {
                    Console.WriteLine(ex.Message);
                }
                //Console.WriteLine(ex.Message);
            }
            
            

        }

        private char CheckChar(char c)
        {
            char zi = c;
            bool isChar = false;
            while (!isChar)
            {
                if (char.IsLetter(zi))
                {
                    zi = char.ToLower(zi);
                    break;
                }
                Console.WriteLine("You did enter a letter.");
                Console.Write("Please enter a new letter: ");
                zi = Console.ReadLine()[0];
            }
            return zi;
        }

        private void SetBlankWord()
        {
            for(int i=0; i<GameWord.Length; i++)
            {
                BlankWord += "_";
            }
        }

        private void SetGameWord()
        {
            Random rnd = new Random();
            int wordIndex = rnd.Next(0, PossibleWords.Length);
            GameWord = PossibleWords[wordIndex];
        }
    }
}
