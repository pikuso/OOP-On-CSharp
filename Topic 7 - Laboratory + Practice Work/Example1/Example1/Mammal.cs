using System;

namespace Example1
{
    public class Mammal
    {
        private int age;
        private float weight;

        public Mammal()
        {
            age = 1;
            weight = 1;
        }

        public Mammal(int age, float weight)
        {
            this.age = age;
            this.weight = weight;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public void Speak()
        {
            Console.WriteLine("Mammal sound!\n");
        }

        public void Sleep()
        {
            Console.WriteLine("Mammal sleep!\n");
        }
    }
}
