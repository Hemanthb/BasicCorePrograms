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

        public void ComputeQuotientRemainder(int divisor,int dividend)
        {
            float quotient = dividend / divisor;
            Console.WriteLine("Quotient is "+quotient);
            Console.WriteLine("Remainder is " + dividend % divisor);

        }

        public void SwapNumbers(int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Swapped numbers are {0} {1}", num1, num2);
        }

        public void CheckOddOrEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("{0} is Even", num);
            }
            else
            {
                Console.WriteLine("{0} is Odd", num);
            }
        }

        public void CheckVowelsConsonants(char alphabet)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            if(vowels.Contains(char.ToLower(alphabet)))
            {
                Console.WriteLine("Given alphabet {0} is a vowel",alphabet);
            }
            else
            {
                Console.WriteLine("Given alphabet {0} is a consonant", alphabet);
            }
        }

        public void Largest(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("{0} is the largest", num1);
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("{0} is the largest", num2);
            }
            else
            {
                Console.WriteLine("{0} is the largest", num3);
            }
        }
    }
}
