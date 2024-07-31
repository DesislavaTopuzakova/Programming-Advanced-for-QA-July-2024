using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Store;

//описваме всеки един магазин
public class Shop
{
    //нямаме характеристики

    //действие -> метод AddAndGetBoxes
    //получава масив с продукти
    public string AddAndGetBoxes(string[] products)
    {
        //string [] products = [
        // "3452 Carrot 3 2.30",
        // "6432 Pepper 4 1.23",
        // "1235 Tomato 2 3.50",
        //]
        List<Box> boxList = new(); //списък с кутии
        foreach (string product in products)
        {
            //product = "3452 Carrot 3 2.30"
            string[] data = product.Split();

            long serialNumber = long.Parse(data[0]);
            string name = data[1];
            int itemQty = int.Parse(data[2]);
            decimal price = decimal.Parse(data[3]);

            decimal boxPrice = price * itemQty;
            Item newItem = new()
            {
                Name = name,
                Price = price
            };

            Box newBox = new()
            {
                SerialNumber = serialNumber,
                Item = newItem,
                ItemQuantity = itemQty,
                BoxPrice = boxPrice
            };

            boxList.Add(newBox);
        }

        //списък с кутии, в които има по 1 вид продукт

        //сортирам кутиите спрямо цената низходящ ред
        StringBuilder sb = new(); //""
        foreach (Box box in boxList.OrderByDescending(box => box.BoxPrice))
        {
            sb.AppendLine(box.SerialNumber.ToString());
            sb.AppendLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
            sb.AppendLine($"-- ${box.BoxPrice:f2}");
        }

        return sb.ToString().Trim();
    }
}
