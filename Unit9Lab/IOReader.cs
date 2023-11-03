using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit9Lab
{
    public class IOReader
    {
        public IOReader()
        {
                
        }

        public void Read()
        {
            StreamReader inputFile = new StreamReader("input.txt");

            for (int i = 0; i < 5; ++i)
            {
                string line = inputFile.ReadLine();
                Console.WriteLine(line);
            }

            inputFile.Close();
        }
    }
}
