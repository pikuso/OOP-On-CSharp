using System;

//var 19
class Program
{
    static void Main()
    {

        int[] array = new int[10];
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 11);
        }

        Console.WriteLine("Згенерований масив:");
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int product = 1;
        int count = 0;
        int[] indices = new int[3];

        for (int i = 0; i < array.Length && count < 3; i++)
        {
            if (array[i] > 0)
            {
                product *= array[i];
                indices[count] = i; 
                count++;
            }
        }

        if (count == 3)
        {
            Console.WriteLine($"Добуток перших трьох додатних елементів: {product}");
            Console.WriteLine($"Індекси цих елементів: {indices[0]}, {indices[1]}, {indices[2]}");
        }
        else
        {
            Console.WriteLine("Менше трьох додатних елементів в масиві.");
        }
    }
}
