using System.Text.RegularExpressions;

string text = Console.ReadLine();
//текст, в който ще търся валидните цели имена

Regex regexFullName = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
//шаблон, на който искам да ми отговаря текста


//прилагаме шаблона към текста
//-> получаваме съвкупност / колекция от всички текстове, които отговарят (мачват) на шаблона
MatchCollection allFullNames = regexFullName.Matches(text);

//oбхождаме всички валидни пълни имена
foreach (Match fullName in allFullNames)
{
    Console.Write(fullName.Value + " ");
}

