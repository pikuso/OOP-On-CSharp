//Завдання 1: Піднесення до кубу різниці двох цілих чисел
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first integer:");
        if (!int.TryParse(Console.ReadLine(), out int num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        Console.WriteLine("Enter the second integer:");
        if (!int.TryParse(Console.ReadLine(), out int num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        int result = CubeDifference(num1, num2);
        Console.WriteLine($"The cube of the difference between {num1} and {num2} is: {result}");
    }

    static int CubeDifference(int a, int b)
    {
        int difference = a - b;
        return difference * difference * difference; 
    }
}
