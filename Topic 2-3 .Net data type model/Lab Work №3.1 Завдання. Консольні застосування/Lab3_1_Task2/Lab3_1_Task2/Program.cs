using System;

class Task2
{
    public static void CalculateTriangle()
    {
        Console.WriteLine("Завдання 2: Трикутник двома сторонами та кутом між ними.");

        Console.Write("Введіть сторону a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введіть сторону b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введіть кут між ними (в градусах): ");
        double angleInDegrees = double.Parse(Console.ReadLine());

        double angleInRadians = angleInDegrees * (Math.PI / 180);

        double c = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(angleInRadians));

        Console.WriteLine($"Третя сторона трикутника: {c}");
    }
}
