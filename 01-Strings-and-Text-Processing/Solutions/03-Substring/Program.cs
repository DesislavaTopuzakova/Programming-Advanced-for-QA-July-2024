//1. входни данни
string wordToRemove = Console.ReadLine(); //дума, която ще премахвам
string text = Console.ReadLine(); //текст, от който ще премахвам дадена дума


//повтаряме: премахваме дадения текст
//стоп: в текста(text) вече нямам дадената дума(wordToRemove)
//продължавам: в текста (text) имам дадената дума (wordToRemove)


//IndexOf
//-1 -> ако не намираме думата
//позиция -> ако намираме думата

//докато намираме думата в текста
while (text.IndexOf(wordToRemove) != -1)
{
    //думата wordToRemove я има в text
    //wordToRemove = "ice"
    //text = "kicegiciceeb"
    int positionWord = text.IndexOf(wordToRemove);
    text = text.Remove(positionWord, wordToRemove.Length);
}

Console.WriteLine(text);


