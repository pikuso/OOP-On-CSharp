//Завдання 3: Оператор циклу
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть натуральне число n:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть дійсне число x:");
        double x = Convert.ToDouble(Console.ReadLine());

        double sum = 0;

        for (int i = 0; i <= n; i++)
        {
            sum += Math.Pow(x, i) / Factorial(i);
        }

        Console.WriteLine($"Значення суми S: {sum}");
    }
    static double Factorial(int num)
    {
        double result = 1;
        for (int i = 2; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }
}
