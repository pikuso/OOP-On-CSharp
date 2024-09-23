// Завдання 4: Обчислити відстань між двома точками на площині
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the x-coordinate of the first point:");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the y-coordinate of the first point:");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the x-coordinate of the second point:");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the y-coordinate of the second point:");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine($"The distance between the two points is: {distance:F2}");
    }

    static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        // Обчислення відстані між двома точками за формулою: sqrt((x2 - x1)^2 + (y2 - y1)^2)
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}
