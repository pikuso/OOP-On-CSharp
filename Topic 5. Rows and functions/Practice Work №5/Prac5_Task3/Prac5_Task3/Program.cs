using System;

namespace StepInApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = { 1, 8, 4 };

            long s;

            StepIn(out s, 2, digits);

            Console.WriteLine($"Sum of squares of numbers: {s}");
        }

        // Метод StepIn 
        public static void StepIn(out long r, int a, params int[] b)
        {
            r = 0;

            foreach (int i in b)
            {
                r += (long)Math.Pow(i, a);
            }
        }
    }
}
