using System;

class Program
{
    static void Main()
    {
        // A) x > y && x == 2, где x = 2, y = 4
        int x = 2;
        int y = 4;
        bool resultA = (x > y) && (x == 2);
        Console.WriteLine($"A) x > y && x == 2, where x = 2, y = 4: {resultA}");

        // Б) x == y && x != 2, где x = 12, y = 5
        x = 12;
        y = 5;
        bool resultB = (x == y) && (x != 2);
        Console.WriteLine($"Б) x == y && x != 2, where x = 12, y = 5: {resultB}");

        // В) k > v || k <= 2, где k = 2, v = 4
        int k = 2;
        int v = 4;
        bool resultC = (k > v) || (k <= 2);
        Console.WriteLine($"В) k > v || k <= 2, where k = 2, v = 4: {resultC}");
    }
}
