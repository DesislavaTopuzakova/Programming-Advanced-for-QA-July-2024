//запис: key (дума) -> value (списък със синоними)

Dictionary<string, List<string>> wordSynonyms = new Dictionary<string, List<string>>();

int countWords = int.Parse(Console.ReadLine()); //брой на буквите


for (int count = 1; count <= countWords; count++)
{
    string word = Console.ReadLine(); //стойността на думата
    string synonym = Console.ReadLine(); //синоним на думата

    if (!wordSynonyms.ContainsKey(word))
    {
        //за първи път срещаме думата
        wordSynonyms.Add(word, new List<string>());
        wordSynonyms[word].Add(synonym);
    }
    else
    {
        //вече сме срещали думата -> добавяме новия синоним към текущия списък със синоними
        wordSynonyms[word].Add(synonym);
    }
}

//запис: key (дума) -> value (списък със синонимите)
foreach (KeyValuePair<string, List<string>> entry in wordSynonyms)
{
    //entry
    //entry.Key -> дума (string)
    //entry.Value -> списък със синоними (List<string>)
    Console.WriteLine(entry.Key + " - " + string.Join(", ", entry.Value));
}