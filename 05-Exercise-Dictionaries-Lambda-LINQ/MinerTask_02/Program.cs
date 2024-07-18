//полезно изкопаемо -> общо количество
Dictionary<string, int> resourcesQuantity = new Dictionary<string, int>();

//входни данни -> "stop" или име на полезно изкопаемо

//повтаряме: въвеждаме имена на полезни изкопаеми + въвеждаме и неговата стойност
//цикъл: while
//спираме: входни данни == "stop"
//продължаваме: входни данни != "stop"

string resource = Console.ReadLine(); //име на полезно изкопаемо

while (resource != "stop")
{

    int quantity = int.Parse(Console.ReadLine()); //количество от полезното изкопаемо

    //полезно изкопаемо -> resource
    //количество -> quantity

    //проверка дали вече сме имали такова полезно изкопаемо
    if (resourcesQuantity.ContainsKey(resource))
    {
        //срещали сме вече такъв ресурс
        resourcesQuantity[resource] += quantity;
        //resourcesQuantity[resource] = resourcesQuantity[resource] + 15;
    }
    else
    {
        //не сме срещали такъв ресурс
        resourcesQuantity.Add(resource, quantity);
    }

    resource = Console.ReadLine();
}


//речник със записи (пол. изкопаемо -> количество)
foreach(KeyValuePair<string, int> entry in resourcesQuantity)
{
    //entry -> все един запис
    //entry.Key -> име на полезно изкопаемо
    //entry.Value -> количество
    Console.WriteLine(entry.Key + " -> " + entry.Value);
}