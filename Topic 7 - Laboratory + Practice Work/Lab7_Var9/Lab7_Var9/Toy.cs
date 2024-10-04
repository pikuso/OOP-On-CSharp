public class Toy : Goods
{
    private string type;

    public Toy(string name, double price, string type) : base(name, price)
    {
        this.type = type;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Type: {type}");
    }
}
