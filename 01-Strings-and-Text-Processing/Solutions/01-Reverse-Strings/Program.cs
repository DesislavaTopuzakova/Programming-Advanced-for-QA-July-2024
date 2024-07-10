//повтаряме: въвеждаме входни данни (текст) + обръщаме текста
//while цикъл -> не знаем колко точно пъти повтаряме
//стоп: входни данни == "end"
//продължаваме: входни данни != "end"

string input = Console.ReadLine();

while (input != "end")
{
    //input = "Ivan" -> reverse -> "navI"
    //обръщам текста
    string reversedText = ""; //обърнатия текст
    //всички символи от последния към първия
    for (int position = input.Length - 1; position >= 0; position--)
    {
        char currentSymbol = input[position];
        reversedText += currentSymbol;
        //reversedText = reversedText + currentSymbol;
    }

    //input = "Ivan" -> текст в прав ред
    //reversedText = "navI" -> текст в обърнат ред
    Console.WriteLine(input + " = " + reversedText);


    input = Console.ReadLine();
}

