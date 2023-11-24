namespace Unit12Lab
{
    //struct Person
    //{
    //    public string givenName;
    //    public string familyName;
    //    public string phoneNumber;
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToe game = new TicTacToe();
            game.SetUpGame();
            game.PlayGame();

            //Person alan = new Person("Alan", "Turing", "0123456789");

            //Console.WriteLine("Original details");
            //Console.WriteLine(alan.GivenName + ' ' + alan.FamilyName + " : " + alan.PhoneNumber);
            //Console.WriteLine();

            //updatePhoneNumber(alan);

            //Console.WriteLine();
            //Console.WriteLine("Updated details");
            //Console.WriteLine(alan.GivenName + ' ' + alan.FamilyName + " : " + alan.PhoneNumber);
        }

        static void updatePhoneNumber(Person personToUpdate)
        {
            Console.Write("Enter a new phone number: ");
            string newPhoneNumber = Console.ReadLine();

            // Code to check that the new phone number is valid could go here.

            personToUpdate.PhoneNumber = newPhoneNumber;
        }
    }
}