int number = int.Parse(Console.ReadLine());

try
{
    if (number < 0)
    {
        throw new ArgumentException("Negative Number!");
    }
    else if (number > 0)
    {
        throw new ArithmeticException("Positive Number!");
    }
    else
    {
        //number == 0
        Console.WriteLine("Number is zero");
    }
}
catch(ArgumentException argEx)
{
    Console.WriteLine(argEx.Message);
}
catch (ArithmeticException arEx)
{
    Console.WriteLine(arEx.Message);
}
