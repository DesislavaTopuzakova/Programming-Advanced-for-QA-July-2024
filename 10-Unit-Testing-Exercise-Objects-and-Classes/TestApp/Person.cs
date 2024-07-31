using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp;

//описва всеки един човек
public class Person
{
    //характеристики: име, егн, възраст
    public string Name { get; set; } = null!;

    public string Id { get; set; } = null!;

    public int Age { get; set; }

    //действия -> описват чрез методи

    //1. AddPeople -> получава данни за хора (масив) -> всеки един човек го добавя в списък -> връща списъка с хората
    public List<Person> AddPeople(string[] people)
    {
        //string[] people =
        //{
            // "Desislava 9804286322 26",
            // "Ivan 87031456576 37,
            // "Peter 9709094536 27"
        //}
        List<Person> peopleList = new();
        foreach (string data in people)
        {
            //data = "Desislava 9804286322 26"
            string[] split = data.Split();
            //"Desislava 9804286322 26".Split() -> ["Desislava", "9804286322", "26"]

            string name = split[0]; //"Desislava"
            string id = split[1];   //"9804286322"
            int age = int.Parse(split[2]); //"26" -> parse -> 26

            Person? searchPerson = peopleList.FirstOrDefault(person => person.Id == id);

            //object searchPerson
            //name = "Desislava"
            //id = "9804286322"
            //age = 26

            //добавяме човека в списъка, само ако го няма
            if (searchPerson is null)
            {
                peopleList.Add(new()
                {
                    Name = name,
                    Id = id,
                    Age = age
                });
            }
            //ако го има вече в списъка -> актуализираме информацията за него
            else
            {
                searchPerson.Age = age;
                searchPerson.Name = name;
            }
        }

        //peopleList списък с обекти от клас Person
        return peopleList;
    }


    //2. GetByAgeAscending -> приема списък с хора -> връща списък с хората в нарастващ ред спрямо възрастта

    //приема списък с хора -> сортирани в нарастващ ред спрямо възрастта
    public string GetByAgeAscending(List<Person> people)
    {
        //people:
        //[0] -> {name: Alice, age: 35, ID: A0001}
        //[1] -> {name: Bob, age: 30, ID: B0002}

        StringBuilder sb = new();

        //сортираме списъка
        //people:
        //[0] -> {name: Bob, age: 30, ID: B0002}
        //[1] -> {name: Alice, age: 35, ID: A0001}

        foreach (Person person in people.OrderBy(person => person.Age))
        {
            sb.AppendLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
        }

        return sb.ToString().Trim();
    }
}
