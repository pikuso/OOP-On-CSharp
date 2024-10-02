class Task6
{
    public static void CalculateWithRanges()
    {
        Console.WriteLine("Завдання 6: Діапазони значень.");

        while (true)
        {
            Console.Write("Введіть значення x (або 0 для виходу): ");
            double x = double.Parse(Console.ReadLine());

            if (x == 0) break;

            Console.Write("Введіть значення y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введіть значення z: ");
            double z = double.Parse(Console.ReadLine());

            double denominator = Math.Sqrt(z * z + 12 - x * x);
            if (denominator == 0 || double.IsNaN(denominator))
            {
                Console.WriteLine("Некоректні вхідні дані.");
            }
            else
            {
                double a = Math.Cos(y + z) / denominator;

                Console.WriteLine($"Результат обчислення: a = {a}");

                if (x < -10) Console.WriteLine("Число менше за -10");
                else if (x < -1) Console.WriteLine("Число менше за -1");
                else if (x < 1) Console.WriteLine("Число менше за 1");
                else if (x < 10) Console.WriteLine("Число менше за 10");
                else Console.WriteLine("Число більше за 10");

                if (a > 0) Console.WriteLine("Результат: додатнє");
                else if (a < 0) Console.WriteLine("Результат: від’ємне");
                else Console.WriteLine("Результат: нуль");
            }
        }
    }
}
