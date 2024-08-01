//входни данни
int number = int.Parse(Console.ReadLine());

try
{
    //искаме да намерим корен квадратен на въведеното число -> отпечатваме
    if (number < 0)
    {
        //грешка -> 1. вид -> Exception   2. съобщение -> "Invalid number."
        //throw -> хвърляме (предизвикваме) грешка / прекратим програмата и да дадем съобщение
        throw new Exception("Invalid number.");
    }
    
    double result = Math.Sqrt(number);
    Console.WriteLine(result);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Goodbye.");
}


