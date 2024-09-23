//Завдання 1 Варіант 19: Реалізувати функцію піднесення до кубу різниці двох цілих чисел
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first integer:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second integer:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int result = CubeDifference(num1, num2);
        Console.WriteLine($"The cube of the difference between {num1} and {num2} is: {result}");
    }

    static int CubeDifference(int a, int b)
    {
        int difference = a - b;
        return difference * difference * difference;
    }
}
