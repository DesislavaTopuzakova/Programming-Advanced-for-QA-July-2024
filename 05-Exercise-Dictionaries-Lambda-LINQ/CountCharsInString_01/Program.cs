//входни данни

string text = Console.ReadLine(); //"Desislava"

//символ -> бр. срещания
Dictionary<char, int> charsCount = new Dictionary<char, int>();


//обхождане на всеки един символ -> преобравяме го
foreach (char symbol in text)
{
    if (symbol == ' ')
    {
        continue; //пропусне кода след оператора, преминаваме към следващия символ
    }

    //символ, който е различен от интервал -> преобравяме го
    if (!charsCount.ContainsKey(symbol))
    {
        //не сме срещали символа до момента
        charsCount.Add(symbol, 1);
    }
    else
    {
        //вече сме срещали този символ -> увеличаваме броя на срещанията му
        charsCount[symbol]++;
    }

}


//запис: буква (key) -> бр. срещания (value)
foreach(KeyValuePair<char, int> entry in charsCount)
{
    //запис = entry
    //entry.Key -> символ
    //entry.Value -> бр. срещания
    Console.WriteLine(entry.Key + " -> " + entry.Value);
}

//Dictionary = съвкупност от KeyValuePairs
