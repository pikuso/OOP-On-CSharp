using System;
using System.IO;

class Calculator
{
    static void Main(string[] args)
    {
        try
        {
            string inputFilePath = "input.txt";
            string outputFilePath = "output.txt";

            StreamReader reader = new StreamReader(inputFilePath);
            string expression = reader.ReadLine();
            reader.Close();

            double result = Calculate(expression);

            StreamWriter writer = new StreamWriter(outputFilePath);
            writer.WriteLine("Вираз: " + expression);
            writer.WriteLine("Результат: " + result);
            writer.Close();

            Console.WriteLine("The result was successfully saved to the file " + outputFilePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
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
                    case '+': return num1 + num2;
                    case '-': return num1 - num2;
                    case '*': return num1 * num2;
                    case '/':
                        if (num2 == 0) throw new DivideByZeroException("Division by zero is impossible.");
                        return num1 / num2;
                }
            }
        }
        throw new FormatException("Invalid expression format.");
    }
}
