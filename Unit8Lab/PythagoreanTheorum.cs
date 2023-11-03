using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit8Lab
{
    public class PythagoreanTheorum
    {
        public PythagoreanTheorum()
        {
            
        }

        public void RunCalculator()
        {
            Console.WriteLine("Please enter the dimensions of your triangle.");
            Console.Write("Please enter the length of Side A: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Please enter the length of Side B: ");
            double sideB = double.Parse(Console.ReadLine());
            double hypotenuse = Calculate(sideA, sideB);
            Console.WriteLine($"The length of the hypotenuse is: {hypotenuse}.");
        }
        public double Calculate(double sideA, double sideB)
        {
            double hypotenuse = Math.Sqrt(sideA * sideA + sideB * sideB);
            return hypotenuse;
        }


    }
}
