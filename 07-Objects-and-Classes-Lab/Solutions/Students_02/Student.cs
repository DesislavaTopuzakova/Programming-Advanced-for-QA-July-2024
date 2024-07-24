//описвам всеки един студент
public class Student
{
   //част 1: характеристики -> описват чрез properties
   public string FirstName { get; set; }
   public string LastName { get; set; }
   public int Age { get; set; }
   public string HomeTown { get; set; }

    //default конструктор -> създава празен обект: new Student()

    //custom конструктор -> създаваме специфични обекти от класа
    public Student(string firstName, string lastName, int age, string homeTown)
    {
        //нов празен обект
        //FirstName = null
        //LastName = null
        //Age = 0
        //HomeTown = null

        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
    }

}


