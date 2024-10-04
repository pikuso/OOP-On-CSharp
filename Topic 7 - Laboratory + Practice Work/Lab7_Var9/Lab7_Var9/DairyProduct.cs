public class DairyProduct : Product
{
    private double fatContent;

    public DairyProduct(string name, double price, string expirationDate, double fatContent)
        : base(name, price, expirationDate)
    {
        this.fatContent = fatContent;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Fat Content: {fatContent}%");
    }
}
