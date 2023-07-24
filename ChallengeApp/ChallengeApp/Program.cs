using ChallengeApp;

var employee = new Employee("Paweł", "Kuczek");
employee.AddGrade("Paweł");
employee.AddGrade(5);
employee.AddGrade(2.55);
employee.AddGrade('r');
var statistics = employee.GetStatistics();
Console.WriteLine($"Statystyki pracownika: {employee.Name} {employee.Surname}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Sum of grades: {statistics.SumOfGrades:N2}");

