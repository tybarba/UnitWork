using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7Lab
{
    public class DiceRoller
    {
        Random random = new Random();
        public DiceRoller()
        {
                
        }
        private int GetDiceTotal(int numDice)
        {
            int result = 0;
            for (int i = 0; i < numDice; i++)
            {
                int thisRoll = random.Next(1, 7);
                result += thisRoll;
                //Console.WriteLine($"Die {i} rolled {thisRoll}");
            }
            return result;
        }
        public void RollDice(int numDice)
        {
            int result = GetDiceTotal(numDice);
            Console.WriteLine($"You rolled {numDice} dice and got {result}.");
        }

        public void PlayGame()
        {
            bool keepPlaying = true;
            while (keepPlaying){
                Console.Write("How many dice do you want to roll? ");
                int numDiceToRoll = int.Parse(Console.ReadLine());
                RollDice(numDiceToRoll);
                Console.WriteLine("Keep rolling dice? y/n");
                string userResponse = Console.ReadLine();
                if(userResponse == "n")
                {
                    keepPlaying = false;
                }
            }
        }

        public void PlaySnakeEyes()
        {
            int thisRoll;
            do
            {
                thisRoll = GetDiceTotal(2);
                if (thisRoll != 2)
                {
                    Console.WriteLine(thisRoll);
                }
            }
            while (thisRoll != 2);
            Console.WriteLine("Snake eyes!");
        }
    }
}
