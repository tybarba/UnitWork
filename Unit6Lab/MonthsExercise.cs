using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit6Lab
{
    internal class MonthsExercise
    {
        string[] monthNames =
        { "January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December" };

        public MonthsExercise()
        {
                
        }

        public void ChooseMonth()
        {
            Console.WriteLine("What month were you born in?\n");
            for (int i=0; i<monthNames.Length; i++)
            {
                Console.WriteLine($"{i+1} - {monthNames[i]}");
            }
            Console.Write("Your birth month: ");
            int userResponse = int.Parse(Console.ReadLine());
            Console.WriteLine($"I see! You were born in {monthNames[userResponse-1]}!");
        }
    }
}
