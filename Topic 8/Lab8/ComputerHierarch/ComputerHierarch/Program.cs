using ComputerHierarch;

class Program
{
    static void Main(string[] args)
    {
        Server server = new Server("Dell PowerEdge", 64, 8);
        server.ShowSpecs();
        server.PerformTask();

        Workstation workstation = new Workstation("HP ZBook", 32, true);
        workstation.ShowSpecs();
        workstation.PerformTask();

        Console.ReadLine(); 
    }
}
