// See https://aka.ms/new-console-template for more information
BasicCorePrograms.BasicCore basicCore = new BasicCorePrograms.BasicCore();
Console.WriteLine("Enter a number below 31 to get table of 2 to power number");
int n = Convert.ToInt32(Console.ReadLine());
basicCore.DisplayPowerOfTwo(n);
Console.WriteLine();
//calculates Harmonic value of n
Console.WriteLine("Enter a number to get Harmonic value");
int number = Convert.ToInt32(Console.ReadLine());
basicCore.HarmonicValue(number);
Console.WriteLine();
//calculates Prime factorial of a number
Console.WriteLine("Enter a number to get its prime factors");
int no = Convert.ToInt32(Console.ReadLine());
basicCore.PrimeFactors(no);
Console.WriteLine();
//calculates Quotient and Remainder
Console.WriteLine("Enter the divisor and dividend");
int divisor = Convert.ToInt32(Console.ReadLine());
int dividend = Convert.ToInt32(Console.ReadLine());
basicCore.ComputeQuotientRemainder(divisor,dividend);
Console.WriteLine();

basicCore.SwapNumbers(3, 2);
Console.WriteLine();

basicCore.CheckOddOrEven(55);
Console.WriteLine();

basicCore.CheckVowelsConsonants('T');