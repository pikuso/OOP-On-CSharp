using System;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть сторону a:");
            if (!int.TryParse(Console.ReadLine(), out int a) || a <= 0)
            {
                Console.WriteLine("Некоректне значення для сторони a. Введіть додатнє ціле число.");
                return;
            }

            Console.WriteLine("Введiть сторону b:");
            if (!int.TryParse(Console.ReadLine(), out int b) || b <= 0)
            {
                Console.WriteLine("Некоректне значення для сторони b. Введіть додатнє ціле число.");
                return;
            }

            Console.WriteLine("Введiть сторону c:");
            if (!int.TryParse(Console.ReadLine(), out int c) || c <= 0)
            {
                Console.WriteLine("Некоректне значення для сторони c. Введіть додатнє ціле число.");
                return;
            }

            if (IsValidTriangle(a, b, c))
            {
                int p = (a + b + c) / 2;
                Console.WriteLine($"Півпериметр трикутника p = {p}");

                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"Площа трикутника s = {s}");
            }
            else
            {
                Console.WriteLine("Трикутник з такими сторонами не може існувати.");
            }

            Console.ReadLine();
        }

        static bool IsValidTriangle(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
