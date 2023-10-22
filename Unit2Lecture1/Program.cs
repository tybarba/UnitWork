namespace Unit2Lecture1
{
    internal class Program
    {
        static void Main()
        {
            //this lecture was about conditional statements
            Console.WriteLine("Enter your name");
            string? name = Console.ReadLine();
            if (name == "")
            {
                Console.WriteLine("You didn't enter a name");
            }
            else
            {
                Console.WriteLine("Hello" + name);
            }
        }
    }
}