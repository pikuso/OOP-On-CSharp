using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerHierarch
{
    public class Server : Computer
    {
        public int NumberOfProcessors { get; set; }

        public Server(string model, int ram, int numberOfProcessors) : base(model, ram)
        {
            NumberOfProcessors = numberOfProcessors;
        }

        public override void ShowSpecs()
        {
            Console.WriteLine($"Server Model: {Model}, RAM: {RAM} GB, Processors: {NumberOfProcessors}");
        }

        public override void PerformTask()
        {
            Console.WriteLine("Server is handling multiple client requests.");
        }

        public void UpdateSpecs(string model)
        {
            Model = model;
            Console.WriteLine($"Server model updated to: {Model}");
        }

        public void UpdateSpecs(string model, int numberOfProcessors)
        {
            Model = model;
            NumberOfProcessors = numberOfProcessors;
            Console.WriteLine($"Server model updated to: {Model}, Number of processors updated to: {NumberOfProcessors}");
        }
    }
}
