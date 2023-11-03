using Unit7Lab;

namespace Unit8Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiceRoller dice = new DiceRoller();
            dice.PlaySnakeEyes();
            
            //PythagoreanTheorum pythagorean = new PythagoreanTheorum();
            //pythagorean.RunCalculator();

            //string example = repeatChar('$', 5);
            //Console.WriteLine(example);
        }

        //static string repeatChar(char c, int numChars)
        //{
        //    string repeatedChars = "";

        //    for (int i = 0; i < numChars; ++i)
        //    {
        //        repeatedChars += c;
        //    }

        //    return repeatedChars;
        //}

        //static void consoleReadWriteHypotenuseScalene()
        //{
        //    Console.Write("Enter the base length of the right-angled triangle: ");
        //    double baseLength = double.Parse(Console.ReadLine());
        //    Console.Write("Enter the side length of the right-angled triangle: ");
        //    double sideLength = double.Parse(Console.ReadLine());
        //    Console.WriteLine("The hypotenuse is: " + pythagorean.Calculate(baseLength, sideLength));
        //}

        //static void consoleReadWriteHypotenuseIsosceles()
        //{
        //    Console.Write("Enter the leg length of an isosceles right-angled triangle: ");
        //    double legLength = double.Parse(Console.ReadLine());
        //    Console.WriteLine("The hypotenuse is: " + pythagorean.Calculate(legLength, legLength));
        //}
    }
}