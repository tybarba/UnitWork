using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit6Lab
{
    public class ElectricLift
    {
        string[] floorNames = new string[5];

        public ElectricLift()
        {
            floorNames[0] = "Ground";
            floorNames[1] = "First";
            floorNames[2] = "Second";
            floorNames[3] = "Third";
            floorNames[4] = "Fourth";
        }

        public void RideLift()
        {
            Console.WriteLine("The available floors are: ");
            for (int i = 0; i < floorNames.Length; ++i)
            {
                Console.WriteLine(i + " - " + floorNames[i]);
            }
            Console.Write("Choose a floor number: ");
            int userResponse = int.Parse(Console.ReadLine());
            Console.WriteLine($"You have chosen the {floorNames[userResponse]} Floor.");
        }
    }
}
