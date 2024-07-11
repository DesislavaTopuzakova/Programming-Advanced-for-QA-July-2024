using System.Text.RegularExpressions;

string text = Console.ReadLine();
//текст, в който трябва да намерим всички валидни номера

Regex regexPhoneNumber = new Regex(@"[+]359([ -])2\1[0-9]{3}\1[0-9]{4}");
//шаблон, на който трябва да отговаря тел. номер


MatchCollection allValidPhoneNumbers = regexPhoneNumber.Matches(text);

for (int position = 0; position <= allValidPhoneNumbers.Count - 1; position++)
{
    if (position == allValidPhoneNumbers.Count - 1)
    {
        //последния телефонен номер
        Console.Write(allValidPhoneNumbers[position].Value);
    }
    else
    {
        Console.Write(allValidPhoneNumbers[position].Value + ", ");
    }  
}