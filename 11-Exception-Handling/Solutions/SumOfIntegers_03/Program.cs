string input = Console.ReadLine(); //"2147483649 2 3.4 5 invalid 24 -4"
string[] elements = input.Split(); //["2147483649", "2", "3.4", "5", "invalid", "24", "-4"]

int sum = 0; //сумата от всички въведени цели числа

foreach(string element in elements)
{
    //1. проверка дали е число -> element = "invalid"
    //2. проверка дали може да се съхрани в int променлива -> element = "6872364872637846823"

    try
    {
        int number = int.Parse(element);
        sum += number;
    }
    catch (FormatException)
    {
        //element не е цяло число
        Console.WriteLine($"The element '{element}' is in wrong format!");
    }
    catch (OverflowException)
    {
        //element е число, което не може да се съхрани в int променлива
        Console.WriteLine($"The element '{element}' is out of range!");
    }
    finally
    {
        Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
    }
}

//обходили всички елементи в масива
Console.WriteLine($"The total sum of all integers is: {sum}");
