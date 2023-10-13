using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Unit1Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void PressAnyKey()
            {
                Console.WriteLine("Press any key to continue!");
                Console.ReadKey();
            }

            //Core task 5
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
                Console.WriteLine("Currently showing:\n\n\t1.封神第一部\n\t2.热烈\n\t3.功夫之萌虎上山\n");
                Console.Write("Enter the number of the movie you'd like to see: ");
                string userChoiceString = Console.ReadLine();
                bool choiceIsInt = Int32.TryParse(userChoiceString, out int userChoice);
                if (!choiceIsInt)
                {
                    Console.WriteLine("Sorry. Next time, please enter a valid number.");
                    PressAnyKey();
                }
                else
                {
                    Console.WriteLine($"Enjoy the film!");
                    PressAnyKey();
                }
            }

            ////Core task 4
            //Console.WriteLine("1\n2\n3\n4\n5");

            ////Core task 3
            //Console.WriteLine("Press any key to learn my favorite book!");
            //Console.ReadKey();
            //Console.WriteLine("\nMy favorite book is 水浒传");
            //PressAnyKey();


            ////Core task 2
            //Console.WriteLine("Hello world!");
            //Console.WriteLine("Press any key to exit;");
            //Console.ReadKey();

            ////Core task 1
            //Console.WriteLine("Press any key to exit;");
            //Console.ReadKey();
        }
    }
}
