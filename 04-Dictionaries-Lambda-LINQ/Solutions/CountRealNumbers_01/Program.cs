//входни данни -> масив от дробни числа
double [] numbers = Console.ReadLine()      //"8 2 2 8 2"
                    .Split(" ")             //["8", "2", "2", "8", "2"]
                    .Select(double.Parse)   //[8, 2, 2, 8, 2]
                    .ToArray();

//key (число) -> value (бр. срещания)
SortedDictionary<double, int> countNumbers = new SortedDictionary<double, int>();


foreach(double number in numbers)
{
    //проверка дали това число вече е срещано
    if (countNumbers.ContainsKey(number))
    {
        //вече имам записано числото с някакъв брой срещания
        //увеличаваме броя на срещанията с 1
        countNumbers[number]++;
    }
    else
    {
        //не сме срещали моето число до момента -> срещаме за първи път
        countNumbers.Add(number, 1);
    }
}

//запис: key (число) -> value (бр. срещания)
foreach (KeyValuePair<double, int> entry in countNumbers)
{
    //всеки един се запис се съхранява в entry
    //entry.Key -> число
    //entry.Value -> бр. срещания
    Console.WriteLine(entry.Key + " -> " + entry.Value);
}
