//описваме всяка една кола
namespace CarManufacturer
{
    public class Car
    {
        //характеристики -> make, model, year -> описваме чрез properties или полета (fields)
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        //действия

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

