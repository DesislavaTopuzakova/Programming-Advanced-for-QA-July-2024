namespace TestApp.Store;

public class Box
{
    
    //характеристики
    public long SerialNumber { get; set; }

    public Item Item { get; set; }

    public int ItemQuantity { get; set; }

    public decimal BoxPrice { get; set; }

    //конструктор
    public Box()
    {
        this.Item = new();
    }
}
