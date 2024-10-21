using System;

namespace ElectricalResistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter the resistance of the resistor R1 (Оми):");
            double R1 = GetValidResistance();

            Write("Enter the resistance of the resistor R2 (Оми):");
            double R2 = GetValidResistance();

            Write("Enter the resistance of the resistor R3 (Оми):");
            double R3 = GetValidResistance();

            Write("Enter the resistance of the resistor R4 (Оми):");
            double R4 = GetValidResistance();

            Write("Select the connection type:\n1. Successively\n2. Parallel");
            int choice = GetValidChoice();

            double Rtotal;
            if (choice == 1) // послідовно
            {
                Rtotal = R1 + R2 + R3 + R4;
            }
            else // паралельно
            {
                Rtotal = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4);
            }

            Write($"Загальний опір: {Rtotal:F2} Оми");
            Console.ReadLine();
        }

        static void Write(string message)
        {
            Console.WriteLine(message);
        }

        static double GetValidResistance()
        {
            double resistance;
            while (!double.TryParse(Console.ReadLine(), out resistance) || resistance <= 0)
            {
                Write("Помилка! Введіть правильне додатне число:");
            }
            return resistance;
        }
        static int GetValidChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 2))
            {
                Write("Помилка! Введіть 1 для послідовного або 2 для паралельного з'єднання:");
            }
            return choice;
        }
    }
}
