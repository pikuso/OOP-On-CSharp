class Task7
{
    public static void CalculateCallCost()
    {
        Console.WriteLine("Завдання 7: Вартість телефонних розмов.");

        Console.Write("Вартість розмови для першого міста (s1): ");
        double s1 = double.Parse(Console.ReadLine());
        Console.Write("Вартість розмови для другого міста (s2): ");
        double s2 = double.Parse(Console.ReadLine());
        Console.Write("Вартість розмови для третього міста (s3): ");
        double s3 = double.Parse(Console.ReadLine());

        Console.Write("Тривалість розмови для першого міста (t1): ");
        double t1 = double.Parse(Console.ReadLine());
        Console.Write("Тривалість розмови для другого міста (t2): ");
        double t2 = double.Parse(Console.ReadLine());
        Console.Write("Тривалість розмови для третього міста (t3): ");
        double t3 = double.Parse(Console.ReadLine());

        double cost1 = s1 * t1;
        double cost2 = s2 * t2;
        double cost3 = s3 * t3;
        double totalCost = cost1 + cost2 + cost3;

        Console.WriteLine($"Вартість розмови для першого міста: {cost1}");
        Console.WriteLine($"Вартість розмови для другого міста: {cost2}");
        Console.WriteLine($"Вартість розмови для третього міста: {cost3}");
        Console.WriteLine($"Загальна вартість всіх розмов: {totalCost}");
    }
}
