using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2Lab
{
    internal class Program
    {
        static decimal ReadPositiveDecimal(string priceString)
        {
            bool isPositive = false;
            decimal price = 0;
            string userAnswer = priceString;
            while (!isPositive)
            {
                if (!string.IsNullOrEmpty(userAnswer))
                {
                    price = Math.Round(decimal.Parse(userAnswer), 2);
                    if (price > 0) { isPositive = true; break; }
                }
                Console.WriteLine("You entered a wrong number.");
                Console.Write("Enter the price again: ");
                userAnswer = Console.ReadLine();
                //if (!string.IsNullOrEmpty(userAnswer))
                //{
                //    price = Math.Round(decimal.Parse(Console.ReadLine()), 2);
                //    if (price > 0) { isPositive = true; }
                //}
            }
            return price;
        }
        static void Main(string[] args)
        {
            ////###### CALCULATING SOLUTIONS #######
            ///
            /// 2. Tip Calculator
            Console.WriteLine("Hi! Welcome to your tip calculator. Let's get started by finding the subtotal of your bill.");
            Console.Write("Please enter the price of any starters: ");
            decimal startersPrice = ReadPositiveDecimal(Console.ReadLine());
            Console.Write("Okay. Now, enter the price of the main course: ");
            decimal mainCoursePrice = ReadPositiveDecimal(Console.ReadLine());
            Console.Write("Great! Please enter the price of any desserts: ");
            decimal dessertPrice = ReadPositiveDecimal(Console.ReadLine());
            Console.Write("Wonderful. Finally, enter the price of any drinks: ");
            decimal drinksPrice = ReadPositiveDecimal(Console.ReadLine());
            decimal subtotal = startersPrice + mainCoursePrice + dessertPrice + drinksPrice;
            Console.WriteLine($"Fantastic! Your subtotal is: ${subtotal}");
            Console.WriteLine("Do you want to leave a tip? (y/n)");
            string willLeaveTipString = Console.ReadLine();
            if (willLeaveTipString == "n")
            {
                Console.WriteLine($"With a tip of 0%, your total price is: {subtotal}");
            }
            else if (willLeaveTipString == "y")
            {
                Console.Write($"Enter the percent you'd like to tip. " +
                    $"\n\tFor your reference:" +
                    $"\n\t10% - ${Math.Round(subtotal * .1m, 2)} | Total: ${Math.Round(subtotal + subtotal * .1m, 2)}" +
                    $"\n\t15% - ${Math.Round(subtotal * .15m, 2)} | Total: ${Math.Round(subtotal + subtotal * .15m, 2)}" +
                    $"\n\t20% - ${Math.Round(subtotal * .2m, 2)} | Total: ${Math.Round(subtotal + subtotal * .2m, 2)}" +
                    $"\n\nIn percentage, how much would you like to tip? (example: 20)" +
                    $"\nPercentage to tip: ");
                string tipAmountString = Console.ReadLine();
                decimal tipAmount = decimal.Parse(tipAmountString)/100;
                decimal tipTotal = Math.Round(subtotal * tipAmount, 2);
                decimal totalWithTip = subtotal + tipTotal;
                Console.WriteLine($"A tip of {tipAmountString}% is ${tipTotal}.\nYour total bill is ${totalWithTip}");
                Console.Write("How many people will be paying this bill? ");
                int numberOfPayees = int.Parse(Console.ReadLine());
                if(numberOfPayees == 1)
                {
                    Console.WriteLine($"Your total bill is ${totalWithTip}.");
                }
                else
                {
                    Console.WriteLine($"Each person needs to pay ${totalWithTip / numberOfPayees}");
                }
                Console.WriteLine("\nPress any key to exit.");
                Console.ReadKey();


            }



            ////1. Pythagoras' Theorum
            //Console.WriteLine("Please enter the dimensions of your triangle.");
            //Console.Write("Please enter the length of Side A: ");
            //double sideA = double.Parse(Console.ReadLine());
            //Console.Write("Please enter the length of Side B: ");
            //double sideB = double.Parse(Console.ReadLine());
            //double hypotenuse = Math.Sqrt(sideA * sideA + sideB * sideB);
            //Console.WriteLine($"The length of the hypotenuse is: {hypotenuse}.");
            //Console.ReadKey();
            //// double variables are more efficient, decimal variables are more precise (use decimals for money)
            //// if writing a fraction as a decimal variable, end it with "m" ex. decimal price = 10.99m


            //###### VARIABLES AND FUNCTION CALLS ######

            ////Core Task 2.1.2
            //Console.Write("Enter your first name: ");
            //var fName = Console.ReadLine();
            //Console.Write("Enter your last name: ");
            //var lName = Console.ReadLine();
            //Console.WriteLine($"Welcome {fName} {lName}!");

            ////Core Task 2.2
            //Console.WriteLine("\nHow old are you?");
            //Console.Write("Enter your age: ");
            //var userAgeString = Console.ReadLine();
            //bool isUserAgeInt = Int32.TryParse(userAgeString, out int userAge);
            //if (!isUserAgeInt)
            //{
            //    Console.WriteLine("Please enter a valid number. Example: 32");
            //}
            //else
            //{
            //    Console.WriteLine($"Wow, {userAge}! That means in next year you'll be {userAge + 1}!");
            //}
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();

            ////Core Task 2.1.1
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine(); // this is called "initializing a variable"
            //Console.WriteLine("Hello " + name);
        }
    }
}
