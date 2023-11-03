using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Unit6Lab
{
    public class NewCinema
    {
        string[] availableMovies = new string[NumMovies];
        int[] ageRatings =  new int[NumMovies];
        const int NumMovies = 4;
        public NewCinema()
        {
            
        }
        private void GetMovies()
        {
            StreamReader reader = new StreamReader("availableMovies.txt");
            int moviesArrayIndex = 0;
            int agesArrayIndex = 0;
            for(int i=0; i<NumMovies*2; i++) {
                string thisLine = reader.ReadLine();
                if (i%2 == 0)
                {
                    availableMovies[moviesArrayIndex] = thisLine;
                    moviesArrayIndex++;
                    //availableMovies.Append(thisLine);
                }
                else
                {
                    ageRatings[agesArrayIndex] = int.Parse(thisLine);
                    agesArrayIndex++;
                }
            }
        }
        void PressAnyKey()
        {

            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }
        public void GoToCinema()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            GetMovies();
            //Core task 5
            for(int i = 0; i<availableMovies.Length; i++)
            {
                string movieToWrite = availableMovies[i];
                Console.WriteLine(movieToWrite);
            }
            Console.WriteLine("Welcome to the NTU Cinema \n\n");
            Console.Write("Enter your age: ");
            string userAgeString = Console.ReadLine();
            bool isInt = Int32.TryParse(userAgeString, out int userAge);
            if (!isInt)
            {
                Console.WriteLine("Nice try. You won't be going to the movies today because you didn't enter a valid age!");
                PressAnyKey();
            }
            else
            {
                Console.WriteLine("Currently showing...");
                for(int i = 0; i<availableMovies.Length; i++)
                {
                    if (userAge >= ageRatings[i])
                    {
                        Console.WriteLine($"{i + 1} - {availableMovies[i]}");
                    }
                    else
                    {
                        Console.WriteLine($"UNAVAILABLE DUE TO AGE - {availableMovies[i]}");
                    }
                }
                Console.Write("Enter the number of the movie you'd like to see: ");
                string userChoiceString = Console.ReadLine();
                bool choiceIsInt = Int32.TryParse(userChoiceString, out int userChoice);
                if (!choiceIsInt || userChoice -1 > availableMovies.Length || userChoice - 1 < 0)
                {
                    Console.WriteLine("Sorry. Next time, please enter a valid number.");
                    PressAnyKey();
                }
                else
                {
                    if (userAge >= ageRatings[userChoice - 1])
                    {
                        Console.WriteLine($"Enjoy the film!");
                    }
                    else
                    {
                        Console.WriteLine($"You're too young to see that film right now. Please start over.");
                    }
                    PressAnyKey();
                }
            }
        }
    }
}
