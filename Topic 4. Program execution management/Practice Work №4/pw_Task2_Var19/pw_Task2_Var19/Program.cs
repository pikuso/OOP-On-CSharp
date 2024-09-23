//Завдання 2: Оператор switch
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть логічний знак (<, >, <=, ==, !=):");
        string operation = Console.ReadLine();

        switch (operation)
        {
            case "<":
                Console.WriteLine("Менше");
                break;
            case ">":
                Console.WriteLine("Більше");
                break;
            case "<=":
                Console.WriteLine("Менше або дорівнює");
                break;
            case "==":
                Console.WriteLine("Дорівнює");
                break;
            case "!=":
                Console.WriteLine("Не дорівнює");
                break;
            default:
                Console.WriteLine("Невідома операція");
                break;
        }
    }
}
