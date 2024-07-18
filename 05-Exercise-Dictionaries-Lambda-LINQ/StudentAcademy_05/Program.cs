//студент -> списък с оценки
Dictionary<string, List<double>> studentsGrade = new Dictionary<string, List<double>>();


//входни данни
int countStudents = int.Parse(Console.ReadLine());

for (int count = 1; count <= countStudents; count++)
{
    string studentName = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    //проверка имаме ли записан въведения студент
    if (!studentsGrade.ContainsKey(studentName))
    {
        //този студент го срещаме за първи път
        studentsGrade.Add(studentName, new List<double>());
        studentsGrade[studentName].Add(grade);
    }
    //имаме записан въведения студент
    else
    {
        studentsGrade[studentName].Add(grade);
    } 
}


foreach(KeyValuePair<string, List<double>> entry in studentsGrade)
{
    //всеки запис се съхранява в entry
    //entry.Key -> име на студента (string)
    //entry.Value -> списък с оценки (List<double>)
    double averageGrade = entry.Value.Average();
    if (averageGrade >= 4.50)
    {
        Console.WriteLine($"{entry.Key} -> {averageGrade:F2}");
    }
}
