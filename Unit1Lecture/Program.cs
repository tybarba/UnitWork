using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1Lecture
{
    internal class Program
    {
        static void Main()
        {
            int lengthOfThisLessonInMinutes = 120;
            string userResponse;

            Console.WriteLine("Press ctrl K + D to prettify");
            Console.WriteLine($"There are {lengthOfThisLessonInMinutes} minutes in this class.");
            Console.WriteLine("How many minutes are left in this class?");
            userResponse = Console.ReadLine();

            bool wasNumber = Int32.TryParse(userResponse, out int result);
            if( wasNumber )
            {
                Console.WriteLine($"Congrats, you've only got {result} minutes left!");
            }
            else
            {
                Console.WriteLine($"Nice try, you didn't enter a number!");
            }
            Console.ReadKey();
        }
    }
}
