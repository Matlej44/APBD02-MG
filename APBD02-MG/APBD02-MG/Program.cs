// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.WriteLine("Press any key to exit...");

System.Console.ReadKey();

Console.WriteLine("Goodbye!");

Console.WriteLine("w");

Console.WriteLine("Main");

Console.ReadLine();

//Console.Write("D");
 
Console.WriteLine("Rebase");
int[] a = { 1, 2, 3 };
CalculateAvarage(a);
return 0;
//Calculate Avarage function
static double CalculateAvarage(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    
    return (double)sum / numbers.Length;
}
static int CalculateMax(int[] numbers)
{
    return numbers.Max();
}

static int CalculateMin(int[] numbers)
{
    int min = numbers.Min();
    return 0;
}