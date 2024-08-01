int end = 100; //края на диапазона винаги е 100
int start = 1;
List<int> numbers = new List<int>(); //всички въведени числа, които отговарят на условие

//повтаряме: въвждане на цяло число
//стоп: имаме 10 числа в списъка (брой >= 10)
//продължаваме: нямаме все още 10 числа в списъка (брой < 10)
while (numbers.Count < 10)
{
    try
    {
        int number = ReadNumber(start, end);
        numbers.Add(number);
        start = number; //следващото число ще е в диапазон: (предишното прочетено, 100)
    }
    catch (FormatException fe)
    {
        Console.WriteLine(fe.Message);
    }
    catch (ArgumentException argEx)
    {
        Console.WriteLine(argEx.Message);
    }
}

//списък с валидни числа
Console.WriteLine(String.Join(", ", numbers));





//метод, който връща цяло число в дадения диапазон (start, end)
static int ReadNumber(int start, int end)
{
    //1. прочитаме входни данни (текст)
    string input = Console.ReadLine();

    //2. преобразуваме входните данни в цяло число
    try
    {
        int number = int.Parse(input);
        //въведено цяло число
        //3. проверка дали е в диапазона
        if (number <= start || number >= end)
        {
            throw new ArgumentException($"Your number is not in range {start} - {end}!"); //даваме сигнал за невалидно число
        }
        //валидно въведено число
        return number;
    }
    catch(FormatException)
    {
        throw new FormatException("Invalid Number!");
    }

}

