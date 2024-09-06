using System;

class Program
{
    //Var 9
    static void Main()
    {
        Console.Write("Enter a four digit positive number: ");
        string input = Console.ReadLine();

        if (input.Length == 4 && int.TryParse(input, out int number) && number > 0)
        {
            int firstDigit = int.Parse(input[0].ToString());
            int secondDigit = int.Parse(input[1].ToString());
            int thirdDigit = int.Parse(input[2].ToString());
            int fourthDigit = int.Parse(input[3].ToString());

            int sumFirstTwo = firstDigit + secondDigit;
            int sumLastTwo = thirdDigit + fourthDigit;

            bool result = sumFirstTwo == sumLastTwo;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Error: Please enter a valid positive four-digit number.");
        }
    }
}
