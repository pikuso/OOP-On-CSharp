using Example1;
using System;

namespace Example1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal1 = new Mammal();

            mammal1.Sleep();
            mammal1.Speak();

            mammal1.Age = 10;
            mammal1.Weight = 5.8f;
            Print(mammal1);

            var mammal2 = new Mammal();
            Print(mammal2);

            var mammal3 = new Mammal(30, 1000f);
            Print(mammal3);

            Console.ReadKey();

            Dog dog = new Dog();
            dog.Sleep();
            dog.Move();
            dog.Speak();
            dog.BegForFood();

            dog.Age = 7;
            dog.Weight = 35;
            dog.Breed = BREED.LAB;

            PrintDog(dog); 
        }

        static void Print(Mammal mammal)
        {
            Console.WriteLine("---- Mammal properties prints ----- ");
            Console.WriteLine($"Mammal's weight is {mammal.Weight}");
            Console.WriteLine($"Mammal's age is {mammal.Age}");
        }

        static void PrintDog(Dog dog)
        {
            Console.WriteLine("---- Dog properties prints ----- ");
            Console.WriteLine($"Dog's weight is {dog.Weight}");
            Console.WriteLine($"Dog's age is {dog.Age}");
            Console.WriteLine($"Dog's breed is {dog.Breed}");
        }
    }
}
