using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit5Lab
{
    public class BottleSong
    {
        public BottleSong()
        {

        }

        public void SingSong()
        {
            Console.Write("How many bottles do you want to start with? ");
            int startingNumBottles = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What color bottles do you want to use?");
            string bottleColor = Console.ReadLine();
            Console.WriteLine("\n");
            Console.Write("Do you want me to sing the song or write it down for you? ('sing' or 'write') ");
            string userAnswer = Console.ReadLine();
            if (userAnswer == "write")
            {
                WriteSongToText(startingNumBottles, bottleColor);
            }
            else
            {
                for (int i = startingNumBottles; i > 0; i--)
                {
                    WriteSong(i, bottleColor);
                }
            }
            Console.WriteLine("Done!");

        }

        public void WriteSong(int numBottles, string bottleColor)
        {
            {
                var bottle = (numBottles == 1 ? "bottle" : "bottles");
                var nextBottle = (numBottles - 1 == 1 ? "bottle" : "bottles");
                Console.WriteLine(
                    $"{numBottles} {bottleColor} {bottle} sitting on the wall," +
                    $"\r\n{numBottles} {bottleColor} {bottle} sitting on the wall," +
                    $"\r\nand if one {bottleColor} bottle should accidentally fall," +
                    $"\r\nthere will be {numBottles - 1} {bottleColor} {nextBottle} sitting on the wall."
                    );
            }
        }

        public void WriteSongToText(int numBottles, string bottleColor)
        {
            StreamWriter writer = new StreamWriter($"{numBottles}{bottleColor}bottles.txt");
            for (int i = numBottles; i > 0; i--)
            {
                var bottle = (i == 1 ? "bottle" : "bottles");
                var nextBottle = (i - 1 == 1 ? "bottle" : "bottles");
                writer.WriteLine(
                    $"{i} {bottleColor} {bottle} sitting on the wall," +
                    $"\r\n{i} {bottleColor} {bottle} sitting on the wall," +
                    $"\r\nand if one {bottleColor} bottle should accidentally fall," +
                    $"\r\nthere will be {i - 1} {bottleColor} {nextBottle} sitting on the wall."
                    );
            }
            writer.Close();
        }
    }
}
