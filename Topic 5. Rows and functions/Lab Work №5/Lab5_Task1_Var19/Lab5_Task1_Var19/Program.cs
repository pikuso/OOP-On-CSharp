using System;
using System.Text;

namespace Lab5_Combined
{
    class Program
    {
        static void Main(string[] args)
        {
            FixWord();

            ReverseArray();

            Calculator();
        }

        static void FixWord()
        {
            string word = "maxe";
            char[] charArray = word.ToCharArray();
            charArray[0] = 'e';
            charArray[1] = 'x';
            charArray[2] = 'a';
            charArray[3] = 'm';

            string correctedWord = new string(charArray);
            Console.WriteLine("Corrected word: " + correctedWord);
        }

        static void ReverseArray()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array to reverse: " + string.Join(", ", numbers));
            Reverse(numbers);
            Console.WriteLine("Array after reverse: " + string.Join(", ", numbers));
        }

        static void Reverse(int[] array)
        {
            int temp;
            int length = array.Length;

            for (int i = 0; i < length / 2; i++)
            {
                temp = array[i];
                array[i] = array[length - i - 1];
                array[length - i - 1] = temp;
            }
        }

        static void Calculator()
        {
            string input;
            do
            {
                Console.WriteLine("Enter an expression (eg 23+5) or 'exit' to exit:");
                input = Console.ReadLine();

                if (input.ToLower() != "exit")
                {
                    try
                    {
                        double result = Calculate(input);
                        Console.WriteLine("Result: " + result);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            } while (input.ToLower() != "exit");
        }

        static double Calculate(string expression)
        {
            char[] operators = { '+', '-', '*', '/' };

            foreach (char op in operators)
            {
                string[] parts = expression.Split(op);
                if (parts.Length == 2)
                {
                    double num1 = Convert.ToDouble(parts[0]);
                    double num2 = Convert.ToDouble(parts[1]);

                    switch (op)
                    {
                        case '+':
                            return num1 + num2;
                        case '-':
                            return num1 - num2;
                        case '*':
                            return num1 * num2;
                        case '/':
                            if (num2 == 0)
                                throw new DivideByZeroException("Division by zero is impossible.");
                            return num1 / num2;
                    }
                }
            }

            throw new FormatException("Invalid expression format.");
        }
    }
}
