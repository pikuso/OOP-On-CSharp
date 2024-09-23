//Завдання 2: Реалізувати функцію обчислення суми двох цілих чисел
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first integer:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second integer:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = Sum(num1, num2);
        Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }
}
