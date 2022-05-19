﻿using System;
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

        public void PrimeFactors(int number)
        {
            Console.WriteLine("Prime Factors are ----- ");
            while(number%2 == 0)
            {
                Console.Write("2 ");
                number = number/2;
            }
            for(int i = 3; i <= Math.Sqrt(number);i+=2)
            {
                while(number%i == 0)
                {
                    Console.Write(i + " ");
                    number = number/i;
                }
                
            }
            if (number > 2)
            {
                Console.Write(number + " ");
            }
        }
    }
}
