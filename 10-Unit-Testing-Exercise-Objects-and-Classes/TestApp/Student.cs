using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp;

//описваме си всеки един студент
public class Student
{
    //характеристики: име, фамилия, възраст, роден град
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int Age { get; set; }

    public string Hometown { get; set; } = null!;

    //действия -> методи
    //получава масив от студенти -> връща само тези, на които родния град е wantedTown
    public string AddAndGetByCity(string[] students, string wantedTown)
    {
        //students -> масив от текстове -> текст = информация за моя студент
        //string [] students = { "John Doe 25 Sofia", "Jane Smith 22 Varna", "Alice Johnson 20 Sofia" };
        List<Student> studentList = new();

        foreach (string currentStudent in students)
        {
            string[] data = currentStudent.Split();
            string firstName = data[0];
            string lastName = data[1];
            int age = int.Parse(data[2]);
            string hometown = data[3];

            Student? student = studentList
                .FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
            
            if (student is null)
            {
                studentList.Add(new()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Hometown = hometown
                });
            }
            else
            {
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.Hometown = hometown;
            }
        }

        //studentList -> списък с обекти от клас Student

        StringBuilder sb = new();
        foreach (Student student in studentList.Where(s => s.Hometown == wantedTown))
        {
            sb.AppendLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
        }

        return sb.ToString().Trim();
    }
}
