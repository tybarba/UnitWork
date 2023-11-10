using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit10Lab
{
    public class Class1
    {
        public Class1()
        {
                
        }
        public double mean(double[] array)
        {
            if(array.Length == 0)
            {
                throw new Exception("The length can't be zero");
            }
            double sum = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                sum += array[i];
            }

            return (sum / array.Length);
        }
    }
}
