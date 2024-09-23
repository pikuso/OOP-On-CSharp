// Завдання 3: Обчислити вираз y = 12 * a^2 + 7 * a - 16
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an integer value for 'a':");
        int a = Convert.ToInt32(Console.ReadLine());

        int y = 12 * a * a + 7 * a - 16;
        Console.WriteLine($"The result of the expression y = 12 * a^2 + 7 * a - 16 for a = {a} is: {y}");
    }
}
