using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Unit6Lab
{
    struct Movie
    {
        public string MovieTitle;
        public int AgeRating;
    }
    public class NewCinema
    {
        Movie[] movies = new Movie[NumMovies];
        //string[] availableMovies = new string[NumMovies];
        //int[] ageRatings =  new int[NumMovies];
        const int NumMovies = 4;
        public NewCinema()
        {
            
        }
        private void GetMovies()
        {
            StreamReader reader = new StreamReader("../../../../Unit9Lab/bin/Debug/net6.0/availableMovies.txt");
            int movieIndex = 0;
            while (!reader.EndOfStream)
            {
                Movie newMovie = new Movie();
                newMovie.MovieTitle = reader.ReadLine();
                newMovie.AgeRating = int.Parse(reader.ReadLine());
                movies[movieIndex] = newMovie;
                movieIndex++;
            }
            //int moviesArrayIndex = 0;
            //int agesArrayIndex = 0;
            //for(int i=0; i<NumMovies*2; i++) {
            //    string thisLine = reader.ReadLine();
            //    if (i%2 == 0)
            //    {
            //        availableMovies[moviesArrayIndex] = thisLine;
            //        moviesArrayIndex++;
            //        //availableMovies.Append(thisLine);
            //    }
            //    else
            //    {
            //        ageRatings[agesArrayIndex] = int.Parse(thisLine);
            //        agesArrayIndex++;
            //    }
            //}
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
            for(int i = 0; i<movies.Length; i++)
            {
                string movieToWrite = movies[i].MovieTitle;
                Console.WriteLine(movieToWrite);
            }
            Console.WriteLine("Welcome to the NTU Cinema \n\n");
            Console.Write("Enter your age: ");
            string userAgeString = Console.ReadLine();
            bool isInt = Int32.TryParse(userAgeString, out int userAge);
            while (!isInt)
            {
                Console.WriteLine("You didn't enter a correct age.");
                Console.Write("Enter your age: ");
                userAgeString = Console.ReadLine();
                isInt = Int32.TryParse(userAgeString, out int age);
                userAge = age;
            }

            Console.WriteLine("Currently showing...");
            for(int i = 0; i<movies.Length; i++)
            {
                if (userAge >= movies[i].AgeRating)
                {
                    Console.WriteLine($"{i + 1} - {movies[i].MovieTitle}");
                }
                else
                {
                    Console.WriteLine($"UNAVAILABLE DUE TO AGE - {movies[i].AgeRating}");
                }
            }
            Console.Write("Enter the number of the movie you'd like to see: ");
            string userChoiceString = Console.ReadLine();
            bool choiceIsInt = Int32.TryParse(userChoiceString, out int userChoice);
            while(!choiceIsInt || userChoice -1 > movies.Length || userChoice - 1 < 0)
            {
                Console.Write("Enter the number of the movie you'd like to see: ");
                userChoiceString = Console.ReadLine();
                choiceIsInt = Int32.TryParse(userChoiceString, out int choice);
                userChoice = choice;
            }
                if (userAge >= movies[userChoice - 1].AgeRating)
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
