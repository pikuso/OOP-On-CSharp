// Завдання 1: Оператор if
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть три дійсні числа:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double max = a, min = a, middle = a;

        // Визначаємо найбільше число
        if (b > max) max = b;
        if (c > max) max = c;

        // Визначаємо найменше число
        if (b < min) min = b;
        if (c < min) min = c;

        // Визначаємо середнє число
        middle = a + b + c - max - min;

        Console.WriteLine($"Найбільше число: {max}");
        Console.WriteLine($"Найменше число: {min}");
        Console.WriteLine($"Середнє число: {middle}");
    }
}
