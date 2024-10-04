using System.Collections.Generic;

public class Inventory
{
    private List<Goods> goodsList = new List<Goods>();

    public void AddGoods(Goods goods)
    {
        goodsList.Add(goods);
    }

    // Метод для просмотра списка товаров
    public void ViewGoods()
    {
        foreach (var goods in goodsList)
        {
            goods.DisplayInfo();
            Console.WriteLine();
        }
    }
}
