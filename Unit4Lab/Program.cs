namespace Unit4Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueGoing = true;
            while (continueGoing)
            {
                Console.WriteLine("Enter your password:");
                string pw1 = Console.ReadLine();
                Console.WriteLine("Enter your password again:");
                string pw2 = Console.ReadLine();
                if (pw1 == pw2)
                {
                    Console.WriteLine("You have successfully created your password.");
                    continueGoing = false;
                }
                else
                {
                    Console.WriteLine("Your passwords didn't match. Please start over.");
                }
            }
        }
    }
}