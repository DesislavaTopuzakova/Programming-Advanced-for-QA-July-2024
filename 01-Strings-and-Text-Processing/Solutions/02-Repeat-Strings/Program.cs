//1. входни данни -> масив от текстове

string[] words = Console.ReadLine().Split(" ");
//"hi abc add".Split(" ") -> ["hi", "abc", "add"]

string result = ""; //краен текст

//2. обхождаме всеки един въведен текст
foreach(string word in words)
{
    //word = "abc"
    //length = 3

    //намираме дължината = бр. символи
    int length = word.Length;

    //повторим бр. пъти = дължина
    for (int count = 1; count <= length; count++)
    {
        result += word;
    }
}

//3. отпечатваме резултата
Console.WriteLine(result);