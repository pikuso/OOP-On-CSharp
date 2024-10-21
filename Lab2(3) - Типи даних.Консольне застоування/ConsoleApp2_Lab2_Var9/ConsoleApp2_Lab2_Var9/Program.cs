using System;

namespace TriangleCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter side a:");
            double a = GetValidSide();

            Write("Enter side b:");
            double b = GetValidSide();

            Write("Enter angle of C in degrees:");
            double C = GetValidAngle();

            double c = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(C * Math.PI / 180));

            double s = 0.5 * a * b * Math.Sin(C * Math.PI / 180);

            Write($"Side length c: {c:F2}");
            Write($"Area of ​​the triangle: {s:F2}");

            Console.ReadLine();
        }
        static void Write(string message)
        {
            Console.WriteLine(message);
        }

        static double GetValidSide()
        {
            double side;
            while (!double.TryParse(Console.ReadLine(), out side) || side <= 0)
            {
                Write("Error! Please enter a valid positive number:");
            }
            return side;
        }

        static double GetValidAngle()
        {
            double angle;
            while (!double.TryParse(Console.ReadLine(), out angle) || angle <= 0 || angle >= 180)
            {
                Write("Error! Enter the angle in degrees (from 0 to 180):");
            }
            return angle;
        }
    }
}
