public class Goods
{
    protected string name;
    protected double price;

    public Goods(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Price: {price}");
    }
}
