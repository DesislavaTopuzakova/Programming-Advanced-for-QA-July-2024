//описваме всяка една кола
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        //характеристики -> make, model, year -> описваме чрез properties или полета (fields)
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get;  set; }
        public double FuelQuantity { get; set; }   //количество налично гориво
        public double FuelConsumption { get; set; }  //разход на гориво за 1 км

        //действия -> описват се чрез методис
        public void Drive (double distance)
        {
          
            double needFuel = distance * FuelConsumption; //нужно гориво
            //1. не можем да преминем даденото разстояние = distance
            if (FuelQuantity <= needFuel)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            //2. ще успеем да преминем даденото разстояние: FuelQuantity >= needFuel
            else
            {
                FuelQuantity = FuelQuantity - needFuel;
                //FuelQuantity -= needFuel;
            }

        }

        public string WhoAmI()
        {
            StringBuilder sbInfoCar = new StringBuilder();

            sbInfoCar.Append("Make: " + Make).Append("\n");
            sbInfoCar.Append("Model: " + Model).Append("\n");
            sbInfoCar.Append("Year: " + Year).Append("\n");
            sbInfoCar.Append($"Fuel: {FuelQuantity:F2}");

            return sbInfoCar.ToString(); //текста, който имам конструиран в StringBuilder
        }

        //конструктор
        //1. default вграден конструктор -> празен обект от класа
        public Car()
        {
            //нов празен обект
            //Make = null
            //Model = null
            //Year = 0
        }

    }
}

