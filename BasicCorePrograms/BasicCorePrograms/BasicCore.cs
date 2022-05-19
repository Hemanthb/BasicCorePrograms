using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class BasicCore
    {
        public void DisplayPowerOfTwo(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("| 2 power "+i+"  ||  "+Math.Pow(2,i)+"  |");
            }
        }

        public void HarmonicValue(int n)
        {
            double sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 / (float)i;
            }
            Console.WriteLine("Harmonic value of {0} is {1} ",n,sum);
        }
    }
}
