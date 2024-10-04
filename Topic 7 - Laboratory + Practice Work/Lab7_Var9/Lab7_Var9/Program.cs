using System;

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        Goods toy = new Toy("Teddy Bear", 29.99, "Stuffed Animal");
        Goods product = new Product("Bread", 1.50, "2024-12-01");
        Goods dairyProduct = new DairyProduct("Milk", 0.99, "2024-10-01", 3.5);

        inventory.AddGoods(toy);
        inventory.AddGoods(product);
        inventory.AddGoods(dairyProduct);

        inventory.ViewGoods();

        Console.ReadLine();
    }
}
