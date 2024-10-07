using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerHierarch
{
    public abstract class Computer
    {
        public string Model { get; set; }
        public int RAM { get; set; }

        public Computer(string model, int ram)
        {
            Model = model;
            RAM = ram;
        }

        public abstract void ShowSpecs();

        public virtual void PerformTask()
        {
            Console.WriteLine("Computer is performing a task.");
        }

    }

}
