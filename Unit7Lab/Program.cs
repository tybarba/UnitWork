namespace Unit7Lab
{
    internal class Program
    {
        static int numDice = 2; // you need to preface global variables that you'll use in main with "static"
        static void Main(string[] args)
        {
            //DiceRoller dice = new DiceRoller();
            ////dice.PlayGame();
            //dice.RollDice(numDice);
            RailStation station = new RailStation();
            station.DisplayTimes();
        }
    }
}