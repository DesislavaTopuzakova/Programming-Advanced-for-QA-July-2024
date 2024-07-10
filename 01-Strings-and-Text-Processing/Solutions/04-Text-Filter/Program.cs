//1. входни данни

string[] bannedWords = Console.ReadLine().Split(", ");
//"Linux, Windows".Split(", ") -> ["Linux", "Windows"]

string text = Console.ReadLine();

//2. обхождаме и заместваме всички забранени думи
foreach (string banWord in bannedWords)
{
    //banWord = "Linux"
    //replacement = "*****";
    string replacement = string.Empty; //текста, който ще замести забранената ми дума
    for (int star = 1; star <= banWord.Length; star++)
    {
        replacement += "*";
    }

    text = text.Replace(banWord, replacement);
}

//3. отпечатваме финалния текст
Console.WriteLine(text);



