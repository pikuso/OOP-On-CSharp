class Task3
{
    public static void CheckIfContainsThree()
    {
        Console.WriteLine("Завдання 3: Чи містить число цифру 3?");

        Console.Write("Введіть число: ");
        string number = Console.ReadLine();

        bool containsThree = number.Contains('3');

        Console.WriteLine($"Чи містить цифру 3? {containsThree}");
    }
}
