using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerHierarch
{
    public class Workstation : Computer
    {
        public bool IsGraphicsWorkstation { get; set; }

        public Workstation(string model, int ram, bool isGraphicsWorkstation) : base(model, ram)
        {
            IsGraphicsWorkstation = isGraphicsWorkstation;
        }

        public override void ShowSpecs()
        {
            string type = IsGraphicsWorkstation ? "Graphics Workstation" : "Standard Workstation";
            Console.WriteLine($"Workstation Model: {Model}, RAM: {RAM} GB, Type: {type}");
        }

        public override void PerformTask()
        {
            Console.WriteLine("Workstation is running specialized software.");
        }
    }

}
