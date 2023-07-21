using ChallengeApp;

var employee1 = new Employee("Piotr", "Kozioł", 56);
var employee2 = new Employee("Karol", "Krawczyk", 42);
var employee3 = new Employee("Grażyna", "Żarko", 39);

employee1.AddGrade(9);
employee1.AddGrade(7);
employee1.AddGrade(4);
employee1.AddGrade(5);
employee1.AddGrade(8);

employee2.AddGrade(10);
employee2.AddGrade(10);
employee2.AddGrade(10);
employee2.AddGrade(10);
employee2.AddGrade(10);

employee3.AddGrade(4);
employee3.AddGrade(7);
employee3.AddGrade(2);
employee3.AddGrade(9);
employee3.AddGrade(9);

Employee[] employees = { employee1, employee2, employee3 };
List<int> employeesResults = new List<int>();

foreach (Employee employee in employees)
{
    employeesResults.Add(employee.Result);
}

int bestEmployeeResult = employeesResults.Max();

foreach (Employee employee in employees)
{
    if (bestEmployeeResult == employee.Result)
    {
        Console.WriteLine($"Najlepszy wynik wśród pracowników: {bestEmployeeResult}. Należy do: {employee.Name} {employee.Surname}, lat {employee.Age}");
    }
}