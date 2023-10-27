namespace Unit4Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReversalGame game = new ReversalGame();
            game.PlayGame();

            //GuessANumberGame game = new GuessANumberGame();
            //game.PlayGame();

            //SummationLoop summationLoop = new SummationLoop();
            //summationLoop.PerformSummationLoop();
   //         string userPassword = "";
   //         void SetUserPassword(string pw)
   //         {
   //             userPassword = pw;
   //         }
   //         string GetUserPassword()
   //         {
   //             return userPassword;
   //         }
   //         bool continueGoing = true;
   //         while (continueGoing)
   //         {
   //             Console.WriteLine("Enter your password:");
   //             string pw1 = Console.ReadLine();
   //             Console.WriteLine("Enter your password again:");
   //             string pw2 = Console.ReadLine();
   //             if (pw1 == pw2)
   //             {
   //                 Console.WriteLine("Password created successfully.");
   //                 SetUserPassword(pw1);
   //                 continueGoing = false;
   //             }
   //             else
   //             {
   //                 Console.WriteLine("Your passwords didn't match. Please start over.");
   //             }
   //         }
   //         continueGoing = true;
			//Console.Write("\nEnter your password to log-in: ");
			//while (continueGoing)
   //         {
   //             string enteredPassword = Console.ReadLine();
   //             if (enteredPassword == GetUserPassword())
   //             {
   //                 Console.Write("Log in successful.");
   //                 continueGoing = false;
   //             }
   //             else
   //             {
   //                 Console.Write("Password incorrect, try again: ");
   //             }
   //         }
        }
    }
}