//var19
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a value for x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double result = 13.4 * Math.Cos(Math.Abs(x)) * Math.Sin(Math.Pow(x, 2) - 2.25);

        Console.WriteLine($"The result of the expression is: {result}");
    }
}
