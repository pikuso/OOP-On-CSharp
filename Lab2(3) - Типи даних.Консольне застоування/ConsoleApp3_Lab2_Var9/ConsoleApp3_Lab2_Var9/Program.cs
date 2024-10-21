using System;

namespace CheckDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Guess n:");
            string input = Console.ReadLine();

            bool containsThree = input.Contains("3");

            Write($"Does it contain a number '3': {containsThree}");
            Console.ReadKey();
        }

        static void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
