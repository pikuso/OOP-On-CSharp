public class Product : Goods
{
    private string expirationDate;

    public Product(string name, double price, string expirationDate) : base(name, price)
    {
        this.expirationDate = expirationDate;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Expiration Date: {expirationDate}");
    }
}
