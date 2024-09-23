using System;

namespace HelloWorldApp
{
    public class HelloWorld
    {
        public void PrintMessage()
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld hello = new HelloWorld();
            hello.PrintMessage();

            Console.ReadKey(); // Ожидаем нажатие клавиши
        }
    }
}
