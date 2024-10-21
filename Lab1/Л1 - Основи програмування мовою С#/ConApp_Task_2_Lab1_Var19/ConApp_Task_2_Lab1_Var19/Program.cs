using System;

namespace SimpleSumOfDigitsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a four digit number: ");
            string input = Console.ReadLine();

            if (input.Length == 4 && int.TryParse(input, out int number))
            {
                int firstSum = int.Parse(input[0].ToString()) + int.Parse(input[1].ToString());

                int lastSum = int.Parse(input[2].ToString()) + int.Parse(input[3].ToString());

                if (firstSum == lastSum)
                {
                    Console.WriteLine("True: Equal amounts");
                }
                else
                {
                    Console.WriteLine("False: No equal amounts");
                }
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
            }

            Console.ReadKey();
        }
    }
}

//чи дорівнює сума двох перших цифр даного чотиризначного числа сумі двох його останніх цифр.
