//продукт -> ед. цена
Dictionary<string, double> productsPrice = new Dictionary<string, double>();

//продукт -> количество
Dictionary<string, int> productsQuantity = new Dictionary<string, int>();

//входни данни
string input = Console.ReadLine();


while (input != "buy")
{
    //input = "{name} {price} {quantity}"
    //input = "Beer 2.20 100".Split() -> ["Beer", "2.20", "100"]
    string[] productData = input.Split();
    string productName = productData[0];//"Beer"
    double price = double.Parse(productData[1]);// 2.20
    int quantity = int.Parse(productData[2]); // 100

    //проверка, че не сме срещали такъв продукт
    if (!productsPrice.ContainsKey(productName)
        && !productsQuantity.ContainsKey(productName))
    {
        productsPrice.Add(productName, price);
        productsQuantity.Add(productName, quantity);
    }
    //вече имаме такъв продукт
    else
    {
        //увеличаваме наличното количество
        productsQuantity[productName] += quantity;

        //заменяме текущата цена с новата въведена
        productsPrice[productName] = price;
    }

    input = Console.ReadLine();
}


foreach(KeyValuePair<string, double> entry in productsPrice)
{
    //entry
    //entry.Key = име на продукта
    //entry.Value = цена на продукта
    string productName = entry.Key;
    double price = entry.Value;
    int quantity = productsQuantity[productName];
    double totalPrice = price * quantity;
    Console.WriteLine($"{productName} -> {totalPrice:F2}");
}
