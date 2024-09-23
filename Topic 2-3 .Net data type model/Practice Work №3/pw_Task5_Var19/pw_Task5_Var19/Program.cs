// Завдання 5: Вивести на консоль власні анкетні дані
using System;

class Program
{
    static void Main()
    {
        string lastName = "Прізвище";
        string firstName = "Ім'я";
        int age = 17; 
        string group = "Група";
        int course = 3;

        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Вік: {age}");
        Console.WriteLine($"Група: {group}");
        Console.WriteLine($"Курс: {course}");
    }
}

