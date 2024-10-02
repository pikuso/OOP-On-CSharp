class Task5
{
    public static void CalculateWithLoop()
    {
        Console.WriteLine("Завдання 5: Обчислення з циклом.");

        while (true)
        {
            // Введення значень змінних
            Console.Write("Введіть значення x (або 0 для виходу): ");
            double x = double.Parse(Console.ReadLine());

            // Вихід з циклу, якщо введено x = 0
            if (x == 0)
            {
                break;
            }

            Console.Write("Введіть значення y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введіть значення z: ");
            double z = double.Parse(Console.ReadLine());

            // Перевірка на коректність
            double denominator = Math.Sqrt(z * z + 12 - x * x);
            if (denominator == 0 || double.IsNaN(denominator))
            {
                Console.WriteLine("Неможливо обчислити значення: некоректні вхідні дані.");
            }
            else
            {
                // Обчислення
                double a = Math.Cos(y + z) / denominator;
                Console.WriteLine($"Результат: a = {a}");
            }
        }
    }
}
