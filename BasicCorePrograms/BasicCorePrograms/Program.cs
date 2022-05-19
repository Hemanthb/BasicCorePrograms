// See https://aka.ms/new-console-template for more information
BasicCorePrograms.BasicCore basicCore = new BasicCorePrograms.BasicCore();
string select = "y";
while (select == "y")
{
    Console.WriteLine("Enter your choice to execute required method\n 1) .Display Table of 2 to the power n\n" +
    "2) .To get Harmonic value\n 3) .Prmie Factorial of a number\n 4) .Calculate Quotient & Remainder\n" +
    "5) .Swap 2 Numbers\n 6) .Check Odd Or Even\n 7) .Check Vowels & Consonants\n 8) .Largest of 3 Numbers");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch(choice)
    {
        case 1:
            Console.WriteLine("Enter a number below 31 to get table of 2 to power number");
            int n = Convert.ToInt32(Console.ReadLine());
            basicCore.DisplayPowerOfTwo(n);
            Console.WriteLine();
            break;
        case 2:
            //calculates Harmonic value of n
            Console.WriteLine("Enter a number to get Harmonic value");
            int number = Convert.ToInt32(Console.ReadLine());
            basicCore.HarmonicValue(number);
            Console.WriteLine();
            break;
        case 3:
            //calculates Prime factorial of a number
            Console.WriteLine("Enter a number to get its prime factors");
            int no = Convert.ToInt32(Console.ReadLine());
            basicCore.PrimeFactors(no);
            Console.WriteLine();
            break;
        case 4:
            // calculates Quotient and Remainder
            Console.WriteLine("Enter the divisor and dividend");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int dividend = Convert.ToInt32(Console.ReadLine());
            basicCore.ComputeQuotientRemainder(divisor, dividend);
            Console.WriteLine();
            break;
        case 5:
            Console.WriteLine("Enter 2 numbers to swap");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            basicCore.SwapNumbers(num1, num2);
            Console.WriteLine();
            break;
        case 6:
            Console.WriteLine("Enter a number to check Odd Or Even");
            int checkNum = Convert.ToInt32(Console.ReadLine());
            basicCore.CheckOddOrEven(checkNum);
            Console.WriteLine();
            break;
        case 7:
            Console.WriteLine("Enter a character to check Vowel or Consonant");
            char alphabet = Convert.ToChar(value:Console.ReadLine());
            basicCore.CheckVowelsConsonants(alphabet);
            Console.WriteLine();
            break;
        case 8:
            Console.WriteLine("Enter 3 numbers to check the largest among them");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            basicCore.Largest(number1,number2,number3);
            break;
        default:
            Console.WriteLine("Pls Enter a valid option from 1 -8");
            break;

    }
    Console.WriteLine("Enter 'y' to Continue executing another function or any other key to EXIT");
    select = Console.ReadLine();
}
