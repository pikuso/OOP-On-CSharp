class Task4
{
    public static void CalculateExpression()
    {
        Console.WriteLine("Завдання 4: Обчислення виразу.");

        // Введення змінних x, y, z
        Console.Write("Введіть значення x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введіть значення y: ");
        double y = double.Parse(Console.ReadLine());
        Console.Write("Введіть значення z: ");
        double z = double.Parse(Console.ReadLine());

        // Перевірка на допустимість значень під коренем
        double denominator = Math.Sqrt(z * z + 12 - x * x);
        if (denominator == 0 || double.IsNaN(denominator))
        {
            Console.WriteLine("Неможливо обчислити значення: некоректні вхідні дані.");
        }
        else
        {
            // Обчислення виразу
            double a = Math.Cos(y + z) / denominator;
            Console.WriteLine($"Результат обчислення: a = {a}");
        }
    }
}
