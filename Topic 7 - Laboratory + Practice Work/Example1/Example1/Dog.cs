using Example1;
using System;

namespace Example1
{
    public class Dog : Mammal
    {
        private BREED breed; 

        public Dog() : base() { } 

        public BREED Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        //методи
        public void WagTail()
        {
            Console.WriteLine("Tail wagging...\n");
        }

        public void BegForFood()
        {
            Console.WriteLine("Begging for food...\n");
        }

        new public void Speak()
        {
            Console.WriteLine("Woof!\n");
        }

        public void Move()
        {
            Console.WriteLine("Dog moves 5 steps...\n");
        }
    }
}
