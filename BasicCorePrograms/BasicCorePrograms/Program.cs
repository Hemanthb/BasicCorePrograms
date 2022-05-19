// See https://aka.ms/new-console-template for more information
BasicCorePrograms.BasicCore basicCore = new BasicCorePrograms.BasicCore();
Console.WriteLine("Enter a number below 31 to get table of 2 to power number");
int n = Convert.ToInt32(Console.ReadLine());
basicCore.DisplayPowerOfTwo(n);
Console.WriteLine("Enter a number to get Harmonic value");
int number = Convert.ToInt32(Console.ReadLine());
basicCore.HarmonicValue(number);
