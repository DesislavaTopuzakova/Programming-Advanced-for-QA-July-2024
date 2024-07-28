//компания -> списък със служители
Dictionary<string, List<string>> companyEmployees = new Dictionary<string, List<string>>();


//входни данни
string input = Console.ReadLine();

while (input != "End")
{
    //input = "SoftUni -> AA12345"
    //input.Split(" -> ") = ["SoftUni", "AA12345"]
    string company = input.Split(" -> ")[0];
    string employee = input.Split(" -> ")[1];

    //проверка дали сме записали тази компания
    if (!companyEmployees.ContainsKey(company))
    {
        companyEmployees.Add(company, new List<string>());
    }

    //имаме записана компанията и срещу нея списък със служители
    List<string> employeesList = companyEmployees[company];

    if (!employeesList.Contains(employee))
    {
        employeesList.Add(employee);
    }


    input = Console.ReadLine();
}

foreach (KeyValuePair<string, List<string>> entry in companyEmployees)
{
 Console.WriteLine(entry.Key);
 entry.Value.ForEach(employee => Console.WriteLine("-- " + employee));
}
