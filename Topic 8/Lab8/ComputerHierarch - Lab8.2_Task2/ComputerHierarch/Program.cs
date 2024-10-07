using ComputerHierarch;

class Program
{
    static void Main(string[] args)
    {
        Server server = new Server("Dell PowerEdge", 64, 8);
        server.ShowSpecs();       
        server.PerformTask();      
        server.UpdateSpecs("HP ProLiant");    
        server.ShowSpecs();

        server.UpdateSpecs("HP ProLiant", 16);  
        server.ShowSpecs();

        Workstation workstation = new Workstation("HP ZBook", 32, true);
        workstation.ShowSpecs();    
        workstation.PerformTask(); 

        Console.ReadLine();        
    }
}
