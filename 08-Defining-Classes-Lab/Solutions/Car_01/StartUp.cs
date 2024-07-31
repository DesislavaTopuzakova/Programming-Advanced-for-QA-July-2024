namespace CarManufacturer
{
    public class StartUp
    {
        //основната логика на задачата
        //при стартиране на клас StartUp -> изпълнява Main
        //Main метода си пишем, кода, който искаме да се изпълни при стартиране
        public static void Main (string [] args)
        {
            Car car = new Car();
            //празен обект: car
            //Маке = null
            //Model = null
            //Year = 0

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;

            Console.WriteLine("Make: " + car.Make);
            Console.WriteLine("Model: " + car.Model);
            Console.WriteLine("Year: " + car.Year);
        }
    }
}

