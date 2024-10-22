using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the value of n (integer):");
        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
            return;
        }

        Console.WriteLine("Введіть значення k (ціле число):");
        if (!int.TryParse(Console.ReadLine(), out int k))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
            return;
        }
        int arraySize = 10;
        double[] Z = new double[arraySize];

        // Заповнення масиву
        for (int i = 0; i < arraySize; i++)
        {
            Z[i] = n * f(k) + Math.Sin(k);
            Console.WriteLine($"Z[{i}] = {Z[i]}");
            k++; 
        }

        // Обчислення добутку елементів, для яких |Z[i]| > 5
        double product = 1;
        bool hasValidElements = false; 

        foreach (var value in Z)
        {
            if (Math.Abs(value) > 5)
            {
                product *= value;
                hasValidElements = true; 
            }
        }

        if (hasValidElements)
        {
            Console.WriteLine($"The product of elements for which |Z[i]| > 5:: {product}");
        }
        else
        {
            Console.WriteLine("No element found for which |Z[i]| > 5.");
        }
    }
    // Функція f(k)
    static double f(int k)
    {
        return 13.4 * Math.Cos(Math.Abs(k)) * Math.Sin(Math.Pow(k, 2) - 2.25);
    }
}
