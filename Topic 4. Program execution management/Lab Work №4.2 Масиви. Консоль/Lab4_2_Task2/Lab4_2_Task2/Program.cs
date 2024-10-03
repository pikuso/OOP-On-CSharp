using System;
//var 19
class Program
{
    static void Main()
    {
        Console.Write("Введіть значення n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введіть значення k: ");
        int k = int.Parse(Console.ReadLine());

        int size = n; 
        double[] Z = new double[size];

        for (int i = 0; i < size; i++)
        {
            Z[i] = n * f(k) + Math.Sin(k);
        }

        Console.WriteLine("Масив Z:");
        foreach (var value in Z)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

        double product = 1;
        bool found = false;

        foreach (var value in Z)
        {
            if (Math.Abs(value) > 5)
            {
                product *= value;
                found = true;
            }
        }

        if (found)
        {
            Console.WriteLine($"Добуток елементів, для яких |Zi| > 5: {product}");
        }
        else
        {
            Console.WriteLine("Немає елементів, які задовольняють умову |Zi| > 5.");
        }
    }

    static int f(int k)
    {
      
        return k * k;
    }
}
