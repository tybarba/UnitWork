using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7Lab
{
    internal class RailStation
    {
        string[] stationCodes = { "LON", "NOT", "BHM", "MAN", "CDF", "EDB", "GLC", "LDS" };

        int[] scheduledHours = { 08, 09, 11, 13, 15, 18, 21, 23 };

        int[] scheduledMinutes = { 05, 45, 23, 01, 27, 05, 48, 55 };

        int[] lateMinutes = { 8, 0, 37, 6, 0, 0, 20, 9 };
        public RailStation()
        {
                
        }
        public void DisplayTimes()
        {
            Console.WriteLine("Destination   Scheduled   Expected");

            for (int i = 0; i < stationCodes.Length; ++i)
            {
                Console.Write("    ");
                Console.Write(stationCodes[i]);
                Console.Write("         ");
                WriteTime(scheduledHours[i], scheduledMinutes[i]);
                //Console.Write(scheduledHours[i] + ":" + scheduledMinutes[i]);
                Console.Write("      ");

                int expectedMinutes = scheduledMinutes[i] + lateMinutes[i];
                WriteTime(scheduledHours[i], expectedMinutes);
                //Console.Write(scheduledHours[i] + ":" + expectedMinutes);

                Console.WriteLine();
            }
        }

        private void WriteTime(int hour, int minutes)
        {
            Console.Write(string.Format("{0:00}:{1:00}", hour, minutes));
        }
    }
}
